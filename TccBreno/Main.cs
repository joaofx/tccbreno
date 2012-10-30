using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TccBreno
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Excel;

    public partial class Main : Form
    {
        private List<RadiacaoHora> radiacoesHora;
        private List<AreaDia> areasDias;

        public Main()
        {
            InitializeComponent();
        }

        private void OpenSpreadSheetClick(object sender, EventArgs e)
        {
	        var result = this.openFileDialog.ShowDialog();
	        
            if (result == DialogResult.OK)
	        {
		        this.spreadSheetFile.Text = this.openFileDialog.FileName;
	        }
        }

        private void ImportSpreadSheetClick(object sender, EventArgs e)
        {
            this.ImportSpreadSheet();
            this.CalculateAreaGroupedByDay();
        }

        private void CalculateAreaGroupedByDay()
        {
            this.status.Text = "Calculando áreas";

            this.areasDias = new List<AreaDia>();

            var result = this.radiacoesHora.OrderBy(x => x.Data).GroupBy(x => x.Data);

            foreach (var group in result)
            {
                double areaTotal = 0;
                RadiacaoHora lastHour = null;
                ////var areasHoras = new List<AreaHora>();

                foreach(var hour in group)
                {
                    double area = 0;
                    if (lastHour != null)
                    {
                        area = 0.5 * 1 * (hour.Radiacao + lastHour.Radiacao);
                    }
                    else
                    {
                        area = hour.Radiacao / 2;
                    }

                    areaTotal += area;

                    ////areasHoras.Add(new AreaHora { Radiacao = hour.Radiacao, Area = area });
                    
                    lastHour = hour;
                }

                var areaDia = new AreaDia
                {
                    Data = @group.Key, 
                    AreaTotal = areaTotal,
                    ////AreaHoras = areasHoras
                };

                this.areasDias.Add(areaDia);

                var item = new ListViewItem(@group.Key.ToString("dd/MM/yyyy"));

                item.SubItems.Add(String.Format("{0:N3}", areaTotal));
                this.areasList.Items.Add(item);
            }
        }

        private void ImportSpreadSheet()
        {
            this.status.Text = "Importando...";

            this.areasList.Items.Clear();

            var start = Convert.ToInt32(this.lineStart.Text);
            var end = Convert.ToInt32(this.endLine.Text);

            this.progress.Value = 1;
            this.progress.Minimum = 1;
            this.progress.Maximum = end;

            var excel = new Application();
            var wb = excel.Workbooks.Open(this.spreadSheetFile.Text, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

            var sheets = wb.Worksheets;
            var worksheet = (Excel.Worksheet)sheets.Item[1];

            Excel.Range range = worksheet.Range["A:C"];
            var items = (System.Array)range.Cells.Value;

            this.radiacoesHora = new List<RadiacaoHora>();

            for (int i = start; i <= end; i++)
            {
                try
                {
                    var radiacaoHora = new RadiacaoHora
                    {
                        Data = Convert.ToDateTime((items.GetValue(i, 1).ToString()).Substring(0, 10)),
                        ////Hora = Convert.ToInt32((double)items.GetValue(i, 2)),
                        Radiacao = (double)items.GetValue(i, 3)
                    };

                    if (radiacaoHora.Radiacao > 0)
                    {
                        this.radiacoesHora.Add(radiacaoHora);
                    }
                }
                catch (Exception)
                {
                }

                this.progress.Value++;
                this.status.Text = "Linha " + i + " processada";
                System.Windows.Forms.Application.DoEvents();
            }

            this.status.Text = "Importação completa";
        }

        ////private void AreasListSelectedIndexChanged(object sender, EventArgs e)
        ////{
        ////    if (this.areasList.SelectedItems.Count == 0)
        ////        return;

        ////    var selectedItem = this.areasList.SelectedItems[0];

        ////    if (selectedItem == null)
        ////        return;

        ////    var data = Convert.ToDateTime(selectedItem.Text);
        ////    var areaDia = this.areasDias.FirstOrDefault(x => x.Data == data);

        ////    if (areaDia == null)
        ////        return;

        ////    this.areaPorHoraList.Items.Clear();

        ////    foreach(var areaHora in areaDia.AreaHoras)
        ////    {
        ////        var item = new ListViewItem(areaHora.Hora.ToString());
        ////        item.SubItems.Add(String.Format("{0:N3}", areaHora.Radiacao));
        ////        item.SubItems.Add(String.Format("{0:N3}", areaHora.Area));
        ////        this.areaPorHoraList.Items.Add(item);
        ////    }
        ////}

        private void CalculateClassesClick(object sender, EventArgs e)
        {
            this.classes.Items.Clear();

            var classesBuilt = this.BuildClasses(
                Convert.ToDouble(maximo.Text),
                Convert.ToDouble(intervalo.Text),
                Convert.ToDouble(quantidade.Text));

            var totalFrequencia = 0;

            // acha frequencia
            foreach (var radiacao in this.areasDias)
            {
                var oneClass =
                    classesBuilt.FirstOrDefault(
                        x => radiacao.AreaTotal >= x.Inferior && radiacao.AreaTotal <= x.Superior);

                if (oneClass != null)
                {
                    oneClass.Frequencia++;
                    totalFrequencia++;
                }
            }

            // acha frequencia acumulada e porcentual
            var acumulador = 0;

            foreach (var oneClass in classesBuilt)
            {
                acumulador = acumulador + oneClass.Frequencia;
                oneClass.FrequenciaAcumulada = acumulador;
                oneClass.FrequenciaPorcentual = ((double) oneClass.Frequencia / totalFrequencia) * 100;
            }

            foreach (var @class in classesBuilt)
            {
                var item = new ListViewItem();
                
                item.Text = string.Format("{0:N4} - {1:N4}", @class.Superior, @class.Inferior);
                item.SubItems.Add(@class.Frequencia.ToString());
                item.SubItems.Add(@class.FrequenciaAcumulada.ToString());
                item.SubItems.Add(string.Format("{0:N2} %", @class.FrequenciaPorcentual));

                this.classes.Items.Add(item);
            }

            this.frequencias.Text = totalFrequencia.ToString();
        }

        private IEnumerable<OneClass> BuildClasses(double max, double amplitude, double quantidade)
        {
            var list = new List<OneClass>();
            var start = max;

            for (int i = 0; i < quantidade; i++)
            {
                var end = start - amplitude;
                list.Add(new OneClass { Superior = start, Inferior = end });
                start = end - 0.0001;
            }

            return list;
        }

        private void CopiarClipboardClick(object sender, EventArgs e)
        {
            var clipboard = new StringBuilder();

            foreach (var item in this.areasDias)
            {
                clipboard.AppendFormat(
                    "{0}\t{1}{2}",
                    item.Data.ToString("dd/MM/yyyy"),
                    item.AreaTotal,
                    Environment.NewLine);
            }

            Clipboard.SetText(clipboard.ToString());
        }
    }

    internal class OneClass
    {
        public double Superior
        {
            get;
            set;
        }

        public double Inferior
        {
            get;
            set;
        }

        public int Frequencia
        {
            get;
            set;
        }

        public int FrequenciaAcumulada
        {
            get;
            set;
        }

        public double FrequenciaPorcentual
        {
            get;
            set;
        }
    }

    ////internal class AreaHora
    ////{
    ////    public int Hora
    ////    {
    ////        get;
    ////        set;
    ////    }

    ////    public double Radiacao
    ////    {
    ////        get;
    ////        set;
    ////    }

    ////    public double Area
    ////    {
    ////        get;
    ////        set;
    ////    }
    ////}

    internal class AreaDia
    {
        public DateTime Data
        {
            get;
            set;
        }

        public double AreaTotal
        {
            get;
            set;
        }

        ////public List<AreaHora> AreaHoras
        ////{
        ////    get;
        ////    set;
        ////}
    }

    class RadiacaoHora
    {
        public DateTime Data
        {
            get;
            set;
        }

        ////public int Hora
        ////{
        ////    get;
        ////    set;
        ////}

        public double Radiacao
        {
            get;
            set;
        }
    }
}

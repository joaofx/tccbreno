namespace TccBreno
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lineStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.importSpreadSheet = new System.Windows.Forms.Button();
            this.openSpreadSheet = new System.Windows.Forms.Button();
            this.spreadSheetFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.areasList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.classes = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calculateClasses = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maximo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.intervalo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.frequencias = new System.Windows.Forms.Label();
            this.copiarClipboard = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.endLine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lineStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.importSpreadSheet);
            this.groupBox1.Controls.Add(this.openSpreadSheet);
            this.groupBox1.Controls.Add(this.spreadSheetFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processar Planilha";
            // 
            // endLine
            // 
            this.endLine.Location = new System.Drawing.Point(618, 45);
            this.endLine.Name = "endLine";
            this.endLine.Size = new System.Drawing.Size(40, 21);
            this.endLine.TabIndex = 9;
            this.endLine.Text = "2160";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Linha final";
            // 
            // lineStart
            // 
            this.lineStart.Location = new System.Drawing.Point(523, 46);
            this.lineStart.Name = "lineStart";
            this.lineStart.Size = new System.Drawing.Size(40, 21);
            this.lineStart.TabIndex = 7;
            this.lineStart.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Linha inicial";
            // 
            // importSpreadSheet
            // 
            this.importSpreadSheet.Location = new System.Drawing.Point(695, 43);
            this.importSpreadSheet.Name = "importSpreadSheet";
            this.importSpreadSheet.Size = new System.Drawing.Size(97, 23);
            this.importSpreadSheet.TabIndex = 5;
            this.importSpreadSheet.Text = "Processar";
            this.importSpreadSheet.UseVisualStyleBackColor = true;
            this.importSpreadSheet.Click += new System.EventHandler(this.ImportSpreadSheetClick);
            // 
            // openSpreadSheet
            // 
            this.openSpreadSheet.Location = new System.Drawing.Point(466, 43);
            this.openSpreadSheet.Name = "openSpreadSheet";
            this.openSpreadSheet.Size = new System.Drawing.Size(37, 23);
            this.openSpreadSheet.TabIndex = 4;
            this.openSpreadSheet.Text = "...";
            this.openSpreadSheet.UseVisualStyleBackColor = true;
            this.openSpreadSheet.Click += new System.EventHandler(this.OpenSpreadSheetClick);
            // 
            // spreadSheetFile
            // 
            this.spreadSheetFile.Location = new System.Drawing.Point(28, 45);
            this.spreadSheetFile.Name = "spreadSheetFile";
            this.spreadSheetFile.Size = new System.Drawing.Size(432, 21);
            this.spreadSheetFile.TabIndex = 3;
            this.spreadSheetFile.Text = "D:\\Projetos\\TccBreno\\Doc\\TAB2.xlsx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planilha";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(0, 357);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1026, 23);
            this.progress.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 28);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 23);
            // 
            // areasList
            // 
            this.areasList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.areasList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.areasList.FullRowSelect = true;
            this.areasList.GridLines = true;
            this.areasList.Location = new System.Drawing.Point(15, 127);
            this.areasList.MultiSelect = false;
            this.areasList.Name = "areasList";
            this.areasList.ShowGroups = false;
            this.areasList.Size = new System.Drawing.Size(278, 211);
            this.areasList.TabIndex = 5;
            this.areasList.UseCompatibleStateImageBehavior = false;
            this.areasList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dia";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Área Total";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Área Total Por Dia";
            // 
            // classes
            // 
            this.classes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.classes.FullRowSelect = true;
            this.classes.GridLines = true;
            this.classes.Location = new System.Drawing.Point(311, 162);
            this.classes.MultiSelect = false;
            this.classes.Name = "classes";
            this.classes.ShowGroups = false;
            this.classes.Size = new System.Drawing.Size(703, 161);
            this.classes.TabIndex = 9;
            this.classes.UseCompatibleStateImageBehavior = false;
            this.classes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Classe (m3/s)";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No Obs";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Obs Acum";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Acum %";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 80;
            // 
            // calculateClasses
            // 
            this.calculateClasses.Location = new System.Drawing.Point(817, 127);
            this.calculateClasses.Name = "calculateClasses";
            this.calculateClasses.Size = new System.Drawing.Size(126, 23);
            this.calculateClasses.TabIndex = 10;
            this.calculateClasses.Text = "Calcular Classes";
            this.calculateClasses.UseVisualStyleBackColor = true;
            this.calculateClasses.Click += new System.EventHandler(this.CalculateClassesClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Máximo";
            // 
            // maximo
            // 
            this.maximo.Location = new System.Drawing.Point(535, 127);
            this.maximo.Name = "maximo";
            this.maximo.Size = new System.Drawing.Size(84, 21);
            this.maximo.TabIndex = 12;
            this.maximo.Text = "19.300,700";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Intervalo";
            // 
            // intervalo
            // 
            this.intervalo.Location = new System.Drawing.Point(630, 127);
            this.intervalo.Name = "intervalo";
            this.intervalo.Size = new System.Drawing.Size(74, 21);
            this.intervalo.TabIndex = 14;
            this.intervalo.Text = "1.352,20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(717, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantidade";
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(720, 127);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(60, 21);
            this.quantidade.TabIndex = 16;
            this.quantidade.Text = "10";
            // 
            // frequencias
            // 
            this.frequencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.frequencias.AutoSize = true;
            this.frequencias.Location = new System.Drawing.Point(656, 326);
            this.frequencias.Name = "frequencias";
            this.frequencias.Size = new System.Drawing.Size(0, 13);
            this.frequencias.TabIndex = 17;
            // 
            // copiarClipboard
            // 
            this.copiarClipboard.Location = new System.Drawing.Point(311, 104);
            this.copiarClipboard.Name = "copiarClipboard";
            this.copiarClipboard.Size = new System.Drawing.Size(189, 46);
            this.copiarClipboard.TabIndex = 18;
            this.copiarClipboard.Text = "Copiar áreas por dia para área de trabalho";
            this.copiarClipboard.UseVisualStyleBackColor = true;
            this.copiarClipboard.Click += new System.EventHandler(this.CopiarClipboardClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 411);
            this.Controls.Add(this.copiarClipboard);
            this.Controls.Add(this.frequencias);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.intervalo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculateClasses);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.areasList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Text = "Dados de Radiação Solar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openSpreadSheet;
        private System.Windows.Forms.TextBox spreadSheetFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importSpreadSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lineStart;
        private System.Windows.Forms.TextBox endLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ListView areasList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView classes;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button calculateClasses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maximo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox intervalo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.Label frequencias;
        private System.Windows.Forms.Button copiarClipboard;
    }
}


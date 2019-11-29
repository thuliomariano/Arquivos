namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.txbDiretorio = new System.Windows.Forms.TextBox();
            this.lblDiretorios123 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Arquivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.lsbDiretorio = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(224, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Location = new System.Drawing.Point(33, 24);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(46, 13);
            this.lblDiretorio.TabIndex = 2;
            this.lblDiretorio.Text = "Diretorio";
            // 
            // txbDiretorio
            // 
            this.txbDiretorio.Location = new System.Drawing.Point(101, 19);
            this.txbDiretorio.Name = "txbDiretorio";
            this.txbDiretorio.Size = new System.Drawing.Size(113, 20);
            this.txbDiretorio.TabIndex = 3;
            // 
            // lblDiretorios123
            // 
            this.lblDiretorios123.AutoSize = true;
            this.lblDiretorios123.Location = new System.Drawing.Point(35, 66);
            this.lblDiretorios123.Name = "lblDiretorios123";
            this.lblDiretorios123.Size = new System.Drawing.Size(48, 13);
            this.lblDiretorios123.TabIndex = 4;
            this.lblDiretorios123.Text = "Arquivos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lsbDiretorio);
            this.groupBox1.Controls.Add(this.txbDiretorio);
            this.groupBox1.Controls.Add(this.lblDiretorio);
            this.groupBox1.Controls.Add(this.lblDiretorios123);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(50, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 437);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar diretorio";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Arquivo,
            this.Tamanho});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(259, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 316);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Arquivo
            // 
            this.Arquivo.Text = "Arquivo";
            this.Arquivo.Width = 97;
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho em Bytes";
            this.Tamanho.Width = 144;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar arquivos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lsbDiretorio
            // 
            this.lsbDiretorio.FormattingEnabled = true;
            this.lsbDiretorio.Location = new System.Drawing.Point(36, 83);
            this.lsbDiretorio.Name = "lsbDiretorio";
            this.lsbDiretorio.Size = new System.Drawing.Size(200, 316);
            this.lsbDiretorio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 490);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.TextBox txbDiretorio;
        private System.Windows.Forms.Label lblDiretorios123;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbDiretorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader Arquivo;
        private System.Windows.Forms.ColumnHeader Tamanho;
        public System.Windows.Forms.ListView listView1;
    }
}


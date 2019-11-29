namespace WindowsFormsApp1.Apresentacao
{
    partial class ThreadTeste
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.lsbDiretorio = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbNomeDoDiretorio = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Arquivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(305, 218);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(110, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar thread";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(497, 218);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 23);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar Thread";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Location = new System.Drawing.Point(8, 49);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(46, 13);
            this.lblDiretorio.TabIndex = 3;
            this.lblDiretorio.Text = "Diretorio";
            // 
            // lsbDiretorio
            // 
            this.lsbDiretorio.FormattingEnabled = true;
            this.lsbDiretorio.Location = new System.Drawing.Point(11, 65);
            this.lsbDiretorio.Name = "lsbDiretorio";
            this.lsbDiretorio.Size = new System.Drawing.Size(247, 147);
            this.lsbDiretorio.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNomeDoDiretorio
            // 
            this.txbNomeDoDiretorio.Location = new System.Drawing.Point(77, 24);
            this.txbNomeDoDiretorio.Name = "txbNomeDoDiretorio";
            this.txbNomeDoDiretorio.Size = new System.Drawing.Size(248, 20);
            this.txbNomeDoDiretorio.TabIndex = 6;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Arquivo,
            this.Tamanho});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(305, 65);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(302, 147);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arquivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite o caminho do arquivo";
            // 
            // ThreadTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txbNomeDoDiretorio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbDiretorio);
            this.Controls.Add(this.lblDiretorio);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "ThreadTeste";
            this.Text = "ThreadTeste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThreadTeste_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThreadTeste_FormClosed);
            this.Load += new System.EventHandler(this.ThreadTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lsbDiretorio;
        public System.Windows.Forms.TextBox txbNomeDoDiretorio;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Arquivo;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
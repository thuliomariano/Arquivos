using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.Apresentacao;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lsbDiretorio.Items.Clear();
            listView1.Items.Clear();
            String diretorio = txbDiretorio.Text;

                DirectoryInfo directory = new DirectoryInfo(@"C:\Users\maria\OneDrive\Área de Trabalho\Jogos");
                FileInfo[] arquivos = directory.GetFiles("*", SearchOption.TopDirectoryOnly);
            ListViewItem item = null;
            foreach (var arquivo in arquivos)
                {
                 lsbDiretorio.Items.Add(arquivo.FullName);
                item = new ListViewItem(new string[] { arquivo.FullName, arquivo.Length.ToString() });
                listView1.Items.Add(item);
            }

            
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            lblDiretorios123.Text = folderBrowserDialog1.SelectedPath;
            lsbDiretorio.Items.Clear();


            string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            lsbDiretorio.Items.AddRange(files);



            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThreadTeste thread = new ThreadTeste();
            thread.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] { "", "" });
            listView1.Items.Add(item);
            item = new ListViewItem(new string[] { "", "" });
            listView1.Items.Add(item);
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

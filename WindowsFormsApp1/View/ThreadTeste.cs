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
using System.Threading;
using WindowsFormsApp1.Apresentacao;

namespace WindowsFormsApp1.Apresentacao
{
    public partial class ThreadTeste : Form
    {
        Thread thread1;
        Boolean botao = true;
        public static String AtualziarRelatorio;
        public String mensagem;

        public ThreadTeste()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            botao = true;
            AtualziarRelatorio = txbNomeDoDiretorio.Text;
            thread1 = new Thread(LoopDeDiretorio1);
            lsbDiretorio.Items.Clear();
            thread1.Start();

        
        }



        public void LoopDeDiretorio1()
        {
            

                while (botao)
                {

                try
                {

             
                    String diretorio = txbNomeDoDiretorio.Text;
                    DirectoryInfo directory = new DirectoryInfo(diretorio);
                    FileInfo[] arquivos = directory.GetFiles("*", SearchOption.TopDirectoryOnly);
                    ListViewItem item = null;

                    foreach (var arquivo in arquivos)
                    {

                        lsbDiretorio.Invoke((MethodInvoker)delegate { lsbDiretorio.Items.Add(arquivo.FullName); });


                        item = new ListViewItem(new string[] { arquivo.FullName, arquivo.Length.ToString() });
                        listView2.Invoke((MethodInvoker)delegate { listView2.Items.Add(item); });
                        

                    }
                    
                    Thread.Sleep(1000);
                    listView2.Invoke((MethodInvoker)delegate { listView2.Items.Clear(); });
                    lsbDiretorio.Invoke((MethodInvoker)delegate { lsbDiretorio.Items.Clear(); });
                }
                catch (Exception error)
                {

                    MessageBox.Show("erro de execução");
                }
            }
           

        



        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (botao == true)
            {
                botao = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            if (txbNomeDoDiretorio.Text != "") {
                Thread thread = new Thread(LoopDeDiretorio1);

                lsbDiretorio.Items.Clear();

                String diretorio = txbNomeDoDiretorio.Text;

                DirectoryInfo directory = new DirectoryInfo(diretorio);
                FileInfo[] arquivos = directory.GetFiles("*", SearchOption.TopDirectoryOnly);
                foreach (var arquivo in arquivos)
                {
                   lsbDiretorio.Items.Add(arquivo.FullName);
                }
            }
            else
            {
                MessageBox.Show(this.mensagem = "Erro, favor preencher campo!!!");
            }

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro ao pesquisar diretorios");
            }
        }

        private void ThreadTeste_Load(object sender, EventArgs e)
        {

        }

        private void ThreadTeste_FormClosing(object sender, FormClosingEventArgs e)
        {
            //while (thread1.ThreadState==ThreadState.Running)
            //{
            //    Thread.Sleep(100);
            //}
        }

        private void ThreadTeste_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}

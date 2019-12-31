using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptDeString
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        crypto cr = new crypto();




        private void btnEncryptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtSaidaString.Text = cr.Encrypt(txtString.Text, txtFraseSecreta.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Verifique se foi preenchido corretamente os campos");
            }

           

        }

        private void btnDecrypta_Click(object sender, EventArgs e)
        {
            try
            {
                txtString.Text = cr.Decrypt(txtSaidaString.Text, txtFraseSecreta.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Verifique se foi preenchido corretamente os campos");
            }
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtString.Text = "";
            txtSaidaString.Text = "";
        }


        private void grpEncrypta_Enter(object sender, EventArgs e)
        {

        }











        /*--------------------------------------ABA 2---------------------------------------------------------*/

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\usuario\Desktop";
            openFileDialog1.Title = "Selecionar Arquivo";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtCaminhoDoArquivoTxt.Text = openFileDialog1.FileName;
        }


        private void btnSalvarArquivoEncryptado_Click(object sender, EventArgs e)
        {
            try
            {
               /* string caminhoParaSalvar = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    caminhoParaSalvar = saveFileDialog.FileName;*/


                StreamReader srRecebeArquivoTxt = new StreamReader(txtCaminhoDoArquivoTxt.Text);
                List<string> listaEncriptada = new List<string>();
                //string[] listaEncriptada = new string[srRecebeArquivoTxt;
                crypto crypto = new crypto();

                while (!srRecebeArquivoTxt.EndOfStream)
                {
                    listaEncriptada.Add(crypto.Encrypt(srRecebeArquivoTxt.ReadLine(), txtFraseParaEncryptareDecryptarArquivos.Text));

                }

                //System.IO.File.WriteAllLines(caminhoParaSalvar, listaEncriptada);
                System.IO.File.WriteAllLines(txtLocalParaSalvar.Text, listaEncriptada);
                MessageBox.Show("Conversão finalizada", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                srRecebeArquivoTxt.Dispose();
                listaEncriptada.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }

            limparCamposArquivo();
        }



        private void btnSalvarArquivoDecryptado_Click(object sender, EventArgs e)
        {
            try
            {
               /* string caminhoParaSalvar = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    caminhoParaSalvar = saveFileDialog.FileName;*/

                StreamReader srRecebeArquivoTxt = new StreamReader(txtCaminhoDoArquivoTxt.Text);
                List<string> listaDencriptada = new List<string>();
                crypto crypto = new crypto();

                while (!srRecebeArquivoTxt.EndOfStream)
                {
                    listaDencriptada.Add(crypto.Decrypt(srRecebeArquivoTxt.ReadLine(), txtFraseParaEncryptareDecryptarArquivos.Text));
                }

                System.IO.File.WriteAllLines(txtLocalParaSalvar.Text, listaDencriptada);
                MessageBox.Show("Conversão finalizada", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                srRecebeArquivoTxt.Dispose();
                listaDencriptada.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex);
            }

            limparCamposArquivo();

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Salvar Arquivo";
            saveFileDialog.Filter = "Text File | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                txtLocalParaSalvar.Text = saveFileDialog.FileName;
        }



        public void limparCamposArquivo()
        {
            txtLocalParaSalvar.Text = "";
            txtCaminhoDoArquivoTxt.Text = "";
        }


    }
}

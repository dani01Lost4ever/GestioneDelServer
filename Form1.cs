using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spostamento_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonScegliOrigine.Click += ButtonScegliOrigine_Click;
            this.buttonDestinazione.Click += ButtonDestinazione_Click;
            this.buttonSposta.Click += ButtonSposta_Click;
            this.buttonCopia.Click += ButtonCopia_Click;
        }

        private void ButtonCopia_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(textBoxFolderOrigine.Text) && System.IO.Directory.Exists(textBoxDestinazione.Text))
            {

                string[] files = System.IO.Directory.GetFiles(textBoxFolderOrigine.Text);

                StringBuilder fileListbuilder = new StringBuilder();

                foreach (String pathSingleFile in files)
                {
                    fileListbuilder.Append(" ").Append(pathSingleFile);
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(pathSingleFile);
                    string fileExt = System.IO.Path.GetExtension(pathSingleFile);

                    string destFile = System.IO.Path.Combine(textBoxDestinazione.Text, fileName + fileExt);

                    if (System.IO.File.Exists(destFile))
                    {
                        //string tempFileName = string.Format("{0}_{1}", fileName, DateTime.Now.ToString("yyyyMMddHHmmssfff"));
                        string tempFileName = fileName + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                        destFile = System.IO.Path.Combine(textBoxDestinazione.Text, tempFileName + fileExt);
                    }

                    System.IO.File.Copy(pathSingleFile, destFile);
                    //FileList.Text += "Done, "+ fileExt;
                }
            }
            else
            {
                MessageBox.Show("il percorso di origine e/o destinazione non esiste");
            }
        }

        private void ButtonSposta_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(textBoxFolderOrigine.Text) && System.IO.Directory.Exists(textBoxDestinazione.Text))
            {
                string[] files = System.IO.Directory.GetFiles(textBoxFolderOrigine.Text);
                foreach (String pathSingleFile in files)
                {
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(pathSingleFile);
                    string fileExt = System.IO.Path.GetExtension(pathSingleFile);

                    string destFile = System.IO.Path.Combine(textBoxDestinazione.Text, fileName + fileExt);

                    int count = 1;
                    while (System.IO.File.Exists(destFile))
                    {
                        string tempFileName = string.Format("{0}({1})", fileName, count++);
                        destFile = System.IO.Path.Combine(textBoxDestinazione.Text, tempFileName + fileExt);
                    }

                    System.IO.File.Move(pathSingleFile, destFile);
                    FileList.Text += "Done, " + fileExt;
                }
            }
            else
            {
                MessageBox.Show("il percorso di origine e/o destinazione non esiste");
            }
        }

        private void ButtonDestinazione_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogDestinazione.ShowDialog() == DialogResult.OK)
            {
                textBoxDestinazione.Text = folderBrowserDialogDestinazione.SelectedPath; textBoxDestinazione.Focus();
            }
        }

        private void ButtonScegliOrigine_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogOrigine.ShowDialog() == DialogResult.OK)
            {
                textBoxFolderOrigine.Text = folderBrowserDialogOrigine.SelectedPath; textBoxFolderOrigine.Focus();
            }
        }
    }
}

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

namespace _001_FileOperations
{
    public partial class Form1 : Form
    {
        string filePath, fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectLocation_Click(object sender, EventArgs e)
        {
            /*
             *  Folder Browser Dialog Aracı;  
             *  
             *  Dosya giriş çıkış işlemerinde konum seçmek için kullanılan araçtır. 
             *  Bu diyalog aracında dosya türleri gösterilmez yanlızca konum bilgisi veirlir. 
             */
            folderBrowserDialog1.ShowDialog(); 
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnOpenFileDialog_Click(object sender, EventArgs e)
        {
            /*
             *  Open File Dialog Aracı;
             *  
             *  sadece klasörleri değil aynı zamanda dosyaları da gösteren araçtır. 
             */
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void BtnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();   
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fileName = txtFileName.Text;
            StreamWriter sw = File.CreateText(filePath + "\\" + fileName + ".txt");
            MessageBox.Show(
                "Belgeniz başarı ile oluşturuldu.", 
                "Bilgi", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);   
                string line = sr.ReadLine();
                while (line != null)
                {
                    listBox1.Items.Add(line);
                    line = sr.ReadLine();
                }
            }
        }

        private void btnSelectLocation_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = folderBrowserDialog1.SelectedPath;
                txtFilePath.Text = filePath;
            }
        }
    }
}



using KonelAnons.Models;
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

namespace KonelAnons
{
    public partial class frmAddAnons : Form
    {
        public frmAddAnons()
        {
            InitializeComponent();
        }

        string filePath = "";

        private void btnSelectSound_Click(object sender, EventArgs e)
        {
            filePath = "";
            DialogResult dialogResult = ofdSelectSound.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                filePath = ofdSelectSound.FileName;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Anons Sesini Seçmediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSoundName.Text = "...";
            }
            else
            {
                lblSoundName.Text = Path.GetFileName(filePath);
            }
        }

        private void btnSaveAnons_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnonsName.Text))
            {
                MessageBox.Show("Anons Adını Girmediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Anons Sesini Seçmediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = Path.GetFileName(filePath);
            File.Copy(filePath, Application.StartupPath + "\\media\\" + fileName,true);

            //System.IO.

            DbManager dbManager = new DbManager();
            Anons anons = new Anons
            {
                anons_name = txtAnonsName.Text,
                anons_time = txtAnonsTime.Text,
                anons_filepath = fileName
            };

            try
            {
                dbManager.SaveAnons(anons);
                MessageBox.Show("Yeni Anons Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Anons Ekleme Esnasında Bir Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

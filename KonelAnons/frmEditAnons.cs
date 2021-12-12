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
    public partial class frmEditAnons : Form
    {
        public frmEditAnons()
        {
            InitializeComponent();
        }

        public Anons anons;
        string filePath = "";

        private void frmEditAnons_Load(object sender, EventArgs e)
        {
            txtAnonsName.Text = anons.anons_name;
            txtAnonsTime.Text = anons.anons_time;
            lblSoundName.Text = anons.anons_filepath;
            //filePath = anons.anons_filepath;
        }

        private void btnSaveAnons_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnonsName.Text))
            {
                MessageBox.Show("Anons Adını Girmediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DbManager dbManager = new DbManager();

            anons.anons_name = txtAnonsName.Text;
            anons.anons_time = txtAnonsTime.Text;

            if (!string.IsNullOrEmpty(filePath))
            {
                anons.anons_filepath = Path.GetFileName(filePath);
                string fileName = Path.GetFileName(filePath);
                File.Copy(filePath, Application.StartupPath + "\\media\\" + fileName,true);
            }

            try
            {
                dbManager.EditAnons(anons);
                MessageBox.Show("Anons Bilgileri Düzenlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Anons Düzenleme Esnasında Bir Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectSound_Click(object sender, EventArgs e)
        {
            filePath = "";
            DialogResult dialogResult = ofdSelectSound.ShowDialog();
            if (dialogResult == DialogResult.OK)
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
                //filePath = Path.GetFileName(filePath);
                lblSoundName.Text = Path.GetFileName(filePath); ;
            }
        }
    }
}

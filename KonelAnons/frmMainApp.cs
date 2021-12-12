using KonelAnons.Models;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonelAnons
{
    public partial class frmMainApp : Form
    {
        List<Anons> anonsList;
        Anons nextAnons;

        public frmMainApp()
        {
            anonsList = new List<Anons>();
            nextAnons = new Anons();
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FillAnonsTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vol = AudioUtilities.GetAllDevices();
            var sess = AudioUtilities.GetAllSessions();
            //sess[0].ProcessId
            var vo = AudioUtilities.GetApplicationVolume(sess[1].ProcessId);
            AudioUtilities.SetApplicationMute(sess[1].ProcessId, true,Guid.Empty);
            //var ob = GetVolumeObject("Spotify");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAnons frmAddAnons = new frmAddAnons();
            frmAddAnons.ShowDialog();
            FillAnonsTable();
            tmrAnons.Start();
        }

        public void FillAnonsTable()
        {
            DbManager dbManager = new DbManager();
            anonsList = dbManager.GetAnonsList();
            dgvAnonsList.DataSource = anonsList;
            GetNextAnons();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int anonsId = 0;

            if (dgvAnonsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tablodan Bir Anons Seçin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strAnonsId = dgvAnonsList.SelectedRows[0].Cells[0].Value.ToString();


            if (string.IsNullOrEmpty(strAnonsId))
            {
                MessageBox.Show("Tablodan Bir Anons Seçin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            anonsId = int.Parse(strAnonsId);
            DbManager dbManager = new DbManager();
            Anons anons = dbManager.GetAnons(anonsId);
            frmEditAnons frmEditAnons = new frmEditAnons();
            frmEditAnons.anons = anons;
            frmEditAnons.ShowDialog();
            FillAnonsTable();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int anonsId = 0;

            if (dgvAnonsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tablodan Bir Anons Seçin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strAnonsId = dgvAnonsList.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(strAnonsId))
            {
                MessageBox.Show("Tablodan Bir Anons Seçin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            anonsId = int.Parse(strAnonsId);

            DialogResult dialogResult = MessageBox.Show("Anons Kalıcı Olarak Silinecektir, Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DbManager dbManager = new DbManager();
                dbManager.RemoveAnons(anonsId);
                MessageBox.Show("Anons Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillAnonsTable();
            }
            else
            {
                MessageBox.Show("Anons Silme İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tmrAnons_Tick(object sender, EventArgs e)
        {
            TimeSpan nowTime = DateTime.Now.TimeOfDay;
            foreach (var anons in anonsList)
            {
                TimeSpan anonsTime = TimeSpan.Parse(anons.anons_time);
                if (anonsTime.Hours == nowTime.Hours && anonsTime.Minutes == nowTime.Minutes)
                {
                    PlayAnonsAsnc(anons);
                }
            }
        }

        private async void PlayAnonsAsnc(Anons anons)
        {
            tmrAnons.Stop();
            await Task.Run(() =>
            {
                float preMasterVolume = AudioUtilities.GetMasterVolume();
                AudioUtilities.SetMasterVolume(100f);

                var deviceList = AudioUtilities.GetAllDevices();
                
                //vol.FirstOrDefault().
                var sessions = AudioUtilities.GetAllSessions();

                foreach (var device in deviceList)
                {
                    if(device.State == AudioDeviceState.Active)
                    {
                        Guid deviceId = new Guid(device.ContainerId);
                        foreach (var session in sessions)
                        {
                            if(session.Process!= null)
                            {
                                if (session.Process.ProcessName != "KonelAnons")
                                {
                                    AudioUtilities.SetApplicationMute(session.ProcessId, true, deviceId);
                                }
                                else
                                {

                                    //var speaker = AudioUtilities.GetSpeakersDevice();
                                    //var speakerId = new Guid(speaker.ContainerId);
                                    //AudioUtilities.SetMasterVolume(100f);
                                    //AudioUtilities.SetApplicationVolume(session.ProcessId, 99f, speakerId);
                                    AudioUtilities.SetApplicationVolume(session.ProcessId, 99f, deviceId);
                                }
                            }                                                  
                        }
                    }                
                }        

                Thread.Sleep(2000);

                string filePath = Application.StartupPath + "\\media\\" + anons.anons_filepath;
                using (var ms = File.OpenRead(filePath))
                using (var rdr = new Mp3FileReader(ms))
                using (var wavStream = WaveFormatConversionStream.CreatePcmStream(rdr))
                using (var baStream = new BlockAlignReductionStream(wavStream))
                using (var waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                {
                    waveOut.Init(baStream);
                    waveOut.Play();
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(100);
                    }
                }

                Thread.Sleep(2000);

                AudioUtilities.SetMasterVolume(preMasterVolume);

                foreach (var device in deviceList)
                {
                    if (device.State == AudioDeviceState.Active)
                    {
                        Guid deviceId = new Guid(device.ContainerId);
                        foreach (var session in sessions)
                        {
                            if (session.Process != null)
                            {
                                if (session.Process.ProcessName != "KonelAnons")
                                {
                                    AudioUtilities.SetApplicationMute(session.ProcessId, false, deviceId);
                                }
                            }                          
                        }
                    }
                }

                Thread.Sleep(60000);
                GetNextAnons();
            });
            tmrAnons.Start();
        }

        private void GetNextAnons()
        {
            Anons _nextAnons = null;
            TimeSpan nowTime = DateTime.Now.TimeOfDay;
            foreach (var anons in anonsList)
            {
                TimeSpan tNextAnons = TimeSpan.Parse(anons.anons_time);
                if (_nextAnons == null)
                {

                    if(tNextAnons.Ticks > nowTime.Ticks)
                    {
                        _nextAnons = anons;
                    }                    
                }
                else
                {
                    TimeSpan tLastAnons = TimeSpan.Parse(_nextAnons.anons_time);                    
                    if (tNextAnons.Ticks < tLastAnons.Ticks && tNextAnons.Ticks > nowTime.Ticks)
                    {
                        _nextAnons = anons;
                    }
                }
            }
            nextAnons = _nextAnons;
        }

        private void stmOpenProgram_Click(object sender, EventArgs e)
        {

        }

        private void tmrAnonsTimer_Tick(object sender, EventArgs e)
        {
            if(nextAnons == null)
            {
                lblNextAnonsTime.Text = "Bugün İçin Artık Anons Yok";
            }
            else
            {
                TimeSpan nowTime = DateTime.Now.TimeOfDay;
                TimeSpan anonsTime = TimeSpan.Parse(nextAnons.anons_time);

                TimeSpan nextAnonsTime = anonsTime - nowTime;
                lblNextAnonsTime.Text = nextAnonsTime.ToString("hh")+":"+nextAnonsTime.ToString("mm")+":"+nextAnonsTime.ToString("ss");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PlayAnonsAsnc(anonsList.FirstOrDefault());
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int anonsId = 0;

            if (dgvAnonsList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tablodan Bir Anons Seçin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strAnonsId = dgvAnonsList.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(strAnonsId))
            {
                MessageBox.Show("Tablodan Bir Anons Seçin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            anonsId = int.Parse(strAnonsId);
            var anons = anonsList.FirstOrDefault(x => x.id == anonsId);

            PlayAnonsAsnc(anons);
        }
    }
}

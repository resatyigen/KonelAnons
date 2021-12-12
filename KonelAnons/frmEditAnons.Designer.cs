namespace KonelAnons
{
    partial class frmEditAnons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAnons));
            this.txtAnonsTime = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnonsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectSound = new System.Windows.Forms.Button();
            this.lblSoundName = new System.Windows.Forms.Label();
            this.btnSaveAnons = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofdSelectSound = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAnonsTime
            // 
            this.txtAnonsTime.Location = new System.Drawing.Point(12, 115);
            this.txtAnonsTime.Mask = "00:00";
            this.txtAnonsTime.Name = "txtAnonsTime";
            this.txtAnonsTime.Size = new System.Drawing.Size(100, 20);
            this.txtAnonsTime.TabIndex = 15;
            this.txtAnonsTime.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Anons Zamanı";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Anons Düzenle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnonsName
            // 
            this.txtAnonsName.Location = new System.Drawing.Point(12, 63);
            this.txtAnonsName.Name = "txtAnonsName";
            this.txtAnonsName.Size = new System.Drawing.Size(374, 20);
            this.txtAnonsName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Anons Adı";
            // 
            // btnSelectSound
            // 
            this.btnSelectSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelectSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectSound.ForeColor = System.Drawing.Color.Purple;
            this.btnSelectSound.Location = new System.Drawing.Point(12, 18);
            this.btnSelectSound.Name = "btnSelectSound";
            this.btnSelectSound.Size = new System.Drawing.Size(115, 23);
            this.btnSelectSound.TabIndex = 7;
            this.btnSelectSound.Text = "Anons Sesi Ekle";
            this.btnSelectSound.UseVisualStyleBackColor = true;
            this.btnSelectSound.Click += new System.EventHandler(this.btnSelectSound_Click);
            // 
            // lblSoundName
            // 
            this.lblSoundName.AutoSize = true;
            this.lblSoundName.Location = new System.Drawing.Point(133, 28);
            this.lblSoundName.Name = "lblSoundName";
            this.lblSoundName.Size = new System.Drawing.Size(19, 13);
            this.lblSoundName.TabIndex = 8;
            this.lblSoundName.Text = "....";
            // 
            // btnSaveAnons
            // 
            this.btnSaveAnons.BackColor = System.Drawing.Color.Green;
            this.btnSaveAnons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAnons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAnons.ForeColor = System.Drawing.Color.White;
            this.btnSaveAnons.Location = new System.Drawing.Point(307, 213);
            this.btnSaveAnons.Name = "btnSaveAnons";
            this.btnSaveAnons.Size = new System.Drawing.Size(79, 29);
            this.btnSaveAnons.TabIndex = 17;
            this.btnSaveAnons.Text = "KAYDET";
            this.btnSaveAnons.UseVisualStyleBackColor = false;
            this.btnSaveAnons.Click += new System.EventHandler(this.btnSaveAnons_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSelectSound);
            this.panel1.Controls.Add(this.lblSoundName);
            this.panel1.Location = new System.Drawing.Point(11, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 57);
            this.panel1.TabIndex = 16;
            // 
            // ofdSelectSound
            // 
            this.ofdSelectSound.Filter = "MP3 File (.mp3)|*.mp3";
            // 
            // frmEditAnons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.txtAnonsTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnonsName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveAnons);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditAnons";
            this.Text = "Anons Düzenle";
            this.Load += new System.EventHandler(this.frmEditAnons_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtAnonsTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnonsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectSound;
        private System.Windows.Forms.Label lblSoundName;
        private System.Windows.Forms.Button btnSaveAnons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog ofdSelectSound;
    }
}
namespace KonelAnons
{
    partial class frmMainApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainApp));
            this.dgvAnonsList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tmrAnons = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNextAnonsTime = new System.Windows.Forms.Label();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.appNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stmOpenProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStopProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrAnonsTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnonsList)).BeginInit();
            this.appNotifyMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnonsList
            // 
            this.dgvAnonsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAnonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnonsList.Location = new System.Drawing.Point(12, 136);
            this.dgvAnonsList.Name = "dgvAnonsList";
            this.dgvAnonsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAnonsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAnonsList.Size = new System.Drawing.Size(776, 270);
            this.dgvAnonsList.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(524, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(612, 412);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 28);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "DÜZENLE";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(706, 412);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 28);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "SİL";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tmrAnons
            // 
            this.tmrAnons.Enabled = true;
            this.tmrAnons.Interval = 1000;
            this.tmrAnons.Tick += new System.EventHandler(this.tmrAnons_Tick);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(260, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 101);
            this.label1.TabIndex = 8;
            this.label1.Text = "KONEL OTOMATİK ANONS PROGRAMI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sonraki Anons Zamanı : ";
            // 
            // lblNextAnonsTime
            // 
            this.lblNextAnonsTime.AutoSize = true;
            this.lblNextAnonsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNextAnonsTime.Location = new System.Drawing.Point(170, 421);
            this.lblNextAnonsTime.Name = "lblNextAnonsTime";
            this.lblNextAnonsTime.Size = new System.Drawing.Size(19, 15);
            this.lblNextAnonsTime.TabIndex = 10;
            this.lblNextAnonsTime.Text = "...";
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.ContextMenuStrip = this.appNotifyMenu;
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "Konel Otomatik Anons Programı";
            this.appNotifyIcon.Visible = true;
            // 
            // appNotifyMenu
            // 
            this.appNotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmOpenProgram,
            this.tsmStopProgram});
            this.appNotifyMenu.Name = "appNotifyMenu";
            this.appNotifyMenu.Size = new System.Drawing.Size(164, 48);
            this.appNotifyMenu.Text = "appNotifyMenu";
            // 
            // stmOpenProgram
            // 
            this.stmOpenProgram.Name = "stmOpenProgram";
            this.stmOpenProgram.Size = new System.Drawing.Size(163, 22);
            this.stmOpenProgram.Text = "Programı Aç";
            this.stmOpenProgram.Click += new System.EventHandler(this.stmOpenProgram_Click);
            // 
            // tsmStopProgram
            // 
            this.tsmStopProgram.Name = "tsmStopProgram";
            this.tsmStopProgram.Size = new System.Drawing.Size(163, 22);
            this.tsmStopProgram.Text = "Programı Durdur";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KonelAnons.Properties.Resources.bottom_line;
            this.pictureBox2.Location = new System.Drawing.Point(12, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KonelAnons.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tmrAnonsTimer
            // 
            this.tmrAnonsTimer.Enabled = true;
            this.tmrAnonsTimer.Interval = 1000;
            this.tmrAnonsTimer.Tick += new System.EventHandler(this.tmrAnonsTimer_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlay.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlay.Location = new System.Drawing.Point(436, 412);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(82, 28);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "OYNAT";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNextAnonsTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAnonsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainApp";
            this.Text = "KONEL OTOMATİK ANONS PROGRAMI";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnonsList)).EndInit();
            this.appNotifyMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAnonsList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Timer tmrAnons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNextAnonsTime;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip appNotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem stmOpenProgram;
        private System.Windows.Forms.ToolStripMenuItem tsmStopProgram;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrAnonsTimer;
        private System.Windows.Forms.Button btnPlay;
    }
}
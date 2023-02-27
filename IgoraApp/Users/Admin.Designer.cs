namespace IgoraApp.Users
{
    partial class Admin
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SessionTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CreateLog = new System.Windows.Forms.Button();
            this.UsersHistory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Post = new System.Windows.Forms.Label();
            this.SessionTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UserPhoto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FullName);
            this.groupBox2.Controls.Add(this.Post);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 352);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об администраторе";
            // 
            // SessionTime
            // 
            this.SessionTime.AutoSize = true;
            this.SessionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionTime.Location = new System.Drawing.Point(9, 9);
            this.SessionTime.Name = "SessionTime";
            this.SessionTime.Size = new System.Drawing.Size(87, 20);
            this.SessionTime.TabIndex = 20;
            this.SessionTime.Text = "00 : 00 : 00";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.CreateLog);
            this.groupBox3.Controls.Add(this.UsersHistory);
            this.groupBox3.Location = new System.Drawing.Point(224, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 172);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Функции";
            // 
            // CreateLog
            // 
            this.CreateLog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CreateLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateLog.Location = new System.Drawing.Point(21, 102);
            this.CreateLog.Margin = new System.Windows.Forms.Padding(4);
            this.CreateLog.Name = "CreateLog";
            this.CreateLog.Size = new System.Drawing.Size(179, 42);
            this.CreateLog.TabIndex = 19;
            this.CreateLog.Text = "Создать отчет";
            this.CreateLog.UseVisualStyleBackColor = false;
            // 
            // UsersHistory
            // 
            this.UsersHistory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UsersHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersHistory.Location = new System.Drawing.Point(21, 51);
            this.UsersHistory.Margin = new System.Windows.Forms.Padding(4);
            this.UsersHistory.Name = "UsersHistory";
            this.UsersHistory.Size = new System.Drawing.Size(179, 42);
            this.UsersHistory.TabIndex = 18;
            this.UsersHistory.Text = "История входа";
            this.UsersHistory.UseVisualStyleBackColor = false;
            this.UsersHistory.Click += new System.EventHandler(this.UsersHistory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Авторизован";
            // 
            // UserPhoto
            // 
            this.UserPhoto.Location = new System.Drawing.Point(24, 37);
            this.UserPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.Size = new System.Drawing.Size(169, 192);
            this.UserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPhoto.TabIndex = 13;
            this.UserPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(208, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(211, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Роль";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName.Location = new System.Drawing.Point(258, 69);
            this.FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(46, 17);
            this.FullName.TabIndex = 16;
            this.FullName.Text = "label3";
            // 
            // Post
            // 
            this.Post.AutoSize = true;
            this.Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Post.Location = new System.Drawing.Point(258, 108);
            this.Post.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(46, 17);
            this.Post.TabIndex = 17;
            this.Post.Text = "label4";
            // 
            // SessionTimer
            // 
            this.SessionTimer.Enabled = true;
            this.SessionTimer.Interval = 1000;
            this.SessionTimer.Tick += new System.EventHandler(this.SessionTimerTick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SessionTime);
            this.panel1.Location = new System.Drawing.Point(54, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 38);
            this.panel1.TabIndex = 43;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 378);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminFormClosing);
            this.Load += new System.EventHandler(this.AdminLoad);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateLog;
        private System.Windows.Forms.Button UsersHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox UserPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Post;
        private System.Windows.Forms.Timer SessionTimer;
        private System.Windows.Forms.Label SessionTime;
        private System.Windows.Forms.Panel panel1;
    }
}
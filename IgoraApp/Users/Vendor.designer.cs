namespace IgoraApp.Users
{
    partial class Vendor
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
            this.Post = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserPhoto = new System.Windows.Forms.PictureBox();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SeeAllClients = new System.Windows.Forms.Button();
            this.SeeAllOrders = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SessionTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.SessionTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateOrder.Location = new System.Drawing.Point(23, 34);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(179, 42);
            this.CreateOrder.TabIndex = 18;
            this.CreateOrder.Text = "Создать заказ";
            this.CreateOrder.UseVisualStyleBackColor = false;
            this.CreateOrder.Click += new System.EventHandler(this.RegisterOrder);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UserPhoto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FullName);
            this.groupBox2.Controls.Add(this.Post);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 366);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о продавце";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.SeeAllClients);
            this.groupBox3.Controls.Add(this.SeeAllOrders);
            this.groupBox3.Controls.Add(this.CreateOrder);
            this.groupBox3.Location = new System.Drawing.Point(224, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 201);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Функции";
            // 
            // SeeAllClients
            // 
            this.SeeAllClients.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SeeAllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeAllClients.Location = new System.Drawing.Point(23, 137);
            this.SeeAllClients.Margin = new System.Windows.Forms.Padding(4);
            this.SeeAllClients.Name = "SeeAllClients";
            this.SeeAllClients.Size = new System.Drawing.Size(179, 42);
            this.SeeAllClients.TabIndex = 20;
            this.SeeAllClients.Text = "Все клиенты >>";
            this.SeeAllClients.UseVisualStyleBackColor = false;
            this.SeeAllClients.Click += new System.EventHandler(this.SeeAllClientsClick);
            // 
            // SeeAllOrders
            // 
            this.SeeAllOrders.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SeeAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeAllOrders.Location = new System.Drawing.Point(23, 85);
            this.SeeAllOrders.Margin = new System.Windows.Forms.Padding(4);
            this.SeeAllOrders.Name = "SeeAllOrders";
            this.SeeAllOrders.Size = new System.Drawing.Size(179, 42);
            this.SeeAllOrders.TabIndex = 19;
            this.SeeAllOrders.Text = "Все заказы >>";
            this.SeeAllOrders.UseVisualStyleBackColor = false;
            this.SeeAllOrders.Click += new System.EventHandler(this.SeeAllOrdersClick);
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
            // SessionTimer
            // 
            this.SessionTimer.Enabled = true;
            this.SessionTimer.Interval = 1000;
            this.SessionTimer.Tick += new System.EventHandler(this.SessionTimerTick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SessionTime);
            this.panel2.Location = new System.Drawing.Point(53, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 38);
            this.panel2.TabIndex = 44;
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
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 390);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vendor";
            this.Text = "Продавец";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VendorFormClosing);
            this.Load += new System.EventHandler(this.VendorFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Post;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox UserPhoto;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer SessionTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SeeAllClients;
        private System.Windows.Forms.Button SeeAllOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SessionTime;
    }
}
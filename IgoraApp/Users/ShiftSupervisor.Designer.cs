namespace IgoraApp.Users
{
    partial class ShiftSupervisor
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
            this.GetProducts = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.SessionTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SessionTime = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SeeAllClients = new System.Windows.Forms.Button();
            this.SeeAllOrders = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.UserPhoto = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Post = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // GetProducts
            // 
            this.GetProducts.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GetProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetProducts.Location = new System.Drawing.Point(25, 28);
            this.GetProducts.Name = "GetProducts";
            this.GetProducts.Size = new System.Drawing.Size(179, 42);
            this.GetProducts.TabIndex = 0;
            this.GetProducts.Text = "Принять товар";
            this.GetProducts.UseVisualStyleBackColor = false;
            this.GetProducts.Click += new System.EventHandler(this.GetProductsClick);
            // 
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateOrder.Location = new System.Drawing.Point(25, 77);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(179, 42);
            this.CreateOrder.TabIndex = 1;
            this.CreateOrder.Text = "Создать заказ";
            this.CreateOrder.UseVisualStyleBackColor = false;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrderClick);
            // 
            // SessionTimer
            // 
            this.SessionTimer.Enabled = true;
            this.SessionTimer.Interval = 1000;
            this.SessionTimer.Tick += new System.EventHandler(this.SessionTimerTick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.UserPhoto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.FullName);
            this.groupBox1.Controls.Add(this.Post);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 366);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о старшем смены";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SessionTime);
            this.panel1.Location = new System.Drawing.Point(54, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 38);
            this.panel1.TabIndex = 48;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.SeeAllClients);
            this.groupBox4.Controls.Add(this.SeeAllOrders);
            this.groupBox4.Controls.Add(this.GetProducts);
            this.groupBox4.Controls.Add(this.CreateOrder);
            this.groupBox4.Location = new System.Drawing.Point(224, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 219);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Функции";
            // 
            // SeeAllClients
            // 
            this.SeeAllClients.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SeeAllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeAllClients.Location = new System.Drawing.Point(25, 170);
            this.SeeAllClients.Margin = new System.Windows.Forms.Padding(4);
            this.SeeAllClients.Name = "SeeAllClients";
            this.SeeAllClients.Size = new System.Drawing.Size(179, 42);
            this.SeeAllClients.TabIndex = 3;
            this.SeeAllClients.Text = "Все клиенты >>";
            this.SeeAllClients.UseVisualStyleBackColor = false;
            this.SeeAllClients.Click += new System.EventHandler(this.SeeAllClientsClick);
            // 
            // SeeAllOrders
            // 
            this.SeeAllOrders.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SeeAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeAllOrders.Location = new System.Drawing.Point(25, 123);
            this.SeeAllOrders.Margin = new System.Windows.Forms.Padding(4);
            this.SeeAllOrders.Name = "SeeAllOrders";
            this.SeeAllOrders.Size = new System.Drawing.Size(179, 42);
            this.SeeAllOrders.TabIndex = 2;
            this.SeeAllOrders.Text = "Все заказы >>";
            this.SeeAllOrders.UseVisualStyleBackColor = false;
            this.SeeAllOrders.Click += new System.EventHandler(this.SeeAllOrdersClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Авторизован";
            // 
            // UserPhoto
            // 
            this.UserPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPhoto.Location = new System.Drawing.Point(24, 37);
            this.UserPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.Size = new System.Drawing.Size(169, 192);
            this.UserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPhoto.TabIndex = 13;
            this.UserPhoto.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(208, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "ФИО";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(211, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Роль";
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
            // ShiftSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 390);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShiftSupervisor";
            this.Text = "Старший смены";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShiftSupervisorFormClosing);
            this.Load += new System.EventHandler(this.ShiftSupervisorFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button GetProducts;
        private System.Windows.Forms.Timer SessionTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox UserPhoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Post;
        private System.Windows.Forms.Button SeeAllClients;
        private System.Windows.Forms.Button SeeAllOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SessionTime;
    }
}
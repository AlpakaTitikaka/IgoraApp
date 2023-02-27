namespace IgoraApp.Users.Functions
{
    partial class AddClient
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PassportNumber = new System.Windows.Forms.TextBox();
            this.ClientId = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.ClientAddress = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.PassportSeria = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTitle = new System.Windows.Forms.Label();
            this.AddNewClient = new System.Windows.Forms.Button();
            this.CancelAddition = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PassportNumber);
            this.groupBox2.Controls.Add(this.ClientId);
            this.groupBox2.Controls.Add(this.Phone);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.ClientAddress);
            this.groupBox2.Controls.Add(this.ClientName);
            this.groupBox2.Controls.Add(this.PassportSeria);
            this.groupBox2.Controls.Add(this.Birthday);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IdTitle);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 422);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о покупателе";
            // 
            // PassportNumber
            // 
            this.PassportNumber.Location = new System.Drawing.Point(159, 219);
            this.PassportNumber.MaxLength = 6;
            this.PassportNumber.Name = "PassportNumber";
            this.PassportNumber.Size = new System.Drawing.Size(120, 23);
            this.PassportNumber.TabIndex = 4;
            this.PassportNumber.TextChanged += new System.EventHandler(this.PassportNumberTextChanged);
            // 
            // ClientId
            // 
            this.ClientId.Location = new System.Drawing.Point(9, 49);
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Size = new System.Drawing.Size(270, 23);
            this.ClientId.TabIndex = 0;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(9, 379);
            this.Phone.MaxLength = 20;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(270, 23);
            this.Phone.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(9, 332);
            this.Email.MaxLength = 50;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(270, 23);
            this.Email.TabIndex = 6;
            // 
            // ClientAddress
            // 
            this.ClientAddress.Location = new System.Drawing.Point(9, 266);
            this.ClientAddress.MaxLength = 255;
            this.ClientAddress.Multiline = true;
            this.ClientAddress.Name = "ClientAddress";
            this.ClientAddress.Size = new System.Drawing.Size(270, 43);
            this.ClientAddress.TabIndex = 5;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(9, 111);
            this.ClientName.MaxLength = 100;
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(270, 23);
            this.ClientName.TabIndex = 1;
            this.ClientName.TextChanged += new System.EventHandler(this.ClientNameTextChanged);
            // 
            // PassportSeria
            // 
            this.PassportSeria.Location = new System.Drawing.Point(9, 219);
            this.PassportSeria.MaxLength = 4;
            this.PassportSeria.Name = "PassportSeria";
            this.PassportSeria.Size = new System.Drawing.Size(92, 23);
            this.PassportSeria.TabIndex = 3;
            this.PassportSeria.TextChanged += new System.EventHandler(this.PassportSeriaTextChanged);
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(9, 156);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(270, 23);
            this.Birthday.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Паспорт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // IdTitle
            // 
            this.IdTitle.AutoSize = true;
            this.IdTitle.Location = new System.Drawing.Point(6, 29);
            this.IdTitle.Name = "IdTitle";
            this.IdTitle.Size = new System.Drawing.Size(114, 17);
            this.IdTitle.TabIndex = 0;
            this.IdTitle.Text = "Код покупателя";
            // 
            // AddNewClient
            // 
            this.AddNewClient.Location = new System.Drawing.Point(12, 465);
            this.AddNewClient.Name = "AddNewClient";
            this.AddNewClient.Size = new System.Drawing.Size(114, 31);
            this.AddNewClient.TabIndex = 8;
            this.AddNewClient.Text = "Добавить";
            this.AddNewClient.UseVisualStyleBackColor = true;
            this.AddNewClient.Click += new System.EventHandler(this.AddNewClientClick);
            // 
            // CancelAddition
            // 
            this.CancelAddition.Location = new System.Drawing.Point(197, 465);
            this.CancelAddition.Name = "CancelAddition";
            this.CancelAddition.Size = new System.Drawing.Size(114, 31);
            this.CancelAddition.TabIndex = 9;
            this.CancelAddition.Text = "Отмена";
            this.CancelAddition.UseVisualStyleBackColor = true;
            this.CancelAddition.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 523);
            this.Controls.Add(this.CancelAddition);
            this.Controls.Add(this.AddNewClient);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClient";
            this.Text = "Добавить покупателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddClientFormClosing);
            this.Load += new System.EventHandler(this.AddClientLoad);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdTitle;
        private System.Windows.Forms.Button AddNewClient;
        private System.Windows.Forms.Button CancelAddition;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox ClientAddress;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox PassportSeria;
        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.TextBox PassportNumber;
    }
}
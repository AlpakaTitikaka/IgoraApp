namespace IgoraApp.Users.Functions
{
    partial class AllClients
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
            this.AllClientsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddingClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsData)).BeginInit();
            this.SuspendLayout();
            // 
            // AllClientsData
            // 
            this.AllClientsData.AllowUserToAddRows = false;
            this.AllClientsData.AllowUserToDeleteRows = false;
            this.AllClientsData.AllowUserToOrderColumns = true;
            this.AllClientsData.AllowUserToResizeColumns = false;
            this.AllClientsData.AllowUserToResizeRows = false;
            this.AllClientsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllClientsData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllClientsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClientsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column4,
            this.Column3});
            this.AllClientsData.Location = new System.Drawing.Point(14, 52);
            this.AllClientsData.Margin = new System.Windows.Forms.Padding(4);
            this.AllClientsData.MultiSelect = false;
            this.AllClientsData.Name = "AllClientsData";
            this.AllClientsData.Size = new System.Drawing.Size(864, 363);
            this.AllClientsData.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            this.Column2.Width = 67;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Телефон";
            this.Column6.Name = "Column6";
            this.Column6.Width = 93;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Почта";
            this.Column5.Name = "Column5";
            this.Column5.Width = 74;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Паспорт";
            this.Column7.Name = "Column7";
            this.Column7.Width = 89;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Адрес";
            this.Column4.Name = "Column4";
            this.Column4.Width = 73;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата рождения";
            this.Column3.Name = "Column3";
            this.Column3.Width = 124;
            // 
            // AddingClient
            // 
            this.AddingClient.Location = new System.Drawing.Point(14, 12);
            this.AddingClient.Name = "AddingClient";
            this.AddingClient.Size = new System.Drawing.Size(154, 33);
            this.AddingClient.TabIndex = 6;
            this.AddingClient.Text = "Добавить клиента";
            this.AddingClient.UseVisualStyleBackColor = true;
            this.AddingClient.Click += new System.EventHandler(this.AddingClientClick);
            // 
            // AllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 428);
            this.Controls.Add(this.AddingClient);
            this.Controls.Add(this.AllClientsData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllClients";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.AllClientsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView AllClientsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button AddingClient;
    }
}
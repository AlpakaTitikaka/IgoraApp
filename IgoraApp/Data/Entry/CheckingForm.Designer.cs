namespace IgoraApp.Data.Entry
{
    partial class CheckingForm
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
            this.CaptchaPicture = new System.Windows.Forms.PictureBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.UpdatePicture = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.IncorrectAuthorization = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptchaPicture
            // 
            this.CaptchaPicture.Location = new System.Drawing.Point(17, 16);
            this.CaptchaPicture.Margin = new System.Windows.Forms.Padding(4);
            this.CaptchaPicture.Name = "CaptchaPicture";
            this.CaptchaPicture.Size = new System.Drawing.Size(179, 108);
            this.CaptchaPicture.TabIndex = 0;
            this.CaptchaPicture.TabStop = false;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(204, 26);
            this.Answer.Margin = new System.Windows.Forms.Padding(4);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(136, 23);
            this.Answer.TabIndex = 1;
            // 
            // UpdatePicture
            // 
            this.UpdatePicture.Location = new System.Drawing.Point(204, 57);
            this.UpdatePicture.Margin = new System.Windows.Forms.Padding(4);
            this.UpdatePicture.Name = "UpdatePicture";
            this.UpdatePicture.Size = new System.Drawing.Size(136, 28);
            this.UpdatePicture.TabIndex = 2;
            this.UpdatePicture.Text = "Обновить";
            this.UpdatePicture.UseVisualStyleBackColor = true;
            this.UpdatePicture.Click += new System.EventHandler(this.CheckUserLoad);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(204, 96);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(136, 28);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "ОК";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButtonClick);
            // 
            // IncorrectAuthorization
            // 
            this.IncorrectAuthorization.Interval = 1000;
            this.IncorrectAuthorization.Tick += new System.EventHandler(this.IncorrectAuthorizationTick);
            // 
            // CheckingForm
            // 
            this.AcceptButton = this.CheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 147);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.UpdatePicture);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.CaptchaPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckingFormFormClosing);
            this.Load += new System.EventHandler(this.CheckUserLoad);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CaptchaPicture;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Button UpdatePicture;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Timer IncorrectAuthorization;
    }
}
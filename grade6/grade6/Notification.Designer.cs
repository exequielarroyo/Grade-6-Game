namespace grade6
{
    partial class Notification
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblMsg = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.Xbtn = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Axiforma", 8F);
            this.lblMsg.Location = new System.Drawing.Point(54, 26);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(152, 17);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "you unlock a hidden video";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = global::grade6.Properties.Resources.unlock_53px;
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton2.Location = new System.Drawing.Point(12, 20);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(30, 30);
            this.gunaImageButton2.TabIndex = 2;
            // 
            // Xbtn
            // 
            this.Xbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Xbtn.Image = global::grade6.Properties.Resources.logout_rounded_left_48px;
            this.Xbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.Xbtn.Location = new System.Drawing.Point(214, 20);
            this.Xbtn.Name = "Xbtn";
            this.Xbtn.OnHoverImage = null;
            this.Xbtn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Xbtn.Size = new System.Drawing.Size(30, 30);
            this.Xbtn.TabIndex = 1;
            this.Xbtn.Click += new System.EventHandler(this.Xbtn_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(256, 72);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.Xbtn);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton Xbtn;
        private Guna.UI.WinForms.GunaLabel lblMsg;
        private System.Windows.Forms.Timer timer1;
    }
}
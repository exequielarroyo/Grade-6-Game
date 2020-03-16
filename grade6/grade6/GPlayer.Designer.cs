namespace grade6
{
    partial class GPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPlayer));
            this.flashPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.backButton = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // flashPlayer
            // 
            this.flashPlayer.Enabled = true;
            this.flashPlayer.Location = new System.Drawing.Point(48, 52);
            this.flashPlayer.Name = "flashPlayer";
            this.flashPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashPlayer.OcxState")));
            this.flashPlayer.Size = new System.Drawing.Size(485, 406);
            this.flashPlayer.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.AnimationHoverSpeed = 0.07F;
            this.backButton.AnimationSpeed = 0.03F;
            this.backButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.backButton.BorderColor = System.Drawing.Color.Black;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backButton.FocusedColor = System.Drawing.Color.Empty;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = global::grade6.Properties.Resources.go_back_48px;
            this.backButton.ImageSize = new System.Drawing.Size(50, 50);
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.backButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backButton.OnHoverForeColor = System.Drawing.Color.White;
            this.backButton.OnHoverImage = null;
            this.backButton.OnPressedColor = System.Drawing.Color.Black;
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 3;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.flashPlayer);
            this.Name = "GPlayer";
            this.Size = new System.Drawing.Size(588, 541);
            ((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxShockwaveFlashObjects.AxShockwaveFlash flashPlayer;
        private Guna.UI.WinForms.GunaCircleButton backButton;
    }
}

namespace grade6
{
    partial class VideoLearn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoLearn));
            this.fullButton = new Guna.UI.WinForms.GunaCircleButton();
            this.backButton = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // fullButton
            // 
            this.fullButton.Animated = true;
            this.fullButton.AnimationHoverSpeed = 0.5F;
            this.fullButton.AnimationSpeed = 0.5F;
            this.fullButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.fullButton.BorderColor = System.Drawing.Color.Black;
            this.fullButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fullButton.FocusedColor = System.Drawing.Color.Empty;
            this.fullButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullButton.ForeColor = System.Drawing.Color.White;
            this.fullButton.Image = global::grade6.Properties.Resources.full_screen_48px;
            this.fullButton.ImageSize = new System.Drawing.Size(30, 30);
            this.fullButton.Location = new System.Drawing.Point(440, 376);
            this.fullButton.Name = "fullButton";
            this.fullButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.fullButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fullButton.OnHoverForeColor = System.Drawing.Color.White;
            this.fullButton.OnHoverImage = null;
            this.fullButton.OnPressedColor = System.Drawing.Color.Black;
            this.fullButton.Size = new System.Drawing.Size(50, 50);
            this.fullButton.TabIndex = 3;
            this.fullButton.Click += new System.EventHandler(this.fullButton_Click);
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
            this.backButton.Location = new System.Drawing.Point(16, 17);
            this.backButton.Name = "backButton";
            this.backButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.backButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backButton.OnHoverForeColor = System.Drawing.Color.White;
            this.backButton.OnHoverImage = null;
            this.backButton.OnPressedColor = System.Drawing.Color.Black;
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 2;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.Animated = true;
            this.gunaCircleButton1.AnimationHoverSpeed = 0.5F;
            this.gunaCircleButton1.AnimationSpeed = 0.5F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::grade6.Properties.Resources.play_button_circled_96px;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(120, 120);
            this.gunaCircleButton1.Location = new System.Drawing.Point(232, 376);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(120, 120);
            this.gunaCircleButton1.TabIndex = 1;
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this.gunaElipsePanel1;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.player);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(72, 98);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 15;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(418, 235);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(418, 235);
            this.player.TabIndex = 0;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Axiforma", 8F);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(101, 50);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(15, 20, 3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 17);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // VideoLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.fullButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.gunaCircleButton1);
            this.Name = "VideoLearn";
            this.Size = new System.Drawing.Size(588, 541);
            this.Load += new System.EventHandler(this.VideoLearn_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaCircleButton backButton;
        private Guna.UI.WinForms.GunaCircleButton fullButton;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public Guna.UI.WinForms.GunaLabel titleLabel;
    }
}

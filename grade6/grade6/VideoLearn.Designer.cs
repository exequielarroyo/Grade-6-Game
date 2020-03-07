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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.stopButton = new Guna.UI.WinForms.GunaCircleButton();
            this.fullButton = new Guna.UI.WinForms.GunaCircleButton();
            this.backButton = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this.gunaElipsePanel1;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.label);
            this.gunaElipsePanel1.Controls.Add(this.player);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(27, 91);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 15;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(534, 300);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Black;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Axiforma", 15F);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(20, 248);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 32);
            this.label.TabIndex = 12;
            this.label.Text = "Video title";
            this.label.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
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
            this.titleLabel.TextChanged += new System.EventHandler(this.titleLabel_TextChanged);
            // 
            // stopButton
            // 
            this.stopButton.Animated = true;
            this.stopButton.AnimationHoverSpeed = 0.5F;
            this.stopButton.AnimationSpeed = 0.5F;
            this.stopButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.stopButton.BorderColor = System.Drawing.Color.Black;
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopButton.FocusedColor = System.Drawing.Color.Empty;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Image = global::grade6.Properties.Resources.stop_52px;
            this.stopButton.ImageSize = new System.Drawing.Size(30, 30);
            this.stopButton.Location = new System.Drawing.Point(176, 419);
            this.stopButton.Name = "stopButton";
            this.stopButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.stopButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.stopButton.OnHoverForeColor = System.Drawing.Color.White;
            this.stopButton.OnHoverImage = null;
            this.stopButton.OnPressedColor = System.Drawing.Color.Black;
            this.stopButton.Size = new System.Drawing.Size(50, 50);
            this.stopButton.TabIndex = 12;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
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
            this.fullButton.Location = new System.Drawing.Point(358, 419);
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
            this.gunaCircleButton1.Location = new System.Drawing.Point(232, 397);
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
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.5F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.2F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedImage = global::grade6.Properties.Resources.add_user_male_52px;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Axiforma", 7F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Image = global::grade6.Properties.Resources.add_user_male_52px;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(475, 493);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(106)))));
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(96, 34);
            this.gunaAdvenceButton1.TabIndex = 13;
            this.gunaAdvenceButton1.Text = "ADD USER";
            this.gunaAdvenceButton1.TextOffsetX = 3;
            this.gunaAdvenceButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Margin = new System.Windows.Forms.Padding(0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(534, 300);
            this.player.TabIndex = 0;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            
            // 
            // VideoLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.fullButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.gunaCircleButton1);
            this.Name = "VideoLearn";
            this.Size = new System.Drawing.Size(588, 541);
            this.Load += new System.EventHandler(this.VideoLearn_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaCircleButton backButton;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public Guna.UI.WinForms.GunaLabel titleLabel;
        public Guna.UI.WinForms.GunaCircleButton fullButton;
        public Guna.UI.WinForms.GunaLabel label;
        public Guna.UI.WinForms.GunaCircleButton stopButton;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}

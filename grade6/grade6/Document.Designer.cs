namespace grade6
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.titleLabe = new Guna.UI.WinForms.GunaLabel();
            this.aboutLabel = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backButton = new Guna.UI.WinForms.GunaCircleButton();
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.aboutShadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.gameTitleLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.elements = new System.Windows.Forms.FlowLayoutPanel();
            this.doneButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.aboutShadowPanel.SuspendLayout();
            this.elements.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabe
            // 
            this.titleLabe.AutoSize = true;
            this.titleLabe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabe.Font = new System.Drawing.Font("Google Sans", 15F, System.Drawing.FontStyle.Bold);
            this.titleLabe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.titleLabe.Location = new System.Drawing.Point(3, 0);
            this.titleLabe.Name = "titleLabe";
            this.titleLabe.Size = new System.Drawing.Size(102, 25);
            this.titleLabe.TabIndex = 0;
            this.titleLabe.Text = "title label";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutLabel.Font = new System.Drawing.Font("Google Sans", 12F);
            this.aboutLabel.ForeColor = System.Drawing.Color.White;
            this.aboutLabel.Location = new System.Drawing.Point(10, 10);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(10);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(92, 20);
            this.aboutLabel.TabIndex = 14;
            this.aboutLabel.Text = "About label";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.aboutLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 300);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Axiforma", 8F);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(71, 20);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(15, 20, 3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 17);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.titleLabel.TextChanged += new System.EventHandler(this.titleLabel_TextChanged);
            // 
            // aboutShadowPanel
            // 
            this.aboutShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.aboutShadowPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.aboutShadowPanel.Controls.Add(this.flowLayoutPanel1);
            this.aboutShadowPanel.Location = new System.Drawing.Point(3, 111);
            this.aboutShadowPanel.Name = "aboutShadowPanel";
            this.aboutShadowPanel.Radius = 5;
            this.aboutShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(76)))), ((int)(((byte)(110)))));
            this.aboutShadowPanel.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.aboutShadowPanel.Size = new System.Drawing.Size(556, 300);
            this.aboutShadowPanel.TabIndex = 13;
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameTitleLabel.Font = new System.Drawing.Font("Google Sans", 7F);
            this.gameTitleLabel.ForeColor = System.Drawing.Color.Gray;
            this.gameTitleLabel.Location = new System.Drawing.Point(111, 0);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(53, 13);
            this.gameTitleLabel.TabIndex = 1;
            this.gameTitleLabel.Text = "game title";
            this.gameTitleLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaLabel1.Font = new System.Drawing.Font("Google Sans", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(556, 54);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = resources.GetString("gunaLabel1.Text");
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(3, 82);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(556, 23);
            this.gunaSeparator1.TabIndex = 14;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 100;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(567, 53);
            this.gunaVScrollBar1.Maximum = 700;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(20, 480);
            this.gunaVScrollBar1.TabIndex = 15;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            this.gunaVScrollBar1.ThumbSize = 300;
            this.gunaVScrollBar1.ValueChanged += new Guna.UI.WinForms.GunaVScrollBar.ScrollValueChangedDelegate(this.gunaVScrollBar1_ValueChanged);
            // 
            // elements
            // 
            this.elements.AutoScroll = true;
            this.elements.Controls.Add(this.titleLabe);
            this.elements.Controls.Add(this.gameTitleLabel);
            this.elements.Controls.Add(this.gunaLabel1);
            this.elements.Controls.Add(this.gunaSeparator1);
            this.elements.Controls.Add(this.aboutShadowPanel);
            this.elements.Location = new System.Drawing.Point(3, 59);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(582, 474);
            this.elements.TabIndex = 16;
            // 
            // doneButton
            // 
            this.doneButton.Animated = true;
            this.doneButton.AnimationHoverSpeed = 0.5F;
            this.doneButton.AnimationSpeed = 0.2F;
            this.doneButton.BackColor = System.Drawing.Color.Transparent;
            this.doneButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.doneButton.BorderColor = System.Drawing.Color.Black;
            this.doneButton.BorderSize = 1;
            this.doneButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton;
            this.doneButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.doneButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.doneButton.CheckedForeColor = System.Drawing.Color.Black;
            this.doneButton.CheckedImage = global::grade6.Properties.Resources.checked_checkbox_60px;
            this.doneButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.doneButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.doneButton.FocusedColor = System.Drawing.Color.Empty;
            this.doneButton.Font = new System.Drawing.Font("Axiforma", 7F);
            this.doneButton.ForeColor = System.Drawing.Color.Black;
            this.doneButton.Image = global::grade6.Properties.Resources.checkmark_48px;
            this.doneButton.ImageSize = new System.Drawing.Size(15, 15);
            this.doneButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.doneButton.Location = new System.Drawing.Point(465, 483);
            this.doneButton.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            this.doneButton.Name = "doneButton";
            this.doneButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.doneButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.doneButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.doneButton.OnHoverImage = null;
            this.doneButton.OnHoverLineColor = System.Drawing.Color.Black;
            this.doneButton.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(106)))));
            this.doneButton.Radius = 10;
            this.doneButton.Size = new System.Drawing.Size(96, 34);
            this.doneButton.TabIndex = 17;
            this.doneButton.Text = "DONE";
            this.doneButton.TextOffsetX = 3;
            this.doneButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.elements);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backButton);
            this.Name = "Document";
            this.Size = new System.Drawing.Size(588, 541);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.aboutShadowPanel.ResumeLayout(false);
            this.elements.ResumeLayout(false);
            this.elements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleButton backButton;
        public Guna.UI.WinForms.GunaLabel titleLabel;
        public Guna.UI.WinForms.GunaLabel gameTitleLabel;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Guna.UI.WinForms.GunaShadowPanel aboutShadowPanel;
        public Guna.UI.WinForms.GunaLabel titleLabe;
        public Guna.UI.WinForms.GunaLabel aboutLabel;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel elements;
        private Guna.UI.WinForms.GunaAdvenceButton doneButton;
    }
}

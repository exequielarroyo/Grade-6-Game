namespace grade6
{
    partial class LoadingScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadingBar = new Guna.UI.WinForms.GunaProgressBar();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadingBar
            // 
            this.loadingBar.BackColor = System.Drawing.Color.Transparent;
            this.loadingBar.BorderColor = System.Drawing.Color.Black;
            this.loadingBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.loadingBar.IdleColor = System.Drawing.Color.Gainsboro;
            this.loadingBar.Location = new System.Drawing.Point(306, 437);
            this.loadingBar.Maximum = 500;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.loadingBar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.loadingBar.Size = new System.Drawing.Size(382, 13);
            this.loadingBar.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Axiforma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(421, 417);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(169, 17);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "D e v e l o p   b y   T o r a h   C.";
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Image = global::grade6.Properties.Resources._2Asset_1;
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(368, 205);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(269, 209);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaTransfarantPictureBox2.TabIndex = 3;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaTransfarantPictureBox1.Image = global::grade6.Properties.Resources.mountain_1;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaTransfarantPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(791, 541);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 0;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaTransfarantPictureBox2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Name = "LoadingScreen";
            this.Size = new System.Drawing.Size(791, 541);
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaProgressBar loadingBar;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
    }
}

namespace grade6
{
    partial class Games
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
            this.gProducerCnsumer1 = new grade6.GProducerCnsumer();
            this.SuspendLayout();
            // 
            // gProducerCnsumer1
            // 
            this.gProducerCnsumer1.Location = new System.Drawing.Point(0, 0);
            this.gProducerCnsumer1.Name = "gProducerCnsumer1";
            this.gProducerCnsumer1.Size = new System.Drawing.Size(588, 541);
            this.gProducerCnsumer1.TabIndex = 0;
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gProducerCnsumer1);
            this.Name = "Games";
            this.Size = new System.Drawing.Size(588, 541);
            this.ResumeLayout(false);

        }

        #endregion

        private GProducerCnsumer gProducerCnsumer1;
    }
}

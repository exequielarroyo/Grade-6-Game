﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade6
{
    public partial class Document : UserControl
    {
        public Document()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void gunaVScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            elements.AutoScrollPosition = new Point(0, gunaVScrollBar1.Value);
        }
    }
}

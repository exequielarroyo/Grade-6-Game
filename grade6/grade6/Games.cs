using System;
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
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            listGames.BringToFront();
            gunaVScrollBar1.BringToFront();
        }

        private void producerConsumer_Click(object sender, EventArgs e)
        {
            gProducerCnsumer1.BringToFront();
        }

        private void foodChain_Click(object sender, EventArgs e)
        {
            gFoodChain1.BringToFront();
        }

        private void gunaVScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            listGames.AutoScrollPosition = new Point(0, gunaVScrollBar1.Value);
        }
    }
}

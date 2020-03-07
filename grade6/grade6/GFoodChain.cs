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
    public partial class GFoodChain : UserControl
    {
        public GFoodChain()
        {
            InitializeComponent();
        }

        private void GFoodChain_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(grass, true);
            ControlExtension.Draggable(rabit, true);
            ControlExtension.Draggable(wolf, true);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}

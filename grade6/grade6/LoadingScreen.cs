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
    public partial class LoadingScreen : UserControl
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingBar.Value += 1;
            if (loadingBar.Value >= 500)
            {
                timer1.Stop();
                this.Hide();
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Question : UserControl
    {
        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {
            VideoLearn videoLearn = new VideoLearn();
            if (videoLearn.titleLabel.Text == "Food Chain")
            {
                questionLabel.Text = "aw";
                ans1.Text = "";
                ans2.Text = "";
                ans3.Text = "";
                ans4.Text = "";
            }
            
        }
    }
}

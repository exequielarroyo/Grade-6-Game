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

        public static bool foodChain = false;
        public static bool foodweb = false;
        public static bool herbivoreAnimals = false;
        public static bool carnivoreAnimals = false;
        public static bool omnivoreAnimals = false;
        public static bool producer = false;
        public static bool decomposer = false;

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (titleLabel.Text == "Herbivore Animals")
            {
                if (herbivoreAnimals == false)
                    herbivoreAnimals = true;
                else
                    herbivoreAnimals = false;
            }
            else if (titleLabel.Text == "Carnivore Animals")
            {
                if (carnivoreAnimals == false)
                    carnivoreAnimals = true;
                else
                    carnivoreAnimals = false;
            }
            else if (titleLabel.Text == "Omnivore Animals")
            {
                if (omnivoreAnimals == false)
                    omnivoreAnimals = true;
                else
                    omnivoreAnimals = false;
            }
        }

        private void titleLabel_TextChanged(object sender, EventArgs e)
        {
            Learn learn = new Learn();
            if (titleLabel.Text == "Herbivore Animals")
            {
                if (herbivoreAnimals == false)
                    doneButton.Checked = false;
                else if (herbivoreAnimals == true)
                    doneButton.Checked = true;
            }
            else if (titleLabel.Text == "Carnivore Animals")
            {
                if (carnivoreAnimals == false)
                    doneButton.Checked = false;
                else if (carnivoreAnimals == true)
                    doneButton.Checked = true;
            }
            else if (titleLabel.Text == "Omnivore Animals")
            {
                if (omnivoreAnimals == false)
                    doneButton.Checked = false;
                else if (omnivoreAnimals == true)
                    doneButton.Checked = true;
            }
            
            Refresh();
        }
    }
}

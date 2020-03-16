using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade6
{
    public class GamesClass
    {
        public static bool foodChain = true;
        public static bool foodweb = false;
        public static bool herbivoreAnimals = false;
        public static bool carnivoreAnimals = false;
        public static bool omnivoreAnimals = false;
        public static bool producer = false;
        public static bool decomposer = false;

        public static void Reload()
        {
            Games games = new Games();

            if (VideoLearn.foodChain == false)
            {
                games.foodChain.BaseColor = Color.FromArgb(148, 130, 219);
                games.foodChain.Enabled = false;
                games.title.Enabled = false;
                games.subtitle.Enabled = false;
                games.picture.Enabled = false;
            }
            else if (VideoLearn.foodChain == true)
            {
                games.foodChain.Enabled = true;
                games.title.Enabled = true;
                games.subtitle.Enabled = true;
                games.picture.Enabled = true;
            }
            if (VideoLearn.foodweb == false)
            {
                games.foodwebPanel.BaseColor = Color.FromArgb(148, 130, 219);
                games.title2.Enabled = false;
                games.subtitle2.Enabled = false;
                games.picture2.Enabled = false;
            }
            if (VideoLearn.herbivoreAnimals == false)
            {
                games.herbivorePanel.BaseColor = Color.FromArgb(148, 130, 219);
                games.title3.Enabled = false;
                games.subtitle3.Enabled = false;
                games.picture3.Enabled = false;
            }
            if (VideoLearn.carnivoreAnimals == false)
            {
                games.carnivorePanel.BaseColor = Color.FromArgb(148, 130, 219);
                games.title4.Enabled = false;
                games.subtitle4.Enabled = false;
                games.picture4.Enabled = false;
            }
            if (VideoLearn.omnivoreAnimals == false)
            {
                games.omnivorePanel.BaseColor = Color.FromArgb(148, 130, 219);
                games.title5.Enabled = false;
                games.subtitle5.Enabled = false;
                games.picture5.Enabled = false;
            }
            if (VideoLearn.producer == false)
            {
                games.producerConsumer.BaseColor = Color.FromArgb(148, 130, 219);
                games.title6.Enabled = false;
                games.subtitle6.Enabled = false;
                games.picture6.Enabled = false;
            }
            if (VideoLearn.decomposer == false)
            {
                games.decomposerPanel.BaseColor = Color.FromArgb(148, 130, 219);
                games.title7.Enabled = false;
                games.subtitle7.Enabled = false;
                games.picture7.Enabled = false;
            }
        }
    }
}

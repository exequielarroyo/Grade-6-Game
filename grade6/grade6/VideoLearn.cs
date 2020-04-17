using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace grade6
{
    public partial class VideoLearn : UserControl
    {

        public VideoLearn()
        {
            InitializeComponent();
        }

        private void VideoLearn_Load(object sender, EventArgs e)
        {
            learn.BringToFront();


        }
        public static bool foodChain = false;
        public static bool foodweb = false;
        public static bool herbivoreAnimals = false;
        public static bool carnivoreAnimals = false;
        public static bool omnivoreAnimals = false;
        public static bool producer = false;
        public static bool decomposer = false;

        public void Alert(string msg, Notification.enmType type)
        {
            Notification frm = new Notification();
            frm.showAlert(msg, type);
        }

        //public SoundPlayer lessonComplete = new SoundPlayer(Properties.Resources.com);

        private void doneButton_Click(object sender, EventArgs e)
        {

            if (titleLabel.Text == "Food Chain")
            {
                //lessonComplete.Play();

                if (foodChain == false)
                {
                    foodChain = true;
                    this.Alert("Play \"Arrange the food chain\" in GAMES.", Notification.enmType.Success);
                }
                else
                    foodChain = false;
            }
            else if (titleLabel.Text == "Food Web")
            {
                if (foodweb == false)
                {
                    foodweb = true;
                    this.Alert("Play \"Identify the organism\" in GAMES.", Notification.enmType.Success);
                }
                else
                    foodweb = false;
            }
            else if (titleLabel.Text == "Producer and Consumer")
            {
                if (producer == false)
                {
                    producer = true;
                    this.Alert("Play \"Puzzle game\" in GAMES.", Notification.enmType.Success);
                }
                else
                    producer = false;
            }
            else if (titleLabel.Text == "Decomposer")
            {
                if (decomposer == false)
                {
                    decomposer = true;
                    this.Alert("Play \"Tap tap tap!\" in GAMES.", Notification.enmType.Success);
                }
                else
                    decomposer = false;
            }
            else if (titleLabel.Text == "Herbivore Animals")
            {
                if (herbivoreAnimals == false)
                {
                    herbivoreAnimals = true;
                    this.Alert("Play \"Swipe to go away!\" in GAMES.", Notification.enmType.Success);
                }
                else
                    herbivoreAnimals = false;
            }
            else if (titleLabel.Text == "Carnivore Animals")
            {
                if (carnivoreAnimals == false)
                {
                    carnivoreAnimals = true;
                    this.Alert("Play \"Catch the egg\" in GAMES.", Notification.enmType.Success);
                }
                else
                    carnivoreAnimals = false;
            }
            else if (titleLabel.Text == "Omnivore Animals")
            {
                if (omnivoreAnimals == false)
                {
                    omnivoreAnimals = true;
                    this.Alert("Play \"Identify me!\" in GAMES.", Notification.enmType.Success);
                }
                else
                    omnivoreAnimals = false;
            }
            else if (titleLabel.Text == "Producer and Consumer")
            {
                if (omnivoreAnimals == false)
                {
                    omnivoreAnimals = true;
                    this.Alert("Play \"Puzzle game\" in GAMES.", Notification.enmType.Success);
                }
                else
                    producer = false;
            }
        }

        public static bool isPlay = false;
        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (isPlay == false)
            {
                player.Ctlcontrols.play();
                gunaCircleButton1.Image = Properties.Resources.pause_button_100px;
                isPlay = true;
            }
            else if (isPlay)
            {
                player.Ctlcontrols.pause();
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
            }
        }

        public SoundPlayer click = new SoundPlayer(Properties.Resources.click2);
        private void backButton_Click(object sender, EventArgs e)
        {
            click.Play();
            switch (titleLabel.Text)
            {
                case "Food Chain":
                    if (foodChain.Equals(false))
                    {
                        exit_Click(sender, e);
                        circleProgress.Value = 0;
                    }
                    break;
                case "Food Web":
                    if (foodweb.Equals(false))
                    {
                        exit_Click(sender, e);
                        circleProgress.Value = 0;
                    }
                    break;
                case "Herbivore Animals":
                    if (herbivoreAnimals.Equals(false))
                    {
                        exit_Click(sender, e);
                        circleProgress.Value = 0;
                    }
                    break;
                case "Carnivore Animals":
                    if (carnivoreAnimals.Equals(false))
                    {
                        exit_Click(sender, e);
                        circleProgress.Value = 0;
                    }
                    break;
                case "Omnivore Animals":
                    if (omnivoreAnimals.Equals(false))
                    {
                        exit_Click(sender, e);
                        circleProgress.Value = 0;
                    }
                    break;
                case "Producer and Consumer":
                    if (producer.Equals(false))
                    {
                        exit_Click(sender, e);
                        circleProgress.Value = 0;
                    }
                    break;
                case "Decomposer":
                    if (decomposer.Equals(false))
                    {
                        exit_Click(sender, e);
                        circleProgress.Value = 0;
                    }
                    break;
            }


            gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
            isPlay = false;
            this.SendToBack();
            finishPanel.SendToBack();
            player.Ctlcontrols.stop();
        }

        public void fullButton_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.fullScreen = true;
            }
        }

        public void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                gunaCircleButton1.Image = Properties.Resources.pause_button_100px;
                isPlay = true;
                label.Visible = false;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
                label.Visible = true;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
            }
        }

        private void titleLabel_TextChanged(object sender, EventArgs e)
        {
            if (titleLabel.Text == "Why Meat is the Best Worst Thing in the World 🍔")
            {
                videoPlayer.BringToFront();
            }
            if (titleLabel.Text == "Food Chain")
            {
                subtitle1.Text = "The Food Chain " + "\n" + "Every living thing needs energy in order to live. Everytime animals do something(run, jump) they use energy to do so.";
                subtitle2.Text = "Animals get energy from the food they eat, and all living things get energy from food. Plants use sunlight, water and nutrients to get energy (in a process called photosynthesis). Energy is necessary for living beings to grow.";
                subtitle3.Text = "A food chain shows how each living thing gets food, and how nutrients and energy are passed from creature to creature. Food chains begin with plant-life, and end with animal-life. Some animals eat plants, some animals eat other animals.";
                subtitle4.Text = "A simple food chain could start with grass, which is eaten by rabbits. Then the rabbits are eaten by foxes.";
                subtitle5.Text = "Bigger Food Chains " + "\n\n" + "Here's another food chain, with a few more animals. It starts with acorns, which are eaten by mice. The mice are eaten by snakes, and then finally the snakes are eaten by hawks. At each link in the chain, energy is being transferred from one animal to another.";
                subtitle6.Text = "There can be even more links to any food chain. Here another animal is added. It goes" + "\n\n" + "Grass to grasshopper to mouse to snake to hawk.";
                subtitle7.Text = "There is actually even more to this chain. After a hawk dies, fungi (like mushrooms) and other decomposers break down the dead hawk, and turn the remains of the hawk into nutrients, which are released into the soil. The nutrients (plus sun and water) then cause the grass to grow." + "\n" + "It's a full circle of life and energy!!";
                subtitle8.Text = "So food chains make a full circle, and energy is passed from plant to animal to animal to decomposer and back to plant! There can be many links in food chains but not TOO many. If there are too many links, then the animal at the end would not get enough energy.";
                picture1.Image = Properties.Resources.cateat;
                picture2.Image = Properties.Resources.producer2;
                picture3.Image = Properties.Resources.simplechain;
                picture4.Image = Properties.Resources.button_bigchain2;
                picture5.Image = Properties.Resources.simplechain2;
                picture6.Image = Properties.Resources.simplechain3;
                picture7.Image = Properties.Resources.fullchain;
                picture8.Image = Properties.Resources.fullchain;
                if (foodChain == false)
                {
                    doneButton.Checked = false;
                    circleProgress.Value = 0;
                }
                else if (foodChain == true)
                {
                    doneButton.Checked = true;
                    circleProgress.Value = 100;
                }
            }
            else if (titleLabel.Text == "Food Web")
            {
                subtitle1.Text = "Food Web" + "\n" + "In any ecosystem there are many food chains and, generally, most plants and animals are part of several chains.When you draw all the chains together you end up with a food web.";
                subtitle2.Text = "Most organisms can eat, and be eaten, by many different animals. A food chain wouldn’t be able to show this. Food webs show all these connections. They are more complicated but more accurate.";
                subtitle3.Text = "In the African savannah food web shown here, we can see multiple arrows pointing to different animals. The arrows show the direction the energy is transferred. For example, we can see that zebras eat trees and grasses, so arrows from trees and grasses are pointing to a zebra.";
                subtitle4.Text = "The lions are at the top of the food web, which means they are not eaten by any other type of animal (except by decomposers when it dies).  We call this an apex predator.";
                subtitle5.Text = "Apex predators have big effects on the animals and plants lower down the food chain. If they become extinct in an area, many changes happen. In recent times, it is often humans who have removed top predators.";
                subtitle6.Text = "For example, a tree produces acorns - this is called the producer. Mice, squirrels, and insects eat these acorns and because there are many mice, the weasels, snakes and raccoons have food. With insects in the acorns, other predators would be attracted (like skunks or opossums) and therefore, foxes, hawks or owls could all find food.";
                subtitle7.Text = "Food webs can be effected in many ways considering the urban areas of major countries are taking no action and care. It uses arrows to show the energy relationships among organisms";
                subtitle8.Text = "What can affect a food web?" + "\n" + "Human Impacts" + "\n" + "Overfishing, introduction of non-native species, and bioaccumulation are just a few examples of how humans impact aquatic food webs. Example: Bioaccumulation Pollution can accumulate from species to species, moving up the food chain until it eventually affects the whole food web.";
                picture1.Image = Properties.Resources.foodweb1;
                picture2.Image = Properties.Resources.foodweb2;
                picture3.Image = Properties.Resources.foodweb3;
                picture4.Image = Properties.Resources.foodweb4;
                picture5.Image = Properties.Resources.foodweb5;
                picture6.Image = null;
                picture7.Image = Properties.Resources.herbivore66;
                picture8.Image = Properties.Resources.foodweb8;
                if (foodweb == false)
                {
                    doneButton.Checked = false;
                    circleProgress.Value = 0;
                }
                else if (foodweb == true)
                {
                    doneButton.Checked = true;
                    circleProgress.Value = 100;
                }
            }
            else if (titleLabel.Text == "Producer and Consumer")
            {
                subtitle1.Text = "Plants are called producers. This is because they produce their own food! They do this by using light energy from the Sun, carbon dioxide from the air and water from the soil to produce food - in the form of glucouse/sugar." + "\n" + "The process is called photosynthesis.";
                subtitle2.Text = "The cycle of plants and how they make energy! The sun(light energy), water, minerals and carbon dioxide are all absorbed by the plant. The plant then uses them to make glucose/sugar, which is the energy/food for the plant. Oxygen is also produced by the plant in this cycle, which is then let off into the air.";
                subtitle3.Text = "Consumers" + "\n" + "Animals are called consumers. This is because they cannot make their own food, so they need to consume (eat) plants and/or animals." + "\n" + "There are three (3) groups of Consumer:";
                subtitle4.Text = "Producers and consumers" + "\n" + "A food chain always starts with a producer, an organism that makes food. This is usually a green plant, because plants can make their own food by photosynthesis." + "\n" + "A food chain ends with a consumer, an animal that eats a plant or another animal.";
                subtitle5.Text = "The producers generate food for themselves and others; consumers do not produce anything, instead eating producers, other consumers or both. " + "\n" + "Organisms that eat only producers (i.e., plants) are called herbivores. Animals that eat only consumers (i.e., meat) are called carnivores. Animals such as as humans that usually have diets rich in both plants and animal sources are known as omnivores.";
                subtitle6.Text = "Producer Essentials" + "\n" + "Producers are green plants. Producers' biology allows plants to manufacture their own food through a process called photosynthesis which results in glucose production, some of which plants use themselves in growth and other metabolic activities but most of which serves as food for consumers or simply decays when the plant dies.";
                subtitle7.Text = "Consumer Essentials" + "\n" + "Consumer biology means that they cannot make their own food and must eat other organisms for nourishment." + "\n" + "An example containing all of these types of consumers would be a forest that included birds that are strictly carnivores, deer that are herbivores and bears that are omnivores.";
                subtitle8.Text = "Levels of Consumers" + "\n" + "Consumers occupy different levels within food webs or food chains. In simplest terms, primary consumers are one level above producers and are the herbivores. Secondary consumers are one level up and eat herbivores; tertiary consumers are one level up still and eat herbivores and secondary consumers.";
                picture1.Image = Properties.Resources.producer1;
                picture2.Image = Properties.Resources.producer2;
                picture3.Image = Properties.Resources.producer3;
                picture4.Image = Properties.Resources.producer4;
                picture5.Image = null;
                picture6.Image = Properties.Resources.producer6;
                picture7.Image = Properties.Resources.producer7;
                picture8.Image = Properties.Resources.carnivore8;
                if (producer == false)
                {
                    doneButton.Checked = false;
                    circleProgress.Value = 0;
                }
                else if (producer == true)
                {
                    doneButton.Checked = true;
                    circleProgress.Value = 100;
                }
            }
            else if (titleLabel.Text == "Decomposer")
            {
                subtitle1.Text = "A decomposer is an organism that decomposes, or breaks down, organic material such as the remains of dead organisms. Decomposers include bacteria and fungi.";
                subtitle2.Text = "Decomposers play an important role in every ecosystem. Without decomposers, dead organisms would not be broken down and recycled into other living matter.";
                subtitle3.Text = "Decomposers can be referred to as nature’s recyclers because they help keep nutrients moving in food webs. If the decomposers did not do their job the producers would not get the nutrients they need and would die.";
                subtitle4.Text = "A dead organism provides nutrients for decomposers like bacteria and fungi to use in order to grow and reproduce, propagating their own species.";
                subtitle5.Text = "When an organism dies and decomposers do the work of decomposition, the organism’s remains go through five stages of decomposition: fresh, bloat, active decay, advanced decay, and dry/remains." + "\n" + "Here is a brief summary of the five stages:";
                subtitle6.Text = "Fresh" + "\n" + "This stage begins as soon as an organism’s heart stops beating. With no more oxygen coming into the body and a buildup of carbon dioxide, autolysis begins to occur. Putrefaction also begins to occur.";
                subtitle7.Text = "Bloat" + "\n" + "Due to putrefaction, a buildup of gases occurs and the organism’s remains appear bloated in what is known as the bloat stage. Some gases and fluids are purged from the body.";
                subtitle8.Text = "Active Decay" + "\n" + "The remains lose mass, and liquefaction and disintegration of tissues begins to occur. Bacteria produce chemicals such as ammonia, hydrogen sulfide, and methane, which cause strong odors." + "\n\n" + "Advanced Decay" + "\n" + "The organism has lost a lot of mass, so there is not much left to be decomposed. If the organism is on or in soil, the surrounding soil will show an increase in nitrogen, an important nutrient for plants.";
                picture1.Image = Properties.Resources.decomposer1;
                picture2.Image = Properties.Resources.decomposer2;
                picture3.Image = Properties.Resources.decomposer3;
                picture4.Image = Properties.Resources.decomposer4;
                picture5.Image = Properties.Resources.decomposer5;
                picture6.Image = Properties.Resources.decomposer6;
                picture7.Image = Properties.Resources.decomposer7;
                picture8.Image = null;
                if (decomposer == false)
                {
                    doneButton.Checked = false;
                    circleProgress.Value = 0;
                }
                else if (decomposer == true)
                {
                    doneButton.Checked = true;
                    circleProgress.Value = 100;
                }
            }
            else if (titleLabel.Text == "Herbivore Animals")
            {
                subtitle1.Text = "A Herbivore is an animal that gets its energy from eating plants, and only plants. Omnivores can also eats parts of plants, but generally only the fruits and vegetable produced by bearing plants.";
                subtitle2.Text = "Buffalo are herbivores, and so eat only vegetation. Their favorite foods are grass and herbs, but water buffalo will also eat aquatic plants. Both African and Asian buffalo will eat shrubs and trees when they can't find grass or herbs to eat.";
                subtitle3.Text = "Type of Herbivores " + "\n" + "There are two categories of Herbivores based on what kind of plant they are eating:" + "\n" + "Frugivores" + "\n" + "Folivores";
                subtitle4.Text = "Frugivores" + "\n" + "is any type of herbivore or omnivore where fruit is a preferred food type. Such an animal thrives mostly on raw fruits, succulent fruit-like vegetables, roots, shoots, nuts and seeds.";
                subtitle5.Text = "Folivores" + "\n" + "A Folivore is a herbivore that specializes in eating leaves. Mature leaves contain a high proportion of hard-to-digest cellulose, less energy than other types of foods, and often toxic compounds.";
                subtitle6.Text = "Some Characteristics of Herbivores" + "\n" + "Some of the herbivore animals have two digestive systems." + "\n" + "Herbivores have high energy demands. If they don’t receive sufficient they simply can’t survive." + "\n" + "Herbivores teeth aren’t as razor edge as carnivores teeths. " + "\n" + "Herbivores have alkaline saliva which means digestion does’nt start promptly.";
                subtitle7.Text = "Herbivores as part of the Food web" + "\n" + "Herbivores are a major part of the food web, a description of which organisms in the wild. Organisms in the food web are grouped into trophic, or nutritional, levels. ";
                subtitle8.Text = "Remember that herbivorous animals are those that feed primarily on plants or algae, not only on grass. They are considered \"primary consumers\" in their food chain.";
                picture1.Image = Properties.Resources.herbivore1;
                picture2.Image = Properties.Resources.herbivore5;
                picture3.Image = Properties.Resources.herbivore2;
                picture4.Image = Properties.Resources.herbivore4;
                picture5.Image = Properties.Resources.herbivore5;
                picture6.Image = null;
                picture7.Image = Properties.Resources.herbivore7;
                picture8.Image = Properties.Resources.herbivore1;
                if (herbivoreAnimals == false)
                {
                    doneButton.Checked = false;
                    circleProgress.Value = 0;
                }
                else if (herbivoreAnimals == true)
                {
                    doneButton.Checked = true;
                    circleProgress.Value = 100;
                }
            }
            else if (titleLabel.Text == "Carnivore Animals")
            {
                subtitle1.Text = "Carnivore animals" + "\n" + "A carnivore is an animal that gets food from killing and eating other animals. Carnivores generally eat herbivores, but can eat omnivores, and occasionally other carnivores.";
                subtitle2.Text = "Carnivorous plants" + "\n" + "Carnivorous plants are plants that derive some or most of their nutrients from trapping and consuming animals or protozoans, typically insects and other arthropods.";
                subtitle3.Text = "Carnivore Types" + "\n" + "There are three different categories of carnivores based on the level of meat consumption: Hypercarnivores, Mesocarnivores, and hypocarnivores.";
                subtitle4.Text = "Few Example of Carnivore Animals:";
                subtitle5.Text = "Hypercarnivores" + "\n" + "Carnivores that eat mostly meat are called Hypercarnivores. These creatures are considered obligate carnivores because they cannot properly digest vegetation and have a diet that consist of atleast 70 percent of meat, according to National Geographic. ";
                subtitle6.Text = "Mesocarnivores" + "\n" + "Animals that depends on meat for atleast 50 percent of their diet are called Mesocarnivores. Along with meat, these animals will also eat fruits, vegetable and fungi. Typically small to mid-sized species and often live close to human population.";
                subtitle7.Text = "Hypocarnivores" + "\n" + "Carnivores that eats least amount of meat less than 30 percent of their diet. These animals which can be considered as Omnivores , eat fish, berries, nuts and roots, as well as meat.";
                subtitle8.Text = "Carnivores as part of the Food web" + "\n" + "Carnivores sit at the third level in the food web, along with Omnivores. Carnivores eat other Carnivores , as well as herbivores and omnivores, depending on their species. Carnivores keep the populations of other animals in check.";
                picture1.Image = Properties.Resources.carnivore1;
                picture2.Image = Properties.Resources.carnivore2;
                picture3.Image = Properties.Resources.carnivore3;
                picture4.Image = Properties.Resources.carnivore4;
                picture5.Image = Properties.Resources.carnivore5;
                picture6.Image = Properties.Resources.carnivore6;
                picture7.Image = Properties.Resources.carnivore7;
                picture8.Image = Properties.Resources.carnivore8;
                if (carnivoreAnimals == false)
                {
                    doneButton.Checked = false;
                    circleProgress.Value = 0;
                }
                else if (carnivoreAnimals == true)
                {
                    doneButton.Checked = true;
                    circleProgress.Value = 100;
                }
            }
            else if (titleLabel.Text == "Omnivore Animals")
            {
                subtitle1.Text = "An omnivore is a kind of animal that eats either other animals or plants. Some omnivores will hunt and eat their food, like  carnivores, eating herbivores and other omnivores. Some others are scavengers and will eat dead matter. Many will eat eggs from other animals.";
                subtitle2.Text = "Omnivores have very distinctive teeth that help with the digestion of their varied diets. They often have long, sharp, pointed teeth to rip and cut meat and flat molars to crush plant material.";
                subtitle3.Text = "Omnivores in the food chain" + "\n" + "Like herbivores and carnivores , omnivores are a very important part of the food chain or web. Omnivores help keep in check both animal populations and vegetation growth.";
                subtitle4.Text = "Bears eat both meat and plant foods; in the spring they eat fish and in the fall they eat berries. One of the best examples of opportunistic eaters is raccoons. Raccoons aren’t very picky eaters; they eat mice, frogs, fish, insects, fruit, vegetables and even garbage.";
                subtitle5.Text = "DIFFERENT SIZES OF OMNIVORE";
                subtitle6.Text = "LARGE OMNIVORE";
                subtitle7.Text = "Medium-sized Omnivores";
                subtitle8.Text = "Small Omnivores";
                picture1.Image = Properties.Resources.ominvore1;
                picture2.Image = Properties.Resources.omnivore2;
                picture3.Image = Properties.Resources.omnivore3;
                picture4.Image = Properties.Resources.omnivore4;
                picture5.Image = Properties.Resources.omnivore5;
                picture6.Image = Properties.Resources.omnivore6;
                picture7.Image = Properties.Resources.omnivore7;
                picture8.Image = Properties.Resources.omnivore8;
                if (omnivoreAnimals == false)
                {
                    doneButton.Checked = false;
                    circleProgress.Value = 0;
                }
                else if (omnivoreAnimals == true)
                {
                    doneButton.Checked = true;
                    circleProgress.Value = 100;
                }
            }
            Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying || player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.stop(); ;
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
                label.Visible = true;
            }
        }

        private void doneButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                circleProgress.Value += 1;
                if (circleProgress.Value == 100)
                {
                    timer1.Stop();
                }
            }
        }

        int scroll = 0;
        bool isFinish = false;
        public void exit_Click(object sender, EventArgs e)
        {
            scroll = 0;
            mainFlowLayout.AutoScrollPosition = new Point(0, scroll);
            progBar.Value = 348;
            if (progBar.Value <= 2748)
            {
                flag.Image = Properties.Resources.flag_2_48px;
                flag.Size = new Size(40, 40);
                isFinish = false;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.complete);

            scroll += 348;
            mainFlowLayout.AutoScrollPosition = new Point(0, scroll);
            progBar.Value += 348;
            if (isFinish)
            {
                finishPanel.BringToFront();
                soundPlayer.Play();
                timer1.Start();
            }
            else if (progBar.Value >= 2748)
            {
                flag.Image = Properties.Resources.flag_2_48pxGreen;
                flag.Size = new Size(40, 40);
                if (isFinish == false)
                    isFinish = true;
            }
        }

        private void play_MouseDown(object sender, MouseEventArgs e)
        {
            start1.BaseColor = Color.FromArgb(72, 170, 123);
            play.BaseColor = Color.FromArgb(85, 198, 144);
        }

        private void play_MouseUp(object sender, MouseEventArgs e)
        {
            play.BaseColor = Color.FromArgb(72, 170, 123);
            start1.BaseColor = Color.FromArgb(85, 198, 144);
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            start1.BaseColor = Color.FromArgb(72, 170, 123);
            play.BaseColor = Color.FromArgb(85, 198, 144);
        }
        private void play_MouseHover(object sender, EventArgs e)
        {
            //speech.Speak("Continue learning");
        }
        private void finishPanel_MouseEnter(object sender, EventArgs e)
        {
            play.BaseColor = Color.FromArgb(72, 170, 123);
            start1.BaseColor = Color.FromArgb(85, 198, 144);
        }

        private void play_Click(object sender, EventArgs e)
        {
            videoPlayer.BringToFront();
        }

        SpeechSynthesizer speech = new SpeechSynthesizer();
        private void subtitle1_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle1.Text);
        }

        private void subtitle2_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle2.Text);
        }

        private void subtitle3_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle3.Text);
        }

        private void subtitle4_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle4.Text);
        }

        private void subtitle5_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle5.Text);
        }

        private void subtitle6_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle6.Text);
        }

        private void subtitle7_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle7.Text);
        }

        private void subtitle8_MouseEnter(object sender, EventArgs e)
        {
            nextButton.Hide();
            speech.Speak(subtitle8.Text);
        }

        private void learn_MouseEnter(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Ready)
            {
                nextButton.Show();
            }
        }

        
    }
}

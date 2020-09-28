using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class HeroForm : Form
    {
        SuperHero newHero;
        public HeroForm()
        {
            InitializeComponent();
            newHero = new SuperHero();
        }

        private int getTotalPhysicalAttrPoints()
        {
            return newHero.strength + newHero.strength + newHero.stamina + newHero.agility + newHero.intellect;
        }

        private void adjustPhysicalAttrPoints(int except)
        {
            // Flag to keep track of if we need to decrement all non-exempt
            //  slider values on an iteration pass
            //  Basically: If one value decrements, the other 3 do to.
            bool decremented = false;
            while (getTotalPhysicalAttrPoints() > 100)
            {
                decremented = false;
                if (except != 0 && newHero.speed > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Speed
                    newHero.speed -= 1;
                    speedScrollBar.Value = newHero.speed;
                    speedValueLabel.Text = String.Format("{0}", newHero.speed);
                    decremented = true;
                }
                if (except != 1 && newHero.strength > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Strength
                    newHero.strength -= 1;
                    strengthScrollBar.Value = newHero.strength;
                    strengthValueLabel.Text = String.Format("{0}", newHero.strength);
                    decremented = true;
                }
                if (except != 2 && newHero.stamina > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Stamina
                    newHero.stamina -= 1;
                    staminaScrollBar.Value = newHero.stamina;
                    staminaValueLabel.Text = String.Format("{0}", newHero.stamina);
                    decremented = true;
                }
                if(except != 3 && newHero.agility > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Agility
                    newHero.agility -= 1;
                    agilityScrollBar.Value = newHero.agility;
                    agilityValueLabel.Text = String.Format("{0}", newHero.agility);
                    decremented = true;
                }
                if(except != 4 && newHero.intellect > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Intellect
                    newHero.intellect -= 1;
                    intellectScrollBar.Value = newHero.intellect;
                    intellectValueLabel.Text = String.Format("{0}", newHero.intellect);
                    decremented = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Open Color Dialog
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
            newHero.suitColor = colorDialog1.Color.Name;
        }
        private void speedScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            speedValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.speed = e.NewValue;

            adjustPhysicalAttrPoints(0);
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
                strengthValueLabel.Text = String.Format("{0}", e.NewValue);
                newHero.strength = e.NewValue;

                adjustPhysicalAttrPoints(1);
        }

        private void staminaScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            staminaValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.stamina = e.NewValue;

            adjustPhysicalAttrPoints(2);
        }

        private void agilityScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            agilityValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.agility = e.NewValue;

            adjustPhysicalAttrPoints(3);
        }

        private void intellectScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            intellectValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.intellect = e.NewValue;

            adjustPhysicalAttrPoints(4);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newHero.name = nameTextBox.Text;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            newHero.age = int.Parse(agePicker.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate All Abilities
            foreach (CheckBox c in abilitiesGroupBox.Controls.OfType<CheckBox>())
            {
                if (c.Checked == true)
                {
                    newHero.abilities.Add(c.Text);
                }
            }

            // Calculate all Allegiences selected in allegiencesListBox
            for(int i = 0; i < allegiencesListBox.Items.Count; i++)
            {
                    if(allegiencesListBox.GetItemChecked(i))
                    {
                        newHero.allegiences.Add(allegiencesListBox.Items[i]);
                    }
            }

            // Get office
            newHero.officeLocation = officeListBox.SelectedItem.ToString();

            // Get transport
            newHero.transport = transportGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;

            Console.Out.WriteLine("The Hero We're Sending Over...");
            Console.Out.Write(newHero.ToString());

            // Send hero to Display Form
            Heroes nextForm = new Heroes(newHero);

            this.Hide();
            nextForm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            newHero.birthday = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            newHero.superPowerDiscovery = dateTimePicker2.Value;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            newHero.defeat = dateTimePicker3.Value;
        }

        private void experiencePicker_ValueChanged(object sender, EventArgs e)
        {
            newHero.yrsExperience = int.Parse(experiencePicker.Value.ToString());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            moralLeanVal.Text = string.Format("{0}", trackBar1.Value);
            newHero.moralLean = trackBar1.Value;
        }
    }
}

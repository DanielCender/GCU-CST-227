using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class SuperHero
    {
        public String name { get; set; }
        public int age { get; set; }
        public DateTime birthday { get; set; }
        public DateTime superPowerDiscovery { get; set; }
        public DateTime defeat { get; set; }
        public ArrayList abilities { get; set; }

        // Experiential Attr
        public int yrsExperience { get; set; }
        public String suitColor { get; set; }
        public int moralLean { get; set; }

        // Metadata
        public String officeLocation { get; set; }
        public String transport { get; set; }

        public ArrayList allegiences { get; set; }
        // Physical Attributes
        public int speed { get; set; }
        public int strength { get; set; }
        public int stamina { get; set; }
        public int agility { get; set; }
        public int intellect { get; set; }

        public SuperHero()
        {
            abilities = new ArrayList();
            allegiences = new ArrayList();
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}\n" +
                "Birthday: {2}\n" +
                "Powers Discovered: {3}\n" +
                "Defeat: {4}\n" +
                "Abilities: {5}" +
                "Years Experience: {6}\n" +
                "Suit Color: {7}\n" +
                "Moral Lean: {8}, Office Location: {9}\n" +
                "Preferred Transport: {10}\n" +
                "Allegiences: {11}\n" +
                "Speed: {12}, Strength: {13}\n" +
                "Stamina: {14}, Agility: {15}\n" +
                "Intellect: {16}", name, age, birthday.ToString(), superPowerDiscovery.ToString(), defeat.ToString(), string.Join(", ", abilities.ToArray()), yrsExperience, suitColor, moralLean, officeLocation, transport, string.Join(", ", allegiences.ToArray()), speed, strength, stamina, agility, intellect).Replace("\n",
                                                         Environment.NewLine);
        }
    }
}
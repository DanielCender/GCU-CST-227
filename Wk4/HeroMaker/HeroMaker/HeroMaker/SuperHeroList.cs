using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class SuperHeroList
    {
        public List<SuperHero> listOfHeroes { get; set; }

        public SuperHeroList()
        {
            listOfHeroes = new List<SuperHero>();
        }
    }
}

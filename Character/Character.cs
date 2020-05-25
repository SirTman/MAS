using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    class Character
    {
        protected string name;
        protected string species;
        Sex gender;

        enum Sex
        {
            male,
            female,
            andromorph,
            gynomorphy,
            herm,
            maleherm
        }
        private Face face;
        private Body body;


        //Core Stats
        private static int baseStat = 10;

        protected int STR, RFX, CON, CUN, PRE, INT = baseStat; //Strength, Reflex, Constitution, Cunning, Presence, Intellect
        private int[] stats = { baseStat, baseStat, baseStat, baseStat, baseStat};

        //Condition Stats
        private double stlib = 0.0;   //Libido 0-100
        private double stsen = 1.0;   //Senstivity Multiplyer x0.0

        private double lust;    //Lust 
        private double lustMax; //Lust Maximun DFLT: 100

        private double hp;      //Hit Points
        private double hpMax;   //Hit Points Maximun

        Character()
        {
            this.lustMax = 100.0;
            this.hpMax = 100.0;
        }
    }
}

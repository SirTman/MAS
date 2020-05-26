using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    public abstract class Character
    {
        public string name;
        public string species;
        protected Sex gender;
        //protected enum Sex
        //{
        //    male,
        //    female,
        //    andromorph,
        //    gynomorphy,
        //    herm,
        //    maleherm,
        //    undefined
        //}
        public Face face = new Face();
        public Body body = new Body();


        //Core Stats
        private static int baseStat = 10;

        protected int STR, RFX, CON, CUN, PRE, INT = baseStat; //Strength, Reflex, Constitution, Cunning, Presence, Intellect
        private int[] stats = { baseStat, baseStat, baseStat, baseStat, baseStat};

        //Condition Stats
        private double stlib = 0.0;   //Libido 0-100
        private double stsen = 1.0;   //Senstivity Multiplyer x0.0

        private double lust;    //Lust 
        private double lustMax = 100.0; //Lust Maximun DFLT: 100

        private double hp;      //Hit Points
        private double hpMax = 100.0;   //Hit Points Maximun

        public string getGender()
        {
            string t;

            switch (gender) {
                case Sex.male:
                    t = "male";
                    break;
                case Sex.female:
                    t = "female";
                    break;
                case Sex.andromorph:
                    t = "andromorph";
                    break;
                case Sex.gynomorphy:
                    t = "gynomorphy";
                    break;
                case Sex.herm:
                    t = "herm";
                    break;
                case Sex.maleherm:
                    t = "maleherm";
                    break;
                case Sex.undefined:
                    t = "unknown";
                    break;
                default:
                    t = "unknown";
                    break;
            }
            return t;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    public abstract class Character
    {
        protected string _name;
        public string Name { get; }
        private string _species;
        public string Species { get; set; }
        protected Sex gender;

        public Face face = new Face();
        public Body body = new Body();

        //Core Stats
        private static int baseStat = 10;
        private int
            _strengthScore,     //Strength, 
            _reflexScore,       //Reflex, 
            _constitutionScore, //Constitution, 
            _cunningScore,      //Cunning, 
            _presenceScore,     //Presence, 
            _IntellectScore;    //Intellect
        protected int StrengthScore { set; get; }
        protected int ReflexScore { set; get; }
        protected int ConstitutionScore { set; get; }
        protected int CunningScore { set; get; }
        protected int PresenceScore { set; get; }
        protected int IntellectScore { set; get; }

        private int statModifier(int score)
        {
            double scoreD = score;
            score = Convert.ToInt32(Math.Floor((scoreD - 10) / 2));
            return score;
        }

        private int _STR, _RFX, _CON, _CUN, _PRE, _INT; ////Strength, Reflex, Constitution, //Cunning, //Presence, //Intellect
        public int STR { get { return this.statModifier(StrengthScore); } }
        public int RFX { get { return this.statModifier(ReflexScore); } }
        public int CON { get { return this.statModifier(ConstitutionScore); } }
        public int CUN { get { return this.statModifier(CunningScore); } }
        public int PRE { get { return this.statModifier(PresenceScore); } }
        public int INT { get { return this.statModifier(IntellectScore); } }




        //Condition Stats
        protected int _reputation = 1;

        private double stlib = 0.0;   //Libido 0-100
        private double stsen = 1.0;   //Senstivity Multiplyer x0.0

        private double lust;    //Lust 
        private double lustMax = 100.0; //Lust Maximun DFLT: 100

        private int _hp;      //Hit Points
        public int HP { get; set; }

        private int _hpMax;   //Hit Points Maximun
        public int HPmax { get { return _hpMax; } }

        public void calHPMax() {
            _hpMax = _reputation + (this.CON * _reputation);
        }

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
        public int getAbilityScore(Stat abl) {
            int score = 0;
            switch (abl)
            {
                case Stat.STR:
                    score = this.StrengthScore;
                    break;
                case Stat.RFX:
                    score = this.ReflexScore;
                    break;
                case Stat.CON:
                    score = this.ConstitutionScore;
                    break;
                case Stat.CUN:
                    score = this.CunningScore;
                    break;
                case Stat.PRE:
                    score = this.PresenceScore;
                    break;
                case Stat.INT:
                    score = this.IntellectScore;
                    break;
                default:
                    score = 0;
                    break;
            }
            return score;
        }
        public void setAbilityScore(Stat abl, int num)
        {
            switch (abl)
            {
                case Stat.STR:
                    this.StrengthScore = num;
                    break;
                case Stat.RFX:
                    this.ReflexScore = num;
                    break;
                case Stat.CON:
                    this.ConstitutionScore = num;
                    calHPMax();
                    break;
                case Stat.CUN:
                    this.CunningScore = num;
                    break;
                case Stat.PRE:
                    this.PresenceScore = num;
                    break;
                case Stat.INT:
                    this.IntellectScore = num;
                    break;
            }
        }
        public void addAbilityScore(Stat abl, int num)
        {
            switch (abl)
            {
                case Stat.STR:
                    this.StrengthScore += num;
                    break;
                case Stat.RFX:
                    this.ReflexScore += num;
                    break;
                case Stat.CON:
                    this.ConstitutionScore += num;
                    calHPMax();
                    break;
                case Stat.CUN:
                    this.CunningScore += num;
                    break;
                case Stat.PRE:
                    this.PresenceScore += num;
                    break;
                case Stat.INT:
                    this.IntellectScore += num;
                    break;
            }
        }
        public void subAbilityScore(Stat abl, int num)
        {
            switch (abl)
            {
                case Stat.STR:
                    this.StrengthScore -= num;
                    break;
                case Stat.RFX:
                    this.ReflexScore -= num;
                    break;
                case Stat.CON:
                    this.ConstitutionScore -= num;
                    calHPMax();
                    break;
                case Stat.CUN:
                    this.CunningScore -= num;
                    break;
                case Stat.PRE:
                    this.PresenceScore -= num;
                    break;
                case Stat.INT:
                    this.IntellectScore -= num;
                    break;
            }
        }
          
    }
}

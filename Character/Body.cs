using MAS.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace MAS.Character
{
    public class Body
    {
        //Upper Body=====================================================
        public double Height; //cm-m
        public int feminity;  //0-100
        protected double weight; //kg

        protected List<Breasts> boobs = new List<Breasts>();


        protected string skin;
        protected string skinTone;
        protected string skinAdj; //Adjective

        protected int arms = 2;
        protected int fingers = 5;
        protected string claws;
        protected string clawTone;

        protected List<string> back;
        protected bool wings = false;
        protected bool Fins = false;
        protected bool Tenticals = false;
        protected bool Gills = false;

        //Lower Body=====================================================
        protected int assVol;
        protected List<Hole> butt = new List<Hole>();




        protected int thighsHips;

        //Balls
        protected bool sack; //If fales internal.
        protected int balls; ///Number of balls
        protected double ballsDia; //cm
        protected double cumMULT; // x10.0 mL/h

        protected List<Penis> cock = new List<Penis>();
        protected List<Vagina> pussy = new List<Vagina>();

        private string Legs;
        LegConfig legConfiguration = LegConfig.biped;
        enum LegConfig
        {
            biped,
            quadruped
        }

        FootType feetConfig = FootType.Plantigrade;
        enum FootType
        {
            Plantigrade,
            Digitigrade,
            Unguligrade
        }

        private string tailsType;
        private int tailNUM;

        public Body()
        {
            this.boobs.Add(new Breasts());//Everyone has one chest.
            this.butt.Add(new Hole());//Everyone has an ass.
        }

        public void createCockBalls()
        {
            cock.Add(new Penis());
            sack = true;
            balls = 2;
            ballsDia = 2.5;

        }
        //Penis
        public void createCock() => cock.Add(new Penis());
        public void createCock(string type, double len, double thi) => cock.Add(new Penis(type, len, thi));
        public void createCock(string type, double len, double thi, bool knot) => cock.Add(new Penis(type, len, thi, knot));
        public void createCock(string type, double len, double thi, bool knot, double mult) => cock.Add(new Penis(type, len, thi, knot, mult));

        //Vag
        public void createVagina() => pussy.Add(new Vagina());

        public void adjustAllBustSize(int num)
        {
            for (int i = 0; i < boobs.Count; i++)
            {
                boobs[i].changeSize(num);
            }
        }
        public void setAllBustSize(int num)
        {
            for (int i=0;i < boobs.Count; i++)
            {
                boobs[i].SetSize(num);
            }
        }
    }

}

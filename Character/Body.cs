using MAS.Character.Sexual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    class Body
    {
        //Upper Body=====================================================
        protected double height; //cm-m
        protected int feminity;  //0-100
        protected double weight; //kg

        private Breasts[] boobs;

        private string skin;
        private string skinTone;
        private string skinAdj; //Adjective

        private int arms = 2;
        private int fingers = 5;
        private string claws;
        private string clawTone;

        private string[] back;
        private bool wings = false;
        private bool Fins = false;
        private bool Tenticals = false;

        private bool Gills = false;

        //Lower Body=====================================================
        private int assVol;
        private Hole[] butt = { new Hole()}; //Everyone has an ass.

        private int thighsHips;

        //Balls
        bool sack; //If fales internal.
        int balls;
        double ballsDia;
        double cumMULT; // x10.0 mL/h

        private Penis[] cock;
        private Vagina[] pussy;

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
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    public class Face
    {
        private static Random rnd = new Random();
        private string randomChoice(string[] str)
        {
            int r = rnd.Next(str.Length);
            return str[r];
        }

        //Hair
        private double hairLength;     //Hair Length (cm)
        private string hairColour;     //Hair Colour
        private string hairType;       //Hair Type 
        private string hairStyle;      //Hair Style 

        private bool beard = false; //If the character has a beard.
        private double beardLength;    //Beard Length (cm)

        //Face
        private string face;
        private string tounge = "human";
        private string eyestype = "human";
        private string[] eyeColour = {"white", "white"};
        private string ears = "human";
        
        private string antennae;
        private string horns;
        private string hornsNum; //Number of horns
        private double hornsMis; //Might refer to the amout of branches if their antlers or length of horns

        //Piercings
        private string earsPier;
        private string nosePier;
        private string lipPier;
        private string toungePier;

        public Face() {
            this.face = "human";
        }
        public Face(string type)
        {
            this.face = type;
            this.ears = type;
        }
        public void sethairLength(double val)
        {
            this.hairLength = val;
        }

        private string lenAdj(double len)
        {
            string adj = "bald head";

            if (len == 0) {
                string[] arr = { "shaved", "bald", "smooth", "hairless", "glabrous" };
                return adj = randomChoice(arr) + " head";
            }
            if (len < 2.5) { string[] arr = { "shaved", "bald", "smooth", "hairless", "glabrous" }; adj = randomChoice(arr); }
            else if (len < 7.6) { string[] arr = { "close-cropped, ", "trim, ", "very short, " }; adj = randomChoice(arr); }
            else if(len < 15) { adj = "short, "; }
            else if(len < 25) { adj = "shaggy, "; }
            else if(len < 41) { adj = "moderately long, "; }
            else if(len < 66) { string[] arr = { "long, ", "shoulder-length, " }; adj = randomChoice(arr); }
            else if(len < 102) { string[] arr = { "very long, ", "flowing locks of " }; adj = randomChoice(arr); }

            return adj;
        }
    }
}

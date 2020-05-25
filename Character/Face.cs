using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    class Face
    {
        //Hair
        private double hairLength;     //Hair Length (cm)
        private string hairColour;     //Hair Colour
        private string hairType;       //Hair Type 
        private string hairStyle;      //Hair Style 

        private Boolean beard = false; //If the character has a beard.
        private double beardLength;    //Beard Length (cm)

        //Face
        private string face;
        private string tounge;
        private string eyestype;
        private string[] eyeColour = { "white", "white"};
        private string ears;
        
        private string antennae;
        private string horns;
        private string hornsNum; //Number of horns
        private double hornsMis; //Might refer to the amout of branches if their antlers or length of horns

        //Piercings
        private string earsPier;
        private string nosePier;
        private string lipPier;
        private string toungePier;
    }
}

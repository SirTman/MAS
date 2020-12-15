using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAS.Character;

namespace MAS.Character.PC
{
    public class Player : Character
    {
        public Player(string Pname,bool isMale)
        {
            this._name = Pname;
            this.gender = isMale ? Sex.male : Sex.female;
            Globals.PC_OrginalGender = this.gender;
            switch (gender)
            {
                case Sex.male:
                    //Globals.PC_OrginalGender = Sex.male;
                    face.sethairLength(2.5);//cm
                    body.setAllBustSize(0);
                    body.Height = 180;
                    body.createCockBalls();
                    
                    break;

                case Sex.female:
                    //Globals.PC_OrginalGender = Sex.female;
                    face.sethairLength(26);//cm
                    body.setAllBustSize(1);
                    body.Height = 170;
                    body.createVagina();
                    break;
            }
        }

        public void setStartSpecies(StartingRace race)
        {
            this.Species = race.ToString();
            switch (race)
            {
                case StartingRace.Human:
                    //
                    break;
                case StartingRace.Rabbit:
                    body.Height -= 35;
                    break;
                case StartingRace.Cat:
                    body.Height -= 20;
                    break;
                case StartingRace.Goat:
                    body.Height -= 15;
                    break;
                case StartingRace.Dog:
                    body.Height += 15;
                    break;
                case StartingRace.Horse:
                    body.Height += 20;
                    break;
                case StartingRace.Cow:
                    body.Height += 35;
                    break;
            }
        }
        public void setSpecies(StartingRace race)
        {
            this.Species = race.ToString();
        }
        public void setSpecies(string race)
        {
            this.Species = race.ToString();
        }

        public void setThickness(int Num)
        {
            
        }

        public void sleep() {
            this.HP = this.HPmax;
        }
    }
}

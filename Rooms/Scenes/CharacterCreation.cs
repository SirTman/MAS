using MAS.Character.PC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS.Rooms.Scenes
{
    class CharacterCreation : Room
    {
        TextBox tmName;
        string playerName;
        bool isMale;
        Player pc;

        public CharacterCreation(MAS mAS)
        {
            this.RoomName = "Registration Office";
            this.description = "You find yourself on the Planet of Capus B27 a wasteland ball of dust in a remote system of the galexy. " +
                "One of the only noticable things on this rock is Trash Town, a city build up of refuse and scrap discared from a warzone long ago" +
                "the town itself is rulleded by a cutthroat Queen. The biggest drawn of the metrolplise is the Karma Coliseum, one of the only ways" +
                "to get propper fame and recognistion around these parts. A bloody area that hosts Mech Battles, where winner takes all, in some weird sence.." +
                "\n\n" +
                "You for whatever reason have decided to join this bloodsport, you find yourself standing in a line nearly at the Admin desk";
            this.MainForm = mAS;
            MainForm.abRight();
            MainForm.setButtons(nextButton());
        }

        protected override string Book()
        {
            string desc = description;
            switch (page)
            {
                case 0:
                    desc = description;
                    break;
                case 1:
                    MainForm.abLeft();
                    desc = "Next please? Ah, Another one to sign up, huh? They sure have been pushing that new compeditor slots after the last royale." +
                        "Alright I'm just going to need you to fill out this form.... what's with that blank stare let's start simple;\nwhat is your name?";
                    tmName = nameField();
                    break;
                case 2:
                    desc = string.Format("Ah, so your name is {0}, cute dear.\n" +
                        "So tell me {0} are you a Man or a Woman?", playerName);
                    MainForm.setButtons(addButton("Male", gender_Click));
                    MainForm.addButtons(addButton("Female", gender_Click));
                    break;
                case 3:
                    desc = string.Format("Ah, so your name is {0}, cute dear.\n" +
                        "Next could you fill in your species?", playerName);
                    buttonlist.Clear();
                    buttonlist.Add(addButton("Human", race_Click));
                    buttonlist.Add(addButton("Rabbit", race_Click));
                    buttonlist.Add(addButton("Cat", race_Click));
                    buttonlist.Add(addButton("Goat", race_Click));
                    buttonlist.Add(addButton("Dog", race_Click));
                    buttonlist.Add(addButton("Horse", race_Click));
                    buttonlist.Add(addButton("Cow", race_Click));
                    MainForm.setButtons(buttonlist);
                    break;
                case 4:
                    
                    MainForm.pc = this.pc;
                    buttonlist.Clear();
                    buttonlist.Add(addButton("20", "Very Thin", thickness_Click));
                    buttonlist.Add(addButton("30", "Thin", thickness_Click));
                    buttonlist.Add(addButton("40", "Lithe", thickness_Click));
                    buttonlist.Add(addButton("50", "Normal;", thickness_Click));
                    buttonlist.Add(addButton("60", "Husky", thickness_Click));
                    buttonlist.Add(addButton("70", "Thickset", thickness_Click));
                    MainForm.setButtons(buttonlist);

                    desc = string.Format("Oh, so you are a {1}, {0}.\n" +
                        "As for your size class would you describe yourself as...?",pc.name, pc.getGender());
                    break;
            }
            return desc;
        }

        private void gender_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            isMale = (button.Name == "Male") ?  true : false;
            this.pc = new Player(playerName, isMale);

            next_Click(sender, e);
        }

        private void thickness_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Name.to

            next_Click(sender, e);
        }

        private void race_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Human":
                    Globals.setStartingRace(StartingRace.Human);
                    break;
                case "Rabbit":
                    Globals.setStartingRace(StartingRace.Rabbit);
                    break;
                case "Cat":
                    Globals.setStartingRace(StartingRace.Cat);
                    break;
                case "Goat":
                    Globals.setStartingRace(StartingRace.Goat);
                    break;
                case "Dog":
                    Globals.setStartingRace(StartingRace.Dog);
                    break;
                case "Horse":
                    Globals.setStartingRace(StartingRace.Horse);
                    break;
                case "Cow":
                    Globals.setStartingRace(StartingRace.Cow);
                    break;
            }
            pc.setSpecies(Globals.PC_OriginalRace);
            next_Click(sender, e);
        }
        
    }
}

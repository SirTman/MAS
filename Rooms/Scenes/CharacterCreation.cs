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
        int pointbuy = 25;
        private int[] baseStatsTotals = { 8, 8, 8, 8, 8, 8 };
        private int[] statsPoints = { 0, 0, 0, 0, 0, 0 };
        private int[] racialBonus = { 0, 0, 0, 0, 0, 0 };

        bool DEBUG_SkipCreation = true;

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
            
            //DEBUG START
            if (DEBUG_SkipCreation)
            {
                playerName = "alex";
                isMale = false;
                this.pc = new Player(playerName, isMale);

                Globals.setStartingRace(StartingRace.Cow);
                racialBonus[0] += 4; //STR
                racialBonus[2] += 4; //CON
                racialBonus[5] -= 2; //INT
                pc.setSpecies(Globals.PC_OriginalRace);

                pc.setThickness(50);//Thickness

                pc.setAbilityScore((Stat)0, 14 + racialBonus[0]);
                pc.setAbilityScore((Stat)1, 10 + racialBonus[1]);
                pc.setAbilityScore((Stat)2, 14 + racialBonus[2]);
                pc.setAbilityScore((Stat)3, 10 + racialBonus[3]);
                pc.setAbilityScore((Stat)4, 10 + racialBonus[4]);
                pc.setAbilityScore((Stat)5, 10 + racialBonus[5]);
                
                MainForm.pc = this.pc;
                MainForm.updateStats();
                MainForm.pc.sleep();
                MainForm.updateHP();
                
                sc_assets();
            }
            //NORMAL START
            else
            {
                MainForm.setButtons(nextButton(sc_name));
                //MainForm.setButtons(nextButton());
            }
        }

        protected override string Book()
        {
            /* string desc = description;
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
                        "As for your size class would you describe yourself as...?", pc.name, pc.getGender());
                    break;
                case 5:
                    break;
            }
            */
            return this.description;
            
        }
        
        //Name
        private void sc_name(object sender, EventArgs e) {
            MainForm.abLeft();
            this.description = "Next please? Ah, Another one to sign up, huh? They sure have been pushing that new compeditor slots after the last royale." +
                "Alright I'm just going to need you to fill out this form.... what's with that blank stare let's start simple;\nwhat is your name?";
            tmName = nameField(sc_gender);
            pushDescription();
        }
        
        //Gender
        private void sc_gender(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tmName.Text))
            {
                playerName = tmName.Text;
                this.description = string.Format("Ah, so your name is {0}, cute dear.\n" +
                            "So tell me {0} are you a Man or a Woman?", playerName);
                MainForm.setButtons(addButton("Male", gender_Click));
                MainForm.addButtons(addButton("Female", gender_Click, "Makes you female"));
                pushDescription();
            }
        }

        private void gender_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            isMale = (button.Name == "Male") ?  true : false;
            this.pc = new Player(playerName, isMale);
            sc_race();
        }

        //Race
        private void sc_race()
        {
            this.description = string.Format("Ah, so your a {0}, awesome.\n" +
                        "Next could you fill in your species?", this.pc.getGender());
            buttonlist.Clear();
            buttonlist.Add(addButton("Human", race_Click));
            buttonlist.Add(addButton("Rabbit", race_Click));
            buttonlist.Add(addButton("Cat", race_Click));
            buttonlist.Add(addButton("Goat", race_Click));
            buttonlist.Add(addButton("Dog", race_Click));
            buttonlist.Add(addButton("Horse", race_Click));
            buttonlist.Add(addButton("Cow", race_Click));
            MainForm.setButtons(buttonlist);
            pushDescription();
        }

        private void race_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Human":
                    Globals.setStartingRace(StartingRace.Human);
                    pointbuy += 3;
                    break;
                case "Rabbit":
                    Globals.setStartingRace(StartingRace.Rabbit);
                    racialBonus[1] += 1; //RFX
                    racialBonus[4] += 2; //PRE
                    break;
                case "Cat":
                    Globals.setStartingRace(StartingRace.Cat);
                    racialBonus[0] += 1; //STR
                    racialBonus[1] += 2; //RFX
                    racialBonus[5] -= 1; //INT
                    break;
                case "Goat":
                    Globals.setStartingRace(StartingRace.Goat);
                    racialBonus[0] += 2; //STR
                    racialBonus[2] += 2; //CON
                    racialBonus[3] -= 1; //CUN
                    break;
                case "Dog":
                    Globals.setStartingRace(StartingRace.Dog);
                    racialBonus[0] += 2; //STR
                    racialBonus[5] += 1; //INT
                    racialBonus[3] += 1; //INT
                    break;
                case "Horse":
                    Globals.setStartingRace(StartingRace.Horse);
                    racialBonus[0] += 3; //STR
                    racialBonus[2] += 2; //CON
                    break;
                case "Cow":
                    Globals.setStartingRace(StartingRace.Cow);
                    racialBonus[0] += 4; //STR
                    racialBonus[2] += 4; //CON
                    racialBonus[5] -= 2; //INT
                    break;
            }
            pc.setSpecies(Globals.PC_OriginalRace);
            sc_thickness();
        }

        //Thickness
        private void sc_thickness() {
            MainForm.pc = this.pc;
            buttonlist.Clear();
            buttonlist.Add(addButton("20", "Very Thin", thickness_Click));
            buttonlist.Add(addButton("30", "Thin", thickness_Click));
            buttonlist.Add(addButton("40", "Lithe", thickness_Click));
            buttonlist.Add(addButton("50", "Normal;", thickness_Click));
            buttonlist.Add(addButton("60", "Husky", thickness_Click));
            buttonlist.Add(addButton("70", "Thickset", thickness_Click));
            MainForm.setButtons(buttonlist);

            this.description = string.Format("Oh, so you are a {1}, {0}.\n" +
                "As for your size class would you describe yourself as...?", pc.Name, pc.getGender());
            pushDescription();
        }

        private void thickness_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            pc.setThickness(Int32.Parse(button.Name));
            sc_stats();
        }

        private void sc_stats() {
            buttonlist.Clear();
            MainForm.clrButtons();
            MainForm.addButtons(statUpButton("STR", statUp, 0));
            MainForm.addButtons(statUpButton("RFX", statUp, 1));
            MainForm.addButtons(statUpButton("CON", statUp, 2));
            MainForm.addButtons(statUpButton("CUN", statUp, 3));
            MainForm.addButtons(statUpButton("PRE", statUp, 4));
            //MainForm.addButtons(statUpButton("INT", statUp, 5));
            Button buttonBreak = statUpButton("INT", statUp, 5);
            MainForm.addButtons(buttonBreak);
            MainForm.actionBarBreak(buttonBreak, true);

            MainForm.addButtons(statDownButton("STR", statDown, 0));
            MainForm.addButtons(statDownButton("RFX", statDown, 1));
            MainForm.addButtons(statDownButton("CON", statDown, 2));
            MainForm.addButtons(statDownButton("CUN", statDown, 3));
            MainForm.addButtons(statDownButton("PRE", statDown, 4));
            MainForm.addButtons(statDownButton("INT", statDown, 5));

            Button finishedButton = finishSatsButton(saveAbility);
            if (pointbuy >= 1)
                finishedButton.Enabled = false;
            MainForm.addButtons(finishedButton);

            //MainForm.setButtons(buttonlist);
            this.description = "Alright, next you are going to have to undergo an evaluation to test your stats." +
                "\n" +
                "Points to Spend: " + pointbuy + "\n\n" + statCal();

            pushDescription();
        }

        private string statCal()
        {
            string strDialog = "";
            string[] str = {
                string.Format("STR TOTAL: {0}", baseStatsTotals[0] + statsPoints[0] + racialBonus[0]),
                string.Format("RFX TOTAL: {0}", baseStatsTotals[1] + statsPoints[1] + racialBonus[1]),
                string.Format("CON TOTAL: {0}", baseStatsTotals[2] + statsPoints[2] + racialBonus[2]),
                string.Format("CUN TOTAL: {0}", baseStatsTotals[3] + statsPoints[3] + racialBonus[3]),
                string.Format("PRE TOTAL: {0}", baseStatsTotals[4] + statsPoints[4] + racialBonus[4]),
                string.Format("INT TOTAL: {0}", baseStatsTotals[5] + statsPoints[5] + racialBonus[5])};

            for (int i = 0; i < str.Length; i++) {
                strDialog += str[i] + " + "+ statsPoints[i] + " (points)";

                switch (Globals.PC_OriginalRace)
                {
                    case StartingRace.Rabbit:
                        if (i == 1) strDialog += " + 1 (Racial Bonus)"; //RFX
                        if (i == 4) strDialog += " + 2 (Racial Bonus)"; //PRE
                        break;
                    case StartingRace.Cat:
                        if (i == 0) strDialog += " + 1 (Racial Bonus)"; //STR
                        if (i == 1) strDialog += " + 2 (Racial Bonus)"; //RFX
                        if (i == 5) strDialog += " - 1 (Racial Bonus)"; //INT
                        break;
                    case StartingRace.Goat:
                        if (i == 0) strDialog += " + 2 (Racial Bonus)"; //STR
                        if (i == 2) strDialog += " + 2 (Racial Bonus)"; //CON
                        if (i == 3) strDialog += " - 1 (Racial Bonus)"; //CUN
                        break;
                    case StartingRace.Dog:
                        if (i == 0) strDialog += " + 2 (Racial Bonus)"; //STR
                        if (i == 5) strDialog += " + 1 (Racial Bonus)"; //INT
                        if (i == 3) strDialog += " + 1 (Racial Bonus)"; //INT
                        break;
                    case StartingRace.Horse:
                        if (i == 0) strDialog += " + 3 (Racial Bonus)"; //STR
                        if (i == 2) strDialog += " + 2 (Racial Bonus)"; //CON
                        break;
                    case StartingRace.Cow:
                        if (i == 0) strDialog += " + 4 (Racial Bonus)"; //STR
                        if (i == 2) strDialog += " + 4 (Racial Bonus)"; //CON
                        if (i == 5) strDialog += " - 2 (Racial Bonus)"; //INT
                        break;
                }
                strDialog += "\n";
            }
            return strDialog;
        }

        private void statUp(object sender, EventArgs e) {
            var button = (Button)sender;
            int val = Int32.Parse(button.Name);
            switch (baseStatsTotals[val] + statsPoints[val])
            {
                case 6: // -> 7
                    if (pointbuy >= 3)
                    {
                        statsPoints[val] += 1;
                        pointbuy -= 3;
                    }
                    break;
                case 7: // -> 8
                    if (pointbuy >= 2)
                    {
                        statsPoints[val] += 1;
                        pointbuy -= 2;
                    }
                    break;
                case 8: // -> 9
                    if (pointbuy >= 1) { 
                        statsPoints[val] += 1;
                        pointbuy -= 1;
                    }
                    break;
                case 9:// -> 10
                    if (pointbuy >= 2) { 
                        statsPoints[val] += 1;
                        pointbuy -= 2;
                    }
                    break;
                case 10:// -> 11
                    if (pointbuy >= 3) { 
                        statsPoints[val] += 1;
                        pointbuy -= 3;
                    }
                    break;
                case 11:// -> 12
                    if (pointbuy >= 4) {
                        statsPoints[val] += 1;
                        pointbuy -= 4;
                    }
                    break;
                case 12:// -> 13
                    if (pointbuy >= 5) {
                        statsPoints[val] += 1;
                        pointbuy -= 5;
                    }
                    break;
                case 13:// -> 14
                    if (pointbuy >= 7) {
                        statsPoints[val] += 1;
                        pointbuy -= 7;
                    }
                    break;
                case 14:// -> 15
                    if (pointbuy >= 9) {
                        statsPoints[val] += 1;
                        pointbuy -= 9;
                    }
                    break;
            }
            sc_stats();
        }
        private void statDown(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int val = Int32.Parse(button.Name);
            switch (baseStatsTotals[val] + statsPoints[val])
            {
                case 7: // -> 6
                    statsPoints[val] -= 1;
                    pointbuy += 3;
                    break;
                case 8: // -> 7
                    statsPoints[val] -= 1;
                    pointbuy += 2;
                    break;
                case 9: // -> 8
                    statsPoints[val] -= 1;
                    pointbuy += 1;
                    break;
                case 10:// -> 9
                    statsPoints[val] -= 1;
                    pointbuy += 2;
                    break;
                case 11:// -> 10
                    statsPoints[val] -= 1;
                    pointbuy += 3;
                    break;
                case 12:// -> 11
                    statsPoints[val] -= 1;
                    pointbuy += 4;
                    break;
                case 13:// -> 12
                    statsPoints[val] -= 1;
                    pointbuy += 5;
                    break;
                case 14:// -> 13
                    statsPoints[val] -= 1;
                    pointbuy += 7;
                    break;
                case 15:// -> 14
                    statsPoints[val] -= 1;
                    pointbuy += 9;
                    break;
            }
            sc_stats();
        }

        private void saveAbility(object sender, EventArgs e) {
            for (int i = 0; i < baseStatsTotals.Length; i++)
            {
                pc.setAbilityScore((Stat)i, (baseStatsTotals[i] + statsPoints[i] + racialBonus[i]));
            }
            MainForm.pc = this.pc;
            MainForm.updateStats();
            MainForm.pc.sleep();
            MainForm.updateHP();
            sc_assets();
        }

        private void sc_assets() {
            this.description = "Well now that is all done, it's time for you to head to the workshop";
            MainForm.setButtons(nextButton(MainForm.returnToWorkshop));
            pushDescription();
        }
    }
}

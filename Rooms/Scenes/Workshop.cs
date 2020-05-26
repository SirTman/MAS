using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS.Rooms.Scenes
{
    class Workshop : Room
    {
        public Workshop(MAS mAS)
        {
            this.MainForm = mAS;
            this.RoomName = "Workshop";
            this.description = "The workshop, the place you typically call home. These days from here you can go to a variety of places.";

            //Define Buttons
            this.buttonlist.Add(addButton("Travel1", "Dawns Cafe", na_Click));
            this.buttonlist.Add(addButton("Travel2", "Dance Club", na_Click));


        }

        private void return_Click(object sender, EventArgs e)
        {
            //var button = (Button)sender;
            //MessageBox.Show(button.Text); #DEBUG
            //MainForm.Scene = new CharacterCreation();
            //MAS NewScene = new MAS(scenesTran);
            MainForm.setButtons(buttonlist);
            MainForm.scDialog(description);
        }

        private void na_Click(object sender, EventArgs e)
        {
            MainForm.setButtons(nextButton(return_Click));
            MainForm.scDialog("Seems closed at the moment");
            //MainForm.scDialog(description);
        }

        protected override string Book()
        {
            throw new NotImplementedException();
        }
    }
}

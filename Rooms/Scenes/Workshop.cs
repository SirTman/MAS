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
        public Workshop()
        {
            this.roomName = "Workshop";
            this.description = "The workshop, the place you typically call home. These days from here you can go to a variety of places.";

            this.buttonlist.Add("Dawns Cafe");
            this.buttonlist.Add("Strip Club");

        }
    }
}

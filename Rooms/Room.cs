using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAS;

namespace MAS.Rooms
{
    public class Room
    {
        public int ID { get; set; }
        protected string roomName { get; set; }
        protected string description { get; set; }

        public List<string> buttonlist = new List<string>();
        public int Page = 0;


        //Constructors
        protected Room() { }

        public Room(string Name, string desc, int setID)
        {
            this.roomName = Name;
            this.description = desc;
            this.ID = setID;
        }

        public string readDesc()
        {
            return description;
            
        }

        public string location()
        {
            return roomName;
        }

        public List<string> buttons()
        {
            return buttonlist;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Rooms.Scenes
{
    class CharacterCreation : Room
    {
        public bool[] buttonToggle = { false, false, false, false, false, false, true };
        public CharacterCreation()
        {
            this.roomName = "Somewhere";
            this.description = "You awaken in a stange place...";
            
            
        }
    }
}

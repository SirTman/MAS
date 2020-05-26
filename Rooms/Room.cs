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
        protected MAS MainForm;

        public int ID { get; set; }
        private string _roomName;
        public string RoomName
        {
            get { return _roomName; }
            set { _roomName = "LOCATION: " + value; }
        }
        protected string description;
        static int page = 0;
    
        public List<Button> buttonlist = new List<Button>();
        public Button addButton(string bName, string bText, EventHandler eh)
        {
            Button newButton = new Button();
            //newButton.Font = new System.Drawing.Font("PF Ronda Seven", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Size = new System.Drawing.Size(132, 50);
            newButton.TabIndex = 7;
            newButton.Name = bName;
            newButton.Text = bText;
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += eh;
            return newButton;
        }

        //Constructors
        protected Room() { }

        public Room(string Name, string desc, int setID, MAS mAS)
        {
            this.RoomName = Name;
            this.description = desc;
            this.ID = setID;
            this.MainForm = mAS;

        }

        public string readDesc()
        {
            return description;
            
        }

        public string location()
        {
            return _roomName;
        }

        //Button Stuff.
        public Button nextButton()
        {
            Button NextButton = addButton("btNext","   Next >>", next_Click);
            return NextButton;
        }
        public Button nextButton(EventHandler ne)
        {
            Button NextButton = addButton("btNext", "   Next >>", ne);
            return NextButton;
        }

        public Button backButton()
        {
            Button BackButton = addButton("btback", "<< Back   ", back_Click);
            return BackButton;
        }
        public Button backButton(EventHandler pe)
        {
            Button BackButton = addButton("btback", "<< Back   ", pe);
            return BackButton;
        }

        private void next_Click(object sender, EventArgs e)
        {
            page += 1;
        }
        private void back_Click(object sender, EventArgs e) {
            page -= 1;
        }

        public List<Button> buttons()
        {
            return buttonlist;
        }
    }
}

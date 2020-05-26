using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAS;
using MAS.Character;
using MAS.Character.PC;

//using player = MAS.

namespace MAS.Rooms
{
    public abstract class Room
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

        protected static int page = 0;
        public void skip(int Num) { page += Num; Book(); }
        protected abstract string Book();

        public List<Button> buttonlist = new List<Button>();
        public Button addButton(string bName, string bText, EventHandler eh)
        {
            Button newButton = new Button();
            //newButton.Font = new System.Drawing.Font("PF Ronda Seven", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Size = new Size(Globals.bw, Globals.bh);
            newButton.TabIndex = 7;
            newButton.Name = bName;
            newButton.Text = bText;
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += eh;
            return newButton;
        }
        public Button addButton(string NameTxt, EventHandler eh)
        {
            Button newButton = new Button();
            //newButton.Font = new System.Drawing.Font("PF Ronda Seven", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Size = new Size(Globals.bw, Globals.bh);
            newButton.TabIndex = 7;
            newButton.Name = NameTxt;
            newButton.Text = NameTxt;
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += eh;
            
            return newButton;
        }

        //Constructors
        public Room() { }

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

        protected void next_Click(object sender, EventArgs e)
        {
            page += 1;
            MainForm.scDialog(Book());
        }
        protected void back_Click(object sender, EventArgs e) {
            page -= 1;
            MainForm.scDialog(Book());
        }

        public List<Button> buttons()
        {
            return buttonlist;
        }

        public TextBox nameField()
        {
            MainForm.clrButtons();

            TextBox NameInput = new TextBox()
            {
                Name = "NameInput",
                TabIndex = 9,
                Size = new Size(500, Globals.bh),
                Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)))
            };

            MainForm.abAdd(NameInput);
            Button newButton = new Button() { Size = new Size(Globals.bw, Globals.bh), TabIndex = 7, Name = "OK", Text = "Ok", UseVisualStyleBackColor = true };
            newButton.Click += new EventHandler(next_Click);
            MainForm.abAdd(newButton);

            return NameInput;
        }
    }
}

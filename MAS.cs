using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MAS.Rooms;
using MAS.Rooms.Scenes;

namespace MAS
{
    public partial class MAS : Form
    {
        Room Scene;

        public MAS()
        {
            InitializeComponent();
            Scene = new Workshop();
            //MessageBox.Show("Dynamic button is clicked"); Yeah Yeah
        }

        public MAS(Room curRoom)
        {
            InitializeComponent();
            Scene = curRoom;
        }

        public void nextButton()
        {
            Button NextButton = addButton("   Next >>");
            ActionBar.Controls.Add(NextButton);
            NextButton.Click += new EventHandler(next_Click);
        }

        public void backButton()
        {
            Button BackButton = addButton("<< Back   ");
            ActionBar.Controls.Add(BackButton);
            BackButton.Click += new EventHandler(next_Click);
        }

        public void travelButton(string location)
        {
            Button TravelButton = addButton(location);
            ActionBar.Controls.Add(TravelButton);
            TravelButton.Click += new EventHandler(travel_Click);
        }

        public Button addButton(string bText)
        {
            Button newButton = new Button();
            //newButton.Font = new System.Drawing.Font("PF Ronda Seven", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Size = new System.Drawing.Size(132, 50);
            newButton.TabIndex = 7;
            newButton.Text = bText;
            newButton.UseVisualStyleBackColor = true;
            return newButton;
        }

        public void SetScene(Room desc)
        {
            CurLocation.Text = "LOCATION: " + desc.location();
            TBMainTextWin.Text = desc.readDesc();
            //for (int i = 0; i < desc.buttomToggle.Length; i++)
            //{
            //  bt1.Visible = desc.buttomToggle[i];
            //}

            for (int i = 0; i < desc.buttonlist.Count; i++)
            {
                travelButton(desc.buttonlist[i]);
            }
        }

        private void MAS_Load(object sender, EventArgs e)
        {
            //nextButton();
            //backButton();
            //Scene = new CharacterCreation();
            SetScene(Scene);


        }

        private void next_Click(object sender, EventArgs e)
        {
            
            
        }

        private void travel_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            MessageBox.Show(button.Text); 

        }
    }
}

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
        private Room scene;
        public Room Scene
        {
            get { return scene; }
            set
            {
                scene = value;
                CurLocation.Text = scene.location();
                TBMainTextWin.Text = scene.readDesc();

                for (int i = 0; i < scene.buttonlist.Count; i++)
                {
                    ActionBar.Controls.Add(scene.buttonlist[i]);
                }
            }
        }

        public MAS()
        {
            InitializeComponent();
        }

        public void scDialog(string dia)
        {
            TBMainTextWin.Text = dia;
        }

        public void clrButtons()
        {
            ActionBar.Controls.Clear();
        }
        //Single Button
        public void addButtons(Button but)
        {   ActionBar.Controls.Add(but);    }
        public void setButtons(Button but)
        {
            clrButtons();
            ActionBar.Controls.Add(but);
            
        }
        //Multi buttons
        public void addButtons(List<Button> but)
        {
            for (int i = 0; i < scene.buttonlist.Count; i++)
            {
                ActionBar.Controls.Add(but[i]);
            }
        }
        public void setButtons(List<Button> but)
        {
            clrButtons();
            for (int i = 0; i < scene.buttonlist.Count; i++)
            {
                ActionBar.Controls.Add(but[i]);
            }
        }

        private void MAS_Load(object sender, EventArgs e)
        {
            //SetScene(Scene);
            Scene = new Workshop(this);
        }

    }
}

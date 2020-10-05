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
using MAS.Character;
using MAS.Character.PC;

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

                //if (scene.buttonlist.Count)

                for (int i = 0; i < scene.buttonlist.Count; i++)
                {
                    ActionBar.Controls.Add(scene.buttonlist[i]);
                }
            }
        }
        public Player pc;
        
        public MAS()
        {
            InitializeComponent();
        }
        //==================================================================================
        public void scDialog(string dia)
        {
            TBMainTextWin.Text = dia;
            
        }

        public void abLeft()
        {
           ActionBar.FlowDirection = FlowDirection.LeftToRight;
        }
        public void abRight()
        {
            ActionBar.FlowDirection = FlowDirection.RightToLeft;
        }
        public void abAdd(Control el)
        {
            ActionBar.Controls.Add(el);
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

        public void actionBarBreak(Control control, bool value)
        {
            ActionBar.SetFlowBreak(control, value);
        }

        public void updateStats()
        {
            string format = "+0;-#;";
            StrScore.Text = pc.getAbilityScore(Stat.STR) + " (" + pc.calModifier(pc.getAbilityScore(Stat.STR)).ToString(format) + ")";
            RfxScore.Text = pc.getAbilityScore(Stat.RFX) + " (" + pc.calModifier(pc.getAbilityScore(Stat.RFX)).ToString(format) + ")";
            ConScore.Text = pc.getAbilityScore(Stat.CON) + " (" + pc.calModifier(pc.getAbilityScore(Stat.CON)).ToString(format) + ")";
            CunScore.Text = pc.getAbilityScore(Stat.CUN) + " (" + pc.calModifier(pc.getAbilityScore(Stat.CUN)).ToString(format) + ")";
            PreScore.Text = pc.getAbilityScore(Stat.PRE) + " (" + pc.calModifier(pc.getAbilityScore(Stat.PRE)).ToString(format) + ")";
            IntScore.Text = pc.getAbilityScore(Stat.INT) + " (" + pc.calModifier(pc.getAbilityScore(Stat.INT)).ToString(format) + ")";
        }

        //public string nameFieldgen()
        //{
        //    clrButtons();
        //    abLeft();
        //    bool yes = false;

        //    TextBox NameInput = new TextBox()
        //    {
        //        Name = "NameInput",
        //        TabIndex = 9,
        //        Size = new Size(362, 49),
        //        Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)))
        //    };

        //    abAdd(NameInput);

        //    Button okButton = new Button() { Size = new Size(132, 50), TabIndex = 7, Name = "OK", Text = "Ok", UseVisualStyleBackColor = true };
        //    okButton.Click += (sender, e) => { yes = true; Scene.skip(1); };
        //    abAdd(okButton);

        //    //AcceptButton = okButton;

        //    return yes ? NameInput.Text : "";
        //}

        //START
        //==================================================================================
        public void returnToWorkshop(object sender, EventArgs e)
        {
            Scene = new Workshop(this);
        }

        private void MAS_Load(object sender, EventArgs e)
        {
            //SetScene(Scene);
            Scene = new CharacterCreation(this);
        }

        private void ActionBar_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}

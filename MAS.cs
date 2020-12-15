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
        //Player
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
            StrScore.Text = pc.getAbilityScore(Stat.STR).ToString();
            RfxScore.Text = pc.getAbilityScore(Stat.RFX).ToString();
            ConScore.Text = pc.getAbilityScore(Stat.CON).ToString();
            CunScore.Text = pc.getAbilityScore(Stat.CUN).ToString();
            PreScore.Text = pc.getAbilityScore(Stat.PRE).ToString();
            IntScore.Text = pc.getAbilityScore(Stat.INT).ToString();
        }
        public void updateHP() {
            labelHPMax.Text = pc.HPmax.ToString();
            labelHPCurrent.Text = pc.HP.ToString();
            hitPointsBar.Maximum = pc.HPmax;
            hitPointsBar.Value = pc.HP;
            hitPointsBar.PerformStep();
        }

        public void returnToWorkshop(object sender, EventArgs e)
        {
            Scene = new Workshop(this);
        }

        private void MAS_Load(object sender, EventArgs e)
        {
            //SetScene(Scene);
            Scene = new CharacterCreation(this);
        }

        private void StrScore_TextChanged(object sender, EventArgs e)
        {
            string format = "+0;-#;";
            strMod.Text = "(" + pc.STR.ToString(format) + ")";
        }

        private void RfxScore_TextChanged(object sender, EventArgs e)
        {
            string format = "+0;-#;";
            rfxMod.Text = "(" + pc.RFX.ToString(format) + ")";
        }

        private void ConScore_TextChanged(object sender, EventArgs e)
        {
            string format = "+0;-#;";
            conMod.Text = "(" + pc.CON.ToString(format) + ")";
        }

        private void CunScore_TextChanged(object sender, EventArgs e)
        {
            string format = "+0;-#;";
            cunMod.Text = "(" + pc.CUN.ToString(format) + ")";
        }

        private void PreScore_TextChanged(object sender, EventArgs e)
        {
            string format = "+0;-#;";
            preMod.Text = "(" + pc.PRE.ToString(format) + ")";
        }

        private void IntScore_TextChanged(object sender, EventArgs e)
        {
            string format = "+0;-#;";
            intMod.Text = "(" + pc.INT.ToString(format) + ")";
        }

        private void labelHP_Click(object sender, EventArgs e)
        {

        }
    }
}

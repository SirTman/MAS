using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    public class Breasts
    {
        //private int Rating {
        //    set => Rating = (int)cupSize;
        //    get => Rating;
        //}
        BreastCup cupSize;
        enum BreastCup
        {
            FLAT,
            A,
            B,
            C,
            D,
            DD,
            DD_BIG,
            E,
            E_BIG,
            EE,
            EE_BIG,
            F,
            F_BIG,
            FF,
            FF_BIG,
            G,
            G_BIG,
            GG,
            GG_BIG,
            H,
            H_BIG,
            HH,
            HH_BIG,
            I,
            I_BIG,
            II,
            II_BIG,
            J,
            J_BIG,
            JJ,
            JJ_BIG,
            K,
            K_BIG,
            KK,
            KK_BIG,
            L,
            L_BIG,
            LL,
            LL_BIG,
            M,
            M_BIG,
            MM,
            MM_BIG,
            MMM,
            MMM_LARGE,
        }
        


        private int breastNum = 2;
        private int nipNum = 1; ///Nipple Per Breast
        private double nipLength = 5.1; ///cm

        private double lactation = 0.0; ///x0.0

        private string nipColour = "pink";
        private string nipPier;
        private bool pussyNips = false; ///Can be fucked

        public Breasts()
        {
            this.cupSize = BreastCup.A;
        }
        public Breasts(int size)
        {
            this.cupSize = (BreastCup)size;
        }

        public void changeSize(int Size)
        {
            int intialSize = (int)this.cupSize;
            intialSize += Size;
            if (intialSize < 0) intialSize = 0;

            this.cupSize = (BreastCup)intialSize;
        }

        public void SetSize(int Size)
        {
            this.cupSize = (BreastCup)Size;
        }
    }
}

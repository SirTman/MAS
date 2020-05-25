using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character.Sexual
{
    class Breasts
    {
        int rating;
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

        int breastNum;
        int nipNum; //Nipple Per Breast
        double nipLength;

        double lactation;

        string nipColour;
        string nipPier;
        Boolean pussyNips = false;

    }
}

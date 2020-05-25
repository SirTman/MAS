using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character.Sexual
{
    class Penis
    {
        string cockType;
        double length;
        double thickness;
        bool knot = false;
        double knotMULT; //x0.0

        string cockPier;

        Penis(string type, double len, double thi) {
            this.cockType = type;
            this.length = len;
            this.thickness = thi;
        }

        Penis(string type, double len, double thi, bool knot)
        {
            this.cockType = type;
            this.length = len;
            this.thickness = thi;
            this.knot = true;
            this.knotMULT = 1.0;
        }

        Penis(string type, double len, double thi, bool knot, double mult)
        {
            this.cockType = type;
            this.length = len;
            this.thickness = thi;
            this.knot = true;
            this.knotMULT = mult;
        }
    }
}

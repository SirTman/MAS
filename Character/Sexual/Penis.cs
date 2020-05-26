using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character
{
    public class Penis
    {
        string cockType;
        double length;//cm
        double thickness;//cm
        bool knot = false;
        double knotMULT; //x0.0

        string cockPier;

        public Penis()
        {
            this.cockType = "human";
            this.length = 20.0;
            this.thickness = 5.1;
        }

        public Penis(string type, double len, double thi) {
            this.cockType = type;
            this.length = len;
            this.thickness = thi;
        }

        public Penis(string type, double len, double thi, bool knot)
        {
            this.cockType = type;
            this.length = len;
            this.thickness = thi;
            this.knot = true;
            this.knotMULT = 1.0;
        }

        public Penis(string type, double len, double thi, bool knot, double mult)
        {
            this.cockType = type;
            this.length = len;
            this.thickness = thi;
            this.knot = true;
            this.knotMULT = mult;
        }
    }
}

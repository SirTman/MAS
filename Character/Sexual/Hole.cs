using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Character.Sexual
{
    class Hole
    {
        double capacity;
        private bool isWet = false;
        protected looseness tightness;
        protected enum looseness
        {
            tight,
            normal,
            loose,
            gaping,
            gapingWide,
            clownCar
        }

        public Hole()
        {
            this.tightness = looseness.tight;
            this.capacity = 25.0;
        }
    }

    class Vagina : Hole
    {
        private string vagType;
        double clitLen;
        double capacity;

        public Vagina()
        {
            this.vagType = "Human";
            this.tightness = looseness.tight;
            this.capacity = 25.0;
            this.clitLen = 0.0;
        }
    }
}

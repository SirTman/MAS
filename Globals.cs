using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS
{
    public enum StartingRace
    {
        Human,
        Rabbit,
        Cat,
        Goat,
        Dog,
        Horse,
        Cow,
        //Custom
    }

    public enum Sex
    {
        male,
        female,
        andromorph,
        gynomorphy,
        herm,
        maleherm,
        undefined
    }

    public enum Stat
    {
        STR, RFX, CON, CUN, PRE, INT
    }

    public static class Globals
    {
        public const int bw = 100;
        public const int bh = 40;

        public static StartingRace PC_OriginalRace;
        public static void setStartingRace(StartingRace type) => PC_OriginalRace = type;

        public static Sex PC_OrginalGender;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperHelper
{
    /**
     * Klasa reprezentująca dane w tabeli poszczególnych lig
     */
    class ShowDataClass
    {
        public int position { get; set; }
        public String name { get; set; }
        public int mWin { get; set; }
        public int mDraw { get; set; }
        public int mLose { get; set; }
        public int goals { get; set; }
        public int lostGoals { get; set; }
        public int points { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperHelper
{
    /**
     * Klasa służąca do tworzenia obiektów drużyn
     */
    public class Teams
    {
        public String idTeam { get; set; }
        public String name { get; set; }
        public String leagueID { get; set; }
        public int goals { get; set; }
        public int lostGoals { get; set; }
        public int points { get; set; }
        public int goalBalance { get; set; }
        public int mWin { get; set; }
        public int mDraw { get; set; }
        public int mLose { get; set; }

    }
}

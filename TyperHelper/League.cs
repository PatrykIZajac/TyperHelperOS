using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperHelper
{
    /**
     * Klasa służąca do tworzenia obiektów lig
     */
    public class League
    {
        public String idLeague { get; set; }
        public String name { get; set; }
        public int countOfTeamsInLeague { get; set; }
        public int countOfGoalsInLeague { get; set; }
        public List<Teams> teams { get; set; }
    }
}

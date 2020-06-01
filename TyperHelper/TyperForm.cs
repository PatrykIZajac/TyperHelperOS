using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyperHelper
{
    public partial class TyperForm : Form
    {
        public TyperForm()
        {
            InitializeComponent();
        }
        
        Teams TeamA = new Teams();
        Teams TeamB = new Teams();
        League LeagueA = new League();
        League LeagueB = new League();

       /**
        * W tym bloku kodu tworzymy zmienne statyczne które bedą odpowiedzialne
        * za wywołanie, odebranie oraz mappowanie do obiektu requestu
        */
        static WebRequest request = HttpWebRequest.Create("link requesta");
        static WebResponse response = request.GetResponse();
        static StreamReader reader = new StreamReader(response.GetResponseStream());

        static String leaguesJSON = reader.ReadToEnd();

        List<League> leaguesListA = JsonConvert.DeserializeObject<List<League>>(leaguesJSON);
        List<League> leaguesListB = JsonConvert.DeserializeObject<List<League>>(leaguesJSON);

        /**
         * Metoda po utworzeniu się formularzu TyperForm
         * wypełnia poszczególne comboboxy listami obiektów
         */
        private void TyperForm_Load(object sender, EventArgs e)
        {
            comboBoxLeague1.DataSource = leaguesListA;
            comboBoxLeague1.DisplayMember = "name";
            comboBoxLeague2.DataSource = leaguesListB;
            comboBoxLeague2.DisplayMember = "name";

            updateLeaguesData();
            updateObjectSelectedTeam();
        }

        private void comboBoxLeague1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateLeaguesData();
            updateObjectSelectedTeam();
        }

        private void comboBoxTeams1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateObjectSelectedTeam();
        }

        private void comboBoxLeague2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateLeaguesData();
            updateObjectSelectedTeam();
        }

        private void comboBoxTeams2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateObjectSelectedTeam();
        }

        /**
         * Metoda ta jest odpowiedzialna za aktualizacje danych
         * obiektu którego w danym momencie wybraliśmy z listy
         */
        public void updateObjectSelectedTeam()
        {
            TeamA = comboBoxTeams1.SelectedItem as Teams;
            TeamB = comboBoxTeams2.SelectedItem as Teams;
        }

        /**
         * Metoda aktualizuje listę wypełnioną obiektami poszczególnych
         * teamów w zależności od ligi którą wcześniej wybierzemy
         */
        private void updateLeaguesData()
        {
            LeagueA = comboBoxLeague1.SelectedItem as League;
            if (LeagueA != null)
            {
                List<Teams> teamListA = LeagueA.teams;

                comboBoxTeams1.DataSource = teamListA;
                comboBoxTeams1.DisplayMember = "name";
            }

            LeagueB = comboBoxLeague2.SelectedItem as League;
            if (LeagueB != null)
            {
                List<Teams> teamListB = LeagueB.teams;

                comboBoxTeams2.DataSource = teamListB;
                comboBoxTeams2.DisplayMember = "name";

            }
        }

        /**
         * Metoda odpowiedzialna za wyliczenie szans poszczególnej drużyny
         * @param[in] team obiekt drużyny
         * @param[in] leagueStrength zmienna przechowująca siłę danej ligi
         */
        public double Chance(Teams team, double leagueStrength)
        {
            //logika
        }

        /**
         * Metoda licząca siłę danej ligi 
         * @param[in] league obiekt ligi
         */
        public double leagueStrength(League league)
        {
            //logika
        }

        /**
         * Metoda licząca siłę danego zespołu
         * @param[in] team obiekt drużyny 
         */
        public double teamStrength(Teams team)
        {
            //logika
        }

        
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            
            
        }

       /**
        * Metoda obsługująca SubmitButton który pokazuję 
        * uzytkownikowi szansę drużyn które wybrał
        */

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            double leagueAStrength = leagueStrength(LeagueA);
            double leagueBStrength = leagueStrength(LeagueB);
            double teamAstrength = teamStrength(TeamA);
            double teamBstrength = teamStrength(TeamB);

            double chanceA = Chance(TeamA, leagueAStrength);
            double chanceB = Chance(TeamB, leagueBStrength);

            double percent = (chanceA + chanceB);
            double percentPerSideA = ((chanceA / percent) * 100);
            double percentPerSideB = ((chanceB / percent) * 100);

            if(percentPerSideA > percentPerSideB)
            {
                label6.ForeColor = Color.Green;
                label7.ForeColor = Color.Red;

                label6.Text = Math.Round(percentPerSideA).ToString() + "%";
                label7.Text = Math.Round(percentPerSideB).ToString() + "%";
            }
            else if (percentPerSideA == percentPerSideB)
            {
                label6.ForeColor = Color.Orange;
                label7.ForeColor = Color.Orange;

                label6.Text = Math.Round(percentPerSideA).ToString() + "%";
                label7.Text = Math.Round(percentPerSideB).ToString() + "%";
            }
            else
            {
                label7.ForeColor = Color.Green;
                label6.ForeColor = Color.Red;
                
                label6.Text = Math.Round(percentPerSideA).ToString() + "%";
                label7.Text = Math.Round(percentPerSideB).ToString() + "%";
            }


            Console.WriteLine("szanse duzyny "+ TeamA.name + ":" + chanceA);
            Console.WriteLine("sila ligi "+ LeagueA.name + ":" + leagueAStrength);
            Console.WriteLine("szanse duzyny "+ TeamB.name+ ":" + chanceB);
            Console.WriteLine("sila ligi " + LeagueB.name + ":" + leagueBStrength);
           
        }

        /**
         * Metoda obsługująca przycisk który odpala w przeglądarce adres strony
         * bukmachera
         */
        private void fortunaBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.efortuna.pl/");
        }

        /**
         * Metoda obsługująca przycisk który odpala w przeglądarce adres strony
         * bukmachera
         */
        private void betClicBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.betclic.pl/");
        }

        /**
         * Metoda obsługująca przycisk który odpala w przeglądarce adres strony
         * bukmachera
         */
        private void stsBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sts.pl/");
        }
    }
        
      
        
}

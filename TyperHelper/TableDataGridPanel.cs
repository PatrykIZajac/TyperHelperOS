using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace TyperHelper
{
    public partial class tableDataGridPanel : Form
    {
        public tableDataGridPanel()
        {
            InitializeComponent();
        }

        League League = new League();

       /**
        * W tym bloku kodu tworzymy zmienne statyczne które bedą odpowiedzialne
        * za wywołanie, odebranie oraz mappowanie do obiektu requestu
        */

        static WebRequest request = HttpWebRequest.Create("link do requesta");
        static WebResponse response = request.GetResponse();
        static StreamReader reader = new StreamReader(response.GetResponseStream());

        static String leaguesJSON = reader.ReadToEnd();

        List<League> leaguesList = JsonConvert.DeserializeObject<List<League>>(leaguesJSON);

        /**
         * Metoda odpowiada za wypełnienie listy lig obiektami 
         * gdy tworzy się formularz TableDataGridPanel
         */
        private void TableDataGridPanel_Load(object sender, EventArgs e)
        {
            comboBoxLeagues.DataSource = leaguesList;
            comboBoxLeagues.DisplayMember = "name";
            updateLeaguesData();
            updateObjectSelectedTeam();
        }

        /**
         * Metoda aktualizuje tabele w zależności od wybranej ligi
         */
        private void updateLeaguesData()
        {
            League = comboBoxLeagues.SelectedItem as League;
            if (League != null)
            {
                List<Teams> teamList = League.teams;
                List<ShowDataClass> tableOfTeams = new List<ShowDataClass>();
                int counter = 1;

                foreach(var item in League.teams){
                    ShowDataClass obj = new ShowDataClass();
                    obj.position = counter;
                    obj.name = item.name;
                    obj.mWin = item.mWin;
                    obj.mDraw = item.mDraw;
                    obj.mLose = item.mLose;
                    obj.goals = item.goals;
                    obj.lostGoals = item.lostGoals;
                    obj.points = item.points;
                    tableOfTeams.Add(obj);
                    counter++;
                }

                dataGridView1.DataSource = tableOfTeams;
                dataGridView1.Columns[0].HeaderText = "Pozycja";
                dataGridView1.Columns[1].HeaderText = "Nazwa";
                dataGridView1.Columns[2].HeaderText = "Wygrane";
                dataGridView1.Columns[3].HeaderText = "Remisy";
                dataGridView1.Columns[4].HeaderText = "Przegrane";
                dataGridView1.Columns[5].HeaderText = "Zdobyte gole";
                dataGridView1.Columns[6].HeaderText = "Stracone gole";
                dataGridView1.Columns[7].HeaderText = "Punkty";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[1].Width = 110;
            }
 
        }

        /**
        * Metoda ta jest odpowiedzialna za aktualizacje danych
        * obiektu którego w danym momencie wybraliśmy z listy
        */
        public void updateObjectSelectedTeam()
        {
            League = comboBoxLeagues.SelectedItem as League;
        }

        private void comboBoxLeagues_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            updateObjectSelectedTeam();
            updateLeaguesData();
        }
    }
}

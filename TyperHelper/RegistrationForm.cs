using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Threading;
using Newtonsoft.Json;

namespace TyperHelper
{
    public partial class RegistrationForm : Form
    {
        Thread th;
        
        public RegistrationForm()
        {
            InitializeComponent();
            
        }

        /**
        * Inicjalizacja bazy FireBase.
        */
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "klucz",
            BasePath = "link"
        };

        /**
        * Utworzenie obiektu klienta bazy.
        */
        IFirebaseClient client;

        /**
         * Gdy formularz RegistrationForm się załaduję utworzy się
         * obiekt klienta 
         */
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                

            }
            catch
            {
                MessageBox.Show("No internet or connection problem");
            }

            try
            {
                checkStatus();
            }
            catch
            {
                MessageBox.Show("Data retrieve failure");
            }

        }

 
        /**
         * Przycisk wysyła zapytanie do bazy ktore rejestruje użytkownika, uprzednio sprawdza 
         * czy dane pola są zapełnione
         */
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(registerUsernameTextBox.Text) &&
                string.IsNullOrWhiteSpace(registerPasswordTextBox.Text))
            {
                MessageBox.Show("wypelnij wszystkie pola!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(registerUsernameTextBox.Text))
                {
                    MessageBox.Show("wypelnij pole nazwy uzytkownika!");
                }

                if (string.IsNullOrWhiteSpace(registerPasswordTextBox.Text))
                {
                    MessageBox.Show("Wypełnij pole hasła");
                }
            }


            if (!string.IsNullOrWhiteSpace(registerUsernameTextBox.Text) &&
               !string.IsNullOrWhiteSpace(registerPasswordTextBox.Text))
            {
                User user = new User()
                {
                    Username = registerUsernameTextBox.Text,
                    Password = registerPasswordTextBox.Text
                };

                SetResponse set = client.Set("Users/" + registerUsernameTextBox.Text, user);

                MessageBox.Show("Successful registered!");
                registerUsernameTextBox.Clear();
                registerPasswordTextBox.Clear();

            }

        }

        /**
         * Metoda obsługująca przycisk który jest odpowiedzialny 
         * za zamknięcię formularzu RegistrationForm 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Metoda obsługująca przycisk który jest odpowiedzialny
         * za pokazanie hasła które użytkownik wpiszę
         */
        private void showPasswordBtn_MouseEnter(object sender, EventArgs e)
        {
            registerPasswordTextBox.UseSystemPasswordChar = false;
        }

        /**
         * Metoda obsługująca przycisk który jest odpowiedzialny
         * za ukrycie hasła które użytkownik wpiszę
         **/
        private void showPasswordBtn_MouseLeave(object sender, EventArgs e)
        {
            registerPasswordTextBox.UseSystemPasswordChar = true;
        }

        /**
         * Metoda obsługuję przycisk który jest odpowiedzialny za powrót 
         * do formularzu LoginForm
         **/
        private void backToLoginFormBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(openLoginForm);
            th.Start();
            this.Close();
        }

        /**
         * Metoda ta pozwala na otworzenie formularzu jako nową aplikację
         **/
        private void openLoginForm()
        {
            Application.Run(new LoginForm());
        }

        /**
         * Metoda która sprawdza stan checkboxa z formularza LoginForm 
         * i na podstawię statusu zmienia na tryb Dark Mode
         **/
        public void checkStatus()
        {
            FirebaseResponse res = client.Get("Status");
            string status = res.ResultAs<string>();
            
  
            if (status == "true")
            {
                    this.BackColor = Color.FromArgb(0, 0, 0);
                    this.registerUsernameTextBox.BackColor = Color.FromArgb(0, 0, 0);
                    this.registerPasswordTextBox.BackColor = Color.FromArgb(0, 0, 0);
                    this.registerPasswordTextBox.ForeColor = Color.White;
                    this.registerUsernameTextBox.ForeColor = Color.White;
                    this.label1.ForeColor = Color.White;
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    this.backToLoginFormBtn.ForeColor = Color.White;
                    this.showPasswordBtn.BackgroundImage = TyperHelper.Properties.Resources.eyeWhite;
                    this.button1.BackgroundImage = TyperHelper.Properties.Resources.closeWhite;
            }else{

                    this.BackColor = Color.FromArgb(255, 255, 255);
                    this.registerUsernameTextBox.BackColor = Color.White;
                    this.registerPasswordTextBox.BackColor = Color.White;
                    this.registerPasswordTextBox.ForeColor = Color.Gray;
                    this.registerUsernameTextBox.ForeColor = Color.Gray;
                    this.label1.ForeColor = Color.Gray;
                    this.label2.ForeColor = Color.Gray;
                    this.label3.ForeColor = Color.Gray;
                    this.backToLoginFormBtn.ForeColor = Color.Black;
                    this.showPasswordBtn.BackgroundImage = TyperHelper.Properties.Resources.eye;
                    this.button1.BackgroundImage = TyperHelper.Properties.Resources.close;

             }
  
        }

        
    }
}

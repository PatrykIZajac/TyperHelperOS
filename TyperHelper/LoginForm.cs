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

namespace TyperHelper
{
    public partial class LoginForm : Form
    {
        Thread th;
        Thread th2;
       
        public LoginForm()
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
         * Metoda odpowiedzialna za utworzenie obiektu klienta gdy
         * formularz LoginForm się załaduje  
         */
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                SetResponse set = client.Set("Status", "false");
                
            }
            catch
            {
                MessageBox.Show("No internet or connection problem");
            }
        }

        /**
         * Przycisk otwiera panel rejestracji.
         */
        private void registrationBtn_Click(object sender, EventArgs e)
        {

            th2 = new Thread(openRegistrationForm);
            th2.Start();
            this.Close();
        }

        /**
         * Przycisk wysyła requesta do bazy, jeśli dane się zgadzają otwiera nowy formularz, w przeciwnym 
         * wypadku prosi o poprawne wprowadzenie danych logowania.
         */
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) &&
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            FirebaseResponse res = client.Get("Users/" + usernameTextBox.Text);
            User ResUser = res.ResultAs<User>(); // database result

            User CurUser = new User() {
                Username = usernameTextBox.Text,
                Password = passwordTextBox.Text
            };

            if (User.isEqual(ResUser, CurUser))
            {
                th = new Thread(openAppForm); 
                th.Start();
                this.Close();
            }
            else
            {
                User.ShowError();
            }
        }

        /**
        * Metoda ta jest odpowiedzialna za uruchomienie formularzu z główną aplikacją.
        */
        private void openAppForm()
        { 
            Application.Run(new AppForm());
        }

        private void openRegistrationForm()
        {
            Application.Run(new RegistrationForm());
        }

        private void showPasswordBtn_MouseEnter(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
        }

        private void showPasswordBtn_MouseLeave(object sender, EventArgs e)
        {
           passwordTextBox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * checkbox1 odpowiada za zmianę motywu panelu logowania i rejestracji 
         * w tryb Dark Mode
         */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            { 
                SetResponse set = client.Set("Status","true");
                
                this.BackColor = Color.FromArgb(0, 0, 0);
                this.checkBox1.ForeColor = Color.White;
                this.usernameTextBox.BackColor = Color.FromArgb(0, 0, 0);
                this.passwordTextBox.BackColor = Color.FromArgb(0, 0, 0);
                this.passwordTextBox.ForeColor = Color.White;
                this.usernameTextBox.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.registrationBtn.ForeColor = Color.White;
                this.showPasswordBtn.BackgroundImage = TyperHelper.Properties.Resources.eyeWhite;
                this.button1.BackgroundImage = TyperHelper.Properties.Resources.switchWhite;
  
            }
             else{
                SetResponse set = client.Set("Status", "false");

                this.BackColor = Color.FromArgb(255, 255, 255);
                this.checkBox1.ForeColor = Color.Black;
                this.usernameTextBox.BackColor = DefaultBackColor;
                this.passwordTextBox.BackColor = DefaultBackColor;
                this.label1.ForeColor = Color.Gray;
                this.label2.ForeColor = Color.Gray;
                this.label3.ForeColor = Color.Gray;
                this.registrationBtn.ForeColor = Color.Black;
                this.passwordTextBox.ForeColor = Color.Black;
                this.usernameTextBox.ForeColor = Color.Black;
                this.showPasswordBtn.BackgroundImage = TyperHelper.Properties.Resources.eye;
                this.button1.BackgroundImage = TyperHelper.Properties.Resources._switch;
            }
        }

        
    }
}

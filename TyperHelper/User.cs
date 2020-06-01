using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyperHelper
{
    class User
    {
        public string Username { get; set;}
        public string Password { get; set;}

        private static string error = "Nie ma takiego uzytkownika, popraw dane!";

        /**
         * Metoda wyświetla komunikat jako messageBox o niepoprawnym loginie bądż haśle
         */
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        /**
         * Metoda sprawdza czy podany login bądź hasło wystepuję w bazie
         * @param: bool
         */
        public static bool isEqual(User user1, User user2)
        {
            if (user1 == null || user2 == null)
            {
                return false;
            }

            if (user1.Username != user2.Username)
            {
                error = "Nie ma takiego uzytkownika, popraw dane!";
            }
            else if (user1.Password != user2.Password)
            {
                error = "Hasło bądź login nie prawidłowy!";
                return false;
            }
            return true;
        }
    }

   
}

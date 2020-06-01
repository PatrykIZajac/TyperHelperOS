using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace TyperHelper
{
    public partial class AppForm : Form
    {
        Thread th;
        public AppForm()
        {
            InitializeComponent();
        }
        private void AppForm_Load(object sender, EventArgs e)
        {
            openChildForm(new TyperForm());

        }
        private Form activeForm = null;

        /**
         * Metoda pozwalająca na przesłanianie formularzy
         */
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                activeForm = childForm;
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            TyperPanel.Controls.Add(childForm);
            TyperPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /**
         * Metoda obsługuję przycisk który ma za zadanie
         * przesłonić poprzednika i w jego miejsce 
         * odpalić formularz TyperForm
         */
        private void DisplayTyperBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new TyperForm());
        }

        /**
        * Metoda obsługuję przycisk który ma za zadanie
        * przesłonić poprzednika i w jego miejsce 
        * odpalić formularz tableDataGridPanel
        */
        private void DisplayTableData_Click(object sender, EventArgs e)
        {
            openChildForm(new tableDataGridPanel());
            
        }
        /**
         * Metoda obsługuję przycisk który słuzy do wylogowania się
         * z apliakcji, włącza formularz LoginForm
         */
        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(openLoginForm);
            th.Start();
            this.Close();
        }
        private void openLoginForm()
        {
            Application.Run(new LoginForm());
        }

       
    }
}

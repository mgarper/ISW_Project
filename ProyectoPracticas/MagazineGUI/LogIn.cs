using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    public partial class LogIn : Form
    {
        private IMagazineService ms;
        private MagazineAPP app;
        public LogIn(IMagazineService service, MagazineAPP app)
        {
            InitializeComponent();
            ms = service;
            this.app = app;
            LoadData();
        }

        public void LoadData()
        {
            loginUser.Text = "";
            pswdUser.Text = "";
        }

        private void logIn(object sender, EventArgs e)
        {
            string isLoggedIn = ms.SignIn(loginUser.Text, pswdUser.Text);
            if (isLoggedIn=="User")
            {
                app.Show();
                app.startSession();
                this.Close();
            }
            else
            {
                string msg = "";
                string header = "";
                if (isLoggedIn == "Login")
                {
                    msg = "El login introducido no coincide con ningún usuario.";
                    header = "Nombre de usuario incorrecto";
                }
                else
                {
                    msg = "La contraseña no se corresponde con el usuario introducido.";
                    header = "Contraseña incorrecta";
                }
                MessageBox.Show(this,
                msg, header,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void goBackToMenu(object sender, FormClosingEventArgs e)
        {
            app.mainPage();
            app.Show();
        }
    }
}

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
    public partial class SignUp : Form
    {
        private IMagazineService Service;
        private MagazineAPP app;
        public SignUp(IMagazineService ims, MagazineAPP ma)
        {
            InitializeComponent();
            Service = ims;
            app = ma;
        }

        private void registerUser(object sender, EventArgs e)
        {
            if(nombreUser.Text != "" && apellidosUser.Text != "" && idUser.Text != "" && emailUser.Text != "" &&
                areasDeInteres.Text != "" && loginUser.Text != "" && pswdUser.Text != "" && pswdConfirmation.Text != "")
            {
                if (pswdUser.Text == pswdConfirmation.Text)
                {
                    string result = Service.SignUp(idUser.Text, nombreUser.Text, apellidosUser.Text, setNotifications.Checked, areasDeInteres.Text,
                        emailUser.Text, loginUser.Text, pswdUser.Text);
                    if (result == "User")
                    {
                        MessageBox.Show(this,
                        "El usuario ha sido registrado correctamente.",
                        "Nuevo usuario registrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        app.startSession();
                        app.Show();
                        this.Close();
                    }
                    else
                    {
                        string msg = "";
                        string header = "";
                        if (result == "Login")
                        {
                            msg = "Introduzca un nombre de usuario diferente.";
                            header = "Nombre de usuario existente";
                        }
                        else
                        {
                            msg = "El dni introducido ya existe.";
                            header = "Identificación ya existente";
                        }
                        MessageBox.Show(this,
                        msg, header,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this,
                        "Las contraseñas no coinciden.",
                        "Error al registrar usuario",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this,
                        "Por favor, rellene todos los campos",
                        "Campos no cumplimentados",
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

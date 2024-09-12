using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Services;

namespace MagazineGUI
{
    public partial class MagazineAPP : Form
    {
        private IMagazineService Service;

        private LogIn loginWind;
        private SignUp signUpWind;
        private WritePaper writePaper;
        private ShowPapers showPapers;
        private ShowUserPapers showUserPapers;
        private ShowPapersArea showPapersArea;
        private WriteIssue writeIssueWind;

        private bool signedIn;
        public MagazineAPP(IMagazineService service)
        {
            InitializeComponent();
            Service = service;

            loginWind = new LogIn(service, this);
            signUpWind = new SignUp(service, this);
            writePaper = new WritePaper(service, this);
            

            signedIn = false;
            LoadData();
        }

        public void LoadData()
        {
            Service.DBInitialization();

            logOutButton.Hide();
            sendPaper.Hide();
            changeAuthors.Hide();
            listPapers.Hide();
            writeIssue.Hide();
            evaluatePapers.Hide();

            loginWind.Hide();
        }

        public void mainPage()
        {
            loginWind = new LogIn(Service, this);
            signUpWind = new SignUp(Service, this);
        }

        public void goBackToMenu()
        {
            writePaper = new WritePaper(Service, this);
            showPapers = new ShowPapers(Service, this);
            showUserPapers = new ShowUserPapers(Service, this);
        }

        private void openLogIn(object sender, EventArgs e)
        {
            this.Hide();
            loginWind.Show();
        }

        public void startSession()
        {
            signedIn = true;

            signInButton.Hide();
            signUpButton.Hide();

            sendPaper.Show();
            changeAuthors.Show();
            logOutButton.Show();

            if(Service.IsChiefEditor())
            {
                listPapers.Show();
                writeIssue.Show();
            }
            if (Service.IsAreaEditor())
            {
                evaluatePapers.Show();
            }
        }

        private void openSignUpForm(object sender, EventArgs e)
        {
            this.Hide();
            signUpWind.Show();
        }

        private void logOut(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(this,
                    "¿Está seguro de que quiere cerrar la sesión?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if(answer == DialogResult.Yes)
            {
                signedIn = false;

                loginWind = new LogIn(Service, this);
                signUpWind = new SignUp(Service, this);

                signUpButton.Show();
                signInButton.Show();

                logOutButton.Hide();
                sendPaper.Hide();
                changeAuthors.Hide();
                listPapers.Hide();
                writeIssue.Hide();
                evaluatePapers.Hide();
            }
        }

        private void goToWritePaper(object sender, EventArgs e)
        {
            this.Hide();
            writePaper.Show();
        }

        private void goToShowPapers(object sender, EventArgs e)
        {
            showPapers = new ShowPapers(Service, this);
            this.Hide();
            showPapers.LoadData();
            showPapers.Show();
        }

        private void goToChangeAuthors(object sender, EventArgs e)
        {
            this.Hide();
            showUserPapers = new ShowUserPapers(Service, this);
            showUserPapers.Show();
        }

        private void showAreaPapers(object sender, EventArgs e)
        {

            showPapersArea = new ShowPapersArea(Service, this);
            this.Hide();
            showPapersArea.Show();
        }

        private void goToWriteIssue(object sender, EventArgs e)
        {
            writeIssueWind = new WriteIssue(Service, this);
            this.Hide();
            writeIssueWind.Show();
        }
    }
}

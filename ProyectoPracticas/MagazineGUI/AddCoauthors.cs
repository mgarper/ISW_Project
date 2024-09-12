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
    public partial class AddCoauthors : Form
    {
        IMagazineService ms;
        ShowUserPapers sup;
        WritePaper wp;
        int idPaper;
        string title;

        PaperDTO currentPaper;
        public AddCoauthors(IMagazineService serv, ShowUserPapers sup, int id, string t)
        {
            InitializeComponent();
            ms = serv;
            this.sup = sup;
            idPaper = id;
            title = t;
            LoadData();
        }

        public AddCoauthors(IMagazineService serv, WritePaper wp, int id, string t)
        {
            InitializeComponent();
            ms = serv;
            this.wp = wp;
            idPaper = id;
            title = t;
            LoadData();
        }

        public void LoadData()
        {
            paperTitle.Text = title;

            ICollection<PaperDTO> papers = ms.GetPapers();
            foreach (PaperDTO paper in papers)
            {
                if (idPaper == paper.GetId())
                {
                    currentPaper = paper;
                }
            }

            bindingPerson.DataSource = null;

            BindingList<object> bl = new BindingList<object>();
            foreach (string p in currentPaper.GetAuthors())
            {
                bl.Add(new
                {
                    ds_author = p,
                });
            }

            bindingPerson.DataSource = bl;
        }


        private void addNewCoauthor(object sender, EventArgs e)
        {
            if(coauthorId.Text != "" && coauthorName.Text != "" && coauthorSurname.Text != "")
            {
                bool b = ms.AnyadirCoautores(idPaper, coauthorId.Text);
                if(b)
                {
                    LoadData();
                    coauthorId.Clear();
                    coauthorName.Clear();
                    coauthorSurname.Clear();
                }
                else
                {
                    DialogResult r = MessageBox.Show(this,
                    "No puede añadir más coautores.",
                    "Lista completa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    addAuthor.Enabled = false;
                }
            }
            else
            {
                DialogResult r = MessageBox.Show(this,
                "Por favor, rellene todos los campos.",
                "Campos incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void lookForUser(object sender, EventArgs e)
        {
            string aux = ms.GetUserNameById(coauthorId.Text);

            string name = "";
            string surname = "";

            if(aux != "")
            {
                string[] list = aux.Split(' ');
                name = list[0];
                for(int i = 1; i < list.Length; i++)
                {
                    surname += list[i];
                }
            }

            coauthorName.Text = name;
            coauthorSurname.Text = surname;
        }
    }
}

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
    public partial class ShowPapers : Form
    {
        private IMagazineService Service;
        private MagazineAPP app;

        private ICollection<PaperDTO> papers;
        public ShowPapers(IMagazineService ms, MagazineAPP ma)
        {
            InitializeComponent();
            app = ma;   
            Service = ms;
            LoadData();
        }

        public void LoadData()
        {
            ICollection<int> issues = Service.GetIssues();
            areaComboBox.Items.Clear();
            areaComboBox.Items.Add("Todos");
            if (issues != null)
                foreach (int i in Service.GetIssues())
                    areaComboBox.Items.Add(""+i);
            areaComboBox.SelectedIndex = -1;
            areaComboBox.ResetText();
            paperBindingSource.DataSource = null;
        }

        private void goToMenu(object sender, FormClosingEventArgs e)
        {
            app.goBackToMenu();
            app.Show();
        }

        private void filterBy(object sender, EventArgs e)
        {
            string item = areaComboBox.SelectedItem.ToString();
            papers = Service.ListAllPapers();
            if (item != "Todos")
            {
                int issue = int.Parse(item);
                papers = Service.SortByIssue(issue, papers);
            }

            BindingList<object> bl = new BindingList<object>();
            foreach(PaperDTO p in papers)
            {
                string aux = "";
                foreach(string s in p.GetAuthors())
                {
                    if(s == p.GetAuthors().Last<string>())
                    {
                        aux += s + ".";
                    }
                    else
                    {
                        aux += s + ", ";
                    }
                }
                string issue = ""+p.GetBelongingIssue();

                if(issue == "-1")
                {
                    issue = "Sin ejemplar";
                }

                bl.Add(new {
                    ds_numero = issue,
                    ds_area = p.GetArea(),
                    ds_titulo = p.GetTitle(),
                    ds_autores = aux,
                    ds_estado = p.GetEstado()
                });
            }

            paperBindingSource.DataSource = bl;
        }
    }
}

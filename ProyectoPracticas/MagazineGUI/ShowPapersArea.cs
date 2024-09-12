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
    public partial class ShowPapersArea : Form
    {
        IMagazineService ms;
        MagazineAPP app;

        public ShowPapersArea(IMagazineService s, MagazineAPP ma)
        {
            InitializeComponent();
            ms = s;
            app = ma;
            LoadData();
        }

        public void LoadData()
        {
            string area = ms.getAreaFromResponsible();
            currentArea.Text = area;

            ICollection<PaperDTO> papers = ms.MostrarSinEvaluar(area);
            bindingEvaluation.DataSource = null;

            BindingList<object> bl = new BindingList<object>();
            foreach (PaperDTO p in papers)
            {
                string aux = "";
                foreach (string s in p.GetAuthors())
                {
                    if (s == p.GetAuthors().Last<string>())
                    {
                        aux += s + ".";
                    }
                    else
                    {
                        aux += s + ", ";
                    }
                }
                bl.Add(new
                {
                    ds_id = p.GetId(),
                    ds_titulo = p.GetTitle(),
                    ds_autores = aux,
                    ds_fechaEnvio = p.GetEnvío()
                });
            }

            bindingEvaluation.DataSource = bl;
        }

        private void goBackToMenu(object sender, FormClosedEventArgs e)
        {
            app.Show();
            app.goBackToMenu();
        }

        private void EvaluatePaper(object sender, EventArgs e)
        {
            if(papersGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow dg = papersGrid.SelectedRows[0];
                int id = Int32.Parse(dg.Cells[0].Value.ToString());
                string title = dg.Cells[1].Value.ToString();
                EvaluatePaper ep = new EvaluatePaper(ms, title, id);
                ep.ShowDialog();
                LoadData();
            } 
            else
            {
                DialogResult r = MessageBox.Show(this,
                    "Seleccione un artículo para evaluar",
                    "Error de selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }
    }
}

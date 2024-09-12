using Magazine.Entities;
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
    public partial class ShowUserPapers : Form
    {
        private MagazineAPP app;
        private IMagazineService ms;
        public ShowUserPapers(IMagazineService service, MagazineAPP app)
        {
            InitializeComponent();
            this.app = app;
            this.ms = service;
            LoadData();
        }
        public void LoadData()
        {
            ICollection<PaperDTO> papers = ms.GetPapers();
            paperBindingSource.DataSource = null;

            BindingList<object> bl = new BindingList<object>();
            foreach (PaperDTO p in papers)
            {
                bl.Add(new
                {
                    ds_id = p.GetId(),
                    ds_titulo = p.GetTitle()
                });
            }

            paperBindingSource.DataSource = bl;
        }

        private void goBackToMenu(object sender, FormClosingEventArgs e)
        {
            app.goBackToMenu();
            app.Show();
        }

        private void goToAddCoauthors(object sender, EventArgs e) // CHECK
        {
            if (paperGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow dg = paperGrid.SelectedRows[0];
                int id = Int32.Parse(dg.Cells[0].Value.ToString());
                string title = dg.Cells[1].Value.ToString();
                AddCoauthors ac = new AddCoauthors(ms, this, id, title);
                ac.ShowDialog();
            }
            else
            {
                DialogResult r = MessageBox.Show(this,
                    "Seleccione un artículo",
                    "Error de selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }
    }
}

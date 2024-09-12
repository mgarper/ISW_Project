using Magazine.BusinessLogic.Services;
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
    public partial class WriteIssue : Form
    {
        IMagazineService mserv;
        MagazineAPP app;

        ICollection<PaperDTO> pubPend;
        ICollection<PaperDTO> pub;

        public WriteIssue(IMagazineService ms, MagazineAPP ma)
        {
            InitializeComponent();
            mserv = ms;
            app = ma;

            buttonRight.Enabled = false;
            buttonLeft.Enabled = false;

            LoadDataIssue();
            LoadDataArea();
        }

        public void LoadDataIssue()
        {
            IssueDTO i = mserv.GetNextNumberIssue();
            numberIssue.Text = ""+i.GetNumber();
            dateTimePicker.Value = (DateTime) i.GetDateTime();
        }

        public void LoadDataArea()
        {
            ICollection<string> areas = mserv.GetAreas();
            selectedArea.Items.Clear();
            if (areas != null)
                foreach (string i in areas)
                    selectedArea.Items.Add(i);
            selectedArea.SelectedIndex = -1;
            selectedArea.ResetText();
            publicationSource.DataSource = null;
            pendingSource.DataSource = null;
        }

        private void filterBy(object sender, EventArgs e)
        {
            string item = selectedArea.SelectedItem.ToString();

            pubPend = mserv.GetPublicationPending(item);
            pub = mserv.GetPapers(item, Int32.Parse(numberIssue.Text));

            BindingList<object> bl1 = new BindingList<object>();
            foreach (PaperDTO p in pub)
            {
                bl1.Add(new
                {
                    ds_id = p.GetId(),
                    ds_titulo = p.GetTitle()
                });
            }

            publicationSource.DataSource = bl1;

            BindingList<object> bl2 = new BindingList<object>();
            foreach (PaperDTO p in pubPend)
            {
                bl2.Add(new
                {
                    ds_pendid = p.GetId(),
                    ds_pendtitulo = p.GetTitle()
                });
            }

            pendingSource.DataSource = bl2;

            if (gridPapers.SelectedRows.Count > 0)
            {
                buttonRight.Enabled = true;
            }
            else
            {
                buttonRight.Enabled = false;
            }

            if (gridPending.SelectedRows.Count > 0)
            {
                buttonLeft.Enabled = true;
            }
            else
            {
                buttonLeft.Enabled = false;
            }
        }

        public void updateView()
        {
            string item = selectedArea.SelectedItem.ToString();

            BindingList<object> bl1 = new BindingList<object>();
            foreach (PaperDTO p in pub)
            {
                bl1.Add(new
                {
                    ds_id = p.GetId(),
                    ds_titulo = p.GetTitle()
                });
            }

            publicationSource.DataSource = bl1;

            BindingList<object> bl2 = new BindingList<object>();
            foreach (PaperDTO p in pubPend)
            {
                bl2.Add(new
                {
                    ds_pendid = p.GetId(),
                    ds_pendtitulo = p.GetTitle()
                });
            }

            pendingSource.DataSource = bl2;

            if(gridPapers.SelectedRows.Count > 0)
            {
                buttonRight.Enabled = true;
            }
            else
            {
                buttonRight.Enabled = false;
            }

            if (gridPending.SelectedRows.Count > 0)
            {
                buttonLeft.Enabled = true;
            }
            else
            {
                buttonLeft.Enabled = false;
            }
        }

        private void goBackToMenu(object sender, FormClosingEventArgs e)
        {
            app.goBackToMenu();
            app.Show();
        }

        private void AddToPapers(object sender, EventArgs e)
        {
            DataGridViewRow dg = gridPending.SelectedRows[0];
            int id = Int32.Parse(dg.Cells[0].Value.ToString());

            Console.WriteLine(pub.Count + "-" + pubPend.Count);
            mserv.AddPaperToPublish(id,pub,pubPend);
            Console.WriteLine(pub.Count + "-" + pubPend.Count);
            updateView();
        }

        private void AddToPublicationPending(object sender, EventArgs e)
        {
            DataGridViewRow dg = gridPapers.SelectedRows[0];
            int id = Int32.Parse(dg.Cells[0].Value.ToString());

            Console.WriteLine(pub.Count + "-" + pubPend.Count);
            mserv.RemovePaperFromPublish(id,pub,pubPend);
            Console.WriteLine(pub.Count + "-" + pubPend.Count);

            updateView();
        }

        private void updateDataIssue(object sender, EventArgs e)
        {
            Console.WriteLine(pub.Count + "-" + pubPend.Count);
            ICollection<int> l1 = new List<int>();
            foreach(PaperDTO p in pub)
            {
                l1.Add(p.GetId());
            }

            ICollection<int> l2 = new List<int>();
            foreach (PaperDTO p in pubPend)
            {
                l2.Add(p.GetId());
            }

            mserv.UpdateNextIssue(selectedArea.SelectedItem.ToString(),l1,l2);

            DialogResult r = MessageBox.Show(this,
                "Los artículos han sido añadidos correctamente",
                "Ejemplar actualizado.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SetDate(object sender, EventArgs e)
        {
            bool res = mserv.SetDate(dateTimePicker.Value);
            if(res)
            {
                MessageBox.Show(this,
                "La fecha ha sido actualizada correctamente.",
                "Fecha actualizada.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this,
                "La fecha introducida es incorrecta.",
                "Error de fecha.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}

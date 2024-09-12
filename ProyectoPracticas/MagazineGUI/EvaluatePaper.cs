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
    public partial class EvaluatePaper : Form
    {
        IMagazineService ms;
        string titulo;
        int id;

        public EvaluatePaper(IMagazineService magserv, string t, int i)
        {
            InitializeComponent();
            ms = magserv;
            titulo = t;
            id = i;
            LoadData();
        }

        public void LoadData()
        {
            paperTitle.Text = titulo;

        }

        private void sendReview(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(this,
                    "¿Desea terminar la evaluación?",
                    "Evaluar artículo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                string txt = "";
                string area = ms.getAreaFromResponsible();
                if (comments.Text != "")
                {
                    txt = comments.Text;
                }
                ms.EvaluarArticulo(area, id, txt, approvedCheckbox.Checked, DateTime.Now);

                this.Close();
            }
            
        }
    }
}

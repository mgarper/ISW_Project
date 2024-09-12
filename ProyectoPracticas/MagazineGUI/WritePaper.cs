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
    public partial class WritePaper : Form
    {
        IMagazineService service;
        MagazineAPP app;
        public WritePaper(IMagazineService ms, MagazineAPP ma)
        {
            InitializeComponent();
            service = ms;
            app = ma;
        }

        private void storePaper(object sender, EventArgs e)
        {
            bool res = service.StorePaper(selectedArea.Text, paperTitle.Text);
            if(res)
            {
                DialogResult r = MessageBox.Show(this,
                "El artículo ha sido enviado correctamente", 
                "Envío de artículo finalizado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                if(r == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show(this,
                    "¿Desea añadir más autores?",
                    "Añadir autores",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if(result == DialogResult.Yes)
                    {
                        PaperDTO p = service.GetPapers().Last();
                        int id = p.GetId();
                        string title = p.GetTitle();
                        AddCoauthors ac = new AddCoauthors(service, this, id, title);
                        ac.ShowDialog();
                    } 
                }
                selectedArea.Clear();
                paperTitle.Clear();
            }
            else
            {
                MessageBox.Show(this,
                "El área introducida no existe.", 
                "Área de envío incorrecta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void openMenu(object sender, FormClosingEventArgs e)
        {
            app.goBackToMenu();
            app.Show();
        }
    }
}

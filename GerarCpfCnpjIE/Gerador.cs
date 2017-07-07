using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarCpfCnpjIE
{
    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            if (radioCNPJ.Checked)
            {
                if (radioPontos.Checked)
                {
                    edtResultado.Text = manager.GerarCnpj(true);
                }
                else
                {
                    edtResultado.Text = manager.GerarCnpj(false);
                }

            }
            else
            {
                if (radioPontos.Checked)
                {
                    edtResultado.Text = manager.GerarCpf(true);
                }
                else
                {
                    edtResultado.Text = manager.GerarCpf(false);
                }
            }           
        }
    }
}

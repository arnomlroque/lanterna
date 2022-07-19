using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanterna
{
    public partial class FormLanterna : Form
    {
        private Lanterna _lanterna;

        public FormLanterna()
        {
            InitializeComponent();
            _lanterna = new Lanterna();
        }

        private void FormLanterna_Load(object sender, EventArgs e)
        {
            InicializarLanterna();
        }

        private void InicializarLanterna()
        {
            AtualizarProgressbar();

            if (_lanterna.Ligada)
            {
                radioButtonLaternaOn.Checked = true;
            }
            else
            {
                radioButtonLaternaOff.Checked = true;
            }
            
        }

        private void buttonTrocarBateria_Click(object sender, EventArgs e)
        {
            _lanterna.Bateria.Trocar();
            AtualizarProgressbar();
        }

        private void timerBateria_Tick(object sender, EventArgs e)
        {
            _lanterna.Bateria.Descarregar();
            AtualizarProgressbar();
        }

        private void AtualizarProgressbar()
        {
            progressBarBateria.Value = _lanterna.Bateria.Porcentagem;
        }

        private void radioButtonLaternaOn_CheckedChanged(object sender, EventArgs e)
        {
            timerBateria.Start();
        }

        private void radioButtonLaternaOff_CheckedChanged(object sender, EventArgs e)
        {
            timerBateria.Stop();
        }
    }
}

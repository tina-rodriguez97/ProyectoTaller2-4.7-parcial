using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private bool todosLosCamposValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, txtNomAltaC)
                && validador.validarCampo(errorProvider, txtApeAltaC)
                && validador.validarCampo(errorProvider, txtDniAltaC)
                && validador.validarCampo(errorProvider, txtTelC)
                && validador.validarCampo(errorProvider, txtDirAltaC)
                && validador.validarCampo(errorProvider, txtMailAltaC);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar agregar Cliente",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (todosLosCamposValidos()) return;
        }

        private void txtNomAltaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }
    }
}

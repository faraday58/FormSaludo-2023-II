using System;
using System.Windows.Forms;

namespace FormSaludo_2023_II
{
    internal  partial class FormSaludo
    {
        public FormSaludo()
        {
            InitialazeComponent();
        }

        private void btnAceptar_Click(object sender,EventArgs e)
        {
            MessageBox.Show(" Hola  " + txtbNombre.Text );
        }
    }
}

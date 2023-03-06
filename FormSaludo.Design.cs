using System;
using System.Windows.Forms;
using System.Drawing;

namespace FormSaludo_2023_II
{
    internal partial class FormSaludo:Form
    {
        private Label lbEtiqueta;
        private TextBox txtbNombre;
        private Button btnAceptar;

      private void InitialazeComponent()
      {
            this.Text = "Formulario Saludo";
            this.Size = new Size(400, 300);


            //Inicializando atributo etiqueta
            this.lbEtiqueta = new Label();
            this.lbEtiqueta.Text = "Introduce tu nombre";
            this.lbEtiqueta.Location = new Point(50, 50);
            this.lbEtiqueta.Size= new Size(150, 40);

            //Inicializando atributo caja de texto
            this.txtbNombre = new TextBox();
            this.txtbNombre.Location = new Point(50, 90);
            this.txtbNombre.Size = new Size(170, 70);

            //Inicializando atributo btnAceptar
            this.btnAceptar = new Button();
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Location = new Point(50, 150);
            this.btnAceptar.Size = new Size(70,40);


            //Agregando el componente al Formulario
            //para ser mostrado
            this.Controls.Add(lbEtiqueta);
            this.Controls.Add(txtbNombre);
            this.Controls.Add(btnAceptar);
      }


    }
}

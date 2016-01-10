using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea_1.Common;

    namespace Tarea_1.GUI
{
    public partial class _default : System.Web.UI.Page
    {
        private Cuentas Cuenta = new Cuentas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (CuentaTextBox.Text.Trim().Length == 0)
            {
            }

            if (DescripcionTextBox.Text.Trim().Length == 0)
            {
            }
            if (BalanceTextBox.Text.Trim().Length == 0)
            {
            }

            Cuenta.CuentaId = Utilitarios.ToInt(CuentaTextBox.ToString());
            Cuenta.Descripcion = DescripcionTextBox.Text;
            //Cuenta.Balance = float.TryParse(BalanceTextBox.Text, );

                if (Cuentas.CuentaId > 0)
                {
                    //Editando
                    paso = Usuario.Modificar();
                }
                else
                {
                    //Insertando
                    paso = Usuario.Insertar();
                }
            }

            if (paso)
            {
                IDTextBox.Clear();
                NombreTextBox.Clear();
                ApellidoTextBox.Clear();
                UsuarioTextBox.Clear();
                PW2TextBox.Clear();
                PWTextBox.Clear();
                MailTextBox.Clear();
                NivelComboBox.SelectedIndex = 0;
                MessageBox.Show("Usuario Guardado.");
            }
            else
            {
                MessageBox.Show("Ha Ocurrido un Error, Compruebe el usuario y la contraseña.");
            }

        }


    }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Tarea_1.Common;

namespace Tarea_1.GUI
{
    public partial class _default : System.Web.UI.Page
    {
        private Cuentas Cuenta = new Cuentas();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EnviarButton_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (IDCuentaTextBox.Text.Trim().Length == 0)
            {
            }

            if (DescripcionTextBox.Text.Trim().Length == 0)
            {
            }
            if (BalanceTextBox.Text.Trim().Length == 0)
            {
            }

            Cuenta.CuentaId = Utilitarios.ToInt(IDCuentaTextBox.ToString());
            Cuenta.Descripcion = DescripcionTextBox.Text;
       //     Cuenta.Balance = Convert.ToDouble(BalanceTextBox.ToString());

            if (Cuenta.CuentaId > 0)
            {
                //Editando
                paso = Cuenta.Modificar();
            }
            else
            {
                //Insertando
                paso = Cuenta.Insertar();
            }
            if (paso)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registrado Satisfactoriamente.');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Ha habido un error.');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GUI/rCuentas.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
       
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GUI/cCuentas.aspx");
        }
    }
}
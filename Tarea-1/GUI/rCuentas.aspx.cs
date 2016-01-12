using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Tarea_1.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            if (DescripcionTextBox.Text.Trim().Length == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe ingresar una descripcion.');", true);
            }
            if (BalanceTextBox.Text.Trim().Length == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe ingresar un balance.');", true);
            }
            else {

                Cuenta.CuentaId = Utilitarios.ToInt(IDCuentaTextBox.ToString());
                Cuenta.Descripcion = DescripcionTextBox.Text;
                Cuenta.Balance = float.Parse(BalanceTextBox.Text);

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
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GUI/rCuentas.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IDCuentaTextBox.Text.Trim().Length == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Ha habido un error. Pruebe ingresando un ID.');", true);
            }
            if (Cuenta.Eliminar(Utilitarios.ToInt(IDCuentaTextBox.Text)))
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cuenta Eliminada.');", true);
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int Id;
            if (IDCuentaTextBox.Text == "")
            {
                Response.Redirect("~/GUI/cCuentas.aspx");
            }
            else
            {
                Id = int.Parse(IDCuentaTextBox.Text);
                Cuenta.Buscar(Id);
                Cuenta.Descripcion = DescripcionTextBox.Text;
                float flotante = Cuenta.Balance;
                BalanceTextBox.Text = flotante.ToString();
            }
            

        }
    }
}
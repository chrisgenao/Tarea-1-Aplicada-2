using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace Tarea_1.GUI
{
    public partial class cCuentas : System.Web.UI.Page
    {
        private Cuentas Cuenta = new Cuentas();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Esto lo usare en las proximas tareas, lo dejo aqui solo para tener la prueba de como funciona.

            // FiltroDropDown.DataSource = Cuenta.Listar("CuentaId, Descripcion", "1 = 1");
            // FiltroDropDown.DataValueField = "CuentaId";
            // FiltroDropDown.DataTextField = "Descripcion";
            // FiltroDropDown.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Cuentas Cuenta = new Cuentas();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (FiltroDropDown.SelectedIndex == 0) //CuentaId
            {
                if (FiltroTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "CuentaId = " + FiltroTextBox.Text;
                }
            }
            else if (FiltroDropDown.SelectedIndex == 1) //Descripcion
                if (FiltroTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Descripcion like '%" + FiltroTextBox.Text + "%'";
                }
            else if (FiltroDropDown.SelectedIndex == 2) //Balance
                if (FiltroTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Apellido = " + FiltroTextBox.Text;
                }

            dt = Cuenta.Listar("CuentaId, Descripcion, Balance", filtro);
            BuscarGridView.DataSource = dt;
            BuscarGridView.DataBind();

        }
    }
}
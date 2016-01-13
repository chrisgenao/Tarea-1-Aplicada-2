using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Drawing;

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

                    filtro = "Balance = " + FiltroTextBox.Text;
                }

            dt = Cuenta.Listar("CuentaId, Descripcion, Balance", filtro);
            BuscarGridView.DataSource = dt;
            BuscarGridView.DataBind();

        }

        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(BuscarGridView, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in BuscarGridView.Rows)
            {
                if (row.RowIndex == BuscarGridView.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
        }
    }
}
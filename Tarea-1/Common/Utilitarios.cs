using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_1.Common
{
    public class Utilitarios
    {
        public static int ToInt(string texto)
        {
            int valor = 0;

            int.TryParse(texto, out valor);

            return valor;
        }

            public static bool ValidarTextBoxVacio(TextBox TextoValidar, string MensajedeError)
        {
            bool valido = true;

            if (TextoValidar.Text.Trim().Length == 0)
            {
                TextoValidar.Focus();
                valido = false;
            }

            return valido;

        }
    }
}
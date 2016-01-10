using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Cuentas
    {
        private ConexionDb Conexion = new ConexionDb();

        public int CuentaId { get; set; }
        public string Descripcion { get; set; }
        public float Balance { get; set; }

        public Cuentas()
        {
            this.CuentaId = 0;
            this.Descripcion = string.Empty;
            this.Balance = 0;


        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.CuentaId = 0;

            this.CuentaId = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Cuentas (Descripcion, Balance) values ('" + this.Descripcion + "', " + this.Balance + ") Select @@IDENTITY"));

            paso = this.CuentaId > 0;

            if (paso)
            {

            }

            return paso;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Cuentas set Descripcion = '" + this.Descripcion + "', Balance = " + this.Balance + " where CuentaId =" + this.CuentaId);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Cuentas where CuentaId=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Descripcion, Balance", "CuentaId=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.CuentaId = IdBuscado;
                this.Descripcion = (string)dt.Rows[0]["Descrpcion"];
                this.Balance = (float)dt.Rows[0]["Balance"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Microsoft.VisualBasic.CompilerServices;


namespace Sistema_Estiba_PDQ;

public class ConsolidaOt
{
    private NpgsqlCommand com;
    private NpgsqlDataReader read;
    
    List<DataReporteCalidad> dataReporteCalidads = new List<DataReporteCalidad>();

    public object Consultar(string expedicion)
    {
        try
    {
        string query = "select * from  alerce.reporte_calidad where expedicion = " + expedicion;

            ModuleNpgSql.Conexion();
            com = new NpgsqlCommand(query, ModuleNpgSql.connNpg);
            read = com.ExecuteReader();

            while (read.Read())
            {
                string pvkilos = Convert.ToString(read["PVKILOS"]);
                int bultos = Convert.ToInt32(read["BULTOS"]);
                Console.WriteLine("Data expedicion: " + expedicion + " pvkilos: " + pvkilos + " bultos: " + bultos);

                dataReporteCalidads.Add(new DataReporteCalidad(expedicion,bultos,pvkilos,false) );
            }
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine(ex.Message);
            ProjectData.SetProjectError(ex);
            MessageBox.Show("Error al obtener datos: " + ex.ToString());
            ProjectData.ClearProjectError();
        }
        return "";
    }

    public object OrdenList()
    {
        return "";
    }

    public object addListExpedicion() 
    {
        return "";
    }

    public class DataReporteCalidad
    {
        public string Expedicion {get; set;}
        public int Bultos { get; set; }
        public string Pvkilos { get; set; }
        public bool BultosOk { get; set; }

        public DataReporteCalidad()
        {
        }

        public DataReporteCalidad(string expedicion,int bultos, string pvkilos, bool bultosOk)
        { 
            this.Expedicion = expedicion; 
            this.Bultos = bultos;  
            this.Pvkilos = pvkilos; 
            this.BultosOk = bultosOk;
        }
    }
}




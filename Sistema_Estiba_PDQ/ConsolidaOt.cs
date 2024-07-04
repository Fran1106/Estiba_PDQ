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
    private string expedicion;

    public object Consultar()
    {
        try
        {
            string query = "select * from  alerce.reporte_calidad where expedicion = " + expedicion;

            ModuleNpgSql.Conexion();

            com = new NpgsqlCommand(query, ModuleNpgSql.connNpg);
            read = com.ExecuteReader();

            while (read.Read())
            {
                int pvkilos = Convert.ToInt32(read["PVKILOS"]);
                int bultos = Convert.ToInt32(read["BULTOS"]);
                Console.WriteLine("Data expedicion: " + expedicion + " pvkilos: " + pvkilos + " bultos: " + bultos);
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


}




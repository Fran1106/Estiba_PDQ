using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Sistema_Estiba_PDQ;

    private NpgsqlCommand com;
    private NpgsqlDataReader read;

    internal class ConsolidaOt
    {
    }

    public void Consultar(string expedicion)
    {

        string query = "select * from  alerce.reporte_calidad where expedicion = " + expedicion;

        NpgsqlCommand command = new NpgsqlCommand(query, conn);
        NpgsqlDataReader reader = command.ExecuteReader();

        Console.WriteLine("Select reader data: " + reader.HasRows);
        Console.WriteLine("Consulta OK Rows obtenidos :  " + reader.Rows);

        try
        {
            while (reader.Read())
            {
                int pvkilos = Convert.ToInt32(reader["PVKILOS"]);
                int bultos = Convert.ToInt32(reader["BULTOS"]);
                MessageBox.Show("Data expedicion: " + expedicion + " pvkilos: " + pvkilos + " bultos: " + bultos);
            }
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine(ex.Message);
            ProjectData.SetProjectError(ex);
            MessageBox.Show("Error Al Generar El Código: " + ex.ToString());
            ProjectData.ClearProjectError();
        }
    }


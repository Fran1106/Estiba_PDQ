using Microsoft .VisualBasic.CompilerServices;
using Npgsql;
using System;
using System.Windows.Forms;

namespace Sistema_Estiba_PDQ;

[StandardModule]
internal sealed class ModuleNpgSql
{
    public static NpgsqlConnection connNpg;

    public static void Conexion()
    {
        try
        {
            NpgsqlConnectionStringBuilder keyValuePairs = new NpgsqlConnectionStringBuilder();
            keyValuePairs.Database = "pdq";
            keyValuePairs.Host = "controlit.csu2b8boipfw.us-east-2.rds.amazonaws.com";
            keyValuePairs.Username = "controlit";
            keyValuePairs.Password = "Vo9xK5SSA5f5LNtJEhgT";
            keyValuePairs.Port = 5432;
            connNpg = new NpgsqlConnection(keyValuePairs.ConnectionString);
            connNpg.Open();
        }
        catch (NpgsqlException ex) 
        {
            Console.WriteLine(ex.Message);
            ProjectData.SetProjectError(ex);
            MessageBox.Show("Error Al Generar El Código: " + ex.ToString());
            ProjectData.ClearProjectError();
        }
    }

    public static void Desconection()
    { 
        connNpg.Dispose();

    }

}


using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Sistema_Estiba_PDQ;

[StandardModule]
internal sealed class ModuleDB
{
	public static MySqlConnection vConn;

	public static void Conectar()
	{
		try
		{
			MySqlConnectionStringBuilder vConnString = new MySqlConnectionStringBuilder();
			vConnString.Server = "192.168.0.180";
			vConnString.Database = "dbestiba";
			vConnString.UserID = "estiba";
			vConnString.Password = "sistemaestibapdq2023";
			vConnString.IntegratedSecurity = false;
			vConn = new MySqlConnection(vConnString.ToString());
			vConn.Open();
		}
		catch (MySqlException ex2)
		{
			ProjectData.SetProjectError(ex2);
			MySqlException ex = ex2;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical);
			ProjectData.ClearProjectError();
		}
	}

	public static void Desconectar()
	{
		vConn.Dispose();
	}
}

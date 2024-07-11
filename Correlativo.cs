using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Sistema_Estiba_PDQ;

public class Correlativo
{
	private MySqlCommand comando;

	private MySqlDataReader dr;

	public object generarCodigo()
	{
		string codigo = "";
		int total = 0;
		try
		{
			ModuleDB.Conectar();
			comando = new MySqlCommand("select count(*) as folio from tbl_datos", ModuleDB.vConn);
			dr = comando.ExecuteReader();
			if (dr.Read())
			{
				total = Conversions.ToInteger(dr["folio"]);
			}
			dr.Close();
			if (total < 10)
			{
				codigo = "0000" + total;
			}
			else if (total < 100)
			{
				codigo = "000" + total;
			}
			else if (total < 1000)
			{
				codigo = "00" + total;
			}
			else if (total < 10000)
			{
				codigo = "0" + total;
			}
		}
		catch (MySqlException ex2)
		{
			ProjectData.SetProjectError(ex2);
			MySqlException ex = ex2;
			MessageBox.Show("Error Al Generar El Código: " + ex.ToString());
			ProjectData.ClearProjectError();
		}
		return codigo;
	}
}

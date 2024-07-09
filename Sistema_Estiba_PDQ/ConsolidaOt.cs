using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Logging;


namespace Sistema_Estiba_PDQ;

public class ConsolidaOt
{
    private NpgsqlCommand com;
    private NpgsqlDataReader read;
    
    private List<DataReporteCalidad> dataReporteCalidads = new List<DataReporteCalidad>();
    private long PesoVolumetrico = 0L;

    public void ConsultarExpedicion(string expedicion)
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
                dataReporteCalidads.Add(new DataReporteCalidad(expedicion,bultos,pvkilos,false) );
            }

            ModuleNpgSql.Desconection();
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine(ex.Message);
            ProjectData.SetProjectError(ex);
            MessageBox.Show("Error al obtener datos: " + ex.ToString());
            ProjectData.ClearProjectError();
        }
    }

    /* obtiene data de expedicion con ot entregada */
    public void SumAllOt(string ot)
    {
        foreach (DataReporteCalidad data in dataReporteCalidads)
        {
            if (data.Expedicion.Equals(ot) && data.Bultos > 1)
            {
                MessageBox.Show("ConsolidaOt.SumAllOt - valida expediocion " + data.Bultos);
                break;
                /* agrega logica para cuando viene mas de un bulto */
            }
            else
            {
                AddPesoVol(Conversions.ToLong(data.Pvkilos));
                break;
            }
        }
    }

    public void AddPesoVol(long NewPeso) 
    {
        this.PesoVolumetrico += NewPeso;
    }

    public long GetPesoVolumetrico() 
    { 
        return this.PesoVolumetrico;
    }

    public void NbultosOK(object listOp)
    {
        /* valida cantidad bultos se encuentra completa
         * define logica para consulta cantidad de bultos esta completa
         * */
        foreach (DataReporteCalidad data in dataReporteCalidads)
        {
            MessageBox.Show("ConsolidaOt.bultosOK  ot : " + data.Expedicion);
        }
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




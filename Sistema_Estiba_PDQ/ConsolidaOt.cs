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
using Microsoft.VisualBasic;

namespace Sistema_Estiba_PDQ;

public class ConsolidaOt
{
    private NpgsqlCommand com;
    private NpgsqlDataReader read;

    private Hashtable dataHashOt = new Hashtable();
    List<int> listaNbulto;
    private long PesoVolumetrico = 0L;

    public void ConsultarExpedicion(string expedicion, int numBultos)
    {
        try
        {
            if (dataHashOt.Contains(expedicion))
            {
                EvalExpedicionExistente(expedicion, numBultos);
                return;
            }

            string query = "select * from  alerce.reporte_calidad where expedicion = " + expedicion;

            ModuleNpgSql.Conexion();
            com = new NpgsqlCommand(query, ModuleNpgSql.connNpg);
            read = com.ExecuteReader();

            while (read.Read())
            {
                string pvkilos = Convert.ToString(read["PVKILOS"]);
                int bultos = Convert.ToInt32(read["BULTOS"]);
               
                    listaNbulto = new List<int>();
                    listaNbulto.Add(numBultos);
                    dataHashOt.Add(expedicion, new DataReporteCalidad(
                        expedicion,
                        bultos, 
                        pvkilos, 
                        bultos.Equals(1), 
                        listaNbulto));
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

    public void SumAllOt(string ot)
    {
        DataReporteCalidad dataReporteCalidad = (DataReporteCalidad)dataHashOt[ot];
        if (dataReporteCalidad.BultosOk && !dataReporteCalidad.PrintOK)
        {
            dataReporteCalidad.PrintOK = true;
            dataHashOt[ot] = dataReporteCalidad;
            AddPesoVol(Conversions.ToLong(dataReporteCalidad.Pvkilos));
        }
    }

    public bool ValidaExpedicionesCompleta()
    {
        ICollection keys = dataHashOt.Keys;
        foreach (string key in keys)
        {
            DataReporteCalidad dataReporteCalidad = (DataReporteCalidad)dataHashOt[key];

            if (!dataReporteCalidad.BultosOk) 
            {
                Interaction.MsgBox("Falta ingresar : "+ (dataReporteCalidad.Bultos-dataReporteCalidad.Nbultos.Count) + 
                    ((dataReporteCalidad.Bultos - dataReporteCalidad.Nbultos.Count)>1 ?" Bultos ":" Bulto ")
                    +"para la Ot : "+ dataReporteCalidad.Expedicion, MsgBoxStyle.Information, ":: PDQ :::");
                return false;
            }
        }
        return true;
    }

    public void AddPesoVol(long NewPeso)
    {
        this.PesoVolumetrico += NewPeso;
    }

    public void EvalExpedicionExistente(string Ot, int Nbulto)
    {
        DataReporteCalidad dataReporteCalidad = (DataReporteCalidad)this.dataHashOt[Ot];
        int TotalBultos = dataReporteCalidad.Bultos;

        if (!dataReporteCalidad.Nbultos.Contains(Nbulto))
        {
            dataReporteCalidad.Nbultos.Add(Nbulto);
            dataReporteCalidad.Nbultos.Sort();
        }

        if (dataReporteCalidad.Nbultos.Count.Equals(TotalBultos))
        {
            dataReporteCalidad.BultosOk = true;
        }
        dataHashOt[Ot] = dataReporteCalidad;
    }

    public long GetPesoVolumetrico() 
    { 
        return this.PesoVolumetrico;
    }
    
    public class DataReporteCalidad
    {
        public string Expedicion {get; set;}
        public int Bultos { get; set; }
        public string Pvkilos { get; set; }
        public bool BultosOk { get; set; }
        public List<int> Nbultos { get; set;}
        public bool PrintOK { get; set; }

        public DataReporteCalidad()
        {
        }

        public DataReporteCalidad(string expedicion,int bultos, string pvkilos, bool bultosOk, List<int> nbultos)
        { 
            this.Expedicion = expedicion; 
            this.Bultos = bultos;  
            this.Pvkilos = pvkilos; 
            this.BultosOk = bultosOk;
            this.Nbultos = nbultos;
            this.PrintOK = false;
        }
    }
}




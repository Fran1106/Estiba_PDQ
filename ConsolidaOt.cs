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
    private int PesoVolumetrico = 0;
    private int Kilogramos = 0;

    public void ConsultarExpedicion(string expedicion, int numBultos)
    {
        try
        {
            if (dataHashOt.Contains(expedicion))
            {
                EvalExpedicionExistente(expedicion, numBultos);
                return;
            }

            string query = "select * from  alerce.reporte_calidad where nenvio = \'" + expedicion + "\'";

            ModuleNpgSql.Conexion();
            com = new NpgsqlCommand(query, ModuleNpgSql.connNpg);
            read = com.ExecuteReader();

            while (read.Read())
            {
                int pvkilos = Convert.ToInt32(read["PVKILOS"]);
                int bultos = Convert.ToInt32(read["BULTOS"]);
                int kilos = Convert.ToInt32(read["KILOS"]);
               
                    this.listaNbulto = new List<int>();
                    this.listaNbulto.Add(numBultos);
                    dataHashOt.Add(expedicion, new DataReporteCalidad(
                        expedicion,
                        bultos, 
                        pvkilos, 
                        bultos.Equals(1), 
                        listaNbulto,
                        kilos));
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

        if (dataReporteCalidad == null) {
            //Interaction.MsgBox("Ot  : " + ot + " No se encuntra en la Base para obtener información de Peso y Kilos ", MsgBoxStyle.Information, ":: PDQ :::");
            return; 
        }

        if (dataReporteCalidad.BultosOk && !dataReporteCalidad.PrintOK)
        {
            dataReporteCalidad.PrintOK = true;
            dataHashOt[ot] = dataReporteCalidad;
            AddPesoVol(dataReporteCalidad.Pvkilos);
            AddKilosgramos(dataReporteCalidad.Kilos);

        }
    }

    public void ValidaExpedicionesCompleta()
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
                
            }
        }        
    }

    public void AddPesoVol(int pvkilos)
    {
        this.PesoVolumetrico += pvkilos;
    }

    public void AddKilosgramos(int kilogramos)
    {
        this.Kilogramos += kilogramos;
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

    public int GetPesoVolumetrico() { return this.PesoVolumetrico; }

    public int GetKilos() { return this.Kilogramos; }
    
    public class DataReporteCalidad
    {
        public string Expedicion {get; set;}
        public int Bultos { get; set; }
        public int Pvkilos { get; set; }
        public bool BultosOk { get; set; }
        public List<int> Nbultos { get; set;}
        public bool PrintOK { get; set; }
        public int Kilos { get; set; }

        public DataReporteCalidad()
        {
        }

        public DataReporteCalidad(string expedicion,int bultos, int pvkilos, bool bultosOk, List<int> nbultos, int Kilos )
        { 
            this.Expedicion = expedicion; 
            this.Bultos = bultos;  
            this.Pvkilos = pvkilos; 
            this.BultosOk = bultosOk;
            this.Nbultos = nbultos;
            this.PrintOK = false;
            this.Kilos = Kilos;
        }
    }
}




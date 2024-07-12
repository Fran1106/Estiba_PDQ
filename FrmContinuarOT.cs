using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Sistema_Estiba_PDQ.My;
using Sistema_Estiba_PDQ.My.Resources;
namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmContinuarOT : Form
{
    private Button button1;
    private IContainer components;
    
    private DataGridViewTextBoxColumn IdColumn;
    private DataGridViewTextBoxColumn FolioColumn;
    private DataGridViewTextBoxColumn UsuarioColumn;
    private DataGridViewTextBoxColumn DestinoColumn;
    private DataGridViewTextBoxColumn RamplaColumn;
    private DataGridViewTextBoxColumn FechaColumn;
    private DataGridViewTextBoxColumn HoraColumn;

    private string Id;
    private string Folio;
    private string Usuario;
    private string Destino;
    private string Rampla;
    private string Fecha;
    private string Hora;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DataGridView1")]
    private DataGridView _DataGridView1;

    internal virtual DataGridView DataGridView1
    {
        [CompilerGenerated]
        get
        {
            return _DataGridView1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        [CompilerGenerated]
        set
        {
            DataGridViewCellEventHandler value2 = DataGridView1_CellClick;
            DataGridView dataGridView1 = _DataGridView1;
            if (dataGridView1 != null)
            {
                dataGridView1.CellClick -= value2;
            }
            _DataGridView1 = value;
            dataGridView1 = _DataGridView1;
            if (dataGridView1 != null)
            {
                dataGridView1.CellClick += value2;
            }
        }
    }

    public FrmContinuarOT()
    {
        base.Load += FrmContinuarOT_Load;
        InitializeComponent();
    }


    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    [System.Diagnostics.DebuggerStepThrough]
    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmContinuarOT));

        DataGridView1 = new System.Windows.Forms.DataGridView();
        button1 = new Button();
        IdColumn = new DataGridViewTextBoxColumn();
        FolioColumn = new DataGridViewTextBoxColumn();
        UsuarioColumn = new DataGridViewTextBoxColumn();
        DestinoColumn = new DataGridViewTextBoxColumn();
        RamplaColumn = new DataGridViewTextBoxColumn();
        FechaColumn = new DataGridViewTextBoxColumn();
        HoraColumn = new DataGridViewTextBoxColumn();
        
        SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();

        // 
        // button1
        // 
        button1.Location = new Point(373, 21);
        button1.Name = "button1";
        button1.Size = new Size(107, 38);
        button1.TabIndex = 1;
        button1.Text = "Continuar OT";
        button1.UseVisualStyleBackColor = true;
        button1.Click += continuarOt;
        // 
        // IdColumn
        // 
        IdColumn.HeaderText = "ID";
        IdColumn.Name = "IdColumn";
        // 
        // FolioColumn
        // 
        FolioColumn.HeaderText = "FOLIO";
        FolioColumn.Name = "FolioColumn";
        // 
        // UsuarioColumn
        // 
        UsuarioColumn.HeaderText = "USUARIO";
        UsuarioColumn.Name = "UsuarioColumn";
        // 
        // DestinoColumn
        // 
        DestinoColumn.HeaderText = "DESTINO";
        DestinoColumn.Name = "DestinoColumn";
        // 
        // RamplaColumn
        // 
        RamplaColumn.HeaderText = "RAMPLA";
        RamplaColumn.Name = "RamplaColumn";
        // 
        // FechaColumn
        // 
        FechaColumn.HeaderText = "FECHA";
        FechaColumn.Name = "FechaColumn";
        // 
        // HoraColumn
        // 
        HoraColumn.HeaderText = "HORA";
        HoraColumn.Name = "HoraColumn";
        // 
        // FrmContinuarOT
        // 

        DataGridView1.AllowUserToAddRows = false;
        DataGridView1.AllowUserToDeleteRows = false;
        DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;

        DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridView1.Columns.AddRange(this.IdColumn, this.FolioColumn, this.UsuarioColumn, this.DestinoColumn, this.RamplaColumn, this.FechaColumn, this.HoraColumn);
        DataGridView1.Location = new System.Drawing.Point(8, 97);
        DataGridView1.Margin = new System.Windows.Forms.Padding(4);
        DataGridView1.Name = "DataGridView1";


        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(0, 0, 192);
        ClientSize = new Size(790, 489);
        Controls.Add(button1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmContinuarOT";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Continuar Con OT";
        base.ResumeLayout(false);
    }


    private void FrmContinuarOT_Load(object sender, EventArgs e)
    {
        Mostrar_Datos();
    }

    private void continuarOt(object sender, EventArgs e)
    {
        MessageBox.Show("FrmContinuarOT --> Button " + this.Id + " " + this.Folio + " " + this.Rampla);
        //Mostrar_Datos();
    }

    private void Mostrar_Datos()
    {
        ModuleDB.Conectar();
        string vSql = "select *  from tbl_datos where usuario = \'fdaine\'\n and " +
            "date_format(STR_TO_DATE(fecha, \'%d/%m/%Y\'),\'%Y-%m-%d\') = date_format(curdate()-2,\'%Y-%m-%d\')\n order by hora desc";
        MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
        MySqlDataReader vReader = vCmd.ExecuteReader();
        DataGridView1.Rows.Clear();
        while (vReader.Read())
        {
            DataGridView1.Rows.Add(vReader.GetString(0), vReader.GetString(1), vReader.GetString(2), vReader.GetString(3), vReader.GetString(4), vReader.GetString(5), vReader.GetString(6));

        }
        vReader.Close();
        ModuleDB.Desconectar();
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
          this.Id = DataGridView1.CurrentRow.Cells["IdColumn"].Value.ToString();
          this.Folio = DataGridView1.CurrentRow.Cells["FolioColumn"].Value.ToString();
          this.Usuario = DataGridView1.CurrentRow.Cells["UsuarioColumn"].Value.ToString();
          this.Destino = DataGridView1.CurrentRow.Cells["DestinoColumn"].Value.ToString();
          this.Rampla = DataGridView1.CurrentRow.Cells["RamplaColumn"].Value.ToString();
          this.Fecha = DataGridView1.CurrentRow.Cells["FechaColumn"].Value.ToString();
          this.Hora = DataGridView1.CurrentRow.Cells["HoraColumn"].Value.ToString();
        
        MessageBox.Show("XXX");
    }
}

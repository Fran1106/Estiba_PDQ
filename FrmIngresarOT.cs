using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Sistema_Estiba_PDQ.My;
using Sistema_Estiba_PDQ.My.Resources;
using ZXing;
using System.Web;
using System.Reflection;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmIngresarOT : Form
{

    Log oLog = new Log(getDirectory());

	private IContainer components;
    private ConsolidaOt consolidaOt = new();

    [CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnImprimir")]
	private Button _BtnImprimir;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DgvIngresarOT")]
	private DataGridView _DgvIngresarOT;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnOperacion")]
	private Button _BtnOperacion;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnAgregar")]
	private Button _BtnAgregar;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtDestino")]
	internal virtual ComboBox TxtDestino
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtUsuario")]
	internal virtual TextBox TxtUsuario
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtCodigo")]
	internal virtual TextBox TxtCodigo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtHora")]
	internal virtual TextBox TxtHora
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtFecha")]
	internal virtual TextBox TxtFecha
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

    [field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}


	internal virtual Button BtnImprimir
	{
		[CompilerGenerated]
		get
		{
			return _BtnImprimir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnImprimir_Click;
			Button btnImprimir = _BtnImprimir;
			if (btnImprimir != null)
			{
				btnImprimir.Click -= value2;
			}
			_BtnImprimir = value;
			btnImprimir = _BtnImprimir;
			if (btnImprimir != null)
			{
				btnImprimir.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TxtPistolear")]
	internal virtual TextBox TxtPistolear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DgvIngresarOT
	{
		[CompilerGenerated]
		get
		{
			return _DgvIngresarOT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellFormattingEventHandler value2 = DgvIngresarOT_CellFormatting;
			DataGridView dgvIngresarOT = _DgvIngresarOT;
			if (dgvIngresarOT != null)
			{
				dgvIngresarOT.CellFormatting -= value2;
			}
			_DgvIngresarOT = value;
			dgvIngresarOT = _DgvIngresarOT;
			if (dgvIngresarOT != null)
			{
				dgvIngresarOT.CellFormatting += value2;
			}
		}
	}

	internal virtual Button BtnOperacion
	{
		[CompilerGenerated]
		get
		{
			return _BtnOperacion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnOperacion_Click;
			Button btnOperacion = _BtnOperacion;
			if (btnOperacion != null)
			{
				btnOperacion.Click -= value2;
			}
			_BtnOperacion = value;
			btnOperacion = _BtnOperacion;
			if (btnOperacion != null)
			{
				btnOperacion.Click += value2;
			}
		}
	}

	internal virtual Button BtnAgregar
	{
		[CompilerGenerated]
		get
		{
			return _BtnAgregar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnAgregar_Click;
			Button btnAgregar = _BtnAgregar;
			if (btnAgregar != null)
			{
				btnAgregar.Click -= value2;
			}
			_BtnAgregar = value;
			btnAgregar = _BtnAgregar;
			if (btnAgregar != null)
			{
				btnAgregar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TxtBulto")]
	internal virtual TextBox TxtBulto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtOt")]
	internal virtual TextBox TxtOt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtCodigo2")]
	internal virtual TextBox TxtCodigo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtDestino2")]
	internal virtual TextBox TxtDestino2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtFolio")]
	internal virtual TextBox TxtFolio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

    [field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ImagenCode")]
	internal virtual PictureBox ImagenCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtRampla")]
	internal virtual ComboBox TxtRampla
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FOLIO")]
	internal virtual DataGridViewTextBoxColumn FOLIO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DESTINO")]
	internal virtual DataGridViewTextBoxColumn DESTINO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CODIGO")]
	internal virtual DataGridViewTextBoxColumn CODIGO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OT")]
	internal virtual DataGridViewTextBoxColumn OT
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NBULTO")]
	internal virtual DataGridViewTextBoxColumn NBULTO
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HORA")]
	internal virtual DataGridViewTextBoxColumn HORA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BARCODE")]
	internal virtual DataGridViewImageColumn BARCODE
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmIngresarOT()
	{
		base.Load += FrmIngresarOT_Load;
		base.Closing += FrmIngresarOT_Closing;
        
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
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmIngresarOT));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TxtUsuario = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TxtCodigo = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.TxtDestino = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.TxtHora = new System.Windows.Forms.TextBox();
		this.TxtFecha = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.TxtRampla = new System.Windows.Forms.ComboBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.BtnImprimir = new System.Windows.Forms.Button();
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
		this.DgvIngresarOT = new System.Windows.Forms.DataGridView();
		this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.NBULTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.BARCODE = new System.Windows.Forms.DataGridViewImageColumn();
		this.GroupBox6 = new System.Windows.Forms.GroupBox();
		this.TxtDestino2 = new System.Windows.Forms.TextBox();
		this.BtnAgregar = new System.Windows.Forms.Button();
		this.ImagenCode = new System.Windows.Forms.PictureBox();
		this.BtnOperacion = new System.Windows.Forms.Button();
		this.TxtFolio = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.TxtCodigo2 = new System.Windows.Forms.TextBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.TxtOt = new System.Windows.Forms.TextBox();
		this.TxtBulto = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.TxtPistolear = new System.Windows.Forms.TextBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		this.GroupBox4.SuspendLayout();
		this.GroupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DgvIngresarOT).BeginInit();
		this.GroupBox6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ImagenCode).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.TxtUsuario);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.TxtCodigo);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.TxtDestino);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(328, 134);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.TxtUsuario.Enabled = false;
		this.TxtUsuario.Location = new System.Drawing.Point(84, 95);
		this.TxtUsuario.Name = "TxtUsuario";
		this.TxtUsuario.Size = new System.Drawing.Size(218, 20);
		this.TxtUsuario.TabIndex = 4;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(23, 102);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(54, 13);
		this.Label4.TabIndex = 5;
		this.Label4.Text = "Usuario:";
		this.TxtCodigo.Enabled = false;
		this.TxtCodigo.Location = new System.Drawing.Point(84, 55);
		this.TxtCodigo.Name = "TxtCodigo";
		this.TxtCodigo.Size = new System.Drawing.Size(218, 20);
		this.TxtCodigo.TabIndex = 3;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(27, 63);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(50, 13);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "Código:";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.Red;
		this.Label2.Location = new System.Drawing.Point(5, 24);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(20, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "(*)";
		this.TxtDestino.Enabled = false;
		this.TxtDestino.FormattingEnabled = true;
		this.TxtDestino.Items.AddRange(new object[20]
		{
			"ARICA", "IQUIQUE", "CALAMA", "ANTOFAGASTA", "COPIAPO", "VALLENAR", "COQUIMBO", "VALPARAISO", "LAMPA", "RANCAGUA",
			"TALCA", "CURICO", "CHILLAN", "CONCEPCION", "LOS ANGELES", "TEMUCO", "OSORNO", "PUERTO MONTT", "COYHAIQUE", "PUNTA ARENAS"
		});
		this.TxtDestino.Location = new System.Drawing.Point(84, 16);
		this.TxtDestino.Name = "TxtDestino";
		this.TxtDestino.Size = new System.Drawing.Size(218, 21);
		this.TxtDestino.TabIndex = 2;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(23, 24);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(54, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Destino:";
		this.GroupBox2.Controls.Add(this.TxtHora);
		this.GroupBox2.Controls.Add(this.TxtFecha);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Location = new System.Drawing.Point(346, 12);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(170, 134);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.TxtHora.Enabled = false;
		this.TxtHora.Location = new System.Drawing.Point(62, 78);
		this.TxtHora.Name = "TxtHora";
		this.TxtHora.Size = new System.Drawing.Size(90, 20);
		this.TxtHora.TabIndex = 6;
		this.TxtFecha.Enabled = false;
		this.TxtFecha.Location = new System.Drawing.Point(62, 38);
		this.TxtFecha.Name = "TxtFecha";
		this.TxtFecha.Size = new System.Drawing.Size(90, 20);
		this.TxtFecha.TabIndex = 5;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(17, 85);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(38, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "Hora:";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.White;
		this.Label6.Location = new System.Drawing.Point(9, 46);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(46, 13);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "Fecha:";
		this.GroupBox3.Controls.Add(this.TxtRampla);
		this.GroupBox3.Controls.Add(this.Label8);
		this.GroupBox3.Controls.Add(this.Label7);
		this.GroupBox3.Location = new System.Drawing.Point(522, 12);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(156, 134);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.TxtRampla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.TxtRampla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.TxtRampla.Enabled = false;
		this.TxtRampla.FormattingEnabled = true;
		this.TxtRampla.Items.AddRange(new object[72]
		{
			"400", "402", "403", "404", "405", "406", "407", "408", "411", "412",
			"413", "414", "415", "417", "418", "419", "420", "421", "422", "423",
			"425", "426", "427", "428", "432", "433", "434", "435", "436", "437",
			"438", "439", "440", "441", "442", "443", "444", "445", "446", "447",
			"448", "449", "451", "452", "453", "454", "455", "456", "457", "458",
			"459", "460", "461", "462", "464", "465", "466", "467", "468", "469",
			"470", "471", "472", "473", "474", "475", "476", "477", "478", "479",
			"480", "EXTERNO"
		});
		this.TxtRampla.Location = new System.Drawing.Point(22, 77);
		this.TxtRampla.Name = "TxtRampla";
		this.TxtRampla.Size = new System.Drawing.Size(105, 21);
		this.TxtRampla.TabIndex = 7;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.Red;
		this.Label8.Location = new System.Drawing.Point(19, 47);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(20, 13);
		this.Label8.TabIndex = 7;
		this.Label8.Text = "(*)";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.White;
		this.Label7.Location = new System.Drawing.Point(40, 47);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(87, 13);
		this.Label7.TabIndex = 11;
		this.Label7.Text = "N° De Rampla";
		this.GroupBox4.Controls.Add(this.Label9);
		this.GroupBox4.Controls.Add(this.BtnImprimir);
		this.GroupBox4.Location = new System.Drawing.Point(684, 12);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(159, 134);
		this.GroupBox4.TabIndex = 3;
		this.GroupBox4.TabStop = false;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.White;
		this.Label9.Location = new System.Drawing.Point(42, 106);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(83, 18);
		this.Label9.TabIndex = 12;
		this.Label9.Text = "IMPRIMIR";
		this.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
		this.BtnImprimir.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Imprimir;
		this.BtnImprimir.Location = new System.Drawing.Point(38, 21);
		this.BtnImprimir.Name = "BtnImprimir";
		this.BtnImprimir.Size = new System.Drawing.Size(89, 82);
		this.BtnImprimir.TabIndex = 8;
		this.BtnImprimir.UseVisualStyleBackColor = false;
		this.GroupBox5.Controls.Add(this.DgvIngresarOT);
		this.GroupBox5.Controls.Add(this.GroupBox6);
		this.GroupBox5.Location = new System.Drawing.Point(12, 198);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(831, 379);
		this.GroupBox5.TabIndex = 4;
		this.GroupBox5.TabStop = false;
		this.DgvIngresarOT.AllowUserToAddRows = false;
		this.DgvIngresarOT.AllowUserToDeleteRows = false;
		this.DgvIngresarOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DgvIngresarOT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
		DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DgvIngresarOT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
		this.DgvIngresarOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DgvIngresarOT.Columns.AddRange(this.FOLIO, this.DESTINO, this.CODIGO, this.OT, this.NBULTO, this.HORA, this.BARCODE);
		this.DgvIngresarOT.Location = new System.Drawing.Point(7, 19);
		this.DgvIngresarOT.Name = "DgvIngresarOT";
		this.DgvIngresarOT.ReadOnly = true;
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
		DataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DgvIngresarOT.RowHeadersDefaultCellStyle = DataGridViewCellStyle9;
		this.DgvIngresarOT.RowHeadersWidth = 51;
		this.DgvIngresarOT.Size = new System.Drawing.Size(818, 353);
		this.DgvIngresarOT.TabIndex = 0;
		DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FOLIO.DefaultCellStyle = DataGridViewCellStyle2;
		this.FOLIO.HeaderText = "FOLIO";
		this.FOLIO.MinimumWidth = 6;
		this.FOLIO.Name = "FOLIO";
		this.FOLIO.ReadOnly = true;
		this.FOLIO.Width = 72;
		DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DESTINO.DefaultCellStyle = DataGridViewCellStyle3;
		this.DESTINO.HeaderText = "DESTINO";
		this.DESTINO.MinimumWidth = 6;
		this.DESTINO.Name = "DESTINO";
		this.DESTINO.ReadOnly = true;
		this.DESTINO.Width = 92;
		DataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CODIGO.DefaultCellStyle = DataGridViewCellStyle4;
		this.CODIGO.HeaderText = "CODIGO";
		this.CODIGO.MinimumWidth = 6;
		this.CODIGO.Name = "CODIGO";
		this.CODIGO.ReadOnly = true;
		this.CODIGO.Width = 85;
		DataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.OT.DefaultCellStyle = DataGridViewCellStyle5;
		this.OT.HeaderText = "OT";
		this.OT.MinimumWidth = 6;
		this.OT.Name = "OT";
		this.OT.ReadOnly = true;
		this.OT.Width = 50;
		DataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.NBULTO.DefaultCellStyle = DataGridViewCellStyle6;
		this.NBULTO.HeaderText = "N° BULTO";
		this.NBULTO.MinimumWidth = 6;
		this.NBULTO.Name = "NBULTO";
		this.NBULTO.ReadOnly = true;
		this.NBULTO.Width = 97;
		DataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.HORA.DefaultCellStyle = DataGridViewCellStyle7;
		this.HORA.HeaderText = "HORA";
		this.HORA.MinimumWidth = 6;
		this.HORA.Name = "HORA";
		this.HORA.ReadOnly = true;
		this.HORA.Width = 70;
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		DataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DataGridViewCellStyle8.NullValue = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(resources.GetObject("DataGridViewCellStyle8.NullValue"));
		this.BARCODE.DefaultCellStyle = DataGridViewCellStyle8;
		this.BARCODE.HeaderText = "BARCODE";
		this.BARCODE.MinimumWidth = 6;
		this.BARCODE.Name = "BARCODE";
		this.BARCODE.ReadOnly = true;
		this.BARCODE.Width = 78;
		this.GroupBox6.Controls.Add(this.TxtDestino2);
		this.GroupBox6.Controls.Add(this.BtnAgregar);
		this.GroupBox6.Controls.Add(this.ImagenCode);
		this.GroupBox6.Controls.Add(this.BtnOperacion);
		this.GroupBox6.Controls.Add(this.TxtFolio);
		this.GroupBox6.Controls.Add(this.Label10);
		this.GroupBox6.Controls.Add(this.Label14);
		this.GroupBox6.Controls.Add(this.TxtCodigo2);
		this.GroupBox6.Controls.Add(this.Label11);
		this.GroupBox6.Controls.Add(this.Label13);
		this.GroupBox6.Controls.Add(this.TxtOt);
		this.GroupBox6.Controls.Add(this.TxtBulto);
		this.GroupBox6.Controls.Add(this.Label12);
		this.GroupBox6.ForeColor = System.Drawing.Color.White;
		this.GroupBox6.Location = new System.Drawing.Point(100, 19);
		this.GroupBox6.Name = "GroupBox6";
		this.GroupBox6.Size = new System.Drawing.Size(609, 185);
		this.GroupBox6.TabIndex = 15;
		this.GroupBox6.TabStop = false;
		this.GroupBox6.Text = "Controles Ocultos";
		this.TxtDestino2.Enabled = false;
		this.TxtDestino2.Location = new System.Drawing.Point(495, 67);
		this.TxtDestino2.Name = "TxtDestino2";
		this.TxtDestino2.Size = new System.Drawing.Size(88, 20);
		this.TxtDestino2.TabIndex = 12;
		this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
		this.BtnAgregar.Location = new System.Drawing.Point(39, 64);
		this.BtnAgregar.Name = "BtnAgregar";
		this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
		this.BtnAgregar.TabIndex = 1;
		this.BtnAgregar.Text = "Agregar";
		this.BtnAgregar.UseVisualStyleBackColor = true;
		this.ImagenCode.Location = new System.Drawing.Point(307, 91);
		this.ImagenCode.Name = "ImagenCode";
		this.ImagenCode.Size = new System.Drawing.Size(125, 70);
		this.ImagenCode.TabIndex = 13;
		this.ImagenCode.TabStop = false;
		this.BtnOperacion.ForeColor = System.Drawing.Color.Black;
		this.BtnOperacion.Location = new System.Drawing.Point(120, 64);
		this.BtnOperacion.Name = "BtnOperacion";
		this.BtnOperacion.Size = new System.Drawing.Size(75, 23);
		this.BtnOperacion.TabIndex = 2;
		this.BtnOperacion.Text = "Operacion";
		this.BtnOperacion.UseVisualStyleBackColor = true;
		this.TxtFolio.Enabled = false;
		this.TxtFolio.Location = new System.Drawing.Point(213, 130);
		this.TxtFolio.Name = "TxtFolio";
		this.TxtFolio.Size = new System.Drawing.Size(88, 20);
		this.TxtFolio.TabIndex = 13;
		this.Label10.AutoSize = true;
		this.Label10.BackColor = System.Drawing.Color.Transparent;
		this.Label10.ForeColor = System.Drawing.Color.White;
		this.Label10.Location = new System.Drawing.Point(216, 47);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(49, 13);
		this.Label10.TabIndex = 3;
		this.Label10.Text = "Codigo 2";
		this.Label14.AutoSize = true;
		this.Label14.BackColor = System.Drawing.Color.Transparent;
		this.Label14.ForeColor = System.Drawing.Color.White;
		this.Label14.Location = new System.Drawing.Point(216, 110);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(29, 13);
		this.Label14.TabIndex = 11;
		this.Label14.Text = "Folio";
		this.TxtCodigo2.Enabled = false;
		this.TxtCodigo2.Location = new System.Drawing.Point(213, 67);
		this.TxtCodigo2.Name = "TxtCodigo2";
		this.TxtCodigo2.Size = new System.Drawing.Size(88, 20);
		this.TxtCodigo2.TabIndex = 9;
		this.Label11.AutoSize = true;
		this.Label11.BackColor = System.Drawing.Color.Transparent;
		this.Label11.ForeColor = System.Drawing.Color.White;
		this.Label11.Location = new System.Drawing.Point(310, 47);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(22, 13);
		this.Label11.TabIndex = 5;
		this.Label11.Text = "OT";
		this.Label13.AutoSize = true;
		this.Label13.BackColor = System.Drawing.Color.Transparent;
		this.Label13.ForeColor = System.Drawing.Color.White;
		this.Label13.Location = new System.Drawing.Point(498, 47);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(52, 13);
		this.Label13.TabIndex = 9;
		this.Label13.Text = "Destino 2";
		this.TxtOt.Enabled = false;
		this.TxtOt.Location = new System.Drawing.Point(307, 67);
		this.TxtOt.Name = "TxtOt";
		this.TxtOt.Size = new System.Drawing.Size(88, 20);
		this.TxtOt.TabIndex = 10;
		this.TxtBulto.Enabled = false;
		this.TxtBulto.Location = new System.Drawing.Point(401, 67);
		this.TxtBulto.Name = "TxtBulto";
		this.TxtBulto.Size = new System.Drawing.Size(88, 20);
		this.TxtBulto.TabIndex = 11;
		this.Label12.AutoSize = true;
		this.Label12.BackColor = System.Drawing.Color.Transparent;
		this.Label12.ForeColor = System.Drawing.Color.White;
		this.Label12.Location = new System.Drawing.Point(404, 47);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(31, 13);
		this.Label12.TabIndex = 7;
		this.Label12.Text = "Bulto";
		this.TxtPistolear.Location = new System.Drawing.Point(359, 171);
		this.TxtPistolear.Name = "TxtPistolear";
		this.TxtPistolear.Size = new System.Drawing.Size(220, 20);
		this.TxtPistolear.TabIndex = 1;
		this.PictureBox2.Image = Sistema_Estiba_PDQ.My.Resources.Resources.PDQ_LOGO;
		this.PictureBox2.Location = new System.Drawing.Point(701, 154);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(142, 39);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 11;
		this.PictureBox2.TabStop = false;
		this.PictureBox1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.cbarras;
		this.PictureBox1.Location = new System.Drawing.Point(276, 160);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(77, 31);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 10;
		this.PictureBox1.TabStop = false;
		base.AcceptButton = this.BtnOperacion;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		base.ClientSize = new System.Drawing.Size(853, 587);
		base.Controls.Add(this.PictureBox2);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.TxtPistolear);
		base.Controls.Add(this.GroupBox5);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmIngresarOT";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Registrar Ordenes De Trabajo";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		this.GroupBox5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DgvIngresarOT).EndInit();
		this.GroupBox6.ResumeLayout(false);
		this.GroupBox6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.ImagenCode).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FrmIngresarOT_Load(object sender, EventArgs e)
	{
        TxtHora.Text = EnviarDatos.hora;
        TxtPistolear.Focus();
		obtener_hora();
		obtener_datos();
		codigo_sucursal();
        Mostrar_Detalles();

    }

	private void FrmIngresarOT_Closing(object sender, CancelEventArgs e)
	{
		limpiar_cajas();
		Dispose();
		Close();
	}

	private void obtener_datos()
	{
		TxtFolio.Text = EnviarDatos.folio;
		TxtUsuario.Text = EnviarDatos.usuario;
		TxtDestino.Text = EnviarDatos.destino;
		TxtRampla.Text = EnviarDatos.rampla;
		TxtFecha.Text = EnviarDatos.fecha;
    }

	private void codigo_sucursal()
	{
		if (Operators.CompareString(TxtDestino.Text, "IQUIQUE", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "011";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "ANTOFAGASTA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "021";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "CALAMA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "022";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "COPIAPO", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "031";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "LA SERENA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "041";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "VALPARAISO", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "051";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "RANCAGUA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "061";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "ARICA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "151";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "PUERTO MONTT", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "101";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "TALCA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "071";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "PUNTA ARENAS", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "121";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "TEMUCO", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "091";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "OSORNO", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "102";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "CONCEPCION", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "081";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "VALLENAR", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "032";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "CURICO", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "072";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "LOS ANGELES", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "082";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "CHILLAN", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "083";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "COYHAIQUE", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "111";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "VALDIVIA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "141";
			TxtPistolear.Focus();
		}
		else if (Operators.CompareString(TxtDestino.Text, "LAMPA", TextCompare: false) == 0)
		{
			TxtCodigo.Text = "131";
			TxtPistolear.Focus();
		}
		else
		{
			Interaction.MsgBox("Debes Seleccionar Un Destino");
		}
	}

	private void codigo_a_txt()
	{
		if (Operators.CompareString(TxtCodigo2.Text, "011", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "IQUIQUE";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "021", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "ANTOFAGASTA";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "022", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "CALAMA";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "031", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "COPIAPO";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "041", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "LA SERENA";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "051", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "VALPARAISO";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "061", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "RANCAGUA";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "151", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "ARICA";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "101", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "PUERTO MONTT";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "071", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "TALCA";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "121", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "PUNTA ARENAS";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "091", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "TEMUCO";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "102", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "OSORNO";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "081", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "CONCEPCION";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "032", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "VALLENAR";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "072", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "CURICO";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "082", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "LOS ANGELES";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "083", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "CHILLAN";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "111", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "COYHAIQUE";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "141", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "VALDIVIA";
		}
		else if (Operators.CompareString(TxtCodigo2.Text, "131", TextCompare: false) == 0)
		{
			TxtDestino2.Text = "LAMPA";
		}
	}

	private void obtener_hora()
	{
		TxtHora.Text = DateTime.Now.ToLongTimeString();
	}

	private void limpiar_cajas()
	{
		TxtDestino.Text = "";
		TxtCodigo.Clear();
		TxtUsuario.Clear();
		TxtFecha.Clear();
		TxtHora.Clear();
		TxtRampla.Text = "";
		TxtCodigo2.Clear();
		TxtOt.Clear();
		TxtBulto.Clear();
		TxtDestino2.Clear();
		TxtFolio.Clear();
		TxtPistolear.Clear();
		TxtPistolear.Focus();
		obtener_hora();
	}

	private void BarCode128()
	{
		BarcodeWriter GENERADOR = new BarcodeWriter();
		GENERADOR.Format = BarcodeFormat.CODE_128;
		try
		{
			Bitmap IMAGEN = new Bitmap(GENERADOR.Write(TxtOt.Text), ImagenCode.Width, ImagenCode.Height);
			ImagenCode.Image = IMAGEN;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex = ex2;
			Interaction.MsgBox(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ordenar_datos()
	{
		DgvIngresarOT.Sort(DgvIngresarOT.Columns["OT"], ListSortDirection.Descending);
	}

	private void BtnAgregar_Click(object sender, EventArgs e)
	{
		if (TxtPistolear.TextLength < 22)
		{
			Interaction.MsgBox("Debes Ingresar Un Codigo Valido");
		}
		else if (Operators.CompareString(TxtCodigo.Text, TxtCodigo2.Text, TextCompare: false) == 0)
		{
			codigo_a_txt();
			BarCode128();
			MemoryStream ms = new MemoryStream();
			Bitmap bmpImage = new Bitmap(ImagenCode.Image);
			bmpImage.Save(ms, ImageFormat.Jpeg);
			byte[] bytImage = ms.ToArray();
			ms.Close();
			DgvIngresarOT.Rows.Add(TxtFolio.Text, TxtDestino2.Text, TxtCodigo2.Text, TxtOt.Text, TxtBulto.Text, TxtHora.Text, bytImage);
        }
		else
		{
			codigo_a_txt();
			BarCode128();
			MemoryStream ms2 = new MemoryStream();
			Bitmap bmpImage2 = new Bitmap(ImagenCode.Image);
			bmpImage2.Save(ms2, ImageFormat.Jpeg);
			byte[] bytImage2 = ms2.ToArray();
			ms2.Close();
			DgvIngresarOT.Rows.Add(TxtFolio.Text, TxtDestino2.Text, TxtCodigo2.Text, TxtOt.Text, TxtBulto.Text, TxtHora.Text, bytImage2);
		}
		GuardaOperacionTbl(TxtFolio.Text, TxtDestino2.Text, TxtCodigo2.Text, TxtOt.Text, TxtBulto.Text, TxtHora.Text);
        consolidaOt.setFolio(TxtFolio.Text);
        consolidaOt.ConsultarExpedicion(TxtOt.Text, Convert.ToInt32(TxtBulto.Text));
        consolidaOt.SumAllOt(TxtOt.Text);
    }

    private void Mostrar_Detalles()
    {
        ModuleDB.Conectar();
        string vSql = "select * from tbl_detalles where folio like'%" + TxtFolio.Text + "%'";
        MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
        MySqlDataReader vReader = vCmd.ExecuteReader();
        DgvIngresarOT.Rows.Clear();
        while (vReader.Read())
        {

            TxtFolio.Text = vReader.GetString(1);
            TxtDestino2.Text = vReader.GetString(2);
            TxtCodigo2.Text = vReader.GetString(3);
            TxtOt.Text =    vReader.GetString(4);
            TxtBulto.Text = vReader.GetString(5);
            TxtHora.Text = vReader.GetString(6);

            codigo_a_txt();
            BarCode128();
            MemoryStream ms2 = new MemoryStream();
            Bitmap bmpImage2 = new Bitmap(ImagenCode.Image);
            bmpImage2.Save(ms2, ImageFormat.Jpeg);
            byte[] bytImage2 = ms2.ToArray();
            ms2.Close();

            DgvIngresarOT.Rows.Add(TxtFolio.Text, TxtDestino2.Text, TxtCodigo2.Text, TxtOt.Text, TxtBulto.Text, TxtHora.Text, bytImage2);
            consolidaOt.ConsultarExpedicion(TxtOt.Text, Convert.ToInt32(TxtBulto.Text));
            consolidaOt.SumAllOt(TxtOt.Text);
        }
        vReader.Close();
        ModuleDB.Desconectar();
    }

    // Metodo que se accede al ingresar Operacion
    private void BtnOperacion_Click(object sender, EventArgs e)
	{
        oLog.Add("FrmIngresarOT : rampla: [" +TxtRampla.Text+ "] usuario: [" + TxtUsuario.Text + "] Cod Captura : [" + TxtPistolear.Text + "] Folio: [" + TxtFolio.Text + "]");

        if (TxtPistolear.TextLength == 22)
		{
            // cuando etiqueta es generada desde Alertran
			string Cadena1 = TxtPistolear.Text;
			string[] Palabra1 = Cadena1.Split(default(char));
			TxtCodigo2.Text = Palabra1[0].Substring(0, 3); // plaza origen
			string Cadena3 = TxtPistolear.Text;
			string[] Palabra3 = Cadena3.Split(default(char));
			TxtOt.Text = Palabra3[0].Substring(11, 8); // OT son 8 caracteres
			string Cadena5 = TxtPistolear.Text;
			string[] Palabra5 = Cadena5.Split(default(char));
			TxtBulto.Text = Palabra5[0].Substring(19, 3); // numero de bultos
			codigo_a_txt();
			obtener_hora();
			BtnAgregar.PerformClick();
			TxtPistolear.Clear();
			TxtPistolear.Focus();
		}
		else if (TxtPistolear.TextLength >= 25)
		{
            // cuando etiqueta es generada desde GTS
            string Cadena2 = TxtPistolear.Text;
			string[] Palabra2 = Cadena2.Split(default(char));
			TxtCodigo2.Text = Palabra2[0].Substring(3, 3); // Cod plaza destino
			string Cadena4 = TxtPistolear.Text;
			string[] Palabra4 = Cadena4.Split(default(char));
			TxtOt.Text = Palabra4[0].Substring(12, 9); // OT son 9 caracteres
			string Cadena6 = TxtPistolear.Text;
			string[] Palabra6 = Cadena6.Split(default(char));
			TxtBulto.Text = Palabra6[0].Substring(24, 3); // Bultos
			codigo_a_txt();
			obtener_hora();
			BtnAgregar.PerformClick();
			TxtPistolear.Clear();
			TxtPistolear.Focus();
		}
    }

	private void GuardaOperacionTbl(string Folio, string Destino, string Codigo, string Ot, string Nbulto, string Hora) 
	{
		ModuleDB.Conectar();
		string vSql = "Insert into tbl_detalles (folio,destino,codigo,ot,bulto,hora) values ('" + Folio + "', '" + Destino + "', '" + Codigo + "', '" + Ot + "', '" + Nbulto + "', '" + Hora + "')";
		MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
		vCmd.ExecuteNonQuery();
		ModuleDB.Desconectar();
    }

    private void guardar_detalles()
	{
    	string conteo = Conversions.ToString(DgvIngresarOT.RowCount);
		Interaction.MsgBox("Registros Guardados - El Total De Registros Es: " + conteo, MsgBoxStyle.Information, ":: PDQ :::");
        ordenar_datos();
	}

	private void imprimir_reporte()
	{
		OTDataSet ds = new OTDataSet();
		DataTable dt = new DataTable();
		dt = ds.Tables["OT"];
		checked
		{
			int num = DgvIngresarOT.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				dt.Rows.Add(DgvIngresarOT.Rows[i].Cells["DESTINO"].Value, DgvIngresarOT.Rows[i].Cells["CODIGO"].Value, DgvIngresarOT.Rows[i].Cells["OT"].Value, DgvIngresarOT.Rows[i].Cells["NBULTO"].Value, DgvIngresarOT.Rows[i].Cells["HORA"].Value, DgvIngresarOT.Rows[i].Cells["BARCODE"].Value);
			}
			LocalReport localReport = MyProject.Forms.FrmReporteOT.ReportViewer1.LocalReport;
			localReport.ReportPath = "ReporteOT.rdlc";
			localReport.DataSources.Clear();
			localReport.DataSources.Add(new ReportDataSource("OTDataset", dt));
            var parameters = new[] { new ReportParameter("PesoVolumetrico", consolidaOt.GetPesoVolumetrico().ToString())
                ,new ReportParameter("Kilos", consolidaOt.GetKilos().ToString())};
                
            localReport.SetParameters(parameters);
       		localReport = null;
            MyProject.Forms.FrmReporteOT.ShowDialog();
			MyProject.Forms.FrmReporteOT.ReportViewer1.RefreshReport();
            limpiar_cajas();
		}
    }

	private void DgvIngresarOT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		int Total = 0;
		checked
		{
			int num = DgvIngresarOT.RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectEqual(DgvIngresarOT.Rows[i].Cells[2].Value, TxtCodigo.Text, TextCompare: false))
				{
					DgvIngresarOT.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(139, 195, 74);
					Total++;
				}
				else
				{
					DgvIngresarOT.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(244, 67, 54);
				}
			}
		}
	}

	private void BtnImprimir_Click(object sender, EventArgs e)
	{
        consolidaOt.ValidaExpedicionesCompleta();
        
        TxtPistolear.Focus();
        guardar_detalles();
        imprimir_reporte();
		Close();
	}

    public static string getDirectory()
    { 
        return Directory.GetCurrentDirectory();
    }
}

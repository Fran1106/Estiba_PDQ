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
using MySql.Data.MySqlClient;
using Sistema_Estiba_PDQ.My;
using Sistema_Estiba_PDQ.My.Resources;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmRegistrosOT : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DgvDatos")]
	private DataGridView _DgvDatos;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TxtBuscarDatos")]
	private TextBox _TxtBuscarDatos;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TxtBuscarDetalles")]
	private TextBox _TxtBuscarDetalles;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnImprimir")]
	private Button _BtnImprimir;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnActualizar")]
	private Button _BtnActualizar;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	internal virtual DataGridView DgvDatos
	{
		[CompilerGenerated]
		get
		{
			return _DgvDatos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DgvDatos_CellClick;
			DataGridView dgvDatos = _DgvDatos;
			if (dgvDatos != null)
			{
				dgvDatos.CellClick -= value2;
			}
			_DgvDatos = value;
			dgvDatos = _DgvDatos;
			if (dgvDatos != null)
			{
				dgvDatos.CellClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TxtFechaDatos")]
	internal virtual TextBox TxtFechaDatos
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

	[field: AccessedThroughProperty("TxtRamplaDatos")]
	internal virtual TextBox TxtRamplaDatos
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

	[field: AccessedThroughProperty("TxtDestinoDatos")]
	internal virtual TextBox TxtDestinoDatos
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

	[field: AccessedThroughProperty("TxtUsuariosDatos")]
	internal virtual TextBox TxtUsuariosDatos
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

	[field: AccessedThroughProperty("TxtIdDatos")]
	internal virtual TextBox TxtIdDatos
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

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TxtBuscarDatos
	{
		[CompilerGenerated]
		get
		{
			return _TxtBuscarDatos;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TxtBuscarDatos_TextChanged;
			TextBox txtBuscarDatos = _TxtBuscarDatos;
			if (txtBuscarDatos != null)
			{
				txtBuscarDatos.TextChanged -= value2;
			}
			_TxtBuscarDatos = value;
			txtBuscarDatos = _TxtBuscarDatos;
			if (txtBuscarDatos != null)
			{
				txtBuscarDatos.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DgvDetalles")]
	internal virtual DataGridView DgvDetalles
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

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TxtBuscarDetalles
	{
		[CompilerGenerated]
		get
		{
			return _TxtBuscarDetalles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TxtBuscarDetalles_TextChanged;
			TextBox txtBuscarDetalles = _TxtBuscarDetalles;
			if (txtBuscarDetalles != null)
			{
				txtBuscarDetalles.TextChanged -= value2;
			}
			_TxtBuscarDetalles = value;
			txtBuscarDetalles = _TxtBuscarDetalles;
			if (txtBuscarDetalles != null)
			{
				txtBuscarDetalles.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("TxtHoraDetalle")]
	internal virtual TextBox TxtHoraDetalle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtBultoDetalle")]
	internal virtual TextBox TxtBultoDetalle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtOtDetalle")]
	internal virtual TextBox TxtOtDetalle
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

	[field: AccessedThroughProperty("TxtCodigoDetalle")]
	internal virtual TextBox TxtCodigoDetalle
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

	[field: AccessedThroughProperty("TxtDestinoDetalle")]
	internal virtual TextBox TxtDestinoDetalle
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

	[field: AccessedThroughProperty("TxtIdDetalle")]
	internal virtual TextBox TxtIdDetalle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtIdDatosDetalle")]
	internal virtual TextBox TxtIdDatosDetalle
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

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BtnActualizar
	{
		[CompilerGenerated]
		get
		{
			return _BtnActualizar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnActualizar_Click;
			Button btnActualizar = _BtnActualizar;
			if (btnActualizar != null)
			{
				btnActualizar.Click -= value2;
			}
			_BtnActualizar = value;
			btnActualizar = _BtnActualizar;
			if (btnActualizar != null)
			{
				btnActualizar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ID")]
	internal virtual DataGridViewTextBoxColumn ID
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

	[field: AccessedThroughProperty("USUARIO")]
	internal virtual DataGridViewTextBoxColumn USUARIO
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

	[field: AccessedThroughProperty("RAMPLA")]
	internal virtual DataGridViewTextBoxColumn RAMPLA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FECHA")]
	internal virtual DataGridViewTextBoxColumn FECHA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("primero")]
	internal virtual DataGridViewTextBoxColumn primero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("segundo")]
	internal virtual DataGridViewTextBoxColumn segundo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tercero")]
	internal virtual DataGridViewTextBoxColumn tercero
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cuarto")]
	internal virtual DataGridViewTextBoxColumn cuarto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("quinto")]
	internal virtual DataGridViewTextBoxColumn quinto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sexto")]
	internal virtual DataGridViewTextBoxColumn sexto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("septimo")]
	internal virtual DataGridViewTextBoxColumn septimo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmRegistrosOT()
	{
		base.Load += FrmRegistrosOT_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmRegistrosOT));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label18 = new System.Windows.Forms.Label();
		this.BtnActualizar = new System.Windows.Forms.Button();
		this.DgvDatos = new System.Windows.Forms.DataGridView();
		this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.RAMPLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.TxtFolio = new System.Windows.Forms.TextBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.TxtFechaDatos = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.TxtRamplaDatos = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TxtDestinoDatos = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TxtUsuariosDatos = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.TxtIdDatos = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.TxtBuscarDatos = new System.Windows.Forms.TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.Label19 = new System.Windows.Forms.Label();
		this.BtnImprimir = new System.Windows.Forms.Button();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.DgvDetalles = new System.Windows.Forms.DataGridView();
		this.primero = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.segundo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tercero = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.quinto = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.sexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.septimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.TxtHoraDetalle = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.TxtBultoDetalle = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.TxtOtDetalle = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.TxtCodigoDetalle = new System.Windows.Forms.TextBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.TxtBuscarDetalles = new System.Windows.Forms.TextBox();
		this.TxtDestinoDetalle = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.TxtIdDetalle = new System.Windows.Forms.TextBox();
		this.TxtIdDatosDetalle = new System.Windows.Forms.TextBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DgvDatos).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		this.GroupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DgvDetalles).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Label18);
		this.GroupBox1.Controls.Add(this.BtnActualizar);
		this.GroupBox1.Controls.Add(this.DgvDatos);
		this.GroupBox1.Controls.Add(this.TxtFolio);
		this.GroupBox1.Controls.Add(this.Label17);
		this.GroupBox1.Controls.Add(this.Label6);
		this.GroupBox1.Controls.Add(this.TxtFechaDatos);
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Controls.Add(this.TxtRamplaDatos);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.TxtDestinoDatos);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.TxtUsuariosDatos);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.TxtIdDatos);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.PictureBox3);
		this.GroupBox1.Controls.Add(this.TxtBuscarDatos);
		this.GroupBox1.Controls.Add(this.Label9);
		this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
		this.GroupBox1.Location = new System.Drawing.Point(0, 0);
		this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
		this.GroupBox1.Size = new System.Drawing.Size(656, 647);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.Label18.AutoSize = true;
		this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label18.ForeColor = System.Drawing.Color.White;
		this.Label18.Location = new System.Drawing.Point(561, 78);
		this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(80, 17);
		this.Label18.TabIndex = 43;
		this.Label18.Text = "Actualizar";
		this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BtnActualizar.BackgroundImage = Sistema_Estiba_PDQ.My.Resources.Resources.IcoActualizar;
		this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.BtnActualizar.Location = new System.Drawing.Point(561, 10);
		this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
		this.BtnActualizar.Name = "BtnActualizar";
		this.BtnActualizar.Size = new System.Drawing.Size(87, 68);
		this.BtnActualizar.TabIndex = 42;
		this.BtnActualizar.UseVisualStyleBackColor = true;
		this.DgvDatos.AllowUserToAddRows = false;
		this.DgvDatos.AllowUserToDeleteRows = false;
		this.DgvDatos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DgvDatos.Columns.AddRange(this.ID, this.FOLIO, this.USUARIO, this.DESTINO, this.RAMPLA, this.FECHA);
		this.DgvDatos.Location = new System.Drawing.Point(8, 97);
		this.DgvDatos.Margin = new System.Windows.Forms.Padding(4);
		this.DgvDatos.Name = "DgvDatos";
		this.DgvDatos.ReadOnly = true;
		this.DgvDatos.RowHeadersWidth = 51;
		this.DgvDatos.Size = new System.Drawing.Size(640, 543);
		this.DgvDatos.TabIndex = 16;
		this.ID.HeaderText = "Id";
		this.ID.MinimumWidth = 6;
		this.ID.Name = "ID";
		this.ID.ReadOnly = true;
		this.ID.Width = 47;
		this.FOLIO.HeaderText = "Folio";
		this.FOLIO.MinimumWidth = 6;
		this.FOLIO.Name = "FOLIO";
		this.FOLIO.ReadOnly = true;
		this.FOLIO.Width = 66;
		this.USUARIO.HeaderText = "Usuario";
		this.USUARIO.MinimumWidth = 6;
		this.USUARIO.Name = "USUARIO";
		this.USUARIO.ReadOnly = true;
		this.USUARIO.Width = 83;
		this.DESTINO.HeaderText = "Destino";
		this.DESTINO.MinimumWidth = 6;
		this.DESTINO.Name = "DESTINO";
		this.DESTINO.ReadOnly = true;
		this.DESTINO.Width = 82;
		this.RAMPLA.HeaderText = "Rampla";
		this.RAMPLA.MinimumWidth = 6;
		this.RAMPLA.Name = "RAMPLA";
		this.RAMPLA.ReadOnly = true;
		this.RAMPLA.Width = 84;
		this.FECHA.HeaderText = "Fecha";
		this.FECHA.MinimumWidth = 6;
		this.FECHA.Name = "FECHA";
		this.FECHA.ReadOnly = true;
		this.FECHA.Width = 74;
		this.TxtFolio.Location = new System.Drawing.Point(180, 262);
		this.TxtFolio.Margin = new System.Windows.Forms.Padding(4);
		this.TxtFolio.Name = "TxtFolio";
		this.TxtFolio.Size = new System.Drawing.Size(241, 22);
		this.TxtFolio.TabIndex = 29;
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.ForeColor = System.Drawing.Color.White;
		this.Label17.Location = new System.Drawing.Point(65, 267);
		this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(54, 17);
		this.Label17.TabIndex = 28;
		this.Label17.Text = "FOLIO";
		this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.White;
		this.Label6.Location = new System.Drawing.Point(151, 17);
		this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(288, 25);
		this.Label6.TabIndex = 27;
		this.Label6.Text = "Registros De Planillas Estiba\r\n";
		this.TxtFechaDatos.Location = new System.Drawing.Point(180, 389);
		this.TxtFechaDatos.Margin = new System.Windows.Forms.Padding(4);
		this.TxtFechaDatos.Name = "TxtFechaDatos";
		this.TxtFechaDatos.Size = new System.Drawing.Size(241, 22);
		this.TxtFechaDatos.TabIndex = 26;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(65, 394);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(58, 17);
		this.Label5.TabIndex = 25;
		this.Label5.Text = "FECHA";
		this.TxtRamplaDatos.Location = new System.Drawing.Point(180, 357);
		this.TxtRamplaDatos.Margin = new System.Windows.Forms.Padding(4);
		this.TxtRamplaDatos.Name = "TxtRamplaDatos";
		this.TxtRamplaDatos.Size = new System.Drawing.Size(241, 22);
		this.TxtRamplaDatos.TabIndex = 24;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(65, 362);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(70, 17);
		this.Label4.TabIndex = 23;
		this.Label4.Text = "RAMPLA";
		this.TxtDestinoDatos.Location = new System.Drawing.Point(180, 325);
		this.TxtDestinoDatos.Margin = new System.Windows.Forms.Padding(4);
		this.TxtDestinoDatos.Name = "TxtDestinoDatos";
		this.TxtDestinoDatos.Size = new System.Drawing.Size(241, 22);
		this.TxtDestinoDatos.TabIndex = 22;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(65, 330);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(76, 17);
		this.Label3.TabIndex = 21;
		this.Label3.Text = "DESTINO";
		this.TxtUsuariosDatos.Location = new System.Drawing.Point(180, 293);
		this.TxtUsuariosDatos.Margin = new System.Windows.Forms.Padding(4);
		this.TxtUsuariosDatos.Name = "TxtUsuariosDatos";
		this.TxtUsuariosDatos.Size = new System.Drawing.Size(241, 22);
		this.TxtUsuariosDatos.TabIndex = 20;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(65, 298);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(77, 17);
		this.Label2.TabIndex = 19;
		this.Label2.Text = "USUARIO";
		this.TxtIdDatos.Location = new System.Drawing.Point(180, 230);
		this.TxtIdDatos.Margin = new System.Windows.Forms.Padding(4);
		this.TxtIdDatos.Name = "TxtIdDatos";
		this.TxtIdDatos.Size = new System.Drawing.Size(241, 22);
		this.TxtIdDatos.TabIndex = 18;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(65, 235);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(23, 17);
		this.Label1.TabIndex = 17;
		this.Label1.Text = "ID";
		this.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.PictureBox3.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Buscar;
		this.PictureBox3.Location = new System.Drawing.Point(431, 53);
		this.PictureBox3.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(40, 37);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox3.TabIndex = 15;
		this.PictureBox3.TabStop = false;
		this.TxtBuscarDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.TxtBuscarDatos.Location = new System.Drawing.Point(180, 65);
		this.TxtBuscarDatos.Margin = new System.Windows.Forms.Padding(4);
		this.TxtBuscarDatos.Name = "TxtBuscarDatos";
		this.TxtBuscarDatos.Size = new System.Drawing.Size(241, 22);
		this.TxtBuscarDatos.TabIndex = 14;
		this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.White;
		this.Label9.Location = new System.Drawing.Point(104, 70);
		this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(63, 17);
		this.Label9.TabIndex = 13;
		this.Label9.Text = "Buscar:";
		this.GroupBox2.Controls.Add(this.Label19);
		this.GroupBox2.Controls.Add(this.BtnImprimir);
		this.GroupBox2.Controls.Add(this.PictureBox1);
		this.GroupBox2.Controls.Add(this.DgvDetalles);
		this.GroupBox2.Controls.Add(this.TxtHoraDetalle);
		this.GroupBox2.Controls.Add(this.Label16);
		this.GroupBox2.Controls.Add(this.TxtBultoDetalle);
		this.GroupBox2.Controls.Add(this.Label15);
		this.GroupBox2.Controls.Add(this.TxtOtDetalle);
		this.GroupBox2.Controls.Add(this.Label10);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.TxtCodigoDetalle);
		this.GroupBox2.Controls.Add(this.PictureBox2);
		this.GroupBox2.Controls.Add(this.Label11);
		this.GroupBox2.Controls.Add(this.TxtBuscarDetalles);
		this.GroupBox2.Controls.Add(this.TxtDestinoDetalle);
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.Label12);
		this.GroupBox2.Controls.Add(this.TxtIdDetalle);
		this.GroupBox2.Controls.Add(this.TxtIdDatosDetalle);
		this.GroupBox2.Controls.Add(this.Label14);
		this.GroupBox2.Controls.Add(this.Label13);
		this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.GroupBox2.Location = new System.Drawing.Point(656, 0);
		this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
		this.GroupBox2.Size = new System.Drawing.Size(752, 647);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.Label19.AutoSize = true;
		this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label19.ForeColor = System.Drawing.Color.White;
		this.Label19.Location = new System.Drawing.Point(661, 78);
		this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(65, 17);
		this.Label19.TabIndex = 44;
		this.Label19.Text = "Imprimir";
		this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BtnImprimir.BackgroundImage = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Imprimir1;
		this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.BtnImprimir.Location = new System.Drawing.Point(649, 10);
		this.BtnImprimir.Margin = new System.Windows.Forms.Padding(4);
		this.BtnImprimir.Name = "BtnImprimir";
		this.BtnImprimir.Size = new System.Drawing.Size(87, 68);
		this.BtnImprimir.TabIndex = 3;
		this.BtnImprimir.UseVisualStyleBackColor = true;
		this.PictureBox1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.PDQ_LOGO;
		this.PictureBox1.Location = new System.Drawing.Point(8, 22);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(165, 68);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 2;
		this.PictureBox1.TabStop = false;
		this.DgvDetalles.AllowUserToAddRows = false;
		this.DgvDetalles.AllowUserToDeleteRows = false;
		this.DgvDetalles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DgvDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DgvDetalles.Columns.AddRange(this.primero, this.segundo, this.tercero, this.cuarto, this.quinto, this.sexto, this.septimo);
		this.DgvDetalles.Location = new System.Drawing.Point(8, 97);
		this.DgvDetalles.Margin = new System.Windows.Forms.Padding(4);
		this.DgvDetalles.Name = "DgvDetalles";
		this.DgvDetalles.ReadOnly = true;
		this.DgvDetalles.RowHeadersWidth = 51;
		this.DgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DgvDetalles.Size = new System.Drawing.Size(728, 543);
		this.DgvDetalles.TabIndex = 32;
		this.primero.HeaderText = "Id";
		this.primero.MinimumWidth = 6;
		this.primero.Name = "primero";
		this.primero.ReadOnly = true;
		this.primero.Width = 47;
		this.segundo.HeaderText = "Folio";
		this.segundo.MinimumWidth = 6;
		this.segundo.Name = "segundo";
		this.segundo.ReadOnly = true;
		this.segundo.Width = 66;
		this.tercero.HeaderText = "Destino";
		this.tercero.MinimumWidth = 6;
		this.tercero.Name = "tercero";
		this.tercero.ReadOnly = true;
		this.tercero.Width = 82;
		this.cuarto.HeaderText = "Código";
		this.cuarto.MinimumWidth = 6;
		this.cuarto.Name = "cuarto";
		this.cuarto.ReadOnly = true;
		this.cuarto.Width = 80;
		this.quinto.HeaderText = "Ot";
		this.quinto.MinimumWidth = 6;
		this.quinto.Name = "quinto";
		this.quinto.ReadOnly = true;
		this.quinto.Width = 49;
		this.sexto.HeaderText = "N° Bulto";
		this.sexto.MinimumWidth = 6;
		this.sexto.Name = "sexto";
		this.sexto.ReadOnly = true;
		this.sexto.Width = 83;
		this.septimo.HeaderText = "Hora";
		this.septimo.MinimumWidth = 6;
		this.septimo.Name = "septimo";
		this.septimo.ReadOnly = true;
		this.septimo.Width = 66;
		this.TxtHoraDetalle.Location = new System.Drawing.Point(197, 364);
		this.TxtHoraDetalle.Margin = new System.Windows.Forms.Padding(4);
		this.TxtHoraDetalle.Name = "TxtHoraDetalle";
		this.TxtHoraDetalle.Size = new System.Drawing.Size(241, 22);
		this.TxtHoraDetalle.TabIndex = 41;
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.ForeColor = System.Drawing.Color.White;
		this.Label16.Location = new System.Drawing.Point(83, 369);
		this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(52, 17);
		this.Label16.TabIndex = 40;
		this.Label16.Text = "HORA";
		this.TxtBultoDetalle.Location = new System.Drawing.Point(197, 332);
		this.TxtBultoDetalle.Margin = new System.Windows.Forms.Padding(4);
		this.TxtBultoDetalle.Name = "TxtBultoDetalle";
		this.TxtBultoDetalle.Size = new System.Drawing.Size(241, 22);
		this.TxtBultoDetalle.TabIndex = 39;
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.ForeColor = System.Drawing.Color.White;
		this.Label15.Location = new System.Drawing.Point(83, 337);
		this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(60, 17);
		this.Label15.TabIndex = 38;
		this.Label15.Text = "BULTO";
		this.TxtOtDetalle.Location = new System.Drawing.Point(197, 300);
		this.TxtOtDetalle.Margin = new System.Windows.Forms.Padding(4);
		this.TxtOtDetalle.Name = "TxtOtDetalle";
		this.TxtOtDetalle.Size = new System.Drawing.Size(241, 22);
		this.TxtOtDetalle.TabIndex = 37;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.ForeColor = System.Drawing.Color.White;
		this.Label10.Location = new System.Drawing.Point(83, 305);
		this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(30, 17);
		this.Label10.TabIndex = 36;
		this.Label10.Text = "OT";
		this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.White;
		this.Label7.Location = new System.Drawing.Point(239, 17);
		this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(252, 25);
		this.Label7.TabIndex = 31;
		this.Label7.Text = "Detalles De Cargas (OT)";
		this.TxtCodigoDetalle.Location = new System.Drawing.Point(197, 268);
		this.TxtCodigoDetalle.Margin = new System.Windows.Forms.Padding(4);
		this.TxtCodigoDetalle.Name = "TxtCodigoDetalle";
		this.TxtCodigoDetalle.Size = new System.Drawing.Size(241, 22);
		this.TxtCodigoDetalle.TabIndex = 35;
		this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.PictureBox2.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Buscar;
		this.PictureBox2.Location = new System.Drawing.Point(505, 53);
		this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(40, 37);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 30;
		this.PictureBox2.TabStop = false;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.ForeColor = System.Drawing.Color.White;
		this.Label11.Location = new System.Drawing.Point(83, 273);
		this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(69, 17);
		this.Label11.TabIndex = 34;
		this.Label11.Text = "CODIGO";
		this.TxtBuscarDetalles.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.TxtBuscarDetalles.Location = new System.Drawing.Point(255, 65);
		this.TxtBuscarDetalles.Margin = new System.Windows.Forms.Padding(4);
		this.TxtBuscarDetalles.Name = "TxtBuscarDetalles";
		this.TxtBuscarDetalles.Size = new System.Drawing.Size(241, 22);
		this.TxtBuscarDetalles.TabIndex = 29;
		this.TxtDestinoDetalle.Location = new System.Drawing.Point(197, 236);
		this.TxtDestinoDetalle.Margin = new System.Windows.Forms.Padding(4);
		this.TxtDestinoDetalle.Name = "TxtDestinoDetalle";
		this.TxtDestinoDetalle.Size = new System.Drawing.Size(241, 22);
		this.TxtDestinoDetalle.TabIndex = 33;
		this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.White;
		this.Label8.Location = new System.Drawing.Point(179, 70);
		this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(63, 17);
		this.Label8.TabIndex = 28;
		this.Label8.Text = "Buscar:";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.White;
		this.Label12.Location = new System.Drawing.Point(83, 241);
		this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(76, 17);
		this.Label12.TabIndex = 32;
		this.Label12.Text = "DESTINO";
		this.TxtIdDetalle.Location = new System.Drawing.Point(197, 172);
		this.TxtIdDetalle.Margin = new System.Windows.Forms.Padding(4);
		this.TxtIdDetalle.Name = "TxtIdDetalle";
		this.TxtIdDetalle.Size = new System.Drawing.Size(241, 22);
		this.TxtIdDetalle.TabIndex = 29;
		this.TxtIdDatosDetalle.Location = new System.Drawing.Point(197, 204);
		this.TxtIdDatosDetalle.Margin = new System.Windows.Forms.Padding(4);
		this.TxtIdDatosDetalle.Name = "TxtIdDatosDetalle";
		this.TxtIdDatosDetalle.Size = new System.Drawing.Size(241, 22);
		this.TxtIdDatosDetalle.TabIndex = 31;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.ForeColor = System.Drawing.Color.White;
		this.Label14.Location = new System.Drawing.Point(83, 177);
		this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(97, 17);
		this.Label14.TabIndex = 28;
		this.Label14.Text = "ID DETALLE";
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.White;
		this.Label13.Location = new System.Drawing.Point(83, 209);
		this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(97, 17);
		this.Label13.TabIndex = 30;
		this.Label13.Text = "ID DATOS D";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		base.ClientSize = new System.Drawing.Size(1408, 647);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.MinimizeBox = false;
		base.Name = "FrmRegistrosOT";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Registros De Ordenes De Trabajo";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DgvDatos).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DgvDetalles).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		base.ResumeLayout(false);
	}

	private void FrmRegistrosOT_Load(object sender, EventArgs e)
	{
		Mostrar_Datos();
	}

	private void Mostrar_Datos()
	{
		ModuleDB.Conectar();
		string vSql = "select * from tbl_datos";
		MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
		MySqlDataReader vReader = vCmd.ExecuteReader();
		DgvDatos.Rows.Clear();
		while (vReader.Read())
		{
			DgvDatos.Rows.Add(vReader.GetString(0), vReader.GetString(1), vReader.GetString(2), vReader.GetString(3), vReader.GetString(4), vReader.GetString(5));
		}
		vReader.Close();
		ModuleDB.Desconectar();
	}

	private void Buscar_Datos()
	{
		ModuleDB.Conectar();
		string vSql = "select * from tbl_datos where folio like'%" + TxtBuscarDatos.Text + "%'or usuario like'%" + TxtBuscarDatos.Text + "%'or fecha like'%" + TxtBuscarDatos.Text + "%'or destino like'%" + TxtBuscarDatos.Text + "%'";
		MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
		MySqlDataReader vReader = vCmd.ExecuteReader();
		DgvDatos.Rows.Clear();
		while (vReader.Read())
		{
			DgvDatos.Rows.Add(vReader.GetString(0), vReader.GetString(1), vReader.GetString(2), vReader.GetString(3), vReader.GetString(4), vReader.GetString(5));
		}
		vReader.Close();
		ModuleDB.Desconectar();
	}

	private void TxtBuscarDatos_TextChanged(object sender, EventArgs e)
	{
		Buscar_Datos();
	}

	private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		TxtIdDatos.Text = DgvDatos.CurrentRow.Cells["id"].Value.ToString();
		TxtFolio.Text = DgvDatos.CurrentRow.Cells["folio"].Value.ToString();
		TxtUsuariosDatos.Text = DgvDatos.CurrentRow.Cells["usuario"].Value.ToString();
		TxtDestinoDatos.Text = DgvDatos.CurrentRow.Cells["destino"].Value.ToString();
		TxtRamplaDatos.Text = DgvDatos.CurrentRow.Cells["rampla"].Value.ToString();
		TxtFechaDatos.Text = DgvDatos.CurrentRow.Cells["fecha"].Value.ToString();
		Mostrar_Detalles();
	}

	private void BtnActualizar_Click(object sender, EventArgs e)
	{
		Mostrar_Datos();
	}

	private void Mostrar_Detalles()
	{
		ModuleDB.Conectar();
		string vSql = "select * from tbl_detalles where folio like'%" + TxtFolio.Text + "%'";
		MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
		MySqlDataReader vReader = vCmd.ExecuteReader();
		DgvDetalles.Rows.Clear();
		while (vReader.Read())
		{
			DgvDetalles.Rows.Add(vReader.GetString(0), vReader.GetString(1), vReader.GetString(2), vReader.GetString(3), vReader.GetString(4), vReader.GetString(5), vReader.GetString(6));
		}
		vReader.Close();
		ModuleDB.Desconectar();
	}

	private void Buscar_Detalles()
	{
		ModuleDB.Conectar();
		string vSql = "select * from tbl_detalles where ot like'%" + TxtBuscarDetalles.Text + "%'";
		MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
		MySqlDataReader vReader = vCmd.ExecuteReader();
		DgvDetalles.Rows.Clear();
		while (vReader.Read())
		{
			DgvDetalles.Rows.Add(vReader.GetString(0), vReader.GetString(1), vReader.GetString(2), vReader.GetString(3), vReader.GetString(4), vReader.GetString(5), vReader.GetString(6));
		}
		vReader.Close();
		ModuleDB.Desconectar();
	}

	private void TxtBuscarDetalles_TextChanged(object sender, EventArgs e)
	{
		Buscar_Detalles();
	}

	private void BtnImprimir_Click(object sender, EventArgs e)
	{
		checked
		{
			if (DgvDatos.SelectedRows.Count > 0)
			{
				OtDataSet2 ds = new OtDataSet2();
				DataTable dt = new DataTable();
				dt = ds.Tables["Respaldo"];
				int num = DgvDetalles.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dt.Rows.Add(DgvDetalles.Rows[i].Cells["tercero"].Value, DgvDetalles.Rows[i].Cells["cuarto"].Value, DgvDetalles.Rows[i].Cells["quinto"].Value, DgvDetalles.Rows[i].Cells["sexto"].Value, DgvDetalles.Rows[i].Cells["septimo"].Value);
				}
				LocalReport localReport = MyProject.Forms.FrmReporteOT2.ReportViewer1.LocalReport;
				localReport.ReportPath = "ReporteRespaldo.rdlc";
				localReport.DataSources.Clear();
				localReport.DataSources.Add(new ReportDataSource("RespaldoDataSet", dt));
				localReport = null;
				MyProject.Forms.FrmReporteOT2.Show();
				MyProject.Forms.FrmReporteOT2.ReportViewer1.RefreshReport();
			}
			else
			{
				Interaction.MsgBox("Debes Seleccionar Un Registro De Planilla Estiba");
			}
		}
	}
}

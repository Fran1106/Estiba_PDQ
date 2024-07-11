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
public class FrmUsuarios : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnEliminar")]
	private Button _BtnEliminar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnEditar")]
	private Button _BtnEditar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnGuardar")]
	private Button _BtnGuardar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnNuevo")]
	private Button _BtnNuevo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DgvUsuarios")]
	private DataGridView _DgvUsuarios;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TxtBuscar")]
	private TextBox _TxtBuscar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnReporte")]
	private Button _BtnReporte;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtPassword")]
	internal virtual TextBox TxtPassword
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

	[field: AccessedThroughProperty("TxtUsuario")]
	internal virtual TextBox TxtUsuario
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

	[field: AccessedThroughProperty("TxtId")]
	internal virtual TextBox TxtId
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

	internal virtual Button BtnEliminar
	{
		[CompilerGenerated]
		get
		{
			return _BtnEliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnEliminar_Click;
			Button btnEliminar = _BtnEliminar;
			if (btnEliminar != null)
			{
				btnEliminar.Click -= value2;
			}
			_BtnEliminar = value;
			btnEliminar = _BtnEliminar;
			if (btnEliminar != null)
			{
				btnEliminar.Click += value2;
			}
		}
	}

	internal virtual Button BtnEditar
	{
		[CompilerGenerated]
		get
		{
			return _BtnEditar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnEditar_Click;
			Button btnEditar = _BtnEditar;
			if (btnEditar != null)
			{
				btnEditar.Click -= value2;
			}
			_BtnEditar = value;
			btnEditar = _BtnEditar;
			if (btnEditar != null)
			{
				btnEditar.Click += value2;
			}
		}
	}

	internal virtual Button BtnGuardar
	{
		[CompilerGenerated]
		get
		{
			return _BtnGuardar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnGuardar_Click;
			Button btnGuardar = _BtnGuardar;
			if (btnGuardar != null)
			{
				btnGuardar.Click -= value2;
			}
			_BtnGuardar = value;
			btnGuardar = _BtnGuardar;
			if (btnGuardar != null)
			{
				btnGuardar.Click += value2;
			}
		}
	}

	internal virtual Button BtnNuevo
	{
		[CompilerGenerated]
		get
		{
			return _BtnNuevo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnNuevo_Click;
			Button btnNuevo = _BtnNuevo;
			if (btnNuevo != null)
			{
				btnNuevo.Click -= value2;
			}
			_BtnNuevo = value;
			btnNuevo = _BtnNuevo;
			if (btnNuevo != null)
			{
				btnNuevo.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DgvUsuarios
	{
		[CompilerGenerated]
		get
		{
			return _DgvUsuarios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DgvUsuarios_CellClick;
			DataGridView dgvUsuarios = _DgvUsuarios;
			if (dgvUsuarios != null)
			{
				dgvUsuarios.CellClick -= value2;
			}
			_DgvUsuarios = value;
			dgvUsuarios = _DgvUsuarios;
			if (dgvUsuarios != null)
			{
				dgvUsuarios.CellClick += value2;
			}
		}
	}

	internal virtual TextBox TxtBuscar
	{
		[CompilerGenerated]
		get
		{
			return _TxtBuscar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TxtBuscar_TextChanged;
			TextBox txtBuscar = _TxtBuscar;
			if (txtBuscar != null)
			{
				txtBuscar.TextChanged -= value2;
			}
			_TxtBuscar = value;
			txtBuscar = _TxtBuscar;
			if (txtBuscar != null)
			{
				txtBuscar.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	internal virtual Button BtnReporte
	{
		[CompilerGenerated]
		get
		{
			return _BtnReporte;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button btnReporte = _BtnReporte;
			if (btnReporte != null)
			{
				btnReporte.Click -= value2;
			}
			_BtnReporte = value;
			btnReporte = _BtnReporte;
			if (btnReporte != null)
			{
				btnReporte.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ID")]
	internal virtual DataGridViewTextBoxColumn ID
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

	[field: AccessedThroughProperty("CLAVE")]
	internal virtual DataGridViewTextBoxColumn CLAVE
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmUsuarios()
	{
		base.Load += FrmUsuarios_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmUsuarios));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TxtPassword = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TxtUsuario = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.TxtId = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.BtnReporte = new System.Windows.Forms.Button();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.BtnEliminar = new System.Windows.Forms.Button();
		this.BtnEditar = new System.Windows.Forms.Button();
		this.BtnGuardar = new System.Windows.Forms.Button();
		this.BtnNuevo = new System.Windows.Forms.Button();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.DgvUsuarios = new System.Windows.Forms.DataGridView();
		this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.TxtBuscar = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DgvUsuarios).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.TxtPassword);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.TxtUsuario);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.TxtId);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(16, 15);
		this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
		this.GroupBox1.Size = new System.Drawing.Size(507, 201);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.TxtPassword.Location = new System.Drawing.Point(124, 130);
		this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
		this.TxtPassword.Name = "TxtPassword";
		this.TxtPassword.Size = new System.Drawing.Size(344, 22);
		this.TxtPassword.TabIndex = 5;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(19, 139);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(96, 17);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Contraseña:";
		this.TxtUsuario.Location = new System.Drawing.Point(124, 87);
		this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
		this.TxtUsuario.Name = "TxtUsuario";
		this.TxtUsuario.Size = new System.Drawing.Size(344, 22);
		this.TxtUsuario.TabIndex = 3;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(19, 96);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(69, 17);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Usuario:";
		this.TxtId.Enabled = false;
		this.TxtId.Location = new System.Drawing.Point(124, 44);
		this.TxtId.Margin = new System.Windows.Forms.Padding(4);
		this.TxtId.Name = "TxtId";
		this.TxtId.Size = new System.Drawing.Size(125, 22);
		this.TxtId.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(19, 53);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(28, 17);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "ID:";
		this.GroupBox2.Controls.Add(this.BtnReporte);
		this.GroupBox2.Controls.Add(this.Label7);
		this.GroupBox2.Controls.Add(this.Label8);
		this.GroupBox2.Controls.Add(this.Label6);
		this.GroupBox2.Controls.Add(this.Label5);
		this.GroupBox2.Controls.Add(this.BtnEliminar);
		this.GroupBox2.Controls.Add(this.BtnEditar);
		this.GroupBox2.Controls.Add(this.BtnGuardar);
		this.GroupBox2.Controls.Add(this.BtnNuevo);
		this.GroupBox2.Location = new System.Drawing.Point(531, 15);
		this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
		this.GroupBox2.Size = new System.Drawing.Size(315, 201);
		this.GroupBox2.TabIndex = 1;
		this.GroupBox2.TabStop = false;
		this.BtnReporte.BackgroundImage = Sistema_Estiba_PDQ.My.Resources.Resources.IcoImprimir3;
		this.BtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.BtnReporte.Location = new System.Drawing.Point(104, 50);
		this.BtnReporte.Margin = new System.Windows.Forms.Padding(4);
		this.BtnReporte.Name = "BtnReporte";
		this.BtnReporte.Size = new System.Drawing.Size(103, 80);
		this.BtnReporte.TabIndex = 6;
		this.BtnReporte.UseVisualStyleBackColor = true;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.White;
		this.Label7.Location = new System.Drawing.Point(185, 84);
		this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(84, 17);
		this.Label7.TabIndex = 9;
		this.Label7.Text = "GUARDAR";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.White;
		this.Label8.Location = new System.Drawing.Point(60, 84);
		this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(62, 17);
		this.Label8.TabIndex = 8;
		this.Label8.Text = "NUEVO";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.White;
		this.Label6.Location = new System.Drawing.Point(190, 177);
		this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(79, 17);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "ELIMINAR";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(39, 177);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(103, 17);
		this.Label5.TabIndex = 6;
		this.Label5.Text = "ACTUALIZAR";
		this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnEliminar.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Eliminar;
		this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.BtnEliminar.Location = new System.Drawing.Point(173, 107);
		this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
		this.BtnEliminar.Name = "BtnEliminar";
		this.BtnEliminar.Size = new System.Drawing.Size(107, 64);
		this.BtnEliminar.TabIndex = 3;
		this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.BtnEliminar.UseVisualStyleBackColor = true;
		this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnEditar.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Actualizar;
		this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.BtnEditar.Location = new System.Drawing.Point(35, 107);
		this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
		this.BtnEditar.Name = "BtnEditar";
		this.BtnEditar.Size = new System.Drawing.Size(107, 64);
		this.BtnEditar.TabIndex = 2;
		this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.BtnEditar.UseVisualStyleBackColor = true;
		this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnGuardar.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Guardar;
		this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.BtnGuardar.Location = new System.Drawing.Point(173, 16);
		this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
		this.BtnGuardar.Name = "BtnGuardar";
		this.BtnGuardar.Size = new System.Drawing.Size(107, 64);
		this.BtnGuardar.TabIndex = 1;
		this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.BtnGuardar.UseVisualStyleBackColor = true;
		this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnNuevo.ForeColor = System.Drawing.Color.SaddleBrown;
		this.BtnNuevo.Image = Sistema_Estiba_PDQ.My.Resources.Resources.IcoNuevo;
		this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.BtnNuevo.Location = new System.Drawing.Point(35, 16);
		this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
		this.BtnNuevo.Name = "BtnNuevo";
		this.BtnNuevo.Size = new System.Drawing.Size(107, 64);
		this.BtnNuevo.TabIndex = 0;
		this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.BtnNuevo.UseVisualStyleBackColor = true;
		this.GroupBox3.Controls.Add(this.DgvUsuarios);
		this.GroupBox3.Location = new System.Drawing.Point(16, 271);
		this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
		this.GroupBox3.Size = new System.Drawing.Size(829, 353);
		this.GroupBox3.TabIndex = 2;
		this.GroupBox3.TabStop = false;
		this.DgvUsuarios.AllowUserToAddRows = false;
		this.DgvUsuarios.AllowUserToDeleteRows = false;
		this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DgvUsuarios.Columns.AddRange(this.ID, this.USUARIO, this.CLAVE);
		this.DgvUsuarios.Location = new System.Drawing.Point(12, 23);
		this.DgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
		this.DgvUsuarios.Name = "DgvUsuarios";
		this.DgvUsuarios.ReadOnly = true;
		this.DgvUsuarios.RowHeadersWidth = 51;
		this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DgvUsuarios.Size = new System.Drawing.Size(809, 322);
		this.DgvUsuarios.TabIndex = 0;
		this.ID.HeaderText = "ID";
		this.ID.MinimumWidth = 6;
		this.ID.Name = "ID";
		this.ID.ReadOnly = true;
		this.ID.Width = 125;
		this.USUARIO.HeaderText = "Usuario";
		this.USUARIO.MinimumWidth = 6;
		this.USUARIO.Name = "USUARIO";
		this.USUARIO.ReadOnly = true;
		this.USUARIO.Width = 125;
		this.CLAVE.HeaderText = "Clave";
		this.CLAVE.MinimumWidth = 6;
		this.CLAVE.Name = "CLAVE";
		this.CLAVE.ReadOnly = true;
		this.CLAVE.Width = 125;
		this.TxtBuscar.Location = new System.Drawing.Point(140, 239);
		this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
		this.TxtBuscar.Name = "TxtBuscar";
		this.TxtBuscar.Size = new System.Drawing.Size(344, 22);
		this.TxtBuscar.TabIndex = 7;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(35, 247);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(63, 17);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Buscar:";
		this.PictureBox2.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Buscar;
		this.PictureBox2.Location = new System.Drawing.Point(493, 226);
		this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(40, 37);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 9;
		this.PictureBox2.TabStop = false;
		this.PictureBox1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.PDQ_LOGO;
		this.PictureBox1.Location = new System.Drawing.Point(679, 223);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(167, 49);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 8;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		base.ClientSize = new System.Drawing.Size(861, 639);
		base.Controls.Add(this.PictureBox2);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.TxtBuscar);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmUsuarios";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Mantención De Datos De Usuarios";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DgvUsuarios).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FrmUsuarios_Load(object sender, EventArgs e)
	{
		Mostrar();
		TxtUsuario.Enabled = false;
		TxtPassword.Enabled = false;
		BtnGuardar.Enabled = false;
		BtnEditar.Enabled = false;
		BtnEliminar.Enabled = false;
	}

	private void Mostrar()
	{
		ModuleDB.Conectar();
		string vSql = "select * from tbl_usuarios";
		MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
		MySqlDataReader vReader = vCmd.ExecuteReader();
		DgvUsuarios.Rows.Clear();
		while (vReader.Read())
		{
			DgvUsuarios.Rows.Add(vReader.GetString(0), vReader.GetString(1), vReader.GetString(2));
		}
		vReader.Close();
		ModuleDB.Desconectar();
	}

	private void Limpiar()
	{
		TxtId.Clear();
		TxtUsuario.Clear();
		TxtPassword.Clear();
		TxtUsuario.Focus();
	}

	private void Buscar()
	{
		ModuleDB.Conectar();
		string vSql = "select * from tbl_usuarios where usuario like'%" + TxtBuscar.Text + "%'";
		MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
		MySqlDataReader vReader = vCmd.ExecuteReader();
		DgvUsuarios.Rows.Clear();
		while (vReader.Read())
		{
			DgvUsuarios.Rows.Add(vReader.GetString(0), vReader.GetString(1), vReader.GetString(2));
		}
		vReader.Close();
		ModuleDB.Desconectar();
	}

	private void BtnNuevo_Click(object sender, EventArgs e)
	{
		Limpiar();
		TxtUsuario.Enabled = true;
		TxtPassword.Enabled = true;
		BtnGuardar.Enabled = true;
		BtnNuevo.Enabled = false;
		TxtUsuario.Focus();
	}

	private void BtnGuardar_Click(object sender, EventArgs e)
	{
		ModuleDB.Conectar();
		string vErrores = "";
		if (Operators.CompareString(TxtUsuario.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debes Ingresar Un Nombre De Usuario\r\n";
		}
		if (Operators.CompareString(TxtPassword.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debes Ingresar Una Clave O Contraseña\r\n";
		}
		if (Operators.CompareString(vErrores, "", TextCompare: false) != 0)
		{
			Interaction.MsgBox(vErrores, MsgBoxStyle.Information, "Errores");
			return;
		}
		try
		{
			string vSql = "INSERT INTO tbl_usuarios (usuario,clave) VALUES (@usuario,@clave)";
			MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
			vCmd.Parameters.AddWithValue("usuario", TxtUsuario.Text.Trim());
			vCmd.Parameters.AddWithValue("clave", TxtPassword.Text.Trim());
			vCmd.ExecuteNonQuery();
			ModuleDB.Desconectar();
			Limpiar();
			Mostrar();
			TxtUsuario.Enabled = false;
			TxtPassword.Enabled = false;
			BtnGuardar.Enabled = false;
			BtnEditar.Enabled = false;
			BtnEliminar.Enabled = false;
			BtnNuevo.Enabled = true;
		}
		catch (MySqlException ex2)
		{
			ProjectData.SetProjectError(ex2);
			MySqlException ex = ex2;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnEditar_Click(object sender, EventArgs e)
	{
		ModuleDB.Conectar();
		string vErrores = "";
		if (Operators.CompareString(TxtUsuario.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debes Ingresar Un Nombre De Usuario\r\n";
		}
		if (Operators.CompareString(TxtPassword.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debes Ingresar Una Clave O Contraseña\r\n";
		}
		if (Operators.CompareString(vErrores, "", TextCompare: false) != 0)
		{
			Interaction.MsgBox(vErrores, MsgBoxStyle.Information, "Errores");
			return;
		}
		try
		{
			string vSql = "UPDATE tbl_usuarios SET usuario=@usuario,clave=@clave WHERE id=@id";
			MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
			vCmd.Parameters.AddWithValue("id", TxtId.Text.Trim());
			vCmd.Parameters.AddWithValue("usuario", TxtUsuario.Text.Trim());
			vCmd.Parameters.AddWithValue("clave", TxtPassword.Text.Trim());
			vCmd.ExecuteNonQuery();
			ModuleDB.Desconectar();
			Limpiar();
			Mostrar();
			TxtUsuario.Enabled = false;
			TxtPassword.Enabled = false;
			BtnGuardar.Enabled = false;
			BtnEditar.Enabled = false;
			BtnEliminar.Enabled = false;
			BtnNuevo.Enabled = true;
		}
		catch (MySqlException ex2)
		{
			ProjectData.SetProjectError(ex2);
			MySqlException ex = ex2;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error");
			ProjectData.ClearProjectError();
		}
	}

	private void BtnEliminar_Click(object sender, EventArgs e)
	{
		if (DgvUsuarios.CurrentCell == null)
		{
			Interaction.MsgBox("Debes Seleccionar Un Registro Para Eliminar");
			return;
		}
		DialogResult vResultado = (DialogResult)Interaction.MsgBox("¿Estas Seguro Que Deseas Eliminar Este Registro", MsgBoxStyle.YesNo, "Confirmación");
		if (vResultado != DialogResult.Yes)
		{
			return;
		}
		ModuleDB.Conectar();
		try
		{
			DataGridViewCell vCell = DgvUsuarios["id", DgvUsuarios.CurrentCell.RowIndex];
			string vSql = "DELETE FROM tbl_usuarios WHERE id=@id";
			MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
			vCmd.Parameters.AddWithValue("id", RuntimeHelpers.GetObjectValue(vCell.Value));
			vCmd.ExecuteNonQuery();
			ModuleDB.Desconectar();
			Limpiar();
			Mostrar();
			TxtUsuario.Enabled = false;
			TxtPassword.Enabled = false;
			BtnGuardar.Enabled = false;
			BtnEditar.Enabled = false;
			BtnEliminar.Enabled = false;
			BtnNuevo.Enabled = true;
		}
		catch (MySqlException ex2)
		{
			ProjectData.SetProjectError(ex2);
			MySqlException ex = ex2;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error");
			ProjectData.ClearProjectError();
		}
	}

	private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		BtnEditar.Enabled = true;
		BtnEliminar.Enabled = true;
		TxtUsuario.Enabled = true;
		TxtPassword.Enabled = true;
		TxtId.Text = Conversions.ToString(DgvUsuarios.SelectedCells[0].Value);
		TxtUsuario.Text = Conversions.ToString(DgvUsuarios.SelectedCells[1].Value);
		TxtPassword.Text = Conversions.ToString(DgvUsuarios.SelectedCells[2].Value);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		UsuariosDataSet ds = new UsuariosDataSet();
		DataTable dt = new DataTable();
		dt = ds.Tables["Usuarios"];
		checked
		{
			int num = DgvUsuarios.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				dt.Rows.Add(DgvUsuarios.Rows[i].Cells["usuario"].Value, DgvUsuarios.Rows[i].Cells["clave"].Value);
			}
			LocalReport localReport = MyProject.Forms.FrmReporteUsuarios.ReportViewer1.LocalReport;
			localReport.ReportPath = "ReporteUsuarios.rdlc";
			localReport.DataSources.Clear();
			localReport.DataSources.Add(new ReportDataSource("UsuarioDataSet", dt));
			localReport = null;
			MyProject.Forms.FrmReporteUsuarios.Show();
			MyProject.Forms.FrmReporteUsuarios.ReportViewer1.RefreshReport();
		}
	}

	private void TxtBuscar_TextChanged(object sender, EventArgs e)
	{
		Buscar();
	}
}

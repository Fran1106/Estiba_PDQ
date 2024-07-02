using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Sistema_Estiba_PDQ.My;
using Sistema_Estiba_PDQ.My.Resources;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmLogin : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnCerrar")]
	private PictureBox _BtnCerrar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnSalir")]
	private Button _BtnSalir;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnIngresar")]
	private Button _BtnIngresar;

	[field: AccessedThroughProperty("Header")]
	internal virtual Panel Header
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox BtnCerrar
	{
		[CompilerGenerated]
		get
		{
			return _BtnCerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnCerrar_Click;
			PictureBox btnCerrar = _BtnCerrar;
			if (btnCerrar != null)
			{
				btnCerrar.Click -= value2;
			}
			_BtnCerrar = value;
			btnCerrar = _BtnCerrar;
			if (btnCerrar != null)
			{
				btnCerrar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Logo")]
	internal virtual PictureBox Logo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtContraseña")]
	internal virtual TextBox TxtContraseña
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

	internal virtual Button BtnSalir
	{
		[CompilerGenerated]
		get
		{
			return _BtnSalir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnSalir_Click;
			Button btnSalir = _BtnSalir;
			if (btnSalir != null)
			{
				btnSalir.Click -= value2;
			}
			_BtnSalir = value;
			btnSalir = _BtnSalir;
			if (btnSalir != null)
			{
				btnSalir.Click += value2;
			}
		}
	}

	internal virtual Button BtnIngresar
	{
		[CompilerGenerated]
		get
		{
			return _BtnIngresar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnIngresar_Click;
			Button btnIngresar = _BtnIngresar;
			if (btnIngresar != null)
			{
				btnIngresar.Click -= value2;
			}
			_BtnIngresar = value;
			btnIngresar = _BtnIngresar;
			if (btnIngresar != null)
			{
				btnIngresar.Click += value2;
			}
		}
	}

	public FrmLogin()
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmLogin));
		this.Header = new System.Windows.Forms.Panel();
		this.BtnCerrar = new System.Windows.Forms.PictureBox();
		this.Logo = new System.Windows.Forms.PictureBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TxtContraseña = new System.Windows.Forms.TextBox();
		this.TxtUsuario = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.BtnSalir = new System.Windows.Forms.Button();
		this.BtnIngresar = new System.Windows.Forms.Button();
		this.Header.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BtnCerrar).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Logo).BeginInit();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.Header.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Header.Controls.Add(this.BtnCerrar);
		this.Header.Controls.Add(this.Logo);
		this.Header.Dock = System.Windows.Forms.DockStyle.Top;
		this.Header.Location = new System.Drawing.Point(0, 0);
		this.Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Header.Name = "Header";
		this.Header.Size = new System.Drawing.Size(716, 62);
		this.Header.TabIndex = 9;
		this.BtnCerrar.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Cerrar;
		this.BtnCerrar.Location = new System.Drawing.Point(680, 14);
		this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.BtnCerrar.Name = "BtnCerrar";
		this.BtnCerrar.Size = new System.Drawing.Size(29, 30);
		this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.BtnCerrar.TabIndex = 1;
		this.BtnCerrar.TabStop = false;
		this.Logo.Image = Sistema_Estiba_PDQ.My.Resources.Resources.PDQ_LOGO;
		this.Logo.Location = new System.Drawing.Point(12, 6);
		this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Logo.Name = "Logo";
		this.Logo.Size = new System.Drawing.Size(237, 50);
		this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.Logo.TabIndex = 0;
		this.Logo.TabStop = false;
		this.GroupBox1.Controls.Add(this.TxtContraseña);
		this.GroupBox1.Controls.Add(this.TxtUsuario);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 89);
		this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.GroupBox1.Size = new System.Drawing.Size(684, 222);
		this.GroupBox1.TabIndex = 10;
		this.GroupBox1.TabStop = false;
		this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.TxtContraseña.Location = new System.Drawing.Point(309, 126);
		this.TxtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.TxtContraseña.Name = "TxtContraseña";
		this.TxtContraseña.PasswordChar = '*';
		this.TxtContraseña.Size = new System.Drawing.Size(297, 28);
		this.TxtContraseña.TabIndex = 4;
		this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.TxtUsuario.Location = new System.Drawing.Point(309, 64);
		this.TxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.TxtUsuario.Name = "TxtUsuario";
		this.TxtUsuario.Size = new System.Drawing.Size(297, 28);
		this.TxtUsuario.TabIndex = 3;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(65, 126);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(119, 22);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Contraseña:";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(65, 64);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(85, 22);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Usuario:";
		this.GroupBox2.Controls.Add(this.BtnSalir);
		this.GroupBox2.Controls.Add(this.BtnIngresar);
		this.GroupBox2.Location = new System.Drawing.Point(12, 316);
		this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.GroupBox2.Size = new System.Drawing.Size(684, 90);
		this.GroupBox2.TabIndex = 11;
		this.GroupBox2.TabStop = false;
		this.BtnSalir.BackColor = System.Drawing.Color.Red;
		this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnSalir.ForeColor = System.Drawing.Color.White;
		this.BtnSalir.Location = new System.Drawing.Point(523, 21);
		this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.BtnSalir.Name = "BtnSalir";
		this.BtnSalir.Size = new System.Drawing.Size(155, 50);
		this.BtnSalir.TabIndex = 1;
		this.BtnSalir.Text = "Salir";
		this.BtnSalir.UseVisualStyleBackColor = false;
		this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
		this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnIngresar.ForeColor = System.Drawing.Color.White;
		this.BtnIngresar.Location = new System.Drawing.Point(347, 21);
		this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.BtnIngresar.Name = "BtnIngresar";
		this.BtnIngresar.Size = new System.Drawing.Size(155, 50);
		this.BtnIngresar.TabIndex = 0;
		this.BtnIngresar.Text = "Ingresar";
		this.BtnIngresar.UseVisualStyleBackColor = false;
		base.AcceptButton = this.BtnIngresar;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.BtnSalir;
		base.ClientSize = new System.Drawing.Size(716, 410);
		base.Controls.Add(this.Header);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.GroupBox2);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmLogin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "FrmLogin";
		this.Header.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.BtnCerrar).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Logo).EndInit();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void BtnIngresar_Click(object sender, EventArgs e)
	{
		ModuleDB.Conectar();
		string vErrores = "";
		if (Operators.CompareString(TxtUsuario.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debes Ingresar Un Nombre De Usuario Valido\r\n";
		}
		if (Operators.CompareString(TxtContraseña.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debes Ingresar Una Contraseña Valida\r\n";
		}
		if (Operators.CompareString(vErrores, "", TextCompare: false) != 0)
		{
			Interaction.MsgBox(vErrores, MsgBoxStyle.Information, "Errores");
			return;
		}
		try
		{
			string sql = "SELECT * FROM tbl_usuarios WHERE usuario = '" + TxtUsuario.Text + "' AND clave = '" + TxtContraseña.Text + "'";
			MySqlCommand cmd = new MySqlCommand(sql, ModuleDB.vConn);
			MySqlDataReader dr = cmd.ExecuteReader();
			if (!dr.Read())
			{
				Interaction.MsgBox("No Se Pudo Iniciar Sesión!", MsgBoxStyle.Critical, "Login Inválido");
				TxtUsuario.Text = "";
				TxtContraseña.Text = "";
			}
			else
			{
				Interaction.MsgBox(TxtUsuario.Text + " Bienvenido Al Sistema Estiba ", MsgBoxStyle.Information, "Login");
				EnviarDatos.login = TxtUsuario.Text;
				MyProject.Forms.FrmPrincipal.Show();
				Hide();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex = ex2;
			ProjectData.ClearProjectError();
		}
		ModuleDB.Desconectar();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void BtnSalir_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}
}

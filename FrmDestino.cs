using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Sistema_Estiba_PDQ.My;
using Sistema_Estiba_PDQ.My.Resources;
using ZXing;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmDestino : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnGuardar")]
	private Button _BtnGuardar;

	private Correlativo obj;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("TxtRampla")]
	internal virtual ComboBox TxtRampla
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

	[field: AccessedThroughProperty("TxtID")]
	internal virtual TextBox TxtID
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

	[field: AccessedThroughProperty("TxtFecha")]
	internal virtual TextBox TxtFecha
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TxtFolio")]
	internal virtual TextBox TxtFolio
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

	[field: AccessedThroughProperty("ErrorProvider1")]
	internal virtual ErrorProvider ErrorProvider1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmDestino()
	{
		base.Load += FrmDestino_Load;

        this.TxtRampla = new System.Windows.Forms.ComboBox();
        Ramplas();

        obj = new Correlativo();
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
        this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmDestino));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TxtID = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.TxtFecha = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.TxtUsuario = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.TxtDestino = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.BtnGuardar = new System.Windows.Forms.Button();
		this.TxtFolio = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ErrorProvider1).BeginInit();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.TxtID);
		this.GroupBox1.Controls.Add(this.Label3);
		this.GroupBox1.Controls.Add(this.TxtFecha);
		this.GroupBox1.Controls.Add(this.Label6);
		this.GroupBox1.Controls.Add(this.TxtUsuario);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.TxtRampla);
		this.GroupBox1.Controls.Add(this.Label8);
		this.GroupBox1.Controls.Add(this.Label7);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.TxtDestino);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Location = new System.Drawing.Point(16, 74);
		this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.GroupBox1.Size = new System.Drawing.Size(525, 268);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.TxtID.Enabled = false;
		this.TxtID.Location = new System.Drawing.Point(209, 23);
		this.TxtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.TxtID.Name = "TxtID";
		this.TxtID.Size = new System.Drawing.Size(119, 22);
		this.TxtID.TabIndex = 19;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(73, 32);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(28, 17);
		this.Label3.TabIndex = 20;
		this.Label3.Text = "ID:";
		this.TxtFecha.Enabled = false;
		this.TxtFecha.Location = new System.Drawing.Point(209, 218);
		this.TxtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.TxtFecha.Name = "TxtFecha";
		this.TxtFecha.Size = new System.Drawing.Size(119, 22);
		this.TxtFecha.TabIndex = 17;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.White;
		this.Label6.Location = new System.Drawing.Point(73, 226);
		this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(57, 17);
		this.Label6.TabIndex = 18;
		this.Label6.Text = "Fecha:";
		this.TxtUsuario.Enabled = false;
		this.TxtUsuario.Location = new System.Drawing.Point(209, 71);
		this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.TxtUsuario.Name = "TxtUsuario";
		this.TxtUsuario.Size = new System.Drawing.Size(273, 22);
		this.TxtUsuario.TabIndex = 15;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(73, 80);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(69, 17);
		this.Label4.TabIndex = 16;
		this.Label4.Text = "Usuario:";
		this.TxtRampla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.TxtRampla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.TxtRampla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.TxtRampla.FormattingEnabled = true;
        this.TxtRampla.Location = new System.Drawing.Point(209, 169);
		this.TxtRampla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.TxtRampla.Name = "TxtRampla";
		this.TxtRampla.Size = new System.Drawing.Size(139, 24);
		this.TxtRampla.TabIndex = 12;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.Red;
		this.Label8.Location = new System.Drawing.Point(39, 178);
		this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(26, 17);
		this.Label8.TabIndex = 13;
		this.Label8.Text = "(*)";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.White;
		this.Label7.Location = new System.Drawing.Point(73, 178);
		this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(115, 17);
		this.Label7.TabIndex = 14;
		this.Label7.Text = "N° De Rampla:";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.Red;
		this.Label2.Location = new System.Drawing.Point(39, 129);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(26, 17);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "(*)";
		this.TxtDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.TxtDestino.FormattingEnabled = true;
		this.TxtDestino.Items.AddRange(new object[20]
		{
			"ARICA", "IQUIQUE", "CALAMA", "ANTOFAGASTA", "COPIAPO", "VALLENAR", "COQUIMBO", "VALPARAISO", "LAMPA", "RANCAGUA",
			"TALCA", "CURICO", "CHILLAN", "CONCEPCION", "LOS ANGELES", "TEMUCO", "OSORNO", "PUERTO MONTT", "COYHAIQUE", "PUNTA ARENAS"
		});
		this.TxtDestino.Location = new System.Drawing.Point(209, 119);
		this.TxtDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.TxtDestino.Name = "TxtDestino";
		this.TxtDestino.Size = new System.Drawing.Size(273, 24);
		this.TxtDestino.TabIndex = 4;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(73, 129);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(68, 17);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Destino:";
		this.PictureBox1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.PDQ_LOGO;
		this.PictureBox1.Location = new System.Drawing.Point(169, 5);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(220, 62);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 1;
		this.PictureBox1.TabStop = false;
		this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
		this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnGuardar.ForeColor = System.Drawing.Color.White;
		this.BtnGuardar.Location = new System.Drawing.Point(113, 362);
		this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.BtnGuardar.Name = "BtnGuardar";
		this.BtnGuardar.Size = new System.Drawing.Size(344, 55);
		this.BtnGuardar.TabIndex = 2;
		this.BtnGuardar.Text = "Crear Planilla Estiba";
		this.BtnGuardar.UseVisualStyleBackColor = false;
		this.TxtFolio.Enabled = false;
		this.TxtFolio.Location = new System.Drawing.Point(225, 502);
		this.TxtFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.TxtFolio.Name = "TxtFolio";
		this.TxtFolio.Size = new System.Drawing.Size(119, 22);
		this.TxtFolio.TabIndex = 21;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(89, 511);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(48, 17);
		this.Label5.TabIndex = 22;
		this.Label5.Text = "Folio:";
		this.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
		this.ErrorProvider1.ContainerControl = this;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		base.ClientSize = new System.Drawing.Size(557, 434);
		base.Controls.Add(this.TxtFolio);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.BtnGuardar);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmDestino";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ErrorProvider1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FrmDestino_Load(object sender, EventArgs e)
	{
		ModuleDB.Conectar();
        obtener_fecha();
		obtener_nombre();
		TxtDestino.Text = "";
		TxtRampla.Text = "";
	}

	private void limpiar()
	{
		TxtID.Clear();
		TxtFolio.Clear();
		TxtDestino.Text = "";
		TxtRampla.Text = "";
	}

	private void obtener_folio()
	{
		TxtFolio.Text = Conversions.ToString(obj.generarCodigo());
	}

	private void obtener_fecha()
	{
		TxtFecha.Text = DateTime.Now.ToShortDateString();
	}

	private void obtener_nombre()
	{
		TxtUsuario.Text = EnviarDatos.login;
	}

	private void Enviar_Datos()
	{
		EnviarDatos.usuario = TxtUsuario.Text;
		EnviarDatos.destino = TxtDestino.Text;
		EnviarDatos.rampla = TxtRampla.Text;
		EnviarDatos.fecha = TxtFecha.Text;
		EnviarDatos.folio = TxtFolio.Text;
	}

	private void guardar_datos()
	{
		string vErrores = "";
		if (Operators.CompareString(TxtDestino.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debe Seleccionar Un Destino Valido\r\n";
		}
		if (Operators.CompareString(TxtRampla.Text.Trim(), "", TextCompare: false) == 0)
		{
			vErrores += "Debe Seleccionar Una Rampla Valida\r\n";
		}
		if (Operators.CompareString(vErrores, "", TextCompare: false) != 0)
		{
			Interaction.MsgBox(vErrores, MsgBoxStyle.Information, "Errores");
			return;
		}
		try
		{
			string vSql = "INSERT INTO tbl_datos (folio,usuario,destino,rampla,fecha,date_time) VALUES (@folio,@usuario,@destino,@rampla,@fecha,current_timestamp())";
			MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
			vCmd.Parameters.AddWithValue("folio", TxtFolio.Text.Trim());
			vCmd.Parameters.AddWithValue("usuario", TxtUsuario.Text.Trim());
			vCmd.Parameters.AddWithValue("destino", TxtDestino.Text);
			vCmd.Parameters.AddWithValue("rampla", TxtRampla.Text);
			vCmd.Parameters.AddWithValue("fecha", TxtFecha.Text.Trim());
            vCmd.ExecuteNonQuery();
			ModuleDB.Desconectar();
			Enviar_Datos();
			MyProject.Forms.FrmIngresarOT.ShowDialog();
			Dispose();
			Close();
		}
		catch (MySqlException ex2)
		{
			ProjectData.SetProjectError(ex2);
			MySqlException ex = ex2;
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error");
			ProjectData.ClearProjectError();
		}
	}

    private void Ramplas()
    {
        try
        {
            ModuleDB.Conectar();
            string vSql = "select * from tbl_rampla order by rampla desc";
            MySqlCommand vCmd = new MySqlCommand(vSql, ModuleDB.vConn);
            MySqlDataReader vReader = vCmd.ExecuteReader();

            while (vReader.Read())
            {
                this.TxtRampla.Items.Add(vReader.GetString(0));
            }
            vReader.Close();
            ModuleDB.Desconectar();
        }
        catch (MySqlException ex2)
        {
            ProjectData.SetProjectError(ex2);
            MySqlException ex = ex2;
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Error");
            ProjectData.ClearProjectError();
        }
    }

	private void BtnGuardar_Click(object sender, EventArgs e)
	{
		obtener_folio();
		guardar_datos();
	}
}

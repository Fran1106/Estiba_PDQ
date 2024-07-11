using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Sistema_Estiba_PDQ.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmPrincipal : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IngresarOTToolStripMenuItem")]
	private ToolStripMenuItem _IngresarOTToolStripMenuItem;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("ContinuarOTToolStripMenuItem")]
    private ToolStripMenuItem _ContinuarOTToolStripMenuItem;

    [CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UsuariosToolStripMenuItem")]
	private ToolStripMenuItem _UsuariosToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AcercaDeToolStripMenuItem")]
	private ToolStripMenuItem _AcercaDeToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ManualToolStripMenuItem")]
	private ToolStripMenuItem _ManualToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UsuariosToolStripMenuItem1")]
	private ToolStripMenuItem _UsuariosToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OTToolStripMenuItem")]
	private ToolStripMenuItem _OTToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RespaldoToolStripMenuItem")]
	private ToolStripMenuItem _RespaldoToolStripMenuItem;

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem IngresarOTToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _IngresarOTToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IngresarOTToolStripMenuItem_Click;
			ToolStripMenuItem ingresarOTToolStripMenuItem = _IngresarOTToolStripMenuItem;
			if (ingresarOTToolStripMenuItem != null)
			{
				ingresarOTToolStripMenuItem.Click -= value2;
			}
			_IngresarOTToolStripMenuItem = value;
			ingresarOTToolStripMenuItem = _IngresarOTToolStripMenuItem;
			if (ingresarOTToolStripMenuItem != null)
			{
				ingresarOTToolStripMenuItem.Click += value2;
			}
		}
	}
    internal virtual ToolStripMenuItem ContinuarOTToolStripMenuItem
    {
        [CompilerGenerated]
        get
        {
            return _ContinuarOTToolStripMenuItem;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        [CompilerGenerated]
        set
        {
            EventHandler value2 = ContinuarOTToolStripMenuItem_Click;
            ToolStripMenuItem continuarOTToolStripMenuItem = _ContinuarOTToolStripMenuItem;
            if (continuarOTToolStripMenuItem != null)
            {
                continuarOTToolStripMenuItem.Click -= value2;
            }
            _ContinuarOTToolStripMenuItem = value;
            continuarOTToolStripMenuItem = _ContinuarOTToolStripMenuItem;
            if (continuarOTToolStripMenuItem != null)
            {
                continuarOTToolStripMenuItem.Click += value2;
            }
        }
    }

    [field: AccessedThroughProperty("ConfiguraciónToolStripMenuItem")]
	internal virtual ToolStripMenuItem ConfiguraciónToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}


    [field: AccessedThroughProperty("ConfiguraciónToolStripMenuItem2")]
    internal virtual ToolStripMenuItem ConfiguraciónToolStripMenuItem2
    {
        get; [MethodImpl(MethodImplOptions.Synchronized)]
        set;
    }

    [field: AccessedThroughProperty("ReportesToolStripMenuItem")]
	internal virtual ToolStripMenuItem ReportesToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem UsuariosToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _UsuariosToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UsuariosToolStripMenuItem_Click;
			ToolStripMenuItem usuariosToolStripMenuItem = _UsuariosToolStripMenuItem;
			if (usuariosToolStripMenuItem != null)
			{
				usuariosToolStripMenuItem.Click -= value2;
			}
			_UsuariosToolStripMenuItem = value;
			usuariosToolStripMenuItem = _UsuariosToolStripMenuItem;
			if (usuariosToolStripMenuItem != null)
			{
				usuariosToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("AyudaToolStripMenuItem")]
	internal virtual ToolStripMenuItem AyudaToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AcercaDeToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AcercaDeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AcercaDeToolStripMenuItem_Click;
			ToolStripMenuItem acercaDeToolStripMenuItem = _AcercaDeToolStripMenuItem;
			if (acercaDeToolStripMenuItem != null)
			{
				acercaDeToolStripMenuItem.Click -= value2;
			}
			_AcercaDeToolStripMenuItem = value;
			acercaDeToolStripMenuItem = _AcercaDeToolStripMenuItem;
			if (acercaDeToolStripMenuItem != null)
			{
				acercaDeToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ManualToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ManualToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ManualToolStripMenuItem_Click;
			ToolStripMenuItem manualToolStripMenuItem = _ManualToolStripMenuItem;
			if (manualToolStripMenuItem != null)
			{
				manualToolStripMenuItem.Click -= value2;
			}
			_ManualToolStripMenuItem = value;
			manualToolStripMenuItem = _ManualToolStripMenuItem;
			if (manualToolStripMenuItem != null)
			{
				manualToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem UsuariosToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _UsuariosToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UsuariosToolStripMenuItem1_Click;
			ToolStripMenuItem usuariosToolStripMenuItem = _UsuariosToolStripMenuItem1;
			if (usuariosToolStripMenuItem != null)
			{
				usuariosToolStripMenuItem.Click -= value2;
			}
			_UsuariosToolStripMenuItem1 = value;
			usuariosToolStripMenuItem = _UsuariosToolStripMenuItem1;
			if (usuariosToolStripMenuItem != null)
			{
				usuariosToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem OTToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OTToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OTToolStripMenuItem_Click;
			ToolStripMenuItem oTToolStripMenuItem = _OTToolStripMenuItem;
			if (oTToolStripMenuItem != null)
			{
				oTToolStripMenuItem.Click -= value2;
			}
			_OTToolStripMenuItem = value;
			oTToolStripMenuItem = _OTToolStripMenuItem;
			if (oTToolStripMenuItem != null)
			{
				oTToolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator3")]
	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem RespaldoToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RespaldoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RespaldoToolStripMenuItem_Click;
			ToolStripMenuItem respaldoToolStripMenuItem = _RespaldoToolStripMenuItem;
			if (respaldoToolStripMenuItem != null)
			{
				respaldoToolStripMenuItem.Click -= value2;
			}
			_RespaldoToolStripMenuItem = value;
			respaldoToolStripMenuItem = _RespaldoToolStripMenuItem;
			if (respaldoToolStripMenuItem != null)
			{
				respaldoToolStripMenuItem.Click += value2;
			}
		}
	}

	public FrmPrincipal()
	{
		base.Closing += FrmPrincipal_Closing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmPrincipal));
		this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
		this.IngresarOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ContinuarOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ConfiguraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.OTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.RespaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.MenuStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] {this.IngresarOTToolStripMenuItem, this.ContinuarOTToolStripMenuItem, this.ConfiguraciónToolStripMenuItem, this.AyudaToolStripMenuItem });
		this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
		this.MenuStrip1.Name = "MenuStrip1";
		this.MenuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
		this.MenuStrip1.Size = new System.Drawing.Size(843, 28);
		this.MenuStrip1.TabIndex = 0;
		this.MenuStrip1.Text = "MenuStrip1";

		this.IngresarOTToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Ingresar;
		this.IngresarOTToolStripMenuItem.Name = "IngresarOTToolStripMenuItem";
		this.IngresarOTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
		this.IngresarOTToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
		this.IngresarOTToolStripMenuItem.Text = "Ingresar OT";

        this.ContinuarOTToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Ingresar;
        this.ContinuarOTToolStripMenuItem.Name = "ContinuarOTToolStripMenuItem";
        this.ContinuarOTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
        this.ContinuarOTToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
        this.ContinuarOTToolStripMenuItem.Text = "Continuar OT";

        this.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.ReportesToolStripMenuItem, this.ToolStripSeparator1, this.UsuariosToolStripMenuItem, this.ToolStripSeparator3, this.RespaldoToolStripMenuItem });
		this.ConfiguraciónToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Config;
		this.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem";
		this.ConfiguraciónToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
		this.ConfiguraciónToolStripMenuItem.Text = "Configuración";

		this.ReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.UsuariosToolStripMenuItem1, this.ToolStripSeparator2, this.OTToolStripMenuItem });
		this.ReportesToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Informe;
		this.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem";
		this.ReportesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
		this.ReportesToolStripMenuItem.Text = "Reportes";
		this.UsuariosToolStripMenuItem1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Informe_Usuarios;
		this.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1";
		this.UsuariosToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F4;
		this.UsuariosToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
		this.UsuariosToolStripMenuItem1.Text = "Usuarios";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(181, 6);
		this.OTToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Informe_OT;
		this.OTToolStripMenuItem.Name = "OTToolStripMenuItem";
		this.OTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
		this.OTToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
		this.OTToolStripMenuItem.Text = "OT";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(181, 6);
		this.UsuariosToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Usuarios;
		this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
		this.UsuariosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
		this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
		this.UsuariosToolStripMenuItem.Text = "Usuarios";
		this.ToolStripSeparator3.Name = "ToolStripSeparator3";
		this.ToolStripSeparator3.Size = new System.Drawing.Size(181, 6);
		this.RespaldoToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.IcoRespaldo;
		this.RespaldoToolStripMenuItem.Name = "RespaldoToolStripMenuItem";
		this.RespaldoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
		this.RespaldoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
		this.RespaldoToolStripMenuItem.Text = "Respaldo";
		this.AyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.AcercaDeToolStripMenuItem, this.ManualToolStripMenuItem });
		this.AyudaToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Ayuda;
		this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
		this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
		this.AyudaToolStripMenuItem.Text = "Ayuda";
		this.AcercaDeToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_AcercaDe;
		this.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem";
		this.AcercaDeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
		this.AcercaDeToolStripMenuItem.Text = "Acerca De";
		this.ManualToolStripMenuItem.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Manual;
		this.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem";
		this.ManualToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
		this.ManualToolStripMenuItem.Text = "Manual";
		this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.PictureBox1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.PDQ_LOGO;
		this.PictureBox1.Location = new System.Drawing.Point(184, 163);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(466, 208);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 1;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		base.ClientSize = new System.Drawing.Size(843, 552);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.MenuStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = this.MenuStrip1;
		base.Name = "FrmPrincipal";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Sistema Estiba PDQ";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.MenuStrip1.ResumeLayout(false);
		this.MenuStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string a = Interaction.InputBox("Ingrese La Contraseña", "Sistema PDQ");
		if (Operators.CompareString(a, "Ctradersoporte*", TextCompare: false) == 0)
		{
			MyProject.Forms.FrmUsuarios.BtnEditar.Visible = true;
			MyProject.Forms.FrmUsuarios.BtnNuevo.Visible = true;
			MyProject.Forms.FrmUsuarios.BtnGuardar.Visible = true;
			MyProject.Forms.FrmUsuarios.BtnEliminar.Visible = true;
			MyProject.Forms.FrmUsuarios.BtnReporte.Visible = false;
			MyProject.Forms.FrmUsuarios.TxtId.Visible = true;
			MyProject.Forms.FrmUsuarios.TxtUsuario.Visible = true;
			MyProject.Forms.FrmUsuarios.TxtPassword.Visible = true;
			MyProject.Forms.FrmUsuarios.Label1.Visible = true;
			MyProject.Forms.FrmUsuarios.Label2.Visible = true;
			MyProject.Forms.FrmUsuarios.Label3.Visible = true;
			MyProject.Forms.FrmUsuarios.Label4.Visible = true;
			MyProject.Forms.FrmUsuarios.Label5.Visible = true;
			MyProject.Forms.FrmUsuarios.Label6.Visible = true;
			MyProject.Forms.FrmUsuarios.Label7.Visible = true;
			MyProject.Forms.FrmUsuarios.Label8.Visible = true;
			MyProject.Forms.FrmUsuarios.ShowDialog();
		}
		else
		{
			Interaction.MsgBox("Contraseña Incorrecta Intente Nuevamente!");
		}
	}

	private void IngresarOTToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmDestino.TxtDestino.Text = "";
		MyProject.Forms.FrmDestino.TxtRampla.Text = "";
		MyProject.Forms.FrmDestino.ShowDialog();
	}

    private void ContinuarOTToolStripMenuItem_Click(object sender, EventArgs e)
    {   
        MyProject.Forms.FrmContinuarOT.ShowDialog();
    }

    private void OTToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmRegistrosOT.ShowDialog();
	}

	private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmAcercaDe.ShowDialog();
	}

	private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.FrmUsuarios.BtnEditar.Visible = false;
		MyProject.Forms.FrmUsuarios.BtnNuevo.Visible = false;
		MyProject.Forms.FrmUsuarios.BtnGuardar.Visible = false;
		MyProject.Forms.FrmUsuarios.BtnEliminar.Visible = false;
		MyProject.Forms.FrmUsuarios.BtnReporte.Visible = true;
		MyProject.Forms.FrmUsuarios.TxtId.Visible = false;
		MyProject.Forms.FrmUsuarios.TxtUsuario.Visible = false;
		MyProject.Forms.FrmUsuarios.TxtPassword.Visible = false;
		MyProject.Forms.FrmUsuarios.Label1.Visible = false;
		MyProject.Forms.FrmUsuarios.Label2.Visible = false;
		MyProject.Forms.FrmUsuarios.Label3.Visible = false;
		MyProject.Forms.FrmUsuarios.Label4.Visible = false;
		MyProject.Forms.FrmUsuarios.Label5.Visible = false;
		MyProject.Forms.FrmUsuarios.Label6.Visible = false;
		MyProject.Forms.FrmUsuarios.Label7.Visible = false;
		MyProject.Forms.FrmUsuarios.Label8.Visible = false;
		MyProject.Forms.FrmUsuarios.ShowDialog();
	}

	private void FrmPrincipal_Closing(object sender, CancelEventArgs e)
	{
		Application.Exit();
	}

	private void RespaldoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string a = Interaction.InputBox("Ingrese La Contraseña", "Sistema PDQ");
		if (Operators.CompareString(a, "Ctradersoporte*", TextCompare: false) == 0)
		{
			MyProject.Forms.FrmRespaldo.ShowDialog();
		}
		else
		{
			Interaction.MsgBox("Contraseña Incorrecta Intente Nuevamente!");
		}
	}

	private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ProcessStartInfo loPSI = new ProcessStartInfo();
		Process loProceso = new Process();
		loPSI.FileName = Application.StartupPath + "\\Manual.pdf";
		try
		{
			loProceso = Process.Start(loPSI);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception Exp = ex;
			ProjectData.ClearProjectError();
		}
	}
}

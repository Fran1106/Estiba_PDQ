using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sistema_Estiba_PDQ.My.Resources;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmRespaldo : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnRespaldar")]
	private Button _BtnRespaldar;

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	internal virtual Button BtnRespaldar
	{
		[CompilerGenerated]
		get
		{
			return _BtnRespaldar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnRespaldar_Click;
			Button btnRespaldar = _BtnRespaldar;
			if (btnRespaldar != null)
			{
				btnRespaldar.Click -= value2;
			}
			_BtnRespaldar = value;
			btnRespaldar = _BtnRespaldar;
			if (btnRespaldar != null)
			{
				btnRespaldar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SaveFileDialog1")]
	internal virtual SaveFileDialog SaveFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtRespaldar")]
	internal virtual ComboBox TxtRespaldar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmRespaldo()
	{
		base.Load += FrmRespaldo_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmRespaldo));
		this.Label2 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TxtRespaldar = new System.Windows.Forms.ComboBox();
		this.BtnRespaldar = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(10, 87);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(319, 29);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Backup De Base De Datos\r\n";
		this.Panel1.BackColor = System.Drawing.Color.LightBlue;
		this.Panel1.Controls.Add(this.PictureBox1);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Margin = new System.Windows.Forms.Padding(4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(586, 133);
		this.Panel1.TabIndex = 35;
		this.PictureBox1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.PDQ_LOGO;
		this.PictureBox1.Location = new System.Drawing.Point(363, 0);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(207, 73);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 4;
		this.PictureBox1.TabStop = false;
		this.GroupBox1.Controls.Add(this.TxtRespaldar);
		this.GroupBox1.Controls.Add(this.BtnRespaldar);
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.GroupBox1.ForeColor = System.Drawing.Color.White;
		this.GroupBox1.Location = new System.Drawing.Point(22, 143);
		this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
		this.GroupBox1.Size = new System.Drawing.Size(548, 172);
		this.GroupBox1.TabIndex = 49;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "RESPALDAR";
		this.TxtRespaldar.Enabled = false;
		this.TxtRespaldar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.TxtRespaldar.FormattingEnabled = true;
		this.TxtRespaldar.Location = new System.Drawing.Point(199, 46);
		this.TxtRespaldar.Margin = new System.Windows.Forms.Padding(4);
		this.TxtRespaldar.Name = "TxtRespaldar";
		this.TxtRespaldar.Size = new System.Drawing.Size(291, 30);
		this.TxtRespaldar.TabIndex = 50;
		this.TxtRespaldar.Text = "dbestiba";
		this.BtnRespaldar.ForeColor = System.Drawing.Color.Black;
		this.BtnRespaldar.Location = new System.Drawing.Point(311, 97);
		this.BtnRespaldar.Margin = new System.Windows.Forms.Padding(4);
		this.BtnRespaldar.Name = "BtnRespaldar";
		this.BtnRespaldar.Size = new System.Drawing.Size(180, 59);
		this.BtnRespaldar.TabIndex = 49;
		this.BtnRespaldar.Text = "Respaldar";
		this.BtnRespaldar.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(41, 50);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(137, 25);
		this.Label5.TabIndex = 48;
		this.Label5.Text = "Base de datos";
		this.SaveFileDialog1.Filter = "Backup files (*.Back)|*.bak";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		base.ClientSize = new System.Drawing.Size(586, 334);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Panel1);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmRespaldo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Respaldo De Base De Datos";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void FrmRespaldo_Load(object sender, EventArgs e)
	{
	}

	private void BtnRespaldar_Click(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists("c:\\Backup"))
			{
				Directory.CreateDirectory("c:\\Backup");
			}
			string NombreBaseDatos = TxtRespaldar.Text + "[" + Strings.Format(DateAndTime.Now.ToString("ddMMyyyy")) + "][" + Strings.Format(DateAndTime.Now.ToString("HHmmss")) + "].sql";
			string cadena = "cmd.exe /C C:\\laragon\\bin\\mysql\\mysql-8.0.30-winx64\\bin\\mysqldump.exe -h localhost -u root" + TxtRespaldar.Text + " -R>c:\\Backup\\" + NombreBaseDatos;
			Interaction.Shell(cadena);
			MessageBox.Show("Respaldo Exitoso!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex = ex2;
			MessageBox.Show(Information.Err().Description);
			ProjectData.ClearProjectError();
		}
	}
}

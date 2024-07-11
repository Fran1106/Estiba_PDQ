using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Sistema_Estiba_PDQ.My.Resources;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmAcercaDe : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnSalir")]
	private Button _BtnSalir;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmAcercaDe()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmAcercaDe));
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.BtnSalir = new System.Windows.Forms.Button();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.PictureBox1);
		this.GroupBox1.Controls.Add(this.BtnSalir);
		this.GroupBox1.Location = new System.Drawing.Point(16, 7);
		this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.GroupBox1.Size = new System.Drawing.Size(549, 326);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(63, 229);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(418, 72);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "Diseñado Y Programado Por El Departamento De Informatica \r\nPDQ LAMPA.\r\n\r\n\r\n";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(63, 210);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(203, 18);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Sistema Estiba PDQ 2023\r\n";
		this.PictureBox1.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Nuevo;
		this.PictureBox1.Location = new System.Drawing.Point(67, 23);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(405, 150);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 1;
		this.PictureBox1.TabStop = false;
		this.BtnSalir.BackColor = System.Drawing.Color.Red;
		this.BtnSalir.Image = Sistema_Estiba_PDQ.My.Resources.Resources.Ico_Cerrar;
		this.BtnSalir.Location = new System.Drawing.Point(503, 12);
		this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.BtnSalir.Name = "BtnSalir";
		this.BtnSalir.Size = new System.Drawing.Size(40, 37);
		this.BtnSalir.TabIndex = 0;
		this.BtnSalir.UseVisualStyleBackColor = false;
		this.Panel1.BackColor = System.Drawing.Color.White;
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(8, 348);
		this.Panel1.TabIndex = 4;
		this.Panel2.BackColor = System.Drawing.Color.White;
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel2.Location = new System.Drawing.Point(573, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(8, 348);
		this.Panel2.TabIndex = 5;
		this.Panel3.BackColor = System.Drawing.Color.White;
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel3.Location = new System.Drawing.Point(8, 340);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(565, 8);
		this.Panel3.TabIndex = 4;
		this.Panel4.BackColor = System.Drawing.Color.White;
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(8, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(565, 8);
		this.Panel4.TabIndex = 4;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		base.ClientSize = new System.Drawing.Size(581, 348);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		base.Name = "FrmAcercaDe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void BtnSalir_Click(object sender, EventArgs e)
	{
		Close();
	}
}

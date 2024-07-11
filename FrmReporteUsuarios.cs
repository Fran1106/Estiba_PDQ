using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmReporteUsuarios : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("ReportViewer1")]
	internal virtual ReportViewer ReportViewer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmReporteUsuarios()
	{
		base.Load += FrmReporteUsuarios_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Estiba_PDQ.FrmReporteUsuarios));
		this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
		base.SuspendLayout();
		this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Estiba_PDQ.ReporteUsuarios.rdlc";
		this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
		this.ReportViewer1.Name = "ReportViewer1";
		this.ReportViewer1.ServerReport.BearerToken = null;
		this.ReportViewer1.Size = new System.Drawing.Size(800, 525);
		this.ReportViewer1.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 525);
		base.Controls.Add(this.ReportViewer1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FrmReporteUsuarios";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Informe De Usuarios";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		base.ResumeLayout(false);
	}

	private void FrmReporteUsuarios_Load(object sender, EventArgs e)
	{
		ReportViewer1.RefreshReport();
	}
}

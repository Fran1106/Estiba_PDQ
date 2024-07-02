using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Sistema_Estiba_PDQ.My;

namespace Sistema_Estiba_PDQ;

[DesignerGenerated]
public class FrmReporteOT : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("ReportViewer1")]
	internal virtual ReportViewer ReportViewer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FrmReporteOT()
	{
		base.Load += FrmReporteOT_Load;
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
		this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
		base.SuspendLayout();
		this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
		this.ReportViewer1.Name = "ReportViewer1";
		this.ReportViewer1.ServerReport.BearerToken = null;
		this.ReportViewer1.Size = new System.Drawing.Size(1005, 693);
		this.ReportViewer1.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1005, 693);
		base.Controls.Add(this.ReportViewer1);
		base.Name = "FrmReporteOT";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Informe De Ordenes De Trabajo Registradas";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		base.ResumeLayout(false);
	}

	private void FrmReporteOT_Load(object sender, EventArgs e)
	{
		ReportParameter par1 = new ReportParameter("Usuario", MyProject.Forms.FrmIngresarOT.TxtUsuario.Text);
		ReportParameter[] listaPar1 = new ReportParameter[1] { par1 };
		ReportParameter par2 = new ReportParameter("Fecha", MyProject.Forms.FrmIngresarOT.TxtFecha.Text);
		ReportParameter[] listaPar2 = new ReportParameter[1] { par2 };
		ReportParameter par3 = new ReportParameter("Sucursal", MyProject.Forms.FrmIngresarOT.TxtDestino.Text);
		ReportParameter[] listaPar3 = new ReportParameter[1] { par3 };
		ReportParameter par4 = new ReportParameter("Rampla", MyProject.Forms.FrmIngresarOT.TxtRampla.Text);
		ReportParameter[] listaPar4 = new ReportParameter[1] { par4 };
		ReportParameter par5 = new ReportParameter("Folio", MyProject.Forms.FrmIngresarOT.TxtFolio.Text);
		ReportParameter[] listaPar5 = new ReportParameter[1] { par5 };
		ReportViewer1.LocalReport.SetParameters(listaPar1);
		ReportViewer1.LocalReport.SetParameters(listaPar2);
		ReportViewer1.LocalReport.SetParameters(listaPar3);
		ReportViewer1.LocalReport.SetParameters(listaPar4);
		ReportViewer1.LocalReport.SetParameters(listaPar5);
		ReportViewer1.RefreshReport();
	}
}

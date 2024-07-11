using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Sistema_Estiba_PDQ;

/// <summary>
/// Represents a strongly typed in-memory cache of data.
/// </summary>
[Serializable]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("OTDataSet")]
[HelpKeyword("vs.data.DataSet")]
public class OTDataSet : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void OTRowChangeEventHandler(object sender, OTRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class OTDataTable : TypedTableBase<OTRow>
	{
		private DataColumn columnDestino;

		private DataColumn columnCodigo;

		private DataColumn columnOt;

		private DataColumn columnNBulto;

		private DataColumn columnHora;

		private DataColumn columnBarCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn DestinoColumn => columnDestino;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CodigoColumn => columnCodigo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn OtColumn => columnOt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NBultoColumn => columnNBulto;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HoraColumn => columnHora;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn BarCodeColumn => columnBarCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public OTRow this[int index] => (OTRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event OTRowChangeEventHandler OTRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event OTRowChangeEventHandler OTRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event OTRowChangeEventHandler OTRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event OTRowChangeEventHandler OTRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public OTDataTable()
		{
			base.TableName = "OT";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal OTDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				base.Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected OTDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddOTRow(OTRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public OTRow AddOTRow(string Destino, string Codigo, string Ot, string NBulto, string Hora, byte[] BarCode)
		{
			OTRow rowOTRow = (OTRow)NewRow();
			object[] columnValuesArray = new object[6] { Destino, Codigo, Ot, NBulto, Hora, BarCode };
			rowOTRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowOTRow);
			return rowOTRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			OTDataTable cln = (OTDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new OTDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnDestino = base.Columns["Destino"];
			columnCodigo = base.Columns["Codigo"];
			columnOt = base.Columns["Ot"];
			columnNBulto = base.Columns["NBulto"];
			columnHora = base.Columns["Hora"];
			columnBarCode = base.Columns["BarCode"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnDestino = new DataColumn("Destino", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDestino);
			columnCodigo = new DataColumn("Codigo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCodigo);
			columnOt = new DataColumn("Ot", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnOt);
			columnNBulto = new DataColumn("NBulto", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNBulto);
			columnHora = new DataColumn("Hora", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHora);
			columnBarCode = new DataColumn("BarCode", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columnBarCode);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public OTRow NewOTRow()
		{
			return (OTRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new OTRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(OTRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (OTRowChanged != null)
			{
				OTRowChanged?.Invoke(this, new OTRowChangeEvent((OTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (OTRowChanging != null)
			{
				OTRowChanging?.Invoke(this, new OTRowChangeEvent((OTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (OTRowDeleted != null)
			{
				OTRowDeleted?.Invoke(this, new OTRowChangeEvent((OTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (OTRowDeleting != null)
			{
				OTRowDeleting?.Invoke(this, new OTRowChangeEvent((OTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveOTRow(OTRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			OTDataSet ds = new OTDataSet();
			XmlSchemaAny any1 = new XmlSchemaAny();
			any1.Namespace = "http://www.w3.org/2001/XMLSchema";
			any1.MinOccurs = 0m;
			any1.MaxOccurs = decimal.MaxValue;
			any1.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any1);
			XmlSchemaAny any2 = new XmlSchemaAny();
			any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			any2.MinOccurs = 1m;
			any2.ProcessContents = XmlSchemaContentProcessing.Lax;
			sequence.Items.Add(any2);
			XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
			attribute1.Name = "namespace";
			attribute1.FixedValue = ds.Namespace;
			type.Attributes.Add(attribute1);
			XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
			attribute2.Name = "tableTypeName";
			attribute2.FixedValue = "OTDataTable";
			type.Attributes.Add(attribute2);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					XmlSchema schema = null;
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						schema = (XmlSchema)schemas.Current;
						s2.SetLength(0L);
						schema.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = 0L;
							s2.Position = 0L;
							while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
							{
							}
							if (s1.Position == s1.Length)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					s1?.Close();
					s2?.Close();
				}
			}
			xs.Add(dsSchema);
			return type;
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class OTRow : DataRow
	{
		private OTDataTable tableOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Destino
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableOT.DestinoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'Destino' de la tabla 'OT' es DBNull.", e);
				}
			}
			set
			{
				base[tableOT.DestinoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Codigo
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableOT.CodigoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'Codigo' de la tabla 'OT' es DBNull.", e);
				}
			}
			set
			{
				base[tableOT.CodigoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Ot
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableOT.OtColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'Ot' de la tabla 'OT' es DBNull.", e);
				}
			}
			set
			{
				base[tableOT.OtColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NBulto
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableOT.NBultoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'NBulto' de la tabla 'OT' es DBNull.", e);
				}
			}
			set
			{
				base[tableOT.NBultoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string Hora
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableOT.HoraColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'Hora' de la tabla 'OT' es DBNull.", e);
				}
			}
			set
			{
				base[tableOT.HoraColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public byte[] BarCode
		{
			get
			{
				try
				{
					return (byte[])base[tableOT.BarCodeColumn];
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'BarCode' de la tabla 'OT' es DBNull.", e);
				}
			}
			set
			{
				base[tableOT.BarCodeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal OTRow(DataRowBuilder rb)
			: base(rb)
		{
			tableOT = (OTDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsDestinoNull()
		{
			return IsNull(tableOT.DestinoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDestinoNull()
		{
			base[tableOT.DestinoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCodigoNull()
		{
			return IsNull(tableOT.CodigoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCodigoNull()
		{
			base[tableOT.CodigoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsOtNull()
		{
			return IsNull(tableOT.OtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetOtNull()
		{
			base[tableOT.OtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNBultoNull()
		{
			return IsNull(tableOT.NBultoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNBultoNull()
		{
			base[tableOT.NBultoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsHoraNull()
		{
			return IsNull(tableOT.HoraColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetHoraNull()
		{
			base[tableOT.HoraColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsBarCodeNull()
		{
			return IsNull(tableOT.BarCodeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetBarCodeNull()
		{
			base[tableOT.BarCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class OTRowChangeEvent : EventArgs
	{
		private OTRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public OTRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public OTRowChangeEvent(OTRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private OTDataTable tableOT;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public OTDataTable OT => tableOT;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public OTDataSet()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler schemaChangedHandler = SchemaChanged;
		base.Tables.CollectionChanged += schemaChangedHandler;
		base.Relations.CollectionChanged += schemaChangedHandler;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected OTDataSet(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler schemaChangedHandler2 = SchemaChanged;
			Tables.CollectionChanged += schemaChangedHandler2;
			Relations.CollectionChanged += schemaChangedHandler2;
			return;
		}
		string strSchema = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet ds = new DataSet();
			ds.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
			if (ds.Tables["OT"] != null)
			{
				base.Tables.Add(new OTDataTable(ds.Tables["OT"]));
			}
			base.DataSetName = ds.DataSetName;
			base.Prefix = ds.Prefix;
			base.Namespace = ds.Namespace;
			base.Locale = ds.Locale;
			base.CaseSensitive = ds.CaseSensitive;
			base.EnforceConstraints = ds.EnforceConstraints;
			Merge(ds, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler schemaChangedHandler = SchemaChanged;
		base.Tables.CollectionChanged += schemaChangedHandler;
		Relations.CollectionChanged += schemaChangedHandler;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public override DataSet Clone()
	{
		OTDataSet cln = (OTDataSet)base.Clone();
		cln.InitVars();
		cln.SchemaSerializationMode = SchemaSerializationMode;
		return cln;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet ds = new DataSet();
			ds.ReadXml(reader);
			if (ds.Tables["OT"] != null)
			{
				base.Tables.Add(new OTDataTable(ds.Tables["OT"]));
			}
			base.DataSetName = ds.DataSetName;
			base.Prefix = ds.Prefix;
			base.Namespace = ds.Namespace;
			base.Locale = ds.Locale;
			base.CaseSensitive = ds.CaseSensitive;
			base.EnforceConstraints = ds.EnforceConstraints;
			Merge(ds, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream stream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(stream, null));
		stream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(stream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableOT = (OTDataTable)base.Tables["OT"];
		if (initTable && tableOT != null)
		{
			tableOT.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "OTDataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/OTDataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableOT = new OTDataTable();
		base.Tables.Add(tableOT);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeOT()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		OTDataSet ds = new OTDataSet();
		XmlSchemaComplexType type = new XmlSchemaComplexType();
		XmlSchemaSequence sequence = new XmlSchemaSequence();
		XmlSchemaAny any = new XmlSchemaAny();
		any.Namespace = ds.Namespace;
		sequence.Items.Add(any);
		type.Particle = sequence;
		XmlSchema dsSchema = ds.GetSchemaSerializable();
		if (xs.Contains(dsSchema.TargetNamespace))
		{
			MemoryStream s1 = new MemoryStream();
			MemoryStream s2 = new MemoryStream();
			try
			{
				XmlSchema schema = null;
				dsSchema.Write(s1);
				IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
				while (schemas.MoveNext())
				{
					schema = (XmlSchema)schemas.Current;
					s2.SetLength(0L);
					schema.Write(s2);
					if (s1.Length == s2.Length)
					{
						s1.Position = 0L;
						s2.Position = 0L;
						while (s1.Position != s1.Length && s1.ReadByte() == s2.ReadByte())
						{
						}
						if (s1.Position == s1.Length)
						{
							return type;
						}
					}
				}
			}
			finally
			{
				s1?.Close();
				s2?.Close();
			}
		}
		xs.Add(dsSchema);
		return type;
	}
}

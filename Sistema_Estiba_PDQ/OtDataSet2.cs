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
[XmlRoot("OtDataSet2")]
[HelpKeyword("vs.data.DataSet")]
public class OtDataSet2 : DataSet
{
	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class RespaldoDataTable : TypedTableBase<RespaldoRow>
	{
		private DataColumn columnDESTINO;

		private DataColumn columnCODIGO;

		private DataColumn columnOT;

		private DataColumn columnNBULTO;

		private DataColumn columnHORA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn DESTINOColumn => columnDESTINO;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CODIGOColumn => columnCODIGO;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn OTColumn => columnOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NBULTOColumn => columnNBULTO;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HORAColumn => columnHORA;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public RespaldoRow this[int index] => (RespaldoRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event RespaldoRowChangeEventHandler RespaldoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event RespaldoRowChangeEventHandler RespaldoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event RespaldoRowChangeEventHandler RespaldoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event RespaldoRowChangeEventHandler RespaldoRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public RespaldoDataTable()
		{
			base.TableName = "Respaldo";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal RespaldoDataTable(DataTable table)
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
		protected RespaldoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddRespaldoRow(RespaldoRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public RespaldoRow AddRespaldoRow(string DESTINO, string CODIGO, string OT, string NBULTO, string HORA)
		{
			RespaldoRow rowRespaldoRow = (RespaldoRow)NewRow();
			object[] columnValuesArray = new object[5] { DESTINO, CODIGO, OT, NBULTO, HORA };
			rowRespaldoRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowRespaldoRow);
			return rowRespaldoRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			RespaldoDataTable cln = (RespaldoDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new RespaldoDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnDESTINO = base.Columns["DESTINO"];
			columnCODIGO = base.Columns["CODIGO"];
			columnOT = base.Columns["OT"];
			columnNBULTO = base.Columns["NBULTO"];
			columnHORA = base.Columns["HORA"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnDESTINO = new DataColumn("DESTINO", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDESTINO);
			columnCODIGO = new DataColumn("CODIGO", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCODIGO);
			columnOT = new DataColumn("OT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnOT);
			columnNBULTO = new DataColumn("NBULTO", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNBULTO);
			columnHORA = new DataColumn("HORA", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHORA);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public RespaldoRow NewRespaldoRow()
		{
			return (RespaldoRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new RespaldoRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(RespaldoRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (RespaldoRowChanged != null)
			{
				RespaldoRowChanged?.Invoke(this, new RespaldoRowChangeEvent((RespaldoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (RespaldoRowChanging != null)
			{
				RespaldoRowChanging?.Invoke(this, new RespaldoRowChangeEvent((RespaldoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (RespaldoRowDeleted != null)
			{
				RespaldoRowDeleted?.Invoke(this, new RespaldoRowChangeEvent((RespaldoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (RespaldoRowDeleting != null)
			{
				RespaldoRowDeleting?.Invoke(this, new RespaldoRowChangeEvent((RespaldoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveRespaldoRow(RespaldoRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			OtDataSet2 ds = new OtDataSet2();
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
			attribute2.FixedValue = "RespaldoDataTable";
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void RespaldoRowChangeEventHandler(object sender, RespaldoRowChangeEvent e);

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class RespaldoRow : DataRow
	{
		private RespaldoDataTable tableRespaldo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string DESTINO
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRespaldo.DESTINOColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'DESTINO' de la tabla 'Respaldo' es DBNull.", e);
				}
			}
			set
			{
				base[tableRespaldo.DESTINOColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string CODIGO
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRespaldo.CODIGOColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'CODIGO' de la tabla 'Respaldo' es DBNull.", e);
				}
			}
			set
			{
				base[tableRespaldo.CODIGOColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string OT
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRespaldo.OTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'OT' de la tabla 'Respaldo' es DBNull.", e);
				}
			}
			set
			{
				base[tableRespaldo.OTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NBULTO
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRespaldo.NBULTOColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'NBULTO' de la tabla 'Respaldo' es DBNull.", e);
				}
			}
			set
			{
				base[tableRespaldo.NBULTOColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string HORA
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRespaldo.HORAColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'HORA' de la tabla 'Respaldo' es DBNull.", e);
				}
			}
			set
			{
				base[tableRespaldo.HORAColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal RespaldoRow(DataRowBuilder rb)
			: base(rb)
		{
			tableRespaldo = (RespaldoDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsDESTINONull()
		{
			return IsNull(tableRespaldo.DESTINOColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDESTINONull()
		{
			base[tableRespaldo.DESTINOColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsCODIGONull()
		{
			return IsNull(tableRespaldo.CODIGOColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetCODIGONull()
		{
			base[tableRespaldo.CODIGOColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsOTNull()
		{
			return IsNull(tableRespaldo.OTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetOTNull()
		{
			base[tableRespaldo.OTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNBULTONull()
		{
			return IsNull(tableRespaldo.NBULTOColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNBULTONull()
		{
			base[tableRespaldo.NBULTOColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsHORANull()
		{
			return IsNull(tableRespaldo.HORAColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetHORANull()
		{
			base[tableRespaldo.HORAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class RespaldoRowChangeEvent : EventArgs
	{
		private RespaldoRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public RespaldoRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public RespaldoRowChangeEvent(RespaldoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private RespaldoDataTable tableRespaldo;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public RespaldoDataTable Respaldo => tableRespaldo;

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
	public OtDataSet2()
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
	protected OtDataSet2(SerializationInfo info, StreamingContext context)
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
			if (ds.Tables["Respaldo"] != null)
			{
				base.Tables.Add(new RespaldoDataTable(ds.Tables["Respaldo"]));
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
		OtDataSet2 cln = (OtDataSet2)base.Clone();
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
			if (ds.Tables["Respaldo"] != null)
			{
				base.Tables.Add(new RespaldoDataTable(ds.Tables["Respaldo"]));
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
		tableRespaldo = (RespaldoDataTable)base.Tables["Respaldo"];
		if (initTable && tableRespaldo != null)
		{
			tableRespaldo.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "OtDataSet2";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/OtDataSet2.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableRespaldo = new RespaldoDataTable();
		base.Tables.Add(tableRespaldo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeRespaldo()
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
		OtDataSet2 ds = new OtDataSet2();
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

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
[XmlRoot("UsuariosDataSet")]
[HelpKeyword("vs.data.DataSet")]
public class UsuariosDataSet : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void UsuariosRowChangeEventHandler(object sender, UsuariosRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class UsuariosDataTable : TypedTableBase<UsuariosRow>
	{
		private DataColumn columnusuario;

		private DataColumn columnpassword;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn usuarioColumn => columnusuario;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn passwordColumn => columnpassword;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public UsuariosRow this[int index] => (UsuariosRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event UsuariosRowChangeEventHandler UsuariosRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event UsuariosRowChangeEventHandler UsuariosRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event UsuariosRowChangeEventHandler UsuariosRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event UsuariosRowChangeEventHandler UsuariosRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public UsuariosDataTable()
		{
			base.TableName = "Usuarios";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal UsuariosDataTable(DataTable table)
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
		protected UsuariosDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddUsuariosRow(UsuariosRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public UsuariosRow AddUsuariosRow(string usuario, string password)
		{
			UsuariosRow rowUsuariosRow = (UsuariosRow)NewRow();
			object[] columnValuesArray = new object[2] { usuario, password };
			rowUsuariosRow.ItemArray = columnValuesArray;
			base.Rows.Add(rowUsuariosRow);
			return rowUsuariosRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			UsuariosDataTable cln = (UsuariosDataTable)base.Clone();
			cln.InitVars();
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new UsuariosDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnusuario = base.Columns["usuario"];
			columnpassword = base.Columns["password"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnusuario = new DataColumn("usuario", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnusuario);
			columnpassword = new DataColumn("password", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpassword);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public UsuariosRow NewUsuariosRow()
		{
			return (UsuariosRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new UsuariosRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(UsuariosRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (UsuariosRowChanged != null)
			{
				UsuariosRowChanged?.Invoke(this, new UsuariosRowChangeEvent((UsuariosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (UsuariosRowChanging != null)
			{
				UsuariosRowChanging?.Invoke(this, new UsuariosRowChangeEvent((UsuariosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (UsuariosRowDeleted != null)
			{
				UsuariosRowDeleted?.Invoke(this, new UsuariosRowChangeEvent((UsuariosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (UsuariosRowDeleting != null)
			{
				UsuariosRowDeleting?.Invoke(this, new UsuariosRowChangeEvent((UsuariosRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveUsuariosRow(UsuariosRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			UsuariosDataSet ds = new UsuariosDataSet();
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
			attribute2.FixedValue = "UsuariosDataTable";
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
	public class UsuariosRow : DataRow
	{
		private UsuariosDataTable tableUsuarios;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string usuario
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsuarios.usuarioColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'usuario' de la tabla 'Usuarios' es DBNull.", e);
				}
			}
			set
			{
				base[tableUsuarios.usuarioColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string password
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsuarios.passwordColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException e = ex;
					throw new StrongTypingException("El valor de la columna 'password' de la tabla 'Usuarios' es DBNull.", e);
				}
			}
			set
			{
				base[tableUsuarios.passwordColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal UsuariosRow(DataRowBuilder rb)
			: base(rb)
		{
			tableUsuarios = (UsuariosDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsusuarioNull()
		{
			return IsNull(tableUsuarios.usuarioColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetusuarioNull()
		{
			base[tableUsuarios.usuarioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IspasswordNull()
		{
			return IsNull(tableUsuarios.passwordColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetpasswordNull()
		{
			base[tableUsuarios.passwordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class UsuariosRowChangeEvent : EventArgs
	{
		private UsuariosRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public UsuariosRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public UsuariosRowChangeEvent(UsuariosRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private UsuariosDataTable tableUsuarios;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public UsuariosDataTable Usuarios => tableUsuarios;

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
	public UsuariosDataSet()
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
	protected UsuariosDataSet(SerializationInfo info, StreamingContext context)
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
			if (ds.Tables["Usuarios"] != null)
			{
				base.Tables.Add(new UsuariosDataTable(ds.Tables["Usuarios"]));
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
		UsuariosDataSet cln = (UsuariosDataSet)base.Clone();
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
			if (ds.Tables["Usuarios"] != null)
			{
				base.Tables.Add(new UsuariosDataTable(ds.Tables["Usuarios"]));
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
		tableUsuarios = (UsuariosDataTable)base.Tables["Usuarios"];
		if (initTable && tableUsuarios != null)
		{
			tableUsuarios.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "UsuariosDataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/UsuariosDataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableUsuarios = new UsuariosDataTable();
		base.Tables.Add(tableUsuarios);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeUsuarios()
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
		UsuariosDataSet ds = new UsuariosDataSet();
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

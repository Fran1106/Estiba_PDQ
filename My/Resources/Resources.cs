using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Sistema_Estiba_PDQ.My.Resources;

/// <summary>
///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
/// </summary>
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	/// <summary>
	///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager temp = new ResourceManager("Sistema_Estiba_PDQ.Resources", typeof(Resources).Assembly);
				resourceMan = temp;
			}
			return resourceMan;
		}
	}

	/// <summary>
	///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
	///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap cbarras
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("cbarras", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_AcercaDe
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_AcercaDe", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Actualizar
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Actualizar", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Ayuda
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Ayuda", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Buscar
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Buscar", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Cerrar
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Cerrar", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Config
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Config", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Eliminar
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Eliminar", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Guardar
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Guardar", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Imprimir
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Imprimir", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Imprimir1
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Imprimir1", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Informe
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Informe", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Informe_OT
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Informe_OT", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Informe_Usuarios
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Informe_Usuarios", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Ingresar
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Ingresar", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Manual
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Manual", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Ico_Usuarios
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Ico_Usuarios", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap IcoActualizar
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("IcoActualizar", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap IcoImprimir3
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("IcoImprimir3", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap IcoNuevo
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("IcoNuevo", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap IcoRespaldo
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("IcoRespaldo", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap Nuevo
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Nuevo", resourceCulture));
			return (Bitmap)obj;
		}
	}

	/// <summary>
	///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
	/// </summary>
	internal static Bitmap PDQ_LOGO
	{
		get
		{
			object obj = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("PDQ-LOGO", resourceCulture));
			return (Bitmap)obj;
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Sistema_Estiba_PDQ.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmAcercaDe m_FrmAcercaDe;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmDestino m_FrmDestino;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmIngresarOT m_FrmIngresarOT;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmLogin m_FrmLogin;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmPrincipal m_FrmPrincipal;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmRegistrosOT m_FrmRegistrosOT;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmReporteOT m_FrmReporteOT;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmReporteOT2 m_FrmReporteOT2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmReporteUsuarios m_FrmReporteUsuarios;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmRespaldo m_FrmRespaldo;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FrmUsuarios m_FrmUsuarios;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public FrmContinuarOT m_FrmContinuarOT;

        public FrmAcercaDe FrmAcercaDe
		{
			[DebuggerHidden]
			get
			{
				m_FrmAcercaDe = Create__Instance__(m_FrmAcercaDe);
				return m_FrmAcercaDe;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmAcercaDe)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmAcercaDe);
				}
			}
		}

		public FrmDestino FrmDestino
		{
			[DebuggerHidden]
			get
			{
				m_FrmDestino = Create__Instance__(m_FrmDestino);
				return m_FrmDestino;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmDestino)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmDestino);
				}
			}
		}

        public FrmIngresarOT FrmIngresarOT
		{
			[DebuggerHidden]
			get
			{
				m_FrmIngresarOT = Create__Instance__(m_FrmIngresarOT);
				return m_FrmIngresarOT;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmIngresarOT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmIngresarOT);
				}
			}
		}

        public FrmContinuarOT FrmContinuarOT
        {
            [DebuggerHidden]
            get
            {
                m_FrmContinuarOT = Create__Instance__(m_FrmContinuarOT);
                return m_FrmContinuarOT;
            }
            [DebuggerHidden]
            set
            {
                if (value != m_FrmContinuarOT)
                {
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    Dispose__Instance__(ref m_FrmContinuarOT);
                }
            }
        }

        public FrmLogin FrmLogin
		{
			[DebuggerHidden]
			get
			{
				m_FrmLogin = Create__Instance__(m_FrmLogin);
				return m_FrmLogin;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmLogin)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmLogin);
				}
			}
		}

		public FrmPrincipal FrmPrincipal
		{
			[DebuggerHidden]
			get
			{
				m_FrmPrincipal = Create__Instance__(m_FrmPrincipal);
				return m_FrmPrincipal;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmPrincipal)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmPrincipal);
				}
			}
		}

		public FrmRegistrosOT FrmRegistrosOT
		{
			[DebuggerHidden]
			get
			{
				m_FrmRegistrosOT = Create__Instance__(m_FrmRegistrosOT);
				return m_FrmRegistrosOT;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmRegistrosOT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRegistrosOT);
				}
			}
		}

		public FrmReporteOT FrmReporteOT
		{
			[DebuggerHidden]
			get
			{
				m_FrmReporteOT = Create__Instance__(m_FrmReporteOT);
				return m_FrmReporteOT;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmReporteOT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReporteOT);
				}
			}
		}

		public FrmReporteOT2 FrmReporteOT2
		{
			[DebuggerHidden]
			get
			{
				m_FrmReporteOT2 = Create__Instance__(m_FrmReporteOT2);
				return m_FrmReporteOT2;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmReporteOT2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReporteOT2);
				}
			}
		}

		public FrmReporteUsuarios FrmReporteUsuarios
		{
			[DebuggerHidden]
			get
			{
				m_FrmReporteUsuarios = Create__Instance__(m_FrmReporteUsuarios);
				return m_FrmReporteUsuarios;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmReporteUsuarios)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmReporteUsuarios);
				}
			}
		}

		public FrmRespaldo FrmRespaldo
		{
			[DebuggerHidden]
			get
			{
				m_FrmRespaldo = Create__Instance__(m_FrmRespaldo);
				return m_FrmRespaldo;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmRespaldo)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmRespaldo);
				}
			}
		}

		public FrmUsuarios FrmUsuarios
		{
			[DebuggerHidden]
			get
			{
				m_FrmUsuarios = Create__Instance__(m_FrmUsuarios);
				return m_FrmUsuarios;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FrmUsuarios)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FrmUsuarios);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string BetterMessage = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(BetterMessage, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}

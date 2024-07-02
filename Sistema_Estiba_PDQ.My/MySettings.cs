using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Sistema_Estiba_PDQ.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						MyProject.Application.Shutdown += [DebuggerNonUserCode] [EditorBrowsable(EditorBrowsableState.Advanced)] (object sender, EventArgs e) =>
						{
							if (MyProject.Application.SaveMySettingsOnExit)
							{
								MySettingsProperty.Settings.Save();
							}
						};
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Data Source=(local);Initial Catalog=dbestiba;Integrated Security=True")]
	public string dbestibaConnectionString => Conversions.ToString(this["dbestibaConnectionString"]);

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}

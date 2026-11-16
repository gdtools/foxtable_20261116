using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.My
{
	// Token: 0x02000558 RID: 1368
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06005C1D RID: 23581 RVA: 0x0027125F File Offset: 0x0026F45F
		// (set) Token: 0x06005C1E RID: 23582 RVA: 0x00271271 File Offset: 0x0026F471
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public DateTime LastDate
		{
			get
			{
				return Conversions.ToDate(this["LastDate"]);
			}
			set
			{
				this["LastDate"] = value;
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06005C1F RID: 23583 RVA: 0x00271284 File Offset: 0x0026F484
		// (set) Token: 0x06005C20 RID: 23584 RVA: 0x00271296 File Offset: 0x0026F496
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int Count
		{
			get
			{
				return Conversions.ToInteger(this["Count"]);
			}
			set
			{
				this["Count"] = value;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x002712A9 File Offset: 0x0026F4A9
		// (set) Token: 0x06005C22 RID: 23586 RVA: 0x002712BB File Offset: 0x0026F4BB
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public DateTime LoadDate
		{
			get
			{
				return Conversions.ToDate(this["LoadDate"]);
			}
			set
			{
				this["LoadDate"] = value;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x002712CE File Offset: 0x0026F4CE
		// (set) Token: 0x06005C24 RID: 23588 RVA: 0x002712E0 File Offset: 0x0026F4E0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int LoadCount
		{
			get
			{
				return Conversions.ToInteger(this["LoadCount"]);
			}
			set
			{
				this["LoadCount"] = value;
			}
		}
	}
}

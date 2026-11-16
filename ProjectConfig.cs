using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000444 RID: 1092
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("1544")]
	[StandardModule]
	public sealed class ProjectConfig
	{
		// Token: 0x06004989 RID: 18825 RVA: 0x00202507 File Offset: 0x00200707
		public static void SaveConfigValue(string Name, object Value)
		{
			ConfigFunctions.SaveValue(Name, RuntimeHelpers.GetObjectValue(Value), O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], O_O0OO.O_O._Oo.());
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x0020252E File Offset: 0x0020072E
		public static object GetConfigValue(string Name, object DefaultValue)
		{
			return ConfigFunctions.GetValue(Name, RuntimeHelpers.GetObjectValue(DefaultValue), O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], O_O0OO.O_O._Oo.());
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00202555 File Offset: 0x00200755
		public static void RemoveConfigItem(string Name)
		{
			ConfigFunctions.RemoveItem(Name, O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], O_O0OO.O_O._Oo.());
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00202576 File Offset: 0x00200776
		public static void ClearConfigItem()
		{
			ConfigFunctions.ClearItmes(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()]);
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00202591 File Offset: 0x00200791
		public static void SaveAllConfigItem()
		{
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
		}
	}
}

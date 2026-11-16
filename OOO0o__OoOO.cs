using System;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor;

namespace Foxtable
{
	// Token: 0x02000071 RID: 113
	internal class OOO0o__OoOO : VBQuickInfoProvider
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x00018D14 File Offset: 0x00016F14
		protected virtual bool <<EMPTY_NAME>>(IEditorView A_0, object A_1)
		{
			bool result;
			if (!A_0.Properties.ContainsKey("SystemReady"))
			{
				result = false;
			}
			else
			{
				try
				{
					result = base.RequestSession(A_0, RuntimeHelpers.GetObjectValue(A_1));
				}
				catch (Exception ex)
				{
					result = false;
				}
			}
			return result;
		}
	}
}

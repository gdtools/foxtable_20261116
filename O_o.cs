using System;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor;

namespace Foxtable
{
	// Token: 0x02000070 RID: 112
	internal class O_o : VBParameterInfoProvider
	{
		// Token: 0x0600041B RID: 1051 RVA: 0x00018CBC File Offset: 0x00016EBC
		public virtual bool <<EMPTY_NAME>>(IEditorView A_0)
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
					result = base.RequestSession(A_0);
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

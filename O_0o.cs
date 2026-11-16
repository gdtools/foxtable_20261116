using System;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Languages.DotNet;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.Outlining;

namespace Foxtable
{
	// Token: 0x0200006C RID: 108
	internal class O_0o : IOutliner
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x000170F8 File Offset: 0x000152F8
		public AutomaticOutliningUpdateTrigger <<EMPTY_NAME>>()
		{
			return AutomaticOutliningUpdateTrigger.ParseDataChanged;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000170FC File Offset: 0x000152FC
		public IOutliningSource <<EMPTY_NAME>>(ITextSnapshot A_0)
		{
			if (A_0 != null)
			{
				ICodeDocument codeDocument = A_0.Document as ICodeDocument;
				if (codeDocument != null)
				{
					IDotNetParseData dotNetParseData = codeDocument.ParseData as IDotNetParseData;
					if (dotNetParseData != null)
					{
						OooOOO_0_O oooOOO_0_O = new OooOOO_0_O(dotNetParseData.Snapshot);
						oooOOO_0_O.TranslateTo(A_0);
						return oooOOO_0_O;
					}
				}
			}
			return null;
		}
	}
}

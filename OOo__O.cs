using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000054 RID: 84
	internal class OOo__O : UITypeEditor
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x000085CC File Offset: 0x000067CC
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			UITypeEditorEditStyle result;
			if (context != null && context.Instance != null)
			{
				result = UITypeEditorEditStyle.Modal;
			}
			else
			{
				result = base.GetEditStyle(context);
			}
			return result;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000085F4 File Offset: 0x000067F4
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			int num;
			object result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (context != null && context.Instance != null && provider != null)
				{
					goto IL_20;
				}
				IL_17:
				num2 = 3;
				result = value;
				goto IL_B3;
				IL_20:
				num2 = 4;
				this.wfes = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				IL_3D:
				num2 = 5;
				if (this.wfes != null)
				{
					goto IL_4D;
				}
				IL_47:
				num2 = 6;
				result = value;
				goto IL_B3;
				IL_4D:
				num2 = 7;
				this.dlg = new FolderBrowserDialog();
				IL_5A:
				num2 = 8;
				if (value == null || Operators.CompareString(value.ToString(), "", true) <= 0)
				{
					goto IL_87;
				}
				IL_73:
				num2 = 9;
				this.dlg.SelectedPath = value.ToString();
				IL_87:
				num2 = 10;
				if (this.dlg.ShowDialog() != DialogResult.OK)
				{
					goto IL_A9;
				}
				IL_98:
				num2 = 11;
				result = this.dlg.SelectedPath;
				goto IL_B3;
				IL_A9:
				num2 = 13;
				result = RuntimeHelpers.GetObjectValue(value);
				IL_B3:
				goto IL_13D;
				IL_B8:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_FE:
				goto IL_132;
				IL_100:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_110:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_100;
			}
			IL_132:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_13D:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0400007D RID: 125
		private IWindowsFormsEditorService wfes;

		// Token: 0x0400007E RID: 126
		private FolderBrowserDialog dlg;
	}
}

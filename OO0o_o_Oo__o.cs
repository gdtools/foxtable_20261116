using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200005A RID: 90
	internal class OO0o_o_Oo__o : UITypeEditor
	{
		// Token: 0x060002FC RID: 764 RVA: 0x00008E6C File Offset: 0x0000706C
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

		// Token: 0x060002FD RID: 765 RVA: 0x00008E94 File Offset: 0x00007094
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
				goto IL_F1;
				IL_20:
				num2 = 4;
				this.wfes = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				IL_3D:
				num2 = 5;
				if (this.wfes != null)
				{
					goto IL_50;
				}
				IL_47:
				num2 = 6;
				result = value;
				goto IL_F1;
				IL_50:
				num2 = 7;
				this.dlg = new SaveFileDialog();
				IL_5D:
				num2 = 8;
				this.dlg.OverwritePrompt = false;
				IL_6B:
				num2 = 9;
				Ooo0___ ooo0___ = (Ooo0___)context.PropertyDescriptor.Attributes[typeof(Ooo0___)];
				IL_8F:
				num2 = 10;
				this.dlg.Filter = ooo0___.O0oO_0._o_.();
				IL_A4:
				ooo0___ = null;
				IL_A7:
				num2 = 12;
				this.dlg.FilterIndex = 0;
				IL_B6:
				num2 = 13;
				if (this.dlg.ShowDialog() != DialogResult.OK)
				{
					goto IL_E7;
				}
				IL_C7:
				num2 = 14;
				result = c.OOOOO.o.().FileSystem.GetName(this.dlg.FileName);
				goto IL_F1;
				IL_E7:
				num2 = 16;
				result = RuntimeHelpers.GetObjectValue(value);
				IL_F1:
				goto IL_187;
				IL_F6:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_148:
				goto IL_17C;
				IL_14A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_15A:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_14A;
			}
			IL_17C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_187:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04000083 RID: 131
		private IWindowsFormsEditorService wfes;

		// Token: 0x04000084 RID: 132
		private SaveFileDialog dlg;
	}
}

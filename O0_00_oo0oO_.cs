using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200005D RID: 93
	internal class O0_00_oo0oO_ : UITypeEditor
	{
		// Token: 0x06000305 RID: 773 RVA: 0x000095C4 File Offset: 0x000077C4
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

		// Token: 0x06000306 RID: 774 RVA: 0x000095EC File Offset: 0x000077EC
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
				goto IL_10C;
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
				goto IL_10C;
				IL_50:
				num2 = 8;
				this.frmEditor = new O_\u3000();
				IL_5D:
				num2 = 9;
				this.frmEditor.Text = context.PropertyDescriptor.DisplayName;
				IL_76:
				num2 = 10;
				if (value == null)
				{
					goto IL_95;
				}
				IL_7C:
				num2 = 11;
				this.frmEditor.O_0._o_O0o.().Value = Conversions.ToString(value);
				IL_95:
				num2 = 12;
				if (this.wfes.ShowDialog(this.frmEditor) != DialogResult.OK)
				{
					goto IL_EA;
				}
				IL_AC:
				num2 = 13;
				if (Operators.CompareString(this.frmEditor.O_0._o_O0o.().Text, "", true) <= 0)
				{
					goto IL_E3;
				}
				IL_CD:
				num2 = 14;
				result = this.frmEditor.O_0._o_O0o.().Text;
				goto IL_F4;
				IL_E3:
				num2 = 16;
				result = null;
				goto IL_F4;
				IL_EA:
				num2 = 18;
				result = RuntimeHelpers.GetObjectValue(value);
				IL_F4:
				num2 = 19;
				this.frmEditor.Dispose();
				IL_102:
				num2 = 20;
				this.frmEditor = null;
				IL_10C:
				goto IL_1B2;
				IL_111:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_173:
				goto IL_1A7;
				IL_175:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_185:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_175;
			}
			IL_1A7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1B2:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04000088 RID: 136
		private IWindowsFormsEditorService wfes;

		// Token: 0x04000089 RID: 137
		private O_\u3000 frmEditor;
	}
}

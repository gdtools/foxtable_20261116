using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200004B RID: 75
	internal class ooO0o0_oO0_0 : UITypeEditor
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00007634 File Offset: 0x00005834
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

		// Token: 0x060002C2 RID: 706 RVA: 0x0000765C File Offset: 0x0000585C
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
				goto IL_E9;
				IL_20:
				num2 = 4;
				this.oo.O0o0o. = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				IL_3D:
				num2 = 5;
				if (this.oo.O0o0o. != null)
				{
					goto IL_50;
				}
				IL_47:
				num2 = 6;
				result = value;
				goto IL_E9;
				IL_50:
				num2 = 8;
				this.oo.O0o0o. = new O\u3002\u3002o();
				IL_5D:
				num2 = 9;
				if (value == null)
				{
					goto IL_77;
				}
				IL_63:
				num2 = 10;
				this.oo.O0o0o..Value = Conversions.ToString(value);
				IL_77:
				num2 = 11;
				if (this.oo.O0o0o..ShowDialog(this.oo.O0o0o.) != DialogResult.OK)
				{
					goto IL_C7;
				}
				IL_8E:
				num2 = 12;
				if (Operators.CompareString(this.oo.O0o0o..oo0.O_o.().Text, "", true) <= 0)
				{
					goto IL_C0;
				}
				IL_AF:
				num2 = 13;
				result = this.oo.O0o0o..Value;
				goto IL_D1;
				IL_C0:
				num2 = 15;
				result = null;
				goto IL_D1;
				IL_C7:
				num2 = 17;
				result = RuntimeHelpers.GetObjectValue(value);
				IL_D1:
				num2 = 18;
				this.oo.O0o0o..Dispose();
				IL_DF:
				num2 = 19;
				this.oo.O0o0o. = null;
				IL_E9:
				goto IL_18B;
				IL_EE:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_14C:
				goto IL_180;
				IL_14E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_15E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_14E;
			}
			IL_180:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_18B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04000079 RID: 121
		private IWindowsFormsEditorService <<EMPTY_NAME>>;

		// Token: 0x0400007A RID: 122
		private O\u3002\u3002o <<EMPTY_NAME>>;
	}
}

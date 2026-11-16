using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200005B RID: 91
	internal class o0O_O__o000 : UITypeEditor
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00009058 File Offset: 0x00007258
		public virtual UITypeEditorEditStyle <<EMPTY_NAME>>(ITypeDescriptorContext A_0)
		{
			UITypeEditorEditStyle result;
			if (A_0 != null && A_0.Instance != null)
			{
				result = UITypeEditorEditStyle.Modal;
			}
			else
			{
				result = base.GetEditStyle(A_0);
			}
			return result;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00009080 File Offset: 0x00007280
		public virtual object <<EMPTY_NAME>>(ITypeDescriptorContext A_0, IServiceProvider A_1, object A_2)
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
				if (A_0 != null && A_0.Instance != null && A_1 != null)
				{
					goto IL_20;
				}
				IL_17:
				num2 = 3;
				result = A_2;
				goto IL_10C;
				IL_20:
				num2 = 4;
				this.O_o.O00Oo. = (IWindowsFormsEditorService)A_1.GetService(typeof(IWindowsFormsEditorService));
				IL_3D:
				num2 = 5;
				if (this.O_o.O00Oo. != null)
				{
					goto IL_50;
				}
				IL_47:
				num2 = 6;
				result = A_2;
				goto IL_10C;
				IL_50:
				num2 = 8;
				this.O_o.O00Oo. = new O\u3002\u3000\u3002\u3000\u3000();
				IL_5D:
				num2 = 9;
				this.O_o.O00Oo..Text = A_0.PropertyDescriptor.DisplayName;
				IL_76:
				num2 = 10;
				if (A_2 == null)
				{
					goto IL_95;
				}
				IL_7C:
				num2 = 11;
				this.O_o.O00Oo..Oo_.o___.().Text = Conversions.ToString(A_2);
				IL_95:
				num2 = 12;
				if (this.O_o.O00Oo..ShowDialog(this.O_o.O00Oo.) != DialogResult.OK)
				{
					goto IL_EA;
				}
				IL_AC:
				num2 = 13;
				if (Operators.CompareString(this.O_o.O00Oo..Oo_.o___.().Text, "", true) <= 0)
				{
					goto IL_E3;
				}
				IL_CD:
				num2 = 14;
				result = this.O_o.O00Oo..Oo_.o___.().Text;
				goto IL_F4;
				IL_E3:
				num2 = 16;
				result = null;
				goto IL_F4;
				IL_EA:
				num2 = 18;
				result = RuntimeHelpers.GetObjectValue(A_2);
				IL_F4:
				num2 = 19;
				this.O_o.O00Oo..Dispose();
				IL_102:
				num2 = 20;
				this.O_o.O00Oo. = null;
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

		// Token: 0x04000085 RID: 133
		private IWindowsFormsEditorService <<EMPTY_NAME>>;

		// Token: 0x04000086 RID: 134
		private O\u3002\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>;
	}
}

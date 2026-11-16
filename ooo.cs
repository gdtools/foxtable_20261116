using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000055 RID: 85
	internal class ooo : UITypeEditor
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x0000876C File Offset: 0x0000696C
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

		// Token: 0x060002E5 RID: 741 RVA: 0x00008794 File Offset: 0x00006994
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
				goto IL_D5;
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
				goto IL_D5;
				IL_50:
				num2 = 7;
				this.dlg = new OpenFileDialog();
				IL_5D:
				num2 = 8;
				this.dlg.Filter = O_O0OO.o__._oo0O.();
				IL_6F:
				num2 = 9;
				this.dlg.FilterIndex = 0;
				IL_7E:
				num2 = 10;
				if (this.dlg.ShowDialog() != DialogResult.OK)
				{
					goto IL_CB;
				}
				IL_8F:
				num2 = 11;
				string text = ooO.oo__.O000_o_O.(this.dlg.FileName);
				IL_A4:
				num2 = 12;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_BF;
				}
				IL_B7:
				num2 = 13;
				result = text;
				goto IL_D5;
				IL_BF:
				num2 = 15;
				result = RuntimeHelpers.GetObjectValue(value);
				goto IL_D5;
				IL_CB:
				num2 = 17;
				result = RuntimeHelpers.GetObjectValue(value);
				IL_D5:
				goto IL_16F;
				IL_DA:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_130:
				goto IL_164;
				IL_132:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_142:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_132;
			}
			IL_164:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_16F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00008938 File Offset: 0x00006B38
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000893C File Offset: 0x00006B3C
		public override void PaintValue(PaintValueEventArgs e)
		{
			string text = Conversions.ToString(e.Value);
			if (Operators.CompareString(text, "", true) > 0)
			{
				Image image = OO_00oOO.GetImage(text);
				if (image != null)
				{
					e.Graphics.DrawImage(image, e.Bounds);
				}
			}
		}

		// Token: 0x0400007F RID: 127
		private IWindowsFormsEditorService wfes;

		// Token: 0x04000080 RID: 128
		private OpenFileDialog dlg;
	}
}

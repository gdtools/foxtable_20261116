using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Foxtable.Syscmd;
using Foxtable.Word;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000056 RID: 86
	internal class O0_000oo : UITypeEditor
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00008988 File Offset: 0x00006B88
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

		// Token: 0x060002EA RID: 746 RVA: 0x000089B0 File Offset: 0x00006BB0
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
				goto IL_17B;
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
				goto IL_17B;
				IL_50:
				num2 = 7;
				this.dlg = new OpenFileDialog();
				IL_5D:
				num2 = 8;
				if (!(context.Instance is ReportProperty) && !(context.Instance is ReportProperty))
				{
					goto IL_D7;
				}
				IL_79:
				num2 = 9;
				string text = OO_00oOO.ProjectPath + "Attachments";
				IL_8D:
				num2 = 10;
				if (OO_00oOO.FileSys.DirectoryExists(text))
				{
					goto IL_AD;
				}
				IL_9E:
				num2 = 11;
				OO_00oOO.FileSys.CreateDirectory(text);
				IL_AD:
				num2 = 12;
				this.dlg.InitialDirectory = text;
				IL_BD:
				num2 = 13;
				this.dlg.FileOk += Project.O0O0o.Oo0OO_oO.;
				IL_D7:
				num2 = 14;
				Ooo0___ ooo0___ = (Ooo0___)context.PropertyDescriptor.Attributes[typeof(Ooo0___)];
				IL_FB:
				num2 = 15;
				this.dlg.Filter = ooo0___.O0oO_0._o_.();
				IL_110:
				ooo0___ = null;
				IL_113:
				num2 = 17;
				this.dlg.FilterIndex = 0;
				IL_122:
				num2 = 18;
				if (this.dlg.ShowDialog() != DialogResult.OK)
				{
					goto IL_171;
				}
				IL_133:
				num2 = 19;
				string text2 = ooO.oO0__o.0o__.(this.dlg.FileName, null, null);
				IL_14A:
				num2 = 20;
				if (Operators.CompareString(text2, "", true) <= 0)
				{
					goto IL_165;
				}
				IL_15D:
				num2 = 21;
				result = text2;
				goto IL_17B;
				IL_165:
				num2 = 23;
				result = RuntimeHelpers.GetObjectValue(value);
				goto IL_17B;
				IL_171:
				num2 = 25;
				result = RuntimeHelpers.GetObjectValue(value);
				IL_17B:
				goto IL_235;
				IL_180:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1F6:
				goto IL_22A;
				IL_1F8:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_208:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1F8;
			}
			IL_22A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_235:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04000081 RID: 129
		private IWindowsFormsEditorService wfes;

		// Token: 0x04000082 RID: 130
		private OpenFileDialog dlg;
	}
}

using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200004F RID: 79
	internal class O00_ : UITypeEditor
	{
		// Token: 0x060002CF RID: 719 RVA: 0x00007C90 File Offset: 0x00005E90
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

		// Token: 0x060002D0 RID: 720 RVA: 0x00007CB8 File Offset: 0x00005EB8
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
				string a_ = "";
				IL_10:
				num2 = 3;
				if (context != null && context.Instance != null && provider != null)
				{
					goto IL_29;
				}
				IL_20:
				num2 = 4;
				result = value;
				goto IL_291;
				IL_29:
				num2 = 5;
				this.wfes = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				IL_46:
				num2 = 6;
				if (this.wfes != null)
				{
					goto IL_59;
				}
				IL_50:
				num2 = 7;
				result = value;
				goto IL_291;
				IL_59:
				num2 = 8;
				string text = "";
				IL_62:
				num2 = 9;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_233;
				}
				IL_75:
				num2 = 10;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is DataColumnProperty))
				{
					goto IL_187;
				}
				IL_92:
				num2 = 11;
				string name = context.PropertyDescriptor.Name;
				IL_A2:
				num2 = 13;
				if (Operators.CompareString(name, "TreeBuildCols", true) != 0)
				{
					goto IL_EE;
				}
				IL_B4:
				num2 = 14;
				DataColumnProperty dataColumnProperty = (DataColumnProperty)((o_0oooo_OO)context.Instance).Oo._o.();
				IL_CE:
				num2 = 15;
				text = dataColumnProperty.TreeDataTable;
				IL_DA:
				num2 = 16;
				a_ = dataColumnProperty.TreeBuildCols;
				IL_E6:
				dataColumnProperty = null;
				goto IL_233;
				IL_EE:
				num2 = 19;
				if (Operators.CompareString(name, "TreeSourceCols", true) != 0)
				{
					goto IL_13A;
				}
				IL_100:
				num2 = 20;
				DataColumnProperty dataColumnProperty2 = (DataColumnProperty)((o_0oooo_OO)context.Instance).Oo._o.();
				IL_11A:
				num2 = 21;
				text = dataColumnProperty2.TreeDataTable;
				IL_126:
				num2 = 22;
				a_ = dataColumnProperty2.TreeSourceCols;
				IL_132:
				dataColumnProperty2 = null;
				goto IL_233;
				IL_13A:
				num2 = 25;
				if (Operators.CompareString(name, "TreeReceiveCols", true) != 0)
				{
					goto IL_233;
				}
				IL_14F:
				num2 = 26;
				text = OO_00oOO.CurrentTable.DataTable.Name;
				IL_163:
				num2 = 27;
				a_ = ((DataColumnProperty)((o_0oooo_OO)context.Instance).Oo._o.()).TreeReceiveCols;
				goto IL_233;
				IL_187:
				num2 = 29;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is RecordGridProperty))
				{
					goto IL_233;
				}
				IL_1A4:
				num2 = 30;
				if (Operators.CompareString(context.PropertyDescriptor.Name, "Columns", true) != 0)
				{
					goto IL_233;
				}
				IL_1BF:
				num2 = 31;
				RecordGridProperty recordGridProperty = (RecordGridProperty)((o_0oooo_OO)context.Instance).Oo._o.();
				IL_1D9:
				num2 = 32;
				if (Operators.CompareString(recordGridProperty.TableName, "", true) <= 0 || !OO_00oOO.Tables.get_Contains(recordGridProperty.TableName))
				{
					goto IL_230;
				}
				IL_204:
				num2 = 33;
				text = OO_00oOO.Tables[recordGridProperty.TableName].DataTable.Name;
				IL_224:
				num2 = 34;
				a_ = recordGridProperty.Columns;
				IL_230:
				recordGridProperty = null;
				IL_233:
				num2 = 36;
				if (Operators.CompareString(text, "", true) != 0 && OO_00oOO.DataTables.Contains(text))
				{
					goto IL_25A;
				}
				IL_253:
				num2 = 37;
				result = value;
				goto IL_291;
				IL_25A:
				num2 = 39;
				O\u3000O\u3002\u3000\u3002\u3000\u3000\u3000 o_u3000O_u3002_u3000_u3002_u3000_u3000_u = new O\u3000O\u3002\u3000\u3002\u3000\u3000\u3000(OO_00oOO.Tables[text], a_);
				IL_272:
				num2 = 40;
				if (o_u3000O_u3002_u3000_u3002_u3000_u3000_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_28C;
				}
				IL_27F:
				num2 = 41;
				result = o_u3000O_u3002_u3000_u3002_u3000_u3000_u.O0_00O_o.__o.;
				goto IL_291;
				IL_28C:
				num2 = 42;
				result = value;
				IL_291:
				goto IL_38F;
				IL_296:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_350:
				goto IL_384;
				IL_352:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_362:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_352;
			}
			IL_384:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_38F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0400007B RID: 123
		private IWindowsFormsEditorService wfes;
	}
}

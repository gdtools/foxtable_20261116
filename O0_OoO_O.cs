using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200005C RID: 92
	internal class O0_OoO_O : UITypeEditor
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0000926C File Offset: 0x0000746C
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

		// Token: 0x06000303 RID: 771 RVA: 0x00009294 File Offset: 0x00007494
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
				goto IL_218;
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
				goto IL_218;
				IL_59:
				num2 = 8;
				string text = "";
				IL_62:
				num2 = 9;
				DataTable dataTable = null;
				IL_68:
				num2 = 10;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_191;
				}
				IL_7B:
				num2 = 11;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is TableGridProperty))
				{
					goto IL_191;
				}
				IL_98:
				num2 = 12;
				if (Operators.CompareString(context.PropertyDescriptor.Name, "ColumnList", true) != 0)
				{
					goto IL_191;
				}
				IL_B6:
				num2 = 13;
				TableGridProperty tableGridProperty = (TableGridProperty)((o_0oooo_OO)context.Instance).Oo._o.();
				IL_D0:
				num2 = 14;
				if (tableGridProperty.TableType != TableTypeEnum.Normal || Operators.CompareString(tableGridProperty.RelationTable, "", true) <= 0 || !OO_00oOO.Tables.get_Contains(tableGridProperty.RelationTable))
				{
					goto IL_11E;
				}
				IL_104:
				num2 = 15;
				text = tableGridProperty.RelationTable;
				IL_110:
				num2 = 16;
				a_ = tableGridProperty.ColumnList;
				goto IL_18E;
				IL_11E:
				num2 = 18;
				if ((tableGridProperty.TableType != TableTypeEnum.SQLQuery && tableGridProperty.TableType != TableTypeEnum.SQLTable) || Operators.CompareString(tableGridProperty.SelectString, "", true) <= 0)
				{
					goto IL_18E;
				}
				IL_14A:
				num2 = 19;
				SQLCommand sqlcommand = new SQLCommand();
				IL_154:
				num2 = 20;
				sqlcommand.CommandText = tableGridProperty.SelectString;
				IL_165:
				num2 = 21;
				sqlcommand.ConnectionName = tableGridProperty.Connection;
				IL_176:
				num2 = 22;
				dataTable = sqlcommand.OO__00.__.();
				IL_182:
				num2 = 23;
				a_ = tableGridProperty.ColumnList;
				IL_18E:
				tableGridProperty = null;
				IL_191:
				num2 = 25;
				if (Operators.CompareString(text, "", true) <= 0 || !OO_00oOO.Tables.get_Contains(text))
				{
					goto IL_1E4;
				}
				IL_1B2:
				num2 = 26;
				o\u3002_\u3000\u3000\u3000 o_u3002__u3000_u3000_u = new o\u3002_\u3000\u3000\u3000(OO_00oOO.Tables[text], a_);
				IL_1CA:
				num2 = 27;
				if (o_u3002__u3000_u3000_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_213;
				}
				IL_1D7:
				num2 = 28;
				result = o_u3002__u3000_u3000_u.O.0oo0O0_o.;
				goto IL_218;
				IL_1E4:
				num2 = 30;
				if (dataTable == null)
				{
					goto IL_213;
				}
				IL_1EB:
				num2 = 31;
				o\u3002_\u3000\u3000\u3000 o_u3002__u3000_u3000_u2 = new o\u3002_\u3000\u3000\u3000(dataTable, a_);
				IL_1F9:
				num2 = 32;
				if (o_u3002__u3000_u3000_u2.ShowDialog() != DialogResult.OK)
				{
					goto IL_213;
				}
				IL_206:
				num2 = 33;
				result = o_u3002__u3000_u3000_u2.O.0oo0O0_o.;
				goto IL_218;
				IL_213:
				num2 = 34;
				result = value;
				IL_218:
				goto IL_2F6;
				IL_21D:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2B7:
				goto IL_2EB;
				IL_2B9:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2C9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2B9;
			}
			IL_2EB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2F6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04000087 RID: 135
		private IWindowsFormsEditorService wfes;
	}
}

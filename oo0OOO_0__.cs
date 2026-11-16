using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200004E RID: 78
	internal class oo0OOO_0__ : StringConverter
	{
		// Token: 0x060002CB RID: 715 RVA: 0x0000797D File Offset: 0x00005B7D
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00007980 File Offset: 0x00005B80
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00007984 File Offset: 0x00005B84
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			int num;
			TypeConverter.StandardValuesCollection result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = "";
				IL_10:
				num2 = 3;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_149;
				}
				IL_22:
				num2 = 4;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is ComboboxProperty))
				{
					goto IL_5E;
				}
				IL_3B:
				num2 = 5;
				text = ((ComboboxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				goto IL_149;
				IL_5E:
				num2 = 7;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is ListBoxProperty))
				{
					goto IL_9A;
				}
				IL_77:
				num2 = 8;
				text = ((ListBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				goto IL_149;
				IL_9A:
				num2 = 10;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is CheckedListBoxProperty))
				{
					goto IL_D5;
				}
				IL_B4:
				num2 = 11;
				text = ((CheckedListBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				goto IL_149;
				IL_D5:
				num2 = 13;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is CheckedComboBoxProperty))
				{
					goto IL_110;
				}
				IL_EF:
				num2 = 14;
				text = ((CheckedComboBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				goto IL_149;
				IL_110:
				num2 = 16;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is DataColumnProperty))
				{
					goto IL_149;
				}
				IL_12A:
				num2 = 17;
				text = ((DataColumnProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				IL_149:
				num2 = 18;
				if (Operators.CompareString(text, "", true) != 0 && OO_00oOO.DataTables.Contains(text))
				{
					goto IL_173;
				}
				IL_169:
				num2 = 19;
				result = null;
				goto IL_20D;
				IL_173:
				num2 = 20;
				List<string> list = new List<string>();
				IL_17D:
				num2 = 21;
				IEnumerator<DataCol> enumerator = OO_00oOO.DataTables[text].DataCols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataCol dataCol = enumerator.Current;
					IL_1A3:
					num2 = 22;
					list.Add(dataCol.Name);
					IL_1B4:
					num2 = 23;
				}
				IL_1C0:
				num2 = 24;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_1CE:
				num2 = 25;
				if (!OO_00oOO.DataTables[text].BaseTable.Columns.Contains("_Identify"))
				{
					goto IL_202;
				}
				IL_1F3:
				num2 = 26;
				list.Add("_Identify");
				IL_202:
				num2 = 27;
				result = new TypeConverter.StandardValuesCollection(list);
				IL_20D:
				goto IL_2CF;
				IL_212:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_290:
				goto IL_2C4;
				IL_292:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2A2:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_292;
			}
			IL_2C4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2CF:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}

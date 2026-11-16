using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000053 RID: 83
	internal class O0O00 : UITypeEditor
	{
		// Token: 0x060002DE RID: 734 RVA: 0x00008218 File Offset: 0x00006418
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

		// Token: 0x060002DF RID: 735 RVA: 0x00008240 File Offset: 0x00006440
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
				goto IL_27D;
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
				goto IL_27D;
				IL_59:
				num2 = 8;
				string text = "";
				IL_62:
				num2 = 9;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_23E;
				}
				IL_75:
				num2 = 10;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is ComboboxProperty))
				{
					goto IL_D2;
				}
				IL_8F:
				num2 = 11;
				text = ((ComboboxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				IL_AE:
				num2 = 12;
				a_ = ((ComboboxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataFilter;
				goto IL_23E;
				IL_D2:
				num2 = 14;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is CheckedComboBoxProperty))
				{
					goto IL_12F;
				}
				IL_EC:
				num2 = 15;
				text = ((CheckedComboBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				IL_10B:
				num2 = 16;
				a_ = ((CheckedComboBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataFilter;
				goto IL_23E;
				IL_12F:
				num2 = 18;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is ListBoxProperty))
				{
					goto IL_18C;
				}
				IL_149:
				num2 = 19;
				text = ((ListBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				IL_168:
				num2 = 20;
				a_ = ((ListBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataFilter;
				goto IL_23E;
				IL_18C:
				num2 = 22;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is CheckedListBoxProperty))
				{
					goto IL_1E6;
				}
				IL_1A6:
				num2 = 23;
				text = ((CheckedListBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				IL_1C5:
				num2 = 24;
				a_ = ((CheckedListBoxProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataFilter;
				goto IL_23E;
				IL_1E6:
				num2 = 26;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is DataColumnProperty))
				{
					goto IL_23E;
				}
				IL_200:
				num2 = 27;
				text = ((DataColumnProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataSource;
				IL_21F:
				num2 = 28;
				a_ = ((DataColumnProperty)((o_0oooo_OO)context.Instance).Oo._o.()).DataFilter;
				IL_23E:
				num2 = 29;
				if (Operators.CompareString(text, "", true) != 0 && OO_00oOO.DataTables.Contains(text))
				{
					goto IL_265;
				}
				IL_25E:
				num2 = 30;
				result = value;
				goto IL_27D;
				IL_265:
				num2 = 31;
				result = OO_00oOO.DataTables[text].OOoo__00O_.o_O.(a_, true);
				IL_27D:
				goto IL_34F;
				IL_282:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_310:
				goto IL_344;
				IL_312:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_322:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_312;
			}
			IL_344:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_34F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0400007C RID: 124
		private IWindowsFormsEditorService wfes;
	}
}

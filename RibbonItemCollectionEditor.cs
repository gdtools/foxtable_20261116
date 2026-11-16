using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004CE RID: 1230
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonItemCollectionEditor : UITypeEditor
	{
		// Token: 0x0600515C RID: 20828 RVA: 0x002442C8 File Offset: 0x002424C8
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

		// Token: 0x0600515D RID: 20829 RVA: 0x002442F0 File Offset: 0x002424F0
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			object result;
			if (context == null || context.Instance == null || provider == null)
			{
				result = value;
			}
			else
			{
				this.oo_00OOO_o.0O. = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				Form form = Form.ActiveForm;
				if (form != null && !(form is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000) && !(form is o_\u3002\u3002\u3000\u3000\u3002))
				{
					form = null;
				}
				if (this.oo_00OOO_o.0O. == null)
				{
					result = value;
				}
				else
				{
					if (context.Instance is ContextMenuCollection)
					{
						this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(null, RibbonPaneEnum.Right, form);
						this.oo_00OOO_o.0O..Text = this.oo_00OOO_o.0O..Text + " - 快捷菜单";
					}
					else if (context.Instance is RibbonTabCollection)
					{
						this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(null, RibbonPaneEnum.Left, form);
						this.oo_00OOO_o.0O..Text = this.oo_00OOO_o.0O..Text + " - 功能区";
					}
					else if (context.Instance is RibbonTopTabCollection)
					{
						this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(null, RibbonPaneEnum.Bottom, form);
						this.oo_00OOO_o.0O..Text = this.oo_00OOO_o.0O..Text + " - 功能区组";
					}
					else
					{
						DataRow dataRow = ((RibbonBase)((o_0oooo_OO)context.Instance).Oo._o.()).DataRow;
						RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(dataRow["Type"]);
						if (ribbonItemTypeEnum <= RibbonItemTypeEnum.ComboBox)
						{
							if (ribbonItemTypeEnum != RibbonItemTypeEnum.ApplicationMenu)
							{
								if (ribbonItemTypeEnum != RibbonItemTypeEnum.ComboBox)
								{
									goto IL_27D;
								}
							}
							else
							{
								string name = context.PropertyDescriptor.Name;
								if (Operators.CompareString(name, "Items", true) == 0)
								{
									this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form);
									goto IL_28B;
								}
								if (Operators.CompareString(name, "RightPaneItems", true) == 0)
								{
									this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Right, form);
									goto IL_28B;
								}
								if (Operators.CompareString(name, "BottomPaneItems", true) == 0)
								{
									this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Bottom, form);
									goto IL_28B;
								}
								goto IL_28B;
							}
						}
						else if (ribbonItemTypeEnum != RibbonItemTypeEnum.FontComboBox)
						{
							if (ribbonItemTypeEnum != RibbonItemTypeEnum.Gallery)
							{
								goto IL_27D;
							}
							string name2 = context.PropertyDescriptor.Name;
							if (Operators.CompareString(name2, "Items", true) == 0)
							{
								this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Right, form);
								goto IL_28B;
							}
							if (Operators.CompareString(name2, "MenuItems", true) == 0)
							{
								this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form);
								goto IL_28B;
							}
							goto IL_28B;
						}
						string name3 = context.PropertyDescriptor.Name;
						if (Operators.CompareString(name3, "Items", true) == 0)
						{
							this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form);
							goto IL_28B;
						}
						if (Operators.CompareString(name3, "MenuItems", true) == 0)
						{
							this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Right, form);
							goto IL_28B;
						}
						goto IL_28B;
						IL_27D:
						this.oo_00OOO_o.0O. = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form);
						IL_28B:
						this.oo_00OOO_o.0O..Text = string.Concat(new string[]
						{
							this.oo_00OOO_o.0O..Text,
							" - ",
							((RibbonBase)((o_0oooo_OO)context.Instance).Oo._o.()).Name,
							" - ",
							context.PropertyDescriptor.DisplayName
						});
					}
					if (form != null)
					{
						if (form is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)
						{
							((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)form).ooO.Oo_. = this.oo_00OOO_o.0O.;
						}
						else if (form is o_\u3002\u3002\u3000\u3000\u3002)
						{
							((o_\u3002\u3002\u3000\u3000\u3002)form).oOoo_0O.oo00oO. = this.oo_00OOO_o.0O.;
						}
					}
					this.oo_00OOO_o.0O..Owner = Main.OO_O.o.;
					this.oo_00OOO_o.0O..ShowDialog();
					result = RuntimeHelpers.GetObjectValue(value);
					if (this.oo_00OOO_o.0O. != null && !this.oo_00OOO_o.0O..oO.o00o00Oo_O.)
					{
						this.oo_00OOO_o.0O..Dispose();
						this.oo_00OOO_o.0O. = null;
					}
				}
			}
			return result;
		}

		// Token: 0x04002170 RID: 8560
		private IWindowsFormsEditorService <<EMPTY_NAME>>;

		// Token: 0x04002171 RID: 8561
		private o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 <<EMPTY_NAME>>;
	}
}

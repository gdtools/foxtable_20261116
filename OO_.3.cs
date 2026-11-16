using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200017C RID: 380
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OO_
	{
		// Token: 0x06001229 RID: 4649 RVA: 0x00080595 File Offset: 0x0007E795
		internal OO_(string A_0, Foxtable.WinForm.Form A_1)
		{
			this.o.__o_O. = new Dictionary<string, ToolStrip>();
			this.o.__o_O. = new Stack<OO_.Oo__000>();
			this.O_oOoo._o_oo. = "(default)";
			this.o.__o_O. = A_0;
			this.o.__o_O. = A_1;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000805CC File Offset: 0x0007E7CC
		internal void <<EMPTY_NAME>>()
		{
			if (this.o.__o_O. != null && Operators.CompareString(this.o.__o_O..Trim(), "", true) != 0)
			{
				string[] array = this.o.__o_O..Split(new char[]
				{
					'\f'
				});
				ToolStripItemCollection toolStripItemCollection = null;
				ToolStripItem toolStripItem = null;
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = array[i];
					if (Operators.CompareString(text, "Inner", true) == 0)
					{
						if (toolStripItem != null)
						{
							this.o.__o_O..Push(new OO_.Oo__000(toolStripItem, toolStripItemCollection));
							toolStripItemCollection = ((ToolStripDropDownItem)toolStripItem).DropDownItems;
						}
					}
					else if (Operators.CompareString(text, "Outer", true) == 0)
					{
						if (this.o.__o_O..Count > 0)
						{
							OO_.Oo__000 oo__ = this.o.__o_O..Pop();
							toolStripItem = oo__.o.__o_O.;
							toolStripItemCollection = oo__.o.__o_O.;
						}
					}
					else
					{
						object obj;
						if (text.StartsWith("\t"))
						{
							obj = new FormMenuProperty();
						}
						else
						{
							obj = new FormMenuItemProperty();
						}
						text = text.Trim(new char[]
						{
							'\t'
						});
						o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(obj), text, '\t');
						if (obj is FormMenuProperty)
						{
							FormMenuProperty formMenuProperty = (FormMenuProperty)obj;
							ToolStrip toolStrip = null;
							switch (formMenuProperty.Type)
							{
							case StripTypeEnum2.主菜单:
								toolStrip = new MenuStrip();
								toolStrip.Dock = DockStyle.Top;
								break;
							case StripTypeEnum2.工具栏:
								toolStrip = new ToolStrip();
								break;
							case StripTypeEnum2.状态栏:
								toolStrip = new StatusStrip();
								toolStrip.Dock = DockStyle.Bottom;
								toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
								((StatusStrip)toolStrip).SizingGrip = true;
								break;
							case StripTypeEnum2.快捷菜单:
								toolStrip = new ContextMenuStrip();
								break;
							}
							if (this.o.__o_O. != null)
							{
								this.O_oOoo._o_oo. = this.o.__o_O..MenuTheme;
							}
							if (Operators.CompareString(formMenuProperty.Theme, "(none)", true) == 0 || (Operators.CompareString(formMenuProperty.Theme, "(default)", true) == 0 && Operators.CompareString(this.O_oOoo._o_oo., "(none)", true) == 0))
							{
								toolStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
								toolStrip.Renderer = O_O0OO.o0_OO.000.();
							}
							else if (Operators.CompareString(formMenuProperty.Theme, "(default)", true) != 0)
							{
								Main.OO_O.o..Oo.oOo_o0Oo0.(formMenuProperty.Theme, new object[]
								{
									toolStrip
								});
							}
							else
							{
								Main.OO_O.o..Oo.oOo_o0Oo0.(this.O_oOoo._o_oo., new object[]
								{
									toolStrip
								});
							}
							toolStrip.Name = formMenuProperty.Name;
							toolStrip.ImageScalingSize = formMenuProperty.ImageSize;
							toolStrip.Enabled = formMenuProperty.Enabeld;
							toolStrip.Visible = formMenuProperty.Visible;
							if (formMenuProperty.Type == StripTypeEnum2.工具栏)
							{
								toolStrip.Dock = formMenuProperty.Dock;
							}
							toolStripItemCollection = toolStrip.Items;
							toolStripItem = null;
							this.o.__o_O..Add(toolStrip.Name, toolStrip);
							if (this.o.__o_O. != null)
							{
								toolStrip.ItemClicked += this.o.__o_O..o_O._o_0_o.;
							}
						}
						else
						{
							FormMenuItemProperty formMenuItemProperty = (FormMenuItemProperty)obj;
							ToolStripItem toolStripItem2 = null;
							switch (formMenuItemProperty.Type)
							{
							case StripItemTypeEnum.MenuItem:
							{
								toolStripItem2 = new ToolStripMenuItem();
								ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)toolStripItem2;
								toolStripMenuItem.Checked = formMenuItemProperty.Checked;
								toolStripMenuItem.ShortcutKeys = formMenuItemProperty.ShortcutKeys;
								if (this.o.__o_O. != null)
								{
									((ToolStripDropDownMenu)toolStripMenuItem.DropDown).ItemClicked += this.o.__o_O..o_O._o_0_o.;
								}
								break;
							}
							case StripItemTypeEnum.Button:
								toolStripItem2 = new ToolStripButton();
								((ToolStripButton)toolStripItem2).Checked = formMenuItemProperty.Checked;
								break;
							case StripItemTypeEnum.Label:
								toolStripItem2 = new ToolStripLabel();
								break;
							case StripItemTypeEnum.SplitButton:
								toolStripItem2 = new ToolStripSplitButton();
								if (this.o.__o_O. != null)
								{
									((ToolStripDropDownMenu)((ToolStripSplitButton)toolStripItem2).DropDown).ItemClicked += this.o.__o_O..o_O._o_0_o.;
									((ToolStripDropDownMenu)((ToolStripSplitButton)toolStripItem2).DropDown).Name = formMenuItemProperty.Name;
								}
								break;
							case StripItemTypeEnum.TextBox:
								toolStripItem2 = new ToolStripTextBox();
								break;
							case StripItemTypeEnum.ComboBox:
								toolStripItem2 = new ToolStripComboBox();
								if (Operators.CompareString(formMenuItemProperty.ComboList, "", true) > 0)
								{
									((ToolStripComboBox)toolStripItem2).Items.AddRange(formMenuItemProperty.ComboList.Split(new char[]
									{
										'|'
									}));
								}
								break;
							case StripItemTypeEnum.Separator:
								toolStripItem2 = new ToolStripSeparator();
								break;
							}
							toolStripItem2.Name = formMenuItemProperty.Name;
							toolStripItem2.Alignment = formMenuItemProperty.Alignment;
							toolStripItem2.Enabled = formMenuItemProperty.Enabeld;
							toolStripItem2.Visible = formMenuItemProperty.Visible;
							if (formMenuItemProperty.Type != StripItemTypeEnum.Separator)
							{
								toolStripItem2.Text = formMenuItemProperty.Text;
								toolStripItem2.ToolTipText = formMenuItemProperty.ToolTipText;
								if (Operators.CompareString(formMenuItemProperty.ImageFile, "", true) > 0)
								{
									toolStripItem2.Image = OO_00oOO.GetImage(formMenuItemProperty.ImageFile);
								}
							}
							if (formMenuItemProperty.Type == StripItemTypeEnum.Button || formMenuItemProperty.Type == StripItemTypeEnum.SplitButton)
							{
								if (!formMenuItemProperty.DisplayText)
								{
									toolStripItem2.DisplayStyle = ToolStripItemDisplayStyle.Image;
								}
								else
								{
									toolStripItem2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
								}
								if (formMenuItemProperty.TextPosition == TextPositionEnum.Right)
								{
									toolStripItem2.TextImageRelation = TextImageRelation.ImageBeforeText;
								}
								else
								{
									toolStripItem2.TextImageRelation = TextImageRelation.ImageAboveText;
								}
							}
							if (this.o.__o_O. != null)
							{
								toolStripItem2.MouseEnter += this.o.__o_O..O0O_o.OOOO0o.;
								toolStripItem2.MouseLeave += this.o.__o_O..Oo_o.OO.;
								toolStripItem2.MouseHover += this.o.__o_O..o.0__0_0o.;
							}
							toolStripItemCollection.Add(toolStripItem2);
							toolStripItem = toolStripItem2;
						}
					}
				}
			}
		}

		// Token: 0x040006F1 RID: 1777
		private string <<EMPTY_NAME>>;

		// Token: 0x040006F2 RID: 1778
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x040006F3 RID: 1779
		internal Dictionary<string, ToolStrip> <<EMPTY_NAME>>;

		// Token: 0x040006F4 RID: 1780
		private Stack<OO_.Oo__000> <<EMPTY_NAME>>;

		// Token: 0x040006F5 RID: 1781
		internal string <<EMPTY_NAME>>;

		// Token: 0x0200017D RID: 381
		internal class Oo__000
		{
			// Token: 0x0600122B RID: 4651 RVA: 0x00080B63 File Offset: 0x0007ED63
			internal Oo__000(ToolStripItem A_0, ToolStripItemCollection A_1)
			{
				this.o.__o_O. = A_0;
				this.o.__o_O. = A_1;
			}

			// Token: 0x040006F6 RID: 1782
			internal ToolStripItemCollection <<EMPTY_NAME>>;

			// Token: 0x040006F7 RID: 1783
			internal ToolStripItem <<EMPTY_NAME>>;
		}
	}
}

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable.WinForm
{
	// Token: 0x02000180 RID: 384
	[ComVisible(true)]
	[oO0oooo("3220")]
	public class StripItem
	{
		// Token: 0x06001242 RID: 4674 RVA: 0x00080FD3 File Offset: 0x0007F1D3
		internal StripItem(ToolStripItem A_0, Form A_1)
		{
			this.oO.ooo. = A_0;
			this.oO.ooo. = A_1;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00080FE9 File Offset: 0x0007F1E9
		public string Name
		{
			get
			{
				return this.oO.ooo..Name;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00080FF6 File Offset: 0x0007F1F6
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00081003 File Offset: 0x0007F203
		public string Text
		{
			get
			{
				return this.oO.ooo..Text;
			}
			set
			{
				this.oO.ooo..Text = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00081014 File Offset: 0x0007F214
		public StripItem ParentItem
		{
			get
			{
				StripItem result;
				if (this.oO.ooo..OwnerItem != null)
				{
					result = new StripItem(this.oO.ooo..OwnerItem, this.oO.ooo.);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x0008104A File Offset: 0x0007F24A
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x0008105A File Offset: 0x0007F25A
		public bool DisplayText
		{
			get
			{
				return this.oO.ooo..DisplayStyle == ToolStripItemDisplayStyle.ImageAndText;
			}
			set
			{
				if (value)
				{
					this.oO.ooo..DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
					return;
				}
				this.oO.ooo..DisplayStyle = ToolStripItemDisplayStyle.Image;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00081078 File Offset: 0x0007F278
		public int Index
		{
			get
			{
				int result;
				if (this.oO.ooo..Owner != null)
				{
					result = this.oO.ooo..Owner.Items.IndexOf(this.oO.ooo.);
				}
				else
				{
					result = -1;
				}
				return result;
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000810B3 File Offset: 0x0007F2B3
		public void PerformClick()
		{
			this.oO.ooo..PerformClick();
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000810C0 File Offset: 0x0007F2C0
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x000810E2 File Offset: 0x0007F2E2
		public TextPositionEnum TextPosition
		{
			get
			{
				TextPositionEnum result;
				if (this.oO.ooo..TextImageRelation == TextImageRelation.ImageBeforeText)
				{
					result = TextPositionEnum.Right;
				}
				else
				{
					result = TextPositionEnum.Bottom;
				}
				return result;
			}
			set
			{
				if (value == TextPositionEnum.Right)
				{
					this.oO.ooo..TextImageRelation = TextImageRelation.ImageBeforeText;
					return;
				}
				this.oO.ooo..TextImageRelation = TextImageRelation.ImageAboveText;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00081100 File Offset: 0x0007F300
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x00081122 File Offset: 0x0007F322
		public bool DockToRight
		{
			get
			{
				return this.oO.ooo..Alignment == ToolStripItemAlignment.Right;
			}
			set
			{
				if (value)
				{
					this.oO.ooo..Alignment = ToolStripItemAlignment.Right;
					return;
				}
				this.oO.ooo..Alignment = ToolStripItemAlignment.Left;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00081140 File Offset: 0x0007F340
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x0008114D File Offset: 0x0007F34D
		public string ToolTip
		{
			get
			{
				return this.oO.ooo..ToolTipText;
			}
			set
			{
				this.oO.ooo..ToolTipText = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0008115B File Offset: 0x0007F35B
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x00081168 File Offset: 0x0007F368
		public bool Visible
		{
			get
			{
				return this.oO.ooo..Visible;
			}
			set
			{
				this.oO.ooo..Visible = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00081176 File Offset: 0x0007F376
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x00081183 File Offset: 0x0007F383
		public bool Enabled
		{
			get
			{
				return this.oO.ooo..Enabled;
			}
			set
			{
				this.oO.ooo..Enabled = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00081194 File Offset: 0x0007F394
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x000811C4 File Offset: 0x0007F3C4
		public Keys ShortcutKeys
		{
			get
			{
				Keys result;
				if (this.oO.ooo. is ToolStripMenuItem)
				{
					result = ((ToolStripMenuItem)this.oO.ooo.).ShortcutKeys;
				}
				else
				{
					result = Keys.None;
				}
				return result;
			}
			set
			{
				if (this.oO.ooo. is ToolStripMenuItem)
				{
					((ToolStripMenuItem)this.oO.ooo.).ShortcutKeys = value;
				}
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000811E4 File Offset: 0x0007F3E4
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x00081230 File Offset: 0x0007F430
		public bool Checked
		{
			get
			{
				bool @checked;
				if (this.oO.ooo. is ToolStripMenuItem)
				{
					@checked = ((ToolStripMenuItem)this.oO.ooo.).Checked;
				}
				else if (this.oO.ooo. is ToolStripButton)
				{
					@checked = ((ToolStripButton)this.oO.ooo.).Checked;
				}
				return @checked;
			}
			set
			{
				if (this.oO.ooo. is ToolStripMenuItem)
				{
					((ToolStripMenuItem)this.oO.ooo.).Checked = value;
					return;
				}
				if (this.oO.ooo. is ToolStripButton)
				{
					((ToolStripButton)this.oO.ooo.).Checked = value;
				}
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00081270 File Offset: 0x0007F470
		public StripItemCollection Items
		{
			get
			{
				StripItemCollection result;
				if (this.oO.ooo. is ToolStripDropDownItem)
				{
					result = new StripItemCollection(((ToolStripDropDownItem)this.oO.ooo.).DropDownItems, this.oO.ooo.);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x000812AB File Offset: 0x0007F4AB
		public object BaseControl
		{
			get
			{
				return this.oO.ooo.;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000812B3 File Offset: 0x0007F4B3
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x000812C0 File Offset: 0x0007F4C0
		public Image Image
		{
			get
			{
				return this.oO.ooo..Image;
			}
			set
			{
				this.oO.ooo..Image = value;
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000812D0 File Offset: 0x0007F4D0
		public void HideDropDown()
		{
			if (this.oO.ooo. is ToolStripDropDownItem)
			{
				((ToolStripDropDownItem)this.oO.ooo.).HideDropDown();
			}
			if (this.oO.ooo..IsOnDropDown)
			{
				ToolStripItem ownerItem = this.oO.ooo.;
				while (ownerItem.IsOnDropDown)
				{
					if (ownerItem.OwnerItem != null)
					{
						if (!(ownerItem.OwnerItem is ToolStripDropDownItem))
						{
							break;
						}
						ownerItem = ownerItem.OwnerItem;
						((ToolStripDropDownItem)ownerItem).HideDropDown();
					}
					else
					{
						if (ownerItem.Owner != null && ownerItem.Owner is ContextMenuStrip)
						{
							((ContextMenuStrip)ownerItem.Owner).Hide();
							return;
						}
						break;
					}
				}
			}
		}

		// Token: 0x040006FE RID: 1790
		private ToolStripItem <<EMPTY_NAME>>;

		// Token: 0x040006FF RID: 1791
		private Form <<EMPTY_NAME>>;
	}
}

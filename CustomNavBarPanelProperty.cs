using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000411 RID: 1041
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CustomNavBarPanelProperty
	{
		// Token: 0x06004531 RID: 17713 RVA: 0x001F1666 File Offset: 0x001EF866
		internal CustomNavBarPanelProperty(oO_0 A_0)
		{
			this.OO_o_O_.o. = A_0;
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06004532 RID: 17714 RVA: 0x001F1675 File Offset: 0x001EF875
		// (set) Token: 0x06004533 RID: 17715 RVA: 0x001F1682 File Offset: 0x001EF882
		[DefaultValue("")]
		public string Name
		{
			get
			{
				return this.OO_o_O_.o..Name;
			}
			set
			{
				this.OO_o_O_.o..Name = value;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x001F1690 File Offset: 0x001EF890
		// (set) Token: 0x06004535 RID: 17717 RVA: 0x001F16A2 File Offset: 0x001EF8A2
		[DefaultValue("")]
		public string HeaderText
		{
			get
			{
				return this.OO_o_O_.o..Button.PanelHeader;
			}
			set
			{
				this.OO_o_O_.o..Button.PanelHeader = value;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x001F16B5 File Offset: 0x001EF8B5
		// (set) Token: 0x06004537 RID: 17719 RVA: 0x001F16C7 File Offset: 0x001EF8C7
		public string ButtonText
		{
			get
			{
				return this.OO_o_O_.o..Button.Text;
			}
			set
			{
				this.OO_o_O_.o..Button.Text = value;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x001F16DA File Offset: 0x001EF8DA
		// (set) Token: 0x06004539 RID: 17721 RVA: 0x001F16E7 File Offset: 0x001EF8E7
		public string ButtonImageFile
		{
			get
			{
				return this.OO_o_O_.o..ImageFile;
			}
			set
			{
				this.OO_o_O_.o..ImageFile = value;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x001F16F5 File Offset: 0x001EF8F5
		// (set) Token: 0x0600453B RID: 17723 RVA: 0x001F1702 File Offset: 0x001EF902
		public string ButtonSmallImageFile
		{
			get
			{
				return this.OO_o_O_.o..oOo_._0__0o_0o.();
			}
			set
			{
				this.OO_o_O_.o..oOo_._0__0o_0o.(value);
			}
		}

		// Token: 0x04001C1D RID: 7197
		private oO_0 <<EMPTY_NAME>>;
	}
}

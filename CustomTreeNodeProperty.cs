using System;
using System.ComponentModel;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000412 RID: 1042
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CustomTreeNodeProperty
	{
		// Token: 0x0600453C RID: 17724 RVA: 0x001F1710 File Offset: 0x001EF910
		internal CustomTreeNodeProperty(O_o__00Ooo A_0)
		{
			this.o0Ooo_O0oo.O__. = A_0;
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x001F171F File Offset: 0x001EF91F
		// (set) Token: 0x0600453E RID: 17726 RVA: 0x001F172C File Offset: 0x001EF92C
		[DefaultValue("")]
		public string Name
		{
			get
			{
				return this.o0Ooo_O0oo.O__..Name;
			}
			set
			{
				this.o0Ooo_O0oo.O__..Name = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x001F173C File Offset: 0x001EF93C
		// (set) Token: 0x06004540 RID: 17728 RVA: 0x001F1762 File Offset: 0x001EF962
		[DefaultValue("")]
		public string Text
		{
			get
			{
				string result;
				if (this.o0Ooo_O0oo.O__. == null)
				{
					result = null;
				}
				else
				{
					result = this.o0Ooo_O0oo.O__..Text;
				}
				return result;
			}
			set
			{
				if (this.o0Ooo_O0oo.O__. != null)
				{
					this.o0Ooo_O0oo.O__..Text = value;
				}
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x001F1778 File Offset: 0x001EF978
		// (set) Token: 0x06004542 RID: 17730 RVA: 0x001F1785 File Offset: 0x001EF985
		[DefaultValue("")]
		public string Tooltip
		{
			get
			{
				return this.o0Ooo_O0oo.O__..ToolTipText;
			}
			set
			{
				this.o0Ooo_O0oo.O__..ToolTipText = value;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x001F1793 File Offset: 0x001EF993
		// (set) Token: 0x06004544 RID: 17732 RVA: 0x001F17A0 File Offset: 0x001EF9A0
		public string ImageFile
		{
			get
			{
				return this.o0Ooo_O0oo.O__..ImageFile;
			}
			set
			{
				this.o0Ooo_O0oo.O__..ImageFile = value;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x001F17AE File Offset: 0x001EF9AE
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x001F17BB File Offset: 0x001EF9BB
		public string NodeSelectedImageFile
		{
			get
			{
				return this.o0Ooo_O0oo.O__..o0Ooo_O0oo.O__.();
			}
			set
			{
				this.o0Ooo_O0oo.O__..O.OOO_.(value);
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x001F17C9 File Offset: 0x001EF9C9
		// (set) Token: 0x06004548 RID: 17736 RVA: 0x001F17D6 File Offset: 0x001EF9D6
		public Color Backcolor
		{
			get
			{
				return this.o0Ooo_O0oo.O__..BackColor;
			}
			set
			{
				if (Operators.CompareString(value.Name, "0", true) != 0)
				{
					this.o0Ooo_O0oo.O__..BackColor = value;
				}
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x001F17F8 File Offset: 0x001EF9F8
		// (set) Token: 0x0600454A RID: 17738 RVA: 0x001F1805 File Offset: 0x001EFA05
		public Color ForeColor
		{
			get
			{
				return this.o0Ooo_O0oo.O__..ForeColor;
			}
			set
			{
				if (Operators.CompareString(value.Name, "0", true) != 0)
				{
					this.o0Ooo_O0oo.O__..ForeColor = value;
				}
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x001F1828 File Offset: 0x001EFA28
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x001F185C File Offset: 0x001EFA5C
		[DefaultValue("")]
		public string Tag
		{
			get
			{
				string result;
				if (this.o0Ooo_O0oo.O__..Tag == null)
				{
					result = "";
				}
				else
				{
					result = this.o0Ooo_O0oo.O__..Tag.ToString();
				}
				return result;
			}
			set
			{
				this.o0Ooo_O0oo.O__..Tag = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x001F186A File Offset: 0x001EFA6A
		// (set) Token: 0x0600454E RID: 17742 RVA: 0x001F1877 File Offset: 0x001EFA77
		[DefaultValue(false)]
		public bool Checked
		{
			get
			{
				return this.o0Ooo_O0oo.O__..Checked;
			}
			set
			{
				this.o0Ooo_O0oo.O__..Checked = value;
			}
		}

		// Token: 0x04001C1E RID: 7198
		internal O_o__00Ooo <<EMPTY_NAME>>;
	}
}

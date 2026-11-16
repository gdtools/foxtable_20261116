using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002C2 RID: 706
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class PropertyBase
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x0011AEED File Offset: 0x001190ED
		internal PropertyBase(ControlHolder A_0)
		{
			this.o_0_.Oo. = A_0;
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x0011AEFC File Offset: 0x001190FC
		internal ControlTypeEnum Type
		{
			get
			{
				return this.o_0_.Oo..ControlType;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x0011AF09 File Offset: 0x00119109
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x0011AF18 File Offset: 0x00119118
		[Category("基本")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("名称")]
		[MergableProperty(false)]
		public virtual string Name
		{
			get
			{
				return this.o_0_.Oo..Name;
			}
			set
			{
				if (Operators.CompareString(value, this.Name, true) != 0)
				{
					if (this.o_0_.Oo..FindForm() != null && Operators.CompareString(this.o_0_.Oo..Name, "copyingtemp", true) != 0 && ((o\u3002\u3002\u3000\u3000\u3002)this.o_0_.Oo..FindForm()).OO__oo0.0O___.(this.o_0_.Oo..FindForm().Controls, value))
					{
						MessageBox.Show("无效属性值，同名的对象已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
					this.o_0_.Oo..Name = value;
					this.o_0_.Oo..DataRow["Name"] = value;
				}
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0011AFBA File Offset: 0x001191BA
		[Browsable(false)]
		internal ControlHolder Holder
		{
			get
			{
				return this.o_0_.Oo.;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x0011AFC2 File Offset: 0x001191C2
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x0011AFCF File Offset: 0x001191CF
		[Browsable(false)]
		[OooO0(true)]
		public Size Size
		{
			get
			{
				return this.o_0_.Oo..Size;
			}
			set
			{
				this.o_0_.Oo..Size = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0011AFDD File Offset: 0x001191DD
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x0011AFEA File Offset: 0x001191EA
		[Browsable(false)]
		[OooO0(true)]
		public Point Location
		{
			get
			{
				return this.o_0_.Oo..Location;
			}
			set
			{
				this.o_0_.Oo..Location = value;
			}
		}

		// Token: 0x04000FF1 RID: 4081
		internal ControlHolder <<EMPTY_NAME>>;
	}
}

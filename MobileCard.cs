using System;
using System.ComponentModel;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200023D RID: 573
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MobileCard
	{
		// Token: 0x06001B58 RID: 7000 RVA: 0x000C03F8 File Offset: 0x000BE5F8
		public MobileCard()
		{
			this.oO.0OO_OoOoO0. = "";
			this.o.O0OO0__0o. = "";
			this.o0__0o__.o_. = "";
			this.o0_O_0O.OOoo. = "";
			this.O_0._OOO__ooO. = "";
			this.o_OOO.0O__. = "";
			this.OOO00O0Oo0.oo. = "";
			this.O_O0oo.O. = "";
			this.Oo000.Oooo. = "";
			this.o0_.oooO0O. = "";
			this.o0_o.O_0o0O_. = "";
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x000C0484 File Offset: 0x000BE684
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x000C048C File Offset: 0x000BE68C
		[DisplayName("姓名")]
		[O_Oo00Oo000O0(1.0)]
		public string N
		{
			get
			{
				return this.oO.0OO_OoOoO0.;
			}
			set
			{
				this.oO.0OO_OoOoO0. = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x000C0495 File Offset: 0x000BE695
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x000C049D File Offset: 0x000BE69D
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("职务")]
		public string TIL
		{
			get
			{
				return this.o.O0OO0__0o.;
			}
			set
			{
				this.o.O0OO0__0o. = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000C04A6 File Offset: 0x000BE6A6
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x000C04AE File Offset: 0x000BE6AE
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("部门")]
		public string DIV
		{
			get
			{
				return this.o0__0o__.o_.;
			}
			set
			{
				this.o0__0o__.o_. = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x000C04B7 File Offset: 0x000BE6B7
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x000C04BF File Offset: 0x000BE6BF
		[DisplayName("公司")]
		[O_Oo00Oo000O0(4.0)]
		public string COR
		{
			get
			{
				return this.o0_O_0O.OOoo.;
			}
			set
			{
				this.o0_O_0O.OOoo. = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x000C04C8 File Offset: 0x000BE6C8
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x000C04D0 File Offset: 0x000BE6D0
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("地址")]
		public string ADR
		{
			get
			{
				return this.O_0._OOO__ooO.;
			}
			set
			{
				this.O_0._OOO__ooO. = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x000C04D9 File Offset: 0x000BE6D9
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x000C04E1 File Offset: 0x000BE6E1
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("邮编")]
		public string ZIP
		{
			get
			{
				return this.o_OOO.0O__.;
			}
			set
			{
				this.o_OOO.0O__. = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x000C04EA File Offset: 0x000BE6EA
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x000C04F2 File Offset: 0x000BE6F2
		[DisplayName("电话")]
		[O_Oo00Oo000O0(7.0)]
		public string TEL
		{
			get
			{
				return this.OOO00O0Oo0.oo.;
			}
			set
			{
				this.OOO00O0Oo0.oo. = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x000C04FB File Offset: 0x000BE6FB
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x000C0503 File Offset: 0x000BE703
		[DisplayName("传真")]
		[O_Oo00Oo000O0(8.0)]
		public string FAX
		{
			get
			{
				return this.O_O0oo.O.;
			}
			set
			{
				this.O_O0oo.O. = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000C050C File Offset: 0x000BE70C
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x000C0514 File Offset: 0x000BE714
		[DisplayName("手机")]
		[O_Oo00Oo000O0(9.0)]
		public string M
		{
			get
			{
				return this.Oo000.Oooo.;
			}
			set
			{
				this.Oo000.Oooo. = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000C051D File Offset: 0x000BE71D
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x000C0525 File Offset: 0x000BE725
		[DisplayName("邮箱")]
		[O_Oo00Oo000O0(10.0)]
		public string EM
		{
			get
			{
				return this.o0_.oooO0O.;
			}
			set
			{
				this.o0_.oooO0O. = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x000C052E File Offset: 0x000BE72E
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x000C0536 File Offset: 0x000BE736
		[DisplayName("网址")]
		[O_Oo00Oo000O0(12.0)]
		public string URL
		{
			get
			{
				return this.o0_o.O_0o0O_.;
			}
			set
			{
				this.o0_o.O_0o0O_. = value;
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000C0540 File Offset: 0x000BE740
		public string GetCardInfo()
		{
			string text = "\u0001\u0010CARD:";
			foreach (PropertyInfo propertyInfo in base.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				string text2 = Conversions.ToString(propertyInfo.GetValue(this, null));
				if (Operators.CompareString(text2, "", true) > 0)
				{
					text = string.Concat(new string[]
					{
						text,
						propertyInfo.Name,
						":",
						text2,
						";"
					});
				}
			}
			return text + ";";
		}

		// Token: 0x04000B83 RID: 2947
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B84 RID: 2948
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B85 RID: 2949
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B86 RID: 2950
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B87 RID: 2951
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B88 RID: 2952
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B89 RID: 2953
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B8A RID: 2954
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B8B RID: 2955
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B8C RID: 2956
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B8D RID: 2957
		private string <<EMPTY_NAME>>;
	}
}

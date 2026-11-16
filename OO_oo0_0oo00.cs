using System;
using System.Runtime.CompilerServices;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200044F RID: 1103
	internal class OO_oo0_0oo00
	{
		// Token: 0x06004A48 RID: 19016 RVA: 0x0020DD44 File Offset: 0x0020BF44
		public OO_oo0_0oo00()
		{
			this.o00O.o0oo. = 1;
			this.oo._Oo0. = o_o_O0OO_0__.Oo.O_Oo00O.();
			this.oo.o0oOoooo. = o_o_O0OO_0__.ooO_OO.oOoo.();
			this.oo0_._O. = o_o_O0OO_0__.oOo.Ooo.();
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x0020DD74 File Offset: 0x0020BF74
		private DateTime <<EMPTY_NAME>>()
		{
			return this.O.O_.;
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x0020DD7C File Offset: 0x0020BF7C
		private void <<EMPTY_NAME>>(DateTime A_0)
		{
			this.O.O_. = A_0;
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x0020DD85 File Offset: 0x0020BF85
		private int <<EMPTY_NAME>>()
		{
			return this.O.O_.;
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x0020DD8D File Offset: 0x0020BF8D
		private void <<EMPTY_NAME>>(int A_0)
		{
			this.O.O_. = A_0;
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x0020DD98 File Offset: 0x0020BF98
		private void <<EMPTY_NAME>>()
		{
			if (DateTime.Compare(DateTime.Today, this.Oo_.___0.()) != 0)
			{
				this.O.O_.(this.Oo_.___0.() + this.o00O.o0oo.);
				c.OOOOO.o.().Registry.SetValue(this.oo0_._O., this.oo._Oo0., O00.ooo000o_0.00o0.(DateTime.Today.ToString(), "me", "this"));
				c.OOOOO.o.().Registry.SetValue(this.oo0_._O., this.oo.o0oOoooo., O00.ooo000o_0.00o0.(this.Oo_.___0.().ToString(), "me", "this"));
			}
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x0020DE3C File Offset: 0x0020C03C
		private void <<EMPTY_NAME>>()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(this.oo0_._O., this.oo._Oo0., ""));
			if (objectValue != null)
			{
				string s = O00.oO_.0o_oo_0O_.(objectValue.ToString(), "me", "this").ToString();
				DateTime a_ = this.Oo_.___0.();
				DateTime.TryParse(s, out a_);
				this.O.O_.(a_);
			}
			objectValue = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(this.oo0_._O., this.oo.o0oOoooo., 1));
			if (objectValue != null)
			{
				string s2 = O00.oO_.0o_oo_0O_.(objectValue.ToString(), "me", "this").ToString();
				int a_2 = this.Oo_.___0.();
				int.TryParse(s2, out a_2);
				this.O.O_.(a_2);
			}
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x0020DEFC File Offset: 0x0020C0FC
		internal int <<EMPTY_NAME>>()
		{
			this.O.O_.();
			this.o00O.o0oo.();
			if (this.Oo_.___0.() > 60)
			{
				O_O0OO.O_O.OOO_o.(true);
			}
			return this.Oo_.___0.();
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x0020DF20 File Offset: 0x0020C120
		internal bool <<EMPTY_NAME>>()
		{
			return this.O.O_.();
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x0020DF28 File Offset: 0x0020C128
		private bool <<EMPTY_NAME>>()
		{
			int num;
			bool result;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = o_o_O0OO_0__.O0_O_o.o_.();
				IL_10:
				num2 = 3;
				if (Operators.CompareString(text, "", true) != 0)
				{
					goto IL_27;
				}
				IL_21:
				num2 = 4;
				result = false;
				goto IL_72;
				IL_27:
				num2 = 5;
				string s = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(0, 4);
				IL_37:
				num2 = 6;
				string s2 = text.Substring(0, 4);
				IL_44:
				num2 = 7;
				int num3;
				int.TryParse(s, out num3);
				IL_50:
				num2 = 8;
				int num4;
				int.TryParse(s2, out num4);
				IL_5C:
				num2 = 9;
				result = (num4 == (num3 + 670673) % 10000);
				IL_72:
				goto IL_E9;
				IL_74:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_AA:
				goto IL_DE;
				IL_AC:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_BC:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_AC;
			}
			IL_DE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_E9:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04001E2A RID: 7722
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04001E2B RID: 7723
		private int <<EMPTY_NAME>>;

		// Token: 0x04001E2C RID: 7724
		private int <<EMPTY_NAME>>;

		// Token: 0x04001E2D RID: 7725
		private string <<EMPTY_NAME>>;

		// Token: 0x04001E2E RID: 7726
		private string <<EMPTY_NAME>>;

		// Token: 0x04001E2F RID: 7727
		private string <<EMPTY_NAME>>;
	}
}

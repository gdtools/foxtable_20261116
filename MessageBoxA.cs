using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x0200011A RID: 282
	public class MessageBoxA
	{
		// Token: 0x06000EC5 RID: 3781 RVA: 0x00075664 File Offset: 0x00073864
		public static Task<DialogResult> Show(params object[] args)
		{
			MessageBoxA.oO__O oO__O = default(MessageBoxA.oO__O);
			oO__O.Ooo_Oo_0O0o.0_. = args;
			oO__O.Ooo_Oo_0O0o.0_. = -1;
			oO__O.Ooo_Oo_0O0o.0_. = AsyncTaskMethodBuilder<DialogResult>.Create();
			oO__O.Ooo_Oo_0O0o.0_..Start<MessageBoxA.oO__O>(ref oO__O);
			return oO__O.Ooo_Oo_0O0o.0_..Task;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000756B0 File Offset: 0x000738B0
		private static DialogResult <<EMPTY_NAME>>(params object[] A_0)
		{
			DialogResult result;
			if (A_0.Length == 1)
			{
				result = MessageBox.Show(Conversions.ToString(A_0[0]));
			}
			else if (A_0.Length == 2)
			{
				result = MessageBox.Show(Conversions.ToString(A_0[0]), Conversions.ToString(A_0[1]));
			}
			else if (A_0.Length == 3)
			{
				MessageBoxButtons buttons = (MessageBoxButtons)Conversions.ToInteger(A_0[2]);
				result = MessageBox.Show(Conversions.ToString(A_0[0]), Conversions.ToString(A_0[1]), buttons);
			}
			else if (A_0.Length == 4)
			{
				MessageBoxButtons buttons2 = (MessageBoxButtons)Conversions.ToInteger(A_0[2]);
				MessageBoxIcon icon = (MessageBoxIcon)Conversions.ToInteger(A_0[3]);
				result = MessageBox.Show(Conversions.ToString(A_0[0]), Conversions.ToString(A_0[1]), buttons2, icon);
			}
			return result;
		}

		// Token: 0x0200011B RID: 283
		[CompilerGenerated]
		internal sealed class O_0o_0_0O
		{
			// Token: 0x06000EC8 RID: 3784 RVA: 0x00075752 File Offset: 0x00073952
			internal void <<EMPTY_NAME>>()
			{
				this.o.o_oo0OoO. = MessageBoxA.o.o_oo0OoO.(this.o.o_oo0OoO..o.o_oo0OoO.);
			}

			// Token: 0x040005C6 RID: 1478
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005C7 RID: 1479
			public MessageBoxA.O00oo_oO_oO <<EMPTY_NAME>>;
		}

		// Token: 0x0200011C RID: 284
		[CompilerGenerated]
		internal sealed class O00oo_oO_oO
		{
			// Token: 0x06000ECA RID: 3786 RVA: 0x00075774 File Offset: 0x00073974
			internal DialogResult <<EMPTY_NAME>>()
			{
				MessageBoxA.O_0o_0_0O o_0o_0_0O = new MessageBoxA.O_0o_0_0O();
				o_0o_0_0O.o.o_oo0OoO. = this;
				o_0o_0_0O.o.o_oo0OoO. = DialogResult.Cancel;
				if (OO_00oOO.BaseMainForm != null)
				{
					OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(o_0o_0_0O.o.o_oo0OoO.));
				}
				return o_0o_0_0O.o.o_oo0OoO.;
			}

			// Token: 0x040005C8 RID: 1480
			public object[] <<EMPTY_NAME>>;
		}
	}
}

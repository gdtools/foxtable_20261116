using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000288 RID: 648
	internal class O_0O_
	{
		// Token: 0x06002070 RID: 8304 RVA: 0x000E103D File Offset: 0x000DF23D
		internal O_0O_(DataRow A_0)
		{
			this.oooO__O_0o_.o_. = A_0;
			this.oooO__O_0o_.o_. = new OOOO(A_0);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000E1058 File Offset: 0x000DF258
		internal OOOO <<EMPTY_NAME>>()
		{
			return this.oooO__O_0o_.o_.;
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x000E1060 File Offset: 0x000DF260
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x000E1078 File Offset: 0x000DF278
		internal string Name
		{
			get
			{
				return Conversions.ToString(this.oooO__O_0o_.o_.["TableName"]);
			}
			set
			{
				if (o_O_o_oOoo__.O_o_._o0.(value))
				{
					foreach (DataRow dataRow in this.oooO__O_0o_.o_..Table.Select("", "", DataViewRowState.CurrentRows))
					{
						if (dataRow != this.oooO__O_0o_.o_. && Operators.CompareString(Conversions.ToString(this.oooO__O_0o_.o_.["TableName"]), Conversions.ToString(dataRow["TableName"]), true) == 0)
						{
							MessageBox.Show("表[" + value + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
					}
					this.oooO__O_0o_.o_.["TableName"] = value;
				}
			}
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000E1125 File Offset: 0x000DF325
		internal string <<EMPTY_NAME>>()
		{
			return Conversions.ToString(this.oooO__O_0o_.o_.["TableCaption"]);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000E113C File Offset: 0x000DF33C
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.oooO__O_0o_.o_.["TableCaption"] = A_0;
		}

		// Token: 0x04000D9A RID: 3482
		private OOOO <<EMPTY_NAME>>;

		// Token: 0x04000D9B RID: 3483
		private DataRow <<EMPTY_NAME>>;
	}
}

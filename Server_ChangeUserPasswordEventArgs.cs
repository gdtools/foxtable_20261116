using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000194 RID: 404
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Server_ChangeUserPasswordEventArgs
	{
		// Token: 0x06001320 RID: 4896 RVA: 0x00083D94 File Offset: 0x00081F94
		internal Server_ChangeUserPasswordEventArgs(string A_0, IMServer A_1, string A_2, string A_3, oO__oO_0_O A_4)
		{
			this.O0_00._0o0. = A_0;
			this.O0_00._0o0. = A_1;
			this.oo00.o_. = A_2;
			this.o_O0_o.OO00oO. = A_3;
			this.O0_00._0o0. = A_4;
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x00083DC1 File Offset: 0x00081FC1
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x00083DC9 File Offset: 0x00081FC9
		public bool AsyncExecute
		{
			get
			{
				return this.O0_00._0o0.;
			}
			set
			{
				this.O0_00._0o0. = true;
			}
		}

		/// <summary>
		/// 字符型，返回用户名
		/// </summary>
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x00083DD2 File Offset: 0x00081FD2
		public string UserName
		{
			get
			{
				return this.O0_00._0o0.;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x00083DDA File Offset: 0x00081FDA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMServer Server
		{
			get
			{
				return this.O0_00._0o0.;
			}
		}

		/// <summary>
		/// 原密码
		/// </summary>
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x00083DE2 File Offset: 0x00081FE2
		public string OldPassword
		{
			get
			{
				return this.oo00.o_.;
			}
		}

		/// <summary>
		/// 新密码
		/// </summary>
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x00083DEA File Offset: 0x00081FEA
		public string NewPassword
		{
			get
			{
				return this.o_O0_o.OO00oO.;
			}
		}

		/// <summary>
		/// 字符型，返回给用户的信息
		/// </summary>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x00083DF2 File Offset: 0x00081FF2
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x00083DFA File Offset: 0x00081FFA
		public string ReturnMessage
		{
			get
			{
				return this.o.0OOoO0.;
			}
			set
			{
				this.o.0OOoO0. = value;
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00083E03 File Offset: 0x00082003
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.o.0OOoO0., "", true) > 0)
			{
				this.O0_00._0o0..O0o_.Oo0oo.(this.O0_00._0o0..Oo0oo._.(), this.ReturnMessage);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x00083E38 File Offset: 0x00082038
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Handled
		{
			set
			{
				if (value)
				{
					o_OOO_o0_ method = new o_OOO_o0_(this.ooO.o_Oo.);
					if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
					{
						OO_00oOO.BaseMainForm.Invoke(method);
					}
				}
			}
		}

		// Token: 0x0400076D RID: 1901
		private string <<EMPTY_NAME>>;

		// Token: 0x0400076E RID: 1902
		private IMServer <<EMPTY_NAME>>;

		// Token: 0x0400076F RID: 1903
		private string <<EMPTY_NAME>>;

		// Token: 0x04000770 RID: 1904
		private string <<EMPTY_NAME>>;

		// Token: 0x04000771 RID: 1905
		private string <<EMPTY_NAME>>;

		// Token: 0x04000772 RID: 1906
		private oO__oO_0_O <<EMPTY_NAME>>;

		// Token: 0x04000773 RID: 1907
		private bool <<EMPTY_NAME>>;
	}
}

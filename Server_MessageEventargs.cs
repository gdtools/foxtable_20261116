using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001C0 RID: 448
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Server_MessageEventargs
	{
		// Token: 0x060015B9 RID: 5561 RVA: 0x00099339 File Offset: 0x00097539
		internal Server_MessageEventargs(IMServer A_0, string A_1, string A_2, oO__oO_0_O A_3, string[] A_4)
		{
			this.o__.O0_0. = A_0;
			this.o__.O0_0. = A_1;
			this.O0_0OO00ooO.0. = A_2;
			this.o__.O0_0. = A_3;
			this.o__.O0_0. = A_4;
		}

		/// <summary>
		/// 字符型，返回用户名
		/// </summary>
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00099366 File Offset: 0x00097566
		public string UserName
		{
			get
			{
				return this.o__.O0_0.;
			}
		}

		/// <summary>
		/// 字符型，返回消息内容
		/// </summary>
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0009936E File Offset: 0x0009756E
		public string Message
		{
			get
			{
				return this.O0_0OO00ooO.0.;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00099376 File Offset: 0x00097576
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMServer Server
		{
			get
			{
				return this.o__.O0_0.;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0009937E File Offset: 0x0009757E
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x00099386 File Offset: 0x00097586
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AsyncExecute
		{
			get
			{
				return this.o__.O0_0.;
			}
			set
			{
				this.o__.O0_0. = true;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x00099390 File Offset: 0x00097590
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Handled
		{
			set
			{
				if (value)
				{
					o_OOO_o0_ method = new o_OOO_o0_(this.O0_00._0o0.);
					if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
					{
						OO_00oOO.BaseMainForm.Invoke(method);
					}
				}
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000993CC File Offset: 0x000975CC
		private void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.ReturnValue, "", true) > 0)
			{
				string a_ = "$\v\v" + this.ReturnValue + "\v" + this.o__.O0_0.[3];
				this.o__.O0_0..O0o_.Oo0oo.(this.o__.O0_0..Oo0oo._.(), a_);
			}
		}

		/// <summary>
		/// 字符型，用于设置需要给用户返回的信息
		/// </summary>
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00099422 File Offset: 0x00097622
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x0009942A File Offset: 0x0009762A
		public string ReturnValue
		{
			get
			{
				return this.OOO.o0_o.;
			}
			set
			{
				this.OOO.o0_o. = value;
			}
		}

		// Token: 0x0400087B RID: 2171
		private IMServer <<EMPTY_NAME>>;

		// Token: 0x0400087C RID: 2172
		private string <<EMPTY_NAME>>;

		// Token: 0x0400087D RID: 2173
		private string <<EMPTY_NAME>>;

		// Token: 0x0400087E RID: 2174
		private string <<EMPTY_NAME>>;

		// Token: 0x0400087F RID: 2175
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000880 RID: 2176
		private oO__oO_0_O <<EMPTY_NAME>>;

		// Token: 0x04000881 RID: 2177
		internal string[] <<EMPTY_NAME>>;
	}
}

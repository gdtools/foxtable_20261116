using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 用户
	/// </summary>
	// Token: 0x02000262 RID: 610
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("0609")]
	[ComVisible(true)]
	public class UserInfo
	{
		// Token: 0x06001CD1 RID: 7377 RVA: 0x000C678B File Offset: 0x000C498B
		public UserInfo()
		{
			this.OOO_o00.0. = new Dictionary<string, object>();
		}

		/// <summary>
		/// 用户名
		/// </summary>
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000C679E File Offset: 0x000C499E
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x000C67A6 File Offset: 0x000C49A6
		public string Name
		{
			get
			{
				return this.OOO_o00.0.;
			}
			internal set
			{
				if (OO_00oOO.User != this)
				{
					this.OOO_o00.0. = value;
				}
			}
		}

		/// <summary>
		/// 用户分组
		/// </summary>
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000C67B7 File Offset: 0x000C49B7
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000C67BF File Offset: 0x000C49BF
		public string Group
		{
			get
			{
				return this.O_oO0OOO.o0_o_.;
			}
			internal set
			{
				if (OO_00oOO.User != this)
				{
					this.O_oO0OOO.o0_o_. = value;
				}
			}
		}

		/// <summary>
		/// 用户类型
		/// </summary>
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000C67D0 File Offset: 0x000C49D0
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x000C67D8 File Offset: 0x000C49D8
		public UserTypeEnum Type
		{
			get
			{
				return this.OOO_o00.0.;
			}
			internal set
			{
				if (OO_00oOO.User != this)
				{
					this.OOO_o00.0. = value;
				}
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000C67E9 File Offset: 0x000C49E9
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x000C67F1 File Offset: 0x000C49F1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Tag
		{
			get
			{
				return this.Oo_OO.0.;
			}
			set
			{
				if (OO_00oOO.User != this)
				{
					this.Oo_OO.0. = value;
				}
			}
		}

		/// <summary>
		/// 用户角色
		/// </summary>
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000C6802 File Offset: 0x000C4A02
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x000C680A File Offset: 0x000C4A0A
		public string Roles
		{
			get
			{
				return this.OO0O0_OO0_.OO0.;
			}
			internal set
			{
				if (OO_00oOO.User != this)
				{
					this.OO0O0_OO0_.OO0. = value;
				}
			}
		}

		/// <summary>
		/// 是否是默认用户
		/// </summary>
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000C681B File Offset: 0x000C4A1B
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x000C6823 File Offset: 0x000C4A23
		public bool Default
		{
			get
			{
				return this.OOO_o00.0.;
			}
			internal set
			{
				this.OOO_o00.0. = value;
			}
		}

		/// <summary>
		/// 扩展用户属性集合
		/// </summary>
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000C682C File Offset: 0x000C4A2C
		public Dictionary<string, object> ExtendedValues
		{
			get
			{
				return this.OOO_o00.0.;
			}
		}

		/// <summary>
		/// 判断用户是否具备某个角色
		/// </summary>
		/// <param name="Role">角色名</param>
		// Token: 0x06001CDF RID: 7391 RVA: 0x000C6834 File Offset: 0x000C4A34
		public bool IsRole(string Role)
		{
			bool result;
			if (Operators.CompareString(this.Roles, "", true) == 0)
			{
				result = false;
			}
			else
			{
				string[] array = this.Roles.Split(new char[]
				{
					','
				});
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(array[i], Role, true) == 0)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000C6894 File Offset: 0x000C4A94
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x000C689C File Offset: 0x000C4A9C
		internal string Password
		{
			get
			{
				return this.oo0OOOO.0__OO.;
			}
			set
			{
				this.oo0OOOO.0__OO. = value;
			}
		}

		// Token: 0x04000C45 RID: 3141
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C46 RID: 3142
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C47 RID: 3143
		private UserTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000C48 RID: 3144
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000C49 RID: 3145
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C4A RID: 3146
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C4B RID: 3147
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C4C RID: 3148
		private Dictionary<string, object> <<EMPTY_NAME>>;
	}
}

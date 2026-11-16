using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000263 RID: 611
	[oO0oooo("0609")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class UserInfos : IEnumerable<UserInfo>
	{
		// Token: 0x06001CE2 RID: 7394 RVA: 0x000C68A5 File Offset: 0x000C4AA5
		public UserInfos()
		{
			this.ooo___o_0.__. = new Dictionary<DataRow, UserInfo>();
		}

		/// <summary>
		/// 用户数量
		/// </summary>
		// Token: 0x06001CE3 RID: 7395 RVA: 0x000C68B8 File Offset: 0x000C4AB8
		public int Count()
		{
			return this.UserView.Count;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x000C68C5 File Offset: 0x000C4AC5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<UserInfo> GetEnumerator()
		{
			return new o__o_O0_(this.UserView);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x000C68D2 File Offset: 0x000C4AD2
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new o__o_O0_(this.UserView);
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x000C68DF File Offset: 0x000C4ADF
		internal DataView UserView
		{
			get
			{
				if (Operators.CompareString(this.ooo___o_0.__., OO_00oOO.ProjectFile, true) != 0)
				{
					this.ooo___o_0.__. = OO_00oOO.ProjectFile;
					this.ooo___o_0.__.();
				}
				return this.ooo___o_0.__.;
			}
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000C690C File Offset: 0x000C4B0C
		internal void <<EMPTY_NAME>>()
		{
			DataTable table = O_O0OO.OoO_o.oO0o0O.();
			this.ooo___o_0.__..Clear();
			this.ooo___o_0.__. = new DataView(table, "[Type] <= " + Conversions.ToString(4) + " And [Name] Is Not Null And [Type] Is Not Null", "[Type]", DataViewRowState.CurrentRows);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000C6952 File Offset: 0x000C4B52
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Load()
		{
			this.ooo___o_0.__.();
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000C695A File Offset: 0x000C4B5A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Load(string UserName)
		{
			O_O0OO.OoO_o.oO0o0O.(UserName, this.UserView.Table);
		}

		/// <summary>
		/// 判断是否包括指定名称的用户
		/// </summary>
		/// <param name="UserName"></param>
		// Token: 0x06001CEA RID: 7402 RVA: 0x000C6970 File Offset: 0x000C4B70
		public bool Contains(string UserName)
		{
			int num = this.UserView.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(this.UserView[i]["Name"].ToString(), UserName, true) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000644 RID: 1604
		[EditorBrowsable(EditorBrowsableState.Never)]
		public UserInfo this[int Index]
		{
			get
			{
				return this.ooo___o_0.__.(this.UserView[Index].Row);
			}
		}

		// Token: 0x17000645 RID: 1605
		[EditorBrowsable(EditorBrowsableState.Never)]
		public UserInfo this[string name]
		{
			get
			{
				int num = this.UserView.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(this.UserView[i]["Name"].ToString(), name, true) == 0)
					{
						return this.ooo___o_0.__.(this.UserView[i].Row);
					}
				}
				MessageBox.Show("不存在名为\"" + name + "\"的用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return null;
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000C6A64 File Offset: 0x000C4C64
		private UserInfo <<EMPTY_NAME>>(DataRow A_0)
		{
			UserInfo result;
			if (this.ooo___o_0.__..ContainsKey(A_0))
			{
				result = this.ooo___o_0.__.[A_0];
			}
			else
			{
				UserProperty userProperty = new UserProperty();
				o_O_o_oOoo__.OOOO_OO._oo.(userProperty, Conversions.ToString(A_0["Config"]), '\v');
				UserInfo userInfo = new UserInfo();
				userInfo.Name = Conversions.ToString(A_0["Name"]);
				userInfo.Group = userProperty.Group;
				userInfo.Roles = userProperty.Role;
				userInfo.Password = userProperty.PassWord;
				userInfo.Tag = userProperty.Tag;
				if (userProperty.Type != UserTypeEnum.None)
				{
					userInfo.Type = userProperty.Type;
				}
				else
				{
					userInfo.Type = (UserTypeEnum)Conversions.ToInteger(A_0["Type"]);
				}
				this.ooo___o_0.__..Add(A_0, userInfo);
				result = userInfo;
			}
			return result;
		}

		// Token: 0x04000C4D RID: 3149
		private DataView <<EMPTY_NAME>>;

		// Token: 0x04000C4E RID: 3150
		internal Dictionary<DataRow, UserInfo> <<EMPTY_NAME>>;

		// Token: 0x04000C4F RID: 3151
		private string <<EMPTY_NAME>>;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000261 RID: 609
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o__o_O0_ : IEnumerator<UserInfo>
	{
		// Token: 0x06001CC9 RID: 7369 RVA: 0x000C663C File Offset: 0x000C483C
		public o__o_O0_(DataView A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.UserDataView = A_0;
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000C6659 File Offset: 0x000C4859
		public UserInfo get_Current()
		{
			return this.GetUserInfo();
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x000C6661 File Offset: 0x000C4861
		public object get_Current1()
		{
			return this.GetUserInfo();
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000C666C File Offset: 0x000C486C
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.UserDataView.Count;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000C66A1 File Offset: 0x000C48A1
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000C66AA File Offset: 0x000C48AA
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000C66C0 File Offset: 0x000C48C0
		private UserInfo GetUserInfo()
		{
			DataRow row = this.UserDataView[this.Index].Row;
			UserProperty userProperty = new UserProperty();
			o_O_o_oOoo__.OOOO_OO._oo.(userProperty, Conversions.ToString(row["Config"]), '\v');
			UserInfo userInfo = new UserInfo();
			userInfo.Name = Conversions.ToString(row["Name"]);
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
				userInfo.Type = (UserTypeEnum)Conversions.ToInteger(row["Type"]);
			}
			return userInfo;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000C677C File Offset: 0x000C497C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000C42 RID: 3138
		private int Index;

		// Token: 0x04000C43 RID: 3139
		private DataView UserDataView;

		// Token: 0x04000C44 RID: 3140
		private bool disposedValue;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001C3 RID: 451
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Server_UserLoggingEventArgs
	{
		// Token: 0x060015CA RID: 5578 RVA: 0x00099459 File Offset: 0x00097659
		internal Server_UserLoggingEventArgs(string A_0, string A_1, IMServer A_2, oO__oO_0_O A_3, string[] A_4)
		{
			this.oo_O._. = new List<string>();
			this.o_o._O0O_. = A_0;
			this.O.0Oo_o0. = A_1;
			this.o_o._O0O_. = A_2;
			this.o_o._O0O_. = A_3;
			this.o_o._O0O_. = A_4;
		}

		/// <summary>
		/// 字符型，返回登录用户密码
		/// </summary>
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00099491 File Offset: 0x00097691
		public string Password
		{
			get
			{
				return this.O.0Oo_o0.;
			}
		}

		/// <summary>
		/// 字符型，返回登录用户名
		/// </summary>
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00099499 File Offset: 0x00097699
		public string UserName
		{
			get
			{
				return this.o_o._O0O_.;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x000994A1 File Offset: 0x000976A1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMServer Server
		{
			get
			{
				return this.o_o._O0O_.;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x000994A9 File Offset: 0x000976A9
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x000994B1 File Offset: 0x000976B1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AsyncExecute
		{
			get
			{
				return this.oo0_O00.o_0.;
			}
			set
			{
				this.oo0_O00.o_0. = true;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x000994BC File Offset: 0x000976BC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Handled
		{
			set
			{
				if (value)
				{
					ooo_0_ method = new ooo_0_(o0___oO.O.oOo0O0O.);
					if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
					{
						OO_00oOO.BaseMainForm.Invoke(method, new object[]
						{
							this.o_o._O0O_.,
							this,
							this.o_o._O0O_.,
							this.o_o._O0O_.
						});
					}
				}
			}
		}

		/// <summary>
		/// 默认为False，设置为True，则允许用户登录
		/// </summary>
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0009951D File Offset: 0x0009771D
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00099525 File Offset: 0x00097725
		public bool Success
		{
			get
			{
				return this.o_o._O0O_.;
			}
			set
			{
				this.o_o._O0O_. = value;
			}
		}

		/// <summary>
		/// 字符型，通常在禁止用户登陆时，返回一个错误提示给用户；或者在登录成功时，给用户返回一个欢迎信息
		/// </summary>
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0009952E File Offset: 0x0009772E
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00099536 File Offset: 0x00097736
		public string Message
		{
			get
			{
				return this.Oooo0.o.;
			}
			set
			{
				this.Oooo0.o. = value;
			}
		}

		/// <summary>
		/// 字符型集合，用于设置登录者的好友名单
		/// </summary>
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0009953F File Offset: 0x0009773F
		public List<string> Buddies
		{
			get
			{
				return this.oo_O._.;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00099547 File Offset: 0x00097747
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0009954F File Offset: 0x0009774F
		internal bool BuildIn
		{
			get
			{
				return this.O.0Oo_o0.;
			}
			set
			{
				this.O.0Oo_o0. = value;
			}
		}

		/// <summary>
		/// UserInfo类型，当用户使用内置身份验证登录OpenQQ， 通过验证后此属性返回登录用户，否则返回Nothing
		/// </summary>
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00099558 File Offset: 0x00097758
		public UserInfo User
		{
			get
			{
				UserInfo result;
				if (this.a == 1)
				{
					result = this.a;
				}
				else
				{
					this.a = 1;
					if (this.Server.Buildin)
					{
						string[] array = this.UserName.Split(new char[]
						{
							'.'
						});
						UserInfo userInfo = null;
						string text;
						if (array.Length == 2)
						{
							text = array[1];
						}
						else
						{
							text = this.UserName;
						}
						if (OO_00oOO.Users.Contains(text))
						{
							userInfo = OO_00oOO.Users[text];
							if (userInfo.Type == UserTypeEnum.User)
							{
								if (Operators.CompareString(userInfo.Password, this.Password, true) != 0)
								{
									O_O0OO.OoO_o.oO0o0O.(text, OO_00oOO.Users.UserView.Table);
									userInfo = OO_00oOO.Users[text];
								}
							}
							else
							{
								string text2 = O_O0OO.O_O._Oo.();
								if (Operators.CompareString(userInfo.Password, O00.MD5Encrypt(O00.ooo000o_0.00o0.(this.Password, text2.Substring(0, 8), text2.Substring(text2.Length - 8))), true) != 0)
								{
									O_O0OO.OoO_o.oO0o0O.(text, OO_00oOO.Users.UserView.Table);
									userInfo = OO_00oOO.Users[text];
								}
							}
						}
						else
						{
							O_O0OO.OoO_o.oO0o0O.(text, OO_00oOO.Users.UserView.Table);
							if (OO_00oOO.Users.Contains(text))
							{
								userInfo = OO_00oOO.Users[text];
							}
						}
						if (userInfo != null)
						{
							if (userInfo.Type == UserTypeEnum.User)
							{
								if (Operators.CompareString(userInfo.Password, this.Password, true) == 0)
								{
									this.a = userInfo;
									return this.a;
								}
							}
							else
							{
								string text3 = O_O0OO.O_O._Oo.();
								if (Operators.CompareString(userInfo.Password, O00.MD5Encrypt(O00.ooo000o_0.00o0.(this.Password, text3.Substring(0, 8), text3.Substring(text3.Length - 8))), true) == 0)
								{
									this.a = userInfo;
									return this.a;
								}
							}
						}
					}
					result = null;
				}
				return result;
			}
		}

		// Token: 0x04000884 RID: 2180
		private string <<EMPTY_NAME>>;

		// Token: 0x04000885 RID: 2181
		private string <<EMPTY_NAME>>;

		// Token: 0x04000886 RID: 2182
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000887 RID: 2183
		private string <<EMPTY_NAME>>;

		// Token: 0x04000888 RID: 2184
		private IMServer <<EMPTY_NAME>>;

		// Token: 0x04000889 RID: 2185
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400088A RID: 2186
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x0400088B RID: 2187
		private UserInfo <<EMPTY_NAME>>;

		// Token: 0x0400088C RID: 2188
		internal oO__oO_0_O <<EMPTY_NAME>>;

		// Token: 0x0400088D RID: 2189
		internal string[] <<EMPTY_NAME>>;

		// Token: 0x0400088E RID: 2190
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400088F RID: 2191
		private UserInfo a;

		// Token: 0x04000890 RID: 2192
		private int a;
	}
}

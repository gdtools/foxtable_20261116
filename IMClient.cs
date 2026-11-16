using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001D6 RID: 470
	[oO0oooo("2987")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class IMClient
	{
		// Token: 0x0600166C RID: 5740 RVA: 0x000A07B8 File Offset: 0x0009E9B8
		internal IMClient(string A_0)
		{
			this.o_00o.O. = true;
			this.ooOo.oO0. = new ReaderWriterLock();
			this.O0_OOo.O. = true;
			this.ooOo.oO0. = new Queue<oO__oO_0_O>();
			this.oOO0O.O0O0. = new IMBuddyCollections();
			this.StopHeartbratServer = false;
			this.StopHeartbratBuddy = false;
			this.Oo0__0.ooO0__o. = -1;
			this.O0Oo0OO.O. = 5;
			this.O.o0OOOO_. = 81920;
			this.O.OOo0_Oooo. = 81920;
			this.OoOoo._. = true;
			this.oo.___oo__0_O. = new Dictionary<string, ooo0>();
			this.oo.___oo__0_O. = new Dictionary<string, O_0OOOoO>();
			this.ooOooo.oO. = new Dictionary<string, ooOoO>();
			this.ooOooo.oO. = new Dictionary<string, O_0__O_o_O>();
			this.O0_OOo.O. = new Dictionary<string, O_0__O_o_O>();
			this.O00.O0. = new List<object>();
			this.ooOooo.oO. = new List<int>();
			this.oo.___oo__0_O. = RuntimeHelpers.GetObjectValue(new object());
			this.oOO0_O.O__0_0. = new List<int>();
			this.ooOo.oO0. = new Dictionary<int, O0o000>();
			this.oo.___oo__0_O. = new Dictionary<string, DateTime>();
			this.o00_.0o0. = true;
			this.O00._Oo. = new Dictionary<string, DateTime>();
			this.O00.O0. = new Dictionary<string, string>();
			this.OO.0o0OoooO. = A_0;
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x000A08D5 File Offset: 0x0009EAD5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Name
		{
			get
			{
				return this.OO.0o0OoooO.;
			}
		}

		/// <summary>
		/// QQBuddy集合，包括所有的好友
		/// </summary>
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x000A08DD File Offset: 0x0009EADD
		public IMBuddyCollections Buddies
		{
			get
			{
				return this.oOO0O.O0O0.;
			}
		}

		/// <summary>
		/// 字符型，指定QQserver的IP地址
		/// </summary>
		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x000A08E5 File Offset: 0x0009EAE5
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x000A08ED File Offset: 0x0009EAED
		public string ServerIP
		{
			get
			{
				return this.Oooo0O.0__OO__.;
			}
			set
			{
				this.Oooo0O.0__OO__. = value;
			}
		}

		/// <summary>
		/// 整数型，指定QQServer的端口号
		/// </summary>
		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x000A08F6 File Offset: 0x0009EAF6
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x000A08FE File Offset: 0x0009EAFE
		public int ServerPort
		{
			get
			{
				return this.o_00o.O.;
			}
			set
			{
				this.o_00o.O. = value;
			}
		}

		/// <summary>
		/// 字符型，用户在登录成功或失败后，获取服务器返回的信息
		/// </summary>
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x000A0907 File Offset: 0x0009EB07
		public string ServerMessage
		{
			get
			{
				return this.oOOooo_._O.;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x000A090F File Offset: 0x0009EB0F
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x000A0917 File Offset: 0x0009EB17
		internal bool Heartbeat
		{
			get
			{
				return this.o_00o.O.;
			}
			set
			{
				this.o_00o.O. = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x000A0920 File Offset: 0x0009EB20
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x000A0928 File Offset: 0x0009EB28
		internal int HeartbeatInterval
		{
			get
			{
				return this.oO_0.0O_o.;
			}
			set
			{
				if (value < 5)
				{
					value = 5;
				}
				this.oO_0.0O_o. = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x000A0938 File Offset: 0x0009EB38
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x000A0940 File Offset: 0x0009EB40
		internal int HeartbeatTimeout
		{
			get
			{
				return this.O_00O_000.O0_.;
			}
			set
			{
				if (value < 10)
				{
					value = 10;
				}
				this.O_00O_000.O0_. = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x000A0952 File Offset: 0x0009EB52
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x000A095A File Offset: 0x0009EB5A
		internal DateTime LastReceiveHeartbeatTime
		{
			get
			{
				return this.oOOOo0.oo0OoO0.;
			}
			set
			{
				this.oOOOo0.oo0OoO0. = value;
			}
		}

		/// <summary>
		/// 字符型，指定登录用户名。
		/// </summary>
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000A0963 File Offset: 0x0009EB63
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x000A096B File Offset: 0x0009EB6B
		public string UserName
		{
			get
			{
				return this.o_00o.O.;
			}
			set
			{
				this.o_00o.O. = value;
			}
		}

		/// <summary>
		/// 字符型，指定登录用户密码
		/// </summary>
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000A0974 File Offset: 0x0009EB74
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x000A097C File Offset: 0x0009EB7C
		public string Password
		{
			get
			{
				return this.oo00000_0o0.oO.;
			}
			set
			{
				this.oo00000_0o0.oO. = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000A0985 File Offset: 0x0009EB85
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x000A098D File Offset: 0x0009EB8D
		internal IPEndPoint WanIP
		{
			get
			{
				return this.OO.OO_oO_0_0.;
			}
			set
			{
				this.OO.OO_oO_0_0. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于判断QQClient是否已经启动
		/// </summary>
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x000A0996 File Offset: 0x0009EB96
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x000A099E File Offset: 0x0009EB9E
		public bool Ready
		{
			get
			{
				return this.oo.o_.;
			}
			private set
			{
				this.oo.o_. = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x000A09A7 File Offset: 0x0009EBA7
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x000A09AF File Offset: 0x0009EBAF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int ReceiveBufferSize
		{
			get
			{
				return this.O.o0OOOO_.;
			}
			set
			{
				this.O.o0OOOO_. = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x000A09B8 File Offset: 0x0009EBB8
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x000A09C0 File Offset: 0x0009EBC0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int SendBufferSize
		{
			get
			{
				return this.O.OOo0_Oooo.;
			}
			set
			{
				this.O.OOo0_Oooo. = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x000A09CC File Offset: 0x0009EBCC
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x000A0A07 File Offset: 0x0009EC07
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string DataFile
		{
			get
			{
				string result;
				if (Operators.CompareString(this.Oo00_0._0O_., "", true) == 0)
				{
					result = this.UserName + ".mdb";
				}
				else
				{
					result = this.Oo00_0._0O_.;
				}
				return result;
			}
			set
			{
				this.Oo00_0._0O_. = value;
			}
		}

		/// <summary>
		/// 逻辑型，默认为False，如果设置为True，在发送消息时，不管对方是否在线，都会通过服务器转发
		/// </summary>
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x000A0A10 File Offset: 0x0009EC10
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x000A0A18 File Offset: 0x0009EC18
		public bool ThroughServer
		{
			get
			{
				return this.O.o0OOOO_.;
			}
			set
			{
				this.O.o0OOOO_. = value;
			}
		}

		/// <summary>
		/// 逻辑型，是否允许用户通过内置聊天窗口传输文件，默认为True
		/// </summary>
		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x000A0A21 File Offset: 0x0009EC21
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x000A0A29 File Offset: 0x0009EC29
		public bool AllowSendFile
		{
			get
			{
				return this.OoOoo._.;
			}
			set
			{
				this.OoOoo._. = value;
			}
		}

		/// <summary>
		/// 是否在内置聊天窗口接收并显示QQServer发来的系统通知，默认为True，通常无需设置
		/// </summary>
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x000A0A32 File Offset: 0x0009EC32
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x000A0A3A File Offset: 0x0009EC3A
		public bool ReceiveNotice
		{
			get
			{
				return this.o00_.0o0.;
			}
			set
			{
				this.o00_.0o0. = value;
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000A0A43 File Offset: 0x0009EC43
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ClearWeChatUsers()
		{
			this.O00.O0..Clear();
		}

		/// <summary>
		/// 启动QQClient
		/// </summary>
		/// <param name="Timeout">选参数，整数型，默认值为5，单位为秒；用于指定超时时间，在此时间内没有收到服务器反馈，则认为登录失败</param>
		// Token: 0x06001691 RID: 5777 RVA: 0x000A0A50 File Offset: 0x0009EC50
		public bool Start(int Timeout = 5)
		{
			bool result;
			if (this.ooOo.oO0. != null)
			{
				MessageBox.Show("此IMClient已经启动，请先停止，才能重新启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (this.o_00o.O. == 0 || Operators.CompareString(this.Oooo0O.0__OO__., "", true) == 0)
			{
				MessageBox.Show("必须指定服务器的IP地址和端口号,才能启动IMClient!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				bool flag;
				if (Operators.CompareString(this.UserName, "", true) == 0 && Operators.CompareString(this.Password, "", true) == 0)
				{
					if (Operators.CompareString(OO_00oOO.User.Group, "", true) > 0)
					{
						this.UserName = OO_00oOO.User.Group + "." + OO_00oOO.User.Name;
					}
					else
					{
						this.UserName = OO_00oOO.User.Name;
					}
					this.Password = OO_00oOO.User.Password;
					flag = true;
				}
				this.Oo0__0.ooO0__o. = -1;
				this.Buddies.OOO__.0.();
				this.o_oo0Oooo.OOO_. = OoOo0O.OO_o.0o_O.(4);
				if (Timeout != 5)
				{
					Timeout = Math.Max(1, Timeout);
					this.O0Oo0OO.O. = Timeout;
				}
				try
				{
					string[] array = this.Oooo0O.0__OO__..Split(new char[]
					{
						'.'
					});
					if (array.Length == 4 && Versioned.IsNumeric(array[0]) && Versioned.IsNumeric(array[1]) && Versioned.IsNumeric(array[2]) && Versioned.IsNumeric(array[3]))
					{
						this.ooOo.oO0. = new IPEndPoint(IPAddress.Parse(this.Oooo0O.0__OO__.), this.o_00o.O.);
					}
					else
					{
						foreach (IPAddress ipaddress in Dns.GetHostEntry(this.Oooo0O.0__OO__.).AddressList)
						{
							if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
							{
								this.ooOo.oO0. = new IPEndPoint(ipaddress, this.o_00o.O.);
								break;
							}
						}
					}
					if (this.ooOo.oO0. == null)
					{
						MessageBox.Show("IMserver服务器地址无效", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						result = false;
					}
					else
					{
						this.ooOo.oO0. = new UdpClient(0);
						this.O00._Oo. = new UdpClient(0);
						this.ooOo.oO0..Client.ReceiveBufferSize = this.ReceiveBufferSize;
						this.ooOo.oO0..Client.SendBufferSize = this.SendBufferSize;
						this.O00._Oo..Client.ReceiveBufferSize = 81920;
						o0___oO.O.oOo0O0O.(this.ooOo.oO0.);
						o0___oO.O.oOo0O0O.(this.O00._Oo.);
						string text;
						if (flag)
						{
							text = string.Concat(new string[]
							{
								"@1\v",
								this.o_00o.O.,
								"\v",
								this.oo00000_0o0.oO.,
								"\v",
								this.o_oo0Oooo.OOO_.,
								"\v"
							});
						}
						else
						{
							text = string.Concat(new string[]
							{
								"@\v",
								this.o_00o.O.,
								"\v",
								this.oo00000_0o0.oO.,
								"\v",
								this.o_oo0Oooo.OOO_.,
								"\v"
							});
						}
						string text2 = o0___oO.o0__.0.();
						if (Operators.CompareString(text2, "", true) > 0)
						{
							string text3 = this.ooOo.oO0..Client.LocalEndPoint.ToString();
							text3 = text3.Substring(text3.IndexOf(":") + 1);
							text = text + text2 + ":" + text3;
						}
						else
						{
							text += "None";
						}
						this.O.00O0_O_o_oO.(this.ooOo.oO0., text);
						DateTime now = DateTime.Now;
						while (DateTime.Compare(DateTime.Now, now.AddSeconds((double)Timeout)) < 0)
						{
							if (this.ooOo.oO0..Available > 0)
							{
								IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
								byte[] bytes = this.ooOo.oO0..Receive(ref ipendPoint);
								string @string = Encoding.Unicode.GetString(bytes);
								string[] array2 = @string.Split(new char[]
								{
									'\v'
								});
								if (array2.Length == 7 && Operators.CompareString(array2[0], this.o_00o.O., true) == 0)
								{
									this.O0_OOo.O. = false;
									this.oOOooo_._O. = array2[1];
									if (Operators.CompareString(array2[2], "1", true) == 0)
									{
										this.Heartbeat = true;
									}
									else
									{
										this.Heartbeat = false;
									}
									this.HeartbeatInterval = Conversions.ToInteger(array2[3]);
									this.HeartbeatTimeout = Conversions.ToInteger(array2[4]);
									this.LastReceiveHeartbeatTime = DateTime.Now;
									this.Oo0__0.ooO0__o. = false;
									this.O0O.Oo_. = false;
									this.WanIP = o0___oO.o0__.0.(array2[5]);
									this.Oo0__0.ooO0__o. = Conversions.ToInteger(array2[6]);
									this.o0oo.Oo_o.();
									this.Oooo_OoO._OO.();
									this.O.00O0_O_o_oO.(Timeout, this.Oo0__0.ooO0__o.);
									if (this.Heartbeat)
									{
										this.ooOo.oO0. = new System.Threading.Timer(new TimerCallback(this.o00O0._0O.), null, this.HeartbeatInterval * 1000, this.HeartbeatInterval * 1000);
									}
									this.oo.o_. = true;
									text = "+@\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
									this.O.00O0_O_o_oO.(this.ooOo.oO0., text);
									this.O00._Oo. = DateTime.Now;
									this.o_oo0.O0Oo__oO. = false;
									Client_UserEventArgs client_UserEventArgs = new Client_UserEventArgs(this);
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Connected", new object[]
									{
										client_UserEventArgs
									}, true, "项目", false);
									if (this.UnreadCount > 0 && OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg2.wav"))
									{
										OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg2.wav", AudioPlayMode.Background);
									}
									return true;
								}
								if (this.ooOo.oO0. != null && this.ooOo.oO0. != null)
								{
									text = "-@\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
									this.O.00O0_O_o_oO.(this.ooOo.oO0., text);
								}
								this.oo.o_. = false;
								this.O0_OOo.O. = true;
								this.Buddies.OOO__.0.();
								if (this.ooOo.oO0. != null)
								{
									this.ooOo.oO0..Close();
									this.ooOo.oO0. = null;
								}
								if (this.O00._Oo. != null)
								{
									this.O00._Oo..Close();
									this.O00._Oo. = null;
								}
								if (this.ooOo.oO0. != null)
								{
									this.ooOo.oO0..Dispose();
									this.ooOo.oO0. = null;
								}
								this.ooOo.oO0. = null;
								this.oOOooo_._O. = @string;
								return false;
							}
						}
						this.oOOooo_._O. = "规定时间内未获服务器响应!";
						this.O_0O0o.__O_.();
						result = false;
					}
				}
				catch (Exception a_)
				{
					this.O_0O0o.__O_.();
					ooO.oOo0Oo.o.(a_, "启动IMClient");
				}
			}
			return result;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000A10D4 File Offset: 0x0009F2D4
		private void <<EMPTY_NAME>>()
		{
			if (this.ooOo.oO0. != null && this.ooOo.oO0. != null)
			{
				string a_ = "-@\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
				this.O.00O0_O_o_oO.(this.ooOo.oO0., a_);
			}
			this.Buddies.OOO__.0.();
			this.oo.o_. = false;
			this.O0_OOo.O. = true;
			if (this.ooOo.oO0. != null)
			{
				this.ooOo.oO0..Close();
				this.ooOo.oO0. = null;
			}
			if (this.O00._Oo. != null)
			{
				this.O00._Oo..Close();
				this.O00._Oo. = null;
			}
			if (this.ooOo.oO0. != null)
			{
				this.ooOo.oO0..Dispose();
				this.ooOo.oO0. = null;
			}
			this.ooOo.oO0. = null;
		}

		/// <summary>
		/// QQClient退出登录
		/// </summary>
		// Token: 0x06001693 RID: 5779 RVA: 0x000A1188 File Offset: 0x0009F388
		public void Stop()
		{
			if (!this.O0_OOo.O.)
			{
				if (this.ooOooo.oO. != null)
				{
					this.ooOooo.oO..Close();
					this.ooOooo.oO. = null;
				}
				Client_LogoutEventArgs client_LogoutEventArgs = new Client_LogoutEventArgs(this, 1);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", new object[]
				{
					client_LogoutEventArgs
				}, true, "项目", false);
				string text = "!1\v" + this.o_00o.O. + "\v" + this.o_oo0Oooo.OOO_.;
				byte[] bytes = Encoding.Unicode.GetBytes(text);
				this.ooOo.oO0..Send(bytes, bytes.Length, this.ooOo.oO0.);
				try
				{
					foreach (IMBuddy imbuddy in this.Buddies)
					{
						this.O.00O0_O_o_oO.(imbuddy.Name, text);
					}
				}
				finally
				{
					IEnumerator<IMBuddy> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.dispose();
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000A1270 File Offset: 0x0009F470
		public void dispose()
		{
			if (this.ooOo.oO0. != null)
			{
				if (this.ooOooo.oO. != null)
				{
					this.ooOooo.oO..Close();
					this.ooOooo.oO. = null;
				}
				this.oo.o_. = false;
				this.O0_OOo.O. = true;
				this.ooOo.oO0..AcquireWriterLock(-1);
				Exception ex = null;
				try
				{
					if (this.ooOo.oO0. != null)
					{
						this.ooOo.oO0..Dispose();
						this.ooOo.oO0. = null;
					}
					object obj = this.ooOo.oO0.;
					lock (obj)
					{
						this.ooOo.oO0..Clear();
					}
					this.Buddies.OOO__.0.();
					this.oo.___oo__0_O..Clear();
					this.oo.___oo__0_O..Clear();
					this.ooOo.oO0. = null;
					this.ooOo.oO0..Close();
					this.ooOo.oO0. = null;
					this.O00._Oo..Close();
					this.O00._Oo. = null;
					this.oOO0O.O0O0..Close();
					this.oOOOo0.oo0OoO0. = null;
					this.oOO0O.O0O0. = null;
					if (this.oOOOo0.oo0OoO0. != null)
					{
						this.oOOOo0.oo0OoO0..Clear();
						this.oOOOo0.oo0OoO0. = null;
					}
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
				finally
				{
					this.ooOo.oO0..ReleaseWriterLock();
				}
				if (ex != null)
				{
					ooO.oOo0Oo.o.(ex, "关闭IMClient");
				}
			}
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000A13D4 File Offset: 0x0009F5D4
		private void <<EMPTY_NAME>>()
		{
			Exception ex = null;
			this.ooOo.oO0..AcquireReaderLock(-1);
			try
			{
				this.ooOo.oO0..BeginReceive(new AsyncCallback(this.O.00O0_O_o_oO.), null);
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			finally
			{
				this.ooOo.oO0..ReleaseReaderLock();
			}
			if (ex != null)
			{
				this.Stop();
				ooO.oOo0Oo.o.(ex, "IMClient异步接收");
			}
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000A1458 File Offset: 0x0009F658
		private void <<EMPTY_NAME>>(IAsyncResult A_0)
		{
			if (!this.O0_OOo.O.)
			{
				Exception ex = null;
				this.ooOo.oO0..AcquireReaderLock(-1);
				try
				{
					IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
					byte[] array = this.ooOo.oO0..EndReceive(A_0, ref ipendPoint);
					string text = Encoding.Unicode.GetString(array);
					if (Operators.CompareString(text, "", true) > 0)
					{
						if (text.StartsWith("#\v"))
						{
							string[] array2 = text.Split(new char[]
							{
								'\v'
							});
							if (Operators.CompareString(array2[1], this.UserName, true) == 0 && Operators.CompareString(array2[2], this.o_oo0Oooo.OOO_., true) == 0)
							{
								this.LastReceiveHeartbeatTime = DateTime.Now;
								this.Oo0__0.ooO0__o. = false;
								this.O0O.Oo_. = false;
							}
							else if (this.Buddies.Contains(array2[1]) && Operators.CompareString(this.Buddies[array2[1]].RandKey, array2[2], true) == 0)
							{
								if (this.Buddies[array2[1]].oOo.o0__0Oo0oO. == 0)
								{
									this.Buddies[array2[1]].oOo.o0__0Oo0oO. = this.Buddies[array2[1]].oOo.o0__0Oo0oO. + 1;
									text = "#\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
									array = Encoding.Unicode.GetBytes(text);
									this.ooOo.oO0..Send(array, array.Length, ipendPoint);
									this.Buddies[array2[1]].WanIP = ipendPoint;
									text = "##\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
									array = Encoding.Unicode.GetBytes(text);
									this.ooOo.oO0..Send(array, array.Length, ipendPoint);
								}
								this.Buddies[array2[1]].LastReceiveHeartbeatTime = DateTime.Now;
							}
						}
						else if (text.StartsWith("#1\v"))
						{
							string[] array3 = text.Split(new char[]
							{
								'\v'
							});
							if (this.Buddies.Contains(array3[1]) && Operators.CompareString(this.Buddies[array3[1]].RandKey, array3[2], true) == 0)
							{
								this.Buddies[array3[1]].oOo.o0__0Oo0oO. = this.Buddies[array3[1]].oOo.o0__0Oo0oO. + 1;
								this.Buddies[array3[1]].WanIP = ipendPoint;
								this.Buddies[array3[1]].LastReceiveHeartbeatTime = DateTime.Now;
								text = "##\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
								array = Encoding.Unicode.GetBytes(text);
								this.ooOo.oO0..Send(array, array.Length, ipendPoint);
							}
							text = "#\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
							array = Encoding.Unicode.GetBytes(text);
							this.ooOo.oO0..Send(array, array.Length, ipendPoint);
						}
						else if (text.StartsWith("##\v"))
						{
							string[] array4 = text.Split(new char[]
							{
								'\v'
							});
							if (this.Buddies.Contains(array4[1]) && Operators.CompareString(this.Buddies[array4[1]].RandKey, array4[2], true) == 0)
							{
								this.Buddies[array4[1]].O00OO.o_. = this.Buddies[array4[1]].O00OO.o_. + 1;
							}
						}
						else if (text.StartsWith("###\v"))
						{
							string[] array5 = text.Split(new char[]
							{
								'\v'
							});
							if (this.Buddies.Contains(array5[1]) && Operators.CompareString(this.Buddies[array5[1]].RandKey, array5[2], true) == 0)
							{
								text = "##\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
								array = Encoding.Unicode.GetBytes(text);
								this.ooOo.oO0..Send(array, array.Length, ipendPoint);
							}
						}
						else if (text.StartsWith("%1\v"))
						{
							string[] array6 = text.Split(new char[]
							{
								'\v'
							});
							if (this.Buddies.Contains(array6[1]) && this.Buddies[array6[1]].OnLine && array6.Length == 7)
							{
								string text2 = "\v";
								IPEndPoint ipendPoint2 = new IPEndPoint(this.Buddies[array6[1]].WanIP.Address, Conversions.ToInteger(array6[4]));
								UdpClient udpClient = new UdpClient(0);
								o0___oO.O.oOo0O0O.(udpClient);
								udpClient.Client.ReceiveBufferSize = 81920;
								text = "Ping";
								array = Encoding.Unicode.GetBytes(text);
								udpClient.Send(array, array.Length, ipendPoint2);
								string text3 = udpClient.Client.LocalEndPoint.ToString();
								text3 = text3.Substring(text3.IndexOf(":") + 1);
								text = string.Concat(new string[]
								{
									"%1",
									text2,
									array6[1],
									text2,
									text3,
									text2,
									array6[5]
								});
								array = Encoding.Unicode.GetBytes(text);
								this.O.00O0_O_o_oO.(ipendPoint, text);
								ooOoO ooOoO = new ooOoO(this, udpClient, ipendPoint2, array6[2], array6[1], array6[6], (SendTypeEnum)Conversions.ToInteger(array6[3]));
								object obj = this.ooOooo.oO.;
								lock (obj)
								{
									this.ooOooo.oO..Add(ooOoO.o0OO._0.(), ooOoO);
								}
								new Thread(new ThreadStart(ooOoO.O_OOOooo_0.O.)).Start();
							}
						}
						else if (text.StartsWith("%2\v"))
						{
							string[] array7 = text.Split(new char[]
							{
								'\v'
							});
							if (array7.Length == 6 && this.Buddies.Contains(array7[1]))
							{
								UdpClient udpClient2 = new UdpClient(0);
								o0___oO.O.oOo0O0O.(udpClient2);
								udpClient2.Client.ReceiveBufferSize = 81920;
								string ipString = array7[4].Substring(0, array7[4].IndexOf(":"));
								string value = array7[4].Substring(array7[4].IndexOf(":") + 1);
								IPEndPoint ipendPoint3 = new IPEndPoint(IPAddress.Parse(ipString), Conversions.ToInteger(value));
								array = Encoding.Unicode.GetBytes("Ping");
								udpClient2.Send(array, array.Length, ipendPoint3);
								text = "%2\v" + array7[1] + "\v" + array7[4];
								array = Encoding.Unicode.GetBytes(text);
								udpClient2.Send(array, array.Length, this.ooOo.oO0.);
								ooOoO ooOoO2 = new ooOoO(this, udpClient2, ipendPoint3, array7[2], array7[1], array7[5], (SendTypeEnum)Conversions.ToInteger(array7[3]));
								object obj2 = this.ooOooo.oO.;
								lock (obj2)
								{
									this.ooOooo.oO..Add(ooOoO2.o0OO._0.(), ooOoO2);
								}
								new Thread(new ThreadStart(ooOoO2.O_OOOooo_0.O.)).Start();
							}
						}
						else if (text.StartsWith("%8\v"))
						{
							string[] array8 = text.Split(new char[]
							{
								'\v'
							});
							if (array8.Length == 3)
							{
								UdpClient udpClient3 = new UdpClient(0);
								o0___oO.O.oOo0O0O.(udpClient3);
								udpClient3.Client.ReceiveBufferSize = 81920;
								int port = Conversions.ToInteger(array8[1]);
								IPEndPoint ipendPoint4 = new IPEndPoint(this.ooOo.oO0..Address, port);
								array = Encoding.Unicode.GetBytes("Ping");
								udpClient3.Send(array, array.Length, ipendPoint4);
								ooOoO ooOoO3 = new ooOoO(this, udpClient3, ipendPoint4, array8[2], null, OoOo0O.OO_o.0o_O.(8), SendTypeEnum.AutoFile);
								if (this.O00._Oo..ContainsKey(array8[2].ToLower()) && (DateTime.Now - this.O00._Oo.[array8[2].ToLower()]).TotalSeconds < 10.0 && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
								{
									OO_00oOO.BaseMainForm.Invoke(new IMClient.o00o_(this.oOO0O.O0O0.), new object[]
									{
										null,
										array8[2],
										ooOoO3
									});
								}
								object obj3 = this.ooOooo.oO.;
								lock (obj3)
								{
									this.ooOooo.oO..Add(ooOoO3.o0OO._0.(), ooOoO3);
								}
								new Thread(new ThreadStart(ooOoO3.O_OOOooo_0.O.)).Start();
							}
						}
						else if (text.StartsWith("%10\v"))
						{
							string[] array9 = text.Split(new char[]
							{
								'\v'
							});
							if (array9.Length == 5 && this.Buddies.Contains(array9[1]) && Operators.CompareString(ipendPoint.ToString(), this.ooOo.oO0..ToString(), true) == 0)
							{
								UdpClient udpClient4 = new UdpClient(0);
								o0___oO.O.oOo0O0O.(udpClient4);
								udpClient4.Client.ReceiveBufferSize = 81920;
								int port2 = Conversions.ToInteger(array9[3]);
								IPEndPoint ipendPoint5 = new IPEndPoint(this.ooOo.oO0..Address, port2);
								array = Encoding.Unicode.GetBytes("Ping");
								udpClient4.Send(array, array.Length, ipendPoint5);
								ooOoO ooOoO4 = new ooOoO(this, udpClient4, ipendPoint5, array9[2], array9[1], array9[4], SendTypeEnum.AutoFile);
								object obj4 = this.ooOooo.oO.;
								lock (obj4)
								{
									this.ooOooo.oO..Add(ooOoO4.o0OO._0.(), ooOoO4);
								}
								new Thread(new ThreadStart(ooOoO4.O_OOOooo_0.O.)).Start();
							}
						}
						else
						{
							object obj5 = this.ooOo.oO0.;
							lock (obj5)
							{
								this.ooOo.oO0..Enqueue(new oO__oO_0_O(ipendPoint, text));
							}
						}
					}
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
				finally
				{
					this.ooOo.oO0..ReleaseReaderLock();
				}
				if (ex == null)
				{
					if (!this.O0_OOo.O.)
					{
						this.o0oo.Oo_o.();
						return;
					}
				}
				else
				{
					ooO.oOo0Oo.o.(ex, "IMClient异步接收回调过程");
				}
			}
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000A1F5C File Offset: 0x000A015C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Send(params object[] args)
		{
			if (args.Length == 1)
			{
				this.Send(Conversions.ToString(args[0]));
				return;
			}
			if (args.Length == 2)
			{
				this.Send(Conversions.ToString(args[0]), Conversions.ToString(args[1]), false, false);
				return;
			}
			if (args.Length == 3)
			{
				this.Send(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToBoolean(args[2]), false);
				return;
			}
			if (args.Length == 4)
			{
				this.Send(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToBoolean(args[2]), Conversions.ToBoolean(args[3]));
			}
		}

		/// <summary>
		/// 向服务发送信息
		/// </summary>
		/// <param name="Msg">信息内容</param>
		// Token: 0x06001698 RID: 5784 RVA: 0x000A1FF4 File Offset: 0x000A01F4
		public void Send(string Msg)
		{
			Msg = string.Concat(new string[]
			{
				"$\v",
				this.UserName,
				"\v",
				Msg.Replace("\v", ""),
				"\v",
				this.o_oo0Oooo.OOO_.
			});
			this.O.00O0_O_o_oO.("", Msg);
		}

		/// <summary>
		/// 向好友发送信息
		/// </summary>
		/// <param name="UserName">好友名</param>
		/// <param name="Msg">信息内容</param>
		/// <param name="AnyWay"> 可选参数，逻辑型，如果对方不在线，是否发离线消息</param>
		/// <param name="ThroughServer">可选参数，逻辑型，默认为False,如果设置为True，将强制通过服务器中转发送</param>
		// Token: 0x06001699 RID: 5785 RVA: 0x000A2058 File Offset: 0x000A0258
		[oO0oooo("2990")]
		public bool Send(string UserName, string Msg, bool AnyWay = false, bool ThroughServer = false)
		{
			Msg = o0___oO.o0__.0.(Msg);
			bool result;
			if (Operators.CompareString(UserName, "", true) == 0)
			{
				this.Send(Msg);
				result = true;
			}
			else if (this.Buddies.Contains(UserName))
			{
				IMBuddy imbuddy = this.Buddies[UserName];
				if (!imbuddy.OnLine && !AnyWay && !imbuddy.FromWeChat)
				{
					result = false;
				}
				else if (imbuddy.oOo.o0__0Oo0oO. > 0 && !imbuddy.FromWeChat && imbuddy.O00OO.o_. > 0 && !this.ThroughServer && !ThroughServer)
				{
					Msg = string.Concat(new string[]
					{
						"$\v",
						this.UserName,
						"\v",
						Msg.Replace("\v", ""),
						"\v",
						this.o_oo0Oooo.OOO_.
					});
					this.O.00O0_O_o_oO.(UserName, Msg);
					result = true;
				}
				else
				{
					string text = UserName;
					if (imbuddy.FromWeChat)
					{
						text = "\"" + text + "\"";
					}
					Msg = string.Concat(new string[]
					{
						"=$\v",
						text,
						"\v",
						this.UserName,
						"\v",
						Msg.Replace("\v", ""),
						"\v",
						this.o_oo0Oooo.OOO_.
					});
					this.O.00O0_O_o_oO.("", Msg);
					result = true;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000A21C4 File Offset: 0x000A03C4
		internal void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2 = true)
		{
			char value = '\v';
			if (A_2)
			{
				string text = A_1.Replace(Conversions.ToString(value), "");
				if (text.StartsWith("{!}"))
				{
					text = text.Substring(3);
				}
				this.O.00O0_O_o_oO.(A_0, text, 2, 1, this.UserName);
			}
			if (this.oo.___oo__0_O..ContainsKey(A_0))
			{
				string a_ = string.Concat(new string[]
				{
					"*1",
					Conversions.ToString(value),
					this.UserName,
					Conversions.ToString(value),
					this.o_oo0Oooo.OOO_.,
					Conversions.ToString(value),
					A_0,
					Conversions.ToString(value),
					A_1.Replace(Conversions.ToString(value), "")
				});
				try
				{
					foreach (IMBuddy imbuddy in this.oo.___oo__0_O.[A_0].O0_.OO.())
					{
						if (imbuddy.oOo.o0__0Oo0oO. > 0 && imbuddy.O00OO.o_. > 0 && !this.ThroughServer)
						{
							this.O.00O0_O_o_oO.(imbuddy.Name, a_);
						}
						else
						{
							string a_2 = string.Concat(new string[]
							{
								"*1",
								Conversions.ToString(value),
								imbuddy.Name,
								Conversions.ToString(value),
								this.UserName,
								Conversions.ToString(value),
								this.o_oo0Oooo.OOO_.,
								Conversions.ToString(value),
								A_0,
								Conversions.ToString(value),
								A_1.Replace(Conversions.ToString(value), "")
							});
							this.O.00O0_O_o_oO.(a_2);
						}
					}
					return;
				}
				finally
				{
					List<IMBuddy>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (this.oo.___oo__0_O..ContainsKey(A_0))
			{
				string a_3 = string.Concat(new string[]
				{
					"*1",
					Conversions.ToString(value),
					this.UserName,
					Conversions.ToString(value),
					this.o_oo0Oooo.OOO_.,
					Conversions.ToString(value),
					A_0,
					Conversions.ToString(value),
					A_1.Replace(Conversions.ToString(value), "")
				});
				try
				{
					foreach (string text2 in this.oo.___oo__0_O.[A_0].O0O0o_.00O.())
					{
						if (Operators.CompareString(text2, this.UserName, true) != 0)
						{
							if (this.Buddies.Contains(text2) && this.Buddies[text2].oOo.o0__0Oo0oO. > 0 && this.Buddies[text2].O00OO.o_. > 0 && !this.ThroughServer)
							{
								this.O.00O0_O_o_oO.(text2, a_3);
							}
							else
							{
								string a_4 = string.Concat(new string[]
								{
									"*1",
									Conversions.ToString(value),
									text2,
									Conversions.ToString(value),
									this.UserName,
									Conversions.ToString(value),
									this.o_oo0Oooo.OOO_.,
									Conversions.ToString(value),
									A_0,
									Conversions.ToString(value),
									A_1.Replace(Conversions.ToString(value), "")
								});
								this.O.00O0_O_o_oO.(a_4);
							}
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
		}

		/// <summary>
		/// 向好友或会议发送信息
		/// </summary>
		/// <param name="BuddyName">好友名</param>
		/// <param name="msg">消息内容</param>
		// Token: 0x0600169B RID: 5787 RVA: 0x000A2540 File Offset: 0x000A0740
		[oO0oooo("3021")]
		public void SendChatMessage(string BuddyName, string msg)
		{
			IMBuddy imbuddy = null;
			if (this.Buddies.Contains(BuddyName))
			{
				imbuddy = this.Buddies[BuddyName];
			}
			if (imbuddy == null)
			{
				try
				{
					foreach (ooo0 ooo in this.oo.___oo__0_O..Values)
					{
						if (Operators.CompareString(ooo.oo.o0.(), BuddyName, true) == 0)
						{
							imbuddy = ooo;
						}
					}
				}
				finally
				{
					Dictionary<string, ooo0>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (imbuddy == null)
			{
				try
				{
					foreach (O_0OOOoO o_0OOOoO in this.oo.___oo__0_O..Values)
					{
						if (Operators.CompareString(o_0OOOoO.Name, BuddyName, true) == 0)
						{
							imbuddy = o_0OOOoO;
						}
					}
				}
				finally
				{
					Dictionary<string, O_0OOOoO>.ValueCollection.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			if (imbuddy != null)
			{
				if (imbuddy is ooo0)
				{
					this.o00O0._0O.(((ooo0)imbuddy).Oo_0__o.o.(), msg, true);
					return;
				}
				if (imbuddy is O_0OOOoO)
				{
					this.o00O0._0O.(((O_0OOOoO)imbuddy).O_O0_o._O0o0O.(), msg, true);
					return;
				}
				if (imbuddy is IMBuddy)
				{
					if (imbuddy.OnLine)
					{
						this.O_._00O0_.++;
						this.ooOo.oO0..Add(this.O_._00O0_., new O0o000(imbuddy, msg));
						this.Send(imbuddy.Name, string.Concat(new string[]
						{
							"={",
							msg,
							"\u0004",
							this.O_._00O0_..ToString(),
							"}="
						}), true, false);
					}
					else
					{
						this.Send(imbuddy.Name, "={" + msg + "}=", true, false);
					}
					string text = msg.Replace("\v", "");
					if (text.StartsWith("{!}"))
					{
						text = text.Substring(3);
					}
					this.O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, null);
				}
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000A2734 File Offset: 0x000A0934
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O.00O0_O_o_oO.("", A_0);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000A2744 File Offset: 0x000A0944
		internal void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			IPEndPoint ipendPoint = null;
			if (Operators.CompareString(A_0, "", true) == 0)
			{
				ipendPoint = this.ooOo.oO0.;
			}
			else if (this.Buddies.Contains(A_0))
			{
				ipendPoint = this.Buddies[A_0].WanIP;
			}
			if (ipendPoint != null)
			{
				this.O.00O0_O_o_oO.(ipendPoint, A_1);
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000A2798 File Offset: 0x000A0998
		internal void <<EMPTY_NAME>>(IPEndPoint A_0, string A_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(A_1);
			this.ooOo.oO0..Send(bytes, bytes.Length, A_0);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000A27C4 File Offset: 0x000A09C4
		internal void <<EMPTY_NAME>>(int A_0 = 5, int A_1 = -1)
		{
			if (!this.O0_OOo.O.)
			{
				object buddies = this.Buddies;
				lock (buddies)
				{
					DataView dataView;
					checked
					{
						if (A_1 > 0)
						{
							string s = "^\v" + this.o_00o.O. + "\v" + this.o_oo0Oooo.OOO_.;
							byte[] bytes = Encoding.Unicode.GetBytes(s);
							this.O00._Oo..Send(bytes, bytes.Length, this.ooOo.oO0.);
							DateTime now = DateTime.Now;
							this.Buddies.OOO__.0.();
							while (DateTime.Compare(DateTime.Now, now.AddSeconds((double)A_0)) < 0)
							{
								if (this.O00._Oo..Available > 0)
								{
									now = DateTime.Now;
									IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
									byte[] bytes2 = this.O00._Oo..Receive(ref ipendPoint);
									string[] array = Encoding.Unicode.GetString(bytes2).Split(new char[]
									{
										'\v'
									});
									for (int i = 0; i < array.Length; i++)
									{
										string[] array2 = array[i].Split(new char[]
										{
											'\t'
										});
										if (array2.Length == 5 && Operators.CompareString(array2[0], "^", true) == 0)
										{
											IPEndPoint a_ = o0___oO.o0__.0.(array2[2]);
											this.Buddies.Oo___o.oo.(new IMBuddy(array2[1], a_, array2[3]));
											if (Operators.CompareString(array2[4], "None", true) != 0)
											{
												this.Buddies[array2[1]].LanIP = o0___oO.o0__.0.(array2[4]);
											}
											this.Buddies[array2[1]].Ready = true;
										}
										else if (array2.Length == 2 && Operators.CompareString(array2[0], "^", true) == 0)
										{
											this.Buddies.Oo___o.oo.(new IMBuddy(array2[1], null, null));
										}
									}
									if (this.Buddies.Count == this.Oo0__0.ooO0__o.)
									{
										break;
									}
								}
							}
						}
						if (this.ReceiveNotice)
						{
							IMBuddy imbuddy = new IMBuddy("[System]", null, null);
							imbuddy.SimpleName = "系统通知";
							this.Buddies.Oo___o.oo.(imbuddy);
						}
						if (!o0OO__.OO0oO.o.() && this.Buddies.Count > 20)
						{
							IMBuddyCollections imbuddyCollections = new IMBuddyCollections();
							try
							{
								foreach (IMBuddy a_2 in this.Buddies)
								{
									imbuddyCollections.Oo___o.oo.(a_2);
									if (imbuddyCollections.Count >= 20)
									{
										break;
									}
								}
							}
							finally
							{
								IEnumerator<IMBuddy> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							this.oOO0O.O0O0. = imbuddyCollections;
						}
						try
						{
							foreach (IMBuddy imbuddy2 in this.Buddies)
							{
								if (imbuddy2.OnLine)
								{
									if (imbuddy2.oOo.o0__0Oo0oO. == 0 && imbuddy2.LanIP != null)
									{
										string text = imbuddy2.WanIP.ToString();
										string text2 = this.WanIP.ToString();
										text = text.Substring(0, text.IndexOf(":"));
										text2 = text2.Substring(0, text2.IndexOf(":"));
										if (Operators.CompareString(text, text2, true) == 0)
										{
											this.O.00O0_O_o_oO.(imbuddy2.LanIP, "#1\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.);
										}
									}
									this.O.00O0_O_o_oO.(imbuddy2.Name, "#\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.);
									imbuddy2.LastReceiveHeartbeatTime = DateTime.Now;
									imbuddy2.O00OO.o_. = DateTime.Now;
								}
							}
						}
						finally
						{
							IEnumerator<IMBuddy> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						this.O0.O0OOo.();
						if (this.O00.O0..Count > 0)
						{
							List<string> list = new List<string>();
							List<string> list2 = new List<string>();
							try
							{
								foreach (string text3 in this.O00.O0..Keys)
								{
									list.Add(text3);
									list2.Add(this.O00.O0.[text3]);
								}
							}
							finally
							{
								Dictionary<string, string>.KeyCollection.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							this.OOO__.0.(list, list2);
						}
						dataView = new DataView(this.oOOOo0.oo0OoO0., "[Read] = 0", "Name", DataViewRowState.CurrentRows);
					}
					if (dataView.Count > 0)
					{
						string text4 = dataView[0]["Name"].ToString();
						int num = 1;
						int num2 = dataView.Count - 1;
						for (int j = 1; j <= num2; j++)
						{
							if (Operators.CompareString(dataView[j]["Name"].ToString(), text4, true) == 0)
							{
								num++;
							}
							else
							{
								this.oOO0O.O0O0.(text4, num);
								num = 1;
								text4 = dataView[j]["Name"].ToString();
							}
						}
						this.oOO0O.O0O0.(text4, num);
					}
				}
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000A2CF8 File Offset: 0x000A0EF8
		private void <<EMPTY_NAME>>(string A_0, int A_1)
		{
			if (this.oo.___oo__0_O..ContainsKey(A_0))
			{
				this.oo.___oo__0_O.[A_0].oo.0o_0O0_0. = A_1;
				return;
			}
			if (this.oo.___oo__0_O..ContainsKey(A_0))
			{
				this.oo.___oo__0_O.[A_0].oo.0o_0O0_0. = A_1;
				return;
			}
			if (this.Buddies.Contains(A_0))
			{
				this.Buddies[A_0].oo.0o_0O0_0. = A_1;
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000A2D68 File Offset: 0x000A0F68
		private void <<EMPTY_NAME>>()
		{
			if (!this.O0_OOo.O.)
			{
				UdpClient udpClient = new UdpClient(0);
				o0___oO.O.oOo0O0O.(udpClient);
				udpClient.Client.ReceiveBufferSize = 81920;
				string s = "+$\v" + this.o_00o.O. + "\v" + this.o_oo0Oooo.OOO_.;
				byte[] bytes = Encoding.Unicode.GetBytes(s);
				udpClient.Send(bytes, bytes.Length, this.ooOo.oO0.);
				Oo0_0o0_OoO0O oo0_0o0_OoO0O = new Oo0_0o0_OoO0O(udpClient, this.ooOo.oO0.);
				if (oo0_0o0_OoO0O.oOo0O_o_.oO_o.())
				{
					string text = oo0_0o0_OoO0O.oOo0O_o_.oO_o.();
					if (Operators.CompareString(text, "", true) == 0)
					{
						this.oOOOo0.oo0OoO0..Fill(this.oOOOo0.oo0OoO0.);
						return;
					}
					string[] array = text.Split(new char[]
					{
						'\f'
					});
					List<Client_MessageEventargs> list = new List<Client_MessageEventargs>();
					List<weMessageReceived> list2 = new List<weMessageReceived>();
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i = checked(i + 1))
					{
						string[] array3 = array2[i].Split(new char[]
						{
							'\v'
						});
						if (Operators.CompareString(array3[0], "*", true) == 0 && array3.Length == 7)
						{
							if (Operators.CompareString(array3[1], this.UserName, true) == 0)
							{
								ooo0 ooo = new ooo0(array3[2], this.WanIP, array3[4], array3[3]);
								ooo.O0_.OO.(Conversions.ToDate(array3[6]));
								List<IMBuddy> list3 = new List<IMBuddy>();
								foreach (string text2 in array3[5].Split(new char[]
								{
									','
								}))
								{
									if (this.Buddies.Contains(text2))
									{
										list3.Add(this.Buddies[text2]);
									}
								}
								ooo.O0_.OO.(list3);
								this.oo.___oo__0_O..Add(ooo.Oo_0__o.o.(), ooo);
							}
							else if (this.Buddies.Contains(array3[1]))
							{
								O_0OOOoO o_0OOOoO = new O_0OOOoO(array3[2], array3[4], this.Buddies[array3[1]], array3[3], array3[5]);
								o_0OOOoO.O0O0o_.00O.(Conversions.ToDate(array3[6]));
								this.oo.___oo__0_O..Add(o_0OOOoO.O_O0_o._O0o0O.(), o_0OOOoO);
							}
							DataRow[] array5 = this.oo00000_0o0.oO..Select("MeetingKey = '" + array3[4] + "'");
							DataRow dataRow;
							if (array5.Length > 0)
							{
								dataRow = array5[0];
							}
							else
							{
								dataRow = this.oo00000_0o0.oO..NewRow();
								dataRow["MeetingKey"] = array3[4];
								this.oo00000_0o0.oO..Rows.Add(dataRow);
							}
							dataRow["Hostess"] = array3[1];
							dataRow["MeetingName"] = array3[2];
							dataRow["DateTime"] = array3[6];
							dataRow["Description"] = array3[3];
							dataRow["Members"] = array3[5];
							dataRow["Finish"] = false;
						}
						else if (Operators.CompareString(array3[0], "*", true) == 0 && array3.Length == 8)
						{
							if (!this.oo.___oo__0_O..ContainsKey(array3[4]) && !this.oo.___oo__0_O..ContainsKey(array3[4]))
							{
								DataRow dataRow2 = this.oo00000_0o0.oO..NewRow();
								dataRow2["MeetingKey"] = array3[4];
								dataRow2["Hostess"] = array3[1];
								dataRow2["MeetingName"] = array3[2];
								dataRow2["DateTime"] = array3[6];
								dataRow2["Description"] = array3[3];
								dataRow2["Members"] = array3[5];
								dataRow2["Finish"] = true;
								this.oo00000_0o0.oO..Rows.Add(dataRow2);
							}
						}
						else if (array3.Length == 4 && Operators.CompareString(array3[0], "$", true) == 0)
						{
							if (this.Buddies.Contains(array3[1]) || Operators.CompareString(array3[1], "", true) == 0)
							{
								if (array3[2].StartsWith("={") && array3[2].EndsWith("}="))
								{
									DataRow dataRow3 = this.oOOOo0.oo0OoO0..NewRow();
									dataRow3["Name"] = array3[1];
									dataRow3["Type"] = 1;
									string text3 = array3[2].Substring(2, array3[2].Length - 4);
									if (text3.StartsWith("{!}"))
									{
										text3 = text3.Substring(3);
										string text4 = array3[1];
										if (Operators.CompareString(text4, "[System]", true) == 0)
										{
											text4 = "系统通知";
										}
										OO_00oOO.PopMessage(text3, text4, PopiconEnum.Infomation, -1);
									}
									dataRow3["Content"] = text3;
									dataRow3["Time"] = Conversions.ToDate(array3[3]);
									dataRow3["Read"] = 0;
									this.oOOOo0.oo0OoO0..Rows.Add(dataRow3);
								}
								else
								{
									Client_MessageEventargs client_MessageEventargs = new Client_MessageEventargs(this, array3[1], array3[2]);
									DateTime dateTime;
									if (DateTime.TryParse(array3[3], out dateTime))
									{
										client_MessageEventargs.SendTime = client_MessageEventargs.SendTime;
									}
									list.Add(client_MessageEventargs);
								}
							}
						}
						else if (array3.Length == 4 && Operators.CompareString(array3[0], "=$", true) == 0)
						{
							if (array3[2].StartsWith("={") && array3[2].EndsWith("}="))
							{
								DataRow dataRow4 = this.oOOOo0.oo0OoO0..NewRow();
								if (array3[1].IndexOf('\t') < 0)
								{
									dataRow4["Name"] = array3[1];
								}
								else
								{
									string[] array6 = array3[1].Split(new char[]
									{
										'\t'
									});
									dataRow4["Name"] = array6[0];
									if (!this.O00.O0..ContainsKey(array6[0]) && array6.Length == 2)
									{
										this.O00.O0..Add(array6[0], array6[1]);
									}
								}
								dataRow4["Type"] = 1;
								string text5 = array3[2].Substring(2, array3[2].Length - 4);
								if (text5.StartsWith("{!}"))
								{
									text5 = text5.Substring(3);
								}
								dataRow4["Content"] = text5;
								dataRow4["Time"] = Conversions.ToDate(array3[3]);
								dataRow4["Read"] = 0;
								this.oOOOo0.oo0OoO0..Rows.Add(dataRow4);
							}
							else
							{
								string text6 = array3[2];
								int a_;
								if (text6.StartsWith("\u0002=?") && text6.EndsWith("?="))
								{
									a_ = 1;
								}
								else if (text6.StartsWith("\u0002<?") && text6.EndsWith("?>"))
								{
									a_ = 2;
								}
								weMessageReceived item = new weMessageReceived(this, array3[1], a_, text6);
								list2.Add(item);
							}
						}
						else if (array3.Length == 5 && Operators.CompareString(array3[0], "*1", true) == 0)
						{
							DataRow dataRow5 = this.oOOOo0.oo0OoO0..NewRow();
							dataRow5["Name"] = array3[2];
							dataRow5["Type"] = 1;
							dataRow5["Content"] = array3[3];
							dataRow5["Time"] = Conversions.ToDate(array3[4]);
							dataRow5["Read"] = 0;
							dataRow5["MeetingSender"] = array3[1];
							this.oOOOo0.oo0OoO0..Rows.Add(dataRow5);
						}
					}
					this.oo00000_0o0.oO..Update(this.oo00000_0o0.oO.);
					this.oOOOo0.oo0OoO0..Update(this.oOOOo0.oo0OoO0.);
					this.oOOOo0.oo0OoO0..Rows.Clear();
					this.oOOOo0.oo0OoO0..Fill(this.oOOOo0.oo0OoO0.);
					try
					{
						foreach (Client_MessageEventargs client_MessageEventargs2 in list)
						{
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_ReceivedMessage", new object[]
							{
								client_MessageEventargs2
							}, true, "项目", false);
						}
					}
					finally
					{
						List<Client_MessageEventargs>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (weMessageReceived weMessageReceived in list2)
						{
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_WeMessageReceived", new object[]
							{
								weMessageReceived
							}, true, "项目", false);
						}
					}
					finally
					{
						List<weMessageReceived>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000A3618 File Offset: 0x000A1818
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string SendWait(params object[] args)
		{
			string result;
			if (args.Length == 1)
			{
				result = this.SendWait(Conversions.ToString(args[0]), -1);
			}
			else if (args.Length == 2)
			{
				result = this.SendWait(Conversions.ToString(args[0]), Conversions.ToInteger(args[1]));
			}
			return result;
		}

		/// <summary>
		/// 用于向服务器发送信息，并在收到服务器回复之前，停止执行后续代码
		/// </summary>
		/// <param name="msg">消息内容</param>
		/// <param name="TimeOut">整数型，可选参数，用于设置等待时间，默认值为5，单位为秒，如果在此时间内没有收到服务器回复，则继续执行后续代码</param>
		// Token: 0x060016A3 RID: 5795 RVA: 0x000A365C File Offset: 0x000A185C
		[oO0oooo("2991")]
		public string SendWait(string msg, int TimeOut = -1)
		{
			string result;
			if (this.O0_OOo.O.)
			{
				result = "";
			}
			else
			{
				this.o0.0o_00.();
				if (TimeOut == -1)
				{
					TimeOut = this.O0Oo0OO.O.;
				}
				TimeOut = Math.Max(1, TimeOut);
				msg = string.Concat(new string[]
				{
					"$\v",
					this.o_00o.O.,
					"\v",
					msg,
					"\v",
					this.o_oo0Oooo.OOO_.
				});
				byte[] bytes = Encoding.Unicode.GetBytes(msg);
				this.O00._Oo..Send(bytes, bytes.Length, this.ooOo.oO0.);
				DateTime now = DateTime.Now;
				while (DateTime.Compare(DateTime.Now, now.AddSeconds((double)TimeOut)) < 0)
				{
					if (this.O00._Oo..Available > 0)
					{
						IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
						byte[] bytes2 = this.O00._Oo..Receive(ref ipendPoint);
						string[] array = Encoding.Unicode.GetString(bytes2).Split(new char[]
						{
							'\v'
						});
						if (array.Length == 4 && Operators.CompareString(array[3], this.o_oo0Oooo.OOO_., true) == 0)
						{
							return array[2];
						}
						return "";
					}
				}
				result = "";
			}
			return result;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000A378C File Offset: 0x000A198C
		internal string <<EMPTY_NAME>>(string A_0, int A_1 = -1)
		{
			string result;
			if (this.O0_OOo.O.)
			{
				result = "";
			}
			else
			{
				this.o0.0o_00.();
				if (A_1 == -1)
				{
					A_1 = this.O0Oo0OO.O.;
				}
				A_1 = Math.Max(1, A_1);
				byte[] bytes = Encoding.Unicode.GetBytes(A_0);
				this.O00._Oo..Send(bytes, bytes.Length, this.ooOo.oO0.);
				DateTime now = DateTime.Now;
				while (DateTime.Compare(DateTime.Now, now.AddSeconds((double)A_1)) < 0)
				{
					if (this.O00._Oo..Available > 0)
					{
						IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
						byte[] bytes2 = this.O00._Oo..Receive(ref ipendPoint);
						return Encoding.Unicode.GetString(bytes2);
					}
				}
				result = "";
			}
			return result;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x000A3848 File Offset: 0x000A1A48
		private void <<EMPTY_NAME>>()
		{
			while (this.O00._Oo..Available > 0)
			{
				IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
				this.O00._Oo..Receive(ref ipendPoint);
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000A3880 File Offset: 0x000A1A80
		internal void <<EMPTY_NAME>>(object A_0)
		{
			object buddies = this.Buddies;
			lock (buddies)
			{
				if (!this.O0_OOo.O.)
				{
					string s = "#\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.;
					byte[] bytes = Encoding.Unicode.GetBytes(s);
					byte[] bytes2 = Encoding.Unicode.GetBytes("###\v" + this.UserName + "\v" + this.o_oo0Oooo.OOO_.);
					if (!this.StopHeartbratServer)
					{
						this.ooOo.oO0..Send(bytes, bytes.Length, this.ooOo.oO0.);
					}
					if (!this.StopHeartbratBuddy)
					{
						try
						{
							foreach (IMBuddy imbuddy in this.Buddies)
							{
								if (imbuddy.OnLine)
								{
									this.ooOo.oO0..Send(bytes, bytes.Length, imbuddy.WanIP);
									if (imbuddy.O00OO.o_. == 0 && imbuddy.oO0.OooOOO00. < 3)
									{
										this.ooOo.oO0..Send(bytes2, bytes2.Length, imbuddy.WanIP);
										imbuddy.oO0.OooOOO00.++;
									}
								}
							}
						}
						finally
						{
							IEnumerator<IMBuddy> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
				}
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000A39EC File Offset: 0x000A1BEC
		internal DataRow <<EMPTY_NAME>>(string A_0, string A_1, int A_2, int A_3, string A_4)
		{
			try
			{
				if (this.oOO0O.O0O0. != null)
				{
					DataRow dataRow = this.oOOOo0.oo0OoO0..NewRow();
					dataRow["Name"] = A_0;
					dataRow["Type"] = A_2;
					dataRow["Content"] = A_1;
					dataRow["Time"] = DateTime.Now;
					dataRow["Read"] = A_3;
					dataRow["MeetingSender"] = A_4;
					this.oOOOo0.oo0OoO0..Rows.Add(dataRow);
					this.oOOOo0.oo0OoO0..Update(new DataRow[]
					{
						dataRow
					});
					dataRow["_Identify"] = RuntimeHelpers.GetObjectValue(this.ooOooo.oO..ExecuteScalar());
					dataRow.AcceptChanges();
					IMBuddy imbuddy = null;
					if (A_4 == null)
					{
						if (!this.Buddies.Contains(A_0))
						{
							return null;
						}
						imbuddy = this.Buddies[A_0];
					}
					else if (this.oo.___oo__0_O..ContainsKey(A_0))
					{
						imbuddy = this.oo.___oo__0_O.[A_0];
					}
					else if (this.oo.___oo__0_O..ContainsKey(A_0))
					{
						imbuddy = this.oo.___oo__0_O.[A_0];
					}
					else
					{
						if (this.ooOooo.oO..o.0_0_Ooo. != null && this.ooOooo.oO..o.0_0_Ooo..Tag is o0o0_oo00Oo)
						{
							o0o0_oo00Oo o0o0_oo00Oo = (o0o0_oo00Oo)this.ooOooo.oO..o.0_0_Ooo..Tag;
							if (this.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()))
							{
								imbuddy = this.oo.___oo__0_O.[o0o0_oo00Oo.OO.O_o__.()];
							}
							else if (this.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()))
							{
								imbuddy = this.oo.___oo__0_O.[o0o0_oo00Oo.OO.O_o__.()];
							}
						}
						if (imbuddy == null)
						{
							return null;
						}
					}
					if (this.ooOooo.oO. != null && this.ooOooo.oO..Oo0_O0o.o_.)
					{
						if (this.ooOooo.oO..o.0_0_Ooo. != null && this.ooOooo.oO..o.0_0_Ooo..Tag == imbuddy && this.ooOooo.oO..o.0_0_Ooo..TopicPage.Index != 0)
						{
							this.ooOooo.oO..OooOO_o0O0_._.();
						}
						C1TopicLink c1TopicLink = this.ooOooo.oO..Oo.Oo00__oooo.().Pages[0].FindLinkByTag(imbuddy);
						bool flag = false;
						if (c1TopicLink != this.ooOooo.oO..o.0_0_Ooo. && c1TopicLink != null && this.ooOooo.oO..o.0_0_Ooo. != null && this.ooOooo.oO..o.0_0_Ooo..Tag is o0o0_oo00Oo)
						{
							o0o0_oo00Oo o0o0_oo00Oo2 = (o0o0_oo00Oo)this.ooOooo.oO..o.0_0_Ooo..Tag;
							if (this.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo2.OO.O_o__.()) && c1TopicLink.Tag == this.oo.___oo__0_O.[o0o0_oo00Oo2.OO.O_o__.()])
							{
								flag = true;
							}
							else if (this.oo.___oo__0_O..ContainsKey(o0o0_oo00Oo2.OO.O_o__.()) && c1TopicLink.Tag == this.oo.___oo__0_O.[o0o0_oo00Oo2.OO.O_o__.()])
							{
								flag = true;
							}
						}
						if ((c1TopicLink != null && this.ooOooo.oO..o.0_0_Ooo. == c1TopicLink) || flag)
						{
							Oo0O oo0O = this.ooOooo.oO..O_0oOOO_.OO.();
							oo0O.BeginUpdate();
							this.ooOooo.oO..O_0.00o.(oo0O, dataRow);
							oo0O.EndUpdate();
							oo0O.ShowCell(oo0O.Rows.Count - 1, 0);
							if (oo0O.Row == 0)
							{
								oo0O.Select(1, 1, 2, 1);
							}
						}
						else
						{
							imbuddy.oo.0o_0O0_0.++;
							if (c1TopicLink == null)
							{
								c1TopicLink = new C1TopicLink();
								c1TopicLink.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")";
								c1TopicLink.Tag = imbuddy;
								if (imbuddy is ooo0 || imbuddy is O_0OOOoO)
								{
									c1TopicLink.ImageIndex = 9;
								}
								else if (imbuddy.FromWeChat)
								{
									c1TopicLink.ImageIndex = 20;
								}
								else if (imbuddy.OnLine)
								{
									c1TopicLink.ImageIndex = 0;
								}
								else
								{
									c1TopicLink.ImageIndex = 1;
								}
								this.ooOooo.oO..Oo.Oo00__oooo.().Pages[0].Links.Add(c1TopicLink);
								if (!this.ooOooo.oO..Oo.Oo00__oooo.().Pages[0].PageVisible)
								{
									this.ooOooo.oO..Oo.Oo00__oooo.().Pages[0].PageVisible = true;
								}
							}
							else
							{
								c1TopicLink.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")";
							}
						}
					}
					else if (A_3 == 0)
					{
						imbuddy.oo.0o_0O0_0.++;
					}
					if (A_2 == 1 && OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav"))
					{
						OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background);
					}
					return dataRow;
				}
				return null;
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			return null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000A3F08 File Offset: 0x000A2108
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				if (!OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "QQClient"))
				{
					OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "QQClient");
				}
				if (!OO_00oOO.FileSys.FileExists(OO_00oOO.ProjectPath + "QQClient\\" + this.DataFile))
				{
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "IMclient.mdb", OO_00oOO.ProjectPath + "QQClient\\" + this.DataFile);
				}
				this.oOOOo0.oo0OoO0. = new DataTable();
				this.oo00000_0o0.oO. = new DataTable();
				this.oOO0O.O0O0. = new OleDbConnection(Oo00.o_._0OOo.(OO_00oOO.ProjectPath + "QQClient\\" + this.DataFile));
				this.oOOOo0.oo0OoO0. = new OleDbDataAdapter("Select * From [Messages] Where [Read] = 0", this.oOO0O.O0O0.);
				this.oOOOo0.oo0OoO0..FillSchema(this.oOOOo0.oo0OoO0., SchemaType.Source);
				this.oo00000_0o0.oO. = new OleDbDataAdapter("Select * From [Meetings]", this.oOO0O.O0O0.);
				this.oo00000_0o0.oO..FillSchema(this.oo00000_0o0.oO., SchemaType.Source);
				this.oo00000_0o0.oO..Fill(this.oo00000_0o0.oO.);
				o_O_o_oOoo__.OO_O0oO0.oooO_.(this.oOOOo0.oo0OoO0.);
				o_O_o_oOoo__.OO_O0oO0.oooO_.(this.oo00000_0o0.oO.);
				this.ooOooo.oO. = new OleDbCommand("Select @@IDENTITY", this.oOO0O.O0O0.);
				this.oOO0O.O0O0..Open();
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000A40A8 File Offset: 0x000A22A8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenChatWindow(params object[] args)
		{
			if (args.Length == 0)
			{
				this.OpenChatWindow();
				return;
			}
			if (args.Length == 1)
			{
				this.OpenChatWindow(Conversions.ToString(args[0]));
				return;
			}
			if (args.Length == 2)
			{
				this.OpenChatWindow(Conversions.ToString(args[0]), Conversions.ToString(args[1]));
			}
		}

		/// <summary>
		/// 打开内置聊天窗口
		/// </summary>
		// Token: 0x060016AA RID: 5802 RVA: 0x000A40E7 File Offset: 0x000A22E7
		[oO0oooo("2993")]
		public void OpenChatWindow()
		{
			this.OpenChatWindow("", "");
		}

		/// <summary>
		/// 打开内置聊天窗口
		/// </summary>
		/// <param name="Caption">指定内置聊天窗口的标题</param>
		// Token: 0x060016AB RID: 5803 RVA: 0x000A40F9 File Offset: 0x000A22F9
		[oO0oooo("2993")]
		public void OpenChatWindow(string Caption)
		{
			this.OpenChatWindow(Caption, "");
		}

		/// <summary>
		/// 打开内置聊天窗口
		/// </summary>
		/// <param name="Caption">指定内置聊天窗口的标题</param>
		/// <param name="ImageFile">用于指定内置聊天窗口的图标文件，必须为Icon格式</param>
		// Token: 0x060016AC RID: 5804 RVA: 0x000A4108 File Offset: 0x000A2308
		[oO0oooo("2993")]
		public void OpenChatWindow(string Caption, string ImageFile)
		{
			if (this.ooOooo.oO. == null)
			{
				f4 f = new f4(this);
				this.ooOooo.oO. = f;
				f.Owner = OO_00oOO.BaseMainForm;
				f.oOo00_.0Oo.().Enabled = this.AllowSendFile;
				if (Operators.CompareString(Caption, "", true) > 0)
				{
					f.Text = Caption + "(" + this.UserName + ")";
				}
				if (!string.IsNullOrEmpty(ImageFile))
				{
					if (string.IsNullOrEmpty(Path.GetPathRoot(ImageFile)))
					{
						if (OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + ImageFile))
						{
							ImageFile = O_O0OO.OOo_o.0o. + ImageFile;
						}
						else
						{
							ImageFile = ooO.OoO0o_o___.O.(ImageFile);
						}
						if (!File.Exists(ImageFile))
						{
							ImageFile = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\images\\" + c.OOOOO.o.().FileSystem.GetName(ImageFile);
						}
					}
					if (OO_00oOO.FileSys.FileExists(ImageFile))
					{
						f.Icon = new Icon(ImageFile);
					}
				}
				f.Show();
			}
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000A4214 File Offset: 0x000A2414
		internal void <<EMPTY_NAME>>(IMBuddy A_0)
		{
			A_0.OnLine = false;
			if (this.ooOooo.oO. != null && this.ooOooo.oO..Oo0_O0o.o_.)
			{
				try
				{
					foreach (object obj in this.ooOooo.oO..Oo.Oo00__oooo.().Pages)
					{
						C1TopicPage c1TopicPage = (C1TopicPage)obj;
						C1TopicLink c1TopicLink = c1TopicPage.FindLinkByTag(A_0);
						if (c1TopicLink != null)
						{
							if (c1TopicLink.TopicPage.Index == 0)
							{
								c1TopicLink.ImageIndex = 1;
							}
							else
							{
								c1TopicLink.ImageIndex = 12;
							}
							int num = 0;
							int num2 = c1TopicPage.Links.Count - 1;
							for (int i = 0; i <= num2; i++)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(c1TopicPage.Links[i].Tag);
								if (objectValue is ooo0 || objectValue is O_0OOOoO || ((IMBuddy)objectValue).OnLine)
								{
									num++;
								}
							}
							num = Math.Min(num, c1TopicPage.Links.Count - 1);
							if (num != c1TopicLink.Index)
							{
								c1TopicPage.Links.Remove(c1TopicLink);
								c1TopicPage.Links.Insert(num, c1TopicLink);
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (this.ooOooo.oO..o.0_0_Ooo. != null && this.ooOooo.oO..o.0_0_Ooo..Tag == A_0)
				{
					this.ooOooo.oO..oOoO.O_o__.("对方已经离线,您可以继续发送离线消息!");
				}
			}
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x000A4390 File Offset: 0x000A2590
		internal void <<EMPTY_NAME>>(object A_0)
		{
			object[] array = (object[])A_0;
			IMBuddy a_ = (IMBuddy)array[0];
			string a_2 = array[1].ToString();
			SendTypeEnum a_3 = (SendTypeEnum)Conversions.ToInteger(array[2]);
			oO0 a_4 = null;
			if (array[3] != null)
			{
				a_4 = (oO0)array[3];
			}
			bool a_5;
			if (array.Length == 5)
			{
				a_5 = Conversions.ToBoolean(array[4]);
			}
			this.o00O0._0O.(a_, a_2, a_3, a_4, a_5);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000A43F0 File Offset: 0x000A25F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SendFile(params object[] args)
		{
			switch (args.Length)
			{
			case 1:
				this.SendFile(Conversions.ToString(args[0]), false);
				return;
			case 2:
				if (args[1] is bool)
				{
					this.SendFile(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]));
					return;
				}
				this.SendFile(Conversions.ToString(args[0]), Conversions.ToString(args[1]), false);
				return;
			case 3:
				this.SendFile(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToBoolean(args[2]));
				return;
			default:
				return;
			}
		}

		/// <summary>
		/// 向好友发送文件
		/// </summary>
		/// <param name="BuddyName">好友名</param>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="ShowProcess">可选参数，辑型，是否显示发送进度，默认为False</param>
		// Token: 0x060016B0 RID: 5808 RVA: 0x000A4480 File Offset: 0x000A2680
		[oO0oooo("3020")]
		public void SendFile(string BuddyName, string FileName, bool ShowProcess = false)
		{
			if (OO_00oOO.FileSys.FileExists(FileName) && this.Buddies.Contains(BuddyName) && (this.Buddies[BuddyName].OnLine || this.Buddies[BuddyName].FromWeChat))
			{
				object[] array = new object[5];
				array[0] = this.Buddies[BuddyName];
				array[1] = FileName;
				if (this.Buddies[BuddyName].FromWeChat)
				{
					array[2] = SendTypeEnum.ManualFile;
				}
				else
				{
					array[2] = SendTypeEnum.AutoFile;
				}
				if (ShowProcess)
				{
					oO0 oO = new oO0(this, this.Buddies[BuddyName], FileName, SendTypeEnum.ManualFile);
					oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(FileName);
					oO.o.oo00_.().Visible = false;
					oO.OO0.oo_o00o.().Enabled = false;
					FileInfo fileInfo = new FileInfo(FileName);
					string text;
					if (fileInfo.Length / 1024L < 1000L)
					{
						text = (fileInfo.Length / 1024L).ToString() + "K";
					}
					else
					{
						text = Strings.Format((double)fileInfo.Length / 1024.0 / 1024.0, "0.00") + "M";
					}
					oO.o_0O.00.().Text = text;
					if (this.ooOooo.oO. == null)
					{
						this.ooOooo.oO. = new o\u3000\u3002\u3000\u3002\u3000(this);
						this.ooOooo.oO..Owner = OO_00oOO.BaseMainForm;
					}
					this.ooOooo.oO..O_0O_o.0.(oO);
					this.ooOooo.oO..Show();
					array[3] = oO;
				}
				else
				{
					array[3] = null;
				}
				array[4] = false;
				new Thread(new ParameterizedThreadStart(this.O00__O._O_00o.)).Start(array);
			}
		}

		/// <summary>
		/// 向服务器发送文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="ShowProcess">可选参数，逻辑型，是否显示发送进度，默认为False</param>
		// Token: 0x060016B1 RID: 5809 RVA: 0x000A4648 File Offset: 0x000A2848
		[oO0oooo("3020")]
		public void SendFile(string FileName, bool ShowProcess = false)
		{
			if (OO_00oOO.FileSys.FileExists(FileName))
			{
				object[] array = new object[5];
				array[0] = null;
				array[1] = FileName;
				array[2] = SendTypeEnum.AutoFile;
				if (ShowProcess)
				{
					oO0 oO = new oO0(this, null, FileName, SendTypeEnum.ManualFile);
					oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(FileName);
					oO.o.oo00_.().Visible = false;
					oO.OO0.oo_o00o.().Enabled = false;
					FileInfo fileInfo = new FileInfo(FileName);
					string text;
					if (fileInfo.Length / 1024L < 1000L)
					{
						text = (fileInfo.Length / 1024L).ToString() + "K";
					}
					else
					{
						text = Strings.Format((double)fileInfo.Length / 1024.0 / 1024.0, "0.00") + "M";
					}
					oO.o_0O.00.().Text = text;
					if (this.ooOooo.oO. == null)
					{
						this.ooOooo.oO. = new o\u3000\u3002\u3000\u3002\u3000(this);
						this.ooOooo.oO..Owner = OO_00oOO.BaseMainForm;
					}
					this.ooOooo.oO..O_0O_o.0.(oO);
					this.ooOooo.oO..Show();
					array[3] = oO;
				}
				else
				{
					array[3] = null;
				}
				array[4] = false;
				new Thread(new ParameterizedThreadStart(this.O00__O._O_00o.)).Start(array);
			}
		}

		/// <summary>
		/// 用于向好友或者会议发送文件
		/// </summary>
		/// <param name="BuddyName">好友名称或会议名称</param>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="ShowProcess">可选参数，辑型，是否显示发送进度，默认为False</param>
		// Token: 0x060016B2 RID: 5810 RVA: 0x000A47A0 File Offset: 0x000A29A0
		[oO0oooo("3022")]
		public void SendChatFile(string BuddyName, string FileName, bool ShowProcess = false)
		{
			if (OO_00oOO.FileSys.FileExists(FileName))
			{
				this.O.00O0_O_o_oO.(BuddyName, FileName, false, ShowProcess);
			}
		}

		/// <summary>
		/// 用于向好友或者会议发送图片
		/// </summary>
		/// <param name="BuddyName">好友名称或会议名称</param>
		/// <param name="FileName">图片文件名，含路径</param>
		/// <param name="ShowProcess">可选参数，辑型，是否显示发送进度，默认为False</param>
		// Token: 0x060016B3 RID: 5811 RVA: 0x000A47B9 File Offset: 0x000A29B9
		[oO0oooo("3023")]
		public void SendChatImage(string BuddyName, string FileName, bool ShowProcess = false)
		{
			if (OO_00oOO.FileSys.FileExists(FileName))
			{
				this.O.00O0_O_o_oO.(BuddyName, FileName, true, ShowProcess);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000A47D4 File Offset: 0x000A29D4
		private void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2, bool A_3)
		{
			string a_ = null;
			string a_2 = null;
			IMBuddy imbuddy = null;
			if (OO_00oOO.FileSys.FileExists(A_1))
			{
				if (this.Buddies.Contains(A_0))
				{
					imbuddy = this.Buddies[A_0];
					a_2 = A_0;
				}
				if (imbuddy == null)
				{
					try
					{
						foreach (ooo0 ooo in this.oo.___oo__0_O..Values)
						{
							if (Operators.CompareString(ooo.oo.o0.(), A_0, true) == 0)
							{
								imbuddy = ooo;
								a_2 = ooo.Oo_0__o.o.();
								a_ = this.UserName;
							}
						}
					}
					finally
					{
						Dictionary<string, ooo0>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (imbuddy == null)
				{
					try
					{
						foreach (O_0OOOoO o_0OOOoO in this.oo.___oo__0_O..Values)
						{
							if (Operators.CompareString(o_0OOOoO.Name, A_0, true) == 0)
							{
								imbuddy = o_0OOOoO;
								a_2 = o_0OOOoO.O_O0_o._O0o0O.();
								a_ = this.UserName;
							}
						}
					}
					finally
					{
						Dictionary<string, O_0OOOoO>.ValueCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (imbuddy != null)
				{
					if (A_2)
					{
						string text;
						if (A_1.StartsWith(OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\", StringComparison.CurrentCultureIgnoreCase))
						{
							text = A_1.Substring((OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\").Length);
						}
						else
						{
							string text2 = string.Concat(new string[]
							{
								OO_00oOO.ProjectPath,
								"QQClient\\CaptureFiles\\",
								Strings.Format(DateTime.Today, "yyyyMM"),
								"\\",
								OoOo0O.OO_o.0o_O.(10),
								Path.GetExtension(A_1)
							});
							OO_00oOO.FileSys.CopyFile(A_1, text2, true);
							text = text2.Substring((OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\").Length);
							A_1 = text2;
						}
						text = "\u0002=(" + text + ")=";
						this.O.00O0_O_o_oO.(a_2, text, 2, 1, a_);
					}
					object[] array = new object[5];
					array[0] = imbuddy;
					array[1] = A_1;
					if (A_2)
					{
						array[2] = SendTypeEnum.Capture;
					}
					else
					{
						array[2] = SendTypeEnum.ManualFile;
					}
					if (A_3)
					{
						oO0 oO = new oO0(this, imbuddy, A_1, SendTypeEnum.ManualFile);
						oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(A_1);
						oO.o.oo00_.().Visible = false;
						oO.OO0.oo_o00o.().Enabled = false;
						FileInfo fileInfo = new FileInfo(A_1);
						string text3;
						if (fileInfo.Length / 1024L < 1000L)
						{
							text3 = (fileInfo.Length / 1024L).ToString() + "K";
						}
						else
						{
							text3 = Strings.Format((double)fileInfo.Length / 1024.0 / 1024.0, "0.00") + "M";
						}
						oO.o_0O.00.().Text = text3;
						if (this.ooOooo.oO. == null)
						{
							this.ooOooo.oO. = new o\u3000\u3002\u3000\u3002\u3000(this);
							this.ooOooo.oO..Owner = OO_00oOO.BaseMainForm;
						}
						this.ooOooo.oO..O_0O_o.0.(oO);
						this.ooOooo.oO..Show();
						array[3] = oO;
					}
					else
					{
						array[3] = null;
					}
					array[4] = false;
					new Thread(new ParameterizedThreadStart(this.O00__O._O_00o.)).Start(array);
				}
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000A4B24 File Offset: 0x000A2D24
		internal void <<EMPTY_NAME>>(IMBuddy A_0, string A_1, SendTypeEnum A_2, oO0 A_3, bool A_4)
		{
			string text = OoOo0O.OO_o.0o_O.(6);
			if (A_3 != null)
			{
				text = A_3.o0O.Oo.;
			}
			UdpClient udpClient = new UdpClient(0);
			o0___oO.O.oOo0O0O.(udpClient);
			udpClient.Client.SendBufferSize = 81920;
			string text2 = "\v";
			bool flag;
			bool flag4;
			if (A_0 != null && !A_0.FromWeChat && A_0.oOo.o0__0Oo0oO. > 0 && A_0.O00OO.o_. > 0 && !A_4)
			{
				IPEndPoint ipendPoint = A_0.WanIP;
				if (ipendPoint.ToString().StartsWith("192.168.") || ipendPoint.ToString().StartsWith("127.0.0.1"))
				{
					string text3 = udpClient.Client.LocalEndPoint.ToString();
					text3 = text3.Substring(text3.IndexOf(":") + 1);
					string s = string.Concat(new string[]
					{
						"%1",
						text2,
						this.UserName,
						text2,
						this.o_oo0Oooo.OOO_.,
						text2,
						A_0.Name,
						text2,
						A_0.RandKey,
						text2,
						OO_00oOO.FileSys.GetName(A_1),
						text2,
						Conversions.ToString((int)A_2),
						text2,
						text3,
						text2,
						text
					});
					byte[] bytes = Encoding.Unicode.GetBytes(s);
					udpClient.Send(bytes, bytes.Length, this.ooOo.oO0.);
					DateTime now = DateTime.Now;
					flag = true;
					while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
					{
						if (udpClient.Available > 0)
						{
							IPEndPoint ipendPoint2 = new IPEndPoint(IPAddress.Any, 0);
							byte[] bytes2 = udpClient.Receive(ref ipendPoint2);
							int port;
							if (int.TryParse(Encoding.Unicode.GetString(bytes2), out port))
							{
								IPEndPoint a_ = new IPEndPoint(A_0.WanIP.Address, port);
								O_0__O_o_O o_0__O_o_O = new O_0__O_o_O(this, udpClient, a_, A_1, A_0, text, A_2);
								o_0__O_o_O.O00o___0OoO.0. = A_3;
								bool flag2 = false;
								object obj = this.ooOooo.oO.;
								lock (obj)
								{
									if (!this.ooOooo.oO..ContainsKey(o_0__O_o_O.O_OO.o0o_o0.()))
									{
										this.ooOooo.oO..Add(o_0__O_o_O.O_OO.o0o_o0.(), o_0__O_o_O);
										flag2 = true;
									}
								}
								if (flag2)
								{
									flag4 = true;
									o_0__O_o_O.o0o_0OO00.Oo0_.();
									break;
								}
								break;
							}
						}
					}
				}
			}
			if (flag)
			{
				if (!flag4 && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
				{
					if (A_2 == SendTypeEnum.Capture)
					{
						OO_00oOO.BaseMainForm.Invoke(new IMClient.OO_0_(this.O0.O0OOo.), new object[]
						{
							A_0,
							A_1
						});
						return;
					}
					if (A_2 == SendTypeEnum.ManualFile)
					{
						OO_00oOO.BaseMainForm.Invoke(new IMClient.OO_0_(this.O.00O0_O_o_oO.), new object[]
						{
							A_0,
							A_1
						});
						return;
					}
				}
			}
			else
			{
				if (A_0 != null && !A_0.FromWeChat && A_0.oOo.o0__0Oo0oO. > 0 && A_0.O00OO.o_. > 0 && !A_4)
				{
					string s = string.Concat(new string[]
					{
						"%2",
						text2,
						this.UserName,
						text2,
						this.o_oo0Oooo.OOO_.,
						text2,
						OO_00oOO.FileSys.GetName(A_1),
						text2,
						Conversions.ToString((int)A_2),
						text2,
						A_0.Name,
						text2,
						A_0.RandKey,
						text2,
						text
					});
					byte[] bytes = Encoding.Unicode.GetBytes(s);
					udpClient.Send(bytes, bytes.Length, this.ooOo.oO0.);
					DateTime now = DateTime.Now;
					flag = true;
					while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
					{
						if (udpClient.Available > 0)
						{
							IPEndPoint ipendPoint3 = new IPEndPoint(IPAddress.Any, 0);
							byte[] bytes3 = udpClient.Receive(ref ipendPoint3);
							string[] array = Encoding.Unicode.GetString(bytes3).Split(new char[]
							{
								':'
							});
							if (array.Length == 2)
							{
								IPAddress address = IPAddress.Parse(array[0]);
								int port2;
								if (int.TryParse(array[1], out port2))
								{
									IPEndPoint a_ = new IPEndPoint(address, port2);
									O_0__O_o_O o_0__O_o_O2 = new O_0__O_o_O(this, udpClient, a_, A_1, A_0, text, A_2);
									o_0__O_o_O2.O00o___0OoO.0. = A_3;
									bool flag5 = false;
									object obj2 = this.ooOooo.oO.;
									lock (obj2)
									{
										if (!this.ooOooo.oO..ContainsKey(o_0__O_o_O2.O_OO.o0o_o0.()))
										{
											this.ooOooo.oO..Add(o_0__O_o_O2.O_OO.o0o_o0.(), o_0__O_o_O2);
											flag5 = true;
										}
									}
									if (flag5)
									{
										flag4 = true;
										o_0__O_o_O2.o0o_0OO00.Oo0_.();
										break;
									}
									break;
								}
							}
						}
					}
				}
				if (flag)
				{
					if (!flag4 && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
					{
						if (A_2 == SendTypeEnum.Capture)
						{
							OO_00oOO.BaseMainForm.Invoke(new IMClient.OO_0_(this.O0.O0OOo.), new object[]
							{
								A_0,
								A_1
							});
							return;
						}
						if (A_2 == SendTypeEnum.ManualFile)
						{
							OO_00oOO.BaseMainForm.Invoke(new IMClient.OO_0_(this.O.00O0_O_o_oO.), new object[]
							{
								A_0,
								A_1
							});
							return;
						}
					}
				}
				else
				{
					if (A_2 == SendTypeEnum.AutoFile && A_0 != null && !A_0.FromWeChat && !(A_0 is ooo0) && !(A_0 is O_0OOOoO))
					{
						if (A_0.OnLine)
						{
							string s = string.Concat(new string[]
							{
								"%10",
								text2,
								this.UserName,
								text2,
								this.o_oo0Oooo.OOO_.,
								text2,
								OO_00oOO.FileSys.GetName(A_1),
								text2,
								A_0.Name,
								text2,
								A_0.RandKey,
								text2,
								text
							});
							byte[] bytes = Encoding.Unicode.GetBytes(s);
							udpClient.Send(bytes, bytes.Length, this.ooOo.oO0.);
							DateTime now = DateTime.Now;
							while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
							{
								if (udpClient.Available > 0)
								{
									IPEndPoint ipendPoint4 = new IPEndPoint(IPAddress.Any, 0);
									byte[] bytes4 = udpClient.Receive(ref ipendPoint4);
									string[] array2 = Encoding.Unicode.GetString(bytes4).Split(new char[]
									{
										'\t'
									});
									int port3;
									if (array2.Length == 2 && int.TryParse(array2[0], out port3) && Operators.CompareString(array2[1], text, true) == 0)
									{
										IPEndPoint a_ = new IPEndPoint(this.ooOo.oO0..Address, port3);
										O_0__O_o_O o_0__O_o_O3 = new O_0__O_o_O(this, udpClient, a_, A_1, A_0, text, SendTypeEnum.AutoFile);
										bool flag7 = false;
										object obj3 = this.ooOooo.oO.;
										lock (obj3)
										{
											if (!this.ooOooo.oO..ContainsKey(o_0__O_o_O3.O_OO.o0o_o0.()))
											{
												this.ooOooo.oO..Add(o_0__O_o_O3.O_OO.o0o_o0.(), o_0__O_o_O3);
												flag7 = true;
											}
										}
										if (flag7)
										{
											flag4 = true;
											o_0__O_o_O3.o0o_0OO00.Oo0_.();
											break;
										}
										break;
									}
								}
							}
						}
					}
					else
					{
						string s = string.Concat(new string[]
						{
							"%3",
							text2,
							this.UserName,
							text2,
							this.o_oo0Oooo.OOO_.,
							text2,
							OO_00oOO.FileSys.GetName(A_1),
							text2,
							Conversions.ToString((int)A_2),
							text2,
							text
						});
						byte[] bytes = Encoding.Unicode.GetBytes(s);
						udpClient.Send(bytes, bytes.Length, this.ooOo.oO0.);
						DateTime now = DateTime.Now;
						while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
						{
							if (udpClient.Available > 0)
							{
								IPEndPoint ipendPoint5 = new IPEndPoint(IPAddress.Any, 0);
								byte[] bytes5 = udpClient.Receive(ref ipendPoint5);
								string[] array3 = Encoding.Unicode.GetString(bytes5).Split(new char[]
								{
									'\t'
								});
								int port4;
								if (array3.Length == 2 && int.TryParse(array3[1], out port4))
								{
									IPEndPoint a_ = new IPEndPoint(this.ooOo.oO0..Address, port4);
									O_0__O_o_O o_0__O_o_O4 = new O_0__O_o_O(this, udpClient, a_, A_1, A_0, text, A_2);
									o_0__O_o_O4.O00o___0OoO.0. = A_3;
									o_0__O_o_O4.o_OoO._.(array3[0]);
									bool flag9 = false;
									object obj4 = this.ooOooo.oO.;
									lock (obj4)
									{
										if (!this.ooOooo.oO..ContainsKey(o_0__O_o_O4.O_OO.o0o_o0.()))
										{
											this.ooOooo.oO..Add(o_0__O_o_O4.O_OO.o0o_o0.(), o_0__O_o_O4);
											flag9 = true;
										}
									}
									if (flag9)
									{
										flag4 = true;
										o_0__O_o_O4.o0o_0OO00.Oo0_.();
										break;
									}
									break;
								}
							}
						}
					}
					if (!flag4 && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
					{
						if (A_2 == SendTypeEnum.Capture)
						{
							OO_00oOO.BaseMainForm.Invoke(new IMClient.OO_0_(this.O0.O0OOo.), new object[]
							{
								A_0,
								A_1
							});
							return;
						}
						if (A_2 == SendTypeEnum.ManualFile)
						{
							OO_00oOO.BaseMainForm.Invoke(new IMClient.OO_0_(this.O.00O0_O_o_oO.), new object[]
							{
								A_0,
								A_1
							});
							return;
						}
						if (A_2 == SendTypeEnum.AutoFile)
						{
							AfterSendFileEventArgs afterSendFileEventArgs = new AfterSendFileEventArgs(Interaction.IIf(A_0 == null, "", A_0.Name).ToString(), A_1, false);
							OO_00oOO.BaseMainForm.Invoke(new IMClient.o_oOO_(this.OOO__.0.), new object[]
							{
								afterSendFileEventArgs
							});
						}
					}
				}
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000A54E0 File Offset: 0x000A36E0
		private void <<EMPTY_NAME>>(IMBuddy A_0, string A_1)
		{
			string a_ = "\u0002/\u0002=(" + A_1.Substring((OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\").Length) + ")=\\\u0002";
			this.O.00O0_O_o_oO.(A_0.Name, a_, 1, 1, null);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x000A5528 File Offset: 0x000A3728
		private void <<EMPTY_NAME>>(IMBuddy A_0, string A_1)
		{
			FileInfo fileInfo = new FileInfo(A_1);
			string a_ = string.Concat(new string[]
			{
				"\u0002{因网络问题，文件发送失败\"",
				OO_00oOO.FileSys.GetName(A_1),
				"\"(",
				o0___oO.o0__.0.(fileInfo.Length),
				")}\u0002"
			});
			this.O.00O0_O_o_oO.(A_0.Name, a_, 2, 1, null);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000A558D File Offset: 0x000A378D
		private void <<EMPTY_NAME>>(AfterSendFileEventArgs A_0)
		{
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_AfterSendFile", new object[]
			{
				A_0
			}, true, "项目", false);
		}

		/// <summary>
		/// 向服务端申请更改密码
		/// </summary>
		/// <param name="OldPassword">原密码</param>
		/// <param name="NewPassword">新密码</param>
		// Token: 0x060016B9 RID: 5817 RVA: 0x000A55B0 File Offset: 0x000A37B0
		[oO0oooo("2992")]
		public string ChangePassWord(string OldPassword, string NewPassword)
		{
			string text = "\v";
			string a_ = string.Concat(new string[]
			{
				".",
				text,
				this.UserName,
				text,
				this.o_oo0Oooo.OOO_.,
				text,
				OldPassword,
				text,
				NewPassword
			});
			return this.o00O0._0O.(a_, -1);
		}

		/// <summary>
		/// 请求QQServer发送指定的文件到本机
		/// </summary>
		/// <param name="FileName">指定要下载的文件名，包括相对路径</param>
		/// <param name="TimeOut">可选参数，指定等待服务器响应的时间，单位为秒，默认为5秒</param>
		/// <param name="ShowProcess">可选参数，辑型，是否显示接收进度，默认为False</param>
		// Token: 0x060016BA RID: 5818 RVA: 0x000A560C File Offset: 0x000A380C
		[oO0oooo("3044")]
		public int RequestFile(string FileName, int TimeOut = 5, bool ShowProcess = false)
		{
			this.o0.0o_00.();
			if ((DateTime.Now - this.O_00O_000.O0_.).TotalSeconds > 10.0)
			{
				this.O00._Oo..Clear();
			}
			this.O_00O_000.O0_. = DateTime.Now;
			string key = OO_00oOO.FileSys.GetName(FileName).ToLower();
			if (this.O00._Oo..ContainsKey(key))
			{
				this.O00._Oo..Remove(key);
			}
			if (ShowProcess)
			{
				this.O00._Oo..Add(key, DateTime.Now);
			}
			string text = string.Concat(new string[]
			{
				"%9\v",
				this.UserName,
				"\v",
				this.o_oo0Oooo.OOO_.,
				"\v",
				FileName
			});
			byte[] bytes = Encoding.Unicode.GetBytes(text);
			this.O00._Oo..Send(bytes, bytes.Length, this.ooOo.oO0.);
			DateTime now = DateTime.Now;
			while ((DateTime.Now - now).TotalSeconds < (double)TimeOut)
			{
				if (this.O00._Oo..Available > 0)
				{
					IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
					byte[] bytes2 = this.O00._Oo..Receive(ref ipendPoint);
					text = Encoding.Unicode.GetString(bytes2);
					break;
				}
			}
			int result;
			if (Operators.CompareString(text, "None", true) == 0)
			{
				result = 0;
			}
			else if (Operators.CompareString(text, "OK", true) == 0)
			{
				result = 1;
			}
			else
			{
				result = 2;
			}
			return result;
		}

		/// <summary>
		/// 增加微信好友
		/// </summary>
		/// <param name="id">微信号</param>
		/// <param name="Name">用户名</param>
		// Token: 0x060016BB RID: 5819 RVA: 0x000A5778 File Offset: 0x000A3978
		[oO0oooo("A4103")]
		public void AddWeChatUser(string id, string Name)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			list.Add(id);
			list2.Add(Name);
			this.AddWeChatUsers(list, list2);
		}

		/// <summary>
		/// 用于增加多个微信好友
		/// </summary>
		/// <param name="IDS"></param>
		/// <param name="Names"></param>
		// Token: 0x060016BC RID: 5820 RVA: 0x000A57A8 File Offset: 0x000A39A8
		[oO0oooo("A4104")]
		public void AddWeChatUsers(List<string> IDS, List<string> Names)
		{
			if (IDS.Count == Names.Count)
			{
				int num = IDS.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!this.O00.O0..ContainsKey(IDS[i]))
					{
						this.O00.O0..Add(IDS[i], Names[i]);
					}
				}
				if (this.Ready)
				{
					this.OOO__.0.(IDS, Names);
				}
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000A5818 File Offset: 0x000A3A18
		private void <<EMPTY_NAME>>(List<string> A_0, List<string> A_1)
		{
			int num = A_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!this.Buddies.Contains(A_0[i]))
				{
					IMBuddy imbuddy = new IMBuddy(A_0[i], A_1[i]);
					this.Buddies.Oo___o.oo.(imbuddy);
					imbuddy.oo.0o_0O0_0. = Conversions.ToInteger(this.oOOOo0.oo0OoO0..Compute("Count([_Identify])", "Name = '" + imbuddy.Name + "'"));
				}
			}
			if (this.ooOooo.oO. != null && this.ooOooo.oO..Oo0_O0o.o_.)
			{
				C1TopicPage c1TopicPage = this.ooOooo.oO..Oo.Oo00__oooo.().Pages[0];
				int num2 = A_0.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (this.Buddies.Contains(A_0[j]))
					{
						IMBuddy imbuddy2 = this.Buddies[A_0[j]];
						C1TopicPage c1TopicPage2 = this.ooOooo.oO..Oo.Oo00__oooo.().FindPage(imbuddy2.UserGroup);
						if (c1TopicPage2 == null)
						{
							c1TopicPage2 = new C1TopicPage();
							c1TopicPage2.Text = imbuddy2.UserGroup;
							c1TopicPage2.Collapsed = true;
							c1TopicPage2.ImageList = this.ooOooo.oO..O_0oOOO_.OO.();
							this.ooOooo.oO..Oo.Oo00__oooo.().Pages.Add(c1TopicPage2);
						}
						C1TopicLink c1TopicLink = new C1TopicLink();
						c1TopicLink.Text = imbuddy2.SimpleName;
						c1TopicLink.Tag = imbuddy2;
						c1TopicLink.ImageIndex = 20;
						c1TopicPage2.Links.Add(c1TopicLink);
						if (imbuddy2.oo.0o_0O0_0. > 0)
						{
							c1TopicLink = new C1TopicLink();
							if (imbuddy2.oo.0o_0O0_0. > 0)
							{
								c1TopicLink.Text = imbuddy2.SimpleName + "(" + Conversions.ToString(imbuddy2.oo.0o_0O0_0.) + ")";
							}
							else
							{
								c1TopicLink.Text = imbuddy2.SimpleName;
							}
							c1TopicLink.Tag = imbuddy2;
							c1TopicLink.ImageIndex = 20;
							c1TopicPage.Links.Add(c1TopicLink);
						}
					}
				}
			}
		}

		/// <summary>
		/// 返回未读消息数量，仅统计通过内置聊天窗口收发的信息
		/// </summary>
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x000A5A2C File Offset: 0x000A3C2C
		public int UnreadCount
		{
			get
			{
				return Conversions.ToInteger(RuntimeHelpers.GetObjectValue(this.oOOOo0.oo0OoO0..Compute("Count([_Identify])", "Read = 0")));
			}
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000A5A50 File Offset: 0x000A3C50
		private void <<EMPTY_NAME>>(IMBuddy A_0, string A_1, ooOoO A_2)
		{
			Oo0O__ oo0O__ = new Oo0O__(this, A_0, A_1, A_2.o0OO._0.());
			oo0O__.o_0.Oo_0O0_. = true;
			oo0O__.o.o_oo.().Text = OO_00oOO.FileSys.GetName(A_1);
			oo0O__.OOOO_.0O0o0.().Visible = false;
			oo0O__.o0_0oO.0o0_.().Enabled = false;
			if (this.ooOooo.oO. == null)
			{
				this.ooOooo.oO. = new o\u3000\u3002\u3000\u3002\u3000(this);
				this.ooOooo.oO..Owner = OO_00oOO.BaseMainForm;
			}
			this.ooOooo.oO..O_0O_o.0.(oo0O__);
			this.ooOooo.oO..Show();
			A_2.O0__00OoOo_O.o. = oo0O__;
		}

		/// <summary>
		/// 字符型，用于设置自定义菜单
		/// </summary>
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x000A5AE3 File Offset: 0x000A3CE3
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x000A5AEB File Offset: 0x000A3CEB
		[oO0oooo("3076")]
		public string MenuItems
		{
			get
			{
				return this.o_O.OOO.;
			}
			set
			{
				this.o_O.OOO. = value;
				if (this.ooOooo.oO. != null && this.ooOooo.oO..Oo0_O0o.o_.)
				{
					this.ooOooo.oO..o_0_o000O_0.O0.();
				}
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000A5B14 File Offset: 0x000A3D14
		internal void <<EMPTY_NAME>>(Form A_0)
		{
			if (this.ooOooo.oO. != null && this.ooOooo.oO..Visible)
			{
				Point location = this.ooOooo.oO..Location;
				int value = this.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Value;
				Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
				object obj = null;
				if (this.ooOooo.oO..o.0_0_Ooo. != null)
				{
					obj = RuntimeHelpers.GetObjectValue(this.ooOooo.oO..o.0_0_Ooo..Tag);
				}
				try
				{
					foreach (object obj2 in this.ooOooo.oO..Oo.Oo00__oooo.().Pages)
					{
						C1TopicPage c1TopicPage = (C1TopicPage)obj2;
						dictionary.Add(c1TopicPage.Text, c1TopicPage.Collapsed);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.ooOooo.oO..Close();
				this.ooOooo.oO. = null;
				this.OpenChatWindow();
				this.ooOooo.oO..Location = location;
				try
				{
					foreach (object obj3 in this.ooOooo.oO..Oo.Oo00__oooo.().Pages)
					{
						C1TopicPage c1TopicPage2 = (C1TopicPage)obj3;
						if (dictionary.ContainsKey(c1TopicPage2.Text))
						{
							c1TopicPage2.Collapsed = dictionary[c1TopicPage2.Text];
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				this.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Value = Math.Max(this.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Minimum, Math.Min(value, this.ooOooo.oO..Oo.Oo00__oooo.().VerticalScroll.Maximum));
				if (obj == null)
				{
					return;
				}
				try
				{
					foreach (object obj4 in this.ooOooo.oO..Oo.Oo00__oooo.().Pages)
					{
						C1TopicLink c1TopicLink = ((C1TopicPage)obj4).FindLinkByTag(RuntimeHelpers.GetObjectValue(obj));
						if (c1TopicLink != null)
						{
							this.ooOooo.oO..oOO_._0_0o_0.(c1TopicLink);
							break;
						}
					}
					return;
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
			}
			this.OpenChatWindow();
		}

		// Token: 0x04000905 RID: 2309
		private string <<EMPTY_NAME>>;

		// Token: 0x04000906 RID: 2310
		private string <<EMPTY_NAME>>;

		// Token: 0x04000907 RID: 2311
		private string <<EMPTY_NAME>>;

		// Token: 0x04000908 RID: 2312
		private int <<EMPTY_NAME>>;

		// Token: 0x04000909 RID: 2313
		internal IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x0400090A RID: 2314
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x0400090B RID: 2315
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400090C RID: 2316
		private int <<EMPTY_NAME>>;

		// Token: 0x0400090D RID: 2317
		private int <<EMPTY_NAME>>;

		// Token: 0x0400090E RID: 2318
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x0400090F RID: 2319
		private System.Threading.Timer <<EMPTY_NAME>>;

		// Token: 0x04000910 RID: 2320
		internal UdpClient <<EMPTY_NAME>>;

		// Token: 0x04000911 RID: 2321
		internal UdpClient <<EMPTY_NAME>>;

		// Token: 0x04000912 RID: 2322
		private ReaderWriterLock <<EMPTY_NAME>>;

		// Token: 0x04000913 RID: 2323
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000914 RID: 2324
		internal Queue<oO__oO_0_O> <<EMPTY_NAME>>;

		// Token: 0x04000915 RID: 2325
		private IMBuddyCollections <<EMPTY_NAME>>;

		// Token: 0x04000916 RID: 2326
		private string <<EMPTY_NAME>>;

		// Token: 0x04000917 RID: 2327
		private string <<EMPTY_NAME>>;

		// Token: 0x04000918 RID: 2328
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000919 RID: 2329
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400091A RID: 2330
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool StopHeartbratServer;

		// Token: 0x0400091B RID: 2331
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool StopHeartbratBuddy;

		// Token: 0x0400091C RID: 2332
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400091D RID: 2333
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400091E RID: 2334
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400091F RID: 2335
		private int <<EMPTY_NAME>>;

		// Token: 0x04000920 RID: 2336
		private int <<EMPTY_NAME>>;

		// Token: 0x04000921 RID: 2337
		private int <<EMPTY_NAME>>;

		// Token: 0x04000922 RID: 2338
		private int <<EMPTY_NAME>>;

		// Token: 0x04000923 RID: 2339
		internal OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04000924 RID: 2340
		internal OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x04000925 RID: 2341
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04000926 RID: 2342
		internal OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x04000927 RID: 2343
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04000928 RID: 2344
		private OleDbCommand <<EMPTY_NAME>>;

		// Token: 0x04000929 RID: 2345
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400092A RID: 2346
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400092B RID: 2347
		private string <<EMPTY_NAME>>;

		// Token: 0x0400092C RID: 2348
		internal f4 <<EMPTY_NAME>>;

		// Token: 0x0400092D RID: 2349
		internal o\u3000\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x0400092E RID: 2350
		internal Dictionary<string, ooo0> <<EMPTY_NAME>>;

		// Token: 0x0400092F RID: 2351
		internal Dictionary<string, O_0OOOoO> <<EMPTY_NAME>>;

		// Token: 0x04000930 RID: 2352
		internal Dictionary<string, ooOoO> <<EMPTY_NAME>>;

		// Token: 0x04000931 RID: 2353
		internal Dictionary<string, O_0__O_o_O> <<EMPTY_NAME>>;

		// Token: 0x04000932 RID: 2354
		internal Dictionary<string, O_0__O_o_O> <<EMPTY_NAME>>;

		// Token: 0x04000933 RID: 2355
		internal List<object> <<EMPTY_NAME>>;

		// Token: 0x04000934 RID: 2356
		internal List<int> <<EMPTY_NAME>>;

		// Token: 0x04000935 RID: 2357
		internal int <<EMPTY_NAME>>;

		// Token: 0x04000936 RID: 2358
		internal object <<EMPTY_NAME>>;

		// Token: 0x04000937 RID: 2359
		internal List<int> <<EMPTY_NAME>>;

		// Token: 0x04000938 RID: 2360
		internal Dictionary<int, O0o000> <<EMPTY_NAME>>;

		// Token: 0x04000939 RID: 2361
		internal int <<EMPTY_NAME>>;

		// Token: 0x0400093A RID: 2362
		internal DateTime <<EMPTY_NAME>>;

		// Token: 0x0400093B RID: 2363
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400093C RID: 2364
		internal Dictionary<string, DateTime> <<EMPTY_NAME>>;

		// Token: 0x0400093D RID: 2365
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400093E RID: 2366
		private Dictionary<string, DateTime> <<EMPTY_NAME>>;

		// Token: 0x0400093F RID: 2367
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000940 RID: 2368
		private string <<EMPTY_NAME>>;

		// Token: 0x04000941 RID: 2369
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x020002F0 RID: 752
		// (Invoke) Token: 0x0600294B RID: 10571
		private delegate void OO_0_(IMBuddy A_0, string A_1);

		// Token: 0x020002F1 RID: 753
		// (Invoke) Token: 0x0600294F RID: 10575
		private delegate void o_oOO_(AfterSendFileEventArgs A_0);

		// Token: 0x020002F2 RID: 754
		// (Invoke) Token: 0x06002953 RID: 10579
		private delegate void o00o_(IMBuddy A_0, string A_1, ooOoO A_2);
	}
}

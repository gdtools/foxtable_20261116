using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002EE RID: 750
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	[oO0oooo("2979")]
	public class IMServer
	{
		// Token: 0x0600290A RID: 10506 RVA: 0x00127A2C File Offset: 0x00125C2C
		public IMServer(string A_0)
		{
			this.oo._0oo_00O. = -1;
			this.OOOOoo_0o.Oo. = -1;
			this.o_O0O00OO0.00. = true;
			this.O_O.Oo0000. = 30;
			this.OO_.OO. = 100;
			this.o0oo__0Oo_.o00. = true;
			this.ooO_.O0_. = new ReaderWriterLock();
			this.o_O0O00OO0.00. = new IMUserCollections();
			this.ooO_.O0_. = new Queue<oO__oO_0_O>();
			this.oOOO_0o.oo. = 81920;
			this.O._OoOO0o. = 81920;
			this.o_O0O00OO0.00. = new Dictionary<string, o0o0_oo00Oo>();
			this.ooO_.O0_. = new Dictionary<string, ooOoO>();
			this.ooO_.O0_. = new Dictionary<string, O_0__O_o_O>();
			this.oo._0oo_00O. = A_0;
		}

		/// <summary>
		/// QQUser集合，包括所有已经登录的用户
		/// </summary>
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x00127ACA File Offset: 0x00125CCA
		public IMUserCollections Users
		{
			get
			{
				return this.o_O0O00OO0.00.;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x00127AD2 File Offset: 0x00125CD2
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Name
		{
			get
			{
				return this.oo._0oo_00O.;
			}
		}

		/// <summary>
		/// 逻辑型，用于判断QQserver是否处于启动状态
		/// </summary>
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x00127ADA File Offset: 0x00125CDA
		public bool Ready
		{
			get
			{
				return !this.o0oo__0Oo_.o00.;
			}
		}

		/// <summary>
		/// 字符型，指定QQserver的IP地址
		/// </summary>
		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x00127AE5 File Offset: 0x00125CE5
		// (set) Token: 0x0600290F RID: 10511 RVA: 0x00127AED File Offset: 0x00125CED
		public string ServerIP
		{
			get
			{
				return this.ooO_.O0_.;
			}
			set
			{
				this.ooO_.O0_. = value;
			}
		}

		/// <summary>
		/// 整数型，指定QQServer的登录端口。
		/// </summary>
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x00127AF6 File Offset: 0x00125CF6
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x00127AFE File Offset: 0x00125CFE
		public int ServerPort
		{
			get
			{
				return this.ooO_.O0_.;
			}
			set
			{
				this.ooO_.O0_. = value;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x00127B07 File Offset: 0x00125D07
		// (set) Token: 0x06002913 RID: 10515 RVA: 0x00127B0F File Offset: 0x00125D0F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool MonitorHeartbeat
		{
			get
			{
				return this.o_O0O00OO0.00.;
			}
			set
			{
				this.o_O0O00OO0.00. = value;
			}
		}

		/// <summary>
		/// 心跳信号间隔，默认为30，单位为秒
		/// </summary>
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x00127B18 File Offset: 0x00125D18
		// (set) Token: 0x06002915 RID: 10517 RVA: 0x00127B20 File Offset: 0x00125D20
		public int HeartbeatInterval
		{
			get
			{
				return this.O_O.Oo0000.;
			}
			set
			{
				if (value < 5)
				{
					value = 5;
				}
				this.O_O.Oo0000. = value;
			}
		}

		/// <summary>
		/// 指定心跳信号超时时长，默认为100，单位为秒，也就是100秒内没有收到某客户端的心跳信号，就认为该客户端已经离线
		/// </summary>
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x00127B30 File Offset: 0x00125D30
		// (set) Token: 0x06002917 RID: 10519 RVA: 0x00127B38 File Offset: 0x00125D38
		public int HeartbeatTimeout
		{
			get
			{
				return this.OO_.OO.;
			}
			set
			{
				if (value < 10)
				{
					value = 10;
				}
				this.OO_.OO. = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x00127B4A File Offset: 0x00125D4A
		// (set) Token: 0x06002919 RID: 10521 RVA: 0x00127B52 File Offset: 0x00125D52
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int ReceiveBufferSize
		{
			get
			{
				return this.oOOO_0o.oo.;
			}
			set
			{
				this.oOOO_0o.oo. = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x00127B5B File Offset: 0x00125D5B
		// (set) Token: 0x0600291B RID: 10523 RVA: 0x00127B63 File Offset: 0x00125D63
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int SendBufferSize
		{
			get
			{
				return this.O._OoOO0o.;
			}
			set
			{
				this.O._OoOO0o. = value;
			}
		}

		/// <summary>
		/// 是否使用内置身份验证，默认为False
		/// </summary>
		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x00127B6C File Offset: 0x00125D6C
		// (set) Token: 0x0600291D RID: 10525 RVA: 0x00127B74 File Offset: 0x00125D74
		public bool Buildin
		{
			get
			{
				return this.o__00O.o_o0_o0.;
			}
			set
			{
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.o.0_O_O.
				});
				if (dataRow != null && Operators.CompareString(dataRow["Config"].ToString(), "1", true) == 0)
				{
					this.o__00O.o_o0_o0. = value;
				}
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x00127BDF File Offset: 0x00125DDF
		internal Dictionary<string, o0o0_oo00Oo> MeetingInfos
		{
			get
			{
				return this.o_O0O00OO0.00.;
			}
		}

		/// <summary>
		/// 指定QQServer的随机端口范围
		/// </summary>
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x00127BE7 File Offset: 0x00125DE7
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x00127BF0 File Offset: 0x00125DF0
		[oO0oooo("3247")]
		public string PortRange
		{
			get
			{
				return this.OOOOoo_0o.Oo.;
			}
			set
			{
				this.OOOOoo_0o.Oo. = value;
				this.oo._0oo_00O. = -1;
				this.OOOOoo_0o.Oo. = -1;
				if (Operators.CompareString(value, "", true) > 0)
				{
					string[] array = value.Split(new char[]
					{
						'/',
						'\\'
					});
					if (array.Length >= 1 && int.TryParse(array[0], out this.oo._0oo_00O.))
					{
						this.oo._0oo_00O. = Math.Max(0, this.oo._0oo_00O.);
					}
					if (array.Length >= 2 && int.TryParse(array[1], out this.OOOOoo_0o.Oo.))
					{
						this.OOOOoo_0o.Oo. = Math.Min(65535, this.OOOOoo_0o.Oo.);
					}
				}
			}
		}

		/// <summary>
		/// 启动QQServer
		/// </summary>
		// Token: 0x06002921 RID: 10529 RVA: 0x00127C8C File Offset: 0x00125E8C
		[oO0oooo("3024")]
		public bool Start()
		{
			bool result;
			if (this.ooO_.O0_. != null)
			{
				MessageBox.Show("此IMServer已经启动，请先停止，才能重新启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (this.ooO_.O0_. == 0)
			{
				MessageBox.Show("必须同时指定端口,才能启动IMServer!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				this.Users.o_.oOoo_0.();
				try
				{
					IPEndPoint localEP;
					if (Operators.CompareString(this.ooO_.O0_., "", true) == 0)
					{
						localEP = new IPEndPoint(IPAddress.Any, this.ooO_.O0_.);
					}
					else
					{
						localEP = new IPEndPoint(IPAddress.Parse(this.ooO_.O0_.), this.ooO_.O0_.);
					}
					this.ooO_.O0_. = new UdpClient(localEP);
					this.ooO_.O0_..Client.ReceiveBufferSize = this.ReceiveBufferSize;
					this.ooO_.O0_..Client.SendBufferSize = this.SendBufferSize;
					o0___oO.O.oOo0O0O.(this.ooO_.O0_.);
					this.o0oo__0Oo_.o00. = false;
					this.Oo__o._0_.();
					this.O0o_.Oo0oo.();
					this.o.Ooo_.();
					result = true;
				}
				catch (Exception a_)
				{
					this.o0oo__0Oo_.o00. = true;
					if (this.ooO_.O0_. != null)
					{
						this.ooO_.O0_..Close();
						this.ooO_.O0_. = null;
					}
					ooO.oOo0Oo.o.(a_, "启动IMServer");
					result = false;
				}
			}
			return result;
		}

		/// <summary>
		/// 停止QQServer
		/// </summary>
		// Token: 0x06002922 RID: 10530 RVA: 0x00127DD4 File Offset: 0x00125FD4
		public void Stop()
		{
			this.o0oo__0Oo_.o00. = true;
			this.ooO_.O0_..AcquireWriterLock(-1);
			Exception ex = null;
			try
			{
				try
				{
					foreach (IMUser imuser in this.Users)
					{
						string a_ = "&3\v" + imuser.Name + "\v" + this.Users[imuser.Name].OO__o_.O0_0O_0.;
						this.oOOOo._.(imuser.Name, a_);
					}
				}
				finally
				{
					IEnumerator<IMUser> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.Users.o_.oOoo_0.();
				this.MeetingInfos.Clear();
				object obj = this.ooO_.O0_.;
				lock (obj)
				{
					this.ooO_.O0_..Clear();
				}
				if (this.ooO_.O0_. != null)
				{
					this.ooO_.O0_..Close();
					this.ooO_.O0_. = null;
				}
				if (this.O0O_.O. != null)
				{
					if (this.O0O_.O..State == ConnectionState.Open)
					{
						this.O0O_.O..Close();
					}
					this.O0O_.O. = null;
				}
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			finally
			{
				this.ooO_.O0_..ReleaseWriterLock();
			}
			if (ex != null)
			{
				ooO.oOo0Oo.o.(ex, "关闭IMServer");
			}
		}

		/// <summary>
		/// 踢出用户
		/// </summary>
		/// <param name="UserName">字符型，指定用户名，此用户将被踢出</param>
		// Token: 0x06002923 RID: 10531 RVA: 0x00127F40 File Offset: 0x00126140
		[oO0oooo("3026")]
		public void KickOff(string UserName)
		{
			if (this.Users.Contains(UserName))
			{
				string a_ = "&1\v" + UserName + "\v" + this.Users[UserName].OO__o_.O0_0O_0.;
				this.oOOOo._.(UserName, a_);
				a_ = "!2\v" + UserName + "\v" + this.Users[UserName].OO__o_.O0_0O_0.;
				try
				{
					foreach (IMUser imuser in this.Users)
					{
						if (imuser.Buddies.Contains(UserName))
						{
							this.oOOOo._.(imuser.Name, a_);
						}
					}
				}
				finally
				{
					IEnumerator<IMUser> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.Users.o_.oOoo_0.(UserName);
				Server_UserLogoutEventArgs server_UserLogoutEventArgs = new Server_UserLogoutEventArgs(UserName, this, 2);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", new object[]
				{
					server_UserLogoutEventArgs
				}, true, "项目", false);
			}
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00128034 File Offset: 0x00126234
		private void <<EMPTY_NAME>>()
		{
			this.ooO_.O0_..AcquireReaderLock(-1);
			Exception ex = null;
			try
			{
				this.ooO_.O0_..BeginReceive(new AsyncCallback(this.O0o_.Oo0oo.), null);
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			finally
			{
				this.ooO_.O0_..ReleaseReaderLock();
			}
			if (ex != null)
			{
				this.Stop();
				ooO.oOo0Oo.o.(ex, "IMServer异步接收");
			}
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x001280B8 File Offset: 0x001262B8
		private void <<EMPTY_NAME>>(IAsyncResult A_0)
		{
			if (!this.o0oo__0Oo_.o00.)
			{
				this.ooO_.O0_..AcquireReaderLock(-1);
				Exception ex = null;
				try
				{
					IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
					byte[] array = this.ooO_.O0_..EndReceive(A_0, ref ipendPoint);
					string text = Encoding.Unicode.GetString(array);
					if (Operators.CompareString(text, "", true) > 0)
					{
						if (Operators.CompareString(text, "\u0005\v\u0005", true) == 0)
						{
							this.ooO_.O0_..Send(array, array.Length, ipendPoint);
						}
						else if (text.StartsWith("#\v"))
						{
							string[] array2 = text.Split(new char[]
							{
								'\v'
							});
							if (this.Users.Contains(array2[1]) && Operators.CompareString(this.Users[array2[1]].OO__o_.O0_0O_0., array2[2], true) == 0)
							{
								this.ooO_.O0_..Send(array, array.Length, ipendPoint);
								this.Users[array2[1]].LastHeartbeatTime = DateTime.Now;
							}
						}
						else if (text.StartsWith("=$\v"))
						{
							string[] array3 = text.Split(new char[]
							{
								'\v'
							});
							if (array3.Length == 5)
							{
								if (array3[1].StartsWith("\"") && array3[1].EndsWith("\""))
								{
									this.ooO_.O0_..Enqueue(new oO__oO_0_O(ipendPoint, text));
								}
								else if (this.Users.Contains(array3[1]) && this.Users.Contains(array3[2]) && Operators.CompareString(this.Users[array3[2]].OO__o_.O0_0O_0., array3[4], true) == 0)
								{
									text = string.Concat(new string[]
									{
										"$\v",
										array3[2],
										"\v",
										array3[3],
										"\v",
										array3[4]
									});
									this.oOOOo._.(array3[1], text);
								}
								else
								{
									text = "$\v" + array3[2] + "\v" + array3[3];
									this.O0O_.O..CommandText = "Insert Into [Messages] ([Receiver],[Time],[Content]) Values(?, #" + Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") + "#,?)";
									this.O0O_.O..Parameters.Clear();
									this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", array3[1]));
									this.O0O_.O..Parameters.Add(new OleDbParameter("@p2", text));
									this.O0O_.O..ExecuteNonQuery();
								}
							}
						}
						else if (text.StartsWith("*\v"))
						{
							string[] array4 = text.Split(new char[]
							{
								'\v'
							});
							if (array4.Length == 7 && this.Users.Contains(array4[1]) && Operators.CompareString(this.Users[array4[1]].OO__o_.O0_0O_0., array4[2], true) == 0)
							{
								string s = "{OK}";
								byte[] bytes = Encoding.Unicode.GetBytes(s);
								this.ooO_.O0_..Send(bytes, bytes.Length, ipendPoint);
								new Thread(new ParameterizedThreadStart(this.O0o_.Oo0oo.)).Start(array4);
							}
						}
						else if (text.StartsWith("*1\v"))
						{
							string[] array5 = text.Split(new char[]
							{
								'\v'
							});
							if (array5.Length == 6)
							{
								char value = '\v';
								if (this.Users.Contains(array5[1]) && this.Users.Contains(array5[2]) && Operators.CompareString(this.Users[array5[2]].OO__o_.O0_0O_0., array5[3], true) == 0)
								{
									text = string.Concat(new string[]
									{
										"*1",
										Conversions.ToString(value),
										array5[2],
										Conversions.ToString(value),
										array5[3],
										Conversions.ToString(value),
										array5[4],
										Conversions.ToString(value),
										array5[5]
									});
									this.oOOOo._.(array5[1], text);
								}
								else
								{
									text = string.Concat(new string[]
									{
										"*1",
										Conversions.ToString(value),
										array5[2],
										Conversions.ToString(value),
										array5[4],
										Conversions.ToString(value),
										array5[5]
									});
									this.O0O_.O..CommandText = "Insert Into [Messages] ([Receiver],[Time],[Content]) Values(?, #" + Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") + "#, ?)";
									this.O0O_.O..Parameters.Clear();
									this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", array5[1]));
									this.O0O_.O..Parameters.Add(new OleDbParameter("@p2", text));
									this.O0O_.O..ExecuteNonQuery();
								}
							}
						}
						else if (text.StartsWith("*2\v"))
						{
							string[] array6 = text.Split(new char[]
							{
								'\v'
							});
							if (array6.Length == 4 && this.MeetingInfos.ContainsKey(array6[3]) && this.Users.Contains(array6[1]) && Operators.CompareString(this.MeetingInfos[array6[3]].O_oO._O.(), array6[1], true) == 0 && Operators.CompareString(this.Users[array6[1]].OO__o_.O0_0O_0., array6[2], true) == 0)
							{
								this.O0O_.O..CommandText = "Delete From [Meetings] Where [MeetingKey]  = '" + array6[3] + "'";
								this.O0O_.O..ExecuteNonQuery();
								try
								{
									foreach (string text2 in this.MeetingInfos[array6[3]].o.oo_o0O.())
									{
										if (this.Users.Contains(text2))
										{
											this.oOOOo._.(text2, text);
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								this.MeetingInfos.Remove(array6[3]);
							}
						}
						else if (text.StartsWith("*3\v"))
						{
							string[] array7 = text.Split(new char[]
							{
								'\v'
							});
							if (array7.Length == 5 && this.MeetingInfos.ContainsKey(array7[3]) && this.Users.Contains(array7[1]) && Operators.CompareString(this.MeetingInfos[array7[3]].O_oO._O.(), array7[1], true) == 0 && Operators.CompareString(this.Users[array7[1]].OO__o_.O0_0O_0., array7[2], true) == 0)
							{
								this.MeetingInfos[array7[3]].o.oo_o0O.(array7[4]);
								this.O0O_.O..CommandText = string.Concat(new string[]
								{
									"Update [Meetings] Set [Members] = '",
									array7[4],
									"' Where [MeetingKey]  = '",
									array7[3],
									"'"
								});
								this.O0O_.O..ExecuteNonQuery();
							}
						}
						else if (text.StartsWith("%1\v"))
						{
							string[] array8 = text.Split(new char[]
							{
								'\v'
							});
							char value2 = '\v';
							if (array8.Length == 9)
							{
								if (this.Users.Contains(array8[1]) && Operators.CompareString(this.Users[array8[1]].OO__o_.O0_0O_0., array8[2], true) == 0 && this.Users.Contains(array8[3]) && Operators.CompareString(this.Users[array8[3]].OO__o_.O0_0O_0., array8[4], true) == 0)
								{
									text = string.Concat(new string[]
									{
										"%1",
										Conversions.ToString(value2),
										array8[1],
										Conversions.ToString(value2),
										array8[5],
										Conversions.ToString(value2),
										array8[6],
										Conversions.ToString(value2),
										array8[7],
										Conversions.ToString(value2),
										ipendPoint.ToString(),
										Conversions.ToString(value2),
										array8[8]
									});
									this.oOOOo._.(array8[3], text);
								}
							}
							else if (array8.Length == 4 && this.Users.Contains(array8[1]))
							{
								string ipString = array8[3].Substring(0, array8[3].IndexOf(":"));
								string value3 = array8[3].Substring(array8[3].IndexOf(":") + 1);
								IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipString), Conversions.ToInteger(value3));
								byte[] bytes2 = Encoding.Unicode.GetBytes(array8[2]);
								this.ooO_.O0_..Send(bytes2, bytes2.Length, endPoint);
							}
						}
						else if (text.StartsWith("%2\v"))
						{
							string[] array9 = text.Split(new char[]
							{
								'\v'
							});
							char value4 = '\v';
							if (array9.Length == 8)
							{
								if (this.Users.Contains(array9[1]) && Operators.CompareString(this.Users[array9[1]].OO__o_.O0_0O_0., array9[2], true) == 0 && this.Users.Contains(array9[5]) && Operators.CompareString(this.Users[array9[5]].OO__o_.O0_0O_0., array9[6], true) == 0)
								{
									text = string.Concat(new string[]
									{
										"%2",
										Conversions.ToString(value4),
										array9[1],
										Conversions.ToString(value4),
										array9[3],
										Conversions.ToString(value4),
										array9[4],
										Conversions.ToString(value4),
										ipendPoint.ToString(),
										Conversions.ToString(value4),
										array9[7]
									});
									this.oOOOo._.(array9[5], text);
								}
							}
							else if (array9.Length == 3 && this.Users.Contains(array9[1]))
							{
								string ipString2 = array9[2].Substring(0, array9[2].IndexOf(":"));
								string value5 = array9[2].Substring(array9[2].IndexOf(":") + 1);
								IPEndPoint endPoint2 = new IPEndPoint(IPAddress.Parse(ipString2), Conversions.ToInteger(value5));
								byte[] bytes3 = Encoding.Unicode.GetBytes(ipendPoint.ToString());
								this.ooO_.O0_..Send(bytes3, bytes3.Length, endPoint2);
							}
						}
						else if (text.StartsWith("%02\v"))
						{
							string[] array10 = text.Split(new char[]
							{
								'\v'
							});
							char value6 = '\v';
							if (array10.Length == 5 && this.Users.Contains(array10[1]) && Operators.CompareString(this.Users[array10[1]].OO__o_.O0_0O_0., array10[2], true) == 0)
							{
								string ipString3 = array10[3].Substring(0, array10[3].IndexOf(":"));
								string value7 = array10[3].Substring(array10[3].IndexOf(":") + 1);
								IPEndPoint endPoint3 = new IPEndPoint(IPAddress.Parse(ipString3), Conversions.ToInteger(value7));
								byte[] bytes4 = Encoding.Unicode.GetBytes(string.Concat(new string[]
								{
									"%02",
									Conversions.ToString(value6),
									array10[4],
									Conversions.ToString(value6),
									ipendPoint.ToString()
								}));
								this.ooO_.O0_..Send(bytes4, bytes4.Length, endPoint3);
							}
						}
						else if (text.StartsWith("%10\v"))
						{
							string[] array11 = text.Split(new char[]
							{
								'\v'
							});
							if (array11.Length == 7 && this.Users.Contains(array11[1]) && Operators.CompareString(this.Users[array11[1]].OO__o_.O0_0O_0., array11[2], true) == 0 && this.Users.Contains(array11[4]) && Operators.CompareString(this.Users[array11[4]].OO__o_.O0_0O_0., array11[5], true) == 0)
							{
								new Thread(new ThreadStart(new oO_o_0_o_O_o
								{
									O00.oo0_0oo. = ipendPoint,
									O00.oo0_0oo. = array11[3],
									O00.oo0_0oo. = this.Users[array11[1]],
									oO.o0_O_. = this.Users[array11[4]],
									oO.o0_O_. = array11[6],
									O00.oo0_0oo. = this
								}.O___o.o.)).Start();
							}
						}
						else if (text.StartsWith("%3\v"))
						{
							string[] array12 = text.Split(new char[]
							{
								'\v'
							});
							if (array12.Length == 6 && this.Users.Contains(array12[1]) && Operators.CompareString(this.Users[array12[1]].OO__o_.O0_0O_0., array12[2], true) == 0)
							{
								string text3 = this.O0o_.Oo0oo.(array12[3]);
								UdpClient udpClient = o0___oO.o0__.0.(this);
								o0___oO.O.oOo0O0O.(udpClient);
								udpClient.Client.ReceiveBufferSize = 81920;
								string text4 = udpClient.Client.LocalEndPoint.ToString();
								text4 = text3.Substring((OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\").Length) + "\t" + text4.Substring(text4.IndexOf(":") + 1);
								byte[] bytes5 = Encoding.Unicode.GetBytes(text4);
								this.ooO_.O0_..Send(bytes5, bytes5.Length, ipendPoint);
								ooOoO ooOoO = new ooOoO(this, udpClient, ipendPoint, text3, array12[1], array12[5], (SendTypeEnum)Conversions.ToInteger(array12[4]));
								bool flag = false;
								object obj = this.ooO_.O0_.;
								lock (obj)
								{
									if (!this.ooO_.O0_..ContainsKey(ooOoO.o0OO._0.()))
									{
										this.ooO_.O0_..Add(ooOoO.o0OO._0.(), ooOoO);
										flag = true;
									}
								}
								if (flag)
								{
									new Thread(new ThreadStart(ooOoO.O_OOOooo_0.O.)).Start();
								}
							}
						}
						else if (text.StartsWith("%4\v"))
						{
							string[] array13 = text.Split(new char[]
							{
								'\v'
							});
							if (array13.Length == 4 && this.Users.Contains(array13[1]) && Operators.CompareString(this.Users[array13[1]].OO__o_.O0_0O_0., array13[2], true) == 0)
							{
								object[] parameter = new object[]
								{
									array13[3],
									ipendPoint
								};
								new Thread(new ParameterizedThreadStart(this.o__00O.o_o0_o0.)).Start(parameter);
							}
						}
						else if (text.StartsWith("%9\v"))
						{
							string[] array14 = text.Split(new char[]
							{
								'\v'
							});
							if (array14.Length == 4 && this.Users.Contains(array14[1]) && Operators.CompareString(this.Users[array14[1]].OO__o_.O0_0O_0., array14[2], true) == 0)
							{
								string text5 = Path.Combine(OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\", array14[3]);
								if (!text5.StartsWith(OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\") || !OO_00oOO.FileSys.FileExists(text5))
								{
									array = Encoding.Unicode.GetBytes("None");
									this.ooO_.O0_..Send(array, array.Length, ipendPoint);
								}
								else
								{
									array = Encoding.Unicode.GetBytes("OK");
									this.ooO_.O0_..Send(array, array.Length, ipendPoint);
									this.SendFile(array14[1], text5);
								}
							}
						}
						else
						{
							object obj2 = this.ooO_.O0_.;
							lock (obj2)
							{
								this.ooO_.O0_..Enqueue(new oO__oO_0_O(ipendPoint, text));
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
					this.ooO_.O0_..ReleaseReaderLock();
				}
				if (ex == null)
				{
					if (!this.o0oo__0Oo_.o00.)
					{
						this.o.Ooo_.();
						return;
					}
				}
				else
				{
					this.Stop();
					ooO.oOo0Oo.o.(ex, "IMServer异步接收回调过程");
				}
			}
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00129180 File Offset: 0x00127380
		private void <<EMPTY_NAME>>(object A_0)
		{
			try
			{
				object[] array = (object[])A_0;
				string text = OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\" + array[0].ToString();
				IPEndPoint ipendPoint = (IPEndPoint)array[1];
				if (!OO_00oOO.FileSys.FileExists(text))
				{
					this.O0o_.Oo0oo.(ipendPoint, "-1");
				}
				else
				{
					UdpClient udpClient = o0___oO.o0__.0.(this);
					o0___oO.O.oOo0O0O.(udpClient);
					udpClient.Client.SendBufferSize = 81920;
					string text2 = udpClient.Client.LocalEndPoint.ToString();
					text2 = text2.Substring(text2.IndexOf(":") + 1);
					byte[] bytes = Encoding.Unicode.GetBytes(text2);
					this.ooO_.O0_..Send(bytes, bytes.Length, ipendPoint);
					DateTime now = DateTime.Now;
					while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
					{
						if (udpClient.Available > 0)
						{
							IPEndPoint ipendPoint2 = new IPEndPoint(IPAddress.Any, 0);
							byte[] bytes2 = udpClient.Receive(ref ipendPoint2);
							if (Operators.CompareString(Encoding.Unicode.GetString(bytes2), "Ping", true) == 0)
							{
								O_0__O_o_O o_0__O_o_O = new O_0__O_o_O(this, udpClient, ipendPoint, text, null, OoOo0O.OO_o.0o_O.(8), SendTypeEnum.ManualFile);
								object obj = this.ooO_.O0_.;
								lock (obj)
								{
									this.ooO_.O0_..Add(o_0__O_o_O.O_OO.o0o_o0.(), o_0__O_o_O);
								}
								o_0__O_o_O.o0o_0OO00.Oo0_.();
								break;
							}
						}
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		/// <summary>
		/// 用代码向客户端发送文件
		/// </summary>
		/// <param name="UserName">用户名</param>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x06002927 RID: 10535 RVA: 0x00129348 File Offset: 0x00127548
		[oO0oooo("3027")]
		public void SendFile(string UserName, string FileName)
		{
			object[] parameter = new object[]
			{
				UserName,
				FileName
			};
			new Thread(new ParameterizedThreadStart(this.o0Oo.OoO.)).Start(parameter);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0012937C File Offset: 0x0012757C
		private void <<EMPTY_NAME>>(object A_0)
		{
			object[] array = (object[])A_0;
			string text = array[0].ToString();
			string text2 = array[1].ToString();
			string text3 = "\v";
			UdpClient udpClient = o0___oO.o0__.0.(this);
			o0___oO.O.oOo0O0O.(udpClient);
			udpClient.Client.SendBufferSize = 81920;
			string text4 = udpClient.Client.LocalEndPoint.ToString();
			string text5 = string.Concat(new string[]
			{
				"%8",
				text3,
				text4.Substring(text4.IndexOf(":") + 1),
				text3,
				OO_00oOO.FileSys.GetName(text2)
			});
			this.oOOOo._.(text, text5);
			DateTime now = DateTime.Now;
			bool flag2;
			while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
			{
				if (udpClient.Available > 0)
				{
					IPEndPoint a_ = new IPEndPoint(IPAddress.Any, 0);
					byte[] bytes = udpClient.Receive(ref a_);
					text5 = Encoding.Unicode.GetString(bytes);
					if (Operators.CompareString(text5, "Ping", true) == 0)
					{
						O_0__O_o_O o_0__O_o_O = new O_0__O_o_O(this, udpClient, a_, text2, null, OoOo0O.OO_o.0o_O.(8), SendTypeEnum.AutoFile);
						o_0__O_o_O.O._O___O. = text;
						object obj = this.ooO_.O0_.;
						lock (obj)
						{
							this.ooO_.O0_..Add(o_0__O_o_O.O_OO.o0o_o0.(), o_0__O_o_O);
						}
						flag2 = true;
						o_0__O_o_O.o0o_0OO00.Oo0_.();
						break;
					}
				}
			}
			if (!flag2)
			{
				AfterSendFileEventArgs afterSendFileEventArgs = new AfterSendFileEventArgs(text, text2, false);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_AfterSendFile", new object[]
				{
					afterSendFileEventArgs
				}, true, "项目", false);
			}
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0012952C File Offset: 0x0012772C
		private void <<EMPTY_NAME>>()
		{
			DbDataAdapter dbDataAdapter = new OleDbDataAdapter("Select * From [Meetings] Where Finish = False Or Finish Is Null ", this.O0O_.O.);
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					o0o0_oo00Oo o0o0_oo00Oo = new o0o0_oo00Oo(dataRow["MeetingName"].ToString(), dataRow["MeetingKey"].ToString(), dataRow["Hostess"].ToString(), dataRow["Description"].ToString(), dataRow["Members"].ToString(), false);
					o0o0_oo00Oo.o.oo_o0O.(Conversions.ToDate(dataRow["DateTime"]));
					this.MeetingInfos.Add(o0o0_oo00Oo.OO.O_o__.(), o0o0_oo00Oo);
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
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00129624 File Offset: 0x00127824
		private void <<EMPTY_NAME>>(object A_0)
		{
			try
			{
				string[] array = (string[])A_0;
				OleDbCommand oleDbCommand = new OleDbCommand("", this.O0O_.O.);
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Insert Into Meetings (MeetingName,MeetingKey,Hostess,Description,[DateTime],Members,[Finish]) Values(?, '",
					array[5],
					"','",
					array[1],
					"', ?, #",
					Strings.Format(DateTime.Now, "MM/dd/yyyy HH:ss"),
					"#,'",
					array[6],
					"',False)"
				});
				this.O0O_.O..Parameters.Clear();
				oleDbCommand.Parameters.Add(new OleDbParameter("@p1", array[3]));
				oleDbCommand.Parameters.Add(new OleDbParameter("@p2", array[4]));
				oleDbCommand.ExecuteNonQuery();
				o0o0_oo00Oo o0o0_oo00Oo = new o0o0_oo00Oo(array[3], array[5], array[1], array[5], array[6], false);
				this.MeetingInfos.Add(array[5], o0o0_oo00Oo);
				string text = "\v";
				string text2 = string.Concat(new string[]
				{
					"*",
					text,
					array[1],
					text,
					array[3],
					text,
					array[4],
					text,
					array[5],
					text,
					array[6],
					text,
					Strings.Format(DateTime.Now, "MM/dd/yyyy HH:ss")
				});
				try
				{
					foreach (string text3 in o0o0_oo00Oo.o.oo_o0O.())
					{
						if (this.Users.Contains(text3))
						{
							this.oOOOo._.(text3, text2);
						}
						else
						{
							this.O0O_.O..CommandText = string.Concat(new string[]
							{
								"Insert Into [Messages] ([Receiver],[Time],[Content]) Values('",
								text3,
								"',#",
								Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"),
								"#, ?)"
							});
							this.O0O_.O..Parameters.Clear();
							this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", text2));
							this.O0O_.O..ExecuteNonQuery();
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		/// <summary>
		/// 向用户发送信息
		/// </summary>
		/// <param name="UserName">用户名</param>
		/// <param name="msg">信息内容</param>
		/// <param name="AnyWay">可选参数，逻辑型，如果客户端不在线，是否发离线消息</param>
		// Token: 0x0600292B RID: 10539 RVA: 0x001298B4 File Offset: 0x00127AB4
		[oO0oooo("2980")]
		public void Send(string UserName, string msg, bool AnyWay = false)
		{
			if (this.Users.Contains(UserName))
			{
				msg = "$\v\v" + msg.Replace("\v", "") + "\v" + this.Users[UserName].OO__o_.O0_0O_0.;
				IPEndPoint a_ = this.Users[UserName].WanIP;
				this.O0o_.Oo0oo.(a_, msg);
				return;
			}
			if (AnyWay)
			{
				msg = "$\v\v" + msg;
				this.O0O_.O..CommandText = string.Concat(new string[]
				{
					"Insert Into [Messages] ([Receiver],[Time],[Content]) Values('",
					UserName,
					"',#",
					Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"),
					"#, ?)"
				});
				this.O0O_.O..Parameters.Clear();
				this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", msg));
				this.O0O_.O..ExecuteNonQuery();
			}
		}

		/// <summary>
		/// 用于向客户端发送文字通知
		/// </summary>
		/// <param name="UserName">用户名</param>
		/// <param name="msg">通知内容</param>
		// Token: 0x0600292C RID: 10540 RVA: 0x001299B0 File Offset: 0x00127BB0
		[oO0oooo("3062")]
		public void SendNotice(string UserName, string msg)
		{
			msg = "={" + msg.Replace("\v", "") + "}=";
			if (!this.Users.Contains(UserName))
			{
				try
				{
					foreach (o0o0_oo00Oo o0o0_oo00Oo in this.MeetingInfos.Values)
					{
						if (Operators.CompareString(o0o0_oo00Oo.oOO_00_0.o.(), UserName, true) == 0)
						{
							try
							{
								foreach (string a_ in o0o0_oo00Oo.o.oo_o0O.())
								{
									this.ooO.OO_o_000.(a_, msg);
								}
								return;
							}
							finally
							{
								List<string>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
					}
				}
				finally
				{
					Dictionary<string, o0o0_oo00Oo>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			this.ooO.OO_o_000.(UserName, msg);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00129A8C File Offset: 0x00127C8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (this.Users.Contains(A_0))
			{
				A_1 = "$\v[System]\v" + A_1 + "\v" + this.Users[A_0].OO__o_.O0_0O_0.;
				IPEndPoint a_ = this.Users[A_0].WanIP;
				this.O0o_.Oo0oo.(a_, A_1);
				return;
			}
			A_1 = "$\v[System]\v" + A_1;
			this.O0O_.O..CommandText = string.Concat(new string[]
			{
				"Insert Into [Messages] ([Receiver],[Time],[Content]) Values('",
				A_0,
				"',#",
				Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"),
				"#, ?)"
			});
			this.O0O_.O..Parameters.Clear();
			this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", A_1));
			this.O0O_.O..ExecuteNonQuery();
		}

		/// <summary>
		/// 向用户发送文件通知
		/// </summary>
		/// <param name="UserName">用户名</param>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x0600292E RID: 10542 RVA: 0x00129B74 File Offset: 0x00127D74
		[oO0oooo("3063")]
		public void SendNoticeFile(string UserName, string FileName)
		{
			if (OO_00oOO.FileSys.FileExists(FileName))
			{
				string text = OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\" + Strings.Format(DateTime.Today, "yyyyMM") + "\\";
				if (!OO_00oOO.FileSys.DirectoryExists(text))
				{
					OO_00oOO.FileSys.CreateDirectory(text);
				}
				string text2 = OO_00oOO.FileSys.GetName(FileName);
				text2 = text + text2;
				if (!OO_00oOO.FileSys.FileExists(text2) || Operators.CompareString(O00.CRCCheckFile(FileName), O00.CRCCheckFile(text2), true) != 0)
				{
					if (OO_00oOO.FileSys.FileExists(text2))
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
						string extension = Path.GetExtension(text2);
						int num = 1;
						while (OO_00oOO.FileSys.FileExists(string.Concat(new string[]
						{
							text,
							fileNameWithoutExtension,
							"(",
							Conversions.ToString(num),
							")",
							extension
						})))
						{
							num++;
						}
						text2 = string.Concat(new string[]
						{
							text,
							fileNameWithoutExtension,
							"(",
							Conversions.ToString(num),
							")",
							extension
						});
					}
					if (Operators.CompareString(FileName.ToLower(), text2.ToLower(), true) != 0)
					{
						OO_00oOO.FileSys.CopyFile(FileName, text2, true);
					}
				}
				FileInfo fileInfo = new FileInfo(text2);
				string a_ = string.Concat(new string[]
				{
					"={\u0002\u0002<?",
					Strings.Format(DateTime.Today, "yyyyMM"),
					"\\",
					OO_00oOO.FileSys.GetName(text2),
					"\t",
					o0___oO.o0__.0.(fileInfo.Length),
					"?>}="
				});
				if (!this.Users.Contains(UserName))
				{
					try
					{
						foreach (o0o0_oo00Oo o0o0_oo00Oo in this.MeetingInfos.Values)
						{
							if (Operators.CompareString(o0o0_oo00Oo.oOO_00_0.o.(), UserName, true) == 0)
							{
								try
								{
									foreach (string a_2 in o0o0_oo00Oo.o.oo_o0O.())
									{
										this.o__00O.o_o0_o0.(a_2, a_);
									}
									return;
								}
								finally
								{
									List<string>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						Dictionary<string, o0o0_oo00Oo>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.o__00O.o_o0_o0.(UserName, a_);
			}
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00129DE8 File Offset: 0x00127FE8
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (this.Users.Contains(A_0))
			{
				A_1 = "$\v[System]\v" + A_1 + "\v" + this.Users[A_0].OO__o_.O0_0O_0.;
				IPEndPoint a_ = this.Users[A_0].WanIP;
				this.O0o_.Oo0oo.(a_, A_1);
				return;
			}
			A_1 = A_1.Replace("\u0002\u0002", "\u0002");
			A_1 = "$\v[System]\v" + A_1;
			this.O0O_.O..CommandText = string.Concat(new string[]
			{
				"Insert Into [Messages] ([Receiver],[Time],[Content]) Values('",
				A_0,
				"',#",
				Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"),
				"#, ?)"
			});
			this.O0O_.O..Parameters.Clear();
			this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", A_1));
			this.O0O_.O..ExecuteNonQuery();
		}

		/// <summary>
		/// 向用户发送图片通知
		/// </summary>
		/// <param name="UserName">用户名</param>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x06002930 RID: 10544 RVA: 0x00129EE4 File Offset: 0x001280E4
		[oO0oooo("3064")]
		public void SendNoticeImage(string UserName, string FileName)
		{
			if (OO_00oOO.FileSys.FileExists(FileName))
			{
				string text = OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\" + Strings.Format(DateTime.Today, "yyyyMM") + "\\";
				if (!OO_00oOO.FileSys.DirectoryExists(text))
				{
					OO_00oOO.FileSys.CreateDirectory(text);
				}
				string text2 = OO_00oOO.FileSys.GetName(FileName);
				text2 = text + text2;
				if (!OO_00oOO.FileSys.FileExists(text2) || Operators.CompareString(O00.CRCCheckFile(FileName), O00.CRCCheckFile(text2), true) != 0)
				{
					if (OO_00oOO.FileSys.FileExists(text2))
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
						string extension = Path.GetExtension(text2);
						int num = 1;
						while (OO_00oOO.FileSys.FileExists(string.Concat(new string[]
						{
							text,
							fileNameWithoutExtension,
							"(",
							Conversions.ToString(num),
							")",
							extension
						})))
						{
							num++;
						}
						text2 = string.Concat(new string[]
						{
							text,
							fileNameWithoutExtension,
							"(",
							Conversions.ToString(num),
							")",
							extension
						});
					}
					if (Operators.CompareString(FileName.ToLower(), text2.ToLower(), true) != 0)
					{
						OO_00oOO.FileSys.CopyFile(FileName, text2, true);
					}
				}
				new FileInfo(text2);
				string a_ = string.Concat(new string[]
				{
					"={\u0002\u0002=?",
					Strings.Format(DateTime.Today, "yyyyMM"),
					"\\",
					OO_00oOO.FileSys.GetName(text2),
					"?=}="
				});
				if (!this.Users.Contains(UserName))
				{
					try
					{
						foreach (o0o0_oo00Oo o0o0_oo00Oo in this.MeetingInfos.Values)
						{
							if (Operators.CompareString(o0o0_oo00Oo.oOO_00_0.o.(), UserName, true) == 0)
							{
								try
								{
									foreach (string a_2 in o0o0_oo00Oo.o.oo_o0O.())
									{
										this.o0Oo.OoO.(a_2, a_);
									}
									return;
								}
								finally
								{
									List<string>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						Dictionary<string, o0o0_oo00Oo>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.o0Oo.OoO.(UserName, a_);
			}
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x0012A140 File Offset: 0x00128340
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (this.Users.Contains(A_0))
			{
				A_1 = "$\v[System]\v" + A_1 + "\v" + this.Users[A_0].OO__o_.O0_0O_0.;
				IPEndPoint a_ = this.Users[A_0].WanIP;
				this.O0o_.Oo0oo.(a_, A_1);
				return;
			}
			A_1 = A_1.Replace("\u0002\u0002", "\u0002");
			A_1 = "$\v[System]\v" + A_1;
			this.O0O_.O..CommandText = string.Concat(new string[]
			{
				"Insert Into [Messages] ([Receiver],[Time],[Content]) Values('",
				A_0,
				"',#",
				Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"),
				"#, ?)"
			});
			this.O0O_.O..Parameters.Clear();
			this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", A_1));
			this.O0O_.O..ExecuteNonQuery();
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x0012A23C File Offset: 0x0012843C
		internal void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (this.Users.Contains(A_0))
			{
				IPEndPoint a_ = this.Users[A_0].WanIP;
				this.O0o_.Oo0oo.(a_, A_1);
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0012A274 File Offset: 0x00128474
		internal void <<EMPTY_NAME>>(IPEndPoint A_0, string A_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(A_1);
			this.ooO_.O0_..Send(bytes, bytes.Length, A_0);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0012A2A0 File Offset: 0x001284A0
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				if (!OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "QQServer"))
				{
					OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "QQServer");
				}
				string text = OO_00oOO.ProjectPath + "QQServer\\" + this.Name + "_Cache.mdb";
				if (!OO_00oOO.FileSys.FileExists(text))
				{
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "IMServer.mdb", text);
				}
				this.O0O_.O. = new OleDbConnection(Oo00.o_._0OOo.(text));
				this.O0O_.O. = new OleDbDataAdapter("Select * From [Messages] Where [_Identify] Is Null", this.O0O_.O.);
				this.O0O_.O. = new OleDbCommand("", this.O0O_.O.);
				this.O0O_.O..Open();
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0012A398 File Offset: 0x00128598
		internal string <<EMPTY_NAME>>(string A_0)
		{
			object o00.O0. = OO_00oOO.IMClients.O00.O0.;
			ObjectFlowControl.CheckForSyncLockOnValueType(o00.O0.);
			string result;
			lock (o00.O0.)
			{
				if (Operators.CompareString(OO_00oOO.FileSys.GetParentPath(A_0), "", true) == 0)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
					string extension = Path.GetExtension(A_0);
					string text = OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\" + Strings.Format(DateTime.Today, "yyyyMM") + "\\";
					if (!OO_00oOO.FileSys.DirectoryExists(text))
					{
						OO_00oOO.FileSys.CreateDirectory(text);
					}
					if (!OO_00oOO.FileSys.FileExists(text + fileNameWithoutExtension + extension) && !IMServer.oO_0OO.0..Contains(text + fileNameWithoutExtension + extension))
					{
						A_0 = text + fileNameWithoutExtension + extension;
						IMServer.oO_0OO.0..Add(A_0);
					}
					else
					{
						int num = 1;
						while (OO_00oOO.FileSys.FileExists(string.Concat(new string[]
						{
							text,
							fileNameWithoutExtension,
							"(",
							Conversions.ToString(num),
							")",
							extension
						})) || IMServer.oO_0OO.0..Contains(string.Concat(new string[]
						{
							text,
							fileNameWithoutExtension,
							"(",
							Conversions.ToString(num),
							")",
							extension
						})))
						{
							num++;
						}
						A_0 = string.Concat(new string[]
						{
							text,
							fileNameWithoutExtension,
							"(",
							Conversions.ToString(num),
							")",
							extension
						});
						IMServer.oO_0OO.0..Add(A_0);
					}
				}
				result = A_0;
			}
			return result;
		}

		/// <summary>
		/// 向客户端转发收到的微信消息
		/// </summary>
		/// <param name="WeChatID">字符型，发送方微信ID</param>
		/// <param name="Receiver">接收方的OpenQQ用户名</param>
		/// <param name="Message">字符型，要转发的微信消息</param>
		// Token: 0x06002936 RID: 10550 RVA: 0x0012A574 File Offset: 0x00128774
		[oO0oooo("A4106")]
		public void ForwardMessage(string WeChatID, string Receiver, string Message)
		{
			string text = "\v";
			Message = string.Concat(new string[]
			{
				"=$",
				text,
				WeChatID,
				text,
				Message
			});
			this.O0O_.O.(Receiver, Message);
		}

		/// <summary>
		/// 向客户端转发收到的微信发来的文件
		/// </summary>
		/// <param name="WeChatID">字符型，发送方微信ID</param>
		/// <param name="Receiver">接收方的OpenQQ用户名</param>
		/// <param name="FileName">字符型，要转发的文件名，含相对路径</param>
		// Token: 0x06002937 RID: 10551 RVA: 0x0012A5B4 File Offset: 0x001287B4
		[oO0oooo("A4107")]
		public void ForwardFile(string WeChatID, string Receiver, string FileName)
		{
			string text = "\v";
			string a_ = string.Concat(new string[]
			{
				"=$",
				text,
				WeChatID,
				text,
				"\u0002<?",
				FileName,
				"?>"
			});
			this.O0O_.O.(Receiver, a_);
		}

		/// <summary>
		/// 向客户端转发收到的微信聊天消息
		/// </summary>
		/// <param name="WeChatID">字符型，发送方微信ID</param>
		/// <param name="Receiver">接收方的OpenQQ用户名</param>
		/// <param name="Message">字符型，消息内容</param>
		// Token: 0x06002938 RID: 10552 RVA: 0x0012A604 File Offset: 0x00128804
		[oO0oooo("A4108")]
		public void ForwardChatMessage(string WeChatID, string Receiver, string Message)
		{
			string text = "\v";
			Message = string.Concat(new string[]
			{
				"=$",
				text,
				WeChatID,
				text,
				"={",
				Message,
				"}="
			});
			this.O0O_.O.(Receiver, Message);
		}

		/// <summary>
		/// 向客户端转发收到的微信聊天文件
		/// </summary>
		/// <param name="WeChatID">字符型，发送方微信ID</param>
		/// <param name="Receiver">接收方的OpenQQ用户名</param>
		/// <param name="FileName">符型，要转发的文件名，含相对路径</param>
		// Token: 0x06002939 RID: 10553 RVA: 0x0012A654 File Offset: 0x00128854
		[oO0oooo("A4109")]
		public void ForwardChatFile(string WeChatID, string Receiver, string FileName)
		{
			string text = "\v";
			string text2 = OO_00oOO.ProjectPath + "QQServer\\UploadFiles\\" + FileName;
			if (OO_00oOO.FileSys.FileExists(text2))
			{
				FileInfo fileInfo = new FileInfo(text2);
				string a_ = string.Concat(new string[]
				{
					"=$",
					text,
					WeChatID,
					text,
					"={\u0002<?",
					FileName,
					"\t",
					o0___oO.o0__.0.(fileInfo.Length),
					"?>}="
				});
				this.O0O_.O.(Receiver, a_);
			}
		}

		/// <summary>
		/// 向客户端转发收到的微信聊天文件
		/// </summary>
		/// <param name="WeChatID">字符型，发送方微信ID</param>
		/// <param name="Receiver">接收方的OpenQQ用户名</param>
		/// <param name="FileName">要发送的图片文件名，含路径</param>
		// Token: 0x0600293A RID: 10554 RVA: 0x0012A6E0 File Offset: 0x001288E0
		[oO0oooo("A4105")]
		public void ForwardChatImage(string WeChatID, string Receiver, string FileName)
		{
			string text = "\v";
			string a_ = string.Concat(new string[]
			{
				"=$",
				text,
				WeChatID,
				text,
				"={\u0002=?",
				FileName,
				"?=}="
			});
			this.O0O_.O.(Receiver, a_);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x0012A730 File Offset: 0x00128930
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (this.Users.Contains(A_0))
			{
				IPEndPoint a_ = this.Users[A_0].WanIP;
				this.O0o_.Oo0oo.(a_, A_1);
				return;
			}
			this.O0O_.O..CommandText = string.Concat(new string[]
			{
				"Insert Into [Messages] ([Receiver],[Time],[Content]) Values('",
				A_0,
				"',#",
				Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"),
				"#, ?)"
			});
			this.O0O_.O..Parameters.Clear();
			this.O0O_.O..Parameters.Add(new OleDbParameter("@p1", A_1));
			this.O0O_.O..ExecuteNonQuery();
		}

		// Token: 0x040010F3 RID: 4339
		private string <<EMPTY_NAME>>;

		// Token: 0x040010F4 RID: 4340
		private int <<EMPTY_NAME>>;

		// Token: 0x040010F5 RID: 4341
		private string <<EMPTY_NAME>>;

		// Token: 0x040010F6 RID: 4342
		private string <<EMPTY_NAME>>;

		// Token: 0x040010F7 RID: 4343
		internal int <<EMPTY_NAME>>;

		// Token: 0x040010F8 RID: 4344
		internal int <<EMPTY_NAME>>;

		// Token: 0x040010F9 RID: 4345
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010FA RID: 4346
		private int <<EMPTY_NAME>>;

		// Token: 0x040010FB RID: 4347
		private int <<EMPTY_NAME>>;

		// Token: 0x040010FC RID: 4348
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040010FD RID: 4349
		internal ReaderWriterLock <<EMPTY_NAME>>;

		// Token: 0x040010FE RID: 4350
		internal UdpClient <<EMPTY_NAME>>;

		// Token: 0x040010FF RID: 4351
		private IMUserCollections <<EMPTY_NAME>>;

		// Token: 0x04001100 RID: 4352
		private string <<EMPTY_NAME>>;

		// Token: 0x04001101 RID: 4353
		internal Queue<oO__oO_0_O> <<EMPTY_NAME>>;

		// Token: 0x04001102 RID: 4354
		private int <<EMPTY_NAME>>;

		// Token: 0x04001103 RID: 4355
		private int <<EMPTY_NAME>>;

		// Token: 0x04001104 RID: 4356
		private Dictionary<string, o0o0_oo00Oo> <<EMPTY_NAME>>;

		// Token: 0x04001105 RID: 4357
		internal OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04001106 RID: 4358
		internal OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x04001107 RID: 4359
		internal Dictionary<string, ooOoO> <<EMPTY_NAME>>;

		// Token: 0x04001108 RID: 4360
		internal Dictionary<string, O_0__O_o_O> <<EMPTY_NAME>>;

		// Token: 0x04001109 RID: 4361
		private OleDbCommand <<EMPTY_NAME>>;

		// Token: 0x0400110A RID: 4362
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400110B RID: 4363
		private static List<string> <<EMPTY_NAME>> = new List<string>();
	}
}

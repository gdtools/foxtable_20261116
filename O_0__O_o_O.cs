using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001DB RID: 475
	internal class O_0__O_o_O
	{
		// Token: 0x060016E5 RID: 5861 RVA: 0x000A6D70 File Offset: 0x000A4F70
		internal O_0__O_o_O(object A_0, UdpClient A_1, IPEndPoint A_2, string A_3, IMBuddy A_4, string A_5, SendTypeEnum A_6)
		{
			this.O00o___0OoO.0. = 8;
			this.Oo.Oo0. = 8;
			this.oO_0_Ooo.o. = 1024;
			this.OOOo._0. = new AutoResetEvent(false);
			this.O0.0O0o_O. = new ReaderWriterLock();
			this.O00o___0OoO.0. = new List<int>();
			this.Oo.Oo0. = new List<int>();
			this.OOOo._0. = new Dictionary<int, DateTime>();
			this.O.0O__o. = -1;
			this.O0.0O0o_O. = RuntimeHelpers.GetObjectValue(A_0);
			this.O00o___0OoO.0. = A_1;
			this.OOOo._0. = A_2;
			this.OOOo._0. = A_3;
			this.oO_Ooo_.0. = A_6;
			this.OOOo._0. = new FileStream(A_3, FileMode.Open, FileAccess.Read, FileShare.Read);
			this.Oo.Oo0. = this.OOOo._0..Length;
			this.oO_Ooo_.0. = A_4;
			this.oo.00ooO0_o. = A_5;
			if (A_2.Address.ToString().StartsWith("192.168."))
			{
				this.oO_0_Ooo.o. = 10240;
			}
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x000A6E58 File Offset: 0x000A5058
		internal string <<EMPTY_NAME>>()
		{
			return this.o0OO0ooo0_O.O.;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x000A6E60 File Offset: 0x000A5060
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o0OO0ooo0_O.O. = A_0;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x000A6E69 File Offset: 0x000A5069
		internal string <<EMPTY_NAME>>()
		{
			return this.oo.00ooO0_o.;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x000A6E71 File Offset: 0x000A5071
		internal IMBuddy <<EMPTY_NAME>>()
		{
			return this.oO_Ooo_.0.;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x000A6E79 File Offset: 0x000A5079
		internal SendTypeEnum <<EMPTY_NAME>>()
		{
			return this.oO_Ooo_.0.;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x000A6E81 File Offset: 0x000A5081
		internal void <<EMPTY_NAME>>(SendTypeEnum A_0)
		{
			this.oO_Ooo_.0. = A_0;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x000A6E8A File Offset: 0x000A508A
		internal bool <<EMPTY_NAME>>()
		{
			return this.oo.00ooO0_o.;
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x000A6E92 File Offset: 0x000A5092
		private void <<EMPTY_NAME>>(bool A_0)
		{
			this.oo.00ooO0_o. = A_0;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x000A6E9B File Offset: 0x000A509B
		internal bool <<EMPTY_NAME>>()
		{
			return this.o0OO0ooo0_O.O.;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x000A6EA3 File Offset: 0x000A50A3
		private void <<EMPTY_NAME>>(bool A_0)
		{
			this.o0OO0ooo0_O.O. = A_0;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000A6EAC File Offset: 0x000A50AC
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				string s = string.Concat(new string[]
				{
					Conversions.ToString(this.Oo.Oo0.),
					":",
					Conversions.ToString(this.oO_0_Ooo.o.),
					":",
					Conversions.ToString(this.OOOo._0..Length)
				});
				byte[] bytes = Encoding.Unicode.GetBytes(s);
				this.O00o___0OoO.0..Send(bytes, bytes.Length, this.OOOo._0.);
				DateTime now = DateTime.Now;
				UdpClient udpClient = null;
				IMBuddy imbuddy = null;
				if (this.O0.0O0o_O. is IMClient && this.o_0.Oo_0O0_.() != null && !(this.o_0.Oo_0O0_.() is O_0OOOoO) && !(this.o_0.Oo_0O0_.() is ooo0))
				{
					imbuddy = this.o_0.Oo_0O0_.();
				}
				bool flag;
				while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
				{
					if (this.O00o___0OoO.0..Available > 0)
					{
						IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
						byte[] bytes2 = this.O00o___0OoO.0..Receive(ref ipendPoint);
						string text = Encoding.Unicode.GetString(bytes2);
						if (Operators.CompareString(ipendPoint.ToString(), this.OOOo._0..ToString(), true) != 0)
						{
							continue;
						}
						if (text.StartsWith("@") && text.EndsWith("@"))
						{
							text = text.Substring(1, text.Length - 2);
						}
						string[] array = text.Split(new char[]
						{
							':'
						});
						if (array.Length == 2 && int.TryParse(array[0], out this.Oo.Oo0.) && int.TryParse(array[1], out this.oO_0_Ooo.o.))
						{
							this.Oo.Oo0. = Math.Abs(this.Oo.Oo0.);
							this.oO_0_Ooo.o. = Math.Abs(this.oO_0_Ooo.o.);
							this.O0.0O0o_O. = new object[(int)Math.Ceiling((double)this.OOOo._0..Length / (double)this.oO_0_Ooo.o.) - 1 + 1];
							this.OOOo._0. = new int[(int)Math.Ceiling((double)this.O0.0O0o_O..Length / (double)this.Oo.Oo0.) - 1 + 1];
							this.Oo.Oo0. = new int[(int)Math.Ceiling((double)this.O0.0O0o_O..Length / (double)this.Oo.Oo0.) - 1 + 1];
							flag = true;
							break;
						}
					}
					if (udpClient != null && udpClient.Available > 0)
					{
						IPEndPoint ipendPoint2 = new IPEndPoint(IPAddress.Any, 0);
						byte[] bytes3 = udpClient.Receive(ref ipendPoint2);
						string text2 = Encoding.Unicode.GetString(bytes3);
						if (Operators.CompareString(ipendPoint2.ToString(), this.OOOo._0..ToString(), true) != 0)
						{
							continue;
						}
						if (Operators.CompareString(text2, "Ping", true) == 0)
						{
							s = string.Concat(new string[]
							{
								Conversions.ToString(this.Oo.Oo0.),
								":",
								Conversions.ToString(this.oO_0_Ooo.o.),
								":",
								Conversions.ToString(this.OOOo._0..Length)
							});
							bytes = Encoding.Unicode.GetBytes(s);
							udpClient.Send(bytes, bytes.Length, this.OOOo._0.);
							continue;
						}
						if (text2.StartsWith("@") && text2.EndsWith("@"))
						{
							text2 = text2.Substring(1, text2.Length - 2);
						}
						string[] array2 = text2.Split(new char[]
						{
							':'
						});
						if (array2.Length == 2 && int.TryParse(array2[0], out this.Oo.Oo0.) && int.TryParse(array2[1], out this.oO_0_Ooo.o.))
						{
							this.Oo.Oo0. = Math.Abs(this.Oo.Oo0.);
							this.oO_0_Ooo.o. = Math.Abs(this.oO_0_Ooo.o.);
							this.O0.0O0o_O. = new object[(int)Math.Ceiling((double)this.OOOo._0..Length / (double)this.oO_0_Ooo.o.) - 1 + 1];
							this.OOOo._0. = new int[(int)Math.Ceiling((double)this.O0.0O0o_O..Length / (double)this.Oo.Oo0.) - 1 + 1];
							this.Oo.Oo0. = new int[(int)Math.Ceiling((double)this.O0.0O0o_O..Length / (double)this.Oo.Oo0.) - 1 + 1];
							flag = true;
							this.O00o___0OoO.0. = udpClient;
							break;
						}
					}
					if ((DateTime.Now - now).TotalSeconds > 1.0 && imbuddy != null)
					{
						IMClient imclient = (IMClient)this.O0.0O0o_O.;
						if (udpClient == null)
						{
							string text3 = "\v";
							if (this.O0.0O0o_O. is IMServer)
							{
								udpClient = o0___oO.o0__.0.((IMServer)this.O0.0O0o_O.);
							}
							else
							{
								udpClient = new UdpClient(0);
							}
							o0___oO.O.oOo0O0O.(udpClient);
							udpClient.Client.SendBufferSize = 81920;
							udpClient.Client.ReceiveBufferSize = 81920;
							byte[] bytes4 = Encoding.Unicode.GetBytes(string.Concat(new string[]
							{
								"%02",
								text3,
								imclient.UserName,
								text3,
								imclient.o_oo0Oooo.OOO_.,
								text3,
								this.OOOo._0..ToString(),
								text3,
								this.O_OO.o0o_o0.()
							}));
							udpClient.Send(bytes4, bytes4.Length, imclient.ooOo.oO0.);
							bytes4 = Encoding.Unicode.GetBytes("Ping");
							udpClient.Send(bytes4, bytes4.Length, this.OOOo._0.);
						}
					}
				}
				if (!flag)
				{
					this.O00o___0OoO.0..Close();
					this.OOOo._0..Close();
					this.o_OoO._.(true);
					this.O._O___O. = true;
				}
				else
				{
					this.O00o___0OoO.0. = DateTime.Now;
					this.OO.Oooo. = DateTime.Now;
					this.O00o___0OoO.0..BeginReceive(new AsyncCallback(this.o_OoO._.), null);
					int num = Math.Min(this.O00o___0OoO.0. - 1, this.OOOo._0..Length - 1);
					for (int i = 0; i <= num; i++)
					{
						this.oo0_.O00.(i);
						this.O00o___0OoO.0..Add(i);
						this.Oo.Oo0..Add(i);
					}
					int num2 = this.O00o___0OoO.0.[this.O00o___0OoO.0..Count - 1];
					int millisecondsTimeout = 2000;
					now = DateTime.Now;
					try
					{
						foreach (int a_ in this.O00o___0OoO.0.)
						{
							this.o0o_0OO00.Oo0_.(a_);
							Thread.Sleep(10);
						}
					}
					finally
					{
						List<int>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.O00o___0OoO.0..Clear();
					int num3;
					if (this.o_0.Oo_0O0_.() == SendTypeEnum.Capture)
					{
						num3 = 5;
					}
					else
					{
						num3 = 20;
					}
					bool a_3;
					while ((!(this.O0.0O0o_O. is IMClient) || !((IMClient)this.O0.0O0o_O.).O0_OOo.O.) && (!(this.O0.0O0o_O. is IMServer) || !((IMServer)this.O0.0O0o_O.).o0oo__0Oo_.o00.) && !this.O0.0O0o_O. && !this.oo0_.O00.())
					{
						bool flag2;
						try
						{
							foreach (int a_2 in this.O00o___0OoO.0.)
							{
								if (flag2)
								{
									Thread.Sleep(10);
								}
								this.o0o_0OO00.Oo0_.(a_2);
							}
						}
						finally
						{
							List<int>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						flag2 = false;
						bool flag3 = false;
						this.O00o___0OoO.0..Clear();
						if (this.OOOo._0..WaitOne(millisecondsTimeout))
						{
							flag3 = true;
							millisecondsTimeout = 1000;
						}
						object oo.Oo0. = this.Oo.Oo0.;
						int num4;
						lock (oo.Oo0.)
						{
							for (int j = this.Oo.Oo0..Count - 1; j >= 0; j += -1)
							{
								if (this.Oo.Oo0.[this.Oo.Oo0.[j]] > 0)
								{
									this.Oo.Oo0..RemoveAt(j);
									flag3 = true;
								}
							}
							if (flag3)
							{
								num4 = 0;
								while (this.Oo.Oo0..Count < this.O00o___0OoO.0. && num2 < this.OOOo._0..Length - 1)
								{
									num2++;
									this.oo0_.O00.(num2);
									this.O00o___0OoO.0..Add(num2);
									this.Oo.Oo0..Add(num2);
								}
								if (this.Oo.Oo0..Count == 0)
								{
									a_3 = true;
									break;
								}
								for (int k = this.Oo.Oo0..Count - 1; k >= 0; k += -1)
								{
									int num5 = this.Oo.Oo0.[k];
									if (!this.O00o___0OoO.0..Contains(num5))
									{
										if (this.O.0O__o. - num5 >= 1)
										{
											bytes = BitConverter.GetBytes(num5);
											this.O00o___0OoO.0..Send(bytes, bytes.Length, this.OOOo._0.);
										}
										if (this.O.0O__o. - num5 >= 3 && (DateTime.Now - this.OOOo._0.[num5]).TotalMilliseconds > this.oo.00ooO0_o. * (double)(1 + this.OOOo._0.[num5]) && !this.O00o___0OoO.0..Contains(num5))
										{
											this.O00o___0OoO.0..Insert(0, num5);
											int num6;
											num6++;
										}
									}
								}
							}
							else
							{
								num4++;
								if (this.Oo.Oo0..Count == 0)
								{
									a_3 = true;
									break;
								}
								if (num4 == 1)
								{
									this.O00o___0OoO.0..AddRange(this.Oo.Oo0.);
								}
								else
								{
									int index = OoOo0O.Oo_oOO_._Oo_o.(0, this.Oo.Oo0..Count);
									this.O00o___0OoO.0..Add(this.Oo.Oo0.[index]);
								}
								flag2 = true;
								millisecondsTimeout = 1500;
								try
								{
									foreach (int value in this.Oo.Oo0.)
									{
										bytes = BitConverter.GetBytes(value);
										this.O00o___0OoO.0..Send(bytes, bytes.Length, this.OOOo._0.);
									}
								}
								finally
								{
									List<int>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								int num6;
								num6 += this.O00o___0OoO.0..Count;
							}
						}
						try
						{
							foreach (int num7 in this.O00o___0OoO.0.)
							{
								if (this.OOOo._0.[num7] >= num3)
								{
									this.O._O___O. = true;
									goto IL_A96;
								}
							}
						}
						finally
						{
							List<int>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						if (num4 > 20)
						{
							this.O._O___O. = true;
							break;
						}
						if (this.O00o___0OoO.0. != null && this.O00o___0OoO.0..FindForm() != null && (DateTime.Now - this.OO.Oooo.).TotalSeconds >= 0.5 && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
						{
							OO_00oOO.BaseMainForm.Invoke(new O_0__O_o_O.ooO_(this.oO_Ooo_.0.));
						}
					}
					IL_A96:
					this.O0.0O0o_O..AcquireWriterLock(-1);
					double totalSeconds = (DateTime.Now - now).TotalSeconds;
					this.O0.0O0o_O. = true;
					this.O00o___0OoO.0..Close();
					this.O0.0O0o_O..ReleaseWriterLock();
					if (!this.oo0_.O00.())
					{
						this.oo.00ooO0_o.(a_3);
					}
					this.OOOo._0..Close();
				}
			}
			catch (Exception a_4)
			{
				ooO.oOo0Oo.o.(a_4, "");
			}
			finally
			{
				this.O0.0O0o_O. = true;
				this.o_OoO._.(true);
				if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
				{
					OO_00oOO.BaseMainForm.Invoke(new O_0__O_o_O.O_0OO0O(this.oo0_.O00.));
				}
			}
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000A7AAC File Offset: 0x000A5CAC
		private void <<EMPTY_NAME>>()
		{
			if (this.o_0.Oo_0O0_.() == SendTypeEnum.Capture && !this.oo0_.O00.() && this.O0.0O0o_O. is IMClient && !(this.o_0.Oo_0O0_.() is ooo0) && !(this.o_0.Oo_0O0_.() is O_0OOOoO))
			{
				string a_ = "\u0002/\u0002=(" + this.OOOo._0..Substring((OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\").Length) + ")=\\\u0002";
				IMClient imclient = (IMClient)this.O0.0O0o_O.;
				((IMClient)this.O0.0O0o_O.).O.00O0_O_o_oO.(this.o_0.Oo_0O0_.().Name, a_, 1, 1, null);
			}
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000A7B54 File Offset: 0x000A5D54
		private void <<EMPTY_NAME>>()
		{
			TimeSpan timeSpan = DateTime.Now - this.O00o___0OoO.0.;
			double num = (double)this.oO_Ooo_.0. / 1024.0 / timeSpan.TotalSeconds;
			if (num < 1000.0)
			{
				this.O00o___0OoO.0..o_.0o0O__.().Text = Strings.Format(num, "0.0") + "K/S";
			}
			else
			{
				this.O00o___0OoO.0..o_.0o0O__.().Text = Strings.Format(num / 1024.0, "0.00") + "M/S";
			}
			long num2 = this.oO_Ooo_.0. / 1024L;
			string str;
			if (num2 < 1000L)
			{
				str = num2.ToString() + "K";
			}
			else
			{
				str = Strings.Format((double)this.oO_Ooo_.0. / 1024.0 / 1024.0, "0.00") + "M";
			}
			num2 = this.Oo.Oo0. / 1014L;
			string str2;
			if (num2 < 1000L)
			{
				str2 = num2.ToString() + "K";
			}
			else
			{
				str2 = Strings.Format((double)this.Oo.Oo0. / 1024.0 / 1024.0, "0.00") + "M";
			}
			this.O00o___0OoO.0..o_0O.00.().Text = str + "/" + str2;
			this.O00o___0OoO.0..o_.0o0O__.().Value = Math.Min(100, (int)Math.Round((double)this.oO_Ooo_.0. / (double)this.Oo.Oo0. * 100.0));
			this.OO.Oooo. = DateTime.Now;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x000A7D1C File Offset: 0x000A5F1C
		private void <<EMPTY_NAME>>(int A_0)
		{
			this.OOOo._0.[A_0] = this.OOOo._0.[A_0] + 1;
			this.OOOo._0.[A_0] = DateTime.Now;
			int num = A_0 * this.Oo.Oo0.;
			int num2 = Math.Min(num + this.Oo.Oo0. - 1, this.O0.0O0o_O..Length - 1);
			int num3 = num2;
			for (int i = num; i <= num3; i++)
			{
				byte[] array = (byte[])this.O0.0O0o_O.[i];
				if (array != null)
				{
					if (this.OOOo._0.[A_0] > 1)
					{
						Array.Copy(BitConverter.GetBytes(-BitConverter.ToInt32(array, 0)), 0, array, 0, 4);
					}
					if (this.Oo.Oo0.[A_0] > 0)
					{
						break;
					}
					this.O00o___0OoO.0..Send(array, array.Length, this.OOOo._0.);
				}
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000A7DD0 File Offset: 0x000A5FD0
		private void <<EMPTY_NAME>>(int A_0)
		{
			int num = A_0 * this.Oo.Oo0.;
			int num2 = Math.Min(num + this.Oo.Oo0. - 1, this.O0.0O0o_O..Length - 1);
			byte[] array = new byte[this.oO_0_Ooo.o. - 1 + 1];
			int num3 = num2;
			for (int i = num; i <= num3; i++)
			{
				int num4 = this.OOOo._0..Read(array, 0, this.oO_0_Ooo.o.);
				byte[] array2 = new byte[num4 + 3 + 1];
				Array.Copy(BitConverter.GetBytes(i), 0, array2, 0, 4);
				Array.Copy(array, 0, array2, 4, num4);
				this.O0.0O0o_O.[i] = array2;
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000A7E64 File Offset: 0x000A6064
		private void <<EMPTY_NAME>>(int A_0)
		{
			int num = A_0 * this.Oo.Oo0.;
			int num2 = Math.Min(num + this.Oo.Oo0. - 1, this.O0.0O0o_O..Length - 1);
			int num3 = num2;
			for (int i = num; i <= num3; i++)
			{
				this.O0.0O0o_O.[i] = null;
			}
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x000A7EAC File Offset: 0x000A60AC
		private void <<EMPTY_NAME>>(IAsyncResult A_0)
		{
			this.O0.0O0o_O..AcquireReaderLock(-1);
			try
			{
				if (!this.O0.0O0o_O.)
				{
					IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
					byte[] bytes = this.O00o___0OoO.0..EndReceive(A_0, ref ipendPoint);
					string @string = Encoding.Unicode.GetString(bytes);
					if (Operators.CompareString(this.OOOo._0..ToString(), ipendPoint.ToString(), true) == 0)
					{
						object oo.Oo0. = this.Oo.Oo0.;
						bool flag2;
						lock (oo.Oo0.)
						{
							int num;
							if (int.TryParse(@string, out num))
							{
								if (num == 2147483647 || num == -2147483648)
								{
									this.oo.00ooO0_o.(true);
									this.OOOo._0..Set();
									return;
								}
								num = Math.Abs(num);
								if (this.Oo.Oo0..Contains(num))
								{
									this.Oo.Oo0..Remove(num);
									this.o_0.Oo_0O0_.(num);
								}
								if (num >= 0 && num <= this.Oo.Oo0..Length - 1)
								{
									if (this.Oo.Oo0.[num] == 0)
									{
										this.oO_Ooo_.0. += (long)(this.Oo.Oo0. * this.oO_0_Ooo.o.);
										this.O.0O__o. = Math.Max(this.O.0O__o., num);
										flag2 = true;
										if (this.OOOo._0.[num] == 1)
										{
											this.O00o___0OoO.0. += (DateTime.Now - this.OOOo._0.[num]).TotalMilliseconds;
											this.O._O___O.++;
											this.oo.00ooO0_o. = this.O00o___0OoO.0. / (double)this.O._O___O.;
										}
									}
									this.Oo.Oo0.[num] = this.Oo.Oo0.[num] + 1;
								}
							}
							while (this.O00o___0OoO.0..Available > 0)
							{
								ipendPoint = new IPEndPoint(IPAddress.Any, 0);
								bytes = this.O00o___0OoO.0..Receive(ref ipendPoint);
								@string = Encoding.Unicode.GetString(bytes);
								if (Operators.CompareString(this.OOOo._0..ToString(), ipendPoint.ToString(), true) == 0 && int.TryParse(@string, out num))
								{
									if (num == 2147483647 || num == -2147483648)
									{
										this.oo.00ooO0_o.(true);
										this.OOOo._0..Set();
										return;
									}
									num = Math.Abs(num);
									if (this.Oo.Oo0..Contains(num))
									{
										this.Oo.Oo0..Remove(num);
										this.o_0.Oo_0O0_.(num);
									}
									if (num >= 0 && num <= this.Oo.Oo0..Length - 1)
									{
										if (this.Oo.Oo0.[num] == 0)
										{
											this.oO_Ooo_.0. += (long)(this.Oo.Oo0. * this.oO_0_Ooo.o.);
											this.O.0O__o. = Math.Max(this.O.0O__o., num);
											flag2 = true;
											if (this.OOOo._0.[num] == 1)
											{
												this.O00o___0OoO.0. += (DateTime.Now - this.OOOo._0.[num]).TotalMilliseconds;
												this.O._O___O.++;
												this.oo.00ooO0_o. = this.O00o___0OoO.0. / (double)this.O._O___O.;
											}
										}
										this.Oo.Oo0.[num] = this.Oo.Oo0.[num] + 1;
									}
								}
							}
						}
						if (flag2)
						{
							this.OOOo._0..Set();
						}
						if (!this.O0.0O0o_O.)
						{
							this.O00o___0OoO.0..BeginReceive(new AsyncCallback(this.o_OoO._.), null);
						}
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.O0.0O0o_O..ReleaseReaderLock();
			}
		}

		// Token: 0x0400095D RID: 2397
		private object <<EMPTY_NAME>>;

		// Token: 0x0400095E RID: 2398
		private UdpClient <<EMPTY_NAME>>;

		// Token: 0x0400095F RID: 2399
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x04000960 RID: 2400
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000961 RID: 2401
		private FileStream <<EMPTY_NAME>>;

		// Token: 0x04000962 RID: 2402
		private int <<EMPTY_NAME>>;

		// Token: 0x04000963 RID: 2403
		private int <<EMPTY_NAME>>;

		// Token: 0x04000964 RID: 2404
		private int <<EMPTY_NAME>>;

		// Token: 0x04000965 RID: 2405
		private object[] <<EMPTY_NAME>>;

		// Token: 0x04000966 RID: 2406
		private int[] <<EMPTY_NAME>>;

		// Token: 0x04000967 RID: 2407
		private int[] <<EMPTY_NAME>>;

		// Token: 0x04000968 RID: 2408
		private AutoResetEvent <<EMPTY_NAME>>;

		// Token: 0x04000969 RID: 2409
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400096A RID: 2410
		private ReaderWriterLock <<EMPTY_NAME>>;

		// Token: 0x0400096B RID: 2411
		private List<int> <<EMPTY_NAME>>;

		// Token: 0x0400096C RID: 2412
		private List<int> <<EMPTY_NAME>>;

		// Token: 0x0400096D RID: 2413
		private Dictionary<int, DateTime> <<EMPTY_NAME>>;

		// Token: 0x0400096E RID: 2414
		private double <<EMPTY_NAME>>;

		// Token: 0x0400096F RID: 2415
		private int <<EMPTY_NAME>>;

		// Token: 0x04000970 RID: 2416
		private double <<EMPTY_NAME>>;

		// Token: 0x04000971 RID: 2417
		private int <<EMPTY_NAME>>;

		// Token: 0x04000972 RID: 2418
		private IMBuddy <<EMPTY_NAME>>;

		// Token: 0x04000973 RID: 2419
		private string <<EMPTY_NAME>>;

		// Token: 0x04000974 RID: 2420
		private SendTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000975 RID: 2421
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000976 RID: 2422
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000977 RID: 2423
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000978 RID: 2424
		private string <<EMPTY_NAME>>;

		// Token: 0x04000979 RID: 2425
		internal oO0 <<EMPTY_NAME>>;

		// Token: 0x0400097A RID: 2426
		private long <<EMPTY_NAME>>;

		// Token: 0x0400097B RID: 2427
		internal long <<EMPTY_NAME>>;

		// Token: 0x0400097C RID: 2428
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x0400097D RID: 2429
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x0400097E RID: 2430
		internal string <<EMPTY_NAME>>;

		// Token: 0x020001DC RID: 476
		// (Invoke) Token: 0x060016FA RID: 5882
		public delegate void O_0OO0O();

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x060016FE RID: 5886
		public delegate void ooO_();
	}
}

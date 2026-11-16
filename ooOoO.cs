using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001D9 RID: 473
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ooOoO
	{
		// Token: 0x060016D3 RID: 5843 RVA: 0x000A5EF4 File Offset: 0x000A40F4
		internal ooOoO(object A_0, UdpClient A_1, IPEndPoint A_2, string A_3, string A_4, string A_5, SendTypeEnum A_6)
		{
			this.o_Oo_o._Oo_o_. = 8;
			this.O.0_oO_o_0O0o. = 1024;
			this.O_0Oo.OO_o. = RuntimeHelpers.GetObjectValue(A_0);
			this.O0__00OoOo_O.o. = A_1;
			this.O_0Oo.OO_o. = A_2;
			this.o_Oo_o._Oo_o_. = A_3;
			this.o_Oo_o._Oo_o_. = A_6;
			this.ooo0_.o__. = Path.GetTempFileName();
			this.o_Oo_o._Oo_o_. = new FileStream(this.ooo0_.o__., FileMode.Create);
			this.oOoo_oo0o_._0. = A_4;
			this.oo_o__O_.oOO0. = A_5;
			if (A_2.Address.ToString().StartsWith("192.168."))
			{
				this.O.0_oO_o_0O0o. = 10240;
			}
			if (A_0 is IMClient)
			{
				IMClient imclient = (IMClient)this.O_0Oo.OO_o.;
				if (imclient.ooOooo.oO. != null && !imclient.ooOooo.oO..IsDisposed)
				{
					try
					{
						foreach (object obj in imclient.ooOooo.oO..Controls)
						{
							Control control = (Control)obj;
							if (control is Oo0O__ && Operators.CompareString(((Oo0O__)control).O_OO.o0o_o0., A_5, true) == 0)
							{
								this.O0__00OoOo_O.o. = (Oo0O__)control;
								break;
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
				}
			}
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x000A6038 File Offset: 0x000A4238
		internal string <<EMPTY_NAME>>()
		{
			return this.oo_o__O_.oOO0.;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x000A6040 File Offset: 0x000A4240
		internal string <<EMPTY_NAME>>()
		{
			return this.oOoo_oo0o_._0.;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x000A6048 File Offset: 0x000A4248
		internal SendTypeEnum <<EMPTY_NAME>>()
		{
			return this.o_Oo_o._Oo_o_.;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000A6050 File Offset: 0x000A4250
		internal void <<EMPTY_NAME>>(SendTypeEnum A_0)
		{
			this.o_Oo_o._Oo_o_. = A_0;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000A6059 File Offset: 0x000A4259
		internal bool <<EMPTY_NAME>>()
		{
			return this.o_Oo_o._Oo_o_.;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x000A6061 File Offset: 0x000A4261
		private void <<EMPTY_NAME>>(bool A_0)
		{
			this.o_Oo_o._Oo_o_. = A_0;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000A606A File Offset: 0x000A426A
		internal bool <<EMPTY_NAME>>()
		{
			return this.O_OOOooo_0.O.;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x000A6072 File Offset: 0x000A4272
		private void <<EMPTY_NAME>>(bool A_0)
		{
			this.O_OOOooo_0.O. = true;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000A607B File Offset: 0x000A427B
		internal DataRow <<EMPTY_NAME>>()
		{
			return this.o0_.OO0O_o.;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x000A6083 File Offset: 0x000A4283
		internal void <<EMPTY_NAME>>(DataRow A_0)
		{
			this.o0_.OO0O_o. = A_0;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x000A608C File Offset: 0x000A428C
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				DateTime now = DateTime.Now;
				IPEndPoint ipendPoint = null;
				IMClient imclient = null;
				if (this.O_0Oo.OO_o. is IMClient)
				{
					imclient = (IMClient)this.O_0Oo.OO_o.;
				}
				bool flag;
				while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0 && !this.ooo0_.o__.)
				{
					if (this.O0__00OoOo_O.o..Available > 0)
					{
						now = DateTime.Now;
						IPEndPoint ipendPoint2 = new IPEndPoint(IPAddress.Any, 0);
						byte[] array = this.O0__00OoOo_O.o..Receive(ref ipendPoint2);
						string @string = Encoding.Unicode.GetString(array);
						if (imclient != null && Operators.CompareString(imclient.ooOo.oO0..ToString(), ipendPoint2.ToString(), true) == 0 && @string.StartsWith("%02\v") && ipendPoint == null)
						{
							string[] array2 = @string.Split(new char[]
							{
								'\v'
							});
							if (array2.Length == 3 && Operators.CompareString(array2[1], this.o0OO._0.(), true) == 0)
							{
								string ipString = array2[2].Substring(0, array2[2].IndexOf(":"));
								string value = array2[2].Substring(array2[2].IndexOf(":") + 1);
								ipendPoint = new IPEndPoint(IPAddress.Parse(ipString), Conversions.ToInteger(value));
								array = Encoding.Unicode.GetBytes("Ping");
								this.O0__00OoOo_O.o..Send(array, array.Length, ipendPoint);
								continue;
							}
						}
						if (Operators.CompareString(this.O_0Oo.OO_o..ToString(), ipendPoint2.ToString(), true) == 0 || (ipendPoint != null && Operators.CompareString(ipendPoint.ToString(), ipendPoint2.ToString(), true) == 0))
						{
							string[] array3 = @string.Split(new char[]
							{
								':'
							});
							if (array3.Length == 3 && Versioned.IsNumeric(array3[0]) && Versioned.IsNumeric(array3[1]))
							{
								int val = Conversions.ToInteger(array3[0]);
								int val2 = Conversions.ToInteger(array3[1]);
								long num = Conversions.ToLong(array3[2]);
								this.oOoo_oo0o_._0. = num;
								this.o_Oo_o._Oo_o_. = Math.Min(this.o_Oo_o._Oo_o_., val);
								this.O.0_oO_o_0O0o. = Math.Min(this.O.0_oO_o_0O0o., val2);
								this.O_0Oo.OO_o. = new object[(int)Math.Ceiling((double)num / (double)this.O.0_oO_o_0O0o.) - 1 + 1];
								this.o_Oo_o._Oo_o_. = new int[(int)Math.Ceiling((double)this.O_0Oo.OO_o..Length / (double)this.o_Oo_o._Oo_o_.) - 1 + 1];
								this.o_Oo_o._Oo_o_..SetLength(num);
								this.O_0Oo.OO_o. = ipendPoint2;
								flag = true;
								break;
							}
						}
					}
				}
				if (!flag || this.o_Oo_o._Oo_o_..Length == 0)
				{
					this.o_Oo_o._Oo_o_..Close();
					this.O0__00OoOo_O.o..Close();
					if (OO_00oOO.FileSys.FileExists(this.ooo0_.o__.))
					{
						OO_00oOO.FileSys.DeleteFile(this.ooo0_.o__.);
					}
					if (!flag)
					{
						this.Oo0___._oooo_O. = true;
					}
					this.o0_.OO0O_o.(true);
				}
				else
				{
					byte[] bytes = Encoding.Unicode.GetBytes(Conversions.ToString(this.o_Oo_o._Oo_o_.) + ":" + Conversions.ToString(this.O.0_oO_o_0O0o.));
					this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
					Encoding.Unicode.GetBytes(string.Concat(new string[]
					{
						"@",
						Conversions.ToString(this.o_Oo_o._Oo_o_.),
						":",
						Conversions.ToString(this.O.0_oO_o_0O0o.),
						"@"
					}));
					this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
					this.O_0Oo.OO_o. = DateTime.Now;
					this.O.0_oO_o_0O0o. = DateTime.Now;
					now = DateTime.Now;
					int[] array4 = new int[this.o_Oo_o._Oo_o_..Length - 1 + 1];
					int num2;
					if (this.OO.000O.() == SendTypeEnum.Capture)
					{
						num2 = 5;
					}
					else
					{
						num2 = 20;
					}
					bool flag2;
					while (DateTime.Compare(DateTime.Now, now.AddSeconds((double)num2)) < 0 && (!(this.O_0Oo.OO_o. is IMClient) || !((IMClient)this.O_0Oo.OO_o.).O0_OOo.O.) && (!(this.O_0Oo.OO_o. is IMServer) || !((IMServer)this.O_0Oo.OO_o.).o0oo__0Oo_.o00.) && !this.ooo0_.o__.)
					{
						if (this.O0__00OoOo_O.o..Available > 0)
						{
							now = DateTime.Now;
							IPEndPoint ipendPoint3 = new IPEndPoint(IPAddress.Any, 0);
							byte[] array5 = this.O0__00OoOo_O.o..Receive(ref ipendPoint3);
							if (Operators.CompareString(ipendPoint3.ToString(), this.O_0Oo.OO_o..ToString(), true) == 0)
							{
								if (array5.Length == 4)
								{
									int num3 = BitConverter.ToInt32(array5, 0);
									if (this.o_Oo_o._Oo_o_.[num3] == -1)
									{
										array4[num3]++;
										bytes = Encoding.Unicode.GetBytes(num3.ToString());
										this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
										bytes = Encoding.Unicode.GetBytes((-num3).ToString());
										this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
									}
								}
								else if (array5.Length > 4)
								{
									int num4 = Math.Abs(BitConverter.ToInt32(array5, 0));
									if (num4 >= 0 && num4 <= this.O_0Oo.OO_o..Length - 1)
									{
										int num5 = num4 / this.o_Oo_o._Oo_o_.;
										if (this.o_Oo_o._Oo_o_.[num5] == -1)
										{
											if (num4 == num5 * this.o_Oo_o._Oo_o_.)
											{
												bytes = Encoding.Unicode.GetBytes(num5.ToString());
												this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
												bytes = Encoding.Unicode.GetBytes((-num5).ToString());
												this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
											}
										}
										else if (this.o_Oo_o._Oo_o_.[num5] != -1 && this.O_0Oo.OO_o.[num4] == null)
										{
											this.O_0Oo.OO_o.[num4] = array5;
											this.o_Oo_o._Oo_o_.[num5] = this.o_Oo_o._Oo_o_.[num5] + 1;
											if (this.o_Oo_o._Oo_o_.[num5] == this.o_Oo_o._Oo_o_. || (num5 == this.o_Oo_o._Oo_o_..Length - 1 && this.o_Oo_o._Oo_o_.[num5] == this.O_0Oo.OO_o..Length % this.o_Oo_o._Oo_o_.))
											{
												this.o_Oo_o._Oo_o_.[num5] = -1;
												this.o0_.OO0O_o.(num5);
												this.ooo0_.o__.++;
												bytes = Encoding.Unicode.GetBytes(num5.ToString());
												this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
												bytes = Encoding.Unicode.GetBytes((-num5).ToString());
												this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
											}
										}
										if (this.ooo0_.o__. == this.o_Oo_o._Oo_o_..Length)
										{
											bytes = Encoding.Unicode.GetBytes(int.MaxValue.ToString());
											this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
											Thread.Sleep(10);
											bytes = Encoding.Unicode.GetBytes(int.MinValue.ToString());
											this.O0__00OoOo_O.o..Send(bytes, bytes.Length, this.O_0Oo.OO_o.);
											flag2 = true;
											break;
										}
									}
								}
							}
						}
					}
					this.O0__00OoOo_O.o..Close();
					this.o_Oo_o._Oo_o_..Close();
					if (this.O_0Oo.OO_o. is IMClient && !this.ooo0_.o__. && !flag2)
					{
						this.Oo0___._oooo_O. = true;
					}
					object o00.O0. = OO_00oOO.IMClients.O00.O0.;
					ObjectFlowControl.CheckForSyncLockOnValueType(o00.O0.);
					lock (o00.O0.)
					{
						if (flag2)
						{
							if (Operators.CompareString(OO_00oOO.FileSys.GetParentPath(this.o_Oo_o._Oo_o_.), "", true) == 0)
							{
								string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(this.o_Oo_o._Oo_o_.);
								string extension = Path.GetExtension(this.o_Oo_o._Oo_o_.);
								string text = OO_00oOO.ProjectPath + "QQClient\\ReceivedFiles\\" + Strings.Format(DateTime.Today, "yyyyMM") + "\\";
								if (!OO_00oOO.FileSys.DirectoryExists(text))
								{
									OO_00oOO.FileSys.CreateDirectory(text);
								}
								if (!OO_00oOO.FileSys.FileExists(text + fileNameWithoutExtension + extension))
								{
									this.o_Oo_o._Oo_o_. = text + fileNameWithoutExtension + extension;
								}
								else
								{
									int num6 = 1;
									while (OO_00oOO.FileSys.FileExists(string.Concat(new string[]
									{
										text,
										fileNameWithoutExtension,
										"(",
										Conversions.ToString(num6),
										")",
										extension
									})))
									{
										num6++;
									}
									this.o_Oo_o._Oo_o_. = string.Concat(new string[]
									{
										text,
										fileNameWithoutExtension,
										"(",
										Conversions.ToString(num6),
										")",
										extension
									});
								}
							}
							File.Move(this.ooo0_.o__., this.o_Oo_o._Oo_o_.);
							this.O_OOOooo_0.O.(true);
						}
						else if (OO_00oOO.FileSys.FileExists(this.ooo0_.o__.))
						{
							OO_00oOO.FileSys.DeleteFile(this.ooo0_.o__.);
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
				this.o0_.OO0O_o.(true);
				if (this.OO.000O.() != null && this.OO.000O.() == SendTypeEnum.Capture)
				{
					IMClient imclient2 = (IMClient)this.O_0Oo.OO_o.;
					object oo.___oo__0_O. = imclient2.oo.___oo__0_O.;
					ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.);
					lock (oo.___oo__0_O.)
					{
						imclient2.o_oo0.O0Oo__oO.--;
					}
				}
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x000A6AA4 File Offset: 0x000A4CA4
		private void <<EMPTY_NAME>>(int A_0)
		{
			long offset = (long)A_0 * (long)this.o_Oo_o._Oo_o_. * (long)this.O.0_oO_o_0O0o.;
			int num = A_0 * this.o_Oo_o._Oo_o_.;
			int num2 = Math.Min(num + this.o_Oo_o._Oo_o_. - 1, this.O_0Oo.OO_o..Length - 1);
			this.o_Oo_o._Oo_o_..Seek(offset, SeekOrigin.Begin);
			int num3 = num2;
			for (int i = num; i <= num3; i++)
			{
				byte[] array = (byte[])this.O_0Oo.OO_o.[i];
				this.o_Oo_o._Oo_o_..Write(array, 4, array.Length - 4);
				this.o_Oo_o._Oo_o_. = this.o_Oo_o._Oo_o_. + (long)array.Length - 4L;
				this.O_0Oo.OO_o.[i] = null;
			}
			if (this.O0__00OoOo_O.o. != null && this.O0__00OoOo_O.o..FindForm() != null && (DateTime.Now - this.O.0_oO_o_0O0o.).TotalSeconds >= 0.5 && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new ooOoO.oOoo(this.o0_.OO0O_o.));
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000A6BA8 File Offset: 0x000A4DA8
		private void <<EMPTY_NAME>>()
		{
			TimeSpan timeSpan = DateTime.Now - this.O_0Oo.OO_o.;
			double num = (double)this.o_Oo_o._Oo_o_. / 1024.0 / timeSpan.TotalSeconds;
			if (num < 1000.0)
			{
				this.O0__00OoOo_O.o..O0__00OoOo_O.o.().Text = Strings.Format(num, "0.0") + "K/S";
			}
			else
			{
				num /= 1024.0;
				this.O0__00OoOo_O.o..O0__00OoOo_O.o.().Text = Strings.Format(num, "0.00") + "M/S";
			}
			long num2 = this.o_Oo_o._Oo_o_. / 1024L;
			string str;
			if (num2 < 1000L)
			{
				str = num2.ToString() + "K";
			}
			else
			{
				str = Strings.Format((double)this.o_Oo_o._Oo_o_. / 1024.0 / 1024.0, "0.00") + "M";
			}
			num2 = this.oOoo_oo0o_._0. / 1014L;
			string str2;
			if (num2 < 1000L)
			{
				str2 = num2.ToString() + "K";
			}
			else
			{
				str2 = Strings.Format((double)this.oOoo_oo0o_._0. / 1024.0 / 1024.0, "0.00") + "M";
			}
			this.O0__00OoOo_O.o..Oo0O_.o.().Text = str + "/" + str2;
			this.O0__00OoOo_O.o..O0__00OoOo_O.o.().Value = Math.Min(100, (int)Math.Round((double)this.o_Oo_o._Oo_o_. / (double)this.oOoo_oo0o_._0. * 100.0));
			this.O.0_oO_o_0O0o. = DateTime.Now;
		}

		// Token: 0x04000945 RID: 2373
		private object <<EMPTY_NAME>>;

		// Token: 0x04000946 RID: 2374
		private UdpClient <<EMPTY_NAME>>;

		// Token: 0x04000947 RID: 2375
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x04000948 RID: 2376
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000949 RID: 2377
		private FileStream <<EMPTY_NAME>>;

		// Token: 0x0400094A RID: 2378
		private int <<EMPTY_NAME>>;

		// Token: 0x0400094B RID: 2379
		private int <<EMPTY_NAME>>;

		// Token: 0x0400094C RID: 2380
		private object[] <<EMPTY_NAME>>;

		// Token: 0x0400094D RID: 2381
		private int[] <<EMPTY_NAME>>;

		// Token: 0x0400094E RID: 2382
		private int <<EMPTY_NAME>>;

		// Token: 0x0400094F RID: 2383
		private string <<EMPTY_NAME>>;

		// Token: 0x04000950 RID: 2384
		private string <<EMPTY_NAME>>;

		// Token: 0x04000951 RID: 2385
		private SendTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000952 RID: 2386
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000953 RID: 2387
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000954 RID: 2388
		private string <<EMPTY_NAME>>;

		// Token: 0x04000955 RID: 2389
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04000956 RID: 2390
		internal Oo0O__ <<EMPTY_NAME>>;

		// Token: 0x04000957 RID: 2391
		private long <<EMPTY_NAME>>;

		// Token: 0x04000958 RID: 2392
		internal long <<EMPTY_NAME>>;

		// Token: 0x04000959 RID: 2393
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x0400095A RID: 2394
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x0400095B RID: 2395
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400095C RID: 2396
		internal bool <<EMPTY_NAME>>;

		// Token: 0x020001DA RID: 474
		// (Invoke) Token: 0x060016E4 RID: 5860
		public delegate void oOoo();
	}
}

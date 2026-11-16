using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001CF RID: 463
	internal class o0O0OOoOO
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x0009A44C File Offset: 0x0009864C
		public o0O0OOoOO(IMServer A_0, IPEndPoint A_1, string A_2)
		{
			this.ooOoO_0Oo.O. = 8;
			this.o0Ooo_oO_Oo.0. = 8;
			this.OO._000_oO_O. = 500;
			this.oO_o_O.o_. = new AutoResetEvent(false);
			this.ooOoO_0Oo.O. = new ReaderWriterLock();
			this.ooOoO_0Oo.O. = new List<int>();
			this.o0Ooo_oO_Oo.0. = new List<int>();
			this.O_.OOoo_Oo. = -1;
			this.oO_o_O.o_. = A_0;
			this.ooo_OoooOOO.0. = A_1;
			int length = A_2.Length;
			this.oO_o_O.o_. = new object[(int)Math.Ceiling((double)length / (double)this.OO._000_oO_O.) - 1 + 1];
			this.oO_o_O.o_. = new int[(int)Math.Ceiling((double)this.oO_o_O.o_..Length / (double)this.o0Ooo_oO_Oo.0.) - 1 + 1];
			this.o0Ooo_oO_Oo.0. = new int[(int)Math.Ceiling((double)this.oO_o_O.o_..Length / (double)this.o0Ooo_oO_Oo.0.) - 1 + 1];
			int num = this.oO_o_O.o_..Length - 1;
			for (int i = 0; i <= num; i++)
			{
				this.oO_o_O.o_.[i] = Encoding.Unicode.GetBytes(Conversions.ToString(i) + "\t" + A_2.Substring(i * this.OO._000_oO_O., Math.Min(this.OO._000_oO_O., length - i * this.OO._000_oO_O.)));
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0009A588 File Offset: 0x00098788
		internal bool <<EMPTY_NAME>>()
		{
			try
			{
				this.ooOoO_0Oo.O. = o0___oO.o0__.0.(this.oO_o_O.o_.);
				o0___oO.O.oOo0O0O.(this.ooOoO_0Oo.O.);
				this.ooOoO_0Oo.O..Client.SendBufferSize = 81920;
				this.ooOoO_0Oo.O..Client.ReceiveBufferSize = 81920;
				string text = this.ooOoO_0Oo.O..Client.LocalEndPoint.ToString();
				this.oO_o_O.o_..O0o_.Oo0oo.(this.ooo_OoooOOO.0., text.Substring(text.IndexOf(":") + 1) + "\t" + Conversions.ToString(this.oO_o_O.o_..Length));
				DateTime now = DateTime.Now;
				bool flag;
				while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
				{
					if (this.ooOoO_0Oo.O..Available > 0)
					{
						IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
						byte[] bytes = this.ooOoO_0Oo.O..Receive(ref ipendPoint);
						if (Operators.CompareString(Encoding.Unicode.GetString(bytes), "{Ready}", true) == 0)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					this.ooOoO_0Oo.O..Close();
					return false;
				}
				this.ooOoO_0Oo.O..BeginReceive(new AsyncCallback(this.ooo_OoooOOO.0.), null);
				int num = Math.Min(this.ooOoO_0Oo.O. - 1, this.oO_o_O.o_..Length - 1);
				for (int i = 0; i <= num; i++)
				{
					this.ooOoO_0Oo.O..Add(i);
					this.o0Ooo_oO_Oo.0..Add(i);
				}
				int num2 = this.ooOoO_0Oo.O.[this.ooOoO_0Oo.O..Count - 1];
				now = DateTime.Now;
				bool result;
				for (;;)
				{
					try
					{
						foreach (int a_ in this.ooOoO_0Oo.O.)
						{
							this.ooo_OoooOOO.0.(a_);
						}
					}
					finally
					{
						List<int>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.ooOoO_0Oo.O..Clear();
					if (this.oO_o_O.o_..WaitOne(1000))
					{
						object obj = this.o0Ooo_oO_Oo.0.;
						lock (obj)
						{
							while (this.o0Ooo_oO_Oo.0..Count < this.ooOoO_0Oo.O. && num2 < this.oO_o_O.o_..Length - 1)
							{
								num2++;
								this.ooOoO_0Oo.O..Add(num2);
								this.o0Ooo_oO_Oo.0..Add(num2);
							}
							if (this.o0Ooo_oO_Oo.0..Count == 0)
							{
								result = true;
								break;
							}
							for (int j = this.o0Ooo_oO_Oo.0..Count - 1; j >= 0; j += -1)
							{
								if (this.O_.OOoo_Oo. - this.o0Ooo_oO_Oo.0.[j] >= 1)
								{
									this.oO_o_O.o_..O0o_.Oo0oo.(this.ooo_OoooOOO.0., "*\v" + Conversions.ToString(this.o0Ooo_oO_Oo.0.[j]));
								}
								if (this.O_.OOoo_Oo. - this.o0Ooo_oO_Oo.0.[j] >= 3 && !this.ooOoO_0Oo.O..Contains(this.o0Ooo_oO_Oo.0.[j]))
								{
									this.ooOoO_0Oo.O..Insert(0, this.o0Ooo_oO_Oo.0.[j]);
								}
							}
							goto IL_32A;
						}
						goto IL_319;
					}
					goto IL_319;
					IL_32A:
					for (int k = this.ooOoO_0Oo.O..Count - 1; k >= 0; k += -1)
					{
						int num3 = this.ooOoO_0Oo.O.[k];
						if (this.o0Ooo_oO_Oo.0.[num3] > 0)
						{
							this.ooOoO_0Oo.O..Remove(num3);
							if (this.o0Ooo_oO_Oo.0..Contains(num3))
							{
								this.o0Ooo_oO_Oo.0..Remove(num3);
							}
						}
					}
					try
					{
						foreach (int num4 in this.ooOoO_0Oo.O.)
						{
							if (this.oO_o_O.o_.[num4] >= 8)
							{
								goto IL_3FD;
							}
							if (this.oO_o_O.o_.[num4] >= 1)
							{
								this.oO_o_O.o_..O0o_.Oo0oo.(this.ooo_OoooOOO.0., "*\v" + Conversions.ToString(num4));
							}
						}
						continue;
					}
					finally
					{
						List<int>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					break;
					IL_319:
					this.ooOoO_0Oo.O..AddRange(this.o0Ooo_oO_Oo.0.);
					goto IL_32A;
				}
				IL_3FD:
				this.ooOoO_0Oo.O..AcquireWriterLock(-1);
				double totalSeconds = (DateTime.Now - now).TotalSeconds;
				this.oO_o_O.o_. = true;
				this.ooOoO_0Oo.O..Close();
				this.ooOoO_0Oo.O..ReleaseWriterLock();
				return result;
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			this.oO_o_O.o_. = true;
			bool result2;
			return result2;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0009AA5C File Offset: 0x00098C5C
		private void <<EMPTY_NAME>>(int A_0)
		{
			this.oO_o_O.o_.[A_0] = this.oO_o_O.o_.[A_0] + 1;
			int num = A_0 * this.o0Ooo_oO_Oo.0.;
			int num2 = Math.Min(num + this.o0Ooo_oO_Oo.0. - 1, this.oO_o_O.o_..Length - 1);
			int num3 = num2;
			int num4 = num;
			while (num4 <= num3 && this.o0Ooo_oO_Oo.0.[A_0] <= 0)
			{
				byte[] array = (byte[])this.oO_o_O.o_.[num4];
				this.ooOoO_0Oo.O..Send(array, array.Length, this.ooo_OoooOOO.0.);
				num4++;
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0009AADC File Offset: 0x00098CDC
		private void <<EMPTY_NAME>>(IAsyncResult A_0)
		{
			this.ooOoO_0Oo.O..AcquireReaderLock(-1);
			try
			{
				if (!this.oO_o_O.o_.)
				{
					IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
					byte[] bytes = this.ooOoO_0Oo.O..EndReceive(A_0, ref ipendPoint);
					string @string = Encoding.Unicode.GetString(bytes);
					if (Operators.CompareString(this.ooo_OoooOOO.0..ToString(), ipendPoint.ToString(), true) == 0)
					{
						object obj = this.o0Ooo_oO_Oo.0.;
						lock (obj)
						{
							int num;
							if (int.TryParse(@string, out num))
							{
								num = Math.Abs(num);
								if (this.o0Ooo_oO_Oo.0..Contains(num))
								{
									this.o0Ooo_oO_Oo.0..Remove(num);
									this.o0Ooo_oO_Oo.0.[num] = this.o0Ooo_oO_Oo.0.[num] + 1;
									this.O_.OOoo_Oo. = Math.Max(this.O_.OOoo_Oo., num);
								}
							}
							while (this.ooOoO_0Oo.O..Available > 0)
							{
								ipendPoint = new IPEndPoint(IPAddress.Any, 0);
								bytes = this.ooOoO_0Oo.O..Receive(ref ipendPoint);
								@string = Encoding.Unicode.GetString(bytes);
								if (Operators.CompareString(this.ooo_OoooOOO.0..ToString(), ipendPoint.ToString(), true) == 0 && int.TryParse(@string, out num))
								{
									num = Math.Abs(num);
									if (this.o0Ooo_oO_Oo.0..Contains(num))
									{
										this.o0Ooo_oO_Oo.0..Remove(num);
										this.o0Ooo_oO_Oo.0.[num] = this.o0Ooo_oO_Oo.0.[num] + 1;
										this.O_.OOoo_Oo. = Math.Max(this.O_.OOoo_Oo., num);
									}
								}
							}
						}
						this.oO_o_O.o_..Set();
						this.ooOoO_0Oo.O..BeginReceive(new AsyncCallback(this.ooo_OoooOOO.0.), null);
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.ooOoO_0Oo.O..ReleaseReaderLock();
			}
		}

		// Token: 0x040008DF RID: 2271
		private IMServer <<EMPTY_NAME>>;

		// Token: 0x040008E0 RID: 2272
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x040008E1 RID: 2273
		private UdpClient <<EMPTY_NAME>>;

		// Token: 0x040008E2 RID: 2274
		private int <<EMPTY_NAME>>;

		// Token: 0x040008E3 RID: 2275
		private int <<EMPTY_NAME>>;

		// Token: 0x040008E4 RID: 2276
		private int <<EMPTY_NAME>>;

		// Token: 0x040008E5 RID: 2277
		private object[] <<EMPTY_NAME>>;

		// Token: 0x040008E6 RID: 2278
		private int[] <<EMPTY_NAME>>;

		// Token: 0x040008E7 RID: 2279
		private int[] <<EMPTY_NAME>>;

		// Token: 0x040008E8 RID: 2280
		private AutoResetEvent <<EMPTY_NAME>>;

		// Token: 0x040008E9 RID: 2281
		private bool <<EMPTY_NAME>>;

		// Token: 0x040008EA RID: 2282
		private ReaderWriterLock <<EMPTY_NAME>>;

		// Token: 0x040008EB RID: 2283
		private List<int> <<EMPTY_NAME>>;

		// Token: 0x040008EC RID: 2284
		private List<int> <<EMPTY_NAME>>;

		// Token: 0x040008ED RID: 2285
		private int <<EMPTY_NAME>>;
	}
}

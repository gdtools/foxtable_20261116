using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001CE RID: 462
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Oo0_0o0_OoO0O
	{
		// Token: 0x06001637 RID: 5687 RVA: 0x00099FA4 File Offset: 0x000981A4
		public Oo0_0o0_OoO0O(UdpClient A_0, IPEndPoint A_1)
		{
			this.ooo_OoooOOO.0. = 8;
			this.ooo.0_OO. = 500;
			this.oOo0O_o_.oO_o. = A_0;
			this.ooo_OoooOOO.0. = A_1;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00099FCC File Offset: 0x000981CC
		public bool <<EMPTY_NAME>>()
		{
			DateTime now = DateTime.Now;
			bool flag;
			while (DateTime.Compare(DateTime.Now, now.AddSeconds(4.0)) < 0)
			{
				if (this.oOo0O_o_.oO_o..Available > 0)
				{
					now = DateTime.Now;
					IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
					byte[] bytes = this.oOo0O_o_.oO_o..Receive(ref ipendPoint);
					if (Operators.CompareString(this.ooo_OoooOOO.0..ToString(), ipendPoint.ToString(), true) == 0)
					{
						string @string = Encoding.Unicode.GetString(bytes);
						if (Operators.CompareString(@string, "None", true) == 0)
						{
							this.oOo0O_o_.oO_o..Close();
							return true;
						}
						string[] array = @string.Split(new char[]
						{
							'\t'
						});
						if (array.Length == 2 && Versioned.IsNumeric(array[0]) && Versioned.IsNumeric(array[1]))
						{
							this.ooo_OoooOOO.0. = new IPEndPoint(this.ooo_OoooOOO.0..Address, Conversions.ToInteger(array[0]));
							this.ooo_OoooOOO.0. = new string[Conversions.ToInteger(array[1]) - 1 + 1];
							this.ooo_OoooOOO.0. = new int[(int)Math.Ceiling((double)this.ooo_OoooOOO.0..Length / (double)this.ooo_OoooOOO.0.) - 1 + 1];
							flag = true;
							break;
						}
					}
				}
			}
			if (!flag)
			{
				this.oOo0O_o_.oO_o..Close();
				return false;
			}
			if (this.ooo_OoooOOO.0..Length == 0)
			{
				this.oOo0O_o_.oO_o..Close();
				return true;
			}
			byte[] bytes2 = Encoding.Unicode.GetBytes("{Ready}");
			this.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, this.ooo_OoooOOO.0.);
			now = DateAndTime.Now;
			bool result;
			while (DateTime.Compare(DateTime.Now, now.AddSeconds(4.0)) < 0)
			{
				if (this.oOo0O_o_.oO_o..Available > 0)
				{
					now = DateTime.Now;
					IPEndPoint ipendPoint2 = new IPEndPoint(IPAddress.Any, 0);
					byte[] bytes3 = this.oOo0O_o_.oO_o..Receive(ref ipendPoint2);
					if (Operators.CompareString(ipendPoint2.ToString(), this.ooo_OoooOOO.0..ToString(), true) == 0)
					{
						string text = Encoding.Unicode.GetString(bytes3);
						if (text.StartsWith("*\v"))
						{
							text = text.Substring(2);
							int num;
							if (int.TryParse(text, out num) && this.ooo_OoooOOO.0.[num] == -1)
							{
								bytes2 = Encoding.Unicode.GetBytes(num.ToString());
								this.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, this.ooo_OoooOOO.0.);
								bytes2 = Encoding.Unicode.GetBytes((-num).ToString());
								this.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, this.ooo_OoooOOO.0.);
							}
						}
						else if (text.IndexOf("\t") >= 1)
						{
							string s = text.Substring(0, text.IndexOf("\t"));
							string text2 = text.Substring(text.IndexOf("\t") + 1);
							int num2;
							if (int.TryParse(s, out num2) && num2 >= 0 && num2 <= this.ooo_OoooOOO.0..Length - 1)
							{
								int num3 = num2 / this.ooo_OoooOOO.0.;
								if (Operators.CompareString(this.ooo_OoooOOO.0.[num2], "", true) == 0)
								{
									this.ooo_OoooOOO.0.[num2] = text2;
									this.ooo_OoooOOO.0.[num3] = this.ooo_OoooOOO.0.[num3] + 1;
									if (this.ooo_OoooOOO.0.[num3] == this.ooo_OoooOOO.0. || (num3 == this.ooo_OoooOOO.0..Length - 1 && this.ooo_OoooOOO.0.[num3] == this.ooo_OoooOOO.0..Length % this.ooo_OoooOOO.0.))
									{
										this.ooo_OoooOOO.0.[num3] = -1;
										this.OO___o.0Oo00.++;
										bytes2 = Encoding.Unicode.GetBytes(num3.ToString());
										this.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, this.ooo_OoooOOO.0.);
										bytes2 = Encoding.Unicode.GetBytes((-num3).ToString());
										this.oOo0O_o_.oO_o..Send(bytes2, bytes2.Length, this.ooo_OoooOOO.0.);
									}
								}
								if (this.OO___o.0Oo00. == this.ooo_OoooOOO.0..Length)
								{
									result = true;
									break;
								}
							}
						}
					}
				}
			}
			this.oOo0O_o_.oO_o..Close();
			return result;
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0009A3FC File Offset: 0x000985FC
		internal string <<EMPTY_NAME>>()
		{
			string result;
			if (this.ooo_OoooOOO.0. == null)
			{
				result = "";
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (string value in this.ooo_OoooOOO.0.)
				{
					stringBuilder.Append(value);
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x040008D8 RID: 2264
		private int <<EMPTY_NAME>>;

		// Token: 0x040008D9 RID: 2265
		private int <<EMPTY_NAME>>;

		// Token: 0x040008DA RID: 2266
		private string[] <<EMPTY_NAME>>;

		// Token: 0x040008DB RID: 2267
		private int[] <<EMPTY_NAME>>;

		// Token: 0x040008DC RID: 2268
		private int <<EMPTY_NAME>>;

		// Token: 0x040008DD RID: 2269
		private UdpClient <<EMPTY_NAME>>;

		// Token: 0x040008DE RID: 2270
		private IPEndPoint <<EMPTY_NAME>>;
	}
}

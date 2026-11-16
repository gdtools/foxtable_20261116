using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200019B RID: 411
	internal class oO_o_0_o_O_o
	{
		// Token: 0x06001362 RID: 4962 RVA: 0x00085084 File Offset: 0x00083284
		public void <<EMPTY_NAME>>()
		{
			this.O00.oo0_0oo. = o0___oO.o0__.0.(this.O00.oo0_0oo.);
			o0___oO.O.oOo0O0O.(this.O00.oo0_0oo.);
			this.O00.oo0_0oo..Client.SendBufferSize = 81920;
			this.O00.oo0_0oo..Client.ReceiveBufferSize = 91920;
			string text = "\v";
			string text2 = this.O00.oo0_0oo..Client.LocalEndPoint.ToString();
			string a_ = string.Concat(new string[]
			{
				"%10",
				text,
				this.O00.oo0_0oo..Name,
				text,
				this.O00.oo0_0oo.,
				text,
				text2.Substring(text2.IndexOf(":") + 1),
				text,
				this.oO.o0_O_.
			});
			this.O00.oo0_0oo..oOOOo._.(this.oO.o0_O_..Name, a_);
			DateTime now = DateTime.Now;
			do
			{
				if (this.O00.oo0_0oo..Available > 0)
				{
					now = DateTime.Now;
					IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
					byte[] bytes = this.O00.oo0_0oo..Receive(ref ipendPoint);
					if (Operators.CompareString(Encoding.Unicode.GetString(bytes), "Ping", true) == 0)
					{
						this.oO.o0_O_. = ipendPoint;
					}
				}
			}
			while ((DateTime.Now - now).TotalSeconds < 3.0);
			if (this.oO.o0_O_. != null)
			{
				byte[] bytes2 = Encoding.Unicode.GetBytes(text2.Substring(text2.IndexOf(":") + 1) + "\t" + this.oO.o0_O_.);
				this.O00.oo0_0oo..ooO_.O0_..Send(bytes2, bytes2.Length, this.O00.oo0_0oo.);
				now = DateTime.Now;
				while ((DateTime.Now - now).TotalSeconds < 5.0)
				{
					if (this.O00.oo0_0oo..Available > 0)
					{
						now = DateTime.Now;
						IPEndPoint ipendPoint2 = new IPEndPoint(IPAddress.Any, 0);
						byte[] array = this.O00.oo0_0oo..Receive(ref ipendPoint2);
						if (Operators.CompareString(ipendPoint2.ToString(), this.O00.oo0_0oo..ToString(), true) == 0)
						{
							this.O00.oo0_0oo..Send(array, array.Length, this.oO.o0_O_.);
						}
						else if (Operators.CompareString(ipendPoint2.ToString(), this.oO.o0_O_..ToString(), true) == 0)
						{
							this.O00.oo0_0oo..Send(array, array.Length, this.O00.oo0_0oo.);
						}
					}
				}
			}
		}

		// Token: 0x040007AA RID: 1962
		internal IMServer <<EMPTY_NAME>>;

		// Token: 0x040007AB RID: 1963
		internal IMUser <<EMPTY_NAME>>;

		// Token: 0x040007AC RID: 1964
		internal IMUser <<EMPTY_NAME>>;

		// Token: 0x040007AD RID: 1965
		internal IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x040007AE RID: 1966
		internal IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x040007AF RID: 1967
		internal string <<EMPTY_NAME>>;

		// Token: 0x040007B0 RID: 1968
		internal string <<EMPTY_NAME>>;

		// Token: 0x040007B1 RID: 1969
		private UdpClient <<EMPTY_NAME>>;
	}
}

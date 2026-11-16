using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001D1 RID: 465
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	[oO0oooo("3000")]
	public class UDPClient
	{
		// Token: 0x06001643 RID: 5699 RVA: 0x0009AD8E File Offset: 0x00098F8E
		public UDPClient(string A_0)
		{
			this.O00ooo._. = true;
			this.O00ooo._. = new Queue<UDPClient.OO00_>();
			this.O00ooo._. = new ReaderWriterLock();
			this.O00ooo._. = Encoding.Unicode;
			this.O_o.0__OOO0. = A_0;
		}

		/// <summary>
		/// 名称
		/// </summary>
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0009ADC5 File Offset: 0x00098FC5
		public string Name
		{
			get
			{
				return this.O_o.0__OOO0.;
			}
		}

		/// <summary>
		/// IP地址
		/// </summary>
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x0009ADCD File Offset: 0x00098FCD
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x0009ADD5 File Offset: 0x00098FD5
		public string IP
		{
			get
			{
				return this.ooOoO_0Oo.O.;
			}
			set
			{
				this.ooOoO_0Oo.O. = value;
			}
		}

		/// <summary>
		/// 端口
		/// </summary>
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x0009ADDE File Offset: 0x00098FDE
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x0009ADE6 File Offset: 0x00098FE6
		public int Port
		{
			get
			{
				return this.ooOoO_0Oo.O.;
			}
			set
			{
				this.ooOoO_0Oo.O. = value;
			}
		}

		/// <summary>
		/// 字符型，用于指定UDPClient使用的编码方式。
		/// </summary>
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x0009ADEF File Offset: 0x00098FEF
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x0009ADF7 File Offset: 0x00098FF7
		public string EncodingName
		{
			get
			{
				return this.o0O.OO0__.;
			}
			set
			{
				this.o0O.OO0__. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于判断UDPClient是否已经启动
		/// </summary>
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x0009AE00 File Offset: 0x00099000
		public bool Ready
		{
			get
			{
				return !this.O00ooo._.;
			}
		}

		/// <summary>
		/// 启动UDPClient
		/// </summary>
		// Token: 0x0600164C RID: 5708 RVA: 0x0009AE0C File Offset: 0x0009900C
		[oO0oooo("3001")]
		public bool Start()
		{
			bool result;
			if (this.O00ooo._. != null)
			{
				MessageBox.Show("此UDPClient已经启动，请先停止，才能重新启动！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (this.ooOoO_0Oo.O. == 0 || Operators.CompareString(this.ooOoO_0Oo.O., "", true) == 0)
			{
				MessageBox.Show("必须同时指定端口,才能启动UDPClient!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				this.O00ooo._..Clear();
				this.O00ooo._. = true;
				if (Operators.CompareString(this.EncodingName, "", true) == 0)
				{
					this.O00ooo._. = Encoding.Unicode;
				}
				else
				{
					this.O00ooo._. = Encoding.GetEncoding(this.EncodingName);
				}
				try
				{
					IPEndPoint localEP;
					if (Operators.CompareString(this.ooOoO_0Oo.O., "", true) == 0)
					{
						localEP = new IPEndPoint(IPAddress.Any, this.ooOoO_0Oo.O.);
					}
					else
					{
						localEP = new IPEndPoint(IPAddress.Parse(this.ooOoO_0Oo.O.), this.ooOoO_0Oo.O.);
					}
					this.O00ooo._. = new UdpClient(localEP);
					this.o.__o0_0o0oO_O. = new UdpClient(0);
					o0___oO.O.oOo0O0O.(this.O00ooo._.);
					o0___oO.O.oOo0O0O.(this.o.__o0_0o0oO_O.);
					this.O00ooo._..Client.SendBufferSize = 81920;
					this.O00ooo._..Client.ReceiveBufferSize = 81920;
					this.o.__o0_0o0oO_O..Client.SendBufferSize = 81920;
					this.o.__o0_0o0oO_O..Client.ReceiveBufferSize = 81920;
					this.O00ooo._. = false;
					this.ooOoO_0Oo.O.();
					result = true;
				}
				catch (Exception a_)
				{
					this.O00ooo._. = true;
					if (this.O00ooo._. != null)
					{
						this.O00ooo._..Close();
						this.O00ooo._. = null;
					}
					if (this.o.__o0_0o0oO_O. != null)
					{
						this.o.__o0_0o0oO_O..Close();
						this.o.__o0_0o0oO_O. = null;
					}
					ooO.oOo0Oo.o.(a_, "启动UDPClient");
					result = false;
				}
			}
			return result;
		}

		/// <summary>
		/// 停止UDPClient
		/// </summary>
		// Token: 0x0600164D RID: 5709 RVA: 0x0009AFEC File Offset: 0x000991EC
		public void Stop()
		{
			this.O00ooo._. = true;
			this.O00ooo._..AcquireWriterLock(-1);
			Exception ex = null;
			try
			{
				object o00ooo._. = this.O00ooo._.;
				lock (o00ooo._.)
				{
					this.O00ooo._..Clear();
				}
				if (this.O00ooo._. != null)
				{
					this.O00ooo._..Close();
					this.O00ooo._. = null;
				}
				if (this.o.__o0_0o0oO_O. != null)
				{
					this.o.__o0_0o0oO_O..Close();
					this.o.__o0_0o0oO_O. = null;
				}
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			finally
			{
				this.O00ooo._..ReleaseWriterLock();
			}
			if (ex != null)
			{
				ooO.oOo0Oo.o.(ex, "关闭UDPClient");
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0009B0C0 File Offset: 0x000992C0
		private void <<EMPTY_NAME>>()
		{
			this.O00ooo._..AcquireReaderLock(-1);
			Exception ex = null;
			try
			{
				this.O00ooo._..BeginReceive(new AsyncCallback(this.ooOoO_0Oo.O.), null);
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			finally
			{
				this.O00ooo._..ReleaseReaderLock();
			}
			if (ex != null)
			{
				this.Stop();
				ooO.oOo0Oo.o.(ex, "UDPClient异步接收");
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0009B144 File Offset: 0x00099344
		private void <<EMPTY_NAME>>(IAsyncResult A_0)
		{
			if (!this.O00ooo._.)
			{
				this.O00ooo._..AcquireReaderLock(-1);
				Exception ex = null;
				try
				{
					IPEndPoint a_ = new IPEndPoint(IPAddress.Any, 0);
					byte[] a_2 = this.O00ooo._..EndReceive(A_0, ref a_);
					object o00ooo._. = this.O00ooo._.;
					lock (o00ooo._.)
					{
						this.O00ooo._..Enqueue(new UDPClient.OO00_(a_, a_2));
					}
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
				finally
				{
					this.O00ooo._..ReleaseReaderLock();
				}
				if (ex == null)
				{
					if (!this.O00ooo._.)
					{
						this.ooOoO_0Oo.O.();
						return;
					}
				}
				else
				{
					this.Stop();
					ooO.oOo0Oo.o.(ex, "UDPClient异步接收回调过程");
				}
			}
		}

		/// <summary>
		/// 发送字节信息
		/// </summary>
		/// <param name="ip">对方IP地址</param>
		/// <param name="port">对方端口</param>
		/// <param name="bytes">要发送的字节数组</param>
		// Token: 0x06001650 RID: 5712 RVA: 0x0009B224 File Offset: 0x00099424
		public void Send(string ip, int port, byte[] bytes)
		{
			if (!this.O00ooo._.)
			{
				IPEndPoint endPoint;
				if (Operators.CompareString(ip, "", true) == 0)
				{
					endPoint = new IPEndPoint(IPAddress.Any, port);
				}
				else
				{
					endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
				}
				this.O00ooo._..Send(bytes, bytes.Length, endPoint);
			}
		}

		/// <summary>
		/// 发送字符信息
		/// </summary>
		/// <param name="ip">对方IP地址</param>
		/// <param name="port">对方端口</param>
		/// <param name="msg">要发送的信息</param>
		// Token: 0x06001651 RID: 5713 RVA: 0x0009B274 File Offset: 0x00099474
		public void Send(string ip, int port, string msg)
		{
			byte[] bytes = this.O00ooo._..GetBytes(msg);
			this.Send(ip, port, bytes);
		}

		// Token: 0x040008EF RID: 2287
		private string <<EMPTY_NAME>>;

		// Token: 0x040008F0 RID: 2288
		private int <<EMPTY_NAME>>;

		// Token: 0x040008F1 RID: 2289
		internal UdpClient <<EMPTY_NAME>>;

		// Token: 0x040008F2 RID: 2290
		internal UdpClient <<EMPTY_NAME>>;

		// Token: 0x040008F3 RID: 2291
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040008F4 RID: 2292
		internal Queue<UDPClient.OO00_> <<EMPTY_NAME>>;

		// Token: 0x040008F5 RID: 2293
		private ReaderWriterLock <<EMPTY_NAME>>;

		// Token: 0x040008F6 RID: 2294
		private string <<EMPTY_NAME>>;

		// Token: 0x040008F7 RID: 2295
		private string <<EMPTY_NAME>>;

		// Token: 0x040008F8 RID: 2296
		internal Encoding <<EMPTY_NAME>>;

		// Token: 0x020001D8 RID: 472
		internal class OO00_
		{
			// Token: 0x060016D0 RID: 5840 RVA: 0x000A5ECC File Offset: 0x000A40CC
			internal OO00_(IPEndPoint A_0, byte[] A_1)
			{
				this.O00ooo._. = A_0;
				this.O00ooo._. = A_1;
			}

			// Token: 0x060016D1 RID: 5841 RVA: 0x000A5EE2 File Offset: 0x000A40E2
			internal IPEndPoint <<EMPTY_NAME>>()
			{
				return this.O00ooo._.;
			}

			// Token: 0x060016D2 RID: 5842 RVA: 0x000A5EEA File Offset: 0x000A40EA
			internal byte[] <<EMPTY_NAME>>()
			{
				return this.O00ooo._.;
			}

			// Token: 0x04000943 RID: 2371
			private IPEndPoint <<EMPTY_NAME>>;

			// Token: 0x04000944 RID: 2372
			private byte[] <<EMPTY_NAME>>;
		}
	}
}

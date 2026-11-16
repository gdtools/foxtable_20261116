using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace Foxtable
{
	// Token: 0x02000208 RID: 520
	internal class oOo0_o0Oo_00
	{
		// Token: 0x060019A3 RID: 6563 RVA: 0x000B75AC File Offset: 0x000B57AC
		[CompilerGenerated]
		internal string <<EMPTY_NAME>>()
		{
			return this.o.o_o_0o0O_.;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000B75B4 File Offset: 0x000B57B4
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o.o_o_0o0O_. = A_0;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000B75BD File Offset: 0x000B57BD
		internal oOo0_o0Oo_00(string A_0, HttpListenerResponse A_1, string A_2)
		{
			this.oO0o0o._0.("text/html");
			this.Oo000.o00. = A_0;
			this.Oo000.o00. = A_1;
			this.o.0ooO__. = A_2;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000B75E8 File Offset: 0x000B57E8
		public void <<EMPTY_NAME>>(object A_0)
		{
			if (this.Oo000.o00. != null)
			{
				Encoding encoding = HttpFunctions.OO.0o.(this.o.0ooO__.);
				MemoryStream memoryStream = new MemoryStream(encoding.GetBytes(this.Oo000.o00.));
				Stream stream = this.Oo000.o00..OutputStream;
				try
				{
					byte[] array = new byte[51201];
					this.Oo000.o00..ContentType = this.oO0o0o._0.() + "; charset=" + this.o.0ooO__.;
					this.Oo000.o00..ContentEncoding = encoding;
					if (this.Oo000.o00..Headers["Content-Encoding"] == null)
					{
						this.Oo000.o00..ContentLength64 = memoryStream.Length;
					}
					else if (this.Oo000.o00..Headers["Content-Encoding"].Contains("gzip"))
					{
						stream = new GZipStream(this.Oo000.o00..OutputStream, CompressionMode.Compress, false);
					}
					else if (this.Oo000.o00..Headers["Content-Encoding"].Contains("deflate"))
					{
						stream = new DeflateStream(this.Oo000.o00..OutputStream, CompressionMode.Compress, false);
					}
					else
					{
						this.Oo000.o00..ContentLength64 = memoryStream.Length;
					}
					int num = memoryStream.Read(array, 0, array.Length);
					while (num > 0 && stream.CanWrite)
					{
						stream.Write(array, 0, num);
						num = memoryStream.Read(array, 0, array.Length);
					}
				}
				catch (Exception ex)
				{
				}
				finally
				{
					try
					{
						memoryStream.Close();
						stream.Flush();
						stream.Close();
						if (stream != this.Oo000.o00..OutputStream)
						{
							this.Oo000.o00..OutputStream.Close();
						}
						this.Oo000.o00..Close();
						this.Oo000.o00..Abort();
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x04000AAC RID: 2732
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AAD RID: 2733
		private HttpListenerResponse <<EMPTY_NAME>>;

		// Token: 0x04000AAE RID: 2734
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AAF RID: 2735
		private string <<EMPTY_NAME>>;
	}
}

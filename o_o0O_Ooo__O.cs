using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Foxtable
{
	// Token: 0x02000207 RID: 519
	internal class o_o0O_Ooo__O
	{
		// Token: 0x060019A1 RID: 6561 RVA: 0x000B73F9 File Offset: 0x000B55F9
		internal o_o0O_Ooo__O(string A_0, HttpListenerResponse A_1)
		{
			this.ooO0O.0. = A_0;
			this.ooO0O.0. = A_1;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x000B7410 File Offset: 0x000B5610
		internal void <<EMPTY_NAME>>(object A_0)
		{
			FileStream fileStream = new FileStream(this.ooO0O.0., FileMode.Open, FileAccess.Read, FileShare.Read);
			Stream stream = this.ooO0O.0..OutputStream;
			try
			{
				if (this.ooO0O.0..Headers["Content-Encoding"] == null)
				{
					this.ooO0O.0..ContentLength64 = fileStream.Length;
				}
				else if (this.ooO0O.0..Headers["Content-Encoding"].Contains("gzip"))
				{
					stream = new GZipStream(this.ooO0O.0..OutputStream, CompressionMode.Compress, false);
				}
				else if (this.ooO0O.0..Headers["Content-Encoding"].Contains("deflate"))
				{
					stream = new DeflateStream(this.ooO0O.0..OutputStream, CompressionMode.Compress, false);
				}
				else
				{
					this.ooO0O.0..ContentLength64 = fileStream.Length;
				}
				byte[] array = new byte[51201];
				int num = fileStream.Read(array, 0, array.Length);
				while (num > 0 && stream.CanWrite)
				{
					stream.Write(array, 0, num);
					num = fileStream.Read(array, 0, array.Length);
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				try
				{
					fileStream.Close();
					stream.Flush();
					stream.Close();
					if (stream != this.ooO0O.0..OutputStream)
					{
						this.ooO0O.0..OutputStream.Close();
					}
					this.ooO0O.0..Close();
					this.ooO0O.0..Abort();
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x04000AAA RID: 2730
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AAB RID: 2731
		private HttpListenerResponse <<EMPTY_NAME>>;
	}
}

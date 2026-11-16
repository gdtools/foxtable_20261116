using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Foxtable
{
	// Token: 0x02000236 RID: 566
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class oOO_O__
	{
		// Token: 0x06001AFB RID: 6907 RVA: 0x000BE5C1 File Offset: 0x000BC7C1
		internal oOO_O__(MemoryStream A_0, HttpListenerResponse A_1)
		{
			this.oO0o0o._0. = A_0;
			this.oO0o0o._0. = A_1;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000BE5D8 File Offset: 0x000BC7D8
		internal void <<EMPTY_NAME>>(object A_0)
		{
			Stream stream = this.oO0o0o._0..OutputStream;
			try
			{
				this.oO0o0o._0..ContentType = "text/xml";
				if (this.oO0o0o._0..Headers["Content-Encoding"] == null)
				{
					this.oO0o0o._0..ContentLength64 = this.oO0o0o._0..Length;
				}
				else if (this.oO0o0o._0..Headers["Content-Encoding"].Contains("gzip"))
				{
					stream = new GZipStream(this.oO0o0o._0..OutputStream, CompressionMode.Compress, false);
				}
				else if (this.oO0o0o._0..Headers["Content-Encoding"].Contains("deflate"))
				{
					stream = new DeflateStream(this.oO0o0o._0..OutputStream, CompressionMode.Compress, false);
				}
				else
				{
					this.oO0o0o._0..ContentLength64 = this.oO0o0o._0..Length;
				}
				byte[] array = new byte[51201];
				int num = this.oO0o0o._0..Read(array, 0, array.Length);
				while (num > 0 && stream.CanWrite)
				{
					stream.Write(array, 0, num);
					num = this.oO0o0o._0..Read(array, 0, array.Length);
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				try
				{
					this.oO0o0o._0..Close();
					stream.Flush();
					stream.Close();
					if (stream != this.oO0o0o._0..OutputStream)
					{
						this.oO0o0o._0..OutputStream.Close();
					}
					this.oO0o0o._0..Close();
					this.oO0o0o._0..Abort();
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x04000B62 RID: 2914
		private MemoryStream <<EMPTY_NAME>>;

		// Token: 0x04000B63 RID: 2915
		private HttpListenerResponse <<EMPTY_NAME>>;
	}
}

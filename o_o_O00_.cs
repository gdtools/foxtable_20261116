using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Web;

namespace Foxtable
{
	// Token: 0x02000202 RID: 514
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o_o_O00_
	{
		// Token: 0x06001995 RID: 6549 RVA: 0x000B6D7F File Offset: 0x000B4F7F
		internal o_o_O00_(HttpListenerResponse A_0, PDFCreator A_1, string A_2, bool A_3)
		{
			this.oO0o0o._0. = A_0;
			this.ooO0O.0. = A_1;
			this.ooO0O.0. = A_2;
			this.oO0o0o._0. = A_3;
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000B6DA4 File Offset: 0x000B4FA4
		internal void <<EMPTY_NAME>>(object A_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				this.ooO0O.0..Save(memoryStream);
				memoryStream.Position = 0L;
				if (this.oO0o0o._0.)
				{
					this.oO0o0o._0..ContentType = "Application/pdf";
					this.oO0o0o._0..AddHeader("Content-Disposition", "inline;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(this.ooO0O.0.), this.oO0o0o._0..ContentEncoding));
				}
				else
				{
					this.oO0o0o._0..ContentType = "application/octet-stream";
					this.oO0o0o._0..AddHeader("Content-Disposition", "attachment;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(this.ooO0O.0.), this.oO0o0o._0..ContentEncoding));
				}
				this.oO0o0o._0..ContentLength64 = memoryStream.Length;
				byte[] array = new byte[51201];
				int num = memoryStream.Read(array, 0, array.Length);
				while (num > 0 && this.oO0o0o._0..OutputStream.CanWrite)
				{
					this.oO0o0o._0..OutputStream.Write(array, 0, num);
					num = memoryStream.Read(array, 0, array.Length);
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				this.oO0o0o._0..OutputStream.Close();
				this.oO0o0o._0..Close();
				this.oO0o0o._0..Abort();
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
			}
		}

		// Token: 0x04000A9A RID: 2714
		private PDFCreator <<EMPTY_NAME>>;

		// Token: 0x04000A9B RID: 2715
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A9C RID: 2716
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000A9D RID: 2717
		private HttpListenerResponse <<EMPTY_NAME>>;
	}
}

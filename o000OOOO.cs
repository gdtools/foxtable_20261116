using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Web;
using C1.C1Word;

namespace Foxtable
{
	// Token: 0x02000204 RID: 516
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o000OOOO
	{
		// Token: 0x06001999 RID: 6553 RVA: 0x000B7018 File Offset: 0x000B5218
		internal o000OOOO(HttpListenerResponse A_0, WordCreator A_1, string A_2, bool A_3)
		{
			this.Oo000.o00. = A_0;
			this.Oo000.o00. = A_1;
			this.Oo000.o00. = A_2;
			this.Oo000.o00. = A_3;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000B7040 File Offset: 0x000B5240
		internal void <<EMPTY_NAME>>(object A_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				this.Oo000.o00..Save(memoryStream, FileFormat.OpenXml);
				memoryStream.Position = 0L;
				if (this.Oo000.o00.)
				{
					this.Oo000.o00..ContentType = "application/msword";
					this.Oo000.o00..AddHeader("Content-Disposition", "inline;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(this.Oo000.o00.), this.Oo000.o00..ContentEncoding));
				}
				else
				{
					this.Oo000.o00..ContentType = "application/octet-stream";
					this.Oo000.o00..AddHeader("Content-Disposition", "attachment;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(this.Oo000.o00.), this.Oo000.o00..ContentEncoding));
				}
				this.Oo000.o00..ContentLength64 = memoryStream.Length;
				byte[] array = new byte[51201];
				int num = memoryStream.Read(array, 0, array.Length);
				while (num > 0 && this.Oo000.o00..OutputStream.CanWrite)
				{
					this.Oo000.o00..OutputStream.Write(array, 0, num);
					num = memoryStream.Read(array, 0, array.Length);
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				this.Oo000.o00..OutputStream.Close();
				this.Oo000.o00..Close();
				this.Oo000.o00..Abort();
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
			}
		}

		// Token: 0x04000AA0 RID: 2720
		private WordCreator <<EMPTY_NAME>>;

		// Token: 0x04000AA1 RID: 2721
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AA2 RID: 2722
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AA3 RID: 2723
		private HttpListenerResponse <<EMPTY_NAME>>;
	}
}

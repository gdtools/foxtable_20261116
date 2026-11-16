using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Web;
using C1.C1Excel;
using Foxtable.XLS;

namespace Foxtable
{
	// Token: 0x02000209 RID: 521
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o_o_0OO
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x000B77F4 File Offset: 0x000B59F4
		internal o_o_0OO(HttpListenerResponse A_0, Book A_1, string A_2, bool A_3)
		{
			this.OO__o_OOoOo_.0. = A_0;
			this.OO__o_OOoOo_.0. = A_1;
			this.OO__o_OOoOo_.0. = A_2;
			this.OO__o_OOoOo_.0. = A_3;
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000B781C File Offset: 0x000B5A1C
		internal void <<EMPTY_NAME>>(object A_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				if (this.OO__o_OOoOo_.0..PreBuild)
				{
					this.OO__o_OOoOo_.0..Build(new int[0]);
				}
				if (this.OO__o_OOoOo_.0..oO.o_0o__..CompatibilityMode == CompatibilityMode.Excel2007)
				{
					this.OO__o_OOoOo_.0..oO.o_0o__..Save(memoryStream, FileFormat.OpenXml);
				}
				else
				{
					this.OO__o_OOoOo_.0..oO.o_0o__..Save(memoryStream, FileFormat.Biff8);
				}
				memoryStream.Position = 0L;
				if (this.OO__o_OOoOo_.0.)
				{
					this.OO__o_OOoOo_.0..ContentType = "application/vnd.ms-excel";
					this.OO__o_OOoOo_.0..AddHeader("Content-Disposition", "inline;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(this.OO__o_OOoOo_.0.), this.OO__o_OOoOo_.0..ContentEncoding));
				}
				else
				{
					this.OO__o_OOoOo_.0..ContentType = "application/octet-stream";
					this.OO__o_OOoOo_.0..AddHeader("Content-Disposition", "attachment;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(this.OO__o_OOoOo_.0.), this.OO__o_OOoOo_.0..ContentEncoding));
				}
				this.OO__o_OOoOo_.0..ContentLength64 = memoryStream.Length;
				byte[] array = new byte[51201];
				int num = memoryStream.Read(array, 0, array.Length);
				while (num > 0 && this.OO__o_OOoOo_.0..OutputStream.CanWrite)
				{
					this.OO__o_OOoOo_.0..OutputStream.Write(array, 0, num);
					num = memoryStream.Read(array, 0, array.Length);
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				this.OO__o_OOoOo_.0..OutputStream.Close();
				this.OO__o_OOoOo_.0..Close();
				this.OO__o_OOoOo_.0..Abort();
				if (memoryStream != null)
				{
					memoryStream.Close();
				}
			}
		}

		// Token: 0x04000AB0 RID: 2736
		private Book <<EMPTY_NAME>>;

		// Token: 0x04000AB1 RID: 2737
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AB2 RID: 2738
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AB3 RID: 2739
		private HttpListenerResponse <<EMPTY_NAME>>;
	}
}

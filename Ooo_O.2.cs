using System;
using System.ComponentModel;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200046C RID: 1132
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StandardModule]
	public sealed class Ooo_O
	{
		// Token: 0x06004D38 RID: 19768 RVA: 0x0022D25C File Offset: 0x0022B45C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string GetRemoteImageFile(string FileName, DataCol dc)
		{
			string result;
			if (!dc.Remote)
			{
				if (Operators.CompareString(dc.DefaultFolder, "", true) > 0)
				{
					FileName = dc.DefaultFolder.TrimEnd(new char[]
					{
						'\\'
					}) + "\\" + FileName;
				}
				FileName = ooO.OoO0o_o___.O.(FileName);
				result = FileName;
			}
			else if (dc.FTPClient != null)
			{
				string text = OO_00oOO.ProjectPath + "RemoteFiles\\" + FileName.Replace("/", "\\").Trim(new char[]
				{
					'\\'
				});
				if (OO_00oOO.FileSys.FileExists(text))
				{
					result = text;
				}
				else
				{
					if (O_O0OO.oO_00Ooo___0._..Contains(FileName.ToLower()))
					{
						do
						{
							Thread.Sleep(200);
						}
						while (O_O0OO.oO_00Ooo___0._..Contains(FileName.ToLower()));
					}
					else
					{
						dc.FTPClient.Download(FileName, text, true);
					}
					result = text;
				}
			}
			else
			{
				result = FileName;
			}
			return result;
		}
	}
}

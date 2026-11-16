using System;
using System.ComponentModel;
using System.IO;

namespace Foxtable
{
	// Token: 0x020002AF RID: 687
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FileWatchEventArgs
	{
		// Token: 0x060024D7 RID: 9431 RVA: 0x0010D1B9 File Offset: 0x0010B3B9
		public FileWatchEventArgs(FileSystemEventArgs A_0)
		{
			this.oooOO.OO. = A_0;
		}

		/// <summary>
		/// 触发事件的文件名，不含路径
		/// </summary>
		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x0010D1C8 File Offset: 0x0010B3C8
		public string Name
		{
			get
			{
				return this.oooOO.OO..Name;
			}
		}

		/// <summary>
		/// 触发事件的文件名，含路径
		/// </summary>
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x0010D1D5 File Offset: 0x0010B3D5
		public string FullPath
		{
			get
			{
				return this.oooOO.OO..FullPath;
			}
		}

		// Token: 0x04000F31 RID: 3889
		private FileSystemEventArgs <<EMPTY_NAME>>;
	}
}

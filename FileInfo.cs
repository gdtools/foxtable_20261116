using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Foxtable
{
	/// <summary>
	/// 用于获取文件信息
	/// </summary>
	// Token: 0x020000C4 RID: 196
	[ComVisible(true)]
	[oO0oooo("2707")]
	public class FileInfo
	{
		/// <param name="File">文件路径和名称</param>
		// Token: 0x0600085E RID: 2142 RVA: 0x000423C0 File Offset: 0x000405C0
		public FileInfo(string A_0)
		{
			this.O0oO_0._o_. = new FileInfo(A_0);
		}

		/// <summary>
		/// 创建时间
		/// </summary>
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000423D4 File Offset: 0x000405D4
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x000423E1 File Offset: 0x000405E1
		public DateTime CreationTime
		{
			get
			{
				return this.O0oO_0._o_..CreationTime;
			}
			set
			{
				this.O0oO_0._o_..CreationTime = value;
			}
		}

		/// <summary>
		/// 最后一次访问时间
		/// </summary>
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000423EF File Offset: 0x000405EF
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000423FC File Offset: 0x000405FC
		public DateTime LastAccessTime
		{
			get
			{
				return this.O0oO_0._o_..LastAccessTime;
			}
			set
			{
				this.O0oO_0._o_..LastAccessTime = value;
			}
		}

		/// <summary>
		/// 最后一次修改时间
		/// </summary>
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0004240A File Offset: 0x0004060A
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00042417 File Offset: 0x00040617
		public DateTime LastWriteTime
		{
			get
			{
				return this.O0oO_0._o_..LastWriteTime;
			}
			set
			{
				this.O0oO_0._o_..LastWriteTime = value;
			}
		}

		/// <summary>
		/// 文件大小
		/// </summary>
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00042425 File Offset: 0x00040625
		public long Length
		{
			get
			{
				return this.O0oO_0._o_..Length;
			}
		}

		/// <summary>
		/// 文件名
		/// </summary>
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00042432 File Offset: 0x00040632
		public string Name
		{
			get
			{
				return this.O0oO_0._o_..Name;
			}
		}

		/// <summary>
		/// 扩展名
		/// </summary>
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0004243F File Offset: 0x0004063F
		public string Extension
		{
			get
			{
				return this.O0oO_0._o_..Extension;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0004244C File Offset: 0x0004064C
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00042459 File Offset: 0x00040659
		public bool ReadOnly
		{
			get
			{
				return this.O0oO_0._o_..IsReadOnly;
			}
			set
			{
				this.O0oO_0._o_..IsReadOnly = value;
			}
		}

		/// <summary>
		/// 是否隐藏
		/// </summary>
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00042467 File Offset: 0x00040667
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00042479 File Offset: 0x00040679
		public bool Hidden
		{
			get
			{
				return (this.O0oO_0._o_..Attributes & FileAttributes.Hidden) > (FileAttributes)0;
			}
			set
			{
				if (value)
				{
					this.O0oO_0._o_..Attributes = (this.O0oO_0._o_..Attributes | FileAttributes.Hidden);
					return;
				}
				this.O0oO_0._o_..Attributes = (this.O0oO_0._o_..Attributes & ~FileAttributes.Hidden);
			}
		}

		/// <summary>
		/// 文件路径
		/// </summary>
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x000424B0 File Offset: 0x000406B0
		public string Path
		{
			get
			{
				return this.O0oO_0._o_..DirectoryName;
			}
		}

		// Token: 0x040002AE RID: 686
		private FileInfo <<EMPTY_NAME>>;
	}
}

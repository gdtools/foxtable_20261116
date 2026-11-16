using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Foxtable
{
	/// <summary>
	/// 用于执行外部程序
	/// </summary>
	// Token: 0x02000327 RID: 807
	[ComVisible(true)]
	[oO0oooo("0353")]
	public class Process
	{
		// Token: 0x06002D14 RID: 11540 RVA: 0x0014D1CF File Offset: 0x0014B3CF
		public Process()
		{
			this.o0O0.O0_o. = new Process();
		}

		/// <summary>
		/// 指定要执行的文件
		/// </summary>
		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x0014D1E2 File Offset: 0x0014B3E2
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x0014D1F4 File Offset: 0x0014B3F4
		public string File
		{
			get
			{
				return this.o0O0.O0_o..StartInfo.FileName;
			}
			set
			{
				this.o0O0.O0_o..StartInfo.FileName = value;
			}
		}

		/// <summary>
		/// 指定要执行的动作
		/// </summary>
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x0014D207 File Offset: 0x0014B407
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x0014D219 File Offset: 0x0014B419
		public string Verb
		{
			get
			{
				return this.o0O0.O0_o..StartInfo.Verb;
			}
			set
			{
				this.o0O0.O0_o..StartInfo.Verb = value;
			}
		}

		/// <summary>
		/// 返回一个字符数组，包括即将执行的文件支持哪些动作。
		/// </summary>
		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x0014D22C File Offset: 0x0014B42C
		public string[] Verbs
		{
			get
			{
				return this.o0O0.O0_o..StartInfo.Verbs;
			}
		}

		/// <summary>
		/// 命令行参数
		/// </summary>
		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x0014D23E File Offset: 0x0014B43E
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x0014D250 File Offset: 0x0014B450
		public string Arguments
		{
			get
			{
				return this.o0O0.O0_o..StartInfo.Arguments;
			}
			set
			{
				this.o0O0.O0_o..StartInfo.Arguments = value;
			}
		}

		/// <summary>
		/// 如果设为True，直到关闭外部程序，才会执行接下来的代码
		/// </summary>
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x0014D263 File Offset: 0x0014B463
		// (set) Token: 0x06002D1D RID: 11549 RVA: 0x0014D26B File Offset: 0x0014B46B
		public bool WaitForClose
		{
			get
			{
				return this.o0O0.O0_o.;
			}
			set
			{
				this.o0O0.O0_o. = value;
			}
		}

		/// <summary>
		/// 开始执行
		/// </summary>
		// Token: 0x06002D1E RID: 11550 RVA: 0x0014D274 File Offset: 0x0014B474
		public void Start()
		{
			try
			{
				this.o0O0.O0_o..Start();
				if (this.WaitForClose)
				{
					this.o0O0.O0_o..WaitForExit();
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x0014D2CC File Offset: 0x0014B4CC
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x0014D2D9 File Offset: 0x0014B4D9
		public ProcessStartInfo StartInfo
		{
			get
			{
				return this.o0O0.O0_o..StartInfo;
			}
			set
			{
				this.o0O0.O0_o..StartInfo = value;
			}
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0014D2E7 File Offset: 0x0014B4E7
		public static Process Start(string fileName)
		{
			return Process.Start(fileName);
		}

		/// <summary>
		/// 关闭
		/// </summary>
		// Token: 0x06002D22 RID: 11554 RVA: 0x0014D2EF File Offset: 0x0014B4EF
		public void Close()
		{
			this.o0O0.O0_o..CloseMainWindow();
			this.o0O0.O0_o..Close();
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x0014D308 File Offset: 0x0014B508
		public void WaitForExit()
		{
			this.o0O0.O0_o..WaitForExit();
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x0014D315 File Offset: 0x0014B515
		public IntPtr MainWindowHandle
		{
			get
			{
				return this.o0O0.O0_o..MainWindowHandle;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x0014D322 File Offset: 0x0014B522
		public bool HasExited
		{
			get
			{
				return this.o0O0.O0_o..HasExited;
			}
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0014D32F File Offset: 0x0014B52F
		public bool WaitForInputIdle()
		{
			return this.o0O0.O0_o..WaitForInputIdle();
		}

		// Token: 0x04001249 RID: 4681
		private Process <<EMPTY_NAME>>;

		// Token: 0x0400124A RID: 4682
		private bool <<EMPTY_NAME>>;
	}
}

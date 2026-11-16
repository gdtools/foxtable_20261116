using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using C1.Win.C1Input;
using Foxtable.My;

namespace Foxtable
{
	/// <summary>
	/// 用于在命令窗口显示信息
	/// </summary>
	// Token: 0x02000325 RID: 805
	[ComVisible(true)]
	public class Output
	{
		/// <summary>
		/// 显示信息
		/// </summary>
		/// <param name="Message">信息</param>
		// Token: 0x06002D0A RID: 11530 RVA: 0x0014D068 File Offset: 0x0014B268
		[oO0oooo("2642")]
		public static void Show(string Message)
		{
			if (Output.oo.oOoO0. != null && !Output.oo.oOoO0..IsDisposed)
			{
				if (Message == null)
				{
					Message = "";
				}
				C1TextBox c1TextBox = Output.oo.oOoO0..oo._OoO.();
				c1TextBox.AppendText(Message);
				c1TextBox.AppendText("\r\n");
			}
		}

		/// <summary>
		/// 清除信息
		/// </summary>
		// Token: 0x06002D0B RID: 11531 RVA: 0x0014D0A4 File Offset: 0x0014B2A4
		public static void Clear()
		{
			if (Output.oo.oOoO0. != null && !Output.oo.oOoO0..IsDisposed)
			{
				Output.oo.oOoO0..oo._OoO.().Value = null;
			}
		}

		/// <summary>
		/// 获取指定名称的日志
		/// </summary>
		/// <param name="Key">日志名称</param>
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x0014D0CB File Offset: 0x0014B2CB
		[oO0oooo("0435")]
		public static Output.Log Logs
		{
			get
			{
				if (!Output.oo.oOoO0..ContainsKey(Key))
				{
					Output.oo.oOoO0..Add(Key, new Output.Log());
				}
				return Output.oo.oOoO0.[Key];
			}
		}

		/// <summary>
		/// 日志集合
		/// </summary>
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x0014D0F5 File Offset: 0x0014B2F5
		public static Dictionary<string, Output.Log> Logs
		{
			get
			{
				return Output.oo.oOoO0.;
			}
		}

		// Token: 0x04001246 RID: 4678
		private static Dictionary<string, Output.Log> <<EMPTY_NAME>> = new Dictionary<string, Output.Log>();

		// Token: 0x04001247 RID: 4679
		internal static oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>;

		/// <summary>
		/// 日志
		/// </summary>
		// Token: 0x02000326 RID: 806
		[ComVisible(true)]
		[oO0oooo("0435")]
		public class Log
		{
			// Token: 0x06002D0E RID: 11534 RVA: 0x0014D0FC File Offset: 0x0014B2FC
			public Log()
			{
				this.Builder = new StringBuilder();
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x06002D0F RID: 11535 RVA: 0x0014D10F File Offset: 0x0014B30F
			// (set) Token: 0x06002D10 RID: 11536 RVA: 0x0014D117 File Offset: 0x0014B317
			private virtual StringBuilder Builder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

			/// <summary>
			/// 添加日志信息
			/// </summary>
			/// <param name="Message"></param>
			// Token: 0x06002D11 RID: 11537 RVA: 0x0014D120 File Offset: 0x0014B320
			public void Add(string Message)
			{
				if (this.Builder.Length > 0)
				{
					this.Builder.Append("\r\n");
				}
				this.Builder.Append(Message);
			}

			/// <summary>
			/// 清除日志信息
			/// </summary>
			// Token: 0x06002D12 RID: 11538 RVA: 0x0014D14E File Offset: 0x0014B34E
			public void Clear()
			{
				if (this.Builder.Length > 0)
				{
					this.Builder.Remove(0, this.Builder.Length);
				}
			}

			/// <summary>
			/// 保存日志
			/// </summary>
			/// <param name="FileName">文件名</param>
			/// <param name="Append">如果文件已经存在，是否将信息添加到原有信息之后</param>
			// Token: 0x06002D13 RID: 11539 RVA: 0x0014D178 File Offset: 0x0014B378
			public void Save(string FileName, bool Append)
			{
				if (c.OOOOO.o.().FileSystem.FileExists(FileName))
				{
					c.OOOOO.o.().FileSystem.WriteAllText(FileName, "\r\n", Append);
				}
				c.OOOOO.o.().FileSystem.WriteAllText(FileName, this.Builder.ToString(), Append);
				this.Clear();
			}

			// Token: 0x04001248 RID: 4680
			[AccessedThroughProperty("Builder")]
			[CompilerGenerated]
			private StringBuilder <<EMPTY_NAME>>;
		}
	}
}

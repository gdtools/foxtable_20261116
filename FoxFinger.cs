using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 用于指纹采集和识别
	/// </summary>
	// Token: 0x02000260 RID: 608
	[oO0oooo("2486")]
	[StandardModule]
	public sealed class FoxFinger
	{
		// Token: 0x06001CC2 RID: 7362 RVA: 0x000C6538 File Offset: 0x000C4738
		static FoxFinger()
		{
			if (FoxFinger.Reader == null)
			{
				FoxFinger.Reader = new O_O();
			}
		}

		/// <summary>
		/// 启动指纹采集器
		/// </summary>
		// Token: 0x06001CC3 RID: 7363 RVA: 0x000C654B File Offset: 0x000C474B
		public static void Start()
		{
			FoxFinger.Reader.O00._o.();
		}

		/// <summary>
		/// 关闭指纹采集器
		/// </summary>
		// Token: 0x06001CC4 RID: 7364 RVA: 0x000C6557 File Offset: 0x000C4757
		public static void Stop()
		{
			if (FoxFinger.Reader.o0o.O_.())
			{
				FoxFinger.Reader.OOO0OO0.o_o.();
			}
		}

		/// <summary>
		/// 登记指纹，如果登记成功，返回指纹生成的指纹模板
		/// </summary>
		// Token: 0x06001CC5 RID: 7365 RVA: 0x000C6570 File Offset: 0x000C4770
		public static string Enroll()
		{
			string result;
			if (FoxFinger.Reader.o0o.O_.())
			{
				result = FoxFinger.Reader.O_0_oO.o__.();
			}
			else
			{
				MessageBox.Show("请先启动指纹采集器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = "";
			}
			return result;
		}

		/// <summary>
		/// 比对指纹
		/// </summary>
		/// <param name="TemplateString">用于比对的指纹模板，事先通过Enroll方法采集</param>
		/// <param name="featuresString">用于比对的指纹特征，在FingerCapture事件捕获</param>
		// Token: 0x06001CC6 RID: 7366 RVA: 0x000C65B0 File Offset: 0x000C47B0
		public static bool Verify(string TemplateString, string featuresString)
		{
			bool result;
			if (FoxFinger.Reader.o0o.O_.())
			{
				result = FoxFinger.Reader.O00._o.(TemplateString, featuresString);
			}
			else
			{
				MessageBox.Show("请先启动指纹采集器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			return result;
		}

		/// <summary>
		/// 返回指纹采集器的物理序列号
		/// </summary>
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x000C65F0 File Offset: 0x000C47F0
		public static string SerialNumber
		{
			get
			{
				string result;
				if (FoxFinger.Reader.o0o.O_.())
				{
					result = FoxFinger.Reader.o0o.O_.();
				}
				else
				{
					MessageBox.Show("请先启动指纹采集器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = "";
				}
				return result;
			}
		}

		/// <summary>
		/// 判断指纹采集器是否已经连接并启动
		/// </summary>
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000C6630 File Offset: 0x000C4830
		public static bool Ready
		{
			get
			{
				return FoxFinger.Reader.o0o.O_.();
			}
		}

		// Token: 0x04000C41 RID: 3137
		private static O_O Reader;
	}
}

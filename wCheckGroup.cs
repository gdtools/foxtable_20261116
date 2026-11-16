using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000219 RID: 537
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0053")]
	public class wCheckGroup : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A04 RID: 6660 RVA: 0x000B95FB File Offset: 0x000B77FB
		internal wCheckGroup(string A_0, string A_1) : base(A_0, A_1)
		{
			this.o00.0Oo. = new List<wCheck>();
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000B9610 File Offset: 0x000B7810
		internal wCheckGroup(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.o00.0Oo. = new List<wCheck>();
			this.o00.0Oo. = A_2;
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x000B962C File Offset: 0x000B782C
		private string BaseClass
		{
			get
			{
				return "weui_cells weui_cells_checkbox";
			}
		}

		/// <summary>
		/// 标题
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x000B9633 File Offset: 0x000B7833
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x000B963B File Offset: 0x000B783B
		public string Text
		{
			get
			{
				return this.o00.0Oo.;
			}
			set
			{
				this.o00.0Oo. = value;
			}
		}

		/// <summary>
		/// 增加复选列表项
		/// </summary>
		/// <param name="ID">列表项ID</param>
		/// <param name="Text">复选列表项的文本内容</param>
		/// <param name="Checked">逻辑型，可选参数，复选列表项默认是否勾选</param>
		// Token: 0x06001A09 RID: 6665 RVA: 0x000B9644 File Offset: 0x000B7844
		public wCheck Add(string ID, string Text, bool Checked = false)
		{
			wCheck wCheck = new wCheck(base.ID, ID, Text, Checked);
			this.o00.0Oo..Add(wCheck);
			return wCheck;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x000B9670 File Offset: 0x000B7870
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.Text, "", true) > 0)
			{
				A_0.AppendLine("<div class='fox_group'>");
				new wGroupTitle(base.ID, "", this.Text).OooO_o0o0O.0_.(A_0, A_1);
			}
			string text;
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = "<div class='" + this.BaseClass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					"<div class='",
					this.BaseClass,
					" ",
					base.Class,
					"'"
				});
			}
			text = string.Concat(new string[]
			{
				text,
				" id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			});
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			text += ">";
			A_0.AppendLine(text);
			try
			{
				foreach (wCheck wCheck in this.o00.0Oo.)
				{
					wCheck.OO00000O0.0.(A_0, A_1);
				}
			}
			finally
			{
				List<wCheck>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</div>");
			if (Operators.CompareString(this.Text, "", true) > 0)
			{
				A_0.AppendLine("</div>");
			}
		}

		// Token: 0x04000AF1 RID: 2801
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AF2 RID: 2802
		private List<wCheck> <<EMPTY_NAME>>;
	}
}

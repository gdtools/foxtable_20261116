using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000229 RID: 553
	[oO0oooo("A0052")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wRadioGroup : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A6C RID: 6764 RVA: 0x000BB8FE File Offset: 0x000B9AFE
		internal wRadioGroup(string A_0, string A_1) : base(A_0, A_1)
		{
			this.O0.0O0OooO0. = new List<wRadion>();
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x000BB913 File Offset: 0x000B9B13
		private string BaseClass
		{
			get
			{
				return "weui_cells weui_cells_radio";
			}
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000BB91A File Offset: 0x000B9B1A
		internal wRadioGroup(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.O0.0O0OooO0. = new List<wRadion>();
			this.O0.0O0OooO0. = A_2;
		}

		/// <summary>
		/// 增加单选列表项
		/// </summary>
		/// <param name="ID">列表项ID</param>
		/// <param name="Text">单选列表项的文本内容</param>
		/// <param name="Checked">逻辑型，可选参数，单选列表项默认是否勾选</param>
		// Token: 0x06001A6F RID: 6767 RVA: 0x000BB938 File Offset: 0x000B9B38
		public wRadion Add(string ID, string Text, bool Checked = false)
		{
			wRadion wRadion = new wRadion(base.ID, ID, Text, Checked);
			this.O0.0O0OooO0..Add(wRadion);
			return wRadion;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x000BB964 File Offset: 0x000B9B64
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.O0.0O0OooO0., "", true) > 0)
			{
				A_0.AppendLine("<div class='fox_group'>");
				new wGroupTitle(base.ID, "", this.O0.0O0OooO0.).OooO_o0o0O.0_.(A_0, A_1);
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
				foreach (wRadion wRadion in this.O0.0O0OooO0.)
				{
					wRadion.O0.0O0OooO0.(A_0, A_1);
				}
			}
			finally
			{
				List<wRadion>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</div>");
			if (Operators.CompareString(this.O0.0O0OooO0., "", true) > 0)
			{
				A_0.AppendLine("</div>");
			}
		}

		// Token: 0x04000B25 RID: 2853
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B26 RID: 2854
		private List<wRadion> <<EMPTY_NAME>>;
	}
}

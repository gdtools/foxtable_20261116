using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000238 RID: 568
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0083")]
	public class wToptips : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x000BEA0F File Offset: 0x000BCC0F
		internal wToptips(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.o0_._00. = A_2;
		}

		/// <summary>
		/// 整数型，默认为0，用于设置TopTips初始显示的毫秒数
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x000BEA20 File Offset: 0x000BCC20
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x000BEA28 File Offset: 0x000BCC28
		public int msec
		{
			get
			{
				return this.o00O_OO.O.;
			}
			set
			{
				this.o00O_OO.O. = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x000BEA31 File Offset: 0x000BCC31
		private string baseClass
		{
			get
			{
				return "weui_toptips weui_warn fox_toptips";
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000BEA38 File Offset: 0x000BCC38
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = "<div";
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = text + " class='" + this.baseClass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					" class='",
					this.baseClass,
					" ",
					base.Class,
					"'"
				});
			}
			text = string.Concat(new string[]
			{
				text,
				" name='",
				base.ID,
				"' id='",
				base.ID,
				"'style='display:none'"
			});
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			text = text + ">" + this.o0_._00. + "</div>";
			A_0.AppendLine(text);
			if (this.msec > 0)
			{
				A_1.Scripts.Add(string.Concat(new string[]
				{
					"show('",
					base.ID,
					"',",
					Conversions.ToString(this.msec),
					");"
				}));
			}
		}

		// Token: 0x04000B69 RID: 2921
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B6A RID: 2922
		private int <<EMPTY_NAME>>;
	}
}

using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200022D RID: 557
	[oO0oooo("A0048")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wSelect : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A89 RID: 6793 RVA: 0x000BC251 File Offset: 0x000BA451
		internal wSelect(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.OOOO0._0O. = true;
			this.o_0_oO0_oo_0.O. = true;
			this.OOOO0._0O. = A_2;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000BC270 File Offset: 0x000BA470
		internal wSelect(string A_0, string A_1, string A_2, string A_3) : base(A_0, A_1)
		{
			this.OOOO0._0O. = true;
			this.o_0_oO0_oo_0.O. = true;
			this.OOOO0._0O. = A_2;
			this.O.0_OOOoO. = A_3;
		}

		/// <summary>
		/// 在输入框左侧显示的标签
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x000BC297 File Offset: 0x000BA497
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x000BC29F File Offset: 0x000BA49F
		public string Label
		{
			get
			{
				return this.OOOO0._0O.;
			}
			set
			{
				this.OOOO0._0O. = value;
			}
		}

		/// <summary>
		/// 是否允许用户选择这个项目
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x000BC2A8 File Offset: 0x000BA4A8
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x000BC2B0 File Offset: 0x000BA4B0
		public bool Enabled
		{
			get
			{
				return this.OOOO0._0O.;
			}
			set
			{
				this.OOOO0._0O. = value;
			}
		}

		/// <summary>
		/// 逻辑型，提示表单数据时是否包括此输入框的值，默认为True
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000BC2B9 File Offset: 0x000BA4B9
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x000BC2C1 File Offset: 0x000BA4C1
		public bool Post
		{
			get
			{
				return this.o_0_oO0_oo_0.O.;
			}
			set
			{
				this.o_0_oO0_oo_0.O. = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x000BC2CA File Offset: 0x000BA4CA
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x000BC2D2 File Offset: 0x000BA4D2
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool required
		{
			get
			{
				return this.O.0_OOOoO.;
			}
			set
			{
				this.O.0_OOOoO. = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x000BC2DB File Offset: 0x000BA4DB
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x000BC2E3 File Offset: 0x000BA4E3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string HID
		{
			get
			{
				return this.o_0_oO0_oo_0.O.;
			}
			set
			{
				this.o_0_oO0_oo_0.O. = value;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x000BC2EC File Offset: 0x000BA4EC
		private string baseClass
		{
			get
			{
				return "weui_select";
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000BC2F4 File Offset: 0x000BA4F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.HID, "", true) == 0)
			{
				A_0.AppendLine("<div class='weui_cell weui_cell_select weui_select_after'>");
			}
			else
			{
				A_0.AppendLine(string.Concat(new string[]
				{
					"<div class='weui_cell weui_cell_select weui_select_after' id='",
					this.HID,
					"' name='",
					this.HID,
					"'>"
				}));
			}
			if (Operators.CompareString(this.Label, "", true) > 0)
			{
				A_0.AppendLine("<div class='weui_cell_hd'><label class='weui_label'>" + this.Label + "</label></div>");
			}
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>");
			this.OOOO0._0O.(A_0, A_1);
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000BC3BC File Offset: 0x000BA5BC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = "<select id='" + base.ID + "'";
			if (this.Post)
			{
				text = text + " name='" + base.ID + "'";
			}
			if (!this.Enabled)
			{
				text += " disabled";
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			if (this.required)
			{
				text += " required";
			}
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
			A_0.AppendLine(text + ">");
			if (Operators.CompareString(this.O.0_OOOoO., "", true) > 0)
			{
				A_0.AppendLine("<option style='display: none'></option>");
				foreach (string text2 in this.O.0_OOOoO..Split(new char[]
				{
					'|'
				}))
				{
					bool flag;
					if (text2.StartsWith("[") && text2.EndsWith("]"))
					{
						flag = true;
						text2 = text2.Trim(new char[]
						{
							'['
						}).Trim(new char[]
						{
							']'
						});
					}
					else
					{
						flag = false;
					}
					string[] array2 = text2.Split(new char[]
					{
						':'
					});
					if (flag)
					{
						if (array2.Length > 1)
						{
							A_0.AppendLine(string.Concat(new string[]
							{
								" <option  value='",
								array2[0],
								"' selected>",
								array2[1],
								"</option>"
							}));
						}
						else
						{
							A_0.AppendLine(" <option selected>" + array2[0] + "</option>");
						}
					}
					else if (array2.Length > 1)
					{
						A_0.AppendLine(string.Concat(new string[]
						{
							" <option value='",
							array2[0],
							"'>",
							array2[1],
							"</option>"
						}));
					}
					else
					{
						A_0.AppendLine(" <option>" + array2[0] + "</option>");
					}
				}
			}
			A_0.AppendLine("</select>");
		}

		// Token: 0x04000B32 RID: 2866
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B33 RID: 2867
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B34 RID: 2868
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B35 RID: 2869
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B36 RID: 2870
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B37 RID: 2871
		private bool <<EMPTY_NAME>>;
	}
}

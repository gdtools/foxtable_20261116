using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000220 RID: 544
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0045")]
	public class wInputGroup : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x000BA315 File Offset: 0x000B8515
		public wInputGroup(string A_0, string A_1) : base(A_0, A_1)
		{
			this.OoOO0._00O0__o. = new List<wElement>();
		}

		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">分组ID</param>
		/// <param name="Text">可选参数，用于指定分组标题</param>
		// Token: 0x06001A3B RID: 6715 RVA: 0x000BA32A File Offset: 0x000B852A
		public wInputGroup(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.OoOO0._00O0__o. = new List<wElement>();
			this.O.__00oOO_o0O0. = A_2;
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x000BA346 File Offset: 0x000B8546
		private string BaseClass
		{
			get
			{
				return "weui_cells weui_cells_form";
			}
		}

		/// <summary>
		/// 增加输入框
		/// </summary>
		/// <param name="id">输入框的id</param>
		/// <param name="label">输入框的标题</param>
		/// <param name="type">输入框类型:
		/// 文本为"text"
		/// 密码为"password"
		/// 数值为"number"
		/// 日期为"date"
		/// 时间为"time"
		/// 日期时间为"datetime-local"</param>
		// Token: 0x06001A3D RID: 6717 RVA: 0x000BA350 File Offset: 0x000B8550
		[oO0oooo("A0045")]
		public wInput AddInput(string id, string label, string type)
		{
			wInput wInput = new wInput(base.ID, id, label, type);
			this.OoOO0._00O0__o..Add(wInput);
			return wInput;
		}

		/// <summary>
		/// 增加列表输入框
		/// </summary>
		/// <param name="id">输入框ID</param>
		/// <param name="label">在输入框左侧显示的标签内容</param>
		/// <param name="options">列表项目，用符号"|"隔开，例如"大专|本科|硕士|博士"</param>
		// Token: 0x06001A3E RID: 6718 RVA: 0x000BA37C File Offset: 0x000B857C
		[oO0oooo("A0048")]
		public wSelect AddSelect(string id, string label, string options)
		{
			wSelect wSelect = new wSelect(base.ID, id, label, options);
			this.OoOO0._00O0__o..Add(wSelect);
			return wSelect;
		}

		/// <summary>
		/// 增加逻辑开关
		/// </summary>
		/// <param name="id">开关ID</param>
		/// <param name="label">在开关左侧显示的标签内容</param>
		/// <param name="checked">逻辑型，可选参数，开关默认是否处于开启状态</param>
		// Token: 0x06001A3F RID: 6719 RVA: 0x000BA3A8 File Offset: 0x000B85A8
		[oO0oooo("A0049")]
		public wSwitch AddSwitch(string id, string label, bool @checked = false)
		{
			wSwitch wSwitch = new wSwitch(base.ID, id, label, @checked);
			this.OoOO0._00O0__o..Add(wSwitch);
			return wSwitch;
		}

		/// <summary>
		/// 增加多行文本框
		/// </summary>
		/// <param name="id">输入框ID</param>
		/// <param name="rows">整数型，可选参数，用于设置行数，默认为3行</param>
		// Token: 0x06001A40 RID: 6720 RVA: 0x000BA3D4 File Offset: 0x000B85D4
		[oO0oooo("A0050")]
		public wTextArea AddTextArea(string id, int rows = 3)
		{
			wTextArea wTextArea = new wTextArea(base.ID, id, rows);
			this.OoOO0._00O0__o..Add(wTextArea);
			return wTextArea;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000BA3FC File Offset: 0x000B85FC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public wDataList AddDataList(string id, string Options)
		{
			wDataList wDataList = new wDataList(base.ID, id, Options);
			this.OoOO0._00O0__o..Add(wDataList);
			return wDataList;
		}

		/// <summary>
		/// 增加文件和图片上传组件
		/// </summary>
		/// <param name="id">组件ID</param>
		/// <param name="text">组件标题</param>
		/// <param name="multiple">逻辑型，可选参数，手否允许选择多个文件上传</param>
		// Token: 0x06001A42 RID: 6722 RVA: 0x000BA424 File Offset: 0x000B8624
		[oO0oooo("A0054")]
		public wUploader AddUploader(string id, string text, bool multiple = false)
		{
			wUploader wUploader = new wUploader(base.ID, id, text, multiple, "");
			this.OoOO0._00O0__o..Add(wUploader);
			return wUploader;
		}

		/// <summary>
		/// 增加InputCell组件
		/// </summary>
		/// <param name="ID">组件的ID</param>
		/// <param name="Warn">可选参数，设为1左边标签会套红显示，设为2右边还会显示一个红色警示图标</param>
		// Token: 0x06001A43 RID: 6723 RVA: 0x000BA454 File Offset: 0x000B8654
		[oO0oooo("A0051")]
		public wInputCell AddInputCell(string ID, int Warn = 0)
		{
			wInputCell wInputCell = new wInputCell(base.ID, ID, Warn);
			this.OoOO0._00O0__o..Add(wInputCell);
			return wInputCell;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x000BA47C File Offset: 0x000B867C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddHidenValue(string id, string Value)
		{
			this.AddHiddenValue(id, Value);
		}

		/// <summary>
		/// 输入框组插入隐藏的标记数据
		/// </summary>
		/// <param name="id">标记的ID</param>
		/// <param name="value">标记的值</param>
		// Token: 0x06001A45 RID: 6725 RVA: 0x000BA488 File Offset: 0x000B8688
		[oO0oooo("A0127")]
		public void AddHiddenValue(string id, string value)
		{
			string a_ = string.Concat(new string[]
			{
				"<input name='",
				id,
				"' id='",
				id,
				"' value='",
				value,
				"' hidden>"
			});
			wRawHtml item = new wRawHtml(base.ID, id, a_);
			this.OoOO0._00O0__o..Add(item);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000BA4E8 File Offset: 0x000B86E8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.O.__00oOO_o0O0., "", true) > 0)
			{
				A_0.AppendLine("<div class='fox_group'>");
				new wGroupTitle(base.ID, "", this.O.__00oOO_o0O0.).OooO_o0o0O.0_.(A_0, A_1);
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
				foreach (wElement wElement in this.OoOO0._00O0__o.)
				{
					if (Operators.CompareString(wElement.PID, base.ID, true) == 0)
					{
						((o_oOOOoo_O_O)wElement).OOO.__O_oO_.(A_0, A_1);
					}
				}
			}
			finally
			{
				List<wElement>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</div>");
			if (Operators.CompareString(this.O.__00oOO_o0O0., "", true) > 0)
			{
				A_0.AppendLine("</div>");
			}
		}

		// Token: 0x04000B09 RID: 2825
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B0A RID: 2826
		private List<wElement> <<EMPTY_NAME>>;
	}
}

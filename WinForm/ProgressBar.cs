using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 进度条
	/// </summary>
	// Token: 0x02000534 RID: 1332
	[ComVisible(true)]
	[oO0oooo("0793")]
	public class ProgressBar : Control, OoO_
	{
		// Token: 0x06005905 RID: 22789 RVA: 0x0025F97C File Offset: 0x0025DB7C
		internal ProgressBar(o_O_O0O__ A_0) : base(A_0, ControlTypeEnum.ProgressBar)
		{
			this.Oooo.Oo_0O. = A_0;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06005906 RID: 22790 RVA: 0x0025F98E File Offset: 0x0025DB8E
		// (set) Token: 0x06005907 RID: 22791 RVA: 0x0025F998 File Offset: 0x0025DB98
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.Oooo.Oo_0O..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.BaseControl.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.ProgressBar, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.Oooo.Oo_0O..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value", value);
							if (binding != null)
							{
								binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
								this.Oooo.Oo_0O..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 返回或设置进度条的当前值
		/// </summary>
		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06005908 RID: 22792 RVA: 0x0025FA70 File Offset: 0x0025DC70
		// (set) Token: 0x06005909 RID: 22793 RVA: 0x0025FA7D File Offset: 0x0025DC7D
		public object Value
		{
			get
			{
				return this.Oooo.Oo_0O..Value;
			}
			set
			{
				this.Oooo.Oo_0O..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 返回或设置进度条的最大值
		/// </summary>
		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x0600590A RID: 22794 RVA: 0x0025FA90 File Offset: 0x0025DC90
		// (set) Token: 0x0600590B RID: 22795 RVA: 0x0025FA9D File Offset: 0x0025DC9D
		public int Maximum
		{
			get
			{
				return this.Oooo.Oo_0O..Maximum;
			}
			set
			{
				this.Oooo.Oo_0O..Maximum = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的最小值
		/// </summary>
		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x0600590C RID: 22796 RVA: 0x0025FAAB File Offset: 0x0025DCAB
		// (set) Token: 0x0600590D RID: 22797 RVA: 0x0025FAB8 File Offset: 0x0025DCB8
		public int Minimum
		{
			get
			{
				return this.Oooo.Oo_0O..Minimum;
			}
			set
			{
			}
		}

		/// <summary>
		/// 进度条样式
		/// </summary>
		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x0600590E RID: 22798 RVA: 0x0025FABA File Offset: 0x0025DCBA
		// (set) Token: 0x0600590F RID: 22799 RVA: 0x0025FAC7 File Offset: 0x0025DCC7
		public ProgressBarStyle Style
		{
			get
			{
				return this.Oooo.Oo_0O..Style;
			}
			set
			{
				this.Oooo.Oo_0O..Style = value;
			}
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x0025FAD5 File Offset: 0x0025DCD5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x04002324 RID: 8996
		private o_O_O0O__ <<EMPTY_NAME>>;
	}
}

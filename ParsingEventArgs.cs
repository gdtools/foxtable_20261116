using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200015F RID: 351
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ParsingEventArgs : ControlEventArgs
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x0007E3C5 File Offset: 0x0007C5C5
		public ParsingEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ParseEventArgs A_2) : base(A_0, A_1)
		{
			this.O_0o0.OoO_o. = A_2;
		}

		/// <summary>
		/// 返回用户输入的内容
		/// </summary>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0007E3D6 File Offset: 0x0007C5D6
		public string Text
		{
			get
			{
				return this.O_0o0.OoO_o..Text;
			}
		}

		/// <summary>
		/// 返回或设置写入的值
		/// </summary>
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0007E3E3 File Offset: 0x0007C5E3
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x0007E3F0 File Offset: 0x0007C5F0
		public object Value
		{
			get
			{
				return this.O_0o0.OoO_o..Text;
			}
			set
			{
				this.O_0o0.OoO_o..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x04000675 RID: 1653
		private ParseEventArgs <<EMPTY_NAME>>;
	}
}

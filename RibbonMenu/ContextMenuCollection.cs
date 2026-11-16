using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000026 RID: 38
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("1324")]
	[ComVisible(true)]
	public class ContextMenuCollection : IEnumerable
	{
		// Token: 0x0600012B RID: 299 RVA: 0x000039DA File Offset: 0x00001BDA
		public ContextMenuCollection(Dictionary<string, o__o_OO_o_> A_0)
		{
			this.o_.o0_o. = A_0;
		}

		// Token: 0x1700008B RID: 139
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContextMenu this[object A_0]
		{
			get
			{
				ContextMenu result;
				if (A_0 is string)
				{
					result = this[Conversions.ToString(A_0)];
				}
				else
				{
					result = this[Conversions.ToInteger(A_0)];
				}
				return result;
			}
		}

		// Token: 0x1700008C RID: 140
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContextMenu this[int A_0]
		{
			get
			{
				List<string> list = new List<string>();
				list.AddRange(this.o_.o0_o..Keys);
				return this[list[A_0]];
			}
		}

		// Token: 0x1700008D RID: 141
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContextMenu this[string A_0]
		{
			get
			{
				ContextMenu result;
				if (this.o_.o0_o..ContainsKey(A_0))
				{
					result = new ContextMenu(this.o_.o0_o.[A_0]);
				}
				else
				{
					MessageBox.Show("不存在名为\"" + A_0 + "\"的快捷菜单！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 快捷菜单总数
		/// </summary>
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public int Count
		{
			get
			{
				return this.o_.o0_o..Count;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003AB1 File Offset: 0x00001CB1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator()
		{
			return new ContextMenuEnumerator(this);
		}

		// Token: 0x0400003E RID: 62
		private Dictionary<string, o__o_OO_o_> <<EMPTY_NAME>>;
	}
}

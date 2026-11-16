using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000031 RID: 49
	[oO0oooo("2483")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonGroupCollection : IEnumerable
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00004762 File Offset: 0x00002962
		public RibbonGroupCollection(RibbonGroupCollection A_0)
		{
			this.oOo_.0o_O_O_0. = A_0;
		}

		/// <summary>
		/// 增加功能组
		/// </summary>
		/// <param name="Group">要增加的功能组</param>
		// Token: 0x06000185 RID: 389 RVA: 0x00004771 File Offset: 0x00002971
		public void Add(Group Group)
		{
			this.oOo_.0o_O_O_0..Add(Group.OO0oOo.O_o0.);
		}

		/// <summary>
		/// 插入功能组
		/// </summary>
		/// <param name="Index">插入位置</param>
		/// <param name="Group">要插入的功能组</param>
		// Token: 0x06000186 RID: 390 RVA: 0x00004785 File Offset: 0x00002985
		public void Insert(int Index, Group Group)
		{
			this.oOo_.0o_O_O_0..Insert(Index, Group.OO0oOo.O_o0.);
		}

		/// <summary>
		/// 删除功能组
		/// </summary>
		/// <param name="Group">要删除的功能组</param>
		// Token: 0x06000187 RID: 391 RVA: 0x00004799 File Offset: 0x00002999
		public void Remove(Group Group)
		{
			this.oOo_.0o_O_O_0..Remove(Group.OO0oOo.O_o0.);
		}

		/// <summary>
		/// 删除指定位置的功能组
		/// </summary>
		/// <param name="Index">要删除的功能组位置</param>
		// Token: 0x06000188 RID: 392 RVA: 0x000047AC File Offset: 0x000029AC
		public void RemoveAt(int Index)
		{
			this.oOo_.0o_O_O_0..RemoveAt(Index);
		}

		// Token: 0x170000AE RID: 174
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Group this[object A_0]
		{
			get
			{
				Group result;
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

		// Token: 0x170000AF RID: 175
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Group this[int A_0]
		{
			get
			{
				Group result;
				if (A_0 < 0 | A_0 > this.oOo_.0o_O_O_0..Count - 1)
				{
					result = null;
				}
				else
				{
					result = new Group(this.oOo_.0o_O_O_0.[A_0]);
				}
				return result;
			}
		}

		// Token: 0x170000B0 RID: 176
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Group this[string A_0]
		{
			get
			{
				Group result;
				if (this.oOo_.0o_O_O_0..Contains(A_0))
				{
					result = this[this.oOo_.0o_O_O_0..IndexOf(this.oOo_.0o_O_O_0.[A_0])];
				}
				else
				{
					MessageBox.Show("菜单中不存在名为\"" + A_0 + "\"的功能组！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 删除所有功能组
		/// </summary>
		// Token: 0x0600018C RID: 396 RVA: 0x00004888 File Offset: 0x00002A88
		public void Clear()
		{
			this.oOo_.0o_O_O_0..Clear();
		}

		/// <summary>
		/// 功能组总数
		/// </summary>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00004895 File Offset: 0x00002A95
		public int Count
		{
			get
			{
				return this.oOo_.0o_O_O_0..Count;
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的功能组
		/// </summary>
		/// <param name="Name"></param>
		// Token: 0x0600018E RID: 398 RVA: 0x000048A2 File Offset: 0x00002AA2
		public bool Contains(string Name)
		{
			return this.oOo_.0o_O_O_0..Contains(Name);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000048B0 File Offset: 0x00002AB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Contains(Group g)
		{
			return this.oOo_.0o_O_O_0..Contains(g.OO0oOo.O_o0.);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000048C3 File Offset: 0x00002AC3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator()
		{
			return new RibbonGroupEnumerator(this);
		}

		// Token: 0x04000051 RID: 81
		private RibbonGroupCollection <<EMPTY_NAME>>;
	}
}

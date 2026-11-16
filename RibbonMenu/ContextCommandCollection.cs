using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200002B RID: 43
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class ContextCommandCollection : IEnumerable
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00003D3A File Offset: 0x00001F3A
		internal ContextCommandCollection(C1CommandLinks A_0)
		{
			this.o_o_0oO_.o_o. = A_0;
		}

		/// <summary>
		/// 项目总数
		/// </summary>
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00003D49 File Offset: 0x00001F49
		public int Count
		{
			get
			{
				return this.o_o_0oO_.o_o..Count;
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的项目
		/// </summary>
		/// <param name="Name"></param>
		// Token: 0x06000155 RID: 341 RVA: 0x00003D58 File Offset: 0x00001F58
		public bool Contains(string Name)
		{
			try
			{
				IEnumerator enumerator = this.o_o_0oO_.o_o..GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(((C1CommandLink)enumerator.Current).Command.Name, Name, true) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return false;
		}

		// Token: 0x170000A0 RID: 160
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[object A_0]
		{
			get
			{
				object result;
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

		// Token: 0x170000A1 RID: 161
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[int A_0]
		{
			get
			{
				object result;
				if (A_0 < 0 | A_0 > this.o_o_0oO_.o_o..Count - 1)
				{
					result = null;
				}
				else
				{
					result = new ContextCommand(this.o_o_0oO_.o_o.[A_0]);
				}
				return result;
			}
		}

		// Token: 0x170000A2 RID: 162
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string A_0]
		{
			get
			{
				try
				{
					foreach (object obj in this.o_o_0oO_.o_o.)
					{
						C1CommandLink c1CommandLink = (C1CommandLink)obj;
						if (Operators.CompareString(c1CommandLink.Command.Name, A_0, true) == 0)
						{
							if (c1CommandLink.Command is C1CommandMenu)
							{
								return new ContextCommandMenu(c1CommandLink);
							}
							return new ContextCommand(c1CommandLink);
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				MessageBox.Show("不存在名为\"" + A_0 + "的快捷菜单命令\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return null;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00003EE4 File Offset: 0x000020E4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator()
		{
			return new ContextCommandEnumerator(this);
		}

		/// <summary>
		/// 增加项目
		/// </summary>
		/// <param name="command">要增加的快捷菜单命令</param>
		// Token: 0x0600015A RID: 346 RVA: 0x00003EEC File Offset: 0x000020EC
		public void Add(ContextCommand command)
		{
			this.Add(command, command.Delimiter);
		}

		/// <summary>
		/// 增加项目
		/// </summary>
		/// <param name="command">要增加的快捷菜单命令</param>
		/// <param name="Delimiter">是否在该命令前显示一条分割线</param>
		// Token: 0x0600015B RID: 347 RVA: 0x00003EFC File Offset: 0x000020FC
		public void Add(ContextCommand command, bool Delimiter)
		{
			C1CommandLink c1CommandLink = new C1CommandLink(command.oo0OOOO_._..Command);
			c1CommandLink.Delimiter = Delimiter;
			this.o_o_0oO_.o_o..Add(c1CommandLink);
		}

		// Token: 0x04000047 RID: 71
		private C1CommandLinks <<EMPTY_NAME>>;
	}
}

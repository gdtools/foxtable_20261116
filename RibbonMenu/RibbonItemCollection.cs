using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200002F RID: 47
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("1132")]
	[ComVisible(true)]
	public class RibbonItemCollection : IEnumerable
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00004184 File Offset: 0x00002384
		public RibbonItemCollection(RibbonItemCollection A_0)
		{
			this.oOo_.0o_O_O_0. = A_0;
		}

		/// <summary>
		/// 增加组件
		/// </summary>
		/// <param name="Item">要增加的组件</param>
		// Token: 0x06000173 RID: 371 RVA: 0x00004193 File Offset: 0x00002393
		public void Add(RibbonItem Item)
		{
			this.oOo_.0o_O_O_0..Add(Item.oOo_.0o_O_O_0.);
		}

		/// <summary>
		/// 插入组件
		/// </summary>
		/// <param name="Index">插入位置</param>
		/// <param name="Item">要插入的组件</param>
		// Token: 0x06000174 RID: 372 RVA: 0x000041A7 File Offset: 0x000023A7
		public void Insert(int Index, RibbonItem Item)
		{
			this.oOo_.0o_O_O_0..Insert(Index, Item.oOo_.0o_O_O_0.);
		}

		/// <summary>
		/// 删除指定名称的组件
		/// </summary>
		/// <param name="Name">要删除组件的名称</param>
		// Token: 0x06000175 RID: 373 RVA: 0x000041BB File Offset: 0x000023BB
		public void Remove(string Name)
		{
			this.oOo_.0o_O_O_0..Remove(Name);
		}

		/// <summary>
		/// 删除组件
		/// </summary>
		/// <param name="Item">要删除的文件</param>
		// Token: 0x06000176 RID: 374 RVA: 0x000041C9 File Offset: 0x000023C9
		public void Remove(RibbonItem Item)
		{
			this.oOo_.0o_O_O_0..Remove(Item.oOo_.0o_O_O_0.);
		}

		/// <summary>
		/// 删除指定位置的组件
		/// </summary>
		/// <param name="Index">要删除组件的位置</param>
		// Token: 0x06000177 RID: 375 RVA: 0x000041DC File Offset: 0x000023DC
		public void RemoveAt(int Index)
		{
			this.oOo_.0o_O_O_0..RemoveAt(Index);
		}

		// Token: 0x170000A9 RID: 169
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

		// Token: 0x170000AA RID: 170
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string A_0]
		{
			get
			{
				object result;
				if (this.oOo_.0o_O_O_0..Contains(A_0))
				{
					result = this[this.oOo_.0o_O_O_0..IndexOf(this.oOo_.0o_O_O_0.[A_0])];
				}
				else
				{
					MessageBox.Show("菜单中不存在名为\"" + A_0 + "\"的组件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170000AB RID: 171
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[int A_0]
		{
			get
			{
				object result;
				if (A_0 < 0 | A_0 > this.oOo_.0o_O_O_0..Count - 1)
				{
					result = null;
				}
				else
				{
					if (this.oOo_.0o_O_O_0.[A_0] is RibbonListItem)
					{
						RibbonListItem ribbonListItem = (RibbonListItem)this.oOo_.0o_O_O_0.[A_0];
						if (ribbonListItem.Items.Count > 0 && ribbonListItem.Items[0] is RibbonButton)
						{
							return new Button((RibbonButton)ribbonListItem.Items[0]);
						}
					}
					else
					{
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonToggleButton)
						{
							return new ToggleButton((RibbonToggleButton)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonDatePicker)
						{
							return new DatePicker((RibbonDatePicker)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonTimePicker)
						{
							return new TimePicker((RibbonTimePicker)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonNumericBox)
						{
							return new NumericBox((RibbonNumericBox)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonProgressBar)
						{
							return new ProgressBar((RibbonProgressBar)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonCheckBox)
						{
							return new CheckBox((RibbonCheckBox)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonButton)
						{
							return new Button((RibbonButton)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonColorPicker)
						{
							return new ColorPicker((RibbonColorPicker)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonSplitButton)
						{
							return new SplitButton((RibbonSplitButton)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonLabel)
						{
							return new Label((RibbonLabel)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonTextBox)
						{
							return new TextBox((RibbonTextBox)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonMenu)
						{
							return new MenuButton((RibbonMenu)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonFontComboBox)
						{
							return new FontComboBox((RibbonFontComboBox)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonComboBox)
						{
							return new ComboBox((RibbonComboBox)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonToolBar)
						{
							return new ToolBar((RibbonToolBar)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonToggleGroup)
						{
							return new ToggleGroup((RibbonToggleGroup)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonSeparator)
						{
							return new Separator((RibbonSeparator)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is o_o_Oo0__o_0)
						{
							return new Gallery((o_o_Oo0__o_0)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonGalleryItem)
						{
							return new GalleryItem((RibbonGalleryItem)this.oOo_.0o_O_O_0.[A_0]);
						}
						if (this.oOo_.0o_O_O_0.[A_0] is RibbonTrackBar)
						{
							return new TrackBar((RibbonTrackBar)this.oOo_.0o_O_O_0.[A_0]);
						}
					}
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的组件
		/// </summary>
		/// <param name="Name">组件名称</param>
		// Token: 0x0600017B RID: 379 RVA: 0x000046B6 File Offset: 0x000028B6
		public bool Contains(string Name)
		{
			return this.oOo_.0o_O_O_0..Contains(Name);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000046C4 File Offset: 0x000028C4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Contains(RibbonItem Item)
		{
			return this.oOo_.0o_O_O_0..Contains(Item.oOo_.0o_O_O_0.);
		}

		/// <summary>
		/// 删除所有组件
		/// </summary>
		// Token: 0x0600017D RID: 381 RVA: 0x000046D7 File Offset: 0x000028D7
		public void Clear()
		{
			this.oOo_.0o_O_O_0..Clear();
		}

		/// <summary>
		/// 组件总数
		/// </summary>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000046E4 File Offset: 0x000028E4
		public int Count
		{
			get
			{
				return this.oOo_.0o_O_O_0..Count;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000046F1 File Offset: 0x000028F1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator()
		{
			return new RibbonItemEnumerator(this);
		}

		// Token: 0x0400004E RID: 78
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace Foxtable.WinForm
{
	// Token: 0x02000538 RID: 1336
	[ComVisible(true)]
	public class TabControl : Control
	{
		// Token: 0x06005956 RID: 22870 RVA: 0x0026012D File Offset: 0x0025E32D
		public TabControl(C1DockingTab A_0) : base(A_0, ControlTypeEnum.TabControl)
		{
			this.oO.ooo. = A_0;
			A_0.TabsCanFocus = false;
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06005957 RID: 22871 RVA: 0x00260148 File Offset: 0x0025E348
		// (set) Token: 0x06005958 RID: 22872 RVA: 0x00260156 File Offset: 0x0025E356
		public override Color BackColor
		{
			get
			{
				Color result;
				return result;
			}
			set
			{
			}
		}

		/// <summary>
		/// 页签位置
		/// </summary>
		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06005959 RID: 22873 RVA: 0x00260158 File Offset: 0x0025E358
		// (set) Token: 0x0600595A RID: 22874 RVA: 0x00260165 File Offset: 0x0025E365
		public TabAlignment TabPosition
		{
			get
			{
				return this.oO.ooo..Alignment;
			}
			set
			{
				this.oO.ooo..Alignment = value;
			}
		}

		/// <summary>
		/// 是否显示页签
		/// </summary>
		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x00260173 File Offset: 0x0025E373
		// (set) Token: 0x0600595C RID: 22876 RVA: 0x00260180 File Offset: 0x0025E380
		public bool ShowTabs
		{
			get
			{
				return this.oO.ooo..ShowTabs;
			}
			set
			{
				this.oO.ooo..ShowTabs = value;
			}
		}

		/// <summary>
		/// 页签对齐方式
		/// </summary>
		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x0026018E File Offset: 0x0025E38E
		// (set) Token: 0x0600595E RID: 22878 RVA: 0x0026019B File Offset: 0x0025E39B
		public StringAlignment TabAlign
		{
			get
			{
				return this.oO.ooo..AlignTabs;
			}
			set
			{
				this.oO.ooo..AlignTabs = value;
			}
		}

		/// <summary>
		/// 是否显示多行页签
		/// </summary>
		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x0600595F RID: 22879 RVA: 0x002601A9 File Offset: 0x0025E3A9
		// (set) Token: 0x06005960 RID: 22880 RVA: 0x002601B6 File Offset: 0x0025E3B6
		public bool MultiLine
		{
			get
			{
				return this.oO.ooo..MultiLine;
			}
			set
			{
				this.oO.ooo..MultiLine = value;
			}
		}

		/// <summary>
		/// 页签文本方向
		/// </summary>
		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x002601C4 File Offset: 0x0025E3C4
		// (set) Token: 0x06005962 RID: 22882 RVA: 0x002601D1 File Offset: 0x0025E3D1
		public TabTextDirectionEnum TextDirection
		{
			get
			{
				return this.oO.ooo..TextDirection;
			}
			set
			{
				this.oO.ooo..TextDirection = value;
			}
		}

		/// <summary>
		/// 页签文本位置
		/// </summary>
		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x002601DF File Offset: 0x0025E3DF
		// (set) Token: 0x06005964 RID: 22884 RVA: 0x002601EC File Offset: 0x0025E3EC
		public ButtonLayoutEnum TabLayout
		{
			get
			{
				return this.oO.ooo..TabLayout;
			}
			set
			{
				this.oO.ooo..TabLayout = value;
			}
		}

		/// <summary>
		/// 活动页签的字体是否加粗
		/// </summary>
		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x002601FA File Offset: 0x0025E3FA
		// (set) Token: 0x06005966 RID: 22886 RVA: 0x00260207 File Offset: 0x0025E407
		public bool SelectedTabBold
		{
			get
			{
				return this.oO.ooo..SelectedTabBold;
			}
			set
			{
				this.oO.ooo..SelectedTabBold = value;
			}
		}

		/// <summary>
		/// 页签间距
		/// </summary>
		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x00260215 File Offset: 0x0025E415
		// (set) Token: 0x06005968 RID: 22888 RVA: 0x00260222 File Offset: 0x0025E422
		public int TabsSpacing
		{
			get
			{
				return this.oO.ooo..TabsSpacing;
			}
			set
			{
				this.oO.ooo..TabsSpacing = value;
			}
		}

		/// <summary>
		/// 第一个页签的缩进距离
		/// </summary>
		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06005969 RID: 22889 RVA: 0x00260230 File Offset: 0x0025E430
		// (set) Token: 0x0600596A RID: 22890 RVA: 0x0026023D File Offset: 0x0025E43D
		public int Indent
		{
			get
			{
				return this.oO.ooo..Indent;
			}
			set
			{
				this.oO.ooo..Indent = value;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (set) Token: 0x0600596B RID: 22891 RVA: 0x0026024C File Offset: 0x0025E44C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Pages
		{
			set
			{
				string[] array = value.Split(new char[]
				{
					'\f'
				});
				this.oO.ooo..TabPages.Clear();
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					TabPage tabPage = new TabPage();
					this.oO.ooo..TabPages.Add(tabPage);
					o_O_o_oOoo__.OOOO_OO._oo.(tabPage, array[i], '\t');
				}
			}
		}

		/// <summary>
		/// 返回或设置选定页面编号
		/// </summary>
		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600596C RID: 22892 RVA: 0x002602B0 File Offset: 0x0025E4B0
		// (set) Token: 0x0600596D RID: 22893 RVA: 0x002602BD File Offset: 0x0025E4BD
		[oO0oooo("0831")]
		public int SelectedIndex
		{
			get
			{
				return this.oO.ooo..SelectedIndex;
			}
			set
			{
				this.oO.ooo..SelectedIndex = value;
			}
		}

		/// <summary>
		/// 返回或设置选定的页面
		/// </summary>
		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x0600596E RID: 22894 RVA: 0x002602CB File Offset: 0x0025E4CB
		// (set) Token: 0x0600596F RID: 22895 RVA: 0x002602DD File Offset: 0x0025E4DD
		public TabPage SelectedPage
		{
			get
			{
				return (TabPage)this.oO.ooo..SelectedTab;
			}
			set
			{
				this.oO.ooo..SelectedTab = value;
			}
		}

		/// <summary>
		/// 页面集合
		/// </summary>
		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06005970 RID: 22896 RVA: 0x002602EB File Offset: 0x0025E4EB
		[oO0oooo("0830")]
		public TabPageCollection TabPages
		{
			get
			{
				return new TabPageCollection(this.oO.ooo..TabPages);
			}
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00260300 File Offset: 0x0025E500
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TabPage AddPage()
		{
			TabPage tabPage = new TabPage();
			this.oO.ooo..TabPages.Add(tabPage);
			return tabPage;
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06005972 RID: 22898 RVA: 0x00260328 File Offset: 0x0025E528
		// (set) Token: 0x06005973 RID: 22899 RVA: 0x00260336 File Offset: 0x0025E536
		[EditorBrowsable(EditorBrowsableState.Never)]
		public VisualStyle VisualStyle
		{
			get
			{
				VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x0400232A RID: 9002
		private C1DockingTab <<EMPTY_NAME>>;
	}
}

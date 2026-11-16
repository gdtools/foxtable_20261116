using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000429 RID: 1065
	internal class TreeViewProperty : ControlPropertyBase
	{
		// Token: 0x06004878 RID: 18552 RVA: 0x001F4633 File Offset: 0x001F2833
		public TreeViewProperty(ControlHolder A_0) : base(A_0)
		{
			this.oOo0O_o_.oO_o. = (TreeView)A_0.ChildControl;
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x001F464D File Offset: 0x001F284D
		// (set) Token: 0x0600487A RID: 18554 RVA: 0x001F4658 File Offset: 0x001F2858
		[Description("设置节点高度，设为0表示使用默认高度。")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(3.7)]
		[DisplayName("节点高度")]
		[Category("外观")]
		[MergableProperty(true)]
		public int ItemHeight
		{
			get
			{
				return this.oOo0O_o_.oO_o.;
			}
			set
			{
				this.oOo0O_o_.oO_o. = value;
				if (value > 0)
				{
					this.oOo0O_o_.oO_o..ItemHeight = value;
					return;
				}
				this.oOo0O_o_.oO_o..ItemHeight = (int)Math.Ceiling((double)this.oOo0O_o_.oO_o..Font.Size * 1.5);
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x001F46A9 File Offset: 0x001F28A9
		// (set) Token: 0x0600487C RID: 18556 RVA: 0x001F46B6 File Offset: 0x001F28B6
		[O_Oo00Oo000O0(3.2)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(false)]
		[DisplayName("显示复选框")]
		public bool CheckBoxes
		{
			get
			{
				return this.oOo0O_o_.oO_o..CheckBoxes;
			}
			set
			{
				this.oOo0O_o_.oO_o..CheckBoxes = value;
				if (value)
				{
					this.ItemHeight = Math.Max(16, this.ItemHeight);
				}
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x001F46DA File Offset: 0x001F28DA
		// (set) Token: 0x0600487E RID: 18558 RVA: 0x001F46E7 File Offset: 0x001F28E7
		[O_Oo00Oo000O0(3.3)]
		[Category("外观")]
		[DisplayName("显示加减号")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		public bool ShowPlusMinus
		{
			get
			{
				return this.oOo0O_o_.oO_o..ShowPlusMinus;
			}
			set
			{
				this.oOo0O_o_.oO_o..ShowPlusMinus = value;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x001F46F5 File Offset: 0x001F28F5
		// (set) Token: 0x06004880 RID: 18560 RVA: 0x001F4702 File Offset: 0x001F2902
		[DefaultValue(true)]
		[O_Oo00Oo000O0(3.4)]
		[DisplayName("显示节点连线")]
		[Category("外观")]
		[MergableProperty(true)]
		public bool ShowLines
		{
			get
			{
				return this.oOo0O_o_.oO_o..ShowLines;
			}
			set
			{
				this.oOo0O_o_.oO_o..ShowLines = value;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x001F4710 File Offset: 0x001F2910
		// (set) Token: 0x06004882 RID: 18562 RVA: 0x001F4718 File Offset: 0x001F2918
		[O_Oo00Oo000O0(3.5)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		[Category("外观")]
		[DisplayName("节点图标")]
		public string ImageFile
		{
			get
			{
				return this.oOo0O_o_.oO_o.;
			}
			set
			{
				if (Operators.CompareString(this.oOo0O_o_.oO_o..SelectedImageKey, this.oOo0O_o_.oO_o..ImageKey, true) == 0 && Operators.CompareString(this.o_OoO00.O0O___., "", true) == 0)
				{
					this.oOo0O_o_.oO_o..SelectedImageKey = "";
				}
				this.oOo0O_o_.oO_o..ImageKey = "";
				if (Operators.CompareString(this.oOo0O_o_.oO_o., value, true) != 0 && Operators.CompareString(this.oOo0O_o_.oO_o., "", true) > 0 && !oOO0oo_o0.o.O0o000_.(this.oOo0O_o_.oO_o., this.oOo0O_o_.oO_o..Nodes, this.oOo0O_o_.oO_o.))
				{
					this.oOo0O_o_.oO_o..ImageList.Images.RemoveByKey(this.ImageFile);
				}
				this.oOo0O_o_.oO_o. = value;
				this.SetImageKey();
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x001F47DF File Offset: 0x001F29DF
		// (set) Token: 0x06004884 RID: 18564 RVA: 0x001F47E8 File Offset: 0x001F29E8
		[Description("在选定节点处显示的图像。")]
		[O_Oo00Oo000O0(3.6)]
		[DisplayName("选定图标")]
		[Category("外观")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		public string SelectedImageFile
		{
			get
			{
				return this.o_OoO00.O0O___.;
			}
			set
			{
				if (Operators.CompareString(this.oOo0O_o_.oO_o..ImageKey, this.oOo0O_o_.oO_o..SelectedImageKey, true) == 0 && Operators.CompareString(this.oOo0O_o_.oO_o., "", true) == 0)
				{
					this.oOo0O_o_.oO_o..ImageKey = "";
				}
				this.oOo0O_o_.oO_o..SelectedImageKey = "";
				if (Operators.CompareString(this.o_OoO00.O0O___., value, true) != 0 && Operators.CompareString(this.o_OoO00.O0O___., "", true) > 0 && !oOO0oo_o0.o.O0o000_.(this.oOo0O_o_.oO_o., this.oOo0O_o_.oO_o..Nodes, this.o_OoO00.O0O___.))
				{
					this.oOo0O_o_.oO_o..ImageList.Images.RemoveByKey(this.SelectedImageFile);
				}
				this.o_OoO00.O0O___. = value;
				this.SetImageKey();
			}
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x001F48B0 File Offset: 0x001F2AB0
		private void SetImageKey()
		{
			if (Operators.CompareString(this.ImageFile, "", true) > 0 || Operators.CompareString(this.SelectedImageFile, "", true) > 0)
			{
				ImageList imageList;
				if (this.oOo0O_o_.oO_o..ImageList == null)
				{
					imageList = new ImageList();
					this.oOo0O_o_.oO_o..ImageList = imageList;
				}
				else
				{
					imageList = this.oOo0O_o_.oO_o..ImageList;
				}
				if (Operators.CompareString(this.ImageFile, "", true) > 0 && !imageList.Images.Keys.Contains(this.ImageFile))
				{
					Image image = OO_00oOO.GetImage(this.ImageFile);
					if (image != null)
					{
						imageList.Images.Add(this.ImageFile, image);
					}
				}
				if (Operators.CompareString(this.SelectedImageFile, "", true) > 0 && !imageList.Images.Keys.Contains(this.SelectedImageFile))
				{
					Image image2 = OO_00oOO.GetImage(this.SelectedImageFile);
					if (image2 != null)
					{
						imageList.Images.Add(this.SelectedImageFile, image2);
					}
				}
				if (Operators.CompareString(this.ImageFile, "", true) > 0)
				{
					this.oOo0O_o_.oO_o..ImageKey = this.ImageFile;
				}
				else if (Operators.CompareString(this.SelectedImageFile, "", true) > 0)
				{
					this.oOo0O_o_.oO_o..ImageKey = this.SelectedImageFile;
				}
				else
				{
					this.oOo0O_o_.oO_o..ImageKey = string.Empty;
				}
				if (Operators.CompareString(this.SelectedImageFile, "", true) > 0)
				{
					this.oOo0O_o_.oO_o..SelectedImageKey = this.SelectedImageFile;
				}
				else if (Operators.CompareString(this.ImageFile, "", true) > 0)
				{
					this.oOo0O_o_.oO_o..SelectedImageKey = this.ImageFile;
				}
				else
				{
					this.oOo0O_o_.oO_o..SelectedImageKey = string.Empty;
				}
				if (this.oOo0O_o_.oO_o..ImageList != null && this.oOo0O_o_.oO_o..ImageList.Images.Count == 0)
				{
					this.oOo0O_o_.oO_o..ImageList = null;
				}
			}
			else
			{
				this.oOo0O_o_.oO_o..ImageKey = string.Empty;
				this.oOo0O_o_.oO_o..SelectedImageKey = string.Empty;
				if (this.oOo0O_o_.oO_o..ImageList != null && this.oOo0O_o_.oO_o..ImageList.Images.Count == 0)
				{
					this.oOo0O_o_.oO_o..ImageList = null;
					return;
				}
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x001F4AF1 File Offset: 0x001F2CF1
		// (set) Token: 0x06004887 RID: 18567 RVA: 0x001F4B03 File Offset: 0x001F2D03
		[MergableProperty(false)]
		[OooO0(true)]
		[DisplayName("节点名称")]
		[O_Oo00Oo000O0(1.0)]
		[Category("选定节点")]
		public string NodeName
		{
			get
			{
				return this.oOo0O_o_.oO_o..SelectedNode.Name;
			}
			set
			{
				this.oOo0O_o_.oO_o..SelectedNode.Name = value;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x001F4B18 File Offset: 0x001F2D18
		// (set) Token: 0x06004889 RID: 18569 RVA: 0x001F4B48 File Offset: 0x001F2D48
		[Category("选定节点")]
		[OooO0(true)]
		[MergableProperty(false)]
		[DisplayName("节点文本")]
		[O_Oo00Oo000O0(1.8)]
		public string NodeText
		{
			get
			{
				string result;
				if (this.oOo0O_o_.oO_o..SelectedNode == null)
				{
					result = null;
				}
				else
				{
					result = this.oOo0O_o_.oO_o..SelectedNode.Text;
				}
				return result;
			}
			set
			{
				if (this.oOo0O_o_.oO_o..SelectedNode != null)
				{
					this.oOo0O_o_.oO_o..SelectedNode.Text = value;
				}
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x001F4B68 File Offset: 0x001F2D68
		// (set) Token: 0x0600488B RID: 18571 RVA: 0x001F4B7A File Offset: 0x001F2D7A
		[Category("选定节点")]
		[OooO0(true)]
		[Browsable(false)]
		[O_Oo00Oo000O0(1.9)]
		[MergableProperty(false)]
		[DisplayName("选中节点")]
		public bool NodeChecked
		{
			get
			{
				return this.oOo0O_o_.oO_o..SelectedNode.Checked;
			}
			set
			{
				this.oOo0O_o_.oO_o..SelectedNode.Checked = value;
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x0600488C RID: 18572 RVA: 0x001F4B8D File Offset: 0x001F2D8D
		// (set) Token: 0x0600488D RID: 18573 RVA: 0x001F4B9F File Offset: 0x001F2D9F
		[OooO0(true)]
		[Category("选定节点")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("节点提示")]
		public string NodeTooltip
		{
			get
			{
				return this.oOo0O_o_.oO_o..SelectedNode.ToolTipText;
			}
			set
			{
				this.oOo0O_o_.oO_o..SelectedNode.ToolTipText = value;
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x0600488E RID: 18574 RVA: 0x001F4BB2 File Offset: 0x001F2DB2
		// (set) Token: 0x0600488F RID: 18575 RVA: 0x001F4BC9 File Offset: 0x001F2DC9
		[MergableProperty(false)]
		[OooO0(true)]
		[DisplayName("节点图标")]
		[Category("选定节点")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(3.0)]
		public string NodeImageFile
		{
			get
			{
				return ((O_o__00Ooo)this.oOo0O_o_.oO_o..SelectedNode).ImageFile;
			}
			set
			{
				((O_o__00Ooo)this.oOo0O_o_.oO_o..SelectedNode).ImageFile = value;
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x001F4BE1 File Offset: 0x001F2DE1
		// (set) Token: 0x06004891 RID: 18577 RVA: 0x001F4BF8 File Offset: 0x001F2DF8
		[Description("节点处于选中状态时在该节点中显示的图像")]
		[MergableProperty(false)]
		[OooO0(true)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[DisplayName("选定图标")]
		[Category("选定节点")]
		[O_Oo00Oo000O0(4.0)]
		public string NodeSelectedImageFile
		{
			get
			{
				return ((O_o__00Ooo)this.oOo0O_o_.oO_o..SelectedNode).o0Ooo_O0oo.O__.();
			}
			set
			{
				((O_o__00Ooo)this.oOo0O_o_.oO_o..SelectedNode).O.OOO_.(value);
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x001F4C10 File Offset: 0x001F2E10
		// (set) Token: 0x06004893 RID: 18579 RVA: 0x001F4C22 File Offset: 0x001F2E22
		[MergableProperty(false)]
		[OooO0(true)]
		[DisplayName("背景颜色")]
		[Category("选定节点")]
		[O_Oo00Oo000O0(6.0)]
		public Color NodeBackColor
		{
			get
			{
				return this.oOo0O_o_.oO_o..SelectedNode.BackColor;
			}
			set
			{
				this.oOo0O_o_.oO_o..SelectedNode.BackColor = value;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x001F4C35 File Offset: 0x001F2E35
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x001F4C47 File Offset: 0x001F2E47
		[DisplayName("字体颜色")]
		[OooO0(true)]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(7.0)]
		[Category("选定节点")]
		public Color NodeForeColor
		{
			get
			{
				return this.oOo0O_o_.oO_o..SelectedNode.ForeColor;
			}
			set
			{
				this.oOo0O_o_.oO_o..SelectedNode.ForeColor = value;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x001F4C5A File Offset: 0x001F2E5A
		// (set) Token: 0x06004897 RID: 18583 RVA: 0x001F4C62 File Offset: 0x001F2E62
		[Category("事件")]
		[oO0oooo("0918")]
		[Description("选定节点后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.1)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSelectNode
		{
			get
			{
				return this.OO.o0o0OO.;
			}
			set
			{
				this.OO.o0o0OO. = value;
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x001F4C6B File Offset: 0x001F2E6B
		// (set) Token: 0x06004899 RID: 18585 RVA: 0x001F4C73 File Offset: 0x001F2E73
		[oO0oooo("0919")]
		[Description("选定节点前执行")]
		[Category("事件")]
		[O_Oo00Oo000O0(0.2)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeSelectNode
		{
			get
			{
				return this.O_o0.o0oO0o_.;
			}
			set
			{
				this.O_o0.o0oO0o_. = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x0600489A RID: 18586 RVA: 0x001F4C7C File Offset: 0x001F2E7C
		// (set) Token: 0x0600489B RID: 18587 RVA: 0x001F4C84 File Offset: 0x001F2E84
		[oO0oooo("1310")]
		[O_Oo00Oo000O0(0.3)]
		[Category("事件")]
		[Description("展开节点后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString AfterExpandNode
		{
			get
			{
				return this.o__o00o.0o.;
			}
			set
			{
				this.o__o00o.0o. = value;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x001F4C8D File Offset: 0x001F2E8D
		// (set) Token: 0x0600489D RID: 18589 RVA: 0x001F4C95 File Offset: 0x001F2E95
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("收缩节点后执行")]
		[Category("事件")]
		[oO0oooo("1310")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.31)]
		public EventString AfterCollapseNode
		{
			get
			{
				return this.O.o_000_0.;
			}
			set
			{
				this.O.o_000_0. = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x001F4C9E File Offset: 0x001F2E9E
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x001F4CA6 File Offset: 0x001F2EA6
		[Description("展开节前执行")]
		[oO0oooo("1311")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.4)]
		public EventString BeforeExpandNode
		{
			get
			{
				return this.o_o_0.o0.;
			}
			set
			{
				this.o_o_0.o0. = value;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x001F4CAF File Offset: 0x001F2EAF
		// (set) Token: 0x060048A1 RID: 18593 RVA: 0x001F4CB7 File Offset: 0x001F2EB7
		[oO0oooo("1947")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("改变节点复选框状态后执行")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.41)]
		public EventString AfterCheckNode
		{
			get
			{
				return this.Oo.OO0o.;
			}
			set
			{
				this.Oo.OO0o. = value;
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x001F4CC0 File Offset: 0x001F2EC0
		// (set) Token: 0x060048A3 RID: 18595 RVA: 0x001F4CC8 File Offset: 0x001F2EC8
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0885")]
		[O_Oo00Oo000O0(0.5)]
		[Description("单击节点后执行")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString NodeMouseClick
		{
			get
			{
				return this.oOo0O_o_.oO_o.;
			}
			set
			{
				this.oOo0O_o_.oO_o. = value;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x001F4CD1 File Offset: 0x001F2ED1
		// (set) Token: 0x060048A5 RID: 18597 RVA: 0x001F4CD9 File Offset: 0x001F2ED9
		[oO0oooo("2396")]
		[Description("编辑节点标题后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.5)]
		public EventString AfterEditNode
		{
			get
			{
				return this.o0Oo_o.__o__.;
			}
			set
			{
				this.o0Oo_o.__o__. = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x001F4CE2 File Offset: 0x001F2EE2
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x001F4CEA File Offset: 0x001F2EEA
		[oO0oooo("2404")]
		[Category("事件")]
		[O_Oo00Oo000O0(0.5)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("编辑节点标题前执行")]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeEditNode
		{
			get
			{
				return this.o._OoOO0O_.;
			}
			set
			{
				this.o._OoOO0O_. = value;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x001F4CF3 File Offset: 0x001F2EF3
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x001F4CFB File Offset: 0x001F2EFB
		[Category("事件")]
		[O_Oo00Oo000O0(0.6)]
		[Description("双击节点后执行")]
		[oO0oooo("0886")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString NodeMouseDoubleClick
		{
			get
			{
				return this.o_OoO00.O0O___.;
			}
			set
			{
				this.o_OoO00.O0O___. = value;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x001F4D04 File Offset: 0x001F2F04
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x001F4D0C File Offset: 0x001F2F0C
		[oO0oooo("0920")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.7)]
		[Description("鼠标停留在某一节点后执行")]
		[Category("事件")]
		public EventString NodeMouseHover
		{
			get
			{
				return this.o_0_.o000.;
			}
			set
			{
				this.o_0_.o000. = value;
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x001F4D18 File Offset: 0x001F2F18
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x001F4D3C File Offset: 0x001F2F3C
		[Browsable(false)]
		public string NodesSettingString
		{
			get
			{
				string result = null;
				oOO0oo_o0.O__o0o0O0O_.0.(this.oOo0O_o_.oO_o..Nodes, ref result);
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) != 0)
				{
					string[] array = value.Split(new char[]
					{
						'\f'
					});
					TreeNodeCollection nodes = this.oOo0O_o_.oO_o..Nodes;
					O_o__00Ooo o_o__00Ooo = null;
					foreach (string text in array)
					{
						if (Operators.CompareString(text, "Inner", true) == 0)
						{
							nodes = o_o__00Ooo.Nodes;
						}
						else if (Operators.CompareString(text, "Outer", true) == 0)
						{
							if (nodes[0].Parent.Parent == null)
							{
								nodes = this.oOo0O_o_.oO_o..Nodes;
							}
							else
							{
								nodes = nodes[0].Parent.Parent.Nodes;
							}
						}
						else
						{
							o_o__00Ooo = new O_o__00Ooo();
							nodes.Add(o_o__00Ooo);
							o_O_o_oOoo__.OOOO_OO._oo.(new CustomTreeNodeProperty(o_o__00Ooo), text, '\t');
						}
					}
				}
			}
		}

		// Token: 0x04001D3C RID: 7484
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x04001D3D RID: 7485
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D3E RID: 7486
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D3F RID: 7487
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D40 RID: 7488
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D41 RID: 7489
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D42 RID: 7490
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D43 RID: 7491
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D44 RID: 7492
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D45 RID: 7493
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D46 RID: 7494
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D47 RID: 7495
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D48 RID: 7496
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D49 RID: 7497
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D4A RID: 7498
		private int <<EMPTY_NAME>>;
	}
}

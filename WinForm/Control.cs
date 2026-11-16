using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Gauge;
using C1.Win.C1Input;
using C1.Win.C1Themes;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x0200026E RID: 622
	[ComVisible(true)]
	public class Control
	{
		// Token: 0x06001DE7 RID: 7655 RVA: 0x000CF2EC File Offset: 0x000CD4EC
		public Control(Control A_0, ControlTypeEnum A_1)
		{
			this.o.__O0O. = A_0;
			this.o.__O0O. = A_1;
			this.o.__O0O. = A_0.PointToClient(Control.MousePosition);
		}

		/// <summary>
		/// 返回或设置控件的绑定字段
		/// </summary>
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x000CF314 File Offset: 0x000CD514
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x000CF3AE File Offset: 0x000CD5AE
		[oO0oooo("1860")]
		public virtual string BindingField
		{
			get
			{
				if (this.o.__O0O..DataBindings.Count > 0)
				{
					Binding binding = this.o.__O0O..DataBindings[0];
					if (binding.DataSource is O_0)
					{
						return ((O_0)binding.DataSource).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField;
					}
					if (binding.DataSource == OO_00oOO.Vars.VariableTable)
					{
						return "全局变量." + binding.BindingMemberInfo.BindingField;
					}
				}
				return null;
			}
			set
			{
			}
		}

		/// <summary>
		/// 是否只读，仅对可编辑控件有效
		/// </summary>
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x000CF3B0 File Offset: 0x000CD5B0
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x000CF3B3 File Offset: 0x000CD5B3
		[oO0oooo("0749")]
		public virtual BooleanEnum ReadOnly
		{
			get
			{
				return BooleanEnum.Default;
			}
			set
			{
			}
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000CF3B5 File Offset: 0x000CD5B5
		public void RefrshReadonly()
		{
			if (this.o.__O0O. is O000O)
			{
				((O000O)this.o.__O0O.).SetReadOnlyProperty();
			}
		}

		/// <summary>
		/// 返回底层控件
		/// </summary>
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x000CF3D4 File Offset: 0x000CD5D4
		public Control BaseControl
		{
			get
			{
				return this.o.__O0O.;
			}
		}

		/// <summary>
		/// 控件名
		/// </summary>
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x000CF3DC File Offset: 0x000CD5DC
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x000CF3E9 File Offset: 0x000CD5E9
		public virtual string Name
		{
			get
			{
				return this.o.__O0O..Name;
			}
			set
			{
				this.o.__O0O..Name = value;
			}
		}

		/// <summary>
		/// 控件是否可用
		/// </summary>
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x000CF3F7 File Offset: 0x000CD5F7
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x000CF404 File Offset: 0x000CD604
		[oO0oooo("0714")]
		public bool Enabled
		{
			get
			{
				return this.o.__O0O..Enabled;
			}
			set
			{
				if (this.Form == null || this.Form.O_o_.0o0__o0O. != this.o.__O0O.)
				{
					this.o.__O0O..Enabled = value;
				}
			}
		}

		/// <summary>
		/// 控件是否可见
		/// </summary>
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x000CF42D File Offset: 0x000CD62D
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x000CF43A File Offset: 0x000CD63A
		[oO0oooo("0715")]
		public bool Visible
		{
			get
			{
				return this.o.__O0O..Visible;
			}
			set
			{
				this.o.__O0O..Visible = value;
			}
		}

		/// <summary>
		/// 控件水平位置，单位为像素。
		/// </summary>
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x000CF448 File Offset: 0x000CD648
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x000CF455 File Offset: 0x000CD655
		public int Left
		{
			get
			{
				return this.o.__O0O..Left;
			}
			set
			{
				this.o.__O0O..Left = value;
			}
		}

		/// <summary>
		/// 控件垂直位置，单位为像素。
		/// </summary>
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x000CF463 File Offset: 0x000CD663
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x000CF470 File Offset: 0x000CD670
		public int Top
		{
			get
			{
				return this.o.__O0O..Top;
			}
			set
			{
				this.o.__O0O..Top = value;
			}
		}

		/// <summary>
		/// 控件宽度，单位为像素
		/// </summary>
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x000CF47E File Offset: 0x000CD67E
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x000CF48B File Offset: 0x000CD68B
		public virtual int Width
		{
			get
			{
				return this.o.__O0O..Width;
			}
			set
			{
				this.o.__O0O..Width = value;
			}
		}

		/// <summary>
		/// 控件高度，单位为像素
		/// </summary>
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x000CF499 File Offset: 0x000CD699
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x000CF4A6 File Offset: 0x000CD6A6
		public virtual int Height
		{
			get
			{
				return this.o.__O0O..Height;
			}
			set
			{
				this.o.__O0O..Height = value;
			}
		}

		/// <summary>
		/// 锚定位置
		/// </summary>
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x000CF4B4 File Offset: 0x000CD6B4
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x000CF4C1 File Offset: 0x000CD6C1
		[oO0oooo("0701")]
		public AnchorStyles Anchor
		{
			get
			{
				return this.o.__O0O..Anchor;
			}
			set
			{
				this.o.__O0O..Anchor = value;
			}
		}

		/// <summary>
		/// 停靠位置
		/// </summary>
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x000CF4CF File Offset: 0x000CD6CF
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x000CF4DC File Offset: 0x000CD6DC
		[oO0oooo("0702")]
		public DockStyle Dock
		{
			get
			{
				return this.o.__O0O..Dock;
			}
			set
			{
				this.o.__O0O..Dock = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x000CF4EC File Offset: 0x000CD6EC
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x000CF528 File Offset: 0x000CD728
		[oO0oooo("0720")]
		public virtual Color BackColor
		{
			get
			{
				Color result;
				if (this.o.__O0O. is WebViewer)
				{
					result = ((WebViewer)this.o.__O0O.).DefaultBackgroundColor;
				}
				else
				{
					result = this.o.__O0O..BackColor;
				}
				return result;
			}
			set
			{
				if (this.o.__O0O. is C1TextBox)
				{
					((C1TextBox)this.o.__O0O.).BackColor = value;
					return;
				}
				if (this.o.__O0O. is WebViewer)
				{
					((WebViewer)this.o.__O0O.).DefaultBackgroundColor = value;
					return;
				}
				this.o.__O0O..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x000CF57F File Offset: 0x000CD77F
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x000CF58C File Offset: 0x000CD78C
		[oO0oooo("0721")]
		public virtual Color ForeColor
		{
			get
			{
				return this.o.__O0O..ForeColor;
			}
			set
			{
				this.o.__O0O..ForeColor = value;
			}
		}

		/// <summary>
		/// 字体
		/// </summary>
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x000CF59A File Offset: 0x000CD79A
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x000CF5A8 File Offset: 0x000CD7A8
		[oO0oooo("0722")]
		public Font Font
		{
			get
			{
				return this.o.__O0O..Font;
			}
			set
			{
				this.o.__O0O..Font = (Font)value.Clone();
				if (this.o.__O0O. is C1TopicBar)
				{
					C1TopicBar c1TopicBar = (C1TopicBar)this.o.__O0O.;
					c1TopicBar.PageStyle.NormalPage.NormalCaption.Font = value;
					c1TopicBar.PageStyle.NormalPage.MouseOverCaption.Font = value;
					c1TopicBar.PageStyle.NormalPage.PressedCaption.Font = value;
				}
			}
		}

		/// <summary>
		/// Tab健顺序
		/// </summary>
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x000CF626 File Offset: 0x000CD826
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x000CF633 File Offset: 0x000CD833
		public int TabIndex
		{
			get
			{
				return this.o.__O0O..TabIndex;
			}
			set
			{
				this.o.__O0O..TabIndex = value;
			}
		}

		/// <summary>
		/// 是否允许通过按Tab健将焦点移到这个控件
		/// </summary>
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000CF641 File Offset: 0x000CD841
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x000CF651 File Offset: 0x000CD851
		public bool TabStop
		{
			get
			{
				return !this.o.__O0O..TabStop;
			}
			set
			{
				this.o.__O0O..TabStop = !value;
			}
		}

		/// <summary>
		/// 是否触发Validateing事件
		/// </summary>
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x000CF662 File Offset: 0x000CD862
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x000CF66F File Offset: 0x000CD86F
		[oO0oooo("2480")]
		public bool CausesValidation
		{
			get
			{
				return this.o.__O0O..CausesValidation;
			}
			set
			{
				this.o.__O0O..CausesValidation = value;
			}
		}

		/// <summary>
		/// 是否处于最顶端
		/// </summary>
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x000CF67D File Offset: 0x000CD87D
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x000CF680 File Offset: 0x000CD880
		[oO0oooo("0723")]
		public bool TopMost
		{
			get
			{
				return false;
			}
			set
			{
				if (value)
				{
					this.BackMost = false;
					this.o.__O0O..BringToFront();
				}
			}
		}

		/// <summary>
		/// 是否处于最底端
		/// </summary>
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x000CF697 File Offset: 0x000CD897
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x000CF69A File Offset: 0x000CD89A
		[oO0oooo("0724")]
		public bool BackMost
		{
			get
			{
				return false;
			}
			set
			{
				if (value)
				{
					this.TopMost = false;
					this.o.__O0O..SendToBack();
				}
			}
		}

		/// <summary>
		/// 是否可打印
		/// </summary>
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000CF6B4 File Offset: 0x000CD8B4
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x000CF6F1 File Offset: 0x000CD8F1
		[oO0oooo("1604")]
		public bool Printable
		{
			get
			{
				bool printable;
				if (this.o.__O0O..PrintSettings.CanExtend(this.o.__O0O.))
				{
					printable = this.o.__O0O..PrintSettings.GetPrintable(this.o.__O0O.);
				}
				return printable;
			}
			set
			{
				if (this.o.__O0O..PrintSettings.CanExtend(this.o.__O0O.))
				{
					this.o.__O0O..PrintSettings.SetPrintable(this.o.__O0O., value);
				}
			}
		}

		/// <summary>
		/// 在打印此控件之前，是否另起一页
		/// </summary>
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x000CF724 File Offset: 0x000CD924
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x000CF761 File Offset: 0x000CD961
		[oO0oooo("1604")]
		public bool NewPage
		{
			get
			{
				bool newPage;
				if (this.o.__O0O..PrintSettings.CanExtend(this.o.__O0O.))
				{
					newPage = this.o.__O0O..PrintSettings.GetNewPage(this.o.__O0O.);
				}
				return newPage;
			}
			set
			{
				if (this.o.__O0O..PrintSettings.CanExtend(this.o.__O0O.))
				{
					this.o.__O0O..PrintSettings.SetNewPage(this.o.__O0O., value);
				}
			}
		}

		/// <summary>
		/// 是否打印边框
		/// </summary>
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000CF794 File Offset: 0x000CD994
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x000CF7D1 File Offset: 0x000CD9D1
		[oO0oooo("3102")]
		public bool PrintBorder
		{
			get
			{
				bool result;
				if (this.o.__O0O..PrintSettings.CanExtend(this.o.__O0O.))
				{
					result = this.o.__O0O..PrintSettings.O0O.o____o00.(this.o.__O0O.);
				}
				return result;
			}
			set
			{
				if (this.o.__O0O..PrintSettings.CanExtend(this.o.__O0O.))
				{
					this.o.__O0O..PrintSettings.O0O.o____o00.(this.o.__O0O., value);
				}
			}
		}

		/// <summary>
		/// 刷新
		/// </summary>
		// Token: 0x06001E16 RID: 7702 RVA: 0x000CF802 File Offset: 0x000CDA02
		public void Refresh()
		{
			this.o.__O0O..Refresh();
		}

		/// <summary>
		/// 控件位置
		/// </summary>
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x000CF80F File Offset: 0x000CDA0F
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x000CF81C File Offset: 0x000CDA1C
		public Point Location
		{
			get
			{
				return this.o.__O0O..Location;
			}
			set
			{
				this.o.__O0O..Location = value;
			}
		}

		/// <summary>
		/// 控件大小
		/// </summary>
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x000CF82A File Offset: 0x000CDA2A
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x000CF837 File Offset: 0x000CDA37
		public Size Size
		{
			get
			{
				return this.o.__O0O..Size;
			}
			set
			{
				this.o.__O0O..Size = value;
			}
		}

		/// <summary>
		/// 控件是否获得了焦点
		/// </summary>
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000CF845 File Offset: 0x000CDA45
		public bool Focused
		{
			get
			{
				return this.o.__O0O..Focused;
			}
		}

		/// <summary>
		/// 光标形状
		/// </summary>
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x000CF852 File Offset: 0x000CDA52
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x000CF85F File Offset: 0x000CDA5F
		public Cursor Cursor
		{
			get
			{
				return this.o.__O0O..Cursor;
			}
			set
			{
				if (!(this.o.__O0O. is WebBrowser))
				{
					this.o.__O0O..Cursor = value;
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000CF87A File Offset: 0x000CDA7A
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x000CF887 File Offset: 0x000CDA87
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CursorEnum CursorType
		{
			get
			{
				return ooO.OO_oOO0O.O00.(this.Cursor);
			}
			set
			{
				this.Cursor = ooO.OO_oOO0O.O00.(value);
			}
		}

		/// <summary>
		/// 动态提示内容
		/// </summary>
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000CF898 File Offset: 0x000CDA98
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x000CF8D8 File Offset: 0x000CDAD8
		[oO0oooo("1282")]
		public string ToolTip
		{
			get
			{
				string toolTip;
				if (this.o.__O0O..FindForm() != null)
				{
					toolTip = this.Form.Pane.ToolTip1.GetToolTip(this.o.__O0O.);
				}
				else
				{
					toolTip = this.o.__O0O.;
				}
				return toolTip;
			}
			set
			{
				this.o.__O0O. = value;
				if (this.o.__O0O..FindForm() != null)
				{
					this.Form.Pane.ToolTip1.SetToolTip(this.o.__O0O., value);
				}
			}
		}

		/// <summary>
		/// 错误提示内容
		/// </summary>
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x000CF90C File Offset: 0x000CDB0C
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x000CF94C File Offset: 0x000CDB4C
		[oO0oooo("2676")]
		public string Error
		{
			get
			{
				string error;
				if (this.o.__O0O..FindForm() != null)
				{
					error = this.Form.Pane.ErrorProvider1.GetError(this.o.__O0O.);
				}
				else
				{
					error = this.o.__O0O.;
				}
				return error;
			}
			set
			{
				this.o.__O0O. = value;
				if (this.o.__O0O..FindForm() != null)
				{
					this.Form.Pane.ErrorProvider1.SetError(this.o.__O0O., value);
				}
			}
		}

		/// <summary>
		/// 在此控件位置显示一个提示信息，直到执行HideToolTip方法，否则这个提示信息会一直显示
		/// </summary>
		/// <param name="info">要提示的信息</param>
		/// <param name="duration">设置显示持续的时间，单位为毫秒，如果省略，则一直显示，直到执行HideToolTip方法</param>
		// Token: 0x06001E24 RID: 7716 RVA: 0x000CF980 File Offset: 0x000CDB80
		[oO0oooo("2686")]
		public void ShowToolTip(string info, int duration = -1)
		{
			if (duration <= 0)
			{
				this.Form.Pane.ToolTip1.Show(info, this.BaseControl, this.BaseControl.ClientSize.Width, this.BaseControl.ClientSize.Height);
				return;
			}
			this.Form.Pane.ToolTip1.Show(info, this.BaseControl, duration);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x000CF9F4 File Offset: 0x000CDBF4
		public void ShowToolTip(string info, int X, int Y, int duration = -1)
		{
			if (duration <= 0)
			{
				this.Form.Pane.ToolTip1.Show(info, this.BaseControl, X, Y);
				return;
			}
			this.Form.Pane.ToolTip1.Show(info, this.BaseControl, X, Y, duration);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000CFA45 File Offset: 0x000CDC45
		public void ShowToolTip(string info, Point location, int duration = -1)
		{
			this.ShowToolTip(info, location.X, location.Y, duration);
		}

		/// <summary>
		/// 隐藏此控件的提示信息
		/// </summary>
		// Token: 0x06001E27 RID: 7719 RVA: 0x000CFA5D File Offset: 0x000CDC5D
		[oO0oooo("2688")]
		public void HideToolTip()
		{
			this.Form.Pane.ToolTip1.Hide(this.BaseControl);
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000CFA7A File Offset: 0x000CDC7A
		internal string ToolTipText
		{
			get
			{
				return this.o.__O0O.;
			}
		}

		/// <summary>
		/// 将焦点移到此控件
		/// </summary>
		// Token: 0x06001E29 RID: 7721 RVA: 0x000CFA84 File Offset: 0x000CDC84
		[oO0oooo("0729")]
		public void Select()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o.__O0O..Select();
				IL_14:
				num2 = 3;
				if (!this.o.__O0O..CanFocus)
				{
					goto IL_31;
				}
				IL_23:
				num2 = 4;
				this.o.__O0O..Focus();
				IL_31:
				goto IL_94;
				IL_33:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_55:
				goto IL_89;
				IL_57:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_67:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_57;
			}
			IL_89:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_94:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 将控件中的内容写入到绑定字段或者变量中
		/// </summary>
		// Token: 0x06001E2A RID: 7722 RVA: 0x000CFB40 File Offset: 0x000CDD40
		[oO0oooo("0731")]
		public void WriteValue()
		{
			if (this.o.__O0O..DataBindings.Count > 0 && this.o.__O0O..DataBindings[0].BindingManagerBase.Count > 0)
			{
				DataRowView dataRowView = (DataRowView)this.o.__O0O..DataBindings[0].BindingManagerBase.Current;
				if (this.o.__O0O. is C1TextBox)
				{
					string text = dataRowView[this.o.__O0O..DataBindings[0].BindingMemberInfo.BindingField].ToString();
					C1TextBox c1TextBox = (C1TextBox)this.o.__O0O.;
					if (!c1TextBox.UpdateValueWithCurrentText())
					{
						return;
					}
					if (c1TextBox.Value == null)
					{
						if (Operators.CompareString(text, "", true) == 0)
						{
							return;
						}
					}
					else if (Operators.CompareString(c1TextBox.Value.ToString(), text, true) == 0)
					{
						return;
					}
				}
				this.o.__O0O..DataBindings[0].WriteValue();
				dataRowView.EndEdit();
			}
		}

		/// <summary>
		/// 从绑定字段或者变量中读取数据到控件中
		/// </summary>
		// Token: 0x06001E2B RID: 7723 RVA: 0x000CFC39 File Offset: 0x000CDE39
		[oO0oooo("0730")]
		public void ReadValue()
		{
			if (this.o.__O0O..DataBindings.Count > 0)
			{
				this.o.__O0O..DataBindings[0].ReadValue();
			}
		}

		/// <summary>
		/// 获取绑定的Table
		/// </summary>
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x000CFC64 File Offset: 0x000CDE64
		[oO0oooo("1523")]
		public Table BindTable
		{
			get
			{
				if (this.o.__O0O..DataBindings.Count > 0)
				{
					Binding binding = this.o.__O0O..DataBindings[0];
					if (!(this.o.__O0O..DataBindings[0].DataSource is O_0))
					{
						return null;
					}
					string text = ((O_0)this.o.__O0O..DataBindings[0].DataSource).Oo._Oo0OO.();
					if (OO_00oOO.Tables.get_Contains(text))
					{
						return OO_00oOO.Tables[text];
					}
				}
				return null;
			}
		}

		/// <summary>
		/// 如果已经绑定到Table，可以通过此属性获取当前Row
		/// </summary>
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x000CFCF8 File Offset: 0x000CDEF8
		public Row BindRow
		{
			get
			{
				if (this.o.__O0O..DataBindings.Count > 0)
				{
					if (!(this.o.__O0O..DataBindings[0].DataSource is O_0))
					{
						return null;
					}
					string text = ((O_0)this.o.__O0O..DataBindings[0].DataSource).Oo._Oo0OO.();
					if (OO_00oOO.Tables.get_Contains(text))
					{
						return OO_00oOO.Tables[text].Current;
					}
				}
				return null;
			}
		}

		/// <summary>
		/// 如果已经绑定到Table，可以通过此属性获取绑定的Col
		/// </summary>
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x000CFD80 File Offset: 0x000CDF80
		public Col BindCol
		{
			get
			{
				if (this.o.__O0O..DataBindings.Count > 0)
				{
					BindingMemberInfo bindingMemberInfo = this.o.__O0O..DataBindings[0].BindingMemberInfo;
					if (!(this.o.__O0O..DataBindings[0].DataSource is O_0))
					{
						return null;
					}
					string text = ((O_0)this.o.__O0O..DataBindings[0].DataSource).Oo._Oo0OO.();
					if (OO_00oOO.Tables.get_Contains(text) && OO_00oOO.Tables[text].Cols.Contains(bindingMemberInfo.BindingField))
					{
						return OO_00oOO.Tables[text].Cols[bindingMemberInfo.BindingField];
					}
					bindingMemberInfo = default(BindingMemberInfo);
				}
				return null;
			}
		}

		/// <summary>
		/// 设置控件位置和大小
		/// </summary>
		/// <param name="x">水平位置</param>
		/// <param name="y">垂直位置</param>
		/// <param name="Width">宽度</param>
		/// <param name="Height">高度</param>
		// Token: 0x06001E2F RID: 7727 RVA: 0x000CFE51 File Offset: 0x000CE051
		[oO0oooo("0823")]
		public void SetBounds(int x, int y, int Width, int Height)
		{
			this.o.__O0O..SetBounds(x, y, Width, Height);
		}

		/// <summary>
		/// 设置控件的中文输入法状态
		/// </summary>
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x000CFE64 File Offset: 0x000CE064
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x000CFE94 File Offset: 0x000CE094
		[oO0oooo("1863")]
		public BooleanEnum ImeMode
		{
			get
			{
				ImeMode imeMode = this.o.__O0O..ImeMode;
				BooleanEnum result;
				if (imeMode != System.Windows.Forms.ImeMode.On)
				{
					if (imeMode != System.Windows.Forms.ImeMode.Close)
					{
						result = BooleanEnum.Default;
					}
					else
					{
						result = BooleanEnum.False;
					}
				}
				else
				{
					result = BooleanEnum.True;
				}
				return result;
			}
			set
			{
				switch (value)
				{
				case BooleanEnum.Default:
					this.o.__O0O..ImeMode = System.Windows.Forms.ImeMode.NoControl;
					return;
				case BooleanEnum.True:
					this.o.__O0O..ImeMode = System.Windows.Forms.ImeMode.On;
					return;
				case BooleanEnum.False:
					this.o.__O0O..ImeMode = System.Windows.Forms.ImeMode.Close;
					return;
				default:
					return;
				}
			}
		}

		/// <summary>
		/// 控件所在的窗口
		/// </summary>
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x000CFEE0 File Offset: 0x000CE0E0
		public Form Form
		{
			get
			{
				Form result;
				if (this.o.__O0O. != null)
				{
					result = this.o.__O0O.;
				}
				else
				{
					Control parent = this.o.__O0O.;
					for (;;)
					{
						parent = parent.Parent;
						if (parent is FormPanel)
						{
							break;
						}
						if (parent == null)
						{
							goto Block_4;
						}
					}
					if (OO_00oOO.Forms.Contains(parent.Name))
					{
						return OO_00oOO.Forms[parent.Name];
					}
					return null;
					Block_4:
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 获取父控件
		/// </summary>
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000CFF44 File Offset: 0x000CE144
		public object Parent
		{
			get
			{
				object result;
				if (this.o.__O0O..Parent is TabPage || this.o.__O0O..Parent is NavPage)
				{
					result = this.o.__O0O..Parent;
				}
				else if (this.o.__O0O..Parent is SplitterPanel)
				{
					result = new SplitPanel((SplitterPanel)this.o.__O0O..Parent);
				}
				else if (this.o.__O0O..Parent is FormPanel)
				{
					result = this.Form;
				}
				else if (this.o.__O0O..Parent.Parent != null && this.o.__O0O..Parent.Parent is CustomPictureBox)
				{
					result = new PictureBox((CustomPictureBox)this.o.__O0O..Parent.Parent);
				}
				else if (this.o.__O0O..Parent is GroupBox || this.o.__O0O..Parent is Panel || this.o.__O0O..Parent is C1Gauge)
				{
					result = ooO_0O.o_O0.O_.(this.o.__O0O..Parent);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 设置控件的快捷菜单
		/// </summary>
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x000D0064 File Offset: 0x000CE264
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x000D009A File Offset: 0x000CE29A
		[oO0oooo("3116")]
		public Strip ContextStrip
		{
			get
			{
				Strip result;
				if (this.o.__O0O..ContextMenuStrip != null)
				{
					result = new Strip(this.o.__O0O..ContextMenuStrip, this.o.__O0O.);
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.o.__O0O..ContextMenuStrip = null;
					return;
				}
				if (value.BaseControl is ContextMenuStrip)
				{
					this.o.__O0O..ContextMenuStrip = (ContextMenuStrip)value.BaseControl;
				}
			}
		}

		/// <summary>
		/// 在该控件的指定位置显示指定的快捷菜单
		/// </summary>
		/// <param name="x">水平位置</param>
		/// <param name="y">垂直位置</param>
		/// <param name="Strip">要显示的快捷菜单</param>
		// Token: 0x06001E36 RID: 7734 RVA: 0x000D00CF File Offset: 0x000CE2CF
		[oO0oooo("3116")]
		public void ShowContextStrip(int x, int y, Strip Strip)
		{
			if (Strip.BaseControl is ContextMenuStrip)
			{
				((ContextMenuStrip)Strip.BaseControl).Show(this.BaseControl, x, y);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x000D00F8 File Offset: 0x000CE2F8
		public Point MousePosition
		{
			get
			{
				return this.o.__O0O.;
			}
		}

		/// <summary>
		/// 设置控件样式
		/// </summary>
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x000D0100 File Offset: 0x000CE300
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x000D0130 File Offset: 0x000CE330
		[oO0oooo("3305")]
		public string Theme
		{
			get
			{
				string result;
				if (C1ThemeController.IsObjectThemeable(this.BaseControl))
				{
					result = Main.OO_O.o..o0_o_o_0.0O.(this.BaseControl);
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (C1ThemeController.IsObjectThemeable(this.BaseControl))
				{
					if (this.BaseControl is SplitContainer)
					{
						SplitContainer splitContainer = (SplitContainer)this.BaseControl;
						bool flag = splitContainer.BackColor == splitContainer.Panel1.BackColor;
						bool flag2 = splitContainer.BackColor == splitContainer.Panel2.BackColor;
						Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
						{
							this.BaseControl
						});
						if (flag)
						{
							splitContainer.Panel1.BackColor = splitContainer.BackColor;
						}
						if (flag2)
						{
							splitContainer.Panel2.BackColor = splitContainer.BackColor;
							return;
						}
					}
					else
					{
						Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
						{
							this.BaseControl
						});
						if (this.BaseControl is C1DockingTab)
						{
							((C1DockingTab)this.BaseControl).TabSizeMode = TabSizeModeEnum.Normal;
						}
						if (this.BaseControl is C1Button)
						{
							C1Button c1Button = (C1Button)this.BaseControl;
							if (Operators.CompareString(value, "(none)", true) == 0)
							{
								if (c1Button.FlatStyle != FlatStyle.Flat)
								{
									c1Button.FlatStyle = FlatStyle.Flat;
									return;
								}
							}
							else if (c1Button.FlatStyle != FlatStyle.Standard)
							{
								c1Button.FlatStyle = FlatStyle.Standard;
							}
						}
					}
				}
			}
		}

		// Token: 0x04000CB9 RID: 3257
		private Control <<EMPTY_NAME>>;

		// Token: 0x04000CBA RID: 3258
		internal ControlTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000CBB RID: 3259
		private string <<EMPTY_NAME>>;

		// Token: 0x04000CBC RID: 3260
		internal Form <<EMPTY_NAME>>;

		// Token: 0x04000CBD RID: 3261
		private Point <<EMPTY_NAME>>;
	}
}

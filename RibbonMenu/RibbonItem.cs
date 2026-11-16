using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000008 RID: 8
	[oO0oooo("1100")]
	[ComVisible(true)]
	public class RibbonItem
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000254F File Offset: 0x0000074F
		internal RibbonItem(RibbonItem A_0)
		{
			this.oOo_.0o_O_O_0. = A_0;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000255E File Offset: 0x0000075E
		public RibbonItem()
		{
			this.oOo_.0o_O_O_0. = null;
		}

		/// <summary>
		/// 组件名称
		/// </summary>
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000256D File Offset: 0x0000076D
		public string Name
		{
			get
			{
				return this.oOo_.0o_O_O_0..ID;
			}
		}

		/// <summary>
		/// 字符型，返回或设置组件的附加信息
		/// </summary>
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000257A File Offset: 0x0000077A
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002587 File Offset: 0x00000787
		public string UserData
		{
			get
			{
				return this.oOo_.0o_O_O_0..Description;
			}
			set
			{
				this.oOo_.0o_O_O_0..Description = value;
			}
		}

		/// <summary>
		/// 返回或者设置组件是否可用
		/// </summary>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002595 File Offset: 0x00000795
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000025A2 File Offset: 0x000007A2
		public virtual bool Enabled
		{
			get
			{
				return this.oOo_.0o_O_O_0..Enabled;
			}
			set
			{
				this.oOo_.0o_O_O_0..Enabled = value;
			}
		}

		/// <summary>
		/// 返回或者设置组件的大图标
		/// </summary>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000025BD File Offset: 0x000007BD
		public Image LargeImage
		{
			get
			{
				return this.oOo_.0o_O_O_0..LargeImage;
			}
			set
			{
				this.oOo_.0o_O_O_0..LargeImage = value;
			}
		}

		/// <summary>
		/// 返回或者设置组件的小图标
		/// </summary>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000025CB File Offset: 0x000007CB
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000025D8 File Offset: 0x000007D8
		public Image SmallImage
		{
			get
			{
				return this.oOo_.0o_O_O_0..SmallImage;
			}
			set
			{
				this.oOo_.0o_O_O_0..SmallImage = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000025E6 File Offset: 0x000007E6
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000025F3 File Offset: 0x000007F3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color ForeColor
		{
			get
			{
				return this.oOo_.0o_O_O_0..ForeColorInner;
			}
			set
			{
				this.oOo_.0o_O_O_0..ForeColorInner = value;
				this.oOo_.0o_O_O_0..ForeColorOuter = value;
			}
		}

		/// <summary>
		/// 设置标题和图标的相对位置
		/// </summary>
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002643 File Offset: 0x00000843
		public TextImageRelationEnum TextImageRelation
		{
			get
			{
				TextImageRelationEnum result;
				if (this.oOo_.0o_O_O_0..TextImageRelation == C1.Win.C1Ribbon.TextImageRelation.Automatic)
				{
					result = TextImageRelationEnum.Automatic;
				}
				else if (this.oOo_.0o_O_O_0..TextImageRelation == C1.Win.C1Ribbon.TextImageRelation.ImageAboveText)
				{
					result = TextImageRelationEnum.ImageAboveText;
				}
				else
				{
					result = TextImageRelationEnum.ImageBeforeText;
				}
				return result;
			}
			set
			{
				if (value == TextImageRelationEnum.Automatic)
				{
					this.oOo_.0o_O_O_0..TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.Automatic;
					return;
				}
				if (value == TextImageRelationEnum.ImageAboveText)
				{
					this.oOo_.0o_O_O_0..TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText;
					return;
				}
				this.oOo_.0o_O_O_0..TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageBeforeText;
			}
		}

		/// <summary>
		/// 返回或者设置组件的提示内容
		/// </summary>
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002672 File Offset: 0x00000872
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000267F File Offset: 0x0000087F
		public string ToolTip
		{
			get
			{
				return this.oOo_.0o_O_O_0..ToolTip;
			}
			set
			{
				this.oOo_.0o_O_O_0..ToolTip = value;
			}
		}

		/// <summary>
		/// 返回或者设置组件是否可见
		/// </summary>
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000268D File Offset: 0x0000088D
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000269A File Offset: 0x0000089A
		public virtual bool Visible
		{
			get
			{
				return this.oOo_.0o_O_O_0..Visible;
			}
			set
			{
				this.oOo_.0o_O_O_0..Visible = value;
			}
		}

		/// <summary>
		/// 是否允许自动隐藏标题
		/// </summary>
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000026A8 File Offset: 0x000008A8
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000026B8 File Offset: 0x000008B8
		public bool AutoHideText
		{
			get
			{
				return this.oOo_.0o_O_O_0..SupportedGroupSizing == SupportedGroupSizing.Any;
			}
			set
			{
				if (value)
				{
					this.oOo_.0o_O_O_0..SupportedGroupSizing = SupportedGroupSizing.Any;
					return;
				}
				this.oOo_.0o_O_O_0..SupportedGroupSizing = SupportedGroupSizing.TextAlwaysVisible;
			}
		}

		// Token: 0x0400000E RID: 14
		internal RibbonItem <<EMPTY_NAME>>;
	}
}

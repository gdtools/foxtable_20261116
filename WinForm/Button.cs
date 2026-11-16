using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 按钮
	/// </summary>
	// Token: 0x02000519 RID: 1305
	[ComVisible(true)]
	public class Button : Control
	{
		// Token: 0x06005683 RID: 22147 RVA: 0x0025B0E6 File Offset: 0x002592E6
		public Button(C1Button A_0) : base(A_0, ControlTypeEnum.Button)
		{
			this.oo._00. = A_0;
		}

		/// <summary>
		/// 按钮标题
		/// </summary>
		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x0025B0F7 File Offset: 0x002592F7
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x0025B104 File Offset: 0x00259304
		public string Text
		{
			get
			{
				return this.oo._00..Text;
			}
			set
			{
				this.oo._00..Text = value;
			}
		}

		/// <summary>
		/// 按钮标题的对齐方式
		/// </summary>
		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x0025B112 File Offset: 0x00259312
		// (set) Token: 0x06005687 RID: 22151 RVA: 0x0025B11F File Offset: 0x0025931F
		[oO0oooo("1855")]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.oo._00..TextAlign;
			}
			set
			{
				this.oo._00..TextAlign = value;
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x0025B12D File Offset: 0x0025932D
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x0025B130 File Offset: 0x00259330
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ImageFile
		{
			get
			{
				return null;
			}
			set
			{
				this.oo._00..Image = OO_00oOO.GetImage(value);
			}
		}

		/// <summary>
		/// 按钮图片对齐方式
		/// </summary>
		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x0025B143 File Offset: 0x00259343
		// (set) Token: 0x0600568B RID: 22155 RVA: 0x0025B150 File Offset: 0x00259350
		[oO0oooo("1856")]
		public ContentAlignment ImageAlign
		{
			get
			{
				return this.oo._00..ImageAlign;
			}
			set
			{
				this.oo._00..ImageAlign = value;
			}
		}

		/// <summary>
		/// 标题和图片的相对位置
		/// </summary>
		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x0025B15E File Offset: 0x0025935E
		// (set) Token: 0x0600568D RID: 22157 RVA: 0x0025B16B File Offset: 0x0025936B
		[oO0oooo("1857")]
		public TextImageRelation TextImageRelation
		{
			get
			{
				return this.oo._00..TextImageRelation;
			}
			set
			{
				this.oo._00..TextImageRelation = value;
			}
		}

		/// <summary>
		/// 按钮图片
		/// </summary>
		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x0025B179 File Offset: 0x00259379
		// (set) Token: 0x0600568F RID: 22159 RVA: 0x0025B186 File Offset: 0x00259386
		[oO0oooo("0772")]
		public Image Image
		{
			get
			{
				return this.oo._00..Image;
			}
			set
			{
				this.oo._00..Image = value;
			}
		}

		/// <summary>
		/// 按钮外观
		/// </summary>
		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06005690 RID: 22160 RVA: 0x0025B194 File Offset: 0x00259394
		// (set) Token: 0x06005691 RID: 22161 RVA: 0x0025B1A2 File Offset: 0x002593A2
		[oO0oooo("1858")]
		public FlatStyle FlatStyle
		{
			get
			{
				FlatStyle result;
				return result;
			}
			set
			{
			}
		}

		/// <summary>
		/// 按钮样式
		/// </summary>
		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x0025B1A4 File Offset: 0x002593A4
		// (set) Token: 0x06005693 RID: 22163 RVA: 0x0025B1B2 File Offset: 0x002593B2
		[oO0oooo("3093")]
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

		/// <summary>
		/// 边框宽度
		/// </summary>
		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x0025B1B4 File Offset: 0x002593B4
		// (set) Token: 0x06005695 RID: 22165 RVA: 0x0025B1C6 File Offset: 0x002593C6
		public int BorderSize
		{
			get
			{
				return this.oo._00..FlatAppearance.BorderSize;
			}
			set
			{
				this.oo._00..FlatAppearance.BorderSize = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x0025B1D9 File Offset: 0x002593D9
		// (set) Token: 0x06005697 RID: 22167 RVA: 0x0025B1EB File Offset: 0x002593EB
		public Color BorderColor
		{
			get
			{
				return this.oo._00..FlatAppearance.BorderColor;
			}
			set
			{
				this.oo._00..FlatAppearance.BorderColor = value;
			}
		}

		/// <summary>
		/// 鼠标按下时的背景颜色
		/// </summary>
		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06005698 RID: 22168 RVA: 0x0025B1FE File Offset: 0x002593FE
		// (set) Token: 0x06005699 RID: 22169 RVA: 0x0025B210 File Offset: 0x00259410
		public Color MouseDownBackColor
		{
			get
			{
				return this.oo._00..FlatAppearance.MouseDownBackColor;
			}
			set
			{
				this.oo._00..FlatAppearance.MouseDownBackColor = value;
			}
		}

		/// <summary>
		/// 鼠标经过时的背景颜色
		/// </summary>
		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x0600569A RID: 22170 RVA: 0x0025B223 File Offset: 0x00259423
		// (set) Token: 0x0600569B RID: 22171 RVA: 0x0025B235 File Offset: 0x00259435
		[oO0oooo("2309")]
		public Color MouseOverBackColor
		{
			get
			{
				return this.oo._00..FlatAppearance.MouseOverBackColor;
			}
			set
			{
				this.oo._00..FlatAppearance.MouseOverBackColor = value;
			}
		}

		/// <summary>
		/// 模拟单击此按钮
		/// </summary>
		// Token: 0x0600569C RID: 22172 RVA: 0x0025B248 File Offset: 0x00259448
		[oO0oooo("2309")]
		public void PerformClick()
		{
			this.o.__O0O..o0_0OO0._O.(this.oo._00., new EventArgs());
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x0025B260 File Offset: 0x00259460
		// (set) Token: 0x0600569E RID: 22174 RVA: 0x0025B26D File Offset: 0x0025946D
		public override Color ForeColor
		{
			get
			{
				return this.oo._00..ForeColor;
			}
			set
			{
				this.oo._00..ForeColor = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600569F RID: 22175 RVA: 0x0025B27B File Offset: 0x0025947B
		// (set) Token: 0x060056A0 RID: 22176 RVA: 0x0025B288 File Offset: 0x00259488
		public override Color BackColor
		{
			get
			{
				return this.oo._00..BackColor;
			}
			set
			{
				this.oo._00..BackColor = value;
			}
		}

		// Token: 0x040022CA RID: 8906
		private C1Button <<EMPTY_NAME>>;
	}
}

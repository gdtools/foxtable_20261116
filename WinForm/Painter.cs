using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.My;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 绘图板
	/// </summary>
	// Token: 0x02000530 RID: 1328
	[oO0oooo("1481")]
	[ComVisible(true)]
	public class Painter : Control
	{
		// Token: 0x0600588D RID: 22669 RVA: 0x0025EDFD File Offset: 0x0025CFFD
		internal Painter(O_oo A_0) : base(A_0, ControlTypeEnum.Painter)
		{
			this.o.oO_oo_O. = A_0;
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x0025EE0F File Offset: 0x0025D00F
		// (set) Token: 0x0600588F RID: 22671 RVA: 0x0025EE1C File Offset: 0x0025D01C
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o.oO_oo_O..BorderStyle;
			}
			set
			{
				this.o.oO_oo_O..BorderStyle = value;
			}
		}

		/// <summary>
		/// 是否自动出现滚动条
		/// </summary>
		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06005890 RID: 22672 RVA: 0x0025EE2A File Offset: 0x0025D02A
		// (set) Token: 0x06005891 RID: 22673 RVA: 0x0025EE37 File Offset: 0x0025D037
		public bool AutoScroll
		{
			get
			{
				return this.o.oO_oo_O..AutoScroll;
			}
			set
			{
				this.o.oO_oo_O..AutoScroll = value;
			}
		}

		/// <summary>
		/// 扩展尺寸
		/// </summary>
		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x0025EE45 File Offset: 0x0025D045
		// (set) Token: 0x06005893 RID: 22675 RVA: 0x0025EE52 File Offset: 0x0025D052
		public Size ExtendSize
		{
			get
			{
				return this.o.oO_oo_O..AutoScrollMinSize;
			}
			set
			{
				this.o.oO_oo_O..AutoScrollMinSize = value;
			}
		}

		/// <summary>
		/// 获取绘图板的Graphics对象
		/// </summary>
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x0025EE60 File Offset: 0x0025D060
		[oO0oooo("1482")]
		public Graphics Graphics
		{
			get
			{
				Graphics result;
				if (this.o.oO_oo_O. != null)
				{
					result = this.o.oO_oo_O.;
				}
				else
				{
					if (this.o.oO_oo_O..o.oO00_.() == null)
					{
						if (this.o.oO_oo_O..AutoScrollMinSize.IsEmpty)
						{
							this.o.oO_oo_O..o.oO00_.(new Bitmap(this.o.oO_oo_O..ClientSize.Width, this.o.oO_oo_O..ClientSize.Height));
						}
						else
						{
							this.o.oO_oo_O..o.oO00_.(new Bitmap(this.o.oO_oo_O..AutoScrollMinSize.Width, this.o.oO_oo_O..AutoScrollMinSize.Height));
						}
					}
					this.o.oO_oo_O. = Graphics.FromImage(this.o.oO_oo_O..o.oO00_.());
					this.o.oO_oo_O..SmoothingMode = SmoothingMode.AntiAlias;
					this.o.oO_oo_O..TextRenderingHint = TextRenderingHint.AntiAlias;
					result = this.o.oO_oo_O.;
				}
				return result;
			}
		}

		/// <summary>
		/// 显示绘制好的图形
		/// </summary>
		// Token: 0x06005895 RID: 22677 RVA: 0x0025EF4A File Offset: 0x0025D14A
		public void Repaint()
		{
			this.o.oO_oo_O..BackgroundImage = null;
			if (this.o.oO_oo_O..o.oO00_.() != null)
			{
				this.o.oO_oo_O..BackgroundImage = this.o.oO_oo_O..o.oO00_.();
			}
		}

		/// <summary>
		/// 保存绘制好的图形
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x06005896 RID: 22678 RVA: 0x0025EF7B File Offset: 0x0025D17B
		public void Save(string FileName)
		{
			if (this.o.oO_oo_O..o.oO00_.() != null)
			{
				this.o.oO_oo_O..o.oO00_.().Save(FileName, O_O0OO.OoO_00._.(FileName));
			}
		}

		/// <summary>
		/// 获取绘图板中的图片
		/// </summary>
		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x0025EFA4 File Offset: 0x0025D1A4
		public Image Image
		{
			get
			{
				Image result;
				if (this.o.oO_oo_O..o.oO00_.() != null)
				{
					result = this.o.oO_oo_O..o.oO00_.();
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 将绘制好的图形复制到剪贴板
		/// </summary>
		// Token: 0x06005898 RID: 22680 RVA: 0x0025EFCF File Offset: 0x0025D1CF
		public void Copy()
		{
			c.OOOOO.o.().Clipboard.SetImage(this.Image);
		}

		// Token: 0x0400230B RID: 8971
		private O_oo <<EMPTY_NAME>>;

		// Token: 0x0400230C RID: 8972
		private Graphics <<EMPTY_NAME>>;
	}
}

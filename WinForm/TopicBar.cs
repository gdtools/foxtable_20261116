using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Command;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 任务栏
	/// </summary>
	// Token: 0x0200053B RID: 1339
	[ComVisible(true)]
	public class TopicBar : Control
	{
		// Token: 0x060059D2 RID: 22994 RVA: 0x00260CDC File Offset: 0x0025EEDC
		internal TopicBar(Oo_ A_0) : base(A_0, ControlTypeEnum.TopicBar)
		{
			this.o.OOoo. = A_0;
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x060059D3 RID: 22995 RVA: 0x00260CED File Offset: 0x0025EEED
		// (set) Token: 0x060059D4 RID: 22996 RVA: 0x00260CF0 File Offset: 0x0025EEF0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Setting
		{
			get
			{
				return null;
			}
			set
			{
				oOO0oo_o0.O.ooooo.(this.o.OOoo., value);
			}
		}

		/// <summary>
		/// 页面集合
		/// </summary>
		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x060059D5 RID: 22997 RVA: 0x00260CFE File Offset: 0x0025EEFE
		[oO0oooo("0841")]
		public TopicPageCollection Pages
		{
			get
			{
				if (this.a == null)
				{
					this.a = new TopicPageCollection(this.o.OOoo.);
				}
				return this.a;
			}
		}

		/// <summary>
		/// 页面展开方式
		/// </summary>
		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x00260D1F File Offset: 0x0025EF1F
		// (set) Token: 0x060059D7 RID: 22999 RVA: 0x00260D32 File Offset: 0x0025EF32
		public bool Animation
		{
			get
			{
				return this.o.OOoo..Animation != C1AnimationEnum.Off;
			}
			set
			{
				if (value)
				{
					this.o.OOoo..Animation = C1AnimationEnum.System;
					return;
				}
				this.o.OOoo..Animation = C1AnimationEnum.Off;
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x00260D50 File Offset: 0x0025EF50
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x00260D5E File Offset: 0x0025EF5E
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

		// Token: 0x04002331 RID: 9009
		private Oo_ <<EMPTY_NAME>>;

		// Token: 0x04002332 RID: 9010
		private TopicPageCollection a;
	}
}

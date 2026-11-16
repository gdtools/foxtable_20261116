using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml;
using C1.Win.C1GanttView;

namespace Foxtable.WinForm
{
	// Token: 0x02000509 RID: 1289
	[ComVisible(true)]
	public class GanttView : Control
	{
		// Token: 0x06005411 RID: 21521 RVA: 0x00257131 File Offset: 0x00255331
		public GanttView(GanttView A_0) : base(A_0, ControlTypeEnum.GanttView)
		{
			this.o_.ooOO_. = A_0;
		}

		// Token: 0x17001277 RID: 4727
		// (set) Token: 0x06005412 RID: 21522 RVA: 0x00257144 File Offset: 0x00255344
		[Browsable(false)]
		public string Settings
		{
			set
			{
				((ISupportInitialize)this.o_.ooOO_.).BeginInit();
				this.o_.ooOO_..BeginUpdate();
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(value);
				((GanttView)base.BaseControl).LoadXml(xmlDocument);
				this.o_.ooOO_..EndUpdate();
				((ISupportInitialize)this.o_.ooOO_.).EndInit();
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06005413 RID: 21523 RVA: 0x0025719B File Offset: 0x0025539B
		public C1GanttView GanttView
		{
			get
			{
				return (C1GanttView)base.BaseControl;
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06005414 RID: 21524 RVA: 0x002571A8 File Offset: 0x002553A8
		// (set) Token: 0x06005415 RID: 21525 RVA: 0x002571B5 File Offset: 0x002553B5
		public Color GridForeColor
		{
			get
			{
				return this.o_.ooOO_..GridForeColor;
			}
			set
			{
				this.o_.ooOO_..GridForeColor = value;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x002571C3 File Offset: 0x002553C3
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x002571D0 File Offset: 0x002553D0
		public Color FixedForeColor
		{
			get
			{
				return this.o_.ooOO_..FixedForeColor;
			}
			set
			{
				this.o_.ooOO_..FixedForeColor = value;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x002571DE File Offset: 0x002553DE
		// (set) Token: 0x06005419 RID: 21529 RVA: 0x002571EB File Offset: 0x002553EB
		public Color FixedBackColor
		{
			get
			{
				return this.o_.ooOO_..FixedBackColor;
			}
			set
			{
				this.o_.ooOO_..FixedBackColor = value;
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x0600541A RID: 21530 RVA: 0x002571F9 File Offset: 0x002553F9
		// (set) Token: 0x0600541B RID: 21531 RVA: 0x00257206 File Offset: 0x00255406
		public Color CellBorderColor
		{
			get
			{
				return this.o_.ooOO_..CellBorderColor;
			}
			set
			{
				this.o_.ooOO_..CellBorderColor = value;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x00257214 File Offset: 0x00255414
		// (set) Token: 0x0600541D RID: 21533 RVA: 0x00257221 File Offset: 0x00255421
		public Color FixedCellBorderColor
		{
			get
			{
				return this.o_.ooOO_..FixedCellBorderColor;
			}
			set
			{
				this.o_.ooOO_..FixedCellBorderColor = value;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x0025722F File Offset: 0x0025542F
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x0025723C File Offset: 0x0025543C
		public Color EmptyAreaBackColor
		{
			get
			{
				return this.o_.ooOO_..EmptyAreaBackColor;
			}
			set
			{
				this.o_.ooOO_..EmptyAreaBackColor = value;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x0025724A File Offset: 0x0025544A
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x00257257 File Offset: 0x00255457
		public Color HighlightBackColor
		{
			get
			{
				return this.o_.ooOO_..HighlightBackColor;
			}
			set
			{
				this.o_.ooOO_..HighlightBackColor = value;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06005422 RID: 21538 RVA: 0x00257265 File Offset: 0x00255465
		// (set) Token: 0x06005423 RID: 21539 RVA: 0x00257272 File Offset: 0x00255472
		public Color HighlightForeColor
		{
			get
			{
				return this.o_.ooOO_..HighlightForeColor;
			}
			set
			{
				this.o_.ooOO_..HighlightForeColor = value;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x00257280 File Offset: 0x00255480
		// (set) Token: 0x06005425 RID: 21541 RVA: 0x0025728D File Offset: 0x0025548D
		public Color ToolbarBackColor
		{
			get
			{
				return this.o_.ooOO_..ToolbarBackColor;
			}
			set
			{
				this.o_.ooOO_..ToolbarBackColor = value;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x0025729B File Offset: 0x0025549B
		// (set) Token: 0x06005427 RID: 21543 RVA: 0x002572A8 File Offset: 0x002554A8
		public Color SplitterColor
		{
			get
			{
				return this.o_.ooOO_..SplitterColor;
			}
			set
			{
				this.o_.ooOO_..SplitterColor = value;
			}
		}

		// Token: 0x040022B1 RID: 8881
		private GanttView <<EMPTY_NAME>>;
	}
}

using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using C1.Win.C1Gauge;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x0200050A RID: 1290
	[ComVisible(true)]
	public class Gauges : Control
	{
		// Token: 0x06005428 RID: 21544 RVA: 0x002572B6 File Offset: 0x002554B6
		internal Gauges(O0_O_0O A_0) : base(A_0, ControlTypeEnum.Gauges)
		{
		}

		// Token: 0x17001283 RID: 4739
		// (set) Token: 0x06005429 RID: 21545 RVA: 0x002572C4 File Offset: 0x002554C4
		[Browsable(false)]
		public string Settings
		{
			set
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(value);
				((C1Gauge)base.BaseControl).Load(xmlDocument);
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x002572F0 File Offset: 0x002554F0
		public C1RadialGauge RadialGauge
		{
			get
			{
				C1Gauge c1Gauge = (C1Gauge)base.BaseControl;
				int num = c1Gauge.Gauges.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (c1Gauge.Gauges[i] is C1RadialGauge)
					{
						return (C1RadialGauge)c1Gauge.Gauges[i];
					}
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600542B RID: 21547 RVA: 0x00257354 File Offset: 0x00255554
		public C1LinearGauge LinearGauge
		{
			get
			{
				C1Gauge c1Gauge = (C1Gauge)base.BaseControl;
				int num = c1Gauge.Gauges.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (c1Gauge.Gauges[i] is C1LinearGauge)
					{
						return (C1LinearGauge)c1Gauge.Gauges[i];
					}
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x002573B7 File Offset: 0x002555B7
		// (set) Token: 0x0600542D RID: 21549 RVA: 0x002573D4 File Offset: 0x002555D4
		public double Value
		{
			get
			{
				return ((C1Gauge)base.BaseControl).Gauges[0].Value;
			}
			set
			{
				((C1Gauge)base.BaseControl).Gauges[0].Value = value;
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x0600542E RID: 21550 RVA: 0x002573F4 File Offset: 0x002555F4
		public GaugeCollection Gauges
		{
			get
			{
				return ((C1Gauge)base.BaseControl).Gauges;
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x0600542F RID: 21551 RVA: 0x00257406 File Offset: 0x00255606
		// (set) Token: 0x06005430 RID: 21552 RVA: 0x00257409 File Offset: 0x00255609
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BackGroundImageFile
		{
			get
			{
				return null;
			}
			set
			{
				base.BaseControl.BackgroundImage = OO_00oOO.GetImage(value);
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06005431 RID: 21553 RVA: 0x0025741C File Offset: 0x0025561C
		// (set) Token: 0x06005432 RID: 21554 RVA: 0x00257429 File Offset: 0x00255629
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ImageLayout BackgroundImageLayout
		{
			get
			{
				return base.BaseControl.BackgroundImageLayout;
			}
			set
			{
				base.BaseControl.BackgroundImageLayout = value;
			}
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x00257438 File Offset: 0x00255638
		[oO0oooo("1912")]
		public void AddControl(Control Control)
		{
			base.BaseControl.Controls.Add(Control.BaseControl);
			if (Control.BaseControl is O_oOooO_O)
			{
				Table o.0O_O0o_. = ((O_oOooO_O)Control.BaseControl).o.0O_O0o_.;
				if (o.0O_O0o_..TableType != TableTypeEnum.Normal || o.0O_O0o_..IsCopy)
				{
					o.0O_O0o_..oO_o_0o._0oooo.(true);
				}
			}
			Control.TopMost = true;
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x0025749C File Offset: 0x0025569C
		[oO0oooo("1912")]
		public void RemoveControl(string Name)
		{
			try
			{
				foreach (object obj in base.BaseControl.Controls)
				{
					Control control = (Control)obj;
					if (Operators.CompareString(control.Name, Name, true) == 0)
					{
						oOO0oo_o0.O00OO_O_oO_.o.(base.BaseControl.Controls, control);
						break;
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
			oOO0oo_o0.oOo.oO_O0_o_Oo.(base.BaseControl);
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x00257524 File Offset: 0x00255724
		public void ClearControl()
		{
			for (int i = base.BaseControl.Controls.Count - 1; i >= 0; i += -1)
			{
				Control a_ = base.BaseControl.Controls[i];
				oOO0oo_o0.O00OO_O_oO_.o.(base.BaseControl.Controls, a_);
			}
			oOO0oo_o0.oOo.oO_O0_o_Oo.(base.BaseControl);
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06005436 RID: 21558 RVA: 0x0025757C File Offset: 0x0025577C
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(base.BaseControl);
			}
		}
	}
}

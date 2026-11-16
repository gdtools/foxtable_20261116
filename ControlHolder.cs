using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Gauge;
using C1.Win.C1Input;
using C1.Win.Map;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200039D RID: 925
	[DesignerGenerated]
	internal class ControlHolder : UserControl
	{
		// Token: 0x06003CAB RID: 15531 RVA: 0x001B8F4F File Offset: 0x001B714F
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.O_O00._. != null)
			{
				this.O_O00._..Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x001B8F70 File Offset: 0x001B7170
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.FocusLabel = new TextBox();
			base.SuspendLayout();
			this.FocusLabel.BackColor = SystemColors.Control;
			this.FocusLabel.BorderStyle = BorderStyle.None;
			this.FocusLabel.Location = new Point(94, 13);
			this.FocusLabel.Name = "FocusLabel";
			this.FocusLabel.Size = new Size(0, 14);
			this.FocusLabel.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.FocusLabel);
			base.Name = "o.o..0o.";
			base.Size = new Size(164, 48);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x001B9050 File Offset: 0x001B7250
		public ControlHolder()
		{
			base.DockChanged += this.o0O._O_O.;
			base.Load += this.O0.0O.;
			base.Paint += this.o_.0Oo.;
			this.O0._o.();
			base.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.Selectable, false);
			this.BackColor = Color.Transparent;
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06003CAE RID: 15534 RVA: 0x001B90C2 File Offset: 0x001B72C2
		// (set) Token: 0x06003CAF RID: 15535 RVA: 0x001B90CA File Offset: 0x001B72CA
		internal virtual TextBox FocusLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06003CB0 RID: 15536 RVA: 0x001B90D4 File Offset: 0x001B72D4
		// (remove) Token: 0x06003CB1 RID: 15537 RVA: 0x001B910C File Offset: 0x001B730C
		public event ControlHolder.oOo ActivatedChanged
		{
			[CompilerGenerated]
			add
			{
				ControlHolder.oOo oOo = this.o.O_o00O_0o_O.;
				ControlHolder.oOo oOo2;
				do
				{
					oOo2 = oOo;
					ControlHolder.oOo value2 = (ControlHolder.oOo)Delegate.Combine(oOo2, value);
					oOo = Interlocked.CompareExchange<ControlHolder.oOo>(ref this.o.O_o00O_0o_O., value2, oOo2);
				}
				while (oOo != oOo2);
			}
			[CompilerGenerated]
			remove
			{
				ControlHolder.oOo oOo = this.o.O_o00O_0o_O.;
				ControlHolder.oOo oOo2;
				do
				{
					oOo2 = oOo;
					ControlHolder.oOo value2 = (ControlHolder.oOo)Delegate.Remove(oOo2, value);
					oOo = Interlocked.CompareExchange<ControlHolder.oOo>(ref this.o.O_o00O_0o_O., value2, oOo2);
				}
				while (oOo != oOo2);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06003CB2 RID: 15538 RVA: 0x001B9144 File Offset: 0x001B7344
		// (remove) Token: 0x06003CB3 RID: 15539 RVA: 0x001B917C File Offset: 0x001B737C
		public event ControlHolder.o_o_0oO0o000 SelectedChanged
		{
			[CompilerGenerated]
			add
			{
				ControlHolder.o_o_0oO0o000 o_o_0oO0o = this.O_O00._.;
				ControlHolder.o_o_0oO0o000 o_o_0oO0o2;
				do
				{
					o_o_0oO0o2 = o_o_0oO0o;
					ControlHolder.o_o_0oO0o000 value2 = (ControlHolder.o_o_0oO0o000)Delegate.Combine(o_o_0oO0o2, value);
					o_o_0oO0o = Interlocked.CompareExchange<ControlHolder.o_o_0oO0o000>(ref this.O_O00._., value2, o_o_0oO0o2);
				}
				while (o_o_0oO0o != o_o_0oO0o2);
			}
			[CompilerGenerated]
			remove
			{
				ControlHolder.o_o_0oO0o000 o_o_0oO0o = this.O_O00._.;
				ControlHolder.o_o_0oO0o000 o_o_0oO0o2;
				do
				{
					o_o_0oO0o2 = o_o_0oO0o;
					ControlHolder.o_o_0oO0o000 value2 = (ControlHolder.o_o_0oO0o000)Delegate.Remove(o_o_0oO0o2, value);
					o_o_0oO0o = Interlocked.CompareExchange<ControlHolder.o_o_0oO0o000>(ref this.O_O00._., value2, o_o_0oO0o2);
				}
				while (o_o_0oO0o != o_o_0oO0o2);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06003CB4 RID: 15540 RVA: 0x001B91B4 File Offset: 0x001B73B4
		// (remove) Token: 0x06003CB5 RID: 15541 RVA: 0x001B91EC File Offset: 0x001B73EC
		public event ControlHolder.OO__oOoO_ LockedChanged
		{
			[CompilerGenerated]
			add
			{
				ControlHolder.OO__oOoO_ oo__oOoO_ = this.O_O00._.;
				ControlHolder.OO__oOoO_ oo__oOoO_2;
				do
				{
					oo__oOoO_2 = oo__oOoO_;
					ControlHolder.OO__oOoO_ value2 = (ControlHolder.OO__oOoO_)Delegate.Combine(oo__oOoO_2, value);
					oo__oOoO_ = Interlocked.CompareExchange<ControlHolder.OO__oOoO_>(ref this.O_O00._., value2, oo__oOoO_2);
				}
				while (oo__oOoO_ != oo__oOoO_2);
			}
			[CompilerGenerated]
			remove
			{
				ControlHolder.OO__oOoO_ oo__oOoO_ = this.O_O00._.;
				ControlHolder.OO__oOoO_ oo__oOoO_2;
				do
				{
					oo__oOoO_2 = oo__oOoO_;
					ControlHolder.OO__oOoO_ value2 = (ControlHolder.OO__oOoO_)Delegate.Remove(oo__oOoO_2, value);
					oo__oOoO_ = Interlocked.CompareExchange<ControlHolder.OO__oOoO_>(ref this.O_O00._., value2, oo__oOoO_2);
				}
				while (oo__oOoO_ != oo__oOoO_2);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06003CB6 RID: 15542 RVA: 0x001B9224 File Offset: 0x001B7424
		// (remove) Token: 0x06003CB7 RID: 15543 RVA: 0x001B925C File Offset: 0x001B745C
		public event ControlHolder.oo_O__O_ DockStyleChanged
		{
			[CompilerGenerated]
			add
			{
				ControlHolder.oo_O__O_ oo_O__O_ = this.O_O00._.;
				ControlHolder.oo_O__O_ oo_O__O_2;
				do
				{
					oo_O__O_2 = oo_O__O_;
					ControlHolder.oo_O__O_ value2 = (ControlHolder.oo_O__O_)Delegate.Combine(oo_O__O_2, value);
					oo_O__O_ = Interlocked.CompareExchange<ControlHolder.oo_O__O_>(ref this.O_O00._., value2, oo_O__O_2);
				}
				while (oo_O__O_ != oo_O__O_2);
			}
			[CompilerGenerated]
			remove
			{
				ControlHolder.oo_O__O_ oo_O__O_ = this.O_O00._.;
				ControlHolder.oo_O__O_ oo_O__O_2;
				do
				{
					oo_O__O_2 = oo_O__O_;
					ControlHolder.oo_O__O_ value2 = (ControlHolder.oo_O__O_)Delegate.Remove(oo_O__O_2, value);
					oo_O__O_ = Interlocked.CompareExchange<ControlHolder.oo_O__O_>(ref this.O_O00._., value2, oo_O__O_2);
				}
				while (oo_O__O_ != oo_O__O_2);
			}
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x001B9294 File Offset: 0x001B7494
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ControlHolder.oo_O__O_ o_O00._. = this.O_O00._.;
			if (o_O00._. != null)
			{
				o_O00._.(this);
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x001B92B2 File Offset: 0x001B74B2
		[Browsable(false)]
		public string DisplayName
		{
			get
			{
				return base.Name;
			}
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x001B92BC File Offset: 0x001B74BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Oo0oo_O_O00__ value = new Oo0oo_O_O00__(O0OO000oo0O.OOOOo._.);
			base.Controls.Add(value);
			value = new Oo0oo_O_O00__(O0OO000oo0O.o_.0_0O.);
			base.Controls.Add(value);
			value = new Oo0oo_O_O00__(O0OO000oo0O.Oo0ooo.OO.);
			base.Controls.Add(value);
			value = new Oo0oo_O_O00__(O0OO000oo0O.o_oO._0O.);
			base.Controls.Add(value);
			value = new Oo0oo_O_O00__(O0OO000oo0O.o.00o000O00o__.);
			base.Controls.Add(value);
			value = new Oo0oo_O_O00__(O0OO000oo0O.OO_._O.);
			base.Controls.Add(value);
			value = new Oo0oo_O_O00__(O0OO000oo0O.o0_OoOo.OO.);
			base.Controls.Add(value);
			value = new Oo0oo_O_O00__(O0OO000oo0O.ooo_O0o._.);
			base.Controls.Add(value);
			this.O_.0oo_O. = new o0O__ooOO00();
			base.Controls.Add(this.O_.0oo_O.);
			base.TabIndexChanged += this.O_.0oo_O..O00Oo0o._.;
			this.FocusLabel.SendToBack();
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x001B939F File Offset: 0x001B759F
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x001B93A7 File Offset: 0x001B75A7
		public string Key
		{
			get
			{
				return this.o.O_o00O_0o_O.;
			}
			set
			{
				this.o.O_o00O_0o_O. = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x001B93B0 File Offset: 0x001B75B0
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x001B93B8 File Offset: 0x001B75B8
		public DataRow DataRow
		{
			get
			{
				return this.o.O_o00O_0o_O.;
			}
			set
			{
				this.o.O_o00O_0o_O. = value;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06003CBF RID: 15551 RVA: 0x001B93C1 File Offset: 0x001B75C1
		// (set) Token: 0x06003CC0 RID: 15552 RVA: 0x001B93CC File Offset: 0x001B75CC
		public bool Activated
		{
			get
			{
				return this.o.O_o00O_0o_O.;
			}
			set
			{
				if (this.o.O_o00O_0o_O. != value)
				{
					if (value)
					{
						oOO0oo_o0.o_0O.O.(base.FindForm().Controls);
					}
					this.o.O_o00O_0o_O. = value;
					ControlHolder.oOo oOo = this.o.O_o00O_0o_O.;
					if (oOo != null)
					{
						oOo(this);
					}
					if (value)
					{
						this.FocusLabel.Focus();
					}
				}
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x001B941D File Offset: 0x001B761D
		// (set) Token: 0x06003CC2 RID: 15554 RVA: 0x001B9428 File Offset: 0x001B7628
		public bool Selected
		{
			get
			{
				return this.OOOOooo0000.o.;
			}
			set
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
					if (this.OOOOooo0000.o. == value)
					{
						goto IL_E6;
					}
					IL_15:
					num2 = 4;
					this.OOOOooo0000.o. = value;
					IL_1E:
					num2 = 5;
					ControlHolder.o_o_0oO0o000 o_O00._. = this.O_O00._.;
					if (o_O00._. != null)
					{
						o_O00._.(this);
					}
					IL_31:
					num2 = 6;
					if (!(!value & this.Activated))
					{
						goto IL_53;
					}
					IL_40:
					num2 = 7;
					oOO0oo_o0.O.ooooo.(base.FindForm().Controls);
					IL_53:
					num2 = 8;
					this.Activated = value;
					IL_5C:
					num2 = 9;
					if (!value)
					{
						goto IL_B1;
					}
					IL_62:
					num2 = 10;
					if (!(base.Parent is O_O_))
					{
						goto IL_B1;
					}
					IL_72:
					num2 = 11;
					C1DockingTab c1DockingTab = (C1DockingTab)base.Parent.Parent;
					IL_87:
					num2 = 12;
					if (c1DockingTab.SelectedTab == base.Parent)
					{
						goto IL_AE;
					}
					IL_99:
					num2 = 13;
					c1DockingTab.SelectedTab = (O_O_)base.Parent;
					IL_AE:
					c1DockingTab = null;
					IL_B1:
					num2 = 15;
					if (this.ControlType != ControlTypeEnum.Line)
					{
						goto IL_E6;
					}
					IL_BE:
					num2 = 16;
					if (!value)
					{
						goto IL_DD;
					}
					IL_C4:
					num2 = 17;
					((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).oOO_0._000..Add(this);
					IL_DD:
					num2 = 18;
					base.Invalidate();
					IL_E6:
					goto IL_184;
					IL_EB:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_145:
					goto IL_179;
					IL_147:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_157:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_147;
				}
				IL_179:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_184:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x001B95E0 File Offset: 0x001B77E0
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x001B95E8 File Offset: 0x001B77E8
		public bool Locked
		{
			get
			{
				return this.o0.O_o_o0O.;
			}
			set
			{
				this.o0.O_o_o0O. = value;
				ControlHolder.OO__oOoO_ o_O00._. = this.O_O00._.;
				if (o_O00._. != null)
				{
					o_O00._.(this);
				}
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x001B960D File Offset: 0x001B780D
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x001B9615 File Offset: 0x001B7815
		public ControlTypeEnum ControlType
		{
			get
			{
				return this.o.O_o00O_0o_O.;
			}
			set
			{
				this.o.O_o00O_0o_O. = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x001B9620 File Offset: 0x001B7820
		public bool IsContainer
		{
			get
			{
				ControlTypeEnum controlTypeEnum = this.ControlType;
				if (controlTypeEnum <= ControlTypeEnum.TreeView)
				{
					if (controlTypeEnum != ControlTypeEnum.TopicBar && controlTypeEnum - ControlTypeEnum.GroupBox > 5)
					{
						goto IL_55;
					}
				}
				else if (controlTypeEnum != ControlTypeEnum.NavBar)
				{
					switch (controlTypeEnum)
					{
					case ControlTypeEnum.FilterTree:
					case ControlTypeEnum.LoadTree:
					case ControlTypeEnum.InlineTree:
					case ControlTypeEnum.LayersTree:
					case ControlTypeEnum.Gauges:
					case ControlTypeEnum.GanttView:
					case ControlTypeEnum.Map:
						break;
					case ControlTypeEnum.FontPicker:
					case ControlTypeEnum.ColorPicker:
					case ControlTypeEnum.PDFViewer:
						goto IL_55;
					default:
						goto IL_55;
					}
				}
				return true;
				IL_55:
				return false;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x001B9685 File Offset: 0x001B7885
		// (set) Token: 0x06003CC9 RID: 15561 RVA: 0x001B9690 File Offset: 0x001B7890
		public Control ChildControl
		{
			get
			{
				return this.OOOOooo0000.o.;
			}
			set
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
					this.OOOOooo0000.o. = value;
					IL_10:
					num2 = 3;
					this.OOOOooo0000.o..Dock = DockStyle.Fill;
					IL_1E:
					num2 = 4;
					if (this.ChildControl.GetType() != typeof(C1TextBox) && !(this.ChildControl is C1DropDownControl))
					{
						goto IL_59;
					}
					IL_44:
					num2 = 5;
					base.Height = this.OOOOooo0000.o..Height;
					goto IL_76;
					IL_59:
					num2 = 7;
					if (!this.IsFixedHeight)
					{
						goto IL_76;
					}
					IL_63:
					num2 = 8;
					base.Height = this.OOOOooo0000.o..Height;
					IL_76:
					num2 = 9;
					if (!this.IsFixedWidth)
					{
						goto IL_95;
					}
					IL_81:
					num2 = 10;
					base.Width = this.OOOOooo0000.o..Width;
					IL_95:
					num2 = 11;
					this.OOOOooo0000.o..Resize += this.O000_oo.o_.;
					IL_AF:
					num2 = 12;
					if (!(this.OOOOooo0000.o. is C1TextBox))
					{
						goto IL_DE;
					}
					IL_BF:
					num2 = 13;
					((C1TextBox)this.OOOOooo0000.o.).MultilineChanged += this.o_.0Oo.;
					IL_DE:
					num2 = 14;
					if (!(this.OOOOooo0000.o. is C1TextBox) && !(this.OOOOooo0000.o. is C1DropDownControl))
					{
						goto IL_115;
					}
					IL_FB:
					num2 = 15;
					this.OOOOooo0000.o..FontChanged += this.O_0oO0OOoOO0.o.;
					IL_115:
					num2 = 16;
					ControlTypeEnum controlTypeEnum = this.ControlType;
					if (controlTypeEnum <= ControlTypeEnum.TreeView)
					{
						if (controlTypeEnum - ControlTypeEnum.GroupBox <= 2 || controlTypeEnum - ControlTypeEnum.TabControl <= 1)
						{
							goto IL_184;
						}
					}
					else
					{
						if (controlTypeEnum == ControlTypeEnum.NavBar)
						{
							goto IL_184;
						}
						switch (controlTypeEnum)
						{
						case ControlTypeEnum.FilterTree:
						case ControlTypeEnum.LoadTree:
						case ControlTypeEnum.InlineTree:
						case ControlTypeEnum.LayersTree:
						case ControlTypeEnum.Gauges:
						case ControlTypeEnum.GanttView:
						case ControlTypeEnum.Map:
							goto IL_184;
						}
					}
					IL_16A:
					num2 = 19;
					this.OOOOooo0000.o..Enter += this.o0__0.OOO.;
					IL_184:
					num2 = 21;
					if (this.ControlType != ControlTypeEnum.TreeView)
					{
						goto IL_206;
					}
					IL_191:
					num2 = 22;
					base.Controls.Add(new O00_Oooo0oo00());
					IL_1A4:
					num2 = 23;
					((TreeView)this.ChildControl).AfterSelect += this.O.O_000.;
					IL_1C3:
					num2 = 24;
					((TreeView)this.ChildControl).AfterLabelEdit += this.O.O0.;
					IL_1E2:
					num2 = 25;
					((TreeView)this.ChildControl).BeforeLabelEdit += this.O.O_000.;
					goto IL_33B;
					IL_206:
					num2 = 27;
					if (this.ControlType != ControlTypeEnum.SplitContainer)
					{
						goto IL_256;
					}
					IL_213:
					num2 = 28;
					((SplitContainer)this.ChildControl).SplitterMoving += this.O.O_000.;
					IL_232:
					num2 = 29;
					((SplitContainer)this.ChildControl).SplitterMoved += this.O.O_000.;
					goto IL_33B;
					IL_256:
					num2 = 31;
					if (this.ControlType != ControlTypeEnum.TabControl)
					{
						goto IL_2B9;
					}
					IL_263:
					num2 = 32;
					base.Controls.Add(new oOOOO_Oo_());
					IL_276:
					num2 = 33;
					((C1DockingTab)this.OOOOooo0000.o.).SelectedIndexChanging += this.O0_.0.;
					IL_295:
					num2 = 34;
					((C1DockingTab)this.OOOOooo0000.o.).SelectedIndexChanged += this.O.oOO0_o0_.;
					goto IL_33B;
					IL_2B9:
					num2 = 36;
					if (this.ControlType != ControlTypeEnum.NavBar)
					{
						goto IL_2FA;
					}
					IL_2C6:
					num2 = 37;
					base.Controls.Add(new OOO0_00O());
					IL_2D9:
					num2 = 38;
					((C1NavBar)this.OOOOooo0000.o.).SelectedPanelChanged += this.O__oO_.__0_0OO.;
					goto IL_33B;
					IL_2FA:
					num2 = 40;
					if (this.ControlType != ControlTypeEnum.Gauges)
					{
						goto IL_31C;
					}
					IL_307:
					num2 = 41;
					base.Controls.Add(new O_O_OO());
					goto IL_33B;
					IL_31C:
					num2 = 43;
					if (this.ControlType != ControlTypeEnum.TopicBar)
					{
						goto IL_33B;
					}
					IL_328:
					num2 = 44;
					base.Controls.Add(new oOOO0oo0_oO_o());
					IL_33B:
					num2 = 45;
					if (!O_O0OO.O0_00o.o0__o..PropertyIsValid)
					{
						goto IL_3FF;
					}
					IL_34D:
					num2 = 46;
					if (!this.IsContainer)
					{
						goto IL_38E;
					}
					IL_358:
					num2 = 47;
					OO0 value2 = new OO0();
					IL_362:
					num2 = 48;
					base.Controls.Add(value2);
					IL_372:
					num2 = 49;
					this.OOOOooo0000.o..MouseDown += this.o_.0Oo.;
					goto IL_3FF;
					IL_38E:
					num2 = 51;
					this.OOOOooo0000.o..MouseDown += this.o0_.0O_O0O.;
					IL_3A8:
					num2 = 52;
					this.OOOOooo0000.o..MouseMove += this.oOO.O.;
					IL_3C2:
					num2 = 53;
					this.OOOOooo0000.o..MouseUp += this.O000_oo.o_.;
					IL_3DC:
					num2 = 54;
					if (this.OOOOooo0000.o. is WebBrowser)
					{
						goto IL_3FF;
					}
					IL_3EC:
					num2 = 55;
					this.OOOOooo0000.o..Cursor = Cursors.SizeAll;
					IL_3FF:
					num2 = 56;
					base.Controls.Add(this.OOOOooo0000.o.);
					IL_413:
					goto IL_549;
					IL_418:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_50A:
					goto IL_53E;
					IL_50C:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_51C:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_50C;
				}
				IL_53E:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_549:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x001B9C0C File Offset: 0x001B7E0C
		public bool IsFixedWidth
		{
			get
			{
				if (this.ChildControl.GetType() == typeof(C1Label))
				{
					if (this.ChildControl.AutoSize)
					{
						return true;
					}
				}
				else if (this.ChildControl.GetType() == typeof(TrackBar) && ((TrackBar)this.ChildControl).Orientation == Orientation.Vertical)
				{
					return true;
				}
				bool result;
				if (this.ChildControl.GetType() == typeof(OOo00o_0o0_))
				{
					result = true;
				}
				else if (this.ChildControl is MonthCalendar)
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x001B9C9C File Offset: 0x001B7E9C
		public bool IsFixedHeight
		{
			get
			{
				bool result;
				if ((this.ChildControl.GetType() == typeof(C1Label) || this.ChildControl.GetType() == typeof(CheckBox)) && this.ChildControl.AutoSize)
				{
					result = true;
				}
				else if (this.ChildControl.GetType() == typeof(C1TextBox) && !((C1TextBox)this.ChildControl).Multiline)
				{
					result = true;
				}
				else if (this.ChildControl is C1DropDownControl)
				{
					result = true;
				}
				else if (this.ChildControl is MonthCalendar)
				{
					result = true;
				}
				else if (this.ChildControl.GetType() == typeof(TrackBar) && ((TrackBar)this.ChildControl).Orientation == Orientation.Horizontal)
				{
					result = true;
				}
				else if (this.ChildControl.GetType() == typeof(OOo00o_0o0_))
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06003CCC RID: 15564 RVA: 0x001B9D84 File Offset: 0x001B7F84
		public ControlHolder ParentHolder
		{
			get
			{
				ControlHolder result;
				if (base.Parent is o0_OO0)
				{
					result = (ControlHolder)base.Parent.Parent.Parent.Parent;
				}
				else if (base.Parent is oO_0)
				{
					result = (ControlHolder)base.Parent.Parent.Parent;
				}
				else if (base.Parent is Panel | base.Parent is GroupBox | base.Parent is C1Gauge | base.Parent is C1Map)
				{
					result = (ControlHolder)base.Parent.Parent;
				}
				else if (base.Parent.Parent is CustomPictureBox)
				{
					result = (ControlHolder)base.Parent.Parent.Parent;
				}
				else if (base.Parent is C1DockingTabPage)
				{
					result = (ControlHolder)base.Parent.Parent.Parent;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x001B9E88 File Offset: 0x001B8088
		protected override void OnParentChanged(EventArgs e)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IL_09:
				num2 = 3;
				base.OnParentChanged(e);
				IL_12:
				num2 = 4;
				if (base.FindForm() == null)
				{
					goto IL_5A8;
				}
				IL_1F:
				num2 = 6;
				if (base.Parent != base.FindForm())
				{
					goto IL_62;
				}
				IL_2F:
				num2 = 7;
				this.DataRow["ParentKey"] = RuntimeHelpers.GetObjectValue(((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).o_0O.OO0_0_.["Key"]);
				goto IL_80;
				IL_62:
				num2 = 9;
				this.DataRow["ParentKey"] = this.ParentHolder.Key;
				IL_80:
				num2 = 10;
				if (this.O.O_000. == 1)
				{
					goto IL_5A8;
				}
				IL_8F:
				num2 = 12;
				this.O.O_000. = 1;
				IL_99:
				num2 = 13;
				this.ChildControl.Click += this.Ooo0O00_0._O0.;
				IL_B3:
				num2 = 14;
				if (!(this.ControlType == ControlTypeEnum.GroupBox | this.ControlType == ControlTypeEnum.Panel | this.ControlType == ControlTypeEnum.Gauges | this.ControlType == ControlTypeEnum.Map))
				{
					goto IL_18D;
				}
				IL_E6:
				num2 = 15;
				o\u3002\u3002\u3000\u3000\u3002 @object = (o\u3002\u3002\u3000\u3000\u3002)base.FindForm();
				IL_F5:
				num2 = 16;
				this.ChildControl.MouseDown += @object.O0ooOo0.o.;
				IL_10F:
				num2 = 17;
				this.ChildControl.MouseMove += @object.oooo_._O.;
				IL_129:
				num2 = 18;
				this.ChildControl.MouseUp += @object.OOOoO.Oo_O0o_0.;
				IL_143:
				num2 = 19;
				this.ChildControl.AllowDrop = true;
				IL_152:
				num2 = 20;
				this.ChildControl.DragEnter += @object.o_.000OOOoo.;
				IL_16C:
				num2 = 21;
				this.ChildControl.DragDrop += @object.o.Ooo0__0.;
				IL_186:
				@object = null;
				goto IL_576;
				IL_18D:
				num2 = 24;
				if (this.ControlType != ControlTypeEnum.PictureBox)
				{
					goto IL_25E;
				}
				IL_19D:
				num2 = 25;
				PictureBox pictureBox = ((CustomPictureBox)this.ChildControl).PictureBox1;
				IL_1B2:
				num2 = 26;
				o\u3002\u3002\u3000\u3000\u3002 object2 = (o\u3002\u3002\u3000\u3000\u3002)base.FindForm();
				IL_1C2:
				num2 = 27;
				pictureBox.MouseDown += this.o_.0Oo.;
				IL_1D8:
				num2 = 28;
				pictureBox.MouseDown += object2.O0ooOo0.o.;
				IL_1EF:
				num2 = 29;
				pictureBox.MouseMove += object2.oooo_._O.;
				IL_206:
				num2 = 30;
				pictureBox.MouseUp += object2.OOOoO.Oo_O0o_0.;
				IL_21D:
				num2 = 31;
				pictureBox.AllowDrop = true;
				IL_228:
				num2 = 32;
				pictureBox.DragEnter += object2.o_.000OOOoo.;
				IL_23F:
				num2 = 33;
				pictureBox.DragDrop += object2.o.Ooo0__0.;
				IL_256:
				object2 = null;
				goto IL_576;
				IL_25E:
				num2 = 36;
				if (this.ControlType != ControlTypeEnum.SplitContainer)
				{
					goto IL_43A;
				}
				IL_26E:
				num2 = 37;
				o0000O o0000O = (o0000O)this.ChildControl;
				IL_27E:
				num2 = 38;
				o\u3002\u3002\u3000\u3000\u3002 object3 = (o\u3002\u3002\u3000\u3000\u3002)base.FindForm();
				IL_28E:
				num2 = 39;
				o0000O.oo0oO_O.oooO0O.().Click += this.Ooo0O00_0._O0.;
				IL_2A9:
				num2 = 40;
				o0000O.oo0oO_O.oooO0O.().MouseDown += this.o_.0Oo.;
				IL_2C4:
				num2 = 41;
				o0000O.oo0oO_O.oooO0O.().MouseDown += object3.O0ooOo0.o.;
				IL_2E0:
				num2 = 42;
				o0000O.oo0oO_O.oooO0O.().MouseMove += object3.oooo_._O.;
				IL_2FC:
				num2 = 43;
				o0000O.oo0oO_O.oooO0O.().MouseUp += object3.OOOoO.Oo_O0o_0.;
				IL_318:
				num2 = 44;
				o0000O.oo0oO_O.oooO0O.().AllowDrop = true;
				IL_328:
				num2 = 45;
				o0000O.oo0oO_O.oooO0O.().DragEnter += object3.o_.000OOOoo.;
				IL_344:
				num2 = 46;
				o0000O.oo0oO_O.oooO0O.().DragDrop += object3.o.Ooo0__0.;
				IL_360:
				num2 = 47;
				o0000O.o.Oo0oo000O.().Click += this.Ooo0O00_0._O0.;
				IL_37B:
				num2 = 48;
				o0000O.o.Oo0oo000O.().MouseDown += this.o_.0Oo.;
				IL_396:
				num2 = 49;
				o0000O.o.Oo0oo000O.().MouseDown += object3.O0ooOo0.o.;
				IL_3B2:
				num2 = 50;
				o0000O.o.Oo0oo000O.().MouseMove += object3.oooo_._O.;
				IL_3CE:
				num2 = 51;
				o0000O.o.Oo0oo000O.().MouseUp += object3.OOOoO.Oo_O0o_0.;
				IL_3EA:
				num2 = 52;
				o0000O.o.Oo0oo000O.().AllowDrop = true;
				IL_3FA:
				num2 = 53;
				o0000O.o.Oo0oo000O.().DragEnter += object3.o_.000OOOoo.;
				IL_416:
				num2 = 54;
				o0000O.o.Oo0oo000O.().DragDrop += object3.o.Ooo0__0.;
				IL_432:
				object3 = null;
				goto IL_576;
				IL_43A:
				num2 = 57;
				if (this.ControlType != ControlTypeEnum.TabControl)
				{
					goto IL_4B3;
				}
				IL_447:
				num2 = 58;
				if (((C1DockingTab)this.ChildControl).TabPages.Count != 0)
				{
					goto IL_576;
				}
				IL_464:
				num2 = 59;
				this.oo_.o_O.().Text = "Page1";
				IL_477:
				num2 = 60;
				this.oo_.o_O.().Text = "Page2";
				IL_48A:
				num2 = 61;
				this.oo_.o_O.().Text = "Page3";
				IL_49D:
				num2 = 62;
				C1DockingTab c1DockingTab = (C1DockingTab)this.ChildControl;
				IL_4AC:
				goto IL_576;
				IL_4B3:
				num2 = 65;
				if (this.ControlType != ControlTypeEnum.NavBar)
				{
					goto IL_576;
				}
				IL_4C3:
				num2 = 66;
				if (((C1NavBar)this.ChildControl).Panels.Count != 0)
				{
					goto IL_576;
				}
				IL_4E0:
				num2 = 67;
				string[] array = "日历|联系人|任务".Split(new char[]
				{
					'|'
				});
				IL_4FA:
				num2 = 68;
				int num3 = 1;
				do
				{
					IL_500:
					num2 = 69;
					oO_0 a_ = this.oo_.o_O.();
					IL_50B:
					num2 = 70;
					CustomNavBarPanelProperty customNavBarPanelProperty = new CustomNavBarPanelProperty(a_);
					IL_517:
					num2 = 71;
					customNavBarPanelProperty.ButtonText = array[num3 - 1];
					IL_528:
					num2 = 72;
					customNavBarPanelProperty.ButtonImageFile = "240" + Conversions.ToString(num3) + ".ico";
					IL_548:
					num2 = 73;
					customNavBarPanelProperty.ButtonSmallImageFile = "160" + Conversions.ToString(num3) + ".ico";
					IL_568:
					num2 = 74;
					num3++;
				}
				while (num3 <= 3);
				IL_576:
				num2 = 75;
				if (Operators.CompareString(OO_00oOO.BaseMainForm.GetType().Name, OO_00oOO.BaseMainForm.Name, true) != 0)
				{
					goto IL_5A8;
				}
				IL_59A:
				num2 = 76;
				base.Controls.Clear();
				IL_5A8:
				goto IL_72E;
				IL_5AD:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_6EF:
				goto IL_723;
				IL_6F1:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_701:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_6F1;
			}
			IL_723:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_72E:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x001BA5E8 File Offset: 0x001B87E8
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (A_1.Button == MouseButtons.Left)
			{
				if (Control.ModifierKeys == Keys.Control)
				{
					this.Selected = !this.Selected;
					return;
				}
				if (this.Selected)
				{
					this.Activated = true;
					return;
				}
				oOO0oo_o0.o0.Oo__.(base.FindForm().Controls);
				this.Selected = true;
			}
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x001BA648 File Offset: 0x001B8848
		public void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				if (base.FindForm() == null)
				{
					goto IL_2D;
				}
				IL_11:
				num2 = 3;
				base.FindForm().Focus();
				IL_1F:
				num2 = 4;
				this.FocusLabel.Focus();
				IL_2D:
				num2 = 5;
				if ((DateTime.Now - this.O.O_000.).TotalSeconds >= 0.5)
				{
					goto IL_18B;
				}
				IL_55:
				num2 = 6;
				if (this.ControlType != ControlTypeEnum.Button)
				{
					goto IL_18B;
				}
				IL_63:
				num2 = 7;
				O\u3000\u3002\u3000\u3000 o_u3000_u3002_u3000_u = new O\u3000\u3002\u3000\u3000("Control", "Click", "WinForm.Button");
				IL_7B:
				num2 = 8;
				ControlPropertyBase controlPropertyBase = (ControlPropertyBase)((o_0oooo_OO)((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).o_0O.OO0_0_.[this.Key]).Oo._o.();
				IL_A9:
				num2 = 9;
				o_u3000_u3002_u3000_u.O.O_0o_Oo_.().oo.O0ooOo00_0.("0732");
				IL_BD:
				num2 = 10;
				if (controlPropertyBase.Click == null || controlPropertyBase.Click.Count <= 0)
				{
					goto IL_EF;
				}
				IL_D8:
				num2 = 11;
				o_u3000_u3002_u3000_u.O0O0.0__o0.(controlPropertyBase.Click[0]);
				IL_EF:
				num2 = 12;
				if (o_u3000_u3002_u3000_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_181;
				}
				IL_FF:
				num2 = 13;
				if (Operators.CompareString(o_u3000_u3002_u3000_u.O.O_0o_Oo_.(), "", true) != 0)
				{
					goto IL_123;
				}
				IL_116:
				num2 = 14;
				controlPropertyBase.Click = null;
				goto IL_14B;
				IL_123:
				num2 = 16;
				EventString eventString = new EventString();
				IL_12D:
				num2 = 17;
				eventString.Add(o_u3000_u3002_u3000_u.O.O_0o_Oo_.());
				IL_13F:
				num2 = 18;
				controlPropertyBase.Click = eventString;
				IL_14B:
				num2 = 19;
				((o\u3000\u3002)base.FindForm().MdiParent).o_.OO000o___oo.().Refresh();
				IL_168:
				num2 = 20;
				((o\u3000\u3002)base.FindForm().MdiParent).OO_._oOo. = true;
				IL_181:
				num2 = 21;
				o_u3000_u3002_u3000_u.Dispose();
				IL_18B:
				num2 = 22;
				this.O.O_000. = DateTime.Now;
				IL_199:
				goto IL_247;
				IL_19E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_208:
				goto IL_23C;
				IL_20A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_21A:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_20A;
			}
			IL_23C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_247:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x001BA8C0 File Offset: 0x001B8AC0
		public void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o_o_O._. = base.Location;
				IL_15:
				num2 = 3;
				if (A_1.Button != MouseButtons.Left)
				{
					goto IL_15C;
				}
				IL_27:
				num2 = 4;
				if (Control.ModifierKeys != Keys.Control)
				{
					goto IL_48;
				}
				IL_35:
				num2 = 5;
				this.Selected = !this.Selected;
				goto IL_7A;
				IL_48:
				num2 = 7;
				if (!this.Selected)
				{
					goto IL_5D;
				}
				IL_52:
				num2 = 8;
				this.Activated = true;
				goto IL_7A;
				IL_5D:
				num2 = 10;
				oOO0oo_o0.o0.Oo__.(base.FindForm().Controls);
				IL_70:
				num2 = 11;
				this.Selected = true;
				IL_7A:
				num2 = 12;
				this.O_O00._. = base.Parent;
				IL_89:
				num2 = 13;
				this.O_.0oo_O. = new Point(A_1.X, A_1.Y);
				IL_A3:
				num2 = 14;
				this.OO_00.OO_o. = new Point(A_1.X, A_1.Y);
				IL_BD:
				num2 = 15;
				this.O_O00._. = new O__o00(base.Parent);
				IL_D1:
				num2 = 16;
				this.DynamicKey = ShareLibriay.GetRandString(8);
				IL_E0:
				num2 = 17;
				IEnumerator enumerator = base.Parent.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Control control = (Control)obj;
					IL_103:
					num2 = 18;
					if (control is ControlHolder)
					{
						IL_10F:
						num2 = 19;
						((ControlHolder)control).DynamicKey = this.DynamicKey;
						IL_124:
						num2 = 20;
						this.O_O00._..o.oO0O0OO_o_.((ControlHolder)control);
					}
					IL_139:
					num2 = 21;
				}
				IL_144:
				num2 = 22;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_170;
				}
				goto IL_170;
				IL_15C:
				num2 = 24;
				this.O_O00._. = null;
				IL_166:
				num2 = 25;
				this.o0o0.0OO. = false;
				IL_170:
				goto IL_22A;
				IL_175:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1EB:
				goto IL_21F;
				IL_1ED:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1FD:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_1ED;
			}
			IL_21F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_22A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x001BAB1C File Offset: 0x001B8D1C
		public void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
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
				if (A_1.Button != MouseButtons.Left)
				{
					goto IL_221;
				}
				IL_19:
				num2 = 3;
				if (this.o0o0.0OO.)
				{
					goto IL_7F;
				}
				IL_23:
				num2 = 4;
				Point point = new Point(this.O_.0oo_O..X - A_1.X, this.O_.0oo_O..Y - A_1.Y);
				IL_50:
				num2 = 5;
				if (Math.Abs(point.X) < 3 & Math.Abs(point.Y) < 3)
				{
					goto IL_221;
				}
				IL_76:
				num2 = 8;
				this.o0o0.0OO. = true;
				IL_7F:
				num2 = 9;
				Point point2 = new Point(A_1.X, A_1.Y);
				IL_95:
				num2 = 10;
				if (!this.Activated)
				{
					goto IL_DF;
				}
				IL_A0:
				num2 = 11;
				oOO0oo_o0.O00OO_O_oO_.o.(base.Parent.Controls, point2.X - this.OO_00.OO_o..X, point2.Y - this.OO_00.OO_o..Y, this.DynamicKey);
				IL_DF:
				num2 = 12;
				((o\u3000\u3002)base.FindForm().MdiParent).O0.0O00_O.().Refresh();
				IL_FC:
				num2 = 13;
				if (Control.ModifierKeys == Keys.Shift)
				{
					goto IL_1CA;
				}
				IL_10E:
				num2 = 14;
				Control control = this.O0._o.(((Control)A_0).PointToScreen(new Point(A_1.X, A_1.Y)), base.FindForm(), this, true);
				IL_13C:
				num2 = 15;
				if (control != null)
				{
					goto IL_14C;
				}
				IL_142:
				num2 = 16;
				control = base.FindForm();
				IL_14C:
				num2 = 17;
				control.Refresh();
				IL_155:
				num2 = 18;
				if (base.Parent == control)
				{
					goto IL_1CA;
				}
				IL_161:
				num2 = 19;
				Point p = base.Parent.PointToScreen(base.Location);
				IL_177:
				num2 = 20;
				p = control.PointToClient(p);
				IL_184:
				num2 = 21;
				int a_ = p.X - base.Location.X;
				IL_1A0:
				num2 = 22;
				int a_2 = p.Y - base.Location.Y;
				IL_1BC:
				num2 = 23;
				this.O.O_000.(control, a_, a_2);
				IL_1CA:
				num2 = 24;
				if (base.Parent != this.O_O00._.)
				{
					goto IL_1F0;
				}
				IL_1DB:
				num2 = 25;
				((Control)A_0).Cursor = Cursors.SizeAll;
				goto IL_221;
				IL_1F0:
				num2 = 27;
				((Control)A_0).Cursor = new Cursor(c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\Images\\DRAGMOVE.CUR");
				IL_221:
				goto IL_2E3;
				IL_226:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2A4:
				goto IL_2D8;
				IL_2A6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2B6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2A6;
			}
			IL_2D8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x001BAE30 File Offset: 0x001B9030
		public void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (((Control)A_0).Cursor != Cursors.SizeAll)
			{
				((Control)A_0).Cursor = Cursors.SizeAll;
			}
			if (this.o0o0.0OO.)
			{
				this.o0o0.0OO. = false;
			}
			if (this.o_o_O._. != base.Location && this.O_O00._. != null)
			{
				((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).o_0O.OO0_0_..Add(this.O_O00._.);
				this.O_O00._. = null;
			}
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x001BAEB0 File Offset: 0x001B90B0
		private void <<EMPTY_NAME>>(Control A_0, int A_1, int A_2)
		{
			List<ControlHolder> list = new List<ControlHolder>();
			try
			{
				foreach (object obj in base.Parent.Controls)
				{
					Control control = (Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.Selected & Operators.CompareString(controlHolder.DynamicKey, this.DynamicKey, true) == 0)
						{
							list.Add((ControlHolder)control);
						}
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
			try
			{
				foreach (Control control in list)
				{
					ControlHolder controlHolder2 = (ControlHolder)control;
					controlHolder2.Parent = A_0;
					controlHolder2.Location = new Point(controlHolder2.Location.X + A_1, controlHolder2.Location.Y + A_2);
				}
			}
			finally
			{
				List<ControlHolder>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x001BAFC8 File Offset: 0x001B91C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.FocusLabel.Focus();
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x001BAFD8 File Offset: 0x001B91D8
		public Control <<EMPTY_NAME>>(Point A_0, Control A_1, ControlHolder A_2, bool A_3)
		{
			int num;
			Control result;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_2.ParentHolder == null || !A_3)
				{
					goto IL_6C;
				}
				IL_17:
				num2 = 3;
				if (!A_2.Parent.ClientRectangle.Contains(A_2.Parent.PointToClient(A_0)))
				{
					goto IL_6C;
				}
				IL_3B:
				num2 = 4;
				Control control = this.O0._o.(A_0, A_2.Parent, A_2, false);
				IL_4E:
				num2 = 5;
				if (control == null)
				{
					goto IL_5E;
				}
				IL_54:
				num2 = 6;
				result = control;
				goto IL_412;
				IL_5E:
				num2 = 8;
				result = A_2.Parent;
				goto IL_412;
				IL_6C:
				num2 = 9;
				IEnumerator enumerator = A_1.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Control control2 = (Control)obj;
					IL_8F:
					num2 = 10;
					if (control2 != A_2 && control2 is ControlHolder)
					{
						IL_A6:
						num2 = 11;
						ControlHolder controlHolder = (ControlHolder)control2;
						IL_B2:
						num2 = 12;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							IL_E6:
							num2 = 13;
							if (controlHolder.ChildControl.ClientRectangle.Contains(controlHolder.ChildControl.PointToClient(A_0)))
							{
								IL_110:
								num2 = 14;
								control = this.O0._o.(A_0, controlHolder.ChildControl, A_2, false);
								IL_125:
								num2 = 15;
								if (control != null)
								{
									IL_12C:
									num2 = 16;
									result = control;
									goto IL_412;
								}
								IL_137:
								num2 = 18;
								result = controlHolder.ChildControl;
								goto IL_412;
							}
						}
						else
						{
							IL_147:
							num2 = 20;
							if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
							{
								IL_158:
								num2 = 21;
								PictureBox pictureBox = ((CustomPictureBox)controlHolder.ChildControl).PictureBox1;
								IL_16E:
								num2 = 22;
								ControlHolder controlHolder2 = null;
								IL_174:
								num2 = 23;
								Control control3 = pictureBox;
								for (;;)
								{
									IL_1A3:
									num2 = 25;
									if (control3 == null)
									{
										break;
									}
									IL_17D:
									num2 = 26;
									if (control3 is ControlHolder)
									{
										goto IL_189;
									}
									IL_197:
									num2 = 29;
									control3 = control3.Parent;
								}
								IL_1AA:
								num2 = 31;
								if (controlHolder2 == null)
								{
									goto IL_3E6;
								}
								IL_1B4:
								num2 = 33;
								if (!controlHolder2.ClientRectangle.Contains(pictureBox.PointToClient(A_0)))
								{
									goto IL_3E6;
								}
								IL_1D4:
								num2 = 34;
								control = this.O0._o.(A_0, pictureBox, A_2, false);
								IL_1E4:
								num2 = 35;
								if (control != null)
								{
									IL_1EB:
									num2 = 36;
									result = control;
									goto IL_412;
								}
								IL_1F6:
								num2 = 38;
								result = pictureBox;
								goto IL_412;
								IL_189:
								num2 = 27;
								controlHolder2 = (ControlHolder)control3;
								goto IL_1AA;
							}
							IL_201:
							num2 = 40;
							if (controlHolder.ControlType == ControlTypeEnum.TabControl)
							{
								IL_20F:
								num2 = 41;
								C1DockingTab c1DockingTab = (C1DockingTab)controlHolder.ChildControl;
								IL_220:
								num2 = 42;
								if (c1DockingTab.SelectedTab.ClientRectangle.Contains(c1DockingTab.SelectedTab.PointToClient(A_0)))
								{
									IL_247:
									num2 = 43;
									control = this.O0._o.(A_0, c1DockingTab.SelectedTab, A_2, false);
									IL_25C:
									num2 = 44;
									if (control != null)
									{
										IL_263:
										num2 = 45;
										result = control;
										goto IL_412;
									}
									IL_26E:
									num2 = 47;
									result = c1DockingTab.SelectedTab;
									goto IL_412;
								}
								else
								{
									IL_27E:
									c1DockingTab = null;
								}
							}
							else
							{
								IL_286:
								num2 = 50;
								if (controlHolder.ControlType == ControlTypeEnum.NavBar)
								{
									IL_294:
									num2 = 51;
									C1NavBar c1NavBar = (C1NavBar)controlHolder.ChildControl;
									IL_2A5:
									num2 = 52;
									if (c1NavBar.SelectedPanel.ClientRectangle.Contains(c1NavBar.SelectedPanel.PointToClient(A_0)))
									{
										IL_2CC:
										num2 = 53;
										control = this.O0._o.(A_0, c1NavBar.SelectedPanel, A_2, false);
										IL_2E1:
										num2 = 54;
										if (control != null)
										{
											IL_2E8:
											num2 = 55;
											result = control;
											goto IL_412;
										}
										IL_2F3:
										num2 = 57;
										result = c1NavBar.SelectedPanel;
										goto IL_412;
									}
									else
									{
										IL_303:
										c1NavBar = null;
									}
								}
								else
								{
									IL_30B:
									num2 = 60;
									if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
									{
										IL_31C:
										num2 = 61;
										o0000O o0000O = (o0000O)controlHolder.ChildControl;
										IL_32D:
										num2 = 62;
										if (o0000O.oo0oO_O.oooO0O.().ClientRectangle.Contains(o0000O.oo0oO_O.oooO0O.().PointToClient(A_0)))
										{
											IL_354:
											num2 = 63;
											control = this.O0._o.(A_0, o0000O.oo0oO_O.oooO0O.(), A_2, false);
											IL_369:
											num2 = 64;
											if (control != null)
											{
												IL_370:
												num2 = 65;
												result = control;
												goto IL_412;
											}
											IL_37B:
											num2 = 67;
											result = o0000O.oo0oO_O.oooO0O.();
											goto IL_412;
										}
										else
										{
											IL_38B:
											num2 = 68;
											if (o0000O.o.Oo0oo000O.().ClientRectangle.Contains(o0000O.o.Oo0oo000O.().PointToClient(A_0)))
											{
												IL_3B2:
												num2 = 69;
												control = this.O0._o.(A_0, o0000O.o.Oo0oo000O.(), A_2, false);
												IL_3C7:
												num2 = 70;
												if (control != null)
												{
													IL_3CE:
													num2 = 71;
													result = control;
													goto IL_412;
												}
												IL_3D6:
												num2 = 73;
												result = o0000O.o.Oo0oo000O.();
												goto IL_412;
											}
											else
											{
												IL_3E3:
												o0000O = null;
											}
										}
									}
								}
							}
						}
					}
					IL_3E6:
					num2 = 75;
				}
				IL_3F5:
				num2 = 76;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_40D:
				num2 = 77;
				result = null;
				IL_412:
				goto IL_59C;
				IL_417:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_55D:
				goto IL_591;
				IL_55F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_56F:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_55F;
			}
			IL_591:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_59C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x001BB5A8 File Offset: 0x001B97A8
		public O_O_ <<EMPTY_NAME>>()
		{
			Control control = (C1DockingTab)this.ChildControl;
			O_O_ o_O_ = new O_O_();
			control.Controls.Add(o_O_);
			o\u3002\u3002\u3000\u3000\u3002 @object = (o\u3002\u3002\u3000\u3000\u3002)base.FindForm();
			o_O_.Click += this.Ooo0O00_0._O0.;
			o_O_.MouseDown += this.o_.0Oo.;
			o_O_.MouseDown += @object.O0ooOo0.o.;
			o_O_.MouseMove += @object.oooo_._O.;
			o_O_.MouseUp += @object.OOOoO.Oo_O0o_0.;
			o_O_.AllowDrop = true;
			o_O_.DragEnter += @object.o_.000OOOoo.;
			o_O_.DragDrop += @object.o.Ooo0__0.;
			return o_O_;
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x001BB668 File Offset: 0x001B9868
		internal oO_0 <<EMPTY_NAME>>()
		{
			Control control = (C1NavBar)this.ChildControl;
			oO_0 oO_ = new oO_0();
			control.Controls.Add(oO_);
			o\u3002\u3002\u3000\u3000\u3002 @object = (o\u3002\u3002\u3000\u3000\u3002)base.FindForm();
			oO_.Click += this.Ooo0O00_0._O0.;
			oO_.MouseDown += this.o_.0Oo.;
			oO_.MouseDown += @object.O0ooOo0.o.;
			oO_.MouseMove += @object.oooo_._O.;
			oO_.MouseUp += @object.OOOoO.Oo_O0o_0.;
			oO_.AllowDrop = true;
			oO_.DragEnter += @object.o_.000OOOoo.;
			oO_.DragDrop += @object.o.Ooo0__0.;
			return oO_;
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x001BB728 File Offset: 0x001B9928
		private void <<EMPTY_NAME>>(object A_0, SelectedIndexChangingEventArgs A_1)
		{
			C1DockingTab c1DockingTab = (C1DockingTab)A_0;
			if (c1DockingTab.SelectedTab != null)
			{
				oOO0oo_o0.o0.Oo__.(c1DockingTab.SelectedTab.Controls);
			}
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x001BB756 File Offset: 0x001B9956
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.FindForm() != null)
			{
				PropertyGridEx2 propertyGridEx = ((o\u3000\u3002)base.FindForm().MdiParent).O0.0O00_O.();
				propertyGridEx.SelectedObjects = propertyGridEx.SelectedObjects;
			}
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x001BB784 File Offset: 0x001B9984
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in ((C1NavBar)A_0).Panels)
				{
					oOO0oo_o0.o0.Oo__.(((C1NavBarPanel)obj).Controls);
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
			if (base.FindForm() != null)
			{
				PropertyGridEx2 propertyGridEx = ((o\u3000\u3002)base.FindForm().MdiParent).O0.0O00_O.();
				propertyGridEx.SelectedObjects = propertyGridEx.SelectedObjects;
			}
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001BB814 File Offset: 0x001B9A14
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.IsFixedHeight)
			{
				base.Height = this.ChildControl.Height;
			}
			if (this.IsFixedWidth)
			{
				base.Width = this.ChildControl.Width;
			}
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x001BB848 File Offset: 0x001B9A48
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.FindForm() != null && this.ChildControl is C1TextBox)
			{
				C1TextBox c1TextBox = (C1TextBox)this.ChildControl;
				if (!c1TextBox.Multiline)
				{
					base.Height = c1TextBox.PreferredHeight;
				}
			}
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x001BB88C File Offset: 0x001B9A8C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.ChildControl is C1TextBox)
			{
				C1TextBox c1TextBox = (C1TextBox)this.ChildControl;
				if (!c1TextBox.Multiline)
				{
					base.Height = c1TextBox.PreferredHeight;
				}
				else
				{
					base.Height = c1TextBox.PreferredHeight * 5;
				}
			}
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x001BB8D8 File Offset: 0x001B9AD8
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			((o\u3000\u3002)base.FindForm().MdiParent).O0.0O00_O.().Refresh();
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x001BB8F4 File Offset: 0x001B9AF4
		private void <<EMPTY_NAME>>(object A_0, NodeLabelEditEventArgs A_1)
		{
			PropertyGridEx2 propertyGridEx = ((o\u3000\u3002)base.FindForm().MdiParent).O0.0O00_O.();
			propertyGridEx.SelectedObjects = propertyGridEx.SelectedObjects;
			if (this.O_O00._. != null && Operators.CompareString(this.O_O00._..o_0_0.O_o__0o.(), A_1.Label, true) != 0)
			{
				((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).o_0O.OO0_0_..Add(this.O_O00._.);
			}
			this.O_O00._. = null;
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x001BB966 File Offset: 0x001B9B66
		private void <<EMPTY_NAME>>(object A_0, NodeLabelEditEventArgs A_1)
		{
			this.O_O00._. = new O0oo_0O(A_1.Node, this);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x001BB97C File Offset: 0x001B9B7C
		public void <<EMPTY_NAME>>()
		{
			o\u3002\u3002\u3000\u3000\u3002 o_u3002_u3002_u3000_u3000_u = (o\u3002\u3002\u3000\u3000\u3002)base.FindForm();
			if (this.ChildControl is Panel)
			{
				((Panel)this.ChildControl).AutoScrollPosition = new Point(0, 0);
			}
			if (this.ControlType == ControlTypeEnum.Table)
			{
				string text = Conversions.ToString(this.DataRow["Key"]);
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					text,
					o0_O.Oo.Oo__O.
				});
				if (dataRow != null)
				{
					dataRow["Config"] = "";
				}
			}
			this.DataRow["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.[this.Key], false, '\v', false);
			string text2 = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.[this.Key], true, '\v', false);
			if (Operators.CompareString(text2, "", true) > 0)
			{
				this.DataRow["Code"] = "{" + O00.ooo000o_0.00o0.(text2, ooO0__OO.O_Oo00oO.Ooo.(), Oo00.ooO.ooo.()) + "}";
			}
			else
			{
				this.DataRow["Code"] = null;
			}
			if (this.ControlType == ControlTypeEnum.Panel | this.ControlType == ControlTypeEnum.GroupBox | this.ControlType == ControlTypeEnum.Gauges | this.ControlType == ControlTypeEnum.Map)
			{
				try
				{
					foreach (object obj in this.ChildControl.Controls)
					{
						Control control = (Control)obj;
						if (control is ControlHolder)
						{
							((ControlHolder)control).oO_O.0O__o.();
						}
					}
					return;
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			if (this.ControlType == ControlTypeEnum.PictureBox)
			{
				try
				{
					foreach (object obj2 in ((CustomPictureBox)this.ChildControl).PictureBox1.Controls)
					{
						Control control = (Control)obj2;
						if (control is ControlHolder)
						{
							((ControlHolder)control).oO_O.0O__o.();
						}
					}
					return;
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			if (this.ControlType == ControlTypeEnum.TabControl)
			{
				C1DockingTab c1DockingTab = (C1DockingTab)this.ChildControl;
				try
				{
					foreach (object obj3 in c1DockingTab.TabPages)
					{
						O_O_ o_O_ = (O_O_)obj3;
						try
						{
							foreach (object obj4 in o_O_.Controls)
							{
								Control control = (Control)obj4;
								if (control is ControlHolder)
								{
									((ControlHolder)control).oO_O.0O__o.();
									((ControlHolder)control).DataRow["Page"] = c1DockingTab.TabPages.IndexOf(o_O_);
								}
							}
						}
						finally
						{
							IEnumerator enumerator4;
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				c1DockingTab = null;
			}
			else if (this.ControlType == ControlTypeEnum.NavBar)
			{
				C1NavBar c1NavBar = (C1NavBar)this.ChildControl;
				try
				{
					foreach (object obj5 in c1NavBar.Panels)
					{
						oO_0 oO_ = (oO_0)obj5;
						try
						{
							foreach (object obj6 in oO_.Controls)
							{
								Control control = (Control)obj6;
								if (control is ControlHolder)
								{
									((ControlHolder)control).oO_O.0O__o.();
									((ControlHolder)control).DataRow["Page"] = c1NavBar.Panels.IndexOf(oO_);
								}
							}
						}
						finally
						{
							IEnumerator enumerator6;
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				c1NavBar = null;
			}
			else if (this.ControlType == ControlTypeEnum.SplitContainer)
			{
				o0000O o0000O = (o0000O)this.ChildControl;
				try
				{
					foreach (object obj7 in o0000O.oo0oO_O.oooO0O.().Controls)
					{
						Control control = (Control)obj7;
						if (control is ControlHolder)
						{
							((ControlHolder)control).oO_O.0O__o.();
							((ControlHolder)control).DataRow["Page"] = 1;
						}
					}
				}
				finally
				{
					IEnumerator enumerator7;
					if (enumerator7 is IDisposable)
					{
						(enumerator7 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj8 in o0000O.o.Oo0oo000O.().Controls)
					{
						Control control = (Control)obj8;
						if (control is ControlHolder)
						{
							((ControlHolder)control).oO_O.0O__o.();
							((ControlHolder)control).DataRow["Page"] = 2;
						}
					}
				}
				finally
				{
					IEnumerator enumerator8;
					if (enumerator8 is IDisposable)
					{
						(enumerator8 as IDisposable).Dispose();
					}
				}
				o0000O = null;
			}
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x001BBED4 File Offset: 0x001BA0D4
		public DataRow <<EMPTY_NAME>>(DataTable A_0)
		{
			int num;
			DataRow result;
			int num5;
			object obj9;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				DataRow dataRow = A_0.NewRow();
				IL_11:
				num2 = 3;
				dataRow.ItemArray = this.DataRow.ItemArray;
				IL_25:
				num2 = 4;
				A_0.Rows.Add(dataRow);
				IL_34:
				num2 = 5;
				o\u3002\u3002\u3000\u3000\u3002 o_u3002_u3002_u3000_u3000_u = (o\u3002\u3002\u3000\u3000\u3002)base.FindForm();
				IL_43:
				num2 = 6;
				dataRow["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.[this.Key], false, '\v', false);
				IL_6C:
				num2 = 7;
				string a_ = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.[this.Key], true, '\v', false);
				IL_8B:
				num2 = 8;
				dataRow["Code"] = "{" + O00.ooo000o_0.00o0.(a_, ooO0__OO.O_Oo00oO.Ooo.(), Oo00.ooO.ooo.()) + "}";
				IL_B9:
				num2 = 9;
				if (!(this.ControlType == ControlTypeEnum.Panel | this.ControlType == ControlTypeEnum.GroupBox | this.ControlType == ControlTypeEnum.Gauges | this.ControlType == ControlTypeEnum.Map))
				{
					goto IL_157;
				}
				IL_E9:
				num2 = 10;
				IEnumerator enumerator = this.ChildControl.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Control control = (Control)obj;
					IL_10E:
					num2 = 11;
					if (control is ControlHolder)
					{
						IL_11A:
						num2 = 12;
						((ControlHolder)control).o_.0Oo.(A_0);
					}
					IL_12B:
					num2 = 13;
				}
				IL_137:
				num2 = 14;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_4F0;
				}
				goto IL_4F0;
				IL_157:
				num2 = 16;
				if (this.ControlType != ControlTypeEnum.PictureBox)
				{
					goto IL_1DC;
				}
				IL_164:
				num2 = 17;
				IEnumerator enumerator2 = ((CustomPictureBox)this.ChildControl).PictureBox1.Controls.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					Control control = (Control)obj2;
					IL_193:
					num2 = 18;
					if (control is ControlHolder)
					{
						IL_19F:
						num2 = 19;
						((ControlHolder)control).o_.0Oo.(A_0);
					}
					IL_1B0:
					num2 = 20;
				}
				IL_1BC:
				num2 = 21;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
					goto IL_4F0;
				}
				goto IL_4F0;
				IL_1DC:
				num2 = 23;
				if (this.ControlType != ControlTypeEnum.TabControl)
				{
					goto IL_2DB;
				}
				IL_1EC:
				num2 = 24;
				C1DockingTab c1DockingTab = (C1DockingTab)this.ChildControl;
				IL_1FC:
				num2 = 25;
				IEnumerator enumerator3 = c1DockingTab.TabPages.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					object obj3 = enumerator3.Current;
					O_O_ o_O_ = (O_O_)obj3;
					IL_220:
					num2 = 26;
					IEnumerator enumerator4 = o_O_.Controls.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						object obj4 = enumerator4.Current;
						Control control = (Control)obj4;
						IL_241:
						num2 = 27;
						if (control is ControlHolder)
						{
							IL_24D:
							num2 = 28;
							int num3 = c1DockingTab.TabPages.IndexOf(o_O_);
							IL_260:
							num2 = 29;
							DataRow dataRow2 = ((ControlHolder)control).o_.0Oo.(A_0);
							IL_272:
							num2 = 30;
							dataRow2["Page"] = num3;
						}
						IL_288:
						num2 = 31;
					}
					IL_294:
					num2 = 32;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
					IL_2AC:
					num2 = 33;
				}
				IL_2BB:
				num2 = 34;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
				IL_2D3:
				c1DockingTab = null;
				goto IL_4F0;
				IL_2DB:
				num2 = 37;
				if (this.ControlType != ControlTypeEnum.NavBar)
				{
					goto IL_3D3;
				}
				IL_2EB:
				num2 = 38;
				C1NavBar c1NavBar = (C1NavBar)this.ChildControl;
				IL_2FB:
				num2 = 39;
				IEnumerator enumerator5 = c1NavBar.Panels.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					object obj5 = enumerator5.Current;
					oO_0 oO_ = (oO_0)obj5;
					IL_31F:
					num2 = 40;
					IEnumerator enumerator6 = oO_.Controls.GetEnumerator();
					while (enumerator6.MoveNext())
					{
						object obj6 = enumerator6.Current;
						Control control = (Control)obj6;
						IL_340:
						num2 = 41;
						if (control is ControlHolder)
						{
							IL_34C:
							num2 = 42;
							DataRow dataRow2 = ((ControlHolder)control).o_.0Oo.(A_0);
							IL_35E:
							num2 = 43;
							dataRow2["Page"] = c1NavBar.Panels.IndexOf(oO_);
						}
						IL_380:
						num2 = 44;
					}
					IL_38C:
					num2 = 45;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
					IL_3A4:
					num2 = 46;
				}
				IL_3B3:
				num2 = 47;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
				IL_3CB:
				c1NavBar = null;
				goto IL_4F0;
				IL_3D3:
				num2 = 50;
				if (this.ControlType != ControlTypeEnum.SplitContainer)
				{
					goto IL_4F0;
				}
				IL_3E3:
				num2 = 51;
				o0000O o0000O = (o0000O)this.ChildControl;
				IL_3F3:
				num2 = 52;
				IEnumerator enumerator7 = o0000O.oo0oO_O.oooO0O.().Controls.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					object obj7 = enumerator7.Current;
					Control control = (Control)obj7;
					IL_419:
					num2 = 53;
					if (control is ControlHolder)
					{
						IL_425:
						num2 = 54;
						DataRow dataRow2 = ((ControlHolder)control).o_.0Oo.(A_0);
						IL_437:
						num2 = 55;
						dataRow2["Page"] = 1;
					}
					IL_44C:
					num2 = 56;
				}
				IL_458:
				num2 = 57;
				if (enumerator7 is IDisposable)
				{
					(enumerator7 as IDisposable).Dispose();
				}
				IL_470:
				num2 = 58;
				IEnumerator enumerator8 = o0000O.o.Oo0oo000O.().Controls.GetEnumerator();
				while (enumerator8.MoveNext())
				{
					object obj8 = enumerator8.Current;
					Control control = (Control)obj8;
					IL_496:
					num2 = 59;
					if (control is ControlHolder)
					{
						IL_4A2:
						num2 = 60;
						DataRow dataRow2 = ((ControlHolder)control).o_.0Oo.(A_0);
						IL_4B4:
						num2 = 61;
						dataRow2["Page"] = 2;
					}
					IL_4C9:
					num2 = 62;
				}
				IL_4D5:
				num2 = 63;
				if (enumerator8 is IDisposable)
				{
					(enumerator8 as IDisposable).Dispose();
				}
				IL_4ED:
				o0000O = null;
				IL_4F0:
				o_u3002_u3002_u3000_u3000_u = null;
				IL_4F3:
				num2 = 66;
				result = dataRow;
				IL_4F9:
				goto IL_657;
				IL_4FE:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_618:
				goto IL_64C;
				IL_61A:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_62A:;
			}
			catch when (endfilter(obj9 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj10;
				goto IL_61A;
			}
			IL_64C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_657:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x001BC560 File Offset: 0x001BA760
		public void <<EMPTY_NAME>>(object A_0, SplitterCancelEventArgs A_1)
		{
			if (this.O_.0oo_O. == null)
			{
				this.O_.0oo_O. = new o00OOoo(this);
			}
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x001BC576 File Offset: 0x001BA776
		public void <<EMPTY_NAME>>(object A_0, SplitterEventArgs A_1)
		{
			if (this.O_.0oo_O. != null)
			{
				((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).o_0O.OO0_0_..Add(this.O_.0oo_O.);
				this.O_.0oo_O. = null;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x001BC5A2 File Offset: 0x001BA7A2
		// (set) Token: 0x06003CE6 RID: 15590 RVA: 0x001BC5AA File Offset: 0x001BA7AA
		public string DynamicKey
		{
			get
			{
				return this.OOOOooo0000.o.;
			}
			set
			{
				this.OOOOooo0000.o. = value;
			}
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x001BC5B4 File Offset: 0x001BA7B4
		private void <<EMPTY_NAME>>(object A_0, PaintEventArgs A_1)
		{
			if (this.ControlType == ControlTypeEnum.Line)
			{
				if (!this.Selected)
				{
					try
					{
						base.Region = this.ChildControl.Region;
						return;
					}
					catch (Exception ex)
					{
						return;
					}
				}
				base.Region = null;
			}
		}

		// Token: 0x040018F5 RID: 6389
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018F6 RID: 6390
		[AccessedThroughProperty("FocusLabel")]
		[CompilerGenerated]
		private TextBox <<EMPTY_NAME>>;

		// Token: 0x040018F7 RID: 6391
		private bool <<EMPTY_NAME>>;

		// Token: 0x040018F8 RID: 6392
		private bool <<EMPTY_NAME>>;

		// Token: 0x040018F9 RID: 6393
		private bool <<EMPTY_NAME>>;

		// Token: 0x040018FA RID: 6394
		private string <<EMPTY_NAME>>;

		// Token: 0x040018FB RID: 6395
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x040018FC RID: 6396
		private string <<EMPTY_NAME>>;

		// Token: 0x040018FD RID: 6397
		[CompilerGenerated]
		private ControlHolder.oOo <<EMPTY_NAME>>;

		// Token: 0x040018FE RID: 6398
		[CompilerGenerated]
		private ControlHolder.o_o_0oO0o000 <<EMPTY_NAME>>;

		// Token: 0x040018FF RID: 6399
		[CompilerGenerated]
		private ControlHolder.OO__oOoO_ <<EMPTY_NAME>>;

		// Token: 0x04001900 RID: 6400
		[CompilerGenerated]
		private ControlHolder.oo_O__O_ <<EMPTY_NAME>>;

		// Token: 0x04001901 RID: 6401
		internal o0O__ooOO00 <<EMPTY_NAME>>;

		// Token: 0x04001902 RID: 6402
		private Point <<EMPTY_NAME>>;

		// Token: 0x04001903 RID: 6403
		private Point <<EMPTY_NAME>>;

		// Token: 0x04001904 RID: 6404
		private Control <<EMPTY_NAME>>;

		// Token: 0x04001905 RID: 6405
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001906 RID: 6406
		private Control <<EMPTY_NAME>>;

		// Token: 0x04001907 RID: 6407
		private ControlTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04001908 RID: 6408
		private O__o00 <<EMPTY_NAME>>;

		// Token: 0x04001909 RID: 6409
		private o00OOoo <<EMPTY_NAME>>;

		// Token: 0x0400190A RID: 6410
		private O0oo_0O <<EMPTY_NAME>>;

		// Token: 0x0400190B RID: 6411
		private Point <<EMPTY_NAME>>;

		// Token: 0x0400190C RID: 6412
		private int <<EMPTY_NAME>>;

		// Token: 0x0400190D RID: 6413
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x0200039E RID: 926
		// (Invoke) Token: 0x06003CEB RID: 15595
		public delegate void oOo(ControlHolder A_0);

		// Token: 0x0200039F RID: 927
		// (Invoke) Token: 0x06003CEF RID: 15599
		public delegate void o_o_0oO0o000(ControlHolder A_0);

		// Token: 0x020003A0 RID: 928
		// (Invoke) Token: 0x06003CF3 RID: 15603
		public delegate void OO__oOoO_(ControlHolder A_0);

		// Token: 0x020003A1 RID: 929
		// (Invoke) Token: 0x06003CF7 RID: 15607
		public delegate void oo_O__O_(ControlHolder A_0);
	}
}

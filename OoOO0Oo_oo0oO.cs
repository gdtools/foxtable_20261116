using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003DE RID: 990
	internal class OoOO0Oo_oo0oO : C1DropDownControl, O000O
	{
		// Token: 0x0600407D RID: 16509 RVA: 0x001D43D7 File Offset: 0x001D25D7
		[CompilerGenerated]
		internal virtual System.Windows.Forms.ListBox <<EMPTY_NAME>>()
		{
			return this.O.__.;
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x001D43E0 File Offset: 0x001D25E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.ListBox A_0)
		{
			EventHandler value = new EventHandler(this.O_O_OoOoOo.o0_.);
			ListControlConvertEventHandler value2 = new ListControlConvertEventHandler(this.O_oOO_._o.);
			System.Windows.Forms.ListBox o.__. = this.O.__.;
			if (o.__. != null)
			{
				o.__..SelectedIndexChanged -= value;
				o.__..Format -= value2;
			}
			this.O.__. = A_0;
			o.__. = this.O.__.;
			if (o.__. != null)
			{
				o.__..SelectedIndexChanged += value;
				o.__..Format += value2;
			}
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x001D4440 File Offset: 0x001D2640
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(OoOO0Oo_oo0oO.o0__0 A_0)
		{
			OoOO0Oo_oo0oO.o0__0 o0__ = this.O_o_.O.;
			OoOO0Oo_oo0oO.o0__0 o0__2;
			do
			{
				o0__2 = o0__;
				OoOO0Oo_oo0oO.o0__0 value = (OoOO0Oo_oo0oO.o0__0)Delegate.Combine(o0__2, A_0);
				o0__ = Interlocked.CompareExchange<OoOO0Oo_oo0oO.o0__0>(ref this.O_o_.O., value, o0__2);
			}
			while (o0__ != o0__2);
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x001D4478 File Offset: 0x001D2678
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(OoOO0Oo_oo0oO.o0__0 A_0)
		{
			OoOO0Oo_oo0oO.o0__0 o0__ = this.O_o_.O.;
			OoOO0Oo_oo0oO.o0__0 o0__2;
			do
			{
				o0__2 = o0__;
				OoOO0Oo_oo0oO.o0__0 value = (OoOO0Oo_oo0oO.o0__0)Delegate.Remove(o0__2, A_0);
				o0__ = Interlocked.CompareExchange<OoOO0Oo_oo0oO.o0__0>(ref this.O_o_.O., value, o0__2);
			}
			while (o0__ != o0__2);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x001D44B0 File Offset: 0x001D26B0
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(OoOO0Oo_oo0oO.oo0O00O A_0)
		{
			OoOO0Oo_oo0oO.oo0O00O oo0O00O = this.O.oO.;
			OoOO0Oo_oo0oO.oo0O00O oo0O00O2;
			do
			{
				oo0O00O2 = oo0O00O;
				OoOO0Oo_oo0oO.oo0O00O value = (OoOO0Oo_oo0oO.oo0O00O)Delegate.Combine(oo0O00O2, A_0);
				oo0O00O = Interlocked.CompareExchange<OoOO0Oo_oo0oO.oo0O00O>(ref this.O.oO., value, oo0O00O2);
			}
			while (oo0O00O != oo0O00O2);
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x001D44E8 File Offset: 0x001D26E8
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(OoOO0Oo_oo0oO.oo0O00O A_0)
		{
			OoOO0Oo_oo0oO.oo0O00O oo0O00O = this.O.oO.;
			OoOO0Oo_oo0oO.oo0O00O oo0O00O2;
			do
			{
				oo0O00O2 = oo0O00O;
				OoOO0Oo_oo0oO.oo0O00O value = (OoOO0Oo_oo0oO.oo0O00O)Delegate.Remove(oo0O00O2, A_0);
				oo0O00O = Interlocked.CompareExchange<OoOO0Oo_oo0oO.oo0O00O>(ref this.O.oO., value, oo0O00O2);
			}
			while (oo0O00O != oo0O00O2);
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x001D4520 File Offset: 0x001D2720
		internal OoOO0Oo_oo0oO()
		{
			base.DropDownClosed += this.O_oOO_._o.;
			base.DropDownOpened += this.o.0_o0OO.;
			base.Enter += this.O0o00oo.O0_.;
			base.FontChanged += this.O00o.o.;
			base.GotFocus += this.oo0_._O0_0.;
			base.KeyDown += this.O_oOO_._o.;
			base.KeyPress += this.O_oOO_._o.;
			base.Validated += this.O_o0o0_Oo.0.;
			this.O.oO. = BooleanEnum.Default;
			this.O.__. = true;
			this.O0_0oo.___o. = 11;
			this.oo__Oo_.oO. = -1;
			this.ShowUpDownButtons = false;
			this.O.oO. = new O\u30000\u3002\u3002O();
			this.o__0_OooO0._.(this.O.oO..OOOO.0.());
			this.DropDownForm = this.O.oO.;
			this.O__oo_OO.O_.().Font = this.Font;
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
			base.EmptyAsNull = true;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.AutoTabWhenFilled = true;
			base.MaskInfo.EmptyAsNull = true;
			base.ErrorInfo.ShowErrorMessage = false;
			base.AutoSize = false;
			base.VerticalAlign = VerticalAlignEnum.Middle;
			base.Padding = new Padding(1, 2, 1, 1);
			this.DateTimeInput = false;
			this.NumericInput = false;
			base.ExitOnLeftRightKey = ExitOnLeftRightKey.Both;
			base.ExitOnLastChar = true;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x001D46AB File Offset: 0x001D28AB
		protected virtual void <<EMPTY_NAME>>(ref Message A_0)
		{
			if (A_0.Msg != 770 || this.oo0.ooo.())
			{
				base.WndProc(ref A_0);
			}
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x001D46C9 File Offset: 0x001D28C9
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.O.oO.;
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x001D46D1 File Offset: 0x001D28D1
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.O.oO. = A_0;
			ooO_0O.o_O0.O_.(this, this.O__oo_OO.O_.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x001D46F2 File Offset: 0x001D28F2
		public bool <<EMPTY_NAME>>()
		{
			return this.O.__.;
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x001D46FA File Offset: 0x001D28FA
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O.__. = A_0;
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x001D4703 File Offset: 0x001D2903
		public System.Windows.Forms.ListBox.ObjectCollection <<EMPTY_NAME>>()
		{
			return this.O__oo_OO.O_.().Items;
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x001D4710 File Offset: 0x001D2910
		public string <<EMPTY_NAME>>()
		{
			return this.O__oo_OO.O_.().DisplayMember;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x001D471D File Offset: 0x001D291D
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.O__oo_OO.O_.().DisplayMember = A_0;
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x001D472B File Offset: 0x001D292B
		public string <<EMPTY_NAME>>()
		{
			return this.O__oo_OO.O_.().ValueMember;
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x001D4738 File Offset: 0x001D2938
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.O__oo_OO.O_.().ValueMember = A_0;
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x001D4746 File Offset: 0x001D2946
		public object <<EMPTY_NAME>>()
		{
			return this.O__oo_OO.O_.().DataSource;
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x001D4754 File Offset: 0x001D2954
		public void <<EMPTY_NAME>>(object A_0)
		{
			string a_ = this.O_o0o0_Oo.0.();
			this.O__oo_OO.O_.().DataSource = RuntimeHelpers.GetObjectValue(A_0);
			this.o_O0.OO0o0O0o.(a_);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x001D4780 File Offset: 0x001D2980
		public bool <<EMPTY_NAME>>()
		{
			return this.O__oo_OO.O_.().MultiColumn;
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x001D478D File Offset: 0x001D298D
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O__oo_OO.O_.().MultiColumn = A_0;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x001D479B File Offset: 0x001D299B
		public int <<EMPTY_NAME>>()
		{
			return this.O__oo_OO.O_.().ColumnWidth;
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x001D47A8 File Offset: 0x001D29A8
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O__oo_OO.O_.().ColumnWidth = A_0;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x001D47B6 File Offset: 0x001D29B6
		public int <<EMPTY_NAME>>()
		{
			return this.O.__.;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x001D47BE File Offset: 0x001D29BE
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O.__. = A_0;
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x001D47C7 File Offset: 0x001D29C7
		public int <<EMPTY_NAME>>()
		{
			return this.ooo_.000.;
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x001D47CF File Offset: 0x001D29CF
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.ooo_.000. = A_0;
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x001D47D8 File Offset: 0x001D29D8
		public int <<EMPTY_NAME>>()
		{
			return this.O0_0oo.___o.;
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x001D47E0 File Offset: 0x001D29E0
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O0_0oo.___o. = A_0;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x001D47EC File Offset: 0x001D29EC
		private void <<EMPTY_NAME>>(object A_0, DropDownClosedEventArgs A_1)
		{
			if (this.DropDownForm != this.O.oO.)
			{
				this.DropDownForm = this.O.oO.;
			}
			if (this.OO0._0O.() != null & this.Oo00.O_O0OO___.)
			{
				this.Oo00.O_O0OO___. = false;
				((DataView)this.OO0._0O.()).RowFilter = this.O.oO.;
			}
			if (this.oo__Oo_.oO. != this.O__oo_OO.O_.().SelectedIndex && base.UpdateValueWithCurrentText() && base.DataBindings.Count > 0)
			{
				base.DataBindings[0].WriteValue();
			}
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x001D487C File Offset: 0x001D2A7C
		internal void <<EMPTY_NAME>>()
		{
			if (this.DropDownForm == this.O.oO.)
			{
				this.oo__Oo_.oO. = true;
				if (this.Value == null)
				{
					this.O__oo_OO.O_.().SelectedIndex = -1;
				}
				else if (this.O__oo_OO.O_.().DataSource == null)
				{
					this.O__oo_OO.O_.().SelectedIndex = this.O__oo_OO.O_.().FindStringExact(this.Value.ToString());
				}
				else
				{
					this.O__oo_OO.O_.().SelectedIndex = ((DataView)this.O__oo_OO.O_.().DataSource).Find(RuntimeHelpers.GetObjectValue(this.Value));
				}
				this.oo__Oo_.oO. = false;
				if (this.O.oOo.() > 0)
				{
					this.O.oO..Width = Math.Max(60, this.O.oOo.());
				}
				else
				{
					this.O.oO..Width = Math.Max(60, base.Width);
				}
				int num = Math.Min(this.o0Oo_.o_.(), Math.Max(1, this.O__oo_OO.O_.().Items.Count));
				if (this.O_o0o0_Oo.0.() > 0)
				{
					num = Math.Min(num, (int)Convert.ToInt16(Math.Floor((double)(this.O_o0o0_Oo.0.() - 4) / (double)this.O__oo_OO.O_.().ItemHeight)));
				}
				num = Math.Max(1, Math.Min(num, this.O__oo_OO.O_.().Items.Count));
				this.O.oO..OOOO.0.().Height = this.O.oO..OOOO.0.().ItemHeight * num + 4;
				this.O.oO..Height = this.O.oO..OOOO.0.().Height;
				this.oo__Oo_.oO. = this.O__oo_OO.O_.().SelectedIndex;
			}
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x001D4A13 File Offset: 0x001D2C13
		internal int <<EMPTY_NAME>>()
		{
			return this.O.oO..O0o0o.o.();
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x001D4A20 File Offset: 0x001D2C20
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.O.oO..OOOO.0.(A_0);
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x001D4A30 File Offset: 0x001D2C30
		public int <<EMPTY_NAME>>()
		{
			int result;
			if (base.DroppedDown || this.O.oO..Visible)
			{
				result = this.O__oo_OO.O_.().SelectedIndex;
			}
			else if (this.Value == null)
			{
				result = -1;
			}
			else if (this.OO0._0O.() == null)
			{
				result = this.O_o0o0_Oo.0.().IndexOf(RuntimeHelpers.GetObjectValue(this.Value));
			}
			else
			{
				result = ((DataView)this.OO0._0O.()).Find(RuntimeHelpers.GetObjectValue(this.Value));
			}
			return result;
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x001D4AAC File Offset: 0x001D2CAC
		public void <<EMPTY_NAME>>(int A_0)
		{
			if (base.DroppedDown)
			{
				this.O__oo_OO.O_.().SelectedIndex = A_0;
				return;
			}
			if (A_0 == -1)
			{
				this.Value = null;
				return;
			}
			if (this.O__oo_OO.O_.().DataSource == null)
			{
				this.Value = RuntimeHelpers.GetObjectValue(this.O__oo_OO.O_.().Items[A_0]);
				return;
			}
			this.Value = RuntimeHelpers.GetObjectValue(((DataView)this.OO0._0O.())[A_0][this.Ooo_O__.0o.()]);
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x001D4B2C File Offset: 0x001D2D2C
		public object <<EMPTY_NAME>>()
		{
			object result;
			if (base.DroppedDown || this.O.oO..Visible)
			{
				if (this.O__oo_OO.O_.().SelectedIndex == -1)
				{
					result = null;
				}
				else if (this.OO0._0O.() == null)
				{
					result = this.O__oo_OO.O_.().SelectedItem;
				}
				else
				{
					result = new DataRow(((DataRowView)this.O__oo_OO.O_.().SelectedItem).Row);
				}
			}
			else if (this.Value == null)
			{
				result = null;
			}
			else if (this.OO0._0O.() == null)
			{
				if (this.O_o0o0_Oo.0.().Contains(RuntimeHelpers.GetObjectValue(this.Value)))
				{
					result = this.Value;
				}
				else
				{
					result = null;
				}
			}
			else
			{
				int num = ((DataView)this.OO0._0O.()).Find(RuntimeHelpers.GetObjectValue(this.Value));
				if (num >= 0)
				{
					result = new DataRow(((DataView)this.OO0._0O.())[num].Row);
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x001D4C14 File Offset: 0x001D2E14
		public void <<EMPTY_NAME>>(object A_0)
		{
			if (base.DroppedDown)
			{
				if (A_0 == null)
				{
					this.O__oo_OO.O_.().SelectedIndex = -1;
					return;
				}
				if (this.OO0._0O.() != null)
				{
					DataRow dataRow = (DataRow)A_0;
					int num = ((DataView)this.OO0._0O.()).Find(RuntimeHelpers.GetObjectValue(dataRow[this.Ooo_O__.0o.()]));
					if (num >= 0)
					{
						this.O_.oOO00.(num);
					}
					return;
				}
				if (this.O_o0o0_Oo.0.().Contains(RuntimeHelpers.GetObjectValue(A_0)))
				{
					this.O__oo_OO.O_.().SelectedIndex = this.O_o0o0_Oo.0.().IndexOf(RuntimeHelpers.GetObjectValue(A_0));
					return;
				}
			}
			else
			{
				if (A_0 == null)
				{
					this.Value = null;
					return;
				}
				if (this.OO0._0O.() == null)
				{
					if (this.O_o0o0_Oo.0.().Contains(RuntimeHelpers.GetObjectValue(A_0)))
					{
						this.Value = RuntimeHelpers.GetObjectValue(A_0);
						return;
					}
				}
				else
				{
					DataRow dataRow2 = (DataRow)A_0;
					if (((DataView)this.OO0._0O.()).Find(RuntimeHelpers.GetObjectValue(dataRow2[this.Ooo_O__.0o.()])) >= 0)
					{
						this.Value = RuntimeHelpers.GetObjectValue(dataRow2[this.Ooo_O__.0o.()]);
					}
				}
			}
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x001D4D28 File Offset: 0x001D2F28
		public object <<EMPTY_NAME>>()
		{
			object result;
			if (this.OO0._0O.() == null)
			{
				result = this.Ooo_O__.0o.();
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.Ooo_O__.0o.());
				if (objectValue == null)
				{
					result = null;
				}
				else
				{
					result = ((DataRow)objectValue)[this.Ooo_O__.0o.()];
				}
			}
			return result;
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x001D4D6C File Offset: 0x001D2F6C
		public void <<EMPTY_NAME>>(object A_0)
		{
			if (A_0 != null && this.OO0._0O.() != null)
			{
				int num = ((DataView)this.OO0._0O.()).Find(RuntimeHelpers.GetObjectValue(A_0));
				if (num >= 0)
				{
					A_0 = new DataRow(((DataView)this.OO0._0O.())[num].Row);
				}
				else
				{
					A_0 = null;
				}
			}
			this.o.OOoOo_00O.(RuntimeHelpers.GetObjectValue(A_0));
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x001D4DCF File Offset: 0x001D2FCF
		public bool <<EMPTY_NAME>>()
		{
			return this.O__oo_OO.O_.().FormattingEnabled;
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x001D4DDC File Offset: 0x001D2FDC
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O__oo_OO.O_.().FormattingEnabled = A_0;
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x001D4DEA File Offset: 0x001D2FEA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0_0oo.___o.();
			if (this.DropDownForm != null)
			{
				this.DropDownForm.Owner = null;
			}
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x001D4E08 File Offset: 0x001D3008
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.O__oo_OO.O_.());
			base.ReadOnly = base.ReadOnly;
			if (base.ReadOnly)
			{
				if (Operators.CompareString(base.DisplayFormat.CustomFormat, "", true) > 0 && this.DataType == typeof(DateTime))
				{
					base.DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				base.DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
				return;
			}
			else
			{
				if (Operators.CompareString(base.DisplayFormat.CustomFormat, "", true) > 0 && this.DataType == typeof(DateTime))
				{
					base.EditFormat.FormatType = FormatTypeEnum.CustomFormat;
					base.EditFormat.CustomFormat = base.DisplayFormat.CustomFormat;
					return;
				}
				base.EditFormat.FormatType = FormatTypeEnum.DefaultFormat;
				base.EditFormat.CustomFormat = "";
				return;
			}
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x001D4EE4 File Offset: 0x001D30E4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O__oo_OO.O_.().Font = this.Font;
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x001D4EF8 File Offset: 0x001D30F8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count == 0)
			{
				base.ReadOnly = true;
				return;
			}
			ooO_0O.o_O0.O_.(this, this.O__oo_OO.O_.());
			base.ReadOnly = base.ReadOnly;
			this.O0_0oo.___o.();
			if (this.o_0.__.)
			{
				this.oOOO_.o.();
			}
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x001D4F60 File Offset: 0x001D3160
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Space && (Operators.CompareString(this.Text, "", true) == 0 || !this.oo0.ooo.()) && !base.DroppedDown)
			{
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
				this.OpenDropDown();
				this.O.oO..Focus();
				SendKeys.Send("{DOWN}");
				if (this.O.oO..OOOO.0.().Items.Count > 0)
				{
					this.O.oO..OOOO.0.().SelectedIndex = 0;
					return;
				}
			}
			else
			{
				if (!this.oo0.ooo.() && A_1.KeyCode == Keys.Delete)
				{
					A_1.Handled = true;
					A_1.SuppressKeyPress = true;
					return;
				}
				if (A_1.Control && A_1.KeyCode == Keys.Return)
				{
					A_1.Handled = true;
					A_1.SuppressKeyPress = true;
					this.SelectedText = "";
					if (Operators.CompareString(this.Text, "", true) == 0)
					{
						this.OpenDropDown();
						return;
					}
					if (A_1.Shift)
					{
						this.oOOO_.o.();
					}
					if (this.OO0._0O.() != null)
					{
						DataView dataView = (DataView)this.OO0._0O.();
						this.Oo00.O_O0OO___. = true;
						this.O.oO. = dataView.RowFilter;
						if (Operators.CompareString(this.O.oO., "", true) > 0)
						{
							dataView.RowFilter = string.Concat(new string[]
							{
								this.O.oO.,
								" And [",
								this.Ooo_O__.0o.(),
								"] Like '*",
								this.Text,
								"*'"
							});
						}
						else
						{
							dataView.RowFilter = string.Concat(new string[]
							{
								"[",
								this.Ooo_O__.0o.(),
								"] Like '*",
								this.Text,
								"*'"
							});
						}
						if (dataView.Count == 0)
						{
							this.Oo00.O_O0OO___. = false;
							dataView.RowFilter = this.O.oO.;
							this.O.oO. = "";
						}
						this.OpenDropDown();
						if (this.DropDownForm != null)
						{
							O\u30000\u3002\u3002O o_u30000_u3002_u3002O = (O\u30000\u3002\u3002O)this.DropDownForm;
							o_u30000_u3002_u3002O.OOOO.0.().Select();
							if (o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex < 0 && o_u30000_u3002_u3002O.OOOO.0.().Items.Count > 0)
							{
								o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex = 0;
							}
							return;
						}
					}
					else if (this.O_o0o0_Oo.0.() != null)
					{
						List<string> list = new List<string>();
						try
						{
							foreach (object value in this.O_o0o0_Oo.0.())
							{
								string text = Conversions.ToString(value);
								if (text.IndexOf(this.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
								{
									list.Add(text);
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
						if (list.Count > 1 || (list.Count == 1 && Operators.CompareString(this.Text, list[0], true) != 0))
						{
							O\u30000\u3002\u3002O o_u30000_u3002_u3002O2 = new O\u30000\u3002\u3002O();
							o_u30000_u3002_u3002O2.OOOO.0.().Items.AddRange(list.ToArray());
							o_u30000_u3002_u3002O2.OOOO.0.().Font = this.Font;
							this.O.oO..OOOO.0.().SelectedIndex = 0;
							if (this.O.oOo.() > 0)
							{
								o_u30000_u3002_u3002O2.Width = Math.Max(60, this.O.oOo.());
							}
							else
							{
								o_u30000_u3002_u3002O2.Width = Math.Max(60, base.Width);
							}
							o_u30000_u3002_u3002O2.OOOO.0.().Height = Math.Min(this.o0Oo_.o_.(), list.Count) * this.O.oO..OOOO.0.().ItemHeight + 4;
							o_u30000_u3002_u3002O2.Height = o_u30000_u3002_u3002O2.OOOO.0.().Height;
							this.DropDownForm = o_u30000_u3002_u3002O2;
						}
						this.OpenDropDown();
						if (this.DropDownForm != null)
						{
							O\u30000\u3002\u3002O o_u30000_u3002_u3002O3 = (O\u30000\u3002\u3002O)this.DropDownForm;
							o_u30000_u3002_u3002O3.OOOO.0.().Select();
							if (o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex < 0 && o_u30000_u3002_u3002O3.OOOO.0.().Items.Count > 0)
							{
								o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex = 0;
							}
						}
					}
				}
			}
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x001D5364 File Offset: 0x001D3564
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (!this.oo0.ooo.())
			{
				A_1.Handled = true;
				A_1.KeyChar = '\0';
				return;
			}
			if (this.o_0.__.)
			{
				this.oOOO_.o.();
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x001D538C File Offset: 0x001D358C
		// (set) Token: 0x060040AD RID: 16557 RVA: 0x001D53B2 File Offset: 0x001D35B2
		public new object Value
		{
			get
			{
				object result;
				if (base.Value == DBNull.Value)
				{
					result = null;
				}
				else
				{
					result = base.Value;
				}
				return result;
			}
			set
			{
				base.Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x001D53C0 File Offset: 0x001D35C0
		private void <<EMPTY_NAME>>()
		{
			if (base.AutoCompleteMode != AutoCompleteMode.None)
			{
				List<string> list = new List<string>();
				base.AutoCompleteCustomSource.Clear();
				if (this.OO0._0O.() != null)
				{
					DataView dataView = (DataView)this.OO0._0O.();
					int num = dataView.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (!dataView[i].Row.IsNull(this.Ooo_O__.0o.()))
						{
							list.Add(dataView[i][this.Ooo_O__.0o.()].ToString());
						}
					}
				}
				else
				{
					try
					{
						foreach (object value in this.O_o0o0_Oo.0.())
						{
							string item = Conversions.ToString(value);
							list.Add(item);
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
				}
				base.AutoCompleteCustomSource.AddRange(list.ToArray());
				this.o_0.__. = false;
			}
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x001D54BC File Offset: 0x001D36BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.oo__Oo_.oO.)
			{
				OoOO0Oo_oo0oO.o0__0 o_o_.O. = this.O_o_.O.;
				if (o_o_.O. != null)
				{
					o_o_.O.(this, A_1);
				}
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x001D54E4 File Offset: 0x001D36E4
		private void <<EMPTY_NAME>>(object A_0, ListControlConvertEventArgs A_1)
		{
			OoOO0Oo_oo0oO.oo0O00O o.oO. = this.O.oO.;
			if (o.oO. != null)
			{
				o.oO.(this, A_1);
			}
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x001D5503 File Offset: 0x001D3703
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.O__oo_OO.O_.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x001D5520 File Offset: 0x001D3720
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string a_ = "DataFormat_" + Conversions.ToString(base.Tag);
			if (oOO0oo_o0.o.O0o000_.(this, a_))
			{
				base.DisplayFormat.FormatType = FormatTypeEnum.UseEvent;
				return;
			}
			if (Operators.CompareString(base.DisplayFormat.CustomFormat, "", true) > 0)
			{
				base.DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
				return;
			}
			base.DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060040B3 RID: 16563 RVA: 0x001D558B File Offset: 0x001D378B
		// (set) Token: 0x060040B4 RID: 16564 RVA: 0x001D5593 File Offset: 0x001D3793
		public object Value2
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x001D55A1 File Offset: 0x001D37A1
		public bool <<EMPTY_NAME>>()
		{
			return this.o00_.o_Oo_.;
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x001D55A9 File Offset: 0x001D37A9
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o00_.o_Oo_. = A_0;
		}

		// Token: 0x04001A0E RID: 6670
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001A0F RID: 6671
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A10 RID: 6672
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A11 RID: 6673
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A12 RID: 6674
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A13 RID: 6675
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A14 RID: 6676
		[CompilerGenerated]
		private System.Windows.Forms.ListBox <<EMPTY_NAME>>;

		// Token: 0x04001A15 RID: 6677
		private O\u30000\u3002\u3002O <<EMPTY_NAME>>;

		// Token: 0x04001A16 RID: 6678
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A17 RID: 6679
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A18 RID: 6680
		[CompilerGenerated]
		private OoOO0Oo_oo0oO.o0__0 <<EMPTY_NAME>>;

		// Token: 0x04001A19 RID: 6681
		[CompilerGenerated]
		private OoOO0Oo_oo0oO.oo0O00O <<EMPTY_NAME>>;

		// Token: 0x04001A1A RID: 6682
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001A1B RID: 6683
		private static string <<EMPTY_NAME>> = "";

		// Token: 0x04001A1C RID: 6684
		private static string <<EMPTY_NAME>> = "";

		// Token: 0x04001A1D RID: 6685
		private static DataRow <<EMPTY_NAME>>;

		// Token: 0x04001A1E RID: 6686
		private static string <<EMPTY_NAME>> = "(";

		// Token: 0x04001A1F RID: 6687
		private static string <<EMPTY_NAME>> = ")";

		// Token: 0x04001A20 RID: 6688
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001A21 RID: 6689
		private static int <<EMPTY_NAME>> = 7;

		// Token: 0x04001A22 RID: 6690
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001A23 RID: 6691
		internal Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04001A24 RID: 6692
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A25 RID: 6693
		private const int <<EMPTY_NAME>> = 770;

		// Token: 0x04001A26 RID: 6694
		private bool <<EMPTY_NAME>>;

		// Token: 0x020003DF RID: 991
		// (Invoke) Token: 0x060040BA RID: 16570
		public delegate void o0__0(object A_0, EventArgs A_1);

		// Token: 0x020003E0 RID: 992
		// (Invoke) Token: 0x060040BE RID: 16574
		public delegate void oo0O00O(object A_0, ListControlConvertEventArgs A_1);
	}
}

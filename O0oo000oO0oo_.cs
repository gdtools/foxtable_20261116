using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003D8 RID: 984
	internal class O0oo000oO0oo_ : C1DropDownControl, O000O
	{
		// Token: 0x0600401B RID: 16411 RVA: 0x001D2F99 File Offset: 0x001D1199
		[CompilerGenerated]
		private virtual CustomCheckedListBox <<EMPTY_NAME>>()
		{
			return this.OO.Oo0oOO.;
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x001D2FA4 File Offset: 0x001D11A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(CustomCheckedListBox A_0)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.OoO__O.__oo_o.);
			EventHandler value2 = new EventHandler(this.OoO__O.__oo_o.);
			ListControlConvertEventHandler value3 = new ListControlConvertEventHandler(this.OoO__O.__oo_o.);
			CustomCheckedListBox oo.Oo0oOO. = this.OO.Oo0oOO.;
			if (oo.Oo0oOO. != null)
			{
				oo.Oo0oOO..ItemCheck -= value;
				oo.Oo0oOO..SelectedIndexChanged -= value2;
				oo.Oo0oOO..Format -= value3;
			}
			this.OO.Oo0oOO. = A_0;
			oo.Oo0oOO. = this.OO.Oo0oOO.;
			if (oo.Oo0oOO. != null)
			{
				oo.Oo0oOO..ItemCheck += value;
				oo.Oo0oOO..SelectedIndexChanged += value2;
				oo.Oo0oOO..Format += value3;
			}
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x001D3020 File Offset: 0x001D1220
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(O0oo000oO0oo_.o_o00 A_0)
		{
			O0oo000oO0oo_.o_o00 o_o = this.OO.Oo0oOO.;
			O0oo000oO0oo_.o_o00 o_o2;
			do
			{
				o_o2 = o_o;
				O0oo000oO0oo_.o_o00 value = (O0oo000oO0oo_.o_o00)Delegate.Combine(o_o2, A_0);
				o_o = Interlocked.CompareExchange<O0oo000oO0oo_.o_o00>(ref this.OO.Oo0oOO., value, o_o2);
			}
			while (o_o != o_o2);
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x001D3058 File Offset: 0x001D1258
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(O0oo000oO0oo_.o_o00 A_0)
		{
			O0oo000oO0oo_.o_o00 o_o = this.OO.Oo0oOO.;
			O0oo000oO0oo_.o_o00 o_o2;
			do
			{
				o_o2 = o_o;
				O0oo000oO0oo_.o_o00 value = (O0oo000oO0oo_.o_o00)Delegate.Remove(o_o2, A_0);
				o_o = Interlocked.CompareExchange<O0oo000oO0oo_.o_o00>(ref this.OO.Oo0oOO., value, o_o2);
			}
			while (o_o != o_o2);
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x001D3090 File Offset: 0x001D1290
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(O0oo000oO0oo_.o0_00__ooOo A_0)
		{
			O0oo000oO0oo_.o0_00__ooOo o0_00__ooOo = this.OO_o_.o__.;
			O0oo000oO0oo_.o0_00__ooOo o0_00__ooOo2;
			do
			{
				o0_00__ooOo2 = o0_00__ooOo;
				O0oo000oO0oo_.o0_00__ooOo value = (O0oo000oO0oo_.o0_00__ooOo)Delegate.Combine(o0_00__ooOo2, A_0);
				o0_00__ooOo = Interlocked.CompareExchange<O0oo000oO0oo_.o0_00__ooOo>(ref this.OO_o_.o__., value, o0_00__ooOo2);
			}
			while (o0_00__ooOo != o0_00__ooOo2);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x001D30C8 File Offset: 0x001D12C8
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(O0oo000oO0oo_.o0_00__ooOo A_0)
		{
			O0oo000oO0oo_.o0_00__ooOo o0_00__ooOo = this.OO_o_.o__.;
			O0oo000oO0oo_.o0_00__ooOo o0_00__ooOo2;
			do
			{
				o0_00__ooOo2 = o0_00__ooOo;
				O0oo000oO0oo_.o0_00__ooOo value = (O0oo000oO0oo_.o0_00__ooOo)Delegate.Remove(o0_00__ooOo2, A_0);
				o0_00__ooOo = Interlocked.CompareExchange<O0oo000oO0oo_.o0_00__ooOo>(ref this.OO_o_.o__., value, o0_00__ooOo2);
			}
			while (o0_00__ooOo != o0_00__ooOo2);
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x001D3100 File Offset: 0x001D1300
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(O0oo000oO0oo_.oO0__ A_0)
		{
			O0oo000oO0oo_.oO0__ oO0__ = this.OO.Oo0oOO.;
			O0oo000oO0oo_.oO0__ oO0__2;
			do
			{
				oO0__2 = oO0__;
				O0oo000oO0oo_.oO0__ value = (O0oo000oO0oo_.oO0__)Delegate.Combine(oO0__2, A_0);
				oO0__ = Interlocked.CompareExchange<O0oo000oO0oo_.oO0__>(ref this.OO.Oo0oOO., value, oO0__2);
			}
			while (oO0__ != oO0__2);
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x001D3138 File Offset: 0x001D1338
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(O0oo000oO0oo_.oO0__ A_0)
		{
			O0oo000oO0oo_.oO0__ oO0__ = this.OO.Oo0oOO.;
			O0oo000oO0oo_.oO0__ oO0__2;
			do
			{
				oO0__2 = oO0__;
				O0oo000oO0oo_.oO0__ value = (O0oo000oO0oo_.oO0__)Delegate.Remove(oO0__2, A_0);
				oO0__ = Interlocked.CompareExchange<O0oo000oO0oo_.oO0__>(ref this.OO.Oo0oOO., value, oO0__2);
			}
			while (oO0__ != oO0__2);
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x001D3170 File Offset: 0x001D1370
		internal O0oo000oO0oo_()
		{
			base.DropDownOpened += this.o0oOo_0_o_.0_O.;
			base.Enter += this.o__0._O.;
			base.FontChanged += this.ooO.oo_.;
			base.GotFocus += this.O0Oo.oOOoOoO__.;
			base.KeyDown += this.OoO__O.__oo_o.;
			base.KeyPress += this.O0O.o.;
			this.OO.Oo0oOO. = BooleanEnum.Default;
			this.OO.Oo0oOO. = ',';
			this.o0OO.O. = true;
			this.o_O_.0O. = 11;
			this.ShowUpDownButtons = false;
			this.DataType = typeof(string);
			this.OO.Oo0oOO. = new O\u3002\u3000();
			this.o0OO0._0.(this.OO.Oo0oOO..O__0o.o0_.());
			this.DropDownForm = this.OO.Oo0oOO.;
			this.OO.Oo0oOO..O__0o.o0_.().Font = this.Font;
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

		// Token: 0x06004024 RID: 16420 RVA: 0x001D32ED File Offset: 0x001D14ED
		protected virtual void <<EMPTY_NAME>>(ref Message A_0)
		{
			if (A_0.Msg != 770 || this.OOo0_o.O00__.())
			{
				base.WndProc(ref A_0);
			}
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x001D330B File Offset: 0x001D150B
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.OO.Oo0oOO.;
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x001D3313 File Offset: 0x001D1513
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.OO.Oo0oOO. = A_0;
			ooO_0O.o_O0.O_.(this, this.o_0Oo.o_.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x001D3334 File Offset: 0x001D1534
		public char <<EMPTY_NAME>>()
		{
			return this.OO.Oo0oOO.;
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x001D333C File Offset: 0x001D153C
		public void <<EMPTY_NAME>>(char A_0)
		{
			this.OO.Oo0oOO. = A_0;
			this.OO.Oo0oOO..O__0o.o0_.().Separator = Conversions.ToString(A_0);
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x001D335B File Offset: 0x001D155B
		public bool <<EMPTY_NAME>>()
		{
			return this.o0OO.O.;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x001D3363 File Offset: 0x001D1563
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o0OO.O. = A_0;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x001D336C File Offset: 0x001D156C
		public CheckedListBox.ObjectCollection <<EMPTY_NAME>>()
		{
			return this.O0O.o.().Items;
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x001D3379 File Offset: 0x001D1579
		public CheckedListBox.CheckedItemCollection <<EMPTY_NAME>>()
		{
			return this.O0O.o.().CheckedItems;
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x001D3386 File Offset: 0x001D1586
		public string <<EMPTY_NAME>>()
		{
			return this.O0O.o.().DisplayMember;
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x001D3393 File Offset: 0x001D1593
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.O0O.o.().DisplayMember = A_0;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x001D33A1 File Offset: 0x001D15A1
		public string <<EMPTY_NAME>>()
		{
			return this.O0O.o.().ValueMember;
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x001D33AE File Offset: 0x001D15AE
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.O0O.o.().ValueMember = A_0;
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x001D33BC File Offset: 0x001D15BC
		public object <<EMPTY_NAME>>()
		{
			return this.O0O.o.().DataSource;
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x001D33CC File Offset: 0x001D15CC
		public void <<EMPTY_NAME>>(object A_0)
		{
			string a_ = this.O0O.o.();
			this.O0O.o.().DataSource = RuntimeHelpers.GetObjectValue(A_0);
			this.OoO.0oo_Oo_.(a_);
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x001D33F8 File Offset: 0x001D15F8
		public bool <<EMPTY_NAME>>()
		{
			return this.O0O.o.().MultiColumn;
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x001D3405 File Offset: 0x001D1605
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O0O.o.().MultiColumn = A_0;
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x001D3413 File Offset: 0x001D1613
		public int <<EMPTY_NAME>>()
		{
			return this.O0O.o.().ColumnWidth;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x001D3420 File Offset: 0x001D1620
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O0O.o.().ColumnWidth = A_0;
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x001D342E File Offset: 0x001D162E
		public int <<EMPTY_NAME>>()
		{
			return this.OO.Oo0oOO.;
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x001D3436 File Offset: 0x001D1636
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.OO.Oo0oOO. = A_0;
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x001D343F File Offset: 0x001D163F
		public int <<EMPTY_NAME>>()
		{
			return this.O.o0O.;
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x001D3447 File Offset: 0x001D1647
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O.o0O. = A_0;
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x001D3450 File Offset: 0x001D1650
		public int <<EMPTY_NAME>>()
		{
			return this.o_O_.0O.;
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x001D3458 File Offset: 0x001D1658
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.o_O_.0O. = A_0;
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x001D3461 File Offset: 0x001D1661
		public bool <<EMPTY_NAME>>()
		{
			return this.O0O.o.().CheckOnClick;
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x001D346E File Offset: 0x001D166E
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O0O.o.().CheckOnClick = A_0;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x001D347C File Offset: 0x001D167C
		internal void <<EMPTY_NAME>>()
		{
			if (this.o__0o0o_.OO0O_.() == 0)
			{
				this.OO.Oo0oOO..Width = Math.Max(168, base.Width);
			}
			else
			{
				this.OO.Oo0oOO..Width = Math.Max(131, this.o__0o0o_.OO0O_.());
			}
			if (!this.oOO0_o._0O00.())
			{
				int num = Math.Min(this.O_oOo.o0Oo.(), Math.Max(1, this.O0O.o.().Items.Count));
				this.OO.Oo0oOO..O__0o.o0_.().Height = this.OO.Oo0oOO..O__0o.o0_.().ItemHeight * num + 4;
				this.OO.Oo0oOO..Height = this.OO.Oo0oOO..O__0o.o0_.().Height + 32;
				return;
			}
			if (this.O0O.o.() > 0)
			{
				float num2 = (float)this.O0O.o.().ItemHeight;
				if (num2 == 12f && this.O0O.o.().Font.Size != 9f)
				{
					num2 = this.O0O.o.().Font.Size / 9f * 12f;
				}
				int num3 = (int)Convert.ToInt16(Math.Floor((double)(this.O0O.o.() - 36) / (double)this.OO.Oo0oOO..O__0o.o0_.().ItemHeight));
				num3 = Math.Max(1, num3);
				this.OO.Oo0oOO..O__0o.o0_.().Height = (int)Math.Round((double)(num2 * (float)num3 + 4f));
				this.OO.Oo0oOO..Height = this.OO.Oo0oOO..O__0o.o0_.().Height + 32;
			}
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x001D35FC File Offset: 0x001D17FC
		public int <<EMPTY_NAME>>()
		{
			int result;
			if (base.DroppedDown)
			{
				result = this.O0O.o.().SelectedIndex;
			}
			else if (this.Value == null)
			{
				result = -1;
			}
			else if (this.O_.0.() == null)
			{
				result = this.o_0Oo.o_.().IndexOf(RuntimeHelpers.GetObjectValue(this.Value));
			}
			else
			{
				result = ((DataView)this.O_.0.()).Find(RuntimeHelpers.GetObjectValue(this.Value));
			}
			return result;
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x001D366C File Offset: 0x001D186C
		public void <<EMPTY_NAME>>(int A_0)
		{
			if (base.DroppedDown)
			{
				this.O0O.o.().SelectedIndex = A_0;
				return;
			}
			if (A_0 == -1)
			{
				this.Value = null;
				return;
			}
			if (this.O0O.o.().DataSource == null)
			{
				this.Value = RuntimeHelpers.GetObjectValue(this.O0O.o.().Items[A_0]);
				return;
			}
			this.Value = RuntimeHelpers.GetObjectValue(((DataView)this.O_.0.())[A_0][this.OOooOOO.O0.()]);
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x001D36EC File Offset: 0x001D18EC
		public object <<EMPTY_NAME>>()
		{
			object result;
			if (base.DroppedDown)
			{
				int selectedIndex = this.O0O.o.().SelectedIndex;
				if (selectedIndex == -1)
				{
					result = null;
				}
				else if (this.O_.0.() == null)
				{
					result = this.O0O.o.().SelectedItem;
				}
				else
				{
					result = new DataRow(((DataView)this.O_.0.())[selectedIndex].Row);
				}
			}
			else
			{
				if (this.Value != null)
				{
					if (this.O_.0.() == null)
					{
						if (this.o_0Oo.o_.().Contains(RuntimeHelpers.GetObjectValue(this.Value)))
						{
							return this.Value;
						}
					}
					else
					{
						int num = ((DataView)this.O_.0.()).Find(RuntimeHelpers.GetObjectValue(this.Value));
						if (num >= 0)
						{
							return new DataRow(((DataView)this.O_.0.())[num].Row);
						}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x001D37C4 File Offset: 0x001D19C4
		public void <<EMPTY_NAME>>(object A_0)
		{
			if (base.DroppedDown)
			{
				if (A_0 == null)
				{
					this.o0.O_O.(-1);
					return;
				}
				if (this.O_.0.() == null)
				{
					if (this.o_0Oo.o_.().Contains(RuntimeHelpers.GetObjectValue(A_0)))
					{
						this.O0O.o.().SelectedIndex = this.o_0Oo.o_.().IndexOf(RuntimeHelpers.GetObjectValue(A_0));
						return;
					}
					DataRow dataRow = (DataRow)A_0;
					int num = ((DataView)this.O_.0.()).Find(RuntimeHelpers.GetObjectValue(dataRow[this.OOooOOO.O0.()]));
					if (num >= 0)
					{
						this.o0.O_O.(num);
					}
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
				if (this.O_.0.() == null)
				{
					if (this.o_0Oo.o_.().Contains(RuntimeHelpers.GetObjectValue(A_0)))
					{
						this.Value = RuntimeHelpers.GetObjectValue(A_0);
						return;
					}
				}
				else
				{
					DataRow dataRow2 = (DataRow)A_0;
					if (((DataView)this.O_.0.()).Find(RuntimeHelpers.GetObjectValue(dataRow2[this.OOooOOO.O0.()])) >= 0)
					{
						this.Value = RuntimeHelpers.GetObjectValue(dataRow2[this.OOooOOO.O0.()]);
					}
				}
			}
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x001D38D0 File Offset: 0x001D1AD0
		public object <<EMPTY_NAME>>()
		{
			object result;
			if (this.O_.0.() == null)
			{
				result = this.o0.0.();
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.o0.0.());
				if (objectValue == null)
				{
					result = null;
				}
				else
				{
					result = ((DataRow)objectValue)[this.OOooOOO.O0.()];
				}
			}
			return result;
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x001D3914 File Offset: 0x001D1B14
		public void <<EMPTY_NAME>>(object A_0)
		{
			if (A_0 != null && this.O_.0.() != null)
			{
				int num = ((DataView)this.O_.0.()).Find(RuntimeHelpers.GetObjectValue(A_0));
				if (num >= 0)
				{
					A_0 = new DataRow(((DataView)this.O_.0.())[num].Row);
				}
				else
				{
					A_0 = null;
				}
			}
			this.o.__.(RuntimeHelpers.GetObjectValue(A_0));
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x001D3977 File Offset: 0x001D1B77
		public bool <<EMPTY_NAME>>()
		{
			return this.O0O.o.().FormattingEnabled;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x001D3984 File Offset: 0x001D1B84
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O0O.o.().FormattingEnabled = A_0;
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x001D3992 File Offset: 0x001D1B92
		public void <<EMPTY_NAME>>(int A_0, bool A_1)
		{
			this.O0O.o.().SetItemChecked(A_0, A_1);
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x001D39A1 File Offset: 0x001D1BA1
		public bool <<EMPTY_NAME>>(int A_0)
		{
			return this.O0O.o.().GetItemChecked(A_0);
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x001D39B0 File Offset: 0x001D1BB0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O000_oOo_o.ooO.();
			if (this.Value == null)
			{
				this.O0O.o.().Value = "";
			}
			else
			{
				this.O0O.o.().Value = this.Value.ToString();
			}
			if (this.DropDownForm != null)
			{
				this.DropDownForm.Owner = null;
			}
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x001D3A07 File Offset: 0x001D1C07
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.o_0Oo.o_.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x001D3A21 File Offset: 0x001D1C21
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO.Oo0oOO..O__0o.o0_.().Font = this.Font;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x001D3A3C File Offset: 0x001D1C3C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count == 0)
			{
				base.ReadOnly = true;
				return;
			}
			this.O000_oOo_o.ooO.();
			ooO_0O.o_O0.O_.(this, this.o_0Oo.o_.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x001D3A95 File Offset: 0x001D1C95
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (!this.OOo0_o.O00__.() && A_1.KeyCode == Keys.Delete)
			{
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x001D3AB7 File Offset: 0x001D1CB7
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (!this.OOo0_o.O00__.())
			{
				A_1.Handled = true;
				A_1.KeyChar = '\0';
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x001D3AD0 File Offset: 0x001D1CD0
		// (set) Token: 0x06004051 RID: 16465 RVA: 0x001D3AF6 File Offset: 0x001D1CF6
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

		// Token: 0x06004052 RID: 16466 RVA: 0x001D3B04 File Offset: 0x001D1D04
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			O0oo000oO0oo_.o_o00 oo.Oo0oOO. = this.OO.Oo0oOO.;
			if (oo.Oo0oOO. != null)
			{
				oo.Oo0oOO.(this, A_1);
			}
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x001D3B24 File Offset: 0x001D1D24
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			O0oo000oO0oo_.o0_00__ooOo oo_o_.o__. = this.OO_o_.o__.;
			if (oo_o_.o__. != null)
			{
				oo_o_.o__.(this, A_1);
			}
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x001D3B44 File Offset: 0x001D1D44
		private void <<EMPTY_NAME>>(object A_0, ListControlConvertEventArgs A_1)
		{
			O0oo000oO0oo_.oO0__ oo.Oo0oOO. = this.OO.Oo0oOO.;
			if (oo.Oo0oOO. != null)
			{
				oo.Oo0oOO.(this, A_1);
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x001D3B63 File Offset: 0x001D1D63
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.o_0Oo.o_.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x001D3B7D File Offset: 0x001D1D7D
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x001D3B85 File Offset: 0x001D1D85
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

		// Token: 0x06004058 RID: 16472 RVA: 0x001D3B93 File Offset: 0x001D1D93
		public bool <<EMPTY_NAME>>()
		{
			return this.O.o0O.;
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x001D3B9B File Offset: 0x001D1D9B
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O.o0O. = A_0;
		}

		// Token: 0x040019FB RID: 6651
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040019FC RID: 6652
		private char <<EMPTY_NAME>>;

		// Token: 0x040019FD RID: 6653
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019FE RID: 6654
		private int <<EMPTY_NAME>>;

		// Token: 0x040019FF RID: 6655
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A00 RID: 6656
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A01 RID: 6657
		[CompilerGenerated]
		private CustomCheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04001A02 RID: 6658
		internal O\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x04001A03 RID: 6659
		[CompilerGenerated]
		private O0oo000oO0oo_.o_o00 <<EMPTY_NAME>>;

		// Token: 0x04001A04 RID: 6660
		[CompilerGenerated]
		private O0oo000oO0oo_.o0_00__ooOo <<EMPTY_NAME>>;

		// Token: 0x04001A05 RID: 6661
		[CompilerGenerated]
		private O0oo000oO0oo_.oO0__ <<EMPTY_NAME>>;

		// Token: 0x04001A06 RID: 6662
		private const int <<EMPTY_NAME>> = 770;

		// Token: 0x04001A07 RID: 6663
		private bool <<EMPTY_NAME>>;

		// Token: 0x020003D9 RID: 985
		// (Invoke) Token: 0x0600405D RID: 16477
		public delegate void o_o00(object A_0, ItemCheckEventArgs A_1);

		// Token: 0x020003DA RID: 986
		// (Invoke) Token: 0x06004061 RID: 16481
		public delegate void o0_00__ooOo(object A_0, EventArgs A_1);

		// Token: 0x020003DB RID: 987
		// (Invoke) Token: 0x06004065 RID: 16485
		public delegate void oO0__(object A_0, ListControlConvertEventArgs A_1);
	}
}

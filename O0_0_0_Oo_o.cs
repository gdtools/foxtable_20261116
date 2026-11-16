using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200007A RID: 122
	internal class O0_0_0_Oo_o : C1DropDownControl
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x0001F510 File Offset: 0x0001D710
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o_.0.;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001F518 File Offset: 0x0001D718
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o_.0. = A_0;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001F521 File Offset: 0x0001D721
		[CompilerGenerated]
		private virtual O\u30000\u3002\u3002O <<EMPTY_NAME>>()
		{
			return this.o_.0.;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001F52C File Offset: 0x0001D72C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(O\u30000\u3002\u3002O A_0)
		{
			EventHandler value = new EventHandler(this.oo_00.____.);
			O\u30000\u3002\u3002O o_u30000_u3002_u3002O = this.o_.0.;
			if (o_u30000_u3002_u3002O != null)
			{
				o_u30000_u3002_u3002O.Disposed -= value;
			}
			this.o_.0. = A_0;
			o_u30000_u3002_u3002O = this.o_.0.;
			if (o_u30000_u3002_u3002O != null)
			{
				o_u30000_u3002_u3002O.Disposed += value;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001F570 File Offset: 0x0001D770
		public O0_0_0_Oo_o()
		{
			base.DropDownClosed += this.oo_00.____.;
			base.DropDownOpened += this.oO._.;
			base.FontChanged += this.O.o_.;
			base.GotFocus += this.O0.0oOO00O.;
			base.KeyDown += this.o_o.O_0OOO.;
			base.KeyPress += this.oo_00.____.;
			this.o_.0. = true;
			this.o0_O0Oo_o.0Oo. = -1;
			this.ShowUpDownButtons = false;
			this.O.O_oo_OO_O.(new O\u30000\u3002\u3002O());
			this.O.00o0o_.(this.OO.0oo.().OOOO.0.());
			this.DropDownForm = this.OO.0oo.();
			base.VisualStyle = C1.Win.C1Input.VisualStyle.System;
			base.EmptyAsNull = true;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.AutoTabWhenFilled = true;
			base.MaskInfo.EmptyAsNull = true;
			base.ErrorInfo.ShowErrorMessage = false;
			this.OO.0oo.().Font = this.Font;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001F67B File Offset: 0x0001D87B
		protected virtual void <<EMPTY_NAME>>(ref Message A_0)
		{
			if (A_0.Msg != 770 || this.oO.oO__o00.())
			{
				base.WndProc(ref A_0);
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0001F699 File Offset: 0x0001D899
		public bool <<EMPTY_NAME>>()
		{
			return this.o_.0.;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001F6A1 File Offset: 0x0001D8A1
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o_.0. = A_0;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001F6AA File Offset: 0x0001D8AA
		public ListBox.ObjectCollection <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().Items;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001F6B7 File Offset: 0x0001D8B7
		public string <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().DisplayMember;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.OO.0oo.().DisplayMember = A_0;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001F6D2 File Offset: 0x0001D8D2
		public string <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().ValueMember;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001F6DF File Offset: 0x0001D8DF
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.OO.0oo.().ValueMember = A_0;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001F6ED File Offset: 0x0001D8ED
		public object <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().DataSource;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001F6FC File Offset: 0x0001D8FC
		public void <<EMPTY_NAME>>(object A_0)
		{
			string a_ = this.oo_00.____.();
			this.OO.0oo.().DataSource = RuntimeHelpers.GetObjectValue(A_0);
			this.oO_0.__oO0_000.(a_);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001F728 File Offset: 0x0001D928
		public bool <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().MultiColumn;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001F735 File Offset: 0x0001D935
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.OO.0oo.().MultiColumn = A_0;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001F743 File Offset: 0x0001D943
		public int <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().ColumnWidth;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001F750 File Offset: 0x0001D950
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.OO.0oo.().ColumnWidth = A_0;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001F75E File Offset: 0x0001D95E
		public int <<EMPTY_NAME>>()
		{
			return this.o_.0.;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001F766 File Offset: 0x0001D966
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.o_.0. = A_0;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001F76F File Offset: 0x0001D96F
		public int <<EMPTY_NAME>>()
		{
			return this.O0__.o_.;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001F777 File Offset: 0x0001D977
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O0__.o_. = A_0;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001F780 File Offset: 0x0001D980
		public int <<EMPTY_NAME>>()
		{
			return this.oO0o__O.oO.;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001F788 File Offset: 0x0001D988
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.oO0o__O.oO. = A_0;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001F791 File Offset: 0x0001D991
		internal int <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().O0o0o.o.();
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001F79E File Offset: 0x0001D99E
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.OO.0oo.().OOOO.0.(A_0);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001F7AC File Offset: 0x0001D9AC
		private void <<EMPTY_NAME>>(object A_0, DropDownClosedEventArgs A_1)
		{
			if (this.DropDownForm != this.OO.0oo.())
			{
				this.DropDownForm = this.OO.0oo.();
			}
			if (this.O___0oO__.0oO.() != null & this.O0__.o_.)
			{
				this.O0__.o_. = false;
				((DataView)this.O___0oO__.0oO.()).RowFilter = this.o_.0.;
			}
			if (this.o0_O0Oo_o.0Oo. != this.OO.0oo.().SelectedIndex && base.UpdateValueWithCurrentText() && base.DataBindings.Count > 0)
			{
				base.DataBindings[0].WriteValue();
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001F83C File Offset: 0x0001DA3C
		internal void <<EMPTY_NAME>>()
		{
			int num2;
			int num5;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (this.DropDownForm != this.OO.0oo.())
				{
					goto IL_1A7;
				}
				IL_13:
				num = 3;
				if (this.Value != null)
				{
					goto IL_30;
				}
				IL_1D:
				num = 4;
				this.OO.0oo.().SelectedIndex = -1;
				goto IL_BB;
				IL_30:
				num = 6;
				if (this.OO.0oo.().DataSource != null)
				{
					goto IL_64;
				}
				IL_3F:
				num = 7;
				this.OO.0oo.().SelectedIndex = this.OO.0oo.().FindStringExact(this.Value.ToString());
				goto IL_BB;
				IL_64:
				num = 9;
				DataView dataView = (DataView)this.OO.0oo.().DataSource;
				IL_79:
				num = 10;
				if (Operators.CompareString(dataView.Sort, this.oO_0.__oO0_000.(), true) != 0)
				{
					goto IL_B8;
				}
				IL_91:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_98:
				num = 12;
				this.OO.0oo.().SelectedIndex = dataView.Find(RuntimeHelpers.GetObjectValue(this.Value));
				IL_B8:
				dataView = null;
				IL_BB:
				num = 14;
				if (this.O00___.0oO00.() <= 0)
				{
					goto IL_E4;
				}
				IL_C7:
				num = 15;
				this.OO.0oo.().Width = Math.Max(60, this.O00___.0oO00.());
				goto IL_FF;
				IL_E4:
				num = 17;
				this.OO.0oo.().Width = Math.Max(60, base.Width);
				IL_FF:
				num = 18;
				int num3 = Math.Max(this.Oo._.(), (int)Convert.ToInt16(Math.Floor((double)(this.oo_00.____.() - 4) / (double)this.OO.0oo.().ItemHeight)));
				IL_12E:
				num = 19;
				num3 = Math.Min(num3, Math.Max(1, this.OO.0oo.().Items.Count));
				IL_14E:
				num = 20;
				this.OO.0oo.().OOOO.0.().Height = this.OO.0oo.().OOOO.0.().ItemHeight * num3 + 4;
				IL_175:
				num = 21;
				this.OO.0oo.().Height = this.OO.0oo.().OOOO.0.().Height;
				IL_193:
				num = 22;
				this.o0_O0Oo_o.0Oo. = this.OO.0oo.().SelectedIndex;
				IL_1A7:
				goto IL_255;
				IL_1AC:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_216:
				goto IL_24A;
				IL_218:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_228:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_218;
			}
			IL_24A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_255:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001FAC4 File Offset: 0x0001DCC4
		public int <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().SelectedIndex;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001FAD1 File Offset: 0x0001DCD1
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.OO.0oo.().SelectedIndex = A_0;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001FADF File Offset: 0x0001DCDF
		public object <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().SelectedItem;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		public void <<EMPTY_NAME>>(object A_0)
		{
			this.OO.0oo.().SelectedItem = RuntimeHelpers.GetObjectValue(A_0);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001FAFF File Offset: 0x0001DCFF
		public object <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().SelectedValue;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001FB0C File Offset: 0x0001DD0C
		public void <<EMPTY_NAME>>(object A_0)
		{
			this.OO.0oo.().SelectedValue = RuntimeHelpers.GetObjectValue(A_0);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001FB1F File Offset: 0x0001DD1F
		public bool <<EMPTY_NAME>>()
		{
			return this.OO.0oo.().FormattingEnabled;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001FB2C File Offset: 0x0001DD2C
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.OO.0oo.().FormattingEnabled = A_0;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001FB3A File Offset: 0x0001DD3A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.00o0o_.();
			this.OO.0oo.().Owner = null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001FB4E File Offset: 0x0001DD4E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO.0oo.().Font = this.Font;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001FB61 File Offset: 0x0001DD61
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.00o0o_.();
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001FB6C File Offset: 0x0001DD6C
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
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
				if (A_1.KeyCode != Keys.Down)
				{
					goto IL_4D;
				}
				IL_13:
				num2 = 3;
				if (!(base.Parent is O_oOooO_O))
				{
					goto IL_5A2;
				}
				IL_25:
				num2 = 4;
				if (!((O_oOooO_O)base.Parent).FinishEditing())
				{
					goto IL_5A2;
				}
				IL_3C:
				num2 = 5;
				SendKeys.Send("{DOWN}");
				goto IL_5A2;
				IL_4D:
				num2 = 7;
				if (A_1.KeyCode != Keys.Up)
				{
					goto IL_95;
				}
				IL_59:
				num2 = 8;
				if (!(base.Parent is O_oOooO_O))
				{
					goto IL_5A2;
				}
				IL_6B:
				num2 = 9;
				if (!((O_oOooO_O)base.Parent).FinishEditing())
				{
					goto IL_5A2;
				}
				IL_83:
				num2 = 10;
				SendKeys.Send("{UP}");
				goto IL_5A2;
				IL_95:
				num2 = 12;
				if (A_1.KeyCode != Keys.Space || (Operators.CompareString(this.Text, "", true) != 0 && this.oO.oO__o00.()) || base.DroppedDown)
				{
					goto IL_138;
				}
				IL_C8:
				num2 = 13;
				A_1.Handled = true;
				IL_D2:
				num2 = 14;
				A_1.SuppressKeyPress = true;
				IL_DC:
				num2 = 15;
				this.OpenDropDown();
				IL_E5:
				num2 = 16;
				this.OO.0oo.().Focus();
				IL_F4:
				num2 = 17;
				SendKeys.Send("{DOWN}");
				IL_101:
				num2 = 18;
				if (this.OO.0oo.().OOOO.0.().Items.Count <= 0)
				{
					goto IL_5A2;
				}
				IL_11F:
				num2 = 19;
				this.OO.0oo.().OOOO.0.().SelectedIndex = 0;
				goto IL_5A2;
				IL_138:
				num2 = 21;
				if (this.oO.oO__o00.())
				{
					goto IL_16C;
				}
				IL_143:
				num2 = 22;
				if (A_1.KeyCode != Keys.Delete)
				{
					goto IL_5A2;
				}
				IL_153:
				num2 = 23;
				A_1.Handled = true;
				IL_15D:
				num2 = 24;
				A_1.SuppressKeyPress = true;
				goto IL_5A2;
				IL_16C:
				num2 = 26;
				if (!A_1.Control || A_1.KeyCode != Keys.Return)
				{
					goto IL_5A2;
				}
				IL_187:
				num2 = 27;
				A_1.Handled = true;
				IL_191:
				num2 = 28;
				A_1.SuppressKeyPress = true;
				IL_19B:
				num2 = 29;
				this.SelectedText = "";
				IL_1A9:
				num2 = 30;
				if (!(base.Parent is O_oOooO_O))
				{
					goto IL_218;
				}
				IL_1B9:
				num2 = 31;
				O_oOooO_O o_oOooO_O = (O_oOooO_O)base.Parent;
				IL_1C8:
				num2 = 32;
				if (!A_1.Shift)
				{
					goto IL_201;
				}
				IL_1D3:
				num2 = 33;
				o_oOooO_O.o.0O_O0o_..Cols[o_oOooO_O.Cols[o_oOooO_O.Col].Name].ResetAutoCompleteSource();
				IL_201:
				num2 = 34;
				if (o_oOooO_O.Editor != null)
				{
					goto IL_216;
				}
				IL_20C:
				num2 = 35;
				o_oOooO_O.StartEditing();
				IL_216:
				o_oOooO_O = null;
				IL_218:
				num2 = 37;
				if (Operators.CompareString(this.Text, "", true) != 0)
				{
					goto IL_23C;
				}
				IL_22E:
				num2 = 38;
				this.OpenDropDown();
				goto IL_5A2;
				IL_23C:
				num2 = 40;
				if (this.O___0oO__.0oO.() == null)
				{
					goto IL_3BC;
				}
				IL_24A:
				num2 = 41;
				DataView dataView = (DataView)this.O___0oO__.0oO.();
				IL_25A:
				num2 = 42;
				this.O0__.o_. = true;
				IL_264:
				num2 = 43;
				this.o_.0. = dataView.RowFilter;
				IL_274:
				num2 = 44;
				if (Operators.CompareString(this.o_.0., "", true) <= 0)
				{
					goto IL_2D5;
				}
				IL_28B:
				num2 = 45;
				dataView.RowFilter = string.Concat(new string[]
				{
					this.o_.0.,
					" And [",
					this.oO_0.__oO0_000.(),
					"] Like '*",
					this.Text,
					"*'"
				});
				goto IL_314;
				IL_2D5:
				num2 = 47;
				dataView.RowFilter = string.Concat(new string[]
				{
					"[",
					this.oO_0.__oO0_000.(),
					"] Like '*",
					this.Text,
					"*'"
				});
				IL_314:
				num2 = 48;
				if (dataView.Count != 0)
				{
					goto IL_348;
				}
				IL_320:
				num2 = 49;
				this.O0__.o_. = false;
				IL_32A:
				num2 = 50;
				dataView.RowFilter = this.o_.0.;
				IL_33A:
				num2 = 51;
				this.o_.0. = "";
				IL_348:
				num2 = 52;
				this.OpenDropDown();
				IL_351:
				num2 = 53;
				if (this.DropDownForm == null)
				{
					goto IL_5A2;
				}
				IL_35F:
				num2 = 54;
				O\u30000\u3002\u3002O o_u30000_u3002_u3002O = (O\u30000\u3002\u3002O)this.DropDownForm;
				IL_36F:
				num2 = 55;
				o_u30000_u3002_u3002O.OOOO.0.().Select();
				IL_37E:
				num2 = 56;
				if (o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex >= 0 || o_u30000_u3002_u3002O.OOOO.0.().Items.Count <= 0)
				{
					goto IL_3B4;
				}
				IL_3A4:
				num2 = 57;
				o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex = 0;
				IL_3B4:
				o_u30000_u3002_u3002O = null;
				goto IL_5A2;
				IL_3BC:
				num2 = 60;
				if (this.OO.0oo.() == null)
				{
					goto IL_5A2;
				}
				IL_3CA:
				num2 = 61;
				List<string> list = new List<string>();
				IL_3D4:
				num2 = 62;
				IEnumerator enumerator = this.OO.0oo.().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					string text = Conversions.ToString(value);
					IL_3F4:
					num2 = 63;
					if (text.IndexOf(this.Text) >= 0)
					{
						IL_407:
						num2 = 64;
						list.Add(text);
					}
					IL_413:
					num2 = 65;
				}
				IL_41F:
				num2 = 66;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_437:
				num2 = 67;
				if (list.Count <= 1 && (list.Count != 1 || Operators.CompareString(this.Text, list[0], true) == 0))
				{
					goto IL_536;
				}
				IL_46A:
				num2 = 68;
				O\u30000\u3002\u3002O o_u30000_u3002_u3002O2 = new O\u30000\u3002\u3002O();
				IL_474:
				num2 = 69;
				o_u30000_u3002_u3002O2.OOOO.0.().Items.AddRange(list.ToArray());
				IL_48F:
				num2 = 70;
				o_u30000_u3002_u3002O2.OOOO.0.().Font = this.OO.0oo.().Font;
				IL_4A9:
				num2 = 71;
				if (this.O00___.0oO00.() <= 0)
				{
					goto IL_4CE;
				}
				IL_4B5:
				num2 = 72;
				o_u30000_u3002_u3002O2.Width = Math.Max(60, this.O00___.0oO00.());
				goto IL_4E5;
				IL_4CE:
				num2 = 74;
				o_u30000_u3002_u3002O2.Width = Math.Max(60, base.Width);
				IL_4E5:
				num2 = 75;
				o_u30000_u3002_u3002O2.OOOO.0.().Height = Math.Min(list.Count, this.Oo._.()) * o_u30000_u3002_u3002O2.OOOO.0.().ItemHeight + 4;
				IL_515:
				num2 = 76;
				o_u30000_u3002_u3002O2.Height = o_u30000_u3002_u3002O2.OOOO.0.().Height;
				IL_52B:
				num2 = 77;
				this.DropDownForm = o_u30000_u3002_u3002O2;
				IL_536:
				num2 = 78;
				this.OpenDropDown();
				IL_53F:
				num2 = 79;
				if (this.DropDownForm == null)
				{
					goto IL_5A2;
				}
				IL_54A:
				num2 = 80;
				O\u30000\u3002\u3002O o_u30000_u3002_u3002O3 = (O\u30000\u3002\u3002O)this.DropDownForm;
				IL_55A:
				num2 = 81;
				o_u30000_u3002_u3002O3.OOOO.0.().Select();
				IL_569:
				num2 = 82;
				if (o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex >= 0 || o_u30000_u3002_u3002O3.OOOO.0.().Items.Count <= 0)
				{
					goto IL_59F;
				}
				IL_58F:
				num2 = 83;
				o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex = 0;
				IL_59F:
				o_u30000_u3002_u3002O3 = null;
				IL_5A2:
				goto IL_748;
				IL_5A7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_709:
				goto IL_73D;
				IL_70B:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_71B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_70B;
			}
			IL_73D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_748:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000202E8 File Offset: 0x0001E4E8
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (!this.oO.oO__o00.())
			{
				A_1.Handled = true;
				A_1.KeyChar = '\0';
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00020300 File Offset: 0x0001E500
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00020326 File Offset: 0x0001E526
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

		// Token: 0x060004C2 RID: 1218 RVA: 0x00020334 File Offset: 0x0001E534
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!Main.OO_O.o..Disposing && !Main.OO_O.o..IsDisposed && !Main.OO_O.o..o_O.o__.)
			{
				string right = "";
				bool flag;
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (Operators.CompareString(table.Name, table.DataTable.Name, true) == 0)
						{
							try
							{
								foreach (object obj in ((IEnumerable)table.Grid.Cols))
								{
									Column column = (Column)obj;
									if (column.Editor == this && table.DataTable.DataCols[column.Name].oO0._00o_0. == this)
									{
										flag = true;
										right = table.DataTable.Name;
										table.DataTable.DataCols[column.Name].oO0._00o_0. = null;
										break;
									}
								}
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
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (flag)
				{
					try
					{
						foreach (Table table2 in OO_00oOO.Tables)
						{
							if (Operators.CompareString(table2.DataTable.Name, right, true) == 0)
							{
								try
								{
									foreach (object obj2 in ((IEnumerable)table2.Grid.Cols))
									{
										Column column2 = (Column)obj2;
										if (column2.Editor == this)
										{
											column2.Editor = null;
											table2.Cols[column2.Name].o0.O.();
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
						return;
					}
					finally
					{
						IEnumerator<Table> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				try
				{
					foreach (Table table3 in OO_00oOO.Tables)
					{
						try
						{
							foreach (object obj3 in ((IEnumerable)table3.Grid.Cols))
							{
								Column column3 = (Column)obj3;
								if (column3.Editor == this)
								{
									column3.Editor = null;
									Col col = table3.Cols[column3.Name];
									if (Operators.CompareString(col.o_0.oo., "", true) > 0)
									{
										col.ComboList = col.o_0.oo.;
									}
									else if (Operators.CompareString(col.DataSource, "", true) > 0)
									{
										col.DataSource = col.DataSource;
									}
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
					IEnumerator<Table> enumerator5;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
				}
			}
		}

		// Token: 0x04000139 RID: 313
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400013A RID: 314
		private int <<EMPTY_NAME>>;

		// Token: 0x0400013B RID: 315
		private int <<EMPTY_NAME>>;

		// Token: 0x0400013C RID: 316
		private int <<EMPTY_NAME>>;

		// Token: 0x0400013D RID: 317
		private int <<EMPTY_NAME>>;

		// Token: 0x0400013E RID: 318
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x0400013F RID: 319
		[CompilerGenerated]
		private O\u30000\u3002\u3002O <<EMPTY_NAME>>;

		// Token: 0x04000140 RID: 320
		private string <<EMPTY_NAME>>;

		// Token: 0x04000141 RID: 321
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000142 RID: 322
		private const int <<EMPTY_NAME>> = 770;
	}
}

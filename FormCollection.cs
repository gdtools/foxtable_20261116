using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using Foxtable.My;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003C4 RID: 964
	[oO0oooo("0703")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FormCollection : IEnumerable<Foxtable.WinForm.Form>
	{
		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x001C0254 File Offset: 0x001BE454
		// (set) Token: 0x06003E24 RID: 15908 RVA: 0x001C025C File Offset: 0x001BE45C
		private virtual System.Timers.Timer TT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06003E25 RID: 15909 RVA: 0x001C0268 File Offset: 0x001BE468
		internal FormCollection()
		{
			this.O.o_0oOo_O00. = new Dictionary<string, Foxtable.WinForm.Form>();
			this.O.o_0oOo_O00. = 90;
			this.ooO0_o._o. = false;
			this.O.o_0oOo_O00. = DateTime.Now;
			this.O.o_0oOo_O00. = "";
			this.TT = new System.Timers.Timer();
			this.TT.Enabled = true;
			this.TT.Interval = 60000.0;
			this.TT.Elapsed += this.ooO0_o._o.;
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x001C02F0 File Offset: 0x001BE4F0
		internal void <<EMPTY_NAME>>()
		{
			this.O.o_0oOo_O00..Clear();
			foreach (DataRow a_ in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Select("[Type] = " + Conversions.ToString(229) + "Or [Type] = " + Conversions.ToString(233)))
			{
				this.ooO0_o._o.(a_);
			}
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x001C0360 File Offset: 0x001BE560
		internal void <<EMPTY_NAME>>(DataRow A_0)
		{
			Foxtable.WinForm.Form form = new Foxtable.WinForm.Form(A_0, false);
			if (!this.O.o_0oOo_O00..ContainsKey(form.Name))
			{
				this.O.o_0oOo_O00..Add(form.Name, form);
			}
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x001C039A File Offset: 0x001BE59A
		internal void <<EMPTY_NAME>>(string A_0, Foxtable.WinForm.Form A_1)
		{
			this.O.o_0oOo_O00..Add(A_0, A_1);
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x001C03AC File Offset: 0x001BE5AC
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (Foxtable.WinForm.Form form in this.O.o_0oOo_O00..Values)
				{
					form.O_0.O00o_00_O. = false;
					form.Close();
				}
			}
			finally
			{
				Dictionary<string, Foxtable.WinForm.Form>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					table.CloseRecordGrid();
				}
			}
			finally
			{
				IEnumerator<Table> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x001C0444 File Offset: 0x001BE644
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O.o_0oOo_O00..Remove(A_0);
		}

		// Token: 0x17000D14 RID: 3348
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Foxtable.WinForm.Form this[string Name]
		{
			get
			{
				Foxtable.WinForm.Form result;
				if (this.O.o_0oOo_O00. != null && Operators.CompareString(this.O.o_0oOo_O00..Name, Name, true) == 0)
				{
					result = this.O.o_0oOo_O00.;
				}
				else if (this.O.o_0oOo_O00..ContainsKey(Name))
				{
					if (!this.ooO0_o._o. && (DateTime.Now - this.O.o_0oOo_O00.).TotalSeconds > 480.0 && !O_O0OO.O_oO_o0O.o__.)
					{
						this.O.o_0oOo_O00..Clear();
					}
					result = this.O.o_0oOo_O00.[Name];
				}
				else
				{
					try
					{
						foreach (string text in this.O.o_0oOo_O00..Keys)
						{
							if (Operators.CompareString(text, Name, true) == 0)
							{
								return this.O.o_0oOo_O00.[text];
							}
						}
					}
					finally
					{
						Dictionary<string, Foxtable.WinForm.Form>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					MessageBox.Show("不存在名称为\"" + Name + "\"的窗口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 窗口数量
		/// </summary>
		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x001C0564 File Offset: 0x001BE764
		public int Count
		{
			get
			{
				return this.O.o_0oOo_O00..Count;
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的窗口
		/// </summary>
		/// <param name="Name"></param>
		// Token: 0x06003E2D RID: 15917 RVA: 0x001C0574 File Offset: 0x001BE774
		public bool Contains(string Name)
		{
			return (this.O.o_0oOo_O00. != null && Operators.CompareString(this.O.o_0oOo_O00..Name, Name, true) == 0) || this.O.o_0oOo_O00..ContainsKey(Name);
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x001C05AF File Offset: 0x001BE7AF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Foxtable.WinForm.Form> GetEnumerator()
		{
			return (IEnumerator<Foxtable.WinForm.Form>)this.O.o_0oOo_O00..Values.GetEnumerator();
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x001C05CB File Offset: 0x001BE7CB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.O.o_0oOo_O00..Values.GetEnumerator();
		}

		/// <summary>
		/// 返回活动窗口
		/// </summary>
		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06003E30 RID: 15920 RVA: 0x001C05E8 File Offset: 0x001BE7E8
		[oO0oooo("1547")]
		public Foxtable.WinForm.Form ActiveForm
		{
			get
			{
				if (System.Windows.Forms.Form.ActiveForm == Main.OO_O.o.)
				{
					System.Windows.Forms.Control control = Main.OO_O.o..ActiveControl;
					while (control != null)
					{
						if (control is FormPanel)
						{
							if (OO_00oOO.Forms.Contains(control.Name))
							{
								return OO_00oOO.Forms[control.Name];
							}
							break;
						}
						else
						{
							control = control.Parent;
						}
					}
				}
				else if (System.Windows.Forms.Form.ActiveForm != null)
				{
					System.Windows.Forms.Form activeForm = System.Windows.Forms.Form.ActiveForm;
					if (activeForm.Controls.Count > 0 && activeForm.Controls[0] is FormPanel && OO_00oOO.Forms.Contains(activeForm.Controls[0].Name))
					{
						return OO_00oOO.Forms[activeForm.Controls[0].Name];
					}
				}
				return null;
			}
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x001C06B8 File Offset: 0x001BE8B8
		private void <<EMPTY_NAME>>(object A_0, ElapsedEventArgs A_1)
		{
			if (OO_00oOO.SystemReady && !O_O0OO.O_oO_o0O.o__.)
			{
				if (this.a == 1)
				{
					this.O.o_0oOo_O00. = "HKEY_CURRENT_USER\\Software\\" + O00.ooo000o_0.00o0.(o_o_O0OO_0__.O.ooOo__o000OO.().Substring(0, 4), "Tick", "Tick");
					object objectValue = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(this.O.o_0oOo_O00., "Count", 0));
					if (objectValue != null)
					{
						int.TryParse(objectValue.ToString(), out this.o_.O__O00OOO.);
					}
				}
				if (this.a == 3)
				{
					FormCollection.o0OoOo00__Oo0 o0OoOo00__Oo = new FormCollection.o0OoOo00__Oo0();
					if (this.o_.O__O00OOO. > 60)
					{
						O_O0OO.O_O.OOO_o.(true);
					}
					if (this.o_.O__O00OOO. > this.O.o_0oOo_O00. && !o0OoOo00__Oo.O.o_0oOo_O00.())
					{
						try
						{
							foreach (Foxtable.WinForm.Form form in OO_00oOO.Forms)
							{
								bool opened = form.Opened;
							}
						}
						finally
						{
							IEnumerator<Foxtable.WinForm.Form> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						this.OoO___.0_o. = true;
						O_O0OO.O00O0o_O_._O. = false;
					}
					this.TT.Enabled = false;
				}
				this.a++;
			}
		}

		// Token: 0x0400199B RID: 6555
		private Dictionary<string, Foxtable.WinForm.Form> <<EMPTY_NAME>>;

		// Token: 0x0400199C RID: 6556
		[CompilerGenerated]
		[AccessedThroughProperty("TT")]
		private System.Timers.Timer <<EMPTY_NAME>>;

		// Token: 0x0400199D RID: 6557
		private int <<EMPTY_NAME>>;

		// Token: 0x0400199E RID: 6558
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400199F RID: 6559
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040019A0 RID: 6560
		private int <<EMPTY_NAME>>;

		// Token: 0x040019A1 RID: 6561
		internal Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x040019A2 RID: 6562
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040019A3 RID: 6563
		private string <<EMPTY_NAME>>;

		// Token: 0x040019A4 RID: 6564
		private int a;

		// Token: 0x020003C6 RID: 966
		private class o0OoOo00__Oo0
		{
			// Token: 0x06003F56 RID: 16214 RVA: 0x001D086B File Offset: 0x001CEA6B
			public o0OoOo00__Oo0()
			{
				this.O.o_0oOo_O00. = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(8, 4);
				this.o_0O.O. = o_o_O0OO_0__.O0_O_o.o_.();
				OO_00oOO.Forms.ooO0_o._o. = true;
			}

			// Token: 0x06003F57 RID: 16215 RVA: 0x001D089C File Offset: 0x001CEA9C
			internal bool <<EMPTY_NAME>>()
			{
				int num;
				bool result;
				int num5;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					if (Operators.CompareString(this.o_0O.O., "", true) != 0)
					{
						goto IL_25;
					}
					IL_1C:
					num2 = 3;
					result = false;
					goto IL_15A;
					IL_25:
					num2 = 4;
					string text = this.o_0O.O.;
					IL_2F:
					num2 = 5;
					this.o_0O.O. = this.o_0O.O..Substring(8, 4);
					IL_44:
					num2 = 6;
					int.TryParse(this.O.o_0oOo_O00., out this.O.o_0oOo_O00.);
					IL_58:
					num2 = 7;
					this.O.o_0oOo_O00. = O00.ooo000o_0.00o0.(this.O.o_0oOo_O00., text.Substring(0, 4), text.Substring(4, 4));
					IL_7D:
					num2 = 8;
					this.O.o_0oOo_O00. = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., this.O.o_0oOo_O00.);
					IL_95:
					num2 = 9;
					this.O.o_0oOo_O00. = O00.MD5Encrypt(this.O.o_0oOo_O00.);
					IL_A9:
					num2 = 10;
					int num3 = 0;
					do
					{
						IL_AF:
						num2 = 11;
						this.o_.o_O_. += Conversions.ToString((int)((this.O.o_0oOo_O00.[num3] - '\u0001') % '\t' + '\u0001'));
						IL_DC:
						num2 = 12;
						num3++;
					}
					while (num3 <= 3);
					IL_EA:
					num2 = 13;
					int.TryParse(this.o_.o_O_., out this.O.o_0oOo_O00.);
					IL_FF:
					num2 = 14;
					int.TryParse(this.o_0O.O., out this.o_0O.O.);
					IL_114:
					num2 = 15;
					if (o0OO__.o_o.0OOoO0O0.(this.O.o_0oOo_O00. + this.o_0O.O.) != 1008829567 && o0OO__.o_o.0OOoO0O0.(Math.Abs(this.O.o_0oOo_O00. - this.o_0O.O.)) != 1008829567)
					{
						goto IL_155;
					}
					IL_14E:
					num2 = 16;
					result = true;
					goto IL_15A;
					IL_155:
					num2 = 18;
					result = false;
					IL_15A:
					goto IL_1F8;
					IL_15F:
					int num4 = num5 + 1;
					num5 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
					IL_1B9:
					goto IL_1ED;
					IL_1BB:
					num5 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_1CB:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_1BB;
				}
				IL_1ED:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_1F8:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x040019D6 RID: 6614
			private string <<EMPTY_NAME>>;

			// Token: 0x040019D7 RID: 6615
			private string <<EMPTY_NAME>>;

			// Token: 0x040019D8 RID: 6616
			private int <<EMPTY_NAME>>;

			// Token: 0x040019D9 RID: 6617
			private int <<EMPTY_NAME>>;

			// Token: 0x040019DA RID: 6618
			private string <<EMPTY_NAME>>;
		}
	}
}

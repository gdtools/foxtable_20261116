using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000268 RID: 616
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3002\u3002_o\u3000 : Form
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x000C9C74 File Offset: 0x000C7E74
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0_o0.o_0_. != null)
				{
					this.o0_o0.o_0_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000C9CB4 File Offset: 0x000C7EB4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0_o0.o_0_.(new Label());
			this.o.__o.(new RadioButton());
			this.o0_o0.o_0_.(new RadioButton());
			this.oOO._o00o00__.(new C1Button());
			this.o.__o.(new C1Button());
			base.SuspendLayout();
			this.oOO._o00o00__.().AutoSize = true;
			this.oOO._o00o00__.().Location = new Point(12, 29);
			this.oOO._o00o00__.().Name = "Label1";
			this.oOO._o00o00__.().Size = new Size(0, 12);
			this.oOO._o00o00__.().TabIndex = 0;
			this.oOO._o00o00__.().AutoSize = true;
			this.oOO._o00o00__.().Checked = true;
			this.oOO._o00o00__.().Location = new Point(38, 66);
			this.oOO._o00o00__.().Name = "rdoNo";
			this.oOO._o00o00__.().Size = new Size(131, 16);
			this.oOO._o00o00__.().TabIndex = 1;
			this.oOO._o00o00__.().TabStop = true;
			this.oOO._o00o00__.().Text = "否，我要考虑一下！";
			this.oOO._o00o00__.().UseVisualStyleBackColor = true;
			this.O.ooOOO_0O.().AutoSize = true;
			this.O.ooOOO_0O.().Location = new Point(38, 88);
			this.O.ooOOO_0O.().Name = "rdoYes";
			this.O.ooOOO_0O.().Size = new Size(131, 16);
			this.O.ooOOO_0O.().TabIndex = 2;
			this.O.ooOOO_0O.().Text = "是，我确定要转换！";
			this.O.ooOOO_0O.().UseVisualStyleBackColor = true;
			this.O.ooOOO_0O.().Location = new Point(63, 138);
			this.O.ooOOO_0O.().Name = "Button1";
			this.O.ooOOO_0O.().Size = new Size(75, 23);
			this.O.ooOOO_0O.().TabIndex = 3;
			this.O.ooOOO_0O.().Text = "确定";
			this.O.ooOOO_0O.().UseVisualStyleBackColor = true;
			this.oOO._o00o00__.().Location = new Point(146, 138);
			this.oOO._o00o00__.().Name = "Button2";
			this.oOO._o00o00__.().Size = new Size(75, 23);
			this.oOO._o00o00__.().TabIndex = 4;
			this.oOO._o00o00__.().Text = "取消";
			this.oOO._o00o00__.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(284, 182);
			base.Controls.Add(this.oOO._o00o00__.());
			base.Controls.Add(this.O.ooOOO_0O.());
			base.Controls.Add(this.O.ooOOO_0O.());
			base.Controls.Add(this.oOO._o00o00__.());
			base.Controls.Add(this.oOO._o00o00__.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o.0.O0";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "转换列";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x000C9FD8 File Offset: 0x000C81D8
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0_o0.o_0_.;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x000C9FE0 File Offset: 0x000C81E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0_o0.o_0_. = A_0;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000C9FE9 File Offset: 0x000C81E9
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o0_o0.o_0_.;
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x000C9FF1 File Offset: 0x000C81F1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o0_o0.o_0_. = A_0;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x000C9FFA File Offset: 0x000C81FA
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o.__o.;
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x000CA002 File Offset: 0x000C8202
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o.__o. = A_0;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x000CA00B File Offset: 0x000C820B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_o0.o_0_.;
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x000CA014 File Offset: 0x000C8214
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o00O__.oO.);
			C1Button c1Button = this.o0_o0.o_0_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_o0.o_0_. = A_0;
			c1Button = this.o0_o0.o_0_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x000CA057 File Offset: 0x000C8257
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.__o.;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x000CA060 File Offset: 0x000C8260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_.0O_OOOo.);
			C1Button c1Button = this.o.__o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.__o. = A_0;
			c1Button = this.o.__o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000CA0A3 File Offset: 0x000C82A3
		public O\u3002\u3002\u3002\u3002_o\u3000()
		{
			base.AutoSizeChanged += this.oOO._o00o00__.;
			this.oOO._o00o00__.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000CA0D8 File Offset: 0x000C82D8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x000CA0E0 File Offset: 0x000C82E0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				if (!this.oOO._o00o00__.().Checked)
				{
					goto IL_23;
				}
				IL_16:
				num2 = 3;
				base.Close();
				goto IL_41B;
				IL_23:
				num2 = 5;
				if (!this.O.0o_0_.)
				{
					goto IL_22A;
				}
				IL_30:
				num2 = 6;
				ColumnDataTypeEnum columnDataTypeEnum = Oo00.oO.OO.(this.O.0o_0_..BaseColumn.DataType, this.O.0o_0_.);
				IL_4E:
				num2 = 7;
				OleDbCommand oleDbCommand = new OleDbCommand();
				IL_57:
				num2 = 8;
				oleDbCommand.Connection = this.O.0o_0_..DataTable.frd_Connection;
				IL_70:
				num2 = 9;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Alter Table [",
					this.O.0o_0_..DataTable.o._OOO0oOo0__..Trim(new char[]
					{
						'[',
						']'
					}),
					"] Drop COLUMN [",
					this.O.0o_0_..Name,
					"]"
				});
				IL_D3:
				num2 = 10;
				oleDbCommand.Connection.Open();
				IL_E2:
				num2 = 11;
				oleDbCommand.ExecuteNonQuery();
				IL_ED:
				num2 = 12;
				oleDbCommand.Connection.Close();
				IL_FC:
				num2 = 13;
				this.O.0o_0_..IsTemporary = true;
				IL_10B:
				num2 = 14;
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()];
				IL_124:
				num2 = 15;
				DataRow dataRow = dataTable.NewRow();
				IL_130:
				num2 = 16;
				dataRow["Table"] = this.O.0o_0_..DataTable.Name;
				IL_14F:
				num2 = 17;
				dataRow["Column"] = this.O.0o_0_..Name;
				IL_169:
				num2 = 18;
				dataRow["DataType"] = columnDataTypeEnum;
				IL_17E:
				num2 = 19;
				dataRow["MaxLength"] = this.O.0o_0_..MaxLength;
				IL_19D:
				num2 = 20;
				dataRow["Expression"] = "";
				IL_1B1:
				num2 = 21;
				dataTable.Rows.Add(dataRow);
				IL_1C2:
				dataTable = null;
				IL_1C5:
				num2 = 23;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
				IL_1E2:
				num2 = 24;
				base.Close();
				IL_1EB:
				num2 = 25;
				MessageBox.Show("[" + this.O.0o_0_..Name + "]已经成功转为表达式列，需要重新打开项目才能生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_216:
				num2 = 26;
				Project.Open(OO_00oOO.ProjectFile, new string[0]);
				IL_22A:
				num2 = 27;
				if (!this.O_0oo.O0.)
				{
					goto IL_41B;
				}
				IL_238:
				num2 = 28;
				ADOXBuilder adoxbuilder = null;
				IL_23E:
				num2 = 29;
				string name = "";
				IL_248:
				num2 = 30;
				if (!this.O.0o_0_..DataTable.frd_IsInnerTable)
				{
					goto IL_27E;
				}
				IL_25D:
				num2 = 31;
				adoxbuilder = new ADOXBuilder();
				IL_267:
				num2 = 32;
				name = this.O.0o_0_..DataTable.Name;
				goto IL_2FB;
				IL_27E:
				num2 = 34;
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					IL_29D:
					num2 = 35;
					if (O_O0OO.O._o_.()[text] == this.O.0o_0_..DataTable.frd_Connection)
					{
						IL_2BE:
						num2 = 36;
						adoxbuilder = new ADOXBuilder(text);
						IL_2CA:
						num2 = 37;
						name = this.O.0o_0_..DataTable.o._OOO0oOo0__.;
					}
					IL_2DF:
					num2 = 38;
				}
				IL_2EB:
				num2 = 39;
				((IDisposable)enumerator).Dispose();
				IL_2FB:
				num2 = 40;
				if (adoxbuilder == null)
				{
					goto IL_41B;
				}
				IL_305:
				num2 = 42;
				DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
				{
					this.O.0o_0_..DataTable.Name,
					this.O.0o_0_..Name
				});
				IL_34F:
				num2 = 43;
				if (dataRow2 == null)
				{
					goto IL_37D;
				}
				IL_356:
				num2 = 44;
				dataRow2.Delete();
				IL_360:
				num2 = 45;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
				IL_37D:
				num2 = 46;
				adoxbuilder.Open();
				IL_387:
				num2 = 47;
				adoxbuilder.get_Tables(name).AddColumn(this.O.0o_0_..Name, Oo00.oO.OO.(this.O.0o_0_..BaseColumn.DataType, this.O.0o_0_.), this.O.0o_0_..MaxLength);
				IL_3C9:
				num2 = 48;
				adoxbuilder.Close();
				IL_3D3:
				num2 = 49;
				base.Close();
				IL_3DC:
				num2 = 50;
				MessageBox.Show("[" + this.O.0o_0_..Name + "]已经成功转为数据列，需要重新打开项目才能生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_407:
				num2 = 51;
				Project.Open(OO_00oOO.ProjectFile, new string[0]);
				IL_41B:
				goto IL_53D;
				IL_420:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_4FE:
				goto IL_532;
				IL_500:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_510:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_500;
			}
			IL_532:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_53D:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x000CA650 File Offset: 0x000C8850
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000C84 RID: 3204
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000C85 RID: 3205
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000C86 RID: 3206
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04000C87 RID: 3207
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04000C88 RID: 3208
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000C89 RID: 3209
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000C8A RID: 3210
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000C8B RID: 3211
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000C8C RID: 3212
		internal DataCol <<EMPTY_NAME>>;
	}
}

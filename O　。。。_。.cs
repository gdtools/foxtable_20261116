using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000197 RID: 407
	internal partial class O\u3000\u3002\u3002\u3002_\u3002\u3000\u3000 : Form
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x00083F39 File Offset: 0x00082139
		[CompilerGenerated]
		private virtual o_0OOo0o_0O_ <<EMPTY_NAME>>()
		{
			return this.O__0O.OO0Oo.;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00083F44 File Offset: 0x00082144
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(o_0OOo0o_0O_ A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.O__0O.OO0Oo.);
			o_0OOo0o_0O_ o__0O.OO0Oo. = this.O__0O.OO0Oo.;
			if (o__0O.OO0Oo. != null)
			{
				o__0O.OO0Oo..MouseClick -= value;
			}
			this.O__0O.OO0Oo. = A_0;
			o__0O.OO0Oo. = this.O__0O.OO0Oo.;
			if (o__0O.OO0Oo. != null)
			{
				o__0O.OO0Oo..MouseClick += value;
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00083F88 File Offset: 0x00082188
		public O\u3000\u3002\u3002\u3002_\u3002\u3000\u3000(f4 A_0)
		{
			base.Deactivate += this.O__0O.OO0Oo.;
			this.O__0O.OO0Oo.(new o_0OOo0o_0O_());
			this.O_O0_.0O. = new Dictionary<string, string>();
			this.O_O0_.0O. = A_0;
			this.Text = "";
			base.ControlBox = false;
			base.Controls.Add(this.O__0O.OO0Oo.());
			base.TopMost = true;
			base.FormBorderStyle = FormBorderStyle.None;
			base.StartPosition = FormStartPosition.Manual;
			base.ShowInTaskbar = false;
			this.O__0O.OO0Oo.().Dock = DockStyle.Fill;
			this.O__0O.OO0Oo.().Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
			this.O__0O.OO0Oo.().Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
			this.O__0O.OO0Oo.().Styles.EmptyArea.BackColor = this.O__0O.OO0Oo.().Styles.Normal.BackColor;
			this.O__0O.OO0Oo.().Styles.Normal.ImageAlign = ImageAlignEnum.CenterCenter;
			this.O__0O.OO0Oo.().Rows.Count = 0;
			this.O__0O.OO0Oo.().Cols.Count = 9;
			this.O__0O.OO0Oo.().Rows.Fixed = 0;
			this.O__0O.OO0Oo.().Cols.Fixed = 0;
			this.O__0O.OO0Oo.().SelectionMode = SelectionModeEnum.Cell;
			this.O__0O.OO0Oo.().HighLight = HighLightEnum.Never;
			this.O__0O.OO0Oo.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.O__0O.OO0Oo.().AllowEditing = false;
			try
			{
				foreach (string text in OO_00oOO.FileSys.GetFiles(O_O0OO.o.00O_O.() + "faces"))
				{
					Image image = OO_00oOO.GetImage(text);
					int num2;
					int num = num2 / 9;
					int num3 = num2 % 9;
					if (this.O__0O.OO0Oo.().Rows.Count < num + 1)
					{
						this.O__0O.OO0Oo.().Rows.Count = this.O__0O.OO0Oo.().Rows.Count + 1;
					}
					this.O__0O.OO0Oo.().SetCellImage(num, num3, image);
					this.O_O0_.0O..Add(Conversions.ToString(num) + "," + Conversions.ToString(num3), OO_00oOO.FileSys.GetName(text));
					num2++;
				}
			}
			finally
			{
				IEnumerator<string> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			int num4 = this.O__0O.OO0Oo.().Cols.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				this.O__0O.OO0Oo.().AutoSizeCol(i);
				this.O__0O.OO0Oo.().Cols[i].ImageAndText = false;
			}
			int num5 = this.O__0O.OO0Oo.().Rows.Count - 1;
			for (int j = 0; j <= num5; j++)
			{
				this.O__0O.OO0Oo.().AutoSizeRow(j);
			}
			base.Width = this.O__0O.OO0Oo.().Cols[this.O__0O.OO0Oo.().Cols.Count - 1].Left + this.O__0O.OO0Oo.().Cols[this.O__0O.OO0Oo.().Cols.Count - 1].Width + 3;
			base.Height = this.O__0O.OO0Oo.().Rows[this.O__0O.OO0Oo.().Rows.Count - 1].Top + this.O__0O.OO0Oo.().Rows[this.O__0O.OO0Oo.().Rows.Count - 1].Height + 6;
			this.O__0O.OO0Oo.().ScrollBars = ScrollBars.None;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00084318 File Offset: 0x00082518
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			base.Hide();
			string key = Conversions.ToString(this.O__0O.OO0Oo.().Row) + "," + Conversions.ToString(this.O__0O.OO0Oo.().Col);
			if (this.O_O0_.0O..ContainsKey(key))
			{
				this.O_O0_.0O..oOO_._0_0o_0.(this.O_O0_.0O.[key]);
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0008437B File Offset: 0x0008257B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Hide();
		}

		// Token: 0x0400077E RID: 1918
		[CompilerGenerated]
		private o_0OOo0o_0O_ <<EMPTY_NAME>>;

		// Token: 0x0400077F RID: 1919
		private f4 <<EMPTY_NAME>>;

		// Token: 0x04000780 RID: 1920
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}

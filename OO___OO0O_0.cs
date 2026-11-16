using System;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200008A RID: 138
	internal class OO___OO0O_0 : C1DockingTab
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x00022628 File Offset: 0x00020828
		public OO___OO0O_0()
		{
			base.ControlRemoved += this.oO.O_0_.;
			base.SelectedIndexChanging += this.oO.O_0_.;
			base.ParentChanged += this.oO.O_0_.;
			base.VisualStyle = VisualStyle.Custom;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00022678 File Offset: 0x00020878
		private void <<EMPTY_NAME>>(object A_0, ControlEventArgs A_1)
		{
			if (!Main.OO_O.o..o__OO_.Ooo0_. && base.FindForm() != null && base.SelectedTab != null)
			{
				this.o0.oOO_O.(base.SelectedTab);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000226A2 File Offset: 0x000208A2
		private void <<EMPTY_NAME>>(object A_0, SelectedIndexChangingEventArgs A_1)
		{
			if (base.FindForm() != null && A_1.NewIndex >= 0)
			{
				this.o0.oOO_O.(base.TabPages[A_1.NewIndex]);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000226CC File Offset: 0x000208CC
		internal void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			if (A_0.Controls.Count == 1)
			{
				if (A_0.Controls[0] is FormPanel)
				{
					Foxtable.WinForm.Form form = OO_00oOO.Forms[A_0.Controls[0].Name];
					if (form.FormStyle == FormStyleEnum.停靠 || form.FormStyle == FormStyleEnum.共有)
					{
						base.ShowCaption = form.ShowDockCaption;
						base.CanCloseTabs = form.ShowCloseButton;
					}
					return;
				}
				if (A_0.Controls[0] is FileManager)
				{
					base.ShowCaption = ((FileManager)A_0.Controls[0]).DataColumn.ShowCaption;
					base.CanCloseTabs = ((FileManager)A_0.Controls[0]).DataColumn.AllowClose;
					return;
				}
				if (A_0.Controls[0] is PictureViewer)
				{
					base.ShowCaption = ((PictureViewer)A_0.Controls[0]).DataColumn.ShowCaption;
					base.CanCloseTabs = ((PictureViewer)A_0.Controls[0]).DataColumn.AllowClose;
					return;
				}
				if (A_0.Controls[0] is O__o)
				{
					base.ShowCaption = ((O__o)A_0.Controls[0]).o__0_o0.OOO_.().ShowCaption;
					base.CanCloseTabs = ((O__o)A_0.Controls[0]).o__0_o0.OOO_.().AllowClose;
				}
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00022847 File Offset: 0x00020A47
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Main.OO_O.o. != null && base.FindForm() != null)
			{
				Main.OO_O.o..o.O000oo.(new object[]
				{
					this
				});
			}
		}
	}
}

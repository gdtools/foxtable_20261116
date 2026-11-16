using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using C1.Win.FlexViewer;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003FE RID: 1022
	internal class oOO0oo_o0
	{
		// Token: 0x06004184 RID: 16772 RVA: 0x001D8A78 File Offset: 0x001D6C78
		public static bool <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			bool result;
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.Activated)
						{
							controlHolder.Activated = false;
							result = true;
							break;
						}
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							if (oOO0oo_o0.o_0O.O.(controlHolder.ChildControl.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							if (oOO0oo_o0.o_0O.O.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.TabControl)
						{
							if (oOO0oo_o0.o_0O.O.(((C1DockingTab)controlHolder.ChildControl).SelectedTab.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.NavBar)
						{
							if (oOO0oo_o0.o_0O.O.(((C1NavBar)controlHolder.ChildControl).SelectedPanel.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
						{
							o0000O o0000O = (o0000O)controlHolder.ChildControl;
							if (oOO0oo_o0.o_0O.O.(o0000O.oo0oO_O.oooO0O.().Controls))
							{
								result = true;
								break;
							}
							if (oOO0oo_o0.o_0O.O.(o0000O.o.Oo0oo000O.().Controls))
							{
								result = true;
								break;
							}
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
			return result;
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x001D8C20 File Offset: 0x001D6E20
		public static bool <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			bool result;
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.Selected)
						{
							controlHolder.Activated = true;
							result = true;
							break;
						}
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							if (oOO0oo_o0.O.ooooo.(controlHolder.ChildControl.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							if (oOO0oo_o0.O.ooooo.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.TabControl)
						{
							if (oOO0oo_o0.O.ooooo.(((C1DockingTab)controlHolder.ChildControl).SelectedTab.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.NavBar)
						{
							if (oOO0oo_o0.O.ooooo.(((C1NavBar)controlHolder.ChildControl).SelectedPanel.Controls))
							{
								result = true;
								break;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
						{
							o0000O o0000O = (o0000O)controlHolder.ChildControl;
							if (oOO0oo_o0.O.ooooo.(o0000O.oo0oO_O.oooO0O.().Controls))
							{
								result = true;
								break;
							}
							if (oOO0oo_o0.O.ooooo.(o0000O.o.Oo0oo000O.().Controls))
							{
								result = true;
								break;
							}
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
			return result;
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x001D8DC8 File Offset: 0x001D6FC8
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.Selected)
						{
							controlHolder.Selected = false;
						}
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							oOO0oo_o0.o0.Oo__.(controlHolder.ChildControl.Controls);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							oOO0oo_o0.o0.Oo__.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.TabControl)
						{
							oOO0oo_o0.o0.Oo__.(((C1DockingTab)controlHolder.ChildControl).SelectedTab.Controls);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.NavBar)
						{
							oOO0oo_o0.o0.Oo__.(((C1NavBar)controlHolder.ChildControl).SelectedPanel.Controls);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
						{
							o0000O o0000O = (o0000O)controlHolder.ChildControl;
							oOO0oo_o0.o0.Oo__.(o0000O.oo0oO_O.oooO0O.().Controls);
							oOO0oo_o0.o0.Oo__.(o0000O.o.Oo0oo000O.().Controls);
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
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x001D8F3C File Offset: 0x001D713C
		public static ControlHolder <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.Activated)
						{
							return (ControlHolder)control;
						}
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							ControlHolder controlHolder2 = oOO0oo_o0.o.O0o000_.(controlHolder.ChildControl.Controls);
							if (controlHolder2 != null)
							{
								return controlHolder2;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							ControlHolder controlHolder3 = oOO0oo_o0.o.O0o000_.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls);
							if (controlHolder3 != null)
							{
								return controlHolder3;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.TabControl)
						{
							ControlHolder controlHolder4 = oOO0oo_o0.o.O0o000_.(((C1DockingTab)controlHolder.ChildControl).SelectedTab.Controls);
							if (controlHolder4 != null)
							{
								return controlHolder4;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.NavBar)
						{
							ControlHolder controlHolder5 = oOO0oo_o0.o.O0o000_.(((C1NavBar)controlHolder.ChildControl).SelectedPanel.Controls);
							if (controlHolder5 != null)
							{
								return controlHolder5;
							}
						}
						else if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
						{
							o0000O o0000O = (o0000O)controlHolder.ChildControl;
							ControlHolder controlHolder6 = oOO0oo_o0.o.O0o000_.(o0000O.oo0oO_O.oooO0O.().Controls);
							if (controlHolder6 != null)
							{
								return controlHolder6;
							}
							controlHolder6 = oOO0oo_o0.o.O0o000_.(o0000O.o.Oo0oo000O.().Controls);
							if (controlHolder6 != null)
							{
								return controlHolder6;
							}
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
			return null;
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x001D9104 File Offset: 0x001D7304
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.O_.0oo_O. != null)
						{
							controlHolder.O_.0oo_O..Visible = false;
							if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.PictureBox | controlHolder.ControlType == ControlTypeEnum.Map)
							{
								((O0_0_0_0_)controlHolder.ChildControl).OOO_0_oo0.Oo0_.();
							}
							else
							{
								if (controlHolder.ControlType == ControlTypeEnum.TabControl)
								{
									try
									{
										foreach (object obj2 in ((C1DockingTab)controlHolder.ChildControl).TabPages)
										{
											((O0_0_0_0_)((O_O_)obj2)).OOO_0_oo0.Oo0_.();
										}
										continue;
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
								if (controlHolder.ControlType == ControlTypeEnum.NavBar)
								{
									try
									{
										foreach (object obj3 in ((C1NavBar)controlHolder.ChildControl).Panels)
										{
											((O0_0_0_0_)((oO_0)obj3)).OOO_0_oo0.Oo0_.();
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
								if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
								{
									o0000O o0000O = (o0000O)controlHolder.ChildControl;
									o0000O.oo0oO_O.oooO0O.().o__O0_.o_.();
									o0000O.o.Oo0oo000O.().o__O0_.o_.();
								}
							}
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
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x001D92D8 File Offset: 0x001D74D8
		public static void <<EMPTY_NAME>>(O0_0_0_0_ A_0, System.Windows.Forms.Control.ControlCollection A_1)
		{
			A_0.OOO_0_oo0.Oo0_.(-1);
			A_0.O0.o0O_o00_O.(0);
			try
			{
				foreach (object obj in A_1)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						A_0.OOO_0_oo0.Oo0_.(A_0.OOO_0_oo0.Oo0_.() + 1);
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.O_.0oo_O. != null)
						{
							controlHolder.O_.0oo_O..Visible = true;
							if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.PictureBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
							{
								((O0_0_0_0_)controlHolder.ChildControl).O0.o0O_o00_O.();
							}
							else
							{
								if (controlHolder.ControlType == ControlTypeEnum.TabControl)
								{
									try
									{
										foreach (object obj2 in ((C1DockingTab)controlHolder.ChildControl).TabPages)
										{
											((O0_0_0_0_)((O_O_)obj2)).O0.o0O_o00_O.();
										}
										continue;
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
								if (controlHolder.ControlType == ControlTypeEnum.NavBar)
								{
									try
									{
										foreach (object obj3 in ((C1NavBar)controlHolder.ChildControl).Panels)
										{
											((O0_0_0_0_)((oO_0)obj3)).O0.o0O_o00_O.();
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
								if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
								{
									o0000O o0000O = (o0000O)controlHolder.ChildControl;
									o0000O.oo0oO_O.oooO0O.().oo0oo__0o.O.();
									o0000O.o.Oo0oo000O.().oo0oo__0o.O.();
								}
							}
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
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x001D94D4 File Offset: 0x001D76D4
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, Font A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, A_1);
						}
						else
						{
							if (controlHolder.ControlType == ControlTypeEnum.TabControl)
							{
								try
								{
									foreach (object obj2 in ((C1DockingTab)controlHolder.ChildControl).TabPages)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((O_O_)obj2).Controls, A_1);
									}
									goto IL_183;
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
							if (controlHolder.ControlType == ControlTypeEnum.NavBar)
							{
								try
								{
									foreach (object obj3 in ((C1NavBar)controlHolder.ChildControl).Panels)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((oO_0)obj3).Controls, A_1);
									}
									goto IL_183;
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
							{
								o0000O o0000O = (o0000O)controlHolder.ChildControl;
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1);
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1);
							}
						}
						IL_183:
						if (controlHolder.Selected)
						{
							controlHolder.ChildControl.Font = (Font)A_1.Clone();
							controlHolder = null;
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
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x001D96F4 File Offset: 0x001D78F4
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, int A_1, O_0Oo0o_0 A_2)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							oOO0oo_o0.O.ooooo.(controlHolder.ChildControl.Controls, A_1, A_2);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							oOO0oo_o0.O.ooooo.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, A_1, A_2);
						}
						else
						{
							if (controlHolder.ControlType == ControlTypeEnum.TabControl)
							{
								try
								{
									foreach (object obj2 in ((C1DockingTab)controlHolder.ChildControl).TabPages)
									{
										oOO0oo_o0.O.ooooo.(((O_O_)obj2).Controls, A_1, A_2);
									}
									goto IL_189;
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
							if (controlHolder.ControlType == ControlTypeEnum.NavBar)
							{
								try
								{
									foreach (object obj3 in ((C1NavBar)controlHolder.ChildControl).Panels)
									{
										oOO0oo_o0.O.ooooo.(((oO_0)obj3).Controls, A_1, A_2);
									}
									goto IL_189;
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
							{
								o0000O o0000O = (o0000O)controlHolder.ChildControl;
								oOO0oo_o0.O.ooooo.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2);
								oOO0oo_o0.O.ooooo.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2);
							}
						}
						IL_189:
						if (controlHolder.Selected)
						{
							switch (A_2)
							{
							case O_0Oo0o_0.O0o.0O.:
								controlHolder.Left = A_1;
								break;
							case O_0Oo0o_0.O0_O.O.:
								controlHolder.Left = A_1 - control.Width;
								break;
							case O_0Oo0o_0.oO0_o.0.:
								controlHolder.Top = A_1;
								break;
							case O_0Oo0o_0.O._oo0o_.:
								controlHolder.Top = A_1 - control.Height;
								break;
							}
							controlHolder = null;
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
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x001D9950 File Offset: 0x001D7B50
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, Size A_1, oO_ A_2)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1, A_2);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, A_1, A_2);
						}
						else
						{
							if (controlHolder.ControlType == ControlTypeEnum.TabControl)
							{
								try
								{
									foreach (object obj2 in ((C1DockingTab)controlHolder.ChildControl).TabPages)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((O_O_)obj2).Controls, A_1, A_2);
									}
									goto IL_189;
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
							if (controlHolder.ControlType == ControlTypeEnum.NavBar)
							{
								try
								{
									foreach (object obj3 in ((C1NavBar)controlHolder.ChildControl).Panels)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((oO_0)obj3).Controls, A_1, A_2);
									}
									goto IL_189;
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
							{
								o0000O o0000O = (o0000O)controlHolder.ChildControl;
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2);
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2);
							}
						}
						IL_189:
						if (controlHolder.Selected)
						{
							switch (A_2)
							{
							case oO_.O_o_.oo.:
								if (!controlHolder.IsFixedHeight)
								{
									controlHolder.Height = A_1.Height;
								}
								if (!controlHolder.IsFixedWidth)
								{
									controlHolder.Width = A_1.Width;
								}
								break;
							case oO_.o_.00o_o000o_0.:
								if (!controlHolder.IsFixedHeight)
								{
									controlHolder.Height = A_1.Height;
								}
								break;
							case oO_.O_oo0O_O._.:
								if (!controlHolder.IsFixedWidth)
								{
									controlHolder.Width = A_1.Width;
								}
								break;
							}
							controlHolder = null;
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
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, OoO_OO0o_0o A_1)
		{
			int num = 0;
			int num2 = int.MaxValue;
			int num3 = int.MinValue;
			int num4 = 0;
			int i = 0;
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder && control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, A_1);
						}
						else
						{
							if (controlHolder.ControlType == ControlTypeEnum.TabControl)
							{
								try
								{
									foreach (object obj2 in ((C1DockingTab)controlHolder.ChildControl).TabPages)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((O_O_)obj2).Controls, A_1);
									}
									goto IL_1B7;
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
							if (controlHolder.ControlType == ControlTypeEnum.NavBar)
							{
								try
								{
									foreach (object obj3 in ((C1NavBar)controlHolder.ChildControl).Panels)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((oO_0)obj3).Controls, A_1);
									}
									goto IL_1B7;
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
							{
								o0000O o0000O = (o0000O)controlHolder.ChildControl;
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1);
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1);
							}
						}
						IL_1B7:
						if (controlHolder.Selected)
						{
							num4++;
							if (A_1 == OoO_OO0o_0o.O_o_.oo.)
							{
								num += control.Width;
								num2 = Math.Min(num2, control.Left);
								num3 = Math.Max(num3, control.Left + control.Width);
							}
							else
							{
								num += control.Height;
								num2 = Math.Min(num2, control.Top);
								num3 = Math.Max(num3, control.Top + control.Height);
							}
							controlHolder = null;
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
			if (num4 >= 2)
			{
				int num5 = (int)Math.Round((double)(num3 - num2 - num) / (double)(num4 - 1));
				ControlHolder[] array = new ControlHolder[num4 - 1 + 1];
				int[] array2 = new int[num4 - 1 + 1];
				try
				{
					foreach (object obj4 in A_0)
					{
						System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj4;
						if (control is ControlHolder && control is ControlHolder && ((ControlHolder)control).Selected)
						{
							array[i] = (ControlHolder)control;
							if (A_1 == OoO_OO0o_0o.O_o_.oo.)
							{
								array2[i] = control.Left;
							}
							else
							{
								array2[i] = control.Top;
							}
							i++;
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
				Array.Sort<int, ControlHolder>(array2, array);
				int num6 = num4 - 1;
				for (i = 0; i <= num6; i++)
				{
					if (A_1 == OoO_OO0o_0o.O_o_.oo.)
					{
						array[i].Left = num2;
						num2 = num2 + array[i].Width + num5;
					}
					else
					{
						array[i].Top = num2;
						num2 = num2 + array[i].Height + num5;
					}
				}
			}
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x001D9F9C File Offset: 0x001D819C
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, int A_1, int A_2, string A_3)
		{
			System.Windows.Forms.Control control = null;
			try
			{
				foreach (object obj in A_0)
				{
					control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.Selected & controlHolder.Dock == DockStyle.None & (Operators.CompareString(controlHolder.DynamicKey, A_3, true) == 0 | Operators.CompareString(A_3, "", true) == 0))
						{
							controlHolder.SetBounds(controlHolder.Left + A_1, controlHolder.Top + A_2, controlHolder.Width, controlHolder.Height);
							controlHolder.ChildControl.Refresh();
						}
						if (!controlHolder.Selected)
						{
							if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
							{
								oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1, A_2, A_3);
							}
							else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
							{
								oOO0oo_o0.O00OO_O_oO_.o.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, A_1, A_2, A_3);
							}
							else if (controlHolder.ControlType == ControlTypeEnum.TabControl)
							{
								C1DockingTab c1DockingTab = (C1DockingTab)controlHolder.ChildControl;
								try
								{
									foreach (object obj2 in c1DockingTab.TabPages)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((O_O_)obj2).Controls, A_1, A_2, A_3);
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
							else if (controlHolder.ControlType == ControlTypeEnum.NavBar)
							{
								C1NavBar c1NavBar = (C1NavBar)controlHolder.ChildControl;
								try
								{
									foreach (object obj3 in c1NavBar.Panels)
									{
										oOO0oo_o0.O00OO_O_oO_.o.(((oO_0)obj3).Controls, A_1, A_2, A_3);
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
							}
							else if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
							{
								o0000O o0000O = (o0000O)controlHolder.ChildControl;
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2, A_3);
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2, A_3);
							}
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
			if (control != null)
			{
				((o\u3000\u3002)control.FindForm().MdiParent).OO_._oOo. = true;
			}
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x001DA244 File Offset: 0x001D8444
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, O0OO000oo0O A_1, int A_2, int A_3)
		{
			System.Windows.Forms.Control control = null;
			try
			{
				foreach (object obj in A_0)
				{
					control = (System.Windows.Forms.Control)obj;
					if (control is ControlHolder)
					{
						ControlHolder controlHolder = (ControlHolder)control;
						if (controlHolder.ControlType == ControlTypeEnum.Panel | controlHolder.ControlType == ControlTypeEnum.GroupBox | controlHolder.ControlType == ControlTypeEnum.Gauges | controlHolder.ControlType == ControlTypeEnum.Map)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1, A_2, A_3);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.PictureBox)
						{
							oOO0oo_o0.O00OO_O_oO_.o.(((CustomPictureBox)controlHolder.ChildControl).PictureBox1.Controls, A_1, A_2, A_3);
						}
						else if (controlHolder.ControlType == ControlTypeEnum.TabControl)
						{
							C1DockingTab c1DockingTab = (C1DockingTab)controlHolder.ChildControl;
							try
							{
								foreach (object obj2 in c1DockingTab.TabPages)
								{
									oOO0oo_o0.O00OO_O_oO_.o.(((O_O_)obj2).Controls, A_1, A_2, A_3);
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
						else if (controlHolder.ControlType == ControlTypeEnum.NavBar)
						{
							C1NavBar c1NavBar = (C1NavBar)controlHolder.ChildControl;
							try
							{
								foreach (object obj3 in c1NavBar.Panels)
								{
									oOO0oo_o0.O00OO_O_oO_.o.(((oO_0)obj3).Controls, A_1, A_2, A_3);
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
						}
						else if (controlHolder.ControlType == ControlTypeEnum.SplitContainer)
						{
							o0000O o0000O = (o0000O)controlHolder.ChildControl;
							oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2, A_3);
							oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2, A_3);
						}
						if (controlHolder.Selected)
						{
							switch (A_1)
							{
							case O0OO000oo0O.OOOOo._.:
								if (controlHolder.Width - A_2 > 14 & !controlHolder.IsFixedWidth & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Right))
								{
									controlHolder.SetBounds(controlHolder.Left + A_2, controlHolder.Top, controlHolder.Width - A_2, controlHolder.Height);
								}
								break;
							case O0OO000oo0O.ooo_O0o._.:
								if (controlHolder.Height - A_3 > 14 & !controlHolder.IsFixedHeight & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Bottom))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top + A_3, controlHolder.Width, controlHolder.Height - A_3);
								}
								break;
							case O0OO000oo0O.o.00o000O00o__.:
								if (controlHolder.Width + A_2 > 14 & !controlHolder.IsFixedWidth & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Left))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width + A_2, controlHolder.Height);
								}
								break;
							case O0OO000oo0O.o_.0_0O.:
								if (controlHolder.Height + A_3 > 14 & !controlHolder.IsFixedHeight & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Top))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width, controlHolder.Height + A_3);
								}
								break;
							case O0OO000oo0O.o_oO._0O.:
								if (controlHolder.Width - A_2 > 14 & !controlHolder.IsFixedWidth & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Right))
								{
									controlHolder.SetBounds(controlHolder.Left + A_2, controlHolder.Top, controlHolder.Width - A_2, controlHolder.Height);
								}
								if (controlHolder.Height - A_3 > 14 & !controlHolder.IsFixedHeight & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Bottom))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top + A_3, controlHolder.Width, controlHolder.Height - A_3);
								}
								break;
							case O0OO000oo0O.o0_OoOo.OO.:
								if (controlHolder.Width + A_2 > 14 & !controlHolder.IsFixedWidth & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Left))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width + A_2, controlHolder.Height);
								}
								if (controlHolder.Height - A_3 > 14 & !controlHolder.IsFixedHeight & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Bottom))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top + A_3, controlHolder.Width, controlHolder.Height - A_3);
								}
								break;
							case O0OO000oo0O.Oo0ooo.OO.:
								if (controlHolder.Width - A_2 > 14 & !controlHolder.IsFixedWidth & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Right))
								{
									controlHolder.SetBounds(controlHolder.Left + A_2, controlHolder.Top, controlHolder.Width - A_2, controlHolder.Height);
								}
								if (controlHolder.Height + A_3 > 14 & !controlHolder.IsFixedHeight & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Top))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width, controlHolder.Height + A_3);
								}
								break;
							case O0OO000oo0O.OO_._O.:
								if (controlHolder.Width + A_2 > 14 & !controlHolder.IsFixedWidth & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Left))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width + A_2, controlHolder.Height);
								}
								if (controlHolder.Height + A_3 > 14 & !controlHolder.IsFixedHeight & (controlHolder.Dock == DockStyle.None | controlHolder.Dock == DockStyle.Top))
								{
									controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width, controlHolder.Height + A_3);
								}
								break;
							}
							controlHolder.ChildControl.Refresh();
							controlHolder = null;
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
			if (control != null)
			{
				((o\u3000\u3002)control.FindForm().MdiParent).OO_._oOo. = true;
			}
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x001DA898 File Offset: 0x001D8A98
		public static void <<EMPTY_NAME>>(System.Windows.Forms.TreeView A_0)
		{
			A_0.ImageList = O_O0OO.OoO.0OO__0ooo.();
			System.Windows.Forms.TreeNode treeNode;
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.Name.StartsWith(OO_00oOO.MainTable.Name))
					{
						treeNode = A_0.Nodes.Add(table.Name, table.Name);
						treeNode.ImageKey = "Table";
						treeNode.SelectedImageKey = treeNode.ImageKey;
						try
						{
							foreach (Col col in table.Cols)
							{
								System.Windows.Forms.TreeNode treeNode2 = treeNode.Nodes.Add(col.Name, col.Name);
								treeNode2.ImageKey = "Column";
								treeNode2.SelectedImageKey = treeNode2.ImageKey;
								treeNode2.Tag = col.DataCol;
							}
						}
						finally
						{
							IEnumerator<Col> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
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
			try
			{
				foreach (Table table2 in OO_00oOO.Tables)
				{
					if (!table2.Name.StartsWith(OO_00oOO.MainTable.Name))
					{
						treeNode = A_0.Nodes.Add(table2.Name, table2.Name);
						treeNode.ImageKey = "Table";
						treeNode.SelectedImageKey = treeNode.ImageKey;
						try
						{
							foreach (Col col2 in table2.Cols)
							{
								System.Windows.Forms.TreeNode treeNode3 = treeNode.Nodes.Add(col2.Name, col2.Name);
								treeNode3.ImageKey = "Column";
								treeNode3.SelectedImageKey = treeNode3.ImageKey;
								treeNode3.Tag = col2.DataCol;
							}
						}
						finally
						{
							IEnumerator<Col> enumerator4;
							if (enumerator4 != null)
							{
								enumerator4.Dispose();
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			o\u3002\u3002\u3000\u3000\u3002 o_u3002_u3002_u3000_u3000_u = null;
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					System.Windows.Forms.Form form = (System.Windows.Forms.Form)obj;
					if (form is o\u3002\u3002\u3000\u3000\u3002)
					{
						o_u3002_u3002_u3000_u3000_u = (o\u3002\u3002\u3000\u3000\u3002)form;
						break;
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
			if (o_u3002_u3002_u3000_u3000_u != null)
			{
				try
				{
					foreach (PropertyBase propertyBase in o_u3002_u3002_u3000_u3000_u.O0o._0..Values)
					{
						if (propertyBase is TableGridProperty)
						{
							TableGridProperty tableGridProperty = (TableGridProperty)propertyBase;
							if (tableGridProperty.TableType != TableTypeEnum.Normal || !tableGridProperty.IsCopy)
							{
								goto IL_38A;
							}
							string relationTable = tableGridProperty.RelationTable;
							if (Operators.CompareString(relationTable, "", true) > 0 && OO_00oOO.Tables.get_Contains(relationTable) && !OO_00oOO.Tables[relationTable].IsRelation)
							{
								string text = o_u3002_u3002_u3000_u3000_u.o_0O.OO0_0_.["Name"].ToString() + "_" + tableGridProperty.Name;
								treeNode = A_0.Nodes.Add(text, text);
								treeNode.ImageKey = "Table";
								treeNode.SelectedImageKey = treeNode.ImageKey;
								try
								{
									foreach (Col col3 in OO_00oOO.Tables[relationTable].Cols)
									{
										System.Windows.Forms.TreeNode treeNode4 = treeNode.Nodes.Add(col3.Name, col3.Name);
										treeNode4.ImageKey = "Column";
										treeNode4.SelectedImageKey = treeNode4.ImageKey;
										treeNode4.Tag = col3.DataCol;
									}
									continue;
								}
								finally
								{
									IEnumerator<Col> enumerator7;
									if (enumerator7 != null)
									{
										enumerator7.Dispose();
									}
								}
								goto IL_38A;
							}
							continue;
							IL_38A:
							if (tableGridProperty.TableType == TableTypeEnum.SQLQuery || tableGridProperty.TableType == TableTypeEnum.SQLTable)
							{
								SQLCommand sqlcommand = new SQLCommand();
								sqlcommand.CommandText = tableGridProperty.SelectString;
								sqlcommand.ConnectionName = tableGridProperty.Connection;
								try
								{
									DataTable dataTable = sqlcommand.OO__00.__.();
									string text2 = o_u3002_u3002_u3000_u3000_u.o_0O.OO0_0_.["Name"].ToString() + "_" + tableGridProperty.Name;
									treeNode = A_0.Nodes.Add(text2, text2);
									treeNode.ImageKey = "Table";
									treeNode.SelectedImageKey = treeNode.ImageKey;
									try
									{
										foreach (DataCol dataCol in dataTable.DataCols)
										{
											System.Windows.Forms.TreeNode treeNode5 = treeNode.Nodes.Add(dataCol.Name, dataCol.Name);
											treeNode5.ImageKey = "Column";
											treeNode5.SelectedImageKey = treeNode5.ImageKey;
											treeNode5.Tag = dataCol;
										}
									}
									finally
									{
										IEnumerator<DataCol> enumerator8;
										if (enumerator8 != null)
										{
											enumerator8.Dispose();
										}
									}
								}
								catch (Exception ex)
								{
								}
							}
						}
					}
				}
				finally
				{
					Dictionary<string, PropertyBase>.ValueCollection.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
			}
			treeNode = new System.Windows.Forms.TreeNode();
			treeNode.Text = "全局变量";
			treeNode.Name = treeNode.Text;
			treeNode.ImageKey = "Va";
			treeNode.SelectedImageKey = "Va";
			try
			{
				foreach (object obj2 in OO_00oOO.Vars.VariableTable.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj2;
					if (!dataColumn.ColumnName.ToLower().StartsWith("sys"))
					{
						System.Windows.Forms.TreeNode treeNode6 = treeNode.Nodes.Add(dataColumn.ColumnName, dataColumn.ColumnName);
						treeNode6.ImageKey = "Var";
						treeNode6.SelectedImageKey = "Var";
					}
				}
			}
			finally
			{
				IEnumerator enumerator9;
				if (enumerator9 is IDisposable)
				{
					(enumerator9 as IDisposable).Dispose();
				}
			}
			if (treeNode.GetNodeCount(false) > 0)
			{
				A_0.Nodes.Add(treeNode);
			}
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x001DAF24 File Offset: 0x001D9124
		public static bool <<EMPTY_NAME>>(System.Windows.Forms.TreeView A_0, TreeNodeCollection A_1, string A_2)
		{
			bool result;
			if (A_0.Nodes == A_1 && (Operators.CompareString(A_0.ImageKey, A_2, true) == 0 || Operators.CompareString(A_0.SelectedImageKey, A_2, true) == 0))
			{
				result = true;
			}
			else
			{
				try
				{
					foreach (object obj in A_1)
					{
						System.Windows.Forms.TreeNode treeNode = (System.Windows.Forms.TreeNode)obj;
						if (Operators.CompareString(treeNode.ImageKey, A_2, true) == 0 || Operators.CompareString(treeNode.SelectedImageKey, A_2, true) == 0)
						{
							return true;
						}
						if (treeNode.GetNodeCount(false) > 0 && oOO0oo_o0.o.O0o000_.(A_0, treeNode.Nodes, A_2))
						{
							return true;
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
				result = false;
			}
			return result;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x001DAFE4 File Offset: 0x001D91E4
		public static void <<EMPTY_NAME>>(C1TopicBar A_0, string A_1)
		{
			ImageList imageList = new ImageList();
			A_0.Pages.Clear();
			A_0.ImageList = imageList;
			if (Operators.CompareString(A_1, "", true) != 0)
			{
				foreach (string text in A_1.Split(new char[]
				{
					'\f'
				}))
				{
					if (Operators.CompareString(text, "Page", true) == 0)
					{
						bool flag = true;
					}
					else
					{
						bool flag;
						if (flag)
						{
							C1TopicPage c1TopicPage = new C1TopicPage();
							object a_ = new TopicPage(c1TopicPage);
							A_0.Pages.Add(c1TopicPage);
							o_O_o_oOoo__.OOOO_OO._oo.(a_, text, '\t');
						}
						else
						{
							C1TopicLink c1TopicLink = new C1TopicLink();
							object a_2 = new TopicLink(c1TopicLink);
							A_0.Pages[A_0.Pages.Count - 1].Links.Add(c1TopicLink);
							o_O_o_oOoo__.OOOO_OO._oo.(a_2, text, '\t');
						}
						flag = false;
					}
				}
			}
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x001DB0C0 File Offset: 0x001D92C0
		internal static void <<EMPTY_NAME>>(O_oOooO_O A_0)
		{
			if (!A_0.o.0O_O0o_..IsRelation)
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.Name, A_0.o.0O_O0o_..Name, true) == 0)
						{
							int num = oo0__Oo.O_000__.o.().TabPages.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								if (oo0__Oo.O_000__.o.().TabPages[i] is O0o0)
								{
									A_0.Dock = DockStyle.Fill;
									C1DockingTabPage c1DockingTabPage = oo0__Oo.O_000__.o.().TabPages[i];
									for (int j = c1DockingTabPage.Controls.Count - 1; j >= 0; j += -1)
									{
										if (!(c1DockingTabPage.Controls[j] is o_O0_0O0))
										{
											c1DockingTabPage.Controls.Remove(c1DockingTabPage.Controls[j]);
										}
									}
									c1DockingTabPage.Controls.Add(A_0);
									A_0.o.0O_O0o_..O.__O0o0.(true, false);
									A_0.BringToFront();
								}
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
			}
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x001DB230 File Offset: 0x001D9430
		internal static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, System.Windows.Forms.Control A_1)
		{
			int num;
			int num6;
			object obj6;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				bool flag = false;
				IL_0B:
				num2 = 3;
				if (A_1 is C1FlexGrid)
				{
					goto IL_29;
				}
				IL_15:
				num2 = 4;
				if (A_1.DataBindings.Count <= 0)
				{
					goto IL_29;
				}
				IL_25:
				num2 = 5;
				flag = true;
				IL_29:
				num2 = 6;
				if (!(A_1 is O_oOooO_O))
				{
					goto IL_49D;
				}
				IL_36:
				num2 = 7;
				O_oOooO_O o_oOooO_O = (O_oOooO_O)A_1;
				IL_40:
				num2 = 8;
				o_oOooO_O.o.0O_O0o_..HideToolTip();
				IL_4E:
				num2 = 9;
				if (o_oOooO_O.o.0O_O0o_. != OO_00oOO.CurrentTable)
				{
					goto IL_83;
				}
				IL_5F:
				num2 = 10;
				OO_00oOO.CurrentTable = OO_00oOO.MainTable;
				IL_6C:
				num2 = 11;
				OO_00oOO.RaiseSystemEvent(OO_00oOO.MainTable, new SystemEventTypeEnum[]
				{
					SystemEventTypeEnum.CurrentTableChanged
				});
				IL_83:
				num2 = 12;
				if (oOO0oo_o0.O._0O0__o. != BooleanEnum.True)
				{
					goto IL_495;
				}
				IL_91:
				num2 = 13;
				IEnumerator enumerator = ((IEnumerable)o_oOooO_O.Cols).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Column column = (Column)obj;
					IL_B5:
					num2 = 14;
					if (column.Editor != null && column.Editor is OooO00O)
					{
						IL_D5:
						num2 = 15;
						OooO00O oooO00O = (OooO00O)column.Editor;
						IL_E6:
						num2 = 16;
						if (oooO00O.DropDownForm != null && oooO00O.DropDownForm.Controls.Count > 0)
						{
							IL_106:
							num2 = 17;
							oooO00O.DropDownForm.Controls.Clear();
						}
						IL_11A:
						num2 = 18;
						column.Editor = null;
						IL_125:
						num2 = 19;
						if (o_oOooO_O.o.0O_O0o_..TableType == TableTypeEnum.Normal && !o_oOooO_O.o.0O_O0o_..IsCopy)
						{
							IL_144:
							num2 = 20;
							o_oOooO_O.o.0O_O0o_..Cols[column.Name].DropForm = o_oOooO_O.o.0O_O0o_..Cols[column.Name].DropForm;
						}
					}
					IL_181:
					num2 = 21;
				}
				IL_190:
				num2 = 22;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_1A8:
				num2 = 23;
				if (o_oOooO_O.o.0O_O0o_..TableType == TableTypeEnum.Normal)
				{
					goto IL_353;
				}
				IL_1BC:
				num2 = 24;
				bool a_ = OO_00oOO.SystemReady;
				IL_1C6:
				num2 = 25;
				OO_00oOO.SystemReady = false;
				IL_1CF:
				num2 = 26;
				string text = o_oOooO_O.o.0O_O0o_..Name;
				IL_1E0:
				num2 = 27;
				DataTable dataTable = OO_00oOO.DataTables[text].BaseTable;
				IL_1F6:
				num2 = 28;
				IEnumerator<Relation> enumerator2 = OO_00oOO.Relations.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Relation relation = enumerator2.Current;
					IL_210:
					num2 = 29;
					if (relation.ParentTable.BaseTable == dataTable || relation.ChildTable.BaseTable == dataTable)
					{
						IL_233:
						num2 = 30;
						OO_00oOO.Relations.Delete(relation.Name);
					}
					IL_247:
					num2 = 31;
				}
				IL_253:
				num2 = 32;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_261:
				num2 = 33;
				o_O_o_oOoo__.oo.O0o0o.(o_oOooO_O.o.0O_O0o_.);
				IL_270:
				num2 = 34;
				OO_00oOO.Tables.OO._O_o__.(text);
				IL_27F:
				num2 = 35;
				O_O0OO.o__.O.().Remove(text);
				IL_28F:
				num2 = 36;
				OO_00oOO.DataTables.OoO_00.O.(text);
				IL_29E:
				num2 = 37;
				if (!O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(text))
				{
					goto IL_2C8;
				}
				IL_2B4:
				num2 = 38;
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(text);
				IL_2C8:
				num2 = 39;
				o_oOooO_O.SetDataBinding(null, null);
				IL_2D4:
				num2 = 40;
				o_oOooO_O.o.0O_O0o_..View.Dispose();
				IL_2E8:
				num2 = 41;
				o_oOooO_O.o.0O_O0o_..foxGrid = null;
				IL_2F8:
				num2 = 42;
				o_oOooO_O.o.0O_O0o_. = null;
				IL_303:
				num2 = 43;
				o_oOooO_O.o.o0OO00oO_0.();
				IL_30D:
				num2 = 44;
				o_oOooO_O.Controls.Clear();
				IL_31C:
				num2 = 45;
				dataTable.Rows.Clear();
				IL_32B:
				num2 = 46;
				dataTable.Reset();
				IL_335:
				num2 = 47;
				dataTable.Dispose();
				IL_33F:
				num2 = 48;
				flag = true;
				IL_344:
				num2 = 49;
				OO_00oOO.SystemReady = a_;
				goto IL_474;
				IL_353:
				num2 = 51;
				if (!o_oOooO_O.o.0O_O0o_..View.O0O.o__0.())
				{
					goto IL_46A;
				}
				IL_36C:
				num2 = 52;
				bool a_2 = OO_00oOO.SystemReady;
				IL_376:
				num2 = 53;
				OO_00oOO.SystemReady = false;
				IL_37F:
				num2 = 54;
				int @fixed = o_oOooO_O.Cols.Fixed;
				int num3 = o_oOooO_O.Cols.Count - 1;
				for (int i = @fixed; i <= num3; i++)
				{
					IL_3A2:
					num2 = 55;
					o_oOooO_O.Cols[i].Editor = null;
					IL_3B9:
					num2 = 56;
				}
				IL_3C8:
				num2 = 57;
				OO_00oOO.Tables.OO._O_o__.(o_oOooO_O.o.0O_O0o_..View.Oo._Oo0OO.());
				IL_3E6:
				num2 = 58;
				O_O0OO.o__.O.().Remove(o_oOooO_O.o.0O_O0o_..View.Oo._Oo0OO.());
				IL_405:
				num2 = 59;
				o_oOooO_O.SetDataBinding(null, null);
				IL_411:
				num2 = 60;
				o_oOooO_O.o.0O_O0o_..View.Dispose();
				IL_425:
				num2 = 61;
				o_oOooO_O.o.0O_O0o_..foxGrid = null;
				IL_435:
				num2 = 62;
				o_oOooO_O.o.0O_O0o_. = null;
				IL_440:
				num2 = 63;
				o_oOooO_O.o.o0OO00oO_0.();
				IL_44A:
				num2 = 64;
				o_oOooO_O.Controls.Clear();
				IL_459:
				num2 = 65;
				flag = true;
				IL_45E:
				num2 = 66;
				OO_00oOO.SystemReady = a_2;
				goto IL_474;
				IL_46A:
				num2 = 68;
				A_1.Visible = true;
				IL_474:
				num2 = 69;
				if (o_oOooO_O.Controls.Count <= 0)
				{
					goto IL_495;
				}
				IL_486:
				num2 = 70;
				o_oOooO_O.Controls.Clear();
				IL_495:
				o_oOooO_O = null;
				goto IL_C26;
				IL_49D:
				num2 = 73;
				if (!(A_1 is WebViewer))
				{
					goto IL_51E;
				}
				IL_4A8:
				num2 = 74;
				((WebViewer)A_1).NavigateToString("");
				IL_4BB:
				num2 = 75;
				((WebViewer)A_1).Stop();
				IL_4C9:
				num2 = 76;
				if (((WebViewer)A_1).CoreWebView2 == null)
				{
					goto IL_4EC;
				}
				IL_4D9:
				num2 = 77;
				((WebViewer)A_1).CoreWebView2.Stop();
				IL_4EC:
				num2 = 78;
				if (A_1.Parent == null)
				{
					goto IL_50B;
				}
				IL_4F7:
				num2 = 79;
				A_1.Parent.Controls.Remove(A_1);
				IL_50B:
				num2 = 80;
				((WebViewer)A_1).Dispose();
				goto IL_C26;
				IL_51E:
				num2 = 82;
				if (!(A_1 is OooOo0___oO))
				{
					goto IL_608;
				}
				IL_52C:
				num2 = 83;
				OooOo0___oO oooOo0___oO = (OooOo0___oO)A_1;
				IL_537:
				num2 = 84;
				int num4 = oooOo0___oO.Rows.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					IL_552:
					num2 = 85;
					System.Windows.Forms.Control editor = oooOo0___oO.GetCellRange(j, 1).StyleNew.Editor;
					IL_56F:
					num2 = 86;
					if (editor != null && editor is OooO00O)
					{
						IL_57F:
						num2 = 87;
						OooO00O oooO00O2 = (OooO00O)editor;
						IL_58B:
						num2 = 88;
						if (oooO00O2.DropDownForm != null && oooO00O2.DropDownForm.Controls.Count > 0)
						{
							IL_5AB:
							num2 = 89;
							oooO00O2.DropDownForm.Controls.Clear();
						}
						IL_5BF:
						num2 = 90;
						oooOo0___oO.GetCellRange(j, 1).StyleNew.Editor = null;
					}
					IL_5DB:
					num2 = 91;
				}
				IL_5ED:
				num2 = 92;
				oooOo0___oO.OO_.O_O0O.(null);
				IL_5F8:
				num2 = 93;
				oooOo0___oO.OO_.O_O0O.(null);
				goto IL_C26;
				IL_608:
				num2 = 95;
				if (!(A_1 is FileManager))
				{
					goto IL_644;
				}
				IL_613:
				num2 = 96;
				if (!((FileManager)A_1).o0o___Oo0o_0.0.)
				{
					goto IL_C26;
				}
				IL_626:
				num2 = 97;
				((FileManager)A_1).ReadOnly = BooleanEnum.Default;
				IL_635:
				num2 = 98;
				A_1.Visible = true;
				goto IL_C26;
				IL_644:
				num2 = 100;
				if (!(A_1 is PictureViewer))
				{
					goto IL_693;
				}
				IL_64F:
				num2 = 101;
				if (!((PictureViewer)A_1).oO0O.o_O_0OO0.)
				{
					goto IL_C26;
				}
				IL_662:
				num2 = 102;
				((PictureViewer)A_1).ReadOnly = BooleanEnum.Default;
				IL_671:
				num2 = 103;
				((PictureViewer)A_1).ImageFiles = "";
				IL_684:
				num2 = 104;
				A_1.Visible = true;
				goto IL_C26;
				IL_693:
				num2 = 106;
				if (!(A_1 is O__o))
				{
					goto IL_6CF;
				}
				IL_69E:
				num2 = 107;
				if (!((O__o)A_1).o__0_o0.OOO_.)
				{
					goto IL_C26;
				}
				IL_6B1:
				num2 = 108;
				((O__o)A_1).O0oO_OOOOo0o.o.(BooleanEnum.Default);
				IL_6C0:
				num2 = 109;
				A_1.Visible = true;
				goto IL_C26;
				IL_6CF:
				num2 = 111;
				if (!(A_1 is System.Windows.Forms.WebBrowser))
				{
					goto IL_6E8;
				}
				IL_6DA:
				num2 = 112;
				A_1.Dispose();
				goto IL_C26;
				IL_6E8:
				num2 = 114;
				if (!(A_1 is C1TopicBar))
				{
					goto IL_7CA;
				}
				IL_6F6:
				num2 = 115;
				C1TopicBar c1TopicBar = (C1TopicBar)A_1;
				IL_701:
				num2 = 116;
				if (c1TopicBar.ImageList == null)
				{
					goto IL_730;
				}
				IL_70D:
				num2 = 117;
				c1TopicBar.ImageList.Images.Clear();
				IL_721:
				num2 = 118;
				c1TopicBar.ImageList.Dispose();
				IL_730:
				num2 = 119;
				IEnumerator enumerator3 = c1TopicBar.Pages.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					object obj2 = enumerator3.Current;
					C1TopicPage c1TopicPage = (C1TopicPage)obj2;
					IL_751:
					num2 = 120;
					if (c1TopicPage.ImageList != null)
					{
						IL_75D:
						num2 = 121;
						c1TopicPage.ImageList.Images.Clear();
						IL_771:
						num2 = 122;
						c1TopicPage.ImageList.Dispose();
					}
					IL_780:
					num2 = 123;
					c1TopicPage.Links.Clear();
					IL_78F:
					num2 = 124;
				}
				IL_79B:
				num2 = 125;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
				IL_7B3:
				num2 = 126;
				c1TopicBar.Pages.Clear();
				IL_7C2:
				c1TopicBar = null;
				goto IL_C26;
				IL_7CA:
				num2 = 129;
				if (!(A_1 is System.Windows.Forms.TreeView))
				{
					goto IL_838;
				}
				IL_7D8:
				num2 = 130;
				System.Windows.Forms.TreeView treeView = (System.Windows.Forms.TreeView)A_1;
				IL_7E6:
				num2 = 131;
				if (treeView.ImageList == null)
				{
					goto IL_81E;
				}
				IL_7F5:
				num2 = 132;
				treeView.ImageList.Images.Clear();
				IL_80C:
				num2 = 133;
				treeView.ImageList.Dispose();
				IL_81E:
				num2 = 134;
				treeView.Nodes.Clear();
				IL_830:
				treeView = null;
				goto IL_C26;
				IL_838:
				num2 = 137;
				if (!(A_1 is o_0))
				{
					goto IL_866;
				}
				IL_846:
				num2 = 138;
				((o_0)A_1).OOOO_.o.().Nodes.Clear();
				goto IL_C26;
				IL_866:
				num2 = 140;
				if (!(A_1 is C1FlexViewer))
				{
					goto IL_8BD;
				}
				IL_874:
				num2 = 141;
				C1FlexViewer c1FlexViewer = (C1FlexViewer)A_1;
				IL_882:
				num2 = 142;
				if (c1FlexViewer.DocumentSource == null)
				{
					goto IL_C26;
				}
				IL_894:
				num2 = 143;
				c1FlexViewer.DocumentSource.ClearContent();
				IL_8A6:
				num2 = 144;
				c1FlexViewer.DocumentSource.Dispose();
				goto IL_C26;
				IL_8BD:
				num2 = 146;
				if (!(A_1 is o_OO_oOOO0o))
				{
					goto IL_921;
				}
				IL_8CB:
				num2 = 147;
				o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_1;
				IL_8D9:
				num2 = 148;
				o_OO_oOOO0o.Items.Clear();
				IL_8EB:
				num2 = 149;
				o_OO_oOOO0o.LargeImageList.Images.Clear();
				IL_902:
				num2 = 150;
				o_OO_oOOO0o.SmallImageList.Images.Clear();
				IL_919:
				o_OO_oOOO0o = null;
				goto IL_C26;
				IL_921:
				num2 = 153;
				if (!(A_1 is OooO00O))
				{
					goto IL_97F;
				}
				IL_92F:
				num2 = 154;
				OooO00O oooO00O3 = (OooO00O)A_1;
				IL_93D:
				num2 = 155;
				if (oooO00O3.DropDownForm == null || oooO00O3.DropDownForm.Controls.Count <= 0)
				{
					goto IL_977;
				}
				IL_960:
				num2 = 156;
				oooO00O3.DropDownForm.Controls.Clear();
				IL_977:
				oooO00O3 = null;
				goto IL_C26;
				IL_97F:
				num2 = 159;
				if (!(A_1 is GeoMap))
				{
					goto IL_9C3;
				}
				IL_98D:
				num2 = 160;
				GeoMap geoMap = (GeoMap)A_1;
				IL_99B:
				num2 = 161;
				geoMap.O.oO_O_..Clear();
				IL_9AD:
				num2 = 162;
				geoMap.O.oO_O_. = null;
				IL_9BB:
				geoMap = null;
				goto IL_C26;
				IL_9C3:
				num2 = 165;
				oOO0oo_o0.O0o.O.(A_1);
				IL_9CF:
				num2 = 166;
				if (!(A_1 is C1NavBar))
				{
					goto IL_A53;
				}
				IL_9DD:
				num2 = 167;
				C1NavBar c1NavBar = (C1NavBar)A_1;
				IL_9EB:
				num2 = 168;
				IEnumerator enumerator4 = c1NavBar.Panels.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					object obj3 = enumerator4.Current;
					C1NavBarPanel c1NavBarPanel = (C1NavBarPanel)obj3;
					IL_A0F:
					num2 = 169;
					oOO0oo_o0.O00OO_O_oO_.o.(c1NavBarPanel.Controls);
					IL_A21:
					num2 = 170;
				}
				IL_A30:
				num2 = 171;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
				IL_A4B:
				c1NavBar = null;
				goto IL_C26;
				IL_A53:
				num2 = 174;
				if (!(A_1 is C1NavBar))
				{
					goto IL_AD7;
				}
				IL_A61:
				num2 = 175;
				C1DockingTab c1DockingTab = (C1DockingTab)A_1;
				IL_A6F:
				num2 = 176;
				IEnumerator enumerator5 = c1DockingTab.TabPages.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					object obj4 = enumerator5.Current;
					C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)obj4;
					IL_A93:
					num2 = 177;
					oOO0oo_o0.O00OO_O_oO_.o.(c1DockingTabPage.Controls);
					IL_AA5:
					num2 = 178;
				}
				IL_AB4:
				num2 = 179;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
				IL_ACF:
				c1DockingTab = null;
				goto IL_C26;
				IL_AD7:
				num2 = 182;
				if (!(A_1 is System.Windows.Forms.SplitContainer))
				{
					goto IL_B29;
				}
				IL_AE5:
				num2 = 183;
				System.Windows.Forms.SplitContainer splitContainer = (System.Windows.Forms.SplitContainer)A_1;
				IL_AF3:
				num2 = 184;
				oOO0oo_o0.O00OO_O_oO_.o.(splitContainer.Panel1.Controls);
				IL_B0A:
				num2 = 185;
				oOO0oo_o0.O00OO_O_oO_.o.(splitContainer.Panel2.Controls);
				IL_B21:
				splitContainer = null;
				goto IL_C26;
				IL_B29:
				num2 = 188;
				if (!(A_1 is C1DockingTab))
				{
					goto IL_C15;
				}
				IL_B3A:
				num2 = 189;
				C1DockingTab c1DockingTab2 = (C1DockingTab)A_1;
				IL_B48:
				num2 = 190;
				IEnumerator enumerator6 = c1DockingTab2.TabPages.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					object obj5 = enumerator6.Current;
					C1DockingTabPage c1DockingTabPage2 = (C1DockingTabPage)obj5;
					IL_B6C:
					num2 = 191;
					oOO0oo_o0.O00OO_O_oO_.o.(c1DockingTabPage2.Controls);
					IL_B7E:
					num2 = 192;
				}
				IL_B8D:
				num2 = 193;
				if (enumerator6 is IDisposable)
				{
					(enumerator6 as IDisposable).Dispose();
				}
				IL_BA8:
				num2 = 194;
				for (int k = c1DockingTab2.TabPages.Count - 1; k <= 0; k++)
				{
					IL_BC0:
					num2 = 195;
					C1DockingTabPage c1DockingTabPage3 = c1DockingTab2.TabPages[k];
					IL_BD6:
					num2 = 196;
					c1DockingTab2.TabPages.RemoveAt(k);
					IL_BEA:
					num2 = 197;
					c1DockingTabPage3.Dispose();
					IL_BF7:
					num2 = 198;
				}
				IL_C08:
				c1DockingTab2 = null;
				IL_C0B:
				num2 = 200;
				flag = true;
				goto IL_C26;
				IL_C15:
				num2 = 202;
				oOO0oo_o0.O00OO_O_oO_.o.(A_1.Controls);
				IL_C26:
				num2 = 203;
				A_1.DataBindings.Clear();
				IL_C37:
				num2 = 204;
				if (A_1 is O_oOooO_O)
				{
					goto IL_C52;
				}
				IL_C45:
				num2 = 206;
				A_1.CausesValidation = false;
				IL_C52:
				num2 = 207;
				A_0.Remove(A_1);
				IL_C5F:
				num2 = 208;
				if (!flag)
				{
					goto IL_CE5;
				}
				IL_C68:
				num2 = 209;
				if (!(A_1 is O_oOooO_O))
				{
					goto IL_CD9;
				}
				IL_C76:
				num2 = 210;
				O_oOooO_O o_oOooO_O2 = (O_oOooO_O)A_1;
				IL_C84:
				num2 = 211;
				Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
				{
					A_1
				});
				IL_C9E:
				num2 = 212;
				o_oOooO_O2.Styles.Clear();
				IL_CB0:
				num2 = 213;
				o_oOooO_O2.Rows.Count = 0;
				IL_CC3:
				num2 = 214;
				o_oOooO_O2.Cols.Count = 0;
				IL_CD6:
				o_oOooO_O2 = null;
				IL_CD9:
				num2 = 216;
				A_1.Dispose();
				IL_CE5:
				goto IL_109B;
				IL_CEA:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_105C:
				goto IL_1090;
				IL_105E:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_106E:;
			}
			catch when (endfilter(obj6 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj7;
				goto IL_105E;
			}
			IL_1090:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_109B:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x001DC2FC File Offset: 0x001DA4FC
		internal static void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			for (int i = A_0.Count - 1; i >= 0; i += -1)
			{
				System.Windows.Forms.Control a_ = A_0[i];
				oOO0oo_o0.O00OO_O_oO_.o.(A_0, a_);
			}
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x001DC32C File Offset: 0x001DA52C
		internal static void <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			if (A_0 is O0oo000oO0oo_)
			{
				O0oo000oO0oo_ o0oo000oO0oo_ = (O0oo000oO0oo_)A_0;
				if (o0oo000oO0oo_.O_.0.() != null)
				{
					MarshalByValueComponent marshalByValueComponent = (DataView)o0oo000oO0oo_.O_.0.();
					o0oo000oO0oo_.OoO.0oo_Oo_.(null);
					marshalByValueComponent.Dispose();
				}
			}
			else if (A_0 is OoOO0Oo_oo0oO)
			{
				OoOO0Oo_oo0oO ooOO0Oo_oo0oO = (OoOO0Oo_oo0oO)A_0;
				if (ooOO0Oo_oo0oO.OO0._0O.() != null)
				{
					MarshalByValueComponent marshalByValueComponent2 = (DataView)ooOO0Oo_oo0oO.OO0._0O.();
					ooOO0Oo_oo0oO.o_O0.OO0o0O0o.(null);
					marshalByValueComponent2.Dispose();
				}
			}
			else if (A_0 is CustomCheckedListBox)
			{
				CustomCheckedListBox customCheckedListBox = (CustomCheckedListBox)A_0;
				if (customCheckedListBox.DataSource != null)
				{
					MarshalByValueComponent marshalByValueComponent3 = (DataView)customCheckedListBox.DataSource;
					customCheckedListBox.DataSource = null;
					marshalByValueComponent3.Dispose();
				}
			}
			else if (A_0 is CustomListBox)
			{
				CustomListBox customListBox = (CustomListBox)A_0;
				if (customListBox.DataSource != null)
				{
					MarshalByValueComponent marshalByValueComponent4 = (DataView)customListBox.DataSource;
					customListBox.DataSource = null;
					marshalByValueComponent4.Dispose();
				}
			}
			if (oOO0oo_o0.ooo_o__OO_.o. == BooleanEnum.Default)
			{
				oOO0oo_o0.ooo_o__OO_.o. = BooleanEnum.True;
				ProjectProperty o0_00o.o0__o. = O_O0OO.O0_00o.o0__o.;
				if (Operators.CompareString(Conversions.ToString(typeof(ProjectProperty).GetProperty(o0OoOOoOOo0.o0_.O_. + "Name", BindingFlags.Instance | BindingFlags.Public).GetValue(O_O0OO.O0_00o.o0__o., null)), O_O0OO.Oo_o000oO.oO., true) != 0)
				{
					OleDbCommand oleDbCommand = new OleDbCommand("Update [" + ooO0__OO.o0O._ooo_O_.() + "] Set [Name] =  [Name] + '\n'", O_O0OO.OoO.0OO__0ooo.());
					O_O0OO.OoO.0OO__0ooo.().Open();
					oleDbCommand.ExecuteNonQuery();
					O_O0OO.OoO.0OO__0ooo.().Close();
				}
			}
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x001DC48F File Offset: 0x001DA68F
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			for (A_0 = A_0.Parent; A_0 != null; A_0 = A_0.Parent)
			{
				if (A_0 is FormPanel)
				{
					((FormPanel)A_0).PrintPropExtender1.Refresh();
					return;
				}
			}
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x001DC4C0 File Offset: 0x001DA6C0
		public static void <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			if (A_0.DataBindings.Count > 0)
			{
				if (A_0 is C1TextBox && ((C1TextBox)A_0).UpdateValueWithCurrentText())
				{
					A_0.DataBindings[0].WriteValue();
				}
				if (A_0.DataBindings[0].BindingManagerBase.Count > 0)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(A_0.DataBindings[0].BindingManagerBase.Current);
					if (objectValue != null)
					{
						((DataRowView)objectValue).Row.EndEdit();
					}
				}
			}
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x001DC54C File Offset: 0x001DA74C
		internal static void <<EMPTY_NAME>>(TreeNodeCollection A_0, ref string A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.TreeNode treeNode = (System.Windows.Forms.TreeNode)obj;
					CustomTreeNodeProperty a_ = new CustomTreeNodeProperty((O_o__00Ooo)treeNode);
					if (Operators.CompareString(A_1, "", true) != 0)
					{
						A_1 += "\f";
					}
					A_1 += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\t', false).Replace("\f", "");
					if (treeNode.Nodes.Count > 0)
					{
						A_1 += "\fInner";
						oOO0oo_o0.O__o0o0O0O_.0.(treeNode.Nodes, ref A_1);
						A_1 += "\fOuter";
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
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x001DC624 File Offset: 0x001DA824
		internal static void <<EMPTY_NAME>>(TreeNodeCollection A_0, ref string A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.TreeNode treeNode = (System.Windows.Forms.TreeNode)obj;
					SimpleNodeProperty a_ = new SimpleNodeProperty((O_o__00Ooo)treeNode);
					if (Operators.CompareString(A_1, "", true) != 0)
					{
						A_1 += "\f";
					}
					A_1 += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\t', false).Replace("\f", "");
					if (treeNode.Nodes.Count > 0)
					{
						A_1 += "\fInner";
						oOO0oo_o0.o.O0o000_.(treeNode.Nodes, ref A_1);
						A_1 += "\fOuter";
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
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x001DC6FC File Offset: 0x001DA8FC
		internal static void <<EMPTY_NAME>>(System.Windows.Forms.TreeView A_0, DataTable A_1, string A_2, string A_3, string A_4, string A_5, bool A_6 = true)
		{
			A_0.Nodes.Clear();
			string text = "";
			if (A_4 == null)
			{
				A_4 = "";
			}
			string[] array = A_4.Split(new char[]
			{
				'|'
			}, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = A_5.Split(new char[]
			{
				'|'
			}, StringSplitOptions.RemoveEmptyEntries);
			foreach (string text2 in array)
			{
				if (!A_1.Columns.Contains(text2))
				{
					MessageBox.Show("无效列名：" + text2, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
			}
			foreach (string text3 in array2)
			{
				if (!A_1.Columns.Contains(text3))
				{
					MessageBox.Show("无效列名：" + text3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (Operators.CompareString(text, "", true) > 0)
				{
					text += ",";
				}
				text += text3;
			}
			Operators.CompareString(A_2, "", true);
			if (Operators.CompareString(A_3, "", true) > 0)
			{
				text = A_3;
			}
			DataView dataView = new DataView(A_1, "", "", DataViewRowState.CurrentRows);
			try
			{
				dataView.RowFilter = A_2;
				dataView.Sort = text;
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			TreeNodeCollection nodes = A_0.Nodes;
			if (dataView.Count != 0)
			{
				A_0.BeginUpdate();
				int num = dataView.Count - 1;
				for (int k = 0; k <= num; k++)
				{
					nodes = A_0.Nodes;
					bool flag = false;
					int num2 = array2.Length - 1;
					int num3 = 0;
					while (num3 <= num2 && Operators.CompareString(dataView[k].Row[array2[num3]].ToString(), "", true) != 0 && (num3 <= 0 || Operators.CompareString(dataView[k].Row[array2[num3 - 1]].ToString(), "", true) != 0))
					{
						string text4;
						if (A_1.Columns[array2[num3]].DataType == typeof(DateTime))
						{
							DateTime dateTime = Conversions.ToDate(dataView[k][array2[num3]]);
							if (DateTime.Compare(dateTime, dateTime.Date) == 0)
							{
								text4 = Strings.Format(dateTime, "yyyy-MM-dd");
							}
							else if (dateTime.Second == 0)
							{
								text4 = Strings.Format(dateTime, "yyyy-MM-dd HH:mm");
							}
							else
							{
								text4 = Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss");
							}
						}
						else
						{
							text4 = dataView[k][array2[num3]].ToString();
							if (Operators.CompareString(text4, "", true) > 0)
							{
								text4 = text4.Trim();
							}
						}
						if (Operators.CompareString(text4, "", true) != 0)
						{
							if (!flag && k > 0 && string.Compare(dataView[k][array2[num3]].ToString(), dataView[k - 1][array2[num3]].ToString(), true) == 0 && (num3 == 0 || string.Compare(dataView[k][array2[num3 - 1]].ToString(), dataView[k - 1][array2[num3 - 1]].ToString(), true) == 0))
							{
								if (num3 < array2.Length - 1)
								{
									nodes = nodes[text4].Nodes;
								}
							}
							else if (nodes.ContainsKey(text4))
							{
								O_o__00Ooo o_o__00Ooo = (O_o__00Ooo)nodes[text4];
								nodes = o_o__00Ooo.Nodes;
							}
							else
							{
								flag = true;
								O_o__00Ooo o_o__00Ooo = new O_o__00Ooo();
								o_o__00Ooo.Text = text4;
								o_o__00Ooo.Name = o_o__00Ooo.Text;
								nodes.Add(o_o__00Ooo);
								nodes = o_o__00Ooo.Nodes;
								if (A_6)
								{
									if (array.Length > 0)
									{
										if (num3 == array2.Length - 1)
										{
											string text5 = "";
											foreach (string property in array)
											{
												text5 = text5 + "\t" + dataView[k][property].ToString();
											}
											o_o__00Ooo.Tag = text5.Trim(new char[]
											{
												'\t'
											});
										}
									}
									else
									{
										o_o__00Ooo.Tag = dataView[k].Row;
									}
								}
							}
						}
						num3++;
					}
				}
				A_0.EndUpdate();
			}
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x001DCB94 File Offset: 0x001DAD94
		public static ChildrenCollection <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			System.Windows.Forms.Control control = A_0;
			ChildrenCollection childrenCollection = new ChildrenCollection();
			while (!(A_0 is FormPanel))
			{
				A_0 = A_0.Parent;
			}
			Foxtable.WinForm.Form form = OO_00oOO.Forms[A_0.Name];
			try
			{
				foreach (object obj in control.Controls)
				{
					Foxtable.WinForm.Control control2 = ooO_0O.o_O0.O_.((System.Windows.Forms.Control)obj);
					if (control2 != null)
					{
						childrenCollection.Add(control2);
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
			return childrenCollection;
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x001DCC24 File Offset: 0x001DAE24
		internal static bool <<EMPTY_NAME>>(System.Windows.Forms.Control A_0, string A_1)
		{
			Assembly assembly = null;
			for (System.Windows.Forms.Control parent = A_0.Parent; parent != null; parent = parent.Parent)
			{
				if (parent is FormPanel)
				{
					assembly = OO_00oOO.Forms[parent.Name].O_0.O00o_00_O.;
					break;
				}
			}
			bool result;
			if (assembly == null)
			{
				result = false;
			}
			else
			{
				A_1 = o0OoOOoOOo0.OO0._Oo0o.(A_1);
				result = (assembly.GetType("UserCode").GetMethod(A_1) != null);
			}
			return result;
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x001DCC8C File Offset: 0x001DAE8C
		internal static void <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			System.Windows.Forms.Control parent = A_0.Parent;
			while (parent != null)
			{
				if (parent is FormPanel)
				{
					string error = ((FormPanel)parent).ErrorProvider1.GetError(A_0);
					if (error != null)
					{
						FormPanel formPanel = (FormPanel)parent;
						formPanel.ooOo.o_. = A_0;
						formPanel.ooOo.o_. = error;
						return;
					}
				}
				else
				{
					parent = parent.Parent;
				}
			}
		}

		// Token: 0x04001AEE RID: 6894
		private static BooleanEnum <<EMPTY_NAME>> = BooleanEnum.Default;

		// Token: 0x04001AEF RID: 6895
		private static BooleanEnum <<EMPTY_NAME>> = BooleanEnum.True;

		// Token: 0x04001AF0 RID: 6896
		private static Type <<EMPTY_NAME>>;

		// Token: 0x04001AF1 RID: 6897
		private static MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04001AF2 RID: 6898
		private static bool <<EMPTY_NAME>>;
	}
}

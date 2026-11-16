using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Ribbon;
using Foxtable.My;
using Foxtable.My.Resources;
using Foxtable.RibbonMenu;
using Foxtable.Syscmd;
using Foxtable.WinForm;
using Foxtable.Word;
using Foxtable.XLS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004CD RID: 1229
	internal class o_Oo_o0O
	{
		// Token: 0x06005126 RID: 20774 RVA: 0x00240C3A File Offset: 0x0023EE3A
		public o_Oo_o0O()
		{
			this.O_o._0oo0o0_0. = "Connected";
			this.o.o_0o_O0O_. = "";
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00240C58 File Offset: 0x0023EE58
		internal void <<EMPTY_NAME>>(C1Ribbon A_0, Dictionary<string, o__o_OO_o_> A_1, C1CommandHolder A_2, Ribbon A_3)
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
				DataTable dataTable = A_3.DataTable;
				IL_11:
				num2 = 3;
				List<RibbonTab> list = new List<RibbonTab>();
				IL_1A:
				num2 = 4;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				IL_23:
				num2 = 5;
				List<RibbonContextualTabGroup> list2 = new List<RibbonContextualTabGroup>();
				IL_2C:
				num2 = 6;
				this.O_o._0oo0o0_0. = A_2;
				IL_35:
				num2 = 7;
				A_2.Commands.Clear();
				IL_42:
				num2 = 8;
				if (Operators.CompareString(A_3.Text, "", true) != 0)
				{
					goto IL_67;
				}
				IL_58:
				num2 = 9;
				A_3.Text = "Foxtable";
				IL_67:
				num2 = 10;
				if (!A_3.ShowFileName)
				{
					goto IL_DC;
				}
				IL_73:
				num2 = 11;
				if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) != 0)
				{
					goto IL_A8;
				}
				IL_88:
				num2 = 12;
				Main.OO_O.o..Text = A_3.Text + " - 新项目";
				goto IL_F0;
				IL_A8:
				num2 = 14;
				Main.OO_O.o..Text = A_3.Text + " - " + Foxtable.My.c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile);
				goto IL_F0;
				IL_DC:
				num2 = 16;
				Main.OO_O.o..Text = A_3.Text;
				IL_F0:
				num2 = 17;
				O_O0OO.o_Oo0_oOo.0. = A_3.ShowFileName;
				IL_FF:
				num2 = 18;
				A_0.Text = A_3.Text;
				IL_10F:
				num2 = 19;
				A_0.AllowMinimize = A_3.AllowMinimize;
				IL_11F:
				num2 = 20;
				A_0.Minimized = A_3.Minimized;
				IL_12F:
				num2 = 21;
				A_0.HideTabHeaderRow = A_3.HideTabHederRow;
				IL_13F:
				num2 = 22;
				if (Operators.CompareString(A_3.Image, "", true) <= 0)
				{
					goto IL_171;
				}
				IL_157:
				num2 = 23;
				A_0.ApplicationMenu.SmallImage = OO_00oOO.GetImage(A_3.Image);
				IL_171:
				num2 = 24;
				if (A_0.ApplicationMenu.SmallImage != null)
				{
					goto IL_199;
				}
				IL_181:
				num2 = 25;
				A_0.ApplicationMenu.SmallImage = Foxtable.My.Resources.a.oo.O00O.().ToBitmap();
				IL_199:
				num2 = 26;
				A_0.Qat.Items.Clear();
				IL_1AC:
				num2 = 27;
				A_0.ConfigToolBar.Items.Clear();
				IL_1BF:
				num2 = 28;
				A_0.TopToolBar.Items.Clear();
				IL_1D2:
				num2 = 29;
				A_0.BottomToolBar.Items.Clear();
				IL_1E5:
				num2 = 30;
				A_0.ApplicationMenu.LeftPaneItems.Clear();
				IL_1F8:
				num2 = 31;
				A_0.ApplicationMenu.RightPaneItems.Clear();
				IL_20B:
				num2 = 32;
				A_0.ApplicationMenu.BottomPaneItems.Clear();
				IL_21E:
				num2 = 33;
				A_0.ApplicationMenu.Text = "文件";
				IL_231:
				num2 = 34;
				DataRow[] array = dataTable.Select("[Type] = " + Conversions.ToString(0));
				IL_24C:
				num2 = 35;
				if (array.Length == 0)
				{
					goto IL_D5B;
				}
				IL_258:
				num2 = 38;
				A_0.Tag = RuntimeHelpers.GetObjectValue(array[0]["Key"]);
				IL_274:
				num2 = 39;
				A_0.Qat.BelowRibbon = A_3.O0o.O00..BelowRibbon;
				IL_28E:
				num2 = 40;
				A_0.Qat.Visible = A_3.O0o.O00..Visible;
				IL_2A8:
				num2 = 41;
				array = dataTable.Select("[Type] = " + Conversions.ToString(2));
				IL_2C3:
				num2 = 42;
				if (array.Length <= 0)
				{
					goto IL_307;
				}
				IL_2CD:
				num2 = 43;
				this.o0O0.Oo0_OOO0.(A_0.Qat.Items, array[0], RibbonPaneEnum.Left);
				IL_2E6:
				num2 = 44;
				A_0.Qat.Tag = RuntimeHelpers.GetObjectValue(array[0]["Key"]);
				IL_307:
				num2 = 45;
				A_0.ConfigToolBar.Visible = A_3.O0o.O00..Visible;
				IL_321:
				num2 = 46;
				array = dataTable.Select("[Type] = " + Conversions.ToString(3));
				IL_33C:
				num2 = 47;
				if (array.Length <= 0)
				{
					goto IL_380;
				}
				IL_346:
				num2 = 48;
				this.o0O0.Oo0_OOO0.(A_0.ConfigToolBar.Items, array[0], RibbonPaneEnum.Left);
				IL_35F:
				num2 = 49;
				A_0.ConfigToolBar.Tag = RuntimeHelpers.GetObjectValue(array[0]["Key"]);
				IL_380:
				num2 = 50;
				A_0.BottomToolBar.Visible = A_3.O0o.O00..Visible;
				IL_39A:
				num2 = 51;
				array = dataTable.Select("[Type] = " + Conversions.ToString(36));
				IL_3B6:
				num2 = 52;
				if (array.Length <= 0)
				{
					goto IL_3FA;
				}
				IL_3C0:
				num2 = 53;
				this.o0O0.Oo0_OOO0.(A_0.BottomToolBar.Items, array[0], RibbonPaneEnum.Left);
				IL_3D9:
				num2 = 54;
				A_0.BottomToolBar.Tag = RuntimeHelpers.GetObjectValue(array[0]["Key"]);
				IL_3FA:
				num2 = 55;
				A_0.TopToolBar.Visible = A_3.oo00OO_0.0o000..Visible;
				IL_414:
				num2 = 56;
				array = dataTable.Select("[Type] = " + Conversions.ToString(35));
				IL_430:
				num2 = 57;
				if (array.Length <= 0)
				{
					goto IL_474;
				}
				IL_43A:
				num2 = 58;
				this.o0O0.Oo0_OOO0.(A_0.TopToolBar.Items, array[0], RibbonPaneEnum.Left);
				IL_453:
				num2 = 59;
				A_0.TopToolBar.Tag = RuntimeHelpers.GetObjectValue(array[0]["Key"]);
				IL_474:
				num2 = 60;
				C1.Win.C1Ribbon.RibbonItemCollection[] array2 = new C1.Win.C1Ribbon.RibbonItemCollection[]
				{
					A_0.ConfigToolBar.Items,
					A_0.TopToolBar.Items,
					A_0.BottomToolBar.Items
				};
				IL_4A9:
				num2 = 61;
				foreach (C1.Win.C1Ribbon.RibbonItemCollection a_ in array2)
				{
					IL_4BC:
					num2 = 62;
					this.OO.0OO0oo0O_O.(a_);
					IL_4C7:
					num2 = 63;
				}
				IL_4D8:
				num2 = 64;
				A_0.ApplicationMenu.DropDownWidth = A_3.O0o.O00..DropdownWidth;
				IL_4F2:
				num2 = 65;
				A_0.ApplicationMenu.Visible = A_3.O0o.O00..Visible;
				IL_50C:
				num2 = 66;
				A_0.ApplicationMenu.Text = A_3.O0o.O00..Text;
				IL_526:
				num2 = 67;
				array = dataTable.Select("[Type] = " + Conversions.ToString(1));
				IL_541:
				num2 = 68;
				if (array.Length <= 0)
				{
					goto IL_5B7;
				}
				IL_54B:
				num2 = 69;
				this.o0O0.Oo0_OOO0.(A_0.ApplicationMenu.LeftPaneItems, array[0], RibbonPaneEnum.Left);
				IL_564:
				num2 = 70;
				this.o0O0.Oo0_OOO0.(A_0.ApplicationMenu.RightPaneItems, array[0], RibbonPaneEnum.Right);
				IL_57D:
				num2 = 71;
				this.o0O0.Oo0_OOO0.(A_0.ApplicationMenu.BottomPaneItems, array[0], RibbonPaneEnum.Bottom);
				IL_596:
				num2 = 72;
				A_0.ApplicationMenu.Tag = RuntimeHelpers.GetObjectValue(array[0]["Key"]);
				IL_5B7:
				num2 = 73;
				O_O0OO.o0OoO00OO.00O. = A_3.O0o.O00..RecentFiles;
				IL_5CB:
				ProjectData.ClearProjectError();
				num = 0;
				IL_5D2:
				num2 = 75;
				Type type = Assembly.GetExecutingAssembly().GetType(o0OoOOoOOo0.O_00o0.O0OO_0.[0] + "." + o0OoOOoOOo0.O_00o0.O0OO_0.[1]);
				IL_5F9:
				num2 = 76;
				MethodInfo method = type.GetMethod(o0OoOOoOOo0.O_00o0.O0OO_0.[2], BindingFlags.Static | BindingFlags.NonPublic);
				IL_60E:
				num2 = 77;
				this.o.o_0o_O0O_. = method.Name;
				IL_61E:
				num2 = 78;
				foreach (DataRow dataRow in dataTable.Select("[Type] = " + Conversions.ToString(5), "Index", DataViewRowState.CurrentRows))
				{
					IL_64F:
					num2 = 79;
					RibbonTab ribbonTab = new RibbonTab();
					IL_659:
					num2 = 80;
					RibbonTab ribbonTab2 = new RibbonTab(dataRow);
					IL_665:
					num2 = 81;
					ribbonTab.ID = ribbonTab2.Name;
					IL_676:
					num2 = 82;
					ribbonTab.Text = ribbonTab2.Text;
					IL_687:
					num2 = 83;
					ribbonTab.ToolTip = ribbonTab2.ToolTip;
					IL_698:
					num2 = 84;
					ribbonTab.Enabled = ribbonTab2.Enabled;
					IL_6A9:
					num2 = 85;
					ribbonTab.Visible = ribbonTab2.Visible;
					IL_6BA:
					num2 = 86;
					ribbonTab.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					IL_6D5:
					num2 = 87;
					if (Operators.CompareString(ribbonTab2.TopTab, "", true) > 0)
					{
						IL_6ED:
						num2 = 88;
						dictionary.Add(ribbonTab.ID, ribbonTab2.TopTab);
					}
					IL_705:
					num2 = 89;
					if (Operators.CompareString(ribbonTab2.Image, "", true) > 0)
					{
						IL_71D:
						num2 = 90;
						ribbonTab.Image = OO_00oOO.GetImage(ribbonTab2.Image);
					}
					IL_733:
					num2 = 91;
					foreach (DataRow dataRow2 in dataTable.Select("[ParentKey] = '" + dataRow["Key"].ToString() + "'", "Index"))
					{
						IL_772:
						num2 = 92;
						if (Conversions.ToInteger(dataRow2["Type"]) == 7)
						{
							IL_78C:
							num2 = 93;
							RibbonGroup ribbonGroup = new RibbonGroup();
							IL_796:
							num2 = 94;
							RibbonGroup ribbonGroup2 = new RibbonGroup(dataRow2);
							IL_7A2:
							num2 = 95;
							ribbonGroup.ID = ribbonGroup2.Name;
							IL_7B3:
							num2 = 96;
							ribbonGroup.Text = ribbonGroup2.Text;
							IL_7C4:
							num2 = 97;
							ribbonGroup.ToolTip = ribbonGroup2.ToolTip;
							IL_7D5:
							num2 = 98;
							ribbonGroup.Enabled = ribbonGroup2.Enabled;
							IL_7E6:
							num2 = 99;
							ribbonGroup.Visible = ribbonGroup2.Visible;
							IL_7F7:
							num2 = 100;
							ribbonGroup.HasLauncherButton = ribbonGroup2.HasLauncherButton;
							IL_808:
							num2 = 101;
							ribbonGroup.Tag = RuntimeHelpers.GetObjectValue(dataRow2["Key"]);
							IL_823:
							num2 = 102;
							if (Operators.CompareString(ribbonGroup2.Image, "", true) > 0)
							{
								IL_83B:
								num2 = 103;
								ribbonGroup.Image = OO_00oOO.GetImage(ribbonGroup2.Image);
							}
							IL_851:
							num2 = 104;
							ribbonTab.Groups.Add(ribbonGroup);
							IL_863:
							num2 = 105;
							this.o0O0.Oo0_OOO0.(ribbonGroup.Items, dataRow2, RibbonPaneEnum.Left);
						}
						IL_876:
						num2 = 106;
					}
					IL_88A:
					num2 = 107;
					list.Add(ribbonTab);
					IL_896:
					num2 = 108;
				}
				IL_8AA:
				num2 = 109;
				foreach (DataRow dataRow in dataTable.Select("[Type] = " + Conversions.ToString(37), "Index", DataViewRowState.CurrentRows))
				{
					IL_8DC:
					num2 = 110;
					RibbonContextualTabGroup ribbonContextualTabGroup = new RibbonContextualTabGroup();
					IL_8E6:
					num2 = 111;
					RibbonTopTab ribbonTopTab = new RibbonTopTab(dataRow);
					IL_8F2:
					num2 = 112;
					ribbonContextualTabGroup.Color = ribbonTopTab.Color;
					IL_903:
					num2 = 113;
					ribbonContextualTabGroup.ForeColor = ribbonTopTab.ForeColor;
					IL_914:
					num2 = 114;
					ribbonContextualTabGroup.Name = ribbonTopTab.Name;
					IL_925:
					num2 = 115;
					ribbonContextualTabGroup.Text = ribbonTopTab.Text;
					IL_936:
					num2 = 116;
					ribbonContextualTabGroup.ToolTip = ribbonTopTab.ToolTip;
					IL_947:
					num2 = 117;
					ribbonContextualTabGroup.Clickable = ribbonTopTab.Clickable;
					IL_958:
					num2 = 118;
					ribbonContextualTabGroup.Visible = ribbonTopTab.Visible;
					IL_969:
					num2 = 119;
					list2.Add(ribbonContextualTabGroup);
					IL_975:
					num2 = 120;
				}
				IL_989:
				num2 = 121;
				A_0.ContextualTabGroups.Clear();
				IL_997:
				num2 = 122;
				A_0.Tabs.Clear();
				IL_9A5:
				num2 = 123;
				List<RibbonContextualTabGroup>.Enumerator enumerator = list2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					RibbonContextualTabGroup tabGroup = enumerator.Current;
					IL_9BC:
					num2 = 124;
					A_0.ContextualTabGroups.Add(tabGroup);
					IL_9CD:
					num2 = 125;
				}
				IL_9D9:
				num2 = 126;
				((IDisposable)enumerator).Dispose();
				IL_9E9:
				num2 = 127;
				List<RibbonTab>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					RibbonTab ribbonTab3 = enumerator2.Current;
					IL_A03:
					num2 = 128;
					if (dictionary.ContainsKey(ribbonTab3.ID) && A_0.ContextualTabGroups.Contains(dictionary[ribbonTab3.ID]))
					{
						IL_A34:
						num2 = 129;
						A_0.ContextualTabGroups[dictionary[ribbonTab3.ID]].Tabs.Add(ribbonTab3);
					}
					else
					{
						IL_A62:
						num2 = 131;
						A_0.Tabs.Add(ribbonTab3);
					}
					IL_A76:
					num2 = 132;
				}
				IL_A88:
				num2 = 133;
				((IDisposable)enumerator2).Dispose();
				IL_A9B:
				num2 = 134;
				A_0.SelectedTab = null;
				IL_AA8:
				num2 = 135;
				if (Conversions.ToInteger(method.Invoke(null, o0OoOOoOOo0.O_00o0.O0OO_0.)) == 0)
				{
					goto IL_B0D;
				}
				IL_AC2:
				num2 = 136;
				IEnumerator<DataTable> enumerator3 = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataTable dataTable2 = enumerator3.Current;
					IL_ADF:
					num2 = 137;
					dataTable2.o0O.O_0.(null);
					IL_AED:
					num2 = 138;
				}
				IL_AFC:
				num2 = 139;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_B0D:
				num2 = 140;
				A_1.Clear();
				IL_B19:
				num2 = 141;
				foreach (DataRow dataRow in dataTable.Select("[Type] = " + Conversions.ToString(128), "Index", DataViewRowState.CurrentRows))
				{
					IL_B51:
					num2 = 142;
					o__o_OO_o_ o__o_OO_o_ = new o__o_OO_o_();
					IL_B5E:
					num2 = 143;
					Foxtable.ContextMenu contextMenu = new Foxtable.ContextMenu(dataRow);
					IL_B6D:
					num2 = 144;
					o__o_OO_o_.Name = contextMenu.Name;
					IL_B81:
					num2 = 145;
					o__o_OO_o_.UserData = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					IL_B9F:
					num2 = 146;
					this.Oo.oO_ooo_o0.(o__o_OO_o_.CommandLinks, dataRow);
					IL_BB4:
					num2 = 147;
					A_1.Add(contextMenu.Name, o__o_OO_o_);
					IL_BC9:
					num2 = 148;
					if (A_0.FindForm() == OO_00oOO.BaseMainForm)
					{
						IL_BDC:
						num2 = 149;
						o__o_OO_o_.Popup += this.o0O0.o.;
						IL_BF5:
						num2 = 150;
						o__o_OO_o_.Closed += this.o.0oO0ooO__ooo.;
					}
					IL_C0E:
					num2 = 151;
				}
				IL_C25:
				num2 = 152;
				A_0.ApplicationMenu.BottomPaneItems.Insert(0, this.o._o0ooOOO.());
				IL_C42:
				num2 = 153;
				if (dataTable.DataSet != null)
				{
					goto IL_D5B;
				}
				IL_C53:
				num2 = 154;
				if (O_O0OO.o.0__0_O_. != null)
				{
					goto IL_D0D;
				}
				IL_C63:
				num2 = 155;
				O_O0OO.o.0__0_O_. = new RibbonButton();
				IL_C73:
				num2 = 156;
				O_O0OO.o.0__0_O_..SmallImage = Foxtable.My.Resources.a.OOo_0_0oo._0o_.().ToBitmap();
				IL_C8D:
				num2 = 157;
				O_O0OO.o.0__0_O_..ToolTip = "Power by Foxtable";
				IL_CA2:
				num2 = 158;
				O_O0OO.o.0__0_O_..Name = "FoxHomeButton";
				IL_CB7:
				num2 = 159;
				O_O0OO.o.0__0_O_..Click += this.OO_00O00.OO.;
				IL_CD3:
				num2 = 160;
				if (dataTable.DataSet != null)
				{
					goto IL_CF8;
				}
				IL_CE1:
				num2 = 161;
				O_O0OO.o.0__0_O_..Tag = "System";
				goto IL_D0D;
				IL_CF8:
				num2 = 163;
				O_O0OO.o.0__0_O_..Tag = "User";
				IL_D0D:
				num2 = 164;
				A_0.ConfigToolBar.Items.Add(O_O0OO.o.0__0_O_.);
				IL_D5B:
				goto IL_1051;
				IL_D2B:
				num2 = 166;
				if (Information.Err().Number == 0)
				{
					goto IL_D5B;
				}
				IL_D3D:
				num2 = 167;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_D5B;
				IL_D60:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1012:
				goto IL_1046;
				IL_1014:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1024:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1014;
			}
			IL_1046:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1051:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00241CDC File Offset: 0x0023FEDC
		private void <<EMPTY_NAME>>(C1.Win.C1Ribbon.RibbonItemCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					C1.Win.C1Ribbon.RibbonItem ribbonItem = (C1.Win.C1Ribbon.RibbonItem)obj;
					if (ribbonItem is RibbonButton)
					{
						RibbonButton ribbonButton = (RibbonButton)ribbonItem;
						if (Operators.CompareString(ribbonButton.Text, "", true) > 0)
						{
							ribbonButton.Text = ribbonButton.Text.Trim();
						}
					}
					if (ribbonItem is RibbonSplitButton)
					{
						RibbonSplitButton ribbonSplitButton = (RibbonSplitButton)ribbonItem;
						if (Operators.CompareString(ribbonSplitButton.Text, "", true) > 0)
						{
							ribbonSplitButton.Text = ribbonSplitButton.Text.Trim();
						}
					}
					if (ribbonItem is RibbonMenu)
					{
						RibbonMenu ribbonMenu = (RibbonMenu)ribbonItem;
						if (Operators.CompareString(ribbonMenu.Text, "", true) > 0)
						{
							ribbonMenu.Text = ribbonMenu.Text.Trim();
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

		// Token: 0x06005129 RID: 20777 RVA: 0x00241DDC File Offset: 0x0023FFDC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string str;
			if (Operators.CompareString(((RibbonButton)A_0).Tag.ToString(), "User", true) == 0)
			{
				str = "本软件基于Foxtable设计，";
			}
			else
			{
				str = "感谢您使用Foxtable，";
			}
			if (MessageBox.Show(str + "是否访问Foxtable主页？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				ooO.O_o__O__OO.0o.();
			}
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00241E34 File Offset: 0x00240034
		private void <<EMPTY_NAME>>(C1CommandLinks A_0, DataRow A_1)
		{
			A_0.Clear();
			foreach (DataRow dataRow in A_1.Table.Select("[ParentKey] = '" + A_1["Key"].ToString() + "'", "Index"))
			{
				RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(dataRow["Type"]);
				C1Command c1Command;
				if (ribbonItemTypeEnum == RibbonItemTypeEnum.ContextCommand)
				{
					c1Command = this.O_o._0oo0o0_0..CreateCommand();
				}
				else
				{
					if (ribbonItemTypeEnum != RibbonItemTypeEnum.ContextCommandMenu)
					{
						break;
					}
					c1Command = this.O_o._0oo0o0_0..CreateCommand(typeof(C1CommandMenu));
				}
				ContextCommand contextCommand = new ContextCommand(dataRow);
				C1CommandLink c1CommandLink = new C1CommandLink(c1Command);
				c1Command.Name = contextCommand.Name;
				c1Command.Text = contextCommand.Text;
				c1Command.Visible = contextCommand.Visible;
				c1Command.Enabled = contextCommand.Enabled;
				c1Command.Checked = contextCommand.Checked;
				c1Command.CheckAutoToggle = contextCommand.CheckAutoToggle;
				if (contextCommand.Delimiter)
				{
					c1CommandLink.Delimiter = true;
				}
				c1Command.UserData = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
				if (Operators.CompareString(contextCommand.Image, "", true) > 0)
				{
					c1Command.Image = OO_00oOO.GetImage(contextCommand.Image);
				}
				A_0.Add(c1CommandLink);
				if (this.O_o._0oo0o0_0. == Main.OO_O.o..O.OOO0_OOo.())
				{
					c1Command.Click += this.o._o0ooOOO.;
				}
				if (ribbonItemTypeEnum == RibbonItemTypeEnum.ContextCommandMenu)
				{
					C1CommandMenu c1CommandMenu = (C1CommandMenu)c1Command;
					this.Oo.oO_ooo_o0.(c1CommandMenu.CommandLinks, dataRow);
					if (this.O_o._0oo0o0_0. == Main.OO_O.o..O.OOO0_OOo.())
					{
						c1CommandMenu.Popup += this.OoO._o0oo0o0.;
						c1CommandMenu.Closed += this.O.o0_O_O.;
					}
				}
			}
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00242014 File Offset: 0x00240214
		private void <<EMPTY_NAME>>(object A_0, ClickEventArgs A_1)
		{
			C1Command c1Command = (C1Command)A_0;
			ContextCommandEventArgs contextCommandEventArgs = new ContextCommandEventArgs(new ContextCommand(A_1.CallerLink));
			string a_ = "Click_" + Conversions.ToString(c1Command.UserData);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
			{
				contextCommandEventArgs
			}, false, "快捷菜单," + c1Command.Name, false);
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x00242078 File Offset: 0x00240278
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1ContextMenu c1ContextMenu = (C1ContextMenu)A_0;
			ContextMenuEventArgs contextMenuEventArgs = new ContextMenuEventArgs(new Foxtable.RibbonMenu.ContextMenu(c1ContextMenu));
			string a_ = "Popup_" + Conversions.ToString(c1ContextMenu.UserData);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
			{
				contextMenuEventArgs
			}, false, "快捷菜单," + c1ContextMenu.Name, false);
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x002420D8 File Offset: 0x002402D8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1ContextMenu c1ContextMenu = (C1ContextMenu)A_0;
			ContextMenuEventArgs contextMenuEventArgs = new ContextMenuEventArgs(new Foxtable.RibbonMenu.ContextMenu(c1ContextMenu));
			string a_ = "Closed_" + Conversions.ToString(c1ContextMenu.UserData);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
			{
				contextMenuEventArgs
			}, false, "快捷菜单," + c1ContextMenu.Name, false);
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x00242138 File Offset: 0x00240338
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1CommandMenu c1CommandMenu = (C1CommandMenu)A_0;
			ContextCommandMenuEventArgs contextCommandMenuEventArgs = new ContextCommandMenuEventArgs(new ContextCommandMenu(c1CommandMenu));
			string a_ = "Popup_" + Conversions.ToString(c1CommandMenu.UserData);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
			{
				contextCommandMenuEventArgs
			}, false, "快捷菜单," + c1CommandMenu.Name, false);
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x00242198 File Offset: 0x00240398
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1CommandMenu c1CommandMenu = (C1CommandMenu)A_0;
			ContextCommandMenuEventArgs contextCommandMenuEventArgs = new ContextCommandMenuEventArgs(new ContextCommandMenu(c1CommandMenu));
			string a_ = "Closed_" + Conversions.ToString(c1CommandMenu.UserData);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
			{
				contextCommandMenuEventArgs
			}, false, "快捷菜单," + c1CommandMenu.Name, false);
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x002421F8 File Offset: 0x002403F8
		private RibbonButton <<EMPTY_NAME>>()
		{
			RibbonButton ribbonButton = new RibbonButton();
			ribbonButton.Text = "Foxtable";
			ribbonButton.Name = "Foxtable";
			ribbonButton.ToolTip = "Foxtable官方论坛";
			ribbonButton.SmallImage = OO_00oOO.GetImage("Home16.Ico");
			ribbonButton.Click += this.O.OO_0.;
			return ribbonButton;
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x0024224D File Offset: 0x0024044D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO.O_o__O__OO.0o.();
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x00242254 File Offset: 0x00240454
		private void <<EMPTY_NAME>>(RibbonItemCollectionBase A_0, DataRow A_1, RibbonPaneEnum A_2 = RibbonPaneEnum.Left)
		{
			A_0.Clear();
			foreach (DataRow dataRow in A_1.Table.Select("[ParentKey] = '" + A_1["Key"].ToString() + "' And Pane = " + Conversions.ToString((int)A_2), "Index"))
			{
				RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(dataRow["Type"]);
				C1.Win.C1Ribbon.RibbonItem ribbonItem = null;
				switch (ribbonItemTypeEnum)
				{
				case RibbonItemTypeEnum.PaperList:
				case RibbonItemTypeEnum.WindowList:
				case RibbonItemTypeEnum.TableViewList:
				case RibbonItemTypeEnum.GroupTableList:
				case RibbonItemTypeEnum.CrossTableList:
				case RibbonItemTypeEnum.SubtotalModeList:
				case RibbonItemTypeEnum.ExcelReportList:
				case RibbonItemTypeEnum.CodeReportList:
				case RibbonItemTypeEnum.WordReportList:
				{
					RibbonMenu ribbonMenu = new RibbonMenu();
					RibbonMenuButton ribbonMenuButton = new RibbonMenuButton(dataRow);
					this.o0O0.Oo0_OOO0.(ribbonMenuButton, ribbonMenu);
					if (ribbonMenu.LargeImage != null && Operators.CompareString(ribbonMenuButton.Text, "", true) > 0 && ribbonMenuButton.Text.IndexOf(' ') < 0)
					{
						ribbonMenu.Text = ribbonMenuButton.Text + " ";
					}
					else
					{
						ribbonMenu.Text = ribbonMenuButton.Text;
					}
					ribbonItem = ribbonMenu;
					this.o0O0.Oo0_OOO0.(ribbonMenu.Items, dataRow, RibbonPaneEnum.Left);
					ribbonMenu.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					if (ribbonItemTypeEnum == RibbonItemTypeEnum.WindowList)
					{
						ribbonMenu.MouseEnter += this.oo000_oo0o0._.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.PaperList)
					{
						PrinterSettings printerSettings = new PrinterSettings();
						try
						{
							foreach (object obj in printerSettings.PaperSizes)
							{
								PaperSize paperSize = (PaperSize)obj;
								RibbonToggleButton ribbonToggleButton = new RibbonToggleButton();
								ribbonToggleButton.Text = paperSize.PaperName;
								ribbonToggleButton.Tag = paperSize.RawKind;
								ribbonToggleButton.Click += this.O_0O0._0_O0.;
								ribbonMenu.Items.Add(ribbonToggleButton);
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
						RibbonToggleButton ribbonToggleButton2 = new RibbonToggleButton();
						ribbonToggleButton2.Text = "自定义";
						ribbonToggleButton2.Tag = 0;
						ribbonToggleButton2.Click += this.o_O_.o__0Ooo_.;
						ribbonMenu.Items.Add(ribbonToggleButton2);
						ribbonMenu.DropDown += this.o0_Oo.00o00_.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.TableViewList)
					{
						ribbonMenu.MouseEnter += this.OO_.0__o.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.GroupTableList)
					{
						ribbonMenu.MouseEnter += this.O.oO_0o0.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.CrossTableList)
					{
						ribbonMenu.MouseEnter += this.o0.0_0OO_Oo__.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.SubtotalModeList)
					{
						ribbonMenu.MouseEnter += this.o__O.OoO.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.ExcelReportList)
					{
						ribbonMenu.MouseEnter += this.OO.oOo0_0O.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.WordReportList)
					{
						ribbonMenu.MouseEnter += this.OOOOoO.0_0_.;
					}
					else if (ribbonItemTypeEnum == RibbonItemTypeEnum.CodeReportList)
					{
						ribbonMenu.MouseEnter += this.ooO00O0_0.OO_.;
					}
					break;
				}
				case RibbonItemTypeEnum.ToggleGroup:
				{
					RibbonToggleGroup ribbonToggleGroup = new RibbonToggleGroup();
					RibbonToggleGroup a_ = new RibbonToggleGroup(dataRow);
					this.o0O0.Oo0_OOO0.(a_, ribbonToggleGroup);
					ribbonItem = ribbonToggleGroup;
					this.o0O0.Oo0_OOO0.(ribbonToggleGroup.Items, dataRow, RibbonPaneEnum.Left);
					ribbonToggleGroup.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.ToolBar:
				{
					RibbonToolBar ribbonToolBar = new RibbonToolBar();
					RibbonToolBar a_2 = new RibbonToolBar(dataRow);
					this.o0O0.Oo0_OOO0.(a_2, ribbonToolBar);
					ribbonItem = ribbonToolBar;
					this.o0O0.Oo0_OOO0.(ribbonToolBar.Items, dataRow, RibbonPaneEnum.Left);
					ribbonToolBar.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.Button:
				{
					RibbonButton ribbonButton = new RibbonButton();
					RibbonButton a_3 = new RibbonButton(dataRow);
					this.Oo.oO_ooo_o0.(a_3, ribbonButton);
					ribbonItem = ribbonButton;
					ribbonButton.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.CheckBox:
				{
					RibbonCheckBox ribbonCheckBox = new RibbonCheckBox();
					RibbonCheckBox a_4 = new RibbonCheckBox(dataRow);
					this.o0O0.Oo0_OOO0.(a_4, ribbonCheckBox);
					ribbonItem = ribbonCheckBox;
					ribbonCheckBox.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.ColorPicker:
				{
					RibbonColorPicker ribbonColorPicker = new RibbonColorPicker();
					RibbonColorPicker a_5 = new RibbonColorPicker(dataRow);
					this.o0O0.Oo0_OOO0.(a_5, ribbonColorPicker);
					ribbonItem = ribbonColorPicker;
					A_0.Add(ribbonColorPicker);
					ribbonColorPicker.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.ComboBox:
				{
					RibbonComboBox ribbonComboBox = new RibbonComboBox();
					RibbonComboBox a_6 = new RibbonComboBox(dataRow);
					this.o0O0.Oo0_OOO0.(a_6, ribbonComboBox);
					ribbonItem = ribbonComboBox;
					this.o0O0.Oo0_OOO0.(ribbonComboBox.Items, dataRow, RibbonPaneEnum.Left);
					this.o0O0.Oo0_OOO0.(ribbonComboBox.MenuItems, dataRow, RibbonPaneEnum.Right);
					ribbonComboBox.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.TextBox:
				{
					RibbonTextBox ribbonTextBox = new RibbonTextBox();
					RibbonTextBox a_7 = new RibbonTextBox(dataRow);
					this.OO__o0O0.0.(a_7, ribbonTextBox);
					ribbonItem = ribbonTextBox;
					ribbonTextBox.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.FontComboBox:
				{
					RibbonFontComboBox ribbonFontComboBox = new RibbonFontComboBox();
					RibbonFontComboBox a_8 = new RibbonFontComboBox(dataRow);
					this.o0O0.Oo0_OOO0.(a_8, ribbonFontComboBox);
					ribbonItem = ribbonFontComboBox;
					this.o0O0.Oo0_OOO0.(ribbonFontComboBox.MenuItems, dataRow, RibbonPaneEnum.Right);
					ribbonFontComboBox.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.Label:
				{
					RibbonLabel ribbonLabel = new RibbonLabel();
					RibbonLabel a_9 = new RibbonLabel(dataRow);
					this.OO__o0O0.0.(a_9, ribbonLabel);
					ribbonItem = ribbonLabel;
					ribbonLabel.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.MenuButton:
				{
					RibbonMenu ribbonMenu2 = new RibbonMenu();
					RibbonMenuButton a_10 = new RibbonMenuButton(dataRow);
					this.OO__o0O0.0.(a_10, ribbonMenu2);
					ribbonItem = ribbonMenu2;
					this.o0O0.Oo0_OOO0.(ribbonMenu2.Items, dataRow, RibbonPaneEnum.Left);
					ribbonMenu2.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.Separator:
				{
					RibbonSeparator ribbonSeparator = new RibbonSeparator();
					RibbonSeparator a_11 = new RibbonSeparator(dataRow);
					this.o0O0.Oo0_OOO0.(a_11, ribbonSeparator);
					ribbonItem = ribbonSeparator;
					ribbonSeparator.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.SplitButton:
				{
					RibbonSplitButton ribbonSplitButton = new RibbonSplitButton();
					RibbonSplitButton a_12 = new RibbonSplitButton(dataRow);
					this.OO__o0O0.0.(a_12, ribbonSplitButton);
					ribbonItem = ribbonSplitButton;
					this.o0O0.Oo0_OOO0.(ribbonSplitButton.Items, dataRow, RibbonPaneEnum.Left);
					ribbonSplitButton.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.ToggleButton:
				{
					RibbonToggleButton ribbonToggleButton3 = new RibbonToggleButton();
					RibbonToggleButton a_13 = new RibbonToggleButton(dataRow);
					this.OO__o0O0.0.(a_13, ribbonToggleButton3);
					ribbonItem = ribbonToggleButton3;
					ribbonToggleButton3.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.DatePicker:
				{
					RibbonDatePicker ribbonDatePicker = new RibbonDatePicker();
					RibbonDatePicker a_14 = new RibbonDatePicker(dataRow);
					this.o0O0.Oo0_OOO0.(a_14, ribbonDatePicker);
					ribbonItem = ribbonDatePicker;
					ribbonDatePicker.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.NumericBox:
				{
					RibbonNumericBox ribbonNumericBox = new RibbonNumericBox();
					RibbonNumericBox a_15 = new RibbonNumericBox(dataRow);
					this.OO__o0O0.0.(a_15, ribbonNumericBox);
					ribbonItem = ribbonNumericBox;
					ribbonNumericBox.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.ProgressBar:
				{
					RibbonProgressBar ribbonProgressBar = new RibbonProgressBar();
					RibbonProgressBar a_16 = new RibbonProgressBar(dataRow);
					this.OO__o0O0.0.(a_16, ribbonProgressBar);
					ribbonItem = ribbonProgressBar;
					ribbonProgressBar.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.Gallery:
				{
					o_o_Oo0__o_0 o_o_Oo0__o_ = new o_o_Oo0__o_0();
					RibbonGallery a_17 = new RibbonGallery(dataRow);
					this.o0O0.Oo0_OOO0.(a_17, o_o_Oo0__o_);
					ribbonItem = o_o_Oo0__o_;
					A_0.Add(o_o_Oo0__o_);
					this.o0O0.Oo0_OOO0.(o_o_Oo0__o_.MenuItems, dataRow, RibbonPaneEnum.Left);
					this.o0O0.Oo0_OOO0.(o_o_Oo0__o_.Items, dataRow, RibbonPaneEnum.Right);
					if (!o_o_Oo0__o_.oOoO0ooo_0O._.())
					{
						try
						{
							foreach (object obj2 in o_o_Oo0__o_.Items)
							{
								((RibbonGalleryItem)obj2).VerticalLayout = false;
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
					o_o_Oo0__o_.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.GalleryItem:
				{
					RibbonGalleryItem ribbonGalleryItem = new RibbonGalleryItem();
					RibbonGalleryItem a_18 = new RibbonGalleryItem(dataRow);
					this.o0O0.Oo0_OOO0.(a_18, ribbonGalleryItem);
					ribbonItem = ribbonGalleryItem;
					A_0.Add(ribbonGalleryItem);
					ribbonGalleryItem.Tag = RuntimeHelpers.GetObjectValue(dataRow["key"]);
					break;
				}
				case RibbonItemTypeEnum.TimePicker:
				{
					RibbonTimePicker ribbonTimePicker = new RibbonTimePicker();
					RibbonTimePicker a_19 = new RibbonTimePicker(dataRow);
					this.OO__o0O0.0.(a_19, ribbonTimePicker);
					ribbonItem = ribbonTimePicker;
					ribbonTimePicker.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				case RibbonItemTypeEnum.TrackBar:
				{
					RibbonTrackBar ribbonTrackBar = new RibbonTrackBar();
					RibbonTrackBar a_20 = new RibbonTrackBar(dataRow);
					this.OO__o0O0.0.(a_20, ribbonTrackBar);
					ribbonItem = ribbonTrackBar;
					ribbonTrackBar.Tag = RuntimeHelpers.GetObjectValue(dataRow["Key"]);
					break;
				}
				}
				if (ribbonItem != null)
				{
					if (A_0 is RibbonGalleryItemCollection)
					{
						A_0.Add(ribbonItem);
					}
					else if (A_2 == RibbonPaneEnum.Right)
					{
						A_0.Add(new RibbonListItem
						{
							Items = 
							{
								ribbonItem
							}
						});
					}
					else
					{
						A_0.Add(ribbonItem);
					}
				}
			}
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00242B78 File Offset: 0x00240D78
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						return;
					}
				}
				catch (Exception ex)
				{
					return;
				}
				int rawKind = OO_00oOO.CurrentTable.PrintInfo.PaperSize.RawKind;
				RibbonMenu ribbonMenu = (RibbonMenu)A_0;
				try
				{
					foreach (object obj in ribbonMenu.Items)
					{
						RibbonToggleButton ribbonToggleButton = (RibbonToggleButton)obj;
						if (Conversions.ToInteger(ribbonToggleButton.Tag) == rawKind)
						{
							ribbonToggleButton.Pressed = true;
						}
						else
						{
							ribbonToggleButton.Pressed = false;
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

		// Token: 0x06005134 RID: 20788 RVA: 0x00242C48 File Offset: 0x00240E48
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				RibbonToggleButton ribbonToggleButton = (RibbonToggleButton)A_0;
				PrinterSettings printerSettings = new PrinterSettings();
				try
				{
					foreach (object obj in printerSettings.PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						if (Operators.CompareString(paperSize.PaperName, ribbonToggleButton.Text, true) == 0)
						{
							OO_00oOO.CurrentTable.PrintInfo.PaperSize.RawKind = paperSize.RawKind;
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

		// Token: 0x06005135 RID: 20789 RVA: 0x00242CE4 File Offset: 0x00240EE4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
				catch (Exception ex)
				{
					return;
				}
				OO_00oOO.CurrentTable.PrintInfo.PaperSize.RawKind = 0;
			}
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x00242D50 File Offset: 0x00240F50
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonMenu ribbonMenu = (RibbonMenu)A_0;
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			ribbonMenu.Items.Clear();
			if (OO_00oOO.CurrentTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(0)))
				{
					RibbonButton ribbonButton = new RibbonButton();
					ribbonButton.Text = dataRow["Name"].ToString();
					ribbonButton.Click += this.o_O_oO_o.0O__.;
					ribbonMenu.Items.Add(ribbonButton);
				}
			}
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x00242E0C File Offset: 0x0024100C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = ((RibbonButton)A_0).Text;
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
			{
				OO_00oOO.CurrentTable.DataTable.Name,
				text,
				ExtendTablePropertyTypeEnum.View
			});
			if (dataRow != null)
			{
				try
				{
					OO_00oOO.LockBaseMainForm();
					OO_00oOO.CurrentTable.StopRedraw();
					TableViewProperty tableViewProperty = new TableViewProperty(OO_00oOO.CurrentTable);
					o_O_o_oOoo__.OOOO_OO._oo.(tableViewProperty, Conversions.ToString(dataRow["Property"]), '\v');
					tableViewProperty.Restore();
				}
				catch (Exception ex)
				{
				}
				finally
				{
					OO_00oOO.CurrentTable.ResumeRedraw();
					OO_00oOO.UnlockBaseMainForm();
				}
			}
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x00242EE0 File Offset: 0x002410E0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonMenu ribbonMenu = (RibbonMenu)A_0;
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			ribbonMenu.Items.Clear();
			if (OO_00oOO.CurrentTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(1)))
				{
					RibbonButton ribbonButton = new RibbonButton();
					ribbonButton.Text = dataRow["Name"].ToString();
					ribbonButton.Click += this.o00___.0_.;
					ribbonMenu.Items.Add(ribbonButton);
				}
			}
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x00242F9C File Offset: 0x0024119C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = ((RibbonButton)A_0).Text;
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
			{
				OO_00oOO.CurrentTable.DataTable.Name,
				text,
				ExtendTablePropertyTypeEnum.GroupTable
			});
			if (dataRow != null)
			{
				GroupTableBuilder groupTableBuilder = new GroupTableBuilder();
				GroupTableProperty groupTableProperty = new GroupTableProperty(groupTableBuilder);
				o_O_o_oOoo__.OOOO_OO._oo.(groupTableProperty, Conversions.ToString(dataRow["Property"]), '\v');
				groupTableProperty.Restore();
				groupTableBuilder.SourceDataTable = OO_00oOO.CurrentTable.DataTable;
				OO_00oOO.CurrentTable.O_0._O_0OO000O. = groupTableBuilder;
				Foxtable.Syscmd.Table.RebuildGroupTable();
			}
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x00243048 File Offset: 0x00241248
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonMenu ribbonMenu = (RibbonMenu)A_0;
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			ribbonMenu.Items.Clear();
			if (OO_00oOO.CurrentTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(2)))
				{
					RibbonButton ribbonButton = new RibbonButton();
					ribbonButton.Text = dataRow["Name"].ToString();
					ribbonButton.Click += this.oo._oO0_o.;
					ribbonMenu.Items.Add(ribbonButton);
				}
			}
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00243104 File Offset: 0x00241304
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = ((RibbonButton)A_0).Text;
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
			{
				OO_00oOO.CurrentTable.DataTable.Name,
				text,
				ExtendTablePropertyTypeEnum.CrossTable
			});
			if (dataRow != null)
			{
				CrossTableBuilder crossTableBuilder = new CrossTableBuilder();
				CrossTableProperty crossTableProperty = new CrossTableProperty(crossTableBuilder);
				o_O_o_oOoo__.OOOO_OO._oo.(crossTableProperty, Conversions.ToString(dataRow["Property"]), '\v');
				crossTableProperty.o___0o.0OOOooO.();
				crossTableBuilder.SourceDataTable = OO_00oOO.CurrentTable.DataTable;
				OO_00oOO.CurrentTable.O_0._O_0OO000O. = crossTableBuilder;
				Foxtable.Syscmd.Table.RebuildCrossTable();
			}
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x002431B0 File Offset: 0x002413B0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonMenu ribbonMenu = (RibbonMenu)A_0;
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			ribbonMenu.Items.Clear();
			if (OO_00oOO.CurrentTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(3)))
				{
					RibbonButton ribbonButton = new RibbonButton();
					ribbonButton.Text = dataRow["Name"].ToString();
					ribbonButton.Click += this.oo0o00O__.0o0.;
					ribbonMenu.Items.Add(ribbonButton);
				}
			}
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x0024326C File Offset: 0x0024146C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = ((RibbonButton)A_0).Text;
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
			{
				OO_00oOO.CurrentTable.DataTable.Name,
				text,
				ExtendTablePropertyTypeEnum.SubtotalMode
			});
			if (dataRow != null)
			{
				OO_00oOO.CurrentTable.ClearEditInfos();
				SubtotalModeProperty subtotalModeProperty = new SubtotalModeProperty(OO_00oOO.CurrentTable.SubtotalGroups, false, true, true);
				o_O_o_oOoo__.OOOO_OO._oo.(subtotalModeProperty, Conversions.ToString(dataRow["Property"]), '\v');
				subtotalModeProperty.Restore();
				if (OO_00oOO.CurrentTable.IsSubtotal)
				{
					OO_00oOO.CurrentTable.ClearSubtotal();
				}
				OO_00oOO.CurrentTable.GroupAboveData = subtotalModeProperty.GroupAboveData;
				OO_00oOO.CurrentTable.TreeVisible = subtotalModeProperty.TreeVisible;
				OO_00oOO.CurrentTable.SpillNode = subtotalModeProperty.SpillNode;
				OO_00oOO.CurrentTable.Subtotal(false);
			}
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x0024335C File Offset: 0x0024155C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonMenu ribbonMenu = (RibbonMenu)A_0;
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			ribbonMenu.Items.Clear();
			if (OO_00oOO.CurrentTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(5)))
				{
					RibbonButton ribbonButton = new RibbonButton();
					ribbonButton.Text = dataRow["Name"].ToString();
					ribbonButton.Click += this.o_o__OOo.O.;
					ribbonMenu.Items.Add(ribbonButton);
				}
			}
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00243418 File Offset: 0x00241618
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonMenu ribbonMenu = (RibbonMenu)A_0;
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			ribbonMenu.Items.Clear();
			if (OO_00oOO.CurrentTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(9)))
				{
					RibbonButton ribbonButton = new RibbonButton();
					ribbonButton.Text = dataRow["Name"].ToString();
					ribbonButton.Click += this.oo0_O0_.o0Oo.;
					ribbonMenu.Items.Add(ribbonButton);
				}
			}
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x002434D4 File Offset: 0x002416D4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonMenu ribbonMenu = (RibbonMenu)A_0;
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			ribbonMenu.Items.Clear();
			if (OO_00oOO.CurrentTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(6)))
				{
					RibbonButton ribbonButton = new RibbonButton();
					ribbonButton.Text = dataRow["Name"].ToString();
					ribbonButton.Click += this.o00.__0O_o_O.;
					ribbonMenu.Items.Add(ribbonButton);
				}
			}
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x00243590 File Offset: 0x00241790
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.CurrentTable.Current != null)
			{
				RibbonButton ribbonButton = (RibbonButton)A_0;
				XLSFunctions.Reports[ribbonButton.Text].Build();
			}
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x002435C8 File Offset: 0x002417C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.CurrentTable.Current != null)
			{
				RibbonButton ribbonButton = (RibbonButton)A_0;
				WordFunctions.Reports[ribbonButton.Text].Build();
			}
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x00243600 File Offset: 0x00241800
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			RibbonButton ribbonButton = (RibbonButton)A_0;
			OO_00oOO.Reports[ribbonButton.Text].Execute();
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x0024362C File Offset: 0x0024182C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.MainTable != null)
			{
				RibbonButton ribbonButton = (RibbonButton)A_0;
				string left = ribbonButton.Tag.ToString();
				if (Operators.CompareString(left, "Column", true) == 0)
				{
					if (OO_00oOO.CurrentTable.Cols.Contains(ribbonButton.Text))
					{
						OO_00oOO.CurrentTable.Cols[ribbonButton.Text].OpenWindow(0);
						System.Windows.Forms.Control o_o_O.0000_O. = OO_00oOO.CurrentTable.Cols[ribbonButton.Text].o_o_O.0000_O.;
						if (o_o_O.0000_O. != null)
						{
							ooO.OO_oOO0O.O00.(o_o_O.0000_O.);
						}
					}
				}
				else if (Operators.CompareString(left, "Relation", true) == 0)
				{
					if (OO_00oOO.Tables.get_Contains(ribbonButton.Text))
					{
						Foxtable.Table table = OO_00oOO.Tables[ribbonButton.Text];
						if (table.foxGrid.FindForm() == null)
						{
							o_O0_0O0 o_O0_0O;
							switch (table._frdDockArea)
							{
							case DockAreaEnum.右:
								o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[OO_00oOO.MainTable.Name]).o__0_.o0OoOOO.();
								goto IL_1A8;
							case DockAreaEnum.左:
								o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[OO_00oOO.MainTable.Name]).O__O.o_oOO.();
								goto IL_1A8;
							case DockAreaEnum.上:
								o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[OO_00oOO.MainTable.Name]).O_000__.o.();
								goto IL_1A8;
							}
							o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[OO_00oOO.MainTable.Name]).O._o_00__.();
							IL_1A8:
							o_O0_0O.OO_o0_oO.0.(table, table._frdDockTitle);
							ooO.OO_oOO0O.O00.(table.foxGrid);
						}
					}
				}
				else if (Operators.CompareString(left, "Form", true) == 0)
				{
					OO_00oOO.Forms[ribbonButton.Text].Show(int.MaxValue, int.MaxValue);
				}
			}
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x0024382C File Offset: 0x00241A2C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.SystemReady)
			{
				RibbonMenu ribbonMenu = (RibbonMenu)A_0;
				RibbonMenu ribbonMenu2 = new RibbonMenu();
				RibbonMenu ribbonMenu3 = new RibbonMenu();
				RibbonMenu ribbonMenu4 = new RibbonMenu();
				int maxDropDownItems = (int)Math.Floor((double)SysInfo.ScreenHeight / 768.0 * 22.0);
				ribbonMenu2.MaxDropDownItems = maxDropDownItems;
				ribbonMenu3.MaxDropDownItems = maxDropDownItems;
				ribbonMenu4.MaxDropDownItems = maxDropDownItems;
				if (!ribbonMenu.DroppedDown)
				{
					ribbonMenu.Items.Clear();
					if (OO_00oOO.MainTable != null)
					{
						ribbonMenu4.Text = "工作窗口";
						ribbonMenu2.Text = "关联表";
						ribbonMenu3.Text = "列窗口";
						try
						{
							foreach (Foxtable.Table table in OO_00oOO.Tables)
							{
								if (table.Name.StartsWith(OO_00oOO.MainTable.Name + ".") && Operators.CompareString(table.Name, OO_00oOO.MainTable.Name, true) != 0)
								{
									RibbonToggleButton ribbonToggleButton = new RibbonToggleButton();
									ribbonToggleButton.Text = table.Name;
									ribbonToggleButton.Tag = "Relation";
									if (table.foxGrid.FindForm() != null)
									{
										ribbonToggleButton.Pressed = true;
									}
									ribbonToggleButton.Click += this.o_O.0_oO0o0o.;
									ribbonMenu2.Items.Add(ribbonToggleButton);
								}
							}
						}
						finally
						{
							IEnumerator<Foxtable.Table> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						try
						{
							foreach (Col col in OO_00oOO.CurrentTable.Cols)
							{
								if (col.oo_0_oO._.())
								{
									RibbonToggleButton ribbonToggleButton2 = new RibbonToggleButton();
									ribbonToggleButton2.Text = col.Name;
									ribbonToggleButton2.Tag = "Column";
									if (col.o_o_O.0000_O. != null && col.o_o_O.0000_O..FindForm() != null)
									{
										ribbonToggleButton2.Pressed = true;
									}
									ribbonToggleButton2.Click += this.o_O.0_oO0o0o.;
									ribbonMenu3.Items.Add(ribbonToggleButton2);
								}
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
						try
						{
							foreach (Foxtable.WinForm.Form form in OO_00oOO.Forms)
							{
								if (Conversions.ToInteger(form.O_o_.0o0__o0O.["Type"]) != 233 && (Operators.CompareString(form.TableName, OO_00oOO.MainTable.Name, true) == 0 || Operators.CompareString(form.TableName, "", true) == 0))
								{
									RibbonToggleButton ribbonToggleButton3 = new RibbonToggleButton();
									ribbonToggleButton3.Text = form.Name;
									ribbonToggleButton3.Tag = "Form";
									if (form.Opened)
									{
										ribbonToggleButton3.Pressed = true;
									}
									ribbonToggleButton3.Click += this.o_O.0_oO0o0o.;
									ribbonMenu4.Items.Add(ribbonToggleButton3);
								}
							}
						}
						finally
						{
							IEnumerator<Foxtable.WinForm.Form> enumerator3;
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
						ribbonMenu.Items.Add(ribbonMenu2);
						ribbonMenu.Items.Add(ribbonMenu3);
						ribbonMenu.Items.Add(ribbonMenu4);
						ribbonMenu.Items.Add(new RibbonSeparator());
						RibbonButton ribbonButton = new RibbonButton();
						ribbonButton.SmallImage = ribbonMenu.Ribbon.ApplicationMenu.LargeImage;
						ribbonButton.Text = "显示主表";
						ribbonButton.Click += this.OO.0OO0oo0O_O.;
						ribbonMenu.Items.Add(ribbonButton);
					}
				}
			}
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x00243BBC File Offset: 0x00241DBC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.MainTable.Show();
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x00243BC8 File Offset: 0x00241DC8
		private void <<EMPTY_NAME>>(Foxtable.RibbonItem A_0, C1.Win.C1Ribbon.RibbonItem A_1)
		{
			A_1.ID = A_0.Name;
			A_1.Enabled = A_0.Enabled;
			A_1.Visible = A_0.Visible;
			A_1.ToolTip = A_0.ToolTip;
			if (A_0.ForeColor != Color.Transparent)
			{
				A_1.ForeColorInner = A_0.ForeColor;
				A_1.ForeColorOuter = A_0.ForeColor;
			}
			if (!A_0.AutoHideText)
			{
				A_1.SupportedGroupSizing = SupportedGroupSizing.TextAlwaysVisible;
			}
			if (Operators.CompareString(A_0.LargeImage, "", true) > 0)
			{
				A_1.LargeImage = OO_00oOO.GetImage(A_0.LargeImage);
			}
			if (Operators.CompareString(A_0.SmallImage, "", true) > 0)
			{
				A_1.SmallImage = OO_00oOO.GetImage(A_0.SmallImage);
			}
			if (A_0.TextImageRelation == TextImageRelationEnum.Automatic)
			{
				A_1.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.Automatic;
				return;
			}
			if (A_0.TextImageRelation == TextImageRelationEnum.ImageAboveText)
			{
				A_1.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText;
				return;
			}
			A_1.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageBeforeText;
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x00243CB0 File Offset: 0x00241EB0
		private void <<EMPTY_NAME>>(RibbonButton A_0, RibbonButton A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			if (A_1.LargeImage != null && Operators.CompareString(A_0.Text, "", true) > 0 && A_0.Text.IndexOf(' ') < 0)
			{
				A_1.Text = A_0.Text + " ";
			}
			else
			{
				A_1.Text = A_0.Text;
			}
			if (Operators.CompareString(A_1.ToolTip, "", true) == 0)
			{
				A_1.ToolTip = A_1.Text;
			}
			if (A_0.ShortcutKeys != Keys.None)
			{
				A_1.ShortcutKeys = A_0.ShortcutKeys;
			}
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00243D48 File Offset: 0x00241F48
		private void <<EMPTY_NAME>>(RibbonSplitButton A_0, RibbonSplitButton A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			if (A_1.LargeImage != null && Operators.CompareString(A_0.Text, "", true) > 0 && A_0.Text.IndexOf(' ') < 0)
			{
				A_1.Text = A_0.Text + " ";
			}
			else
			{
				A_1.Text = A_0.Text;
			}
			if (Operators.CompareString(A_1.ToolTip, "", true) == 0)
			{
				A_1.ToolTip = A_1.Text;
			}
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00243DCC File Offset: 0x00241FCC
		private void <<EMPTY_NAME>>(RibbonMenuButton A_0, RibbonMenu A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			if (A_1.LargeImage != null && Operators.CompareString(A_0.Text, "", true) > 0 && A_0.Text.IndexOf(' ') < 0)
			{
				A_1.Text = A_0.Text + " ";
			}
			else
			{
				A_1.Text = A_0.Text;
			}
			A_1.ArrowVisible = A_0.ArrowVisible;
			if (Operators.CompareString(A_1.ToolTip, "", true) == 0)
			{
				A_1.ToolTip = A_1.Text;
			}
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00243E5C File Offset: 0x0024205C
		private void <<EMPTY_NAME>>(RibbonGallery A_0, o_o_Oo0__o_0 A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Text = A_0.Text;
			A_1.Expanded = A_0.Expand;
			A_1.VisibleItems = A_0.VisibleItems;
			A_1.oOoO0ooo_0O._.(A_0.CommandMode);
			A_1.o.o_.(A_0.VerticalLayout);
			A_1.ItemSize = new Size(A_0.ItemWidth, A_0.ItemHeight);
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00243EC4 File Offset: 0x002420C4
		private void <<EMPTY_NAME>>(RibbonGalleryItem A_0, RibbonGalleryItem A_1)
		{
			A_1.ID = A_0.Name;
			A_1.Enabled = A_0.Enabled;
			A_1.Visible = A_0.Visible;
			A_1.ToolTip = A_0.ToolTip;
			A_1.Text = A_0.Text;
			if (Operators.CompareString(A_0.Image, "", true) > 0)
			{
				A_1.LargeImage = OO_00oOO.GetImage(A_0.Image);
			}
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00243F32 File Offset: 0x00242132
		private void <<EMPTY_NAME>>(RibbonLabel A_0, RibbonLabel A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Text = A_0.Text;
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00243F48 File Offset: 0x00242148
		private void <<EMPTY_NAME>>(RibbonCheckBox A_0, RibbonCheckBox A_1)
		{
			this.Oo.oO_ooo_o0.(A_0, A_1);
			A_1.Checked = A_0.Checked;
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00243F5E File Offset: 0x0024215E
		private void <<EMPTY_NAME>>(RibbonToggleButton A_0, RibbonToggleButton A_1)
		{
			this.Oo.oO_ooo_o0.(A_0, A_1);
			A_1.Pressed = A_0.Pressed;
			A_1.ToggleGroupName = A_0.GroupName;
			A_1.CanDepress = (Operators.CompareString(A_1.ToggleGroupName, "", true) == 0);
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00243F9A File Offset: 0x0024219A
		private void <<EMPTY_NAME>>(RibbonTextBox A_0, RibbonTextBox A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Label = A_0.Label;
			A_1.MaxLength = A_0.MaxLength;
			A_1.Text = A_0.Text;
			A_1.TextAreaWidth = Math.Max(A_0.TextAreaWidth, 1);
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x00243FDA File Offset: 0x002421DA
		private void <<EMPTY_NAME>>(RibbonDatePicker A_0, RibbonDatePicker A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.StandardFormat = RibbonDateFormat.Custom;
			A_1.Format = "yyyy-MM-dd";
			A_1.Label = A_0.Label;
			A_1.TextAreaWidth = Math.Max(A_0.TextAreaWidth, 1);
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x00244014 File Offset: 0x00242214
		private void <<EMPTY_NAME>>(RibbonTimePicker A_0, RibbonTimePicker A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			if (A_0.LongTimeFormat)
			{
				A_1.StandardFormat = RibbonTimeFormat.LongTime;
			}
			else
			{
				A_1.StandardFormat = RibbonTimeFormat.ShortTime;
			}
			A_1.Label = A_0.Label;
			A_1.TextAreaWidth = A_0.TextAreaWidth;
			A_1.Value = A_0.Value;
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00244068 File Offset: 0x00242268
		private void <<EMPTY_NAME>>(RibbonTrackBar A_0, RibbonTrackBar A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Minimum = A_0.Minimum;
			A_1.Maximum = A_0.Maximum;
			A_1.Value = A_0.Value;
			A_1.TickFrequency = A_0.TickFrequency;
			A_1.StepFrequency = A_0.StepFrequency;
			A_1.Width = A_0.Width;
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x002440C8 File Offset: 0x002422C8
		private void <<EMPTY_NAME>>(RibbonNumericBox A_0, RibbonNumericBox A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Label = A_0.Label;
			A_1.Increment = A_0.Increment;
			A_1.Maximum = A_0.Maximum;
			A_1.Minimum = A_0.Minimum;
			if (Operators.CompareString(A_0.Value, "", true) > 0)
			{
				decimal num;
				decimal.TryParse(A_0.Value, out num);
				num = Math.Max(num, A_0.Minimum);
				num = Math.Min(num, A_0.Maximum);
				A_1.Value = num;
			}
			A_1.TextAreaWidth = Math.Max(A_0.TextAreaWidth, 1);
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00244164 File Offset: 0x00242364
		private void <<EMPTY_NAME>>(RibbonProgressBar A_0, RibbonProgressBar A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Value = A_0.Value;
			A_1.Maximum = A_0.Maximum;
			A_1.Minimum = A_0.Minimum;
			A_1.Width = A_0.Width;
			A_1.Height = A_0.Height;
			A_1.Width = Math.Max(A_0.Width, 1);
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x002441C8 File Offset: 0x002423C8
		private void <<EMPTY_NAME>>(RibbonComboBox A_0, RibbonComboBox A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Label = A_0.Label;
			A_1.MaxDropDownItems = A_0.MaxDropDownItems;
			A_1.MaxLength = A_0.MaxLength;
			A_1.Text = A_0.Text;
			A_1.TextAreaWidth = A_0.TextAreaWidth;
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00244219 File Offset: 0x00242419
		private void <<EMPTY_NAME>>(RibbonFontComboBox A_0, RibbonComboBox A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.Label = A_0.Label;
			A_1.MaxDropDownItems = A_0.MaxDropDownItems;
			A_1.Text = A_0.Text;
			A_1.TextAreaWidth = A_0.TextAreaWidth;
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00244253 File Offset: 0x00242453
		private void <<EMPTY_NAME>>(RibbonColorPicker A_0, RibbonColorPicker A_1)
		{
			A_1.Text = A_0.Text;
			A_1.Color = A_0.Color;
			this.o0O0.Oo0_OOO0.(A_0, A_1);
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00244275 File Offset: 0x00242475
		private void <<EMPTY_NAME>>(RibbonItemContainer A_0, RibbonItemContainer A_1)
		{
			A_1.ID = A_0.Name;
			A_1.Enabled = A_0.Enabled;
			A_1.Visible = A_0.Visible;
			A_1.ToolTip = A_0.ToolTip;
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x002442A7 File Offset: 0x002424A7
		private void <<EMPTY_NAME>>(RibbonToggleGroup A_0, RibbonToggleGroup A_1)
		{
			this.o0O0.Oo0_OOO0.(A_0, A_1);
			A_1.AllowAllButtonsUp = A_0.AllowAllButtonsUp;
		}

		// Token: 0x0400216D RID: 8557
		private C1CommandHolder <<EMPTY_NAME>>;

		// Token: 0x0400216E RID: 8558
		private string <<EMPTY_NAME>>;

		// Token: 0x0400216F RID: 8559
		private string <<EMPTY_NAME>>;
	}
}

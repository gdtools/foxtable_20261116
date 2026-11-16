using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000369 RID: 873
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3002\u3002\u3002\u3000\u3002 : Form
	{
		// Token: 0x060036E6 RID: 14054 RVA: 0x0017FF7C File Offset: 0x0017E17C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo_.o. != null)
				{
					this.Oo_.o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x0017FFBC File Offset: 0x0017E1BC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_o0.000O00o0.(new Label());
			this.o__O__ooO._o.(new C1TextBox());
			this.o__ooOO0O__0.O.(new Label());
			this.o__O__ooO._o.(new C1ComboBox());
			this.o__O__ooO._o.(new C1Button());
			this.o__ooOO0O__0.O.(new C1Button());
			this.o__O__ooO._o.(new Label());
			this.o__O__ooO._o.(new C1FlexGrid());
			((ISupportInitialize)this.O.O0OOoOO.()).BeginInit();
			base.SuspendLayout();
			this.o__o.O.().AutoSize = true;
			this.o__o.O.().BackColor = Color.Transparent;
			this.o__o.O.().Location = new Point(13, 11);
			this.o__o.O.().Name = "Label1";
			this.o__o.O.().Size = new Size(47, 12);
			this.o__o.O.().TabIndex = 0;
			this.o__o.O.().Text = "用户名:";
			this.O.O0OOoOO.().Location = new Point(13, 76);
			this.O.O0OOoOO.().Name = "txtPassWord";
			this.O.O0OOoOO.().PasswordChar = '*';
			this.O.O0OOoOO.().Size = new Size(241, 21);
			this.O.O0OOoOO.().TabIndex = 1;
			this.OO.OOoo_o.().AutoSize = true;
			this.OO.OOoo_o.().BackColor = Color.Transparent;
			this.OO.OOoo_o.().Location = new Point(13, 57);
			this.OO.OOoo_o.().Name = "Label2";
			this.OO.OOoo_o.().Size = new Size(35, 12);
			this.OO.OOoo_o.().TabIndex = 2;
			this.OO.OOoo_o.().Text = "密码:";
			this.O.O0OOoOO.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.O.O0OOoOO.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.O.O0OOoOO.().Location = new Point(13, 30);
			this.O.O0OOoOO.().Name = "lstUsers";
			this.O.O0OOoOO.().Size = new Size(241, 20);
			this.O.O0OOoOO.().TabIndex = 0;
			this.O.O0OOoOO.().ImageAlign = ContentAlignment.MiddleLeft;
			this.O.O0OOoOO.().Location = new Point(56, 231);
			this.O.O0OOoOO.().Name = "btnOK";
			this.O.O0OOoOO.().Size = new Size(75, 23);
			this.O.O0OOoOO.().TabIndex = 3;
			this.O.O0OOoOO.().Text = "确定";
			this.O.O0OOoOO.().UseVisualStyleBackColor = true;
			this.o__o.O.().DialogResult = DialogResult.Cancel;
			this.o__o.O.().ImageAlign = ContentAlignment.MiddleLeft;
			this.o__o.O.().Location = new Point(137, 231);
			this.o__o.O.().Name = "btnCancel";
			this.o__o.O.().Size = new Size(75, 23);
			this.o__o.O.().TabIndex = 4;
			this.o__o.O.().Text = "取消";
			this.o__o.O.().UseVisualStyleBackColor = true;
			this.O.O0OOoOO.().AutoSize = true;
			this.O.O0OOoOO.().BackColor = Color.Transparent;
			this.O.O0OOoOO.().Location = new Point(13, 104);
			this.O.O0OOoOO.().Name = "logtip";
			this.O.O0OOoOO.().Size = new Size(0, 12);
			this.O.O0OOoOO.().TabIndex = 2;
			this.O.O0OOoOO.().AllowSorting = AllowSortingEnum.None;
			this.O.O0OOoOO.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.O.O0OOoOO.().ColumnInfo = "2,0,0,40,0,0,Columns:0{Width:75;Caption:\"属性\";Style:\"TextAlign:LeftCenter;\";StyleFixed:\"TextAlign:CenterCenter;\";}\t1{Caption:\"值\";Style:\"TextAlign:LeftCenter;\";StyleFixed:\"TextAlign:CenterCenter;\";}\t";
			this.O.O0OOoOO.().ExtendLastCol = true;
			this.O.O0OOoOO.().Location = new Point(15, 130);
			this.O.O0OOoOO.().Name = "C1FlexGrid1";
			this.O.O0OOoOO.().Rows.Count = 1;
			this.O.O0OOoOO.().Rows.DefaultSize = 20;
			this.O.O0OOoOO.().Size = new Size(240, 93);
			this.O.O0OOoOO.().TabIndex = 5;
			this.O.O0OOoOO.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			base.AcceptButton = this.O.O0OOoOO.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.o__o.O.();
			base.ClientSize = new Size(269, 262);
			base.Controls.Add(this.O.O0OOoOO.());
			base.Controls.Add(this.O.O0OOoOO.());
			base.Controls.Add(this.o__o.O.());
			base.Controls.Add(this.O.O0OOoOO.());
			base.Controls.Add(this.O.O0OOoOO.());
			base.Controls.Add(this.OO.OOoo_o.());
			base.Controls.Add(this.O.O0OOoOO.());
			base.Controls.Add(this.o__o.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO......";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "用户登录";
			base.TopMost = true;
			((ISupportInitialize)this.O.O0OOoOO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x001804ED File Offset: 0x0017E6ED
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo_.o.;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x001804F5 File Offset: 0x0017E6F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo_.o. = A_0;
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x001804FE File Offset: 0x0017E6FE
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Oo_.o.;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00180506 File Offset: 0x0017E706
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.Oo_.o. = A_0;
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x0018050F File Offset: 0x0017E70F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.0___0_00oo0.;
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00180517 File Offset: 0x0017E717
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.0___0_00oo0. = A_0;
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00180520 File Offset: 0x0017E720
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo_.o.;
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00180528 File Offset: 0x0017E728
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.Oo_.o. = A_0;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00180531 File Offset: 0x0017E731
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_.o.;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x0018053C File Offset: 0x0017E73C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_0_0__.o_.);
			C1Button oo_.o. = this.Oo_.o.;
			if (oo_.o. != null)
			{
				oo_.o..Click -= value;
			}
			this.Oo_.o. = A_0;
			oo_.o. = this.Oo_.o.;
			if (oo_.o. != null)
			{
				oo_.o..Click += value;
			}
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0018057F File Offset: 0x0017E77F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o__ooOO0O__0.O.;
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00180587 File Offset: 0x0017E787
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o__ooOO0O__0.O. = A_0;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00180590 File Offset: 0x0017E790
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_OO0O.0.;
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00180598 File Offset: 0x0017E798
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_OO0O.0. = A_0;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x001805A1 File Offset: 0x0017E7A1
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Oo_.o.;
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x001805AC File Offset: 0x0017E7AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o_._o_0o0.);
			RangeEventHandler value2 = new RangeEventHandler(this.o_0_0__.o_.);
			OwnerDrawCellEventHandler value3 = new OwnerDrawCellEventHandler(this.o_0_0__.o_.);
			RowColEventHandler value4 = new RowColEventHandler(this.o_0_0__.o_.);
			C1FlexGrid oo_.o. = this.Oo_.o.;
			if (oo_.o. != null)
			{
				oo_.o..AfterEdit -= value;
				oo_.o..AfterSelChange -= value2;
				oo_.o..OwnerDrawCell -= value3;
				oo_.o..SetupEditor -= value4;
			}
			this.Oo_.o. = A_0;
			oo_.o. = this.Oo_.o.;
			if (oo_.o. != null)
			{
				oo_.o..AfterEdit += value;
				oo_.o..AfterSelChange += value2;
				oo_.o..OwnerDrawCell += value3;
				oo_.o..SetupEditor += value4;
			}
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x0018064C File Offset: 0x0017E84C
		private void <<EMPTY_NAME>>()
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
				base.Icon = a.OO.oO__O00.();
				IL_14:
				num2 = 3;
				this.O.O0OOoOO.().ItemsDataSource = new DataView(this.OooO.00o., "[Type] <= " + Conversions.ToString(4) + " And [Name] Is Not Null And [Type] Is Not Null", "[Type]", DataViewRowState.CurrentRows);
				IL_48:
				num2 = 4;
				this.O.O0OOoOO.().ItemsDisplayMember = "Name";
				IL_5A:
				num2 = 5;
				this.O.O0OOoOO.().ItemsValueMember = "Name";
				IL_6C:
				num2 = 6;
				this.OooO.00o..DefaultView.Sort = "[Type]";
				IL_83:
				num2 = 7;
				this.OooO.00o. = Main.OO_O.o.;
				IL_90:
				num2 = 8;
				Main.OO_O.o. = SplashFormStateEnum.Hide;
				IL_98:
				num2 = 9;
				DataRow dataRow = this.o.0___0_00oo0..Rows.Find(new object[]
				{
					"LastLogonUser",
					o0_O.ooO__0.oO_0_.
				});
				IL_C4:
				num2 = 10;
				if (dataRow == null)
				{
					goto IL_E8;
				}
				IL_CA:
				num2 = 11;
				this.O.O0OOoOO.().Value = dataRow["Config"].ToString();
				IL_E8:
				num2 = 12;
				if (!OO_00oOO.FileSys.FileExists(this.OooO.00o. + "\\logform.txt"))
				{
					goto IL_7C4;
				}
				IL_10A:
				num2 = 13;
				string text = OO_00oOO.FileSys.ReadAllText(this.OooO.00o. + "\\logform.txt", Encoding.Default);
				IL_12E:
				num2 = 14;
				string[] array = text.Replace("\r", "").Split(new char[]
				{
					'\n'
				});
				IL_154:
				num2 = 15;
				foreach (string text2 in array)
				{
					IL_16A:
					num2 = 16;
					string[] array3 = text2.Split(new char[]
					{
						'@'
					});
					IL_181:
					num2 = 17;
					if (array3.Length > 1)
					{
						IL_18E:
						num2 = 18;
						string left = array3[0];
						IL_197:
						num2 = 20;
						if (Operators.CompareString(left, "form", true) == 0)
						{
							IL_1A9:
							num2 = 21;
							if (array3.Length == 3)
							{
								IL_1B6:
								num2 = 22;
								int width;
								int height;
								if (int.TryParse(array3[1], out width) && int.TryParse(array3[2], out height))
								{
									IL_1D9:
									num2 = 23;
									base.Size = new Size(width, height);
								}
							}
						}
						else
						{
							IL_1F0:
							num2 = 25;
							if (Operators.CompareString(left, "Label1", true) == 0)
							{
								IL_202:
								num2 = 26;
								if (array3.Length == 4)
								{
									IL_20F:
									num2 = 27;
									int x;
									int y;
									if (int.TryParse(array3[2], out x) && int.TryParse(array3[3], out y))
									{
										IL_232:
										num2 = 28;
										this.o__o.O.().Location = new Point(x, y);
										IL_249:
										num2 = 29;
										this.o__o.O.().Text = array3[1];
									}
								}
							}
							else
							{
								IL_260:
								num2 = 31;
								if (Operators.CompareString(left, "Label2", true) == 0)
								{
									IL_272:
									num2 = 32;
									if (array3.Length == 4)
									{
										IL_27F:
										num2 = 33;
										int x2;
										int y2;
										if (int.TryParse(array3[2], out x2) && int.TryParse(array3[3], out y2))
										{
											IL_2A2:
											num2 = 34;
											this.OO.OOoo_o.().Location = new Point(x2, y2);
											IL_2B9:
											num2 = 35;
											this.OO.OOoo_o.().Text = array3[1];
										}
									}
								}
								else
								{
									IL_2D0:
									num2 = 37;
									if (Operators.CompareString(left, "Label3", true) == 0)
									{
										IL_2E5:
										num2 = 38;
										if (array3.Length == 4)
										{
											IL_2F2:
											num2 = 39;
											int x3;
											int y3;
											if (int.TryParse(array3[2], out x3) && int.TryParse(array3[3], out y3))
											{
												IL_315:
												num2 = 40;
												this.O.O0OOoOO.().Location = new Point(x3, y3);
												IL_32C:
												num2 = 41;
												if (Operators.CompareString(array3[1], "", true) > 0)
												{
													IL_344:
													num2 = 42;
													this.O.O0OOoOO.().Text = array3[1];
													IL_356:
													num2 = 43;
													this.O.O0OOoOO.().Tag = "has";
												}
											}
										}
									}
									else
									{
										IL_36E:
										num2 = 45;
										if (Operators.CompareString(left, "TextBox1", true) == 0)
										{
											IL_380:
											num2 = 46;
											if (array3.Length == 4)
											{
												IL_38D:
												num2 = 47;
												int x4;
												int y4;
												int width2;
												if (int.TryParse(array3[1], out x4) && int.TryParse(array3[2], out y4) && int.TryParse(array3[3], out width2))
												{
													IL_3C0:
													num2 = 48;
													this.O.O0OOoOO.().Location = new Point(x4, y4);
													IL_3D7:
													num2 = 49;
													this.O.O0OOoOO.().Width = width2;
												}
											}
										}
										else
										{
											IL_3EC:
											num2 = 51;
											if (Operators.CompareString(left, "TextBox2", true) == 0)
											{
												IL_3FE:
												num2 = 52;
												if (array3.Length == 4)
												{
													IL_40B:
													num2 = 53;
													int x5;
													int y5;
													int width3;
													if (int.TryParse(array3[1], out x5) && int.TryParse(array3[2], out y5) && int.TryParse(array3[3], out width3))
													{
														IL_43E:
														num2 = 54;
														this.O.O0OOoOO.().Location = new Point(x5, y5);
														IL_455:
														num2 = 55;
														this.O.O0OOoOO.().Width = width3;
													}
												}
											}
											else
											{
												IL_46A:
												num2 = 57;
												if (Operators.CompareString(left, "button1", true) == 0)
												{
													IL_47C:
													num2 = 58;
													if (array3.Length == 6)
													{
														IL_489:
														num2 = 59;
														int x6;
														int y6;
														int width4;
														int height2;
														if (int.TryParse(array3[2], out x6) && int.TryParse(array3[3], out y6) && int.TryParse(array3[4], out width4) && int.TryParse(array3[5], out height2))
														{
															IL_4CC:
															num2 = 60;
															this.O.O0OOoOO.().SetBounds(x6, y6, width4, height2);
															IL_4E2:
															num2 = 61;
															this.O.O0OOoOO.().Text = array3[1];
														}
													}
												}
												else
												{
													IL_4F9:
													num2 = 63;
													if (Operators.CompareString(left, "button2", true) == 0)
													{
														IL_50B:
														num2 = 64;
														if (array3.Length == 6)
														{
															IL_518:
															num2 = 65;
															int x7;
															int y7;
															int width5;
															int height3;
															if (int.TryParse(array3[2], out x7) && int.TryParse(array3[3], out y7) && int.TryParse(array3[4], out width5) && int.TryParse(array3[5], out height3))
															{
																IL_55B:
																num2 = 66;
																this.o__o.O.().SetBounds(x7, y7, width5, height3);
																IL_571:
																num2 = 67;
																this.o__o.O.().Text = array3[1];
															}
														}
													}
													else
													{
														IL_588:
														num2 = 69;
														if (Operators.CompareString(left, "FormBorder", true) == 0)
														{
															IL_59A:
															num2 = 70;
															if (array3.Length == 2 && Operators.CompareString(array3[1], "False", true) == 0)
															{
																IL_5BB:
																num2 = 71;
																base.FormBorderStyle = FormBorderStyle.None;
															}
														}
														else
														{
															IL_5CA:
															num2 = 73;
															if (Operators.CompareString(left, "grid", true) == 0)
															{
																IL_5DC:
																num2 = 74;
																if (array3.Length == 5)
																{
																	IL_5E9:
																	num2 = 75;
																	int x8;
																	int y8;
																	int width6;
																	int height4;
																	if (int.TryParse(array3[1], out x8) && int.TryParse(array3[2], out y8) && int.TryParse(array3[3], out width6) && int.TryParse(array3[4], out height4))
																	{
																		IL_62C:
																		num2 = 76;
																		this.O.O0OOoOO.().SetBounds(x8, y8, width6, height4);
																	}
																}
															}
															else
															{
																IL_647:
																num2 = 78;
																if (Operators.CompareString(left, "image1", true) == 0 || Operators.CompareString(left, "image2", true) == 0 || Operators.CompareString(left, "image3", true) == 0)
																{
																	IL_67A:
																	num2 = 79;
																	if (array3.Length == 2 && Operators.CompareString(array3[1], "", true) > 0)
																	{
																		IL_69C:
																		num2 = 80;
																		string text3 = this.OooO.00o. + "\\" + array3[1];
																		IL_6B5:
																		num2 = 81;
																		if (OO_00oOO.FileSys.FileExists(text3))
																		{
																			IL_6C9:
																			num2 = 82;
																			Image image = OO_00oOO.GetImage(text3);
																			IL_6D5:
																			num2 = 83;
																			if (image != null)
																			{
																				IL_6DF:
																				num2 = 84;
																				string left2 = array3[0];
																				IL_6E8:
																				num2 = 86;
																				if (Operators.CompareString(left2, "image1", true) == 0)
																				{
																					IL_6FA:
																					num2 = 87;
																					this.O.O0OOoOO.().Image = image;
																					IL_70A:
																					num2 = 88;
																					if (Operators.CompareString(this.O.O0OOoOO.().Text, "", true) == 0)
																					{
																						IL_728:
																						num2 = 89;
																						this.O.O0OOoOO.().ImageAlign = ContentAlignment.MiddleCenter;
																					}
																				}
																				else
																				{
																					IL_73A:
																					num2 = 91;
																					if (Operators.CompareString(left2, "image2", true) == 0)
																					{
																						IL_74C:
																						num2 = 92;
																						this.o__o.O.().Image = image;
																						IL_75C:
																						num2 = 93;
																						if (Operators.CompareString(this.o__o.O.().Text, "", true) == 0)
																						{
																							IL_777:
																							num2 = 94;
																							this.o__o.O.().ImageAlign = ContentAlignment.MiddleCenter;
																						}
																					}
																					else
																					{
																						IL_789:
																						num2 = 96;
																						if (Operators.CompareString(left2, "image3", true) == 0)
																						{
																							IL_79B:
																							num2 = 97;
																							this.BackgroundImage = image;
																							IL_7A6:
																							num2 = 98;
																							this.BackgroundImageLayout = ImageLayout.None;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					IL_7B0:
					num2 = 99;
				}
				IL_7C4:
				num2 = 100;
				base.CenterToScreen();
				IL_7CD:
				goto IL_9B3;
				IL_7D2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_974:
				goto IL_9A8;
				IL_976:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_986:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_976;
			}
			IL_9A8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9B3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00181030 File Offset: 0x0017F230
		public O\u3002\u3002\u3002\u3002\u3002\u3000\u3002(DataTable A_0, DataTable A_1, string A_2, bool A_3)
		{
			base.FormClosed += this.o_0_0__.o_.;
			int num2;
			int num5;
			object obj2;
			try
			{
				IL_18:
				int num = 1;
				this.OO.OOoo_o.();
				IL_20:
				num = 2;
				if (OO_00oOO.ProjectFile != null)
				{
					goto IL_42;
				}
				IL_29:
				num = 3;
				Main.OO_O.o..OOoo___.0.(base.Controls, O_O0OO.o_.oO_O0.);
				goto IL_59;
				IL_42:
				num = 5;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_59:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_60:
				num = 7;
				this.OooO.00o. = A_0;
				IL_69:
				num = 8;
				this.o.0___0_00oo0. = A_1;
				IL_72:
				num = 9;
				this.OooO.00o. = A_2;
				IL_7C:
				num = 10;
				this.O.O_0O0oO_. = A_3;
				IL_87:
				num = 11;
				A_0.DefaultView.RowFilter = "";
				IL_9A:
				num = 12;
				this.O.O0OOoOO.().TrimEnd = false;
				IL_A9:
				num = 13;
				this.O.O0OOoOO.().TrimStart = false;
				IL_B8:
				num = 14;
				this.O.O0OOoOO.().Cols[0].AllowEditing = false;
				IL_D2:
				num = 15;
				this.O.O0OOoOO.().SelectionMode = SelectionModeEnum.Row;
				IL_E1:
				num = 16;
				this.O.O0OOoOO.().HighLight = HighLightEnum.WithFocus;
				IL_F0:
				num = 17;
				this.O.O0OOoOO.().DrawMode = DrawModeEnum.OwnerDraw;
				IL_FF:
				num = 18;
				DataRow dataRow = null;
				IL_104:
				num = 19;
				IEnumerator enumerator = A_0.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow2 = (DataRow)obj;
					IL_124:
					num = 20;
					if (!dataRow2.IsNull("Type") && Conversions.ToInteger(dataRow2["Type"]) == 7)
					{
						IL_149:
						num = 21;
						dataRow = dataRow2;
						break;
					}
					IL_151:
					num = 23;
				}
				IL_15D:
				num = 24;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_175:
				num = 25;
				if (dataRow != null && !dataRow.IsNull("Config") && Operators.CompareString(dataRow["Config"].ToString(), "", true) != 0)
				{
					goto IL_24D;
				}
				IL_1A8:
				num = 26;
				this.O.O0OOoOO.().Visible = false;
				IL_1B7:
				num = 27;
				this.O.O0OOoOO.().Location = new Point(this.O.O0OOoOO.().Location.X, this.O.O0OOoOO.().Location.Y);
				IL_1F2:
				num = 28;
				this.o__o.O.().Location = new Point(this.o__o.O.().Location.X, this.O.O0OOoOO.().Location.Y);
				IL_22D:
				num = 29;
				base.Height -= this.O.O0OOoOO.().Height;
				goto IL_641;
				IL_24D:
				num = 31;
				if (dataRow == null && dataRow.IsNull("Config") && Operators.CompareString(dataRow["Config"].ToString(), "", true) <= 0)
				{
					goto IL_641;
				}
				IL_281:
				num = 32;
				string text = dataRow["Config"].ToString();
				IL_296:
				num = 33;
				bool flag = true;
				IL_29C:
				num = 34;
				if (!(text.StartsWith("{") & text.EndsWith("}")))
				{
					goto IL_2DC;
				}
				IL_2BA:
				num = 35;
				flag = false;
				IL_2C0:
				num = 36;
				text = text.Trim(new char[]
				{
					'{',
					'}'
				});
				IL_2DC:
				num = 37;
				this.OooO.00o. = text.Split(new char[]
				{
					'\r'
				});
				IL_2F7:
				num = 38;
				foreach (string text2 in this.OooO.00o.)
				{
					IL_311:
					num = 39;
					string[] array = text2.Split(new char[]
					{
						'\t'
					});
					IL_328:
					num = 40;
					if (Operators.CompareString(array[0], "", true) != 0)
					{
						IL_33F:
						num = 42;
						C1FlexGrid c1FlexGrid = this.O.O0OOoOO.();
						IL_34A:
						num = 43;
						c1FlexGrid.Rows.Count = c1FlexGrid.Rows.Count + 1;
						IL_367:
						num = 44;
						c1FlexGrid[c1FlexGrid.Rows.Count - 1, 0] = array[0];
						IL_384:
						num = 45;
						CellRange cellRange = this.O.O0OOoOO.().GetCellRange(c1FlexGrid.Rows.Count - 1, 1);
						IL_3A3:
						num = 46;
						if (Operators.CompareString(array[2], "", true) > 0)
						{
							IL_3B8:
							num = 47;
							cellRange.StyleNew.ComboList = array[2];
						}
						IL_3CB:
						num = 48;
						if (Operators.CompareString(array[1], "0", true) == 0)
						{
							IL_3DF:
							num = 49;
							cellRange.StyleNew.DataType = typeof(string);
							IL_3F8:
							num = 50;
							if (array.Length == 4)
							{
								IL_405:
								num = 51;
								c1FlexGrid[c1FlexGrid.Rows.Count - 1, 1] = array[3];
							}
						}
						else
						{
							IL_427:
							num = 53;
							if (Operators.CompareString(array[1], "1", true) == 0)
							{
								IL_43B:
								num = 54;
								cellRange.StyleNew.DataType = typeof(double);
								IL_454:
								num = 55;
								if (array.Length == 4)
								{
									IL_461:
									num = 56;
									double num3;
									if (double.TryParse(array[3], out num3))
									{
										IL_474:
										num = 57;
										c1FlexGrid[c1FlexGrid.Rows.Count - 1, 1] = num3;
									}
								}
							}
							else
							{
								IL_499:
								num = 59;
								if (Operators.CompareString(array[1], "2", true) == 0)
								{
									IL_4B0:
									num = 60;
									cellRange.StyleNew.DataType = typeof(DateTime);
									IL_4C9:
									num = 61;
									cellRange.StyleNew.Format = "yyyy-MM-dd";
									IL_4DD:
									num = 62;
									cellRange.StyleNew.Editor = O_O0OO.o0_OO.000.();
									IL_4F1:
									num = 63;
									if (array.Length == 4)
									{
										IL_4FE:
										num = 64;
										DateTime dateTime;
										if (DateTime.TryParse(array[3], out dateTime))
										{
											IL_511:
											num = 65;
											c1FlexGrid[c1FlexGrid.Rows.Count - 1, 1] = dateTime;
										}
									}
								}
								else
								{
									IL_536:
									num = 67;
									if (Operators.CompareString(array[1], "3", true) == 0)
									{
										IL_54A:
										num = 68;
										cellRange.StyleNew.DataType = typeof(bool);
										IL_563:
										num = 69;
										if (array.Length == 4)
										{
											IL_570:
											num = 70;
											bool flag2;
											if (bool.TryParse(array[3], out flag2))
											{
												IL_583:
												num = 71;
												c1FlexGrid[c1FlexGrid.Rows.Count - 1, 1] = flag2;
											}
										}
									}
									else
									{
										IL_5A8:
										num = 73;
										if (Operators.CompareString(array[1], "4", true) == 0)
										{
											IL_5BC:
											num = 74;
											cellRange.StyleNew.DataType = typeof(string);
											IL_5D5:
											num = 75;
											c1FlexGrid.Rows[c1FlexGrid.Rows.Count - 1].UserData = "pwd";
											IL_5FC:
											num = 76;
											if (flag)
											{
												IL_603:
												num = 77;
												if (array.Length == 4)
												{
													IL_60D:
													num = 78;
													c1FlexGrid[c1FlexGrid.Rows.Count - 1, 1] = array[3];
												}
											}
										}
									}
								}
							}
						}
						IL_62A:
						c1FlexGrid = null;
					}
					IL_62D:
					num = 80;
				}
				IL_641:
				num = 81;
				this.o__o.O.();
				IL_64A:
				goto IL_7E4;
				IL_64F:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_7A5:
				goto IL_7D9;
				IL_7A7:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_7B7:;
			}
			catch when (endfilter(obj2 is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_7A7;
			}
			IL_7D9:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7E4:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00181848 File Offset: 0x0017FA48
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
				DataRow[] array = this.OooO.00o..Select("[Name] = '" + this.O.O0OOoOO.().Text + "'");
				IL_2F:
				num2 = 3;
				if (array.Length != 0)
				{
					goto IL_5F;
				}
				IL_36:
				num2 = 4;
				MessageBox.Show(O00.DecryptText("6++xAA66aLSS/2MaXdl/ajlP96cX+UbwP9X5hk+Opk8=", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_4F7;
				IL_5F:
				num2 = 6;
				DataRow dataRow = array[0];
				IL_66:
				num2 = 7;
				UserProperty userProperty = new UserProperty();
				IL_6F:
				num2 = 8;
				string text = O_O0OO.o0_OO.000.(this.o.0___0_00oo0..DataSet);
				IL_83:
				num2 = 9;
				o_O_o_oOoo__.OOOO_OO._oo.(userProperty, Conversions.ToString(dataRow["Config"]), '\v');
				IL_A0:
				num2 = 10;
				if (Operators.CompareString(userProperty.PassWord, O00.MD5Encrypt(O00.ooo000o_0.00o0.(this.O.O0OOoOO.().Text, text.Substring(0, 8), text.Substring(text.Length - 8))), true) != 0 && (userProperty.Type == UserTypeEnum.Administrator || userProperty.Type == UserTypeEnum.Developer || Operators.CompareString(userProperty.PassWord, O00.MD5Encrypt(this.O.O0OOoOO.().Text), true) != 0))
				{
					goto IL_4D2;
				}
				IL_11B:
				num2 = 11;
				this.OooO.00o. = new UserInfo();
				IL_129:
				num2 = 12;
				this.OooO.00o..Name = Conversions.ToString(dataRow["Name"]);
				IL_148:
				num2 = 13;
				this.OooO.00o..Group = userProperty.Group;
				IL_15D:
				num2 = 14;
				this.OooO.00o..Roles = userProperty.Role;
				IL_172:
				num2 = 15;
				this.OooO.00o..Tag = userProperty.Tag;
				IL_187:
				num2 = 16;
				this.OooO.00o..Password = userProperty.PassWord;
				IL_19C:
				num2 = 17;
				if (Operators.CompareString(this.OooO.00o..Tag, "", true) <= 0)
				{
					goto IL_26D;
				}
				IL_1BB:
				num2 = 18;
				string[] array2 = this.OooO.00o..Tag.Split(new char[]
				{
					'|'
				});
				IL_1DB:
				num2 = 19;
				foreach (string text2 in array2)
				{
					IL_1EE:
					num2 = 20;
					if (text2.StartsWith("**"))
					{
						IL_1FF:
						num2 = 21;
						text2 = text2.Trim(new char[]
						{
							'*'
						});
						IL_216:
						num2 = 22;
						if (!UKey.Start() || Operators.CompareString(text2, UKey.UID, true) != 0)
						{
							IL_22F:
							num2 = 23;
							MessageBox.Show(O00.DecryptText("ldiL5ZtPgp1Ocj6c/7/37b1s//rHYAK/7zh1Ma1hHts=", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							goto IL_4F7;
						}
					}
					IL_259:
					num2 = 25;
				}
				IL_26D:
				num2 = 26;
				if (userProperty.Type == UserTypeEnum.None)
				{
					goto IL_291;
				}
				IL_27A:
				num2 = 27;
				this.OooO.00o..Type = userProperty.Type;
				goto IL_2B0;
				IL_291:
				num2 = 29;
				this.OooO.00o..Type = (UserTypeEnum)Conversions.ToInteger(dataRow["Type"]);
				IL_2B0:
				num2 = 30;
				if (this.OooO.00o..Type != UserTypeEnum.Administrator && this.OooO.00o..Type != UserTypeEnum.Developer)
				{
					goto IL_387;
				}
				IL_2D1:
				num2 = 31;
				if (this.OooO.00o..Type != UserTypeEnum.Administrator)
				{
					goto IL_2EA;
				}
				IL_2E2:
				num2 = 32;
				o0_O o0_O = o0_O.o_.OOO.;
				goto IL_2F0;
				IL_2EA:
				num2 = 34;
				o0_O = o0_O.ooO.Oo_0O0.;
				IL_2F0:
				num2 = 35;
				DataTable dataTable = this.o.0___0_00oo0.;
				IL_2FB:
				num2 = 36;
				DataRow dataRow2 = dataTable.Rows.Find(new object[]
				{
					"Config",
					o0_O
				});
				IL_324:
				num2 = 37;
				if (dataRow2 == null)
				{
					goto IL_384;
				}
				IL_32B:
				num2 = 38;
				if (Operators.CompareString(Conversions.ToString(dataRow2["Config"]), O00.MD5Encrypt(userProperty.PassWord).Substring(0, 8), true) == 0)
				{
					goto IL_384;
				}
				IL_35A:
				num2 = 39;
				MessageBox.Show(O00.DecryptText("h6WeLTVRHfSD/3gFdjBy9A==", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_4F7;
				IL_384:
				dataTable = null;
				IL_387:
				num2 = 42;
				if (this.OooO.00o..Type != UserTypeEnum.Default)
				{
					goto IL_3B6;
				}
				IL_398:
				num2 = 43;
				this.OooO.00o..Type = UserTypeEnum.User;
				IL_3A7:
				num2 = 44;
				this.OooO.00o..Default = true;
				IL_3B6:
				num2 = 45;
				DataRow dataRow3 = this.o.0___0_00oo0..Rows.Find(new object[]
				{
					"LastLogonUser",
					o0_O.ooO__0.oO_0_.
				});
				IL_3E3:
				num2 = 46;
				if (dataRow3 != null)
				{
					goto IL_439;
				}
				IL_3EA:
				num2 = 47;
				dataRow3 = this.o.0___0_00oo0..NewRow();
				IL_3FA:
				num2 = 48;
				dataRow3["Name"] = "LastLogonUser";
				IL_40E:
				num2 = 49;
				dataRow3["Type"] = o0_O.ooO__0.oO_0_.;
				IL_424:
				num2 = 50;
				this.o.0___0_00oo0..Rows.Add(dataRow3);
				IL_439:
				num2 = 51;
				if (Operators.CompareString(dataRow3["Config"].ToString(), this.OooO.00o..Name, true) == 0)
				{
					goto IL_47A;
				}
				IL_460:
				num2 = 52;
				dataRow3["Config"] = this.OooO.00o..Name;
				IL_47A:
				num2 = 53;
				this.o__O__ooO._o.();
				IL_483:
				num2 = 54;
				base.DialogResult = DialogResult.OK;
				IL_48D:
				num2 = 55;
				if (this.OooO.00o. != SplashFormStateEnum.Normal || this.o0O.OO00OOOO_0.)
				{
					goto IL_4F7;
				}
				IL_4A0:
				num2 = 56;
				Main.ProcessForm.Show();
				IL_4AD:
				num2 = 57;
				Main.ProcessForm.Activate();
				IL_4BA:
				num2 = 58;
				Main.ProcessForm.Focus();
				IL_4C8:
				num2 = 59;
				Application.DoEvents();
				goto IL_4F7;
				IL_4D2:
				num2 = 61;
				MessageBox.Show(O00.DecryptText("orJKZaEkG7xneDQ8hKZC2w==", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				IL_4F7:
				goto IL_641;
				IL_4FC:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_602:
				goto IL_636;
				IL_604:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_614:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_604;
			}
			IL_636:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_641:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00181EBC File Offset: 0x001800BC
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num5;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.OooO.00o..ExtendedValues.Clear();
				IL_19:
				num2 = 3;
				if (!this.O.O0OOoOO.().Visible)
				{
					goto IL_247;
				}
				IL_2B:
				num2 = 5;
				int num3 = this.O.O0OOoOO.().Rows.Count - this.O.O0OOoOO.().Rows.Fixed - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_5A:
					num2 = 6;
					C1FlexGrid c1FlexGrid = this.O.O0OOoOO.();
					IL_64:
					num2 = 7;
					this.OooO.00o..ExtendedValues.Add(c1FlexGrid.GetData(i + 1, 0).ToString(), RuntimeHelpers.GetObjectValue(c1FlexGrid.GetData(i + 1, 1)));
					IL_98:
					num2 = 8;
					if (c1FlexGrid.GetData(i + 1, 1) != null)
					{
						IL_AB:
						num2 = 9;
						string[] array = this.OooO.00o.[i].Split(new char[]
						{
							'\t'
						});
						IL_C9:
						num2 = 10;
						if (array.Length == 4)
						{
							IL_D3:
							num2 = 11;
							array[3] = c1FlexGrid.GetData(i + 1, 1).ToString();
							IL_EB:
							num2 = 12;
							this.OooO.00o.[i] = string.Join("\t", array);
						}
						else
						{
							IL_105:
							num2 = 14;
							this.OooO.00o.[i] = this.OooO.00o.[i] + "\t" + c1FlexGrid.GetData(i + 1, 1).ToString();
						}
					}
					IL_135:
					c1FlexGrid = null;
					IL_138:
					num2 = 16;
				}
				IL_14A:
				num2 = 17;
				DataRow dataRow = null;
				IL_14F:
				num2 = 18;
				IEnumerator enumerator = this.OooO.00o..Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow2 = (DataRow)obj;
					IL_174:
					num2 = 19;
					if (Conversions.ToInteger(dataRow2["Type"]) == 7)
					{
						IL_18B:
						num2 = 20;
						dataRow = dataRow2;
						break;
					}
					IL_193:
					num2 = 22;
				}
				IL_19F:
				num2 = 23;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_1B7:
				num2 = 24;
				string text = dataRow["Config"].ToString();
				IL_1CC:
				num2 = 25;
				if (!text.StartsWith("{") || !text.EndsWith("}"))
				{
					goto IL_21A;
				}
				IL_1EB:
				num2 = 26;
				dataRow["Config"] = "{" + string.Join("\r", this.OooO.00o.) + "}";
				goto IL_238;
				IL_21A:
				num2 = 28;
				dataRow["Config"] = string.Join("\r", this.OooO.00o.);
				IL_238:
				num2 = 29;
				Oo00.o0_o._O_.(this.OooO.00o., true);
				IL_247:
				goto IL_311;
				IL_24C:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_2D2:
				goto IL_306;
				IL_2D4:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2E4:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_2D4;
			}
			IL_306:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_311:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x00182200 File Offset: 0x00180400
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			this.Oo_.o. = true;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x0018220C File Offset: 0x0018040C
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.O.O0OOoOO.();
			if (c1FlexGrid.Col == 0)
			{
				c1FlexGrid.Col = 1;
			}
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00182234 File Offset: 0x00180434
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (this.O.O0OOoOO.().Rows[A_1.Row].UserData != null && A_1.Col == 1 && Operators.CompareString(A_1.Text, "", true) > 0)
			{
				A_1.Text = new string('*', A_1.Text.Length);
			}
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00182298 File Offset: 0x00180498
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.O.O0OOoOO.();
			if (c1FlexGrid.Editor is TextBox)
			{
				if (c1FlexGrid.Rows[A_1.Row].UserData != null)
				{
					((TextBox)c1FlexGrid.Editor).PasswordChar = '*';
				}
				else
				{
					((TextBox)c1FlexGrid.Editor).PasswordChar = '\0';
				}
			}
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x001822F8 File Offset: 0x001804F8
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400164F RID: 5711
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001650 RID: 5712
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001651 RID: 5713
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001652 RID: 5714
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001653 RID: 5715
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001654 RID: 5716
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001655 RID: 5717
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001656 RID: 5718
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001657 RID: 5719
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001658 RID: 5720
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04001659 RID: 5721
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400165A RID: 5722
		private SplashFormStateEnum <<EMPTY_NAME>>;

		// Token: 0x0400165B RID: 5723
		internal UserInfo <<EMPTY_NAME>>;

		// Token: 0x0400165C RID: 5724
		private string[] <<EMPTY_NAME>>;

		// Token: 0x0400165D RID: 5725
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400165E RID: 5726
		private string <<EMPTY_NAME>>;

		// Token: 0x0400165F RID: 5727
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001660 RID: 5728
		private bool <<EMPTY_NAME>>;
	}
}

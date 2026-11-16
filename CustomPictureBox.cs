using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003E5 RID: 997
	internal class CustomPictureBox : System.Windows.Forms.Panel, O0_0_0_0_
	{
		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x001D671A File Offset: 0x001D491A
		// (set) Token: 0x060040FE RID: 16638 RVA: 0x001D6724 File Offset: 0x001D4924
		internal virtual C1PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this.O.o__.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AsyncCompletedEventHandler value2 = new AsyncCompletedEventHandler(this.O0O00O0oO0.0.);
				MouseEventHandler value3 = new MouseEventHandler(this.O__0o.OOOOo.);
				MouseEventHandler value4 = new MouseEventHandler(this.oO_OOoOoO.O0O.);
				MouseEventHandler value5 = new MouseEventHandler(this.oO_._o.);
				MouseEventHandler value6 = new MouseEventHandler(this.Oo0o.0O0Oo0.);
				C1PictureBox o.o__. = this.O.o__.;
				if (o.o__. != null)
				{
					o.o__..LoadCompleted -= value2;
					o.o__..MouseDoubleClick -= value3;
					o.o__..MouseDown -= value4;
					o.o__..MouseMove -= value5;
					o.o__..MouseUp -= value6;
				}
				this.O.o__. = value;
				o.o__. = this.O.o__.;
				if (o.o__. != null)
				{
					o.o__..LoadCompleted += value2;
					o.o__..MouseDoubleClick += value3;
					o.o__..MouseDown += value4;
					o.o__..MouseMove += value5;
					o.o__..MouseUp += value6;
				}
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x001D67E4 File Offset: 0x001D49E4
		// (set) Token: 0x06004100 RID: 16640 RVA: 0x001D67EC File Offset: 0x001D49EC
		private virtual OOO__0oo_oo httpDown
		{
			[CompilerGenerated]
			get
			{
				return this.o.o0_O_O.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				OOO__0oo_oo.oOOO a_ = new OOO__0oo_oo.oOOO(this.O0O00O0oO0.0.);
				OOO__0oo_oo ooo__0oo_oo = this.o.o0_O_O.;
				if (ooo__0oo_oo != null)
				{
					ooo__0oo_oo.o0O_.0o0_oO.(a_);
				}
				this.o.o0_O_O. = value;
				ooo__0oo_oo = this.o.o0_O_O.;
				if (ooo__0oo_oo != null)
				{
					ooo__0oo_oo.O_o0.0oo0_o.(a_);
				}
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x001D682F File Offset: 0x001D4A2F
		// (set) Token: 0x06004102 RID: 16642 RVA: 0x001D6838 File Offset: 0x001D4A38
		private virtual FTPClient _FTPClient
		{
			[CompilerGenerated]
			get
			{
				return this.o.o0_O_O.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				FTPClient.oO_o_0OOo__0 a_ = new FTPClient.oO_o_0OOo__0(this.O.0O_oo.);
				FTPClient.O__0O000__Oo a_2 = new FTPClient.O__0O000__Oo(this.O.0O_oo.);
				FTPClient.Oo__ a_3 = new FTPClient.Oo__(this.O.0O_oo.);
				FTPClient ftpclient = this.o.o0_O_O.;
				if (ftpclient != null)
				{
					ftpclient.DownloadCompleted -= a_;
					ftpclient.DownloadError -= a_2;
					ftpclient.FileCompared -= a_3;
				}
				this.o.o0_O_O. = value;
				ftpclient = this.o.o0_O_O.;
				if (ftpclient != null)
				{
					ftpclient.DownloadCompleted += a_;
					ftpclient.DownloadError += a_2;
					ftpclient.FileCompared += a_3;
				}
			}
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x001D68B4 File Offset: 0x001D4AB4
		public CustomPictureBox(Foxtable.WinForm.Form A_0)
		{
			base.ParentChanged += this.Oo0o.0O0Oo0.;
			this.PictureBox1 = new C1PictureBox();
			this.oOO__OoO.o. = true;
			this.O.Oo. = "";
			this.PictureBox1.Dock = DockStyle.Fill;
			base.Controls.Add(this.PictureBox1);
			this.PictureBox1.InitialImage = O_O0OO.o0_OO.000.();
			this.BackColor = Color.White;
			this.O0O00O0oO0.0.();
			this.o.o0_O_O. = A_0;
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06004104 RID: 16644 RVA: 0x001D693B File Offset: 0x001D4B3B
		// (set) Token: 0x06004105 RID: 16645 RVA: 0x001D6943 File Offset: 0x001D4B43
		internal bool AutoUpdate
		{
			get
			{
				return this.oOO__OoO.o.;
			}
			set
			{
				this.oOO__OoO.o. = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06004106 RID: 16646 RVA: 0x001D694C File Offset: 0x001D4B4C
		// (set) Token: 0x06004107 RID: 16647 RVA: 0x001D695C File Offset: 0x001D4B5C
		public Image Image
		{
			get
			{
				return this.PictureBox1.Image;
			}
			set
			{
				Image image = this.PictureBox1.Image;
				if (image != null)
				{
					image.Dispose();
				}
				this.PictureBox1.Image = value;
				this.O0O00O0oO0.0.();
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06004108 RID: 16648 RVA: 0x001D6992 File Offset: 0x001D4B92
		// (set) Token: 0x06004109 RID: 16649 RVA: 0x001D699A File Offset: 0x001D4B9A
		public ImageSizeMode SizeMode
		{
			get
			{
				return this.O.o__.;
			}
			set
			{
				this.O.o__. = value;
				this.O0O00O0oO0.0.();
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x001D69A9 File Offset: 0x001D4BA9
		// (set) Token: 0x0600410B RID: 16651 RVA: 0x001D69B4 File Offset: 0x001D4BB4
		public string ImageFile
		{
			get
			{
				return this.o.o0_O_O.;
			}
			set
			{
				string text = value;
				if (this.o.o0_O_O. != null)
				{
					BeforeGetImageEventArgs beforeGetImageEventArgs = new BeforeGetImageEventArgs(this, this.o.o0_O_O., value);
					string a_ = "BeforeGetImage_" + Conversions.ToString(base.Tag);
					O_O0OO.OoO_o.oO0o0O.(this.o.o0_O_O..O_0.O00o_00_O., a_, new object[]
					{
						beforeGetImageEventArgs
					}, false, this.o.o0_O_O..mmname + "," + base.Name, false);
					text = beforeGetImageEventArgs.File;
				}
				if (Operators.CompareString(this.o.o0_O_O., value, true) != 0)
				{
					this.o.o0_O_O. = value;
					this.oO0O0Ooo0OO._o. = "";
					this.oO0O0Ooo0OO._o. = true;
					this.O_0o_0O._00o0o. = false;
					C1PictureBox c1PictureBox = this.PictureBox1;
					if (c1PictureBox.Image != null && c1PictureBox.Image != O_O0OO.o0_OO.000.() && c1PictureBox.Image != c1PictureBox.ErrorImage)
					{
						c1PictureBox.Image.Dispose();
					}
					c1PictureBox.Image = null;
					c1PictureBox.Dock = DockStyle.Fill;
					if (this.FTPClient != null && this.FTPClient.AsyncState == Oo_0.Oo_o_o.__oo.)
					{
						this.FTPClient.o_0_.__0OO.();
					}
					if (this.o000O0O__.o_.)
					{
						this.PictureBox1.CancelAsync();
					}
					this.O.Oo. = text;
					if (Operators.CompareString(text, "", true) != 0)
					{
						if (text.StartsWith("http", StringComparison.CurrentCultureIgnoreCase))
						{
							if (this.httpDown == null)
							{
								this.httpDown = new OOO__0oo_oo();
							}
							this.httpDown.o0O_.0o0_oO.();
							this.oO0O0Ooo0OO._o. = text;
							string text2 = OO_00oOO.ProjectPath + "RemoteFiles\\" + this.O0O00O0oO0.0.(OO_00oOO.FileSys.GetName(this.oO0O0Ooo0OO._o.));
							if (OO_00oOO.FileSys.FileExists(text2))
							{
								this.o000O0O__.o_. = true;
								this.PictureBox1.LoadAsync(text2);
								return;
							}
						}
						else if (this.FTPClient == null)
						{
							if ((text.Length < 2 || Operators.CompareString(text.Substring(1, 1), ":", true) != 0) && !text.StartsWith("\\\\"))
							{
								if (base.DataBindings.Count > 0)
								{
									BindingMemberInfo bindingMemberInfo = base.DataBindings[0].BindingMemberInfo;
									if (base.DataBindings[0].DataSource is O_0)
									{
										string text3 = ((O_0)base.DataBindings[0].DataSource).Oo._Oo0OO.();
										if (OO_00oOO.Tables.get_Contains(text3) && OO_00oOO.Tables[text3].Cols.Contains(bindingMemberInfo.BindingField))
										{
											DataCol dataCol = OO_00oOO.Tables[text3].Cols[bindingMemberInfo.BindingField].DataCol;
											if (Operators.CompareString(dataCol.DefaultFolder, "", true) > 0)
											{
												text = dataCol.DefaultFolder.TrimEnd(new char[]
												{
													'\\'
												}) + "\\" + text;
											}
										}
									}
									bindingMemberInfo = default(BindingMemberInfo);
								}
								text = ooO.OoO0o_o___.O.(text);
							}
							if (OO_00oOO.FileSys.FileExists(text))
							{
								this.o000O0O__.o_. = true;
								this.PictureBox1.LoadAsync(text);
								return;
							}
							this.o.o0_O_O. = "";
							return;
						}
						else
						{
							this.oOO__OoO.o. = "";
							this.O.o_0. = "";
							string text4 = text;
							string text5 = OO_00oOO.ProjectPath + "RemoteFiles\\" + text4.Replace("/", "\\").Trim(new char[]
							{
								'\\'
							});
							if (OO_00oOO.FileSys.FileExists(text5))
							{
								this.o000O0O__.o_. = true;
								this.PictureBox1.LoadAsync(text5);
								if (this.AutoUpdate)
								{
									this.O.o_0. = text;
									this.O.o__. = DateTime.Now;
									return;
								}
							}
							else
							{
								this.PictureBox1.Image = null;
								this.oOO__OoO.o. = text;
							}
						}
					}
				}
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x0600410C RID: 16652 RVA: 0x001D6D6A File Offset: 0x001D4F6A
		// (set) Token: 0x0600410D RID: 16653 RVA: 0x001D6D74 File Offset: 0x001D4F74
		internal FTPClient FTPClient
		{
			get
			{
				return this._FTPClient;
			}
			set
			{
				if (value != null)
				{
					this._FTPClient = new FTPClient();
					this._FTPClient.Host = value.Host;
					this._FTPClient.Account = value.Account;
					this._FTPClient.Password = value.Password;
					this._FTPClient.Port = value.Port;
					this._FTPClient.UTF8 = value.UTF8;
					if (!this.oo00__O.0_0.)
					{
						this.oo00__O.0_0. = true;
						NetworkChange.NetworkAvailabilityChanged += this.O0O00O0oO0.0.;
						NetworkChange.NetworkAddressChanged += this.O_.000o_.;
						return;
					}
				}
				else
				{
					this._FTPClient = null;
				}
			}
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x001D6E20 File Offset: 0x001D5020
		private void <<EMPTY_NAME>>()
		{
			if (this.SizeMode == ImageSizeMode.Normal & this.PictureBox1.Image != null)
			{
				int width = Math.Max(base.ClientRectangle.Width, this.PictureBox1.Image.Size.Width);
				int height = Math.Max(base.ClientRectangle.Height, this.PictureBox1.Image.Size.Height);
				this.PictureBox1.Dock = DockStyle.None;
				this.PictureBox1.SetBounds(0, 0, width, height);
			}
			else
			{
				this.PictureBox1.Dock = DockStyle.Fill;
			}
			switch (this.SizeMode)
			{
			case ImageSizeMode.Normal:
				this.PictureBox1.SizeMode = PictureBoxSizeMode.Normal;
				return;
			case ImageSizeMode.CenterImage:
				this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
				return;
			case ImageSizeMode.StretchImage:
				this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				return;
			case ImageSizeMode.Zoom:
				this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x001D6F1C File Offset: 0x001D511C
		private void <<EMPTY_NAME>>(object A_0, AsyncCompletedEventArgs A_1)
		{
			this.o000O0O__.o_. = false;
			if (base.FindForm() != null && (this.FTPClient == null || !this.FTPClient.O0.o0.) && !base.IsDisposed)
			{
				if (A_1.Error == null && !A_1.Cancelled)
				{
					if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
					{
						OO_00oOO.BaseMainForm.Invoke(new CustomPictureBox.oo0ooOoOOoO__(this.O0O00O0oO0.0.), new object[]
						{
							true
						});
						return;
					}
				}
				else if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
				{
					OO_00oOO.BaseMainForm.Invoke(new CustomPictureBox.oo0ooOoOOoO__(this.O0O00O0oO0.0.), new object[]
					{
						false
					});
				}
			}
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x001D6FE4 File Offset: 0x001D51E4
		private void <<EMPTY_NAME>>(bool A_0)
		{
			if (!A_0)
			{
				if (Operators.CompareString(this.o.o0_O_O., "", true) > 0)
				{
					this.PictureBox1.Image = this.PictureBox1.ErrorImage;
				}
				else
				{
					this.PictureBox1.Image = null;
				}
				this.PictureBox1.Dock = DockStyle.Fill;
				this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
				return;
			}
			this.O0O00O0oO0.0.();
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x001D704C File Offset: 0x001D524C
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (!(base.Parent is ControlHolder) && Operators.CompareString(this.ImageFile, "", true) > 0 && Operators.CompareString(this.O.Oo., "", true) > 0 && Operators.CompareString(this.oOO__OoO.o., "", true) == 0 && Operators.CompareString(this.oO0O0Ooo0OO._o., "", true) == 0)
			{
				if (this.O.Oo..StartsWith("http", StringComparison.CurrentCultureIgnoreCase))
				{
					this.oO0O0Ooo0OO._o. = this.O.Oo.;
					this.O_0o_0O._00o0o. = true;
					return;
				}
				if ((this.FTPClient != null & Operators.CompareString(this.oOO__OoO.o., "", true) == 0) && this.FTPClient.AsyncState == Oo_0.OOoo0_OO__._o. && !O_O0OO.oO_00Ooo___0._..Contains(this.ImageFile.ToLower()))
				{
					this.oOO__OoO.o. = this.O.Oo.;
					this.O_0o_0O._00o0o. = true;
				}
			}
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x001D7140 File Offset: 0x001D5340
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (!(base.Parent is ControlHolder) && A_1.Button == MouseButtons.Left)
			{
				this.O.o__. = A_1.X;
				this.oo0_.0_. = A_1.Y;
				this.O.o__. = true;
				this.PictureBox1.Cursor = Cursors.Hand;
			}
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x001D7198 File Offset: 0x001D5398
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (!(base.Parent is ControlHolder))
			{
				int num = base.HorizontalScroll.Value - (A_1.X - this.O.o__.);
				int num2 = base.VerticalScroll.Value - (A_1.Y - this.oo0_.0_.);
				if (this.O.o__.)
				{
					if (!(num >= 0 & num <= base.HorizontalScroll.Maximum))
					{
						num = base.HorizontalScroll.Value;
					}
					if (!(num2 >= 0 & num2 <= base.VerticalScroll.Maximum))
					{
						num2 = base.VerticalScroll.Value;
					}
					base.AutoScrollPosition = new Point(num, num2);
				}
			}
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x001D724C File Offset: 0x001D544C
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (!(base.Parent is ControlHolder))
			{
				this.O.o__. = false;
				this.PictureBox1.Cursor = Cursors.Default;
			}
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x001D7274 File Offset: 0x001D5474
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()))
			{
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower());
			}
			if (Operators.CompareString(A_0, this.ImageFile, true) == 0)
			{
				string text = OO_00oOO.ProjectPath + "RemoteFiles\\" + A_0.Replace("/", "\\").Trim(new char[]
				{
					'\\'
				});
				if (OO_00oOO.FileSys.FileExists(text))
				{
					this.o000O0O__.o_. = true;
					this.PictureBox1.LoadAsync(text);
				}
			}
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x001D7304 File Offset: 0x001D5504
		private void <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			if (O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()))
			{
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower());
			}
			if (Operators.CompareString(A_0, this.ImageFile, true) == 0)
			{
				this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
				this.PictureBox1.Image = this.PictureBox1.ErrorImage;
			}
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x001D7365 File Offset: 0x001D5565
		private void <<EMPTY_NAME>>(object A_0, NetworkAvailabilityEventArgs A_1)
		{
			if (this.FTPClient != null)
			{
				this.FTPClient.Connected = false;
			}
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x001D737B File Offset: 0x001D557B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.FTPClient != null)
			{
				this.FTPClient.Connected = false;
			}
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x001D7394 File Offset: 0x001D5594
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.FindForm() == null || (this.FTPClient != null && this.FTPClient.O0.o0.))
			{
				Application.Idle -= this.oO_._o.;
				NetworkChange.NetworkAvailabilityChanged -= this.O0O00O0oO0.0.;
				NetworkChange.NetworkAddressChanged -= this.O_.000o_.;
				if (this.FTPClient != null)
				{
					this.FTPClient.Connected = false;
					this.FTPClient = null;
					return;
				}
			}
			else if (this.FTPClient != null && this.FTPClient.AsyncState == Oo_0.OOoo0_OO__._o.)
			{
				if (Operators.CompareString(this.oOO__OoO.o., "", true) > 0)
				{
					string text = this.oOO__OoO.o.;
					if (text.IndexOf('\n') < 0 && text.IndexOf('\r') < 0)
					{
						string text2 = OO_00oOO.ProjectPath + "RemoteFiles\\" + text.Replace("/", "\\").Trim(new char[]
						{
							'\\'
						});
						if (O_O0OO.oO_00Ooo___0._..Contains(text.ToLower()))
						{
							this.oO0O0Ooo0OO._o. = false;
							return;
						}
						this.oOO__OoO.o. = "";
						string parentPath = OO_00oOO.FileSys.GetParentPath(text2);
						if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
						{
							OO_00oOO.FileSys.CreateDirectory(parentPath);
						}
						if (OO_00oOO.FileSys.FileExists(text2) && !this.O_0o_0O._00o0o.)
						{
							this.o000O0O__.o_. = true;
							this.PictureBox1.LoadAsync(text2);
							return;
						}
						this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
						this.PictureBox1.Image = O_O0OO.o0_OO.000.();
						O_O0OO.oO_00Ooo___0._..Add(text.ToLower());
						this.FTPClient.O_O0Ooo_00.o.(text, text2, false);
						return;
					}
				}
				else if (Operators.CompareString(this.O.o_0., "", true) > 0 && (DateTime.Now - this.O.o__.).TotalSeconds > 2.0)
				{
					string o.o_0. = this.O.o_0.;
					this.O.o_0. = "";
					string a_ = OO_00oOO.ProjectPath + "RemoteFiles\\" + o.o_0..Replace("/", "\\").Trim(new char[]
					{
						'\\'
					});
					this.FTPClient.O_O_0_O0.oOO.(o.o_0., a_);
					return;
				}
			}
			else if (Operators.CompareString(this.oO0O0Ooo0OO._o., "", true) > 0 && this.httpDown.o0O_.0o0_oO.())
			{
				string text3 = this.oO0O0Ooo0OO._o.;
				string text4 = OO_00oOO.ProjectPath + "RemoteFiles\\" + this.O0O00O0oO0.0.(OO_00oOO.FileSys.GetName(text3));
				if (O_O0OO.oO_00Ooo___0._..Contains(this.oO0O0Ooo0OO._o..ToLower()))
				{
					this.oO0O0Ooo0OO._o. = false;
					this.O_0o_0O._00o0o. = false;
					return;
				}
				if (OO_00oOO.FileSys.FileExists(text4) && !this.oO0O0Ooo0OO._o. && !this.O_0o_0O._00o0o.)
				{
					this.oO0O0Ooo0OO._o. = "";
					this.o000O0O__.o_. = true;
					this.PictureBox1.LoadAsync(text4);
					return;
				}
				this.oO0O0Ooo0OO._o. = "";
				O_O0OO.oO_00Ooo___0._..Add(text3.ToLower());
				if (OO_00oOO.FileSys.FileExists(text4) && this.O_0o_0O._00o0o.)
				{
					this.httpDown.o0O_.0o0_oO.(text3, text4, false);
				}
				else
				{
					this.httpDown.o0O_.0o0_oO.(text3, text4, true);
				}
				if (!OO_00oOO.FileSys.FileExists(text4) || this.O_0o_0O._00o0o.)
				{
					this.PictureBox1.Dock = DockStyle.Fill;
					this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
					this.PictureBox1.Image = O_O0OO.o0_OO.000.();
				}
			}
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x001D771C File Offset: 0x001D591C
		private string <<EMPTY_NAME>>(string A_0)
		{
			foreach (char value in "<>*?/\\|:\"")
			{
				A_0 = A_0.Replace(Conversions.ToString(value), "");
			}
			return A_0;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x001D775C File Offset: 0x001D595C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.Parent != null)
			{
				Application.Idle += this.oO_._o.;
				return;
			}
			Application.Idle -= this.oO_._o.;
			if (this.oo00__O.0_0.)
			{
				NetworkChange.NetworkAvailabilityChanged -= this.O0O00O0oO0.0.;
				NetworkChange.NetworkAddressChanged -= this.O_.000o_.;
			}
			if (this.FTPClient != null)
			{
				if (this.FTPClient.Connected)
				{
					this.FTPClient.Close();
				}
				this.FTPClient = null;
				if (Operators.CompareString(this.o.o0_O_O., "", true) > 0 && O_O0OO.oO_00Ooo___0._..Contains(this.o.o0_O_O..ToLower()))
				{
					O_O0OO.oO_00Ooo___0._..Remove(this.o.o0_O_O..ToLower());
				}
			}
			if (this.httpDown != null)
			{
				this.httpDown.o0O_.0o0_oO.();
			}
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x001D7839 File Offset: 0x001D5A39
		private void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			if (Operators.CompareString(A_0, this.ImageFile, true) == 0)
			{
				this.oO0O0Ooo0OO._o. = false;
				if (!A_2)
				{
					this.O_0o_0O._00o0o. = true;
					this.oOO__OoO.o. = A_0;
				}
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x001D7862 File Offset: 0x001D5A62
		// (set) Token: 0x0600411E RID: 16670 RVA: 0x001D786A File Offset: 0x001D5A6A
		public int CurrentTabOrder
		{
			get
			{
				return this.OOOoo.0_oo.;
			}
			set
			{
				this.OOOoo.0_oo. = value;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x001D7873 File Offset: 0x001D5A73
		// (set) Token: 0x06004120 RID: 16672 RVA: 0x001D787B File Offset: 0x001D5A7B
		public int MaxTabOrder
		{
			get
			{
				return this.O_0o_0O._00o0o.;
			}
			set
			{
				this.O_0o_0O._00o0o. = value;
			}
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x001D7884 File Offset: 0x001D5A84
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O00OO_O_oO_.o.(this, this.PictureBox1.Controls);
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x001D7897 File Offset: 0x001D5A97
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O._0O0__o.(this.PictureBox1.Controls);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x001D78AC File Offset: 0x001D5AAC
		private void <<EMPTY_NAME>>(bool A_0, string A_1, string A_2, bool A_3)
		{
			if (A_0 && !A_3)
			{
				if (O_O0OO.oO_00Ooo___0._..Contains(A_1.ToLower()))
				{
					O_O0OO.oO_00Ooo___0._..Remove(A_1.ToLower());
				}
				if (Operators.CompareString(A_1, this.O.Oo., true) == 0 && OO_00oOO.FileSys.FileExists(A_2))
				{
					this.o000O0O__.o_. = true;
					this.PictureBox1.LoadAsync(A_2);
				}
			}
			if (!A_0 && Operators.CompareString(A_1, this.O.Oo., true) == 0 && this.PictureBox1.Image == O_O0OO.o0_OO.000.())
			{
				this.PictureBox1.Image = this.PictureBox1.ErrorImage;
			}
		}

		// Token: 0x04001A36 RID: 6710
		[AccessedThroughProperty("PictureBox1")]
		[CompilerGenerated]
		private C1PictureBox <<EMPTY_NAME>>;

		// Token: 0x04001A37 RID: 6711
		[CompilerGenerated]
		[AccessedThroughProperty("httpDown")]
		private OOO__0oo_oo <<EMPTY_NAME>>;

		// Token: 0x04001A38 RID: 6712
		private ImageSizeMode <<EMPTY_NAME>>;

		// Token: 0x04001A39 RID: 6713
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A3A RID: 6714
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A3B RID: 6715
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A3C RID: 6716
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A3D RID: 6717
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04001A3E RID: 6718
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A3F RID: 6719
		[CompilerGenerated]
		[AccessedThroughProperty("_FTPClient")]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04001A40 RID: 6720
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A41 RID: 6721
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A42 RID: 6722
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A43 RID: 6723
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A44 RID: 6724
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A45 RID: 6725
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A46 RID: 6726
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04001A47 RID: 6727
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A48 RID: 6728
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A49 RID: 6729
		private int <<EMPTY_NAME>>;

		// Token: 0x04001A4A RID: 6730
		private int <<EMPTY_NAME>>;

		// Token: 0x020003E6 RID: 998
		// (Invoke) Token: 0x06004127 RID: 16679
		private delegate void oo0ooOoOOoO__(bool A_0);
	}
}

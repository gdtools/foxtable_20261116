using System;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using DPFP.Verification;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200025E RID: 606
	internal class O_O : DPFP.Capture.EventHandler
	{
		// Token: 0x06001CAF RID: 7343 RVA: 0x000C5930 File Offset: 0x000C3B30
		internal void <<EMPTY_NAME>>()
		{
			if (this.O00._o. != null)
			{
				this.O00._o..StopCapture();
			}
			this.O00._o. = null;
			this.ooo0o.ooo_ooO. = null;
			this.O00._o. = false;
			if (!OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "finger.lic"))
			{
				CatalogClass catalogClass = new CatalogClass();
				((_Catalog)catalogClass).Create(Oo00.o00.0OO.(O_O0OO.o.00O_O.() + "finger.lic"));
				Table table = new TableClass();
				Index index = new IndexClass();
				table.Name = "~TMPCLPFinger";
				table.Columns.Append("SN", ADOX.DataTypeEnum.adVarWChar, 48);
				table.Columns.Append("RG", ADOX.DataTypeEnum.adVarWChar, 48);
				index.Name = "PrimaryKey";
				index.Columns.Append("SN", ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				((_Catalog)catalogClass).Tables.Append(table);
				((Connection)((_Catalog)catalogClass).ActiveConnection).Close();
			}
			OleDbConnection oleDbConnection = new OleDbConnection(Oo00.o_._0OOo.(O_O0OO.o.00O_O.() + "finger.lic"));
			OleDbCommand oleDbCommand = new OleDbCommand();
			oleDbCommand.Connection = oleDbConnection;
			ReadersCollection readersCollection;
			try
			{
				readersCollection = new ReadersCollection();
			}
			catch (Exception ex)
			{
				MessageBox.Show("请安装指纹仪驱动程序！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (readersCollection.Count == 0)
			{
				MessageBox.Show("没有检测到指纹仪！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			int num = readersCollection.Count - 1;
			int num2 = 0;
			if (num2 <= num)
			{
				this.ooo0o.ooo_ooO. = readersCollection[num2];
				oleDbCommand.CommandText = "select rg from [~TMPCLPFinger] where sn = '" + this.ooo0o.ooo_ooO..SerialNumber + "'";
				string text = "";
				oleDbConnection.Open();
				object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				oleDbConnection.Close();
				O_O.O0O_o o0O_o = new O_O.O0O_o();
				if (objectValue != null)
				{
					text = objectValue.ToString();
				}
				if (Operators.CompareString(text, "", true) == 0 || !o0O_o.linkfinger(this.ooo0o.ooo_ooO..SerialNumber, text))
				{
					o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002 o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u = new o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002();
					o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u.oOoOOO00.0_.().Text = this.ooo0o.ooo_ooO..SerialNumber;
					while (o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u.ShowDialog() != DialogResult.Cancel)
					{
						text = o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u.o._o0_Oo00_0.().Text.Trim();
						if (o0O_o.linkfinger(this.ooo0o.ooo_ooO..SerialNumber, text))
						{
							oleDbConnection.Open();
							oleDbCommand.CommandText = "Delete  from [~TMPCLPFinger] where sn = '" + this.ooo0o.ooo_ooO..SerialNumber + "'";
							oleDbCommand.ExecuteNonQuery();
							oleDbCommand.CommandText = string.Concat(new string[]
							{
								"Insert into [~TMPCLPFinger] (SN,RG) Values('",
								this.ooo0o.ooo_ooO..SerialNumber,
								"','",
								text,
								"')"
							});
							oleDbCommand.ExecuteNonQuery();
							oleDbConnection.Close();
							goto IL_306;
						}
						MessageBox.Show("请输入正确的激活码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					this.ooo0o.ooo_ooO. = null;
					return;
				}
				IL_306:
				this.O00._o. = new Capture(this.ooo0o.ooo_ooO..SerialNumber);
				if (this.O00._o. != null)
				{
					this.O00._o..EventHandler = this;
					this.O00._o..StartCapture();
				}
				this.O00._o. = true;
			}
			if (!this.O00._o.)
			{
				this.ooo0o.ooo_ooO. = null;
				MessageBox.Show("没有找到指定型号的指纹仪！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000C5CBC File Offset: 0x000C3EBC
		public void <<EMPTY_NAME>>()
		{
			if (this.O00._o. != null)
			{
				this.O00._o..StopCapture();
			}
			this.O00._o. = null;
			this.ooo0o.ooo_ooO. = null;
			this.O00._o. = false;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000C5CE8 File Offset: 0x000C3EE8
		public string <<EMPTY_NAME>>()
		{
			this.O__O.oo_Ooo. = true;
			if (this.O00._o. == null)
			{
				this.O00._o. = new Enrollment();
			}
			this.O00._o..Clear();
			o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020 o_u3000O_u3000_u3002o_u3002_u3000_u3000_u3002_u3002_u = new o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020();
			this.O00._o. = o_u3000O_u3000_u3002o_u3002_u3000_u3000_u3002_u3002_u;
			string result = "";
			if (o_u3000O_u3000_u3002o_u3002_u3000_u3000_u3002_u3002_u.ShowDialog() == DialogResult.OK)
			{
				byte[] inArray = new byte[101];
				this.O00._o..Template.Serialize(ref inArray);
				result = Convert.ToBase64String(inArray);
			}
			this.O00._o..Clear();
			this.O00._o..Close();
			this.O00._o. = null;
			this.O__O.oo_Ooo. = false;
			return result;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000C5D80 File Offset: 0x000C3F80
		public bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (this.ooo0o.ooo_ooO. == null)
			{
				this.ooo0o.ooo_ooO. = new Verification();
			}
			Verification.Result result = new Verification.Result();
			byte[] arrayOfBytes = Convert.FromBase64String(A_0);
			byte[] arrayOfBytes2 = Convert.FromBase64String(A_1);
			Template template = new Template();
			FeatureSet featureSet = new FeatureSet();
			template.DeSerialize(arrayOfBytes);
			featureSet.DeSerialize(arrayOfBytes2);
			this.ooo0o.ooo_ooO..Verify(featureSet, template, ref result);
			return result.Verified;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000C5DE6 File Offset: 0x000C3FE6
		public bool <<EMPTY_NAME>>()
		{
			return this.O00._o.;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x000C5DF0 File Offset: 0x000C3FF0
		public string <<EMPTY_NAME>>()
		{
			string result;
			if (this.o0o.O_.())
			{
				result = this.ooo0o.ooo_ooO..SerialNumber;
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000C5E1C File Offset: 0x000C401C
		protected Bitmap <<EMPTY_NAME>>(Sample A_0)
		{
			SampleConversion sampleConversion = new SampleConversion();
			Bitmap result = null;
			sampleConversion.ConvertToPicture(A_0, ref result);
			return result;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000C5E3C File Offset: 0x000C403C
		protected FeatureSet <<EMPTY_NAME>>(Sample A_0, DataPurpose A_1, ref CaptureFeedback A_2)
		{
			FeatureExtraction featureExtraction = new FeatureExtraction();
			FeatureSet featureSet = new FeatureSet();
			featureExtraction.CreateFeatureSet(A_0, A_1, ref A_2, ref featureSet);
			FeatureSet result;
			if (A_2 == CaptureFeedback.Good)
			{
				result = featureSet;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000C5E6C File Offset: 0x000C406C
		public void <<EMPTY_NAME>>(object A_0, string A_1, Sample A_2)
		{
			if (this.O__O.oo_Ooo.)
			{
				Bitmap original = this.OOO_.00.(A_2);
				PictureBox pictureBox = this.O00._o..oOOoOO._.();
				pictureBox.Image = new Bitmap(original, pictureBox.Size);
				CaptureFeedback captureFeedback = CaptureFeedback.None;
				FeatureSet featureSet = this.o0o.O_.(A_2, DataPurpose.Enrollment, ref captureFeedback);
				if (featureSet != null)
				{
					try
					{
						this.O00._o..AddFeatures(featureSet);
						this.O00._o..oO.oo__0O. = this.O00._o..oO.oo__0O. + 1;
						string name = Enum.GetName(typeof(CaptureFeedback), captureFeedback);
						if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
						{
							OO_00oOO.BaseMainForm.Invoke(new O_o_o0O(this.OOO0OO0.o_o.), new object[]
							{
								name
							});
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("指纹模板采集失败！", "提示", MessageBoxButtons.OK);
						return;
					}
					Enrollment.Status templateStatus = this.O00._o..TemplateStatus;
					if (templateStatus == Enrollment.Status.Failed)
					{
						this.O00._o..DialogResult = DialogResult.Cancel;
						return;
					}
					if (templateStatus == Enrollment.Status.Ready)
					{
						this.O00._o..DialogResult = DialogResult.OK;
						return;
					}
				}
			}
			else
			{
				CaptureFeedback captureFeedback2 = CaptureFeedback.None;
				FeatureSet featureSet2 = this.o0o.O_.(A_2, DataPurpose.Verification, ref captureFeedback2);
				if (featureSet2 != null)
				{
					byte[] inArray = new byte[101];
					featureSet2.Serialize(ref inArray);
					string text = Convert.ToBase64String(inArray);
					if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
					{
						OO_00oOO.BaseMainForm.Invoke(new oO_0OoO(this.o0o.O_.), new object[]
						{
							text,
							A_2
						});
					}
				}
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000C6000 File Offset: 0x000C4200
		private void <<EMPTY_NAME>>(string A_0, Sample A_1)
		{
			FingerCaptureEventArgs fingerCaptureEventArgs = new FingerCaptureEventArgs(A_0, A_1);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FingerCapture", new object[]
			{
				fingerCaptureEventArgs
			}, false, "项目", false);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000C6036 File Offset: 0x000C4236
		private void <<EMPTY_NAME>>(string A_0)
		{
			this.O00._o..O_oO_0._0o.().Text = A_0;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000C6049 File Offset: 0x000C4249
		private void <<EMPTY_NAME>>(string A_0)
		{
			this.O00._o..oo__0O.OOoo.().Text = A_0;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000C605C File Offset: 0x000C425C
		public void <<EMPTY_NAME>>(object A_0, string A_1)
		{
			if (this.O__O.oo_Ooo. && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new O_o_o0O(this.O00._o.), new object[]
				{
					"手指离开"
				});
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000C60AC File Offset: 0x000C42AC
		public void <<EMPTY_NAME>>(object A_0, string A_1)
		{
			if (this.O__O.oo_Ooo. && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new O_o_o0O(this.O00._o.), new object[]
				{
					"手指接触"
				});
			}
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000C60F9 File Offset: 0x000C42F9
		public void <<EMPTY_NAME>>(object A_0, string A_1)
		{
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000C60FB File Offset: 0x000C42FB
		public void <<EMPTY_NAME>>(object A_0, string A_1)
		{
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000C60FD File Offset: 0x000C42FD
		public void <<EMPTY_NAME>>(object A_0, string A_1, CaptureFeedback A_2)
		{
		}

		// Token: 0x04000C28 RID: 3112
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000C29 RID: 3113
		private Capture <<EMPTY_NAME>>;

		// Token: 0x04000C2A RID: 3114
		private ReaderDescription <<EMPTY_NAME>>;

		// Token: 0x04000C2B RID: 3115
		private Enrollment <<EMPTY_NAME>>;

		// Token: 0x04000C2C RID: 3116
		private Verification <<EMPTY_NAME>>;

		// Token: 0x04000C2D RID: 3117
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000C2E RID: 3118
		private o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020 <<EMPTY_NAME>>;

		// Token: 0x0200025F RID: 607
		private class O0O_o
		{
			// Token: 0x06001CC1 RID: 7361 RVA: 0x000C6108 File Offset: 0x000C4308
			internal bool linkfinger(string sn, string rg)
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
					IL_09:
					num2 = 3;
					this.Oo_00._o0oo_. = sn;
					IL_12:
					num2 = 4;
					this.OoO0._0O__o. = Strings.Left(this.Oo_00._o0oo_., 4);
					IL_26:
					num2 = 5;
					this.Ooo_OoOO.o0o. = Strings.Right(this.Oo_00._o0oo_., 4);
					IL_3A:
					num2 = 6;
					this.O0O0O00.o00_. = O00.EncryptText(this.Oo_00._o0oo_., this.OoO0._0O__o., this.Ooo_OoOO.o0o.);
					IL_59:
					num2 = 7;
					this.O0O0O00.o00_. = O00.ooo000o_0.00o0.(this.O0O0O00.o00_., this.OoO0._0O__o., this.Ooo_OoOO.o0o.);
					IL_78:
					num2 = 8;
					this.O0O0O00.o00_. = o_o_O0OO_0__.o000oOoo.0.(this.Oo_00._o0oo_.);
					IL_8B:
					num2 = 9;
					this.Oo_00._o0oo_. = this.O0O0O00.o00_..ToCharArray();
					IL_9F:
					num2 = 10;
					this.oo_._O. = rg;
					IL_A9:
					num2 = 11;
					this.oo_._O. = this.oo_._O..Replace("-", "");
					IL_C7:
					num2 = 12;
					if (this.oo_._O..Length != 16)
					{
						goto IL_310;
					}
					IL_DC:
					num2 = 13;
					int num3 = 0;
					do
					{
						IL_E2:
						num2 = 14;
						this.Oo_00._o0oo_. = (int)this.Oo_00._o0oo_.[num3];
						IL_F4:
						num2 = 15;
						this.o._Oo__. = (int)this.Oo_00._o0oo_.[num3 + 15];
						IL_109:
						num2 = 16;
						this.o__O0O_.o_. += Conversions.ToString((this.Oo_00._o0oo_. + this.o._Oo__.) % 10);
						IL_132:
						num2 = 17;
						num3++;
					}
					while (num3 <= 15);
					IL_141:
					num2 = 18;
					this.OO0O_0.o_. = Conversions.ToInteger(this.o__O0O_.o_..Substring(0, 4));
					IL_15C:
					num2 = 19;
					this.o_o__.0O_0. = Conversions.ToInteger(this.o__O0O_.o_..Substring(4, 4));
					IL_177:
					num2 = 20;
					this.oOO.OoO0o. = Conversions.ToInteger(this.o__O0O_.o_..Substring(8, 4));
					IL_192:
					num2 = 21;
					this.o.0__0_0o0o. = Conversions.ToInteger(this.o__O0O_.o_..Substring(12, 4));
					IL_1AE:
					num2 = 22;
					this.oo__oO_.o0O_o_. = Conversions.ToInteger(this.oo_._O..Substring(0, 4));
					IL_1C9:
					num2 = 23;
					this.o.o00o. = Conversions.ToInteger(this.oo_._O..Substring(4, 4));
					IL_1E4:
					num2 = 24;
					this.o0._OO__. = Conversions.ToInteger(this.oo_._O..Substring(8, 4));
					IL_1FF:
					num2 = 25;
					this.O.o0_OO_O0o. = Conversions.ToInteger(this.oo_._O..Substring(12, 4));
					IL_21B:
					num2 = 26;
					if ((this.oo__oO_.o0O_o_. ^ this.o_o__.0O_0.) == this.OO0O_0.o_. || (this.oo__oO_.o0O_o_. + 10000 ^ this.o_o__.0O_0.) == this.OO0O_0.o_.)
					{
						goto IL_258;
					}
					IL_24E:
					num2 = 27;
					result = false;
					goto IL_315;
					IL_258:
					num2 = 28;
					if ((this.o.o00o. ^ this.o_o__.0O_0.) == this.oo__oO_.o0O_o_. || (this.o.o00o. + 10000 ^ this.o_o__.0O_0.) == this.oo__oO_.o0O_o_.)
					{
						goto IL_295;
					}
					IL_28B:
					num2 = 29;
					result = false;
					goto IL_315;
					IL_295:
					num2 = 30;
					if ((this.o0._OO__. ^ this.oOO.OoO0o.) == this.o.o00o. || (this.o0._OO__. + 10000 ^ this.oOO.OoO0o.) == this.o.o00o.)
					{
						goto IL_2CF;
					}
					IL_2C8:
					num2 = 31;
					result = false;
					goto IL_315;
					IL_2CF:
					num2 = 32;
					if (this.O.o0_OO_O0o. == this.o.0__0_0o0o. + this.oOO.OoO0o. || this.O.o0_OO_O0o. + 9999 == this.o.0__0_0o0o. + this.oOO.OoO0o.)
					{
						goto IL_309;
					}
					IL_302:
					num2 = 33;
					result = false;
					goto IL_315;
					IL_309:
					num2 = 34;
					result = true;
					goto IL_315;
					IL_310:
					num2 = 36;
					result = false;
					IL_315:
					goto IL_3FB;
					IL_31A:
					int num4 = num5 + 1;
					num5 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
					IL_3BC:
					goto IL_3F0;
					IL_3BE:
					num5 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_3CE:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_3BE;
				}
				IL_3F0:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_3FB:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x04000C2F RID: 3119
			private string <<EMPTY_NAME>>;

			// Token: 0x04000C30 RID: 3120
			private string <<EMPTY_NAME>>;

			// Token: 0x04000C31 RID: 3121
			private string <<EMPTY_NAME>>;

			// Token: 0x04000C32 RID: 3122
			private string <<EMPTY_NAME>>;

			// Token: 0x04000C33 RID: 3123
			private string <<EMPTY_NAME>>;

			// Token: 0x04000C34 RID: 3124
			private char[] <<EMPTY_NAME>>;

			// Token: 0x04000C35 RID: 3125
			private string <<EMPTY_NAME>>;

			// Token: 0x04000C36 RID: 3126
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C37 RID: 3127
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C38 RID: 3128
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C39 RID: 3129
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C3A RID: 3130
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C3B RID: 3131
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C3C RID: 3132
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C3D RID: 3133
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C3E RID: 3134
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C3F RID: 3135
			private int <<EMPTY_NAME>>;

			// Token: 0x04000C40 RID: 3136
			private string <<EMPTY_NAME>>;
		}
	}
}

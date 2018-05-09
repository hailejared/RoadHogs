using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RoadHogs
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private IContainer components;

		private virtual Button bttnAccept
		{
			get
			{
				stackVariable1 = this._bttnAccept;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bttnAccept_Click);
				Button button = this._bttnAccept;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._bttnAccept = value;
				button = this._bttnAccept;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button bttnAdult
		{
			get
			{
				stackVariable1 = this._bttnAdult;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bttnAdult_Click);
				Button button = this._bttnAdult;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._bttnAdult = value;
				button = this._bttnAdult;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button bttnChild
		{
			get
			{
				stackVariable1 = this._bttnChild;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bttnChild_Click);
				Button button = this._bttnChild;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._bttnChild = value;
				button = this._bttnChild;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button bttnDelete
		{
			get
			{
				stackVariable1 = this._bttnDelete;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bttnDelete_Click);
				Button button = this._bttnDelete;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._bttnDelete = value;
				button = this._bttnDelete;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button bttnFamily
		{
			get
			{
				stackVariable1 = this._bttnFamily;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bttnFamily_Click);
				Button button = this._bttnFamily;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._bttnFamily = value;
				button = this._bttnFamily;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button bttnMiscellaneous
		{
			get
			{
				stackVariable1 = this._bttnMiscellaneous;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bttnMiscellaneous_Click);
				Button button = this._bttnMiscellaneous;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._bttnMiscellaneous = value;
				button = this._bttnMiscellaneous;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button Button1
		{
			get
			{
				stackVariable1 = this._Button1;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button button2
		{
			get
			{
				stackVariable1 = this._button2;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.button2_Click);
				Button button = this._button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._button2 = value;
				button = this._button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button button3
		{
			get
			{
				stackVariable1 = this._button3;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.button3_Click);
				Button button = this._button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._button3 = value;
				button = this._button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual Button Button4
		{
			get
			{
				stackVariable1 = this._Button4;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		private virtual CheckBox checkBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label Label2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label Label4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label Label6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label Label7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label lblEarnings
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label lblIncludes01
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label lblIncludes02
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label lblTodaysEarnings
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label lblTotal
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual Label LblTotalDollars
		{
			get
			{
				stackVariable1 = this._LblTotalDollars;
				return stackVariable1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LblTotalDollars_Click);
				Label label = this._LblTotalDollars;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._LblTotalDollars = value;
				label = this._LblTotalDollars;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		private virtual ListBox lstbox01
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		private virtual ListBox lstbox02
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Panel Panel1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual PictureBox PictureBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual RadioButton rbCash
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual RadioButton rbEftpos
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public Form1()
		{
			base.Load += new EventHandler(this.Form1_Load);
			this.InitializeComponent();
		}

		private void bttnAccept_Click(object sender, EventArgs e)
		{
			decimal num = Conversions.ToDecimal(this.LblTotalDollars.Text);
			if (Interaction.MsgBox("Are you sure you want to add this to the record?", MsgBoxStyle.YesNo, "Road Hogs") == MsgBoxResult.Yes)
			{
				this.lblEarnings.Text = Conversions.ToString(Conversions.ToDouble(this.lblEarnings.Text) + Convert.ToDouble(num));
				this.LblTotalDollars.Text = Conversions.ToString(0);
				this.checkBox1.Checked = false;
				this.lstbox02.Items.AddRange(this.lstbox01.Items);
				this.lstbox01.Items.Clear();
			}
		}

		private void bttnAdult_Click(object sender, EventArgs e)
		{
			decimal num = new decimal((long)10);
			decimal num1 = new decimal((long)5);
			if (this.rbEftpos.Checked)
			{
				if (!this.checkBox1.Checked)
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
					this.lstbox01.Items.Add("$10.00    Adult    Eftpos");
				}
				else
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num1));
					this.lstbox01.Items.Add("$5.00    Adult    Eftpos");
				}
			}
			else if (this.rbCash.Checked)
			{
				if (!this.checkBox1.Checked)
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
					this.lstbox01.Items.Add("$10.00    Adult    Cash");
				}
				else
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num1));
					this.lstbox01.Items.Add("$5.00    Adult    Cash");
				}
			}
		}

		private void bttnChild_Click(object sender, EventArgs e)
		{
			decimal num = new decimal((long)5);
			decimal num1 = new decimal(25, 0, 0, false, 1);
			if (this.rbEftpos.Checked)
			{
				if (!this.checkBox1.Checked)
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
					this.lstbox01.Items.Add("$5.00    Child    Eftpos");
				}
				else
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num1));
					this.lstbox01.Items.Add("$2.50    Child    Eftpos");
				}
			}
			else if (this.rbCash.Checked)
			{
				if (!this.checkBox1.Checked)
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
					this.lstbox01.Items.Add("$5.00    Child    Cash");
				}
				else
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num1));
					this.lstbox01.Items.Add("$2.50    Child    Cash");
				}
			}
		}

		private void bttnDelete_Click(object sender, EventArgs e)
		{
			this.lstbox01.Items.Clear();
			this.LblTotalDollars.Text = Conversions.ToString(0);
		}

		private void bttnFamily_Click(object sender, EventArgs e)
		{
			decimal num = new decimal((long)28);
			decimal num1 = new decimal((long)14);
			if (this.rbEftpos.Checked)
			{
				if (!this.checkBox1.Checked)
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
					this.lstbox01.Items.Add("$28.00    Family    Eftpos");
				}
				else
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num1));
					this.lstbox01.Items.Add("$14.00    Family    Eftpos");
				}
			}
			else if (this.rbCash.Checked)
			{
				if (!this.checkBox1.Checked)
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
					this.lstbox01.Items.Add("$28.00    Family    Cash");
				}
				else
				{
					this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num1));
					this.lstbox01.Items.Add("$14.00    Family    Cash");
				}
			}
		}

		private void bttnMiscellaneous_Click(object sender, EventArgs e)
		{
			decimal num = Conversions.ToDecimal(Interaction.InputBox("Enter a Number", "", "", -1, -1));
			if (!Versioned.IsNumeric(num))
			{
				Interaction.MsgBox("Numeric values allowed only.", MsgBoxStyle.OkOnly, null);
			}
			else if (this.rbEftpos.Checked)
			{
				this.lstbox01.Items.Add(string.Concat("$", Conversions.ToString(num), "    Misc    Eftpos"));
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
			}
			else if (this.rbCash.Checked)
			{
				this.lstbox01.Items.Add(string.Concat("$", Conversions.ToString(num), "    Misc    Cash"));
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			decimal num = new decimal((long)4);
			if (this.rbEftpos.Checked)
			{
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
				this.lstbox01.Items.Add("$4.00    Beverage    Eftpos");
			}
			else if (this.rbCash.Checked)
			{
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
				this.lstbox01.Items.Add("$4.00    Beverage    Cash");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			decimal num = new decimal((long)3);
			if (this.rbEftpos.Checked)
			{
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
				this.lstbox01.Items.Add("$3.00    Beverage    Eftpos");
			}
			else if (this.rbCash.Checked)
			{
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
				this.lstbox01.Items.Add("$3.00    Beverage    Cash");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			decimal num = new decimal((long)2);
			if (this.rbEftpos.Checked)
			{
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
				this.lstbox01.Items.Add("$2.00    Beverage    Eftpos");
			}
			else if (this.rbCash.Checked)
			{
				this.LblTotalDollars.Text = Conversions.ToString(Conversions.ToDouble(this.LblTotalDollars.Text) + Convert.ToDouble(num));
				this.lstbox01.Items.Add("$2.00    Beverage    Cash");
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("'Close Day' will save today's record and close the program.", MsgBoxStyle.OkCancel, "Road Hogs") == MsgBoxResult.Ok)
			{
				StreamWriter streamWriter = new StreamWriter("c:\\RoadHogs\\Records.txt", true);
				int count = checked(this.lstbox02.Items.Count - 1);
				for (int i = 0; i <= count; i = checked(i + 1))
				{
					streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(this.lstbox02.Items[i]));
				}
				streamWriter.Close();
				base.Close();
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			this.lstbox01.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstbox01.SelectedItem));
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((!disposing ? false : this.components != null))
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ListBox.ObjectCollection items = this.lstbox02.Items;
			DateTime now = DateTime.Now;
			items.Add(now.ToString("d"));
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.bttnDelete = new Button();
			this.LblTotalDollars = new Label();
			this.lblTotal = new Label();
			this.bttnAccept = new Button();
			this.checkBox1 = new CheckBox();
			this.lblEarnings = new Label();
			this.lblTodaysEarnings = new Label();
			this.bttnMiscellaneous = new Button();
			this.lstbox01 = new ListBox();
			this.lblIncludes02 = new Label();
			this.lblIncludes01 = new Label();
			this.button3 = new Button();
			this.button2 = new Button();
			this.bttnFamily = new Button();
			this.bttnChild = new Button();
			this.bttnAdult = new Button();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.lstbox02 = new ListBox();
			this.Button4 = new Button();
			this.rbEftpos = new RadioButton();
			this.rbCash = new RadioButton();
			this.Label4 = new Label();
			this.PictureBox1 = new PictureBox();
			this.Label5 = new Label();
			this.Label6 = new Label();
			this.Panel1 = new Panel();
			this.Button1 = new Button();
			this.Label7 = new Label();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.bttnDelete.BackColor = Color.Tomato;
			this.bttnDelete.Cursor = Cursors.Hand;
			this.bttnDelete.FlatStyle = FlatStyle.Popup;
			this.bttnDelete.Font = new System.Drawing.Font("Candara", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bttnDelete.ForeColor = Color.Black;
			this.bttnDelete.Location = new Point(290, 494);
			this.bttnDelete.Name = "bttnDelete";
			this.bttnDelete.Size = new System.Drawing.Size(93, 32);
			this.bttnDelete.TabIndex = 59;
			this.bttnDelete.Text = "Clear All";
			this.bttnDelete.UseVisualStyleBackColor = false;
			this.LblTotalDollars.Font = new System.Drawing.Font("Candara", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.LblTotalDollars.ForeColor = Color.White;
			this.LblTotalDollars.Location = new Point(358, 460);
			this.LblTotalDollars.Name = "LblTotalDollars";
			this.LblTotalDollars.Size = new System.Drawing.Size(87, 29);
			this.LblTotalDollars.TabIndex = 58;
			this.LblTotalDollars.Text = "0";
			this.lblTotal.Font = new System.Drawing.Font("Candara", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTotal.ForeColor = Color.White;
			this.lblTotal.Location = new Point(285, 460);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(67, 36);
			this.lblTotal.TabIndex = 57;
			this.lblTotal.Text = "Total:";
			this.bttnAccept.BackColor = Color.LightSteelBlue;
			this.bttnAccept.Cursor = Cursors.Hand;
			this.bttnAccept.FlatStyle = FlatStyle.Popup;
			this.bttnAccept.Font = new System.Drawing.Font("Candara", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bttnAccept.Location = new Point(405, 494);
			this.bttnAccept.Name = "bttnAccept";
			this.bttnAccept.Size = new System.Drawing.Size(168, 32);
			this.bttnAccept.TabIndex = 56;
			this.bttnAccept.Text = "Accept";
			this.bttnAccept.UseVisualStyleBackColor = false;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Cursor = Cursors.Hand;
			this.checkBox1.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.checkBox1.ForeColor = Color.White;
			this.checkBox1.Location = new Point(14, 37);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 27);
			this.checkBox1.TabIndex = 55;
			this.checkBox1.Text = "2nd Round Half Price";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.lblEarnings.Font = new System.Drawing.Font("Candara", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblEarnings.ForeColor = Color.White;
			this.lblEarnings.Location = new Point(413, 16);
			this.lblEarnings.Name = "lblEarnings";
			this.lblEarnings.Size = new System.Drawing.Size(169, 47);
			this.lblEarnings.TabIndex = 54;
			this.lblEarnings.Text = "0";
			this.lblTodaysEarnings.Font = new System.Drawing.Font("Candara", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTodaysEarnings.ForeColor = Color.White;
			this.lblTodaysEarnings.Location = new Point(128, 16);
			this.lblTodaysEarnings.Name = "lblTodaysEarnings";
			this.lblTodaysEarnings.Size = new System.Drawing.Size(261, 47);
			this.lblTodaysEarnings.TabIndex = 53;
			this.lblTodaysEarnings.Text = "Today's Earnings:";
			this.bttnMiscellaneous.BackColor = Color.SandyBrown;
			this.bttnMiscellaneous.Cursor = Cursors.Hand;
			this.bttnMiscellaneous.FlatStyle = FlatStyle.Popup;
			this.bttnMiscellaneous.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bttnMiscellaneous.Location = new Point(14, 579);
			this.bttnMiscellaneous.Name = "bttnMiscellaneous";
			this.bttnMiscellaneous.Size = new System.Drawing.Size(142, 62);
			this.bttnMiscellaneous.TabIndex = 52;
			this.bttnMiscellaneous.Text = "Miscellaneous";
			this.bttnMiscellaneous.UseVisualStyleBackColor = false;
			this.lstbox01.BackColor = Color.LightGray;
			this.lstbox01.BorderStyle = BorderStyle.FixedSingle;
			this.lstbox01.Font = new System.Drawing.Font("Candara", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lstbox01.FormattingEnabled = true;
			this.lstbox01.ItemHeight = 26;
			this.lstbox01.Location = new Point(290, 138);
			this.lstbox01.Name = "lstbox01";
			this.lstbox01.Size = new System.Drawing.Size(283, 314);
			this.lstbox01.TabIndex = 51;
			this.lblIncludes02.Font = new System.Drawing.Font("Candara", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblIncludes02.ForeColor = Color.White;
			this.lblIncludes02.Location = new Point(128, 431);
			this.lblIncludes02.Name = "lblIncludes02";
			this.lblIncludes02.Size = new System.Drawing.Size(108, 67);
			this.lblIncludes02.TabIndex = 50;
			this.lblIncludes02.Text = "Lift+, Keri, Water";
			this.lblIncludes01.Font = new System.Drawing.Font("Candara", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblIncludes01.ForeColor = Color.White;
			this.lblIncludes01.Location = new Point(128, 363);
			this.lblIncludes01.Name = "lblIncludes01";
			this.lblIncludes01.Size = new System.Drawing.Size(120, 65);
			this.lblIncludes01.TabIndex = 48;
			this.lblIncludes01.Text = "Coke, Sprite, Zero, L&&P";
			this.button3.BackColor = Color.LightGreen;
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatStyle = FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.Location = new Point(14, 363);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(108, 62);
			this.button3.TabIndex = 47;
			this.button3.Text = "$2 Beverage";
			this.button3.UseVisualStyleBackColor = false;
			this.button2.BackColor = Color.LightGreen;
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatStyle = FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.Location = new Point(14, 431);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 62);
			this.button2.TabIndex = 46;
			this.button2.Text = "$3 Beverage";
			this.button2.UseVisualStyleBackColor = false;
			this.bttnFamily.BackColor = Color.LightSteelBlue;
			this.bttnFamily.Cursor = Cursors.Hand;
			this.bttnFamily.FlatStyle = FlatStyle.Popup;
			this.bttnFamily.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bttnFamily.Location = new Point(14, 281);
			this.bttnFamily.Name = "bttnFamily";
			this.bttnFamily.Size = new System.Drawing.Size(81, 62);
			this.bttnFamily.TabIndex = 44;
			this.bttnFamily.Text = "Family $28";
			this.bttnFamily.UseVisualStyleBackColor = false;
			this.bttnChild.BackColor = Color.LightSteelBlue;
			this.bttnChild.Cursor = Cursors.Hand;
			this.bttnChild.FlatStyle = FlatStyle.Popup;
			this.bttnChild.Font = new System.Drawing.Font("Candara", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bttnChild.Location = new Point(14, 213);
			this.bttnChild.Name = "bttnChild";
			this.bttnChild.Size = new System.Drawing.Size(81, 62);
			this.bttnChild.TabIndex = 43;
			this.bttnChild.Text = "Child/ Student $5";
			this.bttnChild.UseVisualStyleBackColor = false;
			this.bttnAdult.BackColor = Color.LightSteelBlue;
			this.bttnAdult.Cursor = Cursors.Hand;
			this.bttnAdult.FlatStyle = FlatStyle.Popup;
			this.bttnAdult.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bttnAdult.Location = new Point(14, 145);
			this.bttnAdult.Name = "bttnAdult";
			this.bttnAdult.Size = new System.Drawing.Size(81, 62);
			this.bttnAdult.TabIndex = 42;
			this.bttnAdult.Text = "Adult $10";
			this.bttnAdult.UseVisualStyleBackColor = false;
			this.Label1.Font = new System.Drawing.Font("Candara", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label1.ForeColor = Color.White;
			this.Label1.Location = new Point(101, 294);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(87, 65);
			this.Label1.TabIndex = 60;
			this.Label1.Text = "2 Adults      + 2 Children";
			this.Label2.Font = new System.Drawing.Font("Candara", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label2.ForeColor = Color.White;
			this.Label2.Location = new Point(342, 460);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(22, 29);
			this.Label2.TabIndex = 61;
			this.Label2.Text = "$";
			this.Label3.Font = new System.Drawing.Font("Candara", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label3.ForeColor = Color.White;
			this.Label3.Location = new Point(382, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 47);
			this.Label3.TabIndex = 62;
			this.Label3.Text = "$";
			this.lstbox02.BackColor = Color.DimGray;
			this.lstbox02.BorderStyle = BorderStyle.None;
			this.lstbox02.Font = new System.Drawing.Font("Candara", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lstbox02.ForeColor = Color.White;
			this.lstbox02.FormattingEnabled = true;
			this.lstbox02.ItemHeight = 26;
			this.lstbox02.Location = new Point(599, 138);
			this.lstbox02.Name = "lstbox02";
			this.lstbox02.Size = new System.Drawing.Size(283, 312);
			this.lstbox02.TabIndex = 63;
			this.Button4.BackColor = Color.PaleGreen;
			this.Button4.Cursor = Cursors.Hand;
			this.Button4.FlatStyle = FlatStyle.Popup;
			this.Button4.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Button4.Location = new Point(599, 494);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(283, 32);
			this.Button4.TabIndex = 64;
			this.Button4.Text = "Save Record - Exit";
			this.Button4.UseVisualStyleBackColor = false;
			this.rbEftpos.AutoSize = true;
			this.rbEftpos.Checked = true;
			this.rbEftpos.Cursor = Cursors.Hand;
			this.rbEftpos.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.rbEftpos.ForeColor = Color.White;
			this.rbEftpos.Location = new Point(14, 70);
			this.rbEftpos.Name = "rbEftpos";
			this.rbEftpos.Size = new System.Drawing.Size(81, 27);
			this.rbEftpos.TabIndex = 66;
			this.rbEftpos.TabStop = true;
			this.rbEftpos.Text = "Eftpos";
			this.rbEftpos.UseVisualStyleBackColor = true;
			this.rbCash.AutoSize = true;
			this.rbCash.Cursor = Cursors.Hand;
			this.rbCash.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.rbCash.ForeColor = Color.White;
			this.rbCash.Location = new Point(14, 103);
			this.rbCash.Name = "rbCash";
			this.rbCash.Size = new System.Drawing.Size(65, 27);
			this.rbCash.TabIndex = 67;
			this.rbCash.Text = "Cash";
			this.rbCash.UseVisualStyleBackColor = true;
			this.Label4.Font = new System.Drawing.Font("Candara", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label4.ForeColor = Color.White;
			this.Label4.Location = new Point(823, 112);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(62, 23);
			this.Label4.TabIndex = 68;
			this.Label4.Text = "Record";
			this.PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new Point(405, -1);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(386, 111);
			this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 69;
			this.PictureBox1.TabStop = false;
			this.Label5.Font = new System.Drawing.Font("Candara", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label5.ForeColor = Color.White;
			this.Label5.Location = new Point(101, 226);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(147, 52);
			this.Label5.TabIndex = 70;
			this.Label5.Text = "Ages 17 and under/or student ID";
			this.Label6.Font = new System.Drawing.Font("Candara", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label6.ForeColor = Color.White;
			this.Label6.Location = new Point(101, 155);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(87, 52);
			this.Label6.TabIndex = 71;
			this.Label6.Text = "Ages 18 and over";
			this.Panel1.BackColor = Color.CornflowerBlue;
			this.Panel1.Controls.Add(this.lblTodaysEarnings);
			this.Panel1.Controls.Add(this.lblEarnings);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Location = new Point(290, 565);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(592, 76);
			this.Panel1.TabIndex = 72;
			this.Button1.BackColor = Color.LightGreen;
			this.Button1.Cursor = Cursors.Hand;
			this.Button1.FlatStyle = FlatStyle.Popup;
			this.Button1.Font = new System.Drawing.Font("Candara", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Button1.Location = new Point(14, 499);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(108, 62);
			this.Button1.TabIndex = 73;
			this.Button1.Text = "$4 Beverage";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label7.Font = new System.Drawing.Font("Candara", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label7.ForeColor = Color.White;
			this.Label7.Location = new Point(128, 502);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(120, 65);
			this.Label7.TabIndex = 74;
			this.Label7.Text = "GingerBeer, Most, Powerade";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.SteelBlue;
			base.ClientSize = new System.Drawing.Size(897, 655);
			base.ControlBox = false;
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.rbCash);
			base.Controls.Add(this.rbEftpos);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.lstbox02);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.bttnDelete);
			base.Controls.Add(this.LblTotalDollars);
			base.Controls.Add(this.lblTotal);
			base.Controls.Add(this.bttnAccept);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.bttnMiscellaneous);
			base.Controls.Add(this.lstbox01);
			base.Controls.Add(this.lblIncludes02);
			base.Controls.Add(this.lblIncludes01);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.bttnFamily);
			base.Controls.Add(this.bttnChild);
			base.Controls.Add(this.bttnAdult);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Road Hogs";
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void LblTotalDollars_Click(object sender, EventArgs e)
		{
		}
	}
}
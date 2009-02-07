using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace Cage
{
	/// <summary>
	/// Form1 の概要の説明です。
	/// </summary>
	public class about : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelNET;
		private System.Windows.Forms.Label labelSys;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel_url;
		private System.Windows.Forms.Label labelMem;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabelHay2;
		private System.Windows.Forms.LinkLabel linkLabelLame;
		private System.Windows.Forms.LinkLabel linkLabelVorbis;
		private System.Windows.Forms.ToolTip toolTip;
		private System.ComponentModel.IContainer components;

		public about()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(about));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabelVorbis = new System.Windows.Forms.LinkLabel();
			this.linkLabelLame = new System.Windows.Forms.LinkLabel();
			this.linkLabelHay2 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.labelMem = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelSys = new System.Windows.Forms.Label();
			this.labelNET = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.linkLabel_url = new System.Windows.Forms.LinkLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.linkLabelVorbis);
			this.groupBox1.Controls.Add(this.linkLabelLame);
			this.groupBox1.Controls.Add(this.linkLabelHay2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.labelMem);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.labelSys);
			this.groupBox1.Controls.Add(this.labelNET);
			this.groupBox1.Controls.Add(this.labelVersion);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(-4, -8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(282, 292);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// linkLabelVorbis
			// 
			this.linkLabelVorbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabelVorbis.AutoSize = true;
			this.linkLabelVorbis.Location = new System.Drawing.Point(36, 204);
			this.linkLabelVorbis.Name = "linkLabelVorbis";
			this.linkLabelVorbis.Size = new System.Drawing.Size(59, 17);
			this.linkLabelVorbis.TabIndex = 10;
			this.linkLabelVorbis.TabStop = true;
			this.linkLabelVorbis.Text = "Ogg Vorbis";
			this.linkLabelVorbis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVorbis_LinkClicked);
			// 
			// linkLabelLame
			// 
			this.linkLabelLame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabelLame.AutoSize = true;
			this.linkLabelLame.Location = new System.Drawing.Point(36, 184);
			this.linkLabelLame.Name = "linkLabelLame";
			this.linkLabelLame.Size = new System.Drawing.Size(31, 17);
			this.linkLabelLame.TabIndex = 9;
			this.linkLabelLame.TabStop = true;
			this.linkLabelLame.Text = "Lame";
			this.linkLabelLame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLame_LinkClicked);
			// 
			// linkLabelHay2
			// 
			this.linkLabelHay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabelHay2.AutoSize = true;
			this.linkLabelHay2.Location = new System.Drawing.Point(36, 164);
			this.linkLabelHay2.Name = "linkLabelHay2";
			this.linkLabelHay2.Size = new System.Drawing.Size(156, 17);
			this.linkLabelHay2.TabIndex = 5;
			this.linkLabelHay2.TabStop = true;
			this.linkLabelHay2.Text = "BmsWave速波II (thanks nikq)";
			this.toolTip.SetToolTip(this.linkLabelHay2, "実はまだ許可とってない……。");
			this.linkLabelHay2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHay2_LinkClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Powered by";
			// 
			// labelMem
			// 
			this.labelMem.AutoSize = true;
			this.labelMem.Location = new System.Drawing.Point(20, 228);
			this.labelMem.Name = "labelMem";
			this.labelMem.Size = new System.Drawing.Size(29, 17);
			this.labelMem.TabIndex = 7;
			this.labelMem.Text = "mem";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Copyright 2004 nulltask.";
			// 
			// labelSys
			// 
			this.labelSys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelSys.AutoSize = true;
			this.labelSys.Location = new System.Drawing.Point(20, 248);
			this.labelSys.Name = "labelSys";
			this.labelSys.Size = new System.Drawing.Size(37, 17);
			this.labelSys.TabIndex = 4;
			this.labelSys.Text = "winver";
			// 
			// labelNET
			// 
			this.labelNET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNET.AutoSize = true;
			this.labelNET.Location = new System.Drawing.Point(20, 268);
			this.labelNET.Name = "labelNET";
			this.labelNET.Size = new System.Drawing.Size(131, 17);
			this.labelNET.TabIndex = 3;
			this.labelNET.Text = ".NET Framework Version ";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Location = new System.Drawing.Point(24, 104);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(45, 17);
			this.labelVersion.TabIndex = 2;
			this.labelVersion.Text = "Version ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cage";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 276);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(208, 292);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			// 
			// linkLabel_url
			// 
			this.linkLabel_url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel_url.AutoSize = true;
			this.linkLabel_url.Location = new System.Drawing.Point(12, 300);
			this.linkLabel_url.Name = "linkLabel_url";
			this.linkLabel_url.Size = new System.Drawing.Size(112, 17);
			this.linkLabel_url.TabIndex = 4;
			this.linkLabel_url.TabStop = true;
			this.linkLabel_url.Text = "Visit nulltask website.";
			this.linkLabel_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_url_LinkClicked);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 250;
			this.toolTip.ReshowDelay = 100;
			// 
			// about
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(274, 327);
			this.Controls.Add(this.linkLabel_url);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "about";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		bool p = false;
		Thread t;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			labelNET.Text += System.Environment.Version.ToString();
			labelSys.Text = System.Environment.OSVersion.ToString();
			long mem = (System.Environment.WorkingSet / 1024);
			labelMem.Text = "Using " + mem.ToString() + " KB";

			this.Opacity = 0.99;
			this.Opacity = 1;
			button1.Focus();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			long mem = (System.Environment.WorkingSet / 1024);
			labelMem.Text = "Using " + mem.ToString() + " KB";
		}

		private void toomee()
		{
			p = true;
			while(true)
			{
				for(int i = 100; i > 35; i--)
				{
					this.Opacity = (double)i / 100;
					Thread.Sleep(25);
				}
				Thread.Sleep(500);
				for(int i = 35; i < 100; i++)
				{
					this.Opacity = (double)i / 100;
					Thread.Sleep(25);
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_MouseEnter(object sender, System.EventArgs e)
		{
			if(p == true)
				return;
			t = new Thread(new ThreadStart(toomee));
			t.IsBackground = true;
			t.Start();
		}

		private void linkLabel_url_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.ms/");
		}

		private void linkLabelHay2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://nikq.nothing.sh/");
		}

		private void linkLabelLame_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://lame.sourceforge.net/");
		}

		private void linkLabelVorbis_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.vorbis.com/");
		}
	}
}

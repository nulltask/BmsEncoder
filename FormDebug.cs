using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;    // for StreamWriter
using System.Text;  // for Encoding

namespace Cage
{
	/// <summary>
	/// FormDebug の概要の説明です。
	/// </summary>
	public class FormDebug : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBoxDbgMsg;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormDebug()
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
				if(components != null)
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
			this.textBoxDbgMsg = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxDbgMsg
			// 
			this.textBoxDbgMsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBoxDbgMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDbgMsg.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.textBoxDbgMsg.Location = new System.Drawing.Point(0, 0);
			this.textBoxDbgMsg.MaxLength = 2147483647;
			this.textBoxDbgMsg.Multiline = true;
			this.textBoxDbgMsg.Name = "textBoxDbgMsg";
			this.textBoxDbgMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxDbgMsg.Size = new System.Drawing.Size(394, 275);
			this.textBoxDbgMsg.TabIndex = 0;
			this.textBoxDbgMsg.Text = "";
			// 
			// FormDebug
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(394, 275);
			this.Controls.Add(this.textBoxDbgMsg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormDebug";
			this.ShowInTaskbar = false;
			this.Text = "Debug";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		public void SendDebugMessage(string p, string message)
		{
			textBoxDbgMsg.AppendText(System.DateTime.Now.ToString() + " : " + p + " > " + message + "\r\n");
		}
	}
}

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
	/// FormDebug �̊T�v�̐����ł��B
	/// </summary>
	public class FormDebug : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBoxDbgMsg;
		/// <summary>
		/// �K�v�ȃf�U�C�i�ϐ��ł��B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormDebug()
		{
			//
			// Windows �t�H�[�� �f�U�C�i �T�|�[�g�ɕK�v�ł��B
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent �Ăяo���̌�ɁA�R���X�g���N�^ �R�[�h��ǉ����Ă��������B
			//
		}

		/// <summary>
		/// �g�p����Ă��郊�\�[�X�Ɍ㏈�������s���܂��B
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

		#region Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h 
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
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
			this.textBoxDbgMsg.Font = new System.Drawing.Font("�l�r �S�V�b�N", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
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

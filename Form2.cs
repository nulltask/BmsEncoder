using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace Cage
{
	/// <summary>
	/// Form2 の概要の説明です。
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.HScrollBar hScrollBarVorQBValue;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox checkBoxMP3nspsytune;
		private System.Windows.Forms.ComboBox comboBoxMP3Bit;
		private System.Windows.Forms.ComboBox comboBoxMP3Stereo;
		private System.Windows.Forms.ComboBox comboBoxMP3q;
		private System.Windows.Forms.ComboBox comboBoxVorBit;
		private System.Windows.Forms.CheckBox checkBoxMP3ABRForceMinBit;
		private System.Windows.Forms.ComboBox comboBoxMP3ABRMinBit;
		private System.Windows.Forms.ComboBox comboBoxMP3ABRMaxBit;
		private System.Windows.Forms.ComboBox comboBoxMP3ABRBit;
		private System.Windows.Forms.ComboBox comboBoxMP3VBRq;
		private System.Windows.Forms.ComboBox comboBoxMP3VBRPreset;
		private System.Windows.Forms.ComboBox comboBoxMP3VBRMinBit;
		private System.Windows.Forms.CheckBox checkBoxMP3VBRUsePreset;
		private System.Windows.Forms.ComboBox comboBoxMP3VBRMaxBit;
		private System.Windows.Forms.ComboBox comboBoxMP3VBRMethod;
		private System.Windows.Forms.ComboBox comboBoxMP3CBRPreset;
		private System.Windows.Forms.ComboBox comboBoxMP3CBRBit;
		private System.Windows.Forms.CheckBox checkBoxMP3CBRUsePreset;
		private System.Windows.Forms.Button buttonSelectOutPath;
		private System.Windows.Forms.TextBox textBoxOutPath;
		private System.Windows.Forms.RadioButton radioButtonOutDefault;
		private System.Windows.Forms.RadioButton radioButtonOutBMSFolder;
		private System.Windows.Forms.RadioButton radioButtonOutSelected;
		private System.Windows.Forms.CheckBox checkBoxArtistFolder;
		private System.Windows.Forms.ComboBox comboBoxFormat;
		private System.Windows.Forms.CheckBox checkBoxTagging;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ComboBox comboBoxVorCBRBit;
		private System.Windows.Forms.ComboBox comboBoxVorABRBit;
		private System.Windows.Forms.ComboBox comboBoxVorABRMinBit;
		private System.Windows.Forms.ComboBox comboBoxVorABRMaxBit;
		private System.Windows.Forms.TextBox textBoxVorQValue;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox comboBoxMP3Hz;
		private System.Windows.Forms.ComboBox comboBoxVorHz;
		private System.Windows.Forms.ComboBox comboBoxMP3ABRPreset;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPageConfig;
		private System.Windows.Forms.TabPage tabPageMP3;
		private System.Windows.Forms.TabPage tabPageVor;
		private System.Windows.Forms.TabControl tabControlMP3;
		private System.Windows.Forms.TabPage tabPageMP3CBR;
		private System.Windows.Forms.TabPage tabPageMP3VBR;
		private System.Windows.Forms.TabPage tabPageMP3ABR;
		private System.Windows.Forms.TabControl tabControlVor;
		private System.Windows.Forms.TabPage tabPageVorQB;
		private System.Windows.Forms.TabPage tabPageVorABR;
		private System.Windows.Forms.TabPage tabPageVorCBR;
		private System.Windows.Forms.TabPage tabPageWAV;
		private System.Windows.Forms.ComboBox comboBoxWAVEng;
		private System.Windows.Forms.Label label25;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.TabControl tabControlConfig;
		private System.Windows.Forms.TabPage tabPageConfigOut;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TabPage tabPageWAVB2W;
		private System.Windows.Forms.ComboBox comboBoxWAVB2WBit;
		private System.Windows.Forms.ComboBox comboBoxWAVB2WChannel;
		private System.Windows.Forms.CheckBox checkBoxMP3Cmd;
		private System.Windows.Forms.CheckBox checkBoxVorCmd;
		private System.Windows.Forms.CheckBox checkBoxWAVB2WCmd;
		private System.Windows.Forms.TabPage tabPageFileName;
		private System.Windows.Forms.CheckBox checkBoxDeleteDif;
		private System.Windows.Forms.TrackBar trackBarDropTrans;
		private System.Windows.Forms.ComboBox comboBoxWAVB2WHz;
		private System.Windows.Forms.CheckBox checkBoxMP3VBRForceMinBit;
		private System.Windows.Forms.CheckBox checkBoxMP3ABRUsePreset;
		private System.Windows.Forms.TextBox textBoxMP3LowpassValue;
		private System.Windows.Forms.CheckBox checkBoxMP3Lowpass;
		private System.Windows.Forms.TextBox textBoxVorLowpassValue;
		private System.Windows.Forms.CheckBox checkBoxVorLowpass;
		private System.Windows.Forms.CheckBox checkBoxWAVB2WForce;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.NumericUpDown numericUpDownMP3ABRPresetBit;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TabPage tabPagePlus;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ComboBox comboBoxMP3ABRBitDummy;
		private System.Windows.Forms.ComboBox comboBoxMP3ABRMinBitDummy;
		private System.Windows.Forms.ComboBox comboBoxMP3ABRMaxBitDummy;
		private System.Windows.Forms.Label labeltrackBarDropTransValue;
		private System.Windows.Forms.TextBox textBoxWinampPath;
		private System.Windows.Forms.Button buttonWinampPath;
		private System.Windows.Forms.CheckBox checkBoxAdd2Winamp;
		private System.Windows.Forms.CheckBox checkBoxFade;
		private System.Windows.Forms.CheckBox checkBoxVorDownmix;
		private System.Windows.Forms.RadioButton radioButtonA_T;
		private System.Windows.Forms.RadioButton radioButtonT_A;
		private System.Windows.Forms.RadioButton radioButtonT;
		private System.Windows.Forms.RadioButton radioButtonC;
		private System.Windows.Forms.TextBox textBoxCFilename;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.TabPage tabPageHay2;
		private System.Windows.Forms.ComboBox comboBoxWAVHay2Hz;
		private System.Windows.Forms.ComboBox comboBoxWAVHay2Bit;
		private System.Windows.Forms.ComboBox comboBoxWAVHay2PCMMethod;
		private System.Windows.Forms.HScrollBar hScrollBarWAVHay2Vol;
		private System.Windows.Forms.HScrollBar hScrollBarWAVB2WVol;
		private System.Windows.Forms.Label labelWAVHay2Vol;
		private System.Windows.Forms.Label labelWAVB2WVol;
		private System.Windows.Forms.CheckBox checkBoxWAVHay2Inverse;
		private System.Windows.Forms.CheckBox checkBoxWAVHay2FixMixing;
		private System.Windows.Forms.CheckBox checkBoxWAVHay2CutSilence;
		private System.Windows.Forms.CheckBox checkBoxWAVHay2WhiteNoise;
		private System.Windows.Forms.TabControl tabControlWAVE;
		private System.Windows.Forms.ComboBox comboBoxWAVHay2Channel;
		private System.Windows.Forms.Label labelVorbisBitrate;
		private System.Windows.Forms.CheckBox checkBoxWAVB2WChk;

		public Form2()
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

		#region GetPrivateProfileString宣言部分

		/// <summary>
		/// ini ファイルの読み込み用の関数(GetPrivateProfileString)の宣言部分
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="GetPrivateProfileString")]
		private static extern uint GetPrivateProfileString( string lpApplicationName, string lpEntryName, string lpDefault, System.Text.StringBuilder lpReturnedString, uint nSize, string lpFileName ); 

		/// <summary>
		/// ini ファイルの書き込み用の関数(WritePrivateProfileString)の宣言部分
		/// </summary>
		[DllImport("kernel32.dll", EntryPoint="WritePrivateProfileString")]
		private static extern uint WritePrivateProfileString( string lpApplicationName, string lpEntryName, string lpEntryString, string lpFileName );

		#endregion

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageConfig = new System.Windows.Forms.TabPage();
			this.labeltrackBarDropTransValue = new System.Windows.Forms.Label();
			this.tabControlConfig = new System.Windows.Forms.TabControl();
			this.tabPageConfigOut = new System.Windows.Forms.TabPage();
			this.textBoxOutPath = new System.Windows.Forms.TextBox();
			this.radioButtonOutDefault = new System.Windows.Forms.RadioButton();
			this.radioButtonOutBMSFolder = new System.Windows.Forms.RadioButton();
			this.radioButtonOutSelected = new System.Windows.Forms.RadioButton();
			this.checkBoxArtistFolder = new System.Windows.Forms.CheckBox();
			this.buttonSelectOutPath = new System.Windows.Forms.Button();
			this.tabPageFileName = new System.Windows.Forms.TabPage();
			this.textBoxCFilename = new System.Windows.Forms.TextBox();
			this.radioButtonA_T = new System.Windows.Forms.RadioButton();
			this.radioButtonT_A = new System.Windows.Forms.RadioButton();
			this.radioButtonT = new System.Windows.Forms.RadioButton();
			this.radioButtonC = new System.Windows.Forms.RadioButton();
			this.label21 = new System.Windows.Forms.Label();
			this.comboBoxFormat = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxTagging = new System.Windows.Forms.CheckBox();
			this.checkBoxDeleteDif = new System.Windows.Forms.CheckBox();
			this.trackBarDropTrans = new System.Windows.Forms.TrackBar();
			this.tabPageWAV = new System.Windows.Forms.TabPage();
			this.tabControlWAVE = new System.Windows.Forms.TabControl();
			this.tabPageWAVB2W = new System.Windows.Forms.TabPage();
			this.label37 = new System.Windows.Forms.Label();
			this.hScrollBarWAVB2WVol = new System.Windows.Forms.HScrollBar();
			this.labelWAVB2WVol = new System.Windows.Forms.Label();
			this.checkBoxWAVB2WCmd = new System.Windows.Forms.CheckBox();
			this.comboBoxWAVB2WHz = new System.Windows.Forms.ComboBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.comboBoxWAVB2WBit = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.comboBoxWAVB2WChannel = new System.Windows.Forms.ComboBox();
			this.checkBoxWAVB2WChk = new System.Windows.Forms.CheckBox();
			this.checkBoxWAVB2WForce = new System.Windows.Forms.CheckBox();
			this.tabPageHay2 = new System.Windows.Forms.TabPage();
			this.label35 = new System.Windows.Forms.Label();
			this.hScrollBarWAVHay2Vol = new System.Windows.Forms.HScrollBar();
			this.checkBoxWAVHay2Inverse = new System.Windows.Forms.CheckBox();
			this.checkBoxWAVHay2FixMixing = new System.Windows.Forms.CheckBox();
			this.checkBoxWAVHay2CutSilence = new System.Windows.Forms.CheckBox();
			this.comboBoxWAVHay2Hz = new System.Windows.Forms.ComboBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.comboBoxWAVHay2Bit = new System.Windows.Forms.ComboBox();
			this.label33 = new System.Windows.Forms.Label();
			this.comboBoxWAVHay2Channel = new System.Windows.Forms.ComboBox();
			this.comboBoxWAVHay2PCMMethod = new System.Windows.Forms.ComboBox();
			this.label34 = new System.Windows.Forms.Label();
			this.checkBoxWAVHay2WhiteNoise = new System.Windows.Forms.CheckBox();
			this.labelWAVHay2Vol = new System.Windows.Forms.Label();
			this.comboBoxWAVEng = new System.Windows.Forms.ComboBox();
			this.label25 = new System.Windows.Forms.Label();
			this.tabPageMP3 = new System.Windows.Forms.TabPage();
			this.tabControlMP3 = new System.Windows.Forms.TabControl();
			this.tabPageMP3CBR = new System.Windows.Forms.TabPage();
			this.comboBoxMP3CBRPreset = new System.Windows.Forms.ComboBox();
			this.comboBoxMP3CBRBit = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxMP3CBRUsePreset = new System.Windows.Forms.CheckBox();
			this.tabPageMP3VBR = new System.Windows.Forms.TabPage();
			this.comboBoxMP3VBRq = new System.Windows.Forms.ComboBox();
			this.comboBoxMP3VBRPreset = new System.Windows.Forms.ComboBox();
			this.comboBoxMP3VBRMinBit = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBoxMP3VBRUsePreset = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxMP3VBRMaxBit = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBoxMP3VBRMethod = new System.Windows.Forms.ComboBox();
			this.checkBoxMP3VBRForceMinBit = new System.Windows.Forms.CheckBox();
			this.tabPageMP3ABR = new System.Windows.Forms.TabPage();
			this.comboBoxMP3ABRMaxBitDummy = new System.Windows.Forms.ComboBox();
			this.comboBoxMP3ABRMinBitDummy = new System.Windows.Forms.ComboBox();
			this.comboBoxMP3ABRBitDummy = new System.Windows.Forms.ComboBox();
			this.numericUpDownMP3ABRPresetBit = new System.Windows.Forms.NumericUpDown();
			this.comboBoxMP3ABRPreset = new System.Windows.Forms.ComboBox();
			this.checkBoxMP3ABRUsePreset = new System.Windows.Forms.CheckBox();
			this.comboBoxMP3ABRMaxBit = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBoxMP3ABRBit = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.checkBoxMP3ABRForceMinBit = new System.Windows.Forms.CheckBox();
			this.comboBoxMP3ABRMinBit = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.textBoxMP3LowpassValue = new System.Windows.Forms.TextBox();
			this.checkBoxMP3nspsytune = new System.Windows.Forms.CheckBox();
			this.comboBoxMP3Bit = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxMP3Stereo = new System.Windows.Forms.ComboBox();
			this.checkBoxMP3Lowpass = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxMP3q = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.comboBoxMP3Hz = new System.Windows.Forms.ComboBox();
			this.checkBoxMP3Cmd = new System.Windows.Forms.CheckBox();
			this.tabPageVor = new System.Windows.Forms.TabPage();
			this.checkBoxVorCmd = new System.Windows.Forms.CheckBox();
			this.label24 = new System.Windows.Forms.Label();
			this.comboBoxVorHz = new System.Windows.Forms.ComboBox();
			this.tabControlVor = new System.Windows.Forms.TabControl();
			this.tabPageVorQB = new System.Windows.Forms.TabPage();
			this.labelVorbisBitrate = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textBoxVorQValue = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.hScrollBarVorQBValue = new System.Windows.Forms.HScrollBar();
			this.tabPageVorABR = new System.Windows.Forms.TabPage();
			this.comboBoxVorABRMinBit = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.comboBoxVorABRMaxBit = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.comboBoxVorABRBit = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.tabPageVorCBR = new System.Windows.Forms.TabPage();
			this.label20 = new System.Windows.Forms.Label();
			this.comboBoxVorCBRBit = new System.Windows.Forms.ComboBox();
			this.textBoxVorLowpassValue = new System.Windows.Forms.TextBox();
			this.checkBoxVorLowpass = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.comboBoxVorBit = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.checkBoxVorDownmix = new System.Windows.Forms.CheckBox();
			this.tabPagePlus = new System.Windows.Forms.TabPage();
			this.textBoxWinampPath = new System.Windows.Forms.TextBox();
			this.buttonWinampPath = new System.Windows.Forms.Button();
			this.checkBoxAdd2Winamp = new System.Windows.Forms.CheckBox();
			this.checkBoxFade = new System.Windows.Forms.CheckBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.errorProvider = new System.Windows.Forms.ErrorProvider();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tabControlMain.SuspendLayout();
			this.tabPageConfig.SuspendLayout();
			this.tabControlConfig.SuspendLayout();
			this.tabPageConfigOut.SuspendLayout();
			this.tabPageFileName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarDropTrans)).BeginInit();
			this.tabPageWAV.SuspendLayout();
			this.tabControlWAVE.SuspendLayout();
			this.tabPageWAVB2W.SuspendLayout();
			this.tabPageHay2.SuspendLayout();
			this.tabPageMP3.SuspendLayout();
			this.tabControlMP3.SuspendLayout();
			this.tabPageMP3CBR.SuspendLayout();
			this.tabPageMP3VBR.SuspendLayout();
			this.tabPageMP3ABR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMP3ABRPresetBit)).BeginInit();
			this.tabPageVor.SuspendLayout();
			this.tabControlVor.SuspendLayout();
			this.tabPageVorQB.SuspendLayout();
			this.tabPageVorABR.SuspendLayout();
			this.tabPageVorCBR.SuspendLayout();
			this.tabPagePlus.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMain.Controls.Add(this.tabPageConfig);
			this.tabControlMain.Controls.Add(this.tabPageWAV);
			this.tabControlMain.Controls.Add(this.tabPageMP3);
			this.tabControlMain.Controls.Add(this.tabPageVor);
			this.tabControlMain.Controls.Add(this.tabPagePlus);
			this.tabControlMain.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControlMain.Location = new System.Drawing.Point(12, 12);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(500, 268);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPageConfig
			// 
			this.tabPageConfig.Controls.Add(this.labeltrackBarDropTransValue);
			this.tabPageConfig.Controls.Add(this.tabControlConfig);
			this.tabPageConfig.Controls.Add(this.label21);
			this.tabPageConfig.Controls.Add(this.comboBoxFormat);
			this.tabPageConfig.Controls.Add(this.label1);
			this.tabPageConfig.Controls.Add(this.checkBoxTagging);
			this.tabPageConfig.Controls.Add(this.checkBoxDeleteDif);
			this.tabPageConfig.Controls.Add(this.trackBarDropTrans);
			this.tabPageConfig.Location = new System.Drawing.Point(4, 21);
			this.tabPageConfig.Name = "tabPageConfig";
			this.tabPageConfig.Size = new System.Drawing.Size(492, 243);
			this.tabPageConfig.TabIndex = 0;
			this.tabPageConfig.Text = "基本設定";
			// 
			// labeltrackBarDropTransValue
			// 
			this.labeltrackBarDropTransValue.Location = new System.Drawing.Point(212, 108);
			this.labeltrackBarDropTransValue.Name = "labeltrackBarDropTransValue";
			this.labeltrackBarDropTransValue.Size = new System.Drawing.Size(24, 16);
			this.labeltrackBarDropTransValue.TabIndex = 6;
			this.labeltrackBarDropTransValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labeltrackBarDropTransValue.Visible = false;
			// 
			// tabControlConfig
			// 
			this.tabControlConfig.Controls.Add(this.tabPageConfigOut);
			this.tabControlConfig.Controls.Add(this.tabPageFileName);
			this.tabControlConfig.Location = new System.Drawing.Point(252, 12);
			this.tabControlConfig.Name = "tabControlConfig";
			this.tabControlConfig.SelectedIndex = 0;
			this.tabControlConfig.Size = new System.Drawing.Size(228, 220);
			this.tabControlConfig.TabIndex = 0;
			// 
			// tabPageConfigOut
			// 
			this.tabPageConfigOut.Controls.Add(this.textBoxOutPath);
			this.tabPageConfigOut.Controls.Add(this.radioButtonOutDefault);
			this.tabPageConfigOut.Controls.Add(this.radioButtonOutBMSFolder);
			this.tabPageConfigOut.Controls.Add(this.radioButtonOutSelected);
			this.tabPageConfigOut.Controls.Add(this.checkBoxArtistFolder);
			this.tabPageConfigOut.Controls.Add(this.buttonSelectOutPath);
			this.tabPageConfigOut.Location = new System.Drawing.Point(4, 21);
			this.tabPageConfigOut.Name = "tabPageConfigOut";
			this.tabPageConfigOut.Size = new System.Drawing.Size(220, 195);
			this.tabPageConfigOut.TabIndex = 0;
			this.tabPageConfigOut.Text = "出力先";
			// 
			// textBoxOutPath
			// 
			this.textBoxOutPath.Location = new System.Drawing.Point(24, 84);
			this.textBoxOutPath.Name = "textBoxOutPath";
			this.textBoxOutPath.Size = new System.Drawing.Size(160, 19);
			this.textBoxOutPath.TabIndex = 3;
			this.textBoxOutPath.Text = "";
			// 
			// radioButtonOutDefault
			// 
			this.radioButtonOutDefault.Cursor = System.Windows.Forms.Cursors.Default;
			this.radioButtonOutDefault.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonOutDefault.Location = new System.Drawing.Point(8, 16);
			this.radioButtonOutDefault.Name = "radioButtonOutDefault";
			this.radioButtonOutDefault.Size = new System.Drawing.Size(200, 16);
			this.radioButtonOutDefault.TabIndex = 0;
			this.radioButtonOutDefault.Text = "デフォルト (..本体の場所/@output)";
			this.toolTip.SetToolTip(this.radioButtonOutDefault, "デフォルトの出力先に保存されます。");
			this.radioButtonOutDefault.CheckedChanged += new System.EventHandler(this.radioButtonOutDefault_CheckedChanged);
			// 
			// radioButtonOutBMSFolder
			// 
			this.radioButtonOutBMSFolder.Cursor = System.Windows.Forms.Cursors.Default;
			this.radioButtonOutBMSFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonOutBMSFolder.Location = new System.Drawing.Point(8, 40);
			this.radioButtonOutBMSFolder.Name = "radioButtonOutBMSFolder";
			this.radioButtonOutBMSFolder.Size = new System.Drawing.Size(200, 16);
			this.radioButtonOutBMSFolder.TabIndex = 1;
			this.radioButtonOutBMSFolder.Text = "BMSと同じ場所";
			this.toolTip.SetToolTip(this.radioButtonOutBMSFolder, "BMSファイルと同じ場所に保存されます。");
			this.radioButtonOutBMSFolder.CheckedChanged += new System.EventHandler(this.radioButtonOutBMSFolder_CheckedChanged);
			// 
			// radioButtonOutSelected
			// 
			this.radioButtonOutSelected.Cursor = System.Windows.Forms.Cursors.Default;
			this.radioButtonOutSelected.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonOutSelected.Location = new System.Drawing.Point(8, 64);
			this.radioButtonOutSelected.Name = "radioButtonOutSelected";
			this.radioButtonOutSelected.Size = new System.Drawing.Size(200, 16);
			this.radioButtonOutSelected.TabIndex = 2;
			this.radioButtonOutSelected.Text = "任意の場所";
			this.toolTip.SetToolTip(this.radioButtonOutSelected, "ユーザが選択した場所に保存されます。");
			this.radioButtonOutSelected.CheckedChanged += new System.EventHandler(this.radioButtonOutSelected_CheckedChanged);
			// 
			// checkBoxArtistFolder
			// 
			this.checkBoxArtistFolder.Cursor = System.Windows.Forms.Cursors.Default;
			this.checkBoxArtistFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxArtistFolder.Location = new System.Drawing.Point(8, 112);
			this.checkBoxArtistFolder.Name = "checkBoxArtistFolder";
			this.checkBoxArtistFolder.Size = new System.Drawing.Size(200, 16);
			this.checkBoxArtistFolder.TabIndex = 5;
			this.checkBoxArtistFolder.Text = "作者ごとにフォルダ分けをする";
			this.toolTip.SetToolTip(this.checkBoxArtistFolder, "作者ごとにフォルダわけをします。");
			// 
			// buttonSelectOutPath
			// 
			this.buttonSelectOutPath.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonSelectOutPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonSelectOutPath.Location = new System.Drawing.Point(188, 84);
			this.buttonSelectOutPath.Name = "buttonSelectOutPath";
			this.buttonSelectOutPath.Size = new System.Drawing.Size(20, 19);
			this.buttonSelectOutPath.TabIndex = 4;
			this.buttonSelectOutPath.Text = "...";
			this.toolTip.SetToolTip(this.buttonSelectOutPath, "クリックで保存先を決定します。");
			this.buttonSelectOutPath.Click += new System.EventHandler(this.buttonSelectOutPath_Click);
			// 
			// tabPageFileName
			// 
			this.tabPageFileName.Controls.Add(this.textBoxCFilename);
			this.tabPageFileName.Controls.Add(this.radioButtonA_T);
			this.tabPageFileName.Controls.Add(this.radioButtonT_A);
			this.tabPageFileName.Controls.Add(this.radioButtonT);
			this.tabPageFileName.Controls.Add(this.radioButtonC);
			this.tabPageFileName.Location = new System.Drawing.Point(4, 21);
			this.tabPageFileName.Name = "tabPageFileName";
			this.tabPageFileName.Size = new System.Drawing.Size(220, 195);
			this.tabPageFileName.TabIndex = 1;
			this.tabPageFileName.Text = "ファイル名";
			// 
			// textBoxCFilename
			// 
			this.textBoxCFilename.Location = new System.Drawing.Point(20, 108);
			this.textBoxCFilename.Name = "textBoxCFilename";
			this.textBoxCFilename.Size = new System.Drawing.Size(188, 19);
			this.textBoxCFilename.TabIndex = 6;
			this.textBoxCFilename.Text = "";
			this.textBoxCFilename.Visible = false;
			// 
			// radioButtonA_T
			// 
			this.radioButtonA_T.Cursor = System.Windows.Forms.Cursors.Default;
			this.radioButtonA_T.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonA_T.Location = new System.Drawing.Point(8, 16);
			this.radioButtonA_T.Name = "radioButtonA_T";
			this.radioButtonA_T.Size = new System.Drawing.Size(200, 16);
			this.radioButtonA_T.TabIndex = 3;
			this.radioButtonA_T.Text = "作曲者 - タイトル";
			this.toolTip.SetToolTip(this.radioButtonA_T, "例 : Yamajet - (^^).mp3");
			// 
			// radioButtonT_A
			// 
			this.radioButtonT_A.Cursor = System.Windows.Forms.Cursors.Default;
			this.radioButtonT_A.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonT_A.Location = new System.Drawing.Point(8, 40);
			this.radioButtonT_A.Name = "radioButtonT_A";
			this.radioButtonT_A.Size = new System.Drawing.Size(200, 16);
			this.radioButtonT_A.TabIndex = 4;
			this.radioButtonT_A.Text = "タイトル - 作曲者";
			this.toolTip.SetToolTip(this.radioButtonT_A, "例 : (^^) - Yamajet.mp3");
			// 
			// radioButtonT
			// 
			this.radioButtonT.Cursor = System.Windows.Forms.Cursors.Default;
			this.radioButtonT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonT.Location = new System.Drawing.Point(8, 64);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new System.Drawing.Size(200, 16);
			this.radioButtonT.TabIndex = 5;
			this.radioButtonT.Text = "タイトル";
			this.toolTip.SetToolTip(this.radioButtonT, "例 : (^^).mp3");
			// 
			// radioButtonC
			// 
			this.radioButtonC.Cursor = System.Windows.Forms.Cursors.Default;
			this.radioButtonC.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonC.Location = new System.Drawing.Point(8, 88);
			this.radioButtonC.Name = "radioButtonC";
			this.radioButtonC.Size = new System.Drawing.Size(200, 16);
			this.radioButtonC.TabIndex = 5;
			this.radioButtonC.Text = "カスタム";
			this.toolTip.SetToolTip(this.radioButtonC, "ユーザが選択した場所に保存されます。");
			this.radioButtonC.Visible = false;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(12, 88);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(223, 15);
			this.label21.TabIndex = 4;
			this.label21.Text = "ドロップゾーンの透過度 (Win2k/XP/2k3のみ)";
			this.label21.Visible = false;
			// 
			// comboBoxFormat
			// 
			this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFormat.Items.AddRange(new object[] {
																"WAVE",
																"MP3",
																"Ogg Vorbis"});
			this.comboBoxFormat.Location = new System.Drawing.Point(76, 12);
			this.comboBoxFormat.Name = "comboBoxFormat";
			this.comboBoxFormat.Size = new System.Drawing.Size(164, 20);
			this.comboBoxFormat.TabIndex = 1;
			this.toolTip.SetToolTip(this.comboBoxFormat, "変換形式を選択してください。\n\nWAVE … 無圧縮PCM音声。音質の劣化はありませんがファイルサイズが非常に大きいです。\nMP3 … 最も有名で汎用性のある不可" +
				"逆音声圧縮形式。\nOgg Vorbis … MP3と比較すると特に低ビットレート(96Kbps以下)に強く全体的に音質が良いと言われている不可逆圧縮音声形式。");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "変換形式";
			// 
			// checkBoxTagging
			// 
			this.checkBoxTagging.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxTagging.Location = new System.Drawing.Point(12, 40);
			this.checkBoxTagging.Name = "checkBoxTagging";
			this.checkBoxTagging.Size = new System.Drawing.Size(228, 16);
			this.checkBoxTagging.TabIndex = 2;
			this.checkBoxTagging.Text = "自動でタグをつける (MP3, Ogg Vorbis)";
			this.toolTip.SetToolTip(this.checkBoxTagging, "オプション有効でタグを付加します。");
			// 
			// checkBoxDeleteDif
			// 
			this.checkBoxDeleteDif.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxDeleteDif.Location = new System.Drawing.Point(12, 64);
			this.checkBoxDeleteDif.Name = "checkBoxDeleteDif";
			this.checkBoxDeleteDif.Size = new System.Drawing.Size(228, 16);
			this.checkBoxDeleteDif.TabIndex = 3;
			this.checkBoxDeleteDif.Text = "タグから難度表示等を除く";
			this.toolTip.SetToolTip(this.checkBoxDeleteDif, "タグから(7key)などの表示を取り除きます。");
			// 
			// trackBarDropTrans
			// 
			this.trackBarDropTrans.AutoSize = false;
			this.trackBarDropTrans.Cursor = System.Windows.Forms.Cursors.Default;
			this.trackBarDropTrans.Location = new System.Drawing.Point(12, 104);
			this.trackBarDropTrans.Maximum = 100;
			this.trackBarDropTrans.Minimum = 25;
			this.trackBarDropTrans.Name = "trackBarDropTrans";
			this.trackBarDropTrans.Size = new System.Drawing.Size(200, 20);
			this.trackBarDropTrans.TabIndex = 5;
			this.trackBarDropTrans.TickFrequency = 5;
			this.toolTip.SetToolTip(this.trackBarDropTrans, "ドロップゾーンの透過度をスライドで決定します。\n低くしすぎると見えなくなりますので注意。");
			this.trackBarDropTrans.Value = 100;
			this.trackBarDropTrans.Visible = false;
			this.trackBarDropTrans.Scroll += new System.EventHandler(this.trackBarDropTrans_Scroll);
			// 
			// tabPageWAV
			// 
			this.tabPageWAV.Controls.Add(this.tabControlWAVE);
			this.tabPageWAV.Controls.Add(this.comboBoxWAVEng);
			this.tabPageWAV.Controls.Add(this.label25);
			this.tabPageWAV.Location = new System.Drawing.Point(4, 21);
			this.tabPageWAV.Name = "tabPageWAV";
			this.tabPageWAV.Size = new System.Drawing.Size(492, 243);
			this.tabPageWAV.TabIndex = 3;
			this.tabPageWAV.Text = "WAVE変換設定";
			// 
			// tabControlWAVE
			// 
			this.tabControlWAVE.Controls.Add(this.tabPageWAVB2W);
			this.tabControlWAVE.Controls.Add(this.tabPageHay2);
			this.tabControlWAVE.Location = new System.Drawing.Point(252, 12);
			this.tabControlWAVE.Name = "tabControlWAVE";
			this.tabControlWAVE.SelectedIndex = 0;
			this.tabControlWAVE.Size = new System.Drawing.Size(228, 220);
			this.tabControlWAVE.TabIndex = 7;
			// 
			// tabPageWAVB2W
			// 
			this.tabPageWAVB2W.Controls.Add(this.label37);
			this.tabPageWAVB2W.Controls.Add(this.hScrollBarWAVB2WVol);
			this.tabPageWAVB2W.Controls.Add(this.labelWAVB2WVol);
			this.tabPageWAVB2W.Controls.Add(this.checkBoxWAVB2WCmd);
			this.tabPageWAVB2W.Controls.Add(this.comboBoxWAVB2WHz);
			this.tabPageWAVB2W.Controls.Add(this.label27);
			this.tabPageWAVB2W.Controls.Add(this.label28);
			this.tabPageWAVB2W.Controls.Add(this.comboBoxWAVB2WBit);
			this.tabPageWAVB2W.Controls.Add(this.label29);
			this.tabPageWAVB2W.Controls.Add(this.comboBoxWAVB2WChannel);
			this.tabPageWAVB2W.Controls.Add(this.checkBoxWAVB2WChk);
			this.tabPageWAVB2W.Controls.Add(this.checkBoxWAVB2WForce);
			this.tabPageWAVB2W.Location = new System.Drawing.Point(4, 21);
			this.tabPageWAVB2W.Name = "tabPageWAVB2W";
			this.tabPageWAVB2W.Size = new System.Drawing.Size(220, 195);
			this.tabPageWAVB2W.TabIndex = 0;
			this.tabPageWAVB2W.Text = "tjbms2wav";
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(8, 172);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(29, 15);
			this.label37.TabIndex = 22;
			this.label37.Text = "音量";
			// 
			// hScrollBarWAVB2WVol
			// 
			this.hScrollBarWAVB2WVol.Location = new System.Drawing.Point(44, 172);
			this.hScrollBarWAVB2WVol.Maximum = 300;
			this.hScrollBarWAVB2WVol.Minimum = 10;
			this.hScrollBarWAVB2WVol.Name = "hScrollBarWAVB2WVol";
			this.hScrollBarWAVB2WVol.Size = new System.Drawing.Size(140, 14);
			this.hScrollBarWAVB2WVol.TabIndex = 20;
			this.toolTip.SetToolTip(this.hScrollBarWAVB2WVol, "MP3とは違いqが大きいほど品質が向上します。");
			this.hScrollBarWAVB2WVol.Value = 50;
			this.hScrollBarWAVB2WVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarWAVB2WVol_Scroll);
			// 
			// labelWAVB2WVol
			// 
			this.labelWAVB2WVol.Location = new System.Drawing.Point(188, 172);
			this.labelWAVB2WVol.Name = "labelWAVB2WVol";
			this.labelWAVB2WVol.Size = new System.Drawing.Size(24, 16);
			this.labelWAVB2WVol.TabIndex = 21;
			this.labelWAVB2WVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBoxWAVB2WCmd
			// 
			this.checkBoxWAVB2WCmd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxWAVB2WCmd.Location = new System.Drawing.Point(8, 148);
			this.checkBoxWAVB2WCmd.Name = "checkBoxWAVB2WCmd";
			this.checkBoxWAVB2WCmd.Size = new System.Drawing.Size(200, 16);
			this.checkBoxWAVB2WCmd.TabIndex = 9;
			this.checkBoxWAVB2WCmd.Text = "プロンプトを表示する";
			this.toolTip.SetToolTip(this.checkBoxWAVB2WCmd, "DOSプロンプトを表示します。");
			// 
			// comboBoxWAVB2WHz
			// 
			this.comboBoxWAVB2WHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVB2WHz.Items.AddRange(new object[] {
																  "44,100 Hz",
																  "32,000 Hz",
																  "24,000 Hz",
																  "22,050 Hz",
																  "16,000 Hz",
																  "12,000 Hz",
																  "11,025 Hz",
																  "8,000 Hz"});
			this.comboBoxWAVB2WHz.Location = new System.Drawing.Point(100, 12);
			this.comboBoxWAVB2WHz.Name = "comboBoxWAVB2WHz";
			this.comboBoxWAVB2WHz.Size = new System.Drawing.Size(112, 20);
			this.comboBoxWAVB2WHz.TabIndex = 8;
			this.toolTip.SetToolTip(this.comboBoxWAVB2WHz, "高ければ高周波の音が出ます。\n低くする意味は無いかも。");
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(8, 16);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(87, 15);
			this.label27.TabIndex = 5;
			this.label27.Text = "サンプリングレート";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(8, 44);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(41, 15);
			this.label28.TabIndex = 5;
			this.label28.Text = "ビット数";
			// 
			// comboBoxWAVB2WBit
			// 
			this.comboBoxWAVB2WBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVB2WBit.Items.AddRange(new object[] {
																   "16 bit",
																   "8 bit"});
			this.comboBoxWAVB2WBit.Location = new System.Drawing.Point(64, 40);
			this.comboBoxWAVB2WBit.Name = "comboBoxWAVB2WBit";
			this.comboBoxWAVB2WBit.Size = new System.Drawing.Size(148, 20);
			this.comboBoxWAVB2WBit.TabIndex = 8;
			this.toolTip.SetToolTip(this.comboBoxWAVB2WBit, "8bitだと音にざらつきが生じます。");
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(8, 72);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(52, 15);
			this.label29.TabIndex = 5;
			this.label29.Text = "チャンネル";
			// 
			// comboBoxWAVB2WChannel
			// 
			this.comboBoxWAVB2WChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVB2WChannel.Items.AddRange(new object[] {
																	   "ステレオ",
																	   "モノラル"});
			this.comboBoxWAVB2WChannel.Location = new System.Drawing.Point(64, 68);
			this.comboBoxWAVB2WChannel.Name = "comboBoxWAVB2WChannel";
			this.comboBoxWAVB2WChannel.Size = new System.Drawing.Size(148, 20);
			this.comboBoxWAVB2WChannel.TabIndex = 8;
			this.toolTip.SetToolTip(this.comboBoxWAVB2WChannel, "ステレオかモノラルかを選択してください。");
			// 
			// checkBoxWAVB2WChk
			// 
			this.checkBoxWAVB2WChk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxWAVB2WChk.Location = new System.Drawing.Point(8, 100);
			this.checkBoxWAVB2WChk.Name = "checkBoxWAVB2WChk";
			this.checkBoxWAVB2WChk.Size = new System.Drawing.Size(200, 16);
			this.checkBoxWAVB2WChk.TabIndex = 9;
			this.checkBoxWAVB2WChk.Text = "拡張BMSをスキップ";
			this.toolTip.SetToolTip(this.checkBoxWAVB2WChk, "変換前に事前にBMSを解析してtjbms2wavが処理できるかどうか判断します。");
			// 
			// checkBoxWAVB2WForce
			// 
			this.checkBoxWAVB2WForce.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxWAVB2WForce.Location = new System.Drawing.Point(8, 124);
			this.checkBoxWAVB2WForce.Name = "checkBoxWAVB2WForce";
			this.checkBoxWAVB2WForce.Size = new System.Drawing.Size(200, 16);
			this.checkBoxWAVB2WForce.TabIndex = 9;
			this.checkBoxWAVB2WForce.Text = "強制変換 (非推薦)";
			this.toolTip.SetToolTip(this.checkBoxWAVB2WForce, "変換ができなさそうなBMSでも強制的に変換させます。");
			// 
			// tabPageHay2
			// 
			this.tabPageHay2.Controls.Add(this.label35);
			this.tabPageHay2.Controls.Add(this.hScrollBarWAVHay2Vol);
			this.tabPageHay2.Controls.Add(this.checkBoxWAVHay2Inverse);
			this.tabPageHay2.Controls.Add(this.checkBoxWAVHay2FixMixing);
			this.tabPageHay2.Controls.Add(this.checkBoxWAVHay2CutSilence);
			this.tabPageHay2.Controls.Add(this.comboBoxWAVHay2Hz);
			this.tabPageHay2.Controls.Add(this.label31);
			this.tabPageHay2.Controls.Add(this.label32);
			this.tabPageHay2.Controls.Add(this.comboBoxWAVHay2Bit);
			this.tabPageHay2.Controls.Add(this.label33);
			this.tabPageHay2.Controls.Add(this.comboBoxWAVHay2Channel);
			this.tabPageHay2.Controls.Add(this.comboBoxWAVHay2PCMMethod);
			this.tabPageHay2.Controls.Add(this.label34);
			this.tabPageHay2.Controls.Add(this.checkBoxWAVHay2WhiteNoise);
			this.tabPageHay2.Controls.Add(this.labelWAVHay2Vol);
			this.tabPageHay2.Location = new System.Drawing.Point(4, 21);
			this.tabPageHay2.Name = "tabPageHay2";
			this.tabPageHay2.Size = new System.Drawing.Size(220, 195);
			this.tabPageHay2.TabIndex = 2;
			this.tabPageHay2.Text = "BmsWave速波２";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(8, 172);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(29, 15);
			this.label35.TabIndex = 19;
			this.label35.Text = "音量";
			// 
			// hScrollBarWAVHay2Vol
			// 
			this.hScrollBarWAVHay2Vol.Location = new System.Drawing.Point(44, 172);
			this.hScrollBarWAVHay2Vol.Maximum = 300;
			this.hScrollBarWAVHay2Vol.Minimum = 10;
			this.hScrollBarWAVHay2Vol.Name = "hScrollBarWAVHay2Vol";
			this.hScrollBarWAVHay2Vol.Size = new System.Drawing.Size(140, 14);
			this.hScrollBarWAVHay2Vol.TabIndex = 18;
			this.toolTip.SetToolTip(this.hScrollBarWAVHay2Vol, "音量を選択してください。100でオリジナルの音量です。\n大抵の場合音割れが生じるので50-75の間にとどめてください。");
			this.hScrollBarWAVHay2Vol.Value = 50;
			this.hScrollBarWAVHay2Vol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarWAVHay2Vol_Scroll);
			// 
			// checkBoxWAVHay2Inverse
			// 
			this.checkBoxWAVHay2Inverse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxWAVHay2Inverse.Location = new System.Drawing.Point(8, 148);
			this.checkBoxWAVHay2Inverse.Name = "checkBoxWAVHay2Inverse";
			this.checkBoxWAVHay2Inverse.Size = new System.Drawing.Size(96, 16);
			this.checkBoxWAVHay2Inverse.TabIndex = 17;
			this.checkBoxWAVHay2Inverse.Text = "位相逆転";
			this.toolTip.SetToolTip(this.checkBoxWAVHay2Inverse, "位相を逆転します。");
			// 
			// checkBoxWAVHay2FixMixing
			// 
			this.checkBoxWAVHay2FixMixing.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxWAVHay2FixMixing.Location = new System.Drawing.Point(8, 124);
			this.checkBoxWAVHay2FixMixing.Name = "checkBoxWAVHay2FixMixing";
			this.checkBoxWAVHay2FixMixing.Size = new System.Drawing.Size(96, 16);
			this.checkBoxWAVHay2FixMixing.TabIndex = 16;
			this.checkBoxWAVHay2FixMixing.Text = "位相修正";
			this.toolTip.SetToolTip(this.checkBoxWAVHay2FixMixing, "位相の反転しているPCMを、左右を減算ミキシングすることで正しい位相に合わせます。\n出力が変な時は試してみてください。");
			// 
			// checkBoxWAVHay2CutSilence
			// 
			this.checkBoxWAVHay2CutSilence.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxWAVHay2CutSilence.Location = new System.Drawing.Point(112, 124);
			this.checkBoxWAVHay2CutSilence.Name = "checkBoxWAVHay2CutSilence";
			this.checkBoxWAVHay2CutSilence.Size = new System.Drawing.Size(98, 16);
			this.checkBoxWAVHay2CutSilence.TabIndex = 15;
			this.checkBoxWAVHay2CutSilence.Text = "無音カット";
			this.toolTip.SetToolTip(this.checkBoxWAVHay2CutSilence, "曲開始時の、無音区間を切り取ります。");
			// 
			// comboBoxWAVHay2Hz
			// 
			this.comboBoxWAVHay2Hz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVHay2Hz.Items.AddRange(new object[] {
																   "44,100 Hz",
																   "32,000 Hz",
																   "24,000 Hz",
																   "22,050 Hz",
																   "16,000 Hz",
																   "12,000 Hz",
																   "11,025 Hz",
																   "8,000 Hz"});
			this.comboBoxWAVHay2Hz.Location = new System.Drawing.Point(100, 12);
			this.comboBoxWAVHay2Hz.Name = "comboBoxWAVHay2Hz";
			this.comboBoxWAVHay2Hz.Size = new System.Drawing.Size(112, 20);
			this.comboBoxWAVHay2Hz.TabIndex = 13;
			this.toolTip.SetToolTip(this.comboBoxWAVHay2Hz, "高ければ高周波の音が出ます。\n低くする意味は無いかも。");
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(8, 16);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(87, 15);
			this.label31.TabIndex = 11;
			this.label31.Text = "サンプリングレート";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(8, 44);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(41, 15);
			this.label32.TabIndex = 9;
			this.label32.Text = "ビット数";
			// 
			// comboBoxWAVHay2Bit
			// 
			this.comboBoxWAVHay2Bit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVHay2Bit.Items.AddRange(new object[] {
																	"16 bit",
																	"8 bit"});
			this.comboBoxWAVHay2Bit.Location = new System.Drawing.Point(64, 40);
			this.comboBoxWAVHay2Bit.Name = "comboBoxWAVHay2Bit";
			this.comboBoxWAVHay2Bit.Size = new System.Drawing.Size(148, 20);
			this.comboBoxWAVHay2Bit.TabIndex = 14;
			this.toolTip.SetToolTip(this.comboBoxWAVHay2Bit, "8bitだと音にざらつきが生じます。");
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(8, 72);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(52, 15);
			this.label33.TabIndex = 10;
			this.label33.Text = "チャンネル";
			// 
			// comboBoxWAVHay2Channel
			// 
			this.comboBoxWAVHay2Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVHay2Channel.Items.AddRange(new object[] {
																		"ステレオ",
																		"モノラル"});
			this.comboBoxWAVHay2Channel.Location = new System.Drawing.Point(64, 68);
			this.comboBoxWAVHay2Channel.Name = "comboBoxWAVHay2Channel";
			this.comboBoxWAVHay2Channel.Size = new System.Drawing.Size(148, 20);
			this.comboBoxWAVHay2Channel.TabIndex = 12;
			this.toolTip.SetToolTip(this.comboBoxWAVHay2Channel, "ステレオかモノラルかを選択してください。");
			// 
			// comboBoxWAVHay2PCMMethod
			// 
			this.comboBoxWAVHay2PCMMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVHay2PCMMethod.Items.AddRange(new object[] {
																		  "補間なし (低音質)",
																		  "線形補間",
																		  "面積補間",
																		  "ネヴィル補間",
																		  "ベジエ補間 (高音質)"});
			this.comboBoxWAVHay2PCMMethod.Location = new System.Drawing.Point(48, 96);
			this.comboBoxWAVHay2PCMMethod.Name = "comboBoxWAVHay2PCMMethod";
			this.comboBoxWAVHay2PCMMethod.Size = new System.Drawing.Size(164, 20);
			this.comboBoxWAVHay2PCMMethod.TabIndex = 12;
			this.toolTip.SetToolTip(this.comboBoxWAVHay2PCMMethod, "PCM補間法を選択してください。\n下に行くほど高音質(ざら付きが無くなる)です。");
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(8, 100);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(29, 15);
			this.label34.TabIndex = 10;
			this.label34.Text = "補間";
			// 
			// checkBoxWAVHay2WhiteNoise
			// 
			this.checkBoxWAVHay2WhiteNoise.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxWAVHay2WhiteNoise.Location = new System.Drawing.Point(112, 148);
			this.checkBoxWAVHay2WhiteNoise.Name = "checkBoxWAVHay2WhiteNoise";
			this.checkBoxWAVHay2WhiteNoise.Size = new System.Drawing.Size(98, 16);
			this.checkBoxWAVHay2WhiteNoise.TabIndex = 16;
			this.checkBoxWAVHay2WhiteNoise.Text = "音圧補正";
			this.toolTip.SetToolTip(this.checkBoxWAVHay2WhiteNoise, "高周波のホワイトノイズを出力に被せる事で、音のパンチ力を高めてみます。\nテスト中機能。");
			// 
			// labelWAVHay2Vol
			// 
			this.labelWAVHay2Vol.Location = new System.Drawing.Point(188, 172);
			this.labelWAVHay2Vol.Name = "labelWAVHay2Vol";
			this.labelWAVHay2Vol.Size = new System.Drawing.Size(24, 16);
			this.labelWAVHay2Vol.TabIndex = 19;
			this.labelWAVHay2Vol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxWAVEng
			// 
			this.comboBoxWAVEng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWAVEng.Items.AddRange(new object[] {
																"tjbms2wav",
																"BmsWave速波２"});
			this.comboBoxWAVEng.Location = new System.Drawing.Point(12, 32);
			this.comboBoxWAVEng.Name = "comboBoxWAVEng";
			this.comboBoxWAVEng.Size = new System.Drawing.Size(228, 20);
			this.comboBoxWAVEng.TabIndex = 6;
			this.toolTip.SetToolTip(this.comboBoxWAVEng, "BMSをWAVに変換するエンジンを選択します。\n");
			this.comboBoxWAVEng.SelectedIndexChanged += new System.EventHandler(this.comboBoxWAVEng_SelectedIndexChanged);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(12, 16);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(99, 15);
			this.label25.TabIndex = 5;
			this.label25.Text = "WAVE変換エンジン";
			// 
			// tabPageMP3
			// 
			this.tabPageMP3.Controls.Add(this.tabControlMP3);
			this.tabPageMP3.Controls.Add(this.textBoxMP3LowpassValue);
			this.tabPageMP3.Controls.Add(this.checkBoxMP3nspsytune);
			this.tabPageMP3.Controls.Add(this.comboBoxMP3Bit);
			this.tabPageMP3.Controls.Add(this.label2);
			this.tabPageMP3.Controls.Add(this.label4);
			this.tabPageMP3.Controls.Add(this.comboBoxMP3Stereo);
			this.tabPageMP3.Controls.Add(this.checkBoxMP3Lowpass);
			this.tabPageMP3.Controls.Add(this.label5);
			this.tabPageMP3.Controls.Add(this.label6);
			this.tabPageMP3.Controls.Add(this.comboBoxMP3q);
			this.tabPageMP3.Controls.Add(this.label23);
			this.tabPageMP3.Controls.Add(this.comboBoxMP3Hz);
			this.tabPageMP3.Controls.Add(this.checkBoxMP3Cmd);
			this.tabPageMP3.Location = new System.Drawing.Point(4, 21);
			this.tabPageMP3.Name = "tabPageMP3";
			this.tabPageMP3.Size = new System.Drawing.Size(492, 243);
			this.tabPageMP3.TabIndex = 1;
			this.tabPageMP3.Text = "MP3の設定";
			// 
			// tabControlMP3
			// 
			this.tabControlMP3.Controls.Add(this.tabPageMP3CBR);
			this.tabControlMP3.Controls.Add(this.tabPageMP3VBR);
			this.tabControlMP3.Controls.Add(this.tabPageMP3ABR);
			this.tabControlMP3.Location = new System.Drawing.Point(252, 12);
			this.tabControlMP3.Name = "tabControlMP3";
			this.tabControlMP3.SelectedIndex = 0;
			this.tabControlMP3.Size = new System.Drawing.Size(228, 220);
			this.tabControlMP3.TabIndex = 12;
			this.toolTip.SetToolTip(this.tabControlMP3, "ビットレート変動においての最小ビットレートを選択してください。");
			this.tabControlMP3.SelectedIndexChanged += new System.EventHandler(this.tabControlMP3_SelectedIndexChanged);
			// 
			// tabPageMP3CBR
			// 
			this.tabPageMP3CBR.Controls.Add(this.comboBoxMP3CBRPreset);
			this.tabPageMP3CBR.Controls.Add(this.comboBoxMP3CBRBit);
			this.tabPageMP3CBR.Controls.Add(this.label3);
			this.tabPageMP3CBR.Controls.Add(this.checkBoxMP3CBRUsePreset);
			this.tabPageMP3CBR.Location = new System.Drawing.Point(4, 21);
			this.tabPageMP3CBR.Name = "tabPageMP3CBR";
			this.tabPageMP3CBR.Size = new System.Drawing.Size(220, 195);
			this.tabPageMP3CBR.TabIndex = 0;
			this.tabPageMP3CBR.Text = "CBR";
			// 
			// comboBoxMP3CBRPreset
			// 
			this.comboBoxMP3CBRPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3CBRPreset.Items.AddRange(new object[] {
																	  "--preset cbr *",
																	  "--preset insane"});
			this.comboBoxMP3CBRPreset.Location = new System.Drawing.Point(24, 60);
			this.comboBoxMP3CBRPreset.Name = "comboBoxMP3CBRPreset";
			this.comboBoxMP3CBRPreset.Size = new System.Drawing.Size(188, 20);
			this.comboBoxMP3CBRPreset.TabIndex = 9;
			this.toolTip.SetToolTip(this.comboBoxMP3CBRPreset, "CBRプリセットを選択してください。\n\n--preset * … *Kbpsで最適な設定でエンコードします。\n--preset insane … 音質が最高になる" +
				"ようにエンコードします。320Kbps固定。");
			this.comboBoxMP3CBRPreset.SelectedIndexChanged += new System.EventHandler(this.comboBoxMP3CBRPreset_SelectedIndexChanged);
			// 
			// comboBoxMP3CBRBit
			// 
			this.comboBoxMP3CBRBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3CBRBit.Items.AddRange(new object[] {
																   "32 Kbps",
																   "40 Kpbs",
																   "48 Kbps",
																   "56 Kbps",
																   "64 Kbps",
																   "80 Kbps",
																   "96 Kbps",
																   "112 Kbps",
																   "128 Kbps",
																   "160 Kbps",
																   "192 Kbps",
																   "224 Kbps",
																   "256 Kbps",
																   "320 Kbps"});
			this.comboBoxMP3CBRBit.Location = new System.Drawing.Point(76, 12);
			this.comboBoxMP3CBRBit.Name = "comboBoxMP3CBRBit";
			this.comboBoxMP3CBRBit.Size = new System.Drawing.Size(136, 20);
			this.comboBoxMP3CBRBit.TabIndex = 5;
			this.toolTip.SetToolTip(this.comboBoxMP3CBRBit, "ビットレートを選択してください。\n112Kbps以下は低音質です。\n192Kbps以上で高音質です。");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "ビットレート";
			// 
			// checkBoxMP3CBRUsePreset
			// 
			this.checkBoxMP3CBRUsePreset.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3CBRUsePreset.Location = new System.Drawing.Point(8, 40);
			this.checkBoxMP3CBRUsePreset.Name = "checkBoxMP3CBRUsePreset";
			this.checkBoxMP3CBRUsePreset.Size = new System.Drawing.Size(200, 16);
			this.checkBoxMP3CBRUsePreset.TabIndex = 8;
			this.checkBoxMP3CBRUsePreset.Text = "プリセットを使用する";
			this.toolTip.SetToolTip(this.checkBoxMP3CBRUsePreset, "Lameに用意されているプリセットを使用します。");
			this.checkBoxMP3CBRUsePreset.CheckedChanged += new System.EventHandler(this.checkBoxMP3CBRUsePreset_CheckedChanged);
			// 
			// tabPageMP3VBR
			// 
			this.tabPageMP3VBR.Controls.Add(this.comboBoxMP3VBRq);
			this.tabPageMP3VBR.Controls.Add(this.comboBoxMP3VBRPreset);
			this.tabPageMP3VBR.Controls.Add(this.comboBoxMP3VBRMinBit);
			this.tabPageMP3VBR.Controls.Add(this.label7);
			this.tabPageMP3VBR.Controls.Add(this.checkBoxMP3VBRUsePreset);
			this.tabPageMP3VBR.Controls.Add(this.label8);
			this.tabPageMP3VBR.Controls.Add(this.comboBoxMP3VBRMaxBit);
			this.tabPageMP3VBR.Controls.Add(this.label9);
			this.tabPageMP3VBR.Controls.Add(this.label10);
			this.tabPageMP3VBR.Controls.Add(this.comboBoxMP3VBRMethod);
			this.tabPageMP3VBR.Controls.Add(this.checkBoxMP3VBRForceMinBit);
			this.tabPageMP3VBR.Location = new System.Drawing.Point(4, 21);
			this.tabPageMP3VBR.Name = "tabPageMP3VBR";
			this.tabPageMP3VBR.Size = new System.Drawing.Size(220, 195);
			this.tabPageMP3VBR.TabIndex = 1;
			this.tabPageMP3VBR.Text = "VBR";
			// 
			// comboBoxMP3VBRq
			// 
			this.comboBoxMP3VBRq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3VBRq.DropDownWidth = 160;
			this.comboBoxMP3VBRq.Items.AddRange(new object[] {
																 "-V 0 (高音質大容量)",
																 "-V 1",
																 "-V 2",
																 "-V 3",
																 "-V 4 (デフォルト)",
																 "-V 5",
																 "-V 6",
																 "-V 7",
																 "-V 8",
																 "-V 9 (低音質小容量)"});
			this.comboBoxMP3VBRq.Location = new System.Drawing.Point(96, 68);
			this.comboBoxMP3VBRq.Name = "comboBoxMP3VBRq";
			this.comboBoxMP3VBRq.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3VBRq.TabIndex = 10;
			this.toolTip.SetToolTip(this.comboBoxMP3VBRq, "クオリティを選択してください。\nVが小さいほどビットレートを多めに配分します。");
			// 
			// comboBoxMP3VBRPreset
			// 
			this.comboBoxMP3VBRPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3VBRPreset.Items.AddRange(new object[] {
																	  "--preset medium",
																	  "--preset standard",
																	  "--preset extreme",
																	  "--preset fast medium",
																	  "--preset fast standard",
																	  "--preset fast extreme",
																	  "--r3mix"});
			this.comboBoxMP3VBRPreset.Location = new System.Drawing.Point(24, 168);
			this.comboBoxMP3VBRPreset.Name = "comboBoxMP3VBRPreset";
			this.comboBoxMP3VBRPreset.Size = new System.Drawing.Size(188, 20);
			this.comboBoxMP3VBRPreset.TabIndex = 9;
			this.toolTip.SetToolTip(this.comboBoxMP3VBRPreset, @"VBRプリセットを選択してください。

--preset medium … 平均150～180kbps周辺。
--preset standard … 平均170～210kbps周辺。
--preset extreme … 平均200～240kbps周辺。
--preset fast medium … mediumの高速版。若干音質低めでビットレート配分高め。
--preset fast standard … standardの高速版。若干音質低めでビットレート配分高め。
--preset fast extreme … extremeの高速版。若干音質低めでビットレート配分高め。
--r3mix … r3mix.comフォーラムにて考案されたプリセット。");
			this.comboBoxMP3VBRPreset.SelectedIndexChanged += new System.EventHandler(this.comboBoxMP3VBRPreset_SelectedIndexChanged);
			// 
			// comboBoxMP3VBRMinBit
			// 
			this.comboBoxMP3VBRMinBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3VBRMinBit.Items.AddRange(new object[] {
																	  "指定しない",
																	  "32 Kbps",
																	  "40 Kbps",
																	  "48 Kbps",
																	  "56 Kbps",
																	  "64 Kbps",
																	  "80 Kbps",
																	  "96 Kbps",
																	  "112 Kbps",
																	  "128 Kbps",
																	  "160 Kbps",
																	  "192 Kbps",
																	  "224 Kbps",
																	  "256 Kbps",
																	  "320 Kbps"});
			this.comboBoxMP3VBRMinBit.Location = new System.Drawing.Point(96, 12);
			this.comboBoxMP3VBRMinBit.Name = "comboBoxMP3VBRMinBit";
			this.comboBoxMP3VBRMinBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3VBRMinBit.TabIndex = 5;
			this.toolTip.SetToolTip(this.comboBoxMP3VBRMinBit, "ビットレート変動においての最小ビットレートを指定してください。");
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 4;
			this.label7.Text = "最小ビットレート";
			// 
			// checkBoxMP3VBRUsePreset
			// 
			this.checkBoxMP3VBRUsePreset.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3VBRUsePreset.Location = new System.Drawing.Point(8, 148);
			this.checkBoxMP3VBRUsePreset.Name = "checkBoxMP3VBRUsePreset";
			this.checkBoxMP3VBRUsePreset.Size = new System.Drawing.Size(204, 16);
			this.checkBoxMP3VBRUsePreset.TabIndex = 8;
			this.checkBoxMP3VBRUsePreset.Text = "プリセットを使用する";
			this.toolTip.SetToolTip(this.checkBoxMP3VBRUsePreset, "Lameに用意されているプリセットを使用します。");
			this.checkBoxMP3VBRUsePreset.CheckedChanged += new System.EventHandler(this.checkBoxMP3VBRUsePreset_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 44);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 15);
			this.label8.TabIndex = 4;
			this.label8.Text = "最大ビットレート";
			// 
			// comboBoxMP3VBRMaxBit
			// 
			this.comboBoxMP3VBRMaxBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3VBRMaxBit.Items.AddRange(new object[] {
																	  "指定しない",
																	  "32 Kbps",
																	  "40 Kbps",
																	  "48 Kbps",
																	  "56 Kbps",
																	  "64 Kbps",
																	  "80 Kbps",
																	  "96 Kbps",
																	  "112 Kbps",
																	  "128 Kbps",
																	  "160 Kbps",
																	  "192 Kbps",
																	  "224 Kbps",
																	  "256 Kbps",
																	  "320 Kbps"});
			this.comboBoxMP3VBRMaxBit.Location = new System.Drawing.Point(96, 40);
			this.comboBoxMP3VBRMaxBit.Name = "comboBoxMP3VBRMaxBit";
			this.comboBoxMP3VBRMaxBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3VBRMaxBit.TabIndex = 5;
			this.toolTip.SetToolTip(this.comboBoxMP3VBRMaxBit, "ビットレート変動においての最大ビットレートを指定してください。");
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 72);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(70, 15);
			this.label9.TabIndex = 4;
			this.label9.Text = "VBRクオリティ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 100);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(84, 15);
			this.label10.TabIndex = 4;
			this.label10.Text = "VBRアルゴリズム";
			// 
			// comboBoxMP3VBRMethod
			// 
			this.comboBoxMP3VBRMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3VBRMethod.DropDownWidth = 160;
			this.comboBoxMP3VBRMethod.Items.AddRange(new object[] {
																	  "--vbr-old (デフォルト)",
																	  "--vbr-new (-mtrh)"});
			this.comboBoxMP3VBRMethod.Location = new System.Drawing.Point(96, 96);
			this.comboBoxMP3VBRMethod.Name = "comboBoxMP3VBRMethod";
			this.comboBoxMP3VBRMethod.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3VBRMethod.TabIndex = 10;
			this.toolTip.SetToolTip(this.comboBoxMP3VBRMethod, "ビットレート割り当てのアルゴリズムを選択してください。\noldは最もよい結果を示します。\nnewはoldより音質は劣りますが2倍以上の速度でエンコードします。");
			// 
			// checkBoxMP3VBRForceMinBit
			// 
			this.checkBoxMP3VBRForceMinBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3VBRForceMinBit.Location = new System.Drawing.Point(8, 124);
			this.checkBoxMP3VBRForceMinBit.Name = "checkBoxMP3VBRForceMinBit";
			this.checkBoxMP3VBRForceMinBit.Size = new System.Drawing.Size(204, 16);
			this.checkBoxMP3VBRForceMinBit.TabIndex = 8;
			this.checkBoxMP3VBRForceMinBit.Text = "最小ビットレートを強制";
			this.toolTip.SetToolTip(this.checkBoxMP3VBRForceMinBit, "VBRは無音状態になると最小のビットレート(8Kbps)を割り当てます。\n一部携帯プレイヤは8Kbpsを正常に再生できません。\nお使いのプレイヤが無音をうまく処理" +
				"できない場合にONにしてください。");
			// 
			// tabPageMP3ABR
			// 
			this.tabPageMP3ABR.Controls.Add(this.comboBoxMP3ABRMaxBitDummy);
			this.tabPageMP3ABR.Controls.Add(this.comboBoxMP3ABRMinBitDummy);
			this.tabPageMP3ABR.Controls.Add(this.comboBoxMP3ABRBitDummy);
			this.tabPageMP3ABR.Controls.Add(this.numericUpDownMP3ABRPresetBit);
			this.tabPageMP3ABR.Controls.Add(this.comboBoxMP3ABRPreset);
			this.tabPageMP3ABR.Controls.Add(this.checkBoxMP3ABRUsePreset);
			this.tabPageMP3ABR.Controls.Add(this.comboBoxMP3ABRMaxBit);
			this.tabPageMP3ABR.Controls.Add(this.label12);
			this.tabPageMP3ABR.Controls.Add(this.comboBoxMP3ABRBit);
			this.tabPageMP3ABR.Controls.Add(this.label11);
			this.tabPageMP3ABR.Controls.Add(this.checkBoxMP3ABRForceMinBit);
			this.tabPageMP3ABR.Controls.Add(this.comboBoxMP3ABRMinBit);
			this.tabPageMP3ABR.Controls.Add(this.label13);
			this.tabPageMP3ABR.Controls.Add(this.label30);
			this.tabPageMP3ABR.Location = new System.Drawing.Point(4, 21);
			this.tabPageMP3ABR.Name = "tabPageMP3ABR";
			this.tabPageMP3ABR.Size = new System.Drawing.Size(220, 195);
			this.tabPageMP3ABR.TabIndex = 2;
			this.tabPageMP3ABR.Text = "ABR";
			// 
			// comboBoxMP3ABRMaxBitDummy
			// 
			this.comboBoxMP3ABRMaxBitDummy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3ABRMaxBitDummy.Enabled = false;
			this.comboBoxMP3ABRMaxBitDummy.Items.AddRange(new object[] {
																		   "dummy"});
			this.comboBoxMP3ABRMaxBitDummy.Location = new System.Drawing.Point(96, 68);
			this.comboBoxMP3ABRMaxBitDummy.Name = "comboBoxMP3ABRMaxBitDummy";
			this.comboBoxMP3ABRMaxBitDummy.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3ABRMaxBitDummy.TabIndex = 18;
			this.comboBoxMP3ABRMaxBitDummy.Visible = false;
			// 
			// comboBoxMP3ABRMinBitDummy
			// 
			this.comboBoxMP3ABRMinBitDummy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3ABRMinBitDummy.Enabled = false;
			this.comboBoxMP3ABRMinBitDummy.Items.AddRange(new object[] {
																		   "dummy"});
			this.comboBoxMP3ABRMinBitDummy.Location = new System.Drawing.Point(96, 40);
			this.comboBoxMP3ABRMinBitDummy.Name = "comboBoxMP3ABRMinBitDummy";
			this.comboBoxMP3ABRMinBitDummy.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3ABRMinBitDummy.TabIndex = 17;
			this.comboBoxMP3ABRMinBitDummy.Visible = false;
			// 
			// comboBoxMP3ABRBitDummy
			// 
			this.comboBoxMP3ABRBitDummy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3ABRBitDummy.Enabled = false;
			this.comboBoxMP3ABRBitDummy.Items.AddRange(new object[] {
																		"dummy"});
			this.comboBoxMP3ABRBitDummy.Location = new System.Drawing.Point(96, 12);
			this.comboBoxMP3ABRBitDummy.Name = "comboBoxMP3ABRBitDummy";
			this.comboBoxMP3ABRBitDummy.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3ABRBitDummy.TabIndex = 16;
			this.comboBoxMP3ABRBitDummy.Visible = false;
			// 
			// numericUpDownMP3ABRPresetBit
			// 
			this.numericUpDownMP3ABRPresetBit.Location = new System.Drawing.Point(164, 168);
			this.numericUpDownMP3ABRPresetBit.Maximum = new System.Decimal(new int[] {
																						 320,
																						 0,
																						 0,
																						 0});
			this.numericUpDownMP3ABRPresetBit.Minimum = new System.Decimal(new int[] {
																						 16,
																						 0,
																						 0,
																						 0});
			this.numericUpDownMP3ABRPresetBit.Name = "numericUpDownMP3ABRPresetBit";
			this.numericUpDownMP3ABRPresetBit.ReadOnly = true;
			this.numericUpDownMP3ABRPresetBit.Size = new System.Drawing.Size(48, 19);
			this.numericUpDownMP3ABRPresetBit.TabIndex = 15;
			this.numericUpDownMP3ABRPresetBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.numericUpDownMP3ABRPresetBit, "エンコードファイルのビットレートの平均値を1刻みで決定できます。");
			this.numericUpDownMP3ABRPresetBit.Value = new System.Decimal(new int[] {
																					   128,
																					   0,
																					   0,
																					   0});
			// 
			// comboBoxMP3ABRPreset
			// 
			this.comboBoxMP3ABRPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3ABRPreset.Items.AddRange(new object[] {
																	  "--preset *",
																	  "--preset phone",
																	  "--preset phon+",
																	  "--preset mw-us",
																	  "--preset fm",
																	  "--preset hifi",
																	  "--preset cd",
																	  "--preset studio"});
			this.comboBoxMP3ABRPreset.Location = new System.Drawing.Point(24, 144);
			this.comboBoxMP3ABRPreset.Name = "comboBoxMP3ABRPreset";
			this.comboBoxMP3ABRPreset.Size = new System.Drawing.Size(188, 20);
			this.comboBoxMP3ABRPreset.TabIndex = 14;
			this.toolTip.SetToolTip(this.comboBoxMP3ABRPreset, @"ABRプリセットを選択してください。

--preset * … *Kbpsになるように調整します。
--preset phone … 電話音声並。モノラル固定、16Kbps周辺。
--preset phon+ … 電話音声並。モノラル固定、24Kbps周辺。
--preset mw-us … 電話音声並。モノラル固定、40Kbps周辺。
--preset fm … FMラジオ/テープ並。112Kbps周辺。
--preset hifi … ハイファイ並。160Kbps周辺。
--preset cd … CD並。192Kbps周辺。
--preset studio … スタジオ並。256Kbps周辺。");
			this.comboBoxMP3ABRPreset.SelectedIndexChanged += new System.EventHandler(this.comboBoxMP3ABRPreset_SelectedIndexChanged);
			// 
			// checkBoxMP3ABRUsePreset
			// 
			this.checkBoxMP3ABRUsePreset.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3ABRUsePreset.Location = new System.Drawing.Point(8, 124);
			this.checkBoxMP3ABRUsePreset.Name = "checkBoxMP3ABRUsePreset";
			this.checkBoxMP3ABRUsePreset.Size = new System.Drawing.Size(204, 16);
			this.checkBoxMP3ABRUsePreset.TabIndex = 13;
			this.checkBoxMP3ABRUsePreset.Text = "プリセットを使用する";
			this.toolTip.SetToolTip(this.checkBoxMP3ABRUsePreset, "Lameに用意されているプリセットを使用します。");
			this.checkBoxMP3ABRUsePreset.CheckedChanged += new System.EventHandler(this.checkBoxMP3ABRUsePreset_CheckedChanged);
			// 
			// comboBoxMP3ABRMaxBit
			// 
			this.comboBoxMP3ABRMaxBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3ABRMaxBit.Items.AddRange(new object[] {
																	  "指定しない",
																	  "32 Kbps",
																	  "40 Kpbs",
																	  "48 Kbps",
																	  "56 Kbps",
																	  "64 Kbps",
																	  "80 Kbps",
																	  "96 Kbps",
																	  "112 Kbps",
																	  "128 Kbps",
																	  "160 Kbps",
																	  "192 Kbps",
																	  "224 Kbps",
																	  "256 Kbps",
																	  "320 Kbps"});
			this.comboBoxMP3ABRMaxBit.Location = new System.Drawing.Point(96, 68);
			this.comboBoxMP3ABRMaxBit.Name = "comboBoxMP3ABRMaxBit";
			this.comboBoxMP3ABRMaxBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3ABRMaxBit.TabIndex = 9;
			this.toolTip.SetToolTip(this.comboBoxMP3ABRMaxBit, "ビットレート変動においての最大ビットレートを選択してください。");
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 72);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 15);
			this.label12.TabIndex = 8;
			this.label12.Text = "最大ビットレート";
			// 
			// comboBoxMP3ABRBit
			// 
			this.comboBoxMP3ABRBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3ABRBit.Items.AddRange(new object[] {
																   "32 Kbps",
																   "40 Kpbs",
																   "48 Kbps",
																   "56 Kbps",
																   "64 Kbps",
																   "80 Kbps",
																   "96 Kbps",
																   "112 Kbps",
																   "128 Kbps",
																   "160 Kbps",
																   "192 Kbps",
																   "224 Kbps",
																   "256 Kbps",
																   "320 Kbps"});
			this.comboBoxMP3ABRBit.Location = new System.Drawing.Point(96, 12);
			this.comboBoxMP3ABRBit.Name = "comboBoxMP3ABRBit";
			this.comboBoxMP3ABRBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3ABRBit.TabIndex = 7;
			this.toolTip.SetToolTip(this.comboBoxMP3ABRBit, "目標ビットレートを指定してください。\nビットレートの平均値が大体この値になります。");
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 15);
			this.label11.TabIndex = 6;
			this.label11.Text = "目標ビットレート";
			// 
			// checkBoxMP3ABRForceMinBit
			// 
			this.checkBoxMP3ABRForceMinBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3ABRForceMinBit.Location = new System.Drawing.Point(8, 100);
			this.checkBoxMP3ABRForceMinBit.Name = "checkBoxMP3ABRForceMinBit";
			this.checkBoxMP3ABRForceMinBit.Size = new System.Drawing.Size(204, 16);
			this.checkBoxMP3ABRForceMinBit.TabIndex = 12;
			this.checkBoxMP3ABRForceMinBit.Text = "最小ビットレートを強制";
			this.toolTip.SetToolTip(this.checkBoxMP3ABRForceMinBit, "ABRは無音状態になると最小のビットレート(8Kbps)を割り当てます。\n一部携帯プレイヤは8Kbpsを正常に再生できません。\nお使いのプレイヤが無音をうまく処理" +
				"できない場合にONにしてください。");
			// 
			// comboBoxMP3ABRMinBit
			// 
			this.comboBoxMP3ABRMinBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3ABRMinBit.DropDownWidth = 120;
			this.comboBoxMP3ABRMinBit.Items.AddRange(new object[] {
																	  "指定しない",
																	  "32 Kbps",
																	  "40 Kpbs",
																	  "48 Kbps",
																	  "56 Kbps",
																	  "64 Kbps",
																	  "80 Kbps",
																	  "96 Kbps",
																	  "112 Kbps",
																	  "128 Kbps",
																	  "160 Kbps",
																	  "192 Kbps",
																	  "224 Kbps",
																	  "256 Kbps",
																	  "320 Kbps"});
			this.comboBoxMP3ABRMinBit.Location = new System.Drawing.Point(96, 40);
			this.comboBoxMP3ABRMinBit.Name = "comboBoxMP3ABRMinBit";
			this.comboBoxMP3ABRMinBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxMP3ABRMinBit.TabIndex = 11;
			this.toolTip.SetToolTip(this.comboBoxMP3ABRMinBit, "ビットレート変動においての最小ビットレートを選択してください。");
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 44);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 15);
			this.label13.TabIndex = 10;
			this.label13.Text = "最小ビットレート";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(28, 172);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(136, 15);
			this.label30.TabIndex = 8;
			this.label30.Text = "--preset * でのビットレート";
			// 
			// textBoxMP3LowpassValue
			// 
			this.textBoxMP3LowpassValue.Location = new System.Drawing.Point(32, 164);
			this.textBoxMP3LowpassValue.Name = "textBoxMP3LowpassValue";
			this.textBoxMP3LowpassValue.Size = new System.Drawing.Size(60, 19);
			this.textBoxMP3LowpassValue.TabIndex = 9;
			this.textBoxMP3LowpassValue.Text = "";
			// 
			// checkBoxMP3nspsytune
			// 
			this.checkBoxMP3nspsytune.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3nspsytune.Location = new System.Drawing.Point(12, 192);
			this.checkBoxMP3nspsytune.Name = "checkBoxMP3nspsytune";
			this.checkBoxMP3nspsytune.Size = new System.Drawing.Size(228, 16);
			this.checkBoxMP3nspsytune.TabIndex = 8;
			this.checkBoxMP3nspsytune.Text = "nspsytuneを使用する";
			this.toolTip.SetToolTip(this.checkBoxMP3nspsytune, "心理音響モデル演算を行います。\nエンコード速度は落ちますが音質は向上します。");
			// 
			// comboBoxMP3Bit
			// 
			this.comboBoxMP3Bit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3Bit.Items.AddRange(new object[] {
																"固定ビットレート (CBR)",
																"可変ビットレート (VBR)",
																"平均ビットレート (ABR)"});
			this.comboBoxMP3Bit.Location = new System.Drawing.Point(12, 32);
			this.comboBoxMP3Bit.Name = "comboBoxMP3Bit";
			this.comboBoxMP3Bit.Size = new System.Drawing.Size(228, 20);
			this.comboBoxMP3Bit.TabIndex = 7;
			this.toolTip.SetToolTip(this.comboBoxMP3Bit, "ビットレートの方式を決めます。\nとても古い携帯プレイヤではVBR/ABRが再生できない場合があります。");
			this.comboBoxMP3Bit.SelectedIndexChanged += new System.EventHandler(this.comboBoxMP3Bit_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "ビットレート配分方式";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "チャンネル";
			// 
			// comboBoxMP3Stereo
			// 
			this.comboBoxMP3Stereo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3Stereo.Items.AddRange(new object[] {
																   "Stereo",
																   "Joint Stereo",
																   "Forced Joint Stereo",
																   "Mono"});
			this.comboBoxMP3Stereo.Location = new System.Drawing.Point(68, 60);
			this.comboBoxMP3Stereo.Name = "comboBoxMP3Stereo";
			this.comboBoxMP3Stereo.Size = new System.Drawing.Size(172, 20);
			this.comboBoxMP3Stereo.TabIndex = 7;
			this.toolTip.SetToolTip(this.comboBoxMP3Stereo, "チャンネル方式を決定します。\n160Kbps以下はJoint Stereo、192Kbps以上はStereoにするとよいみたいです。");
			// 
			// checkBoxMP3Lowpass
			// 
			this.checkBoxMP3Lowpass.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3Lowpass.Location = new System.Drawing.Point(12, 144);
			this.checkBoxMP3Lowpass.Name = "checkBoxMP3Lowpass";
			this.checkBoxMP3Lowpass.Size = new System.Drawing.Size(228, 16);
			this.checkBoxMP3Lowpass.TabIndex = 8;
			this.checkBoxMP3Lowpass.Text = "ローパスフィルタを使用する";
			this.toolTip.SetToolTip(this.checkBoxMP3Lowpass, "一定周波数以上をカットするときに使います。\n128Kbps以下の低ビットレートにおいて使用すると音質がよくなる場合があります。");
			this.checkBoxMP3Lowpass.CheckedChanged += new System.EventHandler(this.checkBoxMP3Lowpass_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(96, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "KHz";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 15);
			this.label6.TabIndex = 4;
			this.label6.Text = "クオリティ";
			// 
			// comboBoxMP3q
			// 
			this.comboBoxMP3q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3q.Items.AddRange(new object[] {
															  "-q0 (最低速最高音質)",
															  "-q1",
															  "-q2 (低速高音質)",
															  "-q3",
															  "-q4",
															  "-q5 (デフォルト)",
															  "-q6",
															  "-q7 (高速低音質)",
															  "-q8",
															  "-q9 (最高速最低音質)"});
			this.comboBoxMP3q.Location = new System.Drawing.Point(68, 88);
			this.comboBoxMP3q.Name = "comboBoxMP3q";
			this.comboBoxMP3q.Size = new System.Drawing.Size(172, 20);
			this.comboBoxMP3q.TabIndex = 7;
			this.toolTip.SetToolTip(this.comboBoxMP3q, "品質を決定します。\nqが小さいほど品質はよくなりエンコードに時間がかかります。\nq0/q1はエンコードに時間を浪費します。q2と違いがわからなければq2を使いまし" +
				"ょう。");
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(12, 120);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(87, 15);
			this.label23.TabIndex = 4;
			this.label23.Text = "サンプリングレート";
			// 
			// comboBoxMP3Hz
			// 
			this.comboBoxMP3Hz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMP3Hz.Items.AddRange(new object[] {
															   "自動設定",
															   "48,000 Hz",
															   "44,100 Hz",
															   "32,000 Hz",
															   "24,000 Hz",
															   "22,050 Hz",
															   "16,000 Hz",
															   "12,000 Hz",
															   "11,025 Hz",
															   "8,000 Hz"});
			this.comboBoxMP3Hz.Location = new System.Drawing.Point(100, 116);
			this.comboBoxMP3Hz.Name = "comboBoxMP3Hz";
			this.comboBoxMP3Hz.Size = new System.Drawing.Size(140, 20);
			this.comboBoxMP3Hz.TabIndex = 7;
			this.toolTip.SetToolTip(this.comboBoxMP3Hz, "96Kbps以下にすると自動的に32KHzなどに補正がかかります。\n低ビットレートにおいて強制的にサンプリングレートを割り当てるときに使用してください。");
			// 
			// checkBoxMP3Cmd
			// 
			this.checkBoxMP3Cmd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxMP3Cmd.Location = new System.Drawing.Point(12, 216);
			this.checkBoxMP3Cmd.Name = "checkBoxMP3Cmd";
			this.checkBoxMP3Cmd.Size = new System.Drawing.Size(228, 16);
			this.checkBoxMP3Cmd.TabIndex = 8;
			this.checkBoxMP3Cmd.Text = "プロンプトを表示する";
			this.toolTip.SetToolTip(this.checkBoxMP3Cmd, "DOSプロンプトを表示します。");
			this.checkBoxMP3Cmd.Visible = false;
			// 
			// tabPageVor
			// 
			this.tabPageVor.Controls.Add(this.checkBoxVorCmd);
			this.tabPageVor.Controls.Add(this.label24);
			this.tabPageVor.Controls.Add(this.comboBoxVorHz);
			this.tabPageVor.Controls.Add(this.tabControlVor);
			this.tabPageVor.Controls.Add(this.textBoxVorLowpassValue);
			this.tabPageVor.Controls.Add(this.checkBoxVorLowpass);
			this.tabPageVor.Controls.Add(this.label18);
			this.tabPageVor.Controls.Add(this.comboBoxVorBit);
			this.tabPageVor.Controls.Add(this.label14);
			this.tabPageVor.Controls.Add(this.checkBoxVorDownmix);
			this.tabPageVor.Location = new System.Drawing.Point(4, 21);
			this.tabPageVor.Name = "tabPageVor";
			this.tabPageVor.Size = new System.Drawing.Size(492, 243);
			this.tabPageVor.TabIndex = 2;
			this.tabPageVor.Text = "Ogg Vorbisの設定";
			// 
			// checkBoxVorCmd
			// 
			this.checkBoxVorCmd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxVorCmd.Location = new System.Drawing.Point(12, 112);
			this.checkBoxVorCmd.Name = "checkBoxVorCmd";
			this.checkBoxVorCmd.Size = new System.Drawing.Size(228, 16);
			this.checkBoxVorCmd.TabIndex = 22;
			this.checkBoxVorCmd.Text = "プロンプトを表示する";
			this.toolTip.SetToolTip(this.checkBoxVorCmd, "DOSプロンプトを表示します。");
			this.checkBoxVorCmd.Visible = false;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(12, 64);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(87, 15);
			this.label24.TabIndex = 20;
			this.label24.Text = "サンプリングレート";
			// 
			// comboBoxVorHz
			// 
			this.comboBoxVorHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVorHz.Items.AddRange(new object[] {
															   "自動設定",
															   "48,000 Hz",
															   "44,100 Hz",
															   "32,000 Hz",
															   "24,000 Hz",
															   "22,050 Hz",
															   "16,000 Hz",
															   "12,000 Hz",
															   "11,025 Hz",
															   "8,000 Hz"});
			this.comboBoxVorHz.Location = new System.Drawing.Point(100, 60);
			this.comboBoxVorHz.Name = "comboBoxVorHz";
			this.comboBoxVorHz.Size = new System.Drawing.Size(140, 20);
			this.comboBoxVorHz.TabIndex = 21;
			this.toolTip.SetToolTip(this.comboBoxVorHz, "サンプリングレートを低くするとqオプションにおいてのビットレートが変わります。");
			// 
			// tabControlVor
			// 
			this.tabControlVor.Controls.Add(this.tabPageVorQB);
			this.tabControlVor.Controls.Add(this.tabPageVorABR);
			this.tabControlVor.Controls.Add(this.tabPageVorCBR);
			this.tabControlVor.Location = new System.Drawing.Point(252, 12);
			this.tabControlVor.Multiline = true;
			this.tabControlVor.Name = "tabControlVor";
			this.tabControlVor.SelectedIndex = 0;
			this.tabControlVor.Size = new System.Drawing.Size(228, 220);
			this.tabControlVor.TabIndex = 19;
			// 
			// tabPageVorQB
			// 
			this.tabPageVorQB.Controls.Add(this.labelVorbisBitrate);
			this.tabPageVorQB.Controls.Add(this.label15);
			this.tabPageVorQB.Controls.Add(this.textBoxVorQValue);
			this.tabPageVorQB.Controls.Add(this.label22);
			this.tabPageVorQB.Controls.Add(this.hScrollBarVorQBValue);
			this.tabPageVorQB.Location = new System.Drawing.Point(4, 21);
			this.tabPageVorQB.Name = "tabPageVorQB";
			this.tabPageVorQB.Size = new System.Drawing.Size(220, 195);
			this.tabPageVorQB.TabIndex = 0;
			this.tabPageVorQB.Text = "固定品質";
			// 
			// labelVorbisBitrate
			// 
			this.labelVorbisBitrate.AutoSize = true;
			this.labelVorbisBitrate.Location = new System.Drawing.Point(36, 80);
			this.labelVorbisBitrate.Name = "labelVorbisBitrate";
			this.labelVorbisBitrate.Size = new System.Drawing.Size(30, 15);
			this.labelVorbisBitrate.TabIndex = 16;
			this.labelVorbisBitrate.Text = "Kbps";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(12, 60);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(17, 15);
			this.label15.TabIndex = 8;
			this.label15.Text = "-q";
			// 
			// textBoxVorQValue
			// 
			this.textBoxVorQValue.Location = new System.Drawing.Point(36, 56);
			this.textBoxVorQValue.MaxLength = 4;
			this.textBoxVorQValue.Name = "textBoxVorQValue";
			this.textBoxVorQValue.Size = new System.Drawing.Size(36, 19);
			this.textBoxVorQValue.TabIndex = 15;
			this.textBoxVorQValue.Text = "";
			this.toolTip.SetToolTip(this.textBoxVorQValue, "MP3とは違いqが大きいほど品質が向上します。");
			this.textBoxVorQValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVorQValue_KeyPress);
			this.textBoxVorQValue.TextChanged += new System.EventHandler(this.textBoxVorQValue_TextChanged);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(8, 16);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(160, 15);
			this.label22.TabIndex = 8;
			this.label22.Text = "スライドして品質を決めてください";
			// 
			// hScrollBarVorQBValue
			// 
			this.hScrollBarVorQBValue.LargeChange = 50;
			this.hScrollBarVorQBValue.Location = new System.Drawing.Point(8, 36);
			this.hScrollBarVorQBValue.Maximum = 1049;
			this.hScrollBarVorQBValue.Minimum = -100;
			this.hScrollBarVorQBValue.Name = "hScrollBarVorQBValue";
			this.hScrollBarVorQBValue.Size = new System.Drawing.Size(204, 14);
			this.hScrollBarVorQBValue.TabIndex = 0;
			this.toolTip.SetToolTip(this.hScrollBarVorQBValue, "MP3とは違いqが大きいほど品質が向上します。");
			this.hScrollBarVorQBValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarVorQBValue_Scroll);
			// 
			// tabPageVorABR
			// 
			this.tabPageVorABR.Controls.Add(this.comboBoxVorABRMinBit);
			this.tabPageVorABR.Controls.Add(this.label16);
			this.tabPageVorABR.Controls.Add(this.comboBoxVorABRMaxBit);
			this.tabPageVorABR.Controls.Add(this.label17);
			this.tabPageVorABR.Controls.Add(this.comboBoxVorABRBit);
			this.tabPageVorABR.Controls.Add(this.label19);
			this.tabPageVorABR.Location = new System.Drawing.Point(4, 21);
			this.tabPageVorABR.Name = "tabPageVorABR";
			this.tabPageVorABR.Size = new System.Drawing.Size(220, 195);
			this.tabPageVorABR.TabIndex = 1;
			this.tabPageVorABR.Text = "ABR";
			// 
			// comboBoxVorABRMinBit
			// 
			this.comboBoxVorABRMinBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVorABRMinBit.DropDownWidth = 120;
			this.comboBoxVorABRMinBit.Items.AddRange(new object[] {
																	  "45 Kbps",
																	  "46 Kbps",
																	  "47 Kbps",
																	  "48 Kbps",
																	  "49 Kbps",
																	  "50 Kbps",
																	  "51 Kbps",
																	  "52 Kbps",
																	  "53 Kbps",
																	  "54 Kbps",
																	  "55 Kbps",
																	  "56 Kbps",
																	  "57 Kbps",
																	  "58 Kbps",
																	  "59 Kbps",
																	  "60 Kbps",
																	  "61 Kbps",
																	  "62 Kbps",
																	  "63 Kbps",
																	  "64 Kbps",
																	  "65 Kbps",
																	  "66 Kbps",
																	  "67 Kbps",
																	  "68 Kbps",
																	  "69 Kbps",
																	  "70 Kbps",
																	  "71 Kbps",
																	  "72 Kbps",
																	  "73 Kbps",
																	  "74 Kbps",
																	  "75 Kbps",
																	  "76 Kbps",
																	  "77 Kbps",
																	  "78 Kbps",
																	  "79 Kbps",
																	  "80 Kbps",
																	  "81 Kbps",
																	  "82 Kbps",
																	  "83 Kbps",
																	  "84 Kbps",
																	  "85 Kbps",
																	  "86 Kbps",
																	  "87 Kbps",
																	  "88 Kbps",
																	  "89 Kbps",
																	  "90 Kbps",
																	  "91 Kbps",
																	  "92 Kbps",
																	  "93 Kbps",
																	  "94 Kbps",
																	  "95 Kbps",
																	  "96 Kbps",
																	  "97 Kbps",
																	  "98 Kbps",
																	  "99 Kbps",
																	  "100 Kbps",
																	  "101 Kbps",
																	  "102 Kbps",
																	  "103 Kbps",
																	  "104 Kbps",
																	  "105 Kbps",
																	  "106 Kbps",
																	  "107 Kbps",
																	  "108 Kbps",
																	  "109 Kbps",
																	  "110 Kbps",
																	  "111 Kbps",
																	  "112 Kbps",
																	  "113 Kbps",
																	  "114 Kbps",
																	  "115 Kbps",
																	  "116 Kbps",
																	  "117 Kbps",
																	  "118 Kbps",
																	  "119 Kbps",
																	  "120 Kbps",
																	  "121 Kbps",
																	  "122 Kbps",
																	  "123 Kbps",
																	  "124 Kbps",
																	  "125 Kbps",
																	  "126 Kbps",
																	  "127 Kbps",
																	  "128 Kbps",
																	  "129 Kbps",
																	  "130 Kbps",
																	  "131 Kbps",
																	  "132 Kbps",
																	  "133 Kbps",
																	  "134 Kbps",
																	  "135 Kbps",
																	  "136 Kbps",
																	  "137 Kbps",
																	  "138 Kbps",
																	  "139 Kbps",
																	  "140 Kbps",
																	  "141 Kbps",
																	  "142 Kbps",
																	  "143 Kbps",
																	  "144 Kbps",
																	  "145 Kbps",
																	  "146 Kbps",
																	  "147 Kbps",
																	  "148 Kbps",
																	  "149 Kbps",
																	  "150 Kbps",
																	  "151 Kbps",
																	  "152 Kbps",
																	  "153 Kbps",
																	  "154 Kbps",
																	  "155 Kbps",
																	  "156 Kbps",
																	  "157 Kbps",
																	  "158 Kbps",
																	  "159 Kbps",
																	  "160 Kbps",
																	  "161 Kbps",
																	  "162 Kbps",
																	  "163 Kbps",
																	  "164 Kbps",
																	  "165 Kbps",
																	  "166 Kbps",
																	  "167 Kbps",
																	  "168 Kbps",
																	  "169 Kbps",
																	  "170 Kbps",
																	  "171 Kbps",
																	  "172 Kbps",
																	  "173 Kbps",
																	  "174 Kbps",
																	  "175 Kbps",
																	  "176 Kbps",
																	  "177 Kbps",
																	  "178 Kbps",
																	  "179 Kbps",
																	  "180 Kbps",
																	  "181 Kbps",
																	  "182 Kbps",
																	  "183 Kbps",
																	  "184 Kbps",
																	  "185 Kbps",
																	  "186 Kbps",
																	  "187 Kbps",
																	  "188 Kbps",
																	  "189 Kbps",
																	  "190 Kbps",
																	  "191 Kbps",
																	  "192 Kbps",
																	  "193 Kbps",
																	  "194 Kbps",
																	  "195 Kbps",
																	  "196 Kbps",
																	  "197 Kbps",
																	  "198 Kbps",
																	  "199 Kbps",
																	  "200 Kbps",
																	  "201 Kbps",
																	  "202 Kbps",
																	  "203 Kbps",
																	  "204 Kbps",
																	  "205 Kbps",
																	  "206 Kbps",
																	  "207 Kbps",
																	  "208 Kbps",
																	  "209 Kbps",
																	  "210 Kbps",
																	  "211 Kbps",
																	  "212 Kbps",
																	  "213 Kbps",
																	  "214 Kbps",
																	  "215 Kbps",
																	  "216 Kbps",
																	  "217 Kbps",
																	  "218 Kbps",
																	  "219 Kbps",
																	  "220 Kbps",
																	  "221 Kbps",
																	  "222 Kbps",
																	  "223 Kbps",
																	  "224 Kbps",
																	  "225 Kbps",
																	  "226 Kbps",
																	  "227 Kbps",
																	  "228 Kbps",
																	  "229 Kbps",
																	  "230 Kbps",
																	  "231 Kbps",
																	  "232 Kbps",
																	  "233 Kbps",
																	  "234 Kbps",
																	  "235 Kbps",
																	  "236 Kbps",
																	  "237 Kbps",
																	  "238 Kbps",
																	  "239 Kbps",
																	  "240 Kbps",
																	  "241 Kbps",
																	  "242 Kbps",
																	  "243 Kbps",
																	  "244 Kbps",
																	  "245 Kbps",
																	  "246 Kbps",
																	  "247 Kbps",
																	  "248 Kbps",
																	  "249 Kbps",
																	  "250 Kbps",
																	  "251 Kbps",
																	  "252 Kbps",
																	  "253 Kbps",
																	  "254 Kbps",
																	  "255 Kbps",
																	  "256 Kbps",
																	  "257 Kbps",
																	  "258 Kbps",
																	  "259 Kbps",
																	  "260 Kbps",
																	  "261 Kbps",
																	  "262 Kbps",
																	  "263 Kbps",
																	  "264 Kbps",
																	  "265 Kbps",
																	  "266 Kbps",
																	  "267 Kbps",
																	  "268 Kbps",
																	  "269 Kbps",
																	  "270 Kbps",
																	  "271 Kbps",
																	  "272 Kbps",
																	  "273 Kbps",
																	  "274 Kbps",
																	  "275 Kbps",
																	  "276 Kbps",
																	  "277 Kbps",
																	  "278 Kbps",
																	  "279 Kbps",
																	  "280 Kbps",
																	  "281 Kbps",
																	  "282 Kbps",
																	  "283 Kbps",
																	  "284 Kbps",
																	  "285 Kbps",
																	  "286 Kbps",
																	  "287 Kbps",
																	  "288 Kbps",
																	  "289 Kbps",
																	  "290 Kbps",
																	  "291 Kbps",
																	  "292 Kbps",
																	  "293 Kbps",
																	  "294 Kbps",
																	  "295 Kbps",
																	  "296 Kbps",
																	  "297 Kbps",
																	  "298 Kbps",
																	  "299 Kbps",
																	  "300 Kbps",
																	  "301 Kbps",
																	  "302 Kbps",
																	  "303 Kbps",
																	  "304 Kbps",
																	  "305 Kbps",
																	  "306 Kbps",
																	  "307 Kbps",
																	  "308 Kbps",
																	  "309 Kbps",
																	  "310 Kbps",
																	  "311 Kbps",
																	  "312 Kbps",
																	  "313 Kbps",
																	  "314 Kbps",
																	  "315 Kbps",
																	  "316 Kbps",
																	  "317 Kbps",
																	  "318 Kbps",
																	  "319 Kbps",
																	  "320 Kbps",
																	  "321 Kbps",
																	  "322 Kbps",
																	  "323 Kbps",
																	  "324 Kbps",
																	  "325 Kbps",
																	  "326 Kbps",
																	  "327 Kbps",
																	  "328 Kbps",
																	  "329 Kbps",
																	  "330 Kbps",
																	  "331 Kbps",
																	  "332 Kbps",
																	  "333 Kbps",
																	  "334 Kbps",
																	  "335 Kbps",
																	  "336 Kbps",
																	  "337 Kbps",
																	  "338 Kbps",
																	  "339 Kbps",
																	  "340 Kbps",
																	  "341 Kbps",
																	  "342 Kbps",
																	  "343 Kbps",
																	  "344 Kbps",
																	  "345 Kbps",
																	  "346 Kbps",
																	  "347 Kbps",
																	  "348 Kbps",
																	  "349 Kbps",
																	  "350 Kbps",
																	  "351 Kbps",
																	  "352 Kbps",
																	  "353 Kbps",
																	  "354 Kbps",
																	  "355 Kbps",
																	  "356 Kbps",
																	  "357 Kbps",
																	  "358 Kbps",
																	  "359 Kbps",
																	  "360 Kbps",
																	  "361 Kbps",
																	  "362 Kbps",
																	  "363 Kbps",
																	  "364 Kbps",
																	  "365 Kbps",
																	  "366 Kbps",
																	  "367 Kbps",
																	  "368 Kbps",
																	  "369 Kbps",
																	  "370 Kbps",
																	  "371 Kbps",
																	  "372 Kbps",
																	  "373 Kbps",
																	  "374 Kbps",
																	  "375 Kbps",
																	  "376 Kbps",
																	  "377 Kbps",
																	  "378 Kbps",
																	  "379 Kbps",
																	  "380 Kbps",
																	  "381 Kbps",
																	  "382 Kbps",
																	  "383 Kbps",
																	  "384 Kbps",
																	  "385 Kbps",
																	  "386 Kbps",
																	  "387 Kbps",
																	  "388 Kbps",
																	  "389 Kbps",
																	  "390 Kbps",
																	  "391 Kbps",
																	  "392 Kbps",
																	  "393 Kbps",
																	  "394 Kbps",
																	  "395 Kbps",
																	  "396 Kbps",
																	  "397 Kbps",
																	  "398 Kbps",
																	  "399 Kbps",
																	  "400 Kbps",
																	  "401 Kbps",
																	  "402 Kbps",
																	  "403 Kbps",
																	  "404 Kbps",
																	  "405 Kbps",
																	  "406 Kbps",
																	  "407 Kbps",
																	  "408 Kbps",
																	  "409 Kbps",
																	  "410 Kbps",
																	  "411 Kbps",
																	  "412 Kbps",
																	  "413 Kbps",
																	  "414 Kbps",
																	  "415 Kbps",
																	  "416 Kbps",
																	  "417 Kbps",
																	  "418 Kbps",
																	  "419 Kbps",
																	  "420 Kbps",
																	  "421 Kbps",
																	  "422 Kbps",
																	  "423 Kbps",
																	  "424 Kbps",
																	  "425 Kbps",
																	  "426 Kbps",
																	  "427 Kbps",
																	  "428 Kbps",
																	  "429 Kbps",
																	  "430 Kbps",
																	  "431 Kbps",
																	  "432 Kbps",
																	  "433 Kbps",
																	  "434 Kbps",
																	  "435 Kbps",
																	  "436 Kbps",
																	  "437 Kbps",
																	  "438 Kbps",
																	  "439 Kbps",
																	  "440 Kbps",
																	  "441 Kbps",
																	  "442 Kbps",
																	  "443 Kbps",
																	  "444 Kbps",
																	  "445 Kbps",
																	  "446 Kbps",
																	  "447 Kbps",
																	  "448 Kbps",
																	  "449 Kbps",
																	  "450 Kbps",
																	  "451 Kbps",
																	  "452 Kbps",
																	  "453 Kbps",
																	  "454 Kbps",
																	  "455 Kbps",
																	  "456 Kbps",
																	  "457 Kbps",
																	  "458 Kbps",
																	  "459 Kbps",
																	  "460 Kbps",
																	  "461 Kbps",
																	  "462 Kbps",
																	  "463 Kbps",
																	  "464 Kbps",
																	  "465 Kbps",
																	  "466 Kbps",
																	  "467 Kbps",
																	  "468 Kbps",
																	  "469 Kbps",
																	  "470 Kbps",
																	  "471 Kbps",
																	  "472 Kbps",
																	  "473 Kbps",
																	  "474 Kbps",
																	  "475 Kbps",
																	  "476 Kbps",
																	  "477 Kbps",
																	  "478 Kbps",
																	  "479 Kbps",
																	  "480 Kbps",
																	  "481 Kbps",
																	  "482 Kbps",
																	  "483 Kbps",
																	  "484 Kbps",
																	  "485 Kbps",
																	  "486 Kbps",
																	  "487 Kbps",
																	  "488 Kbps",
																	  "489 Kbps",
																	  "490 Kbps",
																	  "491 Kbps",
																	  "492 Kbps",
																	  "493 Kbps",
																	  "494 Kbps",
																	  "495 Kbps",
																	  "496 Kbps",
																	  "497 Kbps",
																	  "498 Kbps",
																	  "499 Kbps",
																	  "500 Kbps"});
			this.comboBoxVorABRMinBit.Location = new System.Drawing.Point(96, 40);
			this.comboBoxVorABRMinBit.Name = "comboBoxVorABRMinBit";
			this.comboBoxVorABRMinBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxVorABRMinBit.TabIndex = 17;
			this.toolTip.SetToolTip(this.comboBoxVorABRMinBit, "ビットレート変動においての最小ビットレートを選択してください。");
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 44);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(82, 15);
			this.label16.TabIndex = 16;
			this.label16.Text = "下限ビットレート";
			// 
			// comboBoxVorABRMaxBit
			// 
			this.comboBoxVorABRMaxBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVorABRMaxBit.Items.AddRange(new object[] {
																	  "45 Kbps",
																	  "46 Kbps",
																	  "47 Kbps",
																	  "48 Kbps",
																	  "49 Kbps",
																	  "50 Kbps",
																	  "51 Kbps",
																	  "52 Kbps",
																	  "53 Kbps",
																	  "54 Kbps",
																	  "55 Kbps",
																	  "56 Kbps",
																	  "57 Kbps",
																	  "58 Kbps",
																	  "59 Kbps",
																	  "60 Kbps",
																	  "61 Kbps",
																	  "62 Kbps",
																	  "63 Kbps",
																	  "64 Kbps",
																	  "65 Kbps",
																	  "66 Kbps",
																	  "67 Kbps",
																	  "68 Kbps",
																	  "69 Kbps",
																	  "70 Kbps",
																	  "71 Kbps",
																	  "72 Kbps",
																	  "73 Kbps",
																	  "74 Kbps",
																	  "75 Kbps",
																	  "76 Kbps",
																	  "77 Kbps",
																	  "78 Kbps",
																	  "79 Kbps",
																	  "80 Kbps",
																	  "81 Kbps",
																	  "82 Kbps",
																	  "83 Kbps",
																	  "84 Kbps",
																	  "85 Kbps",
																	  "86 Kbps",
																	  "87 Kbps",
																	  "88 Kbps",
																	  "89 Kbps",
																	  "90 Kbps",
																	  "91 Kbps",
																	  "92 Kbps",
																	  "93 Kbps",
																	  "94 Kbps",
																	  "95 Kbps",
																	  "96 Kbps",
																	  "97 Kbps",
																	  "98 Kbps",
																	  "99 Kbps",
																	  "100 Kbps",
																	  "101 Kbps",
																	  "102 Kbps",
																	  "103 Kbps",
																	  "104 Kbps",
																	  "105 Kbps",
																	  "106 Kbps",
																	  "107 Kbps",
																	  "108 Kbps",
																	  "109 Kbps",
																	  "110 Kbps",
																	  "111 Kbps",
																	  "112 Kbps",
																	  "113 Kbps",
																	  "114 Kbps",
																	  "115 Kbps",
																	  "116 Kbps",
																	  "117 Kbps",
																	  "118 Kbps",
																	  "119 Kbps",
																	  "120 Kbps",
																	  "121 Kbps",
																	  "122 Kbps",
																	  "123 Kbps",
																	  "124 Kbps",
																	  "125 Kbps",
																	  "126 Kbps",
																	  "127 Kbps",
																	  "128 Kbps",
																	  "129 Kbps",
																	  "130 Kbps",
																	  "131 Kbps",
																	  "132 Kbps",
																	  "133 Kbps",
																	  "134 Kbps",
																	  "135 Kbps",
																	  "136 Kbps",
																	  "137 Kbps",
																	  "138 Kbps",
																	  "139 Kbps",
																	  "140 Kbps",
																	  "141 Kbps",
																	  "142 Kbps",
																	  "143 Kbps",
																	  "144 Kbps",
																	  "145 Kbps",
																	  "146 Kbps",
																	  "147 Kbps",
																	  "148 Kbps",
																	  "149 Kbps",
																	  "150 Kbps",
																	  "151 Kbps",
																	  "152 Kbps",
																	  "153 Kbps",
																	  "154 Kbps",
																	  "155 Kbps",
																	  "156 Kbps",
																	  "157 Kbps",
																	  "158 Kbps",
																	  "159 Kbps",
																	  "160 Kbps",
																	  "161 Kbps",
																	  "162 Kbps",
																	  "163 Kbps",
																	  "164 Kbps",
																	  "165 Kbps",
																	  "166 Kbps",
																	  "167 Kbps",
																	  "168 Kbps",
																	  "169 Kbps",
																	  "170 Kbps",
																	  "171 Kbps",
																	  "172 Kbps",
																	  "173 Kbps",
																	  "174 Kbps",
																	  "175 Kbps",
																	  "176 Kbps",
																	  "177 Kbps",
																	  "178 Kbps",
																	  "179 Kbps",
																	  "180 Kbps",
																	  "181 Kbps",
																	  "182 Kbps",
																	  "183 Kbps",
																	  "184 Kbps",
																	  "185 Kbps",
																	  "186 Kbps",
																	  "187 Kbps",
																	  "188 Kbps",
																	  "189 Kbps",
																	  "190 Kbps",
																	  "191 Kbps",
																	  "192 Kbps",
																	  "193 Kbps",
																	  "194 Kbps",
																	  "195 Kbps",
																	  "196 Kbps",
																	  "197 Kbps",
																	  "198 Kbps",
																	  "199 Kbps",
																	  "200 Kbps",
																	  "201 Kbps",
																	  "202 Kbps",
																	  "203 Kbps",
																	  "204 Kbps",
																	  "205 Kbps",
																	  "206 Kbps",
																	  "207 Kbps",
																	  "208 Kbps",
																	  "209 Kbps",
																	  "210 Kbps",
																	  "211 Kbps",
																	  "212 Kbps",
																	  "213 Kbps",
																	  "214 Kbps",
																	  "215 Kbps",
																	  "216 Kbps",
																	  "217 Kbps",
																	  "218 Kbps",
																	  "219 Kbps",
																	  "220 Kbps",
																	  "221 Kbps",
																	  "222 Kbps",
																	  "223 Kbps",
																	  "224 Kbps",
																	  "225 Kbps",
																	  "226 Kbps",
																	  "227 Kbps",
																	  "228 Kbps",
																	  "229 Kbps",
																	  "230 Kbps",
																	  "231 Kbps",
																	  "232 Kbps",
																	  "233 Kbps",
																	  "234 Kbps",
																	  "235 Kbps",
																	  "236 Kbps",
																	  "237 Kbps",
																	  "238 Kbps",
																	  "239 Kbps",
																	  "240 Kbps",
																	  "241 Kbps",
																	  "242 Kbps",
																	  "243 Kbps",
																	  "244 Kbps",
																	  "245 Kbps",
																	  "246 Kbps",
																	  "247 Kbps",
																	  "248 Kbps",
																	  "249 Kbps",
																	  "250 Kbps",
																	  "251 Kbps",
																	  "252 Kbps",
																	  "253 Kbps",
																	  "254 Kbps",
																	  "255 Kbps",
																	  "256 Kbps",
																	  "257 Kbps",
																	  "258 Kbps",
																	  "259 Kbps",
																	  "260 Kbps",
																	  "261 Kbps",
																	  "262 Kbps",
																	  "263 Kbps",
																	  "264 Kbps",
																	  "265 Kbps",
																	  "266 Kbps",
																	  "267 Kbps",
																	  "268 Kbps",
																	  "269 Kbps",
																	  "270 Kbps",
																	  "271 Kbps",
																	  "272 Kbps",
																	  "273 Kbps",
																	  "274 Kbps",
																	  "275 Kbps",
																	  "276 Kbps",
																	  "277 Kbps",
																	  "278 Kbps",
																	  "279 Kbps",
																	  "280 Kbps",
																	  "281 Kbps",
																	  "282 Kbps",
																	  "283 Kbps",
																	  "284 Kbps",
																	  "285 Kbps",
																	  "286 Kbps",
																	  "287 Kbps",
																	  "288 Kbps",
																	  "289 Kbps",
																	  "290 Kbps",
																	  "291 Kbps",
																	  "292 Kbps",
																	  "293 Kbps",
																	  "294 Kbps",
																	  "295 Kbps",
																	  "296 Kbps",
																	  "297 Kbps",
																	  "298 Kbps",
																	  "299 Kbps",
																	  "300 Kbps",
																	  "301 Kbps",
																	  "302 Kbps",
																	  "303 Kbps",
																	  "304 Kbps",
																	  "305 Kbps",
																	  "306 Kbps",
																	  "307 Kbps",
																	  "308 Kbps",
																	  "309 Kbps",
																	  "310 Kbps",
																	  "311 Kbps",
																	  "312 Kbps",
																	  "313 Kbps",
																	  "314 Kbps",
																	  "315 Kbps",
																	  "316 Kbps",
																	  "317 Kbps",
																	  "318 Kbps",
																	  "319 Kbps",
																	  "320 Kbps",
																	  "321 Kbps",
																	  "322 Kbps",
																	  "323 Kbps",
																	  "324 Kbps",
																	  "325 Kbps",
																	  "326 Kbps",
																	  "327 Kbps",
																	  "328 Kbps",
																	  "329 Kbps",
																	  "330 Kbps",
																	  "331 Kbps",
																	  "332 Kbps",
																	  "333 Kbps",
																	  "334 Kbps",
																	  "335 Kbps",
																	  "336 Kbps",
																	  "337 Kbps",
																	  "338 Kbps",
																	  "339 Kbps",
																	  "340 Kbps",
																	  "341 Kbps",
																	  "342 Kbps",
																	  "343 Kbps",
																	  "344 Kbps",
																	  "345 Kbps",
																	  "346 Kbps",
																	  "347 Kbps",
																	  "348 Kbps",
																	  "349 Kbps",
																	  "350 Kbps",
																	  "351 Kbps",
																	  "352 Kbps",
																	  "353 Kbps",
																	  "354 Kbps",
																	  "355 Kbps",
																	  "356 Kbps",
																	  "357 Kbps",
																	  "358 Kbps",
																	  "359 Kbps",
																	  "360 Kbps",
																	  "361 Kbps",
																	  "362 Kbps",
																	  "363 Kbps",
																	  "364 Kbps",
																	  "365 Kbps",
																	  "366 Kbps",
																	  "367 Kbps",
																	  "368 Kbps",
																	  "369 Kbps",
																	  "370 Kbps",
																	  "371 Kbps",
																	  "372 Kbps",
																	  "373 Kbps",
																	  "374 Kbps",
																	  "375 Kbps",
																	  "376 Kbps",
																	  "377 Kbps",
																	  "378 Kbps",
																	  "379 Kbps",
																	  "380 Kbps",
																	  "381 Kbps",
																	  "382 Kbps",
																	  "383 Kbps",
																	  "384 Kbps",
																	  "385 Kbps",
																	  "386 Kbps",
																	  "387 Kbps",
																	  "388 Kbps",
																	  "389 Kbps",
																	  "390 Kbps",
																	  "391 Kbps",
																	  "392 Kbps",
																	  "393 Kbps",
																	  "394 Kbps",
																	  "395 Kbps",
																	  "396 Kbps",
																	  "397 Kbps",
																	  "398 Kbps",
																	  "399 Kbps",
																	  "400 Kbps",
																	  "401 Kbps",
																	  "402 Kbps",
																	  "403 Kbps",
																	  "404 Kbps",
																	  "405 Kbps",
																	  "406 Kbps",
																	  "407 Kbps",
																	  "408 Kbps",
																	  "409 Kbps",
																	  "410 Kbps",
																	  "411 Kbps",
																	  "412 Kbps",
																	  "413 Kbps",
																	  "414 Kbps",
																	  "415 Kbps",
																	  "416 Kbps",
																	  "417 Kbps",
																	  "418 Kbps",
																	  "419 Kbps",
																	  "420 Kbps",
																	  "421 Kbps",
																	  "422 Kbps",
																	  "423 Kbps",
																	  "424 Kbps",
																	  "425 Kbps",
																	  "426 Kbps",
																	  "427 Kbps",
																	  "428 Kbps",
																	  "429 Kbps",
																	  "430 Kbps",
																	  "431 Kbps",
																	  "432 Kbps",
																	  "433 Kbps",
																	  "434 Kbps",
																	  "435 Kbps",
																	  "436 Kbps",
																	  "437 Kbps",
																	  "438 Kbps",
																	  "439 Kbps",
																	  "440 Kbps",
																	  "441 Kbps",
																	  "442 Kbps",
																	  "443 Kbps",
																	  "444 Kbps",
																	  "445 Kbps",
																	  "446 Kbps",
																	  "447 Kbps",
																	  "448 Kbps",
																	  "449 Kbps",
																	  "450 Kbps",
																	  "451 Kbps",
																	  "452 Kbps",
																	  "453 Kbps",
																	  "454 Kbps",
																	  "455 Kbps",
																	  "456 Kbps",
																	  "457 Kbps",
																	  "458 Kbps",
																	  "459 Kbps",
																	  "460 Kbps",
																	  "461 Kbps",
																	  "462 Kbps",
																	  "463 Kbps",
																	  "464 Kbps",
																	  "465 Kbps",
																	  "466 Kbps",
																	  "467 Kbps",
																	  "468 Kbps",
																	  "469 Kbps",
																	  "470 Kbps",
																	  "471 Kbps",
																	  "472 Kbps",
																	  "473 Kbps",
																	  "474 Kbps",
																	  "475 Kbps",
																	  "476 Kbps",
																	  "477 Kbps",
																	  "478 Kbps",
																	  "479 Kbps",
																	  "480 Kbps",
																	  "481 Kbps",
																	  "482 Kbps",
																	  "483 Kbps",
																	  "484 Kbps",
																	  "485 Kbps",
																	  "486 Kbps",
																	  "487 Kbps",
																	  "488 Kbps",
																	  "489 Kbps",
																	  "490 Kbps",
																	  "491 Kbps",
																	  "492 Kbps",
																	  "493 Kbps",
																	  "494 Kbps",
																	  "495 Kbps",
																	  "496 Kbps",
																	  "497 Kbps",
																	  "498 Kbps",
																	  "499 Kbps",
																	  "500 Kbps"});
			this.comboBoxVorABRMaxBit.Location = new System.Drawing.Point(96, 68);
			this.comboBoxVorABRMaxBit.Name = "comboBoxVorABRMaxBit";
			this.comboBoxVorABRMaxBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxVorABRMaxBit.TabIndex = 15;
			this.toolTip.SetToolTip(this.comboBoxVorABRMaxBit, "ビットレート変動においての最大ビットレートを選択してください。");
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(8, 72);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(82, 15);
			this.label17.TabIndex = 14;
			this.label17.Text = "上限ビットレート";
			// 
			// comboBoxVorABRBit
			// 
			this.comboBoxVorABRBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVorABRBit.Items.AddRange(new object[] {
																   "45 Kbps",
																   "46 Kbps",
																   "47 Kbps",
																   "48 Kbps",
																   "49 Kbps",
																   "50 Kbps",
																   "51 Kbps",
																   "52 Kbps",
																   "53 Kbps",
																   "54 Kbps",
																   "55 Kbps",
																   "56 Kbps",
																   "57 Kbps",
																   "58 Kbps",
																   "59 Kbps",
																   "60 Kbps",
																   "61 Kbps",
																   "62 Kbps",
																   "63 Kbps",
																   "64 Kbps",
																   "65 Kbps",
																   "66 Kbps",
																   "67 Kbps",
																   "68 Kbps",
																   "69 Kbps",
																   "70 Kbps",
																   "71 Kbps",
																   "72 Kbps",
																   "73 Kbps",
																   "74 Kbps",
																   "75 Kbps",
																   "76 Kbps",
																   "77 Kbps",
																   "78 Kbps",
																   "79 Kbps",
																   "80 Kbps",
																   "81 Kbps",
																   "82 Kbps",
																   "83 Kbps",
																   "84 Kbps",
																   "85 Kbps",
																   "86 Kbps",
																   "87 Kbps",
																   "88 Kbps",
																   "89 Kbps",
																   "90 Kbps",
																   "91 Kbps",
																   "92 Kbps",
																   "93 Kbps",
																   "94 Kbps",
																   "95 Kbps",
																   "96 Kbps",
																   "97 Kbps",
																   "98 Kbps",
																   "99 Kbps",
																   "100 Kbps",
																   "101 Kbps",
																   "102 Kbps",
																   "103 Kbps",
																   "104 Kbps",
																   "105 Kbps",
																   "106 Kbps",
																   "107 Kbps",
																   "108 Kbps",
																   "109 Kbps",
																   "110 Kbps",
																   "111 Kbps",
																   "112 Kbps",
																   "113 Kbps",
																   "114 Kbps",
																   "115 Kbps",
																   "116 Kbps",
																   "117 Kbps",
																   "118 Kbps",
																   "119 Kbps",
																   "120 Kbps",
																   "121 Kbps",
																   "122 Kbps",
																   "123 Kbps",
																   "124 Kbps",
																   "125 Kbps",
																   "126 Kbps",
																   "127 Kbps",
																   "128 Kbps",
																   "129 Kbps",
																   "130 Kbps",
																   "131 Kbps",
																   "132 Kbps",
																   "133 Kbps",
																   "134 Kbps",
																   "135 Kbps",
																   "136 Kbps",
																   "137 Kbps",
																   "138 Kbps",
																   "139 Kbps",
																   "140 Kbps",
																   "141 Kbps",
																   "142 Kbps",
																   "143 Kbps",
																   "144 Kbps",
																   "145 Kbps",
																   "146 Kbps",
																   "147 Kbps",
																   "148 Kbps",
																   "149 Kbps",
																   "150 Kbps",
																   "151 Kbps",
																   "152 Kbps",
																   "153 Kbps",
																   "154 Kbps",
																   "155 Kbps",
																   "156 Kbps",
																   "157 Kbps",
																   "158 Kbps",
																   "159 Kbps",
																   "160 Kbps",
																   "161 Kbps",
																   "162 Kbps",
																   "163 Kbps",
																   "164 Kbps",
																   "165 Kbps",
																   "166 Kbps",
																   "167 Kbps",
																   "168 Kbps",
																   "169 Kbps",
																   "170 Kbps",
																   "171 Kbps",
																   "172 Kbps",
																   "173 Kbps",
																   "174 Kbps",
																   "175 Kbps",
																   "176 Kbps",
																   "177 Kbps",
																   "178 Kbps",
																   "179 Kbps",
																   "180 Kbps",
																   "181 Kbps",
																   "182 Kbps",
																   "183 Kbps",
																   "184 Kbps",
																   "185 Kbps",
																   "186 Kbps",
																   "187 Kbps",
																   "188 Kbps",
																   "189 Kbps",
																   "190 Kbps",
																   "191 Kbps",
																   "192 Kbps",
																   "193 Kbps",
																   "194 Kbps",
																   "195 Kbps",
																   "196 Kbps",
																   "197 Kbps",
																   "198 Kbps",
																   "199 Kbps",
																   "200 Kbps",
																   "201 Kbps",
																   "202 Kbps",
																   "203 Kbps",
																   "204 Kbps",
																   "205 Kbps",
																   "206 Kbps",
																   "207 Kbps",
																   "208 Kbps",
																   "209 Kbps",
																   "210 Kbps",
																   "211 Kbps",
																   "212 Kbps",
																   "213 Kbps",
																   "214 Kbps",
																   "215 Kbps",
																   "216 Kbps",
																   "217 Kbps",
																   "218 Kbps",
																   "219 Kbps",
																   "220 Kbps",
																   "221 Kbps",
																   "222 Kbps",
																   "223 Kbps",
																   "224 Kbps",
																   "225 Kbps",
																   "226 Kbps",
																   "227 Kbps",
																   "228 Kbps",
																   "229 Kbps",
																   "230 Kbps",
																   "231 Kbps",
																   "232 Kbps",
																   "233 Kbps",
																   "234 Kbps",
																   "235 Kbps",
																   "236 Kbps",
																   "237 Kbps",
																   "238 Kbps",
																   "239 Kbps",
																   "240 Kbps",
																   "241 Kbps",
																   "242 Kbps",
																   "243 Kbps",
																   "244 Kbps",
																   "245 Kbps",
																   "246 Kbps",
																   "247 Kbps",
																   "248 Kbps",
																   "249 Kbps",
																   "250 Kbps",
																   "251 Kbps",
																   "252 Kbps",
																   "253 Kbps",
																   "254 Kbps",
																   "255 Kbps",
																   "256 Kbps",
																   "257 Kbps",
																   "258 Kbps",
																   "259 Kbps",
																   "260 Kbps",
																   "261 Kbps",
																   "262 Kbps",
																   "263 Kbps",
																   "264 Kbps",
																   "265 Kbps",
																   "266 Kbps",
																   "267 Kbps",
																   "268 Kbps",
																   "269 Kbps",
																   "270 Kbps",
																   "271 Kbps",
																   "272 Kbps",
																   "273 Kbps",
																   "274 Kbps",
																   "275 Kbps",
																   "276 Kbps",
																   "277 Kbps",
																   "278 Kbps",
																   "279 Kbps",
																   "280 Kbps",
																   "281 Kbps",
																   "282 Kbps",
																   "283 Kbps",
																   "284 Kbps",
																   "285 Kbps",
																   "286 Kbps",
																   "287 Kbps",
																   "288 Kbps",
																   "289 Kbps",
																   "290 Kbps",
																   "291 Kbps",
																   "292 Kbps",
																   "293 Kbps",
																   "294 Kbps",
																   "295 Kbps",
																   "296 Kbps",
																   "297 Kbps",
																   "298 Kbps",
																   "299 Kbps",
																   "300 Kbps",
																   "301 Kbps",
																   "302 Kbps",
																   "303 Kbps",
																   "304 Kbps",
																   "305 Kbps",
																   "306 Kbps",
																   "307 Kbps",
																   "308 Kbps",
																   "309 Kbps",
																   "310 Kbps",
																   "311 Kbps",
																   "312 Kbps",
																   "313 Kbps",
																   "314 Kbps",
																   "315 Kbps",
																   "316 Kbps",
																   "317 Kbps",
																   "318 Kbps",
																   "319 Kbps",
																   "320 Kbps",
																   "321 Kbps",
																   "322 Kbps",
																   "323 Kbps",
																   "324 Kbps",
																   "325 Kbps",
																   "326 Kbps",
																   "327 Kbps",
																   "328 Kbps",
																   "329 Kbps",
																   "330 Kbps",
																   "331 Kbps",
																   "332 Kbps",
																   "333 Kbps",
																   "334 Kbps",
																   "335 Kbps",
																   "336 Kbps",
																   "337 Kbps",
																   "338 Kbps",
																   "339 Kbps",
																   "340 Kbps",
																   "341 Kbps",
																   "342 Kbps",
																   "343 Kbps",
																   "344 Kbps",
																   "345 Kbps",
																   "346 Kbps",
																   "347 Kbps",
																   "348 Kbps",
																   "349 Kbps",
																   "350 Kbps",
																   "351 Kbps",
																   "352 Kbps",
																   "353 Kbps",
																   "354 Kbps",
																   "355 Kbps",
																   "356 Kbps",
																   "357 Kbps",
																   "358 Kbps",
																   "359 Kbps",
																   "360 Kbps",
																   "361 Kbps",
																   "362 Kbps",
																   "363 Kbps",
																   "364 Kbps",
																   "365 Kbps",
																   "366 Kbps",
																   "367 Kbps",
																   "368 Kbps",
																   "369 Kbps",
																   "370 Kbps",
																   "371 Kbps",
																   "372 Kbps",
																   "373 Kbps",
																   "374 Kbps",
																   "375 Kbps",
																   "376 Kbps",
																   "377 Kbps",
																   "378 Kbps",
																   "379 Kbps",
																   "380 Kbps",
																   "381 Kbps",
																   "382 Kbps",
																   "383 Kbps",
																   "384 Kbps",
																   "385 Kbps",
																   "386 Kbps",
																   "387 Kbps",
																   "388 Kbps",
																   "389 Kbps",
																   "390 Kbps",
																   "391 Kbps",
																   "392 Kbps",
																   "393 Kbps",
																   "394 Kbps",
																   "395 Kbps",
																   "396 Kbps",
																   "397 Kbps",
																   "398 Kbps",
																   "399 Kbps",
																   "400 Kbps",
																   "401 Kbps",
																   "402 Kbps",
																   "403 Kbps",
																   "404 Kbps",
																   "405 Kbps",
																   "406 Kbps",
																   "407 Kbps",
																   "408 Kbps",
																   "409 Kbps",
																   "410 Kbps",
																   "411 Kbps",
																   "412 Kbps",
																   "413 Kbps",
																   "414 Kbps",
																   "415 Kbps",
																   "416 Kbps",
																   "417 Kbps",
																   "418 Kbps",
																   "419 Kbps",
																   "420 Kbps",
																   "421 Kbps",
																   "422 Kbps",
																   "423 Kbps",
																   "424 Kbps",
																   "425 Kbps",
																   "426 Kbps",
																   "427 Kbps",
																   "428 Kbps",
																   "429 Kbps",
																   "430 Kbps",
																   "431 Kbps",
																   "432 Kbps",
																   "433 Kbps",
																   "434 Kbps",
																   "435 Kbps",
																   "436 Kbps",
																   "437 Kbps",
																   "438 Kbps",
																   "439 Kbps",
																   "440 Kbps",
																   "441 Kbps",
																   "442 Kbps",
																   "443 Kbps",
																   "444 Kbps",
																   "445 Kbps",
																   "446 Kbps",
																   "447 Kbps",
																   "448 Kbps",
																   "449 Kbps",
																   "450 Kbps",
																   "451 Kbps",
																   "452 Kbps",
																   "453 Kbps",
																   "454 Kbps",
																   "455 Kbps",
																   "456 Kbps",
																   "457 Kbps",
																   "458 Kbps",
																   "459 Kbps",
																   "460 Kbps",
																   "461 Kbps",
																   "462 Kbps",
																   "463 Kbps",
																   "464 Kbps",
																   "465 Kbps",
																   "466 Kbps",
																   "467 Kbps",
																   "468 Kbps",
																   "469 Kbps",
																   "470 Kbps",
																   "471 Kbps",
																   "472 Kbps",
																   "473 Kbps",
																   "474 Kbps",
																   "475 Kbps",
																   "476 Kbps",
																   "477 Kbps",
																   "478 Kbps",
																   "479 Kbps",
																   "480 Kbps",
																   "481 Kbps",
																   "482 Kbps",
																   "483 Kbps",
																   "484 Kbps",
																   "485 Kbps",
																   "486 Kbps",
																   "487 Kbps",
																   "488 Kbps",
																   "489 Kbps",
																   "490 Kbps",
																   "491 Kbps",
																   "492 Kbps",
																   "493 Kbps",
																   "494 Kbps",
																   "495 Kbps",
																   "496 Kbps",
																   "497 Kbps",
																   "498 Kbps",
																   "499 Kbps",
																   "500 Kbps"});
			this.comboBoxVorABRBit.Location = new System.Drawing.Point(96, 12);
			this.comboBoxVorABRBit.Name = "comboBoxVorABRBit";
			this.comboBoxVorABRBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxVorABRBit.TabIndex = 13;
			this.toolTip.SetToolTip(this.comboBoxVorABRBit, "目標ビットレートを指定してください。ビットレートの平均値が大体この値になります。");
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(8, 16);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(82, 15);
			this.label19.TabIndex = 12;
			this.label19.Text = "目標ビットレート";
			// 
			// tabPageVorCBR
			// 
			this.tabPageVorCBR.Controls.Add(this.label20);
			this.tabPageVorCBR.Controls.Add(this.comboBoxVorCBRBit);
			this.tabPageVorCBR.Location = new System.Drawing.Point(4, 21);
			this.tabPageVorCBR.Name = "tabPageVorCBR";
			this.tabPageVorCBR.Size = new System.Drawing.Size(220, 195);
			this.tabPageVorCBR.TabIndex = 2;
			this.tabPageVorCBR.Text = "CBR";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(8, 16);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(82, 15);
			this.label20.TabIndex = 14;
			this.label20.Text = "目標ビットレート";
			// 
			// comboBoxVorCBRBit
			// 
			this.comboBoxVorCBRBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVorCBRBit.Items.AddRange(new object[] {
																   "45 Kbps",
																   "46 Kbps",
																   "47 Kbps",
																   "48 Kbps",
																   "49 Kbps",
																   "50 Kbps",
																   "51 Kbps",
																   "52 Kbps",
																   "53 Kbps",
																   "54 Kbps",
																   "55 Kbps",
																   "56 Kbps",
																   "57 Kbps",
																   "58 Kbps",
																   "59 Kbps",
																   "60 Kbps",
																   "61 Kbps",
																   "62 Kbps",
																   "63 Kbps",
																   "64 Kbps",
																   "65 Kbps",
																   "66 Kbps",
																   "67 Kbps",
																   "68 Kbps",
																   "69 Kbps",
																   "70 Kbps",
																   "71 Kbps",
																   "72 Kbps",
																   "73 Kbps",
																   "74 Kbps",
																   "75 Kbps",
																   "76 Kbps",
																   "77 Kbps",
																   "78 Kbps",
																   "79 Kbps",
																   "80 Kbps",
																   "81 Kbps",
																   "82 Kbps",
																   "83 Kbps",
																   "84 Kbps",
																   "85 Kbps",
																   "86 Kbps",
																   "87 Kbps",
																   "88 Kbps",
																   "89 Kbps",
																   "90 Kbps",
																   "91 Kbps",
																   "92 Kbps",
																   "93 Kbps",
																   "94 Kbps",
																   "95 Kbps",
																   "96 Kbps",
																   "97 Kbps",
																   "98 Kbps",
																   "99 Kbps",
																   "100 Kbps",
																   "101 Kbps",
																   "102 Kbps",
																   "103 Kbps",
																   "104 Kbps",
																   "105 Kbps",
																   "106 Kbps",
																   "107 Kbps",
																   "108 Kbps",
																   "109 Kbps",
																   "110 Kbps",
																   "111 Kbps",
																   "112 Kbps",
																   "113 Kbps",
																   "114 Kbps",
																   "115 Kbps",
																   "116 Kbps",
																   "117 Kbps",
																   "118 Kbps",
																   "119 Kbps",
																   "120 Kbps",
																   "121 Kbps",
																   "122 Kbps",
																   "123 Kbps",
																   "124 Kbps",
																   "125 Kbps",
																   "126 Kbps",
																   "127 Kbps",
																   "128 Kbps",
																   "129 Kbps",
																   "130 Kbps",
																   "131 Kbps",
																   "132 Kbps",
																   "133 Kbps",
																   "134 Kbps",
																   "135 Kbps",
																   "136 Kbps",
																   "137 Kbps",
																   "138 Kbps",
																   "139 Kbps",
																   "140 Kbps",
																   "141 Kbps",
																   "142 Kbps",
																   "143 Kbps",
																   "144 Kbps",
																   "145 Kbps",
																   "146 Kbps",
																   "147 Kbps",
																   "148 Kbps",
																   "149 Kbps",
																   "150 Kbps",
																   "151 Kbps",
																   "152 Kbps",
																   "153 Kbps",
																   "154 Kbps",
																   "155 Kbps",
																   "156 Kbps",
																   "157 Kbps",
																   "158 Kbps",
																   "159 Kbps",
																   "160 Kbps",
																   "161 Kbps",
																   "162 Kbps",
																   "163 Kbps",
																   "164 Kbps",
																   "165 Kbps",
																   "166 Kbps",
																   "167 Kbps",
																   "168 Kbps",
																   "169 Kbps",
																   "170 Kbps",
																   "171 Kbps",
																   "172 Kbps",
																   "173 Kbps",
																   "174 Kbps",
																   "175 Kbps",
																   "176 Kbps",
																   "177 Kbps",
																   "178 Kbps",
																   "179 Kbps",
																   "180 Kbps",
																   "181 Kbps",
																   "182 Kbps",
																   "183 Kbps",
																   "184 Kbps",
																   "185 Kbps",
																   "186 Kbps",
																   "187 Kbps",
																   "188 Kbps",
																   "189 Kbps",
																   "190 Kbps",
																   "191 Kbps",
																   "192 Kbps",
																   "193 Kbps",
																   "194 Kbps",
																   "195 Kbps",
																   "196 Kbps",
																   "197 Kbps",
																   "198 Kbps",
																   "199 Kbps",
																   "200 Kbps",
																   "201 Kbps",
																   "202 Kbps",
																   "203 Kbps",
																   "204 Kbps",
																   "205 Kbps",
																   "206 Kbps",
																   "207 Kbps",
																   "208 Kbps",
																   "209 Kbps",
																   "210 Kbps",
																   "211 Kbps",
																   "212 Kbps",
																   "213 Kbps",
																   "214 Kbps",
																   "215 Kbps",
																   "216 Kbps",
																   "217 Kbps",
																   "218 Kbps",
																   "219 Kbps",
																   "220 Kbps",
																   "221 Kbps",
																   "222 Kbps",
																   "223 Kbps",
																   "224 Kbps",
																   "225 Kbps",
																   "226 Kbps",
																   "227 Kbps",
																   "228 Kbps",
																   "229 Kbps",
																   "230 Kbps",
																   "231 Kbps",
																   "232 Kbps",
																   "233 Kbps",
																   "234 Kbps",
																   "235 Kbps",
																   "236 Kbps",
																   "237 Kbps",
																   "238 Kbps",
																   "239 Kbps",
																   "240 Kbps",
																   "241 Kbps",
																   "242 Kbps",
																   "243 Kbps",
																   "244 Kbps",
																   "245 Kbps",
																   "246 Kbps",
																   "247 Kbps",
																   "248 Kbps",
																   "249 Kbps",
																   "250 Kbps",
																   "251 Kbps",
																   "252 Kbps",
																   "253 Kbps",
																   "254 Kbps",
																   "255 Kbps",
																   "256 Kbps",
																   "257 Kbps",
																   "258 Kbps",
																   "259 Kbps",
																   "260 Kbps",
																   "261 Kbps",
																   "262 Kbps",
																   "263 Kbps",
																   "264 Kbps",
																   "265 Kbps",
																   "266 Kbps",
																   "267 Kbps",
																   "268 Kbps",
																   "269 Kbps",
																   "270 Kbps",
																   "271 Kbps",
																   "272 Kbps",
																   "273 Kbps",
																   "274 Kbps",
																   "275 Kbps",
																   "276 Kbps",
																   "277 Kbps",
																   "278 Kbps",
																   "279 Kbps",
																   "280 Kbps",
																   "281 Kbps",
																   "282 Kbps",
																   "283 Kbps",
																   "284 Kbps",
																   "285 Kbps",
																   "286 Kbps",
																   "287 Kbps",
																   "288 Kbps",
																   "289 Kbps",
																   "290 Kbps",
																   "291 Kbps",
																   "292 Kbps",
																   "293 Kbps",
																   "294 Kbps",
																   "295 Kbps",
																   "296 Kbps",
																   "297 Kbps",
																   "298 Kbps",
																   "299 Kbps",
																   "300 Kbps",
																   "301 Kbps",
																   "302 Kbps",
																   "303 Kbps",
																   "304 Kbps",
																   "305 Kbps",
																   "306 Kbps",
																   "307 Kbps",
																   "308 Kbps",
																   "309 Kbps",
																   "310 Kbps",
																   "311 Kbps",
																   "312 Kbps",
																   "313 Kbps",
																   "314 Kbps",
																   "315 Kbps",
																   "316 Kbps",
																   "317 Kbps",
																   "318 Kbps",
																   "319 Kbps",
																   "320 Kbps",
																   "321 Kbps",
																   "322 Kbps",
																   "323 Kbps",
																   "324 Kbps",
																   "325 Kbps",
																   "326 Kbps",
																   "327 Kbps",
																   "328 Kbps",
																   "329 Kbps",
																   "330 Kbps",
																   "331 Kbps",
																   "332 Kbps",
																   "333 Kbps",
																   "334 Kbps",
																   "335 Kbps",
																   "336 Kbps",
																   "337 Kbps",
																   "338 Kbps",
																   "339 Kbps",
																   "340 Kbps",
																   "341 Kbps",
																   "342 Kbps",
																   "343 Kbps",
																   "344 Kbps",
																   "345 Kbps",
																   "346 Kbps",
																   "347 Kbps",
																   "348 Kbps",
																   "349 Kbps",
																   "350 Kbps",
																   "351 Kbps",
																   "352 Kbps",
																   "353 Kbps",
																   "354 Kbps",
																   "355 Kbps",
																   "356 Kbps",
																   "357 Kbps",
																   "358 Kbps",
																   "359 Kbps",
																   "360 Kbps",
																   "361 Kbps",
																   "362 Kbps",
																   "363 Kbps",
																   "364 Kbps",
																   "365 Kbps",
																   "366 Kbps",
																   "367 Kbps",
																   "368 Kbps",
																   "369 Kbps",
																   "370 Kbps",
																   "371 Kbps",
																   "372 Kbps",
																   "373 Kbps",
																   "374 Kbps",
																   "375 Kbps",
																   "376 Kbps",
																   "377 Kbps",
																   "378 Kbps",
																   "379 Kbps",
																   "380 Kbps",
																   "381 Kbps",
																   "382 Kbps",
																   "383 Kbps",
																   "384 Kbps",
																   "385 Kbps",
																   "386 Kbps",
																   "387 Kbps",
																   "388 Kbps",
																   "389 Kbps",
																   "390 Kbps",
																   "391 Kbps",
																   "392 Kbps",
																   "393 Kbps",
																   "394 Kbps",
																   "395 Kbps",
																   "396 Kbps",
																   "397 Kbps",
																   "398 Kbps",
																   "399 Kbps",
																   "400 Kbps",
																   "401 Kbps",
																   "402 Kbps",
																   "403 Kbps",
																   "404 Kbps",
																   "405 Kbps",
																   "406 Kbps",
																   "407 Kbps",
																   "408 Kbps",
																   "409 Kbps",
																   "410 Kbps",
																   "411 Kbps",
																   "412 Kbps",
																   "413 Kbps",
																   "414 Kbps",
																   "415 Kbps",
																   "416 Kbps",
																   "417 Kbps",
																   "418 Kbps",
																   "419 Kbps",
																   "420 Kbps",
																   "421 Kbps",
																   "422 Kbps",
																   "423 Kbps",
																   "424 Kbps",
																   "425 Kbps",
																   "426 Kbps",
																   "427 Kbps",
																   "428 Kbps",
																   "429 Kbps",
																   "430 Kbps",
																   "431 Kbps",
																   "432 Kbps",
																   "433 Kbps",
																   "434 Kbps",
																   "435 Kbps",
																   "436 Kbps",
																   "437 Kbps",
																   "438 Kbps",
																   "439 Kbps",
																   "440 Kbps",
																   "441 Kbps",
																   "442 Kbps",
																   "443 Kbps",
																   "444 Kbps",
																   "445 Kbps",
																   "446 Kbps",
																   "447 Kbps",
																   "448 Kbps",
																   "449 Kbps",
																   "450 Kbps",
																   "451 Kbps",
																   "452 Kbps",
																   "453 Kbps",
																   "454 Kbps",
																   "455 Kbps",
																   "456 Kbps",
																   "457 Kbps",
																   "458 Kbps",
																   "459 Kbps",
																   "460 Kbps",
																   "461 Kbps",
																   "462 Kbps",
																   "463 Kbps",
																   "464 Kbps",
																   "465 Kbps",
																   "466 Kbps",
																   "467 Kbps",
																   "468 Kbps",
																   "469 Kbps",
																   "470 Kbps",
																   "471 Kbps",
																   "472 Kbps",
																   "473 Kbps",
																   "474 Kbps",
																   "475 Kbps",
																   "476 Kbps",
																   "477 Kbps",
																   "478 Kbps",
																   "479 Kbps",
																   "480 Kbps",
																   "481 Kbps",
																   "482 Kbps",
																   "483 Kbps",
																   "484 Kbps",
																   "485 Kbps",
																   "486 Kbps",
																   "487 Kbps",
																   "488 Kbps",
																   "489 Kbps",
																   "490 Kbps",
																   "491 Kbps",
																   "492 Kbps",
																   "493 Kbps",
																   "494 Kbps",
																   "495 Kbps",
																   "496 Kbps",
																   "497 Kbps",
																   "498 Kbps",
																   "499 Kbps",
																   "500 Kbps"});
			this.comboBoxVorCBRBit.Location = new System.Drawing.Point(96, 12);
			this.comboBoxVorCBRBit.Name = "comboBoxVorCBRBit";
			this.comboBoxVorCBRBit.Size = new System.Drawing.Size(116, 20);
			this.comboBoxVorCBRBit.TabIndex = 15;
			this.toolTip.SetToolTip(this.comboBoxVorCBRBit, "ビットレートを選択してください。但し完全なCBRではないので若干のばらつきはあります。");
			// 
			// textBoxVorLowpassValue
			// 
			this.textBoxVorLowpassValue.Location = new System.Drawing.Point(32, 208);
			this.textBoxVorLowpassValue.Name = "textBoxVorLowpassValue";
			this.textBoxVorLowpassValue.Size = new System.Drawing.Size(60, 19);
			this.textBoxVorLowpassValue.TabIndex = 15;
			this.textBoxVorLowpassValue.Text = "";
			this.textBoxVorLowpassValue.Visible = false;
			// 
			// checkBoxVorLowpass
			// 
			this.checkBoxVorLowpass.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxVorLowpass.Location = new System.Drawing.Point(12, 188);
			this.checkBoxVorLowpass.Name = "checkBoxVorLowpass";
			this.checkBoxVorLowpass.Size = new System.Drawing.Size(228, 16);
			this.checkBoxVorLowpass.TabIndex = 14;
			this.checkBoxVorLowpass.Text = "ローパスフィルタを使用する";
			this.toolTip.SetToolTip(this.checkBoxVorLowpass, "一定周波数以上をカットするときに使います。");
			this.checkBoxVorLowpass.Visible = false;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(96, 212);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(25, 15);
			this.label18.TabIndex = 13;
			this.label18.Text = "KHz";
			this.label18.Visible = false;
			// 
			// comboBoxVorBit
			// 
			this.comboBoxVorBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVorBit.Items.AddRange(new object[] {
																"固定品質 (デフォルト)",
																"平均ビットレート (ABR 非推薦)",
																"擬似固定ビットレート (CBR 非推薦)"});
			this.comboBoxVorBit.Location = new System.Drawing.Point(12, 32);
			this.comboBoxVorBit.Name = "comboBoxVorBit";
			this.comboBoxVorBit.Size = new System.Drawing.Size(228, 20);
			this.comboBoxVorBit.TabIndex = 9;
			this.toolTip.SetToolTip(this.comboBoxVorBit, "ビットレートの方式を決めます。ABR/CBRもサポートされていますが非推薦です。");
			this.comboBoxVorBit.SelectedIndexChanged += new System.EventHandler(this.comboBoxVorBit_SelectedIndexChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(12, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(107, 15);
			this.label14.TabIndex = 8;
			this.label14.Text = "ビットレート配分方式";
			// 
			// checkBoxVorDownmix
			// 
			this.checkBoxVorDownmix.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxVorDownmix.Location = new System.Drawing.Point(12, 88);
			this.checkBoxVorDownmix.Name = "checkBoxVorDownmix";
			this.checkBoxVorDownmix.Size = new System.Drawing.Size(228, 16);
			this.checkBoxVorDownmix.TabIndex = 22;
			this.checkBoxVorDownmix.Text = "モノラルに変換";
			this.toolTip.SetToolTip(this.checkBoxVorDownmix, "強制的にモノラルにミックスダウンします。");
			// 
			// tabPagePlus
			// 
			this.tabPagePlus.Controls.Add(this.textBoxWinampPath);
			this.tabPagePlus.Controls.Add(this.buttonWinampPath);
			this.tabPagePlus.Controls.Add(this.checkBoxAdd2Winamp);
			this.tabPagePlus.Controls.Add(this.checkBoxFade);
			this.tabPagePlus.Location = new System.Drawing.Point(4, 21);
			this.tabPagePlus.Name = "tabPagePlus";
			this.tabPagePlus.Size = new System.Drawing.Size(492, 243);
			this.tabPagePlus.TabIndex = 4;
			this.tabPagePlus.Text = "おまけ";
			// 
			// textBoxWinampPath
			// 
			this.textBoxWinampPath.Location = new System.Drawing.Point(28, 36);
			this.textBoxWinampPath.Name = "textBoxWinampPath";
			this.textBoxWinampPath.Size = new System.Drawing.Size(184, 19);
			this.textBoxWinampPath.TabIndex = 16;
			this.textBoxWinampPath.Text = "";
			// 
			// buttonWinampPath
			// 
			this.buttonWinampPath.Cursor = System.Windows.Forms.Cursors.Default;
			this.buttonWinampPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonWinampPath.Location = new System.Drawing.Point(216, 36);
			this.buttonWinampPath.Name = "buttonWinampPath";
			this.buttonWinampPath.Size = new System.Drawing.Size(20, 19);
			this.buttonWinampPath.TabIndex = 17;
			this.buttonWinampPath.Text = "...";
			this.toolTip.SetToolTip(this.buttonWinampPath, "クリックでWinampのパスを決定します。");
			this.buttonWinampPath.Click += new System.EventHandler(this.buttonWinampPath_Click);
			// 
			// checkBoxAdd2Winamp
			// 
			this.checkBoxAdd2Winamp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxAdd2Winamp.Location = new System.Drawing.Point(12, 16);
			this.checkBoxAdd2Winamp.Name = "checkBoxAdd2Winamp";
			this.checkBoxAdd2Winamp.Size = new System.Drawing.Size(228, 16);
			this.checkBoxAdd2Winamp.TabIndex = 15;
			this.checkBoxAdd2Winamp.Text = "変換終了後Winampプレイリストに追加";
			this.toolTip.SetToolTip(this.checkBoxAdd2Winamp, "変換後Winampのプレイリストに追加します。エンコード後にすぐ聴きたい人向け。");
			// 
			// checkBoxFade
			// 
			this.checkBoxFade.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxFade.Location = new System.Drawing.Point(12, 64);
			this.checkBoxFade.Name = "checkBoxFade";
			this.checkBoxFade.Size = new System.Drawing.Size(228, 16);
			this.checkBoxFade.TabIndex = 15;
			this.checkBoxFade.Text = "（＾＾）";
			this.toolTip.SetToolTip(this.checkBoxFade, "これからも僕を応援してくださいね（＾＾）");
			this.checkBoxFade.Visible = false;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOK.Location = new System.Drawing.Point(368, 288);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(68, 28);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCancel.Location = new System.Drawing.Point(444, 288);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(68, 28);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "キャンセル";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.Description = "出力先のフォルダを選択してください";
			this.folderBrowserDialog.SelectedPath = "D:\\Program Files\\Microsoft Visual Studio .NET 2003\\Common7\\IDE";
			// 
			// Form2
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(522, 323);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.tabControlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "変換設定";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageConfig.ResumeLayout(false);
			this.tabControlConfig.ResumeLayout(false);
			this.tabPageConfigOut.ResumeLayout(false);
			this.tabPageFileName.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBarDropTrans)).EndInit();
			this.tabPageWAV.ResumeLayout(false);
			this.tabControlWAVE.ResumeLayout(false);
			this.tabPageWAVB2W.ResumeLayout(false);
			this.tabPageHay2.ResumeLayout(false);
			this.tabPageMP3.ResumeLayout(false);
			this.tabControlMP3.ResumeLayout(false);
			this.tabPageMP3CBR.ResumeLayout(false);
			this.tabPageMP3VBR.ResumeLayout(false);
			this.tabPageMP3ABR.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMP3ABRPresetBit)).EndInit();
			this.tabPageVor.ResumeLayout(false);
			this.tabControlVor.ResumeLayout(false);
			this.tabPageVorQB.ResumeLayout(false);
			this.tabPageVorABR.ResumeLayout(false);
			this.tabPageVorCBR.ResumeLayout(false);
			this.tabPagePlus.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		string exePath = Application.StartupPath ;
		string ini = Application.StartupPath + @"\Cage.ini";

		private void Form2_Load(object sender, System.EventArgs e)
		{
			this.Font = tabControlMain.Font = FormMain.mainfont;

			#region [Main]
			#region//Format
			switch(FormMain.Format)
			{
				case "WAVE":
					comboBoxFormat.SelectedIndex = 0;
					break;
				case "MP3":
					comboBoxFormat.SelectedIndex = 1;
					break;
				case "Vor":
					comboBoxFormat.SelectedIndex = 2;
					break;
			}
			#endregion
			#region//Tagging
			switch(FormMain.Tagging)
			{
				case "True":
					checkBoxTagging.Checked = true;
					break;
				case "False":
					checkBoxTagging.Checked = false;
					break;
			}
			#endregion
			#region//DeleteDif
			switch(FormMain.DeleteDif)
			{
				case "True":
					checkBoxDeleteDif.Checked = true;
					break;
				case "False":
					checkBoxDeleteDif.Checked = false;
					break;
			}
			#endregion
			#region//DropTrans
			labeltrackBarDropTransValue.Text = FormMain.DropTrans;
			trackBarDropTrans.Value = Convert.ToInt32(FormMain.DropTrans);
			#endregion
			#endregion
			#region [Output]
			#region//Out

			switch(FormMain.Out)
			{
				case "Default":
					radioButtonOutDefault.Checked = true;
					break;
				case "BMSFolder":
					radioButtonOutBMSFolder.Checked = true;
					break;
				case "Selected":
					radioButtonOutSelected.Checked = true;
					break;
			}
			#endregion
			#region//OutPath
			textBoxOutPath.Text = FormMain.OutPath;
			#endregion
			#region//ArtistFolder
			switch(FormMain.ArtistFolder)
			{
				case "True":
					checkBoxArtistFolder.Checked = true;
					break;
				case "False":
					checkBoxArtistFolder.Checked = false;
					break;
			}
			#endregion
			#endregion
			#region [Filename]
			#region//Filename
			switch(FormMain.Filename)
			{
				case "Artist-Title":
					radioButtonA_T.Checked = true;
					break;
				case "Title-Artist":
					radioButtonT_A.Checked = true;
					break;
				case "Title":
					radioButtonT.Checked = true;
					break;
				case "Custom":
					radioButtonC.Checked = true;
					break;
			}
			#endregion
			#endregion
			#region [WAVE]
			#region//WAVEng
			switch(FormMain.WAVEng)
			{
				case "tjbms2wav":
					comboBoxWAVEng.SelectedIndex = 0;
					break;
				case "BmsWaveHay2":
					comboBoxWAVEng.SelectedIndex = 1;
					break;
			}
			#endregion
			#endregion
			#region [WAVEB2W]
			#region//B2WHz
			switch(FormMain.B2WHz)
			{
				case "44100":
					comboBoxWAVB2WHz.SelectedIndex = 0;
					break;
				case "32000":
					comboBoxWAVB2WHz.SelectedIndex = 1;
					break;
				case "24000":
					comboBoxWAVB2WHz.SelectedIndex = 2;
					break;
				case "22050":
					comboBoxWAVB2WHz.SelectedIndex = 3;
					break;
				case "16000":
					comboBoxWAVB2WHz.SelectedIndex = 4;
					break;
				case "12000":
					comboBoxWAVB2WHz.SelectedIndex = 5;
					break;
				case "11025":
					comboBoxWAVB2WHz.SelectedIndex = 6;
					break;
				case "8000":
					comboBoxWAVB2WHz.SelectedIndex = 7;
					break;
			}
			#endregion
			#region//B2WBit
			switch(FormMain.B2WBit)
			{
				case "16":
					comboBoxWAVB2WBit.SelectedIndex = 0;
					break;
				case "8":
					comboBoxWAVB2WBit.SelectedIndex = 1;
					break;
			}
			#endregion
			#region//B2WChannel
			switch(FormMain.B2WChannel)
			{
				case "2":
					comboBoxWAVB2WChannel.SelectedIndex = 0;
					break;
				case "1":
					comboBoxWAVB2WChannel.SelectedIndex = 1;
					break;
			}
			#endregion
			#region//B2WChk
			switch(FormMain.B2WChk)
			{
				case "True":
					checkBoxWAVB2WChk.Checked = true;
					break;
				case "False":
					checkBoxWAVB2WChk.Checked = false;
					break;
			}
			#endregion
			#region//B2WForce
			switch(FormMain.B2WForce)
			{
				case "True":
					checkBoxWAVB2WForce.Checked = true;
					break;
				case "False":
					checkBoxWAVB2WForce.Checked = false;
					break;
			}
			#endregion
			#region//B2WCmd
			switch(FormMain.B2WCmd)
			{
				case "True":
					checkBoxWAVB2WCmd.Checked = true;
					break;
				case "False":
					checkBoxWAVB2WCmd.Checked = false;
					break;
			}
			#endregion
			#region//B2WVol
			labelWAVB2WVol.Text = FormMain.B2WVol;
			hScrollBarWAVB2WVol.Value = Convert.ToInt32(FormMain.B2WVol);

			#endregion
			#endregion
			#region [BmsWaveHay2]
			#region//Hay2Hz
			switch(FormMain.Hay2Hz)
			{
				case "44100":
					comboBoxWAVHay2Hz.SelectedIndex = 0;
					break;
				case "32000":
					comboBoxWAVHay2Hz.SelectedIndex = 1;
					break;
				case "24000":
					comboBoxWAVHay2Hz.SelectedIndex = 2;
					break;
				case "22050":
					comboBoxWAVHay2Hz.SelectedIndex = 3;
					break;
				case "16000":
					comboBoxWAVHay2Hz.SelectedIndex = 4;
					break;
				case "12000":
					comboBoxWAVHay2Hz.SelectedIndex = 5;
					break;
				case "11025":
					comboBoxWAVHay2Hz.SelectedIndex = 6;
					break;
				case "8000":
					comboBoxWAVHay2Hz.SelectedIndex = 7;
					break;
			}
			#endregion
			#region//Hay2Bit
			switch(FormMain.Hay2Bit)
			{
				case "16":
					comboBoxWAVHay2Bit.SelectedIndex = 0;
					break;
				case "8":
					comboBoxWAVHay2Bit.SelectedIndex = 1;
					break;
			}
			#endregion
			#region//Hay2Channel
			switch(FormMain.Hay2Channel)
			{
				case "2":
					comboBoxWAVHay2Channel.SelectedIndex = 0;
					break;
				case "1":
					comboBoxWAVHay2Channel.SelectedIndex = 1;
					break;
			}
			#endregion
			#region//Hay2PCMMethod
			switch(FormMain.Hay2PCMMethod)
			{
				case "Nearest":
					comboBoxWAVHay2PCMMethod.SelectedIndex = 0;
					break;
				case "Linear":
					comboBoxWAVHay2PCMMethod.SelectedIndex = 1;
					break;
				case "Mix":
					comboBoxWAVHay2PCMMethod.SelectedIndex = 2;
					break;
				case "Neville":
					comboBoxWAVHay2PCMMethod.SelectedIndex = 3;
					break;
				case "Bezier":
					comboBoxWAVHay2PCMMethod.SelectedIndex = 4;
					break;
			}
			#endregion
			#region//Hay2FixMixing
			switch(FormMain.Hay2FixMixing)
			{
				case "True":
					checkBoxWAVHay2FixMixing.Checked = true;
					break;
				case "False":
					checkBoxWAVHay2FixMixing.Checked = false;
					break;
			}
			#endregion
			#region//Hay2CutSilence
			switch(FormMain.Hay2CutSilence)
			{
				case "True":
					checkBoxWAVHay2CutSilence.Checked = true;
					break;
				case "False":
					checkBoxWAVHay2CutSilence.Checked = false;
					break;
			}
			#endregion
			#region//Hay2Inverse
			switch(FormMain.Hay2Inverse)
			{
				case "True":
					checkBoxWAVHay2Inverse.Checked = true;
					break;
				case "False":
					checkBoxWAVHay2Inverse.Checked = false;
					break;
			}
			#endregion
			#region//Hay2WhiteNoise
			switch(FormMain.Hay2WhiteNoise)
			{
				case "True":
					checkBoxWAVHay2WhiteNoise.Checked = true;
					break;
				case "False":
					checkBoxWAVHay2WhiteNoise.Checked = false;
					break;
			}
			#endregion
			#region//Hay2Vol
			labelWAVHay2Vol.Text = FormMain.Hay2Vol;
			hScrollBarWAVHay2Vol.Value = Convert.ToInt32(FormMain.Hay2Vol);
			#endregion
			#endregion
			#region [MP3]
			#region//MP3Bit
			switch(FormMain.MP3Bit)
			{
				case "CBR":
					comboBoxMP3Bit.SelectedIndex = 0;
					break;
				case "VBR":
					comboBoxMP3Bit.SelectedIndex = 1;
					break;
				case "ABR":
					comboBoxMP3Bit.SelectedIndex = 2;
					break;
			}
			#endregion
			#region//MP3Stereo
			switch(FormMain.MP3Stereo)
			{
				case "Stereo":
					comboBoxMP3Stereo.SelectedIndex = 0;
					break;
				case "Joint Stereo":
					comboBoxMP3Stereo.SelectedIndex = 1;
					break;
				case "Forced Joint Stereo":
					comboBoxMP3Stereo.SelectedIndex = 2;
					break;
				case "Mono":
					comboBoxMP3Stereo.SelectedIndex = 3;
					break;
			}
			#endregion
			#region//MP3q
			switch(FormMain.MP3q)
			{
				case "0":
					comboBoxMP3q.SelectedIndex = 0;
					break;
				case "1":
					comboBoxMP3q.SelectedIndex = 1;
					break;
				case "2":
					comboBoxMP3q.SelectedIndex = 2;
					break;
				case "3":
					comboBoxMP3q.SelectedIndex = 3;
					break;
				case "4":
					comboBoxMP3q.SelectedIndex = 4;
					break;
				case "5":
					comboBoxMP3q.SelectedIndex = 5;
					break;
				case "6":
					comboBoxMP3q.SelectedIndex = 6;
					break;
				case "7":
					comboBoxMP3q.SelectedIndex = 7;
					break;
				case "8":
					comboBoxMP3q.SelectedIndex = 8;
					break;
				case "9":
					comboBoxMP3q.SelectedIndex = 9;
					break;
			}
			#endregion
			#region//MP3Hz
			switch(FormMain.MP3Hz)
			{
				case "Auto":
					comboBoxMP3Hz.SelectedIndex = 0;
					break;
				case "48000":
					comboBoxMP3Hz.SelectedIndex = 1;
					break;
				case "44100":
					comboBoxMP3Hz.SelectedIndex = 2;
					break;
				case "32000":
					comboBoxMP3Hz.SelectedIndex = 3;
					break;
				case "24000":
					comboBoxMP3Hz.SelectedIndex = 4;
					break;
				case "22050":
					comboBoxMP3Hz.SelectedIndex = 5;
					break;
				case "16000":
					comboBoxMP3Hz.SelectedIndex = 6;
					break;
				case "12000":
					comboBoxMP3Hz.SelectedIndex = 7;
					break;
				case "11025":
					comboBoxMP3Hz.SelectedIndex = 8;
					break;
				case "8000":
					comboBoxMP3Hz.SelectedIndex = 9;
					break;
			}
			#endregion
			#region//MP3Lowpass
			switch(FormMain.MP3Lowpass)
			{
				case "True":
					checkBoxMP3Lowpass.Checked = true;
					break;
				case "False":
					checkBoxMP3Lowpass.Checked = false;
					break;
			}
			#endregion
			#region//MP3LowpassValue
			textBoxMP3LowpassValue.Text = FormMain.MP3LowpassValue;
			#endregion
			#region//MP3nspsytune
			switch(FormMain.MP3nspsytune)
			{
				case "True":
					checkBoxMP3nspsytune.Checked = true;
					break;
				case "False":
					checkBoxMP3nspsytune.Checked = false;
					break;
			}
			#endregion
			#region//MP3Cmd
			switch(FormMain.MP3Cmd)
			{
				case "True":
					checkBoxMP3Cmd.Checked = true;
					break;
				case "False":
					checkBoxMP3Cmd.Checked = false;
					break;
			}
			#endregion
			#endregion
			#region [MP3CBR]
			#region//MP3CBRBit
			switch(FormMain.MP3CBRBit)
			{
				case "32":
					comboBoxMP3CBRBit.SelectedIndex = 0;
					break;
				case "40":
					comboBoxMP3CBRBit.SelectedIndex = 1;
					break;
				case "48":
					comboBoxMP3CBRBit.SelectedIndex = 2;
					break;
				case "56":
					comboBoxMP3CBRBit.SelectedIndex = 3;
					break;
				case "64":
					comboBoxMP3CBRBit.SelectedIndex = 4;
					break;
				case "80":
					comboBoxMP3CBRBit.SelectedIndex = 5;
					break;
				case "96":
					comboBoxMP3CBRBit.SelectedIndex = 6;
					break;
				case "112":
					comboBoxMP3CBRBit.SelectedIndex = 7;
					break;
				case "128":
					comboBoxMP3CBRBit.SelectedIndex = 8;
					break;
				case "160":
					comboBoxMP3CBRBit.SelectedIndex = 9;
					break;
				case "192":
					comboBoxMP3CBRBit.SelectedIndex = 10;
					break;
				case "224":
					comboBoxMP3CBRBit.SelectedIndex = 11;
					break;
				case "256":
					comboBoxMP3CBRBit.SelectedIndex = 12;
					break;
				case "320":
					comboBoxMP3CBRBit.SelectedIndex = 13;
					break;
			}
			#endregion
			#region//MP3CBRUsePreset
			switch(FormMain.MP3CBRUsePreset)
			{
				case "True":
					checkBoxMP3CBRUsePreset.Checked = true;
					break;
				case "False":
					checkBoxMP3CBRUsePreset.Checked = false;
					break;
			}
			#endregion
			#region//MP3CBRPreset
			switch(FormMain.MP3CBRPreset)
			{
				case "*":
					comboBoxMP3CBRPreset.SelectedIndex = 0;
					break;
				case "insane":
					comboBoxMP3CBRPreset.SelectedIndex = 1;
					break;
			}
			#endregion
			#endregion
			#region [MP3VBR]
			#region//MP3VBRMinBit
			switch(FormMain.MP3VBRMinBit)
			{
				case "none":
					comboBoxMP3VBRMinBit.SelectedIndex = 0;
					break;
				case "32":
					comboBoxMP3VBRMinBit.SelectedIndex = 1;
					break;
				case "40":
					comboBoxMP3VBRMinBit.SelectedIndex = 2;
					break;
				case "48":
					comboBoxMP3VBRMinBit.SelectedIndex = 3;
					break;
				case "56":
					comboBoxMP3VBRMinBit.SelectedIndex = 4;
					break;
				case "64":
					comboBoxMP3VBRMinBit.SelectedIndex = 5;
					break;
				case "80":
					comboBoxMP3VBRMinBit.SelectedIndex = 6;
					break;
				case "96":
					comboBoxMP3VBRMinBit.SelectedIndex = 7;
					break;
				case "112":
					comboBoxMP3VBRMinBit.SelectedIndex = 8;
					break;
				case "128":
					comboBoxMP3VBRMinBit.SelectedIndex = 9;
					break;
				case "160":
					comboBoxMP3VBRMinBit.SelectedIndex = 10;
					break;
				case "192":
					comboBoxMP3VBRMinBit.SelectedIndex = 11;
					break;
				case "224":
					comboBoxMP3VBRMinBit.SelectedIndex = 12;
					break;
				case "256":
					comboBoxMP3VBRMinBit.SelectedIndex = 13;
					break;
				case "320":
					comboBoxMP3VBRMinBit.SelectedIndex = 14;
					break;
			}
			#endregion
			#region//MP3VBRMaxBit
			switch(FormMain.MP3VBRMaxBit)
			{
				case "none":
					comboBoxMP3VBRMaxBit.SelectedIndex = 0;
					break;
				case "32":
					comboBoxMP3VBRMaxBit.SelectedIndex = 1;
					break;
				case "40":
					comboBoxMP3VBRMaxBit.SelectedIndex = 2;
					break;
				case "48":
					comboBoxMP3VBRMaxBit.SelectedIndex = 3;
					break;
				case "56":
					comboBoxMP3VBRMaxBit.SelectedIndex = 4;
					break;
				case "64":
					comboBoxMP3VBRMaxBit.SelectedIndex = 5;
					break;
				case "80":
					comboBoxMP3VBRMaxBit.SelectedIndex = 6;
					break;
				case "96":
					comboBoxMP3VBRMaxBit.SelectedIndex = 7;
					break;
				case "112":
					comboBoxMP3VBRMaxBit.SelectedIndex = 8;
					break;
				case "128":
					comboBoxMP3VBRMaxBit.SelectedIndex = 9;
					break;
				case "160":
					comboBoxMP3VBRMaxBit.SelectedIndex = 10;
					break;
				case "192":
					comboBoxMP3VBRMaxBit.SelectedIndex = 11;
					break;
				case "224":
					comboBoxMP3VBRMaxBit.SelectedIndex = 12;
					break;
				case "256":
					comboBoxMP3VBRMaxBit.SelectedIndex = 13;
					break;
				case "320":
					comboBoxMP3VBRMaxBit.SelectedIndex = 14;
					break;
			}
			#endregion
			#region//MP3VBRq
			switch(FormMain.MP3VBRq)
			{
				case "0":
					comboBoxMP3VBRq.SelectedIndex = 0;
					break;
				case "1":
					comboBoxMP3VBRq.SelectedIndex = 1;
					break;
				case "2":
					comboBoxMP3VBRq.SelectedIndex = 2;
					break;
				case "3":
					comboBoxMP3VBRq.SelectedIndex = 3;
					break;
				case "4":
					comboBoxMP3VBRq.SelectedIndex = 4;
					break;
				case "5":
					comboBoxMP3VBRq.SelectedIndex = 5;
					break;
				case "6":
					comboBoxMP3VBRq.SelectedIndex = 6;
					break;
				case "7":
					comboBoxMP3VBRq.SelectedIndex = 7;
					break;
				case "8":
					comboBoxMP3VBRq.SelectedIndex = 8;
					break;
				case "9":
					comboBoxMP3VBRq.SelectedIndex = 9;
					break;
			}
			#endregion
			#region//MP3VBRMethod
			switch(FormMain.MP3VBRMethod)
			{
				case "old":
					comboBoxMP3VBRMethod.SelectedIndex = 0;
					break;
				case "new":
					comboBoxMP3VBRMethod.SelectedIndex = 1;
					break;
			}
			#endregion
			#region//MP3VBRForceMinBit
			switch(FormMain.MP3VBRForceMinBit)
			{
				case "True":
					checkBoxMP3VBRForceMinBit.Checked = true;
					break;
				case "False":
					checkBoxMP3VBRForceMinBit.Checked = false;
					break;
			}
			#endregion
			#region//MP3VBRUsePreset
			switch(FormMain.MP3VBRUsePreset)
			{
				case "True":
					checkBoxMP3VBRUsePreset.Checked = true;
					break;
				case "False":
					checkBoxMP3VBRUsePreset.Checked = false;
					break;
			}
			#endregion
			#region//MP3VBRPreset
			switch(FormMain.MP3VBRPreset)
			{
				case "medium":
					comboBoxMP3VBRPreset.SelectedIndex = 0;
					break;
				case "standard":
					comboBoxMP3VBRPreset.SelectedIndex = 1;
					break;
				case "extreme":
					comboBoxMP3VBRPreset.SelectedIndex = 2;
					break;
				case "fast medium":
					comboBoxMP3VBRPreset.SelectedIndex = 3;
					break;
				case "fast standard":
					comboBoxMP3VBRPreset.SelectedIndex = 4;
					break;
				case "fast extreme":
					comboBoxMP3VBRPreset.SelectedIndex = 5;
					break;
				case "r3mix":
					comboBoxMP3VBRPreset.SelectedIndex = 6;
					break;
			}
			#endregion
			#endregion
			#region [MP3ABR]
			#region//MP3ABRBit
			switch(FormMain.MP3ABRBit)
			{
				case "32":
					comboBoxMP3ABRBit.SelectedIndex = 0;
					break;
				case "40":
					comboBoxMP3ABRBit.SelectedIndex = 1;
					break;
				case "48":
					comboBoxMP3ABRBit.SelectedIndex = 2;
					break;
				case "56":
					comboBoxMP3ABRBit.SelectedIndex = 3;
					break;
				case "64":
					comboBoxMP3ABRBit.SelectedIndex = 4;
					break;
				case "80":
					comboBoxMP3ABRBit.SelectedIndex = 5;
					break;
				case "96":
					comboBoxMP3ABRBit.SelectedIndex = 6;
					break;
				case "112":
					comboBoxMP3ABRBit.SelectedIndex = 7;
					break;
				case "128":
					comboBoxMP3ABRBit.SelectedIndex = 8;
					break;
				case "160":
					comboBoxMP3ABRBit.SelectedIndex = 9;
					break;
				case "192":
					comboBoxMP3ABRBit.SelectedIndex = 10;
					break;
				case "224":
					comboBoxMP3ABRBit.SelectedIndex = 11;
					break;
				case "256":
					comboBoxMP3ABRBit.SelectedIndex = 12;
					break;
				case "320":
					comboBoxMP3ABRBit.SelectedIndex = 13;
					break;
			}
			#endregion
			#region//MP3ABRMinBit
			switch(FormMain.MP3ABRMinBit)
			{
				case "none":
					comboBoxMP3ABRMinBit.SelectedIndex = 0;
					break;
				case "32":
					comboBoxMP3ABRMinBit.SelectedIndex = 1;
					break;
				case "40":
					comboBoxMP3ABRMinBit.SelectedIndex = 2;
					break;
				case "48":
					comboBoxMP3ABRMinBit.SelectedIndex = 3;
					break;
				case "56":
					comboBoxMP3ABRMinBit.SelectedIndex = 4;
					break;
				case "64":
					comboBoxMP3ABRMinBit.SelectedIndex = 5;
					break;
				case "80":
					comboBoxMP3ABRMinBit.SelectedIndex = 6;
					break;
				case "96":
					comboBoxMP3ABRMinBit.SelectedIndex = 7;
					break;
				case "112":
					comboBoxMP3ABRMinBit.SelectedIndex = 8;
					break;
				case "128":
					comboBoxMP3ABRMinBit.SelectedIndex = 9;
					break;
				case "160":
					comboBoxMP3ABRMinBit.SelectedIndex = 10;
					break;
				case "192":
					comboBoxMP3ABRMinBit.SelectedIndex = 11;
					break;
				case "224":
					comboBoxMP3ABRMinBit.SelectedIndex = 12;
					break;
				case "256":
					comboBoxMP3ABRMinBit.SelectedIndex = 13;
					break;
				case "320":
					comboBoxMP3ABRMinBit.SelectedIndex = 14;
					break;
			}
			#endregion
			#region//MP3ABRMaxBit
			switch(FormMain.MP3ABRMaxBit)
			{
				case "none":
					comboBoxMP3ABRMaxBit.SelectedIndex = 0;
					break;				
				case "32":
					comboBoxMP3ABRMaxBit.SelectedIndex = 1;
					break;
				case "40":
					comboBoxMP3ABRMaxBit.SelectedIndex = 2;
					break;
				case "48":
					comboBoxMP3ABRMaxBit.SelectedIndex = 3;
					break;
				case "56":
					comboBoxMP3ABRMaxBit.SelectedIndex = 4;
					break;
				case "64":
					comboBoxMP3ABRMaxBit.SelectedIndex = 5;
					break;
				case "80":
					comboBoxMP3ABRMaxBit.SelectedIndex = 6;
					break;
				case "96":
					comboBoxMP3ABRMaxBit.SelectedIndex = 7;
					break;
				case "112":
					comboBoxMP3ABRMaxBit.SelectedIndex = 8;
					break;
				case "128":
					comboBoxMP3ABRMaxBit.SelectedIndex = 9;
					break;
				case "160":
					comboBoxMP3ABRMaxBit.SelectedIndex = 10;
					break;
				case "192":
					comboBoxMP3ABRMaxBit.SelectedIndex = 11;
					break;
				case "224":
					comboBoxMP3ABRMaxBit.SelectedIndex = 12;
					break;
				case "256":
					comboBoxMP3ABRMaxBit.SelectedIndex = 13;
					break;
				case "320":
					comboBoxMP3ABRMaxBit.SelectedIndex = 14;
					break;
			}
			#endregion
			#region//MP3ABRPresetBit
			numericUpDownMP3ABRPresetBit.Value = Convert.ToInt32(FormMain.MP3ABRPresetBit);
			#endregion
			#region//MP3ABRForceMinBit
			switch(FormMain.MP3ABRForceMinBit)
			{
				case "True":
					checkBoxMP3ABRForceMinBit.Checked = true;
					break;
				case "False":
					checkBoxMP3ABRForceMinBit.Checked = false;
					break;
			}
			#endregion
			#region//MP3ABRUsePreset
			switch(FormMain.MP3ABRUsePreset)
			{
				case "True":
					checkBoxMP3ABRUsePreset.Checked = true;
					break;
				case "False":
					checkBoxMP3ABRUsePreset.Checked = false;
					break;
			}
			#endregion
			#region//MP3ABRPreset
			switch(FormMain.MP3ABRPreset)
			{
				case "*":
					comboBoxMP3ABRPreset.SelectedIndex = 0;
					break;
				case "phone":
					comboBoxMP3ABRPreset.SelectedIndex = 1;
					break;
				case "phon+":
					comboBoxMP3ABRPreset.SelectedIndex = 2;
					break;
				case "mw-us":
					comboBoxMP3ABRPreset.SelectedIndex = 3;
					break;
				case "fm":
					comboBoxMP3ABRPreset.SelectedIndex = 4;
					break;
				case "hifi":
					comboBoxMP3ABRPreset.SelectedIndex = 5;
					break;
				case "cd":
					comboBoxMP3ABRPreset.SelectedIndex = 6;
					break;
				case "studio":
					comboBoxMP3ABRPreset.SelectedIndex = 7;
					break;
			}
			#endregion
			#endregion
			#region [Vor]
			#region//VorBit
			switch(FormMain.VorBit)
			{
				case "quality":
					comboBoxVorBit.SelectedIndex = 0;
					break;
				case "ABR":
					comboBoxVorBit.SelectedIndex = 1;
					break;
				case "CBR":
					comboBoxVorBit.SelectedIndex = 2;
					break;
			}
			#endregion
			#region//VorHz
			switch(FormMain.VorHz)
			{
				case "Auto":
					comboBoxVorHz.SelectedIndex = 0;
					break;
				case "48000":
					comboBoxVorHz.SelectedIndex = 1;
					break;
				case "44100":
					comboBoxVorHz.SelectedIndex = 2;
					break;
				case "32000":
					comboBoxVorHz.SelectedIndex = 3;
					break;
				case "24000":
					comboBoxVorHz.SelectedIndex = 4;
					break;
				case "22050":
					comboBoxVorHz.SelectedIndex = 5;
					break;
				case "16000":
					comboBoxVorHz.SelectedIndex = 6;
					break;
				case "12000":
					comboBoxVorHz.SelectedIndex = 7;
					break;
				case "11025":
					comboBoxVorHz.SelectedIndex = 8;
					break;
				case "8000":
					comboBoxVorHz.SelectedIndex = 9;
					break;
			}
			#endregion
			#region//VorLowpass
			switch(FormMain.VorLowpass)
			{
				case "True":
					checkBoxVorLowpass.Checked = true;
					break;
				case "False":
					checkBoxVorLowpass.Checked = false;
					break;
			}
			#endregion
			#region//VorLowpassValue
			textBoxVorLowpassValue.Text = FormMain.VorLowpassValue;
			#endregion
			#region//VorCmd
			switch(FormMain.VorCmd)
			{
				case "True":
					checkBoxVorCmd.Checked = true;
					break;
				case "False":
					checkBoxVorCmd.Checked = false;
					break;
			}
			#endregion
			#endregion
			#region[VorQB]
			#region//VorQValue
			textBoxVorQValue.Text = FormMain.VorQValue;
			hScrollBarVorQBValue.Value = Convert.ToInt32(Convert.ToDouble(FormMain.VorQValue) * 100);
			#endregion
			#endregion
			#region[VorABR]
			#region//VorABRBit
			comboBoxVorABRBit.SelectedIndex = (Convert.ToInt32(FormMain.VorABRBit) - 45);
			#endregion
			#region//VorABRMinBit
			comboBoxVorABRMinBit.SelectedIndex = (Convert.ToInt32(FormMain.VorABRMinBit) - 45);
			#endregion
			#region//VorABRMaxBit
			comboBoxVorABRMaxBit.SelectedIndex = (Convert.ToInt32(FormMain.VorABRMaxBit) - 45);
			#endregion
			#endregion
			#region[VorCBR]
			#region//VorCBRBit
			comboBoxVorCBRBit.SelectedIndex = (Convert.ToInt32(FormMain.VorCBRBit) - 45);
			#endregion
			#endregion
			#region [^^]
			#region//Add2Winamp
			switch(FormMain.Add2Winamp)
			{
				case "True":
					checkBoxAdd2Winamp.Checked = true;
					break;
				case "False":
					checkBoxAdd2Winamp.Checked = false;
					break;
			}
			#endregion
			#region//WinampPath
			textBoxWinampPath.Text = FormMain.WinampPath;
			#endregion
			#region//Fade
			switch(FormMain.Fade)
			{
				case "True":
					checkBoxFade.Checked = true;
					break;
				case "False":
					checkBoxFade.Checked = false;
					break;
			}
			#endregion
			#endregion
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			int i;

			#region Format
			switch(comboBoxFormat.SelectedIndex)
			{
				case 0:
					FormMain.Format = "WAVE";
					break;
				case 1:
					FormMain.Format = "MP3";
					break;
				case 2:
					FormMain.Format = "Vor";
					break;
			}
			#endregion
			#region Tagging
			switch(checkBoxTagging.Checked.ToString())
			{
				case "True":
					FormMain.Tagging = "True";
					break;
				case "False":
					FormMain.Tagging = "False";
					break;
			}
			#endregion
			#region DeleteDif
			switch(checkBoxDeleteDif.Checked.ToString())
			{
				case "True":
					FormMain.DeleteDif = "True";
					break;
				case "False":
					FormMain.DeleteDif = "False";
					break;
			}
			#endregion
			#region DropTrance
			FormMain.DropTrans = trackBarDropTrans.Value.ToString();
			#endregion
			#region Out&OutPath
			if(radioButtonOutDefault.Checked)
			{
				FormMain.Out = "Default";
			}
			else if(radioButtonOutBMSFolder.Checked)
			{
				FormMain.Out = "BMSFolder";
			}
			else if(radioButtonOutSelected.Checked)
			{
				FormMain.Out = "Selected";
			}
			FormMain.OutPath = textBoxOutPath.Text;
			#endregion
			#region ArtistFolder
			switch(checkBoxArtistFolder.Checked.ToString())
			{
				case "True":
					FormMain.ArtistFolder = "True";
					break;
				case "False":
					FormMain.ArtistFolder = "False";
					break;
			}
			#endregion
			#region Filename&CustomFilename
			if(radioButtonA_T.Checked)
			{
				FormMain.Filename = "Artist-Title";
			}
			else if(radioButtonT_A.Checked)
			{
				FormMain.Filename = "Title-Artist";
			}
			else if(radioButtonT.Checked)
			{
				FormMain.Filename = "Title";
			}
			else if(radioButtonC.Checked)
			{
				FormMain.Filename = "Custom";
			}
			FormMain.CustomFilename = textBoxCFilename.Text;
			#endregion
			#region WAVEng
			switch(comboBoxWAVEng.SelectedIndex)
			{
				case 0:
					FormMain.WAVEng = "tjbms2wav";
					break;
				case 1:
					FormMain.WAVEng = "BmsWaveHay2";
					break;
			}
			#endregion
			#region B2WHz
			switch(comboBoxWAVB2WHz.SelectedIndex)
			{
				case 0:
					FormMain.B2WHz = "44100";
					break;
				case 1:
					FormMain.B2WHz = "32000";
					break;
				case 2:
					FormMain.B2WHz = "24000";
					break;
				case 3:
					FormMain.B2WHz = "22050";
					break;
				case 4:
					FormMain.B2WHz = "16000";
					break;
				case 5:
					FormMain.B2WHz = "12000";
					break;
				case 6:
					FormMain.B2WHz = "11025";
					break;
				case 7:
					FormMain.B2WHz = "8000";
					break;
			}
			#endregion
			#region B2WBit
			switch(comboBoxWAVB2WBit.SelectedIndex)
			{
				case 0:
					FormMain.B2WBit = "16";
					break;
				case 1:
					FormMain.B2WBit = "8";
					break;
			}
			#endregion
			#region B2WChannel
			switch(comboBoxWAVB2WChannel.SelectedIndex)
			{
				case 0:
					FormMain.B2WChannel = "2";
					break;
				case 1:
					FormMain.B2WChannel = "1";
					break;
			}
			#endregion
			#region B2WChk
			switch(checkBoxWAVB2WChk.Checked.ToString())
			{
				case "True":
					FormMain.B2WChk = "True";
					break;
				case "False":
					FormMain.B2WChk = "False";
					break;
			}
			#endregion
			#region B2WForce
			switch(checkBoxWAVB2WForce.Checked.ToString())
			{
				case "True":
					FormMain.B2WForce = "True";
					break;
				case "False":
					FormMain.B2WForce = "False";
					break;
			}
			#endregion
			#region B2WCmd
			switch(checkBoxWAVB2WCmd.Checked.ToString())
			{
				case "True":
					FormMain.B2WCmd = "True";
					break;
				case "False":
					FormMain.B2WCmd = "False";
					break;
			}
			#endregion			
			#region B2WVol
			FormMain.B2WVol = hScrollBarWAVB2WVol.Value.ToString();
			#endregion			
			#region Hay2Hz
			switch(comboBoxWAVHay2Hz.SelectedIndex)
			{
				case 0:
					FormMain.Hay2Hz = "44100";
					break;
				case 1:
					FormMain.Hay2Hz = "32000";
					break;
				case 2:
					FormMain.Hay2Hz = "24000";
					break;
				case 3:
					FormMain.Hay2Hz = "22050";
					break;
				case 4:
					FormMain.Hay2Hz = "16000";
					break;
				case 5:
					FormMain.Hay2Hz = "12000";
					break;
				case 6:
					FormMain.Hay2Hz = "11025";
					break;
				case 7:
					FormMain.Hay2Hz = "8000";
					break;
			}
			#endregion
			#region Hay2Bit
			switch(comboBoxWAVHay2Bit.SelectedIndex)
			{
				case 0:
					FormMain.Hay2Bit = "16";
					break;
				case 1:
					FormMain.Hay2Bit = "8";
					break;
			}
			#endregion
			#region Hay2Channel
			switch(comboBoxWAVHay2Channel.SelectedIndex)
			{
				case 0:
					FormMain.Hay2Channel = "2";
					break;
				case 1:
					FormMain.Hay2Channel = "1";
					break;
			}
			#endregion
			#region Hay2PCMMethod
			switch(comboBoxWAVHay2PCMMethod.SelectedIndex)
			{
				case 0:
					FormMain.Hay2PCMMethod = "Nearest";
					break;
				case 1:
					FormMain.Hay2PCMMethod = "Linear";
					break;
				case 2:
					FormMain.Hay2PCMMethod = "Mix";
					break;
				case 3:
					FormMain.Hay2PCMMethod = "Neville";
					break;
				case 4:
					FormMain.Hay2PCMMethod = "Bezier";
					break;
			}
			#endregion
			#region Hay2FixMixing
			switch(checkBoxWAVHay2FixMixing.Checked.ToString())
			{
				case "True":
					FormMain.Hay2FixMixing = "True";
					break;
				case "False":
					FormMain.Hay2FixMixing = "False";
					break;
			}
			#endregion
			#region Hay2CutSilence
			switch(checkBoxWAVHay2CutSilence.Checked.ToString())
			{
				case "True":
					FormMain.Hay2CutSilence = "True";
					break;
				case "False":
					FormMain.Hay2CutSilence = "False";
					break;
			}
			#endregion
			#region Hay2Inverse
			switch(checkBoxWAVHay2Inverse.Checked.ToString())
			{
				case "True":
					FormMain.Hay2Inverse = "True";
					break;
				case "False":
					FormMain.Hay2Inverse = "False";
					break;
			}
			#endregion			
			#region Hay2WhiteNoise
			switch(checkBoxWAVHay2WhiteNoise.Checked.ToString())
			{
				case "True":
					FormMain.Hay2WhiteNoise = "True";
					break;
				case "False":
					FormMain.Hay2WhiteNoise = "False";
					break;
			}
			#endregion
			#region Hay2Vol
			FormMain.Hay2Vol = hScrollBarWAVHay2Vol.Value.ToString();
			#endregion			
			#region MP3Bit
			switch(comboBoxMP3Bit.SelectedIndex)
			{
				case 0:
					FormMain.MP3Bit = "CBR";
					break;
				case 1:
					FormMain.MP3Bit = "VBR";
					break;
				case 2:
					FormMain.MP3Bit = "ABR";
					break;
			}
			#endregion
			#region MP3Stereo
			switch(comboBoxMP3Stereo.SelectedIndex)
			{
				case 0:
					FormMain.MP3Stereo = "Stereo";
					break;
				case 1:
					FormMain.MP3Stereo = "Joint Stereo";
					break;
				case 2:
					FormMain.MP3Stereo = "Forced Joint Stereo";
					break;
				case 3:
					FormMain.MP3Stereo = "Mono";
					break;
			}
			#endregion			
			#region MP3q
			FormMain.MP3q = comboBoxMP3q.SelectedIndex.ToString();
			#endregion		
			#region MP3Hz
			switch(comboBoxMP3Hz.SelectedIndex)
			{
				case 0:
					FormMain.MP3Hz = "Auto";
					break;
				case 1:
					FormMain.MP3Hz = "48000";
					break;
				case 2:
					FormMain.MP3Hz = "44100";
					break;
				case 3:
					FormMain.MP3Hz = "32000";
					break;
				case 4:
					FormMain.MP3Hz = "24000";
					break;
				case 5:
					FormMain.MP3Hz = "22050";
					break;
				case 6:
					FormMain.MP3Hz = "16000";
					break;
				case 7:
					FormMain.MP3Hz = "12000";
					break;
				case 8:
					FormMain.MP3Hz = "11025";
					break;
				case 9:
					FormMain.MP3Hz = "8000";
					break;
			}
			#endregion		
			#region MP3Lowpass
			switch(checkBoxMP3Lowpass.Checked.ToString())
			{
				case "True":
					FormMain.MP3Lowpass = "True";
					break;
				case "False":
					FormMain.MP3Lowpass = "False";
					break;
			}
			#endregion
			#region MP3LowpassValue
			FormMain.MP3LowpassValue = textBoxMP3LowpassValue.Text;
			#endregion
			#region MP3nspsytune
			switch(checkBoxMP3nspsytune.Checked.ToString())
			{
				case "True":
					FormMain.MP3nspsytune = "True";
					break;
				case "False":
					FormMain.MP3nspsytune = "False";
					break;
			}
			#endregion
			#region MP3Cmd
			switch(checkBoxMP3Cmd.Checked.ToString())
			{
				case "True":
					FormMain.MP3Cmd = "True";
					break;
				case "False":
					FormMain.MP3Cmd = "False";
					break;
			}
			#endregion
			#region MP3CBRBit
			switch(comboBoxMP3CBRBit.SelectedIndex)
			{
				case 0:
					FormMain.MP3CBRBit = "32";
					break;
				case 1:
					FormMain.MP3CBRBit = "40";
					break;
				case 2:
					FormMain.MP3CBRBit = "48";
					break;
				case 3:
					FormMain.MP3CBRBit = "56";
					break;
				case 4:
					FormMain.MP3CBRBit = "64";
					break;
				case 5:
					FormMain.MP3CBRBit = "80";
					break;
				case 6:
					FormMain.MP3CBRBit = "96";
					break;
				case 7:
					FormMain.MP3CBRBit = "112";
					break;
				case 8:
					FormMain.MP3CBRBit = "128";
					break;
				case 9:
					FormMain.MP3CBRBit = "160";
					break;
				case 10:
					FormMain.MP3CBRBit = "192";
					break;
				case 11:
					FormMain.MP3CBRBit = "224";
					break;
				case 12:
					FormMain.MP3CBRBit = "256";
					break;
				case 13:
					FormMain.MP3CBRBit = "320";
					break;
			}
			#endregion		
			#region MP3CBRUsePreset
			switch(checkBoxMP3CBRUsePreset.Checked.ToString())
			{
				case "True":
					FormMain.MP3CBRUsePreset = "True";
					break;
				case "False":
					FormMain.MP3CBRUsePreset = "False";
					break;
			}
			#endregion
			#region MP3CBRPreset
			switch(comboBoxMP3CBRPreset.SelectedIndex)
			{
				case 0:
					FormMain.MP3CBRPreset = "*";
					break;
				case 1:
					FormMain.MP3CBRPreset = "insane";
					break;
			}
			#endregion
			#region MP3VBRMinBit
			switch(comboBoxMP3VBRMinBit.SelectedIndex)
			{
				case 0:
					FormMain.MP3VBRMinBit = "none";
					break;
				case 1:
					FormMain.MP3VBRMinBit = "32";
					break;
				case 2:
					FormMain.MP3VBRMinBit = "40";
					break;
				case 3:
					FormMain.MP3VBRMinBit = "48";
					break;
				case 4:
					FormMain.MP3VBRMinBit = "56";
					break;
				case 5:
					FormMain.MP3VBRMinBit = "64";
					break;
				case 6:
					FormMain.MP3VBRMinBit = "80";
					break;
				case 7:
					FormMain.MP3VBRMinBit = "96";
					break;
				case 8:
					FormMain.MP3VBRMinBit = "112";
					break;
				case 9:
					FormMain.MP3VBRMinBit = "128";
					break;
				case 10:
					FormMain.MP3VBRMinBit = "160";
					break;
				case 11:
					FormMain.MP3VBRMinBit = "192";
					break;
				case 12:
					FormMain.MP3VBRMinBit = "224";
					break;
				case 13:
					FormMain.MP3VBRMinBit = "256";
					break;
				case 14:
					FormMain.MP3VBRMinBit = "320";
					break;
			}
			#endregion		
			#region MP3VBRMaxBit
			switch(comboBoxMP3VBRMaxBit.SelectedIndex)
			{
				case 0:
					FormMain.MP3VBRMaxBit = "none";
					break;
				case 1:
					FormMain.MP3VBRMaxBit = "32";
					break;
				case 2:
					FormMain.MP3VBRMaxBit = "40";
					break;
				case 3:
					FormMain.MP3VBRMaxBit = "48";
					break;
				case 4:
					FormMain.MP3VBRMaxBit = "56";
					break;
				case 5:
					FormMain.MP3VBRMaxBit = "64";
					break;
				case 6:
					FormMain.MP3VBRMaxBit = "80";
					break;
				case 7:
					FormMain.MP3VBRMaxBit = "96";
					break;
				case 8:
					FormMain.MP3VBRMaxBit = "112";
					break;
				case 9:
					FormMain.MP3VBRMaxBit = "128";
					break;
				case 10:
					FormMain.MP3VBRMaxBit = "160";
					break;
				case 11:
					FormMain.MP3VBRMaxBit = "192";
					break;
				case 12:
					FormMain.MP3VBRMaxBit = "224";
					break;
				case 13:
					FormMain.MP3VBRMaxBit = "256";
					break;
				case 14:
					FormMain.MP3VBRMaxBit = "320";
					break;
			}
			#endregion		
			#region MP3VBRq
			FormMain.MP3VBRq = comboBoxMP3VBRq.SelectedIndex.ToString();
			#endregion		
			#region MP3VBRMethod
			switch(comboBoxMP3VBRMethod.SelectedIndex)
			{
				case 0:
					FormMain.MP3VBRMethod = "old";
					break;
				case 1:
					FormMain.MP3VBRMethod = "new";
					break;
			}
			#endregion		
			#region MP3VBRForceMinBit
			switch(checkBoxMP3VBRForceMinBit.Checked.ToString())
			{
				case "True":
					FormMain.MP3VBRForceMinBit = "True";
					break;
				case "False":
					FormMain.MP3VBRForceMinBit = "False";
					break;
			}
			#endregion
			#region MP3VBRUsePreset
			switch(checkBoxMP3VBRUsePreset.Checked.ToString())
			{	
				case "True":
					FormMain.MP3VBRUsePreset = "True";
					break;
				case "False":
					FormMain.MP3VBRUsePreset = "False";
					break;
			}
			#endregion
			#region MP3VBRPreset
			switch(comboBoxMP3VBRPreset.SelectedIndex)
			{
				case 0:
					FormMain.MP3VBRPreset = "medium";
					break;
				case 1:
					FormMain.MP3VBRPreset = "standard";
					break;
				case 2:
					FormMain.MP3VBRPreset = "extreme";
					break;
				case 3:
					FormMain.MP3VBRPreset = "fast medium";
					break;
				case 4:
					FormMain.MP3VBRPreset = "fast standard";
					break;
				case 5:
					FormMain.MP3VBRPreset = "fast extreme";
					break;
				case 6:
					FormMain.MP3VBRPreset = "r3mix";
					break;
			}
			#endregion
			#region MP3ABRBit
			switch(comboBoxMP3ABRBit.SelectedIndex)
			{
				case 0:
					FormMain.MP3ABRBit = "32";
					break;
				case 1:
					FormMain.MP3ABRBit = "40";
					break;
				case 2:
					FormMain.MP3ABRBit = "48";
					break;
				case 3:
					FormMain.MP3ABRBit = "56";
					break;
				case 4:
					FormMain.MP3ABRBit = "64";
					break;
				case 5:
					FormMain.MP3ABRBit = "80";
					break;
				case 6:
					FormMain.MP3ABRBit = "96";
					break;
				case 7:
					FormMain.MP3ABRBit = "112";
					break;
				case 8:
					FormMain.MP3ABRBit = "128";
					break;
				case 9:
					FormMain.MP3ABRBit = "160";
					break;
				case 10:
					FormMain.MP3ABRBit = "192";
					break;
				case 11:
					FormMain.MP3ABRBit = "224";
					break;
				case 12:
					FormMain.MP3ABRBit = "256";
					break;
				case 13:
					FormMain.MP3ABRBit = "320";
					break;
			}
			#endregion		
			#region MP3ABRMinBit
			switch(comboBoxMP3ABRMinBit.SelectedIndex)
			{
				case 0:
					FormMain.MP3ABRMinBit = "none";
					break;
				case 1:
					FormMain.MP3ABRMinBit = "32";
					break;
				case 2:
					FormMain.MP3ABRMinBit = "40";
					break;
				case 3:
					FormMain.MP3ABRMinBit = "48";
					break;
				case 4:
					FormMain.MP3ABRMinBit = "56";
					break;
				case 5:
					FormMain.MP3ABRMinBit = "64";
					break;
				case 6:
					FormMain.MP3ABRMinBit = "80";
					break;
				case 7:
					FormMain.MP3ABRMinBit = "96";
					break;
				case 8:
					FormMain.MP3ABRMinBit = "112";
					break;
				case 9:
					FormMain.MP3ABRMinBit = "128";
					break;
				case 10:
					FormMain.MP3ABRMinBit = "160";
					break;
				case 11:
					FormMain.MP3ABRMinBit = "192";
					break;
				case 12:
					FormMain.MP3ABRMinBit = "224";
					break;
				case 13:
					FormMain.MP3ABRMinBit = "256";
					break;
				case 14:
					FormMain.MP3ABRMinBit = "320";
					break;
			}
			#endregion		
			#region MP3ABRMaxBit
			switch(comboBoxMP3ABRMaxBit.SelectedIndex)
			{
				case 0:
					FormMain.MP3ABRMaxBit = "none";
					break;
				case 1:
					FormMain.MP3ABRMaxBit = "32";
					break;
				case 2:
					FormMain.MP3ABRMaxBit = "40";
					break;
				case 3:
					FormMain.MP3ABRMaxBit = "48";
					break;
				case 4:
					FormMain.MP3ABRMaxBit = "56";
					break;
				case 5:
					FormMain.MP3ABRMaxBit = "64";
					break;
				case 6:
					FormMain.MP3ABRMaxBit = "80";
					break;
				case 7:
					FormMain.MP3ABRMaxBit = "96";
					break;
				case 8:
					FormMain.MP3ABRMaxBit = "112";
					break;
				case 9:
					FormMain.MP3ABRMaxBit = "128";
					break;
				case 10:
					FormMain.MP3ABRMaxBit = "160";
					break;
				case 11:
					FormMain.MP3ABRMaxBit = "192";
					break;
				case 12:
					FormMain.MP3ABRMaxBit = "224";
					break;
				case 13:
					FormMain.MP3ABRMaxBit = "256";
					break;
				case 14:
					FormMain.MP3ABRMaxBit = "320";
					break;
			}
			#endregion		
			#region MP3ABRForceMinBit
			switch(checkBoxMP3ABRForceMinBit.Checked.ToString())
			{
				case "True":
					FormMain.MP3ABRForceMinBit = "True";
					break;
				case "False":
					FormMain.MP3ABRForceMinBit = "False";
					break;
			}
			#endregion
			#region MP3ABRUsePreset
			switch(checkBoxMP3ABRUsePreset.Checked.ToString())
			{
				case "True":
					FormMain.MP3ABRUsePreset = "True";
					break;
				case "False":
					FormMain.MP3ABRUsePreset = "False";
					break;
			}
			#endregion
			#region MP3ABRPreset
			switch(comboBoxMP3ABRPreset.SelectedIndex)
			{
				case 0:
					FormMain.MP3ABRPreset = "*";
					break;
				case 1:
					FormMain.MP3ABRPreset = "phone";
					break;
				case 2:
					FormMain.MP3ABRPreset = "phon+";
					break;
				case 3:
					FormMain.MP3ABRPreset = "mw-us";
					break;
				case 4:
					FormMain.MP3ABRPreset = "fm";
					break;
				case 5:
					FormMain.MP3ABRPreset = "hifi";
					break;
				case 6:
					FormMain.MP3ABRPreset = "cd";
					break;
				case 7:
					FormMain.MP3ABRPreset = "studio";
					break;
			}
			#endregion
			#region MP3ABRPresetBit
			FormMain.MP3ABRPresetBit = numericUpDownMP3ABRPresetBit.Value.ToString();
			#endregion
			#region VorBit
			switch(comboBoxVorBit.SelectedIndex)
			{
				case 0:
					FormMain.VorBit = "quality";
					break;
				case 1:
					FormMain.VorBit = "ABR";
					break;
				case 2:
					FormMain.VorBit = "CBR";
					break;
			}
			#endregion
			#region VorHz
			switch(comboBoxVorHz.SelectedIndex)
			{
				case 0:
					FormMain.VorHz = "Auto";
					break;
				case 1:
					FormMain.VorHz = "48000";
					break;
				case 2:
					FormMain.VorHz = "44100";
					break;
				case 3:
					FormMain.VorHz = "32000";
					break;
				case 4:
					FormMain.VorHz = "24000";
					break;
				case 5:
					FormMain.VorHz = "22050";
					break;
				case 6:
					FormMain.VorHz = "16000";
					break;
				case 7:
					FormMain.VorHz = "12000";
					break;
				case 8:
					FormMain.VorHz = "11025";
					break;
				case 9:
					FormMain.VorHz = "8000";
					break;
			}
			#endregion		
			#region VorLowpass
			switch(checkBoxVorLowpass.Checked.ToString())
			{
				case "True":
					FormMain.VorLowpass = "True";
					break;
				case "False":
					FormMain.VorLowpass = "False";
					break;
			}
			#endregion
			#region VorLowpassValue
			FormMain.VorLowpassValue = textBoxVorLowpassValue.Text;
			#endregion
			#region VorCmd
			switch(checkBoxVorCmd.Checked.ToString())
			{
				case "True":
					FormMain.VorCmd = "True";
					break;
				case "False":
					FormMain.VorCmd = "False";
					break;
			}
			#endregion
			#region VorQValue
			FormMain.VorQValue = textBoxVorQValue.Text;
			#endregion
			#region VorABRBit
			i = comboBoxVorABRBit.SelectedIndex + 45;
			FormMain.VorABRBit = i.ToString();
			#endregion
			#region VorABRMinBit
			i = comboBoxVorABRMinBit.SelectedIndex + 45;
			FormMain.VorABRMinBit = i.ToString();
			#endregion
			#region VorABRMaxBit
			i = comboBoxVorABRMaxBit.SelectedIndex + 45;
			FormMain.VorABRMaxBit = i.ToString();
			#endregion
			#region VorCBRBit
			i = comboBoxVorCBRBit.SelectedIndex + 45;
			FormMain.VorCBRBit = i.ToString();
			#endregion
			#region Add2Winamp
			switch(checkBoxAdd2Winamp.Checked.ToString())
			{
				case "True":
					FormMain.Add2Winamp = "True";
					break;
				case "False":
					FormMain.Add2Winamp = "False";
					break;
			}
			#endregion
			#region WinampPath
			FormMain.WinampPath = textBoxWinampPath.Text;
			#endregion
			#region Fade
			switch(checkBoxFade.Checked.ToString())
			{
				case "True":
					FormMain.Fade = "True";
					break;
				case "False":
					FormMain.Fade = "False";
					break;
			}
			#endregion
		}

		private void textBoxVorQValue_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (ch < '0' || ch > '9')
			{
				e.Handled = true;	//入力取消し
			}
		}

		private void hScrollBarVorQBValue_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			float single1 = ((float)hScrollBarVorQBValue.Value) / 100f;
			labelVorbisBitrate.Text = VorbisQualityToBitrate(single1).ToString("0.00") + " Kbps";
			textBoxVorQValue.Text = single1.ToString("0.00");
		}

		private float VorbisQualityToBitrate(float single1)
		{
			float ret;
			if (single1 <= 0f)
			{
				ret = 45f + ((single1 + 1f) * 19f);
			}
			else if (single1 <= 4f)
			{
				ret = 64f + (single1 * 16f);
			}
			else if (single1 <= 8f)
			{
				ret = 128f + ((single1 - 4f) * 32f);
			}
			else if (single1 <= 9f)
			{
				ret = 256f + ((single1 - 8f) * 64f);
			}
			else if (single1 <= 10f)
			{
				ret = 320f + ((single1 - 9f) * 180f);
			}
			else
			{
				ret = 0f;
			}
			return ret;
		}

		private void textBoxVorQValue_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxVorQValue.Text != "")
			{
				if (Convert.ToDouble(textBoxVorQValue.Text) > 10 || Convert.ToDouble(textBoxVorQValue.Text) < -1)
				{
					errorProvider.SetError(textBoxVorQValue, "-1から10までの値を入力してください");
					textBoxVorQValue.Clear();
				}
				else
				{
					errorProvider.SetError(textBoxVorQValue, null);
					hScrollBarVorQBValue.Value = Convert.ToInt32(Convert.ToDouble(textBoxVorQValue.Text) * 100);
				}
			}

		}

		private void tabControlMP3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(tabControlMP3.SelectedIndex)
			{
				case 0:
					checkBoxMP3CBRUsePreset_CheckedChanged(sender,e);
					break;
				case 1:
					checkBoxMP3VBRUsePreset_CheckedChanged(sender,e);
					break;
				case 2:
					checkBoxMP3ABRUsePreset_CheckedChanged(sender,e);
					break;
			}
		}

		private void comboBoxMP3Bit_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(comboBoxMP3Bit.SelectedIndex)
			{
				case 0:
					tabControlMP3.SelectedIndex = 0;
					comboBoxMP3Bit.Focus();
					break;
				case 1:
					tabControlMP3.SelectedIndex = 1;
					comboBoxMP3Bit.Focus();
					break;
				case 2:
					tabControlMP3.SelectedIndex = 2;
					comboBoxMP3Bit.Focus();
					break;
			}
		}

		private void buttonSelectOutPath_Click(object sender, System.EventArgs e)
		{
			folderBrowserDialog.ShowDialog();
			if(folderBrowserDialog.SelectedPath != "")
			{
				textBoxOutPath.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void radioButtonOutDefault_CheckedChanged(object sender, System.EventArgs e)
		{
			textBoxOutPath.Enabled = false;
			buttonSelectOutPath.Enabled = false;
		}

		private void radioButtonOutBMSFolder_CheckedChanged(object sender, System.EventArgs e)
		{
			this.radioButtonOutDefault_CheckedChanged(sender,e);
		}

		private void radioButtonOutSelected_CheckedChanged(object sender, System.EventArgs e)
		{
			textBoxOutPath.Enabled = true;
			buttonSelectOutPath.Enabled = true;
		}

		// ローパス使用チェック変更時イベント
		private void checkBoxMP3Lowpass_CheckedChanged(object sender, System.EventArgs e)
		{
			switch(checkBoxMP3Lowpass.Checked.ToString())
			{
				case "True" :
					textBoxMP3LowpassValue.Enabled = true;
					break;
				case "False" :
					textBoxMP3LowpassValue.Enabled = false;
					break;
			}
		}

		// CBRプリセット変更時イベント
		private void comboBoxMP3CBRPreset_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(checkBoxMP3CBRUsePreset.Checked == true)
			{
				switch(comboBoxMP3CBRPreset.SelectedIndex)
				{
						// --preset cbr *
					case 0:
						comboBoxMP3CBRBit.Enabled = true;
						break;
						// --preset insane
					case 1:
						comboBoxMP3CBRBit.Enabled = false;
						comboBoxMP3CBRBit.SelectedIndex = 13;	// 320Kbps
						break;
				}
			}
		}

		// CBRプリセット使用チェック変更時イベント
		private void checkBoxMP3CBRUsePreset_CheckedChanged(object sender, System.EventArgs e)
		{
			switch(checkBoxMP3CBRUsePreset.Checked.ToString())
			{

				case "True":
					comboBoxMP3CBRPreset.Enabled = true;
					comboBoxMP3CBRPreset_SelectedIndexChanged(sender,e);
					comboBoxMP3q.Enabled = false;
					comboBoxMP3Stereo.Enabled = false;
					checkBoxMP3Lowpass.Enabled = false;
					textBoxMP3LowpassValue.Enabled = false;
					break;
				case "False":
					comboBoxMP3CBRPreset.Enabled = false;
					comboBoxMP3CBRBit.Enabled = true;
					comboBoxMP3q.Enabled = true;
					comboBoxMP3Stereo.Enabled = true;
					checkBoxMP3Lowpass.Enabled = true;
					if(checkBoxMP3Lowpass.Checked == true){textBoxMP3LowpassValue.Enabled = true;}
					break;
			}
		}
		// VBRプリセット変更時イベント
		private void comboBoxMP3VBRPreset_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(checkBoxMP3VBRUsePreset.Checked == true)
			{
				switch(comboBoxMP3VBRPreset.SelectedIndex)
				{
						// --preset medium
					case 0:
						comboBoxMP3VBRMinBit.Enabled = false;
						comboBoxMP3VBRMaxBit.Enabled = false;
						comboBoxMP3VBRq.Enabled = false;
						comboBoxMP3VBRMethod.Enabled = false;
						comboBoxMP3VBRq.SelectedIndex = 3;			// V 3
						comboBoxMP3VBRMethod.SelectedIndex = 0;		// old
						comboBoxMP3VBRMinBit.SelectedIndex = 5;		// 64Kbps
						comboBoxMP3VBRMaxBit.SelectedIndex = 14;	// 320Kbps
						break;
						// --preset standard
					case 1:
						comboBoxMP3VBRMinBit.Enabled = false;
						comboBoxMP3VBRMaxBit.Enabled = false;
						comboBoxMP3VBRq.Enabled = false;
						comboBoxMP3VBRMethod.Enabled = false;
						comboBoxMP3VBRq.SelectedIndex = 2;			// V 2
						comboBoxMP3VBRMethod.SelectedIndex = 0;		// old
						comboBoxMP3VBRMinBit.SelectedIndex = 9;	// 128Kbps
						comboBoxMP3VBRMaxBit.SelectedIndex = 14;	// 320Kbps
						break;
						// --preset extreme
					case 2:
						comboBoxMP3VBRMinBit.Enabled = false;
						comboBoxMP3VBRMaxBit.Enabled = false;
						comboBoxMP3VBRq.Enabled = false;
						comboBoxMP3VBRMethod.Enabled = false;
						comboBoxMP3VBRq.SelectedIndex = 2;			// V 2
						comboBoxMP3VBRMethod.SelectedIndex = 0;		// old
						comboBoxMP3VBRMinBit.SelectedIndex = 9;	// 128Kbps
						comboBoxMP3VBRMaxBit.SelectedIndex = 14;	// 320Kbps
						break;
						// --preset fast medium
					case 3:
						comboBoxMP3VBRMinBit.Enabled = false;
						comboBoxMP3VBRMaxBit.Enabled = false;
						comboBoxMP3VBRq.Enabled = false;
						comboBoxMP3VBRMethod.Enabled = false;
						comboBoxMP3VBRq.SelectedIndex = 3;			// V 3
						comboBoxMP3VBRMethod.SelectedIndex = 0;		// old
						comboBoxMP3VBRMinBit.SelectedIndex = 5;		// 64Kbps
						comboBoxMP3VBRMaxBit.SelectedIndex = 14;	// 320Kbps
						break;
						// --preset fast standard
					case 4:
						comboBoxMP3VBRMinBit.Enabled = false;
						comboBoxMP3VBRMaxBit.Enabled = false;
						comboBoxMP3VBRq.Enabled = false;
						comboBoxMP3VBRMethod.Enabled = false;
						comboBoxMP3VBRq.SelectedIndex = 2;			// V 2
						comboBoxMP3VBRMethod.SelectedIndex = 0;		// old
						comboBoxMP3VBRMinBit.SelectedIndex = 9;	// 128Kbps
						comboBoxMP3VBRMaxBit.SelectedIndex = 14;	// 320Kbps
						break;
						// --preset fast extreme
					case 5:
						comboBoxMP3VBRMinBit.Enabled = false;
						comboBoxMP3VBRMaxBit.Enabled = false;
						comboBoxMP3VBRq.Enabled = false;
						comboBoxMP3VBRMethod.Enabled = false;
						comboBoxMP3VBRq.SelectedIndex = 2;			// V 2
						comboBoxMP3VBRMethod.SelectedIndex = 0;		// old
						comboBoxMP3VBRMinBit.SelectedIndex = 9;	// 128Kbps
						comboBoxMP3VBRMaxBit.SelectedIndex = 14;	// 320Kbps
						break;
						// --r3mix
					case 6:
						comboBoxMP3VBRMinBit.Enabled = false;
						comboBoxMP3VBRMaxBit.Enabled = false;
						comboBoxMP3VBRq.Enabled = false;
						comboBoxMP3VBRMethod.Enabled = false;
						comboBoxMP3VBRq.SelectedIndex = 1;			// V 1
						comboBoxMP3VBRMethod.SelectedIndex = 1;		// new
						comboBoxMP3VBRMinBit.SelectedIndex = 7;	// 128Kbps
						comboBoxMP3VBRMaxBit.SelectedIndex = 14;	// 320Kbps
						break;
				}
			}
		}

		// VBRプリセット使用チェック変更時イベント
		private void checkBoxMP3VBRUsePreset_CheckedChanged(object sender, System.EventArgs e)
		{
			switch(checkBoxMP3VBRUsePreset.Checked.ToString())
			{
				case "True":
					comboBoxMP3VBRPreset.Enabled = true;
					comboBoxMP3VBRPreset_SelectedIndexChanged(sender,e);
					comboBoxMP3q.Enabled = false;
					comboBoxMP3Stereo.Enabled = false;
					checkBoxMP3Lowpass.Enabled = false;
					textBoxMP3LowpassValue.Enabled = false;
					break;
				case "False":
					comboBoxMP3VBRPreset.Enabled = false;
					comboBoxMP3VBRMinBit.Enabled = true;
					comboBoxMP3VBRMaxBit.Enabled = true;
					comboBoxMP3VBRq.Enabled = true;
					comboBoxMP3VBRMethod.Enabled = true;
					comboBoxMP3q.Enabled = true;
					comboBoxMP3Stereo.Enabled = true;
					checkBoxMP3Lowpass.Enabled = true;
					if(checkBoxMP3Lowpass.Checked == true){textBoxMP3LowpassValue.Enabled = true;}
					break;
			}		
		}

		private void comboBoxMP3ABRPreset_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(checkBoxMP3ABRUsePreset.Checked == true)
			{
				switch(comboBoxMP3ABRPreset.SelectedIndex)
				{
						// --preset *
					case 0:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = false;
						comboBoxMP3ABRMinBitDummy.Visible = false;
						comboBoxMP3ABRMaxBitDummy.Visible = false;
						numericUpDownMP3ABRPresetBit.Enabled = true;
						break;
						// --preset phone
					case 1:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"16 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"8 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"160 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
						// --preset phon+
					case 2:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"24 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"8 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"160 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
						// --preset mw-us
					case 3:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"40 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"32 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"320 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
						// --preset voice
					case 4:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"56 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"32 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"320 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
						// --preset fm,radio,tape
					case 5:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"112 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"32 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"320 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
						// --preset hifi
					case 6:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"160 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"32 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"320 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
						// --preset cd
					case 7:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"192 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"32 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"320 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
						// --preset studio
					case 8:
						comboBoxMP3ABRBit.Enabled = false;
						comboBoxMP3ABRMinBit.Enabled = false;
						comboBoxMP3ABRMaxBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Visible = true;
						comboBoxMP3ABRMinBitDummy.Visible = true;
						comboBoxMP3ABRMaxBitDummy.Visible = true;
						numericUpDownMP3ABRPresetBit.Enabled = false;
						comboBoxMP3ABRBitDummy.Items.RemoveAt(0);
						comboBoxMP3ABRBitDummy.Items.Insert(0,"256 Kbps");
						comboBoxMP3ABRBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMinBitDummy.Items.Insert(0,"32 Kbps");
						comboBoxMP3ABRMinBitDummy.SelectedIndex = 0;
						comboBoxMP3ABRMaxBitDummy.Items.Insert(0,"320 Kbps");
						comboBoxMP3ABRMaxBitDummy.SelectedIndex = 0;
						break;
				}
			}		
		}

		private void checkBoxMP3ABRUsePreset_CheckedChanged(object sender, System.EventArgs e)
		{
			switch(checkBoxMP3ABRUsePreset.Checked.ToString())
			{
				case "True":
					comboBoxMP3ABRPreset.Enabled = true;
					comboBoxMP3ABRPreset_SelectedIndexChanged(sender,e);
					comboBoxMP3q.Enabled = false;
					comboBoxMP3Stereo.Enabled = false;
					checkBoxMP3Lowpass.Enabled = false;
					textBoxMP3LowpassValue.Enabled = false;
					break;
				case "False":
					comboBoxMP3ABRPreset.Enabled = false;
					comboBoxMP3ABRBitDummy.Visible = false;
					comboBoxMP3ABRMinBitDummy.Visible = false;
					comboBoxMP3ABRMaxBitDummy.Visible = false;
					comboBoxMP3ABRBit.Enabled = true;
					comboBoxMP3ABRMaxBit.Enabled = true;
					comboBoxMP3ABRMinBit.Enabled = true;
					comboBoxMP3ABRMaxBit.Enabled = true;
					comboBoxMP3q.Enabled = true;
					comboBoxMP3Stereo.Enabled = true;
					checkBoxMP3Lowpass.Enabled = true;
					numericUpDownMP3ABRPresetBit.Enabled = false;
					if(checkBoxMP3Lowpass.Checked == true){textBoxMP3LowpassValue.Enabled = true;}
					break;
			}		
		}

		private void trackBarDropTrans_Scroll(object sender, System.EventArgs e)
		{
			labeltrackBarDropTransValue.Text = trackBarDropTrans.Value.ToString();
		}

		private void buttonWinampPath_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.InitialDirectory = "" ;
			openFileDialog1.Filter = "Winamp (winamp.exe)|winamp.exe";
			openFileDialog1.RestoreDirectory = true ;
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBoxWinampPath.Text = Path.GetFileName(openFileDialog1.FileName);
			}
		}

		private void comboBoxVorBit_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(comboBoxVorBit.SelectedIndex)
			{
				case 0:
					tabControlVor.SelectedIndex = 0;
					comboBoxVorBit.Focus();
					break;
				case 1:
					tabControlVor.SelectedIndex = 1;
					comboBoxVorBit.Focus();
					break;
				case 2:
					tabControlVor.SelectedIndex = 2;
					comboBoxVorBit.Focus();
					break;
			}
		}

		private void hScrollBarWAVB2WVol_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			labelWAVB2WVol.Text = hScrollBarWAVB2WVol.Value.ToString();
		}

		private void hScrollBarWAVHay2Vol_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			labelWAVHay2Vol.Text = hScrollBarWAVHay2Vol.Value.ToString();
		}

		private void comboBoxWAVEng_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(comboBoxWAVEng.SelectedIndex)
			{
				case 0:
					tabControlWAVE.SelectedIndex = 0;
					comboBoxWAVEng.Focus();
					break;
				case 1:
					tabControlWAVE.SelectedIndex = 1;
					comboBoxWAVEng.Focus();
					break;
					/*
				case 2:
					tabControlWAVE.SelectedIndex = 2;
					comboBoxWAVEng.Focus();
					break;
					*/
			}
		}
	}
}

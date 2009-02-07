#region using
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics ;  // for Process
using System.Threading;
using System.Text;
#endregion

namespace Cage
{
	/// <summary>
	/// Cageのメインフォームです。
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		private const string APPLICATION_NAME = "Cage";
		private const string APPLICATION_VERSION = "0.1 Alpha5";

		#region template

		private System.ComponentModel.IContainer components;

		public FormMain()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormMain));
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemFileOp = new System.Windows.Forms.MenuItem();
			this.menuItemFileOpFolder = new System.Windows.Forms.MenuItem();
			this.menuItemFileOpM3U = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItemFileHtml = new System.Windows.Forms.MenuItem();
			this.menuItemFileM3U = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItemFileExit = new System.Windows.Forms.MenuItem();
			this.menuItemEdit = new System.Windows.Forms.MenuItem();
			this.menuItemEditClear = new System.Windows.Forms.MenuItem();
			this.menuItemEditDel = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItemEditTag = new System.Windows.Forms.MenuItem();
			this.menuItem36 = new System.Windows.Forms.MenuItem();
			this.menuItemEditFont = new System.Windows.Forms.MenuItem();
			this.menuItemConv = new System.Windows.Forms.MenuItem();
			this.menuItemConvAll = new System.Windows.Forms.MenuItem();
			this.menuItemConvAbort = new System.Windows.Forms.MenuItem();
			this.menuItemConvChosen = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItemOptionConf = new System.Windows.Forms.MenuItem();
			this.menuItemPlay = new System.Windows.Forms.MenuItem();
			this.menuItemPlayDefault = new System.Windows.Forms.MenuItem();
			this.menuItemPlayNext = new System.Windows.Forms.MenuItem();
			this.menuItemPlayWinamp = new System.Windows.Forms.MenuItem();
			this.menuItemPlayubm = new System.Windows.Forms.MenuItem();
			this.menuItemPlaybmev = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItemPlaynazo = new System.Windows.Forms.MenuItem();
			this.menuItemPlayddr = new System.Windows.Forms.MenuItem();
			this.menuItemPlaymw = new System.Windows.Forms.MenuItem();
			this.menuItemPlayrdm = new System.Windows.Forms.MenuItem();
			this.menuItemPlaybm98 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItemHelp = new System.Windows.Forms.MenuItem();
			this.menuItemHelpRead = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItemHelpWeb = new System.Windows.Forms.MenuItem();
			this.menuItemHelpBbs = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItemHelpVer = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanelName = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanelProgress = new Cage.StatusBarProgressPanel();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.sep00 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonListClear = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonOpen = new System.Windows.Forms.ToolBarButton();
			this.contextMenuOpen = new System.Windows.Forms.ContextMenu();
			this.menuItemFileOpR = new System.Windows.Forms.MenuItem();
			this.menuItemFileOpFolderR = new System.Windows.Forms.MenuItem();
			this.menuItemFileOpM3UR = new System.Windows.Forms.MenuItem();
			this.toolBarButtonSave = new System.Windows.Forms.ToolBarButton();
			this.contextMenuSave = new System.Windows.Forms.ContextMenu();
			this.menuItemFileHtmlR = new System.Windows.Forms.MenuItem();
			this.menuItemFileM3UR = new System.Windows.Forms.MenuItem();
			this.sep01 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonPlay = new System.Windows.Forms.ToolBarButton();
			this.sep03 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonConv = new System.Windows.Forms.ToolBarButton();
			this.contextMenuConv = new System.Windows.Forms.ContextMenu();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.toolBarButtonAbort = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonOption = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listViewBms = new System.Windows.Forms.ListView();
			this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderGenre = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderArtist = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFormat = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderKbps = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderYear = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderInPath = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderOutPath = new System.Windows.Forms.ColumnHeader();
			this.contextMenuListRight = new System.Windows.Forms.ContextMenu();
			this.menuItemEditClearR = new System.Windows.Forms.MenuItem();
			this.menuItemEditDelR = new System.Windows.Forms.MenuItem();
			this.colorFadeBusyBar1 = new System.Windows.Forms.BusyBar.ColorFadeBusyBar();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelProgress)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItemFile,
																					 this.menuItemEdit,
																					 this.menuItemConv,
																					 this.menuItemPlay,
																					 this.menuItemHelp});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemFileOp,
																						 this.menuItemFileOpFolder,
																						 this.menuItemFileOpM3U,
																						 this.menuItem22,
																						 this.menuItemFileHtml,
																						 this.menuItemFileM3U,
																						 this.menuItem20,
																						 this.menuItemFileExit});
			this.menuItemFile.Text = "ファイル (&F)";
			// 
			// menuItemFileOp
			// 
			this.menuItemFileOp.Index = 0;
			this.menuItemFileOp.Text = "ファイルを開く (&O)";
			this.menuItemFileOp.Click += new System.EventHandler(this.menuItemFileOp_Click);
			// 
			// menuItemFileOpFolder
			// 
			this.menuItemFileOpFolder.Index = 1;
			this.menuItemFileOpFolder.Text = "フォルダを開く (&F)";
			this.menuItemFileOpFolder.Click += new System.EventHandler(this.menuItemFileOpFolder_Click);
			// 
			// menuItemFileOpM3U
			// 
			this.menuItemFileOpM3U.Index = 2;
			this.menuItemFileOpM3U.Text = "M3Uプレイリストを開く (&P)";
			this.menuItemFileOpM3U.Click += new System.EventHandler(this.menuItemFileOpM3U_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 3;
			this.menuItem22.Text = "-";
			// 
			// menuItemFileHtml
			// 
			this.menuItemFileHtml.Index = 4;
			this.menuItemFileHtml.Text = "HTMLでリストを生成 (&H)";
			this.menuItemFileHtml.Click += new System.EventHandler(this.menuItemFileHtml_Click);
			// 
			// menuItemFileM3U
			// 
			this.menuItemFileM3U.Index = 5;
			this.menuItemFileM3U.Text = "M3Uでプレイリストを生成 (&M)";
			this.menuItemFileM3U.Click += new System.EventHandler(this.menuItemFileM3U_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 6;
			this.menuItem20.Text = "-";
			// 
			// menuItemFileExit
			// 
			this.menuItemFileExit.Index = 7;
			this.menuItemFileExit.Text = "終了 (&E)";
			this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
			// 
			// menuItemEdit
			// 
			this.menuItemEdit.Index = 1;
			this.menuItemEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemEditClear,
																						 this.menuItemEditDel,
																						 this.menuItem12,
																						 this.menuItemEditTag,
																						 this.menuItem36,
																						 this.menuItemEditFont});
			this.menuItemEdit.Text = "編集 (&E)";
			// 
			// menuItemEditClear
			// 
			this.menuItemEditClear.Index = 0;
			this.menuItemEditClear.Text = "リストをクリア (&C)";
			this.menuItemEditClear.Click += new System.EventHandler(this.menuItemEditClear_Click);
			// 
			// menuItemEditDel
			// 
			this.menuItemEditDel.Index = 1;
			this.menuItemEditDel.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menuItemEditDel.Text = "リストから削除";
			this.menuItemEditDel.Click += new System.EventHandler(this.menuItemEditDel_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.Text = "-";
			this.menuItem12.Visible = false;
			// 
			// menuItemEditTag
			// 
			this.menuItemEditTag.Index = 3;
			this.menuItemEditTag.Text = "タグ情報の編集 (&T)";
			this.menuItemEditTag.Visible = false;
			// 
			// menuItem36
			// 
			this.menuItem36.Index = 4;
			this.menuItem36.Text = "-";
			// 
			// menuItemEditFont
			// 
			this.menuItemEditFont.Index = 5;
			this.menuItemEditFont.Text = "フォント設定 (&F)";
			this.menuItemEditFont.Click += new System.EventHandler(this.menuItemEditFont_Click);
			// 
			// menuItemConv
			// 
			this.menuItemConv.Index = 2;
			this.menuItemConv.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemConvAll,
																						 this.menuItemConvAbort,
																						 this.menuItemConvChosen,
																						 this.menuItem8,
																						 this.menuItemOptionConf});
			this.menuItemConv.Text = "変換 (&C)";
			// 
			// menuItemConvAll
			// 
			this.menuItemConvAll.Index = 0;
			this.menuItemConvAll.Text = "すべて変換 (&A)";
			this.menuItemConvAll.Click += new System.EventHandler(this.menuItemConvAll_Click);
			// 
			// menuItemConvAbort
			// 
			this.menuItemConvAbort.Index = 1;
			this.menuItemConvAbort.Text = "変換を中止 (&A)";
			this.menuItemConvAbort.Visible = false;
			this.menuItemConvAbort.Click += new System.EventHandler(this.menuItemConvAbort_Click);
			// 
			// menuItemConvChosen
			// 
			this.menuItemConvChosen.Index = 2;
			this.menuItemConvChosen.Text = "選択したファイルのみ変換 (&A)";
			this.menuItemConvChosen.Visible = false;
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 3;
			this.menuItem8.Text = "-";
			// 
			// menuItemOptionConf
			// 
			this.menuItemOptionConf.Index = 4;
			this.menuItemOptionConf.Text = "変換設定 (&C)";
			this.menuItemOptionConf.Click += new System.EventHandler(this.menuItemOptionConf_Click);
			// 
			// menuItemPlay
			// 
			this.menuItemPlay.Index = 3;
			this.menuItemPlay.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemPlayDefault,
																						 this.menuItemPlayNext,
																						 this.menuItem9,
																						 this.menuItem10});
			this.menuItemPlay.Text = "再生 (&P)";
			this.menuItemPlay.Visible = false;
			// 
			// menuItemPlayDefault
			// 
			this.menuItemPlayDefault.Index = 0;
			this.menuItemPlayDefault.Text = "デフォルトのプレイヤで再生 (&P)";
			// 
			// menuItemPlayNext
			// 
			this.menuItemPlayNext.Index = 1;
			this.menuItemPlayNext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.menuItemPlayWinamp,
																							 this.menuItemPlayubm,
																							 this.menuItemPlaybmev,
																							 this.menuItem16,
																							 this.menuItemPlaynazo,
																							 this.menuItemPlayddr,
																							 this.menuItemPlaymw,
																							 this.menuItemPlayrdm,
																							 this.menuItemPlaybm98});
			this.menuItemPlayNext.Text = "次のプレイヤに送る (&I)";
			// 
			// menuItemPlayWinamp
			// 
			this.menuItemPlayWinamp.Index = 0;
			this.menuItemPlayWinamp.Text = "Winampに送る (&W)";
			// 
			// menuItemPlayubm
			// 
			this.menuItemPlayubm.Index = 1;
			this.menuItemPlayubm.Text = "uBMplayに送る (&U)";
			// 
			// menuItemPlaybmev
			// 
			this.menuItemPlaybmev.Index = 2;
			this.menuItemPlaybmev.Text = "BMEVに送る (&V)";
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 3;
			this.menuItem16.Text = "-";
			// 
			// menuItemPlaynazo
			// 
			this.menuItemPlaynazo.Index = 4;
			this.menuItemPlaynazo.Text = "nazobmplayに送る (&N)";
			// 
			// menuItemPlayddr
			// 
			this.menuItemPlayddr.Index = 5;
			this.menuItemPlayddr.Text = "Delight Delight Reduplicationに送る (&D)";
			// 
			// menuItemPlaymw
			// 
			this.menuItemPlaymw.Index = 6;
			this.menuItemPlaymw.Text = "MixWaverに送る (&M)";
			// 
			// menuItemPlayrdm
			// 
			this.menuItemPlayrdm.Index = 7;
			this.menuItemPlayrdm.Text = "rhythm-itに送る (&R)";
			// 
			// menuItemPlaybm98
			// 
			this.menuItemPlaybm98.Index = 8;
			this.menuItemPlaybm98.Text = "BM98DEに送る (&B)";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "-";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Text = "プレイヤの設定 (&C)";
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Index = 4;
			this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemHelpRead,
																						 this.menuItem2,
																						 this.menuItemHelpWeb,
																						 this.menuItemHelpBbs,
																						 this.menuItem5,
																						 this.menuItemHelpVer});
			this.menuItemHelp.Text = "ヘルプ (H)";
			// 
			// menuItemHelpRead
			// 
			this.menuItemHelpRead.Index = 0;
			this.menuItemHelpRead.Text = "付属のテキストを開く (&R)";
			this.menuItemHelpRead.Click += new System.EventHandler(this.menuItemHelpRead_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "-";
			// 
			// menuItemHelpWeb
			// 
			this.menuItemHelpWeb.Index = 2;
			this.menuItemHelpWeb.Text = "作者のウェブサイトを開く (&V)";
			this.menuItemHelpWeb.Click += new System.EventHandler(this.menuItemHelpWeb_Click);
			// 
			// menuItemHelpBbs
			// 
			this.menuItemHelpBbs.Index = 3;
			this.menuItemHelpBbs.Text = "バグ報告をする (&B)";
			this.menuItemHelpBbs.Click += new System.EventHandler(this.menuItemHelpBbs_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.Text = "-";
			// 
			// menuItemHelpVer
			// 
			this.menuItemHelpVer.Index = 5;
			this.menuItemHelpVer.Text = "バージョン情報 (&A)";
			this.menuItemHelpVer.Click += new System.EventHandler(this.menuItemHelpVer_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 412);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanelName,
																						  this.statusBarPanel2,
																						  this.statusBarPanelProgress});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(632, 20);
			this.statusBar1.TabIndex = 0;
			this.statusBar1.DrawItem += new System.Windows.Forms.StatusBarDrawItemEventHandler(this.statusBar1_DrawItem);
			// 
			// statusBarPanelName
			// 
			this.statusBarPanelName.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanelName.Text = "待機中...";
			this.statusBarPanelName.Width = 381;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.statusBarPanel2.Text = "(^^)";
			this.statusBarPanel2.Width = 35;
			// 
			// statusBarPanelProgress
			// 
			this.statusBarPanelProgress.AnimationStyle = Cage.ProgressDisplayStyle.LeftToRight;
			this.statusBarPanelProgress.AnimationTick = System.TimeSpan.Parse("00:00:00.5000000");
			this.statusBarPanelProgress.EndPoint = ((long)(100));
			this.statusBarPanelProgress.ProgressPosition = ((long)(0));
			this.statusBarPanelProgress.ShowText = false;
			this.statusBarPanelProgress.StartPoint = ((long)(0));
			this.statusBarPanelProgress.StepSize = ((long)(1));
			this.statusBarPanelProgress.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
			this.statusBarPanelProgress.TextFont = new System.Drawing.Font("Arial", 8F);
			this.statusBarPanelProgress.Width = 200;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.sep00,
																						this.toolBarButtonListClear,
																						this.toolBarButtonOpen,
																						this.toolBarButtonSave,
																						this.sep01,
																						this.toolBarButtonPlay,
																						this.sep03,
																						this.toolBarButtonConv,
																						this.toolBarButtonAbort,
																						this.toolBarButtonOption,
																						this.toolBarButton1});
			this.toolBar1.Cursor = System.Windows.Forms.Cursors.Default;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(632, 28);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.Wrappable = false;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// sep00
			// 
			this.sep00.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButtonListClear
			// 
			this.toolBarButtonListClear.ImageIndex = 0;
			this.toolBarButtonListClear.Tag = "Clear";
			this.toolBarButtonListClear.Text = "クリア";
			// 
			// toolBarButtonOpen
			// 
			this.toolBarButtonOpen.DropDownMenu = this.contextMenuOpen;
			this.toolBarButtonOpen.ImageIndex = 1;
			this.toolBarButtonOpen.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButtonOpen.Tag = "Open";
			this.toolBarButtonOpen.Text = "開く";
			// 
			// contextMenuOpen
			// 
			this.contextMenuOpen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItemFileOpR,
																							this.menuItemFileOpFolderR,
																							this.menuItemFileOpM3UR});
			// 
			// menuItemFileOpR
			// 
			this.menuItemFileOpR.Index = 0;
			this.menuItemFileOpR.Text = "ファイルを開く (&O)";
			this.menuItemFileOpR.Click += new System.EventHandler(this.menuItemFileOpR_Click);
			// 
			// menuItemFileOpFolderR
			// 
			this.menuItemFileOpFolderR.Index = 1;
			this.menuItemFileOpFolderR.Text = "フォルダを開く (&F)";
			this.menuItemFileOpFolderR.Click += new System.EventHandler(this.menuItemFileOpFolderR_Click);
			// 
			// menuItemFileOpM3UR
			// 
			this.menuItemFileOpM3UR.Index = 2;
			this.menuItemFileOpM3UR.Text = "M3Uプレイリストを開く (&P)";
			this.menuItemFileOpM3UR.Click += new System.EventHandler(this.menuItemFileOpM3UR_Click);
			// 
			// toolBarButtonSave
			// 
			this.toolBarButtonSave.DropDownMenu = this.contextMenuSave;
			this.toolBarButtonSave.ImageIndex = 2;
			this.toolBarButtonSave.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButtonSave.Tag = "Save";
			this.toolBarButtonSave.Text = "保存";
			// 
			// contextMenuSave
			// 
			this.contextMenuSave.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItemFileHtmlR,
																							this.menuItemFileM3UR});
			// 
			// menuItemFileHtmlR
			// 
			this.menuItemFileHtmlR.Index = 0;
			this.menuItemFileHtmlR.Text = "HTMLでリストを生成 (&H)";
			this.menuItemFileHtmlR.Click += new System.EventHandler(this.menuItemFileHtmlR_Click);
			// 
			// menuItemFileM3UR
			// 
			this.menuItemFileM3UR.Index = 1;
			this.menuItemFileM3UR.Text = "M3Uでプレイリストを生成 (&M)";
			this.menuItemFileM3UR.Click += new System.EventHandler(this.menuItemFileM3UR_Click);
			// 
			// sep01
			// 
			this.sep01.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButtonPlay
			// 
			this.toolBarButtonPlay.ImageIndex = 6;
			this.toolBarButtonPlay.Text = "再生";
			this.toolBarButtonPlay.Visible = false;
			// 
			// sep03
			// 
			this.sep03.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.sep03.Visible = false;
			// 
			// toolBarButtonConv
			// 
			this.toolBarButtonConv.DropDownMenu = this.contextMenuConv;
			this.toolBarButtonConv.ImageIndex = 3;
			this.toolBarButtonConv.Tag = "Convert";
			this.toolBarButtonConv.Text = "変換";
			// 
			// contextMenuConv
			// 
			this.contextMenuConv.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItem6,
																							this.menuItem7});
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "すべて変換 (&A)";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "選択したファイルのみ変換 (&A)";
			// 
			// toolBarButtonAbort
			// 
			this.toolBarButtonAbort.ImageIndex = 5;
			this.toolBarButtonAbort.Tag = "Abort";
			this.toolBarButtonAbort.Text = "中止";
			this.toolBarButtonAbort.Visible = false;
			// 
			// toolBarButtonOption
			// 
			this.toolBarButtonOption.ImageIndex = 4;
			this.toolBarButtonOption.Tag = "Option";
			this.toolBarButtonOption.Text = "オプション";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Empty;
			// 
			// listViewBms
			// 
			this.listViewBms.AllowDrop = true;
			this.listViewBms.AutoArrange = false;
			this.listViewBms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.columnHeaderTitle,
																						  this.columnHeaderGenre,
																						  this.columnHeaderArtist,
																						  this.columnHeaderFormat,
																						  this.columnHeaderKbps,
																						  this.columnHeaderYear,
																						  this.columnHeaderInPath,
																						  this.columnHeaderOutPath});
			this.listViewBms.ContextMenu = this.contextMenuListRight;
			this.listViewBms.Cursor = System.Windows.Forms.Cursors.Default;
			this.listViewBms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewBms.FullRowSelect = true;
			this.listViewBms.GridLines = true;
			this.listViewBms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewBms.HideSelection = false;
			this.listViewBms.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.listViewBms.Location = new System.Drawing.Point(0, 28);
			this.listViewBms.Name = "listViewBms";
			this.listViewBms.Size = new System.Drawing.Size(632, 384);
			this.listViewBms.TabIndex = 2;
			this.listViewBms.View = System.Windows.Forms.View.Details;
			this.listViewBms.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewBms_DragDrop);
			this.listViewBms.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewBms_DragEnter);
			// 
			// columnHeaderTitle
			// 
			this.columnHeaderTitle.Text = "タイトル";
			this.columnHeaderTitle.Width = 100;
			// 
			// columnHeaderGenre
			// 
			this.columnHeaderGenre.Text = "ジャンル";
			this.columnHeaderGenre.Width = 80;
			// 
			// columnHeaderArtist
			// 
			this.columnHeaderArtist.Text = "作者";
			this.columnHeaderArtist.Width = 80;
			// 
			// columnHeaderFormat
			// 
			this.columnHeaderFormat.Text = "出力形式";
			this.columnHeaderFormat.Width = 70;
			// 
			// columnHeaderKbps
			// 
			this.columnHeaderKbps.Text = "Kbps";
			this.columnHeaderKbps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderKbps.Width = 50;
			// 
			// columnHeaderYear
			// 
			this.columnHeaderYear.Text = "作成年";
			this.columnHeaderYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeaderYear.Width = 50;
			// 
			// columnHeaderInPath
			// 
			this.columnHeaderInPath.Text = "BMSパス";
			this.columnHeaderInPath.Width = 90;
			// 
			// columnHeaderOutPath
			// 
			this.columnHeaderOutPath.Text = "出力先";
			this.columnHeaderOutPath.Width = 90;
			// 
			// contextMenuListRight
			// 
			this.contextMenuListRight.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								 this.menuItemEditClearR,
																								 this.menuItemEditDelR});
			// 
			// menuItemEditClearR
			// 
			this.menuItemEditClearR.Index = 0;
			this.menuItemEditClearR.Text = "リストをクリア (&C)";
			this.menuItemEditClearR.Click += new System.EventHandler(this.menuItemEditClearR_Click);
			// 
			// menuItemEditDelR
			// 
			this.menuItemEditDelR.Index = 1;
			this.menuItemEditDelR.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menuItemEditDelR.Text = "リストから削除";
			this.menuItemEditDelR.Click += new System.EventHandler(this.menuItemEditDelR_Click);
			// 
			// colorFadeBusyBar1
			// 
			this.colorFadeBusyBar1.BackColor = System.Drawing.SystemColors.Control;
			this.colorFadeBusyBar1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
			this.colorFadeBusyBar1.Color2 = System.Drawing.SystemColors.Control;
			this.colorFadeBusyBar1.FadeLength = -1;
			this.colorFadeBusyBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.colorFadeBusyBar1.Location = new System.Drawing.Point(624, 404);
			this.colorFadeBusyBar1.Name = "colorFadeBusyBar1";
			this.colorFadeBusyBar1.PingPong = true;
			this.colorFadeBusyBar1.ShowBorder = false;
			this.colorFadeBusyBar1.Size = new System.Drawing.Size(4, 4);
			this.colorFadeBusyBar1.StepSize = 2;
			this.colorFadeBusyBar1.StepTimeout = 15;
			this.colorFadeBusyBar1.TabIndex = 3;
			this.colorFadeBusyBar1.TextColor = System.Drawing.SystemColors.ControlText;
			// 
			// FormMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(632, 432);
			this.Controls.Add(this.colorFadeBusyBar1);
			this.Controls.Add(this.listViewBms);
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(this.statusBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FormMain_Closing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelProgress)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

		#endregion
		#region DLLImport

		[DllImport("kernel32.dll", EntryPoint="GetPrivateProfileString")]
		private static extern uint GetPrivateProfileString( string lpApplicationName, string lpEntryName, string lpDefault, System.Text.StringBuilder lpReturnedString, uint nSize, string lpFileName ); 
		[DllImport("kernel32.dll", EntryPoint="WritePrivateProfileString")]
		private static extern uint WritePrivateProfileString( string lpApplicationName, string lpEntryName, string lpEntryString, string lpFileName );
		
		#endregion
		#region contorol
		private System.Windows.Forms.BusyBar.ColorFadeBusyBar colorFadeBusyBar1;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItemHelpRead;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItemHelpWeb;
		private System.Windows.Forms.MenuItem menuItemHelpBbs;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListView listViewBms;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private StatusBarProgressPanel statusBarPanelProgress;
		private System.Windows.Forms.MenuItem menuItemFileOp;
		private System.Windows.Forms.MenuItem menuItemFileOpFolder;
		private System.Windows.Forms.MenuItem menuItemFileOpM3U;
		private System.Windows.Forms.MenuItem menuItemFileHtml;
		private System.Windows.Forms.MenuItem menuItemFileM3U;
		private System.Windows.Forms.MenuItem menuItemFileExit;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemOptionConf;
		private System.Windows.Forms.MenuItem menuItemEdit;
		private System.Windows.Forms.MenuItem menuItemEditClear;
		private System.Windows.Forms.MenuItem menuItemEditDel;
		private System.Windows.Forms.MenuItem menuItemEditTag;
		private System.Windows.Forms.MenuItem menuItemPlay;
		private System.Windows.Forms.MenuItem menuItemPlayDefault;
		private System.Windows.Forms.MenuItem menuItemPlayNext;
		private System.Windows.Forms.MenuItem menuItemPlayWinamp;
		private System.Windows.Forms.MenuItem menuItemPlayubm;
		private System.Windows.Forms.MenuItem menuItemPlaybmev;
		private System.Windows.Forms.MenuItem menuItemPlaynazo;
		private System.Windows.Forms.MenuItem menuItemPlayddr;
		private System.Windows.Forms.MenuItem menuItemPlaymw;
		private System.Windows.Forms.MenuItem menuItemPlayrdm;
		private System.Windows.Forms.MenuItem menuItemPlaybm98;
		private System.Windows.Forms.MenuItem menuItemConv;
		private System.Windows.Forms.MenuItem menuItemConvAll;
		private System.Windows.Forms.MenuItem menuItemConvChosen;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemHelpVer;
		private System.Windows.Forms.ToolBarButton toolBarButtonListClear;
		private System.Windows.Forms.ColumnHeader columnHeaderTitle;
		private System.Windows.Forms.ColumnHeader columnHeaderGenre;
		private System.Windows.Forms.ColumnHeader columnHeaderArtist;
		private System.Windows.Forms.ColumnHeader columnHeaderFormat;
		private System.Windows.Forms.ColumnHeader columnHeaderYear;
		private System.Windows.Forms.ColumnHeader columnHeaderInPath;
		private System.Windows.Forms.ColumnHeader columnHeaderOutPath;
		private System.Windows.Forms.ColumnHeader columnHeaderKbps;
		private System.Windows.Forms.ContextMenu contextMenuOpen;
		private System.Windows.Forms.ContextMenu contextMenuSave;
		private System.Windows.Forms.ContextMenu contextMenuConv;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.ToolBarButton sep00;
		private System.Windows.Forms.ToolBarButton toolBarButtonOption;
		private System.Windows.Forms.ToolBarButton sep01;
		private System.Windows.Forms.ToolBarButton sep03;
		private System.Windows.Forms.ToolBarButton toolBarButtonPlay;
		private System.Windows.Forms.ToolBarButton toolBarButtonConv;
		private System.Windows.Forms.ToolBarButton toolBarButtonOpen;
		private System.Windows.Forms.ToolBarButton toolBarButtonSave;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButtonAbort;
		private System.Windows.Forms.MenuItem menuItemConvAbort;
		private System.Windows.Forms.MenuItem menuItemEditFont;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.ContextMenu contextMenuListRight;
		private System.Windows.Forms.MenuItem menuItemEditClearR;
		private System.Windows.Forms.MenuItem menuItemEditDelR;
		private System.Windows.Forms.MenuItem menuItemFileOpFolderR;
		private System.Windows.Forms.MenuItem menuItemFileOpM3UR;
		private System.Windows.Forms.MenuItem menuItemFileHtmlR;
		private System.Windows.Forms.MenuItem menuItemFileM3UR;
		private System.Windows.Forms.MenuItem menuItemFileOpR;
		private System.Windows.Forms.StatusBarPanel statusBarPanelName;

		#endregion
		public void ini_load()
		{
			if(0 <= int.Parse(ReadFromIni("Main","Window_X","-1"))
				&& Screen.GetBounds(this).Width >= int.Parse(ReadFromIni("Main","Window_X","-1")))
			{
				this.Left = int.Parse(ReadFromIni("Main","Window_X","-1"));
			}
			if(0 <= int.Parse(ReadFromIni("Main","Window_Y","-1"))
				&& Screen.GetBounds(this).Width >= int.Parse(ReadFromIni("Main","Window_Y","-1")))
			{
				this.Top = int.Parse(ReadFromIni("Main","Window_Y","-1"));
			}
			this.Height = int.Parse(ReadFromIni("Main","Window_H","480"));
			this.Width = int.Parse(ReadFromIni("Main","Window_W","640"));
			if(ReadFromIni("Main","Window_State","Normal") == "Maximized")
				this.WindowState = FormWindowState.Maximized;
			csize.title = int.Parse(ReadFromIni("Columns","Title","100"));
			csize.genre = int.Parse(ReadFromIni("Columns","Genre","80"));
			csize.artist = int.Parse(ReadFromIni("Columns","Artist","80"));
			csize.format = int.Parse(ReadFromIni("Columns","Format","70"));
			csize.kbps = int.Parse(ReadFromIni("Columns","Kbps","50"));
			csize.year = int.Parse(ReadFromIni("Columns","Year","50"));
			csize.inpath = int.Parse(ReadFromIni("Columns","InPath","90"));
			csize.outpath = int.Parse(ReadFromIni("Columns","OutPath","90"));
			DropTrans = ReadFromIni("Main","DropTrans","100");
			Format = ReadFromIni("Main","Format","MP3");
			Tagging = ReadFromIni("Main","Tagging","True");
			DeleteDif = ReadFromIni("Main","DeleteDif","True");
			Out = ReadFromIni("Output","Out","Default");
			OutPath = ReadFromIni("Output","OutPath",Application.StartupPath + @"\@output\");
			ArtistFolder = ReadFromIni("Output","ArtistFolder","False");
			Filename = ReadFromIni("Filename","Filename","Artist-Title");
			CustomFilename = ReadFromIni("Filename","CustomFilename","");
			WAVEng = ReadFromIni("WAVE","WAVEng","BmsWaveHay2");
			B2WHz = ReadFromIni("WAVEB2W","B2WHz","44100");
			B2WBit = ReadFromIni("WAVEB2W","B2WBit","16");
			B2WChannel = ReadFromIni("WAVEB2W","B2WChannel","2");
			B2WChk = ReadFromIni("WAVEB2W","B2WChk","True");
			B2WForce = ReadFromIni("WAVEB2W","B2WForce","False");
			B2WCmd = ReadFromIni("WAVEB2W","B2WCmd","False");
			B2WVol = ReadFromIni("WAVEB2W","B2WVol","50");
			Hay2Hz = ReadFromIni("WAVEHay2","Hay2Hz","44100");
			Hay2Bit = ReadFromIni("WAVEHay2","Hay2Bit","16");
			Hay2Channel = ReadFromIni("WAVEHay2","Hay2Channel","2");
			Hay2PCMMethod = ReadFromIni("WAVEHay2","Hay2PCMMethod","Linear");
			Hay2FixMixing = ReadFromIni("WAVEHay2","Hay2FixMixing","False");
			Hay2CutSilence = ReadFromIni("WAVEHay2","Hay2CutSilence","True");
			Hay2Inverse = ReadFromIni("WAVEHay2","Hay2Inverse","False");
			Hay2WhiteNoise = ReadFromIni("WAVEHay2","Hay2WhiteNoise","False");
			Hay2Vol = ReadFromIni("WAVEHay2","Hay2Vol","50");
			MP3Bit = ReadFromIni("MP3","MP3Bit","CBR");
			MP3Stereo = ReadFromIni("MP3","MP3Stereo","Joint Stereo");
			MP3q = ReadFromIni("MP3","MP3q","5");
			MP3Hz = ReadFromIni("MP3","MP3Hz","Auto");
			MP3Lowpass = ReadFromIni("MP3","MP3Lowpass","False");
			MP3LowpassValue = ReadFromIni("MP3","MP3LowpassValue","16");
			MP3nspsytune = ReadFromIni("MP3","MP3nspsytune","False");
			MP3Cmd = ReadFromIni("MP3","MP3Cmd","False");
			MP3CBRBit = ReadFromIni("MP3CBR","MP3CBRBit","128");
			MP3CBRUsePreset = ReadFromIni("MP3CBR","MP3CBRUsePreset","False");
			MP3CBRPreset = ReadFromIni("MP3CBR","MP3CBRPreset","insane");
			MP3VBRMinBit = ReadFromIni("MP3VBR","MP3VBRMinBit","32");
			MP3VBRMaxBit = ReadFromIni("MP3VBR","MP3VBRMaxBit","192");
			MP3VBRq = ReadFromIni("MP3VBR","MP3VBRq","4");
			MP3VBRMethod = ReadFromIni("MP3VBR","MP3VBRMethod","old");
			MP3VBRForceMinBit = ReadFromIni("MP3VBR","MP3VBRForceMinBit","False");
			MP3VBRUsePreset = ReadFromIni("MP3VBR","MP3VBRUsePreset","False");
			MP3VBRPreset = ReadFromIni("MP3VBR","MP3VBRPreset","medium");
			MP3ABRBit = ReadFromIni("MP3ABR","MP3ABRBit","128");
			MP3ABRMinBit = ReadFromIni("MP3ABR","MP3ABRMinBit","32");
			MP3ABRMaxBit = ReadFromIni("MP3ABR","MP3ABRMaxBit","192");
			MP3ABRPresetBit = ReadFromIni("MP3ABR","MP3ABRPresetBit","128");
			MP3ABRForceMinBit = ReadFromIni("MP3ABR","MP3ABRForceMinBit","False");
			MP3ABRUsePreset = ReadFromIni("MP3ABR","MP3ABRUsePreset","False");
			MP3ABRPreset = ReadFromIni("MP3ABR","MP3ABRPreset","cd");
			VorBit = ReadFromIni("Vor","VorBit","quality");
			VorHz = ReadFromIni("Vor","VorHz","Auto");
			VorLowpass = ReadFromIni("Vor","VorLowpass","False");
			VorLowpassValue = ReadFromIni("Vor","VorLowpassValue","19.5");
			VorCmd = ReadFromIni("Vor","VorCmd","False");
			VorQValue = ReadFromIni("VorQB","VorQValue","2");
			VorABRBit = ReadFromIni("VorABR","VorABRBit","128");
			VorABRMinBit = ReadFromIni("VorABR","VorABRMinBit","128");
			VorABRMaxBit = ReadFromIni( "VorABR","VorABRMaxBit","128");
			VorCBRBit = ReadFromIni("VorCBR","VorCBRBit","128");
			Add2Winamp = ReadFromIni("^^","Add2Winamp","False");
			WinampPath = ReadFromIni("^^","WinampPath",@"C:\Program Files\Winamp\winamp.exe");
			Fade = ReadFromIni("^^","Fade","False");
		}

		private string ReadFromIni(string key, string val, string def)
		{

			entryLength = GetPrivateProfileString( key,
				val,
				def,
				strEntryString, (uint)(strEntryString.Capacity), ini);

#if DEBUG
			debug.SendDebugMessage("ReadFromIni", "[" + key + "]" + val + "=" + strEntryString.ToString() + " (" + def + ")");
#endif
			return strEntryString.ToString();
		}
		#region ini変数
		public static string Format;
		public static string Tagging;
		public static string DeleteDif;
		public static string DropTrans;
		public static string Window_X;
		public static string Window_Y;
		public static string OnTop;
		public static string Out;
		public static string OutPath;
		public static string ArtistFolder;
		public static string Filename;
		public static string CustomFilename;
		public static string WAVEng;
		public static string B2WHz;
		public static string B2WBit;
		public static string B2WChannel;
		public static string B2WChk;
		public static string B2WForce;
		public static string B2WCmd;
		public static string B2WVol;
		public static string Hay2Hz;
		public static string Hay2Bit;
		public static string Hay2Channel;
		public static string Hay2PCMMethod;
		public static string Hay2FixMixing;
		public static string Hay2CutSilence;
		public static string Hay2Inverse;
		public static string Hay2WhiteNoise;
		public static string Hay2Vol;
		public static string MP3Bit;
		public static string MP3Stereo;
		public static string MP3q;
		public static string MP3Hz;
		public static string MP3Lowpass;
		public static string MP3LowpassValue;
		public static string MP3nspsytune;
		public static string MP3Cmd;
		public static string MP3CBRBit;
		public static string MP3CBRUsePreset;
		public static string MP3CBRPreset;
		public static string MP3VBRMinBit;
		public static string MP3VBRMaxBit;
		public static string MP3VBRq;
		public static string MP3VBRMethod;
		public static string MP3VBRForceMinBit;
		public static string MP3VBRUsePreset;
		public static string MP3VBRPreset;
		public static string MP3ABRBit;
		public static string MP3ABRMinBit;
		public static string MP3ABRMaxBit;
		public static string MP3ABRPresetBit;
		public static string MP3ABRForceMinBit;
		public static string MP3ABRUsePreset;
		public static string MP3ABRPreset;
		public static string VorBit;
		public static string VorHz;
		public static string VorLowpass;
		public static string VorLowpassValue;
		public static string VorCmd;
		public static string VorQValue;
		public static string VorABRBit;
		public static string VorABRMinBit;
		public static string VorABRMaxBit;
		public static string VorCBRBit;
		public static string Add2Winamp;
		public static string WinampPath;
		public static string Fade;
		#endregion
		#region その他変数、定数
		uint entryLength;
		System.Text.StringBuilder strEntryString = new System.Text.StringBuilder( 256 );
		private const string QUOT = "\"";
		public static System.Drawing.Font mainfont = SystemInformation.MenuFont;
		public string exePath = Application.StartupPath ;
		public string ini = Application.StartupPath + @"\Cage.ini";
		public string oggenc = Application.StartupPath + @"\external\oggenc.exe";
		public string lame = Application.StartupPath + @"\external\lame.exe";
		public string bms2wav = Application.StartupPath + @"\external\bms2wavc.exe";
		public string hay2 = Application.StartupPath + @"\external\hay2.exe";
		public string output = Application.StartupPath + @"\@output\";
		static string[] files;
		static string filestemp;
		string val;
		string bit;
		bool IsConvert = false;
		System.Diagnostics.Process p;
		Thread t;
		public FormDebug debug;
		#endregion
		private enum TagType
		{
			FILE_TYPE,
			WAVE_ENGINE,
			TJBMS2WAV_CMD,
			HAY2_CMD,
			LAME_CMD,
			OGGENC_CMD,
			THIS_LENGTH
		}
		private struct csize
		{
			public static int title;
			public static int genre;
			public static int artist;
			public static int format;
			public static int kbps;
			public static int year;
			public static int inpath;
			public static int outpath;
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{
			try
			{
#if DEBUG
				debug = new FormDebug();
				debug.Show();
				debug.SendDebugMessage("Startup", APPLICATION_NAME + " " + APPLICATION_VERSION + " Debug mode start...");
#endif
				base.Hide();
				this.Text = APPLICATION_NAME + " " + APPLICATION_VERSION;
				this.Font = SystemInformation.MenuFont;

				ini_load();
				// カラム幅設定
				listViewBms.Columns[0].Width = csize.title;
				listViewBms.Columns[1].Width = csize.genre;
				listViewBms.Columns[2].Width = csize.artist;
				listViewBms.Columns[3].Width = csize.format;
				listViewBms.Columns[4].Width = csize.kbps;
				listViewBms.Columns[5].Width = csize.year;
				listViewBms.Columns[6].Width = csize.inpath;
				listViewBms.Columns[7].Width = csize.outpath;

				#region//*---------------------------------起動に必要なものがあるかどうかチェックします。
				if (!File.Exists(lame))
				{
					MessageBox.Show("lame.exeが見つかりませんでした。"
						+ "\nMP3への変換はできません。","エラー");
				}
				if (!File.Exists(oggenc))
				{
					MessageBox.Show("oggenc.exeが見つかりませんでした。"
						+ "\nOgg Vorbisへの変換はできません。","エラー");
				}
				if (!File.Exists(bms2wav))
				{
					MessageBox.Show("bms2wavc.exeが見つかりませんでした。"
						+ "\n別途入手してください。","エラー");
					Application.Exit();
				}
				Directory.CreateDirectory(exePath + @"\@output") ;
				#endregion
				// プロセスのインスタンスを作る。
				p = new System.Diagnostics.Process();
				base.Show();
				colorFadeBusyBar1.Hide();

				/*this.SetStyle(
					ControlStyles.DoubleBuffer |         // 描画をバッファで実行する
					ControlStyles.UserPaint |            // 描画は（ＯＳでなく）独自に行う
					ControlStyles.AllPaintingInWmPaint,  // WM_ERASEBKGND を無視する
					true                                 // 指定したスタイルを適用「する」
					);*/
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}

		private void menuItemFileExit_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(IsConvert)
				{
					DialogResult result = MessageBox.Show("変換中のアイテムがありますが終了しますか？\n変換中のアイテムは破棄されます。"
						,"Cageの終了",MessageBoxButtons.YesNo
						,MessageBoxIcon.Question);
					if(result == DialogResult.No)
						return;
				}
				this.Close();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}
		private void menuItemConvAll_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(listViewBms.Items.Count == 0)
					return;
				t = new Thread(new ThreadStart(MainConvThread));
				t.IsBackground = true;
#if DEBUG
				debug.SendDebugMessage("ThreadStart","MainConvThread Start!");
#endif
				t.Start();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}

		private void MainConvThread()
		{
			try
			{
				ToggleItems();
				InitStatusProgress(1, listViewBms.Items.Count * 2);
				string[] tag;
				#region hogehoge
				for(int i = 0; i < listViewBms.Items.Count; i++)
				{
					try
					{
						tag = (string[])listViewBms.Items[i].Tag;
						statusBarPanelName.Text = listViewBms.Items[i].SubItems[0].Text + " を処理中...";
						#region ＢＭＳをＷＡＶＥにレッツ変換！キャー！
						switch(tag[(int)TagType.WAVE_ENGINE])
						{
							case "tjbms2wav":
								#region bms2wavでWAVEに変換
								ProcessStart(bms2wav, tag[(int)TagType.TJBMS2WAV_CMD]);
								#endregion
								break;
							case "BmsWaveHay2":
								#region 速波２でWAVEに変換
								ProcessStart(hay2, tag[(int)TagType.HAY2_CMD]);
								#endregion
								break;
						}
						#endregion
						statusBarPanelProgress.Step();
						#region 変換形式は？！？！
						switch(tag[(int)TagType.FILE_TYPE])
						{
							case "WAVE":
								File.Move(exePath + @"\temp.wav", output 
									+ listViewBms.Items[i].SubItems[7].Text) ;
								break;
							case "MP3":
								ProcessStart(lame, tag[(int)TagType.LAME_CMD]);
								File.Delete(exePath + @"\temp.wav");						
								break;
							case "Vor":
								ProcessStart(oggenc, tag[(int)TagType.OGGENC_CMD]);
								File.Delete(exePath + @"\temp.wav");
								break;
						}
						#endregion
						statusBarPanelProgress.Step();
						#region 願わくばプレイヤで再生させちゃったりして！（はあと！
						if(StringToBool(Add2Winamp))
						{
							if(File.Exists(WinampPath))
							{
								if(!StringToBool(ArtistFolder))
								{
									System.Diagnostics.Process.Start(WinampPath,"/ADD "
										+ QUOT + listViewBms.Items[i].SubItems[7].Text + QUOT);
								}
								else
								{
									System.Diagnostics.Process.Start(WinampPath,"/ADD "
										+ QUOT + listViewBms.Items[i].SubItems[7].Text + QUOT);
								}
							}
						}
						#endregion
					}
					catch (Exception ee)
					{
#if DEBUG
						debug.SendDebugMessage("Exception", ee.Message);
#endif
					}
				}
				#endregion
				InitListView();
				ToggleItems();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}
		private void menuItemHelpVer_Click(object sender, System.EventArgs e)
		{
			try
			{
				about form = new about();
				form.labelVersion.Text += APPLICATION_VERSION;
				form.ShowDialog();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}
		private void menuItemOptionConf_Click(object sender, System.EventArgs e)
		{
			try
			{
				Form2 form = new Form2();
				form.ShowDialog();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}

		private void listViewBms_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
				// 格納されているデータの形式を確認する
				if ( e.Data.GetDataPresent( DataFormats.FileDrop))
				{
					e.Effect = DragDropEffects.Move | (DragDropEffects.Copy | DragDropEffects.Scroll);
				}
				else
				{
					e.Effect = DragDropEffects.None;
				}
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}
		private void listViewBms_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
				files = (string[])e.Data.GetData(DataFormats.FileDrop,false);
				t = new Thread(new ThreadStart(ScanDropFilesThread));
				t.IsBackground = true;
				t.Start();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}
		private void ScanDropFilesThread()
		{
			foreach(string path in files)
			{
				ScanDirectory(path);
			}
			files = filestemp.Split(new char[] {'\n'});
			t = new Thread(new ThreadStart(AddToListViewThread));
			t.IsBackground = true;
			t.Start();
		}
		private void AddToListViewThread()
		{
			try
			{
				#region リストビューに表示するための値を作ります！
				if(Format == "WAVE")
				{
					val = "WAVE";
					bit = "----";
				}
				else if(Format == "MP3")
				{
					val = "MP3 (" + MP3Bit + ")";
					if(MP3Bit == "CBR" && StringToBool(MP3CBRUsePreset))
					{
						bit = "preset " + MP3CBRPreset;
						if(MP3CBRPreset == "*")
							bit += " " + MP3CBRBit;
					}
					else if (MP3Bit == "CBR" && !StringToBool(MP3CBRUsePreset))
					{
						bit = MP3CBRBit;
					}
					else if (MP3Bit == "VBR" && !StringToBool(MP3VBRUsePreset))
					{
						bit = MP3VBRMinBit + "-" + MP3VBRMaxBit;
					}
					else if (MP3Bit == "VBR" && StringToBool(MP3VBRUsePreset))
					{
						bit = "preset " + MP3VBRPreset;
					}
					else if (MP3Bit == "ABR" && !StringToBool(MP3ABRUsePreset))
					{
						bit = MP3ABRMinBit + "-" + MP3ABRBit  + "-" + MP3ABRMaxBit;
					}
					else if (MP3Bit == "ABR" && StringToBool(MP3ABRUsePreset))
					{
						bit =  "preset " + MP3ABRPreset;
					}
				}
				else if(Format == "Vor")
				{
					val = "Ogg Vorbis (" + VorBit + ")";
					val = val.Replace("quality", "QB");
					if(VorBit == "quality")
						bit = "-q " +VorQValue;
					else if(VorBit == "ABR")
						bit = VorABRMinBit  + "-" + VorABRBit + "-" + VorABRMaxBit;
					else if(VorBit == "CBR")
						bit = VorCBRBit;
				}
				#endregion
				#region 格納するファイルの数を数えます！
				int filesLength = files.Length;
#if DEBUG
				debug.SendDebugMessage("AddToListViewThread", "filesLength=" + filesLength.ToString());
#endif
				for (int i = 0; i < files.Length; i++)
				{
					if(!IsBms(files[i]) || !File.Exists(files[i]))
					{
						filesLength--;
					}
				}
				#endregion
				#region 実際にリストにアイテムを追加します！
				if(filesLength > 0)
				{
					ListViewItem[] items = new ListViewItem[filesLength];
					InitStatusProgress(1, files.Length);

					for (int i = 0; i < files.Length; i++)
					{
						statusBarPanelName.Text = "追加中... : " + files[i];
						statusBarPanelProgress.Step();
						string[] p;
						string year;
						if(IsBms(files[i]) && File.Exists(files[i]))
						{
							BmsLoadClass.LoadBMSHeader(files[i], out p);
							#region ファイル名を作りましょう
							string outfilename = "";
							switch(Filename)
							{
								case "Artist-Title":
									outfilename += p[(int)BmsLoadClass.HeaderType.ARTIST]
										+ " - " + p[(int)BmsLoadClass.HeaderType.TITLE];
									break;
								case "Title-Artist":
									outfilename += p[(int)BmsLoadClass.HeaderType.TITLE]
										+ " - " + p[(int)BmsLoadClass.HeaderType.ARTIST];
									break;
								case "Title":
									outfilename += p[(int)BmsLoadClass.HeaderType.TITLE];
									break;
								case "CustomFilename":
									outfilename += "asso";
									break;
							}
							switch(Format)
							{
								case "WAVE":
									outfilename += ".wav";
									break;
								case "MP3":
									outfilename += ".mp3";
									break;
								case "Vor":
									outfilename += ".ogg";
									break;
							}
							outfilename = ToFileName(outfilename);
							#endregion
							items[i] = new ListViewItem(p[(int)BmsLoadClass.HeaderType.TITLE]);
							items[i].SubItems.Add(p[(int)BmsLoadClass.HeaderType.GENRE]);
							items[i].SubItems.Add(p[(int)BmsLoadClass.HeaderType.ARTIST]);
							items[i].SubItems.Add(val);
							items[i].SubItems.Add(bit);
							items[i].SubItems.Add(year = File.GetLastWriteTime(files[i]).Year.ToString());
							items[i].SubItems.Add(files[i].ToString());
							items[i].SubItems.Add(outfilename);
							string[] tag = new string[(int)TagType.THIS_LENGTH];
							#region items[i].Tagをこさえる
							tag[(int)TagType.FILE_TYPE] = Format;
							if(WAVEng == "tjbms2wav")
							{
								tag[(int)TagType.TJBMS2WAV_CMD] = MakeTjbms2wavCmd(p, files[i]);
								tag[(int)TagType.WAVE_ENGINE] = "tjbms2wav";
							}
							else if(WAVEng == "BmsWaveHay2")
							{
								tag[(int)TagType.HAY2_CMD] = MakeHay2Cmd(p, files[i]);
								tag[(int)TagType.WAVE_ENGINE] = "BmsWaveHay2";
							}
							switch(Format)
							{
								case "MP3":
									tag[(int)TagType.LAME_CMD] = MakeLameCmd(p, files[i], year, outfilename);
									break;
								case "Vor":
									tag[(int)TagType.OGGENC_CMD] = MakeOggencCmd(p, files[i], year, outfilename);
									break;
							}

							#endregion
							items[i].Tag = tag;
#if DEBUG
							foreach(string t in tag)
							{
								debug.SendDebugMessage("AddToListViewThread",t);
							}
#endif
						}
					}
					this.listViewBms.Items.AddRange(items);
					statusBarPanelName.Text = "待機中...";
					InitStatusProgress(1,1);
				}
				#endregion
				files.Initialize();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}

		private void menuItemEditClear_Click(object sender, System.EventArgs e)
		{
			try
			{
				InitListView();
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}

		private void FormMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				/*e.Cancel = 
					MessageBox.Show(
					"変換中のアイテムがありますが終了しますか？\n変換中のアイテムは破棄されます。",
					"Cageの終了",
					MessageBoxButtons.YesNo,  // ボタンの一覧は MessageBoxButtons 参照
					MessageBoxIcon.Question   // アイコンの一覧は  MessageBoxIcon 参照
					)
					== DialogResult.No;  // [いいえ] が選択された場合、Form は閉じない*/

				ini_save();
				if(IsConvert)
				{
					try
					{
						p.Kill();
					}
					catch{}
				}
			}
			catch(Exception ee)
			{
#if DEBUG
				debug.SendDebugMessage("Exception",ee.Message);
#endif
			}
		}

		private string MakeTjbms2wavCmd(string[] p, string infilename)
		{
			string ret = QUOT 
				+ infilename
				+ "\" \"" + exePath + @"\temp.wav" + QUOT
				+ " " + B2WHz
				+ " " + B2WBit
				+ " " + B2WChannel
				+ " -v " + B2WVol;
#if DEBUG
			debug.SendDebugMessage("MakeTjbms2wavCmd",ret);
#endif
			return ret;
		}
		private string MakeHay2Cmd(string[] p, string infilename)
		{
			string ret 
				= QUOT + infilename + QUOT +" "
				+ QUOT + exePath + @"\temp.wav" + QUOT;
			ret += " -v" + Hay2Vol;
			ret += " -p256 -o65536"
				+ " -w";

			switch (Hay2Bit)
			{
				case "16":
					ret += "1";
					break;
				case "8":
					ret += "8";
					break;
			}						
							
			switch (Hay2Channel)
			{
				case "2":
					ret += "s";
					break;
				case "1":
					ret += "m";
					break;
			}

			if(StringToBool(Hay2FixMixing))
			{
				ret += "X";
			}
							
			ret += " -i";

			switch(Hay2PCMMethod)
			{
				case "Nearest":
					ret += "0";
					break;
				case "Linear":
					ret += "1";
					break;
				case "Mix":
					ret += "2";
					break;
				case "Neville":
					ret += "3";
					break;
				case "Bezier":
					ret += "4";
					break;
			}

			if(StringToBool(Hay2CutSilence))
			{
				ret += " -s";
			}

			if(StringToBool(Hay2Inverse))
			{
				ret += " -r";
			}

			if(StringToBool(Hay2WhiteNoise))
			{
				ret += " -n";
			}
							
			ret += " -f" + Hay2Hz
				+ " -S12";

#if DEBUG
			debug.SendDebugMessage("MakeHay2Cmd", ret);
#endif
			return ret;
		}

		private string MakeLameCmd(string[] p, string infilename, string year, string outfilename)
		{
			string ret = "--add-id3v2 --verbose";

			switch(MP3Bit)
			{
				case "CBR":
					if(StringToBool(MP3CBRUsePreset))
					{
						switch(MP3CBRPreset)
						{
							case "*":
								ret += " --preset cbr " + MP3CBRBit;
								break;
							case "insane":
								ret += " --preset " + MP3CBRPreset;
								break;
						}
					}
					else
					{
						ret += " -b " + MP3CBRBit
							+ " -q " + MP3q;
						ret += " -m ";

						switch(MP3Stereo)
						{
							case "Stereo":
								ret += "s";
								break;
							case "Joint Stereo":
								ret += "j";
								break;
							case "Forced Joint Stereo":
								ret += "f";
								break;
							case "Mono":
								ret += "m";
								break;
						}
					}
					break;


				case "VBR":
					if(StringToBool(MP3VBRUsePreset))
					{
						if(MP3VBRPreset != "r3mix")
						{
							ret += " --preset " + MP3VBRPreset;
						}
						else
						{
							ret += " --r3mix";
						}
					}
					else
					{
						ret += " -b " + MP3VBRMinBit
							+ " -B " + MP3VBRMaxBit
							+ " -V " + MP3VBRq
							+ " --vbr-" + MP3VBRMethod
							+ " -q " + MP3q;
						ret += " -m ";

						switch(MP3Stereo)
						{
							case "Stereo":
								ret += "s";
								break;
							case "Joint Stereo":
								ret += "j";
								break;
							case "Forced Joint Stereo":
								ret += "f";
								break;
							case "Mono":
								ret += "m";
								break;
						}
					}

					if(StringToBool(MP3VBRForceMinBit))
					{
						ret += " -F";
					}

					break;
				case "ABR":
					if(StringToBool(MP3ABRUsePreset))
					{
						if(MP3ABRPreset == "*")
						{
							ret += " --abr " + MP3ABRPresetBit;
						}
						else
						{
							ret += " --preset " + MP3ABRPreset;
						}
					}
					else
					{
						ret += " --abr " + MP3ABRBit
							+ " -b " + MP3ABRMinBit
							+ " -B " + MP3ABRMaxBit
							+ " -q " + MP3q;
						ret += " -m ";

						switch(MP3Stereo)
						{
							case "Stereo":
								ret += "s";
								break;
							case "Joint Stereo":
								ret += "j";
								break;
							case "Forced Joint Stereo":
								ret += "f";
								break;
							case "Mono":
								ret += "m";
								break;
						}
					}
					if(StringToBool(MP3ABRForceMinBit))
					{
						ret += " -F";
					}
					break;
			}

			if(StringToBool(MP3Lowpass))
			{
				ret += " --lowpass " + MP3LowpassValue;
			}

			if(StringToBool(MP3nspsytune))
			{
				ret += " --nspsytune";
			}

			if(MP3Hz != "Auto")
			{
				ret += " --resample " + MP3Hz;
			}

			if(StringToBool(Tagging))
			{
				ret += " --tt " + QUOT + p[(int)BmsLoadClass.HeaderType.TITLE] + QUOT
					+ " --ta " + QUOT + p[(int)BmsLoadClass.HeaderType.ARTIST] + QUOT
					// + "--tg " + QUOT + p[(int)BmsLoadClass.HeaderType.GENRE] + QUOT
					//+ " --tc \"bmsdropXPd\""
					+ " --ty " + year;
			}

			if(StringToBool(ArtistFolder))
			{
				Directory.CreateDirectory(output + ToFileName(p[(int)BmsLoadClass.HeaderType.ARTIST]));
				ret += " temp.wav "
					+ QUOT + output + ToFileName(p[(int)BmsLoadClass.HeaderType.ARTIST]) + @"\" + outfilename + QUOT;
			}
			else
			{
				ret += " temp.wav "
					+ QUOT + output + outfilename + QUOT;
			}
#if DEBUG
			debug.SendDebugMessage("MakeLameCmd", ret);
#endif
			return ret;
		}

		private string MakeOggencCmd(string[] p, string infilename, string year, string outfilename)
		{
			string ret = "";

			switch(VorBit)
			{
				case "quality":
					ret += "-q " + VorQValue;
					break;
				case "ABR":
					ret += "-b " + VorABRBit
						+ " -m " + VorABRMinBit
						+ " -M " + VorABRMaxBit;
					break;
				case "CBR":
					ret += "-b " + VorCBRBit;
					break;
			}

			if(VorHz != "Auto")
			{
				ret += " --resample " + VorHz;
			}					

			if(StringToBool(Tagging))
			{
				ret += " -t " + QUOT + p[(int)BmsLoadClass.HeaderType.TITLE] + QUOT
					+ " -a " + QUOT + p[(int)BmsLoadClass.HeaderType.ARTIST] + QUOT
					+ " -G " + QUOT + p[(int)BmsLoadClass.HeaderType.GENRE] + QUOT
					//+ " --COMMENT=\"bmsdropXPd\""
					+ " -d " + year;
			}

			if(StringToBool(ArtistFolder))
			{
				Directory.CreateDirectory(output + ToFileName(p[(int)BmsLoadClass.HeaderType.ARTIST]));
				ret += " temp.wav" 
					+ " -o \"" + output + ToFileName(p[(int)BmsLoadClass.HeaderType.ARTIST]) + @"\" + outfilename + "\"";
			}
			else
			{
				ret += " temp.wav" 
					+ " -o \"" + output + outfilename + "\"";
			}
#if DEBUG
			debug.SendDebugMessage("MakeOggencCmd", ret);
#endif
			return ret;
		}

		private string ToFileName(string filename)
		{
			return Regex.Replace(filename, "[\\\\/:,;*?\"<>|]", "_");
		}
		private bool StringToBool(string boolean)
		{
			if(boolean == "True")
				return true;
			else
				return false;
		}
		private bool IsBms(string filename)
		{
			if(
				filename.ToLower().EndsWith(".bms") ||
				filename.ToLower().EndsWith(".bme") ||
				filename.ToLower().EndsWith(".bml") ||
				filename.ToLower().EndsWith(".pms")
				)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void ini_save()
		{
			uint entryLength;
			entryLength = WritePrivateProfileString( "Main", "Window_State", this.WindowState.ToString(), ini ); this.WindowState = 0;
			entryLength = WritePrivateProfileString( "Main", "Window_X", this.Left.ToString(), ini );
			entryLength = WritePrivateProfileString( "Main", "Window_Y", this.Top.ToString(), ini );
			entryLength = WritePrivateProfileString( "Main", "Window_H", this.Height.ToString(), ini );
			entryLength = WritePrivateProfileString( "Main", "Window_W", this.Width.ToString(), ini ); base.Hide();
			entryLength = WritePrivateProfileString( "Main", "Format", Format, ini );
			entryLength = WritePrivateProfileString( "Main", "Tagging", Tagging, ini );
			entryLength = WritePrivateProfileString( "Main", "DeleteDif", DeleteDif, ini );
			entryLength = WritePrivateProfileString( "Main", "DropTrans", DropTrans, ini );
			entryLength = WritePrivateProfileString( "Columns", "Title", listViewBms.Columns[0].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Columns", "Genre", listViewBms.Columns[1].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Columns", "Artist", listViewBms.Columns[2].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Columns", "Format", listViewBms.Columns[3].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Columns", "Kbps", listViewBms.Columns[4].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Columns", "Year", listViewBms.Columns[5].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Columns", "InPath", listViewBms.Columns[6].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Columns", "OutPath", listViewBms.Columns[7].Width.ToString(), ini );
			entryLength = WritePrivateProfileString( "Output", "Out", Out, ini );
			entryLength = WritePrivateProfileString( "Output", "OutPath", OutPath, ini );
			entryLength = WritePrivateProfileString( "Output", "ArtistFolder", ArtistFolder, ini );
			entryLength = WritePrivateProfileString( "Filename", "Filename", Filename, ini );
			entryLength = WritePrivateProfileString( "Filename", "CustomFilename", CustomFilename, ini );
			entryLength = WritePrivateProfileString( "WAVE", "WAVEng", WAVEng, ini );
			entryLength = WritePrivateProfileString( "WAVEB2W", "B2WHz", B2WHz, ini );
			entryLength = WritePrivateProfileString( "WAVEB2W", "B2WBit", B2WBit, ini );
			entryLength = WritePrivateProfileString( "WAVEB2W", "B2WChannel", B2WChannel, ini );
			entryLength = WritePrivateProfileString( "WAVEB2W", "B2WChk", B2WChk, ini );
			entryLength = WritePrivateProfileString( "WAVEB2W", "B2WForce", B2WForce, ini );
			entryLength = WritePrivateProfileString( "WAVEB2W", "B2WCmd", B2WCmd, ini );
			entryLength = WritePrivateProfileString( "WAVEB2W", "B2WVol", B2WVol, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2Hz", Hay2Hz, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2Bit", Hay2Bit, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2Channel", Hay2Channel, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2FixMixing", Hay2FixMixing, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2CutSilence", Hay2CutSilence, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2Inverse", Hay2Inverse, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2WhiteNoise", Hay2WhiteNoise, ini );
			entryLength = WritePrivateProfileString( "WAVEHay2", "Hay2Vol", Hay2Vol, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3Bit", MP3Bit, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3Stereo", MP3Stereo, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3q", MP3q, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3Hz", MP3Hz, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3Lowpass", MP3Lowpass, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3LowpassValue", MP3LowpassValue, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3nspsytune", MP3nspsytune, ini );
			entryLength = WritePrivateProfileString( "MP3", "MP3Cmd", MP3Cmd, ini );
			entryLength = WritePrivateProfileString( "MP3CBR", "MP3CBRBit", MP3CBRBit, ini );
			entryLength = WritePrivateProfileString( "MP3CBR", "MP3CBRUsePreset", MP3CBRUsePreset, ini );
			entryLength = WritePrivateProfileString( "MP3CBR", "MP3CBRPreset", MP3CBRPreset, ini );
			entryLength = WritePrivateProfileString( "MP3VBR", "MP3VBRMinBit", MP3VBRMinBit, ini );
			entryLength = WritePrivateProfileString( "MP3VBR", "MP3VBRMaxBit", MP3VBRMaxBit, ini );
			entryLength = WritePrivateProfileString( "MP3VBR", "MP3VBRq", MP3VBRq, ini );
			entryLength = WritePrivateProfileString( "MP3VBR", "MP3VBRMethod", MP3VBRMethod, ini );
			entryLength = WritePrivateProfileString( "MP3VBR", "MP3VBRForceMinBit", MP3VBRForceMinBit, ini );
			entryLength = WritePrivateProfileString( "MP3VBR", "MP3VBRUsePreset", MP3VBRUsePreset, ini );
			entryLength = WritePrivateProfileString( "MP3VBR", "MP3VBRPreset", MP3VBRPreset, ini );
			entryLength = WritePrivateProfileString( "MP3ABR", "MP3ABRBit", MP3ABRBit, ini );
			entryLength = WritePrivateProfileString( "MP3ABR", "MP3ABRMinBit", MP3ABRMinBit, ini );
			entryLength = WritePrivateProfileString( "MP3ABR", "MP3ABRMaxBit", MP3ABRMaxBit, ini );
			entryLength = WritePrivateProfileString( "MP3ABR", "MP3ABRForceMinBit", MP3ABRForceMinBit, ini );
			entryLength = WritePrivateProfileString( "MP3ABR", "MP3ABRUsePreset", MP3ABRUsePreset, ini );
			entryLength = WritePrivateProfileString( "MP3ABR", "MP3ABRPreset", MP3ABRPreset, ini );
			entryLength = WritePrivateProfileString( "MP3ABR", "MP3ABRPresetBit", MP3ABRPresetBit, ini );
			entryLength = WritePrivateProfileString( "Vor", "VorBit", VorBit, ini );
			entryLength = WritePrivateProfileString( "Vor", "VorHz", VorHz, ini );
			entryLength = WritePrivateProfileString( "Vor", "VorLowpass", VorLowpass, ini );
			entryLength = WritePrivateProfileString( "Vor", "VorLowpassValue", VorLowpassValue, ini );
			entryLength = WritePrivateProfileString( "Vor", "VorCmd", VorCmd, ini );
			entryLength = WritePrivateProfileString( "VorQB", "VorQValue", VorQValue, ini );
			entryLength = WritePrivateProfileString( "VorABR", "VorABRBit", VorABRBit, ini );
			entryLength = WritePrivateProfileString( "VorABR", "VorABRMinBit", VorABRMinBit, ini );
			entryLength = WritePrivateProfileString( "VorABR", "VorABRMaxBit", VorABRMaxBit, ini );
			entryLength = WritePrivateProfileString( "VorCBR", "VorCBRBit", VorCBRBit, ini );
			entryLength = WritePrivateProfileString( "^^", "Add2Winamp", Add2Winamp, ini );
			entryLength = WritePrivateProfileString( "^^", "WinampPath", WinampPath, ini );
			entryLength = WritePrivateProfileString( "^^", "Fade", Fade, ini );
		}

		private void ToggleItems()
		{
			statusBarPanelName.Text = "待機中...";
			IsConvert = !IsConvert;
			toolBarButtonListClear.Enabled = !toolBarButtonListClear.Enabled;
			toolBarButtonOpen.Enabled = !toolBarButtonOpen.Enabled;
			menuItemEdit.Enabled = !menuItemEdit.Enabled;
			menuItemConvAll.Visible = !menuItemConvAll.Visible;
			menuItemConvAbort.Visible = !menuItemConvAbort.Visible;
			toolBarButtonConv.Visible = !toolBarButtonConv.Visible;
			toolBarButtonAbort.Visible = !toolBarButtonAbort.Visible;
			menuItemEditClearR.Enabled = !menuItemEditClearR.Enabled;
			menuItemEditDelR.Enabled = !menuItemEditDelR.Enabled;
			//listViewBms.AllowDrop = !listViewBms.AllowDrop;
			statusBarPanelProgress.Reset();
		}
		private void ToggleBusyBar()
		{
			if (colorFadeBusyBar1.IsRunning)
			{
				colorFadeBusyBar1.Stop();
				colorFadeBusyBar1.Hide();
			}
			else
			{
				colorFadeBusyBar1.Show();
				colorFadeBusyBar1.Start();
			}
		}
		private void ProcessStart(string process, string arguments)
		{
			p.StartInfo.FileName = process;
			p.StartInfo.Arguments = arguments;
			// 子プロセスのウィンドウを表示しない。
			p.StartInfo.CreateNoWindow = true;
			// StandardInput を使用する場合は、
			// UseShellExecute が false になっている必要があります。
			p.StartInfo.UseShellExecute = false; 
			// 標準入力、標準出力を使用します。
			//p.StartInfo.RedirectStandardInput = true;
			//p.StartInfo.RedirectStandardOutput = true;
#if DEBUG
			debug.SendDebugMessage("ProcessStart", process + " (" + arguments + ")");
#endif
			p.Start();
			p.WaitForExit(); 
		}
		private void InitListView()
		{
			csize.title = listViewBms.Columns[0].Width;
			csize.genre = listViewBms.Columns[1].Width;
			csize.artist = listViewBms.Columns[2].Width;
			csize.format = listViewBms.Columns[3].Width;
			csize.kbps = listViewBms.Columns[4].Width;
			csize.year = listViewBms.Columns[5].Width;
			csize.inpath = listViewBms.Columns[6].Width;
			csize.outpath = listViewBms.Columns[7].Width;
			listViewBms.Clear();
			this.listViewBms.Columns.Add("タイトル",csize.title, HorizontalAlignment.Left);
			this.listViewBms.Columns.Add("ジャンル",csize.genre, HorizontalAlignment.Left);
			this.listViewBms.Columns.Add("作者",csize.artist, HorizontalAlignment.Left);
			this.listViewBms.Columns.Add("出力形式",csize.format, HorizontalAlignment.Left);
			this.listViewBms.Columns.Add("Kbps",csize.kbps, HorizontalAlignment.Right);
			this.listViewBms.Columns.Add("作成年",csize.year, HorizontalAlignment.Right);
			this.listViewBms.Columns.Add("BMSパス",csize.inpath, HorizontalAlignment.Left);
			this.listViewBms.Columns.Add("出力先",csize.outpath, HorizontalAlignment.Left);
		}
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch((string)e.Button.Tag)
			{
				case "Clear":
					menuItemEditClear.PerformClick();
					break;
				case "Open":
					menuItemFileOpFolder.PerformClick();
					break;
				case "Save":
					menuItemFileM3U.PerformClick();
					break;
				case "Option":
					menuItemOptionConf.PerformClick();
					break;
				case "Convert":
					menuItemConvAll.PerformClick();
					break;
				case "Abort":
					menuItemConvAbort.PerformClick();
					break;
			}
		}

		private void InitStatusProgress(int stepsize, int endpoint)
		{
			colorFadeBusyBar1.Stop();
			colorFadeBusyBar1.Hide();
			statusBarPanelProgress.Reset();
			statusBarPanelProgress.StepSize = stepsize;
			statusBarPanelProgress.EndPoint = endpoint;
		}

		private void menuItemConvAbort_Click(object sender, System.EventArgs e)
		{
			ToggleItems();
			try
			{
				t.Abort();
				p.Kill();
			}
			catch{}
		}

		private void ScanDirectoryThread()
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "BMSフォルダを選択してください。";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				ToggleBusyBar();
				ScanDirectory(dialog.SelectedPath);
				files = filestemp.Split(new char[] {'\n'});
				t = new Thread(new ThreadStart(AddToListViewThread));
				t.IsBackground = true;
				t.Start();
			}
		}
		private void ScanDirectory(string path)
		{
			if(Directory.Exists(path))
			{
				string[] paths;
				paths = Directory.GetFileSystemEntries(path);
				foreach(string p in paths)
				{
					statusBarPanelName.Text = "列挙中... : " + p;
					ScanDirectory(p);	// 再帰！
				}
			}
			else if(File.Exists(path) && IsBms(path))
			{
				statusBarPanelName.Text = "列挙中... : " + path;
				filestemp += (path + "\n");
			}
		}
		#region menuItem
		private void menuItemEditFont_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.FontDialog dialog
				= new System.Windows.Forms.FontDialog();
			dialog.Font = this.Font;
			if(dialog.ShowDialog() == DialogResult.OK)
				this.Font = dialog.Font;
			mainfont = this.Font;
		}
		private void menuItemEditDel_Click(object sender, System.EventArgs e)
		{
			listViewBms.BeginUpdate();
			foreach(ListViewItem items in listViewBms.SelectedItems)
			{
				items.Remove();
			}
			listViewBms.EndUpdate();
		}
		private void menuItemEditClearR_Click(object sender, System.EventArgs e)
		{
			menuItemEditClear.PerformClick();
		}

		private void menuItemEditDelR_Click(object sender, System.EventArgs e)
		{
			menuItemEditDel.PerformClick();
		}

		private void menuItemFileM3U_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.AddExtension = true;
			dialog.Title = "M3Uプレイリストの保存";
			dialog.Filter = "M3Uプレイリスト (*.m3u)|*.m3u";
			dialog.DefaultExt = "m3u";
			string data = "";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				StreamWriter sr = new StreamWriter(dialog.FileName, false, System.Text.Encoding.Default);
				foreach(ListViewItem items in listViewBms.Items)
				{
					data += items.SubItems[6].Text + "\r\n";
				}
				sr.Write(data);
				sr.Close();
			}
		}

		private void menuItemFileHtml_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.AddExtension = true;
			dialog.Title = "M3Uドキュメントの保存";
			dialog.Filter = "HTMLドキュメント (*.html)|*.html";
			dialog.DefaultExt = "m3u";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				string[] p;
				const string HTML_STYLE = @"<style>body,td,th{font-family:Verdana;}table{border-collapse:collapse;border:solid 1px #808080;background-color:#efefff;font-size:70%;}.na{color:888888;}</style>";
				const string HTML_HEADER = "<html><head>" + HTML_STYLE + "</head><body>"
						  + "<table border><tr><th>player</th><th>title</th><th>artist</th><th>genre</th><th>bpm</th><th>playlevel</th>"
						  + "<th>rank</th><th>total</th><th>comment</th><th>url</th><th>mail</th></tr>\n";
				const string HTML_FOOTER = "</table></body></html>";
				string data = HTML_HEADER;
				InitStatusProgress(1,listViewBms.Items.Count);
				for(int i = 0; i < listViewBms.Items.Count; i++)
				{
					statusBarPanelName.Text = listViewBms.Items[i].SubItems[0].Text + " のヘッダを解析中...";
					data += "<tr>";
					BmsLoadClass.LoadBMSHeader(listViewBms.Items[i].SubItems[6].Text, out p);
					for(int j = 0; j < p.Length; j++)
					{
						if(p[j] == string.Empty || p[j] == null)
							data += "<td class=\"na\">n/a</td>";
						else
							data += "<td>" + p[j] + "</td>";
					}
					data += "</tr>\n";
					statusBarPanelProgress.Step();
				}
				data += HTML_FOOTER;
				
				StreamWriter sr = new StreamWriter(dialog.FileName, false, System.Text.Encoding.Default);
				sr.Write(data);
				sr.Close();

				InitStatusProgress(0,0);
				statusBarPanelName.Text = "待機中...";
			}
		}

		private void menuItemFileOpFolder_Click(object sender, System.EventArgs e)
		{
			t = new Thread(new ThreadStart(ScanDirectoryThread));
			t.IsBackground = true;
			t.Start();
		}

		private void menuItemFileOp_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "BMSを開く";
			dialog.Filter = "BMS (*bms;*.bme;*.bml;*.pms)|*bms;*.bme;*.bml;*.pms";
			dialog.Multiselect = true;
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				files = dialog.FileNames;
				t = new Thread(new ThreadStart(AddToListViewThread));
				t.IsBackground = true;
				t.Start();
			}
		}

		private void menuItemFileOpM3U_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "M3Uプレイリストを開く";
			dialog.Filter = "m3uプレイリスト (*.m3u)|*.m3u";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				if (!File.Exists(dialog.FileName)) return ;

				ToggleBusyBar();
				StreamReader reader = new StreamReader(dialog.FileName,
					Encoding.GetEncoding("Shift_JIS")) ;
				string reader_temp;
				string tmp = "";
				while ((reader_temp = reader.ReadLine()) != null) 
				{
					if(reader_temp.StartsWith("#")) continue;
					statusBarPanelName.Text = "リスト読み込み中... : " + reader_temp;
					tmp += reader_temp + "\n";
				}
				reader.Close();
				statusBarPanelName.Text = "追加準備中...";
				files = tmp.Split(new char[] {'\n'});

				t = new Thread(new ThreadStart(AddToListViewThread));
				t.IsBackground = true;
				t.Start();
			}
		}

		private void menuItemFileOpR_Click(object sender, System.EventArgs e)
		{
			menuItemFileOp.PerformClick();
		}

		private void menuItemFileOpFolderR_Click(object sender, System.EventArgs e)
		{
			menuItemFileOpFolder.PerformClick();
		}

		private void menuItemFileOpM3UR_Click(object sender, System.EventArgs e)
		{
			menuItemFileOpM3U.PerformClick();
		}

		private void menuItemFileHtmlR_Click(object sender, System.EventArgs e)
		{
			menuItemFileHtml.PerformClick();
		}

		private void menuItemFileM3UR_Click(object sender, System.EventArgs e)
		{
			menuItemFileM3U.PerformClick();
		}
		private void menuItemHelpRead_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("気合で使う。");
		}
		private void menuItemHelpWeb_Click(object sender, System.EventArgs e)
		{
			Process.Start("http://www.killertomatoes.com/");
		}

		private void menuItemHelpBbs_Click(object sender, System.EventArgs e)
		{
			Process.Start("http://www.killertomatoes.com/");
		}

		#endregion
		private void statusBar1_DrawItem(object sender, System.Windows.Forms.StatusBarDrawItemEventArgs sbdevent)
		{
			if (sbdevent.Panel == this.statusBarPanelProgress)
			{
				StatusBar sb = (StatusBar)sender;
				Rectangle rect = sbdevent.Bounds;
				this.colorFadeBusyBar1.SetBounds(sb.Location.X + rect.X, sb.Location.Y + rect.Y, 
					rect.Width, rect.Height);
			}
		}

	}
}
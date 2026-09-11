using CreamInstaller.Components;
using CreamInstaller.Resources;
using System.ComponentModel;
using System.Windows.Forms;

namespace CreamInstaller.Forms
{
    partial class MainForm
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            installButton = new Button();
            programsGroupBox = new GroupBox();
            noneFoundLabel = new Label();
            useSmokeAPILayoutPanel = new FlowLayoutPanel();
            useSmokeApiToggle = new ToggleSwitch();
            useSmokeApiLabel = new Label();
            useSmokeAPIHelpButton = new Button();
            allCheckBoxLayoutPanel = new FlowLayoutPanel();
            allCheckBox = new CheckBox();
            progressBar = new ProgressBar();
            progressLabel = new Label();
            scanButton = new Button();
            uninstallButton = new Button();
            progressLabelGames = new Label();
            progressLabelDLCs = new Label();
            saveFlowPanel = new FlowLayoutPanel();
            settingsButton = new Button();
            selectionTreeView = new CustomTreeView();
            topOptionsTable = new TableLayoutPanel();
            mainToolTip = new ToolTip();
            mainToolTip.AutoPopDelay = 8000;
            mainToolTip.InitialDelay = 500;
            mainToolTip.ReshowDelay = 100;
            programsGroupBox.SuspendLayout();
            useSmokeAPILayoutPanel.SuspendLayout();
            allCheckBoxLayoutPanel.SuspendLayout();
            saveFlowPanel.SuspendLayout();
            topOptionsTable.SuspendLayout();
            SuspendLayout();
            // 
            // installButton
            // 
            installButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            installButton.Enabled = false;
            installButton.Location = new System.Drawing.Point(710, 536);
            installButton.Name = "installButton";
            installButton.Size = new System.Drawing.Size(172, 38);
            installButton.TabIndex = 10000;
            installButton.Text = "Generate and Install";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += OnInstall;
            mainToolTip.SetToolTip(installButton, "Generate DLC unlocker configurations and install them into the selected games.");
            // 
            // programsGroupBox
            // 
            programsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            programsGroupBox.Controls.Add(selectionTreeView);
            programsGroupBox.Location = new System.Drawing.Point(18, 64);
            programsGroupBox.Name = "programsGroupBox";
            programsGroupBox.Padding = new Padding(12, 10, 12, 12);
            programsGroupBox.Size = new System.Drawing.Size(864, 382);
            programsGroupBox.TabIndex = 1000;
            programsGroupBox.TabStop = false;
            programsGroupBox.Text = "Programs && Games";
            programsGroupBox.Enter += programsGroupBox_Enter;
            // 
            // noneFoundLabel
            // 
            noneFoundLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            noneFoundLabel.Location = new System.Drawing.Point(18, 454);
            noneFoundLabel.Name = "noneFoundLabel";
            noneFoundLabel.Size = new System.Drawing.Size(864, 24);
            noneFoundLabel.TabIndex = 1003;
            noneFoundLabel.Text = "No applicable programs and/or games found.";
            noneFoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            noneFoundLabel.Visible = false;
            // 
            // useSmokeAPILayoutPanel
            // 
            useSmokeAPILayoutPanel.AutoSize = true;
            useSmokeAPILayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            useSmokeAPILayoutPanel.Controls.Add(useSmokeApiToggle);
            useSmokeAPILayoutPanel.Controls.Add(useSmokeApiLabel);
            useSmokeAPILayoutPanel.Controls.Add(useSmokeAPIHelpButton);
            useSmokeAPILayoutPanel.Margin = new Padding(0);
            useSmokeAPILayoutPanel.Name = "useSmokeAPILayoutPanel";
            useSmokeAPILayoutPanel.Size = new System.Drawing.Size(270, 30);
            useSmokeAPILayoutPanel.TabIndex = 1006;
            useSmokeAPILayoutPanel.WrapContents = false;
            // 
            // useSmokeApiToggle
            // 
            useSmokeApiToggle.Location = new System.Drawing.Point(0, 4);
            useSmokeApiToggle.Margin = new Padding(0, 4, 8, 0);
            useSmokeApiToggle.Name = "useSmokeApiToggle";
            useSmokeApiToggle.Size = new System.Drawing.Size(44, 22);
            useSmokeApiToggle.TabIndex = 1;
            useSmokeApiToggle.CheckedChanged += OnUseSmokeApiToggleChanged;
            // 
            // useSmokeApiLabel
            // 
            useSmokeApiLabel.AutoSize = true;
            useSmokeApiLabel.Location = new System.Drawing.Point(52, 6);
            useSmokeApiLabel.Margin = new Padding(0, 6, 4, 0);
            useSmokeApiLabel.Name = "useSmokeApiLabel";
            useSmokeApiLabel.Size = new System.Drawing.Size(175, 15);
            useSmokeApiLabel.TabIndex = 3;
            useSmokeApiLabel.Text = "Selected Unlocker: SmokeAPI";
            useSmokeApiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // useSmokeAPIHelpButton
            // 
            useSmokeAPIHelpButton.Enabled = false;
            useSmokeAPIHelpButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            useSmokeAPIHelpButton.Location = new System.Drawing.Point(233, 2);
            useSmokeAPIHelpButton.Margin = new Padding(2, 2, 0, 0);
            useSmokeAPIHelpButton.Name = "useSmokeAPIHelpButton";
            useSmokeAPIHelpButton.Size = new System.Drawing.Size(28, 28);
            useSmokeAPIHelpButton.TabIndex = 2;
            useSmokeAPIHelpButton.Text = "?";
            useSmokeAPIHelpButton.UseVisualStyleBackColor = true;
            useSmokeAPIHelpButton.Click += OnUseSmokeAPIHelpButtonClicked;
            mainToolTip.SetToolTip(useSmokeAPIHelpButton, "Learn more about the SmokeAPI and CreamAPI unlocker engines.");
            mainToolTip.SetToolTip(useSmokeApiToggle, "Switch between SmokeAPI (on) and CreamAPI (off) unlocker engines for Steam and Paradox games.");
            // 
            // allCheckBoxLayoutPanel
            // 
            allCheckBoxLayoutPanel.AutoSize = true;
            allCheckBoxLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            allCheckBoxLayoutPanel.Controls.Add(allCheckBox);
            allCheckBoxLayoutPanel.Margin = new Padding(12, 2, 8, 0);
            allCheckBoxLayoutPanel.Name = "allCheckBoxLayoutPanel";
            allCheckBoxLayoutPanel.Size = new System.Drawing.Size(88, 30);
            allCheckBoxLayoutPanel.TabIndex = 1007;
            allCheckBoxLayoutPanel.WrapContents = false;
            // 
            // allCheckBox
            // 
            allCheckBox.AutoSize = false;
            allCheckBox.Checked = true;
            allCheckBox.CheckState = CheckState.Checked;
            allCheckBox.Enabled = false;
            allCheckBox.FlatStyle = FlatStyle.System;
            allCheckBox.Location = new System.Drawing.Point(0, 2);
            allCheckBox.Margin = new Padding(0, 2, 0, 0);
            allCheckBox.Name = "allCheckBox";
            allCheckBox.Size = new System.Drawing.Size(88, 26);
            allCheckBox.TabIndex = 4;
            allCheckBox.Text = "Select All";
            allCheckBox.CheckedChanged += OnAllCheckBoxChanged;
            // 
            // selectionTreeView
            // 
            selectionTreeView.BackColor = System.Drawing.SystemColors.Control;
            selectionTreeView.BorderStyle = BorderStyle.None;
            selectionTreeView.CheckBoxes = true;
            selectionTreeView.Dock = DockStyle.Fill;
            selectionTreeView.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            selectionTreeView.Enabled = false;
            selectionTreeView.FullRowSelect = true;
            selectionTreeView.Location = new System.Drawing.Point(12, 26);
            selectionTreeView.Name = "selectionTreeView";
            selectionTreeView.Size = new System.Drawing.Size(840, 344);
            selectionTreeView.TabIndex = 1001;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new System.Drawing.Point(18, 510);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(864, 12);
            progressBar.TabIndex = 9;
            // 
            // progressLabel
            // 
            progressLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressLabel.Location = new System.Drawing.Point(18, 454);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new System.Drawing.Size(864, 24);
            progressLabel.TabIndex = 10;
            progressLabel.Text = "Gathering and caching programs . . .";
            progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            progressLabel.Visible = false;
            // 
            // scanButton
            // 
            scanButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            scanButton.Location = new System.Drawing.Point(604, 536);
            scanButton.Name = "scanButton";
            scanButton.Size = new System.Drawing.Size(100, 38);
            scanButton.TabIndex = 10004;
            scanButton.Text = "Rescan";
            scanButton.UseVisualStyleBackColor = true;
            scanButton.Click += OnScan;
            mainToolTip.SetToolTip(scanButton, "Re-scan for installed games and refresh the DLC list from cache.");
            // 
            // uninstallButton
            // 
            uninstallButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            uninstallButton.Enabled = false;
            uninstallButton.Location = new System.Drawing.Point(18, 536);
            uninstallButton.Name = "uninstallButton";
            uninstallButton.Size = new System.Drawing.Size(176, 38);
            uninstallButton.TabIndex = 10005;
            uninstallButton.Text = "Uninstall Selected";
            uninstallButton.UseVisualStyleBackColor = true;
            uninstallButton.Click += OnUninstall;
            mainToolTip.SetToolTip(uninstallButton, "Remove DLC unlockers from the selected games only.");
            // 
            // progressLabelGames
            // 
            progressLabelGames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressLabelGames.AutoEllipsis = true;
            progressLabelGames.Location = new System.Drawing.Point(18, 482);
            progressLabelGames.Name = "progressLabelGames";
            progressLabelGames.Size = new System.Drawing.Size(420, 20);
            progressLabelGames.TabIndex = 10007;
            progressLabelGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressLabelDLCs
            // 
            progressLabelDLCs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressLabelDLCs.AutoEllipsis = true;
            progressLabelDLCs.Location = new System.Drawing.Point(450, 482);
            progressLabelDLCs.Name = "progressLabelDLCs";
            progressLabelDLCs.Size = new System.Drawing.Size(432, 20);
            progressLabelDLCs.TabIndex = 10008;
            progressLabelDLCs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveFlowPanel
            // 
            saveFlowPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveFlowPanel.AutoSize = true;
            saveFlowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveFlowPanel.Location = new System.Drawing.Point(390, 538);
            saveFlowPanel.Margin = new Padding(0);
            saveFlowPanel.Name = "saveFlowPanel";
            saveFlowPanel.Size = new System.Drawing.Size(200, 34);
            saveFlowPanel.TabIndex = 10009;
            saveFlowPanel.WrapContents = false;
            // 
            // settingsButton
            // 
            settingsButton.Location = new System.Drawing.Point(772, 0);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new System.Drawing.Size(92, 34);
            settingsButton.TabIndex = 10010;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += OnSettingsButtonClick;
            mainToolTip.SetToolTip(settingsButton, "Open application settings.");
            // 
            // topOptionsTable
            // 
            topOptionsTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topOptionsTable.ColumnCount = 4;
            topOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            topOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            topOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            topOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            topOptionsTable.Controls.Add(useSmokeAPILayoutPanel, 0, 0);
            topOptionsTable.Controls.Add(allCheckBoxLayoutPanel, 2, 0);
            topOptionsTable.Controls.Add(settingsButton, 3, 0);
            topOptionsTable.Location = new System.Drawing.Point(18, 18);
            topOptionsTable.Margin = new Padding(0);
            topOptionsTable.Name = "topOptionsTable";
            topOptionsTable.RowCount = 1;
            topOptionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            topOptionsTable.Size = new System.Drawing.Size(864, 34);
            topOptionsTable.TabIndex = 10009;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(900, 590);
            Controls.Add(topOptionsTable);
            Controls.Add(saveFlowPanel);
            Controls.Add(progressLabelDLCs);
            Controls.Add(progressLabelGames);
            Controls.Add(progressLabel);
            Controls.Add(progressBar);
            Controls.Add(noneFoundLabel);
            Controls.Add(programsGroupBox);
            Controls.Add(uninstallButton);
            Controls.Add(scanButton);
            Controls.Add(installButton);
            FormBorderStyle = FormBorderStyle.Sizable;
            HelpButton = true;
            Icon = Properties.Resources.Icon;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = true;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(820, 540);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "MainForm";
            Load += OnLoad;
            programsGroupBox.ResumeLayout(false);
            useSmokeAPILayoutPanel.ResumeLayout(false);
            useSmokeAPILayoutPanel.PerformLayout();
            allCheckBoxLayoutPanel.ResumeLayout(false);
            saveFlowPanel.ResumeLayout(false);
            saveFlowPanel.PerformLayout();
            topOptionsTable.ResumeLayout(false);
            topOptionsTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button installButton;
        private GroupBox programsGroupBox;
        private ProgressBar progressBar;
        private Label progressLabel;
        internal CheckBox allCheckBox;
        private Button scanButton;
        private Label noneFoundLabel;
        private CustomTreeView selectionTreeView;
        private ToggleSwitch useSmokeApiToggle;
        private Label useSmokeApiLabel;
        private Button useSmokeAPIHelpButton;
        private FlowLayoutPanel useSmokeAPILayoutPanel;
        private FlowLayoutPanel allCheckBoxLayoutPanel;
        private Button uninstallButton;
        private Label progressLabelGames;
        private Label progressLabelDLCs;
        private FlowLayoutPanel saveFlowPanel;
        private Button settingsButton;
        private TableLayoutPanel topOptionsTable;
        private ToolTip mainToolTip;
    }
}

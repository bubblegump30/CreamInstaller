using System.ComponentModel;
using System.Windows.Forms;

using CreamInstaller.Components;

namespace CreamInstaller.Forms
{
    partial class ScanDialog
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            acceptButton = new Button();
            groupBox = new GroupBox();
            allCheckBoxFlowPanel = new FlowLayoutPanel();
            allCheckBox = new CheckBox();
            sortCheckBox = new CheckBox();
            cancelButton = new Button();
            loadButton = new Button();
            saveButton = new Button();
            selectionTreeView = new CustomTreeView();
            filterTextBox = new TextBox();
            groupBox.SuspendLayout();
            allCheckBoxFlowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // acceptButton
            // 
            acceptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            acceptButton.DialogResult = DialogResult.OK;
            acceptButton.Location = new System.Drawing.Point(572, 406);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(90, 36);
            acceptButton.TabIndex = 6;
            acceptButton.Text = "OK";
            acceptButton.UseVisualStyleBackColor = true;
            // 
            // filterTextBox
            // 
            filterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filterTextBox.Location = new System.Drawing.Point(18, 18);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.PlaceholderText = "Search by game name or AppID";
            filterTextBox.Size = new System.Drawing.Size(644, 23);
            filterTextBox.TabIndex = 0;
            filterTextBox.TextChanged += OnFilterTextChanged;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(selectionTreeView);
            groupBox.Controls.Add(allCheckBoxFlowPanel);
            groupBox.Location = new System.Drawing.Point(18, 53);
            groupBox.MinimumSize = new System.Drawing.Size(320, 120);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(12, 10, 12, 12);
            groupBox.Size = new System.Drawing.Size(644, 335);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Choose Programs && Games";
            // 
            // selectionTreeView
            // 
            selectionTreeView.BackColor = System.Drawing.SystemColors.Control;
            selectionTreeView.BorderStyle = BorderStyle.None;
            selectionTreeView.CheckBoxes = true;
            selectionTreeView.Dock = DockStyle.Fill;
            selectionTreeView.Location = new System.Drawing.Point(12, 26);
            selectionTreeView.Name = "selectionTreeView";
            selectionTreeView.ShowLines = false;
            selectionTreeView.ShowPlusMinus = false;
            selectionTreeView.ShowRootLines = false;
            selectionTreeView.Size = new System.Drawing.Size(620, 297);
            selectionTreeView.TabIndex = 0;
            // 
            // allCheckBoxFlowPanel
            // 
            allCheckBoxFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            allCheckBoxFlowPanel.AutoSize = true;
            allCheckBoxFlowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            allCheckBoxFlowPanel.Controls.Add(allCheckBox);
            allCheckBoxFlowPanel.Location = new System.Drawing.Point(574, 1);
            allCheckBoxFlowPanel.Margin = new Padding(0);
            allCheckBoxFlowPanel.Name = "allCheckBoxFlowPanel";
            allCheckBoxFlowPanel.Size = new System.Drawing.Size(56, 24);
            allCheckBoxFlowPanel.TabIndex = 1007;
            // 
            // allCheckBox
            // 
            allCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            allCheckBox.AutoSize = true;
            allCheckBox.Location = new System.Drawing.Point(0, 2);
            allCheckBox.Margin = new Padding(0, 2, 0, 0);
            allCheckBox.Name = "allCheckBox";
            allCheckBox.Size = new System.Drawing.Size(40, 19);
            allCheckBox.TabIndex = 1;
            allCheckBox.Text = "All";
            allCheckBox.CheckedChanged += OnAllCheckBoxChanged;
            // 
            // sortCheckBox
            // 
            sortCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sortCheckBox.AutoSize = true;
            sortCheckBox.Checked = true;
            sortCheckBox.Location = new System.Drawing.Point(111, 415);
            sortCheckBox.Margin = new Padding(3, 0, 0, 0);
            sortCheckBox.Name = "sortCheckBox";
            sortCheckBox.Size = new System.Drawing.Size(98, 19);
            sortCheckBox.TabIndex = 3;
            sortCheckBox.Text = "Sort By Name";
            sortCheckBox.CheckedChanged += OnSortCheckBoxChanged;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(18, 406);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(87, 36);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            loadButton.Enabled = false;
            loadButton.Location = new System.Drawing.Point(476, 406);
            loadButton.Name = "loadButton";
            loadButton.Size = new System.Drawing.Size(90, 36);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += OnLoad;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Enabled = false;
            saveButton.Location = new System.Drawing.Point(380, 406);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(90, 36);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += OnSave;
            // 
            // ScanDialog
            // 
            AcceptButton = acceptButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = false;
            ClientSize = new System.Drawing.Size(680, 460);
            Controls.Add(sortCheckBox);
            Controls.Add(saveButton);
            Controls.Add(loadButton);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(groupBox);
            Controls.Add(filterTextBox);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(600, 390);
            Name = "ScanDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ScanDialog";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            allCheckBoxFlowPanel.ResumeLayout(false);
            allCheckBoxFlowPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button acceptButton;
        private GroupBox groupBox;
        private CustomTreeView selectionTreeView;
        private FlowLayoutPanel allCheckBoxFlowPanel;
        private CheckBox allCheckBox;
        private Button cancelButton;
        private Button loadButton;
        private Button saveButton;
        private CheckBox sortCheckBox;
        private TextBox filterTextBox;
    }
}
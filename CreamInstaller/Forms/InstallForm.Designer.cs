using System.ComponentModel;
using System.Windows.Forms;

namespace CreamInstaller.Forms
{
    sealed partial class InstallForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userProgressBar = new ProgressBar();
            userInfoLabel = new Label();
            acceptButton = new Button();
            retryButton = new Button();
            cancelButton = new Button();
            logTextBox = new RichTextBox();
            reselectButton = new Button();
            SuspendLayout();
            // 
            // userProgressBar
            // 
            userProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userProgressBar.Location = new System.Drawing.Point(18, 48);
            userProgressBar.Name = "userProgressBar";
            userProgressBar.Size = new System.Drawing.Size(864, 14);
            userProgressBar.TabIndex = 1;
            // 
            // userInfoLabel
            // 
            userInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInfoLabel.AutoEllipsis = true;
            userInfoLabel.Location = new System.Drawing.Point(18, 18);
            userInfoLabel.Name = "userInfoLabel";
            userInfoLabel.Size = new System.Drawing.Size(864, 22);
            userInfoLabel.TabIndex = 2;
            userInfoLabel.Text = "Loading . . . ";
            userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acceptButton
            // 
            acceptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            acceptButton.Enabled = false;
            acceptButton.Location = new System.Drawing.Point(782, 596);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(100, 36);
            acceptButton.TabIndex = 4;
            acceptButton.Text = "OK";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += OnAccept;
            // 
            // retryButton
            // 
            retryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            retryButton.Enabled = false;
            retryButton.Location = new System.Drawing.Point(676, 596);
            retryButton.Name = "retryButton";
            retryButton.Size = new System.Drawing.Size(100, 36);
            retryButton.TabIndex = 3;
            retryButton.Text = "Retry";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += OnRetry;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.Location = new System.Drawing.Point(18, 596);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(100, 36);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += OnCancel;
            // 
            // logTextBox
            // 
            logTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logTextBox.HideSelection = false;
            logTextBox.Location = new System.Drawing.Point(18, 76);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            logTextBox.Size = new System.Drawing.Size(864, 504);
            logTextBox.TabIndex = 4;
            logTextBox.TabStop = false;
            logTextBox.Text = "";
            // 
            // reselectButton
            // 
            reselectButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reselectButton.Location = new System.Drawing.Point(462, 596);
            reselectButton.Name = "reselectButton";
            reselectButton.Size = new System.Drawing.Size(208, 36);
            reselectButton.TabIndex = 2;
            reselectButton.Text = "Reselect Programs / Games";
            reselectButton.UseVisualStyleBackColor = true;
            reselectButton.Click += OnReselect;
            // 
            // InstallForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = false;
            ClientSize = new System.Drawing.Size(900, 650);
            Controls.Add(reselectButton);
            Controls.Add(logTextBox);
            Controls.Add(cancelButton);
            Controls.Add(retryButton);
            Controls.Add(acceptButton);
            Controls.Add(userProgressBar);
            Controls.Add(userInfoLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(760, 540);
            Name = "InstallForm";
            StartPosition = FormStartPosition.Manual;
            Text = "InstallForm";
            Load += OnLoad;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar userProgressBar;
        private Label userInfoLabel;
        private Button acceptButton;
        private Button retryButton;
        private Button cancelButton;
        private RichTextBox logTextBox;
        private Button reselectButton;
    }
}


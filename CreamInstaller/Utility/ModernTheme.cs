using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreamInstaller.Utility;

/// <summary>
/// Presentation-only styling layered on top of ThemeManager.
/// Keeps application behavior unchanged while providing a clearer visual hierarchy,
/// larger interaction targets, and consistent light/dark surfaces.
/// </summary>
internal static class ModernTheme
{
    private static readonly Color DarkWindow = ColorTranslator.FromHtml("#0D1117");
    private static readonly Color DarkSurface = ColorTranslator.FromHtml("#161B22");
    private static readonly Color DarkSurfaceHover = ColorTranslator.FromHtml("#21262D");
    private static readonly Color DarkBorder = ColorTranslator.FromHtml("#30363D");
    private static readonly Color DarkText = ColorTranslator.FromHtml("#F0F6FC");
    private static readonly Color DarkMuted = ColorTranslator.FromHtml("#8B949E");

    private static readonly Color LightWindow = ColorTranslator.FromHtml("#F6F8FA");
    private static readonly Color LightSurface = Color.White;
    private static readonly Color LightSurfaceHover = ColorTranslator.FromHtml("#F3F4F6");
    private static readonly Color LightBorder = ColorTranslator.FromHtml("#D0D7DE");
    private static readonly Color LightText = ColorTranslator.FromHtml("#1F2328");
    private static readonly Color LightMuted = ColorTranslator.FromHtml("#57606A");

    private static readonly Color Accent = ColorTranslator.FromHtml("#2F81F7");
    private static readonly Color AccentHover = ColorTranslator.FromHtml("#388BFD");
    private static readonly Color AccentPressed = ColorTranslator.FromHtml("#1F6FEB");
    private static readonly Color Danger = ColorTranslator.FromHtml("#DA3633");
    private static readonly Color DangerHover = ColorTranslator.FromHtml("#F85149");
    private static readonly Color DangerPressed = ColorTranslator.FromHtml("#B62324");

    internal static void Apply(Form form)
    {
        if (form is null || form.IsDisposed)
            return;

        bool dark = Program.DarkModeEnabled;
        Color window = dark ? DarkWindow : LightWindow;
        Color surface = dark ? DarkSurface : LightSurface;
        Color text = dark ? DarkText : LightText;
        Color muted = dark ? DarkMuted : LightMuted;

        form.SuspendLayout();
        form.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        form.BackColor = window;
        form.ForeColor = text;

        foreach (Control control in form.Controls)
            ApplyControl(control, dark);

        ApplyLayoutPolish(form, surface, text, muted);

        form.ResumeLayout(true);
        form.Invalidate(true);
    }

    private static void ApplyControl(Control control, bool dark)
    {
        if (control is null)
            return;

        foreach (Control child in control.Controls)
            ApplyControl(child, dark);

        Color window = dark ? DarkWindow : LightWindow;
        Color surface = dark ? DarkSurface : LightSurface;
        Color hover = dark ? DarkSurfaceHover : LightSurfaceHover;
        Color border = dark ? DarkBorder : LightBorder;
        Color text = dark ? DarkText : LightText;
        Color muted = dark ? DarkMuted : LightMuted;

        switch (control)
        {
            case Button button:
                StyleButton(button, surface, hover, border, text);
                break;

            case GroupBox groupBox:
                groupBox.BackColor = surface;
                groupBox.ForeColor = text;
                groupBox.Padding = new Padding(12, 10, 12, 12);
                break;

            case TreeView treeView:
                treeView.BackColor = surface;
                treeView.ForeColor = text;
                treeView.LineColor = border;
                treeView.BorderStyle = BorderStyle.None;
                break;

            case RichTextBox richTextBox:
                richTextBox.BackColor = surface;
                richTextBox.ForeColor = text;
                richTextBox.BorderStyle = BorderStyle.FixedSingle;
                break;

            case TextBox textBox:
                textBox.BackColor = surface;
                textBox.ForeColor = text;
                textBox.BorderStyle = BorderStyle.FixedSingle;
                break;

            case ComboBox comboBox:
                comboBox.BackColor = surface;
                comboBox.ForeColor = text;
                break;

            case CheckBox checkBox:
                checkBox.BackColor = Color.Transparent;
                checkBox.ForeColor = text;
                break;

            case Label label:
                label.BackColor = Color.Transparent;
                label.ForeColor = IsMutedLabel(label) ? muted : text;
                break;

            case ProgressBar progressBar:
                progressBar.BackColor = surface;
                progressBar.ForeColor = Accent;
                break;

            case TableLayoutPanel table:
                table.BackColor = window;
                break;

            case FlowLayoutPanel flow:
                flow.BackColor = Color.Transparent;
                break;

            case Panel panel:
                panel.BackColor = window;
                break;
        }
    }

    /// <summary>
    /// Final presentation-only adjustments that depend on a control's role in a form.
    /// No application state, event wiring, or business logic is changed here.
    /// </summary>
    private static void ApplyLayoutPolish(Form form, Color surface, Color text, Color muted)
    {
        // Scan dialog: give the search field more breathing room and rebuild its cue banner
        // once after ThemeManager's native refresh. This avoids the ghosted/double-drawn
        // placeholder that can occur on themed WinForms text boxes.
        TextBox filterTextBox = FindControl<TextBox>(form, "filterTextBox");
        GroupBox scanGroupBox = FindControl<GroupBox>(form, "groupBox");
        if (filterTextBox is not null)
        {
            filterTextBox.AutoSize = false;
            filterTextBox.Height = 32;
            filterTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            if (filterTextBox.TextLength == 0 && !string.IsNullOrEmpty(filterTextBox.PlaceholderText))
            {
                string placeholder = filterTextBox.PlaceholderText;
                filterTextBox.PlaceholderText = string.Empty;
                filterTextBox.PlaceholderText = placeholder;
            }
        }

        if (scanGroupBox is not null)
        {
            int originalBottom = scanGroupBox.Bottom;
            if (filterTextBox is not null)
                scanGroupBox.Top = filterTextBox.Bottom + 12;
            scanGroupBox.Height = Math.Max(120, originalBottom - scanGroupBox.Top);
            scanGroupBox.Padding = new Padding(12, 16, 12, 12);
        }

        FlowLayoutPanel scanSelectAllPanel = FindControl<FlowLayoutPanel>(form, "allCheckBoxFlowPanel");
        if (scanSelectAllPanel is not null && scanGroupBox is not null)
        {
            scanSelectAllPanel.BackColor = surface;
            scanSelectAllPanel.Padding = new Padding(6, 1, 4, 1);
            Size preferred = scanSelectAllPanel.PreferredSize;
            scanSelectAllPanel.Location = new Point(
                Math.Max(12, scanGroupBox.ClientSize.Width - preferred.Width - 12),
                4);
        }

        // Main form: visually center the entire top command row.
        TableLayoutPanel topOptionsTable = FindControl<TableLayoutPanel>(form, "topOptionsTable");
        if (topOptionsTable is not null)
        {
            topOptionsTable.Height = 36;
            if (topOptionsTable.RowStyles.Count > 0)
                topOptionsTable.RowStyles[0].Height = 36F;
        }

        ToggleSwitch unlockerToggle = FindControl<ToggleSwitch>(form, "useSmokeApiToggle");
        if (unlockerToggle is not null)
            unlockerToggle.Margin = new Padding(0, 7, 8, 0);

        Label unlockerLabel = FindControl<Label>(form, "useSmokeApiLabel");
        if (unlockerLabel is not null)
            unlockerLabel.Margin = new Padding(0, 8, 6, 0);

        Button helpButton = FindControl<Button>(form, "useSmokeAPIHelpButton");
        if (helpButton is not null)
        {
            helpButton.Size = new Size(30, 30);
            helpButton.Margin = new Padding(2, 3, 0, 0);
        }

        FlowLayoutPanel mainSelectAllPanel = FindControl<FlowLayoutPanel>(form, "allCheckBoxLayoutPanel");
        if (mainSelectAllPanel is not null)
            mainSelectAllPanel.Margin = new Padding(12, 3, 8, 0);

        CheckBox mainSelectAll = FindControl<CheckBox>(form, "allCheckBox");
        if (mainSelectAll is not null && mainSelectAll.Parent?.Name == "allCheckBoxLayoutPanel")
        {
            mainSelectAll.Size = new Size(92, 30);
            mainSelectAll.Margin = new Padding(0, 3, 0, 0);
        }

        Button settingsButton = FindControl<Button>(form, "settingsButton");
        if (settingsButton is not null)
            settingsButton.Size = new Size(96, 36);

        // Keep the empty-state message inside the Programs & Games surface so it remains
        // centered when the progress area is collapsed and the group box grows vertically.
        GroupBox programsGroupBox = FindControl<GroupBox>(form, "programsGroupBox");
        Label noneFoundLabel = FindControl<Label>(form, "noneFoundLabel");
        if (programsGroupBox is not null && noneFoundLabel is not null)
        {
            if (noneFoundLabel.Parent != programsGroupBox)
                noneFoundLabel.Parent = programsGroupBox;

            noneFoundLabel.Dock = DockStyle.Fill;
            noneFoundLabel.Padding = new Padding(24);
            noneFoundLabel.BackColor = surface;
            noneFoundLabel.ForeColor = muted;
            noneFoundLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            noneFoundLabel.TextAlign = ContentAlignment.MiddleCenter;
            noneFoundLabel.BringToFront();
        }
    }

    private static T FindControl<T>(Control root, string name) where T : Control
    {
        Control[] matches = root.Controls.Find(name, true);
        return matches.Length > 0 ? matches[0] as T : null;
    }

    private static void StyleButton(Button button, Color surface, Color hover, Color border, Color text)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 1;
        button.FlatAppearance.BorderColor = border;
        button.FlatAppearance.MouseOverBackColor = hover;
        button.FlatAppearance.MouseDownBackColor = border;
        button.BackColor = surface;
        button.ForeColor = text;
        button.Cursor = Cursors.Hand;
        button.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        button.MinimumSize = new Size(button.MinimumSize.Width, 34);

        if (IsPrimaryButton(button))
        {
            button.BackColor = Accent;
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderColor = Accent;
            button.FlatAppearance.MouseOverBackColor = AccentHover;
            button.FlatAppearance.MouseDownBackColor = AccentPressed;
        }
        else if (IsDangerButton(button))
        {
            button.BackColor = Danger;
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderColor = Danger;
            button.FlatAppearance.MouseOverBackColor = DangerHover;
            button.FlatAppearance.MouseDownBackColor = DangerPressed;
        }
    }

    private static bool IsPrimaryButton(Button button)
        => button.Name is "installButton" or "acceptButton" or "saveButton";

    private static bool IsDangerButton(Button button)
        => button.Name is "uninstallButton" or "clearCacheButton";

    private static bool IsMutedLabel(Label label)
        => label.Name is "progressLabelGames" or "progressLabelDLCs" or "noneFoundLabel";
}

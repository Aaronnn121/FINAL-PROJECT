using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class Theme
{
    // Palette: dark green, black, white
    public static readonly Color Background = Color.FromArgb(12, 14, 12);      // page background
    public static readonly Color Panel = Color.FromArgb(20, 22, 20);           // control background
    public static readonly Color Text = Color.FromArgb(240, 240, 240);         // primary text
    public static readonly Color Accent = Color.FromArgb(0, 122, 72);          // dark green accent
    public static readonly Color AccentHover = Color.FromArgb(0, 150, 90);     // hover accent
    public static readonly Color Muted = Color.FromArgb(140, 140, 140);        // subtle text
    public static readonly Color Danger = Color.FromArgb(255, 68, 68);         // danger/red

    // Fonts
    public static readonly Font BaseFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
    public static readonly Font HeaderFont = new Font("Segoe UI", 10F, FontStyle.Bold);

    public static void ApplyToForm(Form f)
    {
        f.BackColor = Background;
        f.ForeColor = Text;
        f.Font = BaseFont;
        f.Padding = new Padding(12);

        // Recursively apply to contained controls
        foreach (Control c in f.Controls)
            ApplyToControl(c);
    }

    private static void ApplyToControl(Control c)
    {
        // Apply to children first
        foreach (Control child in c.Controls)
            ApplyToControl(child);

        // General text/font
        c.ForeColor = Text;
        c.Font = BaseFont;

        // Type specific styles (do not blindly override all BackColors to preserve explicit designer choices)
        switch (c)
        {
            case Panel p:
                p.BackColor = Background;
                break;

            case GroupBox gb:
                gb.BackColor = Background;
                gb.ForeColor = Text;
                break;

            case Label lbl:
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Text;
                break;

            case Button b:
                ApplyButtonStyle(b);
                break;

            case TextBox tb:
                tb.BackColor = Panel;
                tb.ForeColor = Text;
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.Padding = new Padding(6);
                break;

            case ComboBox cb:
                cb.BackColor = Panel;
                cb.ForeColor = Text;
                cb.FlatStyle = FlatStyle.Flat;
                break;

            case DataGridView dgv:
                StyleDataGridView(dgv);
                break;

            default:
                // leave other controls' backgrounds alone, so designer-specified colors remain
                break;
        }
    }

    private static void ApplyButtonStyle(Button b)
    {
        // Tag-based style hints: set b.Tag = "secondary" | "danger" | "ghost" in the designer to change style
        var tag = b.Tag?.ToString()?.ToLowerInvariant() ?? string.Empty;

        b.FlatStyle = FlatStyle.Flat;
        b.FlatAppearance.BorderSize = 0;
        b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

        if (tag.Contains("secondary"))
        {
            // outline / dark secondary
            b.BackColor = Color.FromArgb(18, 20, 18);
            b.ForeColor = Text;
            b.FlatAppearance.BorderColor = Accent;
            b.FlatAppearance.BorderSize = 2;
        }
        else if (tag.Contains("danger"))
        {
            b.BackColor = Color.FromArgb(18, 20, 18);
            b.ForeColor = Danger;
            b.FlatAppearance.BorderColor = Danger;
            b.FlatAppearance.BorderSize = 2;
        }
        else if (tag.Contains("ghost"))
        {
            b.BackColor = Panel;
            b.ForeColor = Accent;
            b.FlatAppearance.BorderSize = 0;
        }
        else
        {
            // primary
            b.BackColor = Accent;
            b.ForeColor = Color.White;
        }

        // Rounded corners and hover behaviour
        try
        {
            int radius = Math.Max(6, Math.Min(b.Height / 2, 12));
            b.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, b.Width, b.Height, radius, radius));
        }
        catch { /* swallow for design-time */ }

        // Attach hover handlers (avoid duplicate subscriptions)
        b.MouseEnter -= Button_MouseEnter;
        b.MouseLeave -= Button_MouseLeave;
        b.MouseEnter += Button_MouseEnter;
        b.MouseLeave += Button_MouseLeave;
    }

    private static void Button_MouseEnter(object? sender, EventArgs e)
    {
        if (sender is not Button b) return;
        var tag = b.Tag?.ToString()?.ToLowerInvariant() ?? string.Empty;

        if (tag.Contains("secondary") || tag.Contains("danger") || tag.Contains("ghost"))
            b.BackColor = Color.FromArgb(30, 32, 30);
        else
            b.BackColor = AccentHover;
    }

    private static void Button_MouseLeave(object? sender, EventArgs e)
    {
        if (sender is not Button b) return;
        var tag = b.Tag?.ToString()?.ToLowerInvariant() ?? string.Empty;

        if (tag.Contains("secondary") || tag.Contains("danger"))
            b.BackColor = Color.FromArgb(18, 20, 18);
        else if (tag.Contains("ghost"))
            b.BackColor = Panel;
        else
            b.BackColor = Accent;
    }

    public static void StyleDataGridView(DataGridView dgv)
    {
        dgv.EnableHeadersVisualStyles = false;
        dgv.BackgroundColor = Background;
        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = Color.FromArgb(30, 30, 30);

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Accent;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = HeaderFont;
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgv.ColumnHeadersHeight = 42;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        dgv.RowHeadersVisible = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.DefaultCellStyle.BackColor = Panel;
        dgv.DefaultCellStyle.ForeColor = Text;
        dgv.DefaultCellStyle.SelectionBackColor = AccentHover;
        dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(14, 16, 14);
        dgv.RowTemplate.Height = 36;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.ReadOnly = true;
    }

    // P/Invoke for rounded corners
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    public static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);
}
using System.Drawing;
using System.Windows.Forms;

public static class Theme
{
    public static Color Background = Color.FromArgb(15, 15, 15);        // Almost black
    public static Color Panel = Color.FromArgb(25, 25, 25);             // Dark panel
    public static Color Text = Color.FromArgb(230, 230, 230);           // Light grey text
    public static Color Accent = Color.FromArgb(0, 255, 90);            // NEON green
    public static Color AccentHover = Color.FromArgb(0, 200, 70);       // Slightly darker green

    public static void ApplyToForm(Form f)
    {
        f.BackColor = Background;
        f.Font = new Font("Segoe UI", 10, FontStyle.Regular);

        foreach (Control c in f.Controls)
            ApplyToControl(c);
    }

    private static void ApplyToControl(Control c)
    {
        // Apply styling recursively
        foreach (Control child in c.Controls)
            ApplyToControl(child);

        c.ForeColor = Text;

        // Buttons
        if (c is Button b)
        {
            b.BackColor = Accent;
            b.ForeColor = Color.Black;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = AccentHover;
            b.Padding = new Padding(5);
            b.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            b.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, b.Width, b.Height, 10, 10)
            );
        }

        // Textboxes
        if (c is TextBox tb)
        {
            tb.BackColor = Panel;
            tb.ForeColor = Accent;
            tb.BorderStyle = BorderStyle.FixedSingle;
        }

        // ComboBoxes
        if (c is ComboBox cb)
        {
            cb.BackColor = Panel;
            cb.ForeColor = Accent;
            cb.FlatStyle = FlatStyle.Flat;
        }

        // DataGridView
        if (c is DataGridView dgv)
        {
            dgv.BackgroundColor = Background;
            dgv.DefaultCellStyle.BackColor = Panel;
            dgv.DefaultCellStyle.ForeColor = Accent;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Accent;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;
        }
    }

    // Windows API to create rounded corners
    [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    public static extern int CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
    );
}
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class MakeButtonRound
{
    public static void makeButtonRound(Button button, int cornerRadius)
    {
        // Create a rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
        path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
        path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        path.CloseFigure();
        button.Region = new Region(path);

        // Redraw the button with rounded edges
        button.Paint += (sender, e) =>
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(button.BackColor), path);
            e.Graphics.DrawPath(new Pen(Color.Black, 2), path);

            // Draw button text centered
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString(button.Text, button.Font, new SolidBrush(button.ForeColor), button.ClientRectangle, stringFormat);
        };
        button.Invalidate(); // Force the button to repaint
    }
}

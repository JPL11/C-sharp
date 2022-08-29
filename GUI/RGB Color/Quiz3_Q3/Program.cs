using System;
using System.Windows.Forms;
using System.Drawing;

public class RGBColor : Form
{
    public RGBColor()
    {
        this.Paint += new PaintEventHandler(f1_paint);
        Size = new Size(450, 450);
    }
    private void f1_paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.Clear(Color.Black);
        int opacity = 127;
        SolidBrush redBrush = new SolidBrush(Color.FromArgb(opacity, 255, 0, 0));
        g.FillEllipse(redBrush, 50, 50, 225, 225);
        SolidBrush greenBrush = new SolidBrush(Color.FromArgb(opacity, 0, 255, 0));
        g.FillEllipse(greenBrush, 160, 50, 225, 225);
        SolidBrush blueBrush = new SolidBrush(Color.FromArgb(opacity, 0, 0, 254));
        g.FillEllipse(blueBrush, 105, 165, 225, 225);
        g.DrawString("Red", new Font("Verdana", 10), new SolidBrush(Color.White), 90, 140);
        g.DrawString("Green", new Font("Verdana", 10), new SolidBrush(Color.White), 300, 140);
        g.DrawString("Blue", new Font("Verdana", 10), new SolidBrush(Color.White), 200, 300);
        g.DrawString("Yellow", new Font("Verdana", 10), new SolidBrush(Color.LightGray), 200, 120);
        g.DrawString("Magenta", new Font("Verdana", 10), new SolidBrush(Color.White), 120, 220);
        g.DrawString("Cyan", new Font("Verdana", 10), new SolidBrush(Color.White), 260, 220);
        g.DrawString("White", new Font("Verdana", 10), new SolidBrush(Color.Black), 200, 200);
    }
    public static void Main()
    {
        Application.Run(new RGBColor());
    }
}
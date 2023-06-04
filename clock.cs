using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

class Clock : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Clock());
    }

    public Clock()
    {
        this.Width = 1300;
        this.Height = 500;

        Timer tm = new Timer();
        tm.Interval = 1000;
        tm.Start();

        lb = new Label();
        lb.Font = new Font("Javanese Text", 200, FontStyle.Regular);
        lb.ForeColor = Color.Blue;
        lb.Dock = DockStyle.Fill;

        lb.Parent = this;

        tm.Tick += new EventHandler(tm_Tick);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;

        lb.Text = dt.ToLongTimeString();
    }
}

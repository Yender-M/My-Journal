using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Journal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int bordeRadio = 0;

            path.AddArc(0, 0, bordeRadio, bordeRadio, 180, 90);
            path.AddArc(Width - bordeRadio, 0, bordeRadio, bordeRadio, 270, 90);
            path.AddArc(Width - bordeRadio, Height - bordeRadio, bordeRadio, bordeRadio, 0, 90);
            path.AddArc(0, Height - bordeRadio, bordeRadio, bordeRadio, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}

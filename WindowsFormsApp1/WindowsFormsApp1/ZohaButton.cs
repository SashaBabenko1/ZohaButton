using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public class ZohaButton: Control
    {

        public bool isChecked =false;
        public Point mousePoint;
        public Rectangle hitZone;
        public ZohaButton():base()
        {
            this.Size = new System.Drawing.Size(100, 50);
            this.Location = new System.Drawing.Point(0, 0);
            this.BackColor = Color.Blue;
            base.Paint += ZohaButton_Paint;
            base.MouseClick += ZohaButton_MouseClick;
            hitZone = new Rectangle(10, 10, 80, 30);

        }

        private void ZohaButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.mousePoint = new Point (e.X,e.Y);
            this.Invalidate();
        }

        private void ZohaButton_Paint(object sender, PaintEventArgs e)
        {
            var Graphics = this.CreateGraphics();

            int height = this.hitZone.Height = this.hitZone.Y;
            int width = height;

            Graphics.FillRectangle(Brushes.White, this.hitZone);
            if (new Rectangle(this.mousePoint, new Size(1, 1)).IntersectsWith(this.hitZone)) 
            {
                isChecked = !isChecked;
            }
            if (isChecked)
            {
                Graphics.FillEllipse(Brushes.Green, new Rectangle(this.hitZone.X, hitZone.Y, width, height));
            }

            else
            {
                Graphics.FillEllipse(Brushes.Red, new Rectangle(60, 10, width, height));
            }
        }
    }
}

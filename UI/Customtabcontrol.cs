using System.Drawing;
using System.Windows.Forms;

namespace PVRL
{
    public class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            // Enable double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < this.TabPages.Count; i++)
            {
                Rectangle tabRect = this.GetTabRect(i);
                if (i == this.SelectedIndex)
                {
                    e.Graphics.FillRectangle(Brushes.Gray, tabRect);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.LightGray, tabRect);
                }

                TextRenderer.DrawText(e.Graphics, this.TabPages[i].Text, this.Font, tabRect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}

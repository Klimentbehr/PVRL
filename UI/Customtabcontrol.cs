using System;
using System.Drawing;
using System.Windows.Forms;

namespace PVRL
{
    public class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.DrawItem += new DrawItemEventHandler(CustomTabControl_DrawItem);
            this.ItemSize = new Size(100, 30); // Adjust size to resemble taskbar items
            this.SizeMode = TabSizeMode.Fixed; // Ensure fixed size for tabs
            this.Alignment = TabAlignment.Top; // Align tabs at the bottom
        }

        private void CustomTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tabPage = this.TabPages[e.Index];
            Rectangle tabRect = this.GetTabRect(e.Index);

            // Background
            if (e.Index == this.SelectedIndex)
            {
                g.FillRectangle(Brushes.Gray, tabRect); // Selected tab color
            }
            else
            {
                g.FillRectangle(Brushes.DarkGray, tabRect); // Unselected tab color
            }

            // Text
            TextRenderer.DrawText(g, tabPage.Text, this.Font, tabRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
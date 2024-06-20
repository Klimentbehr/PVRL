using System.Windows.Forms;

namespace PVRL
{
    public class CustomTabPage : TabPage
    {
        public CustomTabPage()
        {
            // Enable double buffering to reduce flickering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
    }
}

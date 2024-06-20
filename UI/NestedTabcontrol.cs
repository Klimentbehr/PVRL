using System;
using System.Drawing;
using System.Windows.Forms;

namespace PVRL
{
    public class NestedTabControl : CustomTabControl
    {
        public NestedTabControl()
        {
            this.Alignment = TabAlignment.Top; // Align tabs at the top for nested tabs
        }
    }
}

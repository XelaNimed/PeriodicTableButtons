using System.ComponentModel;
using System.Windows.Forms;

namespace ButtonExample
{
    public class PeriodicElementButton : Button
    {
        [Category("Periodic element info")]
        [DisplayName("Element number")]
        public int ElementNumber { get; set; }

        public PeriodicElementButton()
        {
            Size = new System.Drawing.Size(50, 50);
        }
    }
}

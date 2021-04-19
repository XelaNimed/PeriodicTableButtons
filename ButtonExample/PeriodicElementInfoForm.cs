using System;
using System.Windows.Forms;

namespace ButtonExample
{
    public partial class PeriodicElementInfoForm : Form
    {
        private readonly PeriodicElementInfo _elementInfo;
        public PeriodicElementInfoForm(PeriodicElementInfo elementInfo)
        {
            InitializeComponent();

            _elementInfo = elementInfo ?? throw new ArgumentNullException(nameof(elementInfo));

            Load += onLoad;
            button_OK.Click += (_, _) => Close();
        }

        private void onLoad(object sender, EventArgs e)
        {
            Text = _elementInfo.Name;
            label_AtomicMass.Text = _elementInfo.AtomicMass.ToString();
            label_AtomicRadius.Text = _elementInfo.AtomicRadius.ToString();
            label_Designation.Text = _elementInfo.Designation;
            label_Description.Text = _elementInfo.Description;
        }
    }
}

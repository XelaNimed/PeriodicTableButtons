using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ButtonExample
{
    public partial class MainForm : Form
    {
        private Dictionary<string, PeriodicElementInfo> _periodicElementInfos;

        public MainForm()
        {
            InitializeComponent();
            Load += onLoad;
        }

        private void onLoad(object sender, EventArgs e)
        {
            _periodicElementInfos = loadElementsInfo();
            var buttons = getControlsByType<PeriodicElementButton>(this);
            foreach(var button in buttons)
            {
                button.Click += periodicElementButton_Click;
            }
        }

        private void periodicElementButton_Click(object sender, EventArgs e)
        {
            var button = (PeriodicElementButton)sender;
            string elementNumber = button.ElementNumber.ToString();
            PeriodicElementInfo elementInfo = _periodicElementInfos[elementNumber];
            using var dlg = new PeriodicElementInfoForm(elementInfo);
            _ = dlg.ShowDialog(this);
        }

        private static Dictionary<string, PeriodicElementInfo> loadElementsInfo()
        {
            string currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            const string JSON_NAME = "periodicElementsInfo.json";
            string jsonPath = Path.Combine(currentDir, JSON_NAME);
            return NewtonsoftUtils.DeserializeFileContent<Dictionary<string, PeriodicElementInfo>>(jsonPath);
        }

        private IEnumerable<Control> getControlsByType<T>(Control parent) where T : class
        {
            var controls = parent.Controls.Cast<Control>();

            return controls
                .SelectMany(control => getControlsByType<T>(control))
                .Concat(controls)
                .Where(c => c.GetType() == typeof(T));
        }
    }
}

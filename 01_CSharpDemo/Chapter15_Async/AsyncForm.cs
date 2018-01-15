using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter15_Async
{
    public partial class AsyncForm : Form
    {
        private Label label;
        private Button button;
        private Label test;
        private Button btnTest;

        public AsyncForm()
        {
            label = new Label { Location = new Point(10, 20), Text = "Length" };
            button = new Button { Location = new Point(10, 50), Text = "Click" };

            test = new Label { Location = new Point(10, 100), Text = "test" };
            btnTest = new Button { Location = new Point(10, 120), Text = "Test Click" };

            button.Click += DisplayWebSiteLength;
            label.Text = "changed";

            btnTest.Click += CounterClick;

            AutoSize = true;
            Controls.Add(label);
            Controls.Add(button);

            Controls.Add(test);
            Controls.Add(btnTest);
        }

        private async void DisplayWebSiteLength(object sender, EventArgs e)
        {
            label.Text = "Fetching...";
            using (HttpClient client = new HttpClient())
            {
                var text = await client.GetStringAsync("http://csharpindepth.com");
                label.Text = text.Length.ToString();
            }
        }

        private void CounterClick(object sender, EventArgs e)
        {
            var count = 0;
            if (!int.TryParse(test.Text, out count))
                count = 0;

            test.Text = (++count).ToString();
        }
    }
}

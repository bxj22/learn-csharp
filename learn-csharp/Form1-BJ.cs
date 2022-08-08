using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_csharp
{
    public partial class Form1 : Form
    {

        private void btnBJClear_Click(object sender, EventArgs e)
        {
            lbBJResults.Items.Clear();
        }

        public void WriteTextSafe(string text)
        {
            if (lbBJResults.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { WriteTextSafe($"{text}"); };
                lbBJResults.Invoke(safeWrite);
            }
            else
                lbBJResults.Items.Add(text);
        }

        private void DoGUIBackgroundWrite(bool useInvoke)
        {
            Console.WriteLine("Background thread starting");
            try
            {
                for (int idx = 0; idx < 5; idx++)
                {
                    var msg = $"Writing from background thread: {idx}";
                    if (useInvoke)
                        WriteTextSafe(msg);
                    else
                        lbBJResults.Items.Add(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           Console.WriteLine("Background thread ending");
        }

        private void btnBJWriteGUI_Click(object sender, EventArgs e)
        {
            new Thread(() => DoGUIBackgroundWrite(rbBJWithInvoke.Checked)) { IsBackground = true }.Start();
        }

    }
}

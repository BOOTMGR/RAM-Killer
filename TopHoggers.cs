using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAM_Cleaner_2
{
    public partial class TopHoggers : Form
    {
        private Process[] process;

        public TopHoggers()
        {
            InitializeComponent();
            updateItems();
        }

        public void updateItems()
        {
            process = Process.GetProcesses();
            sortAscending(process);
            checkedListBox1.Items.Clear();
            for (int i = 0; i < process.Length; i++)
            {
                if (i <= 5)
                    checkedListBox1.Items.Add(process[i].ProcessName + " (" + Math.Round(getProcessMemory(process[i]) / 1024 / 1024, 2) + " MB)", true);
                else
                    checkedListBox1.Items.Add(process[i].ProcessName + " (" + Math.Round(getProcessMemory(process[i]) / 1024 / 1024, 2) + " MB)");
            }
        }

        private void sortAscending(Process[] proc)
        {
            for (int x = 0; x < proc.Length - 1; x++)
            {
                for (int i = 0; i < proc.Length - 1; i++)
                {
                    if (getProcessMemory(proc[i]) < getProcessMemory(proc[i + 1]))
                    {
                        Process buf = proc[i];
                        proc[i] = proc[i + 1];
                        proc[i + 1] = buf;
                    }
                }
            }
        }

        private double getProcessMemory(Process proc)
        {
            return (proc.VirtualMemorySize64 + proc.WorkingSet64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Killing random process may lead to data loss & can even halt your System.\nAre you sure want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.No)
                return;
            foreach (int x in checkedListBox1.CheckedIndices)
            {
                try
                {
                    process[x].Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to kill: " + process[x].ProcessName + " (PID: " + process[x].Id + ")\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                checkedListBox1.Items.RemoveAt(x);
            }
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            foreach (int x in checkedListBox1.CheckedIndices)
                checkedListBox1.SetItemChecked(x, false);
        }
    }
}

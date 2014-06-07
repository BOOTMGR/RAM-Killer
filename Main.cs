using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAM_Cleaner_2
{
    public partial class Main : Form
    {
        // Switch for Debugging mode
        public static bool DEBUG = false;

        // For commong debug message format
        public static string DEBUG_TAG = "\t[DEBUG] ";

        // bools for checking multiple instances, siblings
        private static bool isBSRunning = false;
        private static bool isAdobeReaderRunning = false;
        private static bool isKiesRunning = false;
        private static bool isAPSRunning = false;
        private static bool isQTTaskRunning = false;

        // count of instances, siblings
        private static int BSinstance = 0;
        private static int AdobeReaederinstance = 0;
        private static int Kiesinstance = 0;
        private static int APSinstance = 0;
        private static int QTTaskinstance = 0;

        // variable to store estimated memory which can be freed
        private static double mem_est = 0;

        // amount of memory actually freed
        private static double mem_freed = 0;

        // this list stores all target processes
        List<int> hoggers = new List<int>();

        // stores all PIDs to be killed
        List<int> hoggers_ID = new List<int>();

        public Main()
        {
            InitializeComponent();
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
                MessageBox.Show("You are not running this tool as Administrator, so this application may not be able to kill some prcesses. For best experience please run this tool as Administrator", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            estimate();
            printHoggers();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        // Clear log button
        private void but_log_clean_Click(object sender, EventArgs e)
        {
            log_msgbox.Clear();
        }

        // search and add victim processes into list
        private void estimate()
        {
            log_msgbox.Text += "Resource Hogging services Running:\n";
            Process[] p = Process.GetProcesses();
            foreach (Process tmp in p)
            {
                string pname = tmp.ProcessName;
                if (DEBUG)
                    log_msgbox.Text += DEBUG_TAG + pname + "\n";
                if (pname.StartsWith("HD-"))
                {
                    hoggers_ID.Add(tmp.Id);
                    if (!isBSRunning)
                    {
                        hoggers.Add(Utils.BLUESTACKS);
                        BSinstance = 1;
                        isBSRunning = true;
                    }
                    else BSinstance++;
                    mem_est += (tmp.WorkingSet64 + tmp.VirtualMemorySize64);
                }
                else if (pname.Equals("AdobeARM"))
                {
                    hoggers_ID.Add(tmp.Id);
                    if (!isAdobeReaderRunning)
                    {
                        hoggers.Add(Utils.ADOBE_READER);
                        AdobeReaederinstance = 1;
                        isAdobeReaderRunning = true;
                    }
                    else AdobeReaederinstance++;
                    mem_est += (tmp.WorkingSet64 + tmp.VirtualMemorySize64);
                }
                else if (pname.Equals("APSDaemon"))
                {
                    hoggers_ID.Add(tmp.Id);
                    if (!isAPSRunning)
                    {
                        hoggers.Add(Utils.APPLE_APSDAEMON);
                        APSinstance = 1;
                        isAPSRunning = true;
                    }
                    else APSinstance++;
                    mem_est += (tmp.WorkingSet64 + tmp.VirtualMemorySize64);
                }
                else if (pname.Equals("QTTask"))
                {
                    hoggers_ID.Add(tmp.Id);
                    if (!isQTTaskRunning)
                    {
                        hoggers.Add(Utils.QUICKTIME_TASK);
                        QTTaskinstance = 1;
                        isQTTaskRunning = true;
                    }
                    else QTTaskinstance++;
                    mem_est += (tmp.WorkingSet64 + tmp.VirtualMemorySize64);
                }
                else if (pname.StartsWith("Kies"))
                {
                    hoggers_ID.Add(tmp.Id);
                    if (!isKiesRunning)
                    {
                        hoggers.Add(Utils.KIES);
                        Kiesinstance = 1;
                        isKiesRunning = true;
                    }
                    else Kiesinstance++;
                    mem_est += (tmp.WorkingSet64 + tmp.VirtualMemorySize64);
                }
           }
        }

        private void printHoggers()
        {
            if (DEBUG)
            {
                foreach (int x in hoggers_ID)
                {
                    log_msgbox.Text += DEBUG_TAG + "PID: " + x + "\n";
                }
            }
            if (hoggers.Count == 0)
            {
                log_msgbox.Text += "\t(none)\n";
                return;
            }
            foreach (int tmp in hoggers)
            {
                switch (tmp)
                {
                    case 1001:
                        log_msgbox.Text += "\tBluestacks (" + BSinstance + ")\n";
                        break;
                    case 1002:
                        log_msgbox.Text += "\tAdobe Reader (" + AdobeReaederinstance + ")\n";
                        break;
                    case 1003:
                        log_msgbox.Text += "\tKies (" + Kiesinstance + ")\n";
                        break;
                    case 1004:
                        log_msgbox.Text += "\tAPS Daemon(" + APSinstance + ")\n";
                        break;
                    case 1005:
                        log_msgbox.Text += "\tQuickTime Services(" + QTTaskinstance + ")\n";
                        break;
                }
            }
            double inter = mem_est / 1024 / 1024;
            if(inter >= 1024)
                log_msgbox.Text += "\nMemory can be cleaned: " + Math.Round(inter / 1024, 2) + " GB\n";
            else
                log_msgbox.Text += "\nMemory can be cleaned: " + Math.Round(inter, 2) + " MB\n";
        }

        private void flushCounters(bool clearList)
        {
            BSinstance = 0;
            AdobeReaederinstance = 0;
            Kiesinstance = 0;
            APSinstance = 0;
            QTTaskinstance = 0;

            isBSRunning = false;
            isAdobeReaderRunning = false;
            isKiesRunning = false;
            isAPSRunning = false;
            isQTTaskRunning = false;

            mem_est = 0;
            mem_freed = 0;
            if (clearList)
            {
                hoggers.Clear();
                hoggers_ID.Clear();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_analyze_Click(object sender, EventArgs e)
        {
            flushCounters(true);
            estimate();
            printHoggers();
        }

        private void but_clean_Click(object sender, EventArgs e)
        {
            if (hoggers_ID.Count == 0)
            {
                log_msgbox.Text += "No process to kill, please analyze first.\n";
                return;
            }
            foreach (int tmp in hoggers_ID)
            {
                Process p = Process.GetProcessById(tmp);
                try
                {
                    p.Kill();
                }
                catch (Exception ex)
                {
                    log_msgbox.Text += "\nError: " + ex + "\n\nAre you ADMIN?\n";
                    return;
                }
                mem_freed += (p.WorkingSet64 + p.VirtualMemorySize64);
            }
            double inter = mem_freed / 1024 / 1024;
            if (inter >= 1024)
                log_msgbox.Text += "\nMemory cleaned: " + Math.Round(inter / 1024, 2) + " GB\n";
            else
                log_msgbox.Text += "\nMemory cleaned: " + Math.Round(inter, 2) + " MB\n";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flushCounters(true);
        }
    }
}

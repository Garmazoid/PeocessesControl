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
using static System.Net.Mime.MediaTypeNames;

namespace DZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Process[] proccesses;

        private void Form1_Load(object sender, EventArgs e) // System.diagnostics.Process(___)
        {
            proccesses = Process.GetProcesses();

            for (int i = 0; i <  proccesses.Length; i++)
            {
                string line = proccesses[i].ToString();
                line = line.Substring(28);
                line = line.Substring(0, line.Length - 1);

                ProcessList.Items.Add(line);
            }

            Info.Text = "";
        }

        private void ShowInfo_Click(object sender, EventArgs e)
        {
            string text = "";
            try
            {
                string selectIndex = ProcessList.Items[ProcessList.SelectedIndex].ToString(); // имя выбранного процесса
                Process[] selectProc = Process.GetProcessesByName(selectIndex); // список одинаковых процессов

                text += "Name: " + selectIndex + '\n';
                text += "Count: " + selectProc.Length + '\n';
                try { text += "Processor Time: " + selectProc[0].TotalProcessorTime + '\n'; }
                catch { text += "Processor Time: Ошибка! Отказано в доступе\n"; }
                try { text += "Start Time: " + selectProc[0].StartTime + '\n'; }
                catch { text += "Start Time: Ошибка! Отказано в доступе\n"; }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Info.Text = text;
        }

        private void CloseProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string selectIndex = ProcessList.Items[ProcessList.SelectedIndex].ToString(); // имя выбранного процесса
                Process[] selectProc = Process.GetProcessesByName(selectIndex); // список одинаковых процессов

                for (int i = 0; i < selectProc.Length; i++)
                {
                    selectProc[i].Kill();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void StartNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void StartCalc_Click(object sender, EventArgs e)
        {
            Process.Start("win32calc.exe");
        }

        private void StartPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void StartMyApp_Click(object sender, EventArgs e)
        {
            Process.Start("DZ.exe");
        }
    }
}

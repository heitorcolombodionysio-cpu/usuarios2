using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");

        }

        private void btn_notepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btn_pc_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe");
        }
    }
}

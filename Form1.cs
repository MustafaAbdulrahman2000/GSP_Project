using System.Runtime.InteropServices;

namespace GSP_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home1.Show();
            home1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            sequence21.Hide();
            sequence31.Hide();
            sequence41.Hide();
            about1.Hide();
            home1.Hide();

            sequence11.Show();
            sequence11.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sequence11.Hide();
            sequence31.Hide();
            sequence41.Hide();
            about1.Hide();
            home1.Hide();

            sequence21.Show();
            sequence21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sequence11.Hide();
            sequence21.Hide();
            sequence41.Hide();
            about1.Hide();
            home1.Hide();

            sequence31.Show();
            sequence31.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sequence11.Hide();
            sequence21.Hide();
            sequence31.Hide();
            about1.Hide();
            home1.Hide();

            sequence41.Show();
            sequence41.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sequence11.Hide();
            sequence21.Hide();
            sequence31.Hide();
            sequence41.Hide();
            home1.Hide();

            about1.Show();
            about1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sequence11.Hide();
            sequence21.Hide();
            sequence31.Hide();
            sequence41.Hide();
            about1.Hide();

            home1.Show();
            home1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
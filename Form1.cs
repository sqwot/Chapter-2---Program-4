using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chapter_2___Program_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ChangeTest_Click(object sender, EventArgs e) {
            if(enableCheckBox.Checked) {
                if (labelToChange.Text == "Left") {
                    labelToChange.Text = "Right";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                } else {
                    labelToChange.Text = "Left";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
            }else {
                labelToChange.Text = "Text changing is disabled";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            labelToChange.Text = "Mouse_Down";
        }
    }
}

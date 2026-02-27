using System;
using System.Drawing;
using System.Windows.Forms;

namespace _1._1
{
    public partial class Form1 : Form
    {
        private TextBox[] txtInput = new TextBox[5];
        private ListBox listBefore, listAfter;

        public Form1()
        {
            this.Text = "Задача 5: Сдвиг вправо";
            this.Size = new Size(400, 350);

            Label lbl = new Label() { Text = "Введите 5 чисел:", Location = new Point(20, 20), Size = new Size(150, 20) };

            for (int i = 0; i < 5; i++)
            {
                txtInput[i] = new TextBox() { Location = new Point(20 + i * 70, 50), Size = new Size(60, 20) };
                this.Controls.Add(txtInput[i]);
            }

            Button btnShift = new Button() { Text = "Сдвинуть", Location = new Point(20, 90), Size = new Size(100, 30) };
            btnShift.Click += BtnShift_Click;

            listBefore = new ListBox() { Location = new Point(20, 130), Size = new Size(340, 60) };
            listAfter = new ListBox() { Location = new Point(20, 210), Size = new Size(340, 60) };

            this.Controls.Add(lbl);
            this.Controls.Add(btnShift);
            this.Controls.Add(listBefore);
            this.Controls.Add(listAfter);
        }

        private void BtnShift_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5];
            listBefore.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(txtInput[i].Text, out arr[i]))
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }
                listBefore.Items.Add($"a[{i}] = {arr[i]}");
            }

            // Сдвиг вправо
            int last = arr[4];
            for (int i = 4; i > 0; i--)
                arr[i] = arr[i - 1];
            arr[0] = last;

            listAfter.Items.Clear();
            for (int i = 0; i < 5; i++)
                listAfter.Items.Add($"a[{i}] = {arr[i]}");
        }
    }
}
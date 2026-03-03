using System.Drawing;
using System.Windows.Forms;

namespace Forms5
{
    partial class Form1
    {
        private TextBox[] txtInput = new TextBox[5];
        private ListBox listBefore;
        private ListBox listAfter;

        private void InitializeComponent()
        {
            this.Text = "Задача 5: Сдвиг элементов";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Заголовок
            Label lbl = new Label();
            lbl.Text = "Введите 5 чисел:";
            lbl.Location = new Point(20, 20);
            lbl.Size = new Size(150, 20);

            // Поле 1
            txtInput[0] = new TextBox();
            txtInput[0].Location = new Point(20, 50);
            txtInput[0].Size = new Size(60, 20);

            // Поле 2
            txtInput[1] = new TextBox();
            txtInput[1].Location = new Point(90, 50);
            txtInput[1].Size = new Size(60, 20);

            // Поле 3
            txtInput[2] = new TextBox();
            txtInput[2].Location = new Point(160, 50);
            txtInput[2].Size = new Size(60, 20);

            // Поле 4
            txtInput[3] = new TextBox();
            txtInput[3].Location = new Point(230, 50);
            txtInput[3].Size = new Size(60, 20);

            // Поле 5
            txtInput[4] = new TextBox();
            txtInput[4].Location = new Point(300, 50);
            txtInput[4].Size = new Size(60, 20);

            // Добавляем поля
            this.Controls.Add(txtInput[0]);
            this.Controls.Add(txtInput[1]);
            this.Controls.Add(txtInput[2]);
            this.Controls.Add(txtInput[3]);
            this.Controls.Add(txtInput[4]);

            // Кнопка
            Button btn = new Button();
            btn.Text = "Сдвиг";
            btn.Location = new Point(150, 90);
            btn.Size = new Size(100, 30);
            btn.Click += reading;

            // Исходный массив
            Label lblBefore = new Label();
            lblBefore.Text = "Исходный:";
            lblBefore.Location = new Point(20, 130);
            lblBefore.Size = new Size(100, 20);

            listBefore = new ListBox();
            listBefore.Location = new Point(20, 150);
            listBefore.Size = new Size(340, 60);

            // После сдвига
            Label lblAfter = new Label();
            lblAfter.Text = "После сдвига:";
            lblAfter.Location = new Point(20, 220);
            lblAfter.Size = new Size(100, 20);

            listAfter = new ListBox();
            listAfter.Location = new Point(20, 240);
            listAfter.Size = new Size(340, 60);

            // Добавляем все
            this.Controls.Add(lbl);
            this.Controls.Add(btn);
            this.Controls.Add(lblBefore);
            this.Controls.Add(listBefore);
            this.Controls.Add(lblAfter);
            this.Controls.Add(listAfter);
        }
    }
}
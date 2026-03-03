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
            this.Size = new Size(400, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9);

            // Заголовок
            Label lblHeader = new Label
            {
                Text = "Введите 5 чисел:",
                Location = new Point(20, 15),
                Size = new Size(150, 25),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            // Поля ввода (5 штук в ряд)
            for (int i = 0; i < 5; i++)
            {
                txtInput[i] = new TextBox
                {
                    Location = new Point(20 + i * 70, 45),
                    Size = new Size(60, 25),
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Arial", 10)
                };
                this.Controls.Add(txtInput[i]);
            }

            // Кнопка сдвига
            Button btnShift = new Button
            {
                Text = "Сдвиг",
                Location = new Point(150, 80),
                Size = new Size(100, 35),
                BackColor = Color.LightGreen,
                Font = new Font("Arial", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnShift.Click += reading;

            // Подпись для исходного массива
            Label lblBefore = new Label
            {
                Text = "Исходный массив:",
                Location = new Point(20, 125),
                Size = new Size(120, 20),
                Font = new Font("Arial", 9, FontStyle.Italic)
            };

            // Список для исходного массива
            listBefore = new ListBox
            {
                Location = new Point(20, 145),
                Size = new Size(340, 70),
                Font = new Font("Courier New", 10)
            };

            // Подпись для массива после сдвига
            Label lblAfter = new Label
            {
                Text = "После сдвига вправо:",
                Location = new Point(20, 225),
                Size = new Size(150, 20),
                Font = new Font("Arial", 9, FontStyle.Italic)
            };

            // Список для массива после сдвига
            listAfter = new ListBox
            {
                Location = new Point(20, 245),
                Size = new Size(340, 70),
                Font = new Font("Courier New", 10)
            };

            // Добавляем все элементы на форму
            this.Controls.AddRange(new Control[] {
                lblHeader,
                btnShift,
                lblBefore, listBefore,
                lblAfter, listAfter
            });
        }
    }
}
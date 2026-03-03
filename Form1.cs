namespace Forms5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reading(object sender, EventArgs e)
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(txtInput[i].Text, out arr[i]))
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }
            }

            listBefore.Items.Clear();
            for (int i = 0; i < 5; i++)
                listBefore.Items.Add($"a[{i}] = {arr[i]}");

           
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
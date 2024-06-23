using Microsoft.VisualBasic.ApplicationServices;

namespace Фон_шрифт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"E:\Всё что можно - здесь\Программирование\Фон_шрифт\Фон_шрифт\Backgrounds\Зима.jpg");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"E:\Всё что можно - здесь\Программирование\Фон_шрифт\Фон_шрифт\Backgrounds\Закат.jpg");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"E:\Всё что можно - здесь\Программирование\Фон_шрифт\Фон_шрифт\Backgrounds\Водяные лилии.jpg");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"E:\Всё что можно - здесь\Программирование\Фон_шрифт\Фон_шрифт\Backgrounds\Голубые холмы.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Внешний вид")
                this.Text = "Внешний вид";
            if (comboBox1.Text == "Образ")
                this.Text = "Образ";
            if (comboBox1.Text == "Стиль")
                this.Text = "Стиль";
            if (comboBox1.Text == "Мода")
                this.Text = "Мода";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Times New Roman")
                this.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            if (listBox1.Text == "Arial")
                this.Font = new Font("Arial", 12, FontStyle.Bold);
            if (listBox1.Text == "Microsoft Sans Serif")
                this.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            Size = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            Size = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
    }
}

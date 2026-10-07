namespace Крестики_нолики
{
	public partial class Form0 : Form
	{
		public Form0()
		{
			InitializeComponent();
		}

		// Режим "Два игрока"
		private void button1_Click(object sender, EventArgs e)
		{
			// Весь этот код на хитровыебанное закрытие формы и открытие новой
			// я спиздил со своего очень старого проекта
			Hide();
			Form1 Form = new Form1();
			Form.ShowDialog();
			this.Close();
		}

		// Режим "Игра с ботом"
		private void button2_Click(object sender, EventArgs e)
		{
			Hide();
			Form2 Form = new Form2();
			Form.ShowDialog();
			this.Close();
		}
	}
}
namespace Крестики_нолики
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Обозначение переменных для игры
		// Я уже забыл нахуя они нужны, но без них все идет по пизде
		bool IsPlayerXTurn = true;
		bool IsPlayerXWin = false;
		bool IsPlayerOWin = false;
		int FreeButtons = 8;

		// Выключение всех кнопок
		void AllButtonsIsDisabled()
		{
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
			button8.Enabled = false;
			button9.Enabled = false;

			// Ради оптимизации кода, я не стал писать 9 раз эту хуйню,
			// а просто заебенил их в отдельную функцию, которая вызывается
			// при выигрыше одного из игроков или при ничье
			if (IsPlayerXWin)
			{
				this.Text = "Крестики-нолики - Два игрока (Крестики победили)";
			}
			else if (IsPlayerOWin)
			{
				this.Text = "Крестики-нолики - Два игрока (Нолики победили)";
			}
			else
			{
				this.Text = "Крестики-нолики - Два игрока (Ничья)";
			}
			button10.Visible = true;
		}

		// Проверка выигрыша
		void CheckWin()
		{
			// Я не ебу как оптимизировать эту функцию (да и наверное никак),
			// поэтому она выглядит как говно, но она работает, а это главное

			// Выигрыш крестиков
			// Проверка по горизонтали (3 шт)
			if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
			{
				button1.BackColor = Color.Green;
				button2.BackColor = Color.Green;
				button3.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}
			else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
			{
				button4.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}
			else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
			{
				button7.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}
			// Проверка по вертикали (3 шт)
			else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
			{
				button1.BackColor = Color.Green;
				button4.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}
			else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
			{
				button2.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}
			else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
			{
				button3.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}
			// Проверка по диагонали (2 шт)
			else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
			{
				button1.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}
			else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
			{
				button3.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerXWin = true;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Крестики победили!");
			}

			// Выигрыш ноликов
			// Проверка по горизонтали (3 шт)
			else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
			{
				button1.BackColor = Color.Green;
				button2.BackColor = Color.Green;
				button3.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}
			else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
			{
				button4.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}
			else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
			{
				button7.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}
			// Проверка по вертикали (3 шт)
			else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
			{
				button1.BackColor = Color.Green;
				button4.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}
			else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
			{
				button2.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}
			else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
			{
				button3.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}
			// Проверка по диагонали (2 шт)
			else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
			{
				button1.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}
			else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
			{
				button3.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerXWin = false;
				IsPlayerOWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Нолики победили!");
			}

			// Ничья
			if (FreeButtons == 0 && !(IsPlayerXWin || IsPlayerOWin))
			{
				button10.Visible = true;
				IsPlayerXWin = false;
				IsPlayerOWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Ничья!");
			}
			else
			{
				FreeButtons -= 1;
			}
		}

		// Кнопки для игрового поля
		private void button1_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button1.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button1.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button1.Enabled = false;
			CheckWin();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button2.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button2.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button2.Enabled = false;
			CheckWin();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button3.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button3.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button3.Enabled = false;
			CheckWin();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button4.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button4.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button4.Enabled = false;
			CheckWin();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button5.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button5.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button5.Enabled = false;
			CheckWin();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button6.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button6.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button6.Enabled = false;
			CheckWin();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button7.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button7.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button7.Enabled = false;
			CheckWin();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button8.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button8.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button8.Enabled = false;
			CheckWin();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (IsPlayerXTurn)
			{
				button9.Text = "X";
				label2.Text = "Ход ноликов";
				IsPlayerXTurn = false;
			}
			else
			{
				button9.Text = "O";
				label2.Text = "Ход крестиков";
				IsPlayerXTurn = true;
			}
			button9.Enabled = false;
			CheckWin();
		}

		// Кнопка "Новая игра". Она просто возвращает все в исходное состояние
		private void button10_Click(object sender, EventArgs e)
		{
			// Очистка текста на кнопках
			button1.Text = "";
			button2.Text = "";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button6.Text = "";
			button7.Text = "";
			button8.Text = "";
			button9.Text = "";

			// Включение всех кнопок
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;

			// Сброс цвета кнопок
			button1.BackColor = Color.FromArgb(253, 253, 253);
			button2.BackColor = Color.FromArgb(253, 253, 253);
			button3.BackColor = Color.FromArgb(253, 253, 253);
			button4.BackColor = Color.FromArgb(253, 253, 253);
			button5.BackColor = Color.FromArgb(253, 253, 253);
			button6.BackColor = Color.FromArgb(253, 253, 253);
			button7.BackColor = Color.FromArgb(253, 253, 253);
			button8.BackColor = Color.FromArgb(253, 253, 253);
			button9.BackColor = Color.FromArgb(253, 253, 253);

			// Сброс переменных
			IsPlayerXTurn = true;
			IsPlayerXWin = false;
			IsPlayerOWin = false;
			FreeButtons = 8;

			// Прочая хуйня
			this.Text = "Крестики-нолики - Два игрока";
			label2.Text = "Ход крестиков";
			button10.Visible = false;
		}

		// Кнопка "Назад"
		private void button11_Click(object sender, EventArgs e)
		{
			Hide();
			Form0 Form = new Form0();
			Form.ShowDialog();
			this.Close();
		}
	}
}
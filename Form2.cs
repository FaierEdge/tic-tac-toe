namespace Крестики_нолики
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		// Обозначение переменных для игры
		// Я забыл нахуя они нужны, но без них все идет по пизде
		bool IsPlayerTurn = true;
		bool IsPlayerWin = false;
		bool IsBotWin = false;
		int FreeButtons = 8;
		Random Rnd = new Random();

		// Каюсь, идею про список спиздил из интернета,
		// но я настолько немощь, что не смог бы это сам сделать
		List<Button> freeButtons = new List<Button>();

		// Выключение всех кнопок
		void AllButtonsIsDisabled()
		{
			// Ради оптимизации кода, я не стал писать 9 раз эту хуйню,
			// а просто заебенил их в отдельную функцию, которая вызывается
			// при выигрыше игрока, бота или при ничье
			
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
			button8.Enabled = false;
			button9.Enabled = false;

			button10.Visible = true;
			
			if (IsPlayerWin) this.Text = "Крестики-нолики - Игра с ботом (Вы победили)";
			else if (IsBotWin) this.Text = "Крестики-нолики - Игра с ботом (Бот победил)";
			else this.Text = "Крестики-нолики - Игра с ботом (Ничья)";
		}

		// Включение только пустых кнопок (это для бота надо)
		void EnableEmptyButtons()
		{
			if (button1.Text == "") button1.Enabled = true;
			if (button2.Text == "") button2.Enabled = true;
			if (button3.Text == "") button3.Enabled = true;
			if (button4.Text == "") button4.Enabled = true;
			if (button5.Text == "") button5.Enabled = true;
			if (button6.Text == "") button6.Enabled = true;
			if (button7.Text == "") button7.Enabled = true;
			if (button8.Text == "") button8.Enabled = true;
			if (button9.Text == "") button9.Enabled = true;
		}
		
		// Обновление списка свободных кнопок (тоже для бота)
		void UpdateFreeButtons()
		{
			freeButtons.Clear();
			if (button1.Text == "") freeButtons.Add(button1);
			if (button2.Text == "") freeButtons.Add(button2);
			if (button3.Text == "") freeButtons.Add(button3);
			if (button4.Text == "") freeButtons.Add(button4);
			if (button5.Text == "") freeButtons.Add(button5);
			if (button6.Text == "") freeButtons.Add(button6);
			if (button7.Text == "") freeButtons.Add(button7);
			if (button8.Text == "") freeButtons.Add(button8);
			if (button9.Text == "") freeButtons.Add(button9);
		}

		// Ход бота (вот именно с этим я больше всего надрочился)
		void BotTurn()
		{
			IsPlayerTurn = false;
			System.Threading.Thread.Sleep(100);
			label2.Text = "Ход бота";
			System.Threading.Thread.Sleep(100);
			if (!IsPlayerTurn && !IsPlayerWin && !IsBotWin)
			{
				UpdateFreeButtons();

				if (freeButtons.Count > 0)
				{
					// Бот рандомно выбирает свободную клетку и ходит туда
					int RandomIndex = Rnd.Next(freeButtons.Count);
					Button SelectedButton = freeButtons[RandomIndex];
					SelectedButton.Text = "O";
					SelectedButton.Enabled = false;
					CheckWin();

					// Если игра не окончена, ход передаётся игроку
					if (!IsPlayerWin && !IsBotWin)
					{
						IsPlayerTurn = true;
						label2.Text = "Ход игрока";
						EnableEmptyButtons();
					}
				}
			}
			System.Threading.Thread.Sleep(100);
		}

		// Проверка выигрыша
		// Я не ебу как оптимизировать эту функцию (да и наверное никак),
		// поэтому она выглядит как говно, но она работает, а это главное
		void CheckWin()
		{
			// Выигрыш крестиков (игрока)
			// Проверка по горизонтали (3 шт)
			if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
			{
				button1.BackColor = Color.Green;
				button2.BackColor = Color.Green;
				button3.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}
			else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
			{
				button4.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}
			else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
			{
				button7.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}
			// Проверка по вертикали (3 шт)
			else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
			{
				button1.BackColor = Color.Green;
				button4.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}
			else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
			{
				button2.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}
			else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
			{
				button3.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}
			// Проверка по диагонали (2 шт)
			else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
			{
				button1.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}
			else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
			{
				button3.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerWin = true;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Вы победили!");
			}

			// Выигрыш ноликов (бота)
			// Проверка по горизонтали (3 шт)
			else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
			{
				button1.BackColor = Color.Green;
				button2.BackColor = Color.Green;
				button3.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}
			else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
			{
				button4.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}
			else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
			{
				button7.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}
			// Проверка по вертикали (3 шт)
			else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
			{
				button1.BackColor = Color.Green;
				button4.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}
			else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
			{
				button2.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button8.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}
			else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
			{
				button3.BackColor = Color.Green;
				button6.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}
			// Проверка по диагонали (2 шт)
			else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
			{
				button1.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button9.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}
			else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
			{
				button3.BackColor = Color.Green;
				button5.BackColor = Color.Green;
				button7.BackColor = Color.Green;
				IsPlayerWin = false;
				IsBotWin = true;
				AllButtonsIsDisabled();
				MessageBox.Show("Бот победил!");
			}

			// Ничья
			if (FreeButtons == 0 && !(IsPlayerWin || IsBotWin))
			{
				button10.Visible = true;
				IsPlayerWin = false;
				IsBotWin = false;
				AllButtonsIsDisabled();
				MessageBox.Show("Ничья!");
			}
			else
			{
				FreeButtons -= 1;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button1.Text == "")
			{
				button1.Text = "X";
				button1.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button2.Text == "")
			{
				button2.Text = "X";
				button2.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button3.Text == "")
			{
				button3.Text = "X";
				button3.Enabled = false;
				CheckWin();

				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button4.Text == "")
			{
				button4.Text = "X";
				button4.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button5.Text == "")
			{
				button5.Text = "X";
				button5.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button6.Text == "")
			{
				button6.Text = "X";
				button6.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button7.Text == "")
			{
				button7.Text = "X";
				button7.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button8.Text == "")
			{
				button8.Text = "X";
				button8.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (IsPlayerTurn && !IsPlayerWin && !IsBotWin && button9.Text == "")
			{
				button9.Text = "X";
				button9.Enabled = false;
				CheckWin();
				if (!IsPlayerWin && !IsBotWin)
				{
					IsPlayerTurn = false;
					label2.Text = "Ход бота";
					BotTurn();
				}
			}
		}

		// Кнопка "Новая игра"
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
            IsPlayerTurn = true;
            IsPlayerWin = false;
			IsBotWin = false;
			FreeButtons = 8;

			// Прочая хуйня
			this.Text = "Крестики-нолики - Игра с ботом";
			label2.Text = "Ход крестиков";
			button10.Visible = false;
			UpdateFreeButtons();
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
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Настройка ComboBox для выбора языка (без дублирования)
            LanguageChoice.Items.Clear(); // Очищаем, если были дубли
            LanguageChoice.Items.Add("Русский");
            LanguageChoice.Items.Add("Английский");
            LanguageChoice.SelectedIndex = 0; // По умолчанию русский

            // Настройка ComboBox для выбора действия
            SelectEncDec.Items.Clear();
            SelectEncDec.Items.Add("Шифровать");
            SelectEncDec.Items.Add("Дешифровать");
            SelectEncDec.SelectedIndex = 0; // По умолчанию шифрование

            // Настройка NumericUpDown для сдвига
            numericUpDownShift.Minimum = 1;
            numericUpDownShift.Maximum = 33; // Для русского (по умолчанию)
            numericUpDownShift.Value = 3;    // Классический сдвиг Цезаря

            // Обработчик изменения языка
            LanguageChoice.SelectedIndexChanged += (sender, e) =>
            {
                // Устанавливаем максимальный сдвиг в зависимости от языка
                numericUpDownShift.Maximum = (LanguageChoice.SelectedIndex == 0) ? 33 : 26;

                // Если текущее значение сдвига больше нового максимума, исправляем
                if (numericUpDownShift.Value > numericUpDownShift.Maximum)
                {
                    numericUpDownShift.Value = numericUpDownShift.Maximum;
                }
            };

            // Обработчик кнопки "Выполнить"
            buttonLaunch.Click += ButtonLaunch_Click;
        }

        private void ButtonLaunch_Click(object sender, EventArgs e)
        {
            // Получаем текст из поля ввода
            string text = textBoxInput.Text;

            // Проверка на пустой ввод
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите текст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка, что язык выбран (SelectedIndex = -1 означает отсутствие выбора)
            if (LanguageChoice.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите язык!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем значение сдвига из NumericUpDown
            int shift = (int)numericUpDownShift.Value;

            // Определяем язык: 0 - Русский, 1 - Английский
            bool isRussian = (LanguageChoice.SelectedIndex == 0);

            // Определяем режим: 0 - Шифровать, 1 - Дешифровать
            bool isEncrypt = (SelectEncDec.SelectedIndex == 0);

            // Вызываем функцию шифрования/дешифрования
            string result = CaesarCipher(text, shift, isRussian, isEncrypt);

            // Выводим результат в поле вывода
            textBoxOutput.Text = result;
        }

        private string CaesarCipher(string text, int shift, bool isRussian, bool isEncrypt)
        {
            // Выбираем алфавит в зависимости от языка
            string alphabet = isRussian ?
                "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" : // Русский алфавит
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ";         // Английский алфавит

            // Создаем полный алфавит: строчные + заглавные буквы для регистронезависимой обработки
            alphabet = alphabet.ToLower() + alphabet;

            // Если режим дешифровки, инвертируем сдвиг
            shift = isEncrypt ? shift : -shift;

            // Создаем массив для хранения результата
            char[] result = new char[text.Length];

            // Обрабатываем каждый символ входного текста
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                // Ищем индекс символа в алфавите (в верхнем регистре)
                int index = alphabet.IndexOf(char.ToUpper(c));

                if (index >= 0)
                {
                    // Вычисляем новый индекс с учетом сдвига
                    int newIndex = (index + shift) % alphabet.Length;

                    // Корректируем индекс, если он отрицательный (для дешифровки)
                    if (newIndex < 0) newIndex += alphabet.Length;

                    // Сохраняем символ, учитывая исходный регистр
                    result[i] = char.IsLower(c) ?
                        char.ToLower(alphabet[newIndex]) :  // Сохраняем строчную букву
                        alphabet[newIndex];                 // Сохраняем заглавную букву
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string text = System.IO.File.ReadAllText(filePath);
                    textBoxInput.Text = text;
                }
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(filePath, textBoxOutput.Text);
                }
            }
        }
    }
}
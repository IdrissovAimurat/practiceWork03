using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            //task9();
            //task10();
            //task11();
            //task12();
        }
        /// <summary>
        /// 2. Дан текст. Подсчитать общее число вхождений в него символов "+" и "–".
        /// </summary>
        static void task2()
        {
            Console.WriteLine("Введите строку с символами и для её завершения введите точку '.'");

            int plusCount = 0;
            int minusCount = 0;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;
                for (int i = 0; i < str.Length; i++)
                {
                    //если нужно с нижним регистров и с заглавной буквой
                    if (str[i] == '+')
                    {
                        plusCount++;
                    }
                    if (str[i] == '-')
                    {
                        minusCount++;
                    }
                }
            }
            Console.WriteLine("Количество '+' в тексте: " + plusCount);
            Console.WriteLine("Количество '-' в тексте: " + minusCount);

        }
        /// <summary>
        /// 3.  Дан текст. Определить, сколько в нем предложений.
        /// </summary>
        static void task3()
        {
            //т.к. предложения заканчиваются на - ';' ,'.', '!', '?' - то соответсвенно код будет выглядеть вот так вот:
            Console.WriteLine("Введите предложения и для её завершения введите '@exit'");

            int totalSentenceCount = 0;

            while (true)
            {
                string str = Console.ReadLine();
                char[] sentenceSeparators = { '.', '!', '?', ';' };

                if (str == "!exit!")
                    break;

                int sentenceCount = str.Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries).Length;

                totalSentenceCount += sentenceCount; 
            }

            Console.WriteLine("Количество предложений в тексте: " + totalSentenceCount);
        }
        /// <summary>
        /// 4.  Дано предложение. Определить, каких букв в нем больше: м или н.
        /// </summary>
        static void task4()
        {
            Console.WriteLine("Введите строку и для её завершения введите '.'");

            int totalMCount = 0;
            int totalNCount = 0;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;

                int mCount = str.Count(c => c == 'м' || c == 'М');
                int nCount = str.Count(c => c == 'н' || c == 'Н');

                totalMCount += mCount;
                totalNCount += nCount;

                if (mCount > nCount)
                {
                    Console.WriteLine("Букв 'м' больше.");
                }
                else if (nCount > mCount)
                {
                    Console.WriteLine("Букв 'н' больше.");
                }
                else
                {
                    Console.WriteLine("Букв 'м' и 'н' встречаются одинаковое количество раз.");
                }
            }

            Console.WriteLine("Количество букв 'м' в тексте: " + totalMCount);
            Console.WriteLine("Количество букв 'н' в тексте: " + totalNCount);
        }
        /// <summary>
        /// 5. Дано предложение, в котором имеются буквы с и Т. Определить, какая из них встречается позже (при просмотре слова слева направо). Если таких букв несколько, то должны учитываться последние из них. Оператор цикла с условием не использовать.
        /// </summary>
        static void task5()
        {
            Console.WriteLine("Введите строку и для её завершения введите '.'");

            int totalCIndex = -1; // Индекс последней 'с'
            int totalTIndex = -1; // Индекс последней 'Т'

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;

                int indexC = str.LastIndexOf('с');
                int indexT = str.LastIndexOf('Т');

                if (indexC > totalCIndex)
                {
                    totalCIndex = indexC;
                }

                if (indexT > totalTIndex)
                {
                    totalTIndex = indexT;
                }
            }

            if (totalCIndex > totalTIndex)
            {
                Console.WriteLine("Буква 'с' встречается позже.");
            }
            else if (totalTIndex > totalCIndex)
            {
                Console.WriteLine("Буква 'Т' встречается позже.");
            }
            else
            {
                Console.WriteLine("Буквы 'с' и 'Т' встречаются в одной и той же позиции.");
            }

        }
        /// <summary>
        /// 6. Дано предложение. Определить, есть ли буква а в нем.
        /// В случае положительного ответа найти также порядковый номер первой из них
        /// </summary>
        static void task6()
        {
            Console.WriteLine("Введите предложение и для завершения введите '.'");

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;

                bool containsA = str.Contains('а') || str.Contains('А');

                if (containsA)
                {
                    int indexA = str.IndexOf('а') + 1;
                    Console.WriteLine("В предложении есть буква 'а'. Порядковый номер: " + indexA);
                }
                else
                {
                    Console.WriteLine("В предложении нет буквы 'а'.");
                }
            }
        }
        /// <summary>
        /// 7.  Дано предложение. Все буквы е в нем заменить буквой и.
        /// </summary>
        static void task7()
        {
            Console.WriteLine("Введите предложение и для завершения введите '.'");

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;

                string replacedStr = str.Replace('е', 'и').Replace('Е', 'И');
                Console.WriteLine("Измененное предложение: " + replacedStr);
            }
        }
        /// <summary>
        /// 8. Дано предложение. Все его символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой а.
        /// </summary>
        static void task8() 
        {
            Console.WriteLine("Введите предложение и для завершения введите '.'");

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                    break;

                char[] charArray = str.ToCharArray();

                for (int i = 2; i < charArray.Length; i += 3)
                {
                    charArray[i] = 'а';
                }

                string replacedStr = new string(charArray);
                Console.WriteLine("Измененное предложение: " + replacedStr);
            }

        }
        /// <summary>
        /// 9. Дано слово. Поменять местами его вторую и пятую буквы
        /// </summary>
        static void task9()
        {
            Console.WriteLine("Введите слово и для завершения введите '.'");

            while (true)
            {
                string word = Console.ReadLine();

                if (word == ".")
                    break;

                if (word.Length >= 5)
                {
                    char[] charArray = word.ToCharArray();
                    char temp = charArray[1]; // Вторая буква
                    charArray[1] = charArray[4]; // Пятая буква
                    charArray[4] = temp;

                    string swappedWord = new string(charArray);
                    Console.WriteLine("Слово после замены: " + swappedWord);
                }
                else
                {
                    Console.WriteLine("Слово слишком короткое для замены.");
                }
            }

        }
        /// <summary>
        /// 10. Дано слово.
        /// а) Удалить из него третью букву.
        /// б) Удалить из него k-ю букву.
        /// </summary>
        static void task10()
        {
            Console.WriteLine("Введите слово и для завершения введите '.'");
            while (true)
            {
                string word = Console.ReadLine();

                if (word == ".")
                    break;

                Console.WriteLine("Введите номер буквы, которую хотите удалить (a) или (б): ");
                string input = Console.ReadLine();

                if (input == "a")
                {
                    if (word.Length >= 3)
                    {
                        string removedThirdLetter = word.Remove(2, 1);
                        Console.WriteLine("Слово после удаления третьей буквы: " + removedThirdLetter);
                    }
                    else
                    {
                        Console.WriteLine("Слово слишком короткое для удаления третьей буквы.");
                    }
                }
                else if (input == "б")
                {
                    Console.WriteLine("Введите номер буквы (1, 2, 3, и так далее): ");
                    int k = int.Parse(Console.ReadLine());

                    if (k >= 1 && k <= word.Length)
                    {
                        string removedKthLetter = word.Remove(k - 1, 1);
                        Console.WriteLine("Слово после удаления " + k + "-й буквы: " + removedKthLetter);
                    }
                    else
                    {
                        Console.WriteLine("Введен недопустимый номер буквы.");
                    }
                }
                else
                {
                    Console.WriteLine("Введите 'a' для удаления третьей буквы или 'б' для удаления k-й буквы.");
                }
            }
        }
        /// <summary>
        /// 11. Дан текст. Определить количество цифр в нем.
        /// </summary>
        static void task11()
        {
            Console.WriteLine("Введите текст и для завершения введите '.'");
            while (true)
            {
                string text = Console.ReadLine();

                if (text == ".")
                    break;

                int digitCount = 0;
                foreach (char c in text)
                {
                    if (char.IsDigit(c))
                    {
                        digitCount++;
                    }
                }

                Console.WriteLine("Количество цифр в тексте: " + digitCount);
            }

        }
        /// <summary>
        /// 12. Дан текст. Найти сумму всех имеющихся в нем чисел
        /// </summary>
        static void task12()
        {
            Console.WriteLine("Введите текст и для завершения введите '.'");
            while (true)
            {
                string text = Console.ReadLine();

                if (text == ".")
                    break;

                int sum = 0;
                string[] words = text.Split(' ');

                foreach (string word in words)
                {
                    if (int.TryParse(word, out int number))
                    {
                        sum += number;
                    }
                }

                Console.WriteLine("Сумма всех чисел в тексте: " + sum);
            }
        }
    }
}

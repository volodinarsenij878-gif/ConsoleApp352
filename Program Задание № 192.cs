using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program192
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Тип кузова (1—Седан, 2—Хэтчбек, 3—Универсал, 4—Купе, 5—Внедорожник): ");
            if (!int.TryParse(Console.ReadLine(), out int body) || body < 1 || body > 5)
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string capacity, layout;
            switch (body)
            {
                case 1: // Седан
                    capacity = "4–5 мест, багажник отделён от салона.";
                    layout = "Классическая трёхобъёмная компоновка: мотор, салон, багажник.";
                    break;
                case 2: // Хэтчбек
                    capacity = "4–5 мест, увеличенный проём багажника, складывающиеся сиденья.";
                    layout = "Двухобъёмная: салон и багажник объединены, задняя дверь до бампера.";
                    break;
                case 3: // Универсал
                    capacity = "5–7 мест, большой багажный отсек, возможна длинная база.";
                    layout = "Удлинённый двухобъёмный кузов, вертикальная задняя дверь, высокая крыша.";
                    break;
                case 4: // Купе
                    capacity = "2–4 места (чаще 2+2), низкий силуэт, спортивный стиль.";
                    layout = "Компактный двухдверный кузов, акцент на динамику и внешний вид.";
                    break;
                case 5: // Внедорожник
                    capacity = "5–7 мест, высокий клиренс, вместительный салон и багажник.";
                    layout = "Рамная или несущая конструкция, полный привод, вертикальная посадка.";
                    break;
                default: return;
            }
            Console.WriteLine($"Вместимость: {capacity}\nКомпоновка: {layout}");
        }
    }
}

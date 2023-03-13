/*
 * Создайте класс Person с полями name и age
 * Реализуйте конструкторы, свойства и метод
 * который выводит информацию о человеке в консоль
 * Создайте массив из трех объектов класса Person
 * и выведите информацию о каждом человеке в консоль
 */

using System;

namespace Person
{
    class Person
    {
        //поля класса
        public string Name { get; set; }
        public int Age { get; set; }

        public string[] Hobbies { get; set; }

        //конструктор класса
        public Person(string name, int age, string[] hobbies)
        {
            this.Name = name;
            this.Age = age;
            this.Hobbies = hobbies;
        }

        //метод класса
        public void Output()
        {
            string hobbiesList = string.Join(", ", Hobbies);
            Console.WriteLine($"Меня зовут {Name}, мне {Age} лет, мои хобби - это {hobbiesList}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //создание массива объектов класса Person
            Person[] people = new Person[3];
            people[0] = new Person("Адам", 12, new string[] { "драться" });
            people[1] = new Person("Эллейн", 16, new string[] { "петь" });
            people[2] = new Person("Ричард", 13, new string[] { "пить чай" });

            //вывод информации о каждом человеке в консоль
            foreach (Person person in people)
            {
                person.Output();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Account<T>
    {
        private T num;
        private string name;
        private int balance;
        public Account()

        {
            if (num != null && num.GetType() == balance.GetType())//Сравнить тип переменной num. При создании экземпляра класса вывести на экран тип номера - числовой
            { Console.WriteLine("Числовой номер"); }
            //else if (num.GetType() == name.GetType()) - При определении num как строки, num == null, исключение
            //{ Console.WriteLine("Строковый номер"); }
        }
        private T Num
        {
            get { return num; }
            set
            {
                num = value;
            }
        }
        private string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        private int Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }
        }
        public void SetInfo()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите состояние баланса");
            Balance = Convert.ToInt32(Console.ReadLine());
        }
        public string ShowInfo()
        {
            return $"Номер счета: {Num}, Имя владельца: {Name}, Баланс: {Balance}";
        }
    }
}

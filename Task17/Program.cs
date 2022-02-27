using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<string> account1 = new Account<string>();
            Console.WriteLine("Введите номер счета, баланс,ФИО:");
            account1.НазначитьЗначения(Console.ReadLine(),Convert.ToDouble(Console.ReadLine()),Console.ReadLine());
            account1.ВыводДанных();
            Account<int> account2 = new Account<int>();
            Console.WriteLine("\nВведите номер счета, баланс,ФИО");
            account2.НазначитьЗначения(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            account2.ВыводДанных();
            Console.ReadKey();
        }

        class Account<T>
        { 
            private T НомерСчета { get; set;}
            private double Баланс { get; set;}
            private string ФИО { get; set;}

            public void НазначитьЗначения (T НомерСчета, double Баланс, string ФИО)
            {
                this.НомерСчета = НомерСчета;
                this.Баланс = Баланс;
                this.ФИО = ФИО;
            }
           
            public void ВыводДанных()
            {
                Console.WriteLine("Номер счета: {0}", НомерСчета);
                Console.WriteLine("Баланс: {0}", Баланс);
                Console.WriteLine("ФИО: {0}", ФИО);
            }

        }

    }
}

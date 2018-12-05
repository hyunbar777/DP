using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "ON";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            o.State = "OFF";
            o.Show();

            o.SetMemento(c.Memento);
            o.Show();

            Console.ReadKey();

        }
    }
}

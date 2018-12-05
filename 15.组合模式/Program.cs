using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成树根root，根上长出两叶leafA和leafB
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            //根上 长出分支Composite X，分支上也有两叶leafXA和leafXB
            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);

            //Composite X再长出分支Composite XY，分支上也有两只leafXYA和leafXYB
            Composite comp2 = new Composite("Composite XY");
            comp2.Add(new Leaf("Leaf XYA"));
            comp2.Add(new Leaf("Leaf XYB"));

            comp.Add(comp2);

            //根上又长出两叶LeafC和LeafD
            root.Add(new Leaf("Leaf C"));
            //leafD 没长好 被吃了
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);

            Console.ReadKey();
        }
    }
}

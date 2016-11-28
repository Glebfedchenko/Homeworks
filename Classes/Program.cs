using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            ProductOp.MkEx();
            ProductOp.ProductList();

            while (ProductOp.GetId() != ProductOp.IdsLength() + 1)
            {
                ProductOp.CheckId();

                if (ProductOp.GetId() != ProductOp.IdsLength() + 1)
                {
                    i++;
                    ProductOp.CheckAmount();
                }

                ProductOp.AddToList(i);
            }

            ProductOp.OutPutCheck(i);

            Console.ReadKey();
        }
    }
}

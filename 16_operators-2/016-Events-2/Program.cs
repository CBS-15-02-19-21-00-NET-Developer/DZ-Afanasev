using System;

namespace _016_Events_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Block block1 = new Block(1, 2, 3, 4);
            //Block block2 = new Block(10, 20, 30, 40);

            Block block1 = new Block(1, 2, 3, 4);
            Block block2 = new Block(1, 2, 3, 4);


            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());

            Console.WriteLine($"Равенство блоков 1 и 2: {block1.Equals(block2)}");

        }
    }

    class Block
    {
        int side1, side2, side3, side4;

        public Block (int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override bool Equals(object obj)
        {
            Block p = (Block)obj;
            return ((side1==p.side1) && (side2==p.side2) && (side3 == p.side3) && (side4 == p.side4));
        }

        public override string ToString()
        {
            return "Поля блока: " + side1 +" " + side2 + " " + side3 + " " + side4 + " ";
        }


    }
}

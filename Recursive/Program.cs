using System;


namespace Recursive
{
    class Program
    {
        static int[] weigths = new int[]{2,5,6,2,4,7};

        static void Evaluate(bool[] subset)
        {
            var delta = 0;
            for (var i = 0; i < subset.Length; i++)
                if (subset[i]) delta += weigths[i];
                else delta -= weigths[i];
            foreach (var e in subset)
                Console.Write(e ? 1 : 0);
            Console.Write(" ");
            if (delta == 0)
                Console.Write(" OK");
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            Makesubsets(new bool[weigths.Length], 0);
        }

        static void Makesubsets(bool[] subset,int position)
        {
            if (position==subset.Length)
            {
                Evaluate(subset);
                return;
                

            }
            subset[position] = false;
            Makesubsets(subset, position + 1);
            subset[position] = true;
            Makesubsets(subset, position + 1);
        }
    }
}

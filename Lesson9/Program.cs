using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Yarin";
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[name.Length-1]);
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //Console.WriteLine(name.ToLower());//
            // Console.WriteLine(name.ToUpper());

            //Console.WriteLine(index);
            int index = name.IndexOf('a');
            index = name.IndexOf("ari");
            Console.WriteLine(index);
        }
    }
}

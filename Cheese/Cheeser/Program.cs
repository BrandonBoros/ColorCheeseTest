using static System.Net.Mime.MediaTypeNames;

namespace Cheeser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 16; i++)
            {
                Text.Write(i, "cheese");

                if (i == 15)
                {
                    i = 0;
                }
            }
        }
    }
}
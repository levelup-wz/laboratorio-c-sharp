using System.Text;
using System.Threading.Tasks;

namespace IMPARESde1a100;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i <= 100)
        {
            if (i == 100)
                break;
            Console.WriteLine(i = i + 1);
            i++;

        }
        Console.ReadLine();
    }
}
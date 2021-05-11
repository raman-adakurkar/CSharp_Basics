using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClassProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Person raman = new Person();
            raman.firstname = "Raman";
            raman.lastname = "Adakurkar";
            raman.age = 22;

            raman.Introduce();
        }
    }
}

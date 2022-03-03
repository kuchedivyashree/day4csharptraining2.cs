using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class hash
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("d01", "finance");
            ht.Add("d02", "hr");
            ht.Add("d03", "operations");

            if (ht.ContainsValue("marketing"))
            {
                Console.WriteLine(" this department name is already in the list");
            }
            else
            {
                ht.Add("d04", "marketing");

            }
            ICollection Key = ht.Keys;
            foreach(string k in Key)
            {
                Console.WriteLine(k + ":" + ht[k]);

            }
            Console.ReadKey();

        } 
    }
}

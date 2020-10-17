using BauAppFeladat.Model;
using BauAppFeladat.Service;
using System;
using System.Threading.Tasks;

namespace BauAppFeladat
{
    class Program
    {
        public Root data = new Root();

        static async Task Main()
        {
            await Program.getData();
            Program.postData();
            Console.ReadLine();
        }

        public static async Task getData()
        { 
            await DataService.getData();
            Console.WriteLine("resultCode: " + DataService.data.resultCode + "\n" + "message: " + DataService.data.message);
            Console.Write("result: ");
            foreach (var item in DataService.data.result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void postData()
        {
            DataService.postData();
        }        
    }
}

using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            NewToastNotification Window = new NewToastNotification("This is VTC ITS Center Notification. Thank for watching.", 1);

            await Task.Delay(5000);
        }
    }
}

using System;
using System.Net;
using System.Threading;

namespace UriBuilderDemo 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mengambil domain external website lain
            string targetDomain = "career.igdx.id";
            Console.WriteLine("Informasi Domain Eksternal");
            var domainEntry = Dns.GetHostEntry(targetDomain);
            Console.WriteLine("Domain HostName: " + domainEntry.HostName);

            foreach (var ip in domainEntry.AddressList)
            {
                Console.WriteLine("Domain IP: " + ip);
            }

            Console.WriteLine() ;

            //Menggunakan Get Host Addres
            var address = Dns.GetHostAddresses(targetDomain);
            Console.WriteLine("Domain jika menggunakan Get Host Addres : ");
            foreach (var ip in address)
            {
                Console.WriteLine(ip);
            }

            Thread.Sleep(1000);
        }
    }
}

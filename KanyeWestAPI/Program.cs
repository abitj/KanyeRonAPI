using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=0; i<=5; i++)
            {
                KanyeQuote.GetQuote();
                RonQuote.GetQuote();
            }
        }
    }
}

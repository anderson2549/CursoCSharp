using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtension
{
    internal static class Extensions
    {
        public static int[] Peer(this int[] number)
        {
            return number;
        }
        public static bool IsPeer(this int number)
        {
            return (number % 2)==0 ;
        }
        public static string FullName(this Person person, string city)
        {
            return $"{person.Id,-20} | { person.Name,20 }|{city,20}|";
        }
    }
}

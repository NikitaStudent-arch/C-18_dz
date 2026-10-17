using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_18_dz
{
    public class RegularExpressions
    {
        public bool MobilePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\+\d{1,2}-\d{3}-\d{2}-\d{2}-\d{3}$");
        }
        public bool UkrainePassport(string number)
        {
            return Regex.IsMatch(number, @"^\d{9}$");
        }
        public bool FiveDigitNumber(string number)
        {
            return Regex.IsMatch(number, @"^1031[1-9]|103[2-9][0-9]|10[4-9][0-9][0-9]|1[1-9][0-9][0-9][0-9]|[2-7][0-9][0-9][0-9][0-9]|8[0-8][0-9][0-9][0-9]|89[0-5][0-9][0-9]|896[0-3][0-9]|8964[0-5]$");
        }
        public bool UkrainianLanguage(string text)
        {
            return Regex.IsMatch(text, @"^[А-ЩЬЮЯЄІЇҐ][а-щьюяєіїґ']*(?:-[А-ЩЬЮЯЄІЇҐ][а-щьюяєіїґ']*)?$");
        }
        public bool Time(string time)
        {
            return Regex.IsMatch(time, @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$");
        }
        public bool Number(string number)
        {
            return Regex.IsMatch(number, @"^[+-]?\d+(?:[.,]\d+)?$");
        }
        public bool Date(string date)
        {
            return Regex.IsMatch(date, @"^(?:0[1-9]|[12]\d|3[01])\.(?:0[1-9]|1[0-2])\.(?:19\d{2}|20[01]\d|202[01])$");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RegularExpressions re = new RegularExpressions();
            Console.WriteLine(re.MobilePhoneNumber("+1-111-11-11-111"));
            Console.WriteLine(re.UkrainePassport("000001234"));
            Console.WriteLine(re.FiveDigitNumber("10311"));
            Console.WriteLine(re.UkrainianLanguage("Олексій"));
            Console.WriteLine(re.Time("10:59:36"));
            Console.WriteLine(re.Number("-1"));
            Console.WriteLine(re.Date("01.01.1990"));
        }
    }
}

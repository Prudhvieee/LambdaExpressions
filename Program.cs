using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to lambda!");
            List<Person> listPersonInCity = new List<Person>();
            AddPersonInfo(listPersonInCity);
        }
        public static void AddPersonInfo(List<Person> ListPersonInCity)
        {
            ListPersonInCity.Add(new Person("120", "nikki", "102,himagiri", 23));
            ListPersonInCity.Add(new Person("121", "nikki", "104,himagiri", 20));
            ListPersonInCity.Add(new Person("122", "nikki", "120,himagiri", 29));
            ListPersonInCity.Add(new Person("123", "nikki", "114,himagiri", 34));
        }

    }
}

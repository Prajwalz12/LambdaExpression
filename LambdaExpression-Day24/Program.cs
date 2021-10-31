using System;

namespace LambdaExpression_Day24
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<Person> listPersonInCity = new List<Person>();
                AddRecords(listPersonInCity);
                Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
                CheckingForTeenagerPerson(listPersonInCity);
                AllPersonsAverageAge(listPersonInCity);
                CheckNameExistOrNot(listPersonInCity);
                SkipPersonsLessThan60(listPersonInCity);
                RemoveSpecificPerson(listPersonInCity);
                Console.ReadKey();
            }
        }

            
           
    }
}

using System;

//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


namespace _05.WorkDays
{
    class WorkDays
    {

        public static bool IsHoliday(string date)
        {
            string tmpDate =  date.Substring(0, 5);
            bool isHoliday = false;
            //note the holidays are only in dd-MM format so we don't have to reenter the same date for a different year
            //we can add more holidays; we can try and extract the holidays from the CultureInfo.Calendar property in some way
            string[] holidays = { "25-12", "03-03", "12-04" };

            for(int i = 0; i < holidays.Length; i ++)
            {
                if (tmpDate == holidays[i])
                {
                    isHoliday = true;
                }
            }

            return isHoliday;
        }

        public static int NumberOfWorkDays(DateTime currentDate, DateTime date)
        {
            int countWorkDays = 0;
            DateTime tmpDate = currentDate;
            while (tmpDate != date)//note we include the today date and exclude the chosen day in the count; easily modified for diff cases
            {
                string tmpDateToStr = tmpDate.ToString("dd-MM-yyyy");
                if (tmpDate.DayOfWeek < DayOfWeek.Saturday && tmpDate.DayOfWeek > DayOfWeek.Sunday && !IsHoliday(tmpDateToStr))
                {
                    countWorkDays++;
                }

                tmpDate = tmpDate.AddDays(1);
            }

            return countWorkDays;
        }

        static void Main()
        {
            DateTime currentDate = DateTime.Today;
            Console.WriteLine("Please enter your date in the format dd-MM-yyyy");
            string input = Console.ReadLine();
            DateTime chosenDate = new DateTime();
            chosenDate = DateTime.ParseExact(input, "dd-MM-yyyy", null);
         
            int result = NumberOfWorkDays(currentDate, chosenDate);
            Console.WriteLine("There are {0} work days between today and chosen date", result);
        }
    }
}

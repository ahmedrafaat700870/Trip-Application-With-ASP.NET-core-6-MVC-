using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using Tourest.BL;
using Tourest.BL.HomePage;

namespace Tourest.Controllers
{
    public struct DateTimeSpan
    {
        public int Years { get; }
        public int Months { get; }
        public int Days { get; }
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }
        public int Milliseconds { get; }

        public DateTimeSpan(int years, int months, int days, int hours, int minutes, int seconds, int milliseconds)
        {
            Years = years;
            Months = months;
            Days = days;
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Milliseconds = milliseconds;
        }

        enum Phase { Years, Months, Days, Done }

        public static DateTimeSpan CompareDates(DateTime date1, DateTime date2)
        {
            if (date2 < date1)
            {
                var sub = date1;
                date1 = date2;
                date2 = sub;
            }

            DateTime current = date1;
            int years = 0;
            int months = 0;
            int days = 0;

            Phase phase = Phase.Years;
            DateTimeSpan span = new DateTimeSpan();
            int officialDay = current.Day;

            while (phase != Phase.Done)
            {
                switch (phase)
                {
                    case Phase.Years:
                        if (current.AddYears(years + 1) > date2)
                        {
                            phase = Phase.Months;
                            current = current.AddYears(years);
                        }
                        else
                        {
                            years++;
                        }
                        break;
                    case Phase.Months:
                        if (current.AddMonths(months + 1) > date2)
                        {
                            phase = Phase.Days;
                            current = current.AddMonths(months);
                            if (current.Day < officialDay && officialDay <= DateTime.DaysInMonth(current.Year, current.Month))
                                current = current.AddDays(officialDay - current.Day);
                        }
                        else
                        {
                            months++;
                        }
                        break;
                    case Phase.Days:
                        if (current.AddDays(days + 1) > date2)
                        {
                            current = current.AddDays(days);
                            var timespan = date2 - current;
                            span = new DateTimeSpan(years, months, days, timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
                            phase = Phase.Done;
                        }
                        else
                        {
                            days++;
                        }
                        break;
                }
            }

            return span;
        }
    }

    public class ItemController : Controller
    {
        public ItemController()
        {
            oClsItem = new ClsItem();
            oClsInformation = new ClsInformation();
        }
        private readonly ClsItem oClsItem;
        private readonly ClsInformation oClsInformation;
        public string GetPhone (string phone)
        {
            string Phone = string.Empty;
            string[] Numbers = phone.Substring(1).Split(" ");
            foreach(string number in Numbers)
            {
                Phone += number;
            }
            return Phone;
        }
        public List<string> Date(string date)
        {
            DateTime ComingDate;
            if (!string.IsNullOrEmpty(date))
            {
                ComingDate = DateTime.Parse(date);
            } else
            {
                ComingDate = DateTime.Now;
            }
            DateTime Now =  DateTime.Now;
            var ComparDate = DateTimeSpan.CompareDates(ComingDate, Now);
            List<string> Counter = new List<string>();
            Counter.Add(ComparDate.Years.ToString());
            Counter.Add(ComparDate.Months.ToString());
            Counter.Add(ComparDate.Days.ToString());
            Counter.Add(ComparDate.Hours.ToString());
            return Counter;
        }
        public IActionResult Index(int id ,int optionId)
        {
            var TourDetalis = oClsItem.GetItem(id, optionId);
            var Info = oClsInformation.GetInformation();
            ViewBag.Information  = Info;
            ViewBag.PhoneNumber  = GetPhone(Info.InformationPhone);
        
            ViewBag.Date = Date(TourDetalis.TourtOption.EndDate.ToString());
/*            string Message = "I Wan't To Book Tour";*/
            ViewBag.optionId = optionId; 
            return View(TourDetalis);
        }
    }
}

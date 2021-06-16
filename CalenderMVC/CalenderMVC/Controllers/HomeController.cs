using CalenderMVC.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalenderMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calender()
        {
            var calenderModel = new CalenderModel();
            var startDate = DateTime.Today.AddDays((int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - (int)DateTime.Today.DayOfWeek);
            var endDate = startDate.AddDays(7);
            var numDays = (int)((endDate - startDate).TotalDays);
            List<DateTime> weekDateDay = Enumerable.Range(0, numDays).Select(x => startDate.AddDays(x)).ToList();
            ViewBag.Date = weekDateDay;

            calenderModel = new CalenderModel();
            var calenderModelList = new List<CalenderModel>();
            var SundayList = new List<DayList>();
            var MondayList = new List<DayList>();
            var TuesdayList = new List<DayList>();
            var WednesdayList = new List<DayList>();
            var ThursdayList = new List<DayList>();
            var FridayList = new List<DayList>();
            var SaturdayList = new List<DayList>();

            var dataList = new List<Tuple<DateTime, string>>();
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-13 08:00:00", CultureInfo.CurrentCulture), "Test"));
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-14 09:00:00", CultureInfo.CurrentCulture), "Test1"));
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-15 09:00:00", CultureInfo.CurrentCulture), "Test2"));
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-13 09:00:00", CultureInfo.CurrentCulture), "Tes 3"));
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-15 10:00:00", CultureInfo.CurrentCulture), "Test4"));
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-18 09:00:00", CultureInfo.CurrentCulture), "Test 5"));
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-19 09:00:00", CultureInfo.CurrentCulture), "Test6"));
            dataList.Add(new Tuple<DateTime, string>(Convert.ToDateTime("2021-06-13 08:00:00", CultureInfo.CurrentCulture), "Test7"));

            foreach (var item in dataList)
            {
                var date = item.Item1;
                if (date.DayOfWeek == 0)
                {
                    SundayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2
                    });
                }
                else if ((int)date.DayOfWeek == 1)
                {
                    MondayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2
                    });
                }
                else if ((int)date.DayOfWeek == 2)
                {
                    TuesdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2
                    });
                }
                else if ((int)date.DayOfWeek == 3)
                {
                    WednesdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2
                    });
                }
                else if ((int)date.DayOfWeek == 4)
                {
                    ThursdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2
                    });
                }
                else if ((int)date.DayOfWeek == 5)
                {
                    FridayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2
                    });
                }
                else if ((int)date.DayOfWeek == 6)
                {
                    SaturdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2
                    });
                }
            }
            calenderModel.SundayList = SundayList;
            calenderModel.MondayList = MondayList;
            calenderModel.TuesdayList = TuesdayList;
            calenderModel.WednesdayList = WednesdayList;
            calenderModel.ThursdayList = ThursdayList;
            calenderModel.FridayList = FridayList;
            calenderModel.SaturdayList = SaturdayList;
            calenderModelList.Add(calenderModel);
            int maxValue = 0;
            foreach (var item in calenderModelList)
            {
                if (SundayList.Count > maxValue) { maxValue = SundayList.Count; }
                if (MondayList.Count > maxValue) { maxValue = MondayList.Count; }
                if (TuesdayList.Count > maxValue) { maxValue = TuesdayList.Count; }
                if (WednesdayList.Count > maxValue) { maxValue = WednesdayList.Count; }
                if (ThursdayList.Count > maxValue) { maxValue = ThursdayList.Count; }
                if (FridayList.Count > maxValue) { maxValue = FridayList.Count; }
                if (SaturdayList.Count > maxValue) { maxValue = SaturdayList.Count; }
            }
            calenderModelList[0].maxValue = maxValue;
            return View(calenderModelList);
        }
    }
}
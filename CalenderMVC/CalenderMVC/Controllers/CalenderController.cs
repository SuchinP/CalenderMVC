using CalenderMVC.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalenderMVC.Controllers
{
    public class CalenderController : Controller
    {
        // GET: Calender
        public ActionResult Index()
        {
            var startDate = DateTime.Today.AddDays((int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - (int)DateTime.Today.DayOfWeek);
            var endDate = startDate.AddDays(7);
            var numDays = (int)((endDate - startDate).TotalDays);
            List<DateTime> weekDateDay = Enumerable.Range(0, numDays).Select(x => startDate.AddDays(x)).ToList();
            ViewBag.Date = weekDateDay;

            var calenderModel = new CalenderModel();
            var calenderModelList = new List<CalenderModel>();
            var SundayList = new List<DayList>();
            var MondayList = new List<DayList>();
            var TuesdayList = new List<DayList>();
            var WednesdayList = new List<DayList>();
            var ThursdayList = new List<DayList>();
            var FridayList = new List<DayList>();
            var SaturdayList = new List<DayList>();

            var dataList = new List<Tuple<DateTime, string, int, int, int>>();
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-13 08:00:00", CultureInfo.CurrentCulture), "Test", 0, 255, 0));
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-14 09:00:00", CultureInfo.CurrentCulture), "Test1",71,255,100));
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-15 09:00:00", CultureInfo.CurrentCulture), "Test2",188,149,136));
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-13 09:00:00", CultureInfo.CurrentCulture), "Tes 3",71,255,100));
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-15 10:00:00", CultureInfo.CurrentCulture), "Test4",0,255,0));
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-18 09:00:00", CultureInfo.CurrentCulture), "Test 5",85,69,255));
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-19 09:00:00", CultureInfo.CurrentCulture), "Test6",71,255,100));
            dataList.Add(new Tuple<DateTime, string, int, int, int>(Convert.ToDateTime("2021-06-13 08:00:00", CultureInfo.CurrentCulture), "Test7",85,69,255));

            foreach (var item in dataList)
            {
                var date = item.Item1;
                if (date.DayOfWeek == 0)
                {
                    SundayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2,
                        BR = item.Item3,
                        BG = item.Item4,
                        BB = item.Item5
                    });
                }
                else if ((int)date.DayOfWeek == 1)
                {
                    MondayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2,
                        BR = item.Item3,
                        BG = item.Item4,
                        BB = item.Item5
                    });
                }
                else if ((int)date.DayOfWeek == 2)
                {
                    TuesdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2,
                        BR = item.Item3,
                        BG = item.Item4,
                        BB = item.Item5
                    });
                }
                else if ((int)date.DayOfWeek == 3)
                {
                    WednesdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2,
                        BR = item.Item3,
                        BG = item.Item4,
                        BB = item.Item5
                    });
                }
                else if ((int)date.DayOfWeek == 4)
                {
                    ThursdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2,
                        BR = item.Item3,
                        BG = item.Item4,
                        BB = item.Item5
                    });
                }
                else if ((int)date.DayOfWeek == 5)
                {
                    FridayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2,
                        BR = item.Item3,
                        BG = item.Item4,
                        BB = item.Item5
                    });
                }
                else if ((int)date.DayOfWeek == 6)
                {
                    SaturdayList.Add(new DayList()
                    {
                        JobDate = date,
                        Name = item.Item2,
                        BR = item.Item3,
                        BG = item.Item4,
                        BB = item.Item5
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

            return View(calenderModel);
        }
    }
}
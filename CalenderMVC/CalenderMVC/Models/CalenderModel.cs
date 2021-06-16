using System;
using System.Collections.Generic;

namespace CalenderMVC.Models
{
    public class CalenderModel
    {
        public DateTime JobDate { get; set; }
        public string StartTime { get; set; }
        public string Name { get; set; }
        public int BR { get; set; }
        public int BG { get; set; }
        public int BB { get; set; }
        public int FR { get; set; }
        public int FG { get; set; }
        public int FB { get; set; }
        public DaysData days { get; set; }

        public List<DayList> SundayList { get; set; }
        public List<DayList> MondayList { get; set; }
        public List<DayList> TuesdayList { get; set; }
        public List<DayList> WednesdayList { get; set; }
        public List<DayList> ThursdayList { get; set; }
        public List<DayList> FridayList { get; set; }
        public List<DayList> SaturdayList { get; set; }

        public int maxValue { get; set; }
    }

    public class DaysData {
        public string Sunday { get; set; }
        public DateTime SundayJobTime { get; set; }
        public string Monday { get; set; }
        public DateTime MondayJobTime { get; set; }
        public string Tuesday { get; set; }
        public DateTime TuesdayJobTime { get; set; }
        public string Wednesday { get; set; }
        public DateTime WednesdayJobTime { get; set; }
        public string Thursday { get; set; }
        public DateTime ThursdayJobTime { get; set; }
        public string Friday { get; set; }
        public DateTime FridayJobTime { get; set; }
        public string Saturday { get; set; }
        public DateTime SaturdayJobTime { get; set; }
    }

    public class DayList
    {
        public DateTime JobDate { get; set; }
        public string Name { get; set; }
        public int BR { get; set; }
        public int BG { get; set; }
        public int BB { get; set; }
    }
}
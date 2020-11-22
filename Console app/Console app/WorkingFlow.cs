using System;
using System.Collections.Generic;
using System.Text;

namespace Console_app
{

    internal class WorkingFlow
    {
        internal List<string> monthList = new List<string>()
        {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        };
        internal List<string> DaysList31 = new List<string>()
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"
        };
        internal List<string> DaysList30 = new List<string>()
        {
             "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"
        };
        internal List<string> DaysList29 = new List<string>()
        {
             "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29"
        };
        internal List<string> DaysList28 = new List<string>()
        {
             "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"
        };
        internal List<string> Years = new List<string>() { };
        internal void Filling()
        {
            for (int i = 2005; i > 1970; i--)
            {
                Years.Add(Convert.ToString(i));
            }
        }
        internal List<string> CheckBirthDate(int Month, string Year)
        {
            WorkingFlow Datas = new WorkingFlow();
            if (((Convert.ToInt32(Year) - 1964) % 4 == 0))
            {
                if (Month == 2) //Проверка на месяц (31)
                {
                    return Datas.DaysList29;
                }
                else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {
                    return Datas.DaysList30;
                } else
                {
                    return Datas.DaysList31;
                }
            }
            else
            {
                if (Month == 2) //Проверка на месяц (31)
                {
                    return Datas.DaysList28;
                }
                else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {
                    return Datas.DaysList30;
                }
                else
                {
                    return Datas.DaysList31;
                }
            }
        }
    }
}

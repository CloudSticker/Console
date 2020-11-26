using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Console_app
{

    internal class WorkingFlow
    {
        string path = @"StudentList.txt";
        internal List<string> UniversitiesList = new List<string>()
        {
            "МИСиС",
            "Синергия",
            "МГТУ",
            "Баумана",
            "МИРЭА",
            "РХТУ",
            "МГСУ",
            "ФГБОУ",
            "МАИ",
            "РГСУ",
            "ВШЭ"
        };
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
      
        internal bool IsTextOfNamesINPutValid(String enter)
        {
            bool CapitalCheck = true;
            bool IsActualWord = true;
            for (int i = 0; (i < enter.Length) && IsActualWord && CapitalCheck; i++)
            {
                IsActualWord = (enter[i] <= 'я' && enter[i] >= 'А' || enter[i] == 'ё' || enter[i] == 'Ё');
                CapitalCheck = enter[0] == enter.ToUpper()[0];
            }

            return CapitalCheck && IsActualWord && enter != "";
        }
       
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
                if (Month == 1) //Проверка на месяц (31)
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
                if (Month == 1) //Проверка на месяц (31)
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
        internal void ADDinFile(string stroke)
        {
            if (File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.Write($"{stroke}\r\n");
                }
            } else
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(stroke);
                }
            }
        }
        internal int CheckForID()
        {
            int max = 0;
            if(File.Exists(path))
            {
                string[] AllLines = File.ReadAllLines(path);
                for (int i = 0; i < AllLines.Length; i++)
                {
                    string[] ElementsOfLine = AllLines[i].Split(' ');
                    if (max < Convert.ToInt32(ElementsOfLine[0]))
                    {
                        max = Convert.ToInt32(ElementsOfLine[0]);
                        continue;
                    }
                }
                    return max+1;
            } else
            {
                return 1;
            }
        }
    }
}

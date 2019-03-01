﻿using System;
using System.Text.RegularExpressions;

namespace LabManagement
{
    internal class Semester
    {
        public int SemesterID { get; set; }
        public int Version { get; set; }
        public long NameFK { get; set; }
        public int Year { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime SchedulePostDate { get; set; }
        public string Name { get; set; }
        public string ScheduleDateStr { get; set; }
        public string SchedulePostDateStr { get; set; }

        public Semester() { }

        public Semester(ExcelData ws)
        {
            Regex semesterPattern = new Regex(@"^(\d{1,2})\/(\d{1,2})\/(\d{4}).*?(FALL|WINTER|SPRING|SUMMER)\s(\d{4})");
            string rawSemester = ws.excelArray[2, 0].Trim();
            string revisionMonth = semesterPattern.Match(rawSemester).Groups[1].Value;
            string revisionDay = semesterPattern.Match(rawSemester).Groups[2].Value;
            string revisionYear = semesterPattern.Match(rawSemester).Groups[3].Value;
            Name = semesterPattern.Match(rawSemester).Groups[4].Value ;
            string semesterYear = semesterPattern.Match(rawSemester).Groups[5].Value;

            int.TryParse(semesterYear, out int semesterYearTemp);
            int.TryParse(revisionMonth, out int m);
            int.TryParse(revisionDay, out int d);
            int.TryParse(revisionYear, out int y);
            Year = semesterYearTemp;
            SchedulePostDateStr = DateTime.Now.ToString("yyyy-M-d HH:mm:ss");
            ScheduleDateStr = y + "-" + m + "-" + d;  

            NameFK = Db.GetSingleInt("SemesterName", "name", "'" + Name + "'", "semesterNameID");
            var semesterTuple = Db.GetTuple(this, "year = '" + Year + "' AND nameFK = '" + NameFK + "'");

            if (semesterTuple.Count > 0)
            {
                SemesterID = Convert.ToInt32(semesterTuple[0].ToString());
                Version = Convert.ToInt32(semesterTuple[1].ToString()) + 1;
                string updateStr = "version = '" + Version + "'" + ", scheduleDate = '" + ScheduleDateStr + "', schedulePostDate = '" + SchedulePostDateStr + "'";
                Db.UpdateID("Semester", "semesterID", SemesterID, updateStr);
                Console.Write("Updating SemesterID " + SemesterID + " " + updateStr); 
            }
            else
            {
                string insertColumns = "version, nameFK, year, scheduleDate, schedulePostDate";
                string insertData = 1 + ", " + NameFK + "," + Year + ",'" + ScheduleDateStr  + "','" + SchedulePostDateStr + "'";
                SemesterID = Db.SqlInsert("Semester", insertColumns, insertData); 
                Console.Write("Inserting Semester" + insertColumns + " " + insertData + "ReturnedId =" + SemesterID);
            }
        }

    }
}

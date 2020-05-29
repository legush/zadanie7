using System;
using System.Collections.Generic;

namespace zadanie6
{
    class Program
    {
        public class student
        {
            public string ID;
            public string FIO;
            public string date;
            public string group;

        }

        static List<student> SL = new List<student>();

        static void AddStudent(string ID, string FIO, string date, string group)
        {
            SL.Add(new student() { ID = ID, FIO = FIO, date = date, group = group });
        }

        static void DelStudent(string ID)
        {
            for (int i = 0; i < SL.Count; i++){

                if (SL[i].ID == ID)
                    SL.RemoveAt(i);
            }
        }

        static void ChangeStudent(string ID, string FIO, string date, string group)
        {

            for (int i = 0; i < SL.Count; i++) {
                if (SL[i].ID == ID) {
                    SL[i].ID = FIO;
                    SL[i].date = date;
                    SL[i].group = group;
                }
            }

        }

        static void ShowStudent()
        {

            foreach (var a in SL) {
                Console.WriteLine(" " + a.ID + " " + a.FIO + " /" + a.group + " /" + a.date);
            }
            Console.WriteLine();

        }
        static void ShowStudentFio()
        {
            for (int i = 0; i < SL.Count; i++) {
                Console.WriteLine(SL[i].FIO);
            }
            Console.WriteLine();
        }

        static void ShowStudentID(string ID)
        {
            for (int i = 0; i < SL.Count; i++) {
                if (SL[i].ID == ID)
                    Console.WriteLine(SL[i].ID + " / " + SL[i].FIO + " / " + SL[i].date + " / " + SL[i].group);
            }
            Console.WriteLine();
        }

        static void ShowStudentAge(string ID)
        {
            for (int i = 0; i < SL.Count; i++) {
                if (SL[i].ID == ID) {
                    string[] SL1 = SL[i].date.Split(".");
                    int year = 2020;

                    if (int.TryParse(SL1[2], out int res)) Console.Write("возраст с id " + ID + ": " + (year - res));
                }
            }
            Console.WriteLine();
        }

        static void initials(string ID)
        {
            for (int i = 0; i < SL.Count; i++) {
                if (SL[i].ID == ID) {
                    string[] SL1 = SL[i].FIO.Split(" ");

                    Console.WriteLine(SL1[0] + " " + SL1[1][0] + "." + SL1[2][0] + ".");
                }
            }
            Console.WriteLine();
        }

        static void older(string param)
        {
            string[] SL1;
            int year;
            int age;

            for (int i = 0; i < SL.Count; i++) {
                SL1 = SL[i].date.Split(".");
                year = 2020;


                if (int.TryParse(SL1[2], out int res)) {
                    age = year - res;

                    if (param == "s" && age < 18) Console.WriteLine(SL[i].FIO + "\n" + "возраст: " + age + " лет");
                    if (param == "a" && age > 18) Console.WriteLine(SL[i].FIO + "\n" + " возраст: " + age + " лет");
                }
            }
            Console.WriteLine();
        }

        static void search(string f)
        {
            for (int i = 0; i < SL.Count; i++) {
                string[] f1 = SL[i].FIO.Split(" ");

                if (f1[0] == f) {
                    Console.WriteLine(SL[i].ID + " / " + SL[i].FIO + " / " + SL[i].date + " / " + SL[i].group);
                }
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            student first = new student();

            AddStudent("1", "Антонов Анотон Антонович", "15.12.2000", "ИСИП");
            AddStudent("2", "Нечаева Мария Дмитриевна", "13.01.2001", "ССА");
            AddStudent("3", "Колчак Анна Степановна", "13.09.2002", "КП");
            AddStudent("4", "Никулин Степан Александрович", "18.07.2003", "ССА");
            AddStudent("5", "Миказ Джо -", "30.12.2002", "ИСИП");
            AddStudent("6", "Ким Сон Гын", "29.02.2001", "ИСИП");

            initials("3");
            older("s");
            search("Ким");
            /* ShowStudentFio();
             ShowStudentID("4");
             ShowStudentAge("3");*/

        }
    }
}
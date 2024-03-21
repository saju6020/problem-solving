using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution
    {

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var results = employees.GroupBy(e => e.Company)
                                .Select(g => new { Company = g.Key, Avg = g.Average(e => e.Age) });

            results = results.OrderBy(e => e.Company).ToList();
            Dictionary<string, int> resultDic = new Dictionary<string, int>();

            foreach (var result in results)
            {
                resultDic.Add(result.Company,Convert.ToInt32(Math.Round(result.Avg)));
            }

            return resultDic;
        }

            public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
            {
                var results = employees.GroupBy(e => e.Company)
                                   .Select(g => new { Company = g.Key, Count = g.Count() });

            results = results.OrderBy(e => e.Company);

                Dictionary<string, int> resultDic = new Dictionary<string, int>();

                foreach (var result in results)
                {
                    resultDic.Add(result.Company, result.Count);
                }

                return resultDic;
            }

            public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
            {
                var results = employees.GroupBy(e => e.Company)
                                    .Select(g => new { Company = g.Key, Age = g.Max(e => e.Age) });

            results = results.OrderBy(e => e.Company);
            Dictionary<string, Employee> resultDic = new Dictionary<string, Employee>();

                foreach (var result in results)
                {
                    var employee = employees.Where(e=>e.Company == result.Company && e.Age == result.Age).FirstOrDefault();
                    resultDic.Add(result.Company, employee);
                }

                return resultDic;
            }

            public static void Main()
            {
                int countOfEmployees = int.Parse(Console.ReadLine());

                var employees = new List<Employee>();

                for (int i = 0; i < countOfEmployees; i++)
                {
                    string str = Console.ReadLine();
                    string[] strArr = str.Split(' ');
                    employees.Add(new Employee
                    {
                        FirstName = strArr[0],
                        LastName = strArr[1],
                        Company = strArr[2],
                        Age = int.Parse(strArr[3])
                    });
                }

                foreach (var emp in AverageAgeForEachCompany(employees))
                {
                    Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
                }

                foreach (var emp in CountOfEmployeesForEachCompany(employees))
                {
                    Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
                }

                foreach (var emp in OldestAgeForEachCompany(employees))
                {
                    Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
                }
            }
        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Company { get; set; }
        }
    }   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechScreen.Models;

namespace TechScreen.Controllers
{
    public class FirstTabController : ApiController
    {
        public Employee[] Get()
        {
            return new Employee[]

            {
                new Employee {
                Name = "Michael Bruce",
                Position = "Javascript Developer",
                Office = "Singapore",
                Age = "29",
                StartDate = "2011/06/27",
                Salary = "$183,000"},
                new Employee {
                Name = "Tiger Nixon",
                Position = "System Architect",
                Office = "Edinburgh",
                Age = "61",
                StartDate = "2011/04/25",
                Salary = "$320,800"},
                new Employee {
                Name = "Garrett Winters",
                Position = "Accountant",
                Office = "Tokyo",
                Age = "63",
                StartDate = "2011/07/25",
                Salary = "$170,750"},
                new Employee {
                Name = "Cedric Kelly",
                Position = "Senior Javascript Developer",
                Office = "Edinburgh",
                Age = "22",
                StartDate = "2012/03/29",
                Salary = "$433,060"},
                new Employee {
                Name = "Ashton Cox",
                Position = "Junior Technical Author",
                Office = "San Francisco",
                Age = "66",
                StartDate = "2009/01/12",
                Salary = "$86,000"},
                new Employee {
                Name = "Airi Satou",
                Position = "Javascript Developer",
                Office = "Singapore",
                Age = "29",
                StartDate = "2011/06/27",
                Salary = "$183,000"},
                new Employee {
                Name = "Herrod Chandler",
                Position = "System Architect",
                Office = "Edinburgh",
                Age = "61",
                StartDate = "2011/04/25",
                Salary = "$320,800"},
                new Employee {
                Name = "Colleen Hurst",
                Position = "Accountant",
                Office = "Tokyo",
                Age = "63",
                StartDate = "2011/07/25",
                Salary = "$170,750"},
                new Employee {
                Name = "Sonya Frost",
                Position = "Senior Javascript Developer",
                Office = "Edinburgh",
                Age = "22",
                StartDate = "2012/03/29",
                Salary = "$433,060"},
                new Employee {
                Name = "Jena Gaines",
                Position = "Junior Technical Author",
                Office = "San Francisco",
                Age = "66",
                StartDate = "2009/01/12",
                Salary = "$86,000"},
                new Employee {
                Name = "Joseph Roberts",
                Position = "System Architect",
                Office = "Edinburgh",
                Age = "61",
                StartDate = "2011/04/25",
                Salary = "$320,800"},
                new Employee {
                Name = " Bruce Michael",
                Position = "Javascript Developer",
                Office = "Singapore",
                Age = "29",
                StartDate = "2011/06/27",
                Salary = "$183,000"},
                new Employee {
                Name = " Nixon Tiger",
                Position = "System Architect",
                Office = "Edinburgh",
                Age = "61",
                StartDate = "2011/04/25",
                Salary = "$320,800"},
                new Employee {
                Name = "Winters Garrett ",
                Position = "Accountant",
                Office = "Tokyo",
                Age = "63",
                StartDate = "2011/07/25",
                Salary = "$170,750"},
                new Employee {
                Name = "Kelly Cedric",
                Position = "Senior Javascript Developer",
                Office = "Edinburgh",
                Age = "22",
                StartDate = "2012/03/29",
                Salary = "$433,060"},
                new Employee {
                Name = "Cox Ashton",
                Position = "Junior Technical Author",
                Office = "San Francisco",
                Age = "66",
                StartDate = "2009/01/12",
                Salary = "$86,000"},
                new Employee {
                Name = "Satou Airi",
                Position = "Javascript Developer",
                Office = "Singapore",
                Age = "29",
                StartDate = "2011/06/27",
                Salary = "$183,000"},
                new Employee {
                Name = "Chandler Herrod",
                Position = "System Architect",
                Office = "Edinburgh",
                Age = "61",
                StartDate = "2011/04/25",
                Salary = "$320,800"},
                new Employee {
                Name = "Hurst Colleen",
                Position = "Accountant",
                Office = "Tokyo",
                Age = "63",
                StartDate = "2011/07/25",
                Salary = "$170,750"},
                new Employee {
                Name = "Frost Sonya",
                Position = "Senior Javascript Developer",
                Office = "Edinburgh",
                Age = "22",
                StartDate = "2012/03/29",
                Salary = "$433,060"},
                new Employee {
                Name = "Gaines Jena",
                Position = "Junior Technical Author",
                Office = "San Francisco",
                Age = "66",
                StartDate = "2009/01/12",
                Salary = "$86,000"}


            };
        }
    }
}

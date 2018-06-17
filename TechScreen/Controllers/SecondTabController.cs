using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechScreen.Models;

namespace TechScreen.Controllers
{
    public class SecondTabController : ApiController
    {
        public LHSItem[] Get()
        {
            return new LHSItem[]

            {
                new LHSItem{
                Item = "Item1"
                },
                new LHSItem{
                Item = "Item2"
                },
                new LHSItem{
                Item = "Item3"
                },
                new LHSItem{
                Item = "Item4"
                },
                new LHSItem{
                Item = "Item5"
                },
                new LHSItem{
                Item = "Item6"
                },
                new LHSItem{
                Item = "Item7"
                },
                new LHSItem{
                Item = "Item8"
                },
                new LHSItem{
                Item = "Item9"
                },
                new LHSItem{
                Item = "Item10"
                }


            };
        }
    }
}

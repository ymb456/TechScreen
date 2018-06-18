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
                Item = "Apple"
                },
                new LHSItem{
                Item = "Pear"
                },
                new LHSItem{
                Item = "Grape"
                },
                new LHSItem{
                Item = "Pineapple"
                },
                new LHSItem{
                Item = "Orange"
                },
                new LHSItem{
                Item = "Banana"
                },
                new LHSItem{
                Item = "watermelon"
                },
                new LHSItem{
                Item = "Plum"
                },
                new LHSItem{
                Item = "Cherry"
                },
                new LHSItem{
                Item = "Kiwifruit"
                }


            };
        }
    }
}

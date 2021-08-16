using Component.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Component.Client.Pages
{
    public partial class Index
    {
        public List<Information> d;
        protected override void OnInitialized()
        {
            d = new List<Information>()
        {

new Information(){ Title="Amit", DOB= new DateTime(2019,12,10)},
new Information(){ Title="Sumit", DOB= new DateTime(2020,12,10)},
new Information(){ Title="Ravi", DOB= new DateTime(2021,12,10)}

        };
        }


    }
}

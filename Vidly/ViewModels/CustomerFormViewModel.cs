using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        //List yada Ienumerable kullanılabilir. ancak Listin sağladığı avantajlara ihtiyac yok add index vs.

        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }

    }
}
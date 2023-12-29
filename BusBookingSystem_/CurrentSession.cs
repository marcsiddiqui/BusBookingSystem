using BusBookingSystem_.BBS_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBookingSystem_
{
    public static class CurrentSession
    {
        public static Employee LoggedInUser { get; set; }
    }
}

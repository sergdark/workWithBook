using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController:Controller{
        private DataContext context;

        public HomeController(DataContext ctx) => context = ctx;
    }
}

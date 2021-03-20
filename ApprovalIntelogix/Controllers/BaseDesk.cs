using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApprovalIntelogix.Controllers
{
    public class BaseDesk : Controller
    {
        protected bool IsHaveEnoughAccessRight()
        {
            return true;
        }
    }
}

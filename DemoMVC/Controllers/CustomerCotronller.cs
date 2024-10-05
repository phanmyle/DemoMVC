using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models.Entities;
namespace DemoMVC.Controllers;
    public class CustomerController : Controller
    {
        private readonly (ApplicationDbContext _context)
        
        _context = Context;

    }
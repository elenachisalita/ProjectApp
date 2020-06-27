﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Data;
using ProjectApp.Services;
using ProjectApp.ViewModels;

namespace ProjectApp.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly BookContext _context;
        public AppController(IMailService mailService, BookContext context)
        {
            _mailService = mailService;
            _context = context;
        }
        public IActionResult Index()
        {
          
            return View();
        }

        [HttpGet("contact")]

        public IActionResult Contact()
        {
       
          
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
       
            if(ModelState.IsValid)
            {
                //send the email
                _mailService.SendMessage("sawn@yahoo.com", model.Subject, $"From: {model.Name} - {model.Email},Message: {model.Message})");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
         
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public IActionResult Shop()
        {
            var results = from p in _context.Products
                          orderby p.Category
                          select p;
            return View(results.ToList());
        }


    }
}
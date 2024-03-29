﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InMyPlate.Models;
using Microsoft.EntityFrameworkCore;
using InMyPlate.Data;
using System;

namespace InMyPlate.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }


    public IActionResult Index()
    {
        var latestPost = _context.Post.FirstOrDefault();
        return View(latestPost);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}


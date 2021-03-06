﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using DataAccessLibrary.Repositories.Generic;
using DataAccessLibrary.Repositories.RestaurantRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SitMe.Models;

namespace SitMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<User> _userRepository;
        private readonly IRestaurantRepository _restaurantRepository;

        public HomeController(
            ILogger<HomeController> logger,
            IRepository<User> userRepository,
            IRestaurantRepository restaurantRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _restaurantRepository = restaurantRepository ?? throw new ArgumentNullException(nameof(restaurantRepository));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RestaurantProfile()
        {
            return View();
        }

        public async Task<IActionResult> RestaurantList()
        {
            var restaurants = await _restaurantRepository.GetRetaurantsWithTagsAsync(0, 9);

            return View(restaurants);
        }

        public async Task<IActionResult> RestaurantListFilter(string filterByTest)
        {
            var restaurants = await _restaurantRepository.GetRetaurantsWithTagsAsync(filterByTest);

            return PartialView("_RestaurantsList", restaurants);
        }


        public IActionResult CreateReservation()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

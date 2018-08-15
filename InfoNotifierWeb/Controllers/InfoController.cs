using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InfoNotifierWeb.Services;
using InfoNotifierWeb.Models;

namespace InfoNotifierWeb.Controllers
{
    public class InfoController : Controller
    {
        private readonly IInfoItemService _infoItemService;

        public InfoController(IInfoItemService infoItemService)
        {
            _infoItemService = infoItemService;
        }
        
        public async Task<IActionResult> Index()
        {
            // Get to-do items from database
            var items = await _infoItemService.GetIncompleteItemsAsync();

            // Put items into a model
            var model = new InfoViewModel()
            {
                Items = items
            };

            // Render view using the model
            return View(model);
        }
    }
}
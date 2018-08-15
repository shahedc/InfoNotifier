using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InfoNotifierWeb.Models;

namespace InfoNotifierWeb.Services
{
    public class FakeTodoItemService : IInfoItemService
    {
        public Task<InfoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new InfoItem
            {
                Title = "Learn ASP.NET Core",
                ItemDate = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new InfoItem
            {
                Title = "Build awesome apps",
                ItemDate = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
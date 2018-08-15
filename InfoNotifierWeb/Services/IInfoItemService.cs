using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InfoNotifierWeb.Models;

namespace InfoNotifierWeb.Services
{
    public interface IInfoItemService
    {
        Task<InfoItem[]> GetIncompleteItemsAsync();
    }
}
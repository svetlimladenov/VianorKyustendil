using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VianorKyustendil.Web.Components
{
    [ViewComponent(Name = "Menu")]
    public class DynamicMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new List<MenuItemViewModel>()
            {
                new MenuItemViewModel("Google","https://google.com"),
                new MenuItemViewModel("Google Maps","https://maps.google.com"),

            };
            return this.View(viewModel);
        }
    }

    public class MenuItemViewModel
    {
        public MenuItemViewModel(string title, string url)
        {
            this.Title = title;
            this.Url = url;
        }
        public string Title { get; set; }

        public string Url { get; set; }
    }
}

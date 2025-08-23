using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BowlingApp.Components.Pages
{
    public class Game : PageModel
    {
        private readonly ILogger<Game> _logger;

        public Game(ILogger<Game> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
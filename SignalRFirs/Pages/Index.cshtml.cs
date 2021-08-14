﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using SignalRFirs.Hubs;

namespace SignalRFirs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        private PositionHub positionHub = new PositionHub();

        //public async Task OnGetAsync()
        //{
        //    await positionHub.SendPosition(150, 150);
        //}
    }
}

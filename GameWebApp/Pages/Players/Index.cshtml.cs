﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameWebApp.Models;

namespace GameWebApp.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly GameWebApp.Models.GameWebAppContext _context;

        public IndexModel(GameWebApp.Models.GameWebAppContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}

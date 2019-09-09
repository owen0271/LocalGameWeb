using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GameWebApp.Models;

namespace GameWebApp.Pages.GameRooms
{
    public class CreateModel : PageModel
    {
        private readonly GameWebApp.Models.GameWebAppContext _context;

        public CreateModel(GameWebApp.Models.GameWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GameRoom GameRoom { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GameRoom.Add(GameRoom);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
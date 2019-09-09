using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameWebApp.Models;

namespace GameWebApp.Pages.GameRooms
{
    public class DeleteModel : PageModel
    {
        private readonly GameWebApp.Models.GameWebAppContext _context;

        public DeleteModel(GameWebApp.Models.GameWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GameRoom GameRoom { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GameRoom = await _context.GameRoom.FirstOrDefaultAsync(m => m.ID == id);

            if (GameRoom == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GameRoom = await _context.GameRoom.FindAsync(id);

            if (GameRoom != null)
            {
                _context.GameRoom.Remove(GameRoom);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

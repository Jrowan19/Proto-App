
using DemoForm.Data;
using DemoForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoForm.Pages
{
    [BindProperties]
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public Timesheets Timesheets { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public Category Category { get; set; }

        public EditModel(ApplicationDbContext db)

        {
            _db = db;
        }

        public async Task OnGet(int id)
        {

            Timesheets = await _db.Timesheets.FindAsync(id);
            Categories = await _db.Category.ToListAsync();

        }

        //Edit Function
        public async Task<IActionResult> OnPost()
        {

            _db.Timesheets.Update(Timesheets);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
    }
}
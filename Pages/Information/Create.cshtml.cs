
using DemoForm.Data;
using DemoForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoForm.Pages
{
    [BindProperties]    
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public Timesheets Timesheets { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

            Categories = _db.Category.ToList();

        }

        public async Task<IActionResult> OnPost()

        {
                      
                await _db.Timesheets.AddAsync(Timesheets);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");     

        }
    }
}
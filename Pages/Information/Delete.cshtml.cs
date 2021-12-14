
using DemoForm.Data;
using DemoForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoForm.Pages
{
    [BindProperties]
    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _db;


        public Timesheets Timesheets { get; set; }
     

        public Category Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task OnGet(int id)
        {

            Timesheets = await _db.Timesheets.FindAsync(id);         

        }

        public async Task<IActionResult> OnPost()
        {
            var timeSheetFromDb = _db.Timesheets.Find(Timesheets.Id);

            if (timeSheetFromDb != null)

            {
                _db.Timesheets.Remove(timeSheetFromDb);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
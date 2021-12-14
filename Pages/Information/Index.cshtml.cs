
using DemoForm.Data;
using DemoForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoForm.Pages.Information
{

    [BindProperties]
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IEnumerable<Timesheets> Timesheets { get; set; }

        public Timesheets Timesheeting { get; set; }

        //Dependecy Injection, implements ApplicationDbContext from the program.cs container and give it a variable name of db
        public IndexModel(ApplicationDbContext db)

        {
            _db = db;
        }

        public string TableHeader()
        {

            //var tableHeader = "Timesheets";

            string tableHeader = "Timesheets";

            return tableHeader;

        }              

        public int[] IntList()

        {

            int[] intList = { 1, 2, 3, 4, 5, 6 };

            return intList;

        }

        public async Task<IActionResult> OnGetFormData()
        {

            var result = await _db.Timesheets.ToListAsync();

            return new JsonResult(result);

        }

    }
}
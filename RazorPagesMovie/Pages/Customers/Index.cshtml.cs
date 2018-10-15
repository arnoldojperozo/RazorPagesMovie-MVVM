using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }
        public SelectList Names { get; set; }
        public string CustomerName { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public async Task OnGetAsync(string customerName, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> customerQuery = from m in _context.Customer
                                            orderby m.FullName
                                            select m.FullName;

            var customers = from m in _context.Customer
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.Name.Contains(searchString)||s.Lastname.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(customerName))
            {
                customers = customers.Where(x => x.Name == customerName);
            }
            Names = new SelectList(await customerQuery.Distinct().ToListAsync());
            Customer = await customers.ToListAsync();
        }
    }
}
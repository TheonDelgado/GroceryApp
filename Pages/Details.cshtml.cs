using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GroceryApp.Pages.Models;

namespace GroceryApp.Pages
{
  public class DetailsModel : PageModel
  {
    public List<GroceryItem> Foods { get; set; }
    public GroceryItem CurrentFood { get; set; }

    public void OnGet(string name)
    {
      Foods = Inventory.ToList();
      CurrentFood = Foods.Find(item => item.Name.ToLower() == name.ToLower());
    }
  }
}
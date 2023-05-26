using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test5.Pages
{
    public class PageWithServerResponceModel : PageModel
    {
       // public string ServerResponse { get; set; }

        public IActionResult OnGet(string Input1, string Input2)
        {
            if (string.IsNullOrEmpty(Input1) || string.IsNullOrEmpty(Input2))
            {
 //               return Content("Both fields are required.");
            }

            Console.WriteLine($"Input1: {Input1}");
            Console.WriteLine($"Input2: {Input2}");

        //    ServerResponse = "Result OK";

            return Content("ok");
        }
    }
}

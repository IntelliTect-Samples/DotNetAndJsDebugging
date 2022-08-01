using Bogus;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace ExternalDebugging;

public class HomeController : Controller
{
    public string Index()
    {
        // Example 1: Try manually setting a breakpoint in VS for "ControllerActionInvoker.Next".
        // Won't be hit if symbols for its containing assembly, "Microsoft.AspNetCore.Mvc.Core" aren't loaded!


        // Example 2: Uh oh, this third party library throws an exception with an unhelpful message!
        // How can we figure out what we did wrong?
        var name = "ttocS werdnA";
        var recombobulatedName = new LibWithoutSymbols.Recombobulator(name).Recombobulate();
        
        return $"Hello, {recombobulatedName}";
    }




    [HttpGet("NumberToWords/{number}")]
    public string NumberToWords(long number)
    {
        // Look boss, I implemented the feature!
        // Its a little slow sometimes, so put it on a good server.
        for (int i = 0; i <= number; i++)
        {
            string words = i.ToWords();
            if (i == number)
            {
                return words;
            }
        }

        return "";
    }
}

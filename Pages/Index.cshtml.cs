using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;

namespace ASPWeb.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Num { get; set; } = 0;
    public int Count { get; set; } = 0;

    public int Result { get; set; }
    [BindProperty]
    public int Number1 {get;set;} = 0;
    [BindProperty]
    public int Number2 {get;set;} = 0;
    public int Sum {get;set;} 
    [BindProperty]
    public int Maths {get;set;} = 0;
    [BindProperty]
    public int Science {get;set;} = 0;
    [BindProperty]
    public int English {get;set;} = 0;
    [BindProperty]
    public int Gujarati {get;set;} = 0;
    [BindProperty]
    public int Sanskrit {get;set;} = 0;
    public int Percentage {get;set;}
    [BindProperty]
    public int Value {get;set;} = 0;
    [BindProperty]
    public string Msg {get;set;}
    public List<int> Fiboseries { get; set; } = new List<int>();
    [BindProperty]
    public int FactorialValue { get; set; } = 0;
    
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
    public void OnGet()
    {
    
    }
    public void OnPost()
    {
        // Sum=Number1 + Number2;
        // Percentage = ((Maths + Science + English + Gujarati + Sanskrit)*100)/500;
        // if (Value < 2)
        // {
        //     Msg = "Please enter number greater than 2";
        // }
        // else
        // {
        //     int a = 0, b = 1, c = 0;
        //     for (int j = 2; j < Value; j++)
        //     {
        //         c = a + b;
        //         Fiboseries.Add(c);
        //         a = b;
        //         b = c;
        //     }
        // }
        FactorialValue = CalculateFactorial(Value);
    }
}

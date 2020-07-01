using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GoogleChart.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public ActionResult OnGetChartData()
        {
            var chart = new Chart
            {
                cols = new object[]
                {
                    new { id = "May", type = "number", label = "May" },
                    new { id = "Juni", type = "number", label = "Juni" },
                    new { id = "Juli", type = "number", label = "Juli" }
                },
                rows = new object[]
                {
                    new { c = new object[] { new { v = "1" }, new { v = 0.3 }, new { v = 0.3 } } },
                    new { c = new object[] { new { v = "2" }, new { v = 0.2 } , new { v = 0.5 } } },
                    new { c = new object[] { new { v = "3" }, new { v = 0.5 } , new { v = 0.7 } } },
                    new { c = new object[] { new { v = "4" }, new { v = 0.6 } , new { v = 0.9 } } },
                    new { c = new object[] { new { v = "5" }, new { v = 0.1 } , new { v = 1.1 } } },
                    new { c = new object[] { new { v = "6" }, new { v = 0.33 } , new { v = 1.3 } } },
                    new { c = new object[] { new { v = "7" }, new { v = 0.5 } , new { v = 0.55 } } },
                    new { c = new object[] { new { v = "8" }, new { v = 0.55 }, new { v = 0.64 } } },
                    new { c = new object[] { new { v = "9" }, new { v = 0.63 }, new { v = 0.99 } } },
                    new { c = new object[] { new { v = "10" }, new { v = 0.71 }, new { v = 1.33 } } },
                    new { c = new object[] { new { v = "11" }, new { v = 0.2 }, new { v = 2.67 } } },
                    new { c = new object[] { new { v = "12" }, new { v = 0.9 }, new { v = 1.999 } } },
                    new { c = new object[] { new { v = "13" }, new { v = 1.4 }, new { v = 2.36 } } },
                    new { c = new object[] { new { v = "14" }, new { v = 3.4 }, new { v = 3.88 } } },
                    new { c = new object[] { new { v = "15" }, new { v = 3 }, new { v = 4.0 } } },

            },
            };

            return new JsonResult(chart);
        }
    }
}

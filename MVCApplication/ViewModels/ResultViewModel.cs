using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{

    public class ResultViewModel
    {
        [Required]
        public int quant { get; set; }
        [Required]
        public int leng { get; set; }
        public List<string> RandomKeys { get; set; }
    }
}



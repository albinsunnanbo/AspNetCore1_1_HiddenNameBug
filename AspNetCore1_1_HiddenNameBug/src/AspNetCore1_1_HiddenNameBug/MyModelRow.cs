using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore1_1_HiddenNameBug
{
    public class MyModelRow
    {
        [Display(Name = "Foo")]
        public int IntProperty { get; set; }

        public string StringProperty { get; set; }
    }
}

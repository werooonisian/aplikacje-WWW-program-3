using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace aplikacje_WWW_program_3.Models
{
    public class FizzBuzz
    {
        [Range(1, 1000)] //zakres dla naszego inta
        //[Required(ErrorMessage ="Pole jest obowiązkowe")] - dla int podobno nie trzeba 
        public int Number { get; set; }

    }
}

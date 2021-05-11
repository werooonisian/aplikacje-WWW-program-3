using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using aplikacje_WWW_program_3.Pages;


namespace aplikacje_WWW_program_3.Models
{
    public class FizzBuzz
    {
       // public string OwnerID { get; set; } // user ID from AspNetUser table.
        public int Id { get; set; }
        [Range(1, 1000)] //zakres dla naszego inta
        //[Required(ErrorMessage ="Pole jest obowiązkowe")] - dla int podobno nie trzeba 
        public int Number { get; set; }
        public string result { get; set; }
        public DateTime data { get; set; }
        public void pobierzDate(DateTime data)
        {
            this.data = data;
        }
        public void Wyswietl()
        {
            if(Number%3==0)
            {
                result += "Fizz";
            }
            if(Number%5==0)
            {
                result += "Buzz";
            }
            if(Number%5!=0 & Number%3!=0)
            {
                result = "Twoja liczba nie spełnia kryteriów FizzBuzz";
            }
        }



       /* public static List<FizzBuzz> ogarnijListe(List<FizzBuzz> lista)
        {
            List<FizzBuzz> ostatnie10 = new List<FizzBuzz>();
            int num = lista.Count;


            for(int i = 0; i<10; i++)
            {
                if (num == 0)
                {
                    return ostatnie10;
                }
                ostatnie10.Add(lista[num - 1]);
                num--;
            }
            return ostatnie10;
        } */
    }
}
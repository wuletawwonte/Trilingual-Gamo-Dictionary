using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrilingualGamoDictionary.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string WordTitle { get; set; }
        public string Meaning { get; set; }
    }
}

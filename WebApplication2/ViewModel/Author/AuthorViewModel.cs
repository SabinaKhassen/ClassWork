using AutoMapper;
using DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace WebApplication2.ViewModel.Author
{
   public class AuthorViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ввудите поле")]
        public string FirstName { get; set; }
        //[RegularExpression(@"[a-z]@")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Doesn't fit")]
        public string LastName { get; set; }

    }
}

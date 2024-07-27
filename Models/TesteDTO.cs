using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CsvHelper.Configuration.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace csv_net.Models
{

    public class TesteDTO
    {
    
        [Index(0)]
        public int Id { get; set;}
        //Index ordena pela ordem das linhas, independente do nome da coluna excel
        [Index(1)]
        //[Name("FirstName")]
        public string FirstName { get; set; }

        [Index(2)]
        //[Name("LastName")]
        public string LastName { get; set; }

        [Index(3)]
        //[Name("Email")]
        public string Email { get; set; }
      
    }
}
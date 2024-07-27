using CsvHelper.Configuration.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace csv_net.Models
{

    public class TesteDTO
    {
        //Index ordena pela ordem das linhas, independente do nome da coluna excel
        [Index(0)]
        //[Name("FirstName")]
        public string FirstName { get; set; }

        [Index(1)]
        //[Name("LastName")]
        public string LastName { get; set; }

        [Index(2)]
        //[Name("Email")]
        public string Email { get; set; }
      
    }
}
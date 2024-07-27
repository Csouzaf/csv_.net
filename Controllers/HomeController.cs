using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csv_net.Models;
using CsvHelper;
using AutoMapper;
using csv_net.Services;

namespace csv_net.Controllers;

[ApiController]
[Route("teste")]
public class HomeController : Controller
{

    private readonly ImportRepo _imporCsv;

    public HomeController(ImportRepo imporCsv)
    {
        _imporCsv = imporCsv;
    }
    string caminhoPasta = @"D:\OneDrive\Programação\csv_net\teste1.csv";
   [HttpGet()]
   public ActionResult<TesteDTO> lerCsv()
   {
        var importar =_imporCsv.lerCsv(caminhoPasta);
        
        return Ok(importar);
   }
}

using System.Globalization;
using AutoMapper;
using csv_net.Models;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csv_net.Services
{
    public class ImportCsv : ImportRepo
    {
        private readonly IMapper _mapper;

        public ImportCsv(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<TesteDTO> lerCsv(string caminhoPasta)
        {
            List<TesteDTO> lista = null;
            List<string> badRecord = new List<string>();
            try
            {
               var config = new CsvConfiguration(CultureInfo.InvariantCulture)
               {
                
                    IgnoreBlankLines = true,
                    MissingFieldFound = null,
                    Delimiter = ";",
                    HasHeaderRecord = true,
                    
                
                    //BadDataFound = context => badRecord.Add(context.RawRecord)
               };

                using (var lerPasta = new StreamReader(caminhoPasta))

               
                using (var csvLeitura = new CsvReader(lerPasta, config))
                {

                    //  csvLeitura.Read();
                    //  csvLeitura.ReadHeader();
                    //csvLeitura.Configuration.Delimiter = ";";
                    //csvLeitura.Configuration.IgnoreBlankLines = true;
                    // csvLeitura.Configuration.CultureInfo = CultureInfo.InvariantCulture;
                    // csvLeitura.Configuration.IgnoreHeaderWhiteSpace = true;
                    // csvLeitura.Configuration.IsHeaderCaseSensitive = true;
                    // csvLeitura.Configuration.WillThrowOnMissingField = true;
                    // csvLeitura.Read();
                    // // csvLeitura.Configuration.AutoMap<TesteDTO>();
                    // //csvLeitura.Configuration.RegisterClassMap<TesteDTO>(Teste);
                    // //csvLeitura.Read();
                    // content = leitura.ReadToEnd();
                    // while(csvLeitura.Read())
                    // {
                        var leituras = csvLeitura.GetRecords<TesteDTO>().ToList();
                        lista = leituras;
                    //}


                }
            }
            catch (Exception e)
            {

                throw;
            }
            return lista;
        }


    }
}
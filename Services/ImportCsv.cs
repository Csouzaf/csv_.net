using System.Globalization;
using System.Net;
using AutoMapper;
using csv_net.Models;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Mvc;
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
            try
            {
               var config = new CsvConfiguration(CultureInfo.InvariantCulture)
               {
                
                    IgnoreBlankLines = true,
                    MissingFieldFound = null,
                    Delimiter = ";",
                    HasHeaderRecord = true,
                
               };
                
                using (var lerPasta = new StreamReader(caminhoPasta))

            //    Criar a escrita id autoincremente e setar na lista de leituras para que o usuário 
            //    não digite o id no csv, verificar se o id incrementado já existe, se existir, criar um outro
                using (var csvLeitura = new CsvReader(lerPasta, config))
                {   
                        TesteDTO testeDTO = new TesteDTO();
                       
                        var leituras = csvLeitura.GetRecords<TesteDTO>().ToList();
                       
                        lista = leituras;
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
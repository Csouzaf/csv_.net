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

                
                using (var csvLeitura = new CsvReader(lerPasta, config))
                {

                    
                //Precisará transformar tudo q não for string para esse tipo
                // Fazer incremento de soma do id
                // Fazer verificação se o id incrementado já existe no banco, se existir, criar um com outro
                // Na lista csv terá q ignorar a primeira coluna, podendo deixa-la bloqueada mas com a coluna id existente


                    List<TesteDTO> teste = csvLeitura.GetRecords<TesteDTO>().ToList();

                    foreach (var inteiro in teste)
                    {
                        inteiro.Id = "1";
                    }

                    lista = teste;
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
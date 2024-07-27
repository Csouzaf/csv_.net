using csv_net.Models;

namespace csv_net.Services
{
    public interface ImportRepo
    {
        List<TesteDTO> lerCsv(string caminho);
    }
}
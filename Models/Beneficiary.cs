namespace Cadastro.Models
{
    public class Beneficiary
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
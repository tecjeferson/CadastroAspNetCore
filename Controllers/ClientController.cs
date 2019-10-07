using System.Collections.Generic;
using System.Linq;
using Cadastro.Data;
using Cadastro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Controllers
{
    public class ClientController : Controller
    {


        private readonly StoreDataContext _context;

        public ClientController(StoreDataContext context)
        {
            _context = context;
        }

        [Route("v1/clients")]
        [HttpGet]
        //IEnumerable é utilizado para retornar uma lista, aqui no caso uma lista de categoria
        public IEnumerable<Client> Get()
        {
            //AsNoTracking evita que na requisição do servidor ao banco de dados informações adicionais e desnecessárias sejam buscadas 
            //e isso afetaria a performance.
            return _context.Clients.AsNoTracking().ToList();
        }

        [Route("v1/clients/{id}")]
        [HttpGet]
        public Client Get(int id)
        {
            //O metodo Find() ainda não support o AsNoTracking()
            return _context.Clients.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        [Route("v1/clients/{id}/beneficiary")]
        [HttpGet]
        public IEnumerable<Beneficiary> GetBeneficiary(int id)
        {
            //O metodo Find() ainda não support o AsNoTracking()
            return _context.Beneficiaries.AsNoTracking().Where(x => x.ClientId == id).ToList();
        }

        [Route("v1/clients")]
        [HttpPost]
        public Client Post([FromBody]Client category)
        {
            _context.Clients.Add(category);
            _context.SaveChanges();
            return category;
        }

        [Route("v1/clients")]
        [HttpPut]
        public Client Put([FromBody]Client client)
        {
            _context.Entry<Client>(client).State = EntityState.Modified;
            _context.SaveChanges();
            return client;
        }

        [Route("v1/clients")]
        [HttpDelete]
        public Client Delete([FromBody]Client client)
        {
            _context.Clients.Remove(client);
            _context.SaveChanges();
            return client;
        }


    }
}
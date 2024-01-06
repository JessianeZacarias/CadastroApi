using CadastroPessoasApi.Data;
using CadastroPessoasApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CadastroPessoasApi.Service
{
    public class ServicePessoa
    {
        public IEnumerable<PessoaViewModel> GetAll()
        {
            var repository = new Repository();
            return repository.GetAll().ToList();
        }
        public PessoaViewModel GetById(int pessoaId)
        {
            var repository = new Repository();
            return repository.GetById(pessoaId);
        }
        public PessoaViewModel GetByPrimeiroNome(string primeiroNome)
        {
            var repository = new Repository();
            return repository.GetByPrimeiroNome(primeiroNome);
        }
        public void Update(int pessoaId, string primeiroNome)
        {
            var repository = new Repository();
            repository.Update(pessoaId, primeiroNome);
        }
        public string Create(PessoaViewModel pessoa)
        {
            if (pessoa == null)
                return "Os dados são obrigatórios";
            if (pessoa != null && string.IsNullOrEmpty(pessoa.nomeMeio))
                return "O campo nomeMeio é obrigatório";
            if (pessoa != null && string.IsNullOrEmpty(pessoa.ultimoNome))
                return "O campo ultimoNome é obrigatório";
            if (pessoa != null && string.IsNullOrEmpty(pessoa.CPF))
                return "O campo CPF é obrigatório";

            var repository = new Repository();
            return repository.Create(pessoa);
        }
        public void Delete(int pessoaId)
        {
            var repository = new Repository();
            repository.Delete (pessoaId);
            
        }
    }

    
}

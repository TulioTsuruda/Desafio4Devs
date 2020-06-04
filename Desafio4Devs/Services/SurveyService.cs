using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;
using Desafio4Devs.Repository;
using Desafio4Devs.Repository.Interface;
using Desafio4Devs.Services.Interface;

namespace Desafio4Devs.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository _surveyRepository;
        private readonly IClienteService _clienteService;

        public SurveyService() {
            _surveyRepository = new SurveyRepository();
            _clienteService = new ClienteService();
        }

        public void addSurvey(Survey add)
        {
            //Necessário criar a lógica para fazer o calculo das médias e 
            //aplicar qual categoria o cliente pertence. 

            Cliente addCateg = new Cliente();

            if (add.scale > 8) //9-10
            {
                addCateg.categoria = Indicador.Promotor;
            } else if (add.scale >= 7) //7-8
            {
                addCateg.categoria = Indicador.Neutro;
            }else if (add.scale >= 0) //0-6
            {
                addCateg.categoria = Indicador.Detrator;
            }
            else
            {
                addCateg.categoria = Indicador.Nenhuma;
            }

            addCateg.ID = add.ID;

            _clienteService.addCliente(addCateg);

            _surveyRepository.InsertSurvey(add);
        }
    }
}

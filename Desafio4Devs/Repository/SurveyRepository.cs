using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;
using Desafio4Devs.Repository.Interface;

namespace Desafio4Devs.Repository
{
    public class SurveyRepository : ISurveyRepository
    {
        //Tabela para salvar as pesquisas temporariamente
        private List<Survey> SurveyList = new List<Survey>
        {

        };
        public SurveyRepository()
        {
        }

        public void InsertSurvey(Survey form)
        {
            SurveyList.Add(form);
        }
    }
}

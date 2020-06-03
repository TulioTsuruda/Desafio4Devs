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

        public SurveyService() {
            _surveyRepository = new SurveyRepository();
        }
        public void addSurvey(Survey add)
        {
            _surveyRepository.InsertSurvey(add);
        }
    }
}

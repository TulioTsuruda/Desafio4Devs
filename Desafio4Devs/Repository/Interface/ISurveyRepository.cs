using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;

namespace Desafio4Devs.Repository.Interface
{
    public interface ISurveyRepository
    {
        void InsertSurvey(Survey form);
    }
}

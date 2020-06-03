using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;
using Desafio4Devs.Services;
using Desafio4Devs.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Desafio4Devs.Controllers
{
    public class SurveyController : Controller
    {
        private readonly ISurveyService _surveyService;

        public SurveyController()
        {
            _surveyService = new SurveyService();
        }
        [HttpGet]
        public ActionResult Survey()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Saved()
        {
            return View();
        }

        [HttpPost]
        public bool SaveSurvey(Survey addSurvey)
        {
            try
            {
                _surveyService.addSurvey(addSurvey);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

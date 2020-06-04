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

        static Survey _holdData { get; set; }

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
        public ActionResult Cliente()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateCliente()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Saved()
        {
            return View();
        }

        public Survey NextStep(Survey next)
        {
            //Guardar os dados do cliente escolhido
            return _holdData = next;
        }

        [HttpPost]
        public bool SaveSurvey(Survey addSurvey)
        {
            try
            {
                _holdData.scale = addSurvey.scale; //Pega a noto escolhida
                _holdData.motivo = addSurvey.motivo; //Pega o motivo da nota
                _surveyService.addSurvey(_holdData);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

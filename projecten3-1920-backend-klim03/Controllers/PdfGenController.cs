using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using projecten3_1920_backend_klim03.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class PdfGenController : ControllerBase
    {
        private readonly IProjectRepo _projects;
        private readonly PdfGenerator _pdfGenerator;

        public PdfGenController(IProjectRepo projects, PdfGenerator pdfGenerator)
        {
            _projects = projects;
            _pdfGenerator = pdfGenerator;
        }




        

          
        [HttpGet("custompdf/{projectId}")]
        public ActionResult GetCustompdf(long projectId)
        {
        



            return File(_pdfGenerator.GenerateCustomPdf(_projects.GetForProjectProgress(projectId)), "application/pdf"); 

            //return File(_tpg.GenerateTicketPdf(ticket, ticket.Event.CreatedTicket), "application/pdf");
        }


    }
}

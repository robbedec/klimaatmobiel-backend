using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Hosting;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.helpers
{
    public class PdfGenerator
    {
        private IConverter _converter;
        private readonly IHostingEnvironment _hostingEnvironment;

        public PdfGenerator(IConverter converter, IHostingEnvironment environment)
        {
            _converter = converter;
            _hostingEnvironment = environment;
        }


        public byte[] GenerateCustomPdf(Project project)
        {


            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Landscape,
                PaperSize = PaperKind.A4Plus,
            },
                Objects = {
                new ObjectSettings() {
                PagesCount = true,
                HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices  iaculis. Ut                               odio viverra, molestie lectus nec, venenatis turpis.",
                WebSettings = { DefaultEncoding = "utf-8" },
                HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
                }
            }
            };






            byte[] pdf = _converter.Convert(doc);

            return pdf;
        }


    }
}

using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Radzen.Data;

namespace Radzen
{
    public partial class ExportRadzenDbController : ExportController
    {
        private readonly RadzenDbContext context;
        private readonly RadzenDbService service;
        public ExportRadzenDbController(RadzenDbContext context, RadzenDbService service)
        {
            this.service = service;
            this.context = context;
        }

    }
}

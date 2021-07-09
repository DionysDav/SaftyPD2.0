using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Practica1.Domains;
using Practica1.Models;

namespace Practica1.DataAccessLayer
{
    public class PostgreSql604RepositoryOLD
    {
        private ApplicationDb604Context _context = new ApplicationDb604Context();

        public void AddApplicant(Request request)
        {
            //_context.Requests.sql()
        }
    }
}
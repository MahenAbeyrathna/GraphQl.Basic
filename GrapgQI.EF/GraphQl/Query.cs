using GrapgQI.EF.Context;
using GrapgQI.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrapgQI.EF.GraphQl
{
    public class Query
    {
        private DatabaseContext dbContext;

        public Query(DatabaseContext context)
        {
         this.dbContext = context;
        }

        public IQueryable<Student> Students => dbContext.Students;
    }
}

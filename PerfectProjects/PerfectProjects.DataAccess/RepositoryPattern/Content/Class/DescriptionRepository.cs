﻿using PerfectProjects.DataAccess.Data;
using PerfectProjects.DataAccess.RepositoryPattern.Content.Interfaces;
using PerfectProjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectProjects.DataAccess.RepositoryPattern.Content.Class
{
    public class DescriptionRepository : Repository<Description>, IDescriptionRepository
    {
        public DescriptionRepository(ApplicationDbContext db):base(db)
        {
        }
    }
}

﻿using BlazorSrvDataLayer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSrvDataLayer.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base (options)
        {

        }

        public DbSet<Cateogry>  Cateogries { get; set; }
    }
}

﻿namespace TallerWeb3.Dominio.Context
{
    public class DominioDbContext : DbContext
    {
        public DominioDbContext()
            : base("DbConnection")
        {

        }
    }
}
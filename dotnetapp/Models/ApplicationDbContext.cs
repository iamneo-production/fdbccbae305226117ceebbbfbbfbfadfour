using dotnetapp.Models;
using System;
 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

public class ApplicationDbContext : DbContext
    {
public ApplicationDbContext()
        {
        }  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        // Write your ApplicationDbContext here...
    }
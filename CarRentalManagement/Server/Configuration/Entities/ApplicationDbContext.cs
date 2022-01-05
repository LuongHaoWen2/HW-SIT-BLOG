using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class ApplicationDbContext : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
            new Model
            {
                Name = "3 Series"
            },

            new Model
            {
                Name = "X5"
            },
            new Model
            {
                Name = "Rav4"
            }
            );
        }
    }
}

﻿using AspSneakers.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspSneakers.DataAccess.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(x => x.Number).IsRequired();


            builder.HasMany(x => x.ProductSizes)
                    .WithOne(x => x.Size)
                    .HasForeignKey(x => x.SizeId);


        }
    }
}

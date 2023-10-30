using MetricsWise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetricsWise.Infra.Data.EntityConfigurations
{
    public class FundConfiguration : IEntityTypeConfiguration<Fund>
    {
        public void Configure(EntityTypeBuilder<Fund> builder)
        {
            builder.Property(f => f.Name).HasMaxLength(150);
            builder.Property(f => f.Ticker).HasMaxLength(6).IsRequired(); // Unique

            //builder.Property(f => f.Price).HasPrecision(10, 2);

            builder.HasKey(f => f.Id);

            builder.HasData(
                new Fund
                {
                    Id = 1,
                    Name = "Maxi Renda Fundo Invest Imobiliario FII",
                    Ticker = "MXRF11"
                }
            );
        }
    }
}

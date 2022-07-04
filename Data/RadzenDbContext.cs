using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;


namespace Radzen.Data
{
  public partial class RadzenDbContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public RadzenDbContext(DbContextOptions<RadzenDbContext> options):base(options)
    {
    }

    public RadzenDbContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        this.OnModelBuilding(builder);
    }

  }
}

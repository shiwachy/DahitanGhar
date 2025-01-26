using DahitanGhar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahitanGhar.Application.Interfaces;

public interface IDgDbContext
{
    public DbSet<UserEntity> Users { get; set; }


}

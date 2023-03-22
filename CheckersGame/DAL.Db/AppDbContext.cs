﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL.Db;

public class AppDbContext : DbContext
{
    public DbSet<CheckersGame> CheckerGame { get; set; } = default!;
    public DbSet<CheckersOption> CheckersOptions { get; set; } = default!;
    
    public DbSet<CheckersGameState> CheckersGameStates { get; set; } = default!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

}
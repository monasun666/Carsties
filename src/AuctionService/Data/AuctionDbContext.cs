using System;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;
using AuctionService.Entities;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Auction> Auctions { get; set; }

    
}

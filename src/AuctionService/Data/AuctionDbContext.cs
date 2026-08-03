using System;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;
using AuctionService.Entities;
using MassTransit;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.AddInboxStateEntity();
        modelBuilder.AddOutboxMessageEntity();
        modelBuilder.AddOutboxStateEntity();

    }

    
}

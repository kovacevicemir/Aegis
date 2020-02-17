using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Aegis.Models;

namespace Aegis.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PlayerClass> PlayerClass { get; set; }
        public DbSet<PlayerModel> PlayerModel { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemList> ItemList { get; set; }
        public DbSet<Quest> Quest { get; set; }
        public DbSet<QuestPlayer> QuestPlayer { get; set; }
        public DbSet<Monster> Monster { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Guild> Guild { get; set; }
        public DbSet<GuildBank> GuildBank { get; set; }
        public DbSet<GlobalChat> GlobalChat { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Notification> Notification { get; set; }

    }
}

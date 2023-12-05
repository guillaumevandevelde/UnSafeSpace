using Microsoft.EntityFrameworkCore;
using UnSafeSpace.Domain;

namespace UnSafeSpace.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SpaceMessage>().HasData(

                new SpaceMessage { Id = 1, Message = "We bring you a message of peace", Sender = "Zorg", Recipient="Omicron persei 8" },
                new SpaceMessage { Id = 2, Message = "Ohh, I think there was something funny in that hippie.", Sender ="Lrrr", Recipient = "Earth" },
                new SpaceMessage { Id = 3, Message = "This is ancient Earth's most foolish program. Why does Ross, the largest friend, not simply eat the other five?", Sender = "Lrrr", Recipient = "Ndnd" },
                new SpaceMessage { Id = 4, Message = "Its true what they say, men are from Omicron Persei 7, women are from Omicron Persei 9", Sender = "Ndna", Recipient = "Lrrr"},
                new SpaceMessage { Id = 5, Message = "You see, killbots have a preset kill limit. Knowing their weakness, I sent wave after wave of my own men at them until they reached their limit and shut down.", Sender="Captain Zapp Branegan", Recipient="Kif" }
            );
    }


    public DbSet<SpaceMessage> SpaceMessages { get; set; } = null!;
}

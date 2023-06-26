using AxelosChatBotFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace AxelosChatBotFinal.DAL
{
    public class ChatBotContext : DbContext
    {
        public ChatBotContext(DbContextOptions<ChatBotContext> opt) : base(opt)
        {

        }

        public DbSet<PDFFile> PDFFiles { get; set; }
        public DbSet<SeparatedText> SeparatedTexts { get; set; }

    }
}

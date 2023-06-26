using AxelosChatBotFinal.DAL;
using AxelosChatBotFinal.Models;
using System;
using System.Linq;

namespace AxelosChatBotFinal.Services
{
    public class TextService : ITextService
    {
        private readonly ChatBotContext _context;

        public TextService(ChatBotContext context)
        {
            _context = context;
        }

        public void CreateText(SeparatedText text)
        {
            _context.SeparatedTexts.Add(text);
            _context.SaveChanges();
        }

        
        public void DeleteText(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            var text = GetSeparatedTextById(id);
            if (text == null)
            {
                throw new ArgumentNullException();
            }
            _context.SeparatedTexts.Remove(text);
            _context.SaveChanges();
        }

        public SeparatedText GetSeparatedTextById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            return _context.SeparatedTexts.SingleOrDefault(t => t.Id == id);
        }

        
    }
}

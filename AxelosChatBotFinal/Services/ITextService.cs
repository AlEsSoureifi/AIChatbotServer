using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections.Generic;
using AxelosChatBotFinal.Models;

namespace AxelosChatBotFinal.Services
{
    public interface ITextService
    {
        //IEnumerable<SeparatedText> GetAllTexts();
        SeparatedText GetSeparatedTextById(int id);
        void CreateText(SeparatedText text);
        void DeleteText(int id);
    }
}

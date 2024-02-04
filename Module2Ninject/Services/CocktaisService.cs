using Module2Ninject.Entities;
using Module2Ninject.Loggers;
using Module2Ninject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Services;

public class CocktaisService
{
    private readonly ICocktailsRepository cocktailsRepository;
    private readonly ILogger logger;
    private readonly List<Cocktail> cocktails;

    public CocktaisService(ICocktailsRepository cocktailsRepository, ILogger logger)
    {
        this.cocktailsRepository = cocktailsRepository;
        this.logger = logger;
        this.cocktails = cocktailsRepository.GetCocktails();
    }

    public void PrintAbbreviatedInfo()
    {
        this.logger.Log("Скорочена інформація про всі коктейлі:\n");
        foreach (var cocktail in this.cocktails)
        {
            this.logger.Log($"Коктейль: {cocktail.Name};\nІнгредієнти: {cocktail.Ingredients}\n");
        }
    }

    public void PrintFullInfo()
    {
        this.logger.Log("Повна інформація про всі коктейлі:");
        foreach (var cocktail in this.cocktails)
        {
            this.logger.Log($"\nКоктейль: {cocktail.Name}\nІнгредієнти: {cocktail.Ingredients}\nКраїна, де винайшли: {cocktail.CountryOfInvention}\nРік, коли винайшли: {cocktail.YearOfInvention}");
        }
    }
}

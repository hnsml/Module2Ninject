using Module2Ninject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Repositories;

internal class CocktailsRepository : ICocktailsRepository
{
    private List<Cocktail> cocktails;

    public CocktailsRepository(List<Cocktail> cocktails)
    {
        this.cocktails = cocktails;
    }

    public void DeleteCocktailById(int id)
    {
        var coctailToRemove = cocktails.FirstOrDefault(c => c.Id == id);
        if (coctailToRemove != null)
        {
            this.cocktails.Remove(coctailToRemove);
        }
    }

    public Cocktail GetCocktailById(int id)
    {
        return this.cocktails.FirstOrDefault(c => c.Id == id);
    }

    public List<Cocktail> GetCocktails()
    {
        return this.cocktails;
    }

    public void SaveCocktail(Cocktail cocktail)
    {
        this.cocktails.Add(cocktail);
    }

    public void SaveCocktails(List<Cocktail> cocktails)
    {
        this.cocktails.AddRange(cocktails);
    }
}

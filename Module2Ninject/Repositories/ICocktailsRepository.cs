using Module2Ninject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Repositories;

public interface ICocktailsRepository
{
    List<Cocktail> GetCocktails();

    Cocktail GetCocktailById(int id);

    void SaveCocktail(Cocktail coctail);

    void DeleteCocktailById(int id);

    void SaveCocktails(List<Cocktail> cocktails);
}

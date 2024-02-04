using Module2Ninject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Repositories
{
    public interface IGameCharacterRepositories
    {
        List<GameCharacter> GetGameCharacters();

        GameCharacter GetGameCharacterById(int id);

        void SaveGameCharacter(GameCharacter coctail);

        void DeleteGameCharacterById(int id);

        void SaveGameCharacters(List<GameCharacter> gameCharacters);
    }
}

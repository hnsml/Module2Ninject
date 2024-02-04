using Module2Ninject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Repositories
{
    internal class GameCharacterRepositories : IGameCharacterRepositories
    {
        private List<GameCharacter> gameCharacters;

        public GameCharacterRepositories(List<GameCharacter> gameCharacters)
        {
            this.gameCharacters = gameCharacters;
        }

        public void DeleteGameCharacterById(int id)
        {
            var coctailToRemove = gameCharacters.FirstOrDefault(c => c.Id == id);
            if (coctailToRemove != null)
            {
                this.gameCharacters.Remove(coctailToRemove);
            }
        }

        public GameCharacter GetGameCharacterById(int id)
        {
            return this.gameCharacters.FirstOrDefault(c => c.Id == id);
        }

        public List<GameCharacter> GetGameCharacters()
        {
            return this.gameCharacters;
        }

        public void SaveGameCharacter(GameCharacter gameCharacter)
        {
            this.gameCharacters.Add(gameCharacter);
        }

        public void SaveGameCharacters(List<GameCharacter> gameCharacters)
        {
            this.gameCharacters.AddRange(gameCharacters);
        }
    }
}

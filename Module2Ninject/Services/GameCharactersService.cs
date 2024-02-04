using Module2Ninject.Entities;
using Module2Ninject.Loggers;
using Module2Ninject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Services;

public class GameCharactersService
{
    private readonly IGameCharacterRepositories gameCharacterRepositories;
    private readonly ILogger logger;
    private readonly List<GameCharacter> gameCharacters;

    public GameCharactersService(IGameCharacterRepositories gameCharacterRepositories, ILogger logger)
    {
        this.gameCharacterRepositories = gameCharacterRepositories;
        this.logger = logger;
        this.gameCharacters = gameCharacterRepositories.GetGameCharacters();
    }

    public void PrintInfo()
    {
        this.logger.Log("Інформація про ігрових персонажів:");
        foreach (var gameCharacter in this.gameCharacters)
        {
            this.logger.Log($"\nФорма: {gameCharacter.Name}\nЗброя: {gameCharacter.Weapon}\nУрон: {gameCharacter.Damage}");
        }
    }
}

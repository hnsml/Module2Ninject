using Module2Ninject.Modules;
using Ninject;
using Module2Ninject.Entities;
using Module2Ninject.Repositories;
using Module2Ninject.Services;
using Module2Ninject.Logger;
using Module2Ninject.Loggers;
using System.Text;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        IKernel kernel = new StandardKernel(new NinjectBindings());
        ILogger consoleLogger = kernel.Get<ConsoleLogger>();
        ILogger fileLogger = kernel.Get<FileLogger>();

        Console.WriteLine("Для продовження необхідно буде натиснути будь-яку клавішу\nТе, що виводиться в консоль також записується у файл log.txt");
        Console.ReadKey();
        Console.Clear();
        Task1Cocktails(kernel, consoleLogger, fileLogger);
        Task2GameCharacters(kernel, consoleLogger, fileLogger);
        Task3Figures(kernel, consoleLogger, fileLogger);
        Task4Devices(kernel, consoleLogger, fileLogger);
    }

    static void Task1Cocktails(IKernel kernel, ILogger consoleLogger, ILogger fileLogger)
    {
        ICocktailsRepository coctailsRepository = kernel.Get<ICocktailsRepository>();
        Cocktail old_fashioned = new Cocktail
        {
            Name = "Старомодний",
            Ingredients = "50 мл віскі\r\n2 деша гіркої настоянки Angostura (Ангостура)\r\n1 невеликий шматок цукру\r\nкілька крапель содової води\r\nполовина кружка апельсина\r\nкоктейльна вишня\r\nлимонна цедра",
            CountryOfInvention = "Нью-Йорк",
            YearOfInvention = 1867,
        };

        Cocktail negroni = new Cocktail
        {
            Name = "Негроні",
            Ingredients = " 30 мл лондонського сухого джина\r\n30 мл червоного вермута\r\n30 мл червоний бітера\r\n1 шт апельсинової цедри\r\n120 г лід у кубиках",
            CountryOfInvention = "Італія",
            YearOfInvention = 1919,
        };

        Cocktail daiquiri = new Cocktail
        {
            Name = "Дайкірі",
            Ingredients = "60 мл білого рому\r\n15 мл цукрового сиропу\r\n30 мл лаймового соку\r\n200 г лід у кубиках",
            CountryOfInvention = "Куба",
            YearOfInvention = 1817,
        };

        coctailsRepository.SaveCocktails(new List<Cocktail> { old_fashioned, negroni, daiquiri, });

        var cocktailsServices = new CocktaisService(coctailsRepository, consoleLogger);
        cocktailsServices.PrintAbbreviatedInfo();
        Console.ReadKey();
        Console.Clear();
        cocktailsServices.PrintFullInfo();
        Console.ReadKey();
        Console.Clear();

        var cocktailsFileServices = new CocktaisService(coctailsRepository, fileLogger);
        cocktailsFileServices.PrintAbbreviatedInfo();
        cocktailsFileServices.PrintFullInfo();
    }

    static void Task2GameCharacters(IKernel kernel, ILogger consoleLogger, ILogger fileLogger)
    {
        IGameCharacterRepositories gameCharacterRepositories = kernel.Get<IGameCharacterRepositories>();
        gameCharacterRepositories.SaveGameCharacters(new List<GameCharacter> { new Swordsman(), new Spearman(), new Bowman(), });

        var gameCharactersServices = new GameCharactersService(gameCharacterRepositories, consoleLogger);
        gameCharactersServices.PrintInfo();

        var gameCharactersFileServices = new GameCharactersService(gameCharacterRepositories, fileLogger);
        gameCharactersFileServices.PrintInfo();
        Console.ReadKey();
        Console.Clear();
    }

    static void Task3Figures(IKernel kernel, ILogger consoleLogger, ILogger fileLogger)
    {
        IFigureRepository figureRepository = kernel.Get<IFigureRepository>();
        Figure circle = new Figure
        {
            Name = "Коло",
            View = "●",
            NumberOfAngles = 0,
            AreaFormula = "S = πr²",
        };

        Figure square = new Figure
        {
            Name = "Квадрат",
            View = "■",
            NumberOfAngles = 4,
            AreaFormula = "S = 4a",
        };

        Figure triangle = new Figure
        {
            Name = "Трикутник",
            View = "▲",
            NumberOfAngles = 3,
            AreaFormula = "S = 1/2 bh",
        };

        figureRepository.SaveFigures(new List<Figure> { circle, square, triangle, });

        var figuresServices = new FiguresService(figureRepository, consoleLogger);
        figuresServices.PrintAbbreviatedInfo();
        Console.ReadKey();
        Console.Clear();
        figuresServices.PrintFullInfo();

        var figuresFileServices = new FiguresService(figureRepository, fileLogger);
        figuresFileServices.PrintAbbreviatedInfo();
        figuresFileServices.PrintFullInfo();
    }

    static void Task4Devices(IKernel kernel, ILogger consoleLogger, ILogger fileLogger)
    {
        IDeviceRepository deviceRepository = kernel.Get<IDeviceRepository>();

        Device refrigerator = new Device
        {
            Name = "Холодильник",
            Purpose = "для зберігання продуктів",
            Inventor = "Фердинанд Карре",
            Destination = "кухня",
        };

        Device dryer = new Device
        {
            Name = "Сушильна машина",
            Purpose = "для просушки білизни",
            Inventor = "Росс Мур",
            Destination = "ванна або кладова",
        };

        Device coffee_maker = new Device
        {
            Name = "Кавоварка",
            Purpose = "заспокоїти душу та серце або розслабитися",
            Inventor = "де Беллуа",
            Destination = "кухня",
        };

        deviceRepository.SaveDevices(new List<Device> { refrigerator, dryer, coffee_maker, });

        var devicesServices = new DevicesService(deviceRepository, consoleLogger);
        devicesServices.PrintAbbreviatedInfo();
        Console.ReadKey();
        Console.Clear();
        devicesServices.PrintFullInfo();

        var devicesFileServices = new DevicesService(deviceRepository, fileLogger);
        devicesFileServices.PrintAbbreviatedInfo();
        devicesFileServices.PrintFullInfo();
    }
}
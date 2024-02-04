using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2Ninject.Repositories;
using Module2Ninject.Logger;
using Module2Ninject.Loggers;

namespace Module2Ninject.Modules;

public class NinjectBindings : NinjectModule
{
    public override void Load()
    {
        this.Bind<ILogger>().To<ConsoleLogger>();
        this.Bind<FileLogger>().ToSelf().WithConstructorArgument("filePath", "log.txt");
        this.Bind<ICocktailsRepository>().To<CocktailsRepository>();
        this.Bind<IGameCharacterRepositories>().To<GameCharacterRepositories>();
        this.Bind<IFigureRepository>().To<FigureRepository>();
        this.Bind<IDeviceRepository>().To<DeviceRepository>();
    }
}

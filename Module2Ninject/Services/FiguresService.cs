using Module2Ninject.Entities;
using Module2Ninject.Loggers;
using Module2Ninject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Services;

public class FiguresService
{
    private readonly IFigureRepository figuresRepository;
    private readonly ILogger logger;
    private readonly List<Figure> figures;

    public FiguresService(IFigureRepository figuresRepository, ILogger logger)
    {
        this.figuresRepository = figuresRepository;
        this.logger = logger;
        this.figures = figuresRepository.GetFigures();
    }

    public void PrintAbbreviatedInfo()
    {
        this.logger.Log("Скорочена інформація про всі фігури:\n");
        foreach (var figure in this.figures)
        {
            this.logger.Log($"Фігура: {figure.Name};\nВигляд: {figure.View}\n");
        }
    }

    public void PrintFullInfo()
    {
        this.logger.Log("Повна інформація про всі фігури:");
        foreach (var figure in this.figures)
        {
            this.logger.Log($"\nФігура: {figure.Name}\nВигляд: {figure.View}\nКількість кутів: {figure.NumberOfAngles}\nФормула площі: {figure.AreaFormula}");
        }
    }
}

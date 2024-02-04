using Module2Ninject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Repositories;

public class FigureRepository : IFigureRepository
{
    private List<Figure> figures;

    public FigureRepository(List<Figure> figures)
    {
        this.figures = figures;
    }

    public void DeleteFigureById(int id)
    {
        var coctailToRemove = this.figures.FirstOrDefault(c => c.Id == id);
        if (coctailToRemove != null)
        {
            this.figures.Remove(coctailToRemove);
        }
    }

    public Figure GetFigureById(int id)
    {
        return this.figures.FirstOrDefault(c => c.Id == id);
    }

    public List<Figure> GetFigures()
    {
        return this.figures;
    }

    public void SaveFigure(Figure figure)
    {
        this.figures.Add(figure);
    }

    public void SaveFigures(List<Figure> figures)
    {
        this.figures.AddRange(figures);
    }
}

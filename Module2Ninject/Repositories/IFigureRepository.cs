using Module2Ninject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Repositories;

public interface IFigureRepository
{
    List<Figure> GetFigures();

    Figure GetFigureById(int id);

    void SaveFigure(Figure figure);

    void DeleteFigureById(int id);

    void SaveFigures(List<Figure> figures);
}

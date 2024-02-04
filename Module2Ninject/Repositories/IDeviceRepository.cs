using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2Ninject.Entities;
namespace Module2Ninject.Repositories;

public interface IDeviceRepository
{
    List<Device> GetDevices();

    Device GetDeviceById(int id);

    void SaveDevice(Device coctail);

    void DeleteDeviceById(int id);

    void SaveDevices(List<Device> devices);
}

using Module2Ninject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Repositories;

internal class DeviceRepository : IDeviceRepository
{
    private List<Device> devices;

    public DeviceRepository(List<Device> devices)
    {
        this.devices = devices;
    }

    public void DeleteDeviceById(int id)
    {
        var coctailToRemove = devices.FirstOrDefault(c => c.Id == id);
        if (coctailToRemove != null)
        {
            this.devices.Remove(coctailToRemove);
        }
    }

    public Device GetDeviceById(int id)
    {
        return this.devices.FirstOrDefault(c => c.Id == id);
    }

    public List<Device> GetDevices()
    {
        return this.devices;
    }

    public void SaveDevice(Device device)
    {
        this.devices.Add(device);
    }

    public void SaveDevices(List<Device> devices)
    {
        this.devices.AddRange(devices);
    }
}

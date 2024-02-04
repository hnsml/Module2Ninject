using Module2Ninject.Entities;
using Module2Ninject.Loggers;
using Module2Ninject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Services;

public class DevicesService
{
    private readonly IDeviceRepository devicesRepository;
    private readonly ILogger logger;
    private readonly List<Device> devices;

    public DevicesService(IDeviceRepository devicesRepository, ILogger logger)
    {
        this.devicesRepository = devicesRepository;
        this.logger = logger;
        this.devices = devicesRepository.GetDevices();
    }

    public void PrintAbbreviatedInfo()
    {
        this.logger.Log("Коротка інформація про всі прилади:\n");
        foreach (var device in this.devices)
        {
            this.logger.Log($"Прилад: {device.Name};\nПризначення: {device.Purpose}\n");
        }
    }

    public void PrintFullInfo()
    {
        this.logger.Log("Повна інформація про всі прилади:");
        foreach (var device in this.devices)
        {
            this.logger.Log($"\nПрилад: {device.Name}\nПризначення: {device.Purpose}\nВинахідник: {device.Inventor}\nМісце призначення: {device.Destination}");
        }
    }
}

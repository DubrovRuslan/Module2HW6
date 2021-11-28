using Module2HW6.Helpers;
using Module2HW6.Models;
using Module2HW6.Models.Abstractions;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class ElectricalApplianceService : IElectricalApplianceService
    {
        private readonly IElectricalApplianceProvider _electricalApplianceProvider;
        public ElectricalApplianceService(IElectricalApplianceProvider electricalApplianceProvider)
        {
            _electricalApplianceProvider = electricalApplianceProvider;
        }

        public ElectricalAppliance[] GetAllElectricalAppliances()
        {
            return _electricalApplianceProvider.GetAllAppliances();
        }

        public bool AddNewBuiltInFridge(string name, int power, double width, double height, double depth, bool presenceOfFacade, int shelvesCount)
        {
            var builtInFridge = new BuiltInFridge
            {
                Name = name, Power = power,
                IsEnable = false,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                ShelvesCount = shelvesCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInFridge);
        }

        public bool AddNewBuiltInHob(string name, int power, double width, double height, double depth, bool presenceOfFacade, int burnersCount)
        {
            var builtInHob = new BuiltInHob
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                BurnersCount = burnersCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInHob);
        }

        public bool AddNewBuiltInOven(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection)
        {
            var builtInOven = new BuiltInOven
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                IsConvection = isConvection
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInOven);
        }

        public bool AddNewBuiltInWasher(string name, int power, double width, double height, double depth, bool presenceOfFacade, bool isConvection, int weightOfLaundry)
        {
            var builtInWasher = new BuiltInWasher
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                PresenceOfFacade = presenceOfFacade,
                WeightOfLaundry = weightOfLaundry
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(builtInWasher);
        }

        public bool AddNewFridge(string name, int power, double width, double height, double depth, bool isFreezerfreezer, int numberOfShelves)
        {
            var fridge = new Fridge
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                IsFreezerfreezer = isFreezerfreezer,
                NumberOfShelves = numberOfShelves
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(fridge);
        }

        public bool AddNewHoover(string name, int power, int containerVolume, bool isAqua)
        {
            var hoover = new Hoover
            {
                Name = name,
                Power = power,
                ContainerVolume = containerVolume,
                IsAqua = isAqua
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(hoover);
        }

        public bool AddNewIron(string name, int power, bool isSteamer)
        {
            var iron = new Iron
            {
                Name = name,
                Power = power,
                IsSteamer = isSteamer
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(iron);
        }

        public bool AddNewKettle(string name, int power, int volume)
        {
            var kettle = new Kettle
            {
                Name = name,
                Power = power,
                Volume = volume
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(kettle);
        }

        public bool AddNewSmartHoover(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int containerVolume)
        {
            var smartHoover = new SmartHoover
            {
                Name = name,
                Power = power,
                ConnectionType = smartConnectionType,
                OperatingSystem = operatingSystem,
                ContainerVolume = containerVolume,
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(smartHoover);
        }

        public bool AddNewSmartKettle(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int volume)
        {
            var smartKettle = new SmartKettle
            {
                Name = name,
                Power = power,
                ConnectionType = smartConnectionType,
                OperatingSystem = operatingSystem,
                Volume = volume
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(smartKettle);
        }

        public bool AddNewSmartMulticooker(string name, int power, SmartConnectionType smartConnectionType, string operatingSystem, int programsCount)
        {
            var smartMulticooker = new SmartMulticooker
            {
                Name = name,
                Power = power,
                ConnectionType = smartConnectionType,
                OperatingSystem = operatingSystem,
                ProgramsCount = programsCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(smartMulticooker);
        }

        public bool AddNewStove(string name, int power, double width, double height, double depth, int burnersCount)
        {
            var stove = new Stove
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                BurnersCount = burnersCount
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(stove);
        }

        public bool AddNewWasher(string name, int power, double width, double height, double depth, int weightOfLaundry)
        {
            var washer = new Washer
            {
                Name = name,
                Power = power,
                Width = width,
                Height = height,
                Depth = depth,
                WeightOfLaundry = weightOfLaundry
            };
            return _electricalApplianceProvider.AddNewElectricalAppliance(washer);
        }

        public ElectricalAppliance[] SearchApplianceByName(string name)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByName(name));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByPower(int maxPower, int minPower)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByPower(maxPower, minPower));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByPower(int maxPower)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByPower(maxPower));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceByType(ElectricalApplianceType electricalApplianceType)
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceByType(electricalApplianceType));
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceBySmart()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceBySmart());
            }

            return result;
        }

        public ElectricalAppliance[] SearchApplianceIsEnable()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            ElectricalAppliance[] result = null;
            foreach (var item in allAppliances)
            {
                ArrayHelper.AddElementToArray(ref result, item.GetElectricalApplianceIsOn());
            }

            return result;
        }

        public void SortAppliancesByName()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return;
            }

            System.Array.Sort(allAppliances, new ElectricalApplianceNameComparer());
        }

        public void SortAppliancesByPower()
        {
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return;
            }

            System.Array.Sort(allAppliances, new ElectricalAppliancePowerComparer());
        }

        public int? GetTotalPowerUsed()
        {
            var result = 0;
            var allAppliances = _electricalApplianceProvider.GetAllAppliances();
            if (allAppliances == null)
            {
                return null;
            }

            foreach (var item in allAppliances)
            {
                if (item.IsEnable)
                {
                    result += item.Power;
                }
            }

            return result;
        }

        public void PowerOn(ElectricalAppliance[] electricalAppliancesToOn)
        {
            foreach (var item in electricalAppliancesToOn)
            {
                item.IsEnable = true;
            }
        }

        public void PowerOf(ElectricalAppliance[] electricalAppliancesToOff)
        {
            foreach (var item in electricalAppliancesToOff)
            {
                item.IsEnable = false;
            }
        }
    }
}

namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smartHome = new SmartHomeSystem();

            smartHome.DeviceStateChanged += (sender, args) =>
            {
                Console.WriteLine($"[{args.ChangeTime:HH:mm:ss}] {args.DeviceType}: {args.NewState}");
            };

            smartHome.UnlockDoor();
            Thread.Sleep(1000);
            smartHome.TurnOnLight();
            Thread.Sleep(1000);
            smartHome.SetTemperature(24);
            Thread.Sleep(1000);
            smartHome.TurnOffLight();
            Thread.Sleep(2000);
            smartHome.LockDoor();

        }
    }
    public class SmartHomeSystem
    {
        public enum DeviceType { Light, Thermostat, Door }

        public class DeviceStateChangedEventArgs : EventArgs
        {
            public DeviceType DeviceType { get; }
            public string NewState { get; }
            public DateTime ChangeTime { get; }

            public DeviceStateChangedEventArgs(DeviceType type, string state)
            {
                DeviceType = type;
                NewState = state;
                ChangeTime = DateTime.Now;
            }
        }

        public event EventHandler<DeviceStateChangedEventArgs> DeviceStateChanged;

        private bool _isLightOn;
        private int _temperature;
        private bool _isDoorLocked;

        public void TurnOnLight()
        {
            _isLightOn = true;
            OnDeviceStateChanged(DeviceType.Light, "Включен");
        }

        public void TurnOffLight()
        {
            _isLightOn = false;
            OnDeviceStateChanged(DeviceType.Light, "Выключен");
        }

        public void SetTemperature(int newTemp)
        {
            _temperature = newTemp;
            OnDeviceStateChanged(DeviceType.Thermostat, $"Температура изменена на {newTemp}°C");
        }

        public void LockDoor()
        {
            _isDoorLocked = true;
            OnDeviceStateChanged(DeviceType.Door, "Заблокирована");
        }

        public void UnlockDoor()
        {
            _isDoorLocked = false;
            OnDeviceStateChanged(DeviceType.Door, "Разблокирована");
        }

        protected virtual void OnDeviceStateChanged(DeviceType type, string state)
        {
            DeviceStateChanged?.Invoke(this,
                new DeviceStateChangedEventArgs(type, state));
        }
    }
}

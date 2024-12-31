namespace CarRental.UI.Shared
{
    public class VehicleStateContainer
    {
        public event Func<Task>? StateChangedEvent;
        public async Task NotifyStateChanged()
        {
            if (StateChangedEvent != null)
                await StateChangedEvent.Invoke();
        }
    }
}

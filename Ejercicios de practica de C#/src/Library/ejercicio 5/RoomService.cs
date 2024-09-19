using System.Net;

namespace Library;

public class RoomService
{
    public string ServiceName;
    public double ServicePrice;
    public RoomService(string ServiceName, double ServicePrice)
    {
        this.ServiceName = ServiceName;
        this.ServicePrice = ServicePrice;
    }
}
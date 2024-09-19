namespace Library;

public class Room
{
    public int RoomNumber;
    public int MaxGuests;
    public bool IsOccupied;
    public GuestGroup guestGroup; //TODO para saber el num de personas alojadas (hacer un get y set).    
    public RoomBill roomBill;

    public Room(int RoomNumb, List<RoomService> RoomServices, double PricePerNightToPay)
    {
        this.RoomNumber = RoomNumb;
        this.MaxGuests = 4;
        this.IsOccupied = false;
        this.roomBill = new RoomBill(RoomServices, PricePerNightToPay);
        this.guestGroup = new GuestGroup();
    }
    public void GetRoomSevice(RoomService roomServiceToAdd) //recive directo el servicio que se quiere agregar a la cuenta
    {
        this.roomBill.AddServiceToBill(roomServiceToAdd);
    }

    public void PrintRoomServices()
    {
        Console.WriteLine("Servicios a la habitacion:");
        foreach (var services in this.roomBill.RoomServices)
        {    
            Console.WriteLine($"- {services.ServiceName} por ${services.ServicePrice}");
        }
    }

}
namespace Library;

public class Hotel
{
    public string HotelName{ get;}
    public int HotelRooms
    {
        get {return HotelRooms;}
        set 
        {
            HotelRooms = 0;
            foreach (var elem in this.Rooms)
            {
                HotelRooms++;
            }
        }
    }
    public List<Room> Rooms;
    public List<RoomService> AvailableServices
    {
        get { return AvailableServices; }
        set {}
    }


    public Hotel(string HotelName)
    {
        this.HotelName = HotelName;
        this.HotelRooms = 0;
        this.Rooms = new List<Room> ();
        this.AvailableServices = new List<RoomService>();                                
    }
    public void CheckIn(int AmmountOfPeople, int DaysToStayInHotel) //recibe datos de guestGroup (cuantos son y cuantos dias se quedan)
    {
        bool HotelIsFull = true;
        int roomAvailableSlotInList= -1;
        foreach (var elem in this.Rooms)
        {
            roomAvailableSlotInList++;
            if (elem.IsOccupied == false)
            {
                HotelIsFull = false;
            }
        }
        if (HotelIsFull == true)
        {
            Console.WriteLine("el hotel esta lleno");
        }
        else if (HotelIsFull == false)
        {
            if (AmmountOfPeople > this.Rooms[roomAvailableSlotInList].MaxGuests)
            {
                Console.WriteLine($"La habitacion no permite ese numero de personas, maximo: {this.Rooms[roomAvailableSlotInList].MaxGuests}");
            }
            this.Rooms[roomAvailableSlotInList].IsOccupied = true;
            this.Rooms[roomAvailableSlotInList].guestGroup.GuestsNumber = AmmountOfPeople;
            this.Rooms[roomAvailableSlotInList].guestGroup.DaysToStay = DaysToStayInHotel;
            this.Rooms[roomAvailableSlotInList].roomBill.DaysToStay = DaysToStayInHotel;
            
            Console.WriteLine($"La habitacion ha sido reservada:\n- Numero de habitacion: {this.Rooms[roomAvailableSlotInList].RoomNumber}\n- Dias a quedarse: {this.Rooms[roomAvailableSlotInList].roomBill.DaysToStay}\n- Precio por noche: {this.Rooms[roomAvailableSlotInList].roomBill.DaysToStay}");

        }
    }

    public void CheckOut(int RoomNumb)
    {

        this.Rooms[RoomNumb-1].IsOccupied = false;
        this.Rooms[RoomNumb-1].guestGroup.DaysToStay = 0;
        this.Rooms[RoomNumb-1].guestGroup.GuestsNumber = 0;
        this.Rooms[RoomNumb-1].roomBill.DaysToStay = 0;
        
    }

    public void ConstruirHabitaciones(Room room)
    {
        room.roomBill.RoomServices = this.AvailableServices;
        room.RoomNumber = Rooms.Count + 2;
        room.IsOccupied = false;
        this.Rooms.Add(room);
        this.HotelRooms++;
    }

    public void AgregarUnNuevoServicio(RoomService roomService)
    {
        bool NewServiceIsOnList = false;
        AvailableServices.Add(roomService);
        foreach (var elem1 in Rooms)
        {
            foreach (var elem2 in elem1.roomBill.RoomServices)
            {
                if (elem2.ServiceName == roomService.ServiceName)
                {
                    NewServiceIsOnList = true;
                }
                
            }
            if (NewServiceIsOnList == false)
            {
                elem1.roomBill.RoomServices.Add(roomService);
                NewServiceIsOnList = false;
            }
        }
    }

}

namespace Library.Tests;

public class TestsEjercicio5
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Hotel HotelPepe = new Hotel("Hotel pepe");

        RoomService LimpiarHabitacion = new RoomService("Limpiar habitacion", 15);
        RoomService LLevarAlmuerzo = new RoomService("LLevar almuerzo", 10);
        HotelPepe.AgregarUnNuevoServicio(LimpiarHabitacion);
        HotelPepe.AgregarUnNuevoServicio(LLevarAlmuerzo);

        Room room1 = new Room(1,HotelPepe.AvailableServices, 20);
        Room room2 = new Room(2,HotelPepe.AvailableServices, 22); 
        Room room3 = new Room(3,HotelPepe.AvailableServices, 14);
        Room room4 = new Room(4,HotelPepe.AvailableServices, 19);
        HotelPepe.ConstruirHabitaciones(room1);
        HotelPepe.ConstruirHabitaciones(room2);
        HotelPepe.ConstruirHabitaciones(room3);
        HotelPepe.ConstruirHabitaciones(room4);

        HotelPepe.CheckIn(3,5);
        

    }
}
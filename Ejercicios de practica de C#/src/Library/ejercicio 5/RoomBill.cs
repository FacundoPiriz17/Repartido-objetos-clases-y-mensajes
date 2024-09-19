using System.Security.Cryptography.X509Certificates;

namespace Library;

public class RoomBill
{
    public double PricePerNight;
    public int DaysToStay;
    public List<RoomService> RoomServices = new List<RoomService> ();
    public RoomBill(List<RoomService> RoomServices, double PricePerNightToPay)
    {
        this.PricePerNight = PricePerNightToPay;
        this.RoomServices = RoomServices;
    } 

    public double GetTotalBill() 
    {
        double TotalAmountToPayForStay;
        TotalAmountToPayForStay = this.PricePerNight * this.DaysToStay;
        foreach (var i in this.RoomServices)
        {
            TotalAmountToPayForStay = TotalAmountToPayForStay + i.ServicePrice;
        }
        return TotalAmountToPayForStay;
    }

    public void AddServiceToBill(RoomService roomServiceAdded)
    {
        this.RoomServices.Add(roomServiceAdded);
    }

    //no se usa este meotodo
    public void ResetBill()
    {
        this.DaysToStay = 0;

    }

    
}
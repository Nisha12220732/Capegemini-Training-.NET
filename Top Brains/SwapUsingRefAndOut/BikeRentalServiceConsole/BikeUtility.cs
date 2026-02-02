using System.Collections.Immutable;

namespace BikeRentalServiceConsole;
public class BikeUtility
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public void AddBikeDetails(string brand, string model, int ppd)
    {
        bikeDetails.Add(bikeDetails.Count + 1,new Bike(brand,model,ppd));
    }

    public SortedDictionary<string,List<Bike>> GroupBikesByBrand()
    {
        return new SortedDictionary<string, List<Bike>>(bikeDetails.Values.GroupBy(b => b.Brand).ToDictionary(g => g.Key, g=> g.ToList()));
    }


}
using System;
class Program
{
    public class EstimateDetails
    {
        public float ConstructionArea { get; set; }

        public float SiteArea { get; set; }

        public void ValidateConstructionEstimate(float constructionArea, float siteArea)
        {

            if ( siteArea >= constructionArea)
            {
                Console.WriteLine("Construction is Allowed");
                
            }
            else
            {
                throw new ConstructionEstimateException("Sorry your Construction Estimate is not approved!");
            }
        }
    }

    internal class ConstructionEstimateException : Exception
    {
        public ConstructionEstimateException()
        {

        }

        public ConstructionEstimateException(string message) : base(message)
        {

        }
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your Construction Details: ");
            EstimateDetails newsite = new EstimateDetails();
            Console.WriteLine("Enter Construction Area : ");
            newsite.ConstructionArea = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Site Area : ");
            newsite.SiteArea = float.Parse(Console.ReadLine());

            newsite.ValidateConstructionEstimate(newsite.ConstructionArea,newsite.SiteArea);
        }
        catch (ConstructionEstimateException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
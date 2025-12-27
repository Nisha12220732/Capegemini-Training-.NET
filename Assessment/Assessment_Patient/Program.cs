using System;
using System.Collections.Specialized;
using System.Text;
using Assessment_Patient;

class Program
{
static bool HasLastBill = false;
static PatientBill LastBill;
static void Main(string[] args)
{
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();

            Console.Write("Enter your option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewBill();
                    break;

                case "2":
                    ViewLastBill();
                    break;

                case "3":
                    ClearLastBill();
                    break;

                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

static void DisplayMenu()
{
System.Console.WriteLine("=============== Medisure Clinic Billing ==================");
System.Console.WriteLine("1. Create New Bill (Enter Patient Details)");
System.Console.WriteLine("2. View Last Bill");
System.Console.WriteLine("3. Clear Last Bill");
System.Console.WriteLine("4. Exit");
}

static void CreateNewBill()
{
    PatientBill patient1 = new PatientBill();
    System.Console.WriteLine("Enter BillID: ");
    patient1.BillID = Console.ReadLine();
    System.Console.WriteLine("Enter Patient Name: ");
    patient1.PatientName = Console.ReadLine();
    System.Console.WriteLine("Is the Patient Insured? (Y/N) :");
    string Insurance= Console.ReadLine();
        if(Insurance == "Y")
        {
            patient1.HasInsurance = true;
        }
        else
        {
            patient1.HasInsurance = false;
        }

    System.Console.WriteLine("Enter Consultation Fee: ");
    patient1.ConsultationFee = Decimal.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter Lab Charges: ");
    patient1.LabCharges = Decimal.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter Medicine Charges: ");
    patient1.MedicineCharges = Decimal.Parse(Console.ReadLine());
    patient1.CalculateBill();

    LastBill = patient1;
    HasLastBill = true;

    Console.WriteLine("\nBill created successfully.");
            Console.WriteLine($"Gross Amount: {patient1.GrossAmount:F2}");
            Console.WriteLine($"Discount Amount: {patient1.DiscountAmount:F2}");
            Console.WriteLine($"Final Payable: {patient1.FinalPayable:F2}");
            Console.WriteLine("------------------------------------------------------------");
    
        
}

static void ViewLastBill()
{
    if (!HasLastBill)
    {
        Console.WriteLine("No bill available. Please create a new bill first.");
        return;
    }

    Console.WriteLine("----------- Last Bill -----------");
    Console.WriteLine($"BillId: {LastBill.BillID}");
    Console.WriteLine($"Patient: {LastBill.PatientName}");
    Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
    Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
    Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
    Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
    Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
    Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
    Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
}

static void ClearLastBill()
{
    LastBill = null;
    HasLastBill = false;
    Console.WriteLine("Last bill cleared.");
}
}
}

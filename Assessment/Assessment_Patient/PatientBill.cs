using System;
namespace Assessment_Patient
{
    public class PatientBill
    {
        public string BillID {get;set;}
        public string PatientName {get;set;}
        public bool HasInsurance {get; set;}
        public decimal ConsultationFee {get;set;}
        public decimal LabCharges {get; set;}
        public decimal MedicineCharges {get;set;}

        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalPayable { get; set; }

        // Billing calculation method
        public void CalculateBill()
        {
            GrossAmount = ConsultationFee + LabCharges + MedicineCharges;

            if (HasInsurance)
            {
                DiscountAmount = GrossAmount * 0.10m;
            }
            else
            {
                DiscountAmount = 0;
            }

            FinalPayable = GrossAmount - DiscountAmount;
        }
        
    }
}
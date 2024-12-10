namespace HOSPITALMANAGEMENTSYSTEM
{
    class Treatment 
    {

        public string TreatmentName;

        public string? Medication;

        public string Dosage;


        // Constructor initializes treatment details with optional medication
        public Treatment(string treatmentname,  string dosage, string medication="None")
        {
            this.TreatmentName = treatmentname;
            this.Medication = medication;
            this.Dosage = dosage;
        }


        // Displaying the treatment details
        public void DisplayTreatmentDetails()
        {
            Console.WriteLine("\nDetails of your Treatment: ");
            Console.WriteLine($"\nTreatment: {TreatmentName}\nDosage: {Dosage}");

        }


        
    }


}
namespace HOSPITALMANAGEMENTSYSTEM
{
    
    class Program
    {

        static void Main()
        {
            // Creating doctors with names, specializations, and unique IDs
            Doctor doctor1 = new("Dr. Alice", "Cardiologist", 1001);
            Doctor doctor2 = new("Dr. Emily", "Dermatologist", 1002);

            // Creating treatments with names, optional medication, and dosage information
            Treatment treatment1 = new("Treatment-1", "N/A");
            Treatment treatment2 = new("Treatment-2", "Medicine-1", "50mg");
            Treatment skintreatment = new("Skin Treatment", "Skin Cream", "Apply twice daily");

            // Creating patients with names and unique IDs
            Patient patient1 = new("Charlie", 4002);
            Patient patient2 = new("Anna", 4040);

            // Creating appointments by associating doctors, patients, and appointment IDs
            Appointment appointment1 = new(1, DateTime.Parse("2024-10-15"), doctor1, patient1);
            Appointment appointment2 = new(2, DateTime.Parse("2024-10-20"), doctor2, patient2);

            // Adding treatments to each appointment
            appointment1.AddTreatment(treatment1);
            appointment1.AddTreatment(treatment2);
            appointment2.AddTreatment(skintreatment);

            // Linking appointments to patients and displaying their details
            patient1.BookAppointmentWithDoctor(appointment1);
            appointment1.DisplayAppointmentDetails();

            patient2.BookAppointmentWithDoctor(appointment2);
            appointment2.DisplayAppointmentDetails();

        }
    }
}
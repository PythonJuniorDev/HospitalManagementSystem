namespace HOSPITALMANAGEMENTSYSTEM
{

    class Appointment
    {

        public int AppointmentID;

        public DateTime Date;

        public Doctor Doctor;

        public Patient Patient;

        // List to store prescribed treatments
        List<Treatment> prescribed_treatments {get; set;} = new List<Treatment>();

        // Constructor initializes appointment details
        public Appointment(int appointmentID, DateTime date, Doctor doctor, Patient patient)
        {
            this.AppointmentID = appointmentID;
            this.Date = date;
            this.Doctor = doctor;
            this.Patient = patient;
        }


        // Adds a treatment to the list of prescribed treatments
        public void AddTreatment(Treatment treatment)
        {
            prescribed_treatments.Add(treatment);
        }


        // Displays all details of the appointment, including treatments
        public void DisplayAppointmentDetails()
        {
            Console.WriteLine("\nDetails of your appointment: ");
            Console.WriteLine($"\nAppointmentID: {AppointmentID}\nDate: {Date.ToString("MMMM dd, yyyy")}\nDoctor: {Doctor.Name} (Specialization: {Doctor.Specialization})\nPatient: {Patient.Name}");

            foreach (Treatment treatment in prescribed_treatments)
            {
                Console.WriteLine($"\nTreatment: {treatment.TreatmentName}");
                Console.WriteLine($"Medication: {treatment.Medication}");
                Console.WriteLine($"Dosage: {treatment.Dosage}\n");
                
            }
        }


    }



}
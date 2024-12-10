namespace HOSPITALMANAGEMENTSYSTEM
{
    class Patient
    {

        public string Name;
        public int PatientID;

        private List<Appointment> patient_appointments = new List<Appointment>();

        public Patient(string name, int patientID)
        {
            this.Name = name;
            this.PatientID = patientID;
        }


        public void BookAppointmentWithDoctor(Appointment appointment)
        {
            patient_appointments.Add(appointment);

        }


        public void DisplayAppointments()
        {
            Console.WriteLine($"\nPatient's name: {Name}");

            foreach (Appointment details in patient_appointments)
            {
                Console.WriteLine($"AppointmentID: {details.AppointmentID}");
                Console.WriteLine($"Date: {details.Date.ToString("MMMM dd, yyyy")}");
                Console.WriteLine($"Name doctor: {details.Doctor.Name}\n"); 

            }


        }

        
    }


}
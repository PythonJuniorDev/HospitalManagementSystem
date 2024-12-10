namespace HOSPITALMANAGEMENTSYSTEM
{
    
    class Doctor
    {

        public string Name;
        public string Specialization;
        public int DoctorID;


        // Constructor initializes doctor details
        public Doctor(string name, string specialization, int doctorID)
        {
            this.Name = name;
            this.Specialization = specialization;
            this.DoctorID = doctorID;
        }


        // Displays the details of the doctor
        public void DisplayDoctorDetails()
        {
            Console.WriteLine("\nDetails of your doctor: ");
            Console.WriteLine($"\nName: {Name}\nSpecialization: {Specialization}\nDoctorID: {DoctorID}");
            
        }


    }

}





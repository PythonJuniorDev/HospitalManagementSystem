Hospital Management System
This project simulates a hospital management system using C# classes. It models key entities such as doctors, patients, treatments, and appointments, showcasing their interactions in a cohesive structure.



How the Classes Work Together

Doctor Class
Represents a doctor with a name, specialization, and unique ID.
Associated with specific appointments via the Appointment class.

Patient Class
Represents a patient with a name and unique ID.
Links to appointments through the BookAppointmentWithDoctor method.

Treatment Class
Represents treatments, including a name, medication, and dosage.
Assigned to appointments using the AddTreatment method in the Appointment class.

Appointment Class
Acts as the central hub connecting doctors, patients, and treatments.
Manages appointment details and displays all relevant information.

Program Class
Serves as the entry point for the application.
Demonstrates object creation, relationships between entities, and functionality.



Summary
The Appointment Class is the core of the system, linking the Doctor, Patient, and Treatment classes. Together, they simulate the real-world interactions within a hospital management scenario.

About the design
We learned to create a modular design that makes it easy to extend and adapt the system for additional features or entities in the future.

# Hospital Management System

A simulation of a hospital management system built in C#, demonstrating object-oriented programming principles such as encapsulation, abstraction, and modular design. The project models core entities in a hospital environment and their interactions in a cohesive structure.

---

## **Features**
- **Core Classes**:
  - **Doctor**: Represents a doctor with attributes like name, specialization, and ID.
  - **Patient**: Represents a patient with a name and unique ID, linking appointments.
  - **Treatment**: Models treatments, including a name, medication, and dosage.
  - **Appointment**: Acts as the hub connecting doctors, patients, and treatments.

- **Dynamic Functionality**:
  - Link doctors and patients through appointments.
  - Assign multiple treatments to each appointment.
  - Display detailed appointment and treatment information dynamically.

- **Polymorphism and Modularity**:
  - Encapsulation ensures clear boundaries between classes.
  - The system is designed to extend easily with new entities or behaviors.

---

## **How It Works**
1. **Entities**:
   - Doctors, Patients, and Treatments are instantiated as objects.
2. **Appointments**:
   - Appointments connect doctors to patients and include one or more treatments.
3. **Interaction**:
   - Relationships between objects are demonstrated using methods like `AddTreatment` and `BookAppointmentWithDoctor`.
4. **Display**:
   - Appointment and treatment details are printed to the console for easy viewing.

---

## **Getting Started**
### **Prerequisites**
- A C# development environment, such as **Visual Studio**.
- The **.NET Framework** installed.

### **Running the Program**
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/HospitalManagementSystem.git

using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles.SRP___Single_Responsability.Example
{
    public class AppointmentService
    {
        public string Create(Appointment appointment)
        {
            ValidateResult validation = AppointmentServiceValidator.Validate(appointment);

            return validation.IsValid ?
                $"La cita quedo agendada para el paciente {appointment.Patient.Name}." :
                string.Join(Environment.NewLine, validation.ErrorMessage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles.SRP___Single_Responsability.Example
{
    public static class AppointmentServiceValidator
{
        public static ValidateResult Validate(Appointment appointment)
        {
            ValidateResult validation = new ValidateResult();
            if (string.IsNullOrEmpty(appointment.Patient.Name))
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");

            if (appointment.Time.Equals(DateTime.MinValue))
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.");

            if (string.IsNullOrEmpty(appointment.Patient.Email) || !appointment.Patient.Email.Contains("@"))
                validation.ErrorMessage.Add($"La cita no puede ser agendada, debido a que debe proporcionar un email valido.");

            return validation;
        }
    }
}

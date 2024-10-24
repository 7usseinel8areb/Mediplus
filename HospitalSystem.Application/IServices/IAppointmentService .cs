﻿namespace HospitalSystem.Application.Services
{
    public interface IAppointmentService
    {
        Task AddAppointmentAsync(Appointment Appointment);
        Task<Appointment> GetAppointmentByIdAsync(string id);
        Task<IEnumerable<Appointment>> GetAllAppointmentsAsync();
        Task UpdateAppointmentAsync(Appointment Appointment);
        Task DeleteAppointmentAsync(string id);
        Task<IEnumerable<Patient>> GetPatientsByDoctorAsync(string doctorId);
		Task<IEnumerable<Appointment>> GetAppointmentsByPatientIdAsync(string patientId);

	}
}

using DisprzTraining.Models;

namespace DisprzTraining.Business
{
    public interface IAppointmentsBL
    {
        bool CreateNewAppointment(AddNewAppointment data);

        List<Appointment> GetAppointmentsForSelectedDate(DateTime date);

        List<Appointment> GetRangedList(DateTime date);
        bool RemoveAppointments(Guid id, DateTime date);

        bool UpdateAppointments(UpdateAppointment data);
    }
}
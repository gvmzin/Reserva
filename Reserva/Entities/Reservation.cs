using System;
using Reserva.Entities.Exceptions;

namespace Reserva.Entities
{
    internal class Reservation
    {
        /// Atributos
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        /// Construtores
        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");

            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        /// Métodos

        /// Método para calcular a duração da reserva
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        /// Método para atualizar as datas de check-in e check-out
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException( "Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");

            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        /// Sobrecarga do método ToString
        public override string ToString()
        {
            return "Room " 
                + RoomNumber 
                + ", checkin: " 
                + CheckIn.ToString("dd/MM/yyyy")
                +", checkout: "
                +CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                +" nights";
        }
    }
}

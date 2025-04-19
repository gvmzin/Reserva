using System;
using Reserva.Entities;
using Reserva.Entities.Exceptions;
namespace Reserva
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                // Criando uma reserva

                Console.Write("Room number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date(dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date(dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(room, checkIn, checkOut);
                
                // Imprimindo a reserva
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                // Atualizando a reserva

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date(dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date(dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                // Imprimindo a atualização da reserva
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error" + e.Message);
            }

        }

    }
}


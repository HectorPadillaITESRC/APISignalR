﻿
using Microsoft.AspNetCore.SignalR;

namespace APISignalR.Hubs
{
    public class NombresHub:Hub
    {

        public async void AgregarNombre(string nombre)
        {
            //Hacer algo con ese nombre

            await Clients.All.SendAsync("NombreNuevo", nombre);

        }


        public async void EliminarNombre(string nombre)
        {

            await Clients.All.SendAsync("NombreBorrado", nombre);

        }
    }
}

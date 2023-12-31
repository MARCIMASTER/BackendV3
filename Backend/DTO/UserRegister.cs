﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTO
{
    public class UserRegister
    {
        
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }

            //Todo: Agregar campos nuevos para llenar tabla user
            public string nombres { get; set; }
            public string apellidos { get; set; }

            public string rut { get; set; }
            public  DateTime fechaNacimiento { get; set; }
            public string trabaja { get; set; }
            public int ModalidadTrabajoId { get; set; }
            public int ComunaResidenciaId { get; set; }
            public int EstadoId { get; set; }
            public int ComunaTrabajoId { get; set; }


    }
}

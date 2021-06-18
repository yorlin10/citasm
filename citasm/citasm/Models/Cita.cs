using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VisioForge.MediaFramework.ONVIF;

namespace citasm.Models
{
    public class Cita
    {
      
        [Key]
        public int citaId { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el nombre del paciente")]
        [Display(Name = " Nombre")]
        public string CitapNombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el segundo nombre del paciente")]
        [Display(Name = "Segundo Nombre")]
        public string CitapSeNombre { get; set; }


        [Required(ErrorMessage = "Por favor ingrese el apellido del paciente")]
        [Display(Name = "Apellido")]
        public string CitapApellido { get; set; }


        [Required(ErrorMessage = "Por favor ingrese el correo del paciente")]
        [Display(Name = "example@example.com")]
        public string CitapCorreo { get; set; }

        [Display(Name = "Nombre ")]
        public string CitapAcomNombre { get; set; }

        [Display(Name = "Apellido")]
        public string CitaAcomApellido { get; set; }


        [Required(ErrorMessage = "Por favor ingrese la direccion paciente")]
        [Display(Name = "Direccion de la calle")]
        public string CitapDireccion { get; set; }

        [Display(Name = "Direccion de la calle Linea 2")]
        public string CitapDirecciondos { get; set; }


        [Required(ErrorMessage = "Por favor ingrese la cuidad del paciente")]
        [Display(Name = "Cuidad")]
        public string CitapCuidad { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el estado o provincia del paciente")]
        [Display(Name = "Estado/Provincia")]
        public string CitapEstadop { get; set; }

        [Required(ErrorMessage = "este campo es obligatorio")]

        [Display(Name = "Codigo Postal")]
        public int CitapCodigop { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]

        [Display(Name = "Codigo de Aerea")]
        public int CitapTelefonoArea { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio")]

        [Display(Name = "Numero de telefono")]
        public int CitapNumero { get; set; }

        [Display(Name = "Codigo de Area")]

        public int CitapAreaW { get; set; }

        [Display(Name = "Numero de Telefono")]

        public int CitapNumeroW { get; set; }

    }
}

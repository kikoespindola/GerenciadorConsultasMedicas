//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GerenciadorConsultasMedicas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConsultaMedica
    {
        public int ConsultaMedicaID { get; set; }
        public int Paciente { get; set; }
        public int Medico { get; set; }
        public string Queixa { get; set; }
        public string Diagnostico { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<System.TimeSpan> Horario { get; set; }
    
        public virtual Medicos Medicos { get; set; }
        public virtual Pacientes Pacientes { get; set; }
    }
}


using System;

namespace WEBAPIEmail.Data
{
    public class EmaislEnviados
    {
        public int Id { get; set; }
        public Guid IdEmail { get; set; }
        public string Email { get; set; }
        public int IdCampanha { get; set; }
        public int Aberto { get; set; }
    }
}
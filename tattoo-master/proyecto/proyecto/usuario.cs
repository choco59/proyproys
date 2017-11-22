using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class usuario
    {
        public string usuario_id { get; set; }
        public string usuario_tipo { get; set; }
        public string usuario_carnet { get; set; }
        public string usuario_password { get; set; }
        public int usuario_estado { get; set; }

        public usuario() { }
        public usuario(string pusuario_id, string pusuario_tipo, string pusuario_carnet, string pusuario_password, int pusuario_estado)
        {
            this.usuario_id = pusuario_id;
            this.usuario_tipo = pusuario_tipo;
            this.usuario_carnet = pusuario_carnet;
            this.usuario_password = pusuario_password;
            this.usuario_estado = pusuario_estado;

        }
    }
}

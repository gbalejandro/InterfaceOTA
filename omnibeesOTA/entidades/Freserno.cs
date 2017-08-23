using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace omnibeesOTA.entidades
{
    public class Freserno
    {
        private string vn_reserva;
        private int vn_secuencia;
        private string vn_apellido;
        private string vn_nombre;
        private string vn_pase;

        public string Vn_reserva
        {
            get
            {
                return vn_reserva;
            }

            set
            {
                vn_reserva = value;
            }
        }

        public int Vn_secuencia
        {
            get
            {
                return vn_secuencia;
            }

            set
            {
                vn_secuencia = value;
            }
        }

        public string Vn_apellido
        {
            get
            {
                return vn_apellido;
            }

            set
            {
                vn_apellido = value;
            }
        }

        public string Vn_nombre
        {
            get
            {
                return vn_nombre;
            }

            set
            {
                vn_nombre = value;
            }
        }

        public string Vn_pase
        {
            get
            {
                return vn_pase;
            }

            set
            {
                vn_pase = value;
            }
        }
    }
}
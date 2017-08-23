using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace omnibeesOTA.entidades
{
    public class Agencia
    {
        private string mayorista;
        private string nagencia;
        private string pais;
        private string regim_alim;
        private int dias_prepago;

        public string Mayorista
        {
            get
            {
                return mayorista;
            }

            set
            {
                mayorista = value;
            }
        }

        public string nAgencia
        {
            get
            {
                return nagencia;
            }

            set
            {
                nagencia = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        public string Regim_alim
        {
            get
            {
                return regim_alim;
            }

            set
            {
                regim_alim = value;
            }
        }

        public int Dias_prepago
        {
            get
            {
                return dias_prepago;
            }

            set
            {
                dias_prepago = value;
            }
        }
    }
}
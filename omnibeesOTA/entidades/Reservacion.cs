using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace omnibeesOTA.entidades
{
    public class Reservacion
    {
        private String rva_echotoken;
        private String rva_action;
        private String rva_ResID_Type;
        private String rva_ResID_Source;
        private String rva_uniqueID;
        private String rva_may;
        private String rva_agen;
        private String rva_notas;
        private DateTime rva_llegada;
        private DateTime rva_salida;
        private int rva_noches;
        private String rva_tipo_hab;
        private string rva_tarifa;
        private int rva_adulto;
        private int rva_menor;
        private String rva_hab_renta;
        private String rva_hotel_renta;
        private String rva_moneda;
        private String rva_nombre;
        private String rva_apell;
        private String rva_plan;
        private String rva_grupo;
        private String rva_error;
        private String rva_exito;
        private String rva_oasis_rva;
        private String rva_sec;
        private String rva_email;
        private String rva_chaincode;
        private String rva_hotelcode;
        private String rva_oasis_errcode;
        private String rva_oasis_errdesc;
        private String rva_servicio;
        private string rva_companycode_obees;
        private string rva_chanelname_obees;
        private string rva_agencia_obees;
        private string rva_codecontext_obees;
        private bool rva_planindicador;
        private int rva_plancode;
        private string rva_mealplan;
        private string rva_pais;
        private string rva_tipo_huesped;
        private double rva_importe;
        private DateTime rva_create_datetime;
        private string rva_tipo_garantia;
        private string rva_serv_price_type;
        private double rva_tc;
        private int rva_junior;
        private int rva_bebe;

        public string Rva_echotoken
        {
            get
            {
                return rva_echotoken;
            }

            set
            {
                rva_echotoken = value;
            }
        }

        public string Rva_action
        {
            get
            {
                return rva_action;
            }

            set
            {
                rva_action = value;
            }
        }

        public string Rva_ResID_Type
        {
            get
            {
                return rva_ResID_Type;
            }

            set
            {
                rva_ResID_Type = value;
            }
        }

        public string Rva_ResID_Source
        {
            get
            {
                return rva_ResID_Source;
            }

            set
            {
                rva_ResID_Source = value;
            }
        }

        public string Rva_uniqueID
        {
            get
            {
                return rva_uniqueID;
            }

            set
            {
                rva_uniqueID = value;
            }
        }

        public string Rva_may
        {
            get
            {
                return rva_may;
            }

            set
            {
                rva_may = value;
            }
        }

        public string Rva_agen
        {
            get
            {
                return rva_agen;
            }

            set
            {
                rva_agen = value;
            }
        }

        public string Rva_notas
        {
            get
            {
                return rva_notas;
            }

            set
            {
                rva_notas = value;
            }
        }

        public DateTime Rva_llegada
        {
            get
            {
                return rva_llegada;
            }

            set
            {
                rva_llegada = value;
            }
        }

        public DateTime Rva_salida
        {
            get
            {
                return rva_salida;
            }

            set
            {
                rva_salida = value;
            }
        }

        public int Rva_noches
        {
            get
            {
                return rva_noches;
            }

            set
            {
                rva_noches = value;
            }
        }

        public string Rva_tipo_hab
        {
            get
            {
                return rva_tipo_hab;
            }

            set
            {
                rva_tipo_hab = value;
            }
        }

        public string Rva_tarifa
        {
            get
            {
                return rva_tarifa;
            }

            set
            {
                rva_tarifa = value;
            }
        }

        public int Rva_adulto
        {
            get
            {
                return rva_adulto;
            }

            set
            {
                rva_adulto = value;
            }
        }

        public int Rva_menor
        {
            get
            {
                return rva_menor;
            }

            set
            {
                rva_menor = value;
            }
        }

        public string Rva_hab_renta
        {
            get
            {
                return rva_hab_renta;
            }

            set
            {
                rva_hab_renta = value;
            }
        }

        public string Rva_hotel_renta
        {
            get
            {
                return rva_hotel_renta;
            }

            set
            {
                rva_hotel_renta = value;
            }
        }

        public string Rva_moneda
        {
            get
            {
                return rva_moneda;
            }

            set
            {
                rva_moneda = value;
            }
        }

        public string Rva_nombre
        {
            get
            {
                return rva_nombre;
            }

            set
            {
                rva_nombre = value;
            }
        }

        public string Rva_apell
        {
            get
            {
                return rva_apell;
            }

            set
            {
                rva_apell = value;
            }
        }

        public string Rva_plan
        {
            get
            {
                return rva_plan;
            }

            set
            {
                rva_plan = value;
            }
        }

        public string Rva_grupo
        {
            get
            {
                return rva_grupo;
            }

            set
            {
                rva_grupo = value;
            }
        }

        public string Rva_error
        {
            get
            {
                return rva_error;
            }

            set
            {
                rva_error = value;
            }
        }

        public string Rva_exito
        {
            get
            {
                return rva_exito;
            }

            set
            {
                rva_exito = value;
            }
        }

        public string Rva_oasis_rva
        {
            get
            {
                return rva_oasis_rva;
            }

            set
            {
                rva_oasis_rva = value;
            }
        }

        public string Rva_sec
        {
            get
            {
                return rva_sec;
            }

            set
            {
                rva_sec = value;
            }
        }

        public string Rva_email
        {
            get
            {
                return rva_email;
            }

            set
            {
                rva_email = value;
            }
        }

        public string Rva_chaincode
        {
            get
            {
                return rva_chaincode;
            }

            set
            {
                rva_chaincode = value;
            }
        }

        public string Rva_hotelcode
        {
            get
            {
                return rva_hotelcode;
            }

            set
            {
                rva_hotelcode = value;
            }
        }

        public string Rva_oasis_errcode
        {
            get
            {
                return rva_oasis_errcode;
            }

            set
            {
                rva_oasis_errcode = value;
            }
        }

        public string Rva_oasis_errdesc
        {
            get
            {
                return rva_oasis_errdesc;
            }

            set
            {
                rva_oasis_errdesc = value;
            }
        }

        public string Rva_servicio
        {
            get
            {
                return rva_servicio;
            }

            set
            {
                rva_servicio = value;
            }
        }

        public string Rva_companycode_obees
        {
            get
            {
                return rva_companycode_obees;
            }

            set
            {
                rva_companycode_obees = value;
            }
        }

        public string Rva_chanelname_obees
        {
            get
            {
                return rva_chanelname_obees;
            }

            set
            {
                rva_chanelname_obees = value;
            }
        }

        public string Rva_agencia_obees
        {
            get
            {
                return rva_agencia_obees;
            }

            set
            {
                rva_agencia_obees = value;
            }
        }

        public string Rva_codecontext_obees
        {
            get
            {
                return rva_codecontext_obees;
            }

            set
            {
                rva_codecontext_obees = value;
            }
        }

        public bool Rva_planindicador
        {
            get
            {
                return rva_planindicador;
            }

            set
            {
                rva_planindicador = value;
            }
        }

        public int Rva_plancode
        {
            get
            {
                return rva_plancode;
            }

            set
            {
                rva_plancode = value;
            }
        }

        public string Rva_mealplan
        {
            get
            {
                return rva_mealplan;
            }

            set
            {
                rva_mealplan = value;
            }
        }

        public string Rva_pais
        {
            get
            {
                return rva_pais;
            }

            set
            {
                rva_pais = value;
            }
        }

        public string Rva_tipo_huesped
        {
            get
            {
                return rva_tipo_huesped;
            }

            set
            {
                rva_tipo_huesped = value;
            }
        }

        public double Rva_importe
        {
            get
            {
                return rva_importe;
            }

            set
            {
                rva_importe = value;
            }
        }

        public DateTime Rva_create_datetime
        {
            get
            {
                return rva_create_datetime;
            }

            set
            {
                rva_create_datetime = value;
            }
        }

        public string Rva_tipo_garantia
        {
            get
            {
                return rva_tipo_garantia;
            }

            set
            {
                rva_tipo_garantia = value;
            }
        }

        public string Rva_serv_price_type
        {
            get
            {
                return rva_serv_price_type;
            }

            set
            {
                rva_serv_price_type = value;
            }
        }

        public double Rva_tc
        {
            get
            {
                return rva_tc;
            }

            set
            {
                rva_tc = value;
            }
        }

        public int Rva_junior
        {
            get
            {
                return rva_junior;
            }

            set
            {
                rva_junior = value;
            }
        }

        public int Rva_bebe
        {
            get
            {
                return rva_bebe;
            }

            set
            {
                rva_bebe = value;
            }
        }
    }
}
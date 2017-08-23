using omnibeesOTA.entidades;
using omnibeesOTA.rq;
using omnibeesOTA.rs;
using omnibeesOTA.utilerias;
using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Serialization;

namespace omnibeesOTA
{
    /// <summary>
    /// Summary description for OTAWS
    /// </summary>
    [WebService(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OTAWS : System.Web.Services.WebService
    {
        private string fecha_actual;
        private string hora_actual;
        private string Reserva;
        private string ErrorCode;
        private string ErrDesc;

        [WebMethod]
        public OTA_HotelResNotifRS reservations(OTA_HotelResNotifRQ request)
        {
            OTA_HotelResNotifRS response = new OTA_HotelResNotifRS();
            response = procesa(request);
            return response;
        }

        private OTA_HotelResNotifRS procesa(OTA_HotelResNotifRQ reservation)
        {
            Reservacion rv = new Reservacion();
            List<HotelReservationIDrs> reservations = new List<HotelReservationIDrs>();

            // rutina momentanea para guardar el xml enviado
            var StringWriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(reservation.GetType());
            serializer.Serialize(StringWriter, reservation);

            try
            {
                rv.Rva_echotoken = reservation.EchoToken;

                foreach (HotelReservation g in reservation.HotelReservations.HotelReservation)
                {
                    switch (g.ResStatus) {
                        case "Booked":
                            {
                                rv.Rva_action = g.ResStatus;
                                rv.Rva_uniqueID = g.UniqueID.ID;
                                rv.Rva_ResID_Type = g.UniqueID.Type;
                                rv.Rva_ResID_Source = g.UniqueID.ID_Context;
                                rv.Rva_create_datetime = Convert.ToDateTime(g.CreateDateTime);

                                foreach (Service sv in g.Services.Service)
                                {
                                    rv.Rva_servicio = sv.ServiceDetails.ServiceDescription.Text;
                                    rv.Rva_serv_price_type = sv.ServicePricingType;
                                }

                                foreach (Source s in g.POS.Source)
                                {
                                    rv.Rva_agencia_obees = s.PseudoCityCode;
                                    rv.Rva_companycode_obees = s.BookingChannel.CompanyName.Code;
                                    rv.Rva_codecontext_obees = s.BookingChannel.CompanyName.CodeContext;
                                    rv.Rva_chanelname_obees = s.BookingChannel.CompanyName.Value;
                                }

                                if (!Util.isNull(g.RoomStays.RoomStay))
                                {
                                    foreach (RoomStay rs in g.RoomStays.RoomStay)
                                    {
                                        rv.Rva_llegada = Convert.ToDateTime(rs.TimeSpan.Start);
                                        rv.Rva_salida = Convert.ToDateTime(rs.TimeSpan.End);

                                        foreach (RoomRate rr in rs.RoomRates.RoomRate)
                                        {
                                            rv.Rva_hab_renta = rr.RoomTypeCode;
                                            rv.Rva_plan = rr.RatePlanCode;
                                            rv.Rva_grupo = rr.GroupCode;
                                            rv.Rva_tarifa = rr.RoomTypeCode;
                                            rv.Rva_moneda = rr.Total.CurrencyCode;
                                            rv.Rva_importe = rr.Total.AmountAfterTax;
                                        }

                                        foreach (GuestCount gc in rs.GuestCounts.GuestCount)
                                        {
                                            // valido los adultos - juniors - menores - bebes
                                            if (gc.AgeQualifyingCode == 10)
                                            {
                                                rv.Rva_adulto = gc.Count;
                                            }
                                            else
                                            {
                                                // junior
                                                if (gc.Age >= 12 && gc.Age <= 17)
                                                {
                                                    rv.Rva_junior = gc.Count;
                                                }
                                                else if (gc.Age >= 3 && gc.Age <= 11) // menor
                                                {
                                                    rv.Rva_menor = gc.Count;
                                                }
                                                else
                                                {
                                                    rv.Rva_bebe = gc.Count;
                                                }
                                            }
                                        }

                                        foreach (RatePlan rp in rs.RatePlans.RatePlan)
                                        {
                                            rv.Rva_planindicador = Convert.ToBoolean(rp.MealsIncluded.MealPlanIndicator);
                                            rv.Rva_plancode = rp.MealsIncluded.MealPlanCodes;
                                            rv.Rva_tipo_garantia = rp.Guarantee.GuaranteeType;
                                        }
                                    }
                                }

                                foreach (ResGuest rg in g.ResGuests.ResGuest)
                                {
                                    // si la bandera es true, quiere decir que es el huesped principal
                                    if (rg.PrimaryIndicator == "true")
                                    {
                                        rv.Rva_sec = "1";
                                    }
                                    else
                                    {
                                        rv.Rva_sec = rg.ResGuestRPH;
                                    }

                                    foreach (ProfileInfo pi in rg.Profiles.ProfileInfo)
                                    {
                                        rv.Rva_nombre = pi.Profile.Customer.PersonName.GivenName;
                                        rv.Rva_apell = pi.Profile.Customer.PersonName.Surname;
                                        rv.Rva_email = pi.Profile.Customer.Email;
                                        rv.Rva_pais = pi.Profile.Customer.Address.CountryName.Code;

                                        UConnection DB = new UConnection(Properties.Settings.Default.ipBD, Properties.Settings.Default.serverBD, Properties.Settings.Default.usuarioBD, Properties.Settings.Default.passBD);
                                        string sql = "";
                                        int filas = 0;

                                        sql = "insert into OBNOMBRES (ON_RESERVA,ON_SECUENCIA,ON_APELLIDO,ON_NOMBRE) VALUES (" + "'"
                                        + g.UniqueID.ID + "'," + "'" + rv.Rva_sec + "'," + "'" + rv.Rva_apell + "'," + "'"
                                        + rv.Rva_nombre + "')";
                                        bool ok = DB.EjecutaSQL(sql, ref filas);
                                        DB.Dispose();

                                        if (filas == 0)
                                        {
                                            rv.Rva_error = "OCURRIO UN ERROR EN EL GUARDADO DE NOMBRES: " + sql;
                                            return null;
                                        }
                                    }
                                }

                                rv.Rva_hotel_renta = g.ResGlobalInfo.BasicPropertyInfo.HotelCode;
                                rv.Rva_chaincode = g.ResGlobalInfo.BasicPropertyInfo.ChainCode;
                                rv.Rva_importe = g.ResGlobalInfo.Total.AmountAfterTax;

                                foreach (Comment cm in g.ResGlobalInfo.Comments.Comment)
                                {
                                    rv.Rva_notas = cm.Text.Value;
                                }

                                // inserto el request completo como referencia
                                bool ok2 = GuardaReservaOMNI(rv);
                                DateTime Hoy = new DateTime();
                                fecha_actual = Hoy.ToString();
                                // guardado temporal del xml en el servidor
                                File.WriteAllText(@"C:\AppServ\www\interface_ota\docs\" + rv.Rva_uniqueID + ".xml", StringWriter.ToString());

                                ///////////////////////////////////////////////////////// primera fase ////////////////////////////////////////////////////////////////////////////////
                                int stop = 0; // un bloqueo momentaneo para no afectar reservas reales
                                if (ok2)
                                {
                                    // obtengo los parametros de base de datos del hotel a donde va la reserva
                                    MapeoHoteles mh = new MapeoHoteles();
                                    mh = ObtenerParamsBDHotel(g.ResGlobalInfo.BasicPropertyInfo.HotelCode);
                                    // verifico si existen parametros para este hotel
                                    if (mh.Hotel_cn != null)
                                    {
                                        // obtengo el numero de reservacion
                                        rv.Rva_oasis_rva = ObtenerIdReservacion(mh);
                                        if (!string.IsNullOrEmpty(rv.Rva_oasis_rva))
                                        {
                                            Freserno frn = new Freserno();
                                            frn.Vn_reserva = rv.Rva_oasis_rva;
                                            // una vez que ya tengo el numero de reservacion, guardo primero los nombres en freserno
                                            foreach (ResGuest rg2 in g.ResGuests.ResGuest)
                                            {
                                                // si la bandera es true, quiere decir que es el huesped principal
                                                if (rg2.PrimaryIndicator == "true")
                                                {
                                                    frn.Vn_secuencia = 1;
                                                }
                                                else
                                                {
                                                    frn.Vn_secuencia = Convert.ToInt16(rg2.ResGuestRPH);
                                                }

                                                foreach (ProfileInfo pi2 in rg2.Profiles.ProfileInfo)
                                                {
                                                    frn.Vn_nombre = pi2.Profile.Customer.PersonName.GivenName;
                                                    frn.Vn_apellido = pi2.Profile.Customer.PersonName.Surname;
                                                    bool ok6 = InsertarNombre(frn, mh);
                                                }
                                            }
                                            // valido el plan 
                                            switch (rv.Rva_plancode)
                                            {
                                                case 1:
                                                    rv.Rva_mealplan = "AI";
                                                    break;
                                                case 14:
                                                    rv.Rva_mealplan = "EP";
                                                    break;
                                                case 19:
                                                    rv.Rva_mealplan = "DI";
                                                    break;
                                                default:
                                                    rv.Rva_mealplan = "NA";
                                                    break;
                                            }
                                            // CONSULTO EL CODIGO DE LA AGENCIA por su canal y plan de comida
                                            rv.Rva_agen = ObtenerCodigoAgencia(rv.Rva_chanelname_obees, rv.Rva_mealplan);
                                            // obtengo los datos de la agencia
                                            Agencia ag = new Agencia();
                                            ag = ObtenerDatosAgencia(rv.Rva_agen, mh);
                                            rv.Rva_pais = ag.Pais;
                                            rv.Rva_may = ag.Mayorista;
                                            // verifico el timpo de huesped
                                            switch (rv.Rva_may)
                                            {
                                                case "MEX":
                                                case "BRA":
                                                case "SDA":
                                                    {
                                                        if (rv.Rva_agen.Substring(0, 2) == "FI" || rv.Rva_agen.Substring(0, 2) == "BK")
                                                        {
                                                            rv.Rva_tipo_huesped = "WB";
                                                        }
                                                        else
                                                        {
                                                            rv.Rva_tipo_huesped = "EM";
                                                        }
                                                        break;
                                                    }
                                                case "COR":
                                                case "USO":
                                                    {
                                                        rv.Rva_tipo_huesped = "CO";
                                                        break;
                                                    }
                                                case "DIR":
                                                case "AME":
                                                case "EUR":
                                                case "SUD":
                                                    {
                                                        rv.Rva_tipo_huesped = "WB";
                                                        break;
                                                    }
                                                case "INT":
                                                    {
                                                        rv.Rva_tipo_huesped = "CE";
                                                        break;
                                                    }

                                            } // tipo de huesped
                                              // diferencia de fechas para determinar las noches
                                            System.TimeSpan ts = Convert.ToDateTime(rv.Rva_salida) - Convert.ToDateTime(rv.Rva_llegada);
                                            rv.Rva_noches = ts.Days;
                                            // verifico la fecha del prepago, por el momento queda null
                                            //if (ag.Dias_prepago > 0)
                                            //{
                                            //    // obtengo la fecha del prepago

                                            //}
                                            // obtengo el tipo de cambio por la moneda enviada
                                            rv.Rva_tc = ObtenerTipoCambio(rv.Rva_moneda, mh);
                                            // inserto la cabecera en freserva
                                            bool ok8 = InsertaReserva(rv, mh);
                                            HotelReservationIDrs hris = new HotelReservationIDrs();
                                            hris.ResID_Type = "10";
                                            hris.ResID_Value = rv.Rva_oasis_rva;
                                            hris.ResID_Source = "PMS";
                                            reservations.Add(hris);

                                            //rv.Rva_oasis_rva = Reserva;
                                            rv.Rva_oasis_errcode = ErrorCode;
                                            rv.Rva_oasis_errdesc = ErrDesc;
                                        }
                                        else
                                        {
                                            // guardo el proceso que falló al tratar de obtener el id de la reserva
                                            bool ok5 = GuardarSuceso(mh.Hotel_siglas, rv.Rva_uniqueID, "NO SE PUDO OBTENER EL ID DE LA RESERVA PARA ESTE HOTEL");
                                            rv.Rva_error = "OCURRIO UN ERROR EN EL GUARDADO DE LA RESERVA.";
                                            return obtenerMensajeError(rv, reservations);
                                        }
                                    }
                                    else
                                    {
                                        // guardo el proceso que falló al tratar de OBTENER los parametros de conexion para el hotel
                                        bool ok3 = GuardarSuceso(rv.Rva_hotel_renta, rv.Rva_uniqueID, "NO SE OBTUVIERON PARAMETROS DE BASE DE DATOS PARA EL HOTEL");
                                        rv.Rva_error = "OCURRIO UN ERROR EN EL GUARDADO DE LA RESERVA.";
                                        return obtenerMensajeError(rv, reservations);
                                    } // parametros de conexion del hotel
                                }
                                else
                                {
                                    // guardo el proceso que falló al tratar de guardar en la principal, tal cual la envió Omnibees
                                    // SE PONE MENSAJE PROVISIONAL PARA ANALIZAR LOS XML ENVIADOS POR OMNI
                                    bool ok4 = GuardarSuceso(rv.Rva_hotel_renta, rv.Rva_uniqueID, "SE OBTUVO EL XML SATISFACTORIAMENTE");
                                    rv.Rva_error = "SE RECIBIO LA RESERVACION SATISFACTORIAMENTE.";
                                    return obtenerMensajeError(rv, reservations);
                                } // inserta tabla principal
                                break;
                            }
                        case "Modified":
                            {
                                break;
                            }
                        case "Cancelled":
                            {
                                break;
                            }
                    } // accion de la reserva resstatus
                } // hotelreservation

                return obtenerMensajeSatisfaccion(rv, reservations);

            } catch (Exception ex)
            {
                rv.Rva_error = ex.Message;
            }

            return null;
        }

        private bool InsertaReserva(Reservacion rv, MapeoHoteles mph)
        {
            UConnection DB = new UConnection(mph.Hotel_ip, mph.Hotel_cn, mph.Hotel_un, mph.Hotel_pw);
            string sql = "";
            int filas = 0;
            DateTime Hoy = DateTime.Today;
            fecha_actual = Hoy.ToString("dd-MMM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            hora_actual = DateTime.Now.ToString("hh:mm");
            string fecha_llegada = rv.Rva_llegada.ToString("dd-MMM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            string fecha_salida = rv.Rva_salida.ToString("dd-MMM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            sql = string.Format("insert into freserva (rv_reserva, rv_mayorista, rv_agencia, rv_grupo, rv_pais, rv_tipo_huesped, rv_origen, rv_procede, rv_notas, rv_llegada, rv_salida, rv_noches, rv_llegada_h, " +
                "rv_salida_h, rv_tipo_hab, rv_tarifa, rv_adulto, rv_menor, rv_bebe, rv_fase, rv_habi, rv_voucher, rv_importe, rv_deposito, rv_cap_f, rv_cap_h, rv_cap_u, rv_status, rv_planes, rv_tipo_hab_renta, " +
                "rv_hotel_renta, rv_email, rv_moneda, rv_prepago_f, rv_prepago_i, rv_promocion, rv_tc, rv_junior, rv_edificio, rv_tipo_venta) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', " +
                "'{10}',{11},'{12}','{13}','{14}','{15}',{16},{17},{18},'{19}','{20}','{21}',{22},{23},'{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}','{32}','{33}',{34},'{35}',{36},{37},'{38}','{39}')",
                rv.Rva_oasis_rva, rv.Rva_may, rv.Rva_agen, rv.Rva_grupo, rv.Rva_pais, rv.Rva_tipo_huesped, "WB", rv.Rva_may, rv.Rva_notas, fecha_llegada, fecha_salida, rv.Rva_noches, "15:00", "12:00",
                rv.Rva_hab_renta, rv.Rva_tarifa, rv.Rva_adulto, rv.Rva_menor, rv.Rva_bebe, mph.Hotel_fase, null, rv.Rva_uniqueID, Convert.ToDouble(rv.Rva_importe).ToString(CultureInfo.InvariantCulture), 3, 
                fecha_actual, hora_actual, "OBEES", "R", rv.Rva_mealplan, rv.Rva_tarifa, mph.Hotel_os, rv.Rva_email, rv.Rva_moneda, null, 0, "XX", rv.Rva_tc, rv.Rva_junior, null, "LEISURE");
            bool ok = DB.EjecutaSQL(sql, ref filas);
            DB.Dispose();
            return filas > 0;
        }

        private double ObtenerTipoCambio(string Moneda, MapeoHoteles mph)
        {
            double TipoCambio = 0.0;
            DateTime Hoy = DateTime.Today;
            fecha_actual = Hoy.ToString("dd/mm/yy", CultureInfo.CreateSpecificCulture("en-US"));
            UConnection DB = new UConnection(mph.Hotel_ip, mph.Hotel_cn, mph.Hotel_un, mph.Hotel_pw);
            string sql = "select TC_FRONT from frtipoca where TC_FECHA = '" + fecha_actual  + "' and TC_MONEDA = '" + Moneda + "'";
            try
            {
                if (DB.EjecutaSQL(sql))
                {
                    while (DB.ora_DataReader.Read())
                    {
                        TipoCambio = Convert.ToDouble(DB.ora_DataReader["TC_FRONT"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //rv.Rva_error = ex.Message;
            }
            finally
            {
                DB.Dispose();
            }
            return TipoCambio;
        }

        private Agencia ObtenerDatosAgencia(string Agencia, MapeoHoteles mph)
        {
            Agencia ag = new Agencia();
            UConnection DB = new UConnection(mph.Hotel_ip, mph.Hotel_cn, mph.Hotel_un, mph.Hotel_pw);
            string sql = "select AG_MAYORISTA, AG_PAIS, AG_REGIM_ALIM, AG_DIAS_PREPAGO from FRAGEN where AG_AGENCIA = '" + Agencia + "'";

            try
            {
                if (DB.EjecutaSQL(sql))
                {
                    while (DB.ora_DataReader.Read())
                    {
                        ag.Mayorista = Convert.ToString(DB.ora_DataReader["AG_MAYORISTA"]);
                        ag.Pais = Convert.ToString(DB.ora_DataReader["AG_PAIS"]);
                        ag.Regim_alim = Convert.ToString(DB.ora_DataReader["AG_REGIM_ALIM"]);
                        ag.Dias_prepago = Convert.ToInt16(DB.ora_DataReader["AG_DIAS_PREPAGO"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //rv.Rva_error = ex.Message;
            }
            finally
            {
                DB.Dispose();
            }
            return ag;
        }

        private bool InsertarNombre(Freserno frn, MapeoHoteles mph)
        {
            UConnection DB = new UConnection(mph.Hotel_ip, mph.Hotel_cn, mph.Hotel_un, mph.Hotel_pw);
            string sql = "";
            int filas = 0;

            sql = "insert into freserno (VN_RESERVA,VN_SECUENCIA,VN_APELLIDO,VN_NOMBRE) VALUES (" + "'"
            + frn.Vn_reserva + "'," + "'" + frn.Vn_secuencia + "'," + "'" + frn.Vn_apellido + "'," + "'"
            + frn.Vn_nombre + "')";
            bool ok = DB.EjecutaSQL(sql, ref filas);
            DB.Dispose();
            return filas > 0;
        }

        private string ObtenerIdReservacion(MapeoHoteles mh)
        {
            string Existe = "";
            int filas = 0, Reservacion = 0;
            UConnection DB = new UConnection(mh.Hotel_ip, mh.Hotel_cn, mh.Hotel_un, mh.Hotel_pw);
            string sql = "select pr_reserva from frparam";
            try
            {
                if (DB.EjecutaSQL(sql))
                {
                    while (DB.ora_DataReader.Read())
                    {
                        Reservacion = Convert.ToInt32(DB.ora_DataReader["PR_RESERVA"]);
                        Reservacion = Reservacion + 1;
                        string sql2 = string.Format("update frparam set pr_reserva = '{0}'", Reservacion);
                        bool ok = DB.EjecutaSQL(sql2, ref filas);
                    }
                }

                string sql3 = "select RV_RESERVA from freserva where RV_RESERVA = '" + Convert.ToString(Reservacion) + "'";
                if (DB.EjecutaSQL(sql3))
                {
                    while (DB.ora_DataReader.Read())
                    {
                            Existe = Convert.ToString(DB.ora_DataReader["RV_RESERVA"]);
                    }
                }

                if (!string.IsNullOrEmpty(Existe))
                {
                    Reservacion = 0;
                }
            }
            catch (Exception ex)
            {
                //rv.Rva_error = ex.Message;
            }
            finally
            {
                DB.Dispose();
            }
            return Convert.ToString(Reservacion);
        }

        private bool GuardarSuceso(string Hotel, string Reservacion, string Suceso)
        {
            DateTime Hoy = DateTime.Today;
            fecha_actual = Hoy.ToString("dd/MM/yy", CultureInfo.CreateSpecificCulture("en-US"));
            hora_actual = DateTime.Now.ToString("hh:mm");
            int filas = 0;

            string sql = string.Format("insert into obmodifi (hotel, reservacion, suceso, fecha, hora) VALUES ('{0}','{1}','{2}','{3}','{4}')", 
                Hotel, Reservacion, Suceso, fecha_actual, hora_actual);

            UConnection DB = new UConnection(Properties.Settings.Default.ipBD, Properties.Settings.Default.serverBD, Properties.Settings.Default.usuarioBD, Properties.Settings.Default.passBD);
            bool ok = DB.EjecutaSQL(sql, ref filas);
            DB.Dispose();
            return ok;
        }

        private MapeoHoteles ObtenerParamsBDHotel(string IdHotelOB)
        {
            UConnection DB = new UConnection(Properties.Settings.Default.ipBD, Properties.Settings.Default.serverBD, Properties.Settings.Default.usuarioBD, Properties.Settings.Default.passBD);
            string sql = "select * from obhotelmap where oh_hotel_ob = '" + IdHotelOB + "'";
            MapeoHoteles mh = new MapeoHoteles();

            try
            {
                if (DB.EjecutaSQL(sql))
                {
                    while (DB.ora_DataReader.Read())
                    {
                        mh.Desc_ob = Convert.ToString(DB.ora_DataReader["OH_DESC_OB"]);
                        mh.Hotel_os = Convert.ToString(DB.ora_DataReader["OH_HOTEL_OS"]);
                        mh.Hotel_un = Convert.ToString(DB.ora_DataReader["OH_HOTEL_UN"]);
                        mh.Hotel_pw = Convert.ToString(DB.ora_DataReader["OH_HOTEL_PW"]);
                        mh.Hotel_cn = Convert.ToString(DB.ora_DataReader["OH_HOTEL_CN"]);
                        mh.Hotel_siglas = Convert.ToString(DB.ora_DataReader["OH_HOTEL_SIGLAS"]);
                        mh.Hotel_fase = Convert.ToString(DB.ora_DataReader["OH_HOTEL_FASE"]);
                        mh.Hotel_ip = Convert.ToString(DB.ora_DataReader["OH_HOTEL_IP"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //rv.Rva_error = ex.Message;
            }
            finally
            {
                DB.Dispose();
            }

            return mh;
        }
        
        private string ObtenerCodigoAgencia(string Canal, string PlanAlimentos)
        {
            string CodigoAgencia = "";
            UConnection DB = new UConnection(Properties.Settings.Default.ipBD, Properties.Settings.Default.serverBD, Properties.Settings.Default.usuarioBD, Properties.Settings.Default.passBD);
            string sql = "select CODIGO from OBAGENCIA where CANAL = '" + Canal + "' and PLAN = '" + PlanAlimentos + "'";

            try
            {
                if (DB.EjecutaSQL(sql))
                {
                    while (DB.ora_DataReader.Read())
                    {
                        CodigoAgencia = Convert.ToString(DB.ora_DataReader["CODIGO"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //rv.Rva_error = ex.Message;
            }
            finally
            {
                DB.Dispose();
            }
            return CodigoAgencia;
        }

        private bool GuardaReservaOMNI(Reservacion res)
        {
            DateTime Hoy = DateTime.Today;
            fecha_actual = Hoy.ToString("dd/MM/yy", CultureInfo.CreateSpecificCulture("en-US"));
            hora_actual = DateTime.Now.ToString("hh:mm");
            int filas = 0;
            string fecha_rev = res.Rva_create_datetime.ToString("dd/MM/yy", CultureInfo.CreateSpecificCulture("en-US"));
            string hora_rev = res.Rva_create_datetime.ToString("hh:mm");
            bool ok = false;
            
            //string theXml = System.Net.WebUtility.HtmlEncode(sw.ToString().Trim());

            string sql = string.Format("insert into OBOMNIBEES (OO_UNIQUEID, OO_ACTION, OO_AGENCIA, OO_MAYORISTA, OO_LLEGADA, OO_SALIDA, OO_TIPO_HAB, OO_PLAN, OO_GRUPO, OO_TARIFA, OO_MONEDA, "
            + "OO_ADULTO, OO_MENOR, OO_HOTEL_RENTA, OO_NOTA, OO_RVAHOTEL, OO_FECHA, OO_HORA, OO_NOTAS, OO_PAIS, OO_FECREV, OO_HORREV, oo_importe, oo_meal_plan,oo_garantia, oo_tipo_precio"
            + ") VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}',{22},'{23}','{24}','{25}')", 
            res.Rva_uniqueID, res.Rva_action, res.Rva_agencia_obees, res.Rva_may, res.Rva_llegada, res.Rva_salida, 
            res.Rva_hab_renta, res.Rva_plan, res.Rva_grupo, res.Rva_tarifa, res.Rva_moneda, res.Rva_adulto, res.Rva_menor, res.Rva_hotel_renta, 
            res.Rva_notas, null, fecha_actual, hora_actual, res.Rva_notas, res.Rva_pais, fecha_rev, hora_rev, Convert.ToDouble(res.Rva_importe).ToString(CultureInfo.InvariantCulture), 
            res.Rva_plancode, res.Rva_tipo_garantia, res.Rva_serv_price_type);

            UConnection DB = new UConnection(Properties.Settings.Default.ipBD, Properties.Settings.Default.serverBD, Properties.Settings.Default.usuarioBD, Properties.Settings.Default.passBD);
            ok = DB.EjecutaSQL(sql, ref filas);
            DB.Dispose();
            return ok;
        }

        private string encapsulateSOAP(string body)
        {
            String soap = "";
            soap += "\n<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\"> ";
            soap += "\n<soapenv:Body>";
            soap += "\n" + body; // BODY either sucess or error.
            soap += "\n</soapenv:Body>";
            soap += "</soapenv:Envelope>";

            return soap;
        }

        private OTA_HotelResNotifRS obtenerMensajeError(Reservacion rva, List<HotelReservationIDrs> reservas)
        {
            StringWriter xml = new StringWriter();
            

            OTA_HotelResNotifRS response = new OTA_HotelResNotifRS();
            response.EchoToken = rva.Rva_echotoken;
            DateTime Hoy = DateTime.Today;
            string fecha_hora = Hoy.ToString("yyyy-MM-dd'T'hh:mm:ss%K", CultureInfo.CreateSpecificCulture("en-US"));
            response.TimeStamp = fecha_hora;
            response.Version = "3.0";
            response.Error = rva.Rva_error;
            UniqueIDrs uirs = new UniqueIDrs();
            uirs.Type = rva.Rva_ResID_Type;
            uirs.ID = rva.Rva_uniqueID;
            ResGlobalInfors rgi = new ResGlobalInfors();
            rgi.HotelReservations = reservas;
            HotelReservationrs hrs = new HotelReservationrs();
            hrs.ResGlobalInfo = rgi;
            hrs.UniqueIDrs = uirs;
            HotelReservationsrs hrss = new HotelReservationsrs();
            hrss.HotelReservationrs = hrs;
            response.HotelReservationsrs = hrss;
            //var serializer = new XmlSerializer(typeof(OTA_HotelResNotifRS));
            //serializer.Serialize(xml, response);
            return response;
        }

        private OTA_HotelResNotifRS obtenerMensajeSatisfaccion(Reservacion rva, List<HotelReservationIDrs> reservas)
        {
            StringWriter xml = new StringWriter();
            OTA_HotelResNotifRS response = new OTA_HotelResNotifRS();
            response.EchoToken = rva.Rva_echotoken;
            DateTime Hoy = DateTime.Today;
            string fecha_hora = Hoy.ToString("yyyy-MM-dd'T'hh:mm:ss%K", CultureInfo.CreateSpecificCulture("en-US"));
            response.TimeStamp = fecha_hora;
            response.Version = "3.0";
            response.Success = "";
            UniqueIDrs uirs = new UniqueIDrs();
            uirs.Type = rva.Rva_ResID_Type;
            uirs.ID = rva.Rva_uniqueID;
            ResGlobalInfors rgi = new ResGlobalInfors();
            rgi.HotelReservations = reservas;
            HotelReservationrs hrs = new HotelReservationrs();
            hrs.ResGlobalInfo = rgi;
            hrs.UniqueIDrs = uirs;
            HotelReservationsrs hrss = new HotelReservationsrs();
            hrss.HotelReservationrs = hrs;
            response.HotelReservationsrs = hrss;
            //var serializer = new XmlSerializer(typeof(OTA_HotelResNotifRS));
            //serializer.Serialize(xml, response);
            return response;
        }

        private bool booking(Reservacion res)
        {
            // funcion que voy a procesar
            string sp = "FNRVA_OBEES";
            bool ok;

            UConnection DB = new UConnection(Properties.Settings.Default.ipBD, Properties.Settings.Default.serverBD, Properties.Settings.Default.usuarioBD, Properties.Settings.Default.passBD);
            OracleCommand cmd = new OracleCommand();
            OracleParameter retval = new OracleParameter("V_RESERVA", OracleDbType.Varchar2, 50);
            retval.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(retval);
            //res.Rva_oasis_rva = Convert.ToString(retval.Value);
            OracleParameter inval = new OracleParameter("inval", OracleDbType.Varchar2);
            inval.Direction = ParameterDirection.Input;
            inval.Value = res.Rva_action;
            cmd.Parameters.Add(inval);
            OracleParameter inval2 = new OracleParameter("inval2", OracleDbType.Varchar2);
            inval2.Direction = ParameterDirection.Input;
            inval2.Value = res.Rva_uniqueID;
            cmd.Parameters.Add(inval2);
            OracleParameter inval3 = new OracleParameter("inval3", OracleDbType.Varchar2);
            inval3.Direction = ParameterDirection.Input;
            inval3.Value = fecha_actual;
            cmd.Parameters.Add(inval3);
            OracleParameter inval4 = new OracleParameter("inval4", OracleDbType.Varchar2);
            inval4.Direction = ParameterDirection.Input;
            inval4.Value = hora_actual;
            cmd.Parameters.Add(inval4);
            OracleParameter outval = new OracleParameter("outval", OracleDbType.Varchar2, 50);
            outval.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outval);
            //res.Rva_oasis_errcode = Convert.ToString(outval.Value);
            OracleParameter outval2 = new OracleParameter("outval2", OracleDbType.Varchar2, 50);
            outval2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outval2);
            //res.Rva_oasis_errdesc = Convert.ToString(outval2.Value);

            ok = DB.EjecutaSP(ref cmd, sp);
            if (ok)
            {
                Reserva = cmd.Parameters["V_RESERVA"].Value.ToString();
                ErrorCode = cmd.Parameters["ERRCODE"].Value.ToString();
                ErrDesc = cmd.Parameters["ERRDESC"].Value.ToString();
            }
            return ok;
        }
    }
}

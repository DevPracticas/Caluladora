using capaDatos;
using capaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class operaciones
    {
        consultas objConsultas = new consultas();
        public string nuevaOperacion(entidades_resultado_operacion datos)
        {
            switch (datos.operacion)
            {
                case "Suma":
                    datos.resultado = datos.dato1 + datos.dato2;
                    break;

                case "Resta":
                    datos.resultado = datos.dato1 - datos.dato2;

                    break;

                case "Multiplicación":
                    datos.resultado = datos.dato1 * datos.dato2;

                    break;

                case "División":
                    datos.resultado = datos.dato1 / datos.dato2;
                    break;
            }

            return objConsultas.nuevaOperacion(datos);
        }

        public entidades_resultado_operacion buscar(int id)
        {
            return objConsultas.buscar(id);
        }

        public string update(entidades_resultado_operacion datos)
        {
            switch (datos.operacion)
            {
                case "Suma":
                    datos.resultado = datos.dato1 + datos.dato2;                    
                    break;

                case "Resta":
                    datos.resultado = datos.dato1 - datos.dato2;

                    break;

                case "Multiplicación":
                    datos.resultado = datos.dato1 * datos.dato2;

                    break;

                case "División":
                    datos.resultado = datos.dato1 / datos.dato2;
                    break;
            }
            return objConsultas.update(datos);
        }
    }
}

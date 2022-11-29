using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Informe
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.RepublicaGalacticaEntities1 context = new DL.RepublicaGalacticaEntities1())
                {

                    var query = context.Informe().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Maestro maestro = new ML.Maestro();
                            //maestro.NombreCaballero = obj.NombreCaballero;
                            //maestro.Rango = Convert.ToBoolean(obj.Rango);
                            //maestro.Combate = obj.NombreCombate;
                            maestro.OrdenJedi = new ML.OrdenJedi();
                            maestro.OrdenJedi.Nombre = obj.NombreCaballero;
                            maestro.Rango = Convert.ToBoolean(obj.Rango);
                            maestro.SistemasAmenazados = new ML.SistemasAmenazados();
                            maestro.SistemasAmenazados.Sistema = new ML.Sistema();
                            maestro.SistemasAmenazados.Sistema.Nombre = obj.NombreCombate;

                        result.Objects.Add(maestro);
                        }

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros.";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}

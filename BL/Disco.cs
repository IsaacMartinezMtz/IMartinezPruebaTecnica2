using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Disco
    {
        public ML.Result Add(ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            try
            {
               using(DL.IMartinezPruebaTecnica2Entities1 context = new DL.IMartinezPruebaTecnica2Entities1())
                {
                    var query = context.DiscoAdd(disco.Titulo, disco.Artista, disco.GeneroMusical, disco.Duracion, disco.Año, disco.Distribuidora, disco.Ventas, disco.Disponibilidad);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else 
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al ingresar el disco";
                    }
                    
                } 
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage= ex.Message;
                
            }
            return result;
        }
        public ML.Result Update(ML.Disco disco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.IMartinezPruebaTecnica2Entities1 context = new DL.IMartinezPruebaTecnica2Entities1())
                {
                    var query = context.DiscoUpdate(disco.IdDico, disco.Titulo, disco.Artista, disco.GeneroMusical, disco.Duracion, disco.Año, disco.Distribuidora, disco.Ventas, disco.Disponibilidad);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar el disco";
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

        public ML.Result Delete (ML.Disco disco)
        {
            ML.Result result = new ML.Result ();
            try
            {
                using (DL.IMartinezPruebaTecnica2Entities1 context = new DL.IMartinezPruebaTecnica2Entities1())
                {
                    var query = context.DiscoDelete(disco.IdDico);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar el disco";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage= ex.Message;
            }
            return result;
        }
    }
}

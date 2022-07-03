using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Bll.ModalidadCurso.Interfaces
{
  
   public interface IAdModalidadCurso

    {
        //Se llaman todos los metodos que se necesitan para ModalidadCurso


        API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos VerTodosModalidadCursos();
        API.Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso VerDetalleModalidadCurso(API.Dto.ModalidadCurso.Entrada.VerDetalleModalidadCurso pInformacion);
        API.Dto.ModalidadCurso.Salida.AgregarModalidadCurso AgregarModalidadCurso(API.Dto.ModalidadCurso.Entrada.AgregarModalidadCurso pInformacion);
        API.Dto.ModalidadCurso.Salida.EditarModalidadCurso EditarModalidadCurso(API.Dto.ModalidadCurso.Entrada.EditarModalidadCurso pInformacion);
        API.Dto.ModalidadCurso.Salida.EliminarModalidadCurso EliminarModalidadCurso(API.Dto.ModalidadCurso.Entrada.EliminarModalidadCurso pInformacion);



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeuPet.Dto
{
    public record PetResponse( int Id, string Nome, string DataNascimento, string Sexo, string Tipo, string Foto);
}
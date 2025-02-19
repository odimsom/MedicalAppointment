﻿
using Arquitectura.Domain.Entities.medical;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Imedical;

namespace Arquitectura.Persistance.Repositories.medical
{
    public class SpecialtiesRepository : BaseRepository<Specialties, char>, ISpecialtiesRepository
    {
        public SpecialtiesRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}

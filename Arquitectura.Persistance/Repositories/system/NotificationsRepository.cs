﻿

using Arquitectura.Domain.Entities.System;
using Arquitectura.Persistance.Base;
using Arquitectura.Persistance.Context;
using Arquitectura.Persistance.Interfaces.Isystem;

namespace Arquitectura.Persistance.Repositories.system
{
    public class NotificationsRepository : BaseRepository<Notifications, int>, INotificationsRepository
    {
        public NotificationsRepository(ArquitectureContex contex) : base(contex)
        {
        }
    }
}

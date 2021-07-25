﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Info
{
    public interface IEntityInfo
    {
        public string Publicar(IDBEntity entidad);

        public string Publicar(IEnumerable<IDBEntity> ListaTipo);
    }
}

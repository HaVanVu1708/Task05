using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HVVMusic.Models
{
    public interface IStoreRepository
    {
        IQueryable<Music> Musics { get; }
    }
}

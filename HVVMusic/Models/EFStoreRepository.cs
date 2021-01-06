using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HVVMusic.Models
{
    public class EFStoreRepository:IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Music> Musics => context.Musics;
    }
}

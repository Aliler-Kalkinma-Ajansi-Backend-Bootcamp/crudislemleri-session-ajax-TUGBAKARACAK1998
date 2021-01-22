using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Services
{
  public  class GenericService<TEntity> where TEntity:class,new()
    {
        public List<TEntity> Hepsi()
        {
            using (var srv = new ProjeToDoContext())
            {

                return srv.Set<TEntity>().ToList();
            }

        }


        public void Sil(TEntity TEntity)
        {
            using var context = new ProjeToDoContext();
            context.Set<TEntity>().Remove(TEntity);
            context.SaveChanges();


        }


        public void Ekle(TEntity TEntity)
        {
            using var context = new ProjeToDoContext();
            context.Set<TEntity>().Add(TEntity);
            context.SaveChanges();

        }
        public void Guncelle(TEntity TEntity)
        {
            using var context = new ProjeToDoContext();
            context.Set<TEntity>().Update(TEntity);
            context.SaveChanges();

        }


        public TEntity GetirIdile(int id)
        {
            using var context = new ProjeToDoContext();
            return context.Set<TEntity>().Find(id);

        }
    }
}

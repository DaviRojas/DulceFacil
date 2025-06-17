using DulceFacil.Dominio.Modelos.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    //implementacion de la clase IRepositorio
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly DulceFacil2DBContext _dBContext;
        private readonly DbSet<T> _dbSet;

        public RepositorioImpl(DulceFacil2DBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = dBContext.Set<T>();
        }

        public async Task AddAsync(T TEntity)
        {
            try
            {
                await _dbSet.AddAsync(TEntity);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error: No se pudo insertar datos" + e.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await GetByAsync(id);
                _dbSet.Remove(entity);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error: No se pudo eliminar los datos" + e.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error: No se pudo listar los datos" + e.Message);
            }
        }

        public async Task<T> GetByAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync();

            }
            catch (Exception e)
            {
                throw new Exception("Error: No se pudo buscar por id datos" + e.Message);
            }
        }

        public async Task UpdateAsync(T Entity)
        {
            try
            {
                _dbSet.Update(Entity);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error: No se pudo actualizar datos" + e.Message);
            }
        }
    }
}
}

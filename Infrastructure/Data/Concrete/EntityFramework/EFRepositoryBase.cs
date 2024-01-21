using Infrastructure.Data.Abstract;
using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Concrete.EntityFramework
{
	public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
		where TEntity : BaseEntity, IBaseDomain, new()
		where TContext: DbContext,new()
	{
		public void Add(TEntity entity)
		{
			using (TContext ct=new TContext())
			{
				ct.Set<TEntity>().Add(entity);
				ct.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			using (TContext ct = new TContext())
			{
				ct.Set<TEntity>().Remove(entity);
				ct.SaveChanges();
			}
		}

		public void Delete(int Id)
		{
			using (TContext ct = new TContext())
			{
				TEntity entity = ct.Set<TEntity>().FirstOrDefault(x => x.Id == Id);
				ct.Set<TEntity>().Remove(entity);
				ct.SaveChanges();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includelist)
		{
			using (TContext ct = new TContext())
			{
				IQueryable<TEntity> query=ct.Set<TEntity>();
				if (includelist.Length>0)
				{
					foreach (var item in includelist)
					{
						query = query.Include(item);
					}

				}
				return query.SingleOrDefault(filter);
			}
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includelist)
		{
			using (TContext ct = new TContext())
			{
				IQueryable<TEntity> query = ct.Set<TEntity>();
				if (includelist.Length > 0)
				{
					foreach (var item in includelist)
					{
						query = query.Include(item);
					}

				}
				return filter==null ? query.ToList() : query.Where(filter).ToList();
			}
		}

		public TEntity GetById(int Id, params string[] includelist)
		{
			using (TContext ct = new TContext())
			{
				IQueryable<TEntity> query = ct.Set<TEntity>();
				if (includelist.Length > 0)
				{
					foreach (var item in includelist)
					{
						query = query.Include(item);
					}

				}
				return query.SingleOrDefault(x=>x.Id==Id);
			}
		}

		public void Update(TEntity entity)
		{
			using (TContext ct = new TContext())
			{
				TEntity ent = ct.Set<TEntity>().Attach(entity).Entity;
				ct.Entry(entity).State=EntityState.Modified;
				ct.SaveChanges();
			}
		}
	}
}

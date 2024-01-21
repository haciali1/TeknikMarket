using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Abstract
{
	public interface IRepository<TEntity>
		where TEntity : BaseEntity,IBaseDomain,new()
	{
		void Add(TEntity entity);
		void Update(TEntity entity);
		//Personel.Delete(4)
		void Delete(TEntity entity);
		void Delete(int Id);
		//Personel.GetAll(x=>x.adı=="Nancy").Include(Satislar).Include(Satislar.Satislistesi)
		//Personel.GetAll(x=>x.adı=="Nancy","Satislar","Satislar.Satislistesi")
		//filter=null olmasaydı Personel.GetAll() yapamazdık.
		List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter=null,params string[] includelist);
		TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includelist);
		//Personel.GetById(5,"Satislar","Satislar.Satislistesi")
		TEntity GetById(int Id,params string[] includelist);
	}
}

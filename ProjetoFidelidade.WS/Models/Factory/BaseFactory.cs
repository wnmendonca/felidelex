using AutoMapper;

namespace ProjetoFidelidade.WS.Models.Factory
{
    public interface IBaseFactory<TEntity, TModel>
    {
        TModel Convert(TEntity entity);
        TEntity Convert(TModel model);
    }

    public class BaseFactory<TEntity, TModel> : IBaseFactory<TEntity, TModel>
    {
        public virtual TModel Convert(TEntity entity)
        {
            return Mapper.Map<TEntity, TModel>(entity);
        }

        public virtual TEntity Convert(TModel model)
        {
            return Mapper.Map<TModel, TEntity>(model);
        }
    }
}
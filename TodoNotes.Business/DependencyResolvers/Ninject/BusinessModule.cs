using Ninject.Modules;
using TodoNotes.Business.Abstract;
using TodoNotes.Business.Concrete;
using TodoNotes.DataAccess.Abstract;
using TodoNotes.DataAccess.Concrete.EntityFramework;

namespace TodoNotes.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITodoItemService>().To<TodoItemManager>().InSingletonScope();
            Bind<ITodoItemDal>().To<EfTodoItemDal>().InSingletonScope();
            Bind<INoteService>().To<NoteManager>().InSingletonScope();
            Bind<INoteDal>().To<EfNoteDal>().InSingletonScope();
        }
    }
}

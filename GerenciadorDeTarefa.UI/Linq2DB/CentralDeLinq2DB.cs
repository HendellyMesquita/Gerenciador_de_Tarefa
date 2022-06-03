using Ninject.Modules;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using Ninject;
using GerenciadorDeTarefa.Domain.Alertas;

namespace GerenciadorDeTarefa.UI.Linq2DB
{
    public class CentralDeLinq2DB : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServicoGerenciamentoHora)).To(typeof(ServicoGerenciamentoHora));
        }
        public static CentralDeLinq2DB Create()
        {
            return new CentralDeLinq2DB();
        }
    }
    public class LinqResolve
    {
        private static IKernel _ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}

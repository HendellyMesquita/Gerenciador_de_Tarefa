using Ninject.Modules;
using Ninject;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using GerenciadorDeTarefa.Domain.Alertas;
using GerenciadorDeTarefa.Domain.BlocoDeNotas;

namespace GerenciadorDeTarefa.UI.Linq2DB
{
    public class CentralDeLinq2DB : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServicoGerenciamentoHora)).To(typeof(ServicoGerenciamentoHora));
            Bind(typeof(IServicoDeAlerta)).To(typeof(ServicoDeAlerta));
            Bind(typeof(IServicoDeGerrenciamentoDeArquivos)).To(typeof(ServicoDeGerrenciamentoDeArquivos));
            Bind(typeof(IServicoDeFontes)).To(typeof(ServicoDeFontes));
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

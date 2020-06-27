using System;

namespace MeuPrimeiroProjeto.DAL.Infra
{
    public interface IRepository : IDisposable
    {
        IUnityOfWork UnityOfWork { get; }
    }
}

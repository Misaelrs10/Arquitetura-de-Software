using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPrimeiroProjeto.DAL.Infra
{
    public interface IRepository : IDisposable
    {
        IUnityOfWork UnityOfWork { get; }
    }
}

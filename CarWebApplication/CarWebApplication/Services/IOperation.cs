using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace CarWebApplication.Services
{
    public interface IOperation
    {
        Guid Id { get;}
    }

    public interface ISingletonOperation: IOperation
    {

    }

    public class SingletonOperation : ISingletonOperation
    {
        public Guid Id { get ; }
        public SingletonOperation()
        {
            Id = Guid.NewGuid();
        }
    }

    //// ITransientOperation 
    public interface ITransientOperation:IOperation
    {
    }

    public class TransientOperation : ITransientOperation
    {
        public Guid Id { get; }
        public TransientOperation()
        {
            Id = Guid.NewGuid();
        }
    }

    public interface IScopedOperation:IOperation
    {

    }

    public class ScopedOperation: IScopedOperation
    {
        public Guid Id { get; }
        public ScopedOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}

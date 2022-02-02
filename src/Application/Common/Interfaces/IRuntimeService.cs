using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lomboque.Application.Common.Interfaces
{
    public interface IRuntimeService
    {
        Task RunInBackground(TimeSpan timeSpan, Action action);
        
    }
}
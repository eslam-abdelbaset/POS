using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Services
{
    public abstract class ServiceBase
    {
        protected IRepositoryWrapper _repoWrapper;
        public ServiceBase(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
    }
}

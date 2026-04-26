using System;
using System.Collections.Generic;
using System.Text;

namespace LicenseHub.Forms
{
    public interface IEntityDialog<TEntity>
    {
        public TEntity? Result { get; }
    }
}

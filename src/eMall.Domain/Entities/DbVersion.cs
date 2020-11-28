using System;
using eMall.Domain.Entities.Base;

namespace eMall.Domain.Entities
{
    public class DbVersion : Entity
    {
        public string Version { get; private set; }
        public string Description { get; private set; }
        public DateTime DateApplied { get; private set; }

        protected DbVersion()
        {
            
        }
    }
}
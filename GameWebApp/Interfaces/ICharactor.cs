using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWebApp.Interfaces
{
    public interface ICharactor
    {
        string CharactorName { get; set; }
        int Priority { get; }
        /// <summary>
        /// Including actions that happens in the night
        /// </summary>
        void PassiveAction();
        void ActiveAction();
    }
}

using GameWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWebApp.Pages.Charactors
{
    public class Civilian : ICharactor
    {
        string _CharactorName;
        public Civilian(string name)
        {
            _CharactorName = name;
        }
        string ICharactor.CharactorName { get => _CharactorName; set => _CharactorName = value; }

        int ICharactor.Priority => Int32.MinValue;

        void ICharactor.ActiveAction()
        {
            return;
        }

        void ICharactor.PassiveAction()
        {
            return;
        }
    }
}

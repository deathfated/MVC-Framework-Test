using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.FTest.ClickGame
{
    public interface IClickGameModel : IBaseModel
    {
        public int Coin { get; }
    }
}

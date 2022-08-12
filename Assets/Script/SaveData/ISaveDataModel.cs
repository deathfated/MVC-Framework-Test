using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.FTest.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Coin { get; }
    }
}

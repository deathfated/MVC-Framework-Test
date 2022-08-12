using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.FTest.Message
{
    public class SoundfxController : BaseController<SoundfxController>
    {
        public void OnUpdateCoin()
        {
            Debug.Log("Cha-ching Cha-ching");
        }
    }
}

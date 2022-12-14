using Agate.MVC.Base;
using Agate.MVC.Core;
using Deathfated.FTest.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Deathfated.FTest.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]{
                 new SaveDataController()
    };
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            return null;
        }

        private void CreateEventSystem()
        {
            GameObject obj = new("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(obj);
        }
    }
}

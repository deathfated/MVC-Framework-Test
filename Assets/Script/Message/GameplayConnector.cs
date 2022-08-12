using Agate.MVC.Base;
using Deathfated.FTest.Message;
using Deathfated.FTest.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.FTest.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SaveDataController _saveData;
        private SoundfxController _soundfx;

        protected override void Connect()
        {
            Subscribe<UpdateCoinMessage>(OnUpdateCoin);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateCoinMessage>(OnUpdateCoin);
        }

        public void OnUpdateCoin(UpdateCoinMessage message)
        {
            _saveData.OnUpdateCoin(message.Coin);
            _soundfx.OnUpdateCoin();
        }
    }
}
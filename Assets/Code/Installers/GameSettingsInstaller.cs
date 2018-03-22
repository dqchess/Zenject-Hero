using System;
using UnityEngine;
using Zenject;

namespace Code
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "Ultimate Hero/GameSettings")]
    public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
    {
        public GameStateSettings gameState;
        [Serializable]
        public class GameStateSettings
        {
            //
        }
        
        public PlayerSettings Player;
        
        [Serializable]
        public class PlayerSettings
        {
            public PlayerMovementHandler.Settings PlayerMovementHandler;
            public PlayerAnimatorHandler PlayerAnimatorHandler;
        }
        
        public override void InstallBindings()
        {
            Container.BindInstance(Player.PlayerMovementHandler);
            Container.BindInstance(Player.PlayerAnimatorHandler);
        }
    }
}
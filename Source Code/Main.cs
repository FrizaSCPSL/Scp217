using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
using Scp914 = Exiled.Events.Handlers.Scp914;

namespace Scp217
{
    internal class Main : Plugin<Config>
    {
        public override string Author { get; } = "Friza";

        public override string Name { get; } = "Scp217";

        public override string Prefix { get; } = "Scp217";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 0);

        internal EventHandlers EventHandlers { get; set; }
        
        
        public override void OnEnabled()
        {
            Main.Singleton = this;
            EventHandlers = new();

            Exiled.Events.Handlers.Scp914.UpgradingPlayer += EventHandlers.OnScp914UpgradingPlayer;
            Player.Died += EventHandlers.OnDied;
            Player.UsingItem += EventHandlers.OnUsingItem;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp914.UpgradingPlayer -= EventHandlers.OnScp914UpgradingPlayer;
            Player.Died -= EventHandlers.OnDied;
            Player.UsingItem -= EventHandlers.OnUsingItem;

            this.EventHandlers = null;
            
        }
        
        public static Main Singleton;
    }
}
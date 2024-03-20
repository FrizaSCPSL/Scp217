using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using Exiled.CustomRoles;
using PluginAPI.Commands;
using Server = Exiled.Events.Handlers.Server;
using CommandSystem.Commands.RemoteAdmin.ServerEvent;
using CustomPlayerEffects;
using Exiled.API.Extensions;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Scp914;
using Interactables.Interobjects;
using MEC;


namespace Scp217
{
    public class EventHandlers
    {
        public Random random = new Random();
        
        public void OnScp914UpgradingPlayer(UpgradingPlayerEventArgs ev)
        {
            int rand = random.Next(1, 100);
            if (rand <= 5)
            {
                ev.Player.CustomInfo = "Заражен вирусом часового механизма. Стадия 1";
                ev.Player.Broadcast(7, "Вы заразились вирусом часового механизма!");
                if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 1")
                {
                    Timing.CallDelayed(30f, () =>
                    {
                        ev.Player.CustomInfo = "Заражен вирусом часового механизма. Стадия 2";
                        ev.Player.EnableEffect(EffectType.Poisoned, 1, 25f);
                        ev.Player.Broadcast(7, "Вы чувствуете себя не хорошо!");
                    });
                }
                if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 2")
                {
                    Timing.CallDelayed(60f, () =>
                    {
                        ev.Player.CustomInfo = "Заражен вирусом часового механизма. Стадия 3";
                        ev.Player.EnableEffect(EffectType.Poisoned, 1, 40f);
                        ev.Player.Broadcast(7, "Вы чувствуете себя ужасно!");
                    });
                }
                if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 3")
                {
                    Timing.CallDelayed(90f, () =>
                    {
                        ev.Player.CustomInfo = "Заражен вирусом часового механизма. Стадия 4";
                        ev.Player.EnableEffect(EffectType.Poisoned, 40, 70f);
                        ev.Player.Broadcast(7, "Вы чувствуете близкую смерть!"); 
                    });
                }
                if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 4")
                {
                    Timing.CallDelayed(60f, () =>
                    {
                        ev.Player.Broadcast(4, "Вы сейчас умрете!"); 
                    });
                    Timing.CallDelayed(64f, () =>
                    {
                        ev.Player.Kill("Заражение распространилось. Слишком сильно...");
                    });
                }
            }

        }

        public void OnDied(DiedEventArgs ev)
        {
            if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 1")
            {
                ev.Player.Role.Set(RoleTypeId.Tutorial, RoleSpawnFlags.AssignInventory);
                ev.Player.CustomInfo = "SCP 217-1";
                ev.Player.ChangeAppearance(RoleTypeId.Scp0492);
                ev.Player.EnableEffect(EffectType.Stained);
                ev.Player.EnableEffect(EffectType.Scp1853, 4);
                ev.Player.MaxHealth = 250;
                ev.Player.Health = 250;
                ev.Player.AddAhp(200f);
                if (ev.Player.Health <= 100)
                {
                    ev.Player.MaxHealth = 100;
                    ev.Player.DisableEffect(EffectType.Stained);
                    ev.Player.AddAhp(200f);
                    ev.Player.Broadcast(7, "Вы утратили свое здоровье!");
                }
            }
            if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 2")
            {
                ev.Player.Role.Set(RoleTypeId.Tutorial, RoleSpawnFlags.AssignInventory);
                ev.Player.CustomInfo = "SCP 217-1";
                ev.Player.ChangeAppearance(RoleTypeId.Scp0492);
                ev.Player.EnableEffect(EffectType.Stained);
                ev.Player.EnableEffect(EffectType.Scp1853, 4);
                ev.Player.MaxHealth = 250;
                ev.Player.Health = 250;
                ev.Player.AddAhp(200f);
                if (ev.Player.Health <= 100)
                {
                    ev.Player.MaxHealth = 100;
                    ev.Player.DisableEffect(EffectType.Stained);
                    ev.Player.AddAhp(200f);
                    ev.Player.Broadcast(7, "Вы утратили свое здоровье!");
                }
            }
            if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 3")
            {
                ev.Player.Role.Set(RoleTypeId.Tutorial, RoleSpawnFlags.AssignInventory);
                ev.Player.CustomInfo = "SCP 217-1";
                ev.Player.ChangeAppearance(RoleTypeId.Scp0492);
                ev.Player.EnableEffect(EffectType.Stained);
                ev.Player.EnableEffect(EffectType.Scp1853, 4);
                ev.Player.MaxHealth = 250;
                ev.Player.Health = 250;
                ev.Player.AddAhp(200f);
                if (ev.Player.Health <= 100)
                {
                    ev.Player.MaxHealth = 100;
                    ev.Player.DisableEffect(EffectType.Stained);
                    ev.Player.AddAhp(200f);
                    ev.Player.Broadcast(7, "Вы утратили свое здоровье!");
                }
            }
            if (ev.Player.CustomInfo == "Заражен вирусом часового механизма. Стадия 4")
            {
                ev.Player.Role.Set(RoleTypeId.Tutorial, RoleSpawnFlags.AssignInventory);
                ev.Player.CustomInfo = "SCP 217-1";
                ev.Player.ChangeAppearance(RoleTypeId.Scp0492);
                ev.Player.EnableEffect(EffectType.Stained);
                ev.Player.EnableEffect(EffectType.Scp1853, 4);
                ev.Player.MaxHealth = 250;
                ev.Player.Health = 250;
                ev.Player.AddAhp(200f);
                if (ev.Player.Health <= 100)
                {
                    ev.Player.MaxHealth = 100;
                    ev.Player.DisableEffect(EffectType.Stained);
                    ev.Player.AddAhp(200f);
                    ev.Player.Broadcast(7, "Вы утратили свое здоровье!");
                }
            }
            if (ev.Player.CustomInfo == "SCP 217-1")
            {
                ev.Player.CustomInfo = "";
            }
        }

        public void OnUsingItem(UsingItemEventArgs ev)
        {
            if (ev.Player.CustomInfo == "Заражен вирусом часового механизма")
            {
                if (ev.Item.Type == ItemType.SCP500)
                {
                    ev.Player.CustomInfo = "";
                    ev.Player.Broadcast(7, "Вы излечились (не станете SCP-271-1)! Однако стадии все еще распространяются!");
                }
            }
        }
    }
}
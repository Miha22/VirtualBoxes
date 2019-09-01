﻿using System;
using System.Collections.Generic;
using Logger = Rocket.Core.Logging.Logger;
using Rocket.API;

namespace ItemRestrictorAdvanced
{
    sealed class CommandUIEmergency : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;
        public string Name => "emergencyuistop";
        public string Help => "Use this command in case if UI craches and everybody has non clearable UI";
        public string Syntax => "/emuistop";
        public List<string> Aliases => new List<string>() { "emuistop" };
        public List<string> Permissions => new List<string>() { "rocket.emergencyuistop", "rocket.emuistop" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            foreach (var group in Plugin.Instance.Configuration.Instance.Groups)
            {
                Console.WriteLine($"{group.GroupID}: {group.BoxLimit}");
            }
            //ManageUI.UnLoad();
            //Console.WriteLine(ManageUI.Instances == null);
            //Logger.Log("Inventory UI stoped", ConsoleColor.Cyan);
            Rocket.Unturned.Player.UnturnedPlayer player = (Rocket.Unturned.Player.UnturnedPlayer)caller;
            SDG.Unturned.EffectManager.askEffectClearAll();
        }
    }
}

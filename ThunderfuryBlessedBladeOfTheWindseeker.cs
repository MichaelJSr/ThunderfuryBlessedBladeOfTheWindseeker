using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThunderfuryBlessedBladeOfTheWindseeker
{
    public class ThunderfuryBlessedBladeOfTheWindseeker : Mod
    {
        public ThunderfuryBlessedBladeOfTheWindseeker()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}


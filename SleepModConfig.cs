using Terraria.ModLoader.Config;

namespace SleepMod
{
    public class SleepModConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Sleep through rain")]
        public bool SleepThroughRain { get; set; }

        [Label("Sleep through the day")]
        public bool SleepThroughDay { get; set; }
    }
}
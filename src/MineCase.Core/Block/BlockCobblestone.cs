﻿using System;
using System.Collections.Generic;
using System.Text;
using MineCase.Item;

namespace MineCase.Block
{
    public class BlockCobblestone : Block
    {
        public BlockCobblestone()
        {
            FullBlock = true;
            LightOpacity = 255;
            Translucent = false;
            LightValue = 0;
            UseNeighborBrightness = false;
            BlockHardness = 1.0f;
            BlockResistance = 0.0f;
            EnableStats = false;
            NeedsRandomTick = true;
            IsBlockContainer = false;
            BlockSoundType = null;
            BlockParticleGravity = 1.0f;
            BaseBlockState = new BlockState { Id = (uint)BlockId.Cobblestone, MetaValue = 0 };
            Name = "cobblestone";
        }
    }
}

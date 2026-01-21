using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Farmlike.Enums
{
    // Item > 可放在背包中的基础物品，不可放置
    // Tool > 工具
    // Crop > 种子、成长阶段的作物，主要用于地面展示
    // Consumable > 所有的可使用消耗品
    public enum ItemType
    {
        Item,
        Tool,
        Crop,
        Consumable
    }
}


using Farmlike.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Farmlike.SOData
{
    [CreateAssetMenu(menuName = "Items/ItemData")]
    public class ItemData : ScriptableObject
    {
        public string ID;
        public string DisplayName;
        public ItemType Type;
        public Sprite Icon;
        public int BaseValue;
    }
}


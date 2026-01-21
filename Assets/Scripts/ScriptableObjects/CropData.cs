using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Farmlike.SOData
{
    [CreateAssetMenu(menuName = "Items/CropData")]
    public class CropData : ItemData
    {
        public GrowthStage[] GrowthStages;
        public string FinalProductID;
    }

    [System.Serializable]
    public struct GrowthStage
    {
        public int DaysRequired;
        public Sprite StageSprite;
        public bool CanHarvest;
    }
}
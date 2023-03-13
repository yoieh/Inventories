using UnityEngine;

namespace ExpressoBits.Inventories
{
    [AddComponentMenu("Expresso Bits/Inventories/" + nameof(CraftStationObject))]
    public class CraftStationObject : MonoBehaviour
    {
        public CraftStation CraftStation => station;
        [SerializeField] private CraftStation station;
    }
}


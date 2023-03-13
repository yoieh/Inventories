using UnityEngine;

namespace ExpressoBits.Inventories
{
    [AddComponentMenu("Expresso Bits/Inventories/" + nameof(ItemObject))]
    public class ItemObject : MonoBehaviour
    {

        public Item Item => item;
        public bool IsPickable => isPickable;

        [SerializeField]
        private Item item;

        [SerializeField]
        private bool isPickable;

        public void SetPickable(bool isPickable)
        {
            this.isPickable = isPickable;
        }

    }
}


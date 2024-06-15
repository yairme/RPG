using UnityEngine;
public class Item : MonoBehaviour
{   
    #region Item Properties
    /// <summary>
    /// To sort items in the inventory.
    /// </summary>
    protected enum ItemType
    {
        Weapon,
        Armor,
        Consumable,
        Quest,
        Key,
        Junk,
        CraftingMaterials,
        Currency,
        Misc
    }
    
    /// <summary>
    /// The rarity of the item.
    /// </summary>
    protected enum ItemRarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Mythic
    }
    
    /// <summary>
    /// The item icon.
    /// </summary>
    protected Sprite itemIcon;
    
    /// <summary>
    /// The item name.
    /// </summary>
    protected string itemName;
    
    /// <summary>
    /// The item description.
    /// </summary>
    protected string itemDescription;
    
    /// <summary>
    /// The unique identifier of the item.
    /// </summary>
    protected int itemID;
    #endregion 
    #region Item Misc Properties
    /// <summary>
    /// The value of the item.
    /// </summary>
    protected int itemValue;
    
    /// <summary>
    /// The durability of the item.
    /// </summary>
    protected int itemDurability;
    
    /// <summary>
    /// The required level to use the item.
    /// </summary>
    protected int itemRequiredLevel;
    
    /// <summary>
    /// The rarity level of the item.
    /// </summary>
    protected int itemRarity;
    
    /// <summary>
    /// The current stack size of the item.
    /// </summary>
    protected int itemStack;
    
    /// <summary>
    /// The maximum stack size of the item.
    /// </summary>
    protected int itemMaxStack;
    #endregion 
    #region Item Booleans
    /// <summary>
    /// Indicates whether the item can be stacked.
    /// </summary>
    protected bool itemStackable;
    
    /// <summary>
    /// Indicates whether the item is consumable.
    /// </summary>
    protected bool itemConsumable;
    
    /// <summary>
    /// Indicates whether the item can be equipped.
    /// </summary>
    protected bool itemEquipable;
    
    /// <summary>
    /// Indicates whether the item is currently equipped.
    /// </summary>
    protected bool itemEquipped;
    
    /// <summary>
    /// Indicates whether the item can be sold.
    /// </summary>
    protected bool itemSellable;
    
    /// <summary>
    /// Indicates whether the item can be traded.
    /// </summary>
    protected bool itemTradeable;
    
    /// <summary>
    /// Indicates whether the item is a quest item.
    /// </summary>
    protected bool itemQuestItem;
    
    /// <summary>
    /// Indicates whether the item is a key item.
    /// </summary>
    protected bool itemKeyItem;
    
    /// <summary>
    /// Indicates whether the item is unique.
    /// </summary>
    protected bool itemUnique;
    
    /// <summary>
    /// Indicates whether the item is soulbound.
    /// </summary>
    protected bool itemSoulbound;
    
    /// <summary>
    /// Indicates whether the item is bound on pickup.
    /// </summary>
    protected bool itemBindOnPickup;
    
    /// <summary>
    /// Indicates whether the item is bound on equip.
    /// </summary>
    protected bool itemBindOnEquip;
    
    /// <summary>
    /// Indicates whether the item is bound on use.
    /// </summary>
    protected bool itemBindOnUse;
    
    /// <summary>
    /// Indicates whether the item is bound on trade.
    /// </summary>
    protected bool itemBindOnTrade;
    
    /// <summary>
    /// Indicates whether the item is bound on craft.
    /// </summary>
    protected bool itemBindOnCraft;
    #endregion 
    protected void Update()
    {

    }
    /// <summary>
    /// OnMouseOver is called when the mouse is over the GUIElement or Collider.
    /// </summary>
    protected void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("You have selected " + itemName + ".");
        }
    }
    /// <summary>
    /// Soulbound the item if it meets the conditions.
    /// </summary>
    protected void Soulbound()
    {
        if (itemBindOnPickup)
        {
            itemSoulbound = true;
            return;
        }
        if (itemBindOnEquip)
        {
            itemSoulbound = true;
            return;
        }
        if (itemBindOnUse)
        {
            itemSoulbound = true;
            return;
        }
        if (itemBindOnTrade)
        {
            itemSoulbound = true;
            return;
        }
        if (itemBindOnCraft)
        {
            itemSoulbound = true;
            return;
        }
    }
    /// <summary>
    /// Destroys the item if it meets the conditions.
    /// </summary>
    protected void Destroy()
    {
        if (itemDurability <= 0)
        {
            Destroy(gameObject);
            return;
        }
        if (itemStack <= 0)
        {
            Destroy(gameObject);
            return;
        }
        if (itemConsumable)
        {
            if (itemStack <= 0)
            {
                Destroy(gameObject);
                return;
            }
        }
        if (itemQuestItem)
        {
            if (itemStack <= 0)
            {
                Destroy(gameObject);
                return;
            }
        }
        if (itemKeyItem)
        {
            if (itemStack <= 0)
            {
                Destroy(gameObject);
                return;
            }
        }
        if (itemUnique)
        {
            if (itemStack <= 0)
            {
                Destroy(gameObject);
                return;
            }
        }
        if (itemSoulbound)
        {
            if (itemStack <= 0)
            {
                Destroy(gameObject);
                return;
            }
        }
        if (itemBindOnPickup)
        {
            if (itemStack <= 0)
            {
                Destroy(gameObject);
                return;
            }
        }
        if (itemBindOnEquip)
        {
            if (itemStack <= 0)
            {
                Destroy(gameObject);
                return;
            }
        }
    }
    /// <summary>
    /// Checks the item for miscellaneous conditions.
    /// </summary>
    protected void MiscCheck()
    {
        if (itemRequiredLevel > 0)
        {
            if (itemRequiredLevel > playerLevel)
            {
                Debug.Log("You are not high enough level to use this item.");
            }
        }
        if (itemStackable)
        {
            if (itemStack > itemMaxStack)
            {
                itemStack = itemMaxStack;
            }
        }
        if (itemEquipable)
        {
            if (itemEquipped)
            {
                Debug.Log("Item is already equipped.");
            }
        }
        if (itemSellable)
        {
            if (itemValue <= 0)
            {
                Debug.Log("Item has no value.");
            }
        }
        if (itemTradeable)
        {
            if (itemSoulbound)
            {
                Debug.Log("Item is soulbound.");
            }
        }
    }
}
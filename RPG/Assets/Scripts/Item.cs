using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{   
    #region Item Properties
    /// <summary>
    /// To sort items in the inventory.
    /// </summary>
    public enum ItemType
    {
        Weapon,
        Armor,
        trinket,
        Consumable,
        Quest,
        Key,
        Currency,
    }
    public GameObject _itemDisplay;
    /// <summary>
    /// The item icon.
    /// </summary>
    public Sprite itemIcon;
    
    /// <summary>
    /// The item name.
    /// </summary>
    public string itemName;
    
    /// <summary>
    /// The item description.
    /// </summary>
    public string itemDescription;
    
    /// <summary>
    /// The unique identifier of the item.
    /// </summary>
    public int itemID;
    #endregion 
    #region Item Misc Properties
    /// <summary>
    /// The value of the item.
    /// </summary>
    public int itemValue;
    
    /// <summary>
    /// The required level to use the item.
    /// </summary>
    public int itemRequiredLevel;
    
    /// <summary>
    /// The rarity level of the item.
    /// </summary>
    public int itemRarity;
    
    /// <summary>
    /// The current stack size of the item.
    /// </summary>
    public int itemStack;
    
    /// <summary>
    /// The maximum stack size of the item.
    /// </summary>
    public int itemMaxStack;
    #endregion 
    #region Item Booleans
    private bool itemStackable;
    private bool itemConsumable;
    private bool itemEquipable;
    private bool itemEquipped;
    private bool itemSellable;
    private bool itemTradeable;
    private bool itemQuestItem;
    private bool itemKeyItem;
    private bool itemUnique;
    protected bool[] itemBools = new bool[9];

    /// <summary>
    /// Indicates whether the item can be stacked.
    /// </summary>
    public bool ItemStackable { get => itemStackable; }
    /// <summary>
    /// Indicates whether the item is consumable.
    /// </summary>
    public bool ItemConsumable { get => itemConsumable; }
    /// <summary>
    /// Indicates whether the item can be equipped.
    /// </summary>
    public bool ItemEquipable { get => itemEquipable; }
    /// <summary>
    /// Indicates whether the item is currently equipped.
    /// </summary>
    public bool ItemEquipped { get => itemEquipped; }
    /// <summary>
    /// Indicates whether the item can be sold.
    /// </summary>
    public bool ItemSellable { get => itemSellable; }
    /// <summary>
    /// Indicates whether the item can be traded.
    /// </summary>
    public bool ItemTradeable { get => itemTradeable; }
    /// <summary>
    /// Indicates whether the item is a quest item.
    /// </summary>
    public bool ItemQuestItem { get => itemQuestItem; }
    /// <summary>
    /// Indicates whether the item is a key item.
    /// </summary>
    public bool ItemKeyItem { get => itemKeyItem; }
    /// <summary>
    /// Indicates whether the item is unique.
    /// </summary>
    public bool ItemUnique { get => itemUnique; }
    /// <summary>
    /// An array of item booleans.
    /// </summary>
    public bool[] ItemBools { get => itemBools; set => itemBools = value; }

    public void Awake()
    {
        itemBools[0] = itemStackable;
        itemBools[1] = itemConsumable;
        itemBools[2] = itemEquipable;
        itemBools[3] = itemEquipped;
        itemBools[4] = itemSellable;
        itemBools[5] = itemTradeable;
        itemBools[6] = itemQuestItem;
        itemBools[7] = itemKeyItem;
        itemBools[8] = itemUnique;
    }
    #endregion
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
    /// Destroys the item if it meets the conditions.
    /// </summary>
    public void Destroy(GameObject _gameObject)
    {
        if (itemConsumable)
        {
            if (itemStack <= 0)
            {
                Destroy(_gameObject);
                return;
            }
        }
        if (itemQuestItem)
        {
            if (itemStack <= 0)
            {
                Destroy(_gameObject);
                return;
            }
        }
        if (itemKeyItem)
        {
            if (itemStack <= 0)
            {
                Destroy(_gameObject);
                return;
            }
        }
    }
    /// <summary>
    /// Checks the item for miscellaneous conditions.
    /// </summary>
    public void MiscCheck()
    {
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
    }
    public void ItemIconDisplay()
    {
        _itemDisplay.GetComponentInChildren<Image>().sprite = itemIcon;
        if (itemStackable)
        {
            _itemDisplay.transform.GetComponentInChildren<Text>().text = itemStack + " / " + itemMaxStack;
        }
        else
        {
            _itemDisplay.transform.GetComponentInChildren<Text>().text = " ";
        }
    }

    public void LevelCheck(int playerLevel)
    {
        if (itemRequiredLevel > 0)
        {
            if (itemRequiredLevel > playerLevel)
            {
                itemEquipable = false;
            }
            else
            {
                itemEquipable = true;
            }
        }
    }
}
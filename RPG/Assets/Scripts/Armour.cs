using UnityEngine;

public class Armour : Item
{
    Item item = new Item();

#region Armour Properties
    /// <summary>
    /// The armour type.
    /// </summary>
    protected enum ArmourType
    {
        Cloth,
        Leather,
        Mail,
        Plate,
        Shield
    }

    /// <summary>
    /// The armour piece.
    /// </summary>
    protected enum ArmourPiece
    {
        Helmet,
        Shoulders,
        Chest,
        Gloves,
        Belt,
        Legs,
        Boots
    }
    #region Item Mana Properties
        /// <summary>
        /// The amount of mana received from the item.
        /// </summary>
        protected int itemMana;

        /// <summary>
        /// The rate at which mana regenerates over time.
        /// </summary>
        protected int itemManaRegen;
    #endregion 
    #region Item Armor Properties
        /// <summary>
        /// The amount of armor provided by the item.
        /// </summary>
        protected int itemArmor;

        /// <summary>
        /// The amount of magic resistance provided by the item.
        /// </summary>
        protected int itemMagicResist;

        /// <summary>
        /// The chance of dodging an incoming attack with the item equipped.
        /// </summary>
        protected int itemDodge;

        /// <summary>
        /// The chance of blocking an incoming attack with the item equipped.
        /// </summary>
        protected int itemBlock;

        /// <summary>
        /// The speed bonus provided by the item.
        /// </summary>
        protected int itemSpeed;
    #endregion
    #region Item Stats Properties
        /// <summary>
        /// The strength bonus provided by the item.
        /// </summary>
        protected int itemStrength;
        
        /// <summary>
        /// The agility bonus provided by the item.
        /// </summary>
        protected int itemAgility;
        
        /// <summary>
        /// The intellect bonus provided by the item.
        /// </summary>
        protected int itemIntellect;
        
        /// <summary>
        /// The stamina bonus provided by the item.
        /// </summary>
        protected int itemStamina;
    #endregion
#endregion
}
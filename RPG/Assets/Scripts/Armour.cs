using UnityEngine;

public class Armour : Item
{

#region Armour Properties
    /// <summary>
    /// The armour type.
    /// </summary>
    protected enum ArmourType
    {
        Cloth,
        Leather,
        Mail,
        Plate
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
        /// The amount of damage blocked by the item.
        /// </summary>
        protected int itemBlockAmount;

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

    #region Combat Item Properties
            #region Item Rock Properties
                protected bool itemRock;
                protected int itemRockDefense;
                protected int itemRockBlockChance;
                protected int itemRockBlockAmount;
                protected int itemRockDodgeChance;
            #endregion
            #region Item Paper Properties
                protected bool itemPaper;
                protected int itemPaperDefense;
                protected int itemPaperBlockChance;
                protected int itemPaperBlockAmount;
                protected int itemPaperDodgeChance;
            #endregion
            #region Item Scissors Properties
                protected bool itemScissors;
                protected int itemScissorsDefense;
                protected int itemScissorsBlockChance;
                protected int itemScissorsBlockAmount;
                protected int itemScissorsDodgeChance;
            #endregion
        #endregion
#endregion
}
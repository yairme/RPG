using UnityEngine;

public class Weapons : Item
{
    Item item = new Item();

    #region Weapon Properties
    /// <summary>
    /// The weapon type.
    /// </summary>
    protected enum WeaponType
    {
        Sword,
        Axe,
        Bow,
        Staff,
        Wand,
        Dagger,
        Mace,
        Spear,
        Shield,
        Gun,
        Crossbow,
        Throwing,
        Polearm,
        Fist,
        Claws,
        Whip,
        Scythe,
        Sickle,
        Flail,
        Chain,
        Gauntlet,
        Greatsword,
        Greataxe,
        Greatbow,
        Greatmace,
        Greatspear,
        Greatshield,
    }

    /// <summary>
    /// The weapon damage.
    /// </summary>
    protected int weaponDamage;
        #region Item Damage Properties
        /// <summary>
        /// The amount of damage inflicted by the item.
        /// </summary>
        protected int itemDamage;

        /// <summary>
        /// The chance of landing a critical hit with the item.
        /// </summary>
        protected int itemCritChance;

        /// <summary>
        /// The additional damage inflicted by a critical hit with the item.
        /// </summary>
        protected int itemCritDamage;
        #endregion 
        #region Combat Item Properties
            #region Item Rock Properties
            protected bool itemRock;
            protected int itemRockDamage;
            protected int itemRockCritChance;
            protected int itemRockCritDamage;
            #endregion
            #region Item Paper Properties
            protected bool itemPaper;
            protected int itemPaperDamage;
            protected int itemPaperCritChance;
            protected int itemPaperCritDamage;
            #endregion
            #region Item Scissors Properties
            protected bool itemScissors;
            protected int itemScissorsDamage;
            protected int itemScissorsCritChance;
            protected int itemScissorsCritDamage;
        #endregion
    #endregion
    #endregion
}
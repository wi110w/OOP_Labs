namespace Lab_4
{
    using System;
    
    public interface IResurrectable
    {
        int Age
        { get; set; }

        bool Old
        { get; }

        Phoenix Resurrect();
        int GetOlder();
    }

    public interface IDragon
    {
        void Fire();

        void Eat(Creature thing);

        string Type 
        { get; set; }
    }

    public interface IFlyable
    {
        void ShowFace();
    }

    public interface ITransformable
    {
        void Transform();

        void UnTransform();
    }

    public interface IPoisonable
    {
        void Poison(Creature thing);
    }

    public interface IEnchantable
    {
        void Enchant(Creature thing);
    }

    public interface IMonster
    {
        string Spell
        { get; set; }

        void Eat();

        void Scare();
    }

    public interface ICreature
    {
        uint Health
        { get; set; }

        uint Mana
        { get; set; }

        string Name
        { get; set; }

        uint Damage
        { get; set; }

        bool IsDisposed
        { get; set; }

        void Say();
    }

    public interface ICreature<T>
    {
        void Fight(T thing);
    }
}

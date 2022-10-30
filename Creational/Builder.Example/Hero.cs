using System;
using System.Text;

namespace Jarai.Patterns.Creational.Builder
{
    public partial class Hero
    {
        public Profession? Profession { get; }
        public string Name { get; }
        public HairType? HairType { get; }
        public HairColor? HairColor { get; }
        public Armor? Armor { get; }
        public Weapon? Weapon { get; }

        public Hero(Builder builder)
        {
            Profession = builder.Profession;
            Name = builder.Name;
            HairColor = builder.HairColor;
            HairType = builder.HairType;
            Weapon = builder.Weapon;
            Armor = builder.Armor;
        }

      

        public override String ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("This is a ")
                .Append(Profession)
                .Append(" named ")
                .Append(Name);

            if (HairColor != null || HairType != null)
            {
                sb.Append(" with ");
                if (HairColor != null)
                {
                    sb.Append(HairColor).Append(' ');
                }
                if (HairType != null)
                {
                    sb.Append(HairType).Append(' ');
                }
                sb.Append((HairType != Creational.Builder.HairType.Bald) ? "hair" : "head");
            }
            if (Armor != null)
            {
                sb.Append(" wearing ").Append(Armor);
            }
            if (Weapon != null)
            {
                sb.Append(" and wielding a ").Append(Weapon);
            }
            sb.Append('.');

            return sb.ToString();
        }


        public class Builder
        {
            public Profession Profession;
            public String Name;
            public HairType HairType;
            public HairColor HairColor;
            public Armor Armor;
            public Weapon Weapon;

            public Builder(Profession? profession, String name)
            {
                if (profession == null || name == null)
                {
                    throw new ArgumentException("profession and name can not be null");
                }
                Profession = profession.Value;
                Name = name;
            }

            public Builder WithHairType(HairType hairType)
            {
                HairType = hairType;
                return this;
            }

            public Builder WithHairColor(HairColor hairColor)
            {
                HairColor = hairColor;
                return this;
            }

            public Builder WithArmor(Armor armor)
            {
                Armor = armor;
                return this;
            }

            public Builder WithWeapon(Weapon weapon)
            {
                Weapon = weapon;
                return this;
            }

            public Hero Build()
            {
                return new Hero(this);
            }
        }
    }
}

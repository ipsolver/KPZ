﻿using pr2.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task5.Classes
{
    public class HeroBuilder : ICharacterBuilder
    {

        private Character _character = new Character();
        public List<string> GoodMoves { get; set; } = new List<string>();

        public HeroBuilder()
        {
            _character = new Character();
        }
        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }
        public ICharacterBuilder SetHeight(int height)
        {
            _character.Height = height;
            return this;
        }
        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }
        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }
        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }
        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }
        public ICharacterBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }
        public ICharacterBuilder AddMove(string move)
        {
            GoodMoves.Add(move);
            return this;
        }
        public ICharacter Build()
        {
            return _character;
        }
    }
}

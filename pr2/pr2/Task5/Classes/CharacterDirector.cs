using pr2.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task5.Classes
{
    public class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public ICharacter CreateHero(ICharacterBuilder builder)
        {
            return builder.SetName("Mark")
                          .SetHeight(180)
                          .SetBuild("Спортивний")
                          .SetHairColor("Чорне")
                          .SetEyeColor("Блакитні")
                          .SetClothing("Костюм")
                          .AddInventoryItem("Пістоль")
                          .AddInventoryItem("Кинджал")
                          .AddInventoryItem("Зілля здоров'я")
                          .AddMove("Врятував дівчаток")
                          .Build();
        }

        public ICharacter CreateEnemy(ICharacterBuilder builder)
        {
            return builder.SetName("Alex")
                          .SetHeight(190)
                          .SetBuild("Спортивний")
                          .SetHairColor("Чорне")
                          .SetEyeColor("Карі")
                          .SetClothing("Плащ")
                          .AddInventoryItem("Магічний посох")
                          .AddMove("Знищив місто")
                          .Build();
        }
    }
}

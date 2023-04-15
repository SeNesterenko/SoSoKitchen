using UnityEngine;

namespace Serving.Handlers
{
    public class PlateHandler : IIngredientHandler
    {
        public bool IsCooking = false;
        
        public Ingredient GetIngredient()
        {
            //если не собрано
            return null;
            
            //возвращаем готовую еду
        }

        public void Initialize(Ingredient ingredient)
        {
            //TO DO
            // ЗАПУСК СБОРКИ БЛЮДА
        }
    }
}


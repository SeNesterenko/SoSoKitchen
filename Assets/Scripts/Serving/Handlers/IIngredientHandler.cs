namespace Serving
{
    public interface IIngredientHandler
    {
        public Ingredient GetIngredient();
        public void Initialize(Ingredient ingredient);
    }
}



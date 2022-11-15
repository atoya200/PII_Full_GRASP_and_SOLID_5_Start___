
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        /// <summary>
        /// Como en realidad quien tenía la dependencia con Recipe era esta interfaz de la cual dependía Console Printer, 
        /// la dependencía "indeseada", es la que se mantenía entre esta abstracción y la clase concreta. Por ende, lo que
        /// se hizo, fue cambiarla para que dependiera de otra abstracción, IRecipeContent
        /// </summary>
        /// <param name="recipe"></param>
         void PrintRecipe(IRecipeContent recipe);
    }
}
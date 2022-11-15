using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Ahora la clase Console Pinter como depende de la interfaz IPrinter y esta ahora depende
        /// de IRecipeContent, dejo de depender de una clase concreta, cumpliendo así con DIP.
        /// </summary>
        /// <param name="recipe"></param>
        public void PrintRecipe(IRecipeContent recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
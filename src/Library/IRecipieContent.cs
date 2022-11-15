namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Se crea una interfaz para hacer que la clase Recipie dependa de ella y la clase Console Printer también
    /// </summary>
    public interface IRecipeContent
    {
        public string GetTextToPrint();
    }
}
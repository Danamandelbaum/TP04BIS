public static class Info
{
    private static List<Pais> listaPaises = new List<Pais>();

    private static void inicializarLista()
    {
        Pais unPais = new Pais("Argentina", "argentina.png", 45000000, new DateTime(1816,7,9), "Cataratas");
        listaPaises.Add(unPais);
        unPais = new Pais("Brasil", "Brasil.png", 145000000, new DateTime(1816,7,10), "Amazonas");
        listaPaises.Add(unPais);
        unPais = new Pais("Chile", "Chile.png", 25000000, new DateTime(1816,8,9), "Pucon");
        listaPaises.Add(unPais);
        unPais = new Pais("Uruguay", "Uruguay.png", 50000000, new DateTime(1816,10,9), "Punta del Este");
        listaPaises.Add(unPais);
        unPais = new Pais("Mexico", "Mexico.png", 350000000, new DateTime(1819,7,9), "Cancun");
        listaPaises.Add(unPais);
    }
    public static List<Pais> listarPaises()
    {
        if (listaPaises.Count == 0)
        {
            inicializarLista();
        }
        return listaPaises;
    }
    public static Pais DetallePais(string nombre)
    {
        Pais paisBuscado = new Pais();
        foreach (Pais item in listaPaises)
        {
            if (item.nombre == nombre)
            {
                return item;
            }
        }
        return paisBuscado;
    }
}
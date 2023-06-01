public static class Info{
    private static List<Pais> ListaPaises = new List<Pais>();

    private static void InicializarLista(){
        Pais unPais = new Pais("Argentina", "Arg.png", 45000000, new DateTime(1816,7,9), "Cataratas");
        ListaPaises.Add(unPais);
        unPais = new Pais("Brasil", "Brasil.png", 14000000, new DateTime(1820,7,9), "Amazonas");
        ListaPaises.Add(unPais);
        unPais = new Pais("Chile", "chile.png", 15000000, new DateTime(1820,7,9), "Santiago");
        ListaPaises.Add(unPais);
        unPais = new Pais("Uruguay", "uruguay.png", 13000000, new DateTime(1820,7,9), "Rio");
        ListaPaises.Add(unPais);
        unPais = new Pais("Paraguay", "paraguay.png", 12000000, new DateTime(1820,7,9), "Cancun");
        ListaPaises.Add(unPais);
    }
    public static List<Pais> ListarPaises(){
        if (ListaPaises.Count==0)
        {
            InicializarLista();
        }
        return ListaPaises;
    }
    public static Pais DetallePais(string Nombre){
        Pais PaisBuscado = new Pais();
        foreach(Pais item in ListaPaises){
            if (item.Nombre == Nombre){
                return item;
            }
        }
        return PaisBuscado;
    }
}
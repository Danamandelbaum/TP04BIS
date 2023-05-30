public class Pais
{
    public string nombre {get; private set;}
    public string imgBandera {get; private set;}
    public int poblacion {get; private set;}
    public DateTime fechaIndependencia {get; private set;}
    public string atractivosTuristicos {get; private set;}

    public Pais()
    {

    }
    
    public Pais (string nom, string imgban, int pob, DateTime fechaInd, string atTur)
    {
        nombre = nom;
        imgBandera = imgban;
        poblacion = pob;
        fechaIndependencia = fechaInd;
        atractivosTuristicos = atTur;
    }
}
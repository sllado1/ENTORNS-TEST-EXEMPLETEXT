public class Campanyes
{
    /// <summary>
    /// NA: Retorna el nombre de campanyes que s'han fet. El nombre de campanyes és un nombre enter entre 1 i 10000.
    /// </summary>
    /// <param name="n"></param>
    /// <returns> El nombre de campanyes o bé -1 si el nombre de campanyes és incorrecte</returns>
    public int NumCampanyes(int n)
    {
        if (n >= 0 && n<= 10000)
        {
            return n;
        }
        else
        {
            return -1;
        }        
        
    }

    /// <summary>
    /// Retorna el num de ocells anellats a la campanya
    /// </summary>
    /// <param name="valorsCampanya">Informació de la campanya</param>
    /// <returns> -1 L'entrada de la campanya és incorrecte, -2 el número de capturats és incorrecte, -3 els número de ja anellats és incorrecte </returns>
    public int NumAnellamentsCampanya(String valorsCampanya)
    {
        int numCapturats;
        int numJaAnellats;
        //Separem els valors de la campanya
        String[] valors = valorsCampanya.Split(' ');
        
        if (valors.Length == 2)
        {
            // Si hi ha dos valors, està correcte
            //Comprovem els dos valors 
            numCapturats = int.Parse(valors[0]);
            if (numCapturats < 0 || numCapturats > 10000)
            {
                //El valor del número de capturats és incorrecte
                return -2;
            }
            numJaAnellats = int.Parse(valors[1]);
            if (numJaAnellats < 0 || numJaAnellats > 10000 || numJaAnellats > numCapturats)
            {
                //El valor del número de ja anellats és incorrecte
                return -3;
            }
            return numCapturats-numJaAnellats;
        }
        else
        {
            return -1;
        }
        
      
    }
}
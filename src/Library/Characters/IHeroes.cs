namespace RoleplayGame
{

/* Interfaz Enemigos, donde tiene los puntos de valor de victoria. Lo puntos se pueden setear en el caso de los heroes.
Esto nos permite realizar operaciones polimorficas 
*/
    public interface IHeroes
    {
        int VictoryPoints { get; set; }
    
    }
}
namespace RoleplayGame
{

/* Interfaz Enemigos, donde tiene los puntos de valor de victoria. Solo get ya que los enemigos no acumulan puntos de victoria
Esto nos permite realizar operaciones polimorficas 
*/

    public interface IEnemies
    {
        int VictoryPoints { get; }
    }
}
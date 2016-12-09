/**
 * Created by Oleksandr_Breslavets on 11/25/2016.
 * For all toys that could shoot
 */
namespace OOPInCSharp.task2.interfaces
{
    public interface IShootable
    {
        /// <summary>
        /// to set up new projectiles
        /// </summary>
        void Reload();

        /// <summary>
        /// to make a shoot
        /// </summary>
        void Shoot();

    }
}

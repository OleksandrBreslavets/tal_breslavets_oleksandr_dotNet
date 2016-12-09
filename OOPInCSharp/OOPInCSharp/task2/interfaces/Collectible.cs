/**
 * Created by Oleksandr_Breslavets on 11/25/2016.
 * For all toys that could be assembled and disassembled
 */
namespace OOPInCSharp.task2.interfaces
{
    public interface ICollectible
    {
        /// <summary>
        /// to collect a toy
        /// </summary>
        void Collect();

        /// <summary>
        /// to recollect a toy into peaces
        /// </summary>
        void Recollect();
    }
}

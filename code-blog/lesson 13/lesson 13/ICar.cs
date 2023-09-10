namespace Lesson_13
{
    internal interface ICar : IObject
    {
        /// <summary>
        /// Выполнить перемещение.
        /// </summary>
        /// <param name="distnace"> Расстояние. </param>
        /// <returns> Время движения. </returns>
        int Move(int distnace);
    }
}

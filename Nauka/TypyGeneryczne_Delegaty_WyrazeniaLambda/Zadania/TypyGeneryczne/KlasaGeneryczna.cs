using System;

namespace TypyGeneryczne
{
    public class KlasaGeneryczna<T>
    {
        private T pole;
        public T wlasciwosc { get; set; }
        public KlasaGeneryczna(T p1) => pole = p1;

        public void generycznaMetoda(T argument) => Console.WriteLine($"{typeof(T).Name,8}{argument,12}" +
                                                                      $"{pole,10}{wlasciwosc,12}");
    }
}
using System;
using System.Linq;
using Models.Person;
using Interface.IHasPersonInfo;
namespace Queries.Filter;

public class Statistics
{
      public double AverageAge<K>(List<K> list) where K : IHasPersonInfo

            => list.Average(s => s.Age);
      public int MinAge<K>(List<K> list) where K : IHasPersonInfo

            => list.Min(s => s.Age);
      public int MaxAge<K>(List<K> list) where K : IHasPersonInfo

            => list.Max(s => s.Age);
      public int CountAllPersons<K>(List<K> list) where K : IHasPersonInfo

            => list.Count();

}

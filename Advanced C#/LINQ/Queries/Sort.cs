using System;
using System.Linq;
using Interface.IHasPersonInfo;
using Models.Person;

namespace Queries.Sort;

public class Sort
{
    public List<T> ByAgeAccending<T>(List<T> list) where T : IHasPersonInfo =>
         list.OrderBy(s => s.Age).ToList<T>();

    public List<K> ByAgeDecending<K>(List<K> list) where K : IHasPersonInfo

        => list.OrderByDescending(s => s.Age)
        .ToList();
    public List<T> ByNameAccending<T>(List<T> list) where T : IHasPersonInfo =>
         list.OrderBy(s => s.Name).ToList<T>();


    public List<K> ByNameDecending<K>(List<K> list) where K : IHasPersonInfo

        => list.OrderByDescending(s => s.Name)
        .ToList();
}
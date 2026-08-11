using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Interface.IHasPersonInfo;

namespace Queries.Filter;

public class Filter
{
    public List<T> GetAdults<T>(List<T> list)
        where T : IHasPersonInfo =>
        list.Where(p => p.Age >= 18).ToList();

    public List<T> GetByAgeRange<T>(List<T> list, int minAge, int maxAge)
        where T : IHasPersonInfo =>
        list.Where(p => p.Age >= minAge && p.Age <= maxAge).ToList();

    public List<T> GetByNamePattern<T>(List<T> list, string pattern)
        where T : IHasPersonInfo =>
        list.Where(p => Regex.IsMatch(p.Name, pattern)).ToList();

    public List<T> GetByNameStartsWith<T>(List<T> list, string prefix)
        where T : IHasPersonInfo =>
        list.Where(p => p.Name.StartsWith(prefix)).ToList();

    public List<T> GetByNameContains<T>(List<T> list, string text)
        where T : IHasPersonInfo =>
        list.Where(p => p.Name.Contains(text)).ToList();

    public List<T> DelByID<T>(List<T> list, string? text)
        where T : IHasPersonInfo
    {
        var del = list.FirstOrDefault(p => p.Name == text);
        if (del != null)
            list.Remove(del);
        return list;
    }
    public List<T> UpdateByID<T>(List<T> list, string? text)
        where T : IHasPersonInfo
    {
        var del = list.FirstOrDefault(p => p.Name == text);
        if (del != null)
            list.Remove(del);
        return list;
    }
}
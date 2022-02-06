using DisabilityServiceTools.Shared.Models;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace DisabilityServiceTools.Server.Repositories.RepositoryExtensions
{
  public static class RepositoryExamExtensions
  {
    public static IQueryable<Exam> Search(this IQueryable<Exam> products, string searchTearm)
    {
      if (string.IsNullOrWhiteSpace(searchTearm))
        return products;

      var lowerCaseSearchTerm = searchTearm.Trim().ToLower();

      return products.Where(p => p.Id.ToString().ToLower().Contains(lowerCaseSearchTerm));
    }

    public static IQueryable<Exam> Sort(this IQueryable<Exam> products, string orderByQueryString)
    {
      if (string.IsNullOrWhiteSpace(orderByQueryString))
        return products.OrderBy(e => e.Id.ToString());

      var orderParams = orderByQueryString.Trim().Split(',');
      var propertyInfos = typeof(Exam).GetProperties(BindingFlags.Public | BindingFlags.Instance);
      var orderQueryBuilder = new StringBuilder();

      foreach (var param in orderParams)
      {
        if (string.IsNullOrWhiteSpace(param))
          continue;

        var propertyFromQueryName = param.Split(" ")[0];
        var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

        if (objectProperty == null)
          continue;

        var direction = param.EndsWith(" desc") ? "descending" : "ascending";
        orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
      }

      var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
      if (string.IsNullOrWhiteSpace(orderQuery))
        return products.OrderBy(e => e.Id.ToString());

      return products.OrderBy(orderQuery);
    }
  }
}
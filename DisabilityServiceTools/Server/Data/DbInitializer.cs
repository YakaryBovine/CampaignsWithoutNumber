using DisabilityServiceTools.Shared.Models;
using System;
using System.Linq;

namespace DisabilityServiceTools.Server.Data
{
  public static class DbInitializer
  {
    private static readonly Random random = new Random();

    public static void Initialize(DisabilityServiceDBContext context)
    {
      context.Database.EnsureCreated();

      //Students
      if (!context.Student.Any())
      {
        for (int i = 0; i < 1000; i++)
        {
          context.Student.Add(new Student { FirstName = Faker.Name.First(), Surname = Faker.Name.Last(), StudentId = Faker.RandomNumber.Next(999999999) });
        }
      }

      //Course
      if (!context.Course.Any())
      {
        for (int i = 0; i < 100; i++)
        {
          context.Course.Add(new Course { Code = RandomString(4) + RandomNumericalString(3) });
        }
      }

      context.SaveChanges();
    }

    public static string RandomString(int length)
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static string RandomNumericalString(int length)
    {
      const string chars = "0123456789";
      return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   class Human
{
  enum Gender { male, female };

  class Person
  {
    public Gender gender { get; set; }
    public string name { get; set; }
    public int age { get; set; }
  }
  public void Create_Person(int age)
  {
      Person new_Person = new Person();
      new_Person.age = age;
      if (age % 2 == 0)
      {
          new_Person.name = "Guy";
          new_Person.gender = Gender.male;
      }
      else
      {
          new_Person.name = "Girl";
          new_Person.gender = Gender.female;
      }
  }
}

}

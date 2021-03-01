using backend.Models;
using System.Linq;
using System.Collections.Generic;
 
public class BackendRepository
{
public BackendRepository()
{
 
}
public int AddValue(TestValue newValue)
{
int itemIndex;
using (BackendDbContext context = new BackendDbContext())
{
context.TestValues.Add(newValue);
context.SaveChanges();
itemIndex = context.TestValues.ToList().IndexOf(newValue);
}
return itemIndex;
}

public List<TestValue> GetAllValues()
{
using (BackendDbContext context = new BackendDbContext())
{
return context.TestValues.ToList();
}
}


public int UpdateValue(int index, TestValue valueToUpdate)
{
using (BackendDbContext context = new BackendDbContext())
{
var updatingValue = context.TestValues.Where(item => item.TestValueId == index).FirstOrDefault();
updatingValue.TestValueValue = valueToUpdate.TestValueValue;
updatingValue.TestValueDate = valueToUpdate.TestValueDate;
context.SaveChanges();
return index;
}
}


public bool DeleteValue(int index)
{
using (var context = new BackendDbContext())
{
var valueToRemove = context.TestValues.ToList()[index];
context.TestValues.Remove(valueToRemove);
context.SaveChanges();
return true;
}
}

}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Apptest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        public T EnCoding<T>(T entity)
        {
            var type = typeof(T);
            foreach (var item in type.GetProperties())
            {
                //通过反射出来值，然后加密后，再重新赋值。
               item.SetValue(entity, Encoding(item.GetValue(entity).ToString()));
            }
            return entity;
        }
        public string Encoding(string str)
        {
            return null;
        }
    }
}

using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wpf;
using Wpf.binding;
using Wpf._4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ObservableCollection<StudentEntity> studentCollection = StudentsCollection.GetStudents();
        }
    }
}

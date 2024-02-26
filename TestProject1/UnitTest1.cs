using JenkinsDemo;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            TestMe testMe = new TestMe();
            string obj1 = testMe.sayJenkins(1);
            Assert.AreEqual("jenkins",obj1);
        }

        [Test]
        public void Test2()
        {
            TestMe testMe = new TestMe();
            string obj2 = testMe.sayJenkins(2);
            Assert.AreEqual("jenkinsjenkins", obj2);
        }
    }
}
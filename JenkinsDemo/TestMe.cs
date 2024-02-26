namespace JenkinsDemo
{
    public class TestMe
    {
        public string sayJenkins(int items)
        {
            string name = "";
            for(int i = 0; i < items; i++)
            {
                name += "jenkins";
            }
            return name;
        }
    }
}

namespace LambdaLinq
{
    public class Group
    {
        public Group(int num, string dep)
        {
            this.GroupNumber = num;
            this.DepartmentName = dep;
        }
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}

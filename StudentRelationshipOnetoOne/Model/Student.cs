namespace StudentRelationshipOnetoOne.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual StudentAddress Address { get; set; }
    }
}

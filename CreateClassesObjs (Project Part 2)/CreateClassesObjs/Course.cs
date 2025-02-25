namespace CreateClassesObjs
{
    public class Course //create public class called Course
    {
        private string courseName; //create private string field

        //create public method to set the value of the private field
        public void setName(string name)
        {
            this.courseName = name; //set the value of the private field
        }

        public string getName()
        {
            return this.courseName; //return the value of the private field
        }

        public override string ToString()
        {
            return this.courseName; //control what is displayed in the combo box
        }
    }
}

namespace Model.Entites
{
    public class Admin : User
    {
        public Admin(string firstName, string secondName, string middleName, string phone) 
            : base(firstName, secondName, middleName, phone)
        {
        }

        public Admin(){}
    }
}

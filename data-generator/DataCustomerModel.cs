namespace data_generator
{
    public class DataCustomerModel
    {
        private Guid _id;
        private string _name;
        private string _email;
        public DataCustomerModel(Guid id, string name, string email)
        {
            this._id = id;
            this._name = name;
            this._email = email;
        }
        public Guid Id { get { return this._id; } private set { value = this._id; } }
        public string Name { get { return this._name; } private set { value = this._name; } }
        public string Email { get { return this._email; } private set { value = this._email; } }
    }
}

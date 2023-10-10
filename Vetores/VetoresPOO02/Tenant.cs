namespace VetPoo2 {
    class Tenant {

        public string Name { get; set; }
        public string Email { get; set; }

        public Tenant (string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return ($"{Name}, {Email}");
        }
    }
}
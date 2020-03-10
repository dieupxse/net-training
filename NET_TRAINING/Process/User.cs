using System;

namespace NET_TRAINING.Process {
    public class User {
        private string _name;
        //constructor
        public User()
        {
            Console.WriteLine("Init User object");
        }
         public User(string name) {
            _name = name;   
         }
         public User(string name, string mobile, string email, string address) {
             _name = name;
             Mobile = mobile;
             Email = email;
             Address = address;
         }


        private string IsStudent {get;set;}
        public string Name { 
            get {
                return !string.IsNullOrEmpty(_name) ? _name : "AN";
            }
            set {
                if(string.IsNullOrEmpty(_name)) {
                    _name = "AN";
                } else {
                    _name = value;
                }
            }
        }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void Display() {
            Console.WriteLine($"Value of User is {Name} {Mobile} {Email} {Address}");
        }
    }
}
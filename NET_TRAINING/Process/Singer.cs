using System;

namespace NET_TRAINING.Process {
    public class Singer {
        public Singer (string name) {
            Name = name;
        }
        public Singer (string name, int age) {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Display () {
            Console.WriteLine ($"Ca sỹ: {Name} - Tuổi: {Age}");
        }
    }
}
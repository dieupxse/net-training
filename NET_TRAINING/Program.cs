using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NET_TRAINING.Process;

namespace NET_TRAINING {
    class Program {
        static void Main (string[] args) {
            Excercise ();
        }
        private static void Excercise () {
            var singers = Singers ();
            var listSingers = GenerateListSinger (singers);
            DisplayListSinger (listSingers);
        }

        private static int getRandomNumber (int min, int max) {
            Random r = new Random ();
            int rInt = r.Next (min, max); //for ints
            return rInt;
        }

        public static void DisplayListSinger (List<Singer> singers) {
            Console.WriteLine ("Danh sách ca sỹ");
            if (singers == null) {
                Console.WriteLine ("Không có ca sỹ nào");
                return;
            }
            foreach (var singer in singers) {
                singer.Display ();
            }
        }

        public static string GetRandomSinger (string[] singers) {
            return singers[getRandomNumber (0, singers.Length - 1)];
        }

        private static List<Singer> GenerateListSinger (string[] singers) {
            List<Singer> listSingers = new List<Singer> ();
            int count = 0;
            while (count <= 15) {
                var singer = GetRandomSinger (singers);
                if (!listSingers.Any (e => e.Name == singer)) {
                    listSingers.Add (new Singer (singer, getRandomNumber (20, 50)));
                    count++;
                } else { }
                // Thread.Sleep (3000);
            }
            return listSingers;
        }
        private static string[] Singers () {
            string[] singers = new string[] {
                "Mỹ Tâm",
                "Đàm Vĩnh Hưng",
                "Tuấn Hưng",
                "Khắc Việt",
                "Phan Đình Tùng",
                "Noo Phước Thịnh",
                "Hòa Minzy",
                "Erik",
                "Akira Phan",
                "Đức Phúc",
                "Đen Vâu",
                "Hà Anh Tuấn",
                "Bằng Kiều",
                "Quang Dũng",
                "Lệ Quyên",
                "Ông Cao Thắng",
                "Trịnh Thăng Bình",
                "Đông Nhi",
                "Phương Trinh",
                "Quang Hào",
                "Hiền Hồ",
                "Đại Nhân",
                "Trúc Nhân",
                "Sơn Tùng MTP",
                "Ngô Kiến Huy",
                "Phạm Quỳnh Anh",
                "Trương Quỳnh Anh",
                "Phạm Khánh Hưng",
                "Mỹ Linh",
                "Cẩm Ly",
                "Cẩm Lệ",
                "Hồng Ngọc",
                "Issac",
                "Lou Hoang",
                "Tóc Tiên"
            };
            return singers;
        }

        private static List<Singer> SearchSingerByKeyword (List<Singer> singers, string keyword) {
            keyword += "";
            return singers.Where (e => e.Name.Contains (keyword)).ToList ();
        }

        private static List<Singer> SearchSingerByMinAge (List<Singer> singers, int minAge) {
            return singers.Where (e => e.Age >= minAge).ToList ();
        }

        public static List<Singer> SearchSingerByKeywordAndMaxAge (List<Singer> singers, string keyword, int maxAge) {
            return singers.Where (e => e.Name.Contains (keyword) && e.Age <= maxAge).ToList ();
        }
    }
}
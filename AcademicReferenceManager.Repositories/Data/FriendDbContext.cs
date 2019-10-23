using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;

namespace AcademicReferenceManager.Repositories.Data {
    public class FriendDbContext : IFriendDbContext {
        private readonly List<Friend> _friends =
            new List<Friend> {

                new Friend 
                {
                Id = 1,
                FirstName = "Con",
                LastName = "Cochet",
                Email = "ccochet0@huffingtonpost.com",
                Phone = "104 315 1584",
                Address = "142 Washington Street"
                },

                new Friend 
                {
                Id = 2,
                FirstName = "Gunther",
                LastName = "Grime",
                Email = "ggrime1@google.cn",
                Phone = "612 446 8419",
                Address = "42 Ronald Regan Drive"
                },

                new Friend 
                {
                Id = 3,
                FirstName = "Jenna",
                LastName = "McCooke",
                Email = "jmccooke2@pinterest.com",
                Phone = "696 766 1210",
                Address = "9 Utah Park"
                },

                new Friend 
                {
                Id = 4,
                FirstName = "Jule",
                LastName = "Francesconi",
                Email = "jfrancesconi3@nature.com",
                Phone = "272 845 2775",
                Address = "05646 Vera Court"
                },

                new Friend 
                {
                Id = 5,
                FirstName = "Buddie",
                LastName = "Bereford",
                Email = "bbereford4@elpais.com",
                Phone = "577 692 5110",
                Address = "09647 West Trail"
                },

                new Friend 
                {
                Id = 6,
                FirstName = "Mufinella",
                LastName = "Ugoletti",
                Email = "mugoletti5@biblegateway.com",
                Phone = "865 102 3840",
                Address = "00113 Waywood Place"
                },

                new Friend 
                {
                Id = 7,
                FirstName = null,
                LastName = "Georgeau",
                Email = "cgeorgeau6@qq.com",
                Phone = "377 887 8025",
                Address = "7799 Comanche Place"
                },

                new Friend 
                {
                Id = 8,
                FirstName = "Kim",
                LastName = "Deschlein",
                Email = "kdeschlein7@pinterest.com",
                Phone = "217 685 7190",
                Address = "7 Erie Court"
                },

                new Friend 
                {
                Id = 9,
                FirstName = "Gabbi",
                LastName = "Krates",
                Email = "gkrates8@meetup.com",
                Phone = "763 987 8826",
                Address = "7 Kim Road"
                },

                new Friend 
                {
                Id = 10, FirstName = "Katharyn",
                LastName = "Corse",
                Email = "kcorse9@ted.com",
                Phone = "988 582 4873",
                Address = "25 Dryden Drive"
                },

                new Friend 
                {
                Id = 11, FirstName = "Kessiah",
                LastName = "Figgs",
                Email = null,
                Phone = "591 985 8121",
                Address = "42 1st Lane"
                },

                new Friend 
                {
                Id = 12, FirstName = "Andeee",
                LastName = "Proudler",
                Email = "aproudlerb@dedecms.com",
                Phone = "171 388 1294",
                Address = "8179 Basil Terrace"
                },

                new Friend 
                {
                Id = 13, FirstName = "Booth",
                LastName = "Basnett",
                Email = "bbasnettc@bandcamp.com",
                Phone = "890 219 5074",
                Address = "98225 Pine View Court"
                },

                new Friend 
                {
                Id = 14, FirstName = "Margalo",
                LastName = "Murley",
                Email = "mmurleyd@oakley.com",
                Phone = "129 711 4654",
                Address = "1 Clove Avenue"
                },

                new Friend 
                {
                Id = 15, FirstName = "Lea",
                LastName = "McAlroy",
                Email = "lmcalroye@bandcamp.com",
                Phone = "776 785 3353",
                Address = "3 Hovde Trail"
                },

                new Friend 
                {
                Id = 16, FirstName = "Rosalyn",
                LastName = "Guyton",
                Email = "rguytonf@mtv.com",
                Phone = "183 249 4857",
                Address = "9 American Ash Way"
                },

                new Friend 
                {
                Id = 17, FirstName = "Englebert",
                LastName = "Maltster",
                Email = "emaltsterg@dedecms.com",
                Phone = "779 612 6214",
                Address = "522 7th Way"
                },

                new Friend 
                {
                Id = 18, FirstName = "Gaultiero",
                LastName = "Lidgley",
                Email = "glidgleyh@bloglovin.com",
                Phone = "319 860 1673",
                Address = "35731 Oak Valley Trail"
                },

                new Friend 
                {
                Id = 19, FirstName = "Shermie",
                LastName = "Groger",
                Email = "sgrogeri@woothemes.com",
                Phone = "621 633 4434",
                Address = "5 Aberg Drive"
                },

                new Friend 
                {
                Id = 20, FirstName = "Sindee",
                LastName = "Jack",
                Email = "sjackj@ucsd.edu",
                Phone = "449 967 1831",
                Address = "7276 Hoffman Lane"
                },

                new Friend 
                {
                Id = 21, FirstName = "Burlie",
                LastName = "Rowswell",
                Email = null,
                Phone = "352 695 2322",
                Address = "913 Milwaukee Junction"
                },

                new Friend 
                {
                Id = 22, FirstName = "Cozmo",
                LastName = "Benford",
                Email = "cbenfordl@networkadvertising.org",
                Phone = "724 281 5388",
                Address = "5831 Main Street"
                },

                new Friend 
                {
                Id = 23, FirstName = "Skippie",
                LastName = "Ert",
                Email = "sertm@boston.com",
                Phone = "399 147 7244",
                Address = "793 Ridgeview Point"
                },

                new Friend 
                {
                Id = 24, FirstName = "Brig",
                LastName = "Krollmann",
                Email = null,
                Phone = "281 881 5644",
                Address = "27 7th Crossing"
                },

                new Friend 
                {
                Id = 25, FirstName = "Johanna",
                LastName = "Andrioli",
                Email = "jandriolio@toplist.cz",
                Phone = "939 845 8333",
                Address = "7 Rieder Avenue"
                },

                new Friend 
                {
                Id = 26, FirstName = "Tamara",
                LastName = "Quadling",
                Email = "tquadlingp@mapquest.com",
                Phone = "143 311 9675",
                Address = "8 Esker Lane"
                },

                new Friend 
                {
                Id = 27, FirstName = "Mendie",
                LastName = "Motion",
                Email = "mmotionq@ucla.edu",
                Phone = "303 981 9626",
                Address = "23 Heath Pass"
                },

                new Friend 
                {
                Id = 28, FirstName = "Emily",
                LastName = "Tottle",
                Email = "etottler@tinyurl.com",
                Phone = "933 231 8658",
                Address = "2 Menomonie Junction"
                },

                new Friend 
                {
                Id = 29, FirstName = "Kerrill",
                LastName = "Maysor",
                Email = "kmaysors@wisc.edu",
                Phone = "612 646 4045",
                Address = "05080 Lukken Park"
                },

                new Friend 
                {
                Id = 30, FirstName = "Verna",
                LastName = "Puddefoot",
                Email = "vpuddefoott@netlog.com",
                Phone = "222 188 0815",
                Address = "4400 Blackbird Parkway"
                },

                new Friend 
                {
                Id = 31, FirstName = "Emile",
                LastName = "Luca",
                Email = "elucau@ameblo.jp",
                Phone = "246 828 4283",
                Address = "2 Amoth Parkway"
                },

                new Friend 
                {
                Id = 32, FirstName = "Mable",
                LastName = "Fidal",
                Email = "mfidalv@networkadvertising.org",
                Phone = "968 785 7374",
                Address = "33266 Magdeline Crossing"
                },

                new Friend 
                {
                Id = 33, FirstName = null,
                LastName = "Wolledge",
                Email = null,
                Phone = null,
                Address = "16384 Ilene Lane"
                },

                new Friend 
                {
                Id = 34, FirstName = "Rozella",
                LastName = "Palfery",
                Email = "rpalferyx@tripadvisor.com",
                Phone = "146 945 2378",
                Address = "70 Prentice Hill"
                },

                new Friend 
                {
                Id = 35, FirstName = "Noell",
                LastName = "Langfield",
                Email = "nlangfieldy@geocities.com",
                Phone = "116 577 7637",
                Address = "409 Shasta Point"
                },

                new Friend 
                {
                Id = 36, FirstName = "Janel",
                LastName = "Shellard",
                Email = "jshellardz@icq.com",
                Phone = "160 253 7593",
                Address = "09177 8th Crossing"
                },

                new Friend 
                {
                Id = 37, FirstName = "Kally",
                LastName = "Powderham",
                Email = "kpowderham10@google.it",
                Phone = "915 251 9704",
                Address = "31728 Sheridan Court"
                },

                new Friend 
                {
                Id = 38, FirstName = "Collin",
                LastName = "Tschirschky",
                Email = "ctschirschky11@youtube.com",
                Phone = "922 736 9130",
                Address = "1540 Larry Way"
                },

                new Friend 
                {
                Id = 39, FirstName = "Emlynn",
                LastName = "Alderwick",
                Email = "ealderwick12@buzzfeed.com",
                Phone = "928 305 9334",
                Address = "40063 Burrows Circle"
                },

                new Friend 
                {
                Id = 40, FirstName = "Arden",
                LastName = "Winterbourne",
                Email = "awinterbourne13@yale.edu",
                Phone = "558 339 9484",
                Address = "1 Farwell Place"
                },

                new Friend 
                {
                Id = 41, FirstName = "Prinz",
                LastName = "Norley",
                Email = "pnorley14@booking.com",
                Phone = "655 283 1310",
                Address = "37 Mesta Parkway"
                },

                new Friend 
                {
                Id = 42, FirstName = "Berri",
                LastName = "Crookes",
                Email = "bcrookes15@cdc.gov",
                Phone = "747 903 9283",
                Address = "0990 Emmet Junction"
                },

                new Friend 
                {
                Id = 43, FirstName = "Kellia",
                LastName = "Boscott",
                Email = "kboscott16@miibeian.gov.cn",
                Phone = "398 306 5631",
                Address = "63 Chive Point"
                },

                new Friend 
                {
                Id = 44, FirstName = "Trenna",
                LastName = "Blant",
                Email = "tblant17@google.es",
                Phone = "323 168 3200",
                Address = "3066 Bartillon Circle"
                },

                new Friend 
                {
                Id = 45, FirstName = "Ewell",
                LastName = "Duddell",
                Email = "eduddell18@craigslist.org",
                Phone = "581 842 6236",
                Address = "1 Jenifer Parkway"
                },

                new Friend 
                {
                Id = 46, FirstName = "Lowrance",
                LastName = "Kensington",
                Email = "lkensington19@ox.ac.uk",
                Phone = "824 928 2103",
                Address = "95710 Russell Place"
                },

                new Friend 
                {
                Id = 47, FirstName = "Helen-elizabeth",
                LastName = "Elleray",
                Email = "helleray1a@icq.com",
                Phone = "242 130 3213",
                Address = "6 Northland Plaza"
                },

                new Friend 
                {
                Id = 48, FirstName = "Stephanie",
                LastName = "McKitterick",
                Email = "smckitterick1b@cdc.gov",
                Phone = "600 837 9328",
                Address = "21709 Almo Crossing"
                },

                new Friend 
                {
                Id = 49, FirstName = "Allayne",
                LastName = "Raubenheimers",
                Email = null,
                Phone = "559 714 9070",
                Address = "49631 Rowland Circle"
                },

                new Friend 
                {
                Id = 50, FirstName = "Samuele",
                LastName = "Iannitti",
                Email = "siannitti1d@blinklist.com",
                Phone = "244 440 6241",
                Address = "9 American Center"
                },

                new Friend 
                {
                Id = 51, FirstName = "Fredra",
                LastName = "Gingles",
                Email = "fgingles1e@dell.com",
                Phone = "135 718 4156",
                Address = "85608 East Terrace"
                },

                new Friend 
                {
                Id = 52, FirstName = "Shelden",
                LastName = "McInility",
                Email = "smcinility1f@example.com",
                Phone = "887 223 9858",
                Address = "5664 Twin Pines Crossing"
                },

                new Friend 
                {
                Id = 53, FirstName = "Edyth",
                LastName = "Lopez",
                Email = "elopez1g@dot.gov",
                Phone = "589 188 0559",
                Address = "386 Texas Trail"
                },

                new Friend 
                {
                Id = 54, FirstName = "Maryl",
                LastName = "Lakeland",
                Email = "mlakeland1h@youtube.com",
                Phone = "236 579 7038",
                Address = "7 Sachtjen Court"
                },

                new Friend 
                {
                Id = 55, FirstName = "Meris",
                LastName = "Gowdy",
                Email = "mgowdy1i@ifeng.com",
                Phone = "755 732 4817",
                Address = "8815 Duke Hill"
                },

                new Friend 
                {
                Id = 56, FirstName = "Aleta",
                LastName = "Mooney",
                Email = "amooney1j@marriott.com",
                Phone = "892 213 6956",
                Address = "90 Little Fleur Court"
                },

                new Friend 
                {
                Id = 57, FirstName = "Heath",
                LastName = "Petera",
                Email = "hpetera1k@angelfire.com",
                Phone = "878 919 3555",
                Address = "7280 Fordem Terrace"
                },

                new Friend 
                {
                Id = 58, FirstName = "Jocelyn",
                LastName = "Collman",
                Email = "jcollman1l@businessweek.com",
                Phone = "593 371 0199",
                Address = "7 Pennsylvania Place"
                },

                new Friend 
                {
                Id = 59, FirstName = "Brooks",
                LastName = "Lewsley",
                Email = "blewsley1m@prweb.com",
                Phone = "685 834 9837",
                Address = "9 Mesta Parkway"
                },

                new Friend 
                {
                Id = 60, FirstName = "Anestassia",
                LastName = "Duckit",
                Email = "aduckit1n@about.me",
                Phone = "390 912 7350",
                Address = "890 Mendota Pass"
                },

                new Friend 
                {
                Id = 61, FirstName = "Bradford",
                LastName = "Vinton",
                Email = "bvinton1o@yahoo.com",
                Phone = "738 526 4035",
                Address = "179 Hovde Lane"
                },

                new Friend 
                {
                Id = 62, FirstName = "Drusilla",
                LastName = "Brabbs",
                Email = "dbrabbs1p@lycos.com",
                Phone = "770 790 1427",
                Address = "755 Bartillon Point"
                },

                new Friend 
                {
                Id = 63, FirstName = "Ray",
                LastName = "Kaser",
                Email = "rkaser1q@mlb.com",
                Phone = "706 797 7805",
                Address = "19 Prentice Lane"
                },

                new Friend 
                {
                Id = 64, FirstName = "George",
                LastName = "Densey",
                Email = null,
                Phone = "970 954 3830",
                Address = "900 8th Pass"
                },

                new Friend 
                {
                Id = 65, FirstName = "York",
                LastName = "Aikenhead",
                Email = "yaikenhead1s@digg.com",
                Phone = "997 777 9102",
                Address = "9 Saint Paul Center"
                },

                new Friend 
                {
                Id = 66, FirstName = "Saraann",
                LastName = "Lorek",
                Email = "slorek1t@yandex.ru",
                Phone = "687 422 7721",
                Address = "2022 Nancy Avenue"
                },

                new Friend 
                {
                Id = 67, FirstName = "Georas",
                LastName = "Karpinski",
                Email = "gkarpinski1u@hao123.com",
                Phone = "949 208 3035",
                Address = "77694 Miller Parkway"
                },

                new Friend 
                {
                Id = 68, FirstName = "Abbey",
                LastName = "Karpeev",
                Email = "akarpeev1v@w3.org",
                Phone = "677 942 4030",
                Address = "46931 Namekagon Center"
                },

                new Friend 
                {
                Id = 69, FirstName = "Bambie",
                LastName = "Millions",
                Email = "bmillions1w@odnoklassniki.ru",
                Phone = "431 398 9545",
                Address = "02 Oriole Junction"
                },

                new Friend 
                {
                Id = 70, FirstName = "Jeana",
                LastName = "Fawlo",
                Email = "jfawlo1x@weather.com",
                Phone = "647 997 9567",
                Address = "053 Hoffman Park"
                },

                new Friend 
                {
                Id = 71, FirstName = "Finley",
                LastName = "Harradine",
                Email = "fharradine1y@reference.com",
                Phone = "789 143 3669",
                Address = "63605 Manufacturers Drive"
                },

                new Friend 
                {
                Id = 72, FirstName = "Addia",
                LastName = "Moulster",
                Email = "amoulster1z@e-recht24.de",
                Phone = "841 913 1520",
                Address = "05 Schmedeman Circle"
                },

                new Friend 
                {
                Id = 73, FirstName = "Hermon",
                LastName = "Node",
                Email = "hnode20@samsung.com",
                Phone = "554 963 6868",
                Address = "71 Hoard Junction"
                },

                new Friend 
                {
                Id = 74, FirstName = "Robena",
                LastName = "Brizell",
                Email = "rbrizell21@vinaora.com",
                Phone = "875 439 3603",
                Address = "7597 Comanche Avenue"
                },

                new Friend 
                {
                Id = 75, FirstName = "Nananne",
                LastName = "Czyz",
                Email = "nczyz22@nyu.edu",
                Phone = "713 311 1638",
                Address = "13647 Coleman Center"
                },

                new Friend 
                {
                Id = 76, FirstName = "Jennie",
                LastName = "Langham",
                Email = "jlangham23@ucsd.edu",
                Phone = "272 190 9010",
                Address = "813 John Wall Hill"
                },

                new Friend 
                {
                Id = 77, FirstName = null,
                LastName = "Reeds",
                Email = "dreeds24@angelfire.com",
                Phone = "699 149 7172",
                Address = "5 Swallow Terrace"
                },

                new Friend 
                {
                Id = 78, FirstName = "Lincoln",
                LastName = "Earengey",
                Email = "learengey25@gmpg.org",
                Phone = "786 824 7902",
                Address = "9 Paget Place"
                },

                new Friend 
                {
                Id = 79, FirstName = "Dimitry",
                LastName = "Klulicek",
                Email = "dklulicek26@apache.org",
                Phone = "660 941 4637",
                Address = "591 Thierer Street"
                },

                new Friend 
                {
                Id = 80, FirstName = "Sanders",
                LastName = "Marzellano",
                Email = "smarzellano27@arizona.edu",
                Phone = "695 644 3093",
                Address = "49 Longview Street"
                },

                new Friend 
                {
                Id = 81, FirstName = "Tomasina",
                LastName = "Tomney",
                Email = "ttomney28@microsoft.com",
                Phone = "735 689 8075",
                Address = "79 Kim Circle"
                },

                new Friend 
                {
                Id = 82, FirstName = "Otis",
                LastName = "MacHoste",
                Email = "omachoste29@storify.com",
                Phone = "873 668 0719",
                Address = "754 Garrison Parkway"
                },

                new Friend 
                {
                Id = 83, FirstName = null,
                LastName = "Annies",
                Email = "tannies2a@stumbleupon.com",
                Phone = "233 769 3714",
                Address = "08165 Bunker Hill Lane"
                },

                new Friend 
                {
                Id = 84, FirstName = "Phoebe",
                LastName = "Lawranson",
                Email = "plawranson2b@si.edu",
                Phone = "192 338 4628",
                Address = "1 Corben Drive"
                },

                new Friend 
                {
                Id = 85, FirstName = "Wernher",
                LastName = "Pridham",
                Email = null,
                Phone = "846 511 9832",
                Address = "9 Everett Point"
                },

                new Friend 
                {
                Id = 86, FirstName = "Willard",
                LastName = "Cubbin",
                Email = "wcubbin2d@friendfeed.com",
                Phone = "266 977 6621",
                Address = "85 Homewood Court"
                },

                new Friend 
                {
                Id = 87, FirstName = "Freida",
                LastName = "Bratt",
                Email = "fbratt2e@deliciousdays.com",
                Phone = null,
                Address = "87 Ludington Drive"
                },

                new Friend 
                {
                Id = 88, FirstName = "Starlin",
                LastName = "Dight",
                Email = "sdight2f@msn.com",
                Phone = "662 746 9748",
                Address = "996 Lakeland Parkway"
                },

                new Friend 
                {
                Id = 89, FirstName = "Wittie",
                LastName = "Haysom",
                Email = "whaysom2g@creativecommons.org",
                Phone = "654 920 7051",
                Address = "63 Miller Avenue"
                },

                new Friend 
                {
                Id = 90, FirstName = "Merissa",
                LastName = "Fattorini",
                Email = "mfattorini2h@webeden.co.uk",
                Phone = "375 214 0507",
                Address = "4 Canary Alley"
                },

                new Friend 
                {
                Id = 91, FirstName = "Lynna",
                LastName = "Goodlake",
                Email = "lgoodlake2i@quantcast.com",
                Phone = "943 200 4699",
                Address = "91 Park Meadow Hill"
                },

                new Friend 
                {
                Id = 92, FirstName = "Philippa",
                LastName = "Hobble",
                Email = "phobble2j@patch.com",
                Phone = null,
                Address = "96 Browning Way"
                },

                new Friend 
                {
                Id = 93, FirstName = "Bunny",
                LastName = "Heninghem",
                Email = "bheninghem2k@timesonline.co.uk",
                Phone = "359 671 5420",
                Address = "32 Quincy Hill"
                },

                new Friend 
                {
                Id = 94, FirstName = "Carlin",
                LastName = "Mannix",
                Email = "cmannix2l@ted.com",
                Phone = "311 738 6647",
                Address = "6 Weeping Birch Terrace"
                },

                new Friend 
                {
                Id = 95, FirstName = "Bastien",
                LastName = "Brickham",
                Email = "bbrickham2m@plala.or.jp",
                Phone = "115 415 5051",
                Address = "6588 Bellgrove Circle"
                },

                new Friend 
                {
                Id = 96, FirstName = "Irina",
                LastName = "Leebetter",
                Email = "ileebetter2n@photobucket.com",
                Phone = "901 463 3760",
                Address = "221 Clemons Junction"
                },

                new Friend 
                {
                Id = 97, FirstName = "Thorndike",
                LastName = "Bortolussi",
                Email = "tbortolussi2o@mlb.com",
                Phone = "205 730 3576",
                Address = "83 Memorial Road"
                },

                new Friend 
                {
                Id = 98, FirstName = "Magdalen",
                LastName = "Bagniuk",
                Email = "mbagniuk2p@privacy.gov.au",
                Phone = "752 747 9498",
                Address = "69 Cambridge Place"
                },

                new Friend 
                {
                Id = 99, FirstName = "Durant",
                LastName = "Barnsley",
                Email = "dbarnsley2q@angelfire.com",
                Phone = "783 422 4303",
                Address = "2790 Tony Drive"
                },

                new Friend 
                {
                Id = 100, FirstName = "Carlos",
                LastName = "Dericut",
                Email = "cdericut2r@ucoz.com",
                Phone = "687 254 5284",
                Address = "38 Colorado Plaza"
                }
    };

    public List<Friend> Friends => _friends;
}
}
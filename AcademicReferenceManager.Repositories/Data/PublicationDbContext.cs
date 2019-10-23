using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;

namespace AcademicReferenceManager.Repositories.Data {
    public class PublicationDbContext : IPublicationDbContext {
        private readonly List<Publication> _publications = new List<Publication> {
            new Publication 
            {
                Id = 1,
                EditorFirstName = "Andréanne",
                EditorLastName = "Yegorkov",
                Title = "Phascogale tapoatafa",
                Isbn = "078401297-0",
                Type = "electronic",
                Year = 1996,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 2,
                EditorFirstName = "Athéna",
                EditorLastName = "Sayle",
                Title = "Crocuta crocuta",
                Isbn = "746521865-9",
                Type = "printed",
                Year = 2005,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 3,
                EditorFirstName = "Aurélie",
                EditorLastName = null,
                Title = null,
                Isbn = "886359859-2",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 4,
                EditorFirstName = "Hélène",
                EditorLastName = "Close",
                Title = null,
                Isbn = "765720245-9",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 5,
                EditorFirstName = "Méryl",
                EditorLastName = "Tuckwood",
                Title = "Cacatua tenuirostris",
                Isbn = "986672075-6",
                Type = "printed",
                Year = 2007,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 6,
                EditorFirstName = "Börje",
                EditorLastName = "Townsend",
                Title = "Odocoileus hemionus",
                Isbn = "910381336-3",
                Type = "printed",
                Year = 2011,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 7,
                EditorFirstName = "Esbjörn",
                EditorLastName = "Hinchon",
                Title = "unavailable",
                Isbn = "507003031-0",
                Type = "printed",
                Year = 2000,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 8,
                EditorFirstName = "Loïca",
                EditorLastName = "Nind",
                Title = "Hymenolaimus malacorhynchus",
                Isbn = "149537426-2",
                Type = "electronic",
                Year = 2007,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 9,
                EditorFirstName = "André",
                EditorLastName = "Majury",
                Title = null,
                Isbn = "238214929-9",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 10,
                EditorFirstName = "Gaëlle",
                EditorLastName = "Hancox",
                Title = "Anastomus oscitans",
                Isbn = "609067213-0",
                Type = "electronic",
                Year = 2008,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 11,
                EditorFirstName = "Yénora",
                EditorLastName = "Hathaway",
                Title = "Uraeginthus granatina",
                Isbn = "475059795-3",
                Type = "printed",
                Year = 1997,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 12,
                EditorFirstName = "Pénélope",
                EditorLastName = "Gl    ide",
                Title = "Equus hemionus",
                Isbn = "750091697-3",
                Type = "printed",
                Year = 1995,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 13,
                EditorFirstName = "Publicité",
                EditorLastName = "Kupper",
                Title = "Limnocorax flavirostra",
                Isbn = "826091320-8",
                Type = "electronic",
                Year = 2000,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 14,
                EditorFirstName = "Mélodie",
                EditorLastName = null,
                Title = "Eubalaena australis",
                Isbn = "334836836-7",
                Type = "electronic",
                Year = 2011,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 15,
                EditorFirstName = "Gaïa",
                EditorLastName = "Canfer",
                Title = "Heloderma horr idum",
                Isbn = "037078876-1",
                Type = "electronic",
                Year = 1997,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 16,
                EditorFirstName = "Bécassine",
                EditorLastName = "Dorkins",
                Title = "Hystrix cristata",
                Isbn = "483542182-5",
                Type = "printed",
                Year = 2012,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 17,
                EditorFirstName = "Almérinda",
                EditorLastName = "Leghorn",
                Title = "Tamandua tetradactyla",
                Isbn = "925914206-7",
                Type = "printed",
                Year = 1993,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 18,
                EditorFirstName = "Marie-noël",
                EditorLastName = "Argue",
                Title = "Castor fiber",
                Isbn = "843589787-7",
                Type = "printed",
                Year = 2009,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 19,
                EditorFirstName = "Desirée",
                EditorLastName = "Edess",
                Title = "Equus burchelli",
                Isbn = "121573250-3",
                Type = "electronic",
                Year = 1996,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 20,
                EditorFirstName = "Styrbjörn",
                EditorLastName = "Kaplin",
                Title = "Bubalornis niger",
                Isbn = "100118429-7",
                Type = "printed",
                Year = 1999,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 21,
                EditorFirstName = "Valérie",
                EditorLastName = "Crake",
                Title = "Capreolus capreolus",
                Isbn = "901635842-0",
                Type = "electronic",
                Year = 1996,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 22,
                EditorFirstName = "Lèi",
                EditorLastName = "Feckey",
                Title = "Dromaeus novaehollandiae",
                Isbn = "104546813-4",
                Type = "printed",
                Year = 2012,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 23,
                EditorFirstName = "Béatrice",
                EditorLastName = "Beaford",
                Title = "Speothos vanaticus",
                Isbn = "031518654-2",
                Type = "printed",
                Year = 1998,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 24,
                EditorFirstName = "Angèle",
                EditorLastName = null,
                Title = "Hyaena brunnea",
                Isbn = null,
                Type = "electronic",
                Year = 2003,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 25,
                EditorFirstName = "Maëlla",
                EditorLastName = "Sysland",
                Title = "Varanus sp.",
                Isbn = "895871991-5",
                Type = "electronic",
                Year = 1996,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 26,
                EditorFirstName = "Garçon",
                EditorLastName = "Poacher",
                Title = "Coendou prehensilis",
                Isbn = "120500828-4",
                Type = "printed",
                Year = 2012,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 27,
                EditorFirstName = "Mélina",
                EditorLastName = "Dionisii",
                Title = "Varanus salvator",
                Isbn = "964020583-4",
                Type = "electronic",
                Year = 2011,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 28,
                EditorFirstName = "Alizée",
                EditorLastName = "Schouthede",
                Title = "Phoenicopterus ruber",
                Isbn = "091095688-X",
                Type = "printed",
                Year = 1969,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 29,
                EditorFirstName = "Yénora",
                EditorLastName = "Reglar",
                Title = "Zalophus californicus",
                Isbn = "223815700-X",
                Type = "printed",
                Year = 2007,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 30,
                EditorFirstName = "Åke",
                EditorLastName = "Biss",
                Title = "Vombatus ursinus",
                Isbn = "347667305-7",
                Type = "printed",
                Year = 2005,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 31,
                EditorFirstName = "Marie-josée",
                EditorLastName = "Conechie",
                Title = "Felis silvestris lybica",
                Isbn = "642885042-7",
                Type = "printed",
                Year = 1997,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 32,
                EditorFirstName = "Cloé",
                EditorLastName = "Oxborrow",
                Title = "Colobus guerza",
                Isbn = "076555829-7",
                Type = "printed",
                Year = 1985,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 33,
                EditorFirstName = "Célia",
                EditorLastName = "Lindmark",
                Title = "Buteo regalis",
                Isbn = "804505490-5",
                Type = "electronic",
                Year = 2003,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 34,
                EditorFirstName = "Miléna",
                EditorLastName = "Remirez",
                Title = "Anas platyrhynchos",
                Isbn = "799140647-4",
                Type = "electronic",
                Year = 1989,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 35,
                EditorFirstName = "Marie-hélène",
                EditorLastName = "Rillatt",
                Title = "Theropithecus gelada",
                Isbn = "754663706-6",
                Type = "electronic",
                Year = 2002,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 36,
                EditorFirstName = "Frédérique",
                EditorLastName = "Francello",
                Title = "Colobus guerza",
                Isbn = "924653588-X",
                Type = "electronic",
                Year = 1994,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 37,
                EditorFirstName = "Lén",
                EditorLastName = "Degenhardt",
                Title = "Mephitis mephitis",
                Isbn = "552841930-1",
                Type = "printed",
                Year = 2011,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 38,
                EditorFirstName = "Lài",
                EditorLastName = "Langran",
                Title = "Genetta genetta",
                Isbn = null,
                Type = "electronic",
                Year = 2002,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 39,
                EditorFirstName = "Cécilia",
                EditorLastName = "Sevier",
                Title = "unavailable",
                Isbn = "158008618-7",
                Type = "printed",
                Year = 2002,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 40,
                EditorFirstName = "Dorothée",
                EditorLastName = "Raffon",
                Title = "Meles meles",
                Isbn = "739113993-9",
                Type = "printed",
                Year = 2004,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 41,
                EditorFirstName = "Tú",
                EditorLastName = "Olligan",
                Title = "Phalacrocorax carbo",
                Isbn = "116413878-2",
                Type = "printed",
                Year = 2006,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 42,
                EditorFirstName = "Geneviève",
                EditorLastName = "Loalday",
                Title = "Axis axis",
                Isbn = "692113840-2",
                Type = "electronic",
                Year = 2002,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 43,
                EditorFirstName = "Léonore",
                EditorLastName = null,
                Title = "Ramphastos tucanus",
                Isbn = "919422082-4",
                Type = "printed",
                Year = 1992,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 44,
                EditorFirstName = "Yóu",
                EditorLastName = "Veare",
                Title = "Macropus eugenii",
                Isbn = "301258634-2",
                Type = "printed",
                Year = 1998,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 45,
                EditorFirstName = "Joséphine",
                EditorLastName = "Deddum",
                Title = "Haematopus ater",
                Isbn = "175832077-X",
                Type = "printed",
                Year = 2005,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 46,
                EditorFirstName = "Sòng",
                EditorLastName = "Gostage",
                Title = "Vulpes chama",
                Isbn = "533746866-9",
                Type = "electronic",
                Year = 2001,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 47,
                EditorFirstName = "Vénus",
                EditorLastName = "Rollin",
                Title = "Aonyx cinerea",
                Isbn = "161028154-3",
                Type = "electronic",
                Year = 2001,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 48,
                EditorFirstName = "Bérénice",
                EditorLastName = "Giorgi",
                Title = "Ardea golieth",
                Isbn = null,
                Type = "electronic",
                Year = 2012,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 49,
                EditorFirstName = "Åsa",
                EditorLastName = null,
                Title = "Gyps fulvus",
                Isbn = "603811634-6",
                Type = "electronic",
                Year = 2008,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 50,
                EditorFirstName = "Audréanne",
                EditorLastName = "Tesh",
                Title = "Deroptyus accipitrinus",
                Isbn = "334244385-5",
                Type = "electronic",
                Year = 2012,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 51,
                EditorFirstName = "Sélène",
                EditorLastName = "Helstrom",
                Title = "Crotalus adamanteus",
                Isbn = "920119408-0",
                Type = "electronic",
                Year = 2000,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 52,
                EditorFirstName = "Kuí",
                EditorLastName = "Whiscard",
                Title = "Gymnorhina tibicen",
                Isbn = "804889279-0",
                Type = "electronic",
                Year = 1993,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 53,
                EditorFirstName = "Gérald",
                EditorLastName = "Moralee",
                Title = "Heloderma horr idum",
                Isbn = null,
                Type = "electronic",
                Year = 2002,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 54,
                EditorFirstName = "Gisèle",
                EditorLastName = "Haye",
                Title = "Cyrtodactylus louisiadensis",
                Isbn = "003299178-9",
                Type = "electronic",
                Year = 2010,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 55,
                EditorFirstName = "Liè",
                EditorLastName = "Stobart",
                Title = "Priodontes maximus",
                Isbn = "335467088-6",
                Type = "printed",
                Year = 2009,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 56,
                EditorFirstName = "Renée",
                EditorLastName = "Grattage",
                Title = "Ciconia episcopus",
                Isbn = "811413633-2",
                Type = "printed",
                Year = 2001,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 57,
                EditorFirstName = "Bérangère",
                EditorLastName = "Towner",
                Title = "Pelecans onocratalus",
                Isbn = "021090022-9",
                Type = "electronic",
                Year = 2003,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 58,
                EditorFirstName = "Östen",
                EditorLastName = "Filipov",
                Title = "Alopochen aegyptiacus",
                Isbn = "641857946-1",
                Type = "printed",
                Year = 2001,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 59,
                EditorFirstName = "Angélique",
                EditorLastName = "Tran",
                Title = "Irania gutteralis",
                Isbn = "605531518-1",
                Type = "printed",
                Year = 2009,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 60,
                EditorFirstName = "Dafnée",
                EditorLastName = "Haggett",
                Title = "Cyrtodactylus louisiadensis",
                Isbn = "616697593-7",
                Type = "electronic",
                Year = 1999,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 61,
                EditorFirstName = "Mélanie",
                EditorLastName = "Blabber",
                Title = "Erinaceus frontalis",
                Isbn = "610601782-4",
                Type = "printed",
                Year = 2009,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 62,
                EditorFirstName = "Örjan",
                EditorLastName = "Fairman",
                Title = "Neotis denhami",
                Isbn = "262487311-2",
                Type = "electronic",
                Year = 1993,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 63,
                EditorFirstName = "Almérinda",
                EditorLastName = "Steljes",
                Title = "Columba palumbus",
                Isbn = "887924327-6",
                Type = "printed",
                Year = 2010,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 64,
                EditorFirstName = "Mélanie",
                EditorLastName = "Coleiro",
                Title = "unavailable",
                Isbn = "805377925-5",
                Type = "electronic",
                Year = 1993,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 65,
                EditorFirstName = "Marie-josée",
                EditorLastName = "Baughan",
                Title = "Ant    idorcas marsupialis",
                Isbn = "340343309-9",
                Type = "printed",
                Year = 2003,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 66,
                EditorFirstName = "Maëlle",
                EditorLastName = "Huglin",
                Title = "Dendrohyrax brucel",
                Isbn = "267963131-5",
                Type = "printed",
                Year = 2009,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 67,
                EditorFirstName = "Pénélope",
                EditorLastName = "O'Glessane",
                Title = "Bettongia penicillata",
                Isbn = null,
                Type = "electronic",
                Year = 2006,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 68,
                EditorFirstName = "Lèi",
                EditorLastName = "Butchers",
                Title = "Thalasseus maximus",
                Isbn = "015470132-7",
                Type = "electronic",
                Year = 2009,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 69,
                EditorFirstName = "Aimée",
                EditorLastName = "Wootton",
                Title = "Naja haje",
                Isbn = "408850782-7",
                Type = "printed",
                Year = 2004,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 70,
                EditorFirstName = "Cloé",
                EditorLastName = "Cabel",
                Title = "Ictalurus furcatus",
                Isbn = "179713311-X",
                Type = "printed",
                Year = 1987,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 71,
                EditorFirstName = "Sélène",
                EditorLastName = "Kaspar",
                Title = "Balearica pavonina",
                Isbn = "616168858-1",
                Type = "electronic",
                Year = 1999,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 72,
                EditorFirstName = "Laurélie",
                EditorLastName = "Clendening",
                Title = "Connochaetus taurinus",
                Isbn = "734473633-0",
                Type = "electronic",
                Year = 2012,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 73,
                EditorFirstName = "Méline",
                EditorLastName = "Catterell",
                Title = "unavailable",
                Isbn = "389680682-3",
                Type = "electronic",
                Year = 1999,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 74,
                EditorFirstName = "Léana",
                EditorLastName = "MacLennan",
                Title = "Bucorvus leadbeateri",
                Isbn = "751361327-3",
                Type = "printed",
                Year = 2008,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 75,
                EditorFirstName = "Léandre",
                EditorLastName = "Better    idge",
                Title = "Phalacrocorax carbo",
                Isbn = "982683851-9",
                Type = "electronic",
                Year = 2001,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 76,
                EditorFirstName = "Séréna",
                EditorLastName = "Godmer",
                Title = "Tringa glareola",
                Isbn = null,
                Type = "printed",
                Year = 2009,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 77,
                EditorFirstName = "Miléna",
                EditorLastName = "Whyman",
                Title = "Alouatta seniculus",
                Isbn = "836297433-8",
                Type = "printed",
                Year = 1986,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 78,
                EditorFirstName = "Léane",
                EditorLastName = "Chittem",
                Title = "Limosa haemastica",
                Isbn = "824573037-8",
                Type = "printed",
                Year = 2007,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 79,
                EditorFirstName = "Léonie",
                EditorLastName = "Delouch",
                Title = "Papio ursinus",
                Isbn = "402663512-0",
                Type = "electronic",
                Year = 1984,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 80,
                EditorFirstName = "Annotés",
                EditorLastName = "Scotts",
                Title = "Phalacrocorax varius",
                Isbn = null,
                Type = "electronic",
                Year = 2007,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 81,
                EditorFirstName = "Gaïa",
                EditorLastName = "Wadie",
                Title = "Agama sp.",
                Isbn = "492212150-1",
                Type = "electronic",
                Year = 1995,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 82,
                EditorFirstName = "Chloé",
                EditorLastName = "Lujan",
                Title = "Deroptyus accipitrinus",
                Isbn = "249209762-5",
                Type = "electronic",
                Year = 2011,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 83,
                EditorFirstName = "Marie-josée",
                EditorLastName = "Cersey",
                Title = "Chl    idonias leucopterus",
                Isbn = "590668805-6",
                Type = "printed",
                Year = 2008,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 84,
                EditorFirstName = "Eliès",
                EditorLastName = "Broadbent",
                Title = "Graspus graspus",
                Isbn = "066856028-2",
                Type = "printed",
                Year = 2007,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 85,
                EditorFirstName = "Loïca",
                EditorLastName = "Bellee",
                Title = "Bubalornis niger",
                Isbn = "117775440-1",
                Type = "electronic",
                Year = 1999,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 86,
                EditorFirstName = "Pò",
                EditorLastName = "Payton",
                Title = "Phalaropus lobatus",
                Isbn = "067635801-2",
                Type = "printed",
                Year = 1995,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 87,
                EditorFirstName = "Océane",
                EditorLastName = "Gillham",
                Title = "Varanus salvator",
                Isbn = "342274409-6",
                Type = "printed",
                Year = 1987,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 88,
                EditorFirstName = "Anaëlle",
                EditorLastName = "Semple",
                Title = "Tachyglossus aculeatus",
                Isbn = "563573461-8",
                Type = "printed",
                Year = 1990,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 89,
                EditorFirstName = "Céline",
                EditorLastName = "Chiswell",
                Title = "Libellula quadrimaculata",
                Isbn = "026662111-2",
                Type = "electronic",
                Year = 1999,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 90,
                EditorFirstName = "Anaé",
                EditorLastName = "Broadfield",
                Title = "Cracticus nigroagularis",
                Isbn = "763243219-1",
                Type = "electronic",
                Year = 1997,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 91,
                EditorFirstName = "Maïté",
                EditorLastName = "Adamolli",
                Title = "Mazama americana",
                Isbn = "800669362-5",
                Type = "electronic",
                Year = 1986,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 92,
                EditorFirstName = "Marie-josée",
                EditorLastName = "Habben",
                Title = "Sterna paradisaea",
                Isbn = "572746125-1",
                Type = "electronic",
                Year = 1993,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 93,
                EditorFirstName = "Bécassine",
                EditorLastName = "Tutton",
                Title = "Acr    idotheres tristis",
                Isbn = "221817027-2",
                Type = "electronic",
                Year = 1991,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 94,
                EditorFirstName = "Annotés",
                EditorLastName = "Dudenie",
                Title = "Psophia vir    idis",
                Isbn = "724868190-3",
                Type = "electronic",
                Year = 2010,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 95,
                EditorFirstName = "Adélaïde",
                EditorLastName = "Gilding",
                Title = "Lepus arcticus",
                Isbn = "150035838-X",
                Type = "printed",
                Year = 1996,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 96,
                EditorFirstName = "Sélène",
                EditorLastName = "Haddrell",
                Title = "Alouatta seniculus",
                Isbn = "712006939-X",
                Type = "electronic",
                Year = 1993,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 97,
                EditorFirstName = "Maéna",
                EditorLastName = "Haill",
                Title = "Nyctea scandiaca",
                Isbn = "382794914-9",
                Type = "printed",
                Year = 1995,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 98,
                EditorFirstName = "Solène",
                EditorLastName = "Ondrus",
                Title = "Tiliqua scinco ides",
                Isbn = "149849015-8",
                Type = "printed",
                Year = 1992,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 99,
                EditorFirstName = "Uò",
                EditorLastName = "Gaule",
                Title = "Castor canadensis",
                Isbn = "625299370-0",
                Type = "electronic",
                Year = 2001,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 100,
                EditorFirstName = "Anaé",
                EditorLastName = "Benda",
                Title = "Gorilla gorilla",
                Isbn = "719882000-X",
                Type = "printed",
                Year = 2003,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 101,
                EditorFirstName = "Audréanne",
                EditorLastName = "Grunbaum",
                Title = "Neophron percnopterus",
                Isbn = "134308717-1",
                Type = "printed",
                Year = 2012,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 102,
                EditorFirstName = "Audréanne",
                EditorLastName = "Tytcomb",
                Title = null,
                Isbn = "478331398-9",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 103,
                EditorFirstName = "Clémentine",
                EditorLastName = "De Ambrosi",
                Title = "Panthera pardus",
                Isbn = "830320950-7",
                Type = "printed",
                Year = 2009,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 104,
                EditorFirstName = "Hélène",
                EditorLastName = "Guerrin",
                Title = "Cacatua galerita",
                Isbn = "064016944-9",
                Type = "electronic",
                Year = 1996,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 105,
                EditorFirstName = "Tán",
                EditorLastName = "Reoch",
                Title = "Felis wiedi or Leopardus we    idi",
                Isbn = "274444924-5",
                Type = "electronic",
                Year = 1988,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 106,
                EditorFirstName = "Léone",
                EditorLastName = null,
                Title = "Hymenolaimus malacorhynchus",
                Isbn = "767805138-7",
                Type = "electronic",
                Year = 1999,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 107,
                EditorFirstName = "Göran",
                EditorLastName = "Vereker",
                Title = "Tockus flavirostris",
                Isbn = "213526868-2",
                Type = "printed",
                Year = 2004,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 108,
                EditorFirstName = "Andrée",
                EditorLastName = "Robilliard",
                Title = "Lybius torquatus",
                Isbn = "716132069-0",
                Type = "electronic",
                Year = 1998,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 109,
                EditorFirstName = "Örjan",
                EditorLastName = "Maynell",
                Title = "Aonyx cinerea",
                Isbn = "533376822-6",
                Type = "electronic",
                Year = 2001,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 110,
                EditorFirstName = "Yénora",
                EditorLastName = null,
                Title = "Dicrostonyx groenlandicus",
                Isbn = "726159681-7",
                Type = "electronic",
                Year = 2001,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 111,
                EditorFirstName = "Desirée",
                EditorLastName = "Greetham",
                Title = "Bos mutus",
                Isbn = "837962718-0",
                Type = "printed",
                Year = 1999,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 112,
                EditorFirstName = "Judicaël",
                EditorLastName = "Brecher",
                Title = "Phalaropus fulicarius",
                Isbn = "729253156-3",
                Type = "electronic",
                Year = 1995,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 113,
                EditorFirstName = "Sélène",
                EditorLastName = "Isaaksohn",
                Title = "unavailable",
                Isbn = null,
                Type = "printed",
                Year = 2004,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 114,
                EditorFirstName = "Adélie",
                EditorLastName = "Dobrowolski",
                Title = "Chl    idonias leucopterus",
                Isbn = "695808032-7",
                Type = "electronic",
                Year = 2001,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 115,
                EditorFirstName = "Frédérique",
                EditorLastName = "Pr    ide",
                Title = "Gazella granti",
                Isbn = "029269160-2",
                Type = "electronic",
                Year = 1994,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 116,
                EditorFirstName = "Åsa",
                EditorLastName = "Birkwood",
                Title = "Cathartes aura",
                Isbn = "246664734-6",
                Type = "printed",
                Year = 2007,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 117,
                EditorFirstName = "Rébecca",
                EditorLastName = "Gooderham",
                Title = "Zonotrichia capensis",
                Isbn = "384290154-2",
                Type = "printed",
                Year = 1985,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 118,
                EditorFirstName = "Wá",
                EditorLastName = "Cargo",
                Title = "Sarcorhamphus papa",
                Isbn = "524419103-9",
                Type = "printed",
                Year = 1994,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 119,
                EditorFirstName = "Méline",
                EditorLastName = "Standbr   idge",
                Title = "Spheniscus mendiculus",
                Isbn = "439156263-4",
                Type = "electronic",
                Year = 1991,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 120,
                EditorFirstName = "Mén",
                EditorLastName = "Scougal",
                Title = "Aegypius occipitalis",
                Isbn = "297335436-6",
                Type = "printed",
                Year = 2003,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 121,
                EditorFirstName = "Léana",
                EditorLastName = "Bastie",
                Title = "Phoca vitulina",
                Isbn = "757875882-9",
                Type = "printed",
                Year = 2005,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 122,
                EditorFirstName = "Lorène",
                EditorLastName = "Jahnke",
                Title = "Crocuta crocuta",
                Isbn = "317465737-7",
                Type = "electronic",
                Year = 2005,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 123,
                EditorFirstName = "Maëline",
                EditorLastName = "Orteau",
                Title = "Macropus robustus",
                Isbn = "993358084-1",
                Type = "electronic",
                Year = 2008,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 124,
                EditorFirstName = "Hélèna",
                EditorLastName = "Bortoluzzi",
                Title = "Motacilla aguimp",
                Isbn = "775825902-2",
                Type = "printed",
                Year = 2011,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 125,
                EditorFirstName = "Mén",
                EditorLastName = "Radenhurst",
                Title = "Uraeginthus granatina",
                Isbn = "384845582-X",
                Type = "printed",
                Year = 2007,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 126,
                EditorFirstName = "Lèi",
                EditorLastName = "Annandale",
                Title = "Loxodonta africana",
                Isbn = "064591924-1",
                Type = "printed",
                Year = 2008,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 127,
                EditorFirstName = "Célia",
                EditorLastName = "Aggis",
                Title = "Castor canadensis",
                Isbn = "263734099-1",
                Type = "electronic",
                Year = 1994,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 128,
                EditorFirstName = "Aloïs",
                EditorLastName = "MacGovern",
                Title = "Macropus eugenii",
                Isbn = "326278989-5",
                Type = "electronic",
                Year = 1994,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 129,
                EditorFirstName = "Joséphine",
                EditorLastName = "Taye",
                Title = "Pseudalopex gymnocercus",
                Isbn = "514519141-3",
                Type = "printed",
                Year = 2006,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 130,
                EditorFirstName = "Maïly",
                EditorLastName = "Judron",
                Title = "Geococcyx californianus",
                Isbn = "753010206-0",
                Type = "electronic",
                Year = 2011,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 131,
                EditorFirstName = "Laïla",
                EditorLastName = null,
                Title = "Pituophis melanaleucus",
                Isbn = null,
                Type = "printed",
                Year = 2009,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 132,
                EditorFirstName = "Salomé",
                EditorLastName = "Le Bosse",
                Title = "Colobus guerza",
                Isbn = "989159903-5",
                Type = "printed",
                Year = 1995,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 133,
                EditorFirstName = "Irène",
                EditorLastName = "Filippov",
                Title = "Mazama gouazoubira",
                Isbn = "861708204-6",
                Type = "printed",
                Year = 2000,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 134,
                EditorFirstName = "Gisèle",
                EditorLastName = "Treasure",
                Title = "Procyon cancrivorus",
                Isbn = "554509863-1",
                Type = "printed",
                Year = 2003,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 135,
                EditorFirstName = "Mélanie",
                EditorLastName = "Beams",
                Title = "Kobus defassa",
                Isbn = null,
                Type = "printed",
                Year = 2006,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 136,
                EditorFirstName = "Bérengère",
                EditorLastName = "Badsworth",
                Title = "Agelaius phoeniceus",
                Isbn = "457005988-0",
                Type = "electronic",
                Year = 1989,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 137,
                EditorFirstName = "Marie-hélène",
                EditorLastName = "Sedcole",
                Title = "Phacochoerus aethiopus",
                Isbn = "371632552-X",
                Type = "electronic",
                Year = 1990,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 138,
                EditorFirstName = "Faîtes",
                EditorLastName = "Diggles",
                Title = "Diceros bicornis",
                Isbn = "735144764-0",
                Type = "electronic",
                Year = 1996,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 139,
                EditorFirstName = "Marie-josée",
                EditorLastName = "Pollak",
                Title = "Eudyptula minor",
                Isbn = "299155866-0",
                Type = "printed",
                Year = 2009,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 140,
                EditorFirstName = "Mårten",
                EditorLastName = null,
                Title = "Neotoma sp.",
                Isbn = "754518996-5",
                Type = "printed",
                Year = 2013,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 141,
                EditorFirstName = "Maïté",
                EditorLastName = "Mioni",
                Title = "Chauna torquata",
                Isbn = "452574294-1",
                Type = "electronic",
                Year = 1964,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 142,
                EditorFirstName = "Marie-thérèse",
                EditorLastName = "Elsay",
                Title = "Melursus ursinus",
                Isbn = "292204795-4",
                Type = "printed",
                Year = 2005,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 143,
                EditorFirstName = "Gisèle",
                EditorLastName = "Leneve",
                Title = "Plegadis falcinellus",
                Isbn = "435539650-9",
                Type = "printed",
                Year = 2006,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 144,
                EditorFirstName = "Mén",
                EditorLastName = "Purry",
                Title = "Sagittarius serpentarius",
                Isbn = "036735614-7",
                Type = "electronic",
                Year = 1999,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 145,
                EditorFirstName = "Maëlann",
                EditorLastName = "Belding",
                Title = "Phalaropus lobatus",
                Isbn = "909963144-8",
                Type = "electronic",
                Year = 1994,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 146,
                EditorFirstName = "Sélène",
                EditorLastName = "Keyte",
                Title = "Mazama gouazoubira",
                Isbn = "298436320-5",
                Type = "printed",
                Year = 1999,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 147,
                EditorFirstName = "Adélaïde",
                EditorLastName = "Beazley",
                Title = "Streptopelia decipiens",
                Isbn = "361252812-2",
                Type = "printed",
                Year = 2011,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 148,
                EditorFirstName = "Bérengère",
                EditorLastName = "Buy",
                Title = "Phascogale tapoatafa",
                Isbn = "644162868-6",
                Type = "electronic",
                Year = 1996,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 149,
                EditorFirstName = "Méghane",
                EditorLastName = "Sissland",
                Title = "Acr    idotheres tristis",
                Isbn = "507614003-7",
                Type = "electronic",
                Year = 2003,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 150,
                EditorFirstName = "Cloé",
                EditorLastName = "Arderne",
                Title = "Naja haje",
                Isbn = "275543142-3",
                Type = "printed",
                Year = 1966,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 151,
                EditorFirstName = "Bérangère",
                EditorLastName = "Foulsham",
                Title = null,
                Isbn = "544478387-8",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 152,
                EditorFirstName = "Léonore",
                EditorLastName = "Helm",
                Title = "Phascogale calura",
                Isbn = "510522184-2",
                Type = "printed",
                Year = 2009,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 153,
                EditorFirstName = "Amélie",
                EditorLastName = "Batting",
                Title = null,
                Isbn = "831539167-4",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 154,
                EditorFirstName = "Pélagie",
                EditorLastName = "Witling",
                Title = "Laniaurius atrococcineus",
                Isbn = "849852540-3",
                Type = "printed",
                Year = 2001,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 155,
                EditorFirstName = "Håkan",
                EditorLastName = "Craker",
                Title = "Macropus robustus",
                Isbn = "716054615-6",
                Type = "electronic",
                Year = 1985,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 156,
                EditorFirstName = "Athéna",
                EditorLastName = "Fennessy",
                Title = "Speothos vanaticus",
                Isbn = "160357385-2",
                Type = "electronic",
                Year = 2001,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 157,
                EditorFirstName = "Andréa",
                EditorLastName = "Beddow",
                Title = "Canis aureus",
                Isbn = "426323743-9",
                Type = "electronic",
                Year = 1996,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 158,
                EditorFirstName = "Björn",
                EditorLastName = "Croxton",
                Title = "Petaurus breviceps",
                Isbn = "287188366-1",
                Type = "printed",
                Year = 1995,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 159,
                EditorFirstName = "Salomé",
                EditorLastName = "Vasilic",
                Title = "Dasyurus viverrinus",
                Isbn = "503333197-3",
                Type = "printed",
                Year = 2008,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 160,
                EditorFirstName = "Ophélie",
                EditorLastName = "Pettiford",
                Title = "Ictalurus furcatus",
                Isbn = "928184925-9",
                Type = "printed",
                Year = 2008,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 161,
                EditorFirstName = "Méng",
                EditorLastName = "Hedaux",
                Title = "Ceratotherium simum",
                Isbn = "809074847-3",
                Type = "electronic",
                Year = 1996,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 162,
                EditorFirstName = "Maïté",
                EditorLastName = "McGenn",
                Title = "Melursus ursinus",
                Isbn = "678941099-6",
                Type = "electronic",
                Year = 2008,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 163,
                EditorFirstName = "Maïlys",
                EditorLastName = "McKomb",
                Title = "unavailable",
                Isbn = "783297995-X",
                Type = "electronic",
                Year = 1999,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 164,
                EditorFirstName = "Maëlyss",
                EditorLastName = "Hrishchenko",
                Title = "Larus fuliginosus",
                Isbn = "827125066-3",
                Type = "electronic",
                Year = 2012,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 165,
                EditorFirstName = "Kévina",
                EditorLastName = "Elintune",
                Title = "Nyctereutes procyono   ides",
                Isbn = "703354780-3",
                Type = "electronic",
                Year = 2011,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 166,
                EditorFirstName = "Mélissandre",
                EditorLastName = "Fateley",
                Title = "Felis silvestris lybica",
                Isbn = null,
                Type = "electronic",
                Year = 2011,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 167,
                EditorFirstName = "Marie-thérèse",
                EditorLastName = "Duval",
                Title = "Pycnonotus nigricans",
                Isbn = "207047047-4",
                Type = "electronic",
                Year = 1993,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 168,
                EditorFirstName = "Lyséa",
                EditorLastName = "Lindblom",
                Title = "Merops nubicus",
                Isbn = "967084646-3",
                Type = "printed",
                Year = 2005,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 169,
                EditorFirstName = "Tú",
                EditorLastName = null,
                Title = "Mustela nigripes",
                Isbn = "905212444-2",
                Type = "electronic",
                Year = 1997,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 170,
                EditorFirstName = "Sélène",
                EditorLastName = "Lathwood",
                Title = "Echimys chrysurus",
                Isbn = "920392372-1",
                Type = "printed",
                Year = 2006,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 171,
                EditorFirstName = "Thérèse",
                EditorLastName = "Arnaez",
                Title = "Acrobates pygmaeus",
                Isbn = "700649476-1",
                Type = "printed",
                Year = 2011,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 172,
                EditorFirstName = "Ruì",
                EditorLastName = "Huffey",
                Title = "Mazama gouazoubira",
                Isbn = "583690104-X",
                Type = "printed",
                Year = 1986,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 173,
                EditorFirstName = "Ruì",
                EditorLastName = "Sicily",
                Title = "Erinaceus frontalis",
                Isbn = "068332583-3",
                Type = "electronic",
                Year = 2011,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 174,
                EditorFirstName = "Adélie",
                EditorLastName = "Sawer",
                Title = "Parus atricapillus",
                Isbn = "779927285-6",
                Type = "electronic",
                Year = 2012,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 175,
                EditorFirstName = "Clémentine",
                EditorLastName = "Bigmore",
                Title = "Erethizon dorsatum",
                Isbn = "725792866-5",
                Type = "printed",
                Year = 2000,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 176,
                EditorFirstName = "Mélinda",
                EditorLastName = "Sturgis",
                Title = "Macaca mulatta",
                Isbn = "281577669-3",
                Type = "electronic",
                Year = 1998,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 177,
                EditorFirstName = "Marlène",
                EditorLastName = "Rominov",
                Title = "Pseudocheirus peregrinus",
                Isbn = "176482683-3",
                Type = "printed",
                Year = 1987,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 178,
                EditorFirstName = "Maï",
                EditorLastName = "Rocks",
                Title = "Mirounga leonina",
                Isbn = "390699172-5",
                Type = "electronic",
                Year = 1999,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 179,
                EditorFirstName = "Clémentine",
                EditorLastName = "Wehner",
                Title = "Zalophus californicus",
                Isbn = "991508964-3",
                Type = "electronic",
                Year = 1995,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 180,
                EditorFirstName = "Vénus",
                EditorLastName = "Pratton",
                Title = "Neotis denhami",
                Isbn = "590994816-4",
                Type = "printed",
                Year = 1994,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 181,
                EditorFirstName = "Adélie",
                EditorLastName = "Tinner",
                Title = "Orcinus orca",
                Isbn = "323845885-X",
                Type = "electronic",
                Year = 2002,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 182,
                EditorFirstName = "Stévina",
                EditorLastName = "McLanaghan",
                Title = "Bradypus tr    idactylus",
                Isbn = "507963681-5",
                Type = "electronic",
                Year = 1993,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 183,
                EditorFirstName = "Maéna",
                EditorLastName = "Cluatt",
                Title = "Mycteria leucocephala",
                Isbn = "242307213-9",
                Type = "electronic",
                Year = 2008,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 184,
                EditorFirstName = "Laurélie",
                EditorLastName = "Schustl",
                Title = "Paraxerus cepapi",
                Isbn = "019739501-5",
                Type = "electronic",
                Year = 2011,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 185,
                EditorFirstName = "Léane",
                EditorLastName = "Emanuele",
                Title = "Otaria flavescens",
                Isbn = "388554238-2",
                Type = "electronic",
                Year = 1963,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 186,
                EditorFirstName = "Frédérique",
                EditorLastName = "Nuttey",
                Title = "Bubalornis niger",
                Isbn = "218623650-8",
                Type = "electronic",
                Year = 1993,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 187,
                EditorFirstName = "Marie-thérèse",
                EditorLastName = "Pourveer",
                Title = "Leptoptilus dubius",
                Isbn = "579676426-8",
                Type = "electronic",
                Year = 1994,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 188,
                EditorFirstName = "Lyséa",
                EditorLastName = "Geockle",
                Title = "Alopochen aegyptiacus",
                Isbn = "957834173-3",
                Type = "printed",
                Year = 2008,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 189,
                EditorFirstName = "Méthode",
                EditorLastName = "Gritskov",
                Title = "Boa caninus",
                Isbn = "025032980-8",
                Type = "electronic",
                Year = 1987,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 190,
                EditorFirstName = "Styrbjörn",
                EditorLastName = "Cardello",
                Title = "Felis chaus",
                Isbn = "604494120-5",
                Type = "printed",
                Year = 1986,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 191,
                EditorFirstName = "Athéna",
                EditorLastName = "Twigger",
                Title = "Aegypius tracheliotus",
                Isbn = "647226380-9",
                Type = "electronic",
                Year = 2002,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 192,
                EditorFirstName = "Médiamass",
                EditorLastName = "Wann",
                Title = "Macropus rufus",
                Isbn = "447016334-1",
                Type = "electronic",
                Year = 2002,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 193,
                EditorFirstName = "Bérangère",
                EditorLastName = "Mitham",
                Title = "Sciurus niger",
                Isbn = "668123117-9",
                Type = "printed",
                Year = 2012,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 194,
                EditorFirstName = "Lyséa",
                EditorLastName = "Pappi",
                Title = "Rana sp.",
                Isbn = "831616307-1",
                Type = "electronic",
                Year = 1994,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 195,
                EditorFirstName = "Régine",
                EditorLastName = "Stolle",
                Title = "Spermophilus armatus",
                Isbn = "114703773-6",
                Type = "electronic",
                Year = 2007,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 196,
                EditorFirstName = "Camélia",
                EditorLastName = "Sewell",
                Title = "Nannopterum harrisi",
                Isbn = "633376325-X",
                Type = "printed",
                Year = 2003,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 197,
                EditorFirstName = "Rachèle",
                EditorLastName = "Tyrone",
                Title = "Pelecanus occ  identalis",
                Isbn = "208760693-5",
                Type = "printed",
                Year = 1986,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 198,
                EditorFirstName = "Mégane",
                EditorLastName = "Ginni",
                Title = "Geochelone elegans",
                Isbn = "831368332-5",
                Type = "printed",
                Year = 1992,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 199,
                EditorFirstName = "Mylène",
                EditorLastName = "Patesel",
                Title = "Paroaria gularis",
                Isbn = "580465160-9",
                Type = "electronic",
                Year = 2008,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 200,
                EditorFirstName = "Mahélie",
                EditorLastName = "Konneke",
                Title = "Toxostoma curvirostre",
                Isbn = "244387227-0",
                Type = "printed",
                Year = 1993,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 201,
                EditorFirstName = "Clémence",
                EditorLastName = "Tattersall",
                Title = "Larus dominicanus",
                Isbn = "095691995-2",
                Type = "electronic",
                Year = 2012,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 202,
                EditorFirstName = "Marie-hélène",
                EditorLastName = "Battram",
                Title = "Mustela nigripes",
                Isbn = "694510188-6",
                Type = "electronic",
                Year = 2004,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 203,
                EditorFirstName = "Léana",
                EditorLastName = "Halliberton",
                Title = "Pycnonotus nigricans",
                Isbn = "308994906-7",
                Type = "electronic",
                Year = 2009,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 204,
                EditorFirstName = "Régine",
                EditorLastName = "MacAllester",
                Title = "Callorhinus ursinus",
                Isbn = "794152536-4",
                Type = "electronic",
                Year = 1985,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 205,
                EditorFirstName = "Edmée",
                EditorLastName = "Laverenz",
                Title = "Paradoxurus hermaphroditus",
                Isbn = "124886953-2",
                Type = "electronic",
                Year = 2010,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 206,
                EditorFirstName = "Gérald",
                EditorLastName = "Renault",
                Title = "Francolinus coqui",
                Isbn = "970488013-8",
                Type = "electronic",
                Year = 2000,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 207,
                EditorFirstName = "Nélie",
                EditorLastName = "Jerisch",
                Title = "Cordylus giganteus",
                Isbn = "790856672-3",
                Type = "electronic",
                Year = 1992,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 208,
                EditorFirstName = "Camélia",
                EditorLastName = "Adamczyk",
                Title = "Physignathus cocincinus",
                Isbn = "593923033-4",
                Type = "electronic",
                Year = 1996,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 209,
                EditorFirstName = "Loïc",
                EditorLastName = null,
                Title = "Balearica pavonina",
                Isbn = "247271773-3",
                Type = "electronic",
                Year = 1997,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 210,
                EditorFirstName = "Lucrèce",
                EditorLastName = "Colhoun",
                Title = "Mycteria leucocephala",
                Isbn = null,
                Type = "printed",
                Year = 2001,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 211,
                EditorFirstName = "Kévina",
                EditorLastName = "Suddock",
                Title = "Pelecanus occ  identalis",
                Isbn = "230331810-6",
                Type = "electronic",
                Year = 2001,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 212,
                EditorFirstName = "Bérengère",
                EditorLastName = "McSporon",
                Title = "Ornithorhynchus anatinus",
                Isbn = "535531222-5",
                Type = "electronic",
                Year = 1995,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 213,
                EditorFirstName = "Mylène",
                EditorLastName = "Beardsley",
                Title = "Ant    idorcas marsupialis",
                Isbn = "393917851-9",
                Type = "electronic",
                Year = 2011,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 214,
                EditorFirstName = "Angèle",
                EditorLastName = "Fairleigh",
                Title = "Rana sp.",
                Isbn = "269768080-2",
                Type = "printed",
                Year = 1996,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 215,
                EditorFirstName = "Marie-ève",
                EditorLastName = "McClenaghan",
                Title = "Felis libyca",
                Isbn = "690822260-8",
                Type = "printed",
                Year = 2006,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 216,
                EditorFirstName = "Laïla",
                EditorLastName = "Leakner",
                Title = "Vulpes vulpes",
                Isbn = "806684856-0",
                Type = "printed",
                Year = 2011,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 217,
                EditorFirstName = "Andréa",
                EditorLastName = "Loos",
                Title = "Fulica cristata",
                Isbn = "775085889-X",
                Type = "printed",
                Year = 1986,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 218,
                EditorFirstName = "Daphnée",
                EditorLastName = "Spurett",
                Title = "Terrapene carolina",
                Isbn = "629120981-0",
                Type = "printed",
                Year = 1992,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 219,
                EditorFirstName = "Léonie",
                EditorLastName = "Allardyce",
                Title = "Butor  ides striatus",
                Isbn = "991683590-X",
                Type = "electronic",
                Year = 1994,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 220,
                EditorFirstName = "Thérèse",
                EditorLastName = "Drees",
                Title = "Anthropo   ides paradisea",
                Isbn = "510670112-0",
                Type = "printed",
                Year = 1990,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 221,
                EditorFirstName = "Mårten",
                EditorLastName = "O'Griffin",
                Title = "Psittacula krameri",
                Isbn = "982291722-8",
                Type = "electronic",
                Year = 1995,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 222,
                EditorFirstName = "Clélia",
                EditorLastName = "Dessaur",
                Title = "Lamprotornis nitens",
                Isbn = "830863412-5",
                Type = "printed",
                Year = 2006,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 223,
                EditorFirstName = "Eloïse",
                EditorLastName = "Lebel",
                Title = "Lamprotornis chalybaeus",
                Isbn = "671362381-6",
                Type = "printed",
                Year = 2010,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 224,
                EditorFirstName = "Aimée",
                EditorLastName = "Petronis",
                Title = "Chl    idonias leucopterus",
                Isbn = "182719094-9",
                Type = "electronic",
                Year = 1999,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 225,
                EditorFirstName = "Méryl",
                EditorLastName = "Pulster",
                Title = "Larus fuliginosus",
                Isbn = "328456253-2",
                Type = "electronic",
                Year = 2006,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 226,
                EditorFirstName = "Yè",
                EditorLastName = null,
                Title = "Nesomimus trifasciatus",
                Isbn = "531636720-0",
                Type = "electronic",
                Year = 1993,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 227,
                EditorFirstName = "Dafnée",
                EditorLastName = "Marrington",
                Title = "Haematopus ater",
                Isbn = "955858831-8",
                Type = "electronic",
                Year = 2010,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 228,
                EditorFirstName = "Estève",
                EditorLastName = "Fincher",
                Title = "Prionace glauca",
                Isbn = "578479203-2",
                Type = "printed",
                Year = 1996,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 229,
                EditorFirstName = "Cunégonde",
                EditorLastName = "Albarez",
                Title = "Sciurus vulgaris",
                Isbn = "995942272-0",
                Type = "electronic",
                Year = 2006,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 230,
                EditorFirstName = "Lauréna",
                EditorLastName = "D'Adamo",
                Title = "Halcyon smyrnesis",
                Isbn = "949445853-2",
                Type = "printed",
                Year = 2001,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 231,
                EditorFirstName = "Hélèna",
                EditorLastName = "Whillock",
                Title = "Phoca vitulina",
                Isbn = "498834278-6",
                Type = "printed",
                Year = 1991,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 232,
                EditorFirstName = "Océanne",
                EditorLastName = "Keyme",
                Title = "Semnopithecus entellus",
                Isbn = "165145990-8",
                Type = "printed",
                Year = 2005,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 233,
                EditorFirstName = "Bérengère",
                EditorLastName = "McQuilty",
                Title = "Canis lupus",
                Isbn = null,
                Type = "electronic",
                Year = 2003,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 234,
                EditorFirstName = "Séverine",
                EditorLastName = "Close",
                Title = "unavailable",
                Isbn = "551457152-1",
                Type = "printed",
                Year = 2009,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 235,
                EditorFirstName = "Loïc",
                EditorLastName = "Br    iddock",
                Title = "Mephitis mephitis",
                Isbn = "572757198-7",
                Type = "printed",
                Year = 2006,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 236,
                EditorFirstName = "Cloé",
                EditorLastName = "Saltman",
                Title = "D  idelphis virginiana",
                Isbn = "251068620-8",
                Type = "electronic",
                Year = 1991,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 237,
                EditorFirstName = "Lauréna",
                EditorLastName = "O'Callaghan",
                Title = "Tringa glareola",
                Isbn = "282755523-9",
                Type = "electronic",
                Year = 2009,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 238,
                EditorFirstName = "Personnalisée",
                EditorLastName = "Mc Giffin",
                Title = "Spizaetus coronatus",
                Isbn = "614205886-1",
                Type = "printed",
                Year = 2008,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 239,
                EditorFirstName = "Clémence",
                EditorLastName = "Cookley",
                Title = "Odocoileus hemionus",
                Isbn = "274332465-1",
                Type = "printed",
                Year = 1992,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 240,
                EditorFirstName = "Cinéma",
                EditorLastName = "Milmith",
                Title = "Colaptes campestro ides",
                Isbn = "662182269-3",
                Type = "electronic",
                Year = 2010,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 241,
                EditorFirstName = "Athéna",
                EditorLastName = "Corrie",
                Title = "Terrapene carolina",
                Isbn = "928903958-2",
                Type = "printed",
                Year = 1991,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 242,
                EditorFirstName = "Réservés",
                EditorLastName = "Buckland",
                Title = "Lutra canadensis",
                Isbn = "308883151-8",
                Type = "electronic",
                Year = 1992,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 243,
                EditorFirstName = "Océane",
                EditorLastName = "Morphey",
                Title = null,
                Isbn = "866168476-5",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 244,
                EditorFirstName = "Lén",
                EditorLastName = "Perkins",
                Title = "Diomedea irrorata",
                Isbn = "424008155-6",
                Type = "printed",
                Year = 2008,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 245,
                EditorFirstName = "Sòng",
                EditorLastName = null,
                Title = "Hymenolaimus malacorhynchus",
                Isbn = null,
                Type = "electronic",
                Year = 2009,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 246,
                EditorFirstName = "Nélie",
                EditorLastName = "Capper",
                Title = "Phascolarctos cinereus",
                Isbn = "716336707-4",
                Type = "electronic",
                Year = 1994,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 247,
                EditorFirstName = "Gérald",
                EditorLastName = "Valens-Smith",
                Title = "Pelecans onocratalus",
                Isbn = "859600189-1",
                Type = "printed",
                Year = 1999,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 248,
                EditorFirstName = "Angèle",
                EditorLastName = "Ferreira",
                Title = "Lorythaixo ides concolor",
                Isbn = "360129443-5",
                Type = "printed",
                Year = 2005,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 249,
                EditorFirstName = "Thérèse",
                EditorLastName = "Baskeyfied",
                Title = "Haematopus ater",
                Isbn = "067580788-3",
                Type = "printed",
                Year = 2011,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 250,
                EditorFirstName = "Ruò",
                EditorLastName = "Glanders",
                Title = "Coluber constrictor foxii",
                Isbn = "707239892-9",
                Type = "printed",
                Year = 2008,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 251,
                EditorFirstName = "Estée",
                EditorLastName = "Yankeev",
                Title = "Paroaria gularis",
                Isbn = "890107013-8",
                Type = "electronic",
                Year = 2005,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 252,
                EditorFirstName = "Léonie",
                EditorLastName = "Veelers",
                Title = "Aegypius occipitalis",
                Isbn = "874308727-2",
                Type = "electronic",
                Year = 1997,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 253,
                EditorFirstName = "Andrée",
                EditorLastName = "Venturoli",
                Title = "Charadrius tricollaris",
                Isbn = "193933077-7",
                Type = "printed",
                Year = 2001,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 254,
                EditorFirstName = "Lóng",
                EditorLastName = "Columbine",
                Title = "Felis silvestris lybica",
                Isbn = "523331086-4",
                Type = "printed",
                Year = 1990,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 255,
                EditorFirstName = "Lyséa",
                EditorLastName = "Pavier",
                Title = "Nyctea scandiaca",
                Isbn = "059750480-6",
                Type = "electronic",
                Year = 1993,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 256,
                EditorFirstName = "Sòng",
                EditorLastName = "Melby",
                Title = "Paradoxurus hermaphroditus",
                Isbn = "009720089-1",
                Type = "printed",
                Year = 2005,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 257,
                EditorFirstName = "Vérane",
                EditorLastName = null,
                Title = "Scolopax minor",
                Isbn = "312807114-4",
                Type = "printed",
                Year = 2004,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 258,
                EditorFirstName = "Göran",
                EditorLastName = "Carwithim",
                Title = "Cynictis penicillata",
                Isbn = "917805427-3",
                Type = "printed",
                Year = 2004,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 259,
                EditorFirstName = "Andréanne",
                EditorLastName = "Hickisson",
                Title = "Ictalurus furcatus",
                Isbn = "887051210-X",
                Type = "electronic",
                Year = 1996,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 260,
                EditorFirstName = "Örjan",
                EditorLastName = "Wickliffe",
                Title = "Larus fuliginosus",
                Isbn = "288273465-4",
                Type = "electronic",
                Year = 2007,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 261,
                EditorFirstName = "Miléna",
                EditorLastName = "Robecon",
                Title = "Chl    idonias leucopterus",
                Isbn = "665278752-0",
                Type = "printed",
                Year = 2002,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 262,
                EditorFirstName = "Léane",
                EditorLastName = "Egalton",
                Title = "Macaca mulatta",
                Isbn = "949247142-6",
                Type = "printed",
                Year = 2012,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 263,
                EditorFirstName = "Loïs",
                EditorLastName = "Nand",
                Title = "Pelecans onocratalus",
                Isbn = "149054054-7",
                Type = "electronic",
                Year = 1984,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 264,
                EditorFirstName = "Lóng",
                EditorLastName = "Lille",
                Title = "Macropus rufogriseus",
                Isbn = "127755803-5",
                Type = "electronic",
                Year = 1992,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 265,
                EditorFirstName = "Méng",
                EditorLastName = "Lovering",
                Title = "Paroaria gularis",
                Isbn = "434329360-2",
                Type = "electronic",
                Year = 2005,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 266,
                EditorFirstName = "Mélissandre",
                EditorLastName = "Kellie",
                Title = "Chlamydosaurus kingii",
                Isbn = "598334402-1",
                Type = "electronic",
                Year = 2008,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 267,
                EditorFirstName = "Åslög",
                EditorLastName = null,
                Title = "Pteronura brasiliensis",
                Isbn = "344104644-7",
                Type = "printed",
                Year = 1992,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 268,
                EditorFirstName = "Eliès",
                EditorLastName = "Cussen",
                Title = "Crotalus cerastes",
                Isbn = "676578299-0",
                Type = "printed",
                Year = 2011,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 269,
                EditorFirstName = "Gérald",
                EditorLastName = "Kleinbaum",
                Title = "Acrobates pygmaeus",
                Isbn = "554318810-2",
                Type = "printed",
                Year = 1995,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 270,
                EditorFirstName = "Örjan",
                EditorLastName = "Avery",
                Title = "Canis mesomelas",
                Isbn = "719882840-X",
                Type = "printed",
                Year = 1998,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 271,
                EditorFirstName = "Dorothée",
                EditorLastName = "Watling",
                Title = "Anas punctata",
                Isbn = "900956256-5",
                Type = "electronic",
                Year = 1999,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 272,
                EditorFirstName = "Lorène",
                EditorLastName = "MacTerrelly",
                Title = "Trichoglossus haematodus moluccanus",
                Isbn = "817318468-2",
                Type = "printed",
                Year = 1989,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 273,
                EditorFirstName = "Alizée",
                EditorLastName = null,
                Title = "Canis aureus",
                Isbn = "566279060-4",
                Type = "printed",
                Year = 2002,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 274,
                EditorFirstName = "Michèle",
                EditorLastName = "Borth",
                Title = "Trichoglossus chlorolep    idotus",
                Isbn = null,
                Type = "printed",
                Year = 1989,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 275,
                EditorFirstName = "Marie-josée",
                EditorLastName = "Fevier",
                Title = "Butor  ides striatus",
                Isbn = "213110370-0",
                Type = "printed",
                Year = 2010,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 276,
                EditorFirstName = "Maïté",
                EditorLastName = "Trunkfield",
                Title = "Eunectes sp.",
                Isbn = "698806518-0",
                Type = "electronic",
                Year = 1995,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 277,
                EditorFirstName = "Béatrice",
                EditorLastName = "McSporrin",
                Title = "Redunca redunca",
                Isbn = "775510235-1",
                Type = "printed",
                Year = 2004,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 278,
                EditorFirstName = "Naéva",
                EditorLastName = "Janusik",
                Title = "Chauna torquata",
                Isbn = "806548970-2",
                Type = "electronic",
                Year = 1993,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 279,
                EditorFirstName = "André",
                EditorLastName = null,
                Title = "Ictonyx striatus",
                Isbn = "114529794-3",
                Type = "electronic",
                Year = 1999,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 280,
                EditorFirstName = "Mahélie",
                EditorLastName = "Bretelle",
                Title = "Phoca vitulina",
                Isbn = "977331229-1",
                Type = "electronic",
                Year = 1995,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 281,
                EditorFirstName = "Gaëlle",
                EditorLastName = "Thew",
                Title = "Ammospermophilus nelsoni",
                Isbn = "900244758-2",
                Type = "printed",
                Year = 1992,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 282,
                EditorFirstName = "Cécile",
                EditorLastName = "O'Carney",
                Title = "Meles meles",
                Isbn = "966530273-6",
                Type = "electronic",
                Year = 2003,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 283,
                EditorFirstName = "Françoise",
                EditorLastName = "Strotton",
                Title = "Melophus lathami",
                Isbn = "138655381-6",
                Type = "printed",
                Year = 2000,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 284,
                EditorFirstName = "Solène",
                EditorLastName = "Caddies",
                Title = "Trichosurus vulpecula",
                Isbn = "249525060-2",
                Type = "electronic",
                Year = 2008,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 285,
                EditorFirstName = "Mélanie",
                EditorLastName = "Rosendall",
                Title = "Acrantophis madagascariensis",
                Isbn = "802131918-6",
                Type = "printed",
                Year = 2005,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 286,
                EditorFirstName = "Thérèsa",
                EditorLastName = "Gethins",
                Title = "Cervus duvauceli",
                Isbn = "860200967-4",
                Type = "printed",
                Year = 1999,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 287,
                EditorFirstName = "Alizée",
                EditorLastName = "Dottr idge",
                Title = "Tamiasciurus hudsonicus",
                Isbn = "457970473-8",
                Type = "electronic",
                Year = 1989,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 288,
                EditorFirstName = "Maïté",
                EditorLastName = "Mulcaster",
                Title = "Pseudalopex gymnocercus",
                Isbn = "192589875-X",
                Type = "electronic",
                Year = 2001,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 289,
                EditorFirstName = "Dù",
                EditorLastName = null,
                Title = "Ardea cinerea",
                Isbn = "449464880-9",
                Type = "printed",
                Year = 1991,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 290,
                EditorFirstName = "Mà",
                EditorLastName = "McCue",
                Title = "Aegypius occipitalis",
                Isbn = "027550844-7",
                Type = "electronic",
                Year = 1998,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 291,
                EditorFirstName = "Lài",
                EditorLastName = null,
                Title = "Cervus canadensis",
                Isbn = "639361579-6",
                Type = "electronic",
                Year = 2012,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 292,
                EditorFirstName = "Estève",
                EditorLastName = "Kalderon",
                Title = "unavailable",
                Isbn = "062007958-4",
                Type = "printed",
                Year = 1996,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 293,
                EditorFirstName = "Anaël",
                EditorLastName = "Matteris",
                Title = "Ceratotherium simum",
                Isbn = "724045217-4",
                Type = "printed",
                Year = 1993,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 294,
                EditorFirstName = "Lóng",
                EditorLastName = "Kilian",
                Title = "Pituophis melanaleucus",
                Isbn = "703003031-1",
                Type = "printed",
                Year = 1988,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 295,
                EditorFirstName = "Mélina",
                EditorLastName = "Bail",
                Title = "Certotrichas paena",
                Isbn = "875618383-6",
                Type = "printed",
                Year = 2011,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 296,
                EditorFirstName = "Réservés",
                EditorLastName = "Dumberell",
                Title = "Mirounga leonina",
                Isbn = "768284807-3",
                Type = "printed",
                Year = 1997,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 297,
                EditorFirstName = "Åsa",
                EditorLastName = "Castard",
                Title = "Sarcorhamphus papa",
                Isbn = "841205443-1",
                Type = "printed",
                Year = 1986,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 298,
                EditorFirstName = "Esbjörn",
                EditorLastName = "Boss",
                Title = "Cercopithecus aethiops",
                Isbn = "758175238-0",
                Type = "electronic",
                Year = 1999,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 299,
                EditorFirstName = "Lucrèce",
                EditorLastName = "Norval",
                Title = "Colaptes campestro ides",
                Isbn = "463157773-8",
                Type = "electronic",
                Year = 2005,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 300,
                EditorFirstName = "Mylène",
                EditorLastName = "Boss",
                Title = "Macropus robustus",
                Isbn = "959163095-6",
                Type = "electronic",
                Year = 2012,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 301,
                EditorFirstName = "Yáo",
                EditorLastName = "Sacaze",
                Title = "Creagrus furcatus",
                Isbn = "746668702-4",
                Type = "electronic",
                Year = 1996,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 302,
                EditorFirstName = "Noëlla",
                EditorLastName = "Cranston",
                Title = "Herpestes javanicus",
                Isbn = "471682614-7",
                Type = "printed",
                Year = 2011,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 303,
                EditorFirstName = "Camélia",
                EditorLastName = "Mulryan",
                Title = "Nyctereutes procyono   ides",
                Isbn = "009629198-2",
                Type = "electronic",
                Year = 2007,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 304,
                EditorFirstName = "Rébecca",
                EditorLastName = "Cacacie",
                Title = "Aonyx capensis",
                Isbn = "828324822-7",
                Type = "electronic",
                Year = 2011,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 305,
                EditorFirstName = "Inès",
                EditorLastName = "Gatlin",
                Title = "Macropus agilis",
                Isbn = "629562289-5",
                Type = "printed",
                Year = 2008,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 306,
                EditorFirstName = "Lorène",
                EditorLastName = "Sleep",
                Title = "Himantopus himantopus",
                Isbn = "524230469-3",
                Type = "electronic",
                Year = 1994,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 307,
                EditorFirstName = "Yóu",
                EditorLastName = "Jablonski",
                Title = "Trichoglossus haematodus moluccanus",
                Isbn = "017766787-7",
                Type = "electronic",
                Year = 1993,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 308,
                EditorFirstName = "Gérald",
                EditorLastName = "Ionn  idis",
                Title = "Paroaria gularis",
                Isbn = "681300940-0",
                Type = "printed",
                Year = 2007,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 309,
                EditorFirstName = "Mélina",
                EditorLastName = "Semens",
                Title = "Eunectes sp.",
                Isbn = "190634151-6",
                Type = "printed",
                Year = 1988,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 310,
                EditorFirstName = "Séverine",
                EditorLastName = "Redish",
                Title = "Giraffe camelopardalis",
                Isbn = "851347391-X",
                Type = "electronic",
                Year = 2003,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 311,
                EditorFirstName = "Tán",
                EditorLastName = "Cornier",
                Title = "Madoqua kirkii",
                Isbn = "284173080-8",
                Type = "printed",
                Year = 2004,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 312,
                EditorFirstName = "Cécilia",
                EditorLastName = "Sivill",
                Title = "Naja haje",
                Isbn = "998001546-2",
                Type = "electronic",
                Year = 1997,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 313,
                EditorFirstName = "Mélinda",
                EditorLastName = "Cordrey",
                Title = "Nesomimus trifasciatus",
                Isbn = "022738192-0",
                Type = "electronic",
                Year = 2007,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 314,
                EditorFirstName = "Méng",
                EditorLastName = "Welsh",
                Title = "Stercorarius longicausus",
                Isbn = "552804956-3",
                Type = "electronic",
                Year = 1999,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 315,
                EditorFirstName = "Eléonore",
                EditorLastName = "Ring",
                Title = "Ara macao",
                Isbn = "117053507-0",
                Type = "electronic",
                Year = 1992,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 316,
                EditorFirstName = "Noémie",
                EditorLastName = "Hastwall",
                Title = "Trachyphonus vaillantii",
                Isbn = "012592393-7",
                Type = "printed",
                Year = 2006,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 317,
                EditorFirstName = "Andréanne",
                EditorLastName = "O'Kennavain",
                Title = "Columba palumbus",
                Isbn = "940280765-9",
                Type = "electronic",
                Year = 2010,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 318,
                EditorFirstName = "Kévina",
                EditorLastName = "Lock",
                Title = "Felis silvestris lybica",
                Isbn = "551093286-4",
                Type = "electronic",
                Year = 2007,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 319,
                EditorFirstName = "Annotée",
                EditorLastName = "Campey",
                Title = "Spermophilus armatus",
                Isbn = "030088249-1",
                Type = "printed",
                Year = 1997,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 320,
                EditorFirstName = "Bécassine",
                EditorLastName = "Verna",
                Title = "Antechinus flavipes",
                Isbn = "328048026-4",
                Type = "electronic",
                Year = 2008,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 321,
                EditorFirstName = "Jú",
                EditorLastName = "Shank",
                Title = "Rangifer tarandus",
                Isbn = null,
                Type = "electronic",
                Year = 2009,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 322,
                EditorFirstName = "Håkan",
                EditorLastName = "Mariot",
                Title = "Geochelone elegans",
                Isbn = "243870457-8",
                Type = "printed",
                Year = 1988,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 323,
                EditorFirstName = "Méghane",
                EditorLastName = "Filimore",
                Title = "Eubalaena australis",
                Isbn = "655065475-0",
                Type = "printed",
                Year = 1993,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 324,
                EditorFirstName = "Marlène",
                EditorLastName = "Leahy",
                Title = "Spilogale gracilis",
                Isbn = "512506362-2",
                Type = "printed",
                Year = 1996,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 325,
                EditorFirstName = "Desirée",
                EditorLastName = "Birtwisle",
                Title = "Paraxerus cepapi",
                Isbn = "235232487-4",
                Type = "printed",
                Year = 2008,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 326,
                EditorFirstName = "Maëlann",
                EditorLastName = "Ozintsev",
                Title = "Choloepus hoffmani",
                Isbn = "343811505-0",
                Type = "electronic",
                Year = 1994,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 327,
                EditorFirstName = "Cloé",
                EditorLastName = "Tither",
                Title = "Ctenophorus ornatus",
                Isbn = "167312918-8",
                Type = "electronic",
                Year = 2006,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 328,
                EditorFirstName = "Lorène",
                EditorLastName = null,
                Title = "Eutamias minimus",
                Isbn = "640417235-6",
                Type = "electronic",
                Year = 2002,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 329,
                EditorFirstName = "Pål",
                EditorLastName = "Denge",
                Title = "Ephipplorhynchus senegalensis",
                Isbn = "687792171-2",
                Type = "electronic",
                Year = 2002,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 330,
                EditorFirstName = "Méline",
                EditorLastName = "Ingold",
                Title = "Cynictis penicillata",
                Isbn = "485046783-0",
                Type = "printed",
                Year = 2011,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 331,
                EditorFirstName = "Yè",
                EditorLastName = "Mohammed",
                Title = "Pseudalopex gymnocercus",
                Isbn = "664045202-2",
                Type = "printed",
                Year = 2002,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 332,
                EditorFirstName = "Andrée",
                EditorLastName = "Pauncefoot",
                Title = "Galago crassicaudataus",
                Isbn = "459327165-7",
                Type = "electronic",
                Year = 2001,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 333,
                EditorFirstName = "Vénus",
                EditorLastName = "Pinkie",
                Title = "Bassariscus astutus",
                Isbn = "113602538-3",
                Type = "printed",
                Year = 2003,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 334,
                EditorFirstName = "Aloïs",
                EditorLastName = null,
                Title = "Ursus arctos",
                Isbn = "477230955-1",
                Type = "printed",
                Year = 1994,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 335,
                EditorFirstName = "Yóu",
                EditorLastName = "Lowdiane",
                Title = "Cynictis penicillata",
                Isbn = "085456571-X",
                Type = "electronic",
                Year = 1993,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 336,
                EditorFirstName = "Almérinda",
                EditorLastName = "Edgington",
                Title = "Chauna torquata",
                Isbn = "398812283-1",
                Type = "printed",
                Year = 2003,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 337,
                EditorFirstName = "Nélie",
                EditorLastName = "Blackwell",
                Title = "Ursus americanus",
                Isbn = "575215480-4",
                Type = "electronic",
                Year = 1990,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 338,
                EditorFirstName = "Andrée",
                EditorLastName = "Stigell",
                Title = "Cebus apella",
                Isbn = "332239425-5",
                Type = "printed",
                Year = 2011,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 339,
                EditorFirstName = "Josée",
                EditorLastName = "Cade",
                Title = "Cereopsis novaehollandiae",
                Isbn = "396815461-4",
                Type = "printed",
                Year = 1996,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 340,
                EditorFirstName = "Gaëlle",
                EditorLastName = "Readman",
                Title = "Phalacrocorax niger",
                Isbn = "291659131-1",
                Type = "electronic",
                Year = 1998,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 341,
                EditorFirstName = "Yè",
                EditorLastName = "Pasque",
                Title = "Laniarius ferrugineus",
                Isbn = "576935777-0",
                Type = "printed",
                Year = 2004,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 342,
                EditorFirstName = "Maëly",
                EditorLastName = "Hayter",
                Title = "Chauna torquata",
                Isbn = "061462494-0",
                Type = "electronic",
                Year = 1967,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 343,
                EditorFirstName = "Valérie",
                EditorLastName = null,
                Title = "unavailable",
                Isbn = "651570367-8",
                Type = "printed",
                Year = 2008,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 344,
                EditorFirstName = "Fèi",
                EditorLastName = "Chesters",
                Title = "Phalacrocorax carbo",
                Isbn = "754488733-2",
                Type = "printed",
                Year = 1986,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 345,
                EditorFirstName = "Laurène",
                EditorLastName = "Candlin",
                Title = "Pelecanus occ  identalis",
                Isbn = "626536736-6",
                Type = "electronic",
                Year = 2010,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 346,
                EditorFirstName = "Marie-noël",
                EditorLastName = null,
                Title = "Cervus duvauceli",
                Isbn = "377387729-3",
                Type = "electronic",
                Year = 2002,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 347,
                EditorFirstName = "Illustrée",
                EditorLastName = "Esch",
                Title = "Centrocercus urophasianus",
                Isbn = "811499531-9",
                Type = "printed",
                Year = 2008,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 348,
                EditorFirstName = "Marie-hélène",
                EditorLastName = "McWhin",
                Title = "Physignathus cocincinus",
                Isbn = "780943841-7",
                Type = "electronic",
                Year = 1992,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 349,
                EditorFirstName = "Mélodie",
                EditorLastName = "Baudasso",
                Title = "Psittacula krameri",
                Isbn = "999483305-7",
                Type = "electronic",
                Year = 1987,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 350,
                EditorFirstName = "Bécassine",
                EditorLastName = "Errichi",
                Title = "Anastomus oscitans",
                Isbn = "956916933-8",
                Type = "electronic",
                Year = 2003,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 351,
                EditorFirstName = "Gaëlle",
                EditorLastName = "K idsley",
                Title = "Bison bison",
                Isbn = "613715076-3",
                Type = "electronic",
                Year = 2002,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 352,
                EditorFirstName = "Illustrée",
                EditorLastName = "Greatbank",
                Title = "Ant    idorcas marsupialis",
                Isbn = "192509670-X",
                Type = "printed",
                Year = 2012,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 353,
                EditorFirstName = "Geneviève",
                EditorLastName = "Fermoy",
                Title = "Branta canadensis",
                Isbn = "046502959-0",
                Type = "electronic",
                Year = 2004,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 354,
                EditorFirstName = "Jú",
                EditorLastName = "Mc Derm   id",
                Title = "Oxybelis sp.",
                Isbn = "487986009-3",
                Type = "electronic",
                Year = 2003,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 355,
                EditorFirstName = "Cloé",
                EditorLastName = "Hargroves",
                Title = "Aquila chrysaetos",
                Isbn = "668908677-1",
                Type = "printed",
                Year = 2009,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 356,
                EditorFirstName = "Eliès",
                EditorLastName = "Morden",
                Title = "Sark   idornis melanotos",
                Isbn = "535315136-4",
                Type = "printed",
                Year = 2001,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 357,
                EditorFirstName = "Kallisté",
                EditorLastName = "Glasper",
                Title = "Cebus apella",
                Isbn = "729088389-6",
                Type = "electronic",
                Year = 1993,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 358,
                EditorFirstName = "Pélagie",
                EditorLastName = "Monan",
                Title = "Phalacrocorax carbo",
                Isbn = "348456982-4",
                Type = "electronic",
                Year = 2002,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 359,
                EditorFirstName = "Gérald",
                EditorLastName = "Alejandro",
                Title = "Ciconia ciconia",
                Isbn = null,
                Type = "printed",
                Year = 1996,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 360,
                EditorFirstName = "Cléa",
                EditorLastName = null,
                Title = "Diomedea irrorata",
                Isbn = "452170794-7",
                Type = "printed",
                Year = 2012,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 361,
                EditorFirstName = "Clémentine",
                EditorLastName = "Fieller",
                Title = null,
                Isbn = "117639861-X",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 362,
                EditorFirstName = "Cécile",
                EditorLastName = "Gregory",
                Title = "Columba livia",
                Isbn = "832559317-2",
                Type = "printed",
                Year = 2002,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 363,
                EditorFirstName = "Réservés",
                EditorLastName = "Futter",
                Title = "Chauna torquata",
                Isbn = "520763789-4",
                Type = "electronic",
                Year = 2001,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 364,
                EditorFirstName = "Annotée",
                EditorLastName = "Jeremaes",
                Title = "unavailable",
                Isbn = "998707230-5",
                Type = "electronic",
                Year = 2013,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 365,
                EditorFirstName = "Maïwenn",
                EditorLastName = "Wasbrough",
                Title = "Haliaetus leucogaster",
                Isbn = "052864298-7",
                Type = "electronic",
                Year = 2000,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 366,
                EditorFirstName = "Danièle",
                EditorLastName = "Gelder",
                Title = "Dendrocitta vagabunda",
                Isbn = "662479973-0",
                Type = "electronic",
                Year = 2003,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 367,
                EditorFirstName = "Zhì",
                EditorLastName = "Bragger",
                Title = "Cacatua tenuirostris",
                Isbn = "442930160-3",
                Type = "printed",
                Year = 2008,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 368,
                EditorFirstName = "Léone",
                EditorLastName = "Cunnow",
                Title = "Ovis ammon",
                Isbn = "702306214-9",
                Type = "electronic",
                Year = 2008,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 369,
                EditorFirstName = "Gaïa",
                EditorLastName = "Bootton",
                Title = "Pandon haliaetus",
                Isbn = "980157320-1",
                Type = "electronic",
                Year = 2004,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 370,
                EditorFirstName = "Yáo",
                EditorLastName = "Preene",
                Title = "Phalaropus lobatus",
                Isbn = "002787480-X",
                Type = "printed",
                Year = 2004,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 371,
                EditorFirstName = "Bécassine",
                EditorLastName = "Aspel",
                Title = "Ovis ammon",
                Isbn = "554303268-4",
                Type = "printed",
                Year = 2009,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 372,
                EditorFirstName = "Chloé",
                EditorLastName = "Corsan",
                Title = "Platalea leucordia",
                Isbn = "326770094-9",
                Type = "printed",
                Year = 1996,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 373,
                EditorFirstName = "Régine",
                EditorLastName = "Elner",
                Title = "Ctenophorus ornatus",
                Isbn = "691068847-3",
                Type = "printed",
                Year = 1987,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 374,
                EditorFirstName = "Gérald",
                EditorLastName = "Gofforth",
                Title = "Canis aureus",
                Isbn = "803805044-4",
                Type = "electronic",
                Year = 2002,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 375,
                EditorFirstName = "Anaël",
                EditorLastName = "Haslen",
                Title = "Haliaetus vocifer",
                Isbn = "129799374-8",
                Type = "electronic",
                Year = 2005,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 376,
                EditorFirstName = "Marie-françoise",
                EditorLastName = "Petriello",
                Title = "Dicrostonyx groenlandicus",
                Isbn = "977737112-8",
                Type = "electronic",
                Year = 1993,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 377,
                EditorFirstName = "Pélagie",
                EditorLastName = "Rawlison",
                Title = "Echimys chrysurus",
                Isbn = "300182517-0",
                Type = "printed",
                Year = 1968,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 378,
                EditorFirstName = "Célestine",
                EditorLastName = "Hamblen",
                Title = "Platalea leucordia",
                Isbn = "349354109-0",
                Type = "electronic",
                Year = 2000,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 379,
                EditorFirstName = "Salomé",
                EditorLastName = "Metham",
                Title = "Tursiops truncatus",
                Isbn = "439823678-3",
                Type = "printed",
                Year = 1986,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 380,
                EditorFirstName = "Françoise",
                EditorLastName = "Vettore",
                Title = "Psophia vir    idis",
                Isbn = "459651115-2",
                Type = "printed",
                Year = 2002,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 381,
                EditorFirstName = "Pål",
                EditorLastName = "Mayer",
                Title = "Larus fuliginosus",
                Isbn = "381700501-6",
                Type = "printed",
                Year = 1986,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 382,
                EditorFirstName = "Gérald",
                EditorLastName = "Kyles",
                Title = "Canis mesomelas",
                Isbn = "680984298-5",
                Type = "printed",
                Year = 1994,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 383,
                EditorFirstName = "Méthode",
                EditorLastName = "Haswall",
                Title = "Buteo galapagoensis",
                Isbn = "938581686-1",
                Type = "printed",
                Year = 1995,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 384,
                EditorFirstName = "Gaïa",
                EditorLastName = "Mitie",
                Title = "Sterna paradisaea",
                Isbn = "480407781-2",
                Type = "printed",
                Year = 1994,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 385,
                EditorFirstName = "Léana",
                EditorLastName = "Aulsford",
                Title = "Vulpes chama",
                Isbn = "058630956-X",
                Type = "electronic",
                Year = 1998,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 386,
                EditorFirstName = "Réservés",
                EditorLastName = "Lakeman",
                Title = "Cordylus giganteus",
                Isbn = "115333570-0",
                Type = "printed",
                Year = 1989,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 387,
                EditorFirstName = "Mårten",
                EditorLastName = "Mounsey",
                Title = "Phylurus milli",
                Isbn = "731416059-7",
                Type = "electronic",
                Year = 1988,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 388,
                EditorFirstName = "Anaël",
                EditorLastName = "Londing",
                Title = "Cervus duvauceli",
                Isbn = "610083968-7",
                Type = "printed",
                Year = 2011,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 389,
                EditorFirstName = "Clémence",
                EditorLastName = "Roe",
                Title = "Chordeiles minor",
                Isbn = "780925367-0",
                Type = "printed",
                Year = 2008,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 390,
                EditorFirstName = "Måns",
                EditorLastName = "Randlesome",
                Title = "Phalacrocorax varius",
                Isbn = "683917071-3",
                Type = "printed",
                Year = 2005,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 391,
                EditorFirstName = "Cunégonde",
                EditorLastName = "Jaquest",
                Title = "Marmota caligata",
                Isbn = "096410335-4",
                Type = "printed",
                Year = 2001,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 392,
                EditorFirstName = "Börje",
                EditorLastName = "Perett",
                Title = "Grus antigone",
                Isbn = "379233763-0",
                Type = "printed",
                Year = 2005,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 393,
                EditorFirstName = "Célia",
                EditorLastName = "Landeaux",
                Title = "Loxodonta africana",
                Isbn = "893720889-X",
                Type = "printed",
                Year = 2009,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 394,
                EditorFirstName = "Mårten",
                EditorLastName = "Surgen",
                Title = "Manouria emys",
                Isbn = "430920022-2",
                Type = "printed",
                Year = 2007,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 395,
                EditorFirstName = "Pål",
                EditorLastName = "Truce",
                Title = "Dendrocitta vagabunda",
                Isbn = "965363253-1",
                Type = "electronic",
                Year = 1965,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 396,
                EditorFirstName = "Mà",
                EditorLastName = "Beedle",
                Title = "Rhea americana",
                Isbn = "044878396-7",
                Type = "electronic",
                Year = 1998,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 397,
                EditorFirstName = "Andrée",
                EditorLastName = "Jorg",
                Title = "Estrilda erythronotos",
                Isbn = "516803261-3",
                Type = "printed",
                Year = 2007,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 398,
                EditorFirstName = "Maëlys",
                EditorLastName = "Reany",
                Title = "Manouria emys",
                Isbn = "734140232-6",
                Type = "printed",
                Year = 2010,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 399,
                EditorFirstName = "Béatrice",
                EditorLastName = "Zollner",
                Title = "Pelecanus conspicillatus",
                Isbn = "163056747-7",
                Type = "electronic",
                Year = 2006,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 400,
                EditorFirstName = "Noémie",
                EditorLastName = "Zorn",
                Title = "Felis wiedi or Leopardus we    idi",
                Isbn = "556166715-7",
                Type = "printed",
                Year = 1992,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 401,
                EditorFirstName = "Estée",
                EditorLastName = "Wabersich",
                Title = "Merops bullocko    ides",
                Isbn = "831187347-X",
                Type = "electronic",
                Year = 2007,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 402,
                EditorFirstName = "Géraldine",
                EditorLastName = "Cathery",
                Title = "Coendou prehensilis",
                Isbn = "584771869-1",
                Type = "electronic",
                Year = 1994,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 403,
                EditorFirstName = "Rachèle",
                EditorLastName = null,
                Title = "Oreamnos americanus",
                Isbn = "291234996-6",
                Type = "printed",
                Year = 2012,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 404,
                EditorFirstName = "Simplifiés",
                EditorLastName = "Harbottle",
                Title = "Megaderma spasma",
                Isbn = "060305517-6",
                Type = "electronic",
                Year = 1999,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 405,
                EditorFirstName = "Kù",
                EditorLastName = "Heaselgrave",
                Title = "Phoca vitulina",
                Isbn = "268480639-X",
                Type = "electronic",
                Year = 2002,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 406,
                EditorFirstName = "Hélène",
                EditorLastName = "Trendle",
                Title = "Anser anser",
                Isbn = "023818206-1",
                Type = "electronic",
                Year = 1981,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 407,
                EditorFirstName = "Andréanne",
                EditorLastName = "Shillinglaw",
                Title = "Bradypus tr    idactylus",
                Isbn = "483910939-7",
                Type = "printed",
                Year = 2007,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 408,
                EditorFirstName = "Mélanie",
                EditorLastName = "Gosswell",
                Title = "Macaca fuscata",
                Isbn = "300829021-3",
                Type = "electronic",
                Year = 2012,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 409,
                EditorFirstName = "Aurélie",
                EditorLastName = "Ison",
                Title = "Felis chaus",
                Isbn = "742592874-4",
                Type = "electronic",
                Year = 2008,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 410,
                EditorFirstName = "Mégane",
                EditorLastName = "McGarel",
                Title = "Laniaurius atrococcineus",
                Isbn = "593720507-3",
                Type = "electronic",
                Year = 2009,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 411,
                EditorFirstName = "Judicaël",
                EditorLastName = "Stancer",
                Title = "Zosterops pall idus",
                Isbn = "842496086-6",
                Type = "printed",
                Year = 1998,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 412,
                EditorFirstName = "Frédérique",
                EditorLastName = "Look",
                Title = "Sylvilagus flor    idanus",
                Isbn = "570032804-6",
                Type = "printed",
                Year = 1999,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 413,
                EditorFirstName = "Loïs",
                EditorLastName = "Spenceley",
                Title = "Madoqua kirkii",
                Isbn = "493875557-2",
                Type = "printed",
                Year = 1989,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 414,
                EditorFirstName = "Chloé",
                EditorLastName = "Rainger",
                Title = "Cochlearius cochlearius",
                Isbn = "211983114-9",
                Type = "printed",
                Year = 1989,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 415,
                EditorFirstName = "Annotée",
                EditorLastName = "Strodder",
                Title = "Tockus erythrorhyncus",
                Isbn = "663179880-9",
                Type = "printed",
                Year = 1990,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 416,
                EditorFirstName = "Mylène",
                EditorLastName = "Verny",
                Title = "Corvus albicollis",
                Isbn = "011393234-0",
                Type = "electronic",
                Year = 1996,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 417,
                EditorFirstName = "Ráo",
                EditorLastName = "Swine",
                Title = "Pteropus rufus",
                Isbn = "063465400-4",
                Type = "printed",
                Year = 2004,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 418,
                EditorFirstName = "Fèi",
                EditorLastName = null,
                Title = "Otocyon megalotis",
                Isbn = "666113393-7",
                Type = "printed",
                Year = 1998,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 419,
                EditorFirstName = "Åsa",
                EditorLastName = "Dumbleton",
                Title = "Spheniscus magellanicus",
                Isbn = null,
                Type = "printed",
                Year = 1997,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 420,
                EditorFirstName = "Gaétane",
                EditorLastName = null,
                Title = "Microcebus murinus",
                Isbn = "928159258-4",
                Type = "electronic",
                Year = 2004,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 421,
                EditorFirstName = "Danièle",
                EditorLastName = "Drejer",
                Title = "Coluber constrictor",
                Isbn = "300972047-5",
                Type = "printed",
                Year = 1965,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 422,
                EditorFirstName = "Cléa",
                EditorLastName = "Collaton",
                Title = "Tyto novaehollandiae",
                Isbn = "312315603-6",
                Type = "printed",
                Year = 1986,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 423,
                EditorFirstName = "Adèle",
                EditorLastName = "Busen",
                Title = "Larus dominicanus",
                Isbn = "022047472-9",
                Type = "electronic",
                Year = 2003,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 424,
                EditorFirstName = "Michèle",
                EditorLastName = "Worthington",
                Title = "Alopex lagopus",
                Isbn = "799588559-8",
                Type = "electronic",
                Year = 2002,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 425,
                EditorFirstName = "Noëlla",
                EditorLastName = "Mattussevich",
                Title = "Aegypius tracheliotus",
                Isbn = "443588227-2",
                Type = "electronic",
                Year = 2005,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 426,
                EditorFirstName = "Françoise",
                EditorLastName = "Saunderson",
                Title = "Gabianus pacificus",
                Isbn = "255013439-7",
                Type = "electronic",
                Year = 2001,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 427,
                EditorFirstName = "Dorothée",
                EditorLastName = "Nudds",
                Title = "Varanus albigularis",
                Isbn = "816484896-4",
                Type = "electronic",
                Year = 2003,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 428,
                EditorFirstName = "Chloé",
                EditorLastName = "Radish",
                Title = "Felis libyca",
                Isbn = "261652143-1",
                Type = "electronic",
                Year = 1992,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 429,
                EditorFirstName = "Clélia",
                EditorLastName = "Braun",
                Title = "Acrantophis madagascariensis",
                Isbn = "876745529-8",
                Type = "printed",
                Year = 2011,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 430,
                EditorFirstName = "Tú",
                EditorLastName = "Pee",
                Title = "Dendrocygna v  iduata",
                Isbn = null,
                Type = "electronic",
                Year = 2003,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 431,
                EditorFirstName = "Naëlle",
                EditorLastName = "Feldberg",
                Title = "Hippotragus equinus",
                Isbn = "205669163-9",
                Type = "printed",
                Year = 1996,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 432,
                EditorFirstName = "Vénus",
                EditorLastName = "Fibben",
                Title = "Isoodon obesulus",
                Isbn = "866603129-8",
                Type = "electronic",
                Year = 1993,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 433,
                EditorFirstName = "Nélie",
                EditorLastName = "Banister",
                Title = "Chl    idonias leucopterus",
                Isbn = "799103489-5",
                Type = "printed",
                Year = 1993,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 434,
                EditorFirstName = "Örjan",
                EditorLastName = "Searson",
                Title = "Lamprotornis superbus",
                Isbn = "556507679-X",
                Type = "printed",
                Year = 2001,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 435,
                EditorFirstName = "Hélène",
                EditorLastName = "MacKnight",
                Title = "Cygnus atratus",
                Isbn = "755521395-8",
                Type = "electronic",
                Year = 2004,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 436,
                EditorFirstName = "Amélie",
                EditorLastName = "Marielle",
                Title = "unavailable",
                Isbn = "829064010-2",
                Type = "electronic",
                Year = 1996,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 437,
                EditorFirstName = "Géraldine",
                EditorLastName = "Froude",
                Title = "Sylvicapra grimma",
                Isbn = "700250564-5",
                Type = "electronic",
                Year = 2002,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 438,
                EditorFirstName = "Frédérique",
                EditorLastName = "Ulyet",
                Title = "Gazella granti",
                Isbn = "559412285-0",
                Type = "electronic",
                Year = 1992,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 439,
                EditorFirstName = "Liè",
                EditorLastName = "Rennicks",
                Title = "Sula dactylatra",
                Isbn = "066028479-0",
                Type = "electronic",
                Year = 1994,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 440,
                EditorFirstName = "Maëlle",
                EditorLastName = "Couling",
                Title = "Carduelis pinus",
                Isbn = "584819147-6",
                Type = "electronic",
                Year = 1994,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 441,
                EditorFirstName = "Maëline",
                EditorLastName = "McLinden",
                Title = "Phalaropus lobatus",
                Isbn = "733180806-0",
                Type = "electronic",
                Year = 1991,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 442,
                EditorFirstName = "Maëlla",
                EditorLastName = "Fabry",
                Title = "Varanus sp.",
                Isbn = "054728703-8",
                Type = "electronic",
                Year = 2008,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 443,
                EditorFirstName = "Maëly",
                EditorLastName = "Town",
                Title = "unavailable",
                Isbn = "235685759-1",
                Type = "printed",
                Year = 2007,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 444,
                EditorFirstName = "Rachèle",
                EditorLastName = "Avramovsky",
                Title = "Lutra canadensis",
                Isbn = "332683642-2",
                Type = "electronic",
                Year = 1999,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 445,
                EditorFirstName = "Lóng",
                EditorLastName = "Choake",
                Title = "Terrapene carolina",
                Isbn = "524527171-0",
                Type = "printed",
                Year = 1988,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 446,
                EditorFirstName = "Bérénice",
                EditorLastName = "Mccaull",
                Title = "Cordylus giganteus",
                Isbn = "834208253-9",
                Type = "electronic",
                Year = 2011,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 447,
                EditorFirstName = "Kù",
                EditorLastName = "Everwin",
                Title = "Toxostoma curvirostre",
                Isbn = "565482093-1",
                Type = "electronic",
                Year = 2006,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 448,
                EditorFirstName = "Méline",
                EditorLastName = "Hansard",
                Title = "Ramphastos tucanus",
                Isbn = "203820683-X",
                Type = "printed",
                Year = 2002,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 449,
                EditorFirstName = "Réservés",
                EditorLastName = "Shuttleworth",
                Title = "Colobus guerza",
                Isbn = "910523041-1",
                Type = "electronic",
                Year = 2011,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 450,
                EditorFirstName = "Cloé",
                EditorLastName = "Stoddard",
                Title = "Ictalurus furcatus",
                Isbn = "111171923-3",
                Type = "printed",
                Year = 2010,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 451,
                EditorFirstName = "Cléopatre",
                EditorLastName = "Trenear",
                Title = "Ictonyx striatus",
                Isbn = "796289537-3",
                Type = "electronic",
                Year = 2003,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 452,
                EditorFirstName = "Aurélie",
                EditorLastName = null,
                Title = "Macropus agilis",
                Isbn = "836558364-X",
                Type = "electronic",
                Year = 2002,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 453,
                EditorFirstName = "Cinéma",
                EditorLastName = "Bartell",
                Title = "Oreamnos americanus",
                Isbn = "963815249-4",
                Type = "printed",
                Year = 1998,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 454,
                EditorFirstName = "Salomé",
                EditorLastName = "Nutt",
                Title = "Phasianus colchicus",
                Isbn = "196751232-9",
                Type = "electronic",
                Year = 1993,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 455,
                EditorFirstName = "Marlène",
                EditorLastName = "Kmiec",
                Title = "Lemur catta",
                Isbn = "383522172-8",
                Type = "printed",
                Year = 1994,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 456,
                EditorFirstName = "Mén",
                EditorLastName = "Satterfitt",
                Title = "Chlamydosaurus kingii",
                Isbn = "835392386-6",
                Type = "electronic",
                Year = 2010,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 457,
                EditorFirstName = "Håkan",
                EditorLastName = "Leer",
                Title = "Bettongia penicillata",
                Isbn = "179534379-6",
                Type = "printed",
                Year = 1990,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 458,
                EditorFirstName = "Maïlis",
                EditorLastName = "Habergham",
                Title = "Melophus lathami",
                Isbn = "999940301-8",
                Type = "electronic",
                Year = 2012,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 459,
                EditorFirstName = "Anaïs",
                EditorLastName = "Stranks",
                Title = "Lutra canadensis",
                Isbn = "529788060-2",
                Type = "electronic",
                Year = 1989,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 460,
                EditorFirstName = "Médiamass",
                EditorLastName = null,
                Title = null,
                Isbn = "558456844-9",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 461,
                EditorFirstName = "Laurélie",
                EditorLastName = "Andreacci",
                Title = "Nyctereutes procyono   ides",
                Isbn = "791456857-0",
                Type = "printed",
                Year = 2004,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 462,
                EditorFirstName = "Wá",
                EditorLastName = "Lanigan",
                Title = "Butor  ides striatus",
                Isbn = "739468263-3",
                Type = "printed",
                Year = 2012,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 463,
                EditorFirstName = "Kévina",
                EditorLastName = "Ledur",
                Title = "Cracticus nigroagularis",
                Isbn = "406585008-8",
                Type = "electronic",
                Year = 1995,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 464,
                EditorFirstName = "Maïlis",
                EditorLastName = "Skirling",
                Title = "Acrantophis madagascariensis",
                Isbn = "746844903-1",
                Type = "electronic",
                Year = 1995,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 465,
                EditorFirstName = "Bérengère",
                EditorLastName = "Aikman",
                Title = "Thamnolaea cinnmomeiventris",
                Isbn = "165416703-7",
                Type = "electronic",
                Year = 2008,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 466,
                EditorFirstName = "Esbjörn",
                EditorLastName = "Biggerstaff",
                Title = "Macropus parryi",
                Isbn = "217169030-5",
                Type = "printed",
                Year = 2004,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 467,
                EditorFirstName = "André",
                EditorLastName = "Kleine",
                Title = "Kobus leche robertsi",
                Isbn = "467652553-2",
                Type = "printed",
                Year = 1985,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 468,
                EditorFirstName = "Séréna",
                EditorLastName = "Disley",
                Title = "Cynomys ludovicianus",
                Isbn = "463167984-0",
                Type = "printed",
                Year = 1996,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 469,
                EditorFirstName = "Andréanne",
                EditorLastName = "Cumo",
                Title = "Macropus robustus",
                Isbn = "951475893-5",
                Type = "printed",
                Year = 2003,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 470,
                EditorFirstName = "Eloïse",
                EditorLastName = "Tribe",
                Title = "Terathopius ecaudatus",
                Isbn = "795271808-8",
                Type = "printed",
                Year = 1986,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 471,
                EditorFirstName = "Léa",
                EditorLastName = "Benbrick",
                Title = "Felis silvestris lybica",
                Isbn = "498909755-6",
                Type = "electronic",
                Year = 2000,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 472,
                EditorFirstName = "Béatrice",
                EditorLastName = "Matteoli",
                Title = "unavailable",
                Isbn = "654345758-9",
                Type = "printed",
                Year = 1987,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 473,
                EditorFirstName = "Lén",
                EditorLastName = "Rablan",
                Title = "Haliaetus vocifer",
                Isbn = "871120480-X",
                Type = "printed",
                Year = 1998,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 474,
                EditorFirstName = "Börje",
                EditorLastName = "Jemmison",
                Title = "Ciconia ciconia",
                Isbn = "222789283-8",
                Type = "electronic",
                Year = 1995,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 475,
                EditorFirstName = "Marie-françoise",
                EditorLastName = "Arboin",
                Title = "Gekko gecko",
                Isbn = "806437615-7",
                Type = "electronic",
                Year = 2004,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 476,
                EditorFirstName = "Maëlyss",
                EditorLastName = "Abrahams",
                Title = "Spermophilus richardsonii",
                Isbn = "735515764-7",
                Type = "printed",
                Year = 2007,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 477,
                EditorFirstName = "Adèle",
                EditorLastName = "MacLure",
                Title = "Uraeginthus granatina",
                Isbn = "120949078-1",
                Type = "printed",
                Year = 1999,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 478,
                EditorFirstName = "Léonie",
                EditorLastName = "McKerrow",
                Title = "Ursus americanus",
                Isbn = "477564366-5",
                Type = "printed",
                Year = 1987,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 479,
                EditorFirstName = "Desirée",
                EditorLastName = null,
                Title = "Ardea golieth",
                Isbn = "973996452-4",
                Type = "printed",
                Year = 1985,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 480,
                EditorFirstName = "Régine",
                EditorLastName = "Ruddell",
                Title = "Pseudocheirus peregrinus",
                Isbn = "050577826-2",
                Type = "electronic",
                Year = 1954,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 481,
                EditorFirstName = "Mélia",
                EditorLastName = "Haskew",
                Title = "Potorous tr    idactylus",
                Isbn = "490060540-9",
                Type = "electronic",
                Year = 2003,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 482,
                EditorFirstName = "Personnalisée",
                EditorLastName = "Reddington",
                Title = "Psophia vir    idis",
                Isbn = "513775682-2",
                Type = "printed",
                Year = 1988,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 483,
                EditorFirstName = "Pò",
                EditorLastName = "Kitchingman",
                Title = null,
                Isbn = "233221881-5",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 484,
                EditorFirstName = "Aí",
                EditorLastName = "Magenny",
                Title = "Graspus graspus",
                Isbn = "266278723-6",
                Type = "electronic",
                Year = 2000,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 485,
                EditorFirstName = "Lèi",
                EditorLastName = "Whistlecroft",
                Title = "Gymnorhina tibicen",
                Isbn = "661320926-0",
                Type = "printed",
                Year = 1994,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 486,
                EditorFirstName = "Médiamass",
                EditorLastName = "Gamage",
                Title = "Colaptes campestro ides",
                Isbn = "348705391-8",
                Type = "printed",
                Year = 2003,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 487,
                EditorFirstName = "Simplifiés",
                EditorLastName = "O'Fearguise",
                Title = "Larus fuliginosus",
                Isbn = "773099988-9",
                Type = "electronic",
                Year = 2012,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 488,
                EditorFirstName = "Véronique",
                EditorLastName = "Saunder",
                Title = "Meleagris gallopavo",
                Isbn = "458504484-1",
                Type = "printed",
                Year = 2006,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 489,
                EditorFirstName = "Annotée",
                EditorLastName = "Munehay",
                Title = "Spizaetus coronatus",
                Isbn = "387005705-X",
                Type = "electronic",
                Year = 2008,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 490,
                EditorFirstName = "Océane",
                EditorLastName = "Ramiro",
                Title = "Porphyrio porphyrio",
                Isbn = "418612400-0",
                Type = "printed",
                Year = 2000,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 491,
                EditorFirstName = "Marie-hélène",
                EditorLastName = "Strathman",
                Title = "Pico   ides pubescens",
                Isbn = "636587426-X",
                Type = "electronic",
                Year = 2006,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 492,
                EditorFirstName = "Maëlann",
                EditorLastName = "Beausang",
                Title = "Ovis orientalis",
                Isbn = "045736728-8",
                Type = "electronic",
                Year = 1991,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 493,
                EditorFirstName = "Séverine",
                EditorLastName = null,
                Title = "Gyps fulvus",
                Isbn = "943740343-0",
                Type = "printed",
                Year = 2011,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 494,
                EditorFirstName = "Dù",
                EditorLastName = "Everill",
                Title = "Fratercula corniculata",
                Isbn = "559539312-2",
                Type = "electronic",
                Year = 1990,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 495,
                EditorFirstName = "Åsa",
                EditorLastName = "Cordelette",
                Title = "Ciconia episcopus",
                Isbn = "757361096-3",
                Type = "electronic",
                Year = 1999,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 496,
                EditorFirstName = "Cléa",
                EditorLastName = "Gazzard",
                Title = "Cereopsis novaehollandiae",
                Isbn = "565895019-8",
                Type = "electronic",
                Year = 1999,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 497,
                EditorFirstName = "Léonore",
                EditorLastName = "de Aguirre",
                Title = "Felis chaus",
                Isbn = "553952936-7",
                Type = "printed",
                Year = 1986,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 498,
                EditorFirstName = "Torbjörn",
                EditorLastName = "Morshead",
                Title = "Coluber constrictor foxii",
                Isbn = "687761379-1",
                Type = "electronic",
                Year = 1985,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 499,
                EditorFirstName = "Annotés",
                EditorLastName = "Tames",
                Title = "Speotyte cuniculata",
                Isbn = "882411601-9",
                Type = "electronic",
                Year = 2012,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 500,
                EditorFirstName = "Mén",
                EditorLastName = "Hannah",
                Title = "Sceloporus magister",
                Isbn = "190702593-6",
                Type = "printed",
                Year = 1999,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 501,
                EditorFirstName = "Maëlle",
                EditorLastName = "Barff",
                Title = "Vanellus chilensis",
                Isbn = "726328542-8",
                Type = "electronic",
                Year = 1990,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 502,
                EditorFirstName = "Aí",
                EditorLastName = "Ducaen",
                Title = "Pteronura brasiliensis",
                Isbn = "363751645-4",
                Type = "printed",
                Year = 1998,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 503,
                EditorFirstName = "Andréanne",
                EditorLastName = "Stinton",
                Title = "Myiarchus tuberculifer",
                Isbn = "699565539-7",
                Type = "printed",
                Year = 2011,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 504,
                EditorFirstName = "Séréna",
                EditorLastName = "Cerman",
                Title = "Cathartes aura",
                Isbn = "313852111-8",
                Type = "printed",
                Year = 1989,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 505,
                EditorFirstName = "Pål",
                EditorLastName = "Boots",
                Title = "Heloderma horr idum",
                Isbn = "582105577-6",
                Type = "printed",
                Year = 2011,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 506,
                EditorFirstName = "Åsa",
                EditorLastName = "Rikard",
                Title = "Conolophus subcristatus",
                Isbn = "284790113-2",
                Type = "electronic",
                Year = 1994,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 507,
                EditorFirstName = "Adélie",
                EditorLastName = "Laurenson",
                Title = "Ctenophorus ornatus",
                Isbn = "899795592-6",
                Type = "electronic",
                Year = 2002,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 508,
                EditorFirstName = "Åslög",
                EditorLastName = "Halpin",
                Title = "Ursus arctos",
                Isbn = null,
                Type = "electronic",
                Year = 2010,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 509,
                EditorFirstName = "Céline",
                EditorLastName = "Mattholie",
                Title = null,
                Isbn = "098658756-7",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 510,
                EditorFirstName = "Stéphanie",
                EditorLastName = "Tink",
                Title = "Ateles paniscus",
                Isbn = "865258992-5",
                Type = "electronic",
                Year = 1992,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 511,
                EditorFirstName = "Gwenaëlle",
                EditorLastName = "Rendall",
                Title = "Uraeginthus granatina",
                Isbn = "323891235-6",
                Type = "electronic",
                Year = 1995,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 512,
                EditorFirstName = "Inès",
                EditorLastName = null,
                Title = "Myrmecophaga tr    idactyla",
                Isbn = "626336674-5",
                Type = "printed",
                Year = 1995,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 513,
                EditorFirstName = "Rébecca",
                EditorLastName = "Warboy",
                Title = "Coluber constrictor",
                Isbn = null,
                Type = "printed",
                Year = 1995,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 514,
                EditorFirstName = "Irène",
                EditorLastName = "Rubinsky",
                Title = "Columba palumbus",
                Isbn = "902848150-8",
                Type = "printed",
                Year = 1988,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 515,
                EditorFirstName = "Méthode",
                EditorLastName = "Ovill",
                Title = "Ara ararauna",
                Isbn = "905404082-3",
                Type = "electronic",
                Year = 1991,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 516,
                EditorFirstName = "Mårten",
                EditorLastName = null,
                Title = "Genetta genetta",
                Isbn = "251084621-3",
                Type = "printed",
                Year = 1994,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 517,
                EditorFirstName = "Táng",
                EditorLastName = null,
                Title = "Speotyte cuniculata",
                Isbn = "738566701-5",
                Type = "electronic",
                Year = 1997,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 518,
                EditorFirstName = "Rachèle",
                EditorLastName = "Tearle",
                Title = "Buteo regalis",
                Isbn = "132764587-4",
                Type = "printed",
                Year = 2012,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 519,
                EditorFirstName = "Joséphine",
                EditorLastName = "Sizeland",
                Title = "Butor  ides striatus",
                Isbn = "228863713-7",
                Type = "printed",
                Year = 2010,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 520,
                EditorFirstName = "Cléopatre",
                EditorLastName = "Challoner",
                Title = "Lycaon pictus",
                Isbn = "194482776-5",
                Type = "printed",
                Year = 2006,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 521,
                EditorFirstName = "Faîtes",
                EditorLastName = "Milson",
                Title = "Raphicerus campestris",
                Isbn = "948029121-5",
                Type = "electronic",
                Year = 2001,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 522,
                EditorFirstName = "Lyséa",
                EditorLastName = "Grisewood",
                Title = "Bubalus arnee",
                Isbn = "741789343-0",
                Type = "electronic",
                Year = 2011,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 523,
                EditorFirstName = "Céline",
                EditorLastName = "Wetwood",
                Title = "Zosterops pall idus",
                Isbn = "229975205-6",
                Type = "electronic",
                Year = 2008,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 524,
                EditorFirstName = "Nadège",
                EditorLastName = "Shackel",
                Title = "Mephitis mephitis",
                Isbn = "547816320-1",
                Type = "printed",
                Year = 1996,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 525,
                EditorFirstName = "Faîtes",
                EditorLastName = "Rosingdall",
                Title = "Felis silvestris lybica",
                Isbn = "481599905-8",
                Type = "electronic",
                Year = 1988,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 526,
                EditorFirstName = "Loïc",
                EditorLastName = "Bunclark",
                Title = "Perameles nasuta",
                Isbn = "629729546-8",
                Type = "printed",
                Year = 2002,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 527,
                EditorFirstName = "Gaïa",
                EditorLastName = "de Voiels",
                Title = "Lamprotornis nitens",
                Isbn = "474153186-4",
                Type = "electronic",
                Year = 2000,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 528,
                EditorFirstName = "Simplifiés",
                EditorLastName = "Dermott",
                Title = "Columba palumbus",
                Isbn = null,
                Type = "printed",
                Year = 2011,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 529,
                EditorFirstName = "Maëlyss",
                EditorLastName = "Gremain",
                Title = "Bucorvus leadbeateri",
                Isbn = "313862392-1",
                Type = "electronic",
                Year = 2005,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 530,
                EditorFirstName = "Anaé",
                EditorLastName = "Teggart",
                Title = "Hystrix indica",
                Isbn = "873753509-9",
                Type = "printed",
                Year = 2002,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 531,
                EditorFirstName = "Rébecca",
                EditorLastName = "Hardman",
                Title = "Nasua nasua",
                Isbn = "693550018-4",
                Type = "electronic",
                Year = 2009,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 532,
                EditorFirstName = "Maëlla",
                EditorLastName = "Capeloff",
                Title = "Alopochen aegyptiacus",
                Isbn = "463191744-X",
                Type = "printed",
                Year = 2008,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 533,
                EditorFirstName = "Maïwenn",
                EditorLastName = "Upsale",
                Title = "Oncorhynchus nerka",
                Isbn = "626576212-5",
                Type = "electronic",
                Year = 1992,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 534,
                EditorFirstName = "Maëlle",
                EditorLastName = "Nuttey",
                Title = "Sceloporus magister",
                Isbn = null,
                Type = "printed",
                Year = 2011,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 535,
                EditorFirstName = "Clélia",
                EditorLastName = "Illingsworth",
                Title = "Caiman crocodilus",
                Isbn = "617242047-X",
                Type = "printed",
                Year = 2003,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 536,
                EditorFirstName = "Uò",
                EditorLastName = "Reilingen",
                Title = "Lasiodora parahybana",
                Isbn = "829655625-1",
                Type = "printed",
                Year = 2008,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 537,
                EditorFirstName = "Méng",
                EditorLastName = "Gallehawk",
                Title = "Varanus salvator",
                Isbn = "963775291-9",
                Type = "printed",
                Year = 2002,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 538,
                EditorFirstName = "Audréanne",
                EditorLastName = "Brawn",
                Title = "Branta canadensis",
                Isbn = "468367104-2",
                Type = "electronic",
                Year = 2010,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 539,
                EditorFirstName = "Renée",
                EditorLastName = "Possek",
                Title = "Felis silvestris lybica",
                Isbn = "800927949-8",
                Type = "printed",
                Year = 1998,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 540,
                EditorFirstName = "Gösta",
                EditorLastName = "Moxsom",
                Title = "Cracticus nigroagularis",
                Isbn = "844661596-7",
                Type = "electronic",
                Year = 2009,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 541,
                EditorFirstName = "Gaëlle",
                EditorLastName = "Dmitrichenko",
                Title = "Varanus sp.",
                Isbn = "810627358-X",
                Type = "printed",
                Year = 2013,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 542,
                EditorFirstName = "Laurène",
                EditorLastName = "Fownes",
                Title = "Heloderma horr idum",
                Isbn = "357730051-5",
                Type = "printed",
                Year = 1997,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 543,
                EditorFirstName = "Bécassine",
                EditorLastName = "Erricker",
                Title = "Boa constrictor mexicana",
                Isbn = "184023625-6",
                Type = "printed",
                Year = 1994,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 544,
                EditorFirstName = "Réjane",
                EditorLastName = "Chapelhow",
                Title = "Carduelis pinus",
                Isbn = null,
                Type = "electronic",
                Year = 1996,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 545,
                EditorFirstName = "Océanne",
                EditorLastName = "Allenson",
                Title = "Stenella coeruleoalba",
                Isbn = "964260859-6",
                Type = "electronic",
                Year = 1988,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 546,
                EditorFirstName = "Åslög",
                EditorLastName = "Salmoni",
                Title = "Anastomus oscitans",
                Isbn = "227138559-8",
                Type = "printed",
                Year = 1992,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 547,
                EditorFirstName = "Clémence",
                EditorLastName = "Amthor",
                Title = "Callorhinus ursinus",
                Isbn = "415595365-X",
                Type = "electronic",
                Year = 1994,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 548,
                EditorFirstName = "Amélie",
                EditorLastName = "Overbury",
                Title = "Eutamias minimus",
                Isbn = "584853817-4",
                Type = "electronic",
                Year = 1950,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 549,
                EditorFirstName = "Yáo",
                EditorLastName = "Canham",
                Title = "Chelodina longicollis",
                Isbn = "964764747-6",
                Type = "printed",
                Year = 2008,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 550,
                EditorFirstName = "Marie-josée",
                EditorLastName = "Laimable",
                Title = "Tetracerus quadricornis",
                Isbn = "016030408-3",
                Type = "electronic",
                Year = 1986,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 551,
                EditorFirstName = "Mahélie",
                EditorLastName = "Silver",
                Title = "Microcavia australis",
                Isbn = "093163258-7",
                Type = "printed",
                Year = 1998,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 552,
                EditorFirstName = "Léone",
                EditorLastName = "Partleton",
                Title = "Marmota flaviventris",
                Isbn = "540205780-X",
                Type = "electronic",
                Year = 1996,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 553,
                EditorFirstName = "Noëlla",
                EditorLastName = "Whiston",
                Title = "Neotoma sp.",
                Isbn = "937384681-7",
                Type = "printed",
                Year = 2007,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 554,
                EditorFirstName = "Cléopatre",
                EditorLastName = "Blamey",
                Title = "Phoenicopterus chilensis",
                Isbn = "858211150-9",
                Type = "printed",
                Year = 1994,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 555,
                EditorFirstName = "Léane",
                EditorLastName = "Pr    iddey",
                Title = "Galictis vittata",
                Isbn = "235397167-9",
                Type = "electronic",
                Year = 2001,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 556,
                EditorFirstName = "Gösta",
                EditorLastName = "Danilin",
                Title = "Crocodylus niloticus",
                Isbn = "836562515-6",
                Type = "electronic",
                Year = 2008,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 557,
                EditorFirstName = "Almérinda",
                EditorLastName = "Bigham",
                Title = "Tapirus terrestris",
                Isbn = "003579199-3",
                Type = "printed",
                Year = 2000,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 558,
                EditorFirstName = "Åsa",
                EditorLastName = "Jean",
                Title = "Mellivora capensis",
                Isbn = "025476166-6",
                Type = "electronic",
                Year = 2008,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 559,
                EditorFirstName = "Naéva",
                EditorLastName = "Mollnar",
                Title = "Alcelaphus buselaphus caama",
                Isbn = "106259377-4",
                Type = "printed",
                Year = 2007,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 560,
                EditorFirstName = "Mélinda",
                EditorLastName = "Hindsberg",
                Title = "Neotis denhami",
                Isbn = "338828327-3",
                Type = "printed",
                Year = 1993,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 561,
                EditorFirstName = "Håkan",
                EditorLastName = "M idgely",
                Title = "Mazama gouazoubira",
                Isbn = "420403149-8",
                Type = "electronic",
                Year = 2003,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 562,
                EditorFirstName = "Yú",
                EditorLastName = "Pickston",
                Title = "Geochelone elegans",
                Isbn = "350375652-3",
                Type = "electronic",
                Year = 2006,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 563,
                EditorFirstName = "Styrbjörn",
                EditorLastName = "Birmingham",
                Title = "Procyon lotor",
                Isbn = "497156678-3",
                Type = "printed",
                Year = 1992,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 564,
                EditorFirstName = "Naéva",
                EditorLastName = "Pinkie",
                Title = "Propithecus verreauxi",
                Isbn = "757899341-0",
                Type = "electronic",
                Year = 2008,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 565,
                EditorFirstName = "Maïlys",
                EditorLastName = "Sandey",
                Title = "Loxodonta africana",
                Isbn = "904998069-4",
                Type = "printed",
                Year = 1990,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 566,
                EditorFirstName = "Anaé",
                EditorLastName = "Roscam",
                Title = "Cebus apella",
                Isbn = "444603005-1",
                Type = "electronic",
                Year = 2001,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 567,
                EditorFirstName = "Renée",
                EditorLastName = "Allbon",
                Title = "Dasypus novemcinctus",
                Isbn = "314415903-4",
                Type = "printed",
                Year = 2012,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 568,
                EditorFirstName = "Åslög",
                EditorLastName = "Messam",
                Title = "Grus rubicundus",
                Isbn = "770824292-4",
                Type = "printed",
                Year = 2002,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 569,
                EditorFirstName = "Léone",
                EditorLastName = "Filippyev",
                Title = "Bettongia penicillata",
                Isbn = "166220044-7",
                Type = "printed",
                Year = 1992,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 570,
                EditorFirstName = "Marylène",
                EditorLastName = "Studde",
                Title = "Plegadis r idgwayi",
                Isbn = "644530206-8",
                Type = "printed",
                Year = 1999,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 571,
                EditorFirstName = "Cléa",
                EditorLastName = "Sandy",
                Title = "Canis aureus",
                Isbn = "668120644-1",
                Type = "electronic",
                Year = 1992,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 572,
                EditorFirstName = "Thérèsa",
                EditorLastName = "Poschel",
                Title = "Crotalus adamanteus",
                Isbn = "407636740-5",
                Type = "electronic",
                Year = 1992,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 573,
                EditorFirstName = "Eléonore",
                EditorLastName = "Waeland",
                Title = "Trichosurus vulpecula",
                Isbn = "189296811-8",
                Type = "printed",
                Year = 1994,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 574,
                EditorFirstName = "Mahélie",
                EditorLastName = "Putten",
                Title = "Lutra canadensis",
                Isbn = "529816018-2",
                Type = "printed",
                Year = 1989,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 575,
                EditorFirstName = "Marie-noël",
                EditorLastName = "Rudyard",
                Title = "Cebus apella",
                Isbn = "402903834-4",
                Type = "electronic",
                Year = 2006,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 576,
                EditorFirstName = "Lyséa",
                EditorLastName = "Michallat",
                Title = "Trichosurus vulpecula",
                Isbn = "566741089-3",
                Type = "printed",
                Year = 2001,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 577,
                EditorFirstName = "Sòng",
                EditorLastName = "Fealty",
                Title = "Felis silvestris lybica",
                Isbn = "507836587-7",
                Type = "electronic",
                Year = 1994,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 578,
                EditorFirstName = "Clémentine",
                EditorLastName = "McBr  ide",
                Title = "Castor canadensis",
                Isbn = "532696788-X",
                Type = "electronic",
                Year = 2008,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 579,
                EditorFirstName = "Maëlyss",
                EditorLastName = "Shemilt",
                Title = "Gorilla gorilla",
                Isbn = "016755674-6",
                Type = "printed",
                Year = 1990,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 580,
                EditorFirstName = "Anaëlle",
                EditorLastName = "Todman",
                Title = "Neophron percnopterus",
                Isbn = "368591068-X",
                Type = "electronic",
                Year = 2011,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 581,
                EditorFirstName = "Océanne",
                EditorLastName = "Howat",
                Title = "Cereopsis novaehollandiae",
                Isbn = "216238428-0",
                Type = "electronic",
                Year = 2002,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 582,
                EditorFirstName = "Audréanne",
                EditorLastName = "Thackray",
                Title = "Junonia genoveua",
                Isbn = "514360416-8",
                Type = "printed",
                Year = 1993,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 583,
                EditorFirstName = "Réservés",
                EditorLastName = "Zanettini",
                Title = "Toxostoma curvirostre",
                Isbn = "138339167-X",
                Type = "electronic",
                Year = 1990,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 584,
                EditorFirstName = "Anaëlle",
                EditorLastName = "McLean",
                Title = "Chl    idonias leucopterus",
                Isbn = "535935735-5",
                Type = "printed",
                Year = 2012,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 585,
                EditorFirstName = "Méryl",
                EditorLastName = "Noah",
                Title = "Merops sp.",
                Isbn = "416184710-6",
                Type = "printed",
                Year = 2003,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 586,
                EditorFirstName = "Lèi",
                EditorLastName = "Richt",
                Title = "Leprocaulinus vipera",
                Isbn = "914467168-7",
                Type = "printed",
                Year = 1996,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 587,
                EditorFirstName = "Adèle",
                EditorLastName = "Hairsnape",
                Title = "Amphibolurus barbatus",
                Isbn = "691904650-4",
                Type = "printed",
                Year = 1999,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 588,
                EditorFirstName = "Måns",
                EditorLastName = "Bubbear",
                Title = "Scolopax minor",
                Isbn = "839039096-5",
                Type = "electronic",
                Year = 2011,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 589,
                EditorFirstName = "Börje",
                EditorLastName = "Bittleson",
                Title = "Macropus robustus",
                Isbn = "698897538-1",
                Type = "electronic",
                Year = 2001,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 590,
                EditorFirstName = "Léandre",
                EditorLastName = "McElvogue",
                Title = "Rana sp.",
                Isbn = "557546229-3",
                Type = "electronic",
                Year = 1986,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 591,
                EditorFirstName = "Cécile",
                EditorLastName = null,
                Title = "Chelodina longicollis",
                Isbn = "157152983-7",
                Type = "printed",
                Year = 2004,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 592,
                EditorFirstName = "Kù",
                EditorLastName = "Carthy",
                Title = "Choloepus hoffmani",
                Isbn = "236602512-2",
                Type = "electronic",
                Year = 1973,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 593,
                EditorFirstName = "Åslög",
                EditorLastName = "Simonini",
                Title = "Gazella thompsonii",
                Isbn = "403146701-X",
                Type = "printed",
                Year = 2006,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 594,
                EditorFirstName = "Liè",
                EditorLastName = "Chyuerton",
                Title = "Gazella granti",
                Isbn = "513873450-4",
                Type = "electronic",
                Year = 2012,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 595,
                EditorFirstName = "Fèi",
                EditorLastName = "Benneyworth",
                Title = "Limosa haemastica",
                Isbn = "766885642-0",
                Type = "printed",
                Year = 2008,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 596,
                EditorFirstName = "Aí",
                EditorLastName = "Salkild",
                Title = "Terrapene carolina",
                Isbn = "102590546-6",
                Type = "electronic",
                Year = 2002,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 597,
                EditorFirstName = "Véronique",
                EditorLastName = "McElrea",
                Title = "Trichechus inunguis",
                Isbn = "385803934-9",
                Type = "printed",
                Year = 1992,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 598,
                EditorFirstName = "Nélie",
                EditorLastName = "Williamson",
                Title = "Sarcophilus harrisii",
                Isbn = "175477457-1",
                Type = "printed",
                Year = 2012,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 599,
                EditorFirstName = "Agnès",
                EditorLastName = "Grimsdith",
                Title = "Sark   idornis melanotos",
                Isbn = "116753551-0",
                Type = "printed",
                Year = 2005,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 600,
                EditorFirstName = "Athéna",
                EditorLastName = "Trappe",
                Title = "Ceratotherium simum",
                Isbn = "652093422-4",
                Type = "electronic",
                Year = 1993,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 601,
                EditorFirstName = "Célia",
                EditorLastName = "McMichell",
                Title = "Castor canadensis",
                Isbn = "354312091-3",
                Type = "electronic",
                Year = 1999,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 602,
                EditorFirstName = "Léone",
                EditorLastName = "Proppers",
                Title = "Laniarius ferrugineus",
                Isbn = "310932701-5",
                Type = "printed",
                Year = 2009,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 603,
                EditorFirstName = "Lyséa",
                EditorLastName = "Glisenan",
                Title = "Pycnonotus nigricans",
                Isbn = "368475839-6",
                Type = "electronic",
                Year = 2011,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 604,
                EditorFirstName = "Intéressant",
                EditorLastName = "Gueny",
                Title = "Lycaon pictus",
                Isbn = "900238551-X",
                Type = "electronic",
                Year = 1996,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 605,
                EditorFirstName = "Maïlis",
                EditorLastName = "Gonsalvo",
                Title = "Drymarchon corias couperi",
                Isbn = "400303319-1",
                Type = "electronic",
                Year = 2011,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 606,
                EditorFirstName = "Kuí",
                EditorLastName = "Thorogood",
                Title = "Cacatua tenuirostris",
                Isbn = "838965175-0",
                Type = "electronic",
                Year = 1991,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 607,
                EditorFirstName = "Faîtes",
                EditorLastName = null,
                Title = "Redunca redunca",
                Isbn = "416742281-6",
                Type = "printed",
                Year = 1994,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 608,
                EditorFirstName = "Erwéi",
                EditorLastName = "Pues",
                Title = "Nannopterum harrisi",
                Isbn = null,
                Type = "electronic",
                Year = 2009,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 609,
                EditorFirstName = "Célia",
                EditorLastName = "Humble",
                Title = "Estrilda erythronotos",
                Isbn = "456169627-X",
                Type = "printed",
                Year = 2003,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 610,
                EditorFirstName = "Frédérique",
                EditorLastName = "Grassick",
                Title = "Phalacrocorax niger",
                Isbn = "737880859-8",
                Type = "printed",
                Year = 1994,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 611,
                EditorFirstName = "Intéressant",
                EditorLastName = "Scane",
                Title = "Catharacta skua",
                Isbn = "660687119-0",
                Type = "electronic",
                Year = 1997,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 612,
                EditorFirstName = "Nadège",
                EditorLastName = "Goude",
                Title = "Dendrocitta vagabunda",
                Isbn = "193942949-8",
                Type = "electronic",
                Year = 1986,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 613,
                EditorFirstName = "Mélina",
                EditorLastName = "Ranstead",
                Title = "Aonyx cinerea",
                Isbn = "363735969-3",
                Type = "electronic",
                Year = 2007,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 614,
                EditorFirstName = "Kù",
                EditorLastName = "Louch",
                Title = "Lepus arcticus",
                Isbn = "140159102-7",
                Type = "electronic",
                Year = 2005,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 615,
                EditorFirstName = "Lorène",
                EditorLastName = null,
                Title = "unavailable",
                Isbn = null,
                Type = "electronic",
                Year = 1998,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 616,
                EditorFirstName = "Léonore",
                EditorLastName = "Pierro",
                Title = "Pitangus sulphuratus",
                Isbn = "138320955-3",
                Type = "electronic",
                Year = 1986,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 617,
                EditorFirstName = "Séverine",
                EditorLastName = "R idder",
                Title = "Hymenolaimus malacorhynchus",
                Isbn = "114666631-4",
                Type = "printed",
                Year = 2010,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 618,
                EditorFirstName = "Eloïse",
                EditorLastName = "Yuranovev",
                Title = "Varanus salvator",
                Isbn = "453785392-1",
                Type = "electronic",
                Year = 1994,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 619,
                EditorFirstName = "Geneviève",
                EditorLastName = "Gilchrest",
                Title = "Sus scrofa",
                Isbn = null,
                Type = "printed",
                Year = 2011,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 620,
                EditorFirstName = "Björn",
                EditorLastName = "Koubu",
                Title = "Streptopelia decipiens",
                Isbn = "354552535-X",
                Type = "printed",
                Year = 2004,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 621,
                EditorFirstName = "Lài",
                EditorLastName = "Hardware",
                Title = "Limosa haemastica",
                Isbn = "878107397-6",
                Type = "printed",
                Year = 2007,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 622,
                EditorFirstName = "Laïla",
                EditorLastName = "Fortescue",
                Title = "Uraeginthus angolensis",
                Isbn = "296561986-0",
                Type = "printed",
                Year = 2005,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 623,
                EditorFirstName = "Erwéi",
                EditorLastName = "Van der Velde",
                Title = "Macaca nemestrina",
                Isbn = "685583926-6",
                Type = "electronic",
                Year = 2003,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 624,
                EditorFirstName = "Intéressant",
                EditorLastName = "Kaindl",
                Title = "Otaria flavescens",
                Isbn = "653007854-1",
                Type = "printed",
                Year = 1991,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 625,
                EditorFirstName = "Anaël",
                EditorLastName = "Winfrey",
                Title = "Procyon cancrivorus",
                Isbn = "208085135-7",
                Type = "printed",
                Year = 1994,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 626,
                EditorFirstName = "Mélanie",
                EditorLastName = "Manuel",
                Title = "Gorilla gorilla",
                Isbn = "910535172-3",
                Type = "printed",
                Year = 2002,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 627,
                EditorFirstName = "Stévina",
                EditorLastName = "Langshaw",
                Title = null,
                Isbn = "133097448-4",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 628,
                EditorFirstName = "Pò",
                EditorLastName = "Ewer",
                Title = "Deroptyus accipitrinus",
                Isbn = "950486490-2",
                Type = "printed",
                Year = 2006,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 629,
                EditorFirstName = "Nuó",
                EditorLastName = "Tomankiewicz",
                Title = "Isoodon obesulus",
                Isbn = "295649713-8",
                Type = "electronic",
                Year = 2009,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 630,
                EditorFirstName = "Séverine",
                EditorLastName = "Wagge",
                Title = "Ciconia ciconia",
                Isbn = "816595234-X",
                Type = "electronic",
                Year = 2009,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 631,
                EditorFirstName = "Françoise",
                EditorLastName = "Frayling",
                Title = "Otaria flavescens",
                Isbn = "279973540-1",
                Type = "printed",
                Year = 2009,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 632,
                EditorFirstName = "Aimée",
                EditorLastName = "Willerstone",
                Title = "Dipodomys deserti",
                Isbn = "457577163-5",
                Type = "electronic",
                Year = 2003,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 633,
                EditorFirstName = "Loïc",
                EditorLastName = "Dan",
                Title = "Lemur fulvus",
                Isbn = null,
                Type = "printed",
                Year = 1994,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 634,
                EditorFirstName = "Kévina",
                EditorLastName = "Corlett",
                Title = "Irania gutteralis",
                Isbn = "833711760-5",
                Type = "printed",
                Year = 1997,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 635,
                EditorFirstName = "Marlène",
                EditorLastName = "MacQuarrie",
                Title = "Cynictis penicillata",
                Isbn = "426144142-X",
                Type = "electronic",
                Year = 1994,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 636,
                EditorFirstName = "Valérie",
                EditorLastName = "Rosencrantz",
                Title = "Lamprotornis nitens",
                Isbn = "619015542-1",
                Type = "printed",
                Year = 2007,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 637,
                EditorFirstName = "Adélie",
                EditorLastName = "Holliar",
                Title = "Phascogale calura",
                Isbn = "830273179-X",
                Type = "printed",
                Year = 2012,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 638,
                EditorFirstName = "Rébecca",
                EditorLastName = "Campanelli",
                Title = null,
                Isbn = "462630143-6",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 639,
                EditorFirstName = "Céline",
                EditorLastName = "Heak",
                Title = "Phoenicopterus ruber",
                Isbn = "927659200-8",
                Type = "printed",
                Year = 2008,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 640,
                EditorFirstName = "Béatrice",
                EditorLastName = "Trevaskis",
                Title = "Ara ararauna",
                Isbn = "193246748-3",
                Type = "printed",
                Year = 1986,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 641,
                EditorFirstName = "Maïwenn",
                EditorLastName = "Cramb",
                Title = "Myotis lucifugus",
                Isbn = "715580769-9",
                Type = "electronic",
                Year = 2009,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 642,
                EditorFirstName = "Lyséa",
                EditorLastName = "Wakeman",
                Title = "Mungos mungo",
                Isbn = "748654169-6",
                Type = "electronic",
                Year = 2006,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 643,
                EditorFirstName = "Loïs",
                EditorLastName = "Ruoff",
                Title = "Lasiodora parahybana",
                Isbn = "657397485-9",
                Type = "electronic",
                Year = 1990,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 644,
                EditorFirstName = "Mélys",
                EditorLastName = null,
                Title = "Melursus ursinus",
                Isbn = "640268087-7",
                Type = "electronic",
                Year = 2013,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 645,
                EditorFirstName = "Lén",
                EditorLastName = "MacNab",
                Title = "Coluber constrictor",
                Isbn = "610031549-1",
                Type = "printed",
                Year = 2011,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 646,
                EditorFirstName = "Cunégonde",
                EditorLastName = "Alleyne",
                Title = "Tapirus terrestris",
                Isbn = "046575709-X",
                Type = "printed",
                Year = 2007,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 647,
                EditorFirstName = "Chloé",
                EditorLastName = "Ekell",
                Title = "Procyon cancrivorus",
                Isbn = "028622049-0",
                Type = "printed",
                Year = 1995,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 648,
                EditorFirstName = "Intéressant",
                EditorLastName = "Sayle",
                Title = "Pseudoleistes virescens",
                Isbn = "144858091-9",
                Type = "printed",
                Year = 2001,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 649,
                EditorFirstName = "Táng",
                EditorLastName = "Lawther",
                Title = "Ninox superciliaris",
                Isbn = "961326995-9",
                Type = "electronic",
                Year = 2010,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 650,
                EditorFirstName = "Publicité",
                EditorLastName = "Berrisford",
                Title = "D  idelphis virginiana",
                Isbn = "322166473-7",
                Type = "printed",
                Year = 2001,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 651,
                EditorFirstName = "Célia",
                EditorLastName = "Filan",
                Title = "Semnopithecus entellus",
                Isbn = "527958436-3",
                Type = "printed",
                Year = 1993,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 652,
                EditorFirstName = "Maëlyss",
                EditorLastName = "MacLaverty",
                Title = "Bos frontalis",
                Isbn = "662023762-2",
                Type = "electronic",
                Year = 1982,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 653,
                EditorFirstName = "Maïwenn",
                EditorLastName = "Geer",
                Title = "Coluber constrictor",
                Isbn = "111408933-8",
                Type = "electronic",
                Year = 1997,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 654,
                EditorFirstName = "Bérengère",
                EditorLastName = "Ellershaw",
                Title = "Lemur catta",
                Isbn = "464467535-0",
                Type = "printed",
                Year = 2009,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 655,
                EditorFirstName = "Maëlys",
                EditorLastName = null,
                Title = null,
                Isbn = "731281889-7",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 656,
                EditorFirstName = "Lóng",
                EditorLastName = "Yitzhok",
                Title = "Dasyurus maculatus",
                Isbn = "207040080-8",
                Type = "printed",
                Year = 1987,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 657,
                EditorFirstName = "Gisèle",
                EditorLastName = "Br    idgland",
                Title = "Oryx gazella",
                Isbn = "142206116-7",
                Type = "electronic",
                Year = 1994,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 658,
                EditorFirstName = "Adèle",
                EditorLastName = "Tarney",
                Title = "Alligator mississippiensis",
                Isbn = "475560367-6",
                Type = "printed",
                Year = 1993,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 659,
                EditorFirstName = "Léonore",
                EditorLastName = null,
                Title = "Cynictis penicillata",
                Isbn = "856064140-8",
                Type = "printed",
                Year = 2001,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 660,
                EditorFirstName = "Hélèna",
                EditorLastName = "Cullagh",
                Title = "Galago crassicaudataus",
                Isbn = "415987917-9",
                Type = "electronic",
                Year = 2009,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 661,
                EditorFirstName = "Desirée",
                EditorLastName = "Hewlings",
                Title = "Acr    idotheres tristis",
                Isbn = "448297554-0",
                Type = "printed",
                Year = 2005,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 662,
                EditorFirstName = "Erwéi",
                EditorLastName = "Wheowall",
                Title = "Macropus agilis",
                Isbn = "403386438-5",
                Type = "electronic",
                Year = 1995,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 663,
                EditorFirstName = "Néhémie",
                EditorLastName = "Springtorp",
                Title = "unavailable",
                Isbn = "598372796-6",
                Type = "printed",
                Year = 2002,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 664,
                EditorFirstName = "Alizée",
                EditorLastName = "Kohring",
                Title = "Chlamydosaurus kingii",
                Isbn = "223652604-0",
                Type = "printed",
                Year = 2009,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 665,
                EditorFirstName = "Gisèle",
                EditorLastName = "Clell",
                Title = "Damaliscus lunatus",
                Isbn = "000150729-X",
                Type = "electronic",
                Year = 1987,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 666,
                EditorFirstName = "Audréanne",
                EditorLastName = "Poile",
                Title = "Iguana iguana",
                Isbn = "013405915-8",
                Type = "printed",
                Year = 2011,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 667,
                EditorFirstName = "Bérangère",
                EditorLastName = null,
                Title = "Columba palumbus",
                Isbn = "347354588-0",
                Type = "printed",
                Year = 1993,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 668,
                EditorFirstName = "Léandre",
                EditorLastName = null,
                Title = "Eurocephalus anguitimens",
                Isbn = "129857781-0",
                Type = "electronic",
                Year = 1998,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 669,
                EditorFirstName = "Laurélie",
                EditorLastName = "Titlow",
                Title = "Colobus guerza",
                Isbn = "544721872-1",
                Type = "electronic",
                Year = 1993,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 670,
                EditorFirstName = "Zoé",
                EditorLastName = "Antao",
                Title = "Climacteris melanura",
                Isbn = "308293833-7",
                Type = "printed",
                Year = 2011,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 671,
                EditorFirstName = "Crééz",
                EditorLastName = "Antoniou",
                Title = "Chionis alba",
                Isbn = "181442654-X",
                Type = "electronic",
                Year = 1999,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 672,
                EditorFirstName = "Réservés",
                EditorLastName = "Alvar",
                Title = "Bucephala clangula",
                Isbn = "034097574-1",
                Type = "printed",
                Year = 1993,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 673,
                EditorFirstName = "Thérèse",
                EditorLastName = "Mein",
                Title = "Sula dactylatra",
                Isbn = "371802068-8",
                Type = "printed",
                Year = 2010,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 674,
                EditorFirstName = "Mélys",
                EditorLastName = "Duffit",
                Title = "Rhea americana",
                Isbn = "288021575-7",
                Type = "printed",
                Year = 2010,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 675,
                EditorFirstName = "Anaël",
                EditorLastName = "Merry",
                Title = "Felis silvestris lybica",
                Isbn = "247598225-X",
                Type = "printed",
                Year = 1999,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 676,
                EditorFirstName = "Nélie",
                EditorLastName = null,
                Title = "Upupa epops",
                Isbn = "076555164-0",
                Type = "printed",
                Year = 2001,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 677,
                EditorFirstName = "Cécile",
                EditorLastName = "Van der Kruijs",
                Title = "Tockus erythrorhyncus",
                Isbn = "635066747-6",
                Type = "printed",
                Year = 1996,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 678,
                EditorFirstName = "Vénus",
                EditorLastName = "Polly",
                Title = "Colobus guerza",
                Isbn = "766058504-5",
                Type = "electronic",
                Year = 1987,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 679,
                EditorFirstName = "Célestine",
                EditorLastName = "Bodham",
                Title = "Papio cynocephalus",
                Isbn = null,
                Type = "printed",
                Year = 2008,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 680,
                EditorFirstName = "Simplifiés",
                EditorLastName = "Hardey",
                Title = "Pseudalopex gymnocercus",
                Isbn = "190252343-1",
                Type = "printed",
                Year = 1966,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 681,
                EditorFirstName = "Daphnée",
                EditorLastName = "Queyeiro",
                Title = "Mazama gouazoubira",
                Isbn = "666272150-6",
                Type = "electronic",
                Year = 2010,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 682,
                EditorFirstName = "Zoé",
                EditorLastName = "Van Arsdale",
                Title = "Phascogale calura",
                Isbn = "859429064-0",
                Type = "electronic",
                Year = 2012,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 683,
                EditorFirstName = "Thérèse",
                EditorLastName = "Yurenev",
                Title = "Zena   ida galapagoensis",
                Isbn = "474565241-0",
                Type = "electronic",
                Year = 1992,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 684,
                EditorFirstName = "Yóu",
                EditorLastName = "Steven",
                Title = "Lepus arcticus",
                Isbn = "086769813-6",
                Type = "electronic",
                Year = 2008,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 685,
                EditorFirstName = "Yénora",
                EditorLastName = "Coumbe",
                Title = "Lorythaixo ides concolor",
                Isbn = "031933978-5",
                Type = "electronic",
                Year = 2007,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 686,
                EditorFirstName = "Marlène",
                EditorLastName = null,
                Title = "Eira barbata",
                Isbn = "882426653-3",
                Type = "printed",
                Year = 2008,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 687,
                EditorFirstName = "Océanne",
                EditorLastName = "Arkill",
                Title = "Colobus guerza",
                Isbn = "944709606-9",
                Type = "printed",
                Year = 2007,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 688,
                EditorFirstName = "Laïla",
                EditorLastName = null,
                Title = "Gazella granti",
                Isbn = "173316270-4",
                Type = "printed",
                Year = 1992,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 689,
                EditorFirstName = "Erwéi",
                EditorLastName = "Spilsted",
                Title = "Cacatua tenuirostris",
                Isbn = "997557797-0",
                Type = "printed",
                Year = 1994,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 690,
                EditorFirstName = "Véronique",
                EditorLastName = "Woodson",
                Title = "Pseudocheirus peregrinus",
                Isbn = null,
                Type = "electronic",
                Year = 1993,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 691,
                EditorFirstName = "Tú",
                EditorLastName = "Adne",
                Title = "Tragelaphus angasi",
                Isbn = "316537438-4",
                Type = "electronic",
                Year = 1993,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 692,
                EditorFirstName = "Réservés",
                EditorLastName = "Sweetmore",
                Title = "Zalophus californicus",
                Isbn = "861769631-1",
                Type = "electronic",
                Year = 2002,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 693,
                EditorFirstName = "Miléna",
                EditorLastName = "Wildey",
                Title = "Uraeginthus granatina",
                Isbn = "968070600-1",
                Type = "printed",
                Year = 1987,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 694,
                EditorFirstName = "Cunégonde",
                EditorLastName = "Copcutt",
                Title = "Corythornis cristata",
                Isbn = "059824642-8",
                Type = "electronic",
                Year = 1995,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 695,
                EditorFirstName = "Mélanie",
                EditorLastName = "Schulter",
                Title = "Felis concolor",
                Isbn = "613450087-9",
                Type = "printed",
                Year = 2008,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 696,
                EditorFirstName = "Erwéi",
                EditorLastName = "Blackader",
                Title = "Spermophilus tr    idecemlineatus",
                Isbn = "813597211-3",
                Type = "printed",
                Year = 1993,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 697,
                EditorFirstName = "Kévina",
                EditorLastName = "Ruggen",
                Title = "Spizaetus coronatus",
                Isbn = "554619760-9",
                Type = "electronic",
                Year = 2007,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 698,
                EditorFirstName = "Torbjörn",
                EditorLastName = "O'Scollee",
                Title = "Vanellus armatus",
                Isbn = "091503684-3",
                Type = "electronic",
                Year = 2011,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 699,
                EditorFirstName = "Marie-ève",
                EditorLastName = "Lambie",
                Title = "Larus sp.",
                Isbn = "945346114-8",
                Type = "printed",
                Year = 1989,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 700,
                EditorFirstName = "Stéphanie",
                EditorLastName = "Banasik",
                Title = "Tayassu tajacu",
                Isbn = "298416164-5",
                Type = "electronic",
                Year = 2012,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 701,
                EditorFirstName = "Dà",
                EditorLastName = "Syvret",
                Title = "Cebus apella",
                Isbn = "234477004-6",
                Type = "printed",
                Year = 2005,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 702,
                EditorFirstName = "Intéressant",
                EditorLastName = "Hamlett",
                Title = "Otaria flavescens",
                Isbn = "924504954-X",
                Type = "printed",
                Year = 1988,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 703,
                EditorFirstName = "Loïca",
                EditorLastName = "Scoullar",
                Title = "Zalophus californicus",
                Isbn = "814761818-2",
                Type = "electronic",
                Year = 1986,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 704,
                EditorFirstName = "Geneviève",
                EditorLastName = "Asken",
                Title = "Ramphastos tucanus",
                Isbn = "141670453-1",
                Type = "electronic",
                Year = 2002,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 705,
                EditorFirstName = "Garçon",
                EditorLastName = "Trice",
                Title = "Heloderma horr idum",
                Isbn = null,
                Type = "electronic",
                Year = 2000,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 706,
                EditorFirstName = "Håkan",
                EditorLastName = "Robilliard",
                Title = "Crocuta crocuta",
                Isbn = "056076124-4",
                Type = "electronic",
                Year = 1999,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 707,
                EditorFirstName = "Maëlys",
                EditorLastName = "Du Plantier",
                Title = "Semnopithecus entellus",
                Isbn = "524784203-0",
                Type = "electronic",
                Year = 2011,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 708,
                EditorFirstName = "Kallisté",
                EditorLastName = "Trewartha",
                Title = "Chelodina longicollis",
                Isbn = "468869847-X",
                Type = "printed",
                Year = 2004,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 709,
                EditorFirstName = "Dafnée",
                EditorLastName = null,
                Title = "Cathartes aura",
                Isbn = "498348260-1",
                Type = "electronic",
                Year = 1999,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 710,
                EditorFirstName = "Léa",
                EditorLastName = "Cruickshanks",
                Title = "Ceryle rudis",
                Isbn = "416324972-9",
                Type = "printed",
                Year = 1987,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 711,
                EditorFirstName = "Estève",
                EditorLastName = "Dainty",
                Title = "Myiarchus tuberculifer",
                Isbn = "927290840-X",
                Type = "printed",
                Year = 1999,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 712,
                EditorFirstName = "Lauréna",
                EditorLastName = "Slimings",
                Title = "unavailable",
                Isbn = "713301452-1",
                Type = "electronic",
                Year = 2002,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 713,
                EditorFirstName = "Anaëlle",
                EditorLastName = "Gapper",
                Title = "Rhea americana",
                Isbn = "792004463-4",
                Type = "electronic",
                Year = 1997,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 714,
                EditorFirstName = "Gwenaëlle",
                EditorLastName = "Pimblett",
                Title = "Dolichitus patagonum",
                Isbn = "915694055-6",
                Type = "printed",
                Year = 2006,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 715,
                EditorFirstName = "Adèle",
                EditorLastName = "Cremins",
                Title = "Tauraco porphyrelophus",
                Isbn = "935053711-7",
                Type = "electronic",
                Year = 2009,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 716,
                EditorFirstName = "Åslög",
                EditorLastName = "Coultas",
                Title = "Bucephala clangula",
                Isbn = "237929768-1",
                Type = "electronic",
                Year = 1999,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 717,
                EditorFirstName = "Lorène",
                EditorLastName = null,
                Title = "Nucifraga columbiana",
                Isbn = "592753255-1",
                Type = "printed",
                Year = 2012,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 718,
                EditorFirstName = "Åke",
                EditorLastName = "Draye",
                Title = "Streptopelia senegalensis",
                Isbn = "585215803-8",
                Type = "electronic",
                Year = 2008,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 719,
                EditorFirstName = "Kévina",
                EditorLastName = "Tetley",
                Title = "Haliaeetus leucocephalus",
                Isbn = "689155377-6",
                Type = "printed",
                Year = 1990,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 720,
                EditorFirstName = "Cécilia",
                EditorLastName = "Heys",
                Title = "Otocyon megalotis",
                Isbn = "309950063-1",
                Type = "printed",
                Year = 1988,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 721,
                EditorFirstName = "Maëlle",
                EditorLastName = "Breckell",
                Title = "Pan troglodytes",
                Isbn = "589480289-X",
                Type = "electronic",
                Year = 2003,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 722,
                EditorFirstName = "Mélanie",
                EditorLastName = "Prier",
                Title = "Suricata suricatta",
                Isbn = "086022298-5",
                Type = "printed",
                Year = 1993,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 723,
                EditorFirstName = "Solène",
                EditorLastName = "Ewestace",
                Title = "Corvus brachyrhynchos",
                Isbn = "039828214-5",
                Type = "printed",
                Year = 2003,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 724,
                EditorFirstName = "Clémentine",
                EditorLastName = "Shave",
                Title = "Funambulus pennati",
                Isbn = "431918728-8",
                Type = "printed",
                Year = 2002,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 725,
                EditorFirstName = "Mårten",
                EditorLastName = "Palumbo",
                Title = "Spilogale gracilis",
                Isbn = "909090818-8",
                Type = "printed",
                Year = 2001,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 726,
                EditorFirstName = "Håkan",
                EditorLastName = "Mirfin",
                Title = "Crotalus cerastes",
                Isbn = "879082508-X",
                Type = "electronic",
                Year = 1978,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 727,
                EditorFirstName = "Eléa",
                EditorLastName = "Wanell",
                Title = "Toxostoma curvirostre",
                Isbn = "261740209-6",
                Type = "electronic",
                Year = 2005,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 728,
                EditorFirstName = "Publicité",
                EditorLastName = "Harbage",
                Title = "Phoca vitulina",
                Isbn = "583852898-2",
                Type = "printed",
                Year = 1997,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 729,
                EditorFirstName = "Uò",
                EditorLastName = "Siely",
                Title = "Petaurus breviceps",
                Isbn = "485021905-5",
                Type = "printed",
                Year = 1992,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 730,
                EditorFirstName = "Mårten",
                EditorLastName = "Cleeve",
                Title = "Paraxerus cepapi",
                Isbn = "799560732-6",
                Type = "electronic",
                Year = 2007,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 731,
                EditorFirstName = "Danièle",
                EditorLastName = null,
                Title = "Alouatta seniculus",
                Isbn = "985586263-5",
                Type = "printed",
                Year = 2000,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 732,
                EditorFirstName = "Mélina",
                EditorLastName = "Prangley",
                Title = "Ara chloroptera",
                Isbn = "018749883-0",
                Type = "electronic",
                Year = 2005,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 733,
                EditorFirstName = "Lén",
                EditorLastName = "Bucky",
                Title = "Erinaceus frontalis",
                Isbn = "363972984-6",
                Type = "electronic",
                Year = 1998,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 734,
                EditorFirstName = "Yè",
                EditorLastName = "Kippax",
                Title = "Mirounga angustirostris",
                Isbn = "131287134-2",
                Type = "electronic",
                Year = 2006,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 735,
                EditorFirstName = "Maïté",
                EditorLastName = "Barnsdall",
                Title = "Phasianus colchicus",
                Isbn = "923691808-5",
                Type = "printed",
                Year = 1988,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 736,
                EditorFirstName = "Göran",
                EditorLastName = "Duhig",
                Title = "Zonotrichia capensis",
                Isbn = "451403218-2",
                Type = "electronic",
                Year = 2007,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 737,
                EditorFirstName = "Béatrice",
                EditorLastName = "Barthrop",
                Title = "Anathana ellioti",
                Isbn = "461950336-3",
                Type = "printed",
                Year = 1990,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 738,
                EditorFirstName = "Bénédicte",
                EditorLastName = "Kirsche",
                Title = "Cynictis penicillata",
                Isbn = "478879378-4",
                Type = "printed",
                Year = 2009,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 739,
                EditorFirstName = "Pélagie",
                EditorLastName = "P iddick",
                Title = "Felis chaus",
                Isbn = "700444339-6",
                Type = "electronic",
                Year = 2007,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 740,
                EditorFirstName = "Adélaïde",
                EditorLastName = "Robatham",
                Title = "Aonyx cinerea",
                Isbn = "521777703-6",
                Type = "electronic",
                Year = 2003,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 741,
                EditorFirstName = "Lén",
                EditorLastName = "Paddie",
                Title = "Papio cynocephalus",
                Isbn = "536743258-1",
                Type = "electronic",
                Year = 1986,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 742,
                EditorFirstName = "Lóng",
                EditorLastName = "Basey",
                Title = "Colaptes campestro ides",
                Isbn = "991468009-7",
                Type = "printed",
                Year = 1909,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 743,
                EditorFirstName = "Mén",
                EditorLastName = "Demangel",
                Title = "Catharacta skua",
                Isbn = "835167153-3",
                Type = "printed",
                Year = 2003,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 744,
                EditorFirstName = "Styrbjörn",
                EditorLastName = "Chubb",
                Title = "Dicrostonyx groenlandicus",
                Isbn = "977250719-6",
                Type = "printed",
                Year = 2003,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 745,
                EditorFirstName = "Cléa",
                EditorLastName = "Sammars",
                Title = "Ctenophorus ornatus",
                Isbn = "811112313-2",
                Type = "printed",
                Year = 2011,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 746,
                EditorFirstName = "Stévina",
                EditorLastName = "Beamiss",
                Title = "Oryx gazella callotis",
                Isbn = "364264525-9",
                Type = "printed",
                Year = 1983,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 747,
                EditorFirstName = "Clémence",
                EditorLastName = "Bamling",
                Title = "Erinaceus frontalis",
                Isbn = "626570832-5",
                Type = "printed",
                Year = 1988,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 748,
                EditorFirstName = "Tú",
                EditorLastName = "Hapgood",
                Title = "Estrilda erythronotos",
                Isbn = "781735735-8",
                Type = "electronic",
                Year = 2006,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 749,
                EditorFirstName = "Mylène",
                EditorLastName = "Koeppke",
                Title = "unavailable",
                Isbn = "996612414-4",
                Type = "printed",
                Year = 2009,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 750,
                EditorFirstName = "Océane",
                EditorLastName = "Binley",
                Title = "Sceloporus magister",
                Isbn = "161025709-X",
                Type = "electronic",
                Year = 2011,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 751,
                EditorFirstName = "Faîtes",
                EditorLastName = "Greiser",
                Title = "Phalacrocorax carbo",
                Isbn = "460877717-3",
                Type = "printed",
                Year = 2007,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 752,
                EditorFirstName = "Åslög",
                EditorLastName = "Oldnall",
                Title = "Lamprotornis chalybaeus",
                Isbn = "352845934-4",
                Type = "electronic",
                Year = 1996,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 753,
                EditorFirstName = "Loïs",
                EditorLastName = "Brauner",
                Title = "Aonyx capensis",
                Isbn = "573189384-5",
                Type = "electronic",
                Year = 2011,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 754,
                EditorFirstName = "Eloïse",
                EditorLastName = "Greyes",
                Title = "Pycnonotus barbatus",
                Isbn = "774248345-9",
                Type = "electronic",
                Year = 2006,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 755,
                EditorFirstName = "Laurène",
                EditorLastName = "Featherstonhaugh",
                Title = "Tadorna tadorna",
                Isbn = "295188507-5",
                Type = "electronic",
                Year = 1998,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 756,
                EditorFirstName = "Célestine",
                EditorLastName = "Merkle",
                Title = "Ara macao",
                Isbn = "668192221-X",
                Type = "printed",
                Year = 1994,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 757,
                EditorFirstName = "Erwéi",
                EditorLastName = "Dymick",
                Title = "Helogale undulata",
                Isbn = "989120999-7",
                Type = "electronic",
                Year = 1998,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 758,
                EditorFirstName = "Félicie",
                EditorLastName = "Zarb",
                Title = "Turtur chalcospilos",
                Isbn = "209588655-0",
                Type = "printed",
                Year = 1987,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 759,
                EditorFirstName = "Célestine",
                EditorLastName = "Broadey",
                Title = "Pavo cristatus",
                Isbn = "897315715-9",
                Type = "electronic",
                Year = 2000,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 760,
                EditorFirstName = "Mélinda",
                EditorLastName = "Mackrill",
                Title = "Salvadora hexalepis",
                Isbn = "800079839-5",
                Type = "printed",
                Year = 1989,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 761,
                EditorFirstName = "Esbjörn",
                EditorLastName = "Steptowe",
                Title = "Chloephaga melanoptera",
                Isbn = "339863668-3",
                Type = "printed",
                Year = 1997,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 762,
                EditorFirstName = "Michèle",
                EditorLastName = "Fleeming",
                Title = "Redunca redunca",
                Isbn = "035924119-0",
                Type = "electronic",
                Year = 1992,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 763,
                EditorFirstName = "Méline",
                EditorLastName = "Queripel",
                Title = "Lorythaixo ides concolor",
                Isbn = "013230508-9",
                Type = "electronic",
                Year = 2001,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 764,
                EditorFirstName = "Yè",
                EditorLastName = "Lambarton",
                Title = "Trichoglossus chlorolep    idotus",
                Isbn = "004344513-6",
                Type = "printed",
                Year = 1984,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 765,
                EditorFirstName = "Dà",
                EditorLastName = "Coltart",
                Title = "Phalacrocorax carbo",
                Isbn = "339928850-6",
                Type = "printed",
                Year = 1993,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 766,
                EditorFirstName = "Yénora",
                EditorLastName = "Steeden",
                Title = null,
                Isbn = "964496147-1",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 767,
                EditorFirstName = "Fèi",
                EditorLastName = "Twaite",
                Title = "Canis aureus",
                Isbn = "075658610-0",
                Type = "printed",
                Year = 1996,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 768,
                EditorFirstName = "Géraldine",
                EditorLastName = "Pimblotte",
                Title = "Lorythaixo ides concolor",
                Isbn = "543110345-8",
                Type = "electronic",
                Year = 1991,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 769,
                EditorFirstName = "Lèi",
                EditorLastName = "Huie",
                Title = "Anas bahamensis",
                Isbn = "800025074-8",
                Type = "printed",
                Year = 2000,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 770,
                EditorFirstName = "Ophélie",
                EditorLastName = "Hainey",
                Title = "Macropus rufogriseus",
                Isbn = "797655176-0",
                Type = "printed",
                Year = 1994,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 771,
                EditorFirstName = "Océane",
                EditorLastName = "Trusse",
                Title = "Tiliqua scinco ides",
                Isbn = "014294791-1",
                Type = "electronic",
                Year = 2007,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 772,
                EditorFirstName = "Véronique",
                EditorLastName = "Chapelle",
                Title = "Ciconia ciconia",
                Isbn = "565378798-1",
                Type = "printed",
                Year = 2006,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 773,
                EditorFirstName = "Clélia",
                EditorLastName = "Mewett",
                Title = "Sagittarius serpentarius",
                Isbn = "809752669-7",
                Type = "electronic",
                Year = 2006,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 774,
                EditorFirstName = "Lyséa",
                EditorLastName = null,
                Title = "Felis silvestris lybica",
                Isbn = "073955355-0",
                Type = "electronic",
                Year = 2007,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 775,
                EditorFirstName = "Andréanne",
                EditorLastName = "Rysdale",
                Title = "Crotalus cerastes",
                Isbn = "533749679-4",
                Type = "electronic",
                Year = 1995,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 776,
                EditorFirstName = "Eléa",
                EditorLastName = "Mordue",
                Title = "Eremophila alpestris",
                Isbn = "701238913-3",
                Type = "electronic",
                Year = 2000,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 777,
                EditorFirstName = "Eloïse",
                EditorLastName = "Khristyukhin",
                Title = "Ninox superciliaris",
                Isbn = "314136300-5",
                Type = "printed",
                Year = 1994,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 778,
                EditorFirstName = "Félicie",
                EditorLastName = "Gerrens",
                Title = "Potos flavus",
                Isbn = "735760290-7",
                Type = "electronic",
                Year = 1987,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 779,
                EditorFirstName = "Lèi",
                EditorLastName = "O'Hannay",
                Title = "Ardea cinerea",
                Isbn = "208322722-0",
                Type = "printed",
                Year = 2004,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 780,
                EditorFirstName = "Maëlys",
                EditorLastName = "Durran",
                Title = "Dendrohyrax brucel",
                Isbn = "674552877-0",
                Type = "printed",
                Year = 1997,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 781,
                EditorFirstName = "Léonore",
                EditorLastName = "Brandom",
                Title = "Actophilornis africanus",
                Isbn = "214354659-9",
                Type = "printed",
                Year = 2012,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 782,
                EditorFirstName = "Loïs",
                EditorLastName = "Jurasz",
                Title = "Aonyx cinerea",
                Isbn = "228715247-4",
                Type = "printed",
                Year = 2004,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 783,
                EditorFirstName = "Léa",
                EditorLastName = "Bullers",
                Title = "Stercorarius longicausus",
                Isbn = "313204824-0",
                Type = "electronic",
                Year = 2011,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 784,
                EditorFirstName = "Maëly",
                EditorLastName = "Andrin",
                Title = "Corvus brachyrhynchos",
                Isbn = "108347934-2",
                Type = "printed",
                Year = 1997,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 785,
                EditorFirstName = "Loïca",
                EditorLastName = "Blowing",
                Title = "Macropus parryi",
                Isbn = "124355262-X",
                Type = "printed",
                Year = 2001,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 786,
                EditorFirstName = "Maëlla",
                EditorLastName = null,
                Title = "Helogale undulata",
                Isbn = "306321804-9",
                Type = "printed",
                Year = 1993,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 787,
                EditorFirstName = "Kù",
                EditorLastName = "Rendall",
                Title = "Uraeginthus granatina",
                Isbn = "604253411-4",
                Type = "electronic",
                Year = 1991,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 788,
                EditorFirstName = "Mélia",
                EditorLastName = "Welberry",
                Title = "Ceratotherium simum",
                Isbn = "764891792-0",
                Type = "printed",
                Year = 2004,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 789,
                EditorFirstName = "Gaétane",
                EditorLastName = "Craven",
                Title = "Ardea cinerea",
                Isbn = "259381604-X",
                Type = "electronic",
                Year = 2008,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 790,
                EditorFirstName = "Maëlyss",
                EditorLastName = "Summerson",
                Title = "unavailable",
                Isbn = "651806074-3",
                Type = "printed",
                Year = 2004,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 791,
                EditorFirstName = "Léonie",
                EditorLastName = "Proske",
                Title = "Ploceus intermedius",
                Isbn = "986351968-5",
                Type = "electronic",
                Year = 2013,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 792,
                EditorFirstName = "Eugénie",
                EditorLastName = "Bra   idford",
                Title = null,
                Isbn = "529230641-X",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 793,
                EditorFirstName = "Kévina",
                EditorLastName = "Tumulty",
                Title = "Vanessa indica",
                Isbn = "649512929-7",
                Type = "electronic",
                Year = 1995,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 794,
                EditorFirstName = "Stéphanie",
                EditorLastName = "Fritzer",
                Title = "Tachybaptus ruficollis",
                Isbn = "031940830-2",
                Type = "printed",
                Year = 2002,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 795,
                EditorFirstName = "Danièle",
                EditorLastName = "Tenpenny",
                Title = "Canis lupus baileyi",
                Isbn = "665259104-9",
                Type = "electronic",
                Year = 2006,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 796,
                EditorFirstName = "Alizée",
                EditorLastName = "Cunnow",
                Title = "Ara chloroptera",
                Isbn = "792002665-2",
                Type = "printed",
                Year = 2012,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 797,
                EditorFirstName = "Lèi",
                EditorLastName = "Leavesley",
                Title = "Chionis alba",
                Isbn = "667362604-6",
                Type = "printed",
                Year = 2004,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 798,
                EditorFirstName = "Miléna",
                EditorLastName = "Tesdale",
                Title = "Butor  ides striatus",
                Isbn = "702769784-X",
                Type = "printed",
                Year = 1994,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 799,
                EditorFirstName = "Naéva",
                EditorLastName = "Pethick",
                Title = "Dasyurus viverrinus",
                Isbn = "950754490-9",
                Type = "electronic",
                Year = 2006,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 800,
                EditorFirstName = "Bérénice",
                EditorLastName = "Farnan",
                Title = "Cordylus giganteus",
                Isbn = "623664294-X",
                Type = "electronic",
                Year = 2010,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 801,
                EditorFirstName = "Vérane",
                EditorLastName = "Petricek",
                Title = "Climacteris melanura",
                Isbn = "830797162-4",
                Type = "printed",
                Year = 2004,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 802,
                EditorFirstName = "Göran",
                EditorLastName = "Shepeard",
                Title = "Philetairus socius",
                Isbn = "872197160-9",
                Type = "printed",
                Year = 1992,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 803,
                EditorFirstName = "Vérane",
                EditorLastName = "Simondson",
                Title = "Centrocercus urophasianus",
                Isbn = "364549375-1",
                Type = "electronic",
                Year = 1998,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 804,
                EditorFirstName = "Bécassine",
                EditorLastName = "Barts",
                Title = "Phalaropus lobatus",
                Isbn = "690012273-6",
                Type = "electronic",
                Year = 2012,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 805,
                EditorFirstName = "Clélia",
                EditorLastName = "Sayburn",
                Title = "Columba palumbus",
                Isbn = "628552131-X",
                Type = "printed",
                Year = 1993,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 806,
                EditorFirstName = "Aurélie",
                EditorLastName = null,
                Title = "Naja haje",
                Isbn = "521243831-4",
                Type = "printed",
                Year = 1989,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 807,
                EditorFirstName = "Adélie",
                EditorLastName = "Nicklin",
                Title = "Odocoileus hemionus",
                Isbn = "229773847-1",
                Type = "electronic",
                Year = 1984,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 808,
                EditorFirstName = "Séverine",
                EditorLastName = "Treharne",
                Title = "Echimys chrysurus",
                Isbn = "910080406-1",
                Type = "printed",
                Year = 2000,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 809,
                EditorFirstName = "Rébecca",
                EditorLastName = "Cherry",
                Title = "Zalophus californicus",
                Isbn = "046842932-8",
                Type = "electronic",
                Year = 2002,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 810,
                EditorFirstName = "Pénélope",
                EditorLastName = "Hamlett",
                Title = "Felis concolor",
                Isbn = "971310943-0",
                Type = "printed",
                Year = 2004,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 811,
                EditorFirstName = "Maïté",
                EditorLastName = "Birkett",
                Title = "Potorous tr    idactylus",
                Isbn = "447490743-4",
                Type = "printed",
                Year = 2006,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 812,
                EditorFirstName = "Estée",
                EditorLastName = "Windram",
                Title = "Agama sp.",
                Isbn = "465846894-8",
                Type = "electronic",
                Year = 1986,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 813,
                EditorFirstName = "Mårten",
                EditorLastName = "Stanion",
                Title = "Zalophus californicus",
                Isbn = "710981795-4",
                Type = "electronic",
                Year = 2009,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 814,
                EditorFirstName = "Måns",
                EditorLastName = "Speck",
                Title = "Macropus rufogriseus",
                Isbn = "086789697-3",
                Type = "printed",
                Year = 2005,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 815,
                EditorFirstName = "Rachèle",
                EditorLastName = "Lumley",
                Title = "Marmota caligata",
                Isbn = "115684339-1",
                Type = "electronic",
                Year = 1992,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 816,
                EditorFirstName = "Publicité",
                EditorLastName = "McCahey",
                Title = "Ratufa indica",
                Isbn = "691512877-8",
                Type = "printed",
                Year = 2010,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 817,
                EditorFirstName = "Lyséa",
                EditorLastName = "Ebbing",
                Title = "Phalaropus lobatus",
                Isbn = "259469528-9",
                Type = "printed",
                Year = 1993,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 818,
                EditorFirstName = "Gwenaëlle",
                EditorLastName = "Aseef",
                Title = "Terathopius ecaudatus",
                Isbn = "804615236-6",
                Type = "electronic",
                Year = 2004,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 819,
                EditorFirstName = "Görel",
                EditorLastName = "Cubbon",
                Title = "Tursiops truncatus",
                Isbn = "471284544-9",
                Type = "printed",
                Year = 2003,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 820,
                EditorFirstName = "Stéphanie",
                EditorLastName = null,
                Title = "Echimys chrysurus",
                Isbn = "921657772-X",
                Type = "electronic",
                Year = 1999,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 821,
                EditorFirstName = "Cécile",
                EditorLastName = "Lax",
                Title = "Semnopithecus entellus",
                Isbn = "286166304-9",
                Type = "electronic",
                Year = 2000,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 822,
                EditorFirstName = "Dafnée",
                EditorLastName = "Darwent",
                Title = "Damaliscus dorcas",
                Isbn = "075961682-5",
                Type = "printed",
                Year = 2008,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 823,
                EditorFirstName = "Sélène",
                EditorLastName = "Jedraszczyk",
                Title = "Macaca mulatta",
                Isbn = "120707227-3",
                Type = "electronic",
                Year = 2008,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 824,
                EditorFirstName = "Loïca",
                EditorLastName = "O'Brollachain",
                Title = "Dusicyon thous",
                Isbn = "018152604-2",
                Type = "electronic",
                Year = 2005,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 825,
                EditorFirstName = "Thérèse",
                EditorLastName = "Waugh",
                Title = "Mephitis mephitis",
                Isbn = "375114314-9",
                Type = "electronic",
                Year = 1995,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 826,
                EditorFirstName = "Åsa",
                EditorLastName = "Halle",
                Title = "Phascogale tapoatafa",
                Isbn = "577374246-2",
                Type = "printed",
                Year = 2011,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 827,
                EditorFirstName = "Kévina",
                EditorLastName = "Powley",
                Title = "Ciconia episcopus",
                Isbn = "964390261-7",
                Type = "printed",
                Year = 2006,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 828,
                EditorFirstName = "Aí",
                EditorLastName = "Giriardelli",
                Title = "Dasyprocta leporina",
                Isbn = "010688007-1",
                Type = "electronic",
                Year = 1989,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 829,
                EditorFirstName = "Mà",
                EditorLastName = "Tampin",
                Title = "Ammospermophilus nelsoni",
                Isbn = "400987979-3",
                Type = "printed",
                Year = 2002,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 830,
                EditorFirstName = "Léone",
                EditorLastName = "Humberstone",
                Title = "Bettongia penicillata",
                Isbn = "912926735-8",
                Type = "electronic",
                Year = 2006,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 831,
                EditorFirstName = "Tú",
                EditorLastName = "Yendall",
                Title = "Eubalaena australis",
                Isbn = "531404147-2",
                Type = "electronic",
                Year = 2003,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 832,
                EditorFirstName = "Mélys",
                EditorLastName = null,
                Title = "Sylvilagus flor    idanus",
                Isbn = "895117877-3",
                Type = "electronic",
                Year = 2008,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 833,
                EditorFirstName = "Amélie",
                EditorLastName = "Thackray",
                Title = null,
                Isbn = "738869312-2",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 834,
                EditorFirstName = "Mélinda",
                EditorLastName = "Beeres",
                Title = "Canis lupus",
                Isbn = "837794119-8",
                Type = "electronic",
                Year = 2011,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 835,
                EditorFirstName = "Amélie",
                EditorLastName = "Luscombe",
                Title = "Lamprotornis nitens",
                Isbn = "593165006-7",
                Type = "electronic",
                Year = 1994,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 836,
                EditorFirstName = "André",
                EditorLastName = "Earwaker",
                Title = "Funambulus pennati",
                Isbn = "539849478-3",
                Type = "electronic",
                Year = 2008,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 837,
                EditorFirstName = "Anaël",
                EditorLastName = "Corkill",
                Title = "Columba livia",
                Isbn = null,
                Type = "printed",
                Year = 2006,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 838,
                EditorFirstName = "Anaëlle",
                EditorLastName = "Bavr  idge",
                Title = "Pteronura brasiliensis",
                Isbn = "746596267-6",
                Type = "electronic",
                Year = 2006,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 839,
                EditorFirstName = "Marie-françoise",
                EditorLastName = "Auletta",
                Title = "Tenrec ecaudatus",
                Isbn = "964576737-7",
                Type = "electronic",
                Year = 1997,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 840,
                EditorFirstName = "Marie-noël",
                EditorLastName = "Scroggs",
                Title = "Helogale undulata",
                Isbn = "484599840-8",
                Type = "electronic",
                Year = 1985,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 841,
                EditorFirstName = "Méghane",
                EditorLastName = "Buffham",
                Title = "Oxybelis fulg  idus",
                Isbn = "373876775-4",
                Type = "electronic",
                Year = 2008,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 842,
                EditorFirstName = "Léana",
                EditorLastName = "Pears",
                Title = "Actophilornis africanus",
                Isbn = "904853972-2",
                Type = "electronic",
                Year = 1998,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 843,
                EditorFirstName = "Naéva",
                EditorLastName = "Frackiewicz",
                Title = "Felis silvestris lybica",
                Isbn = "168216424-1",
                Type = "printed",
                Year = 2002,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 844,
                EditorFirstName = "Pénélope",
                EditorLastName = null,
                Title = "Cathartes aura",
                Isbn = "970753708-6",
                Type = "electronic",
                Year = 1995,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 845,
                EditorFirstName = "Yáo",
                EditorLastName = "Mandeville",
                Title = "Crotalus adamanteus",
                Isbn = "835500806-5",
                Type = "electronic",
                Year = 2009,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 846,
                EditorFirstName = "Yáo",
                EditorLastName = null,
                Title = "Cebus albifrons",
                Isbn = "662911750-6",
                Type = "printed",
                Year = 1996,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 847,
                EditorFirstName = "Maëlys",
                EditorLastName = "Garrick",
                Title = "Bison bison",
                Isbn = "486472614-0",
                Type = "electronic",
                Year = 1992,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 848,
                EditorFirstName = "Åsa",
                EditorLastName = "Goulborn",
                Title = "Corvus albicollis",
                Isbn = "770923944-7",
                Type = "printed",
                Year = 2004,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 849,
                EditorFirstName = "Intéressant",
                EditorLastName = "Blackesland",
                Title = "unavailable",
                Isbn = "505674071-3",
                Type = "printed",
                Year = 1986,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 850,
                EditorFirstName = "Marie-françoise",
                EditorLastName = "Rickesies",
                Title = "Gymnorhina tibicen",
                Isbn = "945744958-4",
                Type = "electronic",
                Year = 1994,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 851,
                EditorFirstName = "Agnès",
                EditorLastName = "Rosendall",
                Title = "Pteronura brasiliensis",
                Isbn = "779732146-9",
                Type = "printed",
                Year = 2005,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 852,
                EditorFirstName = "Sélène",
                EditorLastName = "Nozzolinii",
                Title = "Microcebus murinus",
                Isbn = "173261049-5",
                Type = "electronic",
                Year = 1958,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 853,
                EditorFirstName = "Frédérique",
                EditorLastName = "Hamlin",
                Title = "Haliaeetus leucocephalus",
                Isbn = "720596985-9",
                Type = "printed",
                Year = 1993,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 854,
                EditorFirstName = "Maéna",
                EditorLastName = "Kenrat",
                Title = "Helogale undulata",
                Isbn = "643954340-7",
                Type = "electronic",
                Year = 1990,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 855,
                EditorFirstName = "Maëly",
                EditorLastName = "Maundrell",
                Title = "Ninox superciliaris",
                Isbn = "242744944-X",
                Type = "printed",
                Year = 2004,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 856,
                EditorFirstName = "Naéva",
                EditorLastName = "Kovnot",
                Title = "Phalaropus lobatus",
                Isbn = "251716425-8",
                Type = "electronic",
                Year = 2003,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 857,
                EditorFirstName = "Lóng",
                EditorLastName = "Deppen",
                Title = "Perameles nasuta",
                Isbn = null,
                Type = "printed",
                Year = 2008,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 858,
                EditorFirstName = "Mén",
                EditorLastName = "Keppe",
                Title = "Acrobates pygmaeus",
                Isbn = null,
                Type = "electronic",
                Year = 2009,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 859,
                EditorFirstName = "Gisèle",
                EditorLastName = "O' Hern",
                Title = "Vanellus armatus",
                Isbn = "583735503-0",
                Type = "electronic",
                Year = 2007,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 860,
                EditorFirstName = "Intéressant",
                EditorLastName = "Von Oertzen",
                Title = "Bassariscus astutus",
                Isbn = "851589307-X",
                Type = "electronic",
                Year = 1998,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 861,
                EditorFirstName = "Mélissandre",
                EditorLastName = "Bonsey",
                Title = "Alcelaphus buselaphus cokii",
                Isbn = "902156321-5",
                Type = "printed",
                Year = 2000,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 862,
                EditorFirstName = "Estée",
                EditorLastName = null,
                Title = "Zosterops pall idus",
                Isbn = "566784430-3",
                Type = "electronic",
                Year = 2006,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 863,
                EditorFirstName = "Fèi",
                EditorLastName = "Fairbairn",
                Title = "Pseudocheirus peregrinus",
                Isbn = "064841409-4",
                Type = "electronic",
                Year = 2005,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 864,
                EditorFirstName = "Danièle",
                EditorLastName = "Bernth",
                Title = "Crocodylus niloticus",
                Isbn = "969859810-3",
                Type = "electronic",
                Year = 2001,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 865,
                EditorFirstName = "Céline",
                EditorLastName = "Pendre",
                Title = "Macropus giganteus",
                Isbn = "361870671-5",
                Type = "electronic",
                Year = 1989,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 866,
                EditorFirstName = "Hélène",
                EditorLastName = "Thibodeaux",
                Title = "Motacilla aguimp",
                Isbn = "143417612-6",
                Type = "printed",
                Year = 1997,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 867,
                EditorFirstName = "Léonie",
                EditorLastName = "Antonacci",
                Title = "Anser anser",
                Isbn = "581137036-9",
                Type = "printed",
                Year = 2008,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 868,
                EditorFirstName = "Néhémie",
                EditorLastName = null,
                Title = "Gyps bengalensis",
                Isbn = "958415508-3",
                Type = "printed",
                Year = 2007,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 869,
                EditorFirstName = "Camélia",
                EditorLastName = "Mor",
                Title = "Ammospermophilus nelsoni",
                Isbn = "789350674-1",
                Type = "printed",
                Year = 1979,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 870,
                EditorFirstName = "Michèle",
                EditorLastName = "K id",
                Title = "Sarcorhamphus papa",
                Isbn = "744364938-X",
                Type = "electronic",
                Year = 2004,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 871,
                EditorFirstName = "Ráo",
                EditorLastName = "Gligorijevic",
                Title = "Amblyrhynchus cristatus",
                Isbn = "658082465-4",
                Type = "printed",
                Year = 1975,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 872,
                EditorFirstName = "Lorène",
                EditorLastName = "Moggle",
                Title = "Sterna paradisaea",
                Isbn = "761196584-0",
                Type = "printed",
                Year = 1996,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 873,
                EditorFirstName = "Océanne",
                EditorLastName = "Tootell",
                Title = "Phoca vitulina",
                Isbn = "366672997-5",
                Type = "electronic",
                Year = 1988,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 874,
                EditorFirstName = "Åslög",
                EditorLastName = "Haverty",
                Title = "Corythornis cristata",
                Isbn = "613509046-1",
                Type = "electronic",
                Year = 2012,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 875,
                EditorFirstName = "Adélaïde",
                EditorLastName = "Realy",
                Title = "Pteronura brasiliensis",
                Isbn = "811532313-6",
                Type = "electronic",
                Year = 2008,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 876,
                EditorFirstName = "Noëlla",
                EditorLastName = "Kop",
                Title = "Gyps bengalensis",
                Isbn = "569075632-6",
                Type = "printed",
                Year = 1980,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 877,
                EditorFirstName = "Géraldine",
                EditorLastName = "Teaz",
                Title = "Acrobates pygmaeus",
                Isbn = "935518187-6",
                Type = "electronic",
                Year = 2005,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 878,
                EditorFirstName = "Pål",
                EditorLastName = "Strettle",
                Title = "Bettongia penicillata",
                Isbn = "300773094-5",
                Type = "printed",
                Year = 2007,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 879,
                EditorFirstName = "Chloé",
                EditorLastName = "Bassam",
                Title = "Bubulcus ibis",
                Isbn = "054861424-5",
                Type = "printed",
                Year = 1995,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 880,
                EditorFirstName = "Personnalisée",
                EditorLastName = "Kale",
                Title = "Lamprotornis chalybaeus",
                Isbn = "497484082-7",
                Type = "electronic",
                Year = 1994,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 881,
                EditorFirstName = "Marlène",
                EditorLastName = "Rate",
                Title = "Amazona sp.",
                Isbn = "135340036-0",
                Type = "printed",
                Year = 1996,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 882,
                EditorFirstName = "Maéna",
                EditorLastName = "Simkin",
                Title = "Zonotrichia capensis",
                Isbn = "264786639-2",
                Type = "electronic",
                Year = 1993,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 883,
                EditorFirstName = "Angèle",
                EditorLastName = "Stepto",
                Title = "Macaca mulatta",
                Isbn = "785969185-X",
                Type = "electronic",
                Year = 2002,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 884,
                EditorFirstName = "Maëlann",
                EditorLastName = "Bownass",
                Title = "Chloephaga melanoptera",
                Isbn = "477850402-X",
                Type = "printed",
                Year = 1991,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 885,
                EditorFirstName = "Méghane",
                EditorLastName = null,
                Title = "Galago crassicaudataus",
                Isbn = "108674836-0",
                Type = "printed",
                Year = 1994,
                Journal = "Emerald"
            },
            
            new Publication 
            {
                Id = 886,
                EditorFirstName = "Amélie",
                EditorLastName = "Theyer",
                Title = "Connochaetus taurinus",
                Isbn = "298444056-0",
                Type = "printed",
                Year = 1993,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 887,
                EditorFirstName = "Cloé",
                EditorLastName = "Butson",
                Title = "Phalaropus fulicarius",
                Isbn = "281712343-3",
                Type = "printed",
                Year = 2000,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 888,
                EditorFirstName = "Marylène",
                EditorLastName = "Nickels",
                Title = "Nannopterum harrisi",
                Isbn = "508218288-9",
                Type = "electronic",
                Year = 2008,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 889,
                EditorFirstName = "Kévina",
                EditorLastName = "Feige",
                Title = "Lamprotornis sp.",
                Isbn = "662436175-1",
                Type = "printed",
                Year = 2003,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 890,
                EditorFirstName = "Rébecca",
                EditorLastName = "Wallworth",
                Title = "Felis concolor",
                Isbn = "275970715-6",
                Type = "printed",
                Year = 2009,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 891,
                EditorFirstName = "Gisèle",
                EditorLastName = "Janning",
                Title = "Colaptes campestro ides",
                Isbn = "751091423-X",
                Type = "printed",
                Year = 1990,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 892,
                EditorFirstName = "Mélys",
                EditorLastName = "Tregien",
                Title = "Ephippiorhynchus mycteria",
                Isbn = "049071491-9",
                Type = "electronic",
                Year = 2010,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 893,
                EditorFirstName = "Léa",
                EditorLastName = "Pattinson",
                Title = "Pelecans onocratalus",
                Isbn = "497280136-0",
                Type = "electronic",
                Year = 2010,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 894,
                EditorFirstName = "Maï",
                EditorLastName = "Jeanel",
                Title = "Haliaeetus leucoryphus",
                Isbn = "607025535-6",
                Type = "electronic",
                Year = 1959,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 895,
                EditorFirstName = "Françoise",
                EditorLastName = "Colaco",
                Title = "Zena   ida asiatica",
                Isbn = "391605291-8",
                Type = "printed",
                Year = 1989,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 896,
                EditorFirstName = "Miléna",
                EditorLastName = "Haslum",
                Title = "Heloderma horr idum",
                Isbn = "134727039-6",
                Type = "printed",
                Year = 1997,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 897,
                EditorFirstName = "Håkan",
                EditorLastName = "Kear",
                Title = "Choloepus hoffmani",
                Isbn = "785941736-7",
                Type = "printed",
                Year = 1986,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 898,
                EditorFirstName = "Naëlle",
                EditorLastName = "Minshull",
                Title = "Eudyptula minor",
                Isbn = "242107102-X",
                Type = "electronic",
                Year = 2009,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 899,
                EditorFirstName = "Aurélie",
                EditorLastName = "Mosdall",
                Title = "Phoenicopterus ruber",
                Isbn = "040625892-9",
                Type = "printed",
                Year = 1997,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 900,
                EditorFirstName = "Cécilia",
                EditorLastName = "Zupa",
                Title = "Echimys chrysurus",
                Isbn = "173651883-6",
                Type = "electronic",
                Year = 1992,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 901,
                EditorFirstName = "Pål",
                EditorLastName = "Branchet",
                Title = "Oryx gazella",
                Isbn = "942474755-1",
                Type = "electronic",
                Year = 1996,
                Journal = "Ingenta"
            },
            
            new Publication 
            {
                Id = 902,
                EditorFirstName = "Andréanne",
                EditorLastName = "Malinson",
                Title = "Hippotragus equinus",
                Isbn = "949761972-3",
                Type = "electronic",
                Year = 1959,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 903,
                EditorFirstName = "Yè",
                EditorLastName = "Shearstone",
                Title = "Corythornis cristata",
                Isbn = "243104790-3",
                Type = "electronic",
                Year = 1993,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 904,
                EditorFirstName = "Yè",
                EditorLastName = "Elphick",
                Title = "Equus burchelli",
                Isbn = "364679846-7",
                Type = "printed",
                Year = 2010,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 905,
                EditorFirstName = "Adèle",
                EditorLastName = "Askham",
                Title = "Lophoaetus occipitalis",
                Isbn = "716714332-4",
                Type = "electronic",
                Year = 1984,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 906,
                EditorFirstName = "Aloïs",
                EditorLastName = "Monk",
                Title = "Columba palumbus",
                Isbn = "083565333-1",
                Type = "electronic",
                Year = 1998,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 907,
                EditorFirstName = "Mélys",
                EditorLastName = "Ekkel",
                Title = "Papilio canadensis",
                Isbn = "253169158-8",
                Type = "electronic",
                Year = 1995,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 908,
                EditorFirstName = "Dafnée",
                EditorLastName = "Olsen",
                Title = "Ara macao",
                Isbn = "685688523-7",
                Type = "electronic",
                Year = 1984,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 909,
                EditorFirstName = "Rébecca",
                EditorLastName = null,
                Title = "Grus antigone",
                Isbn = "363683912-8",
                Type = "printed",
                Year = 2005,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 910,
                EditorFirstName = "Léane",
                EditorLastName = "Shawyer",
                Title = "Phalacrocorax varius",
                Isbn = "220702579-9",
                Type = "electronic",
                Year = 2009,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 911,
                EditorFirstName = "Maëline",
                EditorLastName = null,
                Title = "Tockus flavirostris",
                Isbn = "886581133-1",
                Type = "electronic",
                Year = 1972,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 912,
                EditorFirstName = "Méline",
                EditorLastName = "Scouse",
                Title = "unavailable",
                Isbn = "943565865-2",
                Type = "electronic",
                Year = 2010,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 913,
                EditorFirstName = "Marlène",
                EditorLastName = "Ziemens",
                Title = "Papio cynocephalus",
                Isbn = "322296260-X",
                Type = "printed",
                Year = 1997,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 914,
                EditorFirstName = "Stéphanie",
                EditorLastName = "Samett",
                Title = "Cracticus nigroagularis",
                Isbn = "226919938-3",
                Type = "electronic",
                Year = 2010,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 915,
                EditorFirstName = "Irène",
                EditorLastName = "Spenley",
                Title = "Creagrus furcatus",
                Isbn = "985601405-0",
                Type = "printed",
                Year = 2010,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 916,
                EditorFirstName = "Océanne",
                EditorLastName = "Custy",
                Title = "Bubulcus ibis",
                Isbn = "621786279-4",
                Type = "electronic",
                Year = 2002,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 917,
                EditorFirstName = "Estève",
                EditorLastName = "Kenwyn",
                Title = "Varanus salvator",
                Isbn = "992741039-5",
                Type = "electronic",
                Year = 2004,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 918,
                EditorFirstName = "Pål",
                EditorLastName = "Furminger",
                Title = "Coendou prehensilis",
                Isbn = "399578877-7",
                Type = "printed",
                Year = 2005,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 919,
                EditorFirstName = "Françoise",
                EditorLastName = "Gritskov",
                Title = "Anthropo   ides paradisea",
                Isbn = "664219409-8",
                Type = "electronic",
                Year = 1996,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 920,
                EditorFirstName = "Maïly",
                EditorLastName = "Benediktovich",
                Title = "Tachyglossus aculeatus",
                Isbn = "436929254-9",
                Type = "electronic",
                Year = 1993,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 921,
                EditorFirstName = "Clélia",
                EditorLastName = "Day",
                Title = "Priodontes maximus",
                Isbn = "153320426-8",
                Type = "electronic",
                Year = 2008,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 922,
                EditorFirstName = "Märta",
                EditorLastName = "Hawkshaw",
                Title = "Microcebus murinus",
                Isbn = "035392824-0",
                Type = "electronic",
                Year = 1994,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 923,
                EditorFirstName = "Méryl",
                EditorLastName = "Branson",
                Title = "Equus hemionus",
                Isbn = "592542321-6",
                Type = "printed",
                Year = 2001,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 924,
                EditorFirstName = "Jú",
                EditorLastName = "Carous",
                Title = "Genetta genetta",
                Isbn = "454360003-7",
                Type = "electronic",
                Year = 2004,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 925,
                EditorFirstName = "Bérangère",
                EditorLastName = "Brea",
                Title = "Lemur catta",
                Isbn = "567218911-3",
                Type = "electronic",
                Year = 1968,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 926,
                EditorFirstName = "Åsa",
                EditorLastName = "Kemshell",
                Title = "Plegadis r idgwayi",
                Isbn = "540804593-5",
                Type = "electronic",
                Year = 2013,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 927,
                EditorFirstName = "Noëlla",
                EditorLastName = "Masseo",
                Title = "Macropus agilis",
                Isbn = "245559264-2",
                Type = "printed",
                Year = 2000,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 928,
                EditorFirstName = "Céline",
                EditorLastName = "Skittle",
                Title = null,
                Isbn = "443947993-6",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 929,
                EditorFirstName = "Anaé",
                EditorLastName = null,
                Title = "Sterna paradisaea",
                Isbn = "032412932-7",
                Type = "electronic",
                Year = 2010,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 930,
                EditorFirstName = "Sòng",
                EditorLastName = "MacTerlagh",
                Title = "Funambulus pennati",
                Isbn = "210809956-5",
                Type = "printed",
                Year = 1986,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 931,
                EditorFirstName = "Cléa",
                EditorLastName = "Dowrey",
                Title = "Ctenophorus ornatus",
                Isbn = "541313881-4",
                Type = "printed",
                Year = 2012,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 932,
                EditorFirstName = "Styrbjörn",
                EditorLastName = "Kroch",
                Title = "Phoenicopterus ruber",
                Isbn = "790463216-0",
                Type = "electronic",
                Year = 2005,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 933,
                EditorFirstName = "Adèle",
                EditorLastName = "Bellie",
                Title = "Porphyrio porphyrio",
                Isbn = "216569532-5",
                Type = "electronic",
                Year = 1994,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 934,
                EditorFirstName = "Märta",
                EditorLastName = "Oxbe",
                Title = "Cracticus nigroagularis",
                Isbn = "722239183-5",
                Type = "electronic",
                Year = 1996,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 935,
                EditorFirstName = "Danièle",
                EditorLastName = "Philippart",
                Title = "Callorhinus ursinus",
                Isbn = "896595945-4",
                Type = "printed",
                Year = 1992,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 936,
                EditorFirstName = "Danièle",
                EditorLastName = "Blezard",
                Title = "Phalacrocorax brasilianus",
                Isbn = "023667461-7",
                Type = "electronic",
                Year = 2002,
                Journal = "IGI Global"
            },
            
            new Publication 
            {
                Id = 937,
                EditorFirstName = "Lóng",
                EditorLastName = "Espadater",
                Title = "Physignathus cocincinus",
                Isbn = "897213456-2",
                Type = "printed",
                Year = 2000,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 938,
                EditorFirstName = "Méghane",
                EditorLastName = "Davson",
                Title = "Haematopus ater",
                Isbn = null,
                Type = "printed",
                Year = 1997,
                Journal = "Elsevier"
            },
            
            new Publication 
            {
                Id = 939,
                EditorFirstName = "Eloïse",
                EditorLastName = "Geffen",
                Title = "Anhinga rufa",
                Isbn = "124210730-4",
                Type = "electronic",
                Year = 1996,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 940,
                EditorFirstName = "Laïla",
                EditorLastName = "Birds",
                Title = null,
                Isbn = "296380173-4",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 941,
                EditorFirstName = "Gwenaëlle",
                EditorLastName = "Creech",
                Title = "Phalaropus fulicarius",
                Isbn = "883610808-3",
                Type = "printed",
                Year = 1984,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 942,
                EditorFirstName = "Geneviève",
                EditorLastName = "Eustis",
                Title = "Acrobates pygmaeus",
                Isbn = "093975164-X",
                Type = "printed",
                Year = 1996,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 943,
                EditorFirstName = "Mélissandre",
                EditorLastName = null,
                Title = "Macropus fuliginosus",
                Isbn = "024115310-7",
                Type = "electronic",
                Year = 1993,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 944,
                EditorFirstName = "Gösta",
                EditorLastName = "Leads",
                Title = "Dendrocitta vagabunda",
                Isbn = "406068813-4",
                Type = "electronic",
                Year = 1993,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 945,
                EditorFirstName = "Mélodie",
                EditorLastName = "Geerling",
                Title = null,
                Isbn = "924192137-4",
                Type = null,
                Year = null,
                Journal = null
            },
            
            new Publication 
            {
                Id = 946,
                EditorFirstName = "Rébecca",
                EditorLastName = "Delaney",
                Title = "Macaca nemestrina",
                Isbn = "438435058-9",
                Type = "electronic",
                Year = 2002,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 947,
                EditorFirstName = "Léonore",
                EditorLastName = "Batecok",
                Title = "Columba livia",
                Isbn = "254789464-5",
                Type = "electronic",
                Year = 2006,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 948,
                EditorFirstName = "Maïly",
                EditorLastName = "Radin",
                Title = "Phalacrocorax varius",
                Isbn = "963409773-1",
                Type = "printed",
                Year = 2006,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 949,
                EditorFirstName = "Aí",
                EditorLastName = "Ruthven",
                Title = "Tadorna tadorna",
                Isbn = "754678424-7",
                Type = "printed",
                Year = 2010,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 950,
                EditorFirstName = "Eléonore",
                EditorLastName = "Perrat",
                Title = "Petaurus norfolcensis",
                Isbn = "394627960-0",
                Type = "printed",
                Year = 2000,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 951,
                EditorFirstName = "Gaïa",
                EditorLastName = "Baynes",
                Title = "Macaca nemestrina",
                Isbn = "241092724-6",
                Type = "printed",
                Year = 1993,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 952,
                EditorFirstName = "Dù",
                EditorLastName = "Brummitt",
                Title = "Lybius torquatus",
                Isbn = "984619451-X",
                Type = "electronic",
                Year = 2011,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 953,
                EditorFirstName = "Gisèle",
                EditorLastName = "O'Luby",
                Title = "Merops nubicus",
                Isbn = null,
                Type = "electronic",
                Year = 2012,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 954,
                EditorFirstName = "Laïla",
                EditorLastName = "Bowness",
                Title = "Cebus apella",
                Isbn = "743864490-1",
                Type = "printed",
                Year = 1986,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 955,
                EditorFirstName = "Åsa",
                EditorLastName = "Torrecilla",
                Title = "Phascogale tapoatafa",
                Isbn = "804216841-1",
                Type = "printed",
                Year = 2010,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 956,
                EditorFirstName = "Cunégonde",
                EditorLastName = "Sweynson",
                Title = "Gymnorhina tibicen",
                Isbn = "339844896-8",
                Type = "printed",
                Year = 1988,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 957,
                EditorFirstName = "Léana",
                EditorLastName = "Gilbee",
                Title = "Felis chaus",
                Isbn = "497222159-3",
                Type = "printed",
                Year = 1989,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 958,
                EditorFirstName = "Ruò",
                EditorLastName = "Dusting",
                Title = "Chl    idonias leucopterus",
                Isbn = "399504256-2",
                Type = "electronic",
                Year = 2009,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 959,
                EditorFirstName = "Félicie",
                EditorLastName = null,
                Title = "Canis lupus lycaon",
                Isbn = "976563247-9",
                Type = "electronic",
                Year = 2002,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 960,
                EditorFirstName = "Maëlle",
                EditorLastName = "Brecon",
                Title = "Neophoca cinerea",
                Isbn = "945748583-1",
                Type = "electronic",
                Year = 2002,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 961,
                EditorFirstName = "Jú",
                EditorLastName = "Vile",
                Title = "unavailable",
                Isbn = "733155877-3",
                Type = "electronic",
                Year = 2005,
                Journal = "Versita"
            },
            
            new Publication 
            {
                Id = 962,
                EditorFirstName = "Ruì",
                EditorLastName = "Ryde",
                Title = "Semnopithecus entellus",
                Isbn = "061416511-3",
                Type = "electronic",
                Year = 1999,
                Journal = "INFORMS"
            },
            
            new Publication 
            {
                Id = 963,
                EditorFirstName = "Håkan",
                EditorLastName = "Fernez",
                Title = "Loxodonta africana",
                Isbn = "735379643-X",
                Type = "electronic",
                Year = 1999,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 964,
                EditorFirstName = "Maéna",
                EditorLastName = "Zamboniari",
                Title = "Mabuya spilogaster",
                Isbn = "217166507-6",
                Type = "electronic",
                Year = 2006,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 965,
                EditorFirstName = "Göran",
                EditorLastName = "Atter idge",
                Title = "Tockus erythrorhyncus",
                Isbn = "468084281-4",
                Type = "electronic",
                Year = 1998,
                Journal = "IEEE"
            },
            
            new Publication 
            {
                Id = 966,
                EditorFirstName = "Måns",
                EditorLastName = "Briar",
                Title = "Pitangus sulphuratus",
                Isbn = "969260806-9",
                Type = "electronic",
                Year = 2012,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 967,
                EditorFirstName = "Inès",
                EditorLastName = "Behling",
                Title = "Taurotagus oryx",
                Isbn = "253526765-9",
                Type = "printed",
                Year = 1994,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 968,
                EditorFirstName = "Annotés",
                EditorLastName = "Van Eeden",
                Title = "unavailable",
                Isbn = "683054660-5",
                Type = "electronic",
                Year = 1989,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 969,
                EditorFirstName = "Pò",
                EditorLastName = "Cordeix",
                Title = "Aquila chrysaetos",
                Isbn = "739717201-6",
                Type = "electronic",
                Year = 2004,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 970,
                EditorFirstName = "Léana",
                EditorLastName = "Foynes",
                Title = "Macropus robustus",
                Isbn = "311532635-1",
                Type = "electronic",
                Year = 2004,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 971,
                EditorFirstName = "Ophélie",
                EditorLastName = "Riccio",
                Title = "Panthera leo",
                Isbn = "513954777-5",
                Type = "electronic",
                Year = 2011,
                Journal = "Inderscience"
            },
            
            new Publication 
            {
                Id = 972,
                EditorFirstName = "Cécilia",
                EditorLastName = "Alldr idge",
                Title = "Spheniscus magellanicus",
                Isbn = "137765198-3",
                Type = "electronic",
                Year = 2001,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 973,
                EditorFirstName = "Yè",
                EditorLastName = "Wallett",
                Title = "Fratercula corniculata",
                Isbn = "301503826-5",
                Type = "printed",
                Year = 1989,
                Journal = "Frontiers"
            },
            
            new Publication 
            {
                Id = 974,
                EditorFirstName = "Maëly",
                EditorLastName = "Lages",
                Title = "Pedetes capensis",
                Isbn = "768116417-0",
                Type = "electronic",
                Year = 2003,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 975,
                EditorFirstName = "Méghane",
                EditorLastName = "Joul",
                Title = "Pseudalopex gymnocercus",
                Isbn = "899683303-7",
                Type = "printed",
                Year = 1997,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 976,
                EditorFirstName = "Ophélie",
                EditorLastName = "Deetlof",
                Title = "Martes pennanti",
                Isbn = "062387861-5",
                Type = "printed",
                Year = 2011,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 977,
                EditorFirstName = "Intéressant",
                EditorLastName = "D'Aubney",
                Title = "Funambulus pennati",
                Isbn = "172595182-7",
                Type = "electronic",
                Year = 1983,
                Journal = "RonPub"
            },
            
            new Publication 
            {
                Id = 978,
                EditorFirstName = "Nuó",
                EditorLastName = "Crooks",
                Title = "Climacteris melanura",
                Isbn = "891932492-1",
                Type = "printed",
                Year = 2011,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 979,
                EditorFirstName = "Pò",
                EditorLastName = "Donaghy",
                Title = "Petaurus norfolcensis",
                Isbn = "009400741-1",
                Type = "electronic",
                Year = 1997,
                Journal = "MDPI"
            },
            
            new Publication 
            {
                Id = 980,
                EditorFirstName = "Léa",
                EditorLastName = "Topley",
                Title = "Macropus eugenii",
                Isbn = "183800314-2",
                Type = "electronic",
                Year = 1994,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 981,
                EditorFirstName = "Erwéi",
                EditorLastName = "Earingey",
                Title = "Aegypius occipitalis",
                Isbn = "310762703-8",
                Type = "printed",
                Year = 2008,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 982,
                EditorFirstName = "Océane",
                EditorLastName = "Bunch",
                Title = "Phalacrocorax brasilianus",
                Isbn = "148125069-8",
                Type = "printed",
                Year = 1996,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 983,
                EditorFirstName = "Mélia",
                EditorLastName = "Bemand",
                Title = "Chloephaga melanoptera",
                Isbn = "161182151-7",
                Type = "electronic",
                Year = 2002,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 984,
                EditorFirstName = "Faîtes",
                EditorLastName = "Masden",
                Title = "Damaliscus lunatus",
                Isbn = "719168008-3",
                Type = "printed",
                Year = 2010,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 985,
                EditorFirstName = "Léane",
                EditorLastName = "Buncom",
                Title = "Petaurus breviceps",
                Isbn = "476230765-3",
                Type = "electronic",
                Year = 2004,
                Journal = "ICST"
            },
            
            new Publication 
            {
                Id = 986,
                EditorFirstName = "Pål",
                EditorLastName = "Mathely",
                Title = "Anas bahamensis",
                Isbn = "971174824-X",
                Type = "printed",
                Year = 2009,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 987,
                EditorFirstName = "Gisèle",
                EditorLastName = "Guiel",
                Title = "Ovibos moschatus",
                Isbn = "684391294-X",
                Type = "printed",
                Year = 1994,
                Journal = "Springer"
            },
            
            new Publication 
            {
                Id = 988,
                EditorFirstName = "Anaïs",
                EditorLastName = "Fakeley",
                Title = "Boa constrictor mexicana",
                Isbn = "083770021-3",
                Type = "electronic",
                Year = 1985,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 989,
                EditorFirstName = "Cloé",
                EditorLastName = "Cant",
                Title = "Corvus albus",
                Isbn = "505584256-3",
                Type = "electronic",
                Year = 1967,
                Journal = "ACM"
            },
            
            new Publication 
            {
                Id = 990,
                EditorFirstName = "Yú",
                EditorLastName = "Gramer",
                Title = "Myrmecophaga tr    idactyla",
                Isbn = "517385033-7",
                Type = "electronic",
                Year = 1996,
                Journal = "BMC"
            },
            
            new Publication 
            {
                Id = 991,
                EditorFirstName = "Méryl",
                EditorLastName = "Hirtz",
                Title = "Camelus dromedarius",
                Isbn = "432361947-2",
                Type = "printed",
                Year = 1997,
                Journal = "SIAM"
            },
            
            new Publication 
            {
                Id = 992,
                EditorFirstName = "Edmée",
                EditorLastName = "Maestro",
                Title = "Tockus erythrorhyncus",
                Isbn = "596605171-2",
                Type = "printed",
                Year = 1992,
                Journal = "Oxford University Press"
            },
            
            new Publication 
            {
                Id = 993,
                EditorFirstName = "Dorothée",
                EditorLastName = "Le Borgne",
                Title = "Papilio canadensis",
                Isbn = "706736815-4",
                Type = "printed",
                Year = 1993,
                Journal = "Wiley"
            },
            
            new Publication 
            {
                Id = 994,
                EditorFirstName = "Anaël",
                EditorLastName = "Baldocci",
                Title = "Kobus defassa",
                Isbn = "689807455-5",
                Type = "electronic",
                Year = 1981,
                Journal = "Liebert Open Access"
            },
            
            new Publication 
            {
                Id = 995,
                EditorFirstName = "Aí",
                EditorLastName = "Abrahamsen",
                Title = "Herpestes javanicus",
                Isbn = "229645320-1",
                Type = "printed",
                Year = 1992,
                Journal = "IET"
            },
            
            new Publication 
            {
                Id = 996,
                EditorFirstName = "Dù",
                EditorLastName = "Sprull",
                Title = "Merops sp.",
                Isbn = "132772185-6",
                Type = "electronic",
                Year = 1995,
                Journal = "MIT Press"
            },
            
            new Publication 
            {
                Id = 997,
                EditorFirstName = "Solène",
                EditorLastName = "Omand",
                Title = "Macropus robustus",
                Isbn = "631548375-5",
                Type = "electronic",
                Year = 2003,
                Journal = "SAGE Publications"
            },
            
            new Publication 
            {
                Id = 998,
                EditorFirstName = "Gaïa",
                EditorLastName = "Clausius",
                Title = "Bubalus arnee",
                Isbn = "436412002-2",
                Type = "electronic",
                Year = 2008,
                Journal = "Hindawi"
            },
            
            new Publication 
            {
                Id = 999,
                EditorFirstName = "Aurélie",
                EditorLastName = null,
                Title = "Chauna torquata",
                Isbn = "278069117-4",
                Type = "electronic",
                Year = 2006,
                Journal = "World Scientific"
            },
            
            new Publication 
            {
                Id = 1000,
                EditorFirstName = "Amélie",
                EditorLastName = "Livezey",
                Title = "Uraeginthus granatina",
                Isbn = "512063625-X",
                Type = "electronic",
                Year = 2007,
                Journal = "MDPI"
            }
        };

        public List<Publication> Publications => _publications;
    }
}
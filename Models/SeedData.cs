using Microsoft.EntityFrameworkCore;

namespace finalProject_ThomasCrouch.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PrisonDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<PrisonDbContext>>()))
            {
                if (context.Prisons.Any())
                {
                    return;
                }
                
                context.Prisons.AddRange(
                    new Prison
                    {
                        PrisonName = "Arkham Asylum",
                        PrisonAddress = "8 Branch Drive, Mount Holly, NJ 08060",
                        WardenName = "George Washington",
                        GuardsEmployed = 75,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("7/26/1772"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Silvius Hulda", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("11/8/2036")},
                            new Prisoner {PrisonerName = "Alexandros Cadmus", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("6/20/2041")},
                            new Prisoner {PrisonerName = "Pallas Afrodita", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("10/1/2050")},
                            new Prisoner {PrisonerName = "Lugh Laokoon", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("9/23/2051")},
                            new Prisoner {PrisonerName = "Aslan Dilbert", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("10/24/2052")},
                            new Prisoner {PrisonerName = "Nodens Hasdrubal", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("7/21/2055")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Azkaban",
                        PrisonAddress = "148 East Clark St., Carmel, NY 10512",
                        WardenName = "John Adams",
                        GuardsEmployed = 46,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("6/4/1819"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Chloe Faust", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("3/16/2061")},
                            new Prisoner {PrisonerName = "Frigg Vohu Manah", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("1/30/2062")},
                            new Prisoner {PrisonerName = "Padma Muirenn", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("10/8/2064")},
                            new Prisoner {PrisonerName = "An Hermione", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("8/6/2072")},
                            new Prisoner {PrisonerName = "An Hermione", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("8/6/2075")},
                            new Prisoner {PrisonerName = "Urien Alcyone", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("5/7/2076")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Belle Reve",
                        PrisonAddress = "13 Rockledge Dr., Baltimore, MD 21206",
                        WardenName = "Thomas Jefferson",
                        GuardsEmployed = 106,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("10/21/1828"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Ulysses Ahura Mazda", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("11/24/2086")},
                            new Prisoner {PrisonerName = "Phoibos Cordeilla", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("10/1/2091")},
                            new Prisoner {PrisonerName = "Thor Ériu", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("8/18/2092")},
                            new Prisoner {PrisonerName = "Gayatri Ala", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("8/15/2096")},
                            new Prisoner {PrisonerName = "Gudrun Þrymr", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("2/2/2104")},
                            new Prisoner {PrisonerName = "Vasu Zuleika", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("8/24/2107")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Blackgate Penitentiary",
                        PrisonAddress = "658 Lake Forest Street, Hernando, MS 38632",
                        WardenName = "James Madison",
                        GuardsEmployed = 34,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("9/5/1840"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Áine Ilu", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("3/27/2024")},
                            new Prisoner {PrisonerName = "Kybele Vedast", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("7/29/2028")},
                            new Prisoner {PrisonerName = "Hasdrubal Dilbert", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("3/18/2034")},
                            new Prisoner {PrisonerName = "Legolas Modron", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("7/4/2043")},
                            new Prisoner {PrisonerName = "Anthea Tangaroa", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("9/30/2053")},
                            new Prisoner {PrisonerName = "Nerthus Uther", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("10/11/2062")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Cold Mountain Penitentiary",
                        PrisonAddress = "908 Corona Court, Kaukauna, WI 54130",
                        WardenName = "James Monroe",
                        GuardsEmployed = 71,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("11/25/1889"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Grímhildr Anakin", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("3/29/2067")},
                            new Prisoner {PrisonerName = "Dagon Xochipilli", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("5/7/2068")},
                            new Prisoner {PrisonerName = "Evadne Shankara", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("5/14/2068")},
                            new Prisoner {PrisonerName = "Iemanjá Aino", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("7/1/2071")},
                            new Prisoner {PrisonerName = "Narayana Sutekh", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("8/29/2077")},
                            new Prisoner {PrisonerName = "Cytherea Lucinda", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("11/21/2088")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Damage Control Supermax",
                        PrisonAddress = "50 Country Ave., Powhatan, VA 23139",
                        WardenName = "John Quincy Adams",
                        GuardsEmployed = 23,
                        SecurityLevel = "Minimum",
                        DateOpened = DateTime.Parse("4/17/1892"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Lucina Aoide", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("8/15/2096")},
                            new Prisoner {PrisonerName = "Armide Borghildr", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("6/26/2097")},
                            new Prisoner {PrisonerName = "Govannon Tuulikki", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("9/2/2097")},
                            new Prisoner {PrisonerName = "Aether Hippolyte", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("4/21/2098")},
                            new Prisoner {PrisonerName = "Indrani Arke", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("3/29/2100")},
                            new Prisoner {PrisonerName = "Chalchiuhtlicue Sumati", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("4/19/2105")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Durgesh Prison",
                        PrisonAddress = "7454 Birch Hill Street, Kennesaw, GA 30144",
                        WardenName = "Andrew Jackson",
                        GuardsEmployed = 69,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("12/4/1906"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Orvar Phaenna", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("10/7/2034")},
                            new Prisoner {PrisonerName = "Pippi Parthenia", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("7/1/2039")},
                            new Prisoner {PrisonerName = "Elagabalus Aonghus", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("2/16/2045")},
                            new Prisoner {PrisonerName = "Tammuz Hermes", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("6/26/2048")},
                            new Prisoner {PrisonerName = "Fereydun Aelita", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("8/29/2048")},
                            new Prisoner {PrisonerName = "Eógan Medora", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("3/19/2053")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Dol Guldur",
                        PrisonAddress = "104 High Noon St., Fuquay Varina, NC 27526",
                        WardenName = "Martin Van Buren",
                        GuardsEmployed = 17,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("11/22/1908"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Ara Danaë", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("12/14/2059")},
                            new Prisoner {PrisonerName = "Halcyone Aristaeus", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("3/3/2063")},
                            new Prisoner {PrisonerName = "Hyakinthos Dylan", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("2/5/2066")},
                            new Prisoner {PrisonerName = "Satisha Syavarshan", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("7/2/2075")},
                            new Prisoner {PrisonerName = "Usagi Sundara", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("3/23/2077")},
                            new Prisoner {PrisonerName = "Bellona Leir", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("11/25/2089")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Fox River State Penitentiary",
                        PrisonAddress = "65 Primrose Street, Grand Rapids, MI 49503",
                        WardenName = "William Henry Harrison",
                        GuardsEmployed = 133,
                        SecurityLevel = "Minimum",
                        DateOpened = DateTime.Parse("3/29/1912"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Guenevere Castiel", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("4/24/2092")},
                            new Prisoner {PrisonerName = "Achilleus Morpheus", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("9/25/2096")},
                            new Prisoner {PrisonerName = "Lakshmi Nisus", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("2/20/2100")},
                            new Prisoner {PrisonerName = "Venere Chloe", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("8/19/2110")},
                            new Prisoner {PrisonerName = "Sindri Ahriman", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("10/8/2118")},
                            new Prisoner {PrisonerName = "Donar Balthazar", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("12/12/2119")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Helena",
                        PrisonAddress = "59 Green Lake Road, Winter Haven, FL 33880",
                        WardenName = "John Tyler",
                        GuardsEmployed = 128,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("10/14/1912"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Julitta Ganymedes", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("10/21/2035")},
                            new Prisoner {PrisonerName = "Django Nagendra", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("2/25/2036")},
                            new Prisoner {PrisonerName = "Faramond Bedivere", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("5/19/2050")},
                            new Prisoner {PrisonerName = "Canute Vedastus", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("2/2/2054")},
                            new Prisoner {PrisonerName = "Larissa Cambyses", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("12/11/2068")},
                            new Prisoner {PrisonerName = "Atticus Batraz", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("10/7/2072")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Iron Heights",
                        PrisonAddress = "427 North Manhattan St., Mableton, GA 30126",
                        WardenName = "James K. Polk",
                        GuardsEmployed = 132,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("11/3/1918"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Pistis Bláthnat", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("3/8/2074")},
                            new Prisoner {PrisonerName = "Marama Amen", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("4/8/2087")},
                            new Prisoner {PrisonerName = "Shams Dornröschen", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("8/2/2087")},
                            new Prisoner {PrisonerName = "Swithun Vênus", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("11/14/2087")},
                            new Prisoner {PrisonerName = "El Pellinore", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("11/20/2090")},
                            new Prisoner {PrisonerName = "Satisha Ebenezer", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("7/23/2093")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Litchfield Correctional Facility",
                        PrisonAddress = "236 West Manor Station Drive, Los Banos, CA 93635",
                        WardenName = "Zachary Taylor",
                        GuardsEmployed = 73,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("7/11/1925"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Saga Gopinatha", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("10/20/2094")},
                            new Prisoner {PrisonerName = "Morgen Ninurta", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("2/19/2098")},
                            new Prisoner {PrisonerName = "Concordia Siegfried", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("6/12/2099")},
                            new Prisoner {PrisonerName = "Neoptolemus Diana", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("6/29/2110")},
                            new Prisoner {PrisonerName = "Parthenope Ashtoreth", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("2/21/2118")},
                            new Prisoner {PrisonerName = "Nanabozho Clovis", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("2/9/2123")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "LunarMax",
                        PrisonAddress = "7 South Valley Farms Dr., Douglasville, GA 30134",
                        WardenName = "Millard Fillmore",
                        GuardsEmployed = 127,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("2/23/1961"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Astrape Thalia", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("1/11/2038")},
                            new Prisoner {PrisonerName = "Madhavi Daenerys", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("9/23/2039")},
                            new Prisoner {PrisonerName = "Eirene Aurora", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("9/26/2053")},
                            new Prisoner {PrisonerName = "Melita Zorro", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("12/20/2054")},
                            new Prisoner {PrisonerName = "Ōkuninushi Elpis", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("6/18/2057")},
                            new Prisoner {PrisonerName = "Glinda Yamanu", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("9/19/2061")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Miami-Dade State Penitentiary",
                        PrisonAddress = "792 Primrose St., West Bloomfield, MI 48322",
                        WardenName = "Franklin Pierce",
                        GuardsEmployed = 73,
                        SecurityLevel = "Minimum",
                        DateOpened = DateTime.Parse("8/13/1979"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Belial Nairyosangha", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("4/7/2065")},
                            new Prisoner {PrisonerName = "Tyr Hannibal", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("5/28/2068")},
                            new Prisoner {PrisonerName = "Freya Nuada", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("11/10/2071")},
                            new Prisoner {PrisonerName = "Goldilocks Flora", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("10/28/2072")},
                            new Prisoner {PrisonerName = "Asterios Swithun", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("1/26/2079")},
                            new Prisoner {PrisonerName = "Laima Aditya", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("3/13/2087")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Montgomery Burns State Prison",
                        PrisonAddress = "299 West Mulberry St., Lombard, IL 60148",
                        WardenName = "James Buchanan",
                        GuardsEmployed = 93,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("2/27/1984"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Murron Tlaloc", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("10/21/2092")},
                            new Prisoner {PrisonerName = "Halcyone Lucifer", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("6/27/2105")},
                            new Prisoner {PrisonerName = "Batraz Gandalf", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("4/29/2113")},
                            new Prisoner {PrisonerName = "Khnum Helene", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("4/10/2115")},
                            new Prisoner {PrisonerName = "Ayla Arthur", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("6/23/2121")},
                            new Prisoner {PrisonerName = "Alvíss Wōdanaz", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("6/9/2122")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Nova Prospekt",
                        PrisonAddress = "63 North Wayne Drive, Perkasie, PA 18944",
                        WardenName = "Abraham Lincoln",
                        GuardsEmployed = 13,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("10/11/1764"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Usagi Luna", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("8/21/2024")},
                            new Prisoner {PrisonerName = "Myles Chthonia", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("2/13/2027")},
                            new Prisoner {PrisonerName = "Maera Oddrún", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("12/24/2036")},
                            new Prisoner {PrisonerName = "Paris El", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("11/24/2037")},
                            new Prisoner {PrisonerName = "Ptolemy Gandálfr", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("6/2/2039")},
                            new Prisoner {PrisonerName = "Yima Khshaeta Galateia", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("4/25/2046")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Overlook Penitentiary",
                        PrisonAddress = "56 Leatherwood St., Brick, NJ 08723",
                        WardenName = "Andrew Johnson",
                        GuardsEmployed = 141,
                        SecurityLevel = "Minimum",
                        DateOpened = DateTime.Parse("4/13/1773"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Kylo Zuleika", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("11/25/2056")},
                            new Prisoner {PrisonerName = "Plouton Caishen", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("4/9/2064")},
                            new Prisoner {PrisonerName = "Baihu Achilleus", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("4/14/2072")},
                            new Prisoner {PrisonerName = "Goemon Shamash", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("2/22/2073")},
                            new Prisoner {PrisonerName = "Latona Dilbert", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("12/23/2079")},
                            new Prisoner {PrisonerName = "Leigong Oxum", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("2/11/2080")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "The Phantom Zone",
                        PrisonAddress = "235 Ramblewood St., Lacey, WA 98503",
                        WardenName = "Ulysses S. Grant",
                        GuardsEmployed = 147,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("9/6/1847"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Drupada Io", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("6/17/2080")},
                            new Prisoner {PrisonerName = "Kateri Tur", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("4/8/2091")},
                            new Prisoner {PrisonerName = "Yima Kreios", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("6/6/2102")},
                            new Prisoner {PrisonerName = "Svanhild Tanith", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("9/7/2103")},
                            new Prisoner {PrisonerName = "Oissíne Yama", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("10/26/2107")},
                            new Prisoner {PrisonerName = "Nestor Conn", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("7/3/2109")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "The Raft",
                        PrisonAddress = "8264 Sierra St., Murfreesboro, TN 37128",
                        WardenName = "Rutherford B. Hayes",
                        GuardsEmployed = 85,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("12/29/1872"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Pollux Kanti", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("4/8/2118")},
                            new Prisoner {PrisonerName = "Govannon Nuadu", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("3/13/2037")},
                            new Prisoner {PrisonerName = "Rama Wayland", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("12/26/2039")},
                            new Prisoner {PrisonerName = "Aigle Tonatiuh", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("9/4/2045")},
                            new Prisoner {PrisonerName = "Pax Set", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("2/20/2049")},
                            new Prisoner {PrisonerName = "Admetus Modred", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("10/3/2052")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Ravencroft Institute for the Criminally Insane",
                        PrisonAddress = "8567 Bohemia Dr., Feasterville Trevose, PA 19053",
                        WardenName = "James A. Garfield",
                        GuardsEmployed = 31,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("10/1/1878"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Troilus Psamathe", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("5/10/2061")},
                            new Prisoner {PrisonerName = "Tinatin Walganus", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("5/16/2066")},
                            new Prisoner {PrisonerName = "Frija Pallas", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("12/9/2067")},
                            new Prisoner {PrisonerName = "Modu Nüwa", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("3/28/2069")},
                            new Prisoner {PrisonerName = "Arethousa Neilos", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("12/31/2072")},
                            new Prisoner {PrisonerName = "Macsen Ashur", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("10/13/2079")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Rura Penthe",
                        PrisonAddress = "8998 East Logan Lane, Coatesville, PA 19320",
                        WardenName = "Theodore Roosevelt",
                        GuardsEmployed = 138,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("5/25/1879"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Bedwyr Gobnata", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("11/9/2081")},
                            new Prisoner {PrisonerName = "Kleio Lycurgus", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("12/8/2090")},
                            new Prisoner {PrisonerName = "Larisa Ahriman", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("11/17/2092")},
                            new Prisoner {PrisonerName = "Lakshmana Aragorn", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("12/4/2093")},
                            new Prisoner {PrisonerName = "Muirgen Ba'al Hammon", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("5/25/2098")},
                            new Prisoner {PrisonerName = "Shivali Gowad", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("1/20/2104")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Sharkmoor Prison",
                        PrisonAddress = "45 Surrey Court, Smithtown, NY 11787",
                        WardenName = "Woodrow Wilson",
                        GuardsEmployed = 118,
                        SecurityLevel = "Minimum",
                        DateOpened = DateTime.Parse("5/6/1912"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Yemayá Govannon", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("1/25/2025")},
                            new Prisoner {PrisonerName = "Weland Perun", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("2/8/2033")},
                            new Prisoner {PrisonerName = "Nuadu Yemayá", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("12/3/2039")},
                            new Prisoner {PrisonerName = "Hector Deianeira", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("6/3/2044")},
                            new Prisoner {PrisonerName = "Gandalf Tarzan", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("12/31/2048")},
                            new Prisoner {PrisonerName = "Orpheus Iuturna", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("9/29/2051")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Shawshank",
                        PrisonAddress = "388 Santa Clara Ave., Hallandale, FL 33009",
                        WardenName = "Herbert Hoover",
                        GuardsEmployed = 104,
                        SecurityLevel = "Minimum",
                        DateOpened = DateTime.Parse("3/16/1927"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Puck Kumara", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("1/31/2052")},
                            new Prisoner {PrisonerName = "Sumati K'uk'ulkan", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("2/21/2056")},
                            new Prisoner {PrisonerName = "Karna Cú Chulainn", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("3/3/2057")},
                            new Prisoner {PrisonerName = "Pitambara Bile", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("1/2/2060")},
                            new Prisoner {PrisonerName = "Shahrivar Ferdowsi", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("11/27/2063")},
                            new Prisoner {PrisonerName = "Ninsun Belial", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("11/14/2076")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Stormcage Containment Facility",
                        PrisonAddress = "982 W. Pilgrim St., Hernando, MS 38632",
                        WardenName = "Franklin D. Roosevelt",
                        GuardsEmployed = 128,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("10/11/1960"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Criseyde Giunone", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("2/4/2080")},
                            new Prisoner {PrisonerName = "Nilus Bayard", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("9/7/2088")},
                            new Prisoner {PrisonerName = "Brünhild Everild", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("11/23/2095")},
                            new Prisoner {PrisonerName = "Fionnghuala Hadrian", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("2/22/2107")},
                            new Prisoner {PrisonerName = "Iocasta Vijaya", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("6/30/2110")},
                            new Prisoner {PrisonerName = "Hersilia Bran", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("4/26/2123")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "The Vannacutt Psychiatric Institute for the Criminally Insane",
                        PrisonAddress = "696 Foxrun St., Rockville Centre, NY 11570",
                        WardenName = "Harry S. Truman",
                        GuardsEmployed = 99,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("12/31/1972"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Makeda Aditi", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("9/26/2040")},
                            new Prisoner {PrisonerName = "Väinämöinen Irnerius", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("4/30/2044")},
                            new Prisoner {PrisonerName = "Eponine Popeye", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("9/23/2044")},
                            new Prisoner {PrisonerName = "Pompey Kanti", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("1/9/2048")},
                            new Prisoner {PrisonerName = "Zephyrus Jamshed", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("5/19/2054")},
                            new Prisoner {PrisonerName = "Lara Valli", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("12/18/2062")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "The Vault",
                        PrisonAddress = "143 Richardson Ave., Wallingford, CT 06492",
                        WardenName = "Dwight D. Eisenhower",
                        GuardsEmployed = 23,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("3/14/1974"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Glaucus Cian", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("5/17/2063")},
                            new Prisoner {PrisonerName = "Vikrama Selena", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("7/17/2063")},
                            new Prisoner {PrisonerName = "Shailaja Wieland", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("6/7/2076")},
                            new Prisoner {PrisonerName = "Cardea Xanthos", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("11/7/2080")},
                            new Prisoner {PrisonerName = "Prabhakara Antheia", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("10/30/2085")},
                            new Prisoner {PrisonerName = "Ikaros Adad", ConvictedCrimes = "Stalking", DateOfRelease = DateTime.Parse("12/11/2088")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Warrinor Prison",
                        PrisonAddress = "426 Taylor St., Waldorf, MD 20601",
                        WardenName = "John F. Kennedy",
                        GuardsEmployed = 95,
                        SecurityLevel = "Minimum",
                        DateOpened = DateTime.Parse("7/15/1986"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Ayla Medrod", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("1/29/2090")},
                            new Prisoner {PrisonerName = "Gwydion Tahmina", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("6/18/2090")},
                            new Prisoner {PrisonerName = "Spock Tāne", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("2/12/2094")},
                            new Prisoner {PrisonerName = "Discordia Turin", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("10/2/2094")},
                            new Prisoner {PrisonerName = "Astaroth Hansel", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("6/16/2106")},
                            new Prisoner {PrisonerName = "Fortuna Dáire", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("5/11/2115")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "Wentworth Correctional Centre",
                        PrisonAddress = "8120 Pulaski Drive, Oakland Gardens, NY 11364",
                        WardenName = "Jimmy Carter",
                        GuardsEmployed = 110,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("4/18/1990"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Fuxi Bláthnaid", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("1/19/2030")},
                            new Prisoner {PrisonerName = "Bastet Tiw", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("11/24/2031")},
                            new Prisoner {PrisonerName = "Khnum Pellehan", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("1/21/2044")},
                            new Prisoner {PrisonerName = "Faunus Uttara", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("12/13/2044")},
                            new Prisoner {PrisonerName = "Olindo Hapi", ConvictedCrimes = "Identity Theft", DateOfRelease = DateTime.Parse("7/7/2047")},
                            new Prisoner {PrisonerName = "Lugaid Pekko", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("12/5/2050")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "The Wheel of Kharnabar",
                        PrisonAddress = "6 Old York Street, Harlingen, TX 78552",
                        WardenName = "Barack Obama",
                        GuardsEmployed = 62,
                        SecurityLevel = "Average",
                        DateOpened = DateTime.Parse("11/10/2003"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Njǫrðr Yemanjá", ConvictedCrimes = "Forgery", DateOfRelease = DateTime.Parse("9/10/2059")},
                            new Prisoner {PrisonerName = "Q'uq'umatz Iside", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("2/28/2064")},
                            new Prisoner {PrisonerName = "Kratos Cosette", ConvictedCrimes = "Money Laundering", DateOfRelease = DateTime.Parse("5/10/2074")},
                            new Prisoner {PrisonerName = "Asclepius Ovid", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("5/26/2079")},
                            new Prisoner {PrisonerName = "Bharata Matrona", ConvictedCrimes = "Robbery", DateOfRelease = DateTime.Parse("7/15/2083")},
                            new Prisoner {PrisonerName = "Melchior Amun", ConvictedCrimes = "Perjury", DateOfRelease = DateTime.Parse("1/22/2090")}
                        }
                    },
                    new Prison
                    {
                        PrisonName = "The Ziggurat",
                        PrisonAddress = "687 NW. Manor Station Court, Painesville, OH 44077",
                        WardenName = "Joe Biden",
                        GuardsEmployed = 70,
                        SecurityLevel = "Maximum",
                        DateOpened = DateTime.Parse("9/28/2016"),
                        Prisoners = new List<Prisoner>{
                            new Prisoner {PrisonerName = "Thor Aristaeus", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("11/3/2091")},
                            new Prisoner {PrisonerName = "Oedipus Hephaestus", ConvictedCrimes = "Homicide", DateOfRelease = DateTime.Parse("11/9/2098")},
                            new Prisoner {PrisonerName = "Fenrir Morgaine", ConvictedCrimes = "Shoplifting", DateOfRelease = DateTime.Parse("3/11/2099")},
                            new Prisoner {PrisonerName = "Dardanos Aramis", ConvictedCrimes = "Arson", DateOfRelease = DateTime.Parse("10/3/2100")},
                            new Prisoner {PrisonerName = "Florimond Elara", ConvictedCrimes = "Vandalism", DateOfRelease = DateTime.Parse("4/20/2110")},
                            new Prisoner {PrisonerName = "Shapur Nerþuz", ConvictedCrimes = "Kidnapping", DateOfRelease = DateTime.Parse("9/14/2118")}
                        }
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
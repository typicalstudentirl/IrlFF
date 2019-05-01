using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrlFF.Data.Migrations
{
    public partial class PlayersFixturesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fixture",
                column: "Id",
                values: new object[]
                {
                    3,
                    20,
                    19,
                    18,
                    17,
                    16,
                    15,
                    14,
                    12,
                    13,
                    10,
                    9,
                    8,
                    7,
                    6,
                    5,
                    4,
                    11
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: null);

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "ClubId", "Forename", "Position", "Surname", "TotalPoints", "WeekPoints" },
                values: new object[,]
                {
                    { 121, 7, "Ronan", 4, "Murray", 0, 0 },
                    { 122, 8, "Barry", 1, "Murphy", 0, 0 },
                    { 123, 8, "Brendan", 1, "Clarke", 0, 0 },
                    { 124, 8, "Kevin", 2, "Toner", 0, 0 },
                    { 125, 8, "Simon", 2, "Madden", 0, 0 },
                    { 126, 8, "David", 2, "Webster", 0, 0 },
                    { 127, 8, "Liam", 2, "Desmond", 0, 0 },
                    { 130, 8, "Rhys", 3, "McCabe", 0, 0 },
                    { 129, 8, "Chris", 3, "Forrester", 0, 0 },
                    { 120, 7, "Ronan", 4, "Coughlan", 0, 0 },
                    { 131, 8, "Conor", 3, "Clifford", 0, 0 },
                    { 132, 8, "Brandon", 3, "Miele", 0, 0 },
                    { 133, 8, "James", 3, "Doona", 0, 0 },
                    { 134, 8, "Michael", 4, "Drennan", 0, 0 },
                    { 128, 8, "Darragh", 3, "Markey", 0, 0 },
                    { 119, 7, "Romeo", 4, "Parkes", 0, 0 },
                    { 105, 6, "Brandon", 3, "Kavanagh", 0, 0 },
                    { 117, 7, "Daryl", 3, "Fordyce", 0, 0 },
                    { 102, 6, "Jack", 3, "Byrne", 0, 0 },
                    { 103, 6, "Greg", 3, "Bolger", 0, 0 },
                    { 104, 6, "Ronan", 3, "Finn", 0, 0 },
                    { 135, 8, "Darragh", 4, "Markey", 0, 0 },
                    { 106, 6, "Aaron", 4, "Greene", 0, 0 },
                    { 107, 6, "Dan", 4, "Carr", 0, 0 },
                    { 108, 7, "Mitchell", 1, "Beeney", 0, 0 },
                    { 109, 7, "Ed", 1, "McGinty", 0, 0 },
                    { 110, 7, "Luke", 1, "McNicholas", 0, 0 },
                    { 111, 7, "John", 2, "Mahon", 0, 0 },
                    { 112, 7, "Kyle", 2, "Callan-McFadden", 0, 0 },
                    { 113, 7, "Lewis", 2, "Banks", 0, 0 },
                    { 114, 7, "Johnny", 2, "Dunleavy", 0, 0 },
                    { 115, 7, "David", 3, "Cawley", 0, 0 },
                    { 116, 7, "Jack", 3, "Keaney", 0, 0 },
                    { 118, 7, "John", 3, "Russell", 0, 0 },
                    { 136, 8, "Dean", 4, "Clarke", 0, 0 },
                    { 150, 9, "Jack", 3, "Ryan", 0, 0 },
                    { 138, 9, "Gavin", 1, "Sheridan", 0, 0 },
                    { 158, 10, "Dean", 4, "Walsh", 0, 0 },
                    { 159, 10, "Rory", 2, "Feely", 0, 0 },
                    { 160, 10, "Bastien", 3, "Hery", 0, 0 },
                    { 161, 10, "Izzy", 4, "Akinade", 0, 0 },
                    { 162, 10, "Paul", 1, "Martin", 0, 0 },
                    { 163, 10, "Izzy", 4, "Akinade", 0, 0 },
                    { 157, 10, "John", 4, "Martin", 0, 0 },
                    { 164, 10, "Shane", 3, "Griffin", 0, 0 },
                    { 166, 10, "Shane", 3, "Duggan", 0, 0 },
                    { 167, 10, "Damien", 2, "Delaney", 0, 0 },
                    { 168, 10, "Aaron", 4, "Drinan", 0, 0 },
                    { 169, 10, "Maxim", 4, "Kouogun", 0, 0 },
                    { 170, 10, "Georgie", 3, "Poynton", 0, 0 },
                    { 171, 10, "Aaron", 2, "Simpson", 0, 0 },
                    { 165, 10, "Zack", 3, "Elbouzedi", 0, 0 },
                    { 156, 10, "Kenny", 2, "Browne", 0, 0 },
                    { 155, 10, "Matthew", 1, "Connor", 0, 0 },
                    { 154, 9, "Sean", 4, "McDonald", 0, 0 },
                    { 139, 9, "Conor", 1, "Kearns", 0, 0 },
                    { 140, 9, "Daniel", 2, "Tobin", 0, 0 },
                    { 141, 9, "Evan", 2, "Osam", 0, 0 },
                    { 142, 9, "Liam", 2, "Scales", 0, 0 },
                    { 143, 9, "Josh", 2, "Collins", 0, 0 },
                    { 144, 9, "Darragh", 2, "Corcoran", 0, 0 },
                    { 145, 9, "Evan", 2, "Farrell", 0, 0 },
                    { 146, 9, "Conor", 3, "Crawley", 0, 0 },
                    { 147, 9, "Gary", 3, "O'Neil", 0, 0 },
                    { 148, 9, "Timmy", 3, "Molloy", 0, 0 },
                    { 149, 9, "Richie", 3, "O'Farrell", 0, 0 },
                    { 101, 6, "Dylan", 3, "Watts", 0, 0 },
                    { 151, 9, "Neil", 4, "Farrugia", 0, 0 },
                    { 152, 9, "Yoyo", 4, "Mahdy", 0, 0 },
                    { 153, 9, "Jason", 4, "McClelland", 0, 0 },
                    { 137, 8, "Gary", 4, "Shaw", 0, 0 },
                    { 100, 6, "Aaron", 3, "McEneff", 0, 0 },
                    { 86, 5, "Tony", 3, "McNamee", 0, 0 },
                    { 98, 6, "Roberto", 2, "Lopes", 0, 0 },
                    { 46, 2, "Shane", 2, "Griffin", 0, 0 },
                    { 47, 2, "Gearoid", 3, "Morrissey", 0, 0 },
                    { 48, 2, "Conor", 3, "McCormack", 0, 0 },
                    { 49, 2, "Garry", 3, "Buckley", 0, 0 },
                    { 50, 2, "Kevin", 3, "O'Connor", 0, 0 },
                    { 51, 2, "Gary", 3, "Boylan", 0, 0 },
                    { 45, 2, "Ronan", 2, "Hurley", 0, 0 },
                    { 52, 2, "Darragh", 4, "Rainsford", 0, 0 },
                    { 54, 2, "Daire", 4, "O'Connor", 0, 0 },
                    { 55, 2, "Karl", 4, "Sheppard", 0, 0 },
                    { 56, 2, "James", 4, "Tilley", 0, 0 },
                    { 57, 2, "Cian", 4, "Murphy", 0, 0 },
                    { 58, 4, "Gary", 1, "Rogers", 0, 0 },
                    { 59, 4, "Sean", 2, "Gannon", 0, 0 },
                    { 53, 2, "Graham", 4, "Cummins", 0, 0 },
                    { 44, 2, "Sean", 2, "McLoughlin", 0, 0 },
                    { 43, 2, "Alan", 2, "Bennett", 0, 0 },
                    { 42, 2, "Colm", 2, "Horgan", 0, 0 },
                    { 27, 1, "James", 1, "Talbot", 0, 0 },
                    { 28, 1, "Derek", 2, "Pender", 0, 0 },
                    { 29, 1, "Darragh", 2, "Leahy", 0, 0 },
                    { 30, 1, "Rob", 2, "Cornwall", 0, 0 },
                    { 31, 1, "Scott", 3, "Allardice", 0, 0 },
                    { 32, 1, "Danny", 3, "Mandroiu", 0, 0 },
                    { 33, 1, "Robbie", 3, "McCourt", 0, 0 },
                    { 34, 1, "Dinny", 4, "Corcoran", 0, 0 },
                    { 35, 1, "Keith", 3, "Ward", 0, 0 },
                    { 36, 1, "Kevin", 3, "Devaney", 0, 0 },
                    { 37, 1, "Daniel", 4, "Grant", 0, 0 },
                    { 38, 1, "Conor", 3, "Levingston", 0, 0 },
                    { 39, 1, "Sam", 4, "Byrne", 0, 0 },
                    { 40, 2, "Mark", 1, "McNulty", 0, 0 },
                    { 41, 2, "Tadhg", 1, "Ryan", 0, 0 },
                    { 60, 4, "Brian", 2, "Gartland", 0, 0 },
                    { 61, 4, "Sean", 2, "Hoare", 0, 0 },
                    { 62, 4, "Chris", 2, "Shields", 0, 0 },
                    { 63, 4, "Jordan", 3, "Flores", 0, 0 },
                    { 83, 5, "Mikey", 3, "Place", 0, 0 },
                    { 84, 5, "Rafael", 3, "Cretaro", 0, 0 },
                    { 85, 5, "Niall", 3, "McGinley", 0, 0 },
                    { 172, 10, "Karolis", 3, "Chvedukas", 0, 0 },
                    { 87, 5, "Mark", 3, "Timlin", 0, 0 },
                    { 88, 5, "Gareth", 3, "Harkin", 0, 0 },
                    { 89, 5, "Caolan", 4, "McAleer", 0, 0 },
                    { 90, 5, "Nathan", 4, "Boyle", 0, 0 },
                    { 91, 5, "Sean", 4, "Boyd", 0, 0 },
                    { 92, 5, "Adam", 4, "Duffy", 0, 0 },
                    { 93, 6, "Alan", 1, "Mannus", 0, 0 },
                    { 94, 6, "Leon", 1, "Pohls", 0, 0 },
                    { 95, 6, "James", 2, "Furlong", 0, 0 },
                    { 96, 6, "Sam", 2, "Bone", 0, 0 },
                    { 97, 6, "Ethan", 2, "Boyle", 0, 0 },
                    { 82, 5, "Mark", 3, "Coyle", 0, 0 },
                    { 99, 6, "Trevor", 2, "Clarke", 0, 0 },
                    { 81, 5, "Colm", 2, "Deasy", 0, 0 },
                    { 79, 5, "Daragh", 2, "Elison", 0, 0 },
                    { 64, 4, "John", 3, "Mountney", 0, 0 },
                    { 65, 4, "Patrick", 3, "McEleney", 0, 0 },
                    { 66, 4, "Robbie", 3, "Benson", 0, 0 },
                    { 67, 4, "Dean", 3, "Jarvis", 0, 0 },
                    { 68, 4, "Georgie", 4, "Kelly", 0, 0 },
                    { 69, 4, "Pat", 4, "Hoban", 0, 0 },
                    { 70, 4, "Daniel", 4, "Kelly", 0, 0 },
                    { 71, 4, "Jamie", 4, "McGrath", 0, 0 },
                    { 72, 4, "Sean", 3, "Murray", 0, 0 },
                    { 73, 4, "Dane", 2, "Massey", 0, 0 },
                    { 74, 5, "Ciaran", 1, "Gallagher", 0, 0 },
                    { 75, 5, "Peter", 1, "Burke", 0, 0 },
                    { 76, 5, "Sam", 2, "Todd", 0, 0 },
                    { 77, 5, "Keith", 2, "Cowan", 0, 0 },
                    { 78, 5, "Sam", 2, "Ascroft", 0, 0 },
                    { 80, 5, "Niall", 2, "Logue", 0, 0 },
                    { 173, 10, "Scott", 4, "Twine", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayClub", "Date", "FixtureId", "HomeClub", "Location" },
                values: new object[,]
                {
                    { 11, "Shamrock Rovers", new DateTime(2019, 2, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, "Bohemians", null },
                    { 74, "Dundalk", new DateTime(2019, 4, 29, 20, 19, 45, 0, DateTimeKind.Unspecified), 15, "Waterford", null },
                    { 73, "Sligo Rovers", new DateTime(2019, 4, 29, 19, 45, 0, 0, DateTimeKind.Unspecified), 15, "U.C.D", null },
                    { 72, "Bohemians", new DateTime(2019, 4, 29, 19, 45, 0, 0, DateTimeKind.Unspecified), 15, "Derry City", null },
                    { 71, "Finn Harps", new DateTime(2019, 4, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 15, "Cork City", null },
                    { 70, "Shamrock Rovers", new DateTime(2019, 4, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 14, "Dundalk", null },
                    { 69, "Finn Harps", new DateTime(2019, 4, 26, 20, 19, 45, 0, DateTimeKind.Unspecified), 14, "Sligo Rovers", null },
                    { 68, "U.C.D", new DateTime(2019, 4, 26, 19, 45, 0, 0, DateTimeKind.Unspecified), 14, "St. Pats", null },
                    { 67, "Cork City", new DateTime(2019, 4, 26, 19, 45, 0, 0, DateTimeKind.Unspecified), 14, "Derry City", null },
                    { 75, "St. Pats", new DateTime(2019, 4, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 15, "Shamrock Rovers", null },
                    { 66, "Waterford", new DateTime(2019, 4, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 14, "Bohemians", null },
                    { 64, "St. Pats", new DateTime(2019, 4, 22, 20, 19, 45, 0, DateTimeKind.Unspecified), 13, "Finn Harps", null },
                    { 63, "Sligo Rovers", new DateTime(2019, 4, 22, 19, 45, 0, 0, DateTimeKind.Unspecified), 13, "Cork City", null },
                    { 62, "Derry City", new DateTime(2019, 4, 22, 19, 45, 0, 0, DateTimeKind.Unspecified), 13, "Waterford", null },
                    { 61, "Dundalk", new DateTime(2019, 4, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 13, "U.C.D", null },
                    { 60, "Cork City", new DateTime(2019, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 12, "Waterford", null },
                    { 59, "Sligo Rovers", new DateTime(2019, 4, 19, 20, 19, 45, 0, DateTimeKind.Unspecified), 12, "St. Pats", null },
                    { 58, "Finn Harps", new DateTime(2019, 4, 19, 19, 45, 0, 0, DateTimeKind.Unspecified), 12, "Dundalk", null },
                    { 57, "Shamrock Rovers", new DateTime(2019, 4, 19, 19, 45, 0, 0, DateTimeKind.Unspecified), 12, "Derry City", null },
                    { 65, "Bohemians", new DateTime(2019, 4, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), 13, "Shamrock Rovers", null },
                    { 76, "Cork City", new DateTime(2019, 5, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 16, "Bohemians", null },
                    { 77, "Derry City", new DateTime(2019, 5, 3, 19, 45, 0, 0, DateTimeKind.Unspecified), 16, "Dundalk", null },
                    { 78, "Waterford", new DateTime(2019, 5, 3, 19, 45, 0, 0, DateTimeKind.Unspecified), 16, "St. Pats", null },
                    { 98, "St. Pats", new DateTime(2019, 5, 24, 19, 45, 0, 0, DateTimeKind.Unspecified), 20, "Dundalk", null },
                    { 97, "Finn Harps", new DateTime(2019, 5, 24, 19, 45, 0, 0, DateTimeKind.Unspecified), 20, "Derry City", null },
                    { 96, "Sligo Rovers", new DateTime(2019, 5, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), 20, "Bohemians", null },
                    { 94, "Waterford", new DateTime(2019, 5, 20, 20, 19, 45, 0, DateTimeKind.Unspecified), 19, "Sligo Rovers", null },
                    { 93, "Shamrock Rovers", new DateTime(2019, 5, 20, 19, 45, 0, 0, DateTimeKind.Unspecified), 19, "Finn Harps", null },
                    { 92, "Cork City", new DateTime(2019, 5, 20, 19, 45, 0, 0, DateTimeKind.Unspecified), 19, "U.C.D", null },
                    { 91, "Bohemians", new DateTime(2019, 5, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 19, "Dundlk", null },
                    { 90, "Derry City", new DateTime(2019, 5, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), 18, "Sligo Rovers", null },
                    { 89, "Waterford", new DateTime(2019, 5, 17, 20, 19, 45, 0, DateTimeKind.Unspecified), 18, "Finn Harps", null },
                    { 88, "Shamrock Rovers", new DateTime(2019, 5, 17, 19, 45, 0, 0, DateTimeKind.Unspecified), 18, "U.C.D", null },
                    { 87, "Bohemians", new DateTime(2019, 5, 17, 19, 45, 0, 0, DateTimeKind.Unspecified), 18, "St. Pats", null },
                    { 86, "Dundalk", new DateTime(2019, 5, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 18, "Cork City", null },
                    { 85, "Sligo Rovers", new DateTime(2019, 5, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), 17, "Waterford", null },
                    { 84, "St. Pats", new DateTime(2019, 5, 10, 20, 19, 45, 0, DateTimeKind.Unspecified), 17, "Derry City", null },
                    { 83, "U.C.D", new DateTime(2019, 5, 10, 19, 45, 0, 0, DateTimeKind.Unspecified), 17, "Cork City", null },
                    { 82, "Dundalk", new DateTime(2019, 5, 10, 19, 45, 0, 0, DateTimeKind.Unspecified), 17, "Bohemians", null },
                    { 81, "Finn Harps", new DateTime(2019, 3, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 17, "Shamrock Rovers", null },
                    { 80, "Shamrock Rovers", new DateTime(2019, 5, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 16, "Sligo Rovers", null },
                    { 79, "U.C.D", new DateTime(2019, 5, 3, 20, 19, 45, 0, DateTimeKind.Unspecified), 16, "Finn Harps", null },
                    { 56, "U.C.D", new DateTime(2019, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 12, "Bohemians", null },
                    { 99, "U.C.D", new DateTime(2019, 5, 24, 20, 19, 45, 0, DateTimeKind.Unspecified), 20, "Waterford", null },
                    { 55, "Waterford", new DateTime(2019, 4, 15, 20, 19, 45, 0, DateTimeKind.Unspecified), 11, "Sligo Rovers", null },
                    { 53, "Derry City", new DateTime(2019, 4, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 11, "St. Pats", null },
                    { 29, "Finn Harps", new DateTime(2019, 3, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 6, "U.C.D", null },
                    { 28, "Dundalk", new DateTime(2019, 3, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 6, "Derry City", null },
                    { 27, "Bohemians", new DateTime(2019, 3, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, "Cork City", null },
                    { 26, "U.C.D", new DateTime(2019, 3, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 5, "Sligo Rovers", null },
                    { 25, "Cork", new DateTime(2019, 3, 8, 20, 19, 45, 0, DateTimeKind.Unspecified), 5, "Finn Harps", null },
                    { 24, "Shamrock Rovers", new DateTime(2019, 3, 8, 19, 45, 0, 0, DateTimeKind.Unspecified), 5, "St. Pats", null },
                    { 23, "Waterford", new DateTime(2019, 3, 8, 19, 45, 0, 0, DateTimeKind.Unspecified), 5, "Dundalk", null },
                    { 22, "Derry City", new DateTime(2019, 3, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 5, "Bohemians", null },
                    { 30, "St.Pats", new DateTime(2019, 3, 15, 20, 19, 45, 0, DateTimeKind.Unspecified), 6, "Waterford", null },
                    { 21, "Shamrock Rovers", new DateTime(2019, 3, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 4, "Finn Harps", null },
                    { 19, "Sligo Rovers", new DateTime(2019, 3, 1, 20, 19, 45, 0, DateTimeKind.Unspecified), 4, "Finn Harps", null },
                    { 18, "Bohemians", new DateTime(2019, 3, 1, 19, 45, 0, 0, DateTimeKind.Unspecified), 4, "Waterford", null },
                    { 17, "St. Pats", new DateTime(2019, 3, 1, 19, 45, 0, 0, DateTimeKind.Unspecified), 4, "U.C.D", null },
                    { 16, "Derry City", new DateTime(2019, 3, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 4, "Cork City", null },
                    { 15, "Cork City", new DateTime(2019, 2, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sligo Rovers", null },
                    { 14, "Finn Harps", new DateTime(2019, 2, 25, 20, 19, 45, 0, DateTimeKind.Unspecified), 3, "St. Pats", null },
                    { 13, "U.C.D", new DateTime(2019, 2, 25, 19, 45, 0, 0, DateTimeKind.Unspecified), 3, "Dundalk", null },
                    { 12, "Waterford", new DateTime(2019, 2, 25, 19, 45, 0, 0, DateTimeKind.Unspecified), 3, "Derry City", null },
                    { 20, "Dundalk", new DateTime(2019, 3, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), 4, "Shamrock Rovers", null },
                    { 31, "Sligo Rovers", new DateTime(2019, 3, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, "Shamrock Rovers", null },
                    { 32, "Shamrock Rovers", new DateTime(2019, 3, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), 7, "Finn Harps", null },
                    { 33, "Bohemians", new DateTime(2019, 4, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 7, "Dundalk", null },
                    { 52, "Bohemians", new DateTime(2019, 4, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 11, "Dundalk", null },
                    { 51, "Waterford", new DateTime(2019, 4, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 10, "Shamrock Rovers", null },
                    { 50, "Bohemians", new DateTime(2019, 4, 12, 20, 19, 45, 0, DateTimeKind.Unspecified), 10, "Finn Harps", null },
                    { 49, "Dundalk", new DateTime(2019, 4, 12, 19, 45, 0, 0, DateTimeKind.Unspecified), 10, "Sligo Rovers", null },
                    { 48, "Derry City", new DateTime(2019, 4, 12, 19, 45, 0, 0, DateTimeKind.Unspecified), 10, "U.C.D", null },
                    { 47, "St. Pats", new DateTime(2019, 4, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 10, "Cork City", null },
                    { 46, "Bohemians", new DateTime(2019, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), 9, "Sligo Rovers", null },
                    { 45, "Derry City", new DateTime(2019, 4, 5, 20, 19, 45, 0, DateTimeKind.Unspecified), 9, "Finn Harps", null },
                    { 44, "Waterford", new DateTime(2019, 4, 5, 19, 45, 0, 0, DateTimeKind.Unspecified), 9, "U.C.D", null },
                    { 43, "Dundalk", new DateTime(2019, 4, 5, 19, 45, 0, 0, DateTimeKind.Unspecified), 9, "St. Pats", null },
                    { 42, "Shamrock Rovers", new DateTime(2019, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), 9, "Cork City", null },
                    { 41, "U.C.D", new DateTime(2019, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 8, "Shamrock Rovers", null },
                    { 40, "Finn Harps", new DateTime(2019, 3, 29, 20, 19, 45, 0, DateTimeKind.Unspecified), 8, "Waterford", null },
                    { 39, "Cork City", new DateTime(2019, 3, 29, 19, 45, 0, 0, DateTimeKind.Unspecified), 8, "Dundalk", null },
                    { 38, "Sligo Rovers", new DateTime(2019, 3, 29, 19, 45, 0, 0, DateTimeKind.Unspecified), 8, "Derry City", null },
                    { 37, "St. Pats", new DateTime(2019, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 8, "Bohemians", null },
                    { 36, "Waterford", new DateTime(2019, 4, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 7, "Sligo Rovers", null },
                    { 35, "Cork City", new DateTime(2019, 4, 15, 20, 19, 45, 0, DateTimeKind.Unspecified), 7, "U.C.D", null },
                    { 34, "Derry City", new DateTime(2019, 4, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 7, "St. Pats", null },
                    { 54, "Cork City", new DateTime(2019, 4, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 11, "U.C.D", null },
                    { 100, "Cork City", new DateTime(2019, 5, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), 20, "Shamrock Rovers", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Fixture",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "Waterford RSC");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: "Richmond Park");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: "Oriel Park");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "The Brandywell Stadium");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "Dalymount Park");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "Turner's Cross");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "Location",
                value: "Tallaght Stadium");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "Location",
                value: "Finn Park");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "U.C.D Bowl");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "The Showgrounds");
        }
    }
}

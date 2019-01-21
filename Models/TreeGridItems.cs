﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class TreeGridItems
    {
        public TreeGridItems() { }
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Duration { get; set; }

        public int Progress { get; set; }
        public string Priority { get; set; }
        public bool Approved { get; set; }

        public DateTime FilterStartDate { get; set; }
        public DateTime FilterEndDate { get; set; }

        public List<TreeGridItems> Children { get; set; }

        public int? ParentId { get; set; }

        public static List<TreeGridItems> GetTreeData()
        {
            List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

            TreeGridItems Record1 = null;

            Record1 = new TreeGridItems()
            {
                TaskId = 1,
                TaskName = "Planning",
                StartDate = new DateTime(2016, 06, 07),
                EndDate = new DateTime(2021, 08, 25),
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Children = new List<TreeGridItems>(),
            };

            TreeGridItems Child1 = new TreeGridItems()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                StartDate = new DateTime(2016, 06, 07),
                EndDate = new DateTime(2021, 08, 25),
                Progress = 100,
                Duration = 5,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
            };

            TreeGridItems Child2 = new TreeGridItems()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                StartDate = new DateTime(2016, 06, 07),
                EndDate = new DateTime(2021, 08, 25),
                Duration = 5,
                Priority = "Critical",
                Progress = 100,
                Approved = true,
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
            };

            TreeGridItems Child3 = new TreeGridItems()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                StartDate = new DateTime(2016, 06, 07),
                EndDate = new DateTime(2021, 08, 25),
                Duration = 5,
                Progress = 100,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Approved = false
            };

            TreeGridItems Child4 = new TreeGridItems()
            {
                TaskId = 5,
                TaskName = "Planning complete",
                StartDate = new DateTime(2021, 08, 25),
                EndDate = new DateTime(2021, 08, 25),
                Duration = 3,
                Progress = 25,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 07),
                FilterEndDate = new DateTime(2017, 02, 07),
                Approved = true
            };

            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            Record1.Children.Add(Child4);

            TreeGridItems Record2 = new TreeGridItems()
            {
                TaskId = 6,
                TaskName = "Design",
                StartDate = new DateTime(2021, 08, 25),
                EndDate = new DateTime(2024, 06, 27),
                Progress = 86,
                Duration = 3,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 14),
                Approved = false,
                Children = new List<TreeGridItems>(),
            };

            TreeGridItems Child5 = new TreeGridItems()
            {
                TaskId = 7,
                TaskName = "Software Specification",
                StartDate = new DateTime(2021, 08, 25),
                EndDate = new DateTime(2024, 06, 27),
                Duration = 3,
                Progress = 60,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Approved = false
            };

            TreeGridItems Child6 = new TreeGridItems()
            {
                TaskId = 8,
                TaskName = "Develop prototype",
                StartDate = new DateTime(2021, 08, 25),
                EndDate = new DateTime(2024, 06, 27),
                Duration = 3,
                Progress = 100,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Approved = false
            };

            TreeGridItems Child7 = new TreeGridItems()
            {
                TaskId = 9,
                TaskName = "Get approval from customer",
                StartDate = new DateTime(2024, 06, 27),
                EndDate = new DateTime(2024, 06, 27),
                Duration = 2,
                Progress = 100,
                Approved = true,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 13),
                FilterEndDate = new DateTime(2017, 02, 14),
            };

            TreeGridItems Child8 = new TreeGridItems()
            {
                TaskId = 10,
                TaskName = "Design complete",
                StartDate = new DateTime(2024, 06, 27),
                EndDate = new DateTime(2024, 06, 27),
                Duration = 3,
                Progress = 25,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 14),
                FilterEndDate = new DateTime(2017, 02, 14),
                Approved = true
            };

            Record2.Children.Add(Child5);
            Record2.Children.Add(Child6);
            Record2.Children.Add(Child7);
            Record2.Children.Add(Child8);
            TreeGridItems Record3 = new TreeGridItems()
            {
                TaskId = 12,
                TaskName = "Implementation Phase",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 17),
                Priority = "Normal",
                Approved = false,
                Duration = 11,
                Progress = 25,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 17),
                Children = new List<TreeGridItems>(),
            };

            TreeGridItems Record4 = new TreeGridItems()
            {
                TaskId = 13,
                TaskName = "Phase 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "High",
                Approved = false,
                Duration = 11,
                Progress = 25,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<TreeGridItems>(),
            };
            TreeGridItems Record7 = new TreeGridItems()
            {
                TaskId = 14,
                TaskName = "Implementation Module 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "Normal",
                Duration = 11,
                Approved = false,
                Progress = 25,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<TreeGridItems>(),
            };
            TreeGridItems Child9 = new TreeGridItems()
            {
                TaskId = 15,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
                Approved = false
            };
            TreeGridItems Child10 = new TreeGridItems()
            {
                TaskId = 10,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
                Approved = true
            };
            TreeGridItems Child11 = new TreeGridItems()
            {
                TaskId = 17,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 20),
                EndDate = new DateTime(2017, 02, 21),
                Duration = 2,
                Progress = 25,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 20),
                FilterEndDate = new DateTime(2017, 02, 21),
                Approved = true
            };
            TreeGridItems Child12 = new TreeGridItems()
            {
                TaskId = 18,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 24),
                EndDate = new DateTime(2017, 02, 25),
                Duration = 2,
                Progress = 25,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 24),
                FilterEndDate = new DateTime(2017, 02, 25),
                Approved = false
            };
            TreeGridItems Child13 = new TreeGridItems()
            {
                TaskId = 19,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 26),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 25,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 26),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = false
            };
            TreeGridItems Child14 = new TreeGridItems()
            {
                TaskId = 20,
                TaskName = "Phase 1 complete",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 25,
                Priority = "Low",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = true
            };
            Record7.Children.Add(Child9);
            Record7.Children.Add(Child10);
            Record7.Children.Add(Child11);
            Record7.Children.Add(Child12);
            Record7.Children.Add(Child13);
            Record7.Children.Add(Child14);
            Record4.Children.Add(Record7);
            Record3.Children.Add(Record4);
            TreeGridItems Record5 = new TreeGridItems()
            {
                TaskId = 21,
                TaskName = "Phase 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 28),
                Children = new List<TreeGridItems>(),
                Priority = "High",
                Approved = false,
                Progress = 25,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 28),
                Duration = 12,
            };
            TreeGridItems Record8 = new TreeGridItems()
            {
                TaskId = 22,
                TaskName = "Implementation Module 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 28),
                Priority = "Critical",
                Approved = false,
                Progress = 25,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 28),
                Duration = 12,
                Children = new List<TreeGridItems>(),
            };
            TreeGridItems Child15 = new TreeGridItems()
            {
                TaskId = 23,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 20),
                Duration = 4,
                Progress = 50,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 20),
                Approved = true,
            };
            TreeGridItems Child16 = new TreeGridItems()
            {
                TaskId = 24,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 20),
                Duration = 4,
                Progress = 50,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 20),
                Approved = true,
            };
            TreeGridItems Child17 = new TreeGridItems()
            {
                TaskId = 25,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 21),
                EndDate = new DateTime(2017, 02, 24),
                Duration = 2,
                Progress = 25,
                Priority = "High",
                FilterStartDate = new DateTime(2017, 02, 21),
                FilterEndDate = new DateTime(2017, 02, 24),
                Approved = false,
            };
            TreeGridItems Child18 = new TreeGridItems()
            {
                TaskId = 26,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 25),
                EndDate = new DateTime(2017, 02, 26),
                Duration = 2,
                Progress = 25,
                Priority = "Low",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 25),
                FilterEndDate = new DateTime(2017, 02, 26),
            };
            TreeGridItems Child19 = new TreeGridItems()
            {
                TaskId = 27,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 28),
                Duration = 2,
                Progress = 25,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 28),
                Approved = true,
            };
            TreeGridItems Child20 = new TreeGridItems()
            {
                TaskId = 28,
                TaskName = "Phase 2 complete",
                StartDate = new DateTime(2017, 02, 28),
                EndDate = new DateTime(2017, 02, 28),
                Duration = 2,
                Progress = 25,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 28),
                FilterEndDate = new DateTime(2017, 02, 28),
                Approved = false,
            };
            Record8.Children.Add(Child15);
            Record8.Children.Add(Child16);
            Record8.Children.Add(Child17);
            Record8.Children.Add(Child18);
            Record8.Children.Add(Child19);
            Record8.Children.Add(Child20);
            Record5.Children.Add(Record8);
            Record3.Children.Add(Record5);
            TreeGridItems Record6 = new TreeGridItems()
            {
                TaskId = 29,
                TaskName = "Phase 3",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "Normal",
                Approved = false,
                Progress = 25,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Duration = 11,
                Children = new List<TreeGridItems>(),
            };
            TreeGridItems Record9 = new TreeGridItems()
            {
                TaskId = 22,
                TaskName = "Implementation Module 3",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 27),
                Priority = "High",
                Progress = 25,
                Approved = false,
                Duration = 11,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 27),
                Children = new List<TreeGridItems>(),
            };
            TreeGridItems Child21 = new TreeGridItems()
            {
                TaskId = 31,
                TaskName = "Development Task 1",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Low",
                Approved = true,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
            };
            TreeGridItems Child22 = new TreeGridItems()
            {
                TaskId = 32,
                TaskName = "Development Task 2",
                StartDate = new DateTime(2017, 02, 17),
                EndDate = new DateTime(2017, 02, 19),
                Duration = 3,
                Progress = 50,
                Priority = "Normal",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 17),
                FilterEndDate = new DateTime(2017, 02, 19),
            };
            TreeGridItems Child23 = new TreeGridItems()
            {
                TaskId = 33,
                TaskName = "Testing",
                StartDate = new DateTime(2017, 02, 20),
                EndDate = new DateTime(2017, 02, 21),
                Duration = 2,
                Progress = 25,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 20),
                FilterEndDate = new DateTime(2017, 02, 21),
                Approved = true,

            };
            TreeGridItems Child24 = new TreeGridItems()
            {
                TaskId = 34,
                TaskName = "Bug fix",
                StartDate = new DateTime(2017, 02, 24),
                EndDate = new DateTime(2017, 02, 25),
                Duration = 2,
                Progress = 25,
                Priority = "High",
                Approved = false,
                FilterStartDate = new DateTime(2017, 02, 24),
                FilterEndDate = new DateTime(2017, 02, 25),
            };
            TreeGridItems Child25 = new TreeGridItems()
            {
                TaskId = 35,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2017, 02, 26),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 25,
                Priority = "Normal",
                FilterStartDate = new DateTime(2017, 02, 26),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = true,
            };
            TreeGridItems Child26 = new TreeGridItems()
            {
                TaskId = 36,
                TaskName = "Phase 3 complete",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 02, 27),
                Duration = 2,
                Progress = 25,
                Priority = "Critical",
                FilterStartDate = new DateTime(2017, 02, 27),
                FilterEndDate = new DateTime(2017, 02, 27),
                Approved = false,
            };
            Record9.Children.Add(Child21);
            Record9.Children.Add(Child22);
            Record9.Children.Add(Child23);
            Record9.Children.Add(Child24);
            Record9.Children.Add(Child25);
            Record9.Children.Add(Child26);
            Record6.Children.Add(Record9);
            Record3.Children.Add(Record6);
            BusinessObjectCollection.Add(Record1);
            BusinessObjectCollection.Add(Record2);
            BusinessObjectCollection.Add(Record3);

            return BusinessObjectCollection;
        }

        public class ShipmentData
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Units { get; set; }
            public string Category { get; set; }
            public int UnitPrice { get; set; }
            public int Price { get; set; }
            public string ShipmentCategory { get; set; }
            public DateTime ShippedDate { get; set; }
            public DateTime OrderDate { get; set; }
            public List<ShipmentData> Children { get; set; }


            public static List<ShipmentData> GetShipmentData()
            {

                List<ShipmentData> DataCollection = new List<ShipmentData>();

                ShipmentData Parent1 = new ShipmentData()
                {
                    ID = "1",
                    Name = "Order 1",
                    Units = 1395,
                    UnitPrice = 47,
                    Price = 65565,
                    OrderDate = new DateTime(2017, 3, 2),
                    ShippedDate = new DateTime(2017, 9, 2),
                    ShipmentCategory = "Seafood",
                    Children = new List<ShipmentData>()
                };

                ShipmentData Child1 = new ShipmentData()
                {
                    ID = "1.1",
                    Name = "Mackerel",
                    Category = "Frozen Seafood",
                    Units = 235,
                    UnitPrice = 12,
                    Price = 2820,
                    OrderDate = new DateTime(2017, 3, 3),
                    ShippedDate = new DateTime(2017, 10, 3),
                    ShipmentCategory = "Frozen Seafood"
                };

                ShipmentData Child2 = new ShipmentData()
                {
                    ID = "1.2",
                    Name = "Yellowfin Tuna",
                    Category = "Frozen Seafood",
                    Units = 324,
                    UnitPrice = 8,
                    Price = 2592,
                    OrderDate = new DateTime(2017, 3, 5),
                    ShippedDate = new DateTime(2017, 10, 5),
                    ShipmentCategory = "Frozen Seafood"
                };
                ShipmentData Child3 = new ShipmentData()
                {
                    ID = "1.3",
                    Name = "Herrings",
                    Category = "Frozen Seafood",
                    Units = 488,
                    UnitPrice = 11,
                    Price = 5368,
                    OrderDate = new DateTime(2017, 8, 5),
                    ShippedDate = new DateTime(2017, 5, 15),
                    ShipmentCategory = "Frozen Seafood"
                };
                ShipmentData Child4 = new ShipmentData()
                {
                    ID = "1.4",
                    Name = "Preserved Olives",
                    Category = "Edible",
                    Units = 125,
                    UnitPrice = 9,
                    Price = 1125,
                    OrderDate = new DateTime(2017, 6, 10),
                    ShippedDate = new DateTime(2017, 6, 17),
                    ShipmentCategory = "Edible"
                };
                ShipmentData Child5 = new ShipmentData()
                {
                    ID = "1.5",
                    Name = " Sweet corn Frozen ",
                    Category = "Edible",
                    Units = 223,
                    UnitPrice = 7,
                    Price = 1561,
                    OrderDate = new DateTime(2017, 7, 12),
                    ShippedDate = new DateTime(2017, 7, 19),
                    ShipmentCategory = "Edible"
                };
                Parent1.Children.Add(Child1);
                Parent1.Children.Add(Child2);
                Parent1.Children.Add(Child3);
                Parent1.Children.Add(Child4);
                Parent1.Children.Add(Child5);

                ShipmentData Parent2 = new ShipmentData()
                {
                    ID = "2",
                    Name = "Order 2",
                    Units = 1944,
                    UnitPrice = 58,
                    Price = 21233,
                    OrderDate = new DateTime(2017, 1, 10),
                    ShippedDate = new DateTime(2017, 1, 16),
                    ShipmentCategory = "Seafood",
                    Children = new List<ShipmentData>()
                };

                ShipmentData Child6 = new ShipmentData()
                {
                    ID = "2.1",
                    Name = "Tilapias",
                    Category = "Frozen Seafood",
                    Units = 278,
                    UnitPrice = 15,
                    Price = 4170,
                    OrderDate = new DateTime(2017, 2, 5),
                    ShippedDate = new DateTime(2017, 2, 12),
                    ShipmentCategory = "Frozen Seafood"
                };

                ShipmentData Child7 = new ShipmentData()
                {
                    ID = "2.2",
                    Name = "White Shrimp",
                    Category = "Frozen Seafood",
                    Units = 560,
                    UnitPrice = 7,
                    Price = 3920,
                    OrderDate = new DateTime(2017, 5, 22),
                    ShippedDate = new DateTime(2017, 5, 29),
                    ShipmentCategory = "Frozen Seafood"
                };
                ShipmentData Child8 = new ShipmentData()
                {
                    ID = "2.3",
                    Name = "Fresh Cheese",
                    Category = "Dairy",
                    Units = 323,
                    UnitPrice = 12,
                    Price = 3876,
                    OrderDate = new DateTime(2017, 6, 8),
                    ShippedDate = new DateTime(2017, 6, 15),
                    ShipmentCategory = "Dairy"
                };
                ShipmentData Child9 = new ShipmentData()
                {
                    ID = "2.4",
                    Name = "Blue Veined Cheese",
                    Category = "Dairy",
                    Units = 370,
                    UnitPrice = 15,
                    Price = 5550,
                    OrderDate = new DateTime(2017, 7, 10),
                    ShippedDate = new DateTime(2017, 7, 17),
                    ShipmentCategory = "Dairy"
                };
                ShipmentData Child10 = new ShipmentData()
                {
                    ID = "2.5",
                    Name = "Butter",
                    Category = "Dairy",
                    Units = 413,
                    UnitPrice = 9,
                    Price = 3717,
                    OrderDate = new DateTime(2017, 9, 18),
                    ShippedDate = new DateTime(2017, 9, 25),
                    ShipmentCategory = "Dairy"
                };

                Parent2.Children.Add(Child6);
                Parent2.Children.Add(Child7);
                Parent2.Children.Add(Child8);
                Parent2.Children.Add(Child9);
                Parent2.Children.Add(Child10);

                ShipmentData Parent3 = new ShipmentData()
                {
                    ID = "3",
                    Name = "Order 3",
                    Units = 1944,
                    UnitPrice = 58,
                    Price = 21233,
                    OrderDate = new DateTime(2017, 9, 10),
                    ShippedDate = new DateTime(2017, 9, 20),
                    ShipmentCategory = "Seafood",
                    Children = new List<ShipmentData>()
                };

                ShipmentData Child11 = new ShipmentData()
                {
                    ID = "3.1",
                    Name = "Lead glassware",
                    Category = "Solid crystals",
                    Units = 542,
                    UnitPrice = 6,
                    Price = 3252,
                    OrderDate = new DateTime(2017, 2, 7),
                    ShippedDate = new DateTime(2017, 2, 14),
                    ShipmentCategory = "Solid crystals"
                };

                ShipmentData Child12 = new ShipmentData()
                {
                    ID = "3.2",
                    Name = "Pharmaceutical Glass",
                    Category = "Solid crystals",
                    Units = 324,
                    UnitPrice = 11,
                    Price = 3564,
                    OrderDate = new DateTime(2017, 4, 19),
                    ShippedDate = new DateTime(2017, 4, 26),
                    ShipmentCategory = "Solid crystals"
                };
                ShipmentData Child13 = new ShipmentData()
                {
                    ID = "3.3",
                    Name = "Glass beads",
                    Category = "Solid crystals",
                    Units = 254,
                    UnitPrice = 16,
                    Price = 4064,
                    OrderDate = new DateTime(2017, 5, 22),
                    ShippedDate = new DateTime(2017, 3, 22),
                    ShipmentCategory = "Solid crystals"
                };

                Parent3.Children.Add(Child11);
                Parent3.Children.Add(Child12);
                Parent3.Children.Add(Child13);

                DataCollection.Add(Parent1);
                DataCollection.Add(Parent2);
                DataCollection.Add(Parent3);

                return DataCollection;

            }
        }

        public static List<object> GetTemplateData()
        {
            List<Object> DataCollection = new List<object>();
            List<Object> Child111 = new List<object>();
            Child111.Add(new
            {
                Name = "Andrew Fuller",
                FullName = "AndrewFuller",
                Designation = "Sales Representative",
                EmployeeID = "4",
                EmpID = "EMP045",
                Address = "14 Garrett Hill, London",
                Contact = "(71) 555-4848",
                Country = "UK",
                DOB = new DateTime(1980, 9, 20)
            });
            Child111.Add(new
            {
                Name = "Anne Dodsworth",
                FullName = "AnneDodsworth",
                Designation = "Sales Representative",
                EmployeeID = "5",
                EmpID = "EMP091",
                Address = "4726 - 11th Ave. N.E., Seattle",
                Contact = "(206) 555-1189",
                Country = "USA",
                DOB = new DateTime(1989, 10, 19)
            });
            Child111.Add(new
            {
                Name = "Michael Suyama",
                FullName = "MichaelSuyama",
                Designation = "Sales Representative",
                EmployeeID = "6",
                EmpID = "EMP110",
                Address = "Coventry House Miner Rd., London",
                Contact = "(71) 555-3636",
                Country = "UK",
                DOB = new DateTime(1987, 11, 02)
            });
            Child111.Add(new
            {
                Name = "Janet Leverling",
                FullName = "JanetLeverling",
                Designation = "Sales Coordinator",
                EmployeeID = "7",
                EmpID = "EMP131",
                Address = "Edgeham Hollow Winchester Way, London",
                Contact = "(71) 555-3636",
                Country = "UK",
                DOB = new DateTime(1090, 11, 06)
            });
            List<Object> Child11 = new List<object>();
            Child11.Add(new
            {
                Name = "Nancy Davolio",
                FullName = "NancyDavolio",
                Designation = "Marketing Executive",
                EmployeeID = "3",
                EmpID = "EMP035",
                Address = "4110 Old Redmond Rd., Redmond",
                Contact = "(206) 555-8122",
                Country = "USA",
                DOB = new DateTime(1966, 3, 19),
                Children = Child111
            });
            List<Object> Child112 = new List<object>();
            Child112.Add(new
            {
                Name = "Margaret Peacock",
                FullName = "MargaretPeacock",
                Designation = "Sales Representative",
                EmployeeID = "9",
                EmpID = "EMP213",
                Address = "4726 - 11th Ave. N.E., California",
                Contact = "(206) 555-1989",
                Country = "USA",
                DOB = new DateTime(1986, 1, 21)
            });
            Child112.Add(new
            {
                Name = "Steven Buchanan",
                FullName = "StevenBuchanan",
                Designation = "Sales Representative",
                EmployeeID = "11",
                EmpID = "EMP197",
                Address = "200 Lincoln Ave, Salinas, CA 93901",
                Contact = "(831) 758-7408",
                Country = "USA",
                DOB = new DateTime(1987, 3, 23)
            });
            Child112.Add(new
            {
                Name = "Tedd Lawson",
                FullName = "TeddLawson",
                Designation = "Sales Representative",
                EmployeeID = "12",
                EmpID = "EMP167",
                Address = "200 Lincoln Ave, Salinas, CA 93901",
                Contact = "(831) 758-7368",
                Country = "USA",
                DOB = new DateTime(1989, 8, 9)
            });
            Child11.Add(new
            {
                Name = "Romey Wilson",
                FullName = "RomeyWilson",
                Designation = "Sales Executive",
                EmployeeID = "8",
                EmpID = "EMP039",
                Address = "7 Houndstooth Rd., London",
                Contact = "(71) 555-3690",
                Country = "UK",
                DOB = new DateTime(1980, 2, 2),
                Children = Child112
            });
            List<Object> Child1 = new List<object>();
            Child1.Add(new
            {
                Name = "David william",
                FullName = "DavidWilliam",
                Designation = "Vice President",
                EmployeeID = "2",
                EmpID = "EMP004",
                Address = "722 Moss Bay Blvd., Kirkland",
                Contact = "(206) 555-3412",
                Country = "USA",
                DOB = new DateTime(1971, 5, 20),
                Children = Child11
            });
            DataCollection.Add(new
            {
                Name = "Robert King",
                FullName = "RobertKing",
                Designation = "Chief Executive Officer",
                EmployeeID = "1",
                EmpID = "EMP001",
                Address = "507 - 20th Ave. E.Apt. 2A, Seattle",
                Contact = "(206) 555-9857",
                Country = "USA",
                DOB = new DateTime(1963, 2, 15),
                Children = Child1
            });
            return DataCollection;
        }
        public static List<TreeGridItems> GetSelfData()
        {
            List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 1,
                TaskName = "Parent Task 1",
                StartDate = new DateTime(2017, 10, 23),
                EndDate = new DateTime(2017, 11, 27),
                Duration = 10,
                Progress = 70,
                Priority = "Critical",
                ParentId = null
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 2,
                TaskName = "Child task 1",
                StartDate = new DateTime(2017, 10, 23),
                EndDate = new DateTime(2017, 12, 25),
                Duration = 4,
                Progress = 80,
                Priority = "Low",
                ParentId = 1
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 3,
                TaskName = "Child Task 2",
                StartDate = new DateTime(2017, 10, 24),
                EndDate = new DateTime(2018, 03, 19),
                Duration = 5,
                Progress = 65,
                Priority = "High",
                ParentId = 1
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 4,
                TaskName = "Child task 3",
                StartDate = new DateTime(2017, 10, 25),
                EndDate = new DateTime(2018, 10, 26),
                Duration = 6,
                Progress = 77,
                Priority = "Low",
                ParentId = 1
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 5,
                TaskName = "Parent Task 2",
                StartDate = new DateTime(2017, 10, 23),
                EndDate = new DateTime(2018, 10, 27),
                Duration = 10,
                Progress = 70,
                Priority = "Breaking",
                ParentId = null
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 6,
                TaskName = "Child task 1",
                StartDate = new DateTime(2017, 10, 23),
                EndDate = new DateTime(2017, 12, 19),
                Duration = 4,
                Progress = 80,
                Priority = "Normal",
                ParentId = 5
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 7,
                TaskName = "Child Task 2",
                StartDate = new DateTime(2017, 10, 24),
                EndDate = new DateTime(2017, 11, 20),
                Duration = 5,
                Priority = "High",
                Progress = 65,
                ParentId = 5
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 8,
                TaskName = "Child task 3",
                StartDate = new DateTime(2017, 10, 25),
                EndDate = new DateTime(2018, 11, 20),
                Duration = 6,
                Priority = "High",
                Progress = 77,
                ParentId = 5
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 9,
                TaskName = "Child task 4",
                StartDate = new DateTime(2017, 10, 25),
                EndDate = new DateTime(2018, 03, 19),
                Duration = 6,
                Progress = 77,
                Priority = "Low",
                ParentId = 5
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 10,
                TaskName = "Parent Task 3",
                StartDate = new DateTime(2017, 10, 23),
                EndDate = new DateTime(2018, 03, 25),
                Duration = 10,
                Progress = 70,
                Priority = "Normal",
                ParentId = null
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 11,
                TaskName = "Child task 1",
                StartDate = new DateTime(2017, 10, 23),
                Duration = 4,
                EndDate = new DateTime(2017, 10, 30),
                Priority = "Low",
                Progress = 80,
                ParentId = 10
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 12,
                TaskName = "Child Task 2",
                StartDate = new DateTime(2017, 10, 24),
                EndDate = new DateTime(2018, 11, 19),
                Duration = 5,
                Progress = 65,
                Priority = "Critical",
                ParentId = 10
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 13,
                TaskName = "Child task 3",
                StartDate = new DateTime(2017, 10, 25),
                EndDate = new DateTime(2017, 11, 10),
                Duration = 6,
                Progress = 77,
                Priority = "Critical",
                ParentId = 10
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 14,
                TaskName = "Child task 4",
                StartDate = new DateTime(2017, 10, 25),
                EndDate = new DateTime(2017, 11, 12),
                Duration = 6,
                Progress = 77,
                Priority = "High",
                ParentId = 10
            });
            BusinessObjectCollection.Add(new TreeGridItems()
            {
                TaskId = 15,
                TaskName = "Child task 5",
                StartDate = new DateTime(2017, 10, 25),
                EndDate = new DateTime(2017, 11, 23),
                Duration = 6,
                Progress = 77,
                Priority = "Low",
                ParentId = 10
            });

            return BusinessObjectCollection;
        }
    }
    public class TreeDataFormat
    {
        public TreeDataFormat() { }
        public string orderID { get; set; }
        public string orderName { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime shippedDate { get; set; }
        public int units { get; set; }
        public double price { get; set; }
        public int unitPrice { get; set; }
        public string category { get; set; }
        public List<TreeDataFormat> subTasks { get; set; }
        public static List<TreeDataFormat> GetDataFormat()
        {
            List<TreeDataFormat> data = new List<TreeDataFormat>()
            {
                new TreeDataFormat()
                {
                    orderID= "1",
                    orderName= "Order 1",
                    orderDate= new DateTime(2017, 03, 02),
                    shippedDate= new DateTime(2019, 10, 09),
                    units= 1395,
                    unitPrice= 47,
                    price=133.66,
                    category= "Seafood",
                    subTasks= new List<TreeDataFormat>() {
                        new TreeDataFormat() { orderID= "1.1", orderName= "Mackerel", category= "Frozen seafood", units= 23,
                            orderDate= new DateTime(2017, 03, 02), shippedDate= new DateTime(2019, 05, 13), unitPrice= 12, price= 28.20 },
                        new TreeDataFormat() { orderID= "1.2", orderName= "Mackerel", category= "Frozen seafood", units= 23,
                            orderDate= new DateTime(2017, 03, 05), shippedDate= new DateTime(2019, 05, 22), unitPrice= 11, price= 25.92 },
                        new TreeDataFormat() { orderID= "1.3", orderName= "Mackerel", category= "Frozen seafood", units= 23,
                            orderDate= new DateTime(2017, 03, 10), shippedDate= new DateTime(2019, 10, 14), unitPrice= 8, price= 52.68 },
                        new TreeDataFormat() { orderID= "1.4", orderName= "Mackerel", category= "Edible", units= 23,
                            orderDate= new DateTime(2017, 03, 08), shippedDate= new DateTime(2019, 08, 03), unitPrice= 9, price= 11.25 },
                        new TreeDataFormat() { orderID= "1.5", orderName= "Mackerel", category= "Edible", units= 23,
                            orderDate= new DateTime(2017, 03, 09), shippedDate= new DateTime(2019, 03, 09), unitPrice= 7, price= 15.61 }
                    }
                },
                new TreeDataFormat()
                {
                    orderID= "2",
                    orderName= "Order 2",
                    orderDate= new DateTime(2017, 03, 05),
                    shippedDate= new DateTime(2019, 05, 03),
                    units= 1944,
                    unitPrice= 58,
                    price=212.33,
                    category= "Seafood",
                    subTasks= new List<TreeDataFormat>() {
                        new TreeDataFormat() { orderID= "2.1", orderName= "Tilapias", category= "Frozen seafood", units= 278,
                            orderDate= new DateTime(2017, 03, 05), shippedDate= new DateTime(2019, 03, 15), unitPrice= 15, price= 55.50 },
                        new TreeDataFormat() { orderID= "2.2", orderName= "White Shrimp", category= "Frozen seafood", units= 560,
                            orderDate= new DateTime(2017, 05, 07), shippedDate= new DateTime(2019, 09, 19), unitPrice= 7, price= 41.70 },
                        new TreeDataFormat() { orderID= "2.3", orderName= "Fresh Cheese", category= "Dairy", units= 323,
                            orderDate= new DateTime(2017, 03, 09), shippedDate= new DateTime(2019, 11, 13), unitPrice= 8, price= 39.20 },
                        new TreeDataFormat() { orderID= "2.4", orderName= "Blue Veined Cheese", category= "Dairy", units= 373,
                            orderDate= new DateTime(2017, 03, 11), shippedDate= new DateTime(2019, 11, 13), unitPrice= 9, price= 38.76 },
                        new TreeDataFormat() { orderID= "2.5", orderName= "Butter", category= "Dairy", units= 413,
                            orderDate= new DateTime(2017, 12, 23), shippedDate= new DateTime(2019, 12, 23), unitPrice= 7, price= 37.17 }
                    }
                },
                new TreeDataFormat()
                {
                    orderID= "3",
                    orderName= "Order 3",
                    orderDate= new DateTime(2017, 03, 10),
                    shippedDate= new DateTime(2019, 05, 20),
                    units = 1120,
                    unitPrice = 33,
                    price = 108.80,
                    category= "Seafood",
                    subTasks= new List<TreeDataFormat>() {
                        new TreeDataFormat() { orderID= "2.1", orderName= "Lead glassware", category= "Solid crystals", units= 542,
                            orderDate= new DateTime(2017, 03, 05), shippedDate= new DateTime(2019, 03, 15), unitPrice= 6, price= 32.52 },
                        new TreeDataFormat() { orderID= "2.2", orderName= "Glassware", category= "Solid crystals", units= 324,
                            orderDate= new DateTime(2017, 05, 07), shippedDate= new DateTime(2019, 09, 19), unitPrice= 11, price= 35.64 },
                        new TreeDataFormat() { orderID= "2.3", orderName= "Glass beads", category= "Solid crystals", units= 254,
                            orderDate= new DateTime(2017, 03, 09), shippedDate= new DateTime(2019, 11, 13), unitPrice= 16, price= 40.64 },
                        }
                }
            };
            return data;
        }
    }
    public class TreeGridHeader
    {
        public DateTime StartDate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int PercentDone { get; set; }
        public List<TreeGridHeader> Children { get; set; }
        public string Resources { get; set; }

        public static List<TreeGridHeader> GetDataSource()
        {
            List<TreeGridHeader> BusinessObjectCollection = new List<TreeGridHeader>();
            BusinessObjectCollection.Add(new TreeGridHeader()
            {
                Id = 1,
                Name = "Task 1",
                StartDate = new DateTime(2017, 10, 23),
                Duration = 10,
                PercentDone = 70,
                Resources = "1",

                Children = (new List<TreeGridHeader>()
                    {
                        new TreeGridHeader()
                        {
                            Id = 2,
                            Name = "Child task 1",
                            StartDate = new DateTime(2017, 10, 23),
                            Duration = 4,
                            PercentDone = 80,
                            Resources ="4"
                        },
                        new TreeGridHeader()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = new DateTime(2017, 10, 24),
                            Duration = 5,
                            PercentDone = 65,
                            Resources ="1"
                        },
                        new TreeGridHeader()
                        {
                            Id = 4,
                            Name = "Child task 3",
                            StartDate = new DateTime(2017, 10, 25),
                            Duration = 6,
                            PercentDone = 77,
                            Resources ="5",
                            Children = (new List<TreeGridHeader>()
                            {
                                new TreeGridHeader()
                                {
                                    Id = 5,
                                    Name = "Grand child task 1",
                                    StartDate = new DateTime(2017, 10, 28),
                                    Duration = 5,
                                    PercentDone = 60,
                                    Resources ="7",
                                },
                                new TreeGridHeader()
                                {
                                    Id = 6,
                                    Name = "Grand child task 2",
                                    StartDate = new DateTime(2017, 10, 29),
                                    Duration = 6,
                                    PercentDone = 77,
                                    Resources ="7",
                                },
                                new TreeGridHeader()
                                {
                                    Id = 7,
                                    Name = "Grand child task 3",
                                    StartDate = new DateTime(2017, 10, 29),
                                    Duration = 3,
                                    PercentDone = 77,
                                    Resources ="8"

                                }
                            })
                        }
                    })

            });
            BusinessObjectCollection.Add(new TreeGridHeader()
            {
                Id = 8,
                Name = "Task 2",
                StartDate = new DateTime(2017, 10, 23),
                Duration = 10,
                PercentDone = 70,
                Resources = "5",

                Children = (new List<TreeGridHeader>()
                    {
                        new TreeGridHeader()
                        {
                            Id = 9,
                            Name = "Child task 1",
                            StartDate = new DateTime(2017, 10, 23),
                            Duration = 4,
                            PercentDone = 80,
                            Resources ="4",
                        },
                        new TreeGridHeader()
                        {
                            Id = 10,
                            Name = "Child Task 2",
                            StartDate = new DateTime(2017, 10, 24),
                            Duration = 5,
                            PercentDone = 65,
                            Resources ="1",
                        },
                        new TreeGridHeader()
                        {
                            Id = 11,
                            Name = "Child task 3",
                            StartDate = new DateTime(2017, 10, 25),
                            Duration = 6,
                            PercentDone = 77,
                            Resources ="5",
                            Children = (new List<TreeGridHeader>()
                            {
                                new TreeGridHeader()
                                {
                                    Id = 12,
                                    Name = "Grand child task 1",
                                    StartDate = new DateTime(2017, 10, 28),
                                    Duration = 5,
                                    PercentDone = 60,
                                    Resources ="7",
                                },
                                new TreeGridHeader()
                                {
                                    Id = 13,
                                    Name = "Grand child task 2",
                                    StartDate = new DateTime(2017, 10, 29),
                                    Duration = 6,
                                    PercentDone = 77,
                                    Resources ="7",
                                },
                                new TreeGridHeader()
                                {
                                    Id = 14,
                                    Name = "Grand child task 3",
                                    StartDate = new DateTime(2017, 10, 29),
                                    Duration = 3,
                                    PercentDone = 88,
                                    Resources ="8"

                                }
                            })
                        }
                    })

            });
            return BusinessObjectCollection;
        }
    }
}
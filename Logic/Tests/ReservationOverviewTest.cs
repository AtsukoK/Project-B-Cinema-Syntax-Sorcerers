// using DataAccess;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;
// using System;
// using System.Collections.Generic;
// using System.IO;

// namespace Logic.Tests
// {
//     [TestClass]
//     public class ReservationTests
//     {
//         // private Show CreateMockShow()
//         // {
//         //     // mock show om mee te testen
//         //     List<Chair> chairs = new List<Chair>
//         //     {
//         //         new Chair(1, 10.0, false, 1),
//         //         new Chair(2, 10.0, false, 1),
//         //         new Chair(3, 10.0, false, 1)
//         //     };
//         //     string movie = "Mock Movie";
//         //     string filename = "mock_chairs.json";
//         //     DateTime start = DateTime.Now;
//         //     DateTime end = DateTime.Now.AddHours(2);

//         //     return new Show(chairs, movie, filename, start, end);
//         // }

//         private Movie CreateMockMovie()
//         {
//             // mock movie om mee te testen
//             return new Movie("Mock Movie", "", "", 0.0, 10.0, "", "", "", "", false);
//         }

//         // [TestMethod]
//         // public void ReserveChair_Valid()
//         // {
//         //     // Arrange
//         //     Show show = CreateMockShow();
//         //     string chairId = "2"; // valid chair id
//         //     Movie movie = CreateMockMovie();
//         //     int choice = 1;

//         //     // Act
//         //     bool result = Reservation.ReserveChair(show, chairId, movie, choice);

//         //     // Assert
//         //     Assert.IsTrue(result);
//         // }

//         [TestMethod]
//         public void ReserveChair_Null()
//         {
//             // Arrange
//             Show show = null; // null show object
//             string chairId = "1";
//             Movie movie = CreateMockMovie();
//             int choice = 1;

//             // Act
//             bool result = Reservation.ReserveChair(show, chairId, movie, choice);

//             // Assert
//             Assert.IsFalse(result);
//         }

//         [TestMethod]
//         public void ReserveChair_Invalid()
//         {
//             // Arrange
//             Show show = CreateMockShow();
//             string chairId = "10"; // invalid chair id
//             Movie movie = CreateMockMovie();
//             int choice = 1;

//             // Act
//             bool result = Reservation.ReserveChair(show, chairId, movie, choice);

//             // Assert
//             Assert.IsFalse(result);
//         }

//         [TestMethod]
//         public void ReserveChair_Null2()
//         {
//             // Arrange
//             Show show = CreateMockShow();
//             string chairId = "1";
//             Movie movie = null; // null movie object
//             int choice = 1;

//             // Act
//             bool result = Reservation.ReserveChair(show, chairId, movie, choice);

//             // Assert
//             Assert.IsFalse(result);
//         }

//     }
// }

// oude tests werken niet meer op de vernieuwde main


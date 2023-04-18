//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks; 
//using global::AOS_WCID.Data;    
//using global::AOS_WCID.Entities;
//using global::AOS_WCID.Konsole.Setup;
//using global::AOS_WCID.Konsole;
//using AOS_WCID.Logic;

//namespace WCID_UnitTests
//{

//    [TestClass]
//        public class UnitsSetupTest
//        {
//            [TestMethod]
//            public void EingabeBattallion_ValidInput_ShouldSetPlayerPickBatallion()
//            {
//            // Arrange
            
//                var unitsSetup = new UnitsSetup();
//                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion1", "Description1", 1, 2, 3, 4, 5));
//                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion2", "Description2", 2, 3, 4, 5, 6));

//                // Act
//                var consolenReader = new ConsolenReader();
//                consolenReader.SetFakeInput("1"); // simulate user input
//                unitsSetup.EingabeBattallion();

//                // Assert
//                Assert.Equals(unitsSetup.initialStuff.BatallionList[1], unitsSetup.PlayerPicks.Instance.Batallion);
//            }

//            [TestMethod]
//            public void EingabeBattallion_InvalidInput_ShouldNotSetPlayerPickBatallion()
//            {
//                // Arrange
//                var unitsSetup = new UnitsSetup();
//                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion1", "Description1", 1, 2, 3, 4, 5));
//                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion2", "Description2", 2, 3, 4, 5, 6));

//                // Act
//                var consolenReader = new ConsolenReader();
//                consolenReader.SetFakeInput("invalid"); // simulate user input
//                unitsSetup.EingabeBattallion();

//                // Assert
//                Assert.Null(unitsSetup.PlayerPicks.Instance.Batallion);
//            }
//        [TestMethod]
//        public void EingabeBattallion_ValidInput_ShouldSetPlayerPickBatallion1()
//        {
//            // Arrange
//            var PlayerPicks.Instance = new PlayerPicks();
//            var initialStuff = new DataProvider();
//            var unitsSetup = new UnitsSetup(PlayerPicks.Instance, initialStuff);
//            initialStuff.BatallionList.Add(new Batallion("Batallion1", "Description1", 1, 2, 3, 4, 5));
//            initialStuff.BatallionList.Add(new Batallion("Batallion2", "Description2", 2, 3, 4, 5, 6));

//            // Act
//            inputValidator.SetFakeInput("1");
//            unitsSetup.EingabeBattallion();

//            // Assert
//            Assert.Equals(initialStuff.BatallionList[1], PlayerPicks.Instance.Batallion);
//        }

//        [TestMethod]
//        public void EingabeBattallion_InvalidInput_ShouldNotSetPlayerPickBatallion1()
//        {
//            // Arrange
//            var PlayerPicks.Instance = new PlayerPicks();
//            var initialStuff = new DataProvider();
            
//            var unitsSetup = new UnitsSetup(PlayerPicks.Instance, initialStuff);
//            initialStuff.BatallionList.Add(new Batallion("Batallion1", "Description1", 1, 2, 3, 4, 5));
//            initialStuff.BatallionList.Add(new Batallion("Batallion2", "Description2", 2, 3, 4, 5, 6));

//            // Act
//            SetFakeInput("invalid input");
//            unitsSetup.EingabeBattallion();

//            // Assert
//            Assert.IsNull(PlayerPicks.Instance.Batallion);
//        }
//    }
//}

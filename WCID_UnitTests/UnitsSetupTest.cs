using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using global::AOS_WCID.Data;    
using global::AOS_WCID.Entities;
using global::AOS_WCID.Konsole.Setup;
using global::AOS_WCID.Konsole;


namespace WCID_UnitTests
{

    [TestClass]
        public class UnitsSetupTest
        {
            [TestMethod]
            public void EingabeBattallion_ValidInput_ShouldSetPlayerPickBatallion()
            {
            // Arrange
            InputValidator inputValidator = new InputValidator();
                var unitsSetup = new UnitsSetup();
                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion1", "Description1", 1, 2, 3, 4, 5));
                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion2", "Description2", 2, 3, 4, 5, 6));

                // Act
                var consolenReader = new ConsolenReader();
                consolenReader.SetFakeInput("1"); // simulate user input
                unitsSetup.EingabeBattallion();

                // Assert
                Assert.Equal(unitsSetup.initialStuff.BatallionList[1], unitsSetup.playerPick.Batallion);
            }

            [TestMethod]
            public void EingabeBattallion_InvalidInput_ShouldNotSetPlayerPickBatallion()
            {
                // Arrange
                var inputValidator = new InputValidator();
                var unitsSetup = new UnitsSetup();
                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion1", "Description1", 1, 2, 3, 4, 5));
                unitsSetup.initialStuff.BatallionList.Add(new Batallion("Batallion2", "Description2", 2, 3, 4, 5, 6));

                // Act
                var consolenReader = new ConsolenReader();
                consolenReader.SetFakeInput("invalid"); // simulate user input
                unitsSetup.EingabeBattallion();

                // Assert
                Assert.Null(unitsSetup.playerPick.Batallion);
            }
        }
}

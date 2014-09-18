using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mastermind {
    [TestClass]
    public class testsGameState {

        [TestMethod]
        public void testGameStateConstructor() {
            byte numberOfPins = 4;
            byte numberOfColors = 4;
            byte numberOfTries = 4;
            bool computerIsPlaying = true;

            GameState newState = new GameState(numberOfTries, numberOfPins, numberOfColors, computerIsPlaying);

            Assert.AreEqual(computerIsPlaying, newState.ComputerIsPlaying);
            Assert.AreEqual(numberOfColors, newState.NrOfAvailableColors);
            Assert.AreEqual(numberOfTries, newState.NrOfTries);
            Assert.AreEqual(numberOfPins, newState.NrOfPins);
        }/*testGameStateConstructor*/

        [TestMethod]
        public void testCreateSecretComboOnLength() {
            Mastermind mm = new Mastermind();
            ColorSequence secretcombo = mm.GameState.SecretCombo;
            byte lengthOfSecretCombo = 4;
            Assert.AreEqual(secretcombo.Length, lengthOfSecretCombo);
        }/*testCreateSecretComboOnLength*/

        [TestMethod]
        public void testCreateSecretComboOnAvailableColors() {
            Mastermind mm = new Mastermind();
            GameState settings = mm.GameState;
            ColorSequence secretcombo = mm.GameState.SecretCombo;
            byte lengthOfSecretCombo = 4;
            byte nrPermittedOfColors = 0;

            for (byte i = 0; i < lengthOfSecretCombo; i++) {
                for (byte j = 0; j < settings.NrOfAvailableColors; j++) {
                    if (secretcombo.getColorOnPlace(i) == (Colors)j) {
                        nrPermittedOfColors++;
                    }
                }
            }

            Assert.AreEqual(nrPermittedOfColors, lengthOfSecretCombo);
        }/*testCreateSecretComboOnAvailableColors*/

        [TestMethod]
        public void testColorIsUnique() {
            Mastermind mm = new Mastermind();
            GameState settings = mm.GameState;
            ColorSequence secretcombo = mm.GameState.SecretCombo;
            byte lengthOfSecretCombo = 4;

            for (byte i = 0; i < lengthOfSecretCombo; i++) {
                byte colorFrequency = 0;
                for (byte j = 0; j < settings.NrOfPins; j++) {
						 if (secretcombo.getColorOnPlace(i) == secretcombo.getColorOnPlace(j)) {
                        colorFrequency++;
                    }
                }
                Assert.AreEqual(1, colorFrequency);
                colorFrequency--;
            }
        }/*testColorIsUnique*/

    }
}

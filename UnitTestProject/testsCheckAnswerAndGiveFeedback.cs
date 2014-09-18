using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mastermind {

    [TestClass]
    public class testsCheckAnswerAndGiveFeedback {

        [TestMethod]
        public void testCompareTo() {
            ColorSequence definedColorCombo = createDefinedColorCombo();
            byte amountOfCorrectColorsForIdenticalCombo = (byte)definedColorCombo.Length;
            byte amountOfIncorrectColorsForIdenticalCombo = (byte)0;
            Feedback feedbackForIdenticalCombos =
                new Feedback(amountOfCorrectColorsForIdenticalCombo, amountOfIncorrectColorsForIdenticalCombo);

            Feedback feedbackOfCompareTo = definedColorCombo.compareToColorsequence(definedColorCombo);

            Assert.AreEqual(feedbackForIdenticalCombos, feedbackOfCompareTo);
        }/*testCompareTo*/

        private ColorSequence createDefinedColorCombo() {
            ColorSequence definedColorCombo = new ColorSequence();
            definedColorCombo.addLast(Colors.Yellow);
				definedColorCombo.addLast(Colors.Green);
				definedColorCombo.addLast(Colors.Blue);
				definedColorCombo.addLast(Colors.Red);
            return definedColorCombo;
        }/*createDefinedColorCombo*/

        //[TestMethod] ////oude test, deze functie is weggewerkt geweest na refactoring
        //public void testProcessTry() {
        //    Mastermind mm = new Mastermind();
        //    GameState game = new GameState();
        //    ColorSequence colorComboToProcess = createDefinedColorCombo();
        //    mm.createSecretCombo();

        //    mm.checkAnswerAndGiveFeedbackFor(colorComboToProcess);

        //    foreach (Colors t in colorComboToProcess.ColorCombo) {
        //        Assert.AreEqual(colorComboToProcess.getColorOnPlace(3), settings.TurnHistory[settings.TurnNumber - 1].getColorOnPlace(3));
        //    }
        //}

        //[TestMethod]  //werk enkel wanneer we de secretcombo hardcoden..
        //public void testCheckAnswerAndGiveFeedback() {
        //    Mastermind mm = new Mastermind();
        //    GameState settings = mm.GameState;
        //    ColorSequence colorComboToCheck = createDefinedColorCombo();
        //    mm.createSecretCombo();

        //    mm.checkAnswerAndGiveFeedbackFor(colorComboToCheck);

        //    for (byte i = 0; i < colorComboToCheck.getLength(); i++) {
        //        Assert.AreEqual(colorComboToCheck.getColorOnPlace(i), settings.SecretCombo.getColorOnPlace(i));
        //    }
        //}

    }
}

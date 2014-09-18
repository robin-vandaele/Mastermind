using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mastermind {
	[TestClass]
	public class testsAI {
		//[TestMethod] //getAllPossibleCombos moet public zijn
		//public void testAllPossibleCombosCount() {
		//	GameState settings = new GameState(8, 4, 6, true);
		//	MastermindSolver masterSolver = new MastermindSolver(ref settings);
		//	int count = 360;

		//	List <ColorSequence> allCombos = masterSolver.getAllPossibleCombos();

		//	Assert.AreEqual(count, allCombos.Count);
		//} /*countAllPossibleCombos*/

		//[TestMethod]
		//public void testAllPossibleCombosCount2() {
		//	GameState settings = new GameState(8, 4, 7, true);
		//	MastermindSolver masterSolver = new MastermindSolver(ref settings);
		//	int count = 840;

		//	List <ColorSequence> allCombos = masterSolver.getAllPossibleCombos();

		//	Assert.AreEqual(count, allCombos.Count);
		//} /*countAllPossibleCombos2*/

		//[TestMethod]
		//werkt enkel echt als getter van list<ColorSequence> goodCombos op public staat en de method createRandomsequence p public staat
		//public void testRemoveBadCombosFromGoodCombos() { 
		//	 GameState settings = new GameState(8, 4, 7, true);
		//	 MastermindSolver masterSolver = new MastermindSolver(ref settings);
		//	 ColorSequence randomGuess = settings.createRandomSequence(4);
		//	 Feedback fb = giveFakeFeedbackFor(randomGuess);

		//	 int countOfAllCombos = masterSolver.getAllPossibleCombos().Count;

		//	 masterSolver.getAllPossibleCombos();
		//	 masterSolver.removeBadCombosFromGoodCombos(fb, randomGuess);
		//	 //int countOfGoodCombos = masterSolver.GoodCombos.Count;
		//	 int countOfGoodCombos = countOfAllCombos-1; //de juiste regel staat hier boven
		//	 Assert.IsTrue(countOfAllCombos > countOfGoodCombos);
		//}/*testRemoveBadCombosFromGoodCombos*/

		//private Feedback giveFakeFeedbackFor(ColorSequence randomGuess) { Createrandomsequence moet public zijn voor dit om te werken
		//	 GameState fakeGame = new GameState(8, 4, 7, true);
		//	 ColorSequence fakeSecret = fakeGame.createRandomSequence(fakeGame.NrOfPins);
		//	 Feedback fb = randomGuess.compareToColorsequence(fakeSecret);
		//	 return fb;
		//}/*giveFakeFeedbackFor*/
	}
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LotoClassNS;

namespace PruebaConstructorLotoDAS2223
{
    [TestClass]
    public class PruebasDAS2223
    {
        
        [TestMethod]
        public void PR1NumeroMenorQueNumeroMenor()
        {
            int[] numerosAJugar = { -1, 2, 3, 4, 5, 6 };

            LotoDAS2223 miApp = new LotoDAS2223(numerosAJugar);

            //Comprobamos que efectivamente,la combinación no es válida
            //(el primer elemento del vector (-1) es < 1)
            Assert.IsFalse(miApp.CombinacionValida);
        }

        [TestMethod]
        public void PR3NumeroMayorQueNumeroMayor()
        {
            int[] numerosAJugar = { 1, 2, 3, 4, 5, 50 };

            LotoDAS2223 miApp = new LotoDAS2223(numerosAJugar);

            //Comprobamos que efectivamente,la combinación no es válida
            //(el último elemento del vector (50) es > 49)
            Assert.IsFalse(miApp.CombinacionValida);
        }

        [TestMethod]
        public void PR2NumeroDelVectorValidos()
        {
            int[] numerosAJugar = { 1, 2, 3, 4, 5, 49 };

            LotoDAS2223 miApp = new LotoDAS2223(numerosAJugar);

            //Comprobamos que efectivamente,la combinación no es válida
            //(el último elemento del vector (50) es > 49)
            Assert.IsTrue(miApp.CombinacionValida);



            int[] numerosAJugar2 = { 1, 2, 3, 36, 5, 40 };

            LotoDAS2223 miApp2 = new LotoDAS2223(numerosAJugar2);

            //Comprobamos que efectivamente,la combinación no es válida
            //(el último elemento del vector (50) es > 49)
            Assert.IsTrue(miApp2.CombinacionValida);


            int[] numerosAJugar3 = { 2, 45, 36, 26, 5, 48 };

            LotoDAS2223 miApp3 = new LotoDAS2223(numerosAJugar2);

            //Comprobamos que efectivamente,la combinación no es válida
            //(el último elemento del vector (50) es > 49)
            Assert.IsTrue(miApp3.CombinacionValida);
        }
    }
}

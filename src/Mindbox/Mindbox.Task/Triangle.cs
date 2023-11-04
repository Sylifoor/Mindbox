using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Task
{
    public readonly record struct Triangle : IFigure
    {
        /// <summary>
        /// 
        /// </summary>
        public double SideA { get; init; }

        public double SideB { get; init; }

        public double SideC { get; init; }


        /// <summary></summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <inheritdoc/>
        public double GetArea()
        {
            throw new NotImplementedException();
        }

        /// <summary></summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static bool TryCreate(double sideA, double sideB, double sideC, out Triangle? triangle)
        {
            triangle = null;
            return false;
        }

        /// <summary></summary>
        private static bool CheckCorrect(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}

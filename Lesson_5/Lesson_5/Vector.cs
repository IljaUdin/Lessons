﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Vector
    {
        int _x1, _y1, _z1, _x2, _y2, _z2;
        List<int> _sum, _dif;
        double _vectorLength_1, _vectorLength_2, _vectorProductScalar, _angleBetweenVectors;
        List<double> _vectorProductVector;
        public Vector(List<int> vector_1, List<int> vector_2)
        {
            _x1 = vector_1[0];
            _y1 = vector_1[1];
            _z1 = vector_1[2];

            _x2 = vector_2[0];
            _y2 = vector_2[1];
            _z2 = vector_2[2];
        }
        public double VectorLength_1()
        {
            _vectorLength_1 = Math.Sqrt(Math.Pow(_x1, 2) + Math.Pow(_y1, 2) + Math.Pow(_z1, 2));

            return _vectorLength_1;
        }
        public double VectorLength_2()
        {
            _vectorLength_2 = Math.Sqrt(Math.Pow(_x2, 2) + Math.Pow(_y2, 2) + Math.Pow(_z2, 2));

            return _vectorLength_2;
        }

        public double VectorProductScalar()
        {
            _vectorProductScalar = _x1 * _x2 + _y1 * _y2 + _z1 * _z2;

            return _vectorProductScalar;
        }

        public void VectorProductVector()
        {
            _vectorProductVector = new List<double> { _y1 * _z2 - _z1 * _y2, _z1 * _x2 - _x1 * _z2, _x1 * _y2 - _y1 * _x2 };

            Console.WriteLine("Векторное произведение двух векторов равно : [{0}, {1}, {2}]\n", _vectorProductVector[0], _vectorProductVector[1], _vectorProductVector[2]);
        }
        public void AngleBetweenVectors()
        {
            _angleBetweenVectors = VectorProductScalar() / (Math.Abs(VectorLength_1()) * Math.Abs(VectorLength_2()));

            Console.WriteLine("Угол между векторами (косинус угла) равен : {0:0.000} \n", _angleBetweenVectors);
        }
        public void SumDif()
        {
            _sum = new List<int> { _x1 + _x2, _y1 + _y2, _z1 + _z2 };
            Console.WriteLine("Сумма векторов №1 и №2 равна : [{0}, {1}, {2}] \n", _sum[0], _sum[1], _sum[2]);

            _dif = new List<int> { _x1 - _x2, _y1 - _y2, _z1 - _z2 };
            Console.WriteLine("Разница векторов №1 и №2 равна : [{0}, {1}, {2}]", _dif[0], _dif[1], _dif[2]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Vector
    {
        List<int> _sum, _dif, _list1, _list2;
        double _vectorLength_1, _vectorLength_2, _vectorProductScalar, _angleBetweenVectors;
        List<double> _vectorProductVector;
        public Vector(List<int> vector_1, List<int> vector_2)
        {
            _list1 = vector_1;
            _list2 = vector_2;
        }
        public double VectorLength_1()
        {
            _vectorLength_1 = Math.Sqrt(Math.Pow(_list1[0], 2) + Math.Pow(_list1[1], 2) + Math.Pow(_list1[2], 2));

            return _vectorLength_1;
        }
        public double VectorLength_2()
        {
            _vectorLength_2 = Math.Sqrt(Math.Pow(_list2[0], 2) + Math.Pow(_list2[1], 2) + Math.Pow(_list2[2], 2));

            return _vectorLength_2;
        }

        public double VectorProductScalar()
        {
            _vectorProductScalar = _list1[0] * _list2[0] + _list1[1] * _list2[1] + _list1[2] * _list2[2];

            return _vectorProductScalar;
        }

        public void VectorProductVector()
        {
            _vectorProductVector = new List<double> { _list1[1] * _list2[2] - _list1[2] * _list1[1], _list1[2] * _list2[0] - _list1[0] * _list2[2], _list1[0] * _list2[1] - _list1[1] * _list2[0] };

            Console.WriteLine("Векторное произведение двух векторов равно : [{0}, {1}, {2}]\n", _vectorProductVector[0], _vectorProductVector[1], _vectorProductVector[2]);
        }
        public void AngleBetweenVectors()
        {
            _angleBetweenVectors = VectorProductScalar() / (Math.Abs(VectorLength_1()) * Math.Abs(VectorLength_2()));

            Console.WriteLine("Угол между векторами (косинус угла) равен : {0:0.000} \n", _angleBetweenVectors);
        }
        public void SumDif()
        {
            _sum = new List<int> { _list1[0] + _list2[0], _list1[1] + _list2[1], _list1[2] + _list2[2] };
            Console.WriteLine("Сумма векторов №1 и №2 равна : [{0}, {1}, {2}] \n", _sum[0], _sum[1], _sum[2]);

            _dif = new List<int> { _list1[0] - _list2[0], _list1[1] - _list2[1], _list1[2] - _list2[2] };
            Console.WriteLine("Разница векторов №1 и №2 равна : [{0}, {1}, {2}]", _dif[0], _dif[1], _dif[2]);
        }
    }
}

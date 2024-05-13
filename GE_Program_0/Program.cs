using System;

namespace GE_Program_240513
{
    #region 클래스
    // 클래스
    // 사용자정의 데이터 유형으로 속성과 함수가 포함.
    // 클래스를 통해 객체를 생성하며 접근하고 사용할 수 있는 집합체
    #endregion

    internal class Program
    {
        // Main : 프로그램의 진입점 역할을 수행하는 함수 
        static void Main(string[] args)
        {
            #region 변수
            // 데이터를 저장할 수 있는 메모리 공간을 생성
            // 변수의 메모리 공간은 프로그램이 실행될 때마다 바뀌며
            // 여러 개의 변수가 있을 때 서로 고유의 메모리 공간을 가지고 있다.
            // 변수를 생성하기 위해 메모리 공간의 크기를 지정해주는 자료형을 선언할 필요 있음
            #endregion

            #region 자료형
            // bool
            // int
            // float
            // char
            // short
            // double
            // decimal

            // 데이터를 저장하기 위해 데이터 형태 지정
            // 자료형은 각각의 자료형마다 크기자 정해져 있으며, 자료형의 크기는
            // 바이트 단위로 있으며, 자료형의 경우 자료형에 따라 저장할 수 있는 값의 종류와 범위가 결정됨.
            #endregion 

            bool bData = true;
            int iData = 100;
            char cData = 'C';
            float fData = 3.14f;
            double dData = 65535.5;

            Console.WriteLine($"bool 변수의 값 : {bData}");
            Console.WriteLine($"int 변수의 값 : {iData}");
            Console.WriteLine($"char 변수의 값 : {cData}");
            Console.WriteLine($"float 변수의 값 : {fData}");
            Console.WriteLine("double 변수의 값 : " + dData);
        }
    }
}
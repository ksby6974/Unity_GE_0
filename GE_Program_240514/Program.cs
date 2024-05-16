using System;
using System.Xml.Linq;

namespace GE_Program_240514
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region 변수의 이름 규칙
                // 1. 중복된 이름을 허용하지 않음
                // 2. 대소문자를 구분
                // 3. 예약어(이미 다른 곳에 사용된 이름)를 덮어쓸 수 없음
                // 4. 숫자로 시작할 수 없음
                // 5. 이름에 공백이 포함될 수 없음
                // 6. 변수의 이름으로 특수문자는 기본적으로 사용불가 (예외 "_")

                // 표기법
                // Camel    : 소문ㅏ로 시작하여 대문자로 핵심표기 - int countDown (변수)
                // Pascal   : 시작을 대문자로 - class Program (함수, 클래스)
                // Snake    : _를 넣어 표기함 - 
                #endregion

                #region 상수
                // 프로그램이 실행되는 동안 더 이상 변경할 수 없는 메모리 공간
                // 상수는 메모리 공간을 생성하는 동시에 초기화해야 하며
                // 한 번 저장된 값은 더 이상 변경할 수 없음

                // literal  : 메모리 공간을 가지고 있지 않은 상수 (숫자 등)
                // Symbolic : 메모리 공간을 가지는 상수 (const 고정값 상수)
                #endregion

                #region 연산자
                //
                #endregion

                int iData = 100;
                int iLiteral = 25;
                const int iSymbolic = 20;

                //변수 + 변수
                int result1 = iData + iData;

                // 변수 - 리터럴 상수
                int result2 = iData - iLiteral;

                // 리터럴 상수 * 심볼릭 상수
                int result3 = iLiteral * iSymbolic;

                // 변수 / 심볼릭 상수
                int result4 = iData / iSymbolic;

                // 리터럴 상수 % 리터럴 상수 
                int result5 = iLiteral % iLiteral;

                Console.WriteLine($"result1 값 : {iData} + {iData} = {result1}");
                Console.WriteLine($"result2 값 : {iData} - {iLiteral} = {result2}");
                Console.WriteLine($"result3 값 : {iLiteral} * {iSymbolic} = {result3}");
                Console.WriteLine($"result4 값 : {iData} / {iSymbolic} = {result4}");
                Console.WriteLine($"result5 값 : {iLiteral} % {iLiteral} = {result5}");
            }


            {
                #region 비트
                // 데이터를 나타내는 최소의 단위, 0 또는 1의 조합으로 논리 계산을 수행.
                // 메모리는 비트 단위로 데이터를 저장할 수 있으며
                // 1개의 비트에는 0 또는 1의 값만 저장할 수 있음

                // [2진수]
                // 10진수를 1이 될 때까지 계속 2로 나누고
                // 나눈 위치의 나머지 값을 아래에서 위로 순서대로 정렬

                // [16진수]
                // 1 byte에 2진수로 저장된 값을 2의 제곱으로 나타내며
                // 각각의 비트에 1이나 2의 제곱 위치를 계산한 다음 
                // 각각의 비트를 모두 더하여 10진수로 나타낸다.

                #endregion

                #region 비트 연산자
                // 비트 단위로 논리 연산을 수행하기 위해 사용하는 연산자
                // AND  : 두 피연산자 중 둘다 1이라면 1 반환
                // OR   : 두 피연산자 중 하나라도 1이라면 1 반환
                // XOR  : 두 피연산자 중 둘다 같다면 1 반환
                // NOT  : 피연산자 반전
                #endregion

                int aData = 15;
                int bData = 10;
                Console.WriteLine($"{aData} AND {bData} : {aData & bData}");
                Console.WriteLine($"{aData} OR {bData} : {aData | bData}");
                Console.WriteLine($"{aData} XOR {bData} : {aData ^ bData}");
                Console.WriteLine($"NOT : {~aData}, {~bData}");

                // 첫번째 비트는 부호를 나타내며, 첫번째 비트에 1이 있다면 음수가 된다.

                #region 시프트 연산자
                // 0과 1로 이루어진 2진수를 왼쪽 또는 오른쪽으로 원하는 자리만큼 이동하는 연산
                // >>, << 
                #endregion

                int iTemp = 10;

                Console.WriteLine($"iTemp 변수를 왼쪽으로 shift : {iTemp << 2}");
                Console.WriteLine($"iTemp 변수를 오른쪽으로 shift : {iTemp >> 2}");

                #region 실수 형태의 10진수를 2진수로 변환하는 방법
                // 10진수의 실수 부분을 1.0이 될 때까지 계속 2로 곱한 다음
                // 결과의 정수 부분을 위에서 아래로 순서대로 정렬합니다. 
                #endregion

                float fTemp = 3.14f;
                double dTemp = 1.592;
                Console.WriteLine($"fTemp 변수의 값 : {fTemp}");
                Console.WriteLine($"dTemp 변수의 값 : {dTemp}");

                // 4byte 크기의 실수형 자료형은 소수점 이하 6자리까지만 표기
                // 8byte 크기의 실수형 자료형은 소수점 이하 15자리까지만 표기
            }
        }
    }
}
using System;
using Xunit;
using  FibonacciCalculation;

namespace Fibonaci.UnitTest
{
    public class FibonacciUnitTest
    {
        [Fact]
        public void Given_0_Return_0()
        {
            //arrange
            Fibonacci fibo = new Fibonacci();
            int i = 0;
            //act
            int result = fibo.Fib(i);
            //assert
            Assert.Equal(result,0);
        }
        [Fact]
        public void Given_1_Return_1()
        {
            //arrange
            Fibonacci fibo = new Fibonacci();
            int i = 1;
            //act
            int result = fibo.Fib(i);
            //assert
            Assert.Equal(result,1);
        }

        [Fact]
public void Fib_Given2_Return1()
{
    //arrange
    Fibonacci fibo = new Fibonacci();
    int i = 2;
    //act
    int result = fibo.Fib(i);
    //assert
    Assert.Equal(1, result);
}

[Fact]
public void Fib_Given3_Return2()
{
    //arrange
    Fibonacci fibo = new Fibonacci();
    int i = 3;
    //act
    int result = fibo.Fib(i);
    //assert
    Assert.Equal(2, result);
}

[Fact]
public void Fib_Given4_Return3()
{
    //arrange
    Fibonacci fibo = new Fibonacci();
    int i = 4;
    //act
    int result = fibo.Fib(i);
    //assert
    Assert.Equal(3, result);
}
    }
}
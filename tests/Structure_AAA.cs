using Xunit;
using validNumbers;
using informations;

namespace xunit_train;

public class Structure_AAA
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var cpf = InformationGenerator.GerarCpf();

        //Act
        var result = NumbersValidator.validateCpf(cpf);
        //Assert
       Assert.True(result);
    }
}